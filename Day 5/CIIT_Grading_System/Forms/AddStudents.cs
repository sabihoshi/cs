using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIIT_Grading_System.Forms
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        public User User = new User();

        private void AddStudents_Load(object sender, EventArgs e)
        {
            User.CreateUser(Login.userName);
            foreach (var item in User.userData.Classrooms)
            {
            }
        }
    }
}