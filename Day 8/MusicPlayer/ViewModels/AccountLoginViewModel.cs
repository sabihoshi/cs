﻿using System.Windows;
using Caliburn.Micro;
using LiteDB;
using MusicPlayer.Models;

namespace MusicPlayer.ViewModels
{
    internal class AccountLoginViewModel : Screen
    {
        private readonly AccountViewModel context;
        private readonly IWindowManager manager = new WindowManager();

        public AccountLoginViewModel(AccountViewModel context)
        {
            this.context = context;
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
                    manager.ShowWindow(new MusicPlayerViewModel(user));
                    context.TryClose();
                }
                else
                {
                    InvalidLogin();
                }
            }
            else
            {
                InvalidLogin();
            }
        }

        public void CreateAccount()
        {
            context.LoadAccountCreation();
        }
    }
}