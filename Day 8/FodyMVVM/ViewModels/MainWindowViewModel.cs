using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using FodyMVVM.Classes;

namespace FodyMVVM.ViewModels
{
    public class MainWindowViewModel : RelayCommand, INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            TestClick = new RelayCommand(ShowMessage, o => CanExecute);
            Greeting = "Hi";
        }

        public ICommand TestClick { get; set; }

        public bool CanExecute { get; set; } = true;

        public string Greeting { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ShowMessage(object o)
        {
            MessageBox.Show("Hi");
        }
    }
}