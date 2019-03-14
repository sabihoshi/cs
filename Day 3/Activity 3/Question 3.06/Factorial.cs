using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._06
{
	public partial class Question_6 : Form
	{
		public Question_6()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ulong x = Convert.ToUInt64(Interaction.InputBox("Enter x!", "Factorial", "1"));
			ulong res = 1;
			for (ulong i = 1; i <= x; i++) res *= i;
			MessageBox.Show(string.Format("Result: {0:n0}", res), @"Factorial", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}