using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._08
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Interaction.InputBox("Please input n", "Sum Series", "1"));
			var numbers = new List<int>();
			var sum = 0;
			for (var i = 1; i <= x; i++)
			{
				sum += i;
				numbers.Add(i);
			}

			MessageBox.Show(string.Format("Result: {0} = {1}", string.Join(" + ", numbers), sum), @"Sum Series",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}