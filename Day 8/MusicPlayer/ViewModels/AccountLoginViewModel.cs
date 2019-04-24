using Caliburn.Micro;
using LiteDB;
using MusicPlayer.Models;

namespace MusicPlayer.ViewModels
{
    internal class AccountLoginViewModel : Screen
    {
        private string username;
        private string password;
        private readonly IWindowManager manager = new WindowManager();

        public string Username
        {
            get => username;
            set
            {
                username = value;
                NotifyOfPropertyChange(Username);
            }
        }

        public AccountLoginViewModel()
        {
            
        }
        public string Password
        {
            get => password;
            set { password = value; NotifyOfPropertyChange(Password); }
        }

        public void LoginUser()
        {
            using (var dt = new LiteDatabase(@"MyData.db"))
            {
                var users = dt.GetCollection<UserModel>("Users");
                var user = users.FindOne(u => u.Username == Username);
                if (!(user is null))
                {
                    if (user.Password == Password)
                    {
                        manager.ShowWindow(new MusicPlayerViewModel(user.Username), null, null);
                    }
                    else
                    { // error
                    }
                }
                else
                {
                    // error
                }
            }
        }
    }
}