using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace CIIT_Grading_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string userName, userPass;
        public static string userFile = @"..\..\Data\userLogin.json";
        public static dynamic userLogin;

        private void Login_Load(object sender, EventArgs e)
        {
            using (var r = new StreamReader(userFile))
            {
                string json = r.ReadToEnd();
                userLogin = JsonConvert.DeserializeObject(json);
            }
        }

        private void NewUserButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var projectForm = new NewUser();
            projectForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            userName = UserName.Text;
            userPass = userLogin[userName];
            if (UserPass.Text == userPass)
            {
                this.Hide();
                var projectForm = new StudentPortal();
                projectForm.ShowDialog();
            }
            else
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}