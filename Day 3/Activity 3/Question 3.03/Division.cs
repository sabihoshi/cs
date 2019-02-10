using System;
using System.Windows.Forms;

namespace Question_3._03
{
    public partial class Division : Form
    {
        public Division()
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