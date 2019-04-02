using Caliburn.Micro;
using Microsoft.Win32;
using NAudio.Wave;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using WaveFormRendererLib;

namespace MusicPlayer.Models
{
    public class TrackModel : Screen
    {
        private AudioFileReader _audioFileReader;

        private DirectSoundOut _output;

        public AudioFileReader AudioFileReader
        {
            get { return _audioFileReader; }
            set
            {
                _audioFileReader = value;
                NotifyOfPropertyChange(() => AudioFileReader);
            }
        }

        public DirectSoundOut Output
        {
            get { return _output; }
            set
            {
                _output = value;
                NotifyOfPropertyChange(() => Output);
            }
        }

        public void LoadTrack()
        {
            string fileName = "";
            var openFileDialog1 = new OpenFileDialog();
            try
            {
                if (openFileDialog1.ShowDialog() != null)
                {
                    fileName = openFileDialog1.FileName;
                }
            }
            catch (ArgumentNullException)
            {
            }

            MaxPeakProvider maxPeakProvider = new MaxPeakProvider();
            RmsPeakProvider rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            SamplingPeakProvider samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            AveragePeakProvider averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

            StandardWaveFormRendererSettings myRendererSettings = new StandardWaveFormRendererSettings();
            myRendererSettings.Width = 1080;
            myRendererSettings.TopHeight = 64;
            myRendererSettings.BottomHeight = 64;

            myRendererSettings.BackgroundImage = new Bitmap(@"C:\Users\ciit\Pictures\Konachan.com - 218504 arima_kousei a-shacho blonde_hair dark glasses instrument male miyazono_kaori piano shigatsu_wa_kimi_no_uso tree violin.jpg");

            WaveFormRenderer renderer = new WaveFormRenderer();
            var image = renderer.Render(fileName, averagePeakProvider, myRendererSettings);

            image.Save(@"../render.png", ImageFormat.Png);

            _audioFileReader = new AudioFileReader(fileName) { Volume = 100f };
            _output = new DirectSoundOut(200);
            _output.PlaybackStopped += _output_PlaybackStopped;
            var reader = new Mp3FileReader(fileName);
            _output.Init(reader);
        }

        public void Play()
        {
            if (_output != null)
                _output.Play();
            NotifyOfPropertyChange(() => _output.PlaybackState);
        }

        private void _output_PlaybackStopped(object sender, StoppedEventArgs e)
        {
        }
    }
}