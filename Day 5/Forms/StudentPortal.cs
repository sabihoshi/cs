using CIIT_Grading_System.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UserData;

namespace CIIT_Grading_System.Forms
{
    public partial class StudentPortal : Form
    {
        public StudentPortal()
        {
            InitializeComponent();
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            Login.User.CreateUser(Login.userName);
            WebBrowser.Url = new Uri(@"file:\\\" + Path.GetFullPath(@"..\..\Resources\default.html"));
            foreach (dynamic item in Login.User.userData.Classrooms.Select(c => c.Name))
            {
                string output = item;
                ClassroomList.Items.Add(output);
            }
        }

        private void ClassroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentList.Items.Clear();
            foreach (dynamic item in Login.User.userData.Classrooms.FirstOrDefault(c => c.Name.Equals(ClassroomList.Text)).Students.Select(s => s.Name))
            {
                string output = item;
                StudentList.Items.Add(output);
            }
            StudentList.SelectedIndex = 0;
            StudentList.Enabled = true;
        }

        public string itemName;
        public int itemTotal, itemScore;

        public string CalculateGrade(string classroomName, string studentName)
        {
            var Grade = new GradeTemplate();
            Classroom classroom = Login.User.userData.GetClassroom(ClassroomList.Text);
            Student student = classroom.GetStudent(StudentList.Text);

            foreach (Graded item in student.Lecture.Exams)
            {
                Grade.Lectures.Exams.Total += item.Total;
                Grade.Lectures.Exams.Score += item.Score;
                if (item.Score > 0)
                    Grade.Lectures.Attendance.Score += 2;
                Grade.Lectures.Attendance.Total += 2;
                Grade.Table.Lectures.Add(new List<string> { item.Name.ToString(), $"{item.Total}/{item.Score}", "+2" });
            }
            Grade.Lectures.Exams.Percentage = (100 / Grade.Lectures.Exams.Total) * Grade.Lectures.Exams.Score;
            Grade.Lectures.Percentage += (Grade.Lectures.Exams.Percentage * 75) / 100;

            foreach (Graded item in student.Laboratory)
            {
                Grade.Laboratory.Total += item.Total;
                Grade.Laboratory.Score += item.Score;
                if (item.Score > 0)
                    Grade.Lectures.Attendance.Score += 2;
                Grade.Lectures.Attendance.Total += 2;
                Grade.Table.Laboratory.Add(new List<string> { item.Name.ToString(), $"{item.Total}/{item.Score}", "+2" });
            }
            Grade.Laboratory.Percentage = (100 / Grade.Laboratory.Total) * Grade.Laboratory.Score;

            Grade.HandsOn.Communication.Total += student.HandsOn.Communication;
            Grade.HandsOn.Communication.Percentage = (100 / Grade.HandsOn.Communication.Total) * Grade.HandsOn.Communication.Score;
            if (student.HandsOn.Communication > 0)
                Grade.Lectures.Attendance.Score += 2;
            Grade.Lectures.Attendance.Total += 2;
            Grade.Table.HandsOn.Add(new List<string> { "Communication", $"{student.HandsOn.Communication:0.00}%", "+2" });

            Grade.HandsOn.Teamwork.Total += student.HandsOn.Teamwork;
            Grade.HandsOn.Teamwork.Percentage = (100 / Grade.HandsOn.Teamwork.Total) * Grade.HandsOn.Teamwork.Score;
            if (student.HandsOn.Teamwork > 0)
                Grade.Lectures.Attendance.Score += 2;
            Grade.Lectures.Attendance.Total += 2;
            Grade.Table.HandsOn.Add(new List<string> { "Teamwork", $"{student.HandsOn.Teamwork:0.00}%", "+2" });

            Grade.Table.Lectures.Add(new List<string> { "Recitation", $"+{Grade.Lectures.Recitation.Score}" });
            Grade.Lectures.Attendance.Percentage = (100 / Grade.Lectures.Attendance.Total) * Grade.Lectures.Attendance.Score;
            Grade.Lectures.Percentage += (Grade.Lectures.Attendance.Percentage * 15) / 100;

            List<List<string>> tableList = Grade.Table.Lectures.Count > Grade.Table.Laboratory.Count ? Grade.Table.Lectures : Grade.Table.Laboratory;
            List<List<string>> lower = Grade.Table.Lectures.Count < Grade.Table.Laboratory.Count ? Grade.Table.Lectures : Grade.Table.Laboratory;

            for (int i = 0; i < lower.Count; i++)
            {
                tableList[i].AddRange(lower[i]);
            }
            for (int i = 0; i < Grade.Table.HandsOn.Count; i++)
            {
                tableList[i].AddRange(Grade.Table.HandsOn[i]);
            }

            var tableOutput = new List<string> {
                "|__Lectures__|__________|_____|__Laboratories__|__________|_____|__Hands-on__|__________|_____|",
                "|--:|:-:|:-:|--:|:--|:-:|--:|:-:|:-:|"
            };
            foreach (List<string> item in tableList)
            {
                if (item.Count < 9)
                {
                    int c = 9 - item.Count;
                    for (int i = 0; i < c; i++)
                        item.Add(" ");
                }
                tableOutput.Add($"|{String.Join("|", item)}|");
            }
            string buffer =
                $"# {Login.userName}'s Report Card\n" +
                $"## Final Grade: 96.66%\n" +
                $"\n" +
                $"{String.Join("\r\n", tableOutput)}"
            ;
            return buffer;
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.User.userData.CreateClassroom(Microsoft.VisualBasic.Interaction.InputBox("Enter a new classroom name", "Create new classroom", "Class #"));
            Login.User.JsonUpdate(Login.User.userFile, Login.User.userData);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectForm = new AddStudents();
            projectForm.ShowDialog();
        }

