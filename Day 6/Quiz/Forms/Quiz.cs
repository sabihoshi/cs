using Newtonsoft.Json;
using Quiz.Classes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

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
            UpdateQuestion();
        }

        public void UpdateQuestion()
        {
            PageNo.Text = $"{pageCurrent + 1}/{Quizzes.Questions.Count}";
            Questioned questionCurrent = Quizzes.Questions.FirstOrDefault(q => q.Page == pageCurrent + 1);
            QuestionBox.Text = questionCurrent.Question;

            ChoiceA.Text = questionCurrent.Choices[0];
            ChoiceB.Text = questionCurrent.Choices[1];
            ChoiceC.Text = questionCurrent.Choices[2];
            ChoiceD.Text = questionCurrent.Choices[3];
        }

        private void Test_Load(object sender, EventArgs e)
        {
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Next.Text = "Next";
            if (pageCurrent == 1)
                Back.Enabled = false;
            pageCurrent--;
            UpdateQuestion();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Back.Enabled = true;
            if (pageCurrent == Quizzes.Questions.Count - 1)
            {
            }
            else
            {
                if (pageCurrent == Quizzes.Questions.Count - 2)
                    Next.Text = "Submit";
                pageCurrent++;
                UpdateQuestion();
            }
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

        private void Test_Load_1(object sender, EventArgs e)
        {
        }
    }
}