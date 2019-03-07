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

        public Term Term = null;

        private void TermList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Term = Student.Terms.FirstOrDefault(t => t.Name == TermList.SelectedItem.ToString());
            QuizList.Items.AddRange(Term.Lecture.Exams.Where(q => q.Name != "Major").Select(q => q.Name).ToArray());
        }

        private void QuizList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graded Quiz = Term.Lecture.Exams.FirstOrDefault(q => q.Name == QuizList.SelectedItem.ToString());
            QuizScore.Text = Quiz.Score.ToString();
            QuizTotal.Text = Quiz.Total.ToString();
        }

        public bool CheckInts(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (int.TryParse(textBox.Text, out int score))
                {
                    MessageBox.Show($"Enter only digits! {textBox.Text} is invalid.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text.Remove(0);
                    return false;
                }
            }
            return true;
        }

        private void RemoveQuiz_Click(object sender, EventArgs e)
        {
            Term.Lecture.Exams.RemoveAt(Term.Lecture.Exams.Count - 1);
            QuizList.Items.RemoveAt(QuizList.Items.Count - 1);
            if (QuizList.Items.Count == 0)
                RemoveQuiz.Enabled = false;
        }

        private void AddQuiz_Click(object sender, EventArgs e)
        {
            if (CheckInts(QuizTotal, QuizScore))
            {
                Term.Lecture.Exams.Add(new Graded($"Quiz #{Term.Lecture.Exams.Count + 1}", Convert.ToInt32(QuizScore.Text), Convert.ToInt32(QuizTotal.Text)));
                RemoveQuiz.Enabled = true;
            }
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
            }
        }
    }
}