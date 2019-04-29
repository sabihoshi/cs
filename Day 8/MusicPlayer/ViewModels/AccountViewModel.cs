using System.Collections.Generic;
using System.Windows.Controls;
using Caliburn.Micro;
using LiteDB;
using MusicPlayer.Models;
using MusicPlayer.Views;

namespace MusicPlayer.ViewModels
{
    public class AccountViewModel : Conductor<object>
    {
        private readonly AccountLoginViewModel _accountLogin;
        private readonly AccountCreateViewModel _accountCreate;

        public void LoadAccountCreation()
        {
            ActivateItem(_accountCreate);
        }

        public void LoadAccountLogin()
        {
            ActivateItem(_accountLogin);
        }

        public AccountViewModel()
        {
            _accountLogin = new AccountLoginViewModel(this);
            _accountCreate = new AccountCreateViewModel();
            LoadAccountLogin();
        }
    }
}