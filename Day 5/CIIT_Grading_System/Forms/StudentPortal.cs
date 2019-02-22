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
            foreach (var item in User.userData.Classrooms.Properties())
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
            var classRoom = ClassroomList.SelectedItem;
            StudentList.Items.Clear();
            foreach (var item in User.userData.Classrooms[classRoom])
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

            var midTermsLectures = new List<List<string>>();
            midTermsLectures.AddRange(new List<List<string>> {
                new List<string>{ "Lectures","","" },
                new List<string>{ " -: "," :- ", ":-:" }
            });
            foreach (var item in User.userData.Classrooms[ClassroomList.SelectedItem][StudentList.SelectedItem])
            {
                switch (item.Name)
                {
                    case "Lecture":
                        double totalExams = 0;
                        double scoreExams = 0;
                        double totalAttendance = 0;
                        double scoreAttendance = 0;
                        foreach (var item_ in item.Value)
                        {
                            switch (item_.Name)
                            {
                                case "Exams":
                                    foreach (var item__ in item_.Value)
                                    {
                                        midTermsLectures.Add(new List<string> { item__.Name, String.Format("{0}/{1}", item__.Value.Score, item__.Value.Total), "✔" });
                                        totalExams += Convert.ToDouble(item__.Value.Total);
                                        scoreExams += Convert.ToDouble(item__.Value.Score);
                                    }
                                    break;

                                case "Attendance":
                                    totalAttendance += Convert.ToDouble(item_.Value.Total);
                                    scoreAttendance += Convert.ToDouble(item_.Value.Score);
                                    break;

                                case "Recitation":
                                    scoreExams += Convert.ToDouble(item_.Value);
                                    if (scoreExams > totalExams)
                                        scoreExams = totalExams;
                                    break;
                            }
                        }
                        double percentageExams = (100 / totalExams) * scoreExams;
                        double percentageAttendance = (100 / totalAttendance) * scoreAttendance;

                        percentageLecture += (percentageExams * 75) / 100;
                        percentageLecture += (percentageExams * 25) / 100;
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
                                    midTermsLectures[2].AddRange(new List<string> { item_.Name, String.Format("{0:0.00}", percentageCommunication), "✔" });
                                    break;

                                case "Teamwork":
                                    totalTeamwork += Convert.ToDouble(item_.Value.Total);
                                    scoreTeamwork += Convert.ToDouble(item_.Value.Score);
                                    percentageTeamwork = (100 / totalTeamwork) * scoreTeamwork;
                                    midTermsLectures[2].AddRange(new List<string> { item_.Name, String.Format("{0:0.00}", percentageTeamwork), "✔" });
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
                file.Write(String.Format("<body background = \"{0}\">", Path.GetFullPath(@"..\..\Resources\background.png")));
                file.Write(Markdig.Markdown.ToHtml(buffer));
                file.Write(@"</body>");
                file.Close();
            }
            User.userData.Recent = @"..\..\Data\Users" + fileName;
            User.JsonUpdate(User.userFile, User.userData);
            WebBrowser.Url = new System.Uri(htmlName);
        }
    }
}