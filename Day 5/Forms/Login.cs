using CIIT_Grading_System.Classes;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CIIT_Grading_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static User User = new User();

        public static string userName, userPass;
        public static string userFile = @"..\..\Data\userLogin.json";

        public static Users userLogin = JsonConvert.DeserializeObject<Users>(User.ReadFile(userFile));

        private void NewUserButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var projectForm = new NewUser();
            projectForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userLogin.User.SingleOrDefault(u => u.Username == UserName.Text) != null)
            {
                userName = UserName.Text;
                userPass = userLogin.User.SingleOrDefault(u => u.Username == userName).Password;
                if (UserPass.Text == userPass)
                {
                    Hide();
                    var projectForm = new StudentPortal();
                    projectForm.ShowDialog();
                }
            }
            else
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}