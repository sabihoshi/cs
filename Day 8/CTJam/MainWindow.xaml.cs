using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using NAudio.Wave;
using WaveFormRendererLib;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;

namespace CTJam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WaveOut waveOut;

        private Image draggedImage;

        private string fileName = null;

        private Point initialPosition;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            try
            {
                fileName = openFileDialog1.FileName;
            }
            catch (ArgumentNullException)
            {
                return;
            }

            // 1. Configure Providers
            MaxPeakProvider maxPeakProvider = new MaxPeakProvider();
            RmsPeakProvider rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            SamplingPeakProvider samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            AveragePeakProvider averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

            // 2. Configure the style of the audio wave image
            StandardWaveFormRendererSettings myRendererSettings = new StandardWaveFormRendererSettings();
            myRendererSettings.Width = 1080;
            myRendererSettings.TopHeight = 64;
            myRendererSettings.BottomHeight = 64;

            myRendererSettings.BackgroundImage = new Bitmap(@"C:\Users\ciit\Pictures\Konachan.com - 218504 arima_kousei a-shacho blonde_hair dark glasses instrument male miyazono_kaori piano shigatsu_wa_kimi_no_uso tree violin.jpg");

            // 3. Define the audio file from which the audio wave will be created and define the providers and settings
            WaveFormRenderer renderer = new WaveFormRenderer();
            Image image = renderer.Render(fileName, averagePeakProvider, myRendererSettings);

            // 4. Store the image
            image.Save(@"../render.png", ImageFormat.Png);
            MusicImage.Image = image;
            // Or jpeg, however PNG is recommended if your audio wave needs transparency
            // image.Save(@"C:\Users\sdkca\Desktop\myfile.jpg", ImageFormat.Jpeg);

            waveOut = new WaveOut();
            waveOut.PlaybackStopped += WaveOut_OnPlaybackStopped;
            var reader = new Mp3FileReader(fileName);
            waveOut.Init(reader);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void WaveOut_OnPlaybackStopped(object sender, EventArgs e)
        {
            StateButton.Text = "Play";
        }
    }
}