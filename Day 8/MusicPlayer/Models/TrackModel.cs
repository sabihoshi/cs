using System;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using Microsoft.Win32;
using MusicPlayer.NAudioWrapper;
using NAudio.Wave;
using WaveFormRendererLib;

namespace MusicPlayer.Models
{
    public class TrackModel
    {
        private AudioFileReader _audioFileReader;
        private DirectSoundOut _output;


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

        public double GetLengthInSeconds()
        {
            if (_audioFileReader != null)
                return _audioFileReader.TotalTime.TotalSeconds;
            return 0;
        }

        public double GetPositionInSeconds()
        {
            return _audioFileReader?.CurrentTime.TotalSeconds ?? 0;
        }

        public float GetVolume()
        {
            if (_audioFileReader != null) return _audioFileReader.Volume;

            return 1;
        }
        public void OpenTrack()
        {
            var fileName = "";
            var openFileDialog1 = new OpenFileDialog();
            try
            {
                if (openFileDialog1.ShowDialog() != null) fileName = openFileDialog1.FileName;
            }
            catch (ArgumentNullException)
            {
                return;
            }

            _audioFileReader = new AudioFileReader(fileName) { Volume = 1f };
            _output = new DirectSoundOut(200);
            var wc = new WaveChannel32(_audioFileReader);
            wc.PadWithZeroes = false;
            _output.Init(wc);

            _ = RenderAudio(fileName);
        }

        public bool IsPlaying()
        {
            return _output?.PlaybackState == PlaybackState.Playing;
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
            var maxPeakProvider = new MaxPeakProvider();
            var rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            var samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            var averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

            var rendererSettings = new StandardWaveFormRendererSettings();
            rendererSettings.Width = 1080;
            rendererSettings.TopHeight = 64;
            rendererSettings.BottomHeight = 64;

            // rendererSettings.BackgroundImage = new Bitmap(@"C:\Users\ciit\Pictures\Konachan.com - 218504 arima_kousei a-shacho blonde_hair dark glasses instrument male miyazono_kaori piano shigatsu_wa_kimi_no_uso tree violin.jpg");

            var renderer = new WaveFormRenderer();
            var image = await Task.Run(() => renderer.Render(fileName, averagePeakProvider, rendererSettings));

            image.Save(@"../render.png", ImageFormat.Png);
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