using CIIT_Grading_System.Classes;
using System;
using System.Linq;
using System.Windows.Forms;
using UserData;

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
            foreach (string item in User.userData.Classrooms.Select(c => c.Name))
            {
                ClassroomList.Items.Add(item);
            }
        }

        private void ClassroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserData.Classroom classroom = User.userData.Classrooms.FirstOrDefault(c => c.Name.Equals(ClassroomList.SelectedItem));
            StudentList.Items.Clear();
            StudentList.Enabled = true;
            foreach (string item in classroom.Students.Select(s => s.Name))
            {
                StudentList.Items.Add(item);
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            if (StudentName.Text == "")
                return;
            UserData.Classroom classroom = User.userData.Classrooms.FirstOrDefault(c => c.Name.Equals(ClassroomList.SelectedItem));
            if (classroom == null)
            {
                MessageBox.Show("Invalid classroom!", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Student = new Student(StudentName.Text);
                StudentList.Items.Add(Student);
                User.JsonUpdate(User.userFile, User.userData);
            }
        }
    }
}