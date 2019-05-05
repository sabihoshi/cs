using System.Windows;
using Caliburn.Micro;
using LiteDB;
using MusicPlayer.Models;

namespace MusicPlayer.ViewModels
{
    public class AccountCreateViewModel : Screen
    {
        public string Username { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public void CreateAccount()
        {
            using (var dt = new LiteDatabase(@"MyData.db"))
            {
                var users = dt.GetCollection<UserModel>("Users");
                if (users.FindOne(user => user.Username == Username) != null)
                    MessageBox.Show("That username is already taken!");
                else if(Password1 != Password2)
                    MessageBox.Show("Password does not match!");
                else
                {
                    users.Insert(new UserModel()
                    {
                        Username = Username,
                        Password = Password1
                    });
                }
            }
        }
}
}