using Caliburn.Micro;
using MusicPlayer.ViewModels;
using System.Windows;

namespace MVVMTest.Classes
{
    public class Bootstrapper : BootstrapperBase
    {
        private readonly IWindowManager manager = new WindowManager();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            manager.ShowWindow(new AccountViewModel());
        }
    }
}