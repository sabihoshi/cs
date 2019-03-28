using Caliburn.Micro;

namespace MVVMTest.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Kao";

        private string _lastName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                //NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                //NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
    }
}