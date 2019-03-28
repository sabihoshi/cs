using NAudio.Wave;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WaveFormRendererLib;

namespace CJam
{
    public partial class Form1 : Form
    {
        public WaveOut waveOut;

        private Image draggedImage;

        private string fileName = null;

        private Point initialPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
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

            myRendererSettings.BackgroundImage = new Bitmap(@"C:\Users\Kao\Pictures\Background\73109534_p6_master1200.jpg");

            // 3. Define the audio file from which the audio wave will be created and define the providers and settings
            WaveFormRenderer renderer = new WaveFormRenderer();
            Image image = renderer.Render(fileName, averagePeakProvider, myRendererSettings);

            // 4. Store the image
            image.Save(@"../render.png", ImageFormat.Png);
            pictureBox1.Image = image;
            // Or jpeg, however PNG is recommended if your audio wave needs transparency
            // image.Save(@"C:\Users\sdkca\Desktop\myfile.jpg", ImageFormat.Jpeg);

            waveOut = new WaveOut();
            waveOut.PlaybackStopped += WaveOut_OnPlaybackStopped;
            var reader = new Mp3FileReader(fileName);
            waveOut.Init(reader);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (waveOut.PlaybackState == PlaybackState.Paused || waveOut.PlaybackState == PlaybackState.Stopped)
            {
                waveOut.Play();
                button2.Text = "Pause";
            }
            else
            {
                waveOut.Pause();
                button2.Text = "Play";
            }
        }

        private void ImageMouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox)
            {
                var img = sender as PictureBox;
                var image = img.Image;
                initialPosition = e.Location;
                draggedImage = image;
            }
        }

        private void ImageMouseMove(object sender, MouseEventArgs e)
        {
            if (draggedImage != null)
            {
                var mousePosition = e.Location;
                var offset = mousePosition.X - initialPosition.X;
                initialPosition = mousePosition;
                pictureBox1.Location = new Point(pictureBox1.Location.X + offset, pictureBox1.Location.Y);
            }
        }

        private void ImageMouseUp(object sender, MouseEventArgs e)
        {
            if (draggedImage != null)
            {
                Capture = false;
                draggedImage = null;
            }
        }

        private void WaveOut_OnPlaybackStopped(object sender, EventArgs e)
        {
            button2.Text = "Play";
        }
    }
}