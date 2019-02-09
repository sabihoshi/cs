using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Question_3._08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Please input n", "Sum Series", "1"));
            var numbers = new List<int>();
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
                numbers.Add(i);
            }
            MessageBox.Show(String.Format("Result: {0} = {1}", String.Join(" + ", numbers), sum), "Sum Series", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}