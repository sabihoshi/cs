using System;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using Caliburn.Micro;
using LiteDB;
using NAudio.Wave;
using TagLib;
using WaveFormRendererLib;
using PathIO = System.IO.Path;

namespace MusicPlayer.Models
{
    public class TrackModel : Screen
    {
        public enum PlaybackStoppedTypes
        {
            PlaybackStoppedByUser, PlaybackEnded
        }

        private TrackModel(string path, string title)
        {
            Title = title ?? PathIO.GetFileName(path);
            Path = path;
        }

        public TrackModel() { }

        public TrackModel(string path) : this(path, File.Create(path).Tag.Title) { }

        [BsonIgnore] public PlaybackStoppedTypes PlaybackStoppedType { get; set; }
        [BsonIgnore] public TimeSpan Length => TrackExists ? File.Create(Path).Properties.Duration : new TimeSpan();
        public string Name => TrackExists ? Title : $"File not found. ({Title})";
        [BsonIgnore] public bool IsSelected { get; set; }
        [BsonIgnore] private bool TrackExists => System.IO.File.Exists(Path);
        public string Title { get; set; }
        public string Path { get; set; }
        [BsonIgnore] public PlaybackState PlaybackState => Output?.PlaybackState ?? PlaybackState.Stopped;
        [BsonIgnore] public string PlayingText => IsPlaying ? "▶" : "";
        [BsonIgnore] public double GetPosition => AudioFileReader?.CurrentTime.TotalSeconds ?? 0;
        [BsonIgnore] public bool IsReady => Output                  != null;
        [BsonIgnore] public bool IsPlaying => Output?.PlaybackState == PlaybackState.Playing;
        [BsonIgnore] private AudioFileReader AudioFileReader { get; set; }
        [BsonIgnore] private DirectSoundOut Output { get; set; }

        public double GetGetLength()
        {
            return AudioFileReader?.TotalTime.TotalSeconds ?? 0;
        }

        public string GetLengthInSeconds()
        {
            return TimeSpan.FromSeconds(AudioFileReader?.TotalTime.TotalSeconds ?? 0).ToString(@"mm\:ss");
        }

        public string GetPositionInSeconds()
        {
            return TimeSpan.FromSeconds(AudioFileReader?.CurrentTime.TotalSeconds ?? 0).ToString(@"mm\:ss");
        }

        public void Dispose()
        {
            if (Output != null)
            {
                if (Output.PlaybackState == PlaybackState.Playing) Output.Stop();
                Output.Dispose();
                Output = null;
            }

            if (AudioFileReader != null)
            {
                AudioFileReader.Dispose();
                AudioFileReader = null;
            }

            NotifyOfPropertyChange(() => PlayingText);
        }

        public static bool IsValid(string path)
        {
            try
            {
                new AudioFileReader(path).Dispose();
                File.Create(path).Dispose();
                return true;
            }
            catch { return false; }
        }

        public void LoadTrack(float volume)
        {
            if (!IsValid(Path)) return;
            _ = RenderAudioAsync(Path);
            AudioFileReader = new AudioFileReader(Path) {Volume = volume};
            Output = new DirectSoundOut(200);
            var wc = new WaveChannel32(AudioFileReader) {PadWithZeroes = false};
            Output.Init(wc);
        }

        private void Pause()
        {
            PlaybackStoppedType = PlaybackStoppedTypes.PlaybackStoppedByUser;
            Output?.Pause();
        }

        private void Play()
        {
            PlaybackStoppedType = PlaybackStoppedTypes.PlaybackEnded;
            Output?.Play();
        }

        private static async Task RenderAudioAsync(string fileName)
        {
            var averagePeakProvider = new AveragePeakProvider(4);
            var rendererSettings = new StandardWaveFormRendererSettings
            {
                Width = 1080,
                TopHeight = 64,
                BottomHeight = 64
            };
            var renderer = new WaveFormRenderer();
            var image = await Task.Run(() => renderer.Render(fileName, averagePeakProvider, rendererSettings))
                                  .ConfigureAwait(false);
            image.Save($@"../{PathIO.GetFileNameWithoutExtension(fileName)}.png", ImageFormat.Png);
        }

        public void SetPosition(double value)
        {
            if (AudioFileReader != null) AudioFileReader.CurrentTime = TimeSpan.FromSeconds(value);
        }

        public void SetVolume(float value)
        {
            if (AudioFileReader != null) AudioFileReader.Volume = value;
        }

        public void Stop()
        {
            PlaybackStoppedType = PlaybackStoppedTypes.PlaybackStoppedByUser;
            Output?.Stop();
        }

        public void TogglePlayPause()
        {
            if (Output != null)
            {
                if (Output.PlaybackState == PlaybackState.Playing) Pause();
                else Play();
            }
            else { Play(); }

            NotifyOfPropertyChange(() => PlayingText);
        }
    }
}