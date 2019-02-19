using Newtonsoft.Json;
using System;
using System.IO;
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

        // public static Dictionary<string, List<string>> userLogin = new Dictionary<string, List<string>>();

        public static string fileName = @"..\..\Data\userLogin.json";
        public dynamic userLogin;

        private void Entry_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                userLogin = JsonConvert.DeserializeObject(json);
                foreach (var item in userLogin)
                {
                    Console.WriteLine("{0}", item);
                }
            }
            // userLogin = new Dictionary<string, List<string>>();
            // var buffer = File.ReadAllLines(file).ToList();
            // string[] temp;
            // for (int i = 0; i < buffer.Count; i++)
            // {
            //     temp = buffer[i].Split(' ');
            //     userLogin.Add(temp[0], new List<string> { temp[1], i.ToString() });
            // }
        }

        private void LoginStart_Click(object sender, EventArgs e)
        {
            userName = UserName.Text;
            userPass = userLogin[userName];

            if (UserPass.Text == userPass)
            {
                this.Hide();
                var projectForm = new Interface();
                projectForm.ShowDialog();
            }
            else
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}