using System.Collections.Generic;
using VChan.ViewModels;

namespace VChan.Models
{
    public static class PlaylistExtensions
    {
        public static void AddSong(this PlaylistModel playlist, string path, string title)
        {
            playlist.Songs.Add(new AudioViewModel(path, title));
        }

        public static void AddSong(this PlaylistModel playlist, string path)
        {
            playlist.Songs.Add(new AudioViewModel(path));
        }
    }
    public class PlaylistModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public List<AudioViewModel> Songs { get; } = new List<AudioViewModel>();


    }
}
