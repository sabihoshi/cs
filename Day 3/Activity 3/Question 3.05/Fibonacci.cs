using System;
using System.Windows.Forms;

namespace Question_3._05
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l, o, x = 1, y = 0;
            string a = "";
            l = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input length", "Prime Numbers", "1"));
            for (int i = 2; i < l; i++)
            {
                a += x + ", ";
                o = x + y;
                y = x;
                x = o;
            }
            o = x + y;
            y = x;
            x = o;
            a += y + ", " + x;
            MessageBox.Show("Answer: " + a, "Prime Numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}