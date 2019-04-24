using Caliburn.Micro;

namespace MusicPlayer.Models
{
    public static class ExtensionMethods
    {
        public static void AddSong(this PlaylistModel playlist, params string[] paths)
        {
            foreach (var path in paths)
            {
                if (TrackModel.IsValid(path))
                {
                    playlist.Songs.Add(new TrackModel(path));
                }
            }
        }
    }

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
        public BindableCollection<TrackModel> Songs { get; set; } = new BindableCollection<TrackModel>();
    }
}