        private void manageGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectForm = new EditGrade();
            projectForm.ShowDialog();
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userName = Login.userName;
            string newName = Microsoft.VisualBasic.Interaction.InputBox("Enter a new username", "Username Change", userName);
            Login.userLogin.User.FirstOrDefault(u => u.Username == userName).Username = newName;
            // Login.userLogin.User.
            // Login.User.JsonUpdate(Login.userFile, Login.userLogin);
            File.Move(Login.User.userFile, String.Format(@"..\..\Data\Users\{0}.json", newName));
            Login.User.userFile = newName;
            MessageBox.Show("Username successfully changed.", "Username Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userPass = Login.userPass;
            // Login.userLogin[Login.userName] = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Password Change", userPass);
            MessageBox.Show("Password successfully changed.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login.User.JsonUpdate(Login.userFile, Login.userLogin);
        }

        private void changeAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userAvatar = Login.User.userData.Avatar.ToString();
            Uri newAvatar;
            if (Login.User.userData.Avatar == null)
                userAvatar = "Enter an avatar...";
            newAvatar = new System.Uri(Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Avatar Change", userAvatar));
            Login.User.userData.Avatar = newAvatar;
            Login.User.JsonUpdate(Login.User.userFile, Login.User.userData);
            MessageBox.Show("Avatar successfully changed.", "Avatar Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userStatus = Login.User.userData.Status;
            string newStatus;
            if (Login.User.userData.Status == null)
                userStatus = "Enter a status...";
            newStatus = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Status Change", userStatus);
            Login.User.userData.Status = newStatus;
            Login.User.JsonUpdate(Login.User.userFile, Login.User.userData);
            MessageBox.Show("Status successfully changed.", "Status Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login.userLogin[Login.userName].
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buffer = CalculateGrade(ClassroomList.Text, StudentList.Text);
            Console.WriteLine(buffer);
            string fileName = String.Format(@"..\..\Data\Users\{0}_grade.html", Login.userName);
            string htmlName = @"file:\\\" + Path.GetFullPath(fileName);
            using (StreamWriter file = File.CreateText(fileName))
            {
                file.Write(@"<body background='../../Resources/empty_browser.png'><meta name='viewport' content='width=device-width, initial-scale=1'><link rel='stylesheet' href='../../Resources/github-markdown.css'><style>.markdown-body{box-sizing:border-box;min-width:200px;max-width:980px;margin:0 auto;padding:45px}@media (max-width:767px){.markdown-body{padding:15px}}</style><article class='markdown-body'>");
                file.Write(Markdig.Markdown.ToHtml(buffer, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build()));
                file.Write(@"</article></body>");
                file.Close();
            }
            Login.User.userData.Recent = fileName;
            Login.User.JsonUpdate(Login.User.userFile, Login.User.userData);
            WebBrowser.Url = new System.Uri(htmlName);
        }
    }
}