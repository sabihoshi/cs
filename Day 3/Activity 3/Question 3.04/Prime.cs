using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Question_3._04
{
	public partial class Prime : Form
	{
		public Prime()
		{
			InitializeComponent();
		}

		public static bool IsPrime(int number)
		{
			if (number <= 1) return false;
			if (number == 2) return true;
			if (number % 2 == 0) return false;

			var boundary = (int) Math.Floor(Math.Sqrt(number));

			for (var i = 3; i <= boundary; i += 2)
				if (number % i == 0)
					return false;

			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int start = Convert.ToInt32(Interaction.InputBox("Input x", "Division", "0"));
			int end = Convert.ToInt32(Interaction.InputBox("Input y", "Division", "1"));
			var result = 0;
			for (int i = start; i < end; i++)
				if (IsPrime(i))
					result += i;
			MessageBox.Show("Answer: " + result, @"Division", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void helloWorldLabel_Click(object sender, EventArgs e)
		{
		}
	}
}