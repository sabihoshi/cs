using System;
using System.Collections.Generic;
using System.IO;
using Caliburn.Micro;

namespace MusicPlayer.Models
{
    public static class ExtensionMethods
    {
        public static void AddSong(this PlaylistModel playlist, params string[] paths)
        {
            foreach (var path in paths)
                if (TrackModel.IsValid(path))
                    playlist.Songs.Add(new TrackModel(path));
        }

        public static void AddSong<T>(this PlaylistModel playlist, IEnumerable<T> paths)
        {
            foreach (var path in paths)
                if (TrackModel.IsValid(path as string))
                    playlist.Songs.Add(new TrackModel(path as string));
        }
    }

    public class PlaylistModel : Screen
    {
        private string _imagePath;

        public PlaylistModel(string filename, string name)
        {
            ImagePath = filename;
            Name = name;
        }

        public PlaylistModel() { }

        public int Id { get; set; }
        public string Name { get; set; }

        public string ImagePath
        {
            get => File.Exists(_imagePath)
                ? _imagePath
                : Path.GetFullPath(
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Kao/Resources/placeholder.jpg")
            ;
            set
            {
                _imagePath = value;
                NotifyOfPropertyChange(() => ImagePath);
            }
        }

        public BindableCollection<TrackModel> Songs { get; set; } = new BindableCollection<TrackModel>();
    }
}