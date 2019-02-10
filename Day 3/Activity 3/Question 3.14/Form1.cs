using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Question_3._14
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
            var x = Microsoft.VisualBasic.Interaction.InputBox("Enter x", "Numbers to Words", "1");
            var numbers = x.Select(digit => int.Parse(digit.ToString()));
            int res = 0;
            foreach (int i in numbers)
            {
                res += i;
            }
            MessageBox.Show(String.Format("Result: {0}", res), "Sum in Digits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}