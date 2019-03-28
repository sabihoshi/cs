using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using NAudio.Wave;
using WaveFormRendererLib;
using CTJam.ViewModels;
using System.Linq;

namespace CTJam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WaveOut waveOut;

        private Image draggedImage;

        private System.Drawing.Point initialPosition;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            AudioModel.SelectAudio();
        }

        private void ToggleStateButton(object sender, RoutedEventArgs e)
        {
            if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();
                PlayerStatus.Content = "Play";
            }
            else
            {
                waveOut.Play();
                PlayerStatus.Content = "Pause";
            }
        }

        private void WaveOut_OnPlaybackStopped(object sender, EventArgs e)
        {
            PlayerStatus.Content = "Play";
            var myObject = new List<A>();
            myObject.Find
        }
    }

    public class A
    {
        public string Name { get; set; }
    }
}