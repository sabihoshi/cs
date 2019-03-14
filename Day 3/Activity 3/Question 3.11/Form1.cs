using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Interaction.InputBox("Enter x", "Reverse", "1"));
			int last, res = 0;
			while (x > 0)
			{
				last = x % 10;
				res = res * 10 + last;
				x = x / 10;
			}

			MessageBox.Show("Result: " + res, @"Reverse", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}