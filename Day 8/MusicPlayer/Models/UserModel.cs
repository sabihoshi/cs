using System.Collections.Generic;
using Caliburn.Micro;

namespace MusicPlayer.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public BindableCollection<PlaylistModel> Playlists { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}