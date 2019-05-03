using Caliburn.Micro;

namespace MusicPlayer.ViewModels
{
    public class AccountViewModel : Conductor<object>
    {
        private readonly AccountCreateViewModel _accountCreate;
        private readonly AccountLoginViewModel _accountLogin;

        public AccountViewModel()
        {
            _accountLogin = new AccountLoginViewModel(this);
            _accountCreate = new AccountCreateViewModel();
            LoadAccountLogin();
        }

        public void LoadAccountCreation()
        {
            ActivateItem(_accountCreate);
        }

        public void LoadAccountLogin()
        {
            ActivateItem(_accountLogin);
        }
    }
}