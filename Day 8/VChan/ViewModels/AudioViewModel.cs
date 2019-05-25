using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using VChan.Annotations;
using VChan.Models;

namespace VChan.ViewModels
{
    public class AudioViewModel : INotifyPropertyChanged
    {
        public AudioViewModel(string path, string title)
        {
            Song = new AudioModel(path, title);
        }

        public AudioViewModel(string path)
        {
            Song = new AudioModel(path);
        }
        public bool IsPlaying { get; set; }
        public bool IsSelected { get; set; }
        public AudioModel Song { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
