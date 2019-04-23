using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliburn.Micro;
using LiteDB;
using Microsoft.Win32;
using MusicPlayer.Models;
using NAudio.Wave;
using System.Windows;
using MusicPlayer.Views;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel : Screen
    {
        private double _currentPosition;
        private float _currentVolume = 1f;
        private string _playContent;
        private BindableCollection<PlaylistModel> _playlist = new BindableCollection<PlaylistModel>();
        private PlaylistModel _selectedPlaylist;
        private TrackModel _selectedTrack;
        private double _trackLength;

        public MusicPlayerViewModel()
        {
            PlayContent = "Play";

            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var play = db.GetCollection<PlaylistModel>("Playlists");
                var collection = new BindableCollection<PlaylistModel>(play.FindAll());
                Playlist = collection;
            }

            var window = new AccountLoginView();
            window.Show();
        }

        public BindableCollection<TrackModel> Tracks { get; set; }

        public double CurrentPosition
        {
            get => _currentPosition;
            set
            {
                if (value.Equals(_currentPosition)) return;
                _currentPosition = value;
                SelectedTrack.SetPosition(CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPositionSeconds);
            }
        }

        public double TrackLength
        {
            get => _trackLength;
            set
            {
                _trackLength = value;
                NotifyOfPropertyChange(() => TrackLength);
                NotifyOfPropertyChange(() => TrackLengthSeconds);
            }
        }

        public string CurrentPositionSeconds => SelectedTrack?.GetPositionInSeconds;
        public string TrackLengthSeconds => SelectedTrack?.GetLengthInSeconds;

        public float CurrentVolume
        {
            get => _currentVolume;
            set
            {
                if (_currentVolume.Equals(value)) return;
                _currentVolume = value;
                SelectedTrack?.SetVolume(CurrentVolume);
            }
        }

        public BindableCollection<PlaylistModel> Playlist
        {
            get => _playlist;
            set
            {
                _playlist = value;
                NotifyOfPropertyChange(() => Playlist);
            }
        }

        public PlaylistModel SelectedPlaylist
        {
            get => _selectedPlaylist;
            set
            {
                _selectedPlaylist = value;
                NotifyOfPropertyChange(() => SelectedPlaylist);
            }
        }

        public TrackModel SelectedTrack
        {
            get => _selectedTrack;
            set
            {
                if (_selectedTrack?.Equals(value) ?? false) return;
                _selectedTrack?.Dispose();
                _selectedTrack = value;
                _selectedTrack.LoadTrack();
                if (SelectedTrack.IsReady)
                {
                    TrackLength = SelectedTrack.GetLength;
                    NotifyOfPropertyChange(() => CanPlayTrack);
                    SelectedTrack.TogglePlayPause();
                    _ = UpdateAudio();
                }
            }
        }

        public string PlayContent
        {
            get => _playContent;
            set
            {
                _playContent = value;
                NotifyOfPropertyChange(PlayContent);
            }
        }

        public bool CanPlayTrack => SelectedTrack?.IsReady ?? false;

        public void CreatePlaylist()
        {
            Console.WriteLine(@"It worked");
        }

        public void AddSong(MusicPlayerViewModel source)
        {
            Console.WriteLine($@"Added song to {source.SelectedPlaylist}");
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void MaximizeVolume()
        {
            CurrentVolume = 1f;
            NotifyOfPropertyChange(() => CurrentVolume);
            NotifyOfPropertyChange(() => SelectedTrack);
        }

        public void OpenTrack()
        {
            if (SelectedTrack?.IsPlaying ?? false) SelectedTrack.Dispose();
            var fileDialog = new OpenFileDialog();
            try
            {
                if (fileDialog.ShowDialog() != null) SelectedTrack = new TrackModel(fileDialog.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void PlayTrack()
        {
            SelectedTrack.TogglePlayPause();
            PlayContent = SelectedTrack.IsPlaying ? "Pause" : "Play";
            Task.Run(UpdateAudio);
        }

        private async Task UpdateAudio()
        {
            while (SelectedTrack.PlaybackState == PlaybackState.Playing)
            {
                CurrentPosition = SelectedTrack.GetPosition;
                await Task.Delay(500);
            }
        }
    }
}