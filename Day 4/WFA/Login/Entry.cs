using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void LoginStart_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Kao" && UserPass.Text == "Kao")
            {
                this.Hide();
                var projectForm = new Project();
                projectForm.ShowDialog();
            }
        }
    }
}