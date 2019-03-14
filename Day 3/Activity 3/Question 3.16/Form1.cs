using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._16
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] input = Interaction.InputBox("Enter x", "Numbers to Words", "1").Split(' ');
			MessageBox.Show(string.Format("{0}", string.Join("\n", input)), @"Split String", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}