using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Question_3._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Pow(int x, int y)
        {
            int res = 1;
            for (int i = 1; i <= y; i++)
            {
                res *= x;
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Please input n", "Power Series", "1"));
            var numbers = new List<string>();
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += Pow(i, i);
                numbers.Add(String.Format("{0}^{0}", i));
            }
            MessageBox.Show(String.Format("Result: {0} = {1}", String.Join(" + ", numbers), sum), "Power Series", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}