using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public int Pow(int x, int y)
		{
			var res = 1;
			for (var i = 1; i <= y; i++) res *= x;
			return res;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt32(Interaction.InputBox("Please input n", "Power Series", "1"));
			var numbers = new List<string>();
			var sum = 0;
			for (var i = 1; i <= x; i++)
			{
				sum += Pow(i, i);
				numbers.Add(string.Format("{0}^{0}", i));
			}

			MessageBox.Show(string.Format("Result: {0} = {1}", string.Join(" + ", numbers), sum), @"Power Series",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}