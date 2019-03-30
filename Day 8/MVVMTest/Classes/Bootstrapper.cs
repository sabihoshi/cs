using Caliburn.Micro;
using MVVMTest.ViewModels;
using System.Windows;

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
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}