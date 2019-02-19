using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Login
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private User User = new User();

        private void Interface_Load(object sender, EventArgs e)
        {
            User.CreateUser(Entry.userName);
            WebClient wc = new WebClient();
            try
            {
                byte[] bytes = wc.DownloadData(User.userData.Avatar.ToString());
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                Avatar.Image = img;
            }
            catch (Exception) { }
            string userStatus = User.userData.Status;
            if (userStatus != null)
            {
                if (userStatus == "")
                    userStatus = "Enter status...";
                StatusBox.Text = userStatus;
            }
            else
                StatusBox.Text = "Enter status...";
            WelcomeText.Text = String.Format("Welcome back, {0}!", Entry.userName);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userPass = Entry.userPass;
            Entry.userLogin[Entry.userName] = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Password Change", userPass);
            MessageBox.Show("Password successfully changed.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            User.JsonUpdate(Entry.userFile, Entry.userLogin);
        }

        private void StatusBox_TextChanged(object sender, EventArgs e)
        {
            User.userData.Status = StatusBox.Text;
            User.JsonUpdate(User.userFile, User.userData);
        }

        private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userStatus = User.userData.Status;
            string newStatus;
            if (User.userData.Status == null)
                userStatus = "Enter a status...";
            newStatus = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Status Change", userStatus);
            User.userData.Status = newStatus;
            StatusBox.Text = newStatus;
            User.JsonUpdate(User.userFile, User.userData);
            MessageBox.Show("Status successfully changed.", "Status Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void subscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectForm = new Confirmation();
            projectForm.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void manageSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Subscription();
            newForm.Show();
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userName = Entry.userName;
            string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter a new username", "Username Change", userName);
            Entry.userLogin[userName] = newName;
            Entry.userLogin.Property(userName).Remove();
            User.JsonUpdate(Entry.userFile, Entry.userLogin);
            File.Move(User.userFile, String.Format(@"..\..\Data\Users\{0}.json", newName));
            User.userFile = newName;
            MessageBox.Show("Username successfully changed.", "Username Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(OpenFile.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }
    }
}