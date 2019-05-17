using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using VChan.ViewModels;

namespace VChan
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
            manager.ShowWindow(new PlayerViewModel());
        }
    }
}
