using System;
using System.Windows.Forms;

namespace Question_3._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] num = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var temp = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter x", "Palindrome", "1"));
            var x = temp;
            int last, curr = 0;
            while (temp > 0)
            {
                last = temp % 10;
                curr = (curr * 10) + last;
                temp = temp / 10;
            }
            var y = curr;
            MessageBox.Show(String.Format("{0} is {1}", x, x == y ? "a palindrome" : "not a palindrome"), "Palindrome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}