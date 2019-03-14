using System;
using System.Linq;
using System.Windows.Forms;

namespace Quiz.Forms
{
	public partial class Results : Form
	{
		public Results()
		{
			InitializeComponent();
		}

		private void Results_Load(object sender, EventArgs e)
		{
			Total.Text = Answer.pageMax.ToString();
			Score.Text = Answer.Quiz.Questions.Where((q, i) => q.Correct == Answer.answers[i]).Count().ToString();
			TimeElapsed.Text = (DateTime.Now - Answer.start).ToString(@"mm\:ss");
		}

		private void YEHEY_Click(object sender, EventArgs e)
		{
			Date.Text = DateTime.Now.ToString();
			NameOutput.Text = NameInput.Text;
			SS.Show();
			YEHEY.Hide();
		}

		private void Restart_Click(object sender, EventArgs e)
		{
			var newForm = new Answer();
			newForm.Show();
			Hide();
		}
	}
}