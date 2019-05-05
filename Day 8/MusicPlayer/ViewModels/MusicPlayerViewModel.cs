using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using LiteDB;
using Microsoft.Win32;
using MusicPlayer.Models;
using NAudio.Wave;

namespace MusicPlayer.ViewModels
{
    public class MusicPlayerViewModel : Screen
    {
        public enum LoopSettings
        {
            None, Single, All
        }

        private readonly Random _r = new Random();
        private readonly UserModel _user;
        private readonly IWindowManager manager = new WindowManager();
        private CancellationToken _ct;
        private double _currentPosition;
        private float _currentVolume = 1f;
        private CancellationTokenSource _playbackStoppedToken;
        private PlaylistModel _playingPlaylist;
        private BindableCollection<PlaylistModel> _playlists;
        private PlaylistModel _selectedPlaylist;
        private TrackModel _selectedTrack;
        private double _trackLength;

        public MusicPlayerViewModel(UserModel user)
        {
            _user = user;
            Playlists = _user.Playlists;
        }

        public TrackModel PlayingTrack { get; set; }
        public bool IsShuffle { get; set; } = true;
        public LoopSettings LoopSetting { get; set; } = LoopSettings.None;

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

        public string ShuffleContent => IsShuffle ? "🔀" : "➡";

        public double CurrentPosition
        {
            get => _currentPosition;
            set
            {
                if (value.Equals(_currentPosition)) return;
                _currentPosition = value;
                PlayingTrack.SetPosition(CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPosition);
                NotifyOfPropertyChange(() => CurrentPositionSeconds);
            }
        }

        public double TrackLength
        {
            get => _trackLength;
            set
            {
                _trackLength = value;
                NotifyOfPropertyChange(() => TrackLength);
                NotifyOfPropertyChange(() => TrackLengthSeconds);
            }
        }

        public string CurrentPositionSeconds => PlayingTrack?.GetPositionInSeconds();
        public string TrackLengthSeconds => PlayingTrack?.GetLengthInSeconds();

        public float CurrentVolume
        {
            get => _currentVolume;
            set
            {
                if (_currentVolume.Equals(value)) return;
                _currentVolume = value;
                PlayingTrack?.SetVolume(CurrentVolume);
            }
        }

        public BindableCollection<PlaylistModel> Playlists
        {
            get => _playlists;
            set
            {
                _playlists = value;
                NotifyOfPropertyChange(() => Playlists);
            }
        }

        public PlaylistModel SelectedPlaylist
        {
            get => _selectedPlaylist;
            set
            {
                _selectedPlaylist = value;
                if (SelectedPlaylist == _playingPlaylist)
                {
                    SelectedTrack = PlayingTrack;
                    NotifyOfPropertyChange(() => SelectedTrack);
                }

                NotifyOfPropertyChange(() => SelectedPlaylist);
            }
        }

        public TrackModel SelectedTrack
        {
            get => _selectedTrack;
            set
            {
                if ((SelectedTrack?.Equals(value) ?? false) || value is null) return;
                _selectedTrack = value;
            }
        }

        public string PlayContent => PlayingTrack?.IsPlaying ?? false ? "⏸" : "▶";
        public bool CanPlayTrack => PlayingTrack?.IsReady ?? false;

        public bool CanNextTrack
        {
            get
            {
                if (_playingPlaylist == null) return false;
                if (PlayingTrack     == null) return false;
                if (LoopSetting == LoopSettings.All || IsShuffle) return true;
                return PlayingTrack != _playingPlaylist.Songs.Last();
            }
        }

        public bool CanPreviousTrack
        {
            get
            {
                if (_playingPlaylist == null) return false;
                if (PlayingTrack     == null) return false;
                return PlayingTrack  != _playingPlaylist.Songs.First();
            }
        }

        public void RemoveTracks()
        {
            foreach (var track in SelectedPlaylist.Songs)
                Console.WriteLine(track.IsSelected);
        }

        public void ToggleLoop()
        {
            LoopSetting = (LoopSettings) (((int) LoopSetting + 1) % Enum.GetValues(typeof(LoopSettings)).Length);
            NotifyOfPropertyChange(() => LoopContent);
            NotifyOfPropertyChange(() => CanNextTrack);
        }

        public void ToggleShuffle()
        {
            IsShuffle = !IsShuffle;
            NotifyOfPropertyChange(() => ShuffleContent);
            NotifyOfPropertyChange(() => CanNextTrack);
        }

        public void ChangeTrack()
        {
            if (SelectedTrack == PlayingTrack) return;
            if (PlayingTrack != null)
            {
                PlayingTrack.PlaybackStoppedType = TrackModel.PlaybackStoppedTypes.PlaybackStoppedByUser;
                StopTrack();
            }

            _playingPlaylist = SelectedPlaylist;
            PlayingTrack = SelectedTrack;
            PlayTrack();
        }

