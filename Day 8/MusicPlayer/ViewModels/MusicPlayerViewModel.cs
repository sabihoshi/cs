using System;
using System.Threading.Tasks;
using Caliburn.Micro;
using Microsoft.Win32;
using MusicPlayer.Models;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel : Screen
    {
        private double        _currentPosition;
        private float         _currentVolume = 1f;
        private PlaybackState _playbackState;

        private string                            _playContent;
        private BindableCollection<PlaylistModel> _playlist = new BindableCollection<PlaylistModel>();
        private PlaylistModel                     _selectedPlaylist;
        private TrackModel                        _selectedTrack;

        private double _trackLength;

        public MusicPlayerViewModel()
        {
            PlayContent = "Play";
            var albumPath =
                @"..\..\Images\Albums";
            Playlist.Add(new PlaylistModel($@"{albumPath}\daily_mix_1.png", "Album 1")
            {
                Songs = new BindableCollection<TrackModel>
                {
                    new TrackModel(@"D:\Osu!\[AMV]ONEWAYS - The Boy Who Murdered Love.mp3")
                }
            });
            Playlist.Add(new PlaylistModel($@"{albumPath}\daily_mix_2.png", "Album 2"));
            Playlist.Add(new PlaylistModel($@"{albumPath}\daily_mix_3.png", "Album 3"));
            Playlist.Add(new PlaylistModel($@"{albumPath}\daily_mix_4.png", "Album 4"));
            Playlist.Add(new PlaylistModel($@"{albumPath}\daily_mix_5.png", "Album 5"));
        }

        public BindableCollection<TrackModel> Tracks { get; set; }

        public double CurrentPosition
        {
            get => _currentPosition;
            set
            {
                if (value.Equals(_currentPosition)) return;
                _currentPosition = value;
                _selectedTrack.SetPosition(CurrentPosition);
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
        public string TrackLengthSeconds     => SelectedTrack?.GetLengthInSeconds;

        public float CurrentVolume
        {
            get => _currentVolume;
            set
            {
                if (_currentVolume.Equals(value)) return;
                _currentVolume = value;
                _selectedTrack.SetVolume(CurrentVolume);
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
                _selectedTrack?.Dispose();
                _selectedTrack = value;
                if (_selectedTrack == null)
                    return;
                _selectedTrack.LoadTrack();
                if (SelectedTrack.IsReady)
                {
                    TrackLength = SelectedTrack.GetLength;
                    NotifyOfPropertyChange(() => CanPlayTrack);
                    SelectedTrack.TogglePlayPause(CurrentVolume);
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

        public void MaximizeVolume()
        {
            CurrentVolume = 1f;

            NotifyOfPropertyChange(() => CurrentVolume);
            NotifyOfPropertyChange(() => SelectedTrack);
        }

        public void OpenTrack()
        {
            if (_selectedTrack?.IsPlaying ?? false) _selectedTrack.Dispose();

            var fileDialog = new OpenFileDialog();
            try
            {
                if (fileDialog.ShowDialog() != null)
                    SelectedTrack = new TrackModel(fileDialog.FileName);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void PlayTrack()
        {
            _selectedTrack.TogglePlayPause(CurrentVolume);
            PlayContent = _selectedTrack.IsPlaying ? "Pause" : "Play";
            Task.Run(UpdateAudio);
        }

        private async Task UpdateAudio()
        {
            while (_playbackState == PlaybackState.Playing)
            {
                CurrentPosition = _selectedTrack.GetPosition;
                await Task.Delay(500);
            }
        }

        private enum PlaybackState
        {
            Playing,
            Stopped,
            Paused
        }
    }
}