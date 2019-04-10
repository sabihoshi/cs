using System;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using NAudio.Wave;
using TagLib;
using WaveFormRendererLib;
using PathIO = System.IO.Path;

namespace MusicPlayer.Models
{
    public class TrackModel
    {
        private AudioFileReader _audioFileReader;
        private DirectSoundOut  _output;

        public TrackModel(string path, string name)
        {
            Name = name ?? PathIO.GetFileName(path);
            Path = path;
        }

        public TrackModel(string path) : this(path, File.Create(path).Tag.Title) { }

        public string Name { get; set; }
        public string Path { get; set; }

        public double GetLength => _audioFileReader?.TotalTime.TotalSeconds ?? 0;

        public string GetLengthInSeconds =>
            TimeSpan.FromSeconds(_audioFileReader?.TotalTime.TotalSeconds ?? 0).ToString(@"mm\:ss");

        public string GetPositionInSeconds =>
            TimeSpan.FromSeconds(_audioFileReader?.CurrentTime.TotalSeconds ?? 0).ToString(@"mm\:ss");

        public double GetPosition => _audioFileReader?.CurrentTime.TotalSeconds ?? 0;

        public bool IsReady => _output != null;

        public bool IsPlaying => _output?.PlaybackState == PlaybackState.Playing;

        public void Dispose()
        {
            if (_output != null)
            {
                if (_output.PlaybackState == PlaybackState.Playing) _output.Stop();

                _output.Dispose();
                _output = null;
            }

            if (_audioFileReader != null)
            {
                _audioFileReader.Dispose();
                _audioFileReader = null;
            }
        }

        public float GetVolume()
        {
            return _audioFileReader?.Volume ?? 1;
        }

        public void LoadTrack()
        {
            _ = RenderAudio(Path);

            _audioFileReader = new AudioFileReader(Path) {Volume = 1f};
            _output          = new DirectSoundOut(200);
            var wc = new WaveChannel32(_audioFileReader);
            wc.PadWithZeroes = false;
            _output.Init(wc);
        }

        public void Pause()
        {
            _output?.Pause();
        }

        public void Play()
        {
            _output?.Play();
        }

        public async Task RenderAudio(string fileName)
        {
            var maxPeakProvider      = new MaxPeakProvider();
            var rmsPeakProvider      = new RmsPeakProvider(200);      // e.g. 200
            var samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            var averagePeakProvider  = new AveragePeakProvider(4);    // e.g. 4

            var rendererSettings = new StandardWaveFormRendererSettings();
            rendererSettings.Width        = 1080;
            rendererSettings.TopHeight    = 64;
            rendererSettings.BottomHeight = 64;

            var renderer = new WaveFormRenderer();


            rendererSettings.BackgroundBrush.Clone();

            var image = await Task.Run(() => renderer.Render(fileName, averagePeakProvider, rendererSettings));
            image.Save($@"../{PathIO.GetFileNameWithoutExtension(fileName)}.png", ImageFormat.Png);
        }

        public void SetPosition(double value)
        {
            if (_audioFileReader != null) _audioFileReader.CurrentTime = TimeSpan.FromSeconds(value);
        }

        public void SetVolume(float value)
        {
            if (_output != null) _audioFileReader.Volume = value;
        }

        public void Stop()
        {
            _output?.Stop();
        }

        public void TogglePlayPause(double currentVolumeLevel)
        {
            if (_output != null)
            {
                if (_output.PlaybackState == PlaybackState.Playing)
                    Pause();
                else
                    Play();
            }
            else
            {
                Play();
            }
        }
    }
}