using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Question_3._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input x", "Division", "0"));
            int temp = x;
            int y = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input y", "Division", "1"));
            int result = 0;
            while (x >= y)
            {
                result++;
                x -= y;
            }
            int remainder = temp - (result * y);
            MessageBox.Show("Answer: " + result + "\nRemainder: " + remainder, "Division", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}