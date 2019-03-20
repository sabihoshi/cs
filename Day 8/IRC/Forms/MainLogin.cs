using IRC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        public void ButtonHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(88, 107, 171);
        }

        public void ButtonLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newAccount = new NewAccount();
            newAccount.Show();
        }
    }
}