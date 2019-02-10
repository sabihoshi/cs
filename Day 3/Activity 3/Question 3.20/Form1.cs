using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Question_3_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = Microsoft.VisualBasic.Interaction.InputBox("Enter word", "Letter Count", "1").ToCharArray();
            var list = new List<char>();
            var listCount = new List<int>();
            foreach (char s in input)
            {
                char temp = Char.ToLower(s);
                if (list.IndexOf(temp) == -1)
                {
                    list.Add(temp);
                    listCount.Add(1);
                }
                else
                    listCount[list.IndexOf(temp)] += 1;
            }
            string output = "";
            for (int i = 0; i < list.Count; i++)
            {
                output += String.Format("{0}\t-\t{1}\n", list[i], listCount[i]);
            }
            MessageBox.Show(output, "Letter Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}