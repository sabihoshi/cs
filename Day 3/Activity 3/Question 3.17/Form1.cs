using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._17
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			char[] input = Interaction.InputBox("Enter x", "Numbers to Words", "1").ToCharArray();
			MessageBox.Show(string.Format("{0}", string.Join("\n", input)), @"Split String", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}