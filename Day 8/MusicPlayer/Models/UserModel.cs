using Caliburn.Micro;
using JetBrains.Annotations;

namespace MusicPlayer.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public BindableCollection<PlaylistModel> Playlists { get; set; } = new BindableCollection<PlaylistModel>();
        [NotNull] public string Username { get; set; }
        [NotNull] public string Password { get; set; }
    }
}