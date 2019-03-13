using Library.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new NewUser();
            newForm.Show();
            Hide();
        }

        public static RootUsers Authentication = new RootUsers();

        private void Login_Load(object sender, EventArgs e)
        {
            Authentication = JsonConvert.DeserializeObject<RootUsers>(Manager.ReadFile(@"../../Data/login.json"));
        }

        public string userName, userPass;

        private void UserLogin_Click(object sender, EventArgs e)
        {
            if (Authentication.Users.SingleOrDefault(u => u.Username == UserName.Text) != null)
            {
                userName = UserName.Text;
                userPass = Authentication.Users.SingleOrDefault(u => u.Username == userName).Password;
                if (PassWord.Text == userPass)
                {
                    Hide();
                    var newForm = new Interface();
                    newForm.ShowDialog();
                }
            }
            else
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}