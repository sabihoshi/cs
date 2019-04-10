using System;
using System.Threading.Tasks;
using Caliburn.Micro;
using Microsoft.Win32;
using MusicPlayer.Models;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel : Screen
    {
        private double                            _currentPosition;
        private float                             _currentVolume = 1f;
        private PlaybackState                     _playbackState;
        private string                            _playContent;
        private BindableCollection<PlaylistModel> _playlist = new BindableCollection<PlaylistModel>();
        private PlaylistModel                     _selectedPlaylist;
        private TrackModel                        _selectedTrack;
        private double                            _trackLength;

        public MusicPlayerViewModel()
        {
            PlayContent = "Play";
            var albumPath = @"..\..\Images\Albums";
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
            get => CurrentPosition1;
            set
            {
                if (value.Equals(CurrentPosition1)) return;
                CurrentPosition1 = value;
                SelectedTrack1.SetPosition(CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPositionSeconds);
            }
        }

        public double TrackLength
        {
            get => TrackLength1;
            set
            {
                TrackLength1 = value;
                NotifyOfPropertyChange(() => TrackLength);
                NotifyOfPropertyChange(() => TrackLengthSeconds);
            }
        }

        public string CurrentPositionSeconds => SelectedTrack?.GetPositionInSeconds;
        public string TrackLengthSeconds     => SelectedTrack?.GetLengthInSeconds;

        public float CurrentVolume
        {
            get => CurrentVolume1;
            set
            {
                if (CurrentVolume1.Equals(value)) return;
                CurrentVolume1 = value;
                SelectedTrack1.SetVolume(CurrentVolume);
            }
        }

        public BindableCollection<PlaylistModel> Playlist
        {
            get => Playlist1;
            set
            {
                Playlist1 = value;
                NotifyOfPropertyChange(() => Playlist);
            }
        }

        public PlaylistModel SelectedPlaylist
        {
            get => SelectedPlaylist1;
            set
            {
                SelectedPlaylist1 = value;
                NotifyOfPropertyChange(() => SelectedPlaylist);
            }
        }

        public TrackModel SelectedTrack
        {
            get => SelectedTrack1;
            set
            {
                SelectedTrack1?.Dispose();
                SelectedTrack1 = value;
                if (SelectedTrack1 == null) return;
                SelectedTrack1.LoadTrack();
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
            get => PlayContent1;
            set
            {
                PlayContent1 = value;
                NotifyOfPropertyChange(PlayContent);
            }
        }

        public bool CanPlayTrack => SelectedTrack?.IsReady ?? false;

        public double CurrentPosition1
        {
            get => _currentPosition;
            set => _currentPosition = value;
        }

        public float CurrentVolume1
        {
            get => _currentVolume;
            set => _currentVolume = value;
        }

        public string PlayContent1
        {
            get => _playContent;
            set => _playContent = value;
        }

        public BindableCollection<PlaylistModel> Playlist1
        {
            get => _playlist;
            set => _playlist = value;
        }

        public PlaylistModel SelectedPlaylist1
        {
            get => _selectedPlaylist;
            set => _selectedPlaylist = value;
        }

        public TrackModel SelectedTrack1
        {
            get => _selectedTrack;
            set => _selectedTrack = value;
        }

        public double TrackLength1
        {
            get => _trackLength;
            set => _trackLength = value;
        }

        private PlaybackState PlaybackState1
        {
            get => _playbackState;
            set => _playbackState = value;
        }

        public void MaximizeVolume()
        {
            CurrentVolume = 1f;
            NotifyOfPropertyChange(() => CurrentVolume);
            NotifyOfPropertyChange(() => SelectedTrack);
        }

        public void OpenTrack()
        {
            if (SelectedTrack1?.IsPlaying ?? false) SelectedTrack1.Dispose();
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
            SelectedTrack1.TogglePlayPause();
            PlayContent = SelectedTrack1.IsPlaying ? "Pause" : "Play";
            Task.Run(UpdateAudio);
        }

        private async Task UpdateAudio()
        {
            while (PlaybackState1 == PlaybackState.Playing)
            {
                CurrentPosition = SelectedTrack1.GetPosition;
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