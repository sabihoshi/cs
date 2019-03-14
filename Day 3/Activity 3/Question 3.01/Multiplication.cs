using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._01
{
	public partial class Multiplication : Form
	{
		public Multiplication()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Interaction.InputBox("Input x", "Multiplication", "0"));
			int y = Convert.ToInt32(Interaction.InputBox("Input y", "Multiplication", "0"));
			var result = 0;
			for (var i = 0; i < y; i++) result += x;
			MessageBox.Show("Answer: " + result, @"Multiplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}