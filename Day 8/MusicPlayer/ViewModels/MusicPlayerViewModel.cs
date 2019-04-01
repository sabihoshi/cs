using MusicPlayer.Models;
using Caliburn.Micro;
using MusicPlayer.NAudioWrapper;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel
    {
        private string _title;
        private double _currentTrackLenght;
        private double _currentTrackPosition;
        private string _playPauseImageSource;
        private float _currentVolume;

        private BindableCollection<TrackModel> _playlist;
        private TrackModel _currentlyPlayingTrack;
        private TrackModel _currentlySelectedTrack;
        private AudioPlayer _audioPlayer;
    }
}