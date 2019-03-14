using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._13
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] num = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
			int x = Convert.ToInt32(Interaction.InputBox("Enter x", "Reverse Numbers to Words", "1"));
			int last, temp = 0;
			while (x > 0)
			{
				last = x % 10;
				temp = temp * 10 + last;
				x = x / 10;
			}

			IEnumerable<int> res = Convert.ToString(temp).Select(digit => int.Parse(digit.ToString()));
			var output = new List<string>();
			foreach (int i in res) output.Add(num[i]);
			MessageBox.Show(string.Format("Result: {0}", string.Join(" ", output)), @"Reverse Numbers to Words",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}