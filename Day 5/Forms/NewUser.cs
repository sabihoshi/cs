using System;
using System.Windows.Forms;
using CIIT_Grading_System.Classes;
using UserData;

namespace CIIT_Grading_System.Forms
{
	public partial class NewUser : Form
	{
		public NewUser()
		{
			InitializeComponent();
		}

		private void LoginStart_Click(object sender, EventArgs e)
		{
			if (UserName.Text == "" || UserPass.Text == "")
			{
				if (MessageBox.Show(@"Please enter a valid username or Password!", @"Create user",
					    MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
					Hide();
			}
			else if (UserPass.Text != UserPassCheck.Text)
			{
				if (MessageBox.Show(@"Password does not match!", @"Create user", MessageBoxButtons.OKCancel,
					    MessageBoxIcon.Error) == DialogResult.Cancel)
					Hide();
			}
			else
			{
				Login.User.JsonUpdate($@"../../Data/Users/{UserName.Text}.json", new Data());
				Login.userLogin.User.Add(new UserLogin(UserName.Text, UserPass.Text));
				Login.User.JsonUpdate(Login.userFile, Login.userLogin);
				MessageBox.Show(@"User was created.", @"Create user", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}
	}
}