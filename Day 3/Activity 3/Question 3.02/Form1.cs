using System;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Question_3._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input x", "Multiplication", "0"));
            int y = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input y", "Multiplication", "0"));
            int type = 1;
            if ((x < 0 && y > 0) || (y < 0 && x > 0))
                type = 0;
            if (x < 0)
                x = x * -1;
            if (y < 0)
                y = y * -1;
            int result = 0;
            for (int i = 0; i < y; i++)
            {
                result += x;
            }
            if (type == 0)
                MessageBox.Show("Answer: -" + result, "Multiplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Answer: " + result, "Multiplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}