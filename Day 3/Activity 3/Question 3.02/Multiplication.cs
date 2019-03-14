using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._02
{
	public partial class Multiplication : Form
	{
		public Multiplication()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Interaction.InputBox("Input x", "Multiplication", "0"));
			int y = Convert.ToInt32(Interaction.InputBox("Input y", "Multiplication", "0"));
			var type = 1;
			if (x < 0 && y >= 0 || y < 0 && x >= 0)
				type = 0;
			if (x < 0)
				x = x * -1;
			if (y < 0)
				y = y * -1;
			var result = 0;
			for (var i = 0; i < y; i++) result += x;
			if (type == 0)
				MessageBox.Show("Answer: -" + result, @"Multiplication", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			else
				MessageBox.Show("Answer: " + result, @"Multiplication", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
		}
	}
}