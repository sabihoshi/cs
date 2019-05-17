using Caliburn.Micro;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using VChan.Models;

namespace VChan.ViewModels
{
    public class PlayerViewModel : Screen
    {
        public PlayerViewModel()
        {
            Playlists = new BindableCollection<PlaylistModel>();
            var newPlaylist = new PlaylistModel
            {
                Image = @"C:\Users\Kao\Pictures\Avatars\1549918098893.jpg"
            };
            newPlaylist.AddSong(@"D:\Osu!\P-Light - YELLOW SPLASH!!.mp3");
            newPlaylist.AddSong(@"D:\Osu!\Shinshuu Plains.mp3");
            newPlaylist.AddSong(@"D:\Osu!\Pedal Heart.mp3");
            Playlists.Add(newPlaylist);
        }

        public PlaylistModel SelectedPlaylist { get; set; }
        private AudioFileReader AudioFileReader { get; set; }
        private DirectSoundOut Output { get; set; }
        public BindableCollection<PlaylistModel> Playlists { get; set; }
        public AudioModel SelectedAudio { get; set; }
        public float Volume { get; set; }
        public TimeSpan ElapsedSecondsString =>
            TimeSpan.FromSeconds(AudioFileReader?.CurrentTime.Seconds ?? 0);
        public TimeSpan TotalSecondsString =>
            TimeSpan.FromSeconds(AudioFileReader?.TotalTime.Seconds ?? 0);


        public void LoadAudio()
        {
            try
            {
                AudioFileReader = new AudioFileReader(SelectedAudio.Path) { Volume = Volume };
                Output = new DirectSoundOut();
                var wc = new WaveChannel32(AudioFileReader) {PadWithZeroes = false};
                Output.Init(wc);
            }
            catch (Exception)
            {
                //ignored
            }
        }

        public void ChangeAudio()
        {
            StopAudio();
            PlayAudio();
        }

        public void StopAudio()
        {
            if (Output != null)
            {
                if (Output.PlaybackState == PlaybackState.Playing)
                    Output.Stop();
                Output.Dispose();
                Output = null;
            }
            if (AudioFileReader != null)
            {
                AudioFileReader.Dispose();
                AudioFileReader = null;
            }
        }

        public void PlayAudio()
        {
            if (Output == null && AudioFileReader == null)
                LoadAudio();
        }
    }
}