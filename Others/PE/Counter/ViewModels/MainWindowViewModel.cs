using Caliburn.Micro;
using JetBrains.Annotations;
using PropertyChanged;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace Counter.ViewModels
{
    public class MainWindowViewModel : Screen, INotifyPropertyChanged
    {
        private string _hours;
        private TimeSpan _time;
        private DispatcherTimer _timer;

        public Stopwatch Timer = new Stopwatch();
        private string _minutes;
        private string _seconds;

        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public string Image1 { get; set; } = Path.GetFullPath(@"../../Images/placeholder.png");
        public string Image2 { get; set; } = Path.GetFullPath(@"../../Images/placeholder.png");

        [UsedImplicitly] public bool CanHours => _timer?.IsEnabled   ?? false;
        [UsedImplicitly] public bool CanMinutes => _timer?.IsEnabled ?? false;
        [UsedImplicitly] public bool CanSeconds => _timer?.IsEnabled ?? false;
        [UsedImplicitly] public bool CanRemoveScoreTeam1 => Score1 > 0;
        [UsedImplicitly] public bool CanRemoveScoreTeam2 => Score2 > 0;

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
        [UsedImplicitly] public void ResetTeam1() => Score1 = 0;
        [UsedImplicitly] public void ResetTeam2() => Score2 = 0;
        [UsedImplicitly] public void AddScoreTeam1() => Score1++;
        [UsedImplicitly] public void AddScoreTeam2() => Score2++;
        [UsedImplicitly] public void RemoveScoreTeam1() => Score1--;
        [UsedImplicitly] public void RemoveScoreTeam2() => Score2--;

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
        public void ChangeImage1(DragEventArgs e)
        {
            var fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileList != null) Image1 = fileList.FirstOrDefault();
        }

        [UsedImplicitly]
        public void ChangeImage2(DragEventArgs e)
        {
            var fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileList != null) Image2 = fileList.FirstOrDefault();
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

        [UsedImplicitly]
        public void StartTimer()
        {
            _time = TimeLeft;

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal, delegate
                {
                    TimeLeft = _time;
                    if (_time == TimeSpan.Zero) _timer.Stop();
                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                }, Application.Current.Dispatcher);

            _timer.Start();

            NotifyOfPropertyChange(() => CanHours);
            NotifyOfPropertyChange(() => CanMinutes);
            NotifyOfPropertyChange(() => CanSeconds);
        }
    }
}