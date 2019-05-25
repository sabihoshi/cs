using Caliburn.Micro;
using NAudio.Wave;
using System;
using System.Linq;
using System.Threading.Tasks;
using VChan.Models;

namespace VChan.ViewModels
{
    public class PlayerViewModel : Screen
    {
        private readonly Random _r = new Random();

        private StoppedType _playbackStoppedType;

        public PlayerViewModel()
        {
            Playlists = new BindableCollection<PlaylistModel>();
            var newPlaylist = new PlaylistModel
            {
                Name = "Kao",
                Image = @"C:\Users\Kao\Pictures\Avatars\1549918098893.jpg"
            };
            newPlaylist.AddSong(@"F:\Osu!\P-Light - YELLOW SPLASH!!.mp3");
            newPlaylist.AddSong(@"F:\Osu!\Shinshuu Plains.mp3");
            newPlaylist.AddSong(@"F:\Osu!\Pedal Heart.mp3");
            Playlists.Add(newPlaylist);
        }

        public enum LoopSettings
        {
            None, Single, All
        }

        private enum StoppedType
        {
            StoppedByUser, Ended
        }

        public string LoopContent
        {
            get
            {
                switch (LoopSetting)
                {
                    case LoopSettings.None:   return "↩";
                    case LoopSettings.Single: return "🔂";
                    case LoopSettings.All:    return "🔁";
                    default:                  return "↩";
                }
            }
        }
        public string PlayContent => PlayingAudio?.IsPlaying ?? false ? "⏸" : "▶";
        public string ShuffleContent => IsShuffle ? "🔀" : "➡";

        public bool CanPauseAudio => PlayingAudio?.IsPlaying ?? false;
        public bool CanPlayAudio => Output != null && AudioFileReader != null;
        public TimeSpan ElapsedSeconds => AudioFileReader?.CurrentTime ?? new TimeSpan(0);
        public bool IsShuffle { get; set; } = true;
        public LoopSettings LoopSetting { get; set; } = LoopSettings.None;
        public BindableCollection<PlaylistModel> Playlists { get; set; }
        public AudioViewModel SelectedAudio { get; set; }
        public PlaylistModel SelectedPlaylist { get; set; }
        public TimeSpan AudioLength => AudioFileReader?.TotalTime ?? new TimeSpan(0);

        public double SeekerMax => AudioLength.TotalSeconds;
        public double SeekerPos
        {
            get { return ElapsedSeconds.TotalSeconds; }
            set
            {
                if (value.Equals(SeekerPos)) return;
                SetPosition(value);
            }
        }

        public float Volume { get; set; } = 1f;

        private AudioFileReader AudioFileReader { get; set; }
        private DirectSoundOut Output = new DirectSoundOut();
        private AudioViewModel PlayingAudio { get; set; }
        private PlaylistModel PlayingPlaylist { get; set; }

        /// <summary>
        /// If audio is still playing, make sure to stop the audio first before trying to play a new one.
        /// </summary>
        /// <param name="audio"></param>
        public void ChangeAudio(AudioViewModel audio)
        {
            if (audio == PlayingAudio) return;
            if (AudioFileReader != null)
            {
                _playbackStoppedType = StoppedType.StoppedByUser;
                StopAudio();
            }
            try
            {
                AudioFileReader = new AudioFileReader(audio.Song.Path) { Volume = Volume };
                var wc = new WaveChannel32(AudioFileReader) { PadWithZeroes = false };
                Output.Init(wc);

                PlayingAudio = audio;

                Output.PlaybackStopped += (sender, args) => { PlayingAudio.IsPlaying = false; };
            }
            catch (Exception)
            {
                //ignored
            }
        }

        public void DoubleClick()
        {
            PlayingPlaylist = SelectedPlaylist;
            ChangeAudio(SelectedAudio);
            PlayAudio();
        }

        public void NextAudio()
        {
            var songs = PlayingPlaylist.Songs;
            ChangeAudio(songs[IsShuffle
                ? _r.Next(PlayingPlaylist.Songs.Count)
                : (songs.IndexOf(PlayingAudio) + 1) % songs.Count]);
        }

        public void PlayPauseAudio()
        {
            if (Output?.PlaybackState == PlaybackState.Playing)
            {
                PauseAudio();
            }
            else
            {
                PlayAudio();
            }
        }

        public void PauseAudio()
        {
            if (PlayingAudio == null) return;
            PlayingAudio.IsPlaying = false;
            _playbackStoppedType = StoppedType.StoppedByUser;
            Output?.Pause();
        }

        public void PlayAudio()
        {
            if (PlayingAudio == null) return;
            PlayingAudio.IsPlaying = true;
            _playbackStoppedType = StoppedType.Ended;
            Output?.Play();
            _ = UpdateAudioAsync();
        }

        public void SetPosition(double value)
        {
            if (AudioFileReader == null) return;
            AudioFileReader.CurrentTime = TimeSpan.FromSeconds(value);
        }

        /// <summary>
        /// Make sure to stop and dispose the Output and AudioFileReader.
        /// </summary>
        public void StopAudio()
        {
            Output?.Stop();
            AudioFileReader?.Dispose();
            AudioFileReader = null;
            if (PlayingAudio != null) PlayingAudio.IsPlaying = false;
        }

        public void ToggleLoop()
        {
            LoopSetting = (LoopSettings)(((int)LoopSetting + 1) % Enum.GetValues(typeof(LoopSettings)).Length);
        }

        public void ToggleShuffle()
        {
            IsShuffle = !IsShuffle;
        }

        /// <summary>
        ///     Update the UI the currently elapsed time every 500ms.
        ///     If user pauses or stops on his own, it will not move on to the next audio track.
        /// </summary>
        private async Task UpdateAudioAsync()
        {
            while (Output.PlaybackState == PlaybackState.Playing)
            {
                NotifyOfPropertyChange(() => ElapsedSeconds);
                NotifyOfPropertyChange(() => SeekerPos);
                await Task.Delay(500).ConfigureAwait(true);
            }

            if (_playbackStoppedType == StoppedType.StoppedByUser) return;
            switch (LoopSetting)
            {
                case LoopSettings.None:
                {
                    if (PlayingAudio == PlayingPlaylist.Songs.Last()) StopAudio();
                    else NextAudio();
                    break;
                }
                case LoopSettings.All:
                {
                    NextAudio();
                    break;
                }
                case LoopSettings.Single:
                {
                    SetPosition(0);
                    PlayAudio();
                    break;
                }
            }
        }
    }
}