using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._09
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Interaction.InputBox("Please input n", "Square Series", "1"));
			var numbers = new List<string>();
			var sum = 0;
			for (var i = 1; i <= x; i++)
			{
				sum += i * i;
				numbers.Add(string.Format("{0}²", i));
			}

			MessageBox.Show(string.Format("Result: {0} = {1}", string.Join(" + ", numbers), sum), @"Square Series",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}