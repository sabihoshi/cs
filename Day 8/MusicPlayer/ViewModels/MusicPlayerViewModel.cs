using Caliburn.Micro;
using MusicPlayer.Models;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel : Screen
    {
        private BindableCollection<AlbumModel> _images = new BindableCollection<AlbumModel>();
        private AlbumModel _selectedAlbumModel;
        private TrackModel _track = new TrackModel();

        public MusicPlayerViewModel()
        {
            var albumPath =
                @"C:\Users\ciit\source\repos\Conversion_Types\Conversion Types\Day 8\MVVMTest\Images\Albums";
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_1.png", "Album 1"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_2.png", "Album 2"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_3.png", "Album 3"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_4.png", "Album 4"));
            Images.Add(new AlbumModel($@"{albumPath}\daily_mix_5.png", "Album 5"));
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

        public void OpenTrack()
        {
            _track.LoadTrack();
        }

        public void PlayTrack()
        {
            _track.Play();
        }
    }
}