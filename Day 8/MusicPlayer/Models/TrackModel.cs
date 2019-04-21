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
        private TrackModel(string path, string title)
        {
            Title = title ?? PathIO.GetFileName(path);
            Path = path;
        }

        public TrackModel()
        {
        }

        public TrackModel(string path) : this(path, File.Create(path).Tag.Title)
        {
        }

        public TimeSpan Length => File.Create(Path).Properties.Duration;
        public string Name => $"{Title} ({Length:mm\\:ss})";
        public string Title { get; set; }
        public string Path { get; set; }
        public double GetLength => AudioFileReader?.TotalTime.TotalSeconds ?? 0;
        public PlaybackState PlaybackState => Output?.PlaybackState ?? PlaybackState.Stopped;

        public string GetLengthInSeconds =>
            TimeSpan.FromSeconds(AudioFileReader?.TotalTime.TotalSeconds ?? 0).ToString(@"mm\:ss");

        public string GetPositionInSeconds =>
            TimeSpan.FromSeconds(AudioFileReader?.CurrentTime.TotalSeconds ?? 0).ToString(@"mm\:ss");

        public double GetPosition => AudioFileReader?.CurrentTime.TotalSeconds ?? 0;
        public bool IsReady => Output != null;
        public bool IsPlaying => Output?.PlaybackState == PlaybackState.Playing;

        public AudioFileReader AudioFileReader { get; set; }

        public DirectSoundOut Output { get; set; }

        public void Dispose()
        {
            if (Output != null)
            {
                if (Output.PlaybackState == PlaybackState.Playing) Output.Stop();
                Output.Dispose();
                Output = null;
            }

            if (AudioFileReader != null)
            {
                AudioFileReader.Dispose();
                AudioFileReader = null;
            }
        }

        public float GetVolume()
        {
            return AudioFileReader?.Volume ?? 1;
        }

        public void LoadTrack()
        {
            _ = RenderAudioAsync(Path);
            AudioFileReader = new AudioFileReader(Path) { Volume = 1f };
            Output = new DirectSoundOut(200);
            var wc = new WaveChannel32(AudioFileReader) { PadWithZeroes = false };
            Output.Init(wc);
        }

        public void Pause()
        {
            Output?.Pause();
        }

        public void Play()
        {
            Output?.Play();
        }

        private static async Task RenderAudioAsync(string fileName)
        {
            var averagePeakProvider = new AveragePeakProvider(4);
            var rendererSettings = new StandardWaveFormRendererSettings
            {
                Width = 1080,
                TopHeight = 64,
                BottomHeight = 64
            };
            var renderer = new WaveFormRenderer();
            var image = await Task.Run(() => renderer.Render(fileName, averagePeakProvider, rendererSettings))
                                  .ConfigureAwait(false);
            image.Save($@"../{PathIO.GetFileNameWithoutExtension(fileName)}.png", ImageFormat.Png);
        }

        public void SetPosition(double value)
        {
            if (AudioFileReader != null) AudioFileReader.CurrentTime = TimeSpan.FromSeconds(value);
        }

        public void SetVolume(float value)
        {
            if (AudioFileReader != null) AudioFileReader.Volume = value;
        }

        public void Stop()
        {
            Output?.Stop();
        }

        public void TogglePlayPause()
        {
            if (Output != null)
            {
                if (Output.PlaybackState == PlaybackState.Playing) Pause();
                else Play();
            }
            else
            {
                Play();
            }
        }
    }
}