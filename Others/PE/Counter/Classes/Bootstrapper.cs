using Caliburn.Micro;
using System.Windows;
using Counter.ViewModels;

namespace Counter.Classes
{
    internal class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainWindowViewModel>();
        }
    }
}