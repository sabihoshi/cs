using Caliburn.Micro;

namespace MusicPlayer.Models
{
    public class PlaylistModel
    {
        public PlaylistModel(string filename, string name)
        {
            ImagePath = filename;
            Name = name;
        }

        public PlaylistModel()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public BindableCollection<TrackModel> Songs { get; set; }
    }
}