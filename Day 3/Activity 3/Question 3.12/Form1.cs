using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._12
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
			string x = Interaction.InputBox("Enter x", "Numbers to Words", "1");
			IEnumerable<int> res = x.Select(digit => int.Parse(digit.ToString()));
			var output = new List<string>();
			foreach (int i in res) output.Add(num[i]);
			MessageBox.Show(string.Format("Result: {0}", string.Join(" ", output)), @"Reverse", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}