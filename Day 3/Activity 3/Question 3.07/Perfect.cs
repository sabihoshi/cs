using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Question_3._07
{
    public partial class Perfect : Form
    {
        public Perfect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter x", "Perfect Numbers", "6"));
            int x = 0;
            bool IsPerfect = false;
            var sums = new List<int>();
            for (int i = y; i <= y; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sums.Add(j);
                    x = sums.Sum();
                    if (x == i)
                        IsPerfect = true;
                }
            }
            MessageBox.Show(String.Format(IsPerfect == true ? "Is {0} Perfect: Yes\n" + string.Join(" + ", sums) : "Is {0} Perfect: No", y), "Perfect Numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}