using System;
using System.Windows.Forms;
using Library.Classes;

namespace Library.Forms
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void LoginStart_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || PassWord.Text == "")
            {
                if (MessageBox.Show("Please enter a valid username or Password!", "Create user",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Hide();
            }
            else if (PassWord.Text != UserPassCheck.Text)
            {
                if (MessageBox.Show("Password does not match!", "Create user", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error) == DialogResult.Cancel)
                    Hide();
            }
            else
            {
                Login.Authentication.Users.Add(new User(UserName.Text, PassWord.Text));
                Manager.JsonUpdate(@"./Data/login.json", Login.Authentication);
                MessageBox.Show("User was created.", "Create user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}