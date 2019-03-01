using Newtonsoft.Json;
using Quiz.Classes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        // Global variables
        public Questionnaires Quizzes = new Questionnaires();

        public int pageCurrent = 0;

        private void openAQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buffer = null;
            string fileName = null;
            if (OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var sr = new
                StreamReader(OpenFile.FileName);
                fileName = OpenFile.SafeFileName;
                buffer = sr.ReadToEnd();
                sr.Close();
            }
            QuizLabel.Text = fileName;
            try { Quizzes = JsonConvert.DeserializeObject<Questionnaires>(buffer); }
            catch (Newtonsoft.Json.JsonReaderException) { Console.WriteLine("Invalid File"); }
            QuizProgress.Step = 100 / Quizzes.Questions.Count;
            UpdateQuestion();
        }

        public void UpdateQuestion()
        {
            PageNo.Text = $"{pageCurrent + 1}/{Quizzes.Questions.Count}";
            Questioned questionCurrent = Quizzes.Questions.FirstOrDefault(q => q.Page == pageCurrent);
            QuestionBox.Text = questionCurrent.Question;

            if (pageCurrent == 0)
            {
                if (pageCurrent != Quizzes.Questions.Count)
                    Next.Text = "Next";
                else
                    Next.Text = "Submit";
                Back.Enabled = false;
            }
            else if (pageCurrent < Quizzes.Questions.Count)
            {
                if (pageCurrent + 1 == Quizzes.Questions.Count)
                    Next.Text = "Submit";
                Back.Enabled = true;
            }

            ChoiceA.Text = questionCurrent.Choices[0];
            ChoiceB.Text = questionCurrent.Choices[1];
            ChoiceC.Text = questionCurrent.Choices[2];
            ChoiceD.Text = questionCurrent.Choices[3];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            pageCurrent--;
            QuizProgress.Increment(-QuizProgress.Step);
            UpdateQuestion();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (pageCurrent + 1 == Quizzes.Questions.Count)
            {
                this.Hide();
                var newForm = new QuizResults();
                newForm.Show();
                return;
            }
            pageCurrent++;
            QuizProgress.PerformStep();
            UpdateQuestion();
        }

        private void EasyMode_Click(object sender, EventArgs e)
        {
            HardMode.Checked = false;
            EasyMode.Checked = true;
        }

        private void HardMode_Click(object sender, EventArgs e)
        {
            HardMode.Checked = true;
            EasyMode.Checked = false;
        }
    }
}