using System;
using Caliburn.Micro;
using JetBrains.Annotations;

namespace MusicPlayer.ViewModels
{
    public class AccountViewModel : Conductor<object>
    {
        private readonly AccountCreateViewModel _accountCreate;
        private readonly AccountLoginViewModel _accountLogin;

        public AccountViewModel()
        {
            _accountLogin = new AccountLoginViewModel(this);
            _accountCreate = new AccountCreateViewModel(this);
            LoadAccountLogin();
        }

        [UsedImplicitly]
        public string Logo { get; } =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Kao/Resources/canvas_full_logo.png";

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