using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Markdig;
using Microsoft.VisualBasic;

namespace Login
{
	public partial class Interface : Form
	{
		private readonly User User = new User();

		public Interface()
		{
			InitializeComponent();
		}

		private void Interface_Load(object sender, EventArgs e)
		{
			User.CreateUser(Entry.userName);
			var wc = new WebClient();
			try
			{
				byte[] bytes = wc.DownloadData(User.userData.Avatar.ToString());
				var ms = new MemoryStream(bytes);
				Image img = Image.FromStream(ms);
				Avatar.Image = img;
			}
			catch (Exception)
			{
			}

			string userStatus = User.userData.Status;
			if (userStatus != null)
			{
				if (userStatus == "")
					userStatus = "Enter status...";
				BioBox.Text = userStatus;
			}
			else
			{
				BioBox.Text = "Enter status...";
			}

			if (User.userData.Recent != null)
				WebBrowser.Url = new Uri(Path.GetFullPath(User.userData.Recent.ToString()));
			WelcomeText.Text = string.Format("Welcome back, {0}!", Entry.userName);
		}

		private void BioBox_TextChanged(object sender, EventArgs e)
		{
			User.userData.Status = BioBox.Text;
			User.JsonUpdate(User.userFile, User.userData);
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var buffer = "";
			var fileName = "";
			var htmlName = "";
			if (OpenFile.ShowDialog() == DialogResult.OK)
			{
				var sr = new
					StreamReader(OpenFile.FileName);
				fileName = OpenFile.SafeFileName;
				buffer = sr.ReadToEnd();
				sr.Close();
			}

			fileName = string.Format(@"..\..\Data\Users\{0}_{1}", Entry.userName, fileName);
			htmlName = @"file:///" + Path.GetFullPath(fileName);
			using (StreamWriter file = File.CreateText(fileName))
			{
				file.Write("<body background = \"{0}\">", Path.GetFullPath(@"..\..\Resources\background.png"));
				file.Write(Markdown.ToHtml(buffer));
				file.Write(@"</body>");
				file.Close();
			}

			User.userData.Recent = @"..\..\Data\Users" + fileName;
			User.JsonUpdate(User.userFile, User.userData);
			WebBrowser.Url = new Uri(htmlName);
		}

		private void subscriptionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var projectForm = new Confirmation();
			projectForm.ShowDialog();
		}

		private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string userStatus = User.userData.Status;
			string newStatus;
			if (User.userData.Status == null)
				userStatus = "Enter a status...";
			newStatus = Interaction.InputBox("Enter a new password", "Status Change", userStatus);
			User.userData.Status = newStatus;
			BioBox.Text = newStatus;
			User.JsonUpdate(User.userFile, User.userData);
			MessageBox.Show(@"Status successfully changed.", @"Status Change", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string userName = Entry.userName;
			string newName = Interaction.InputBox("Enter a new username", "Username Change", userName);
			Entry.userLogin[userName] = newName;
			Entry.userLogin.Property(userName).Remove();
			User.JsonUpdate(Entry.userFile, Entry.userLogin);
			File.Move(User.userFile, string.Format(@"..\..\Data\Users\{0}.json", newName));
			User.userFile = newName;
			MessageBox.Show(@"Username successfully changed.", @"Username Change", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string userPass = Entry.userPass;
			Entry.userLogin[Entry.userName] = Interaction.InputBox("Enter a new password", "Password Change", userPass);
			MessageBox.Show(@"Password successfully changed.", @"Password Change", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			User.JsonUpdate(Entry.userFile, Entry.userLogin);
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
			var newForm = new Entry();
			newForm.Show();
		}
	}
}