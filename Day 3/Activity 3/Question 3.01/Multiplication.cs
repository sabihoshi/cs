using System;
using System.Windows.Forms;

namespace Question_3._01
{
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input x", "Multiplication", "0"));
            int y = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input y", "Multiplication", "0"));
            int result = 0;
            for (int i = 0; i < y; i++)
            {
                result += x;
            }
            MessageBox.Show("Answer: " + result, "Multiplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}