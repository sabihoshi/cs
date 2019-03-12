using CIIT_Grading_System.Classes;
using Markdig;
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

        public void UpdateClasses()
        {
            ClassroomList.Items.Clear();
            foreach (var item in Login.User.userData.Classrooms.Select(c => c.Name))
            {
                string output = item;
                ClassroomList.Items.Add(output);
            }
        }

        public void UpdateStudents()
        {
            var Classroom = Login.User.userData.Classrooms.FirstOrDefault(c => c.Name.Equals(ClassroomList.Text));
            if (Classroom.Students == null)
                StudentList.Enabled = false;
            else
            {
                StudentList.Items.Clear();
                foreach (var item in Classroom.Students.Select(s => s.Name))
                {
                    string output = item;
                    StudentList.Items.Add(output);
                }
                StudentList.Enabled = true;
            }
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            Login.User.CreateUser(Login.userName);
            WebBrowser.Url = new Uri(@"file:\\\" + Path.GetFullPath(@"..\..\Resources\default.html"));
            if (Login.User.userData.Classrooms == null)
                Login.User.userData.Classrooms = new List<Classroom>();
            UpdateClasses();
        }

        private void ClassroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentList.Items.Clear();
        }

        public double finalGrade = 0;

        public string CalculateGrade(string classroomName, string studentName, string termName)
        {
            var Grade = new GradeTemplate();

            double CalculatePercentage(GradeTemplate.Recorded component)
            {
                return 100 / component.Total * component.Score;
            }

            Classroom classroom = Login.User.userData.GetClassroom(ClassroomList.Text);
            Term student = classroom.Students.FirstOrDefault(s => s.Name == StudentList.Text).Terms
                .FirstOrDefault(t => t.Name == termName);

            #region Laboratory

            foreach (Graded item in student.Laboratory)
            {
                Grade.Laboratory.Total += item.Total;
                Grade.Laboratory.Score += item.Score;
                if (item.Score > 0)
                    Grade.Lectures.Attendance.Score += 2;
                Grade.Lectures.Attendance.Total += 2;
                Grade.Table.Laboratory.Add(new List<string> { item.Name, $"{item.Total}/{item.Score}", "+2" });
            }
            Grade.Laboratory.Percentage = CalculatePercentage(Grade.Laboratory) * 0.30;

            #endregion Laboratory

            #region HandsOn

            Grade.HandsOn.Teamwork += student.HandsOn.Teamwork;
            if (student.HandsOn.Teamwork > 0)
                Grade.Lectures.Attendance.Score += 2;
            Grade.Lectures.Attendance.Total += 2;
            Grade.Table.HandsOn.Add(new List<string> { "Teamwork", $"{student.HandsOn.Teamwork:0.00}%", "+2" });

            Grade.HandsOn.Communication += student.HandsOn.Communication;
            if (student.HandsOn.Communication > 0)
                Grade.Lectures.Attendance.Score += 2;
            Grade.Lectures.Attendance.Total += 2;
            Grade.Table.HandsOn.Add(new List<string> { "Communication", $"{student.HandsOn.Communication:0.00}%", "+2" });

            Grade.HandsOn.Percentage = ((Grade.HandsOn.Communication + Grade.HandsOn.Teamwork) / 2) * 0.45;

            #endregion HandsOn

            #region Lectures

            foreach (Graded item in student.Lecture.Exams)
            {
                Grade.Lectures.Exams.Total += item.Total;
                Grade.Lectures.Exams.Score += item.Score;
                if (item.Score > 0)
                    Grade.Lectures.Attendance.Score += 2;
                Grade.Lectures.Attendance.Total += 2;
                Grade.Table.Lectures.Add(new List<string> { item.Name, $"{item.Score}/{item.Total}", "+2" });
            }

            Grade.Lectures.Exams.Score += Grade.Lectures.Recitation;
            if (Grade.Lectures.Exams.Score > Grade.Lectures.Exams.Total)
                Grade.Lectures.Exams.Percentage = 100;
            else
                Grade.Lectures.Exams.Percentage = CalculatePercentage(Grade.Lectures.Exams);

            Grade.Lectures.Recitation = student.Lecture.Recitation;
            Grade.Table.Lectures.Add(new List<string> { "Recitation", $"+{Grade.Lectures.Recitation}" });

            Grade.Lectures.Attendance.Percentage =
                CalculatePercentage(Grade.Lectures.Attendance);

            Grade.Lectures.Percentage = (Grade.Lectures.Attendance.Percentage * 0.15 + Grade.Lectures.Exams.Percentage * 0.75) * 0.25;

            #endregion Lectures

            finalGrade += (Grade.HandsOn.Percentage + Grade.Laboratory.Percentage + Grade.Lectures.Percentage) / 2;

            List<List<string>> tableList =
                Grade.Table.Lectures.Count > Grade.Table.Laboratory.Count
                ? Grade.Table.Lectures
                : Grade.Table.Laboratory;
            List<List<string>> lower =
                Grade.Table.Lectures.Count < Grade.Table.Laboratory.Count
                ? Grade.Table.Lectures
                : Grade.Table.Laboratory;

            for (int i = 0; i < lower.Count; i++)
            {
                tableList[i].AddRange(lower[i]);
            }

            for (int i = 0; i < Grade.Table.HandsOn.Count; i++)
            {
                tableList[i].AddRange(Grade.Table.HandsOn[i]);
            }

            var tableOutput = new List<string>
            {
                "|__Lectures__|___|___|__Laboratories__|___|___|__Hands-on__|___|___|",
                "|--:|:-:|:-:|--:|:--|:-:|--:|:-:|:-:|"
            };

            foreach (var item in tableList)
            {
                if (item.Count < 9)
                {
                    int c = 9 - item.Count;
                    for (int i = 0; i < c; i++)
                        item.Add(" ");
                }

                tableOutput.Add($"|{String.Join("|", item)}|");
            }

            tableOutput.Add($"|**Total**|{Grade.Lectures.Percentage:0.00}%| | |{Grade.Laboratory.Percentage:0.00}%| | |{Grade.HandsOn.Percentage:0.00}%| |");

            return String.Join(Environment.NewLine, tableOutput);
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.User.userData.Classrooms.Add(new Classroom(Microsoft.VisualBasic.Interaction.InputBox("Enter a new classroom name", "Create new classroom", "Class #")));
            Login.User.JsonUpdate(Login.User.userFile, Login.User.userData);
            UpdateClasses();
            UpdateStudents();
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
            Login.User.JsonUpdate(Login.userFile, Login.userLogin);
            Login.User.userFile = $@"..\..\Data\Users\{newName}.json";
            File.Move(Login.User.userFile, newName);
            MessageBox.Show("Username successfully changed.", "Username Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userPass = Login.userPass;
            Login.userLogin.User.SingleOrDefault(u => u.Username == Login.userName).Password = Microsoft.VisualBasic.Interaction.InputBox("Enter a new password", "Password Change", userPass);
            MessageBox.Show("Password successfully changed.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login.User.JsonUpdate(Login.userFile, Login.userLogin);
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Delete account",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Login.userLogin.User.Remove(Login.userLogin.User.Single(u => u.Username == Login.userName));
                Login.User.JsonUpdate(Login.userFile, Login.userLogin);
                File.Delete(Login.userFile);
                Hide();
            }
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            finalGrade = 0;
            string midTerms = CalculateGrade(ClassroomList.Text, StudentList.Text, "Midterms");
            string finTerms = CalculateGrade(ClassroomList.Text, StudentList.Text, "Finals");
            string fileName = $@"..\..\Data\Users\{Login.userName}_grade.html";
            string htmlName = @"file:\\\" + Path.GetFullPath(fileName);
            using (StreamWriter file = File.CreateText(fileName))
            {
                file.Write(@"<body background='../../Resources/empty_browser.png'><meta name='viewport' content='width=device-width, initial-scale=1'><link rel='stylesheet' href='../../Resources/github-markdown.css'><style>.markdown-body{box-sizing:border-box;min-width:200px;max-width:980px;margin:0 auto;padding:45px}@media (max-width:767px){.markdown-body{padding:15px}}</style><article class='markdown-body'>");
                file.Write(Markdown.ToHtml
                    (
                $"# {Login.userName}'s Report Card\n" +
                        $"## Final Grade: {finalGrade:0.00}%\n" +
                        $"\n"
                    )
                );
                file.Write(Markdown.ToHtml(midTerms, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build()));
                file.Write(Markdown.ToHtml(finTerms, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build()));
                file.Write(@"</article></body>");
                file.Close();
            }
            Login.User.userData.Recent = fileName;
            Login.User.JsonUpdate(Login.User.userFile, Login.User.userData);
            WebBrowser.Url = new System.Uri(htmlName);
        }
    }
}