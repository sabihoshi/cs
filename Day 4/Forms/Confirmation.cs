using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        public static string userName, userPass;
        public static string userFile = @"..\..\Data\userLogin.json";
        public static dynamic userLogin;

        private void LoginStart_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader(userFile))
            {
                string json = r.ReadToEnd();
                userLogin = JsonConvert.DeserializeObject(json);
            }
            userName = UserName.Text;
            userPass = userLogin[userName];
            if (userName != Entry.userName)
                MessageBox.Show("Please login with the same user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (UserPass.Text == userPass)
            {
                Hide();
                var projectForm = new Subscription();
                projectForm.ShowDialog();
            }
            else
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}