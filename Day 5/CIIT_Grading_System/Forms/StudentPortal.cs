using CIIT_Grading_System.Classes;
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
            foreach (var item in User.userData["Classrooms"].Value<dynamic>())
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

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            double percentageLecture = 0;
            double percentageHandsOn = 0;
            double percentageLaboratory = 0;

            var Grade = new GradeTemplate();
            foreach (dynamic item in User.userData.SelectToken(String.Format("$.Classrooms[?(@.Name=='{0}')].Students[?(@.Name=='{1}')]", ClassroomList.Text, StudentList.Text)))
            {
                switch (item.Name)
                {
                    case "Lecture":
                        double totalExams = 0;
                        double scoreExams = 0;
                        double scoreAttendance = 0;
                        foreach (var item_ in item.Value)
                        {
                            switch (item_.Name)
                            {
                                case "Exams":
                                    foreach (var item__ in item_.Value)
                                    {
                                        totalExams += Convert.ToDouble(item__.Total);
                                        scoreExams += Convert.ToDouble(item__.Score);
                                        Grade.MidTerm.Lectures.Add(new List<string> { item__.Name, $"{item__.Total}/{item__.Score}" });
                                    }
                                    break;

                                case "Recitation":
                                    scoreExams += Convert.ToDouble(item_.Value);
                                    scoreExams = scoreExams > totalExams ? totalExams : scoreExams;
                                    break;

                                default:
                                    break;
                            }
                        }
                        double percentageExams = (100 / totalExams) * scoreExams;
                        percentageLecture += (percentageExams * 75) / 100;
                        break;

                    case "Hands-on":
                        double totalCommunication = 0;
                        double scoreCommunication = 0;
                        double totalTeamwork = 0;
                        double scoreTeamwork = 0;
                        double percentageCommunication = 0;
                        double percentageTeamwork = 0;

                        foreach (var item_ in item.Value)
                        {
                            switch (item_.Name)
                            {
                                case "Communication":
                                    totalCommunication += Convert.ToDouble(item_.Value.Total);
                                    scoreCommunication += Convert.ToDouble(item_.Value.Score);
                                    percentageCommunication = (100 / totalCommunication) * scoreCommunication;
                                    //midTerms.Add(new List<string> { item_.Name, String.Format("{0:0.00}", percentageCommunication), "✔" });
                                    break;

                                case "Teamwork":
                                    totalTeamwork += Convert.ToDouble(item_.Value.Total);
                                    scoreTeamwork += Convert.ToDouble(item_.Value.Score);
                                    percentageTeamwork = (100 / totalTeamwork) * scoreTeamwork;
                                    //midTerms.Add(new List<string> { item_.Name, String.Format("{0:0.00}", percentageTeamwork), "✔" });
                                    break;
                            }
                        }

                        percentageHandsOn += (percentageCommunication * 50) / 100;
                        percentageHandsOn += (percentageTeamwork * 50) / 100;
                        break;

                    case "Laboratory":
                        double totalLaboratory = 0;
                        double scoreLaboratory = 0;
                        foreach (var item_ in item.Value)
                        {
                            totalLaboratory += Convert.ToDouble(item_.Value.Total);
                            scoreLaboratory += Convert.ToDouble(item_.Value.Score);
                        }
                        percentageLaboratory = (100 / totalLaboratory) * scoreLaboratory;
                        break;

                    default:
                        break;
                }
            }

            // percentageLecture += (percentageAttendance * 25) / 100;

            string buffer = String.Format(
                "# {0}'s grade\n" +
                "## Lecture: {1:0.00}%\n" +
                "## Hands-on: {2:0.00}%\n" +
                "## Laboratory: {3:0.00}%\n",
                StudentList.SelectedItem, percentageLecture, percentageHandsOn, percentageLaboratory);

            string fileName = String.Format(@"..\..\Data\Users\{0}_grade.html", Login.userName);
            string htmlName = @"file:\\\" + Path.GetFullPath(fileName);
            using (StreamWriter file = File.CreateText(fileName))
            {
                file.Write(@"<body background='../../Resources/empty_browser.png'><style>body {background-size: 100% 100%;}</style></body>");
                file.Write(Markdig.Markdown.ToHtml(buffer));
                file.Close();
            }
            User.userData["Recent"] = fileName;
            User.JsonUpdate(User.userFile, User.userData);
            WebBrowser.Url = new System.Uri(htmlName);
        }
    }
}