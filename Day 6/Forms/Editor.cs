using Newtonsoft.Json;
using Quiz.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        public Questionnaire Questionnaire = new Questionnaire();

        private void Title_TextChanged(object sender, EventArgs e)
        {
            Question.Enabled = true;
        }

        private void Question_TextChanged(object sender, EventArgs e)
        {
            TextA.Enabled = true;
            TextB.Enabled = true;
            TextC.Enabled = true;
            TextD.Enabled = true;
        }

        private void Choice_TextChanged(object sender, EventArgs e)
        {
            ChoiceA.Text = TextA.Text;
            ChoiceB.Text = TextB.Text;
            ChoiceC.Text = TextC.Text;
            ChoiceD.Text = TextD.Text;
        }

        public int correctAnswer;

        private void Choice_CorrectAnswer(object sender, EventArgs e)
        {
            if (sender == ChoiceA)
                correctAnswer = 0;
            else if (sender == ChoiceB)
                correctAnswer = 1;
            else if (sender == ChoiceC)
                correctAnswer = 2;
            else if (sender == ChoiceD)
                correctAnswer = 3;
        }

        private void UpdateQuestion()
        {
            if (pageCurrent == 1)
            {
                RemoveQuestion.Enabled = false;
                Back.Enabled = false;
            }
            else
            {
                RemoveQuestion.Enabled = true;
                Back.Enabled = true;
            }
            if (pageCurrent == Questionnaire.Questions.Count)
                Next.Enabled = false;
            else
                Next.Enabled = true;

            Question currentQuestion = Questionnaire.Questions[pageCurrent];

            PageNo.Text = $"Page {pageCurrent + 1}/{Questionnaire.Questions.Count}";
            Question.Text = currentQuestion.Description;
            TextA.Text = currentQuestion.Choices[0];
            TextB.Text = currentQuestion.Choices[1];
            TextC.Text = currentQuestion.Choices[2];
            TextD.Text = currentQuestion.Choices[3];

            int c = currentQuestion.Correct;
            ChoiceA.Checked = c == 0;
            ChoiceB.Checked = c == 1;
            ChoiceC.Checked = c == 2;
            ChoiceD.Checked = c == 3;
        }

        public int pageCurrent = 0;

        private void NewQuestion_Click(object sender, EventArgs e)
        {
            Questionnaire.Questions.Add(
                new Question(
                    Question.Text, correctAnswer,
                    TextA.Text, TextB.Text, TextC.Text, TextD.Text
                )
            );
            pageCurrent++;
            UpdateQuestion();
        }

        private void RemoveQuestion_Click(object sender, EventArgs e)
        {
            Questionnaire.Questions.RemoveAt(pageCurrent);
            pageCurrent--;
            UpdateQuestion();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            pageCurrent--;
            UpdateQuestion();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            pageCurrent++;
            UpdateQuestion();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(SaveFile.FileName, JsonConvert.SerializeObject(Questionnaire, Formatting.Indented));
                }
                catch (JsonWriterException) { MessageBox.Show("Invalid file", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}