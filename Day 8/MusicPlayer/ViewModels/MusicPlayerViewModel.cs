using System;
using System.Threading.Tasks;
using Caliburn.Micro;
using MusicPlayer.Models;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel : Screen
    {
        private double _currentPosition;
        private float _currentVolume = 1f;
        private BindableCollection<AlbumModel> _images = new BindableCollection<AlbumModel>();
        private PlaybackState _playbackState;
        private AlbumModel _selectedAlbumModel;
        private TrackModel _track = new TrackModel();

        public MusicPlayerViewModel()
        {
            var albumPath =
                @"..\..\Images\Albums";
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_1.png", "Album 1"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_2.png", "Album 2"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_3.png", "Album 3"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_4.png", "Album 4"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_5.png", "Album 5"));
        }

        public double CurrentPosition
        {
            get => _currentPosition;
            set
            {
                if (value.Equals(_currentPosition)) return;
                _currentPosition = value;
                _track.SetPosition(CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPositionSeconds);
            }
        }

        public string CurrentPositionSeconds => TimeSpan.FromSeconds(CurrentPosition).ToString(@"mm\:ss");
        public string TrackLengthSeconds => TimeSpan.FromSeconds(TrackLength).ToString(@"mm\:ss");

        public float CurrentVolume
        {
            get => _currentVolume;
            set
            {
                if (_currentVolume.Equals(value)) return;
                _currentVolume = value;
                _track?.SetVolume(CurrentVolume);
            }
        }

        public BindableCollection<AlbumModel> Images
        {
            get => _images;
            set
            {
                _images = value;
                NotifyOfPropertyChange(() => Images);
            }
        }

        public AlbumModel SelectedAlbumModel
        {
            get => _selectedAlbumModel;
            set
            {
                _selectedAlbumModel = value;
                NotifyOfPropertyChange(() => SelectedAlbumModel);
            }
        }

        public TrackModel Track
        {
            get => _track;
            set
            {
                _track = value;
                NotifyOfPropertyChange(() => Track);
            }
        }

        public double TrackLength => _track.GetLengthInSeconds();

        public bool CanChangeVolumeSlider(TrackModel track)
        {
            return _track != null;
        }

        public void MaximizeVolume()
        {
            CurrentVolume = 1f;

            NotifyOfPropertyChange(() => CurrentVolume);
        }

        public void OpenTrack()
        {
            _track?.OpenTrack();
            if (_track != null)
            {
                NotifyOfPropertyChange(() => Track);
                NotifyOfPropertyChange(() => CurrentVolume);
                NotifyOfPropertyChange(() => TrackLength);
                NotifyOfPropertyChange(() => TrackLengthSeconds);
            }
        }

        public void PlayAudio()
        {
            _track?.OpenTrack();
        }

        public void PlayTrack()
        {
            _track?.TogglePlayPause(CurrentVolume);
            Task.Run(UpdateAudio);
        }

        private async Task UpdateAudio()
        {
            while (_playbackState == PlaybackState.Playing)
            {
                CurrentPosition = _track.GetPositionInSeconds();
                NotifyOfPropertyChange(() => CurrentPositionSeconds);
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