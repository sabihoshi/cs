using System;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using Caliburn.Micro;
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
            PlaybackStoppedByUser,
            PlaybackEnded
        }

        private TrackModel(string path, string title)
        {
            Title = title ?? PathIO.GetFileName(path);
            Path = path;
        }

        public TrackModel() { }
        public TrackModel(string path) : this(path, File.Create(path).Tag.Title) { }
        public PlaybackStoppedTypes PlaybackStoppedType { get; set; }
        public TimeSpan Length => TrackExists ? File.Create(Path).Properties.Duration : new TimeSpan();

        public string Name
        {
            get
            {
                if (TrackExists) return Title;
                return $"File not found. ({Title})";
            }
        }

        public bool TrackExists => System.IO.File.Exists(Path);
        public string Title { get; set; }
        public string Path { get; set; }
        public double GetLength => AudioFileReader?.TotalTime.TotalSeconds ?? 0;
        public PlaybackState PlaybackState => Output?.PlaybackState        ?? PlaybackState.Stopped;
        public string GetLengthInSeconds =>
            TimeSpan.FromSeconds(AudioFileReader?.TotalTime.TotalSeconds ?? 0).ToString(@"mm\:ss");
        public string PlayingText => IsPlaying ? "▶" : "";
        public string GetPositionInSeconds =>
            TimeSpan.FromSeconds(AudioFileReader?.CurrentTime.TotalSeconds ?? 0).ToString(@"mm\:ss");
        public double GetPosition => AudioFileReader?.CurrentTime.TotalSeconds ?? 0;
        public bool IsReady => Output                  != null;
        public bool IsPlaying => Output?.PlaybackState == PlaybackState.Playing;
        public AudioFileReader AudioFileReader { get; set; }
        public DirectSoundOut Output { get; set; }

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

        public float GetVolume()
        {
            return AudioFileReader?.Volume ?? 1;
        }

        public static bool IsValid(string path)
        {
            try
            {
                new AudioFileReader(path).Dispose();
                File.Create(path).Dispose();
                return true;
            }
            catch
            {
                return false;
            }
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

        public void Pause()
        {
            PlaybackStoppedType = PlaybackStoppedTypes.PlaybackStoppedByUser;
            Output?.Pause();
        }

        public void Play()
        {
            PlaybackStoppedType = PlaybackStoppedTypes.PlaybackEnded;
            Output?.Play();
        }

        private static async Task RenderAudioAsync(string fileName)
        {
            var averagePeakProvider = new AveragePeakProvider(4);
            var rendererSettings = new StandardWaveFormRendererSettings
            {
                Width = 1080, TopHeight = 64, BottomHeight = 64
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
            Output?.Stop();
        }

        public void TogglePlayPause()
        {
            if (Output != null)
            {
                if (Output.PlaybackState == PlaybackState.Playing) Pause();
                else Play();
            }
            else
            {
                Play();
            }
            NotifyOfPropertyChange(() => PlayingText);
        }
    }
}