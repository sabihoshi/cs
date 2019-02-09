using System;
using System.Collections.Generic;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Question_3._09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Please input n", "Square Series", "1"));
            var numbers = new List<string>();
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += (i * i);
                numbers.Add(String.Format("{0}²", i));
            }
            MessageBox.Show(String.Format("Result: {0} = {1}", String.Join(" + ", numbers), sum), "Square Series", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}