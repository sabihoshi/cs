using System;
using System.Windows.Forms;

namespace Question_3._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] input = Microsoft.VisualBasic.Interaction.InputBox("Enter x", "Numbers to Words", "1").ToCharArray();
            MessageBox.Show(String.Format("{0}", String.Join("\n", input)), "Split String", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}