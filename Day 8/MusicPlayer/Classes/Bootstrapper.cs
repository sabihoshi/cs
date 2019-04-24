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

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<AccountLoginViewModel>();
        }
    }
}