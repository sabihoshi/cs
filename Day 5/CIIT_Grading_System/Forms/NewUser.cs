using System;
using System.IO;
using System.Windows.Forms;

namespace CIIT_Grading_System.Forms
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private User User = new User();

        private void LoginStart_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || UserPass.Text == "")
            {
                if (MessageBox.Show("Please enter a valid username or Password!", "Create user", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    this.Hide();
            }
            else if (UserPass.Text != UserPassCheck.Text)
            {
                if (MessageBox.Show("Password does not match!", "Create user", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    this.Hide();
            }
            else

            {
                string fileName = String.Format(@"../../Data/Users/{0}.json", UserName.Text);
                using (StreamWriter file = File.CreateText(fileName))
                {
                    file.WriteLine("{");
                    file.WriteLine("}");
                    file.Close();
                }
                Login.userLogin[UserName.Text] = UserPass.Text;
                User.JsonUpdate(Login.userFile, Login.userLogin);
                MessageBox.Show("User was created.", "Create user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}