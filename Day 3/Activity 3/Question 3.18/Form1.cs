using System;
using System.Windows.Forms;

namespace Question_3._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] input = Microsoft.VisualBasic.Interaction.InputBox("Enter words (can be multiple)", "Plural", "1").Split(' ');
            string word = null;
            for (int i = 0; i < input.Length; i++)
            {
                word = input[i];
                switch (word[word.Length - 1])
                {
                    case 'y':
                        word = word.Remove(word.Length - 1);
                        word += "ies";
                        break;

                    case 's':
                        word += "es";
                        break;

                    default:
                        if (word.Substring(word.Length - 2) == "ch" || word.Substring(word.Length - 2) == "sh")
                            word += "es";
                        else
                            word += 's';
                        break;
                }
                input[i] = word;
            }

            MessageBox.Show(String.Join(" ", input), "Plural", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}