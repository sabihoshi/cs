using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Login
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private static bool LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
            return true;
        }

        private User User = new User();

        private void Interface_Load(object sender, EventArgs e)
        {
            User.CreateUser(Entry.userName);
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(User.userData["avatar"]);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            Avatar.Image = img;
            if (User.userData.TryGetValue("status", out string userStatus))
                StatusBox.Text = userStatus;
            else
                StatusBox.Text = "Enter status...";
            WelcomeText.Text = String.Format("Welcome back, {0}!", Entry.userName);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry.userLogin.TryGetValue(Entry.userName, out var temp);
            string userPass = temp[0].ToString();
            string newPass = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Password Change", userPass);
            if (LineChanger(String.Format("{0} {1}", Entry.userName, newPass), Entry.file, Convert.ToInt32(temp[1])))
            {
                MessageBox.Show("Password successfully changed.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StatusBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry.userLogin.TryGetValue(User.userData["status"], out var temp);
            string userStatus = temp[0].ToString();
            string newStatus = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Status Change", userStatus);
            if (LineChanger(String.Format("{0} {1}", Entry.userName, newStatus), Entry.file, Convert.ToInt32(temp[1])))
            {
                MessageBox.Show("Password successfully changed.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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