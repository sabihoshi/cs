using System;
using System.IO;
using System.Windows.Forms;

namespace Login
{
	public partial class NewUser : Form
	{
		public User User = new User();

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
				string fileName = string.Format(@"../../Data/Users/{0}.json", UserName.Text);
				using (StreamWriter file = File.CreateText(fileName))
				{
					file.WriteLine("{");
					file.WriteLine("}");
					file.Close();
				}

				Entry.userLogin[UserName.Text] = UserPass.Text;
				User.JsonUpdate(Entry.userFile, Entry.userLogin);
				MessageBox.Show(@"User was created.", @"Create user", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}
	}
}