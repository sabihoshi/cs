using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliburn.Micro;
using LiteDB;
using Microsoft.Win32;
using MusicPlayer.Models;
using NAudio.Wave;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel : Screen
    {
        private readonly IWindowManager manager = new WindowManager();
        private double _currentPosition;
        private float _currentVolume = 1f;
        private string _playContent;
        private BindableCollection<PlaylistModel> _playlist = new BindableCollection<PlaylistModel>();
        private PlaylistModel _selectedPlaylist;
        private TrackModel _selectedTrack;
        private double _trackLength;

        public MusicPlayerViewModel(string username)
        {
            PlayContent = "Play";

            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var users = db.GetCollection<UserModel>("Users");
                Playlist = new BindableCollection<PlaylistModel>(
                    users.Find(x => x.Username == username).SelectMany(x => x.Playlists)
                );
            }
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
                if ((SelectedTrack?.Equals(value) ?? false) || value is null) return;
                SelectedTrack?.Dispose();
                _selectedTrack = value;
                SelectedTrack?.LoadTrack();
                if (SelectedTrack?.IsReady ?? false)
                {
                    TrackLength = SelectedTrack.GetLength;
                    NotifyOfPropertyChange(() => CanPlayTrack);
                    SelectedTrack.TogglePlayPause();
                    _ = UpdateAudioAsync();
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
            var fileDialog = new OpenFileDialog
            {
                Multiselect = true
            };
            fileDialog.ShowDialog();
            foreach (var file in fileDialog.FileNames)
                if (TrackModel.IsValid(file))
                    Console.WriteLine(file);
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
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
            NotifyOfPropertyChange(() => PlayContent);
            Task.Run(UpdateAudioAsync);
        }

        private async Task UpdateAudioAsync()
        {
            while (SelectedTrack.PlaybackState == PlaybackState.Playing)
            {
                CurrentPosition = SelectedTrack.GetPosition;
                await Task.Delay(500).ConfigureAwait(false);
            }
        }
    }
}