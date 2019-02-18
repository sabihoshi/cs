using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Login
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        public static string userName, userPass;
        public static Dictionary<string, List<string>> userLogin = new Dictionary<string, List<string>>();
        public static string file = @"C:\Users\Kao\source\repos\cs\Day 4\WFA\Login\Data\userLogin.txt";

        private void Entry_Load(object sender, EventArgs e)
        {
            userLogin = new Dictionary<string, List<string>>();
            var buffer = File.ReadAllLines(file).ToList();
            string[] temp;
            for (int i = 0; i < buffer.Count; i++)
            {
                temp = buffer[i].Split(' ');
                userLogin.Add(temp[0], new List<string> { temp[1], i.ToString() });
            }
        }

        private void LoginFail()
        {
            MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginStart_Click(object sender, EventArgs e)
        {
            userName = UserName.Text;
            if (userLogin.TryGetValue(userName, out var temp))
            {
                string userPass = temp[0].ToString();
                if (UserPass.Text == userPass)
                {
                    this.Hide();
                    var projectForm = new Interface();
                    projectForm.ShowDialog();
                }
                else
                    LoginFail();
            }
            else
                LoginFail();
        }
    }
}