        public void StopTrack()
        {
            PlayingTrack?.Dispose();
            _playbackStoppedToken?.Cancel();
            NotifyOfPropertyChange(() => CanPlayTrack);
        }

        public void CreatePlaylist()
        {
            Playlists.Add(new PlaylistModel(null, "New Playlist"));
            UpdateDatabase();
        }

        public void AddSong()
        {
            var fileDialog = new OpenFileDialog {Multiselect = true};
            fileDialog.ShowDialog();
            SelectedPlaylist.AddSong(fileDialog.FileNames);
            NotifyOfPropertyChange(() => SelectedPlaylist);
            UpdateDatabase();
        }

        public void UpdateDatabase()
        {
            using (var dt = new LiteDatabase(@"MyData.db"))
            {
                var users = dt.GetCollection<UserModel>("Users");
                users.Update(_user);
            }
        }

        public void FilePreviewDragEnter(DragEventArgs e)
        {
            var dropEnabled = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                var filenames =
                    e.Data.GetData(DataFormats.FileDrop, true) as string[];

                if (filenames != null)
                {
                    var ext = Path.GetExtension(filenames[0])?.ToUpperInvariant();
                    if (ext != ".PNG" && ext != ".JPG" && ext != ".JPEG") dropEnabled = false;
                }
            }
            else { dropEnabled = false; }

            if (!dropEnabled)
            {
                e.Effects = DragDropEffects.None;
                e.Handled = true;
            }
        }

        public void ChangePlaylistImage(DragEventArgs e)
        {
            var fileList = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            if (fileList != null) SelectedPlaylist.ImagePath = fileList[0];
            NotifyOfPropertyChange(() => SelectedPlaylist);
            UpdateDatabase();
        }

        public void PlayTrack()
        {
            if (PlayingTrack != null && !(PlayingTrack?.IsReady ?? true)) PlayingTrack.LoadTrack(_currentVolume);
            if (PlayingTrack?.IsReady ?? false)
            {
                TrackLength = PlayingTrack.GetGetLength();
                if (PlayingTrack?.IsPlaying ?? false)
                {
                    PlayingTrack.PlaybackStoppedType = TrackModel.PlaybackStoppedTypes.PlaybackStoppedByUser;
                    PlayingTrack.TogglePlayPause();
                }
                else
                {
                    PlayingTrack.PlaybackStoppedType = TrackModel.PlaybackStoppedTypes.PlaybackEnded;
                    PlayingTrack.TogglePlayPause();
                    _playbackStoppedToken = new CancellationTokenSource();
                    _ct = _playbackStoppedToken.Token;
                    _ = UpdateAudioAsync();
                }
            }
            else { NextTrack(); }

            NotifyOfPropertyChange(() => PlayContent);
            NotifyOfPropertyChange(() => CanPlayTrack);
            NotifyOfPropertyChange(() => CanNextTrack);
            NotifyOfPropertyChange(() => CanPreviousTrack);
        }

        public void NextTrack()
        {
            var songs = _playingPlaylist.Songs;
            var nextSong = IsShuffle
                ? _r.Next(_playingPlaylist.Songs.Count)
                : (songs.IndexOf(PlayingTrack) + 1) % songs.Count;
            StopTrack();
            PlayingTrack = songs[nextSong];
            PlayTrack();
        }

        public void PreviousTrack()
        {
            var songs = _playingPlaylist.Songs;
            var songPos = songs.IndexOf(PlayingTrack);
            StopTrack();
            PlayingTrack = songs[songPos - 1];
            PlayTrack();
        }

        private async Task UpdateAudioAsync()
        {
            while (PlayingTrack.PlaybackState == PlaybackState.Playing)
            {
                if (_ct.IsCancellationRequested)
                {
                    PlayingTrack.PlaybackStoppedType = TrackModel.PlaybackStoppedTypes.PlaybackStoppedByUser;
                    break;
                }

                CurrentPosition = PlayingTrack.GetPosition;
                await Task.Delay(500).ConfigureAwait(true);
            }

            NotifyOfPropertyChange(() => CanPlayTrack);
            if (PlayingTrack.PlaybackStoppedType == TrackModel.PlaybackStoppedTypes.PlaybackEnded)
            {
                var songs = _playingPlaylist.Songs;
                switch (LoopSetting)
                {
                    case LoopSettings.None:
                    {
                        if (PlayingTrack == songs.Last()) StopTrack();
                        NextTrack();
                        break;
                    }
                    case LoopSettings.All:
                    {
                        NextTrack();
                        break;
                    }
                    case LoopSettings.Single:
                    {
                        SelectedTrack.SetPosition(0);
                        PlayTrack();
                        NotifyOfPropertyChange(() => CanPlayTrack);
                        break;
                    }
                }
            }
        }
    }
}