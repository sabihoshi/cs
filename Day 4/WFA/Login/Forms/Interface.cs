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

        private static void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private User User = new User();

        private void Interface_Load(object sender, EventArgs e)
        {
            User.CreateUser(Entry.userName);
            WebClient wc = new WebClient();
            try
            {
                byte[] bytes = wc.DownloadData(User.userData.Avatar);
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
            // Entry.userLogin.TryGetValue(Entry.userName, out var temp);
            // string userPass = temp[0].ToString();
            // LineChanger(
            //         String.Format(
            //             "{0} {1}",
            //             Entry.userName,
            //             Microsoft.VisualBasic.Interaction.InputBox("Enter a new / password", /"Password Change", userPass)
            //         ),
            //         Entry.file,
            //         Convert.ToInt32(temp[1])
            // );
            // MessageBox.Show("Password successfully changed.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StatusBox_TextChanged(object sender, EventArgs e)
        {
            User.userData.Status = StatusBox.Text;
            using (StreamWriter file = File.CreateText(User.fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, User.userData);
            }
        }

        private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userStatus = User.userData.Status;
            if (User.userData.Status == null)
                userStatus = "Enter a status...";
            User.userData.Status = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Status Change", User.userData.Status);
            MessageBox.Show("Status successfully changed.", "Status Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void subscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var projectForm = new Entry();
            projectForm.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void manageSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Project();
            newForm.Show();
        }
    }
}