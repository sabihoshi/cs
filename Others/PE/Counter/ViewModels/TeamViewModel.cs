using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using JetBrains.Annotations;

namespace Counter.ViewModels
{
    public class TeamViewModel : Screen, INotifyPropertyChanged
    {
        public string Image { get; set; } = Path.GetFullPath(@"../../Images/placeholder.png");
        public int Score { get; set; }
        [UsedImplicitly] public bool CanRemoveScoreTeam => Score > 0;

        [UsedImplicitly]
        public void RemoveScoreTeam()
        {
            Score--;
        }

        [UsedImplicitly]
        public void AddScoreTeam()
        {
            Score++;
        }

        [UsedImplicitly]
        public void ResetTeam()
        {
            Score = 0;
        }

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
        public void ChangeImage(DragEventArgs e)
        {
            var fileList = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            if (fileList != null) Image = fileList.FirstOrDefault();
        }
    }
}