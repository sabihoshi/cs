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
            QuizList.Items.AddRange(Term.Lecture.Exams.Select(q => q.Name).ToArray());
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

        private void QuizCount_ValueChanged(object sender, EventArgs e)
        {
            if (Term.Lecture.Exams.Count < QuizCount.Value)
            {
                for (int i = Term.Lecture.Exams.Count; i < QuizCount.Value; i++)
                {
                    QuizList.Items.Add("Quiz #{i}");
                    Term.Lecture.Exams.Add(new Graded("Quiz #{i}", 0, 0));
                }
            }
            else if (Term.Lecture.Exams.Count > QuizCount.Value)
            {
                int count = (int)QuizCount.Value - Term.Lecture.Exams.Count;
                Term.Lecture.Exams.RemoveRange((int)QuizCount.Value - 1, Term.Lecture.Exams.Count);
            }
        }

        private void QuizSave_Click(object sender, EventArgs e)
        {
            Graded Quiz = Term.Lecture.Exams.FirstOrDefault(q => q.Name == QuizList.SelectedItem.ToString());
            if (CheckInts(QuizTotal, QuizScore))
            {
            }
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var Student = new Student(StudentList.SelectedItem.ToString());
            CheckInts(MajorScore, MajorTotal);
            CheckInts(CommunicationScore, CommunicationTotal);
            CheckInts(TeamworkScore, TeamworkTotal);
        }
    }
}