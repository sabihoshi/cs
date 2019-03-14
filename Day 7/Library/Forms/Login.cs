using System;
using System.Linq;
using System.Windows.Forms;
using Library.Classes;
using Newtonsoft.Json;

namespace Library.Forms
{
	public partial class Login : Form
	{
		public static RootUsers Authentication = new RootUsers();

		public static string userName, userPass;

		public static Interface newForm = new Interface();
		public int curTick = 0;

		public int maxTick = 0;

		public Login()
		{
			InitializeComponent();
		}

		private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var newForm = new NewUser();
			newForm.Show();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			Timer.Enabled = false;
			ProgressBar.Value = 0;
			ProgressBar.Visible = false;
			Authentication = JsonConvert.DeserializeObject<RootUsers>(Manager.ReadFile(@"./Data/login.json"));
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			ProgressBar.PerformStep();
			if (ProgressBar.Value >= 100)
			{
				Timer.Enabled = false;
				Hide();
				newForm.ShowDialog();
			}
		}

		private void UserLogin_Click(object sender, EventArgs e)
		{
			if (Authentication.Users.SingleOrDefault(u => u.Username == UserName.Text) != null)
			{
				userName = UserName.Text;
				userPass = Authentication.Users.SingleOrDefault(u => u.Username == userName).Password;
				if (PassWord.Text == userPass)
				{
					ProgressBar.Visible = true;
					Timer.Enabled = true;
					return;
				}
			}

			MessageBox.Show(@"Wrong Username or Password!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}