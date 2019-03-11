using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserData;

namespace CIIT_Grading_System.Forms
{
    public partial class EditGrade : Form
    {
        public EditGrade()
        {
            InitializeComponent();
        }

        private void EditGrade_Load(object sender, EventArgs e)
        {
            foreach (string item in Login.User.userData.Classrooms.Select(c => c.Name))
            {
                ClassroomList.Items.Add(item);
            }
        }

        public Classroom Classroom = null;

        private void ClassroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classroom = Login.User.userData.Classrooms.FirstOrDefault(c => c.Name == ClassroomList.SelectedItem.ToString());
            StudentList.Items.Clear();
            StudentList.Enabled = true;
            StudentList.Items.AddRange(Classroom.Students.Select(s => s.Name).ToArray());
        }

        public Student Student = null;

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student = Classroom.Students.FirstOrDefault(s => s.Name == StudentList.SelectedItem.ToString());
            if (Student.Terms == null)
            {
                Student.Terms = new List<Term>
                {
                    new Term("Midterms"),
                    new Term("Finals")
                };
            }
        }

        private void UpdateFields()
        {
            QuizList.Items.Clear();
            QuizList.Items.AddRange(Term.Lecture.Exams.Where(quiz => quiz.Name != "Major").Select(quiz => quiz.Name).ToArray());
            ActivityList.Items.Clear();
            ActivityList.Items.AddRange(Term.Laboratory.Select(activity => activity.Name).ToArray());
            CommunicationScore.Text = Term.HandsOn.Communication.ToString();
            TeamworkScore.Text = Term.HandsOn.Teamwork.ToString();
        }

        private void Enable(params Control[] controls)
        {
            foreach (Control control in controls)
                control.Enabled = true;
        }

        public Term Term = null;

        private void TermList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Term = Student.Terms.FirstOrDefault(t => t.Name == TermList.SelectedItem.ToString());
            if (Term == null)
            {
                Term = new Term(TermList.SelectedItem.ToString());
            }
            Enable(
                QuizList, QuizScore, QuizTotal,
                MajorScore, MajorTotal,
                CommunicationScore, TeamworkScore,
                ActivityList, ActivityScore, ActivityTotal
            );
            UpdateFields();
        }

        public bool CheckInts(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (!int.TryParse(textBox.Text, out int score))
                {
                    MessageBox.Show($"Enter only digits! {textBox.Text} is invalid.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = "";
                    return false;
                }
            }
            return true;
        }

        private void QuizList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graded Quiz = Term.Lecture.Exams.FirstOrDefault(q => q.Name == QuizList.SelectedItem.ToString());
            QuizScore.Text = Quiz.Score.ToString();
            QuizTotal.Text = Quiz.Total.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var Sender = sender as Button;
            TextBox Score = null;
            TextBox Total = null;
            Button Remove = null;
            List<Graded> Graded = null;
            string name = null;
            switch (Sender.Name)
            {
                case "QuizAdd":
                    Score = QuizScore;
                    Total = QuizTotal;
                    Remove = QuizRemove;
                    Graded = Term.Lecture.Exams;
                    name = "Quiz";
                    break;

                case "ActivityAdd":
                    Score = ActivityScore;
                    Total = ActivityTotal;
                    Remove = ActivityRemove;
                    Graded = Term.Laboratory;
                    name = "Activity";
                    break;
            }
            if (CheckInts(Score, Total))
            {
                int score = Convert.ToInt32(Score.Text);
                int total = Convert.ToInt32(Total.Text);
                total = score > total ? score : total;

                Graded.Add(new Graded($"{name} #{Graded.Where(g => g.Name != "Major").Count() + 1}", score, total));
                UpdateFields();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var Sender = sender as Button;
            ListBox ListBox = null;
            List<Graded> Graded = null;
            switch (Sender.Name)
            {
                case "QuizRemove":
                    Graded = Term.Lecture.Exams;
                    ListBox = QuizList;
                    break;

                case "ActivityRemove":
                    Graded = Term.Laboratory;
                    ListBox = ActivityList;
                    break;
            }
            Graded.RemoveAt(Graded.Count - 1);
            ListBox.Items.RemoveAt(ListBox.Items.Count - 1);
            if (ListBox.Items.Count == 0)
                Sender.Enabled = false;
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var Student = new Student(StudentList.SelectedItem.ToString());
            if (!CheckInts(
                MajorScore, MajorTotal,
                CommunicationScore, TeamworkScore
            ))
            {
                Term.HandsOn.Communication = Convert.ToInt32(CommunicationScore.Text);
                Term.HandsOn.Teamwork = Convert.ToInt32(TeamworkScore.Text);
                Term.Lecture.Exams.Add(new Graded("Major", Convert.ToInt32(MajorScore.Text), Convert.ToInt32(MajorTotal.Text)));
                Login.User.JsonUpdate(Login.User.userFile, Login.User.userData);
            }
        }
    }
}