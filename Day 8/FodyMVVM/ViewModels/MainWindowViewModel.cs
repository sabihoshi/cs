using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using FodyMVVM.Annotations;
using FodyMVVM.Classes;

namespace FodyMVVM.ViewModels
{
    public class MainWindowViewModel : RelayCommand, INotifyPropertyChanged
    {
        private bool _canShowMessage;
        private string _greeting;
        private ICommand _showMessageCommand;

        public MainWindowViewModel()
        {
            ShowMessageCommand = new RelayCommand(ShowMessage, o => CanShowMessage);
            Greeting = "Hi";
        }

        public ICommand ShowMessageCommand
        {
            get => _showMessageCommand;
            set
            {
                if (Equals(value, _showMessageCommand)) return;
                _showMessageCommand = value;
                OnPropertyChanged();
            }
        }

        public bool CanShowMessage
        {
            get => _canShowMessage;
            set
            {
                if (value == _canShowMessage) return;
                _canShowMessage = value;
                OnPropertyChanged();
            }
        }

        public string Greeting
        {
            get => _greeting;
            set
            {
                if (value == _greeting) return;
                _greeting = value;
                CanShowMessage = !string.IsNullOrEmpty(Greeting);
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ShowMessage(object o)
        {
            MessageBox.Show(Greeting);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}