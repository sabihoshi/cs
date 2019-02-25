using System;
using System.Windows.Forms;

namespace Question_3._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] input = Microsoft.VisualBasic.Interaction.InputBox("Enter word", "Encryption", "1").ToCharArray();
            string output = "";
            char[] encryption = { '!', '"', '#', '$', '%', '&', '\'', '(', ')', ',', '.', '~', '}', '|', '[', '\\', ']', '^', '_', ':', ';', '<', '=', '>', '?', '@' };
            foreach (char s in input)
            {
                int temp = Convert.ToInt32(Char.ToLower(s)) - 97;
                output += Convert.ToString(encryption[temp]);
            }
            MessageBox.Show(output, "Encryption", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}