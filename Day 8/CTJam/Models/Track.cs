using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CTJam.Models
{
    public class Track : INotifyPropertyChanged
    {
        private string _filepath;
        private string _friendlyName;

        public Track(string filepath, string friendlyName)
        {
            Filepath = filepath;
            FriendlyName = friendlyName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Filepath
        {
            get { return _filepath; }
            set
            {
                if (value == _filepath) return;
                _filepath = value;
                OnPropertyChanged(nameof(Filepath));
            }
        }

        public string FriendlyName
        {
            get { return _friendlyName; }
            set
            {
                if (value == _friendlyName) return;
                _friendlyName = value;
                OnPropertyChanged(nameof(FriendlyName));
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}