using JetBrains.Annotations;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace Counter.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public string Image1 { get; set; } = Path.GetFullPath(@"../../Images/placeholder.png");
        public string Image2 { get; set; } = Path.GetFullPath(@"../../Images/placeholder.png");

        public Stopwatch Timer = new Stopwatch();

        public void AddScoreTeam1() => Score1++;
        public void AddScoreTeam2() => Score2++;

        public void RemoveScoreTeam1() => Score1--;
        public void RemoveScoreTeam2() => Score2--;

        public bool CanRemoveScoreTeam1 => Score1 > 0;
        public bool CanRemoveScoreTeam2 => Score2 > 0;

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
            if (fileList != null) { Image1 = fileList.FirstOrDefault(); }
        }

        [UsedImplicitly]
        public void ChangeImage2(DragEventArgs e)
        {
            var fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileList != null) { Image2 = fileList.FirstOrDefault(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }
    }
}