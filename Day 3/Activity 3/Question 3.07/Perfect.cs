using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._07
{
	public partial class Perfect : Form
	{
		public Perfect()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int y = Convert.ToInt32(Interaction.InputBox("Enter x", "Perfect Numbers", "6"));
			var x = 0;
			var IsPerfect = false;
			var sums = new List<int>();
			for (int i = y; i <= y; i++)
			for (var j = 1; j < i; j++)
			{
				if (i % j == 0)
					sums.Add(j);
				x = sums.Sum();
				if (x == i)
					IsPerfect = true;
			}

			MessageBox.Show(
				string.Format(IsPerfect ? "Is {0} Perfect: Yes\n" + string.Join(" + ", sums) : "Is {0} Perfect: No", y),
				@"Perfect Numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}