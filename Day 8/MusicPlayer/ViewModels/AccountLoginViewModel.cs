using Caliburn.Micro;
using LiteDB;
using MusicPlayer.Models;
using System.Windows;

namespace MusicPlayer.ViewModels
{
    internal class AccountLoginViewModel : Screen
    {
        private readonly AccountViewModel _context;
        private readonly IWindowManager _manager = new WindowManager();

        public AccountLoginViewModel(AccountViewModel context)
        {
            _context = context;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public void InvalidLogin()
        {
            MessageBox.Show("Invalid username or password, please try again.", "User login", MessageBoxButton.OK);
        }

        public void LoginUser()
        {
            UserModel user;
            using (var dt = new LiteDatabase(@"MyData.db"))
            {
                var users = dt.GetCollection<UserModel>("Users");
                user = users.FindOne(u => u.Username == Username);
            }

            if (!(user is null))
            {
                if (user.Password == Password)
                {
                    _manager.ShowWindow(new MusicPlayerViewModel(user));
                    _context.TryClose();
                }
                else { InvalidLogin(); }
            }
            else { InvalidLogin(); }
        }

        public void CreateAccount()
        {
            _context.LoadAccountCreation();
        }
    }
}