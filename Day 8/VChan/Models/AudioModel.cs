using System;
using LiteDB;
using Tag = TagLib;
using PathIO = System.IO.Path;

namespace VChan.Models
{
    public class AudioModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        [BsonIgnore] public TimeSpan Length => TrackExists ? Tag.File.Create(Path).Properties.Duration : new TimeSpan();
        [BsonIgnore] private bool TrackExists => System.IO.File.Exists(Path);
        public AudioModel(string path) : this(path, Tag.File.Create(path).Tag.Title)
        {
        }

        public AudioModel(string path, string title)
        {
            Path = path;
            Title = title ?? PathIO.GetFileName(path);
        }
    }
}