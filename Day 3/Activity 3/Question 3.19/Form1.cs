using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._19
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			char[] input = Interaction.InputBox("Enter word", "Encryption", "1").ToCharArray();
			var output = "";
			char[] encryption =
			{
				'!', '"', '#', '$', '%', '&', '\'', '(', ')', ',', '.', '~', '}', '|', '[', '\\', ']', '^', '_', ':',
				';', '<', '=', '>', '?', '@'
			};
			foreach (char s in input)
			{
				int temp = Convert.ToInt32(char.ToLower(s)) - 97;
				output += Convert.ToString(encryption[temp]);
			}

			MessageBox.Show(output, @"Encryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}