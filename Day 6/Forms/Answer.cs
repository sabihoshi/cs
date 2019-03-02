using Newtonsoft.Json;
using Quiz.Classes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class Answer : Form
    {
        public Answer()
        {
            InitializeComponent();
        }

        public Questionnaire Quizzes = new Questionnaire();
        public int pageCurrent = 1;

        private void openAQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buffer = null;
            string fileName = null;
            try
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    var sr = new
                    StreamReader(OpenFile.FileName);
                    fileName = OpenFile.SafeFileName;
                    buffer = sr.ReadToEnd();
                    sr.Close();
                }
                Quizzes = JsonConvert.DeserializeObject<Questionnaire>(buffer);
                QuizLabel.Text = Quizzes.Name;
            }
            catch (JsonReaderException) { MessageBox.Show("Invalid file", "Open file", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            QuizProgress.Step = 100 / Quizzes.Questions.Count;
            UpdateQuestion();
        }

        public void UpdateQuestion()
        {
            PageNo.Text = $"{pageCurrent}/{Quizzes.Questions.Count}";
            Question questionCurrent = Quizzes.Questions[pageCurrent - 1];
            QuestionBox.Text = questionCurrent.Description;

            if (pageCurrent == 1)
                Back.Enabled = false;
            else
                Back.Enabled = true;
            if (pageCurrent == Quizzes.Questions.Count)
                Next.Text = "Submit";
            else
                Next.Text = "Next";

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
            if (pageCurrent == Quizzes.Questions.Count)
            {
                Hide();
                var newForm = new Results();
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

        private void createAQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var newForm = new Editor();
            newForm.Show();
        }
    }
}