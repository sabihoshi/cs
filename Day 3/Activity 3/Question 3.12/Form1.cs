using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            string[] num = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string x = Microsoft.VisualBasic.Interaction.InputBox("Enter x", "Numbers to Words", "1");
            var res = x.Select(digit => int.Parse(digit.ToString()));
            var output = new List<string>();
            foreach (int i in res)
            {
                output.Add(num[i]);
            }
            MessageBox.Show(String.Format("Result: {0}", String.Join(" ", output)), "Reverse", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}