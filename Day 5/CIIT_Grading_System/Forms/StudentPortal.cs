using CIIT_Grading_System.Classes;
using Markdig;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CIIT_Grading_System.Forms
{
    public partial class StudentPortal : Form
    {
        public StudentPortal()
        {
            InitializeComponent();
        }

        public User User = new User();

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            User.CreateUser(Login.userName);
            WebBrowser.Url = new Uri(@"file:\\\" + Path.GetFullPath(@"..\..\Resources\default.html"));
            foreach (dynamic item in User.userData["Classrooms"].Value<dynamic>())
            {
                string output = item.Name;
                ClassroomList.Items.Add(output);
            }
        }

        private void addStudentToClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ClassroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentList.Items.Clear();
            foreach (dynamic item in User.userData.SelectToken(String.Format("$.Classrooms[?(@.Name=='{0}')].Students", ClassroomList.Text)))
            {
                string output = item.Name;
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

            foreach (dynamic item in User.userData.SelectToken($"$.Classrooms[?(@.Name=='{ClassroomList.Text}')].Students[?(@.Name=='{StudentList.Text}')]"))
            {
                switch (item.Name)
                {
                    case "Lecture":
                        foreach (dynamic item_ in item.Value)
                        {
                            switch (item_.Name)
                            {
                                case "Exams":
                                    foreach (dynamic item__ in item_.Value)
                                    {
                                        Grade.Lectures.Exams.Total += Convert.ToDouble(item__.Total);
                                        Grade.Lectures.Exams.Score += Convert.ToDouble(item__.Score);
                                        if (item__.Score > 0)
                                            Grade.Lectures.Attendance.Score += 2;
                                        Grade.Lectures.Attendance.Total += 2;
                                        Grade.Table.Lectures.Add(new List<string> { item__.Name.ToString(), $"{item__.Total}/{item__.Score}", "+2" });
                                    }
                                    break;

                                case "Recitation":
                                    Grade.Lectures.Exams.Score += Convert.ToDouble(item_.Value);
                                    if (Grade.Lectures.Exams.Score > Grade.Lectures.Exams.Total)
                                        Grade.Lectures.Exams.Score = Grade.Lectures.Exams.Total;
                                    break;

                                default:
                                    break;
                            }
                        }
                        Grade.Lectures.Exams.Percentage = (100 / Grade.Lectures.Exams.Total) * Grade.Lectures.Exams.Score;
                        Grade.Lectures.Percentage += (Grade.Lectures.Exams.Percentage * 75) / 100;
                        break;

                    case "Hands-on":

                        foreach (dynamic item_ in item.Value)
                        {
                            switch (item_.Name)
                            {
                                case "Communication":
                                    Grade.HandsOn.Communication.Total += Convert.ToDouble(item_.Value);
                                    Grade.HandsOn.Communication.Percentage = (100 / Grade.HandsOn.Communication.Total) * Grade.HandsOn.Communication.Score;
                                    if (item_.Value > 0)
                                        Grade.Lectures.Attendance.Score += 2;
                                    Grade.Lectures.Attendance.Total += 2;
                                    Grade.Table.HandsOn.Add(new List<string> { item_.Name.ToString(), $"{item_.Value:0.00}%", "+2" });
                                    break;

                                case "Teamwork":
                                    Grade.HandsOn.Teamwork.Total += Convert.ToDouble(item_.Value);
                                    Grade.HandsOn.Teamwork.Percentage = (100 / Grade.HandsOn.Teamwork.Total) * Grade.HandsOn.Teamwork.Score;
                                    if (item_.Value > 0)
                                        Grade.Lectures.Attendance.Score += 2;
                                    Grade.Lectures.Attendance.Total += 2;
                                    Grade.Table.HandsOn.Add(new List<string> { item_.Name.ToString(), $"{item_.Value:0.00}%", "+2" });
                                    break;
                            }
                        }
                        Grade.HandsOn.Percentage += (Grade.HandsOn.Communication.Percentage * 50) / 100;
                        Grade.HandsOn.Percentage += (Grade.HandsOn.Teamwork.Percentage * 50) / 100;
                        break;

                    case "Laboratory":
                        foreach (dynamic item_ in item.Value)
                        {
                            Grade.Laboratory.Total += Convert.ToDouble(item_.Total);
                            Grade.Laboratory.Score += Convert.ToDouble(item_.Score);
                            if (item_.Score > 0)
                                Grade.Lectures.Attendance.Score += 2;
                            Grade.Lectures.Attendance.Total += 2;
                            Grade.Table.Laboratory.Add(new List<string> { item_.Name.ToString(), $"{item_.Total}/{item_.Score}", "+2" });
                        }
                        Grade.Laboratory.Percentage = (100 / Grade.Laboratory.Total) * Grade.Laboratory.Score;
                        break;

                    default:
                        break;
                }
            }
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
                "|Lectures|Grade| |Laboratories|Grade| |Hands-on|Grade| |",
                "|--:|:--|:--:|--:|:--|:--:|--:|:--|:--:|"
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

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buffer = CalculateGrade(ClassroomList.Text, StudentList.Text);
            Console.WriteLine(buffer);
            string fileName = String.Format(@"..\..\Data\Users\{0}_grade.html", Login.userName);
            string htmlName = @"file:\\\" + Path.GetFullPath(fileName);
            using (StreamWriter file = File.CreateText(fileName))
            {
                file.Write(@"<body background='../../Resources/empty_browser.png'><style>body {background-size: 100% 100%;}</style></body>");
                file.Write(Markdig.Markdown.ToHtml(buffer, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build()));
                file.Close();
            }
            User.userData["Recent"] = fileName;
            User.JsonUpdate(User.userFile, User.userData);
            WebBrowser.Url = new System.Uri(htmlName);
        }
    }
}