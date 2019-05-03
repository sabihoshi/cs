using Caliburn.Micro;
using System.Windows;
using System.Windows.Controls;
using MusicPlayer.ViewModels;

namespace MVVMTest.Classes
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        private readonly IWindowManager manager = new WindowManager();

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            manager.ShowWindow(new AccountViewModel());
            
        }
    }
}