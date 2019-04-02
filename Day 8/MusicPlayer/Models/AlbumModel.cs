namespace MusicPlayer.Models
{
    public class AlbumModel
    {
        public AlbumModel(string filename, string name)
        {
            Source = filename;
            Name = name;
        }

        public string Name { get; set; }
        public string Source { get; set; }
    }
}