﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        public static string userName, userPass;
        public static string userFile = @"..\..\Data\userLogin.json";
        public static dynamic userLogin;

        private void CreateAccountButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var projectForm = new NewUser();
            projectForm.ShowDialog();
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader(userFile))
            {
                string json = r.ReadToEnd();
                userLogin = JsonConvert.DeserializeObject(json);
            }
        }

        private void LoginStart_Click(object sender, EventArgs e)
        {
            userName = UserName.Text;
            userPass = userLogin[userName];
            if (UserPass.Text == userPass)
            {
                this.Hide();
                var projectForm = new Interface();
                projectForm.ShowDialog();
            }
            else
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}