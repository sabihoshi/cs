﻿using System.Collections.Generic;

namespace MusicPlayer.Models
{
    internal class UserModel
    {
        public int Id { get; set; }
        public List<PlaylistModel> Playlists { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}