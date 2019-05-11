using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Caliburn.Micro;
using JetBrains.Annotations;
using PropertyChanged;

namespace Counter.ViewModels
{
    public class MainWindowViewModel : Screen, INotifyPropertyChanged
    {
        private string _hours;
        private string _minutes;
        private string _seconds;
        private TimeSpan _time;
        private DispatcherTimer _timer;

        private readonly MediaPlayer mediaPlayer = new MediaPlayer();

        [UsedImplicitly] public TeamViewModel Team => new TeamViewModel();

        [UsedImplicitly] public bool CanHours => _timer?.IsEnabled   ?? false;
        [UsedImplicitly] public bool CanMinutes => _timer?.IsEnabled ?? false;
        [UsedImplicitly] public bool CanSeconds => _timer?.IsEnabled ?? false;

        [UsedImplicitly]
        [AlsoNotifyFor(nameof(TimeLeft))]
        public string Hours
        {
            get => TimeLeft.ToString("hh");
            set
            {
                _hours = value;
                if (TimeSpan.TryParse($"{_hours ?? "00"}:{_minutes ?? "00"}:{_seconds ?? "00"}", out var newTime))
                    TimeLeft = newTime;
            }
        }

        [UsedImplicitly]
        [AlsoNotifyFor(nameof(TimeLeft))]
        public string Minutes
        {
            get => TimeLeft.ToString("mm");
            set
            {
                _minutes = value;
                if (TimeSpan.TryParse($"{_hours ?? "00"}:{_minutes ?? "00"}:{_seconds ?? "00"}", out var newTime))
                    TimeLeft = newTime;
            }
        }

        [UsedImplicitly]
        [AlsoNotifyFor(nameof(TimeLeft))]
        public string Seconds
        {
            get => TimeLeft.ToString("ss");
            set
            {
                _seconds = value;
                if (TimeSpan.TryParse($"{_hours ?? "00"}:{_minutes ?? "00"}:{_seconds ?? "00"}", out var newTime))
                    TimeLeft = newTime;
            }
        }

        public TimeSpan TimeLeft { get; set; } = new TimeSpan(0);

        [UsedImplicitly]
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

        [UsedImplicitly]
        public void PauseTimer()
        {
            _timer.Stop();

            NotifyOfPropertyChange(() => CanHours);
            NotifyOfPropertyChange(() => CanMinutes);
            NotifyOfPropertyChange(() => CanSeconds);
        }

        [UsedImplicitly]
        public void ResetTimer()
        {
            PauseTimer();
            TimeLeft = new TimeSpan(0);
        }

        public void TimerHorn()
        {
            mediaPlayer.Open(
                new Uri($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CIIT\Buzzer.wav"));
            mediaPlayer.Play();
        }

        [UsedImplicitly]
        public void StartTimer()
        {
            _time = TimeLeft;

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal, delegate
                {
                    TimeLeft = _time;
                    if (_time == TimeSpan.Zero)
                    {
                        TimerHorn();
                        _timer.Stop();
                    }

                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                }, Application.Current.Dispatcher);

            _timer.Start();

            NotifyOfPropertyChange(() => CanHours);
            NotifyOfPropertyChange(() => CanMinutes);
            NotifyOfPropertyChange(() => CanSeconds);
        }
    }
}