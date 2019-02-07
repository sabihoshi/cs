using System;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Question_3._06
{
    public partial class Question_6 : Form
    {
        public Question_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong x = Convert.ToUInt64(Microsoft.VisualBasic.Interaction.InputBox("Enter x!", "Factorial", "1"));
            ulong res = 1;
            for (ulong i = 1; i <= x; i++)
            {
                res *= i;
            }
            MessageBox.Show(String.Format("Result: {0:n0}", res), "Factorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}