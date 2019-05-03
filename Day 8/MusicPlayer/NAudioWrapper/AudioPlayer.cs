using System;
using NAudio.Wave;

namespace MusicPlayer.NAudioWrapper
{
    /// <summary>
    ///     This class might not be needed as of now.
    /// </summary>
    public class AudioPlayer
    {
        public enum PlaybackStopTypes
        {
            PlaybackStoppedByUser,
            PlaybackStoppedReachingEndOfFile
        }

        private AudioFileReader _audioFileReader;
        private string _filepath;
        private DirectSoundOut _output;

        public AudioPlayer(string filepath, float volume)
        {
            PlaybackStopType = PlaybackStopTypes.PlaybackStoppedReachingEndOfFile;

            _audioFileReader = new AudioFileReader(filepath) {Volume = volume};

            _output = new DirectSoundOut(200);
            _output.PlaybackStopped += _output_PlaybackStopped;

            var wc = new WaveChannel32(_audioFileReader);
            wc.PadWithZeroes = false;

            _output.Init(wc);
        }

        public PlaybackStopTypes PlaybackStopType { get; set; }

        public event Action PlaybackPaused;

        public event Action PlaybackResumed;

        public event Action PlaybackStopped;

        public void Dispose()
        {
            if (_output != null)
            {
                if (_output.PlaybackState == PlaybackState.Playing) _output.Stop();
                _output.Dispose();
                _output = null;
            }

            if (_audioFileReader != null)
            {
                _audioFileReader.Dispose();
                _audioFileReader = null;
            }
        }

        public double GetLenghtInSeconds()
        {
            if (_audioFileReader != null)
                return _audioFileReader.TotalTime.TotalSeconds;
            return 0;
        }

        public double GetPositionInSeconds()
        {
            return _audioFileReader != null ? _audioFileReader.CurrentTime.TotalSeconds : 0;
        }

        public float GetVolume()
        {
            if (_audioFileReader != null) return _audioFileReader.Volume;
            return 1;
        }

        public void Pause()
        {
            if (_output != null)
            {
                _output.Pause();

                PlaybackPaused?.Invoke();
            }
        }

        public void Play(PlaybackState playbackState, double currentVolumeLevel)
        {
            if (playbackState == PlaybackState.Stopped || playbackState == PlaybackState.Paused) _output.Play();

            _audioFileReader.Volume = (float) currentVolumeLevel;

            PlaybackResumed?.Invoke();
        }

        public void SetPosition(double value)
        {
            if (_audioFileReader != null) _audioFileReader.CurrentTime = TimeSpan.FromSeconds(value);
        }

        public void SetVolume(float value)
        {
            if (_output != null) _audioFileReader.Volume = value;
        }

        public void Stop()
        {
            _output?.Stop();
        }

        public void TogglePlayPause(double currentVolumeLevel)
        {
            if (_output != null)
            {
                if (_output.PlaybackState == PlaybackState.Playing)
                    Pause();
                else
                    Play(_output.PlaybackState, currentVolumeLevel);
            }
            else
            {
                Play(PlaybackState.Stopped, currentVolumeLevel);
            }
        }

        private void _output_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            Dispose();
            PlaybackStopped?.Invoke();
        }
    }
}