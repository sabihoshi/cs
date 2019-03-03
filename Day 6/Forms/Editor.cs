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
            if (Questionnaire.Questions.Count == 0)
            {
                deletePageToolStripMenuItem.Enabled = false;
                RemoveQuestion.Enabled = false;
            }
            else
            {
                deletePageToolStripMenuItem.Enabled = true;
                RemoveQuestion.Enabled = true;
            }
            Next.Enabled = pageCurrent != Questionnaire.Questions.Count;
            Back.Enabled = pageCurrent != 1;

            saveToolStripMenuItem.Enabled = Questionnaire.Questions.Count != 0;
            Question currentQuestion = Questionnaire.Questions[pageCurrent - 1];

            PageNo.Text = $"Page {pageCurrent}/{Questionnaire.Questions.Count}";
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
            Questionnaire.Questions.RemoveAt(pageCurrent - 1);
            pageCurrent = pageCurrent <= 1 ? 1 : pageCurrent - 1;
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
            if (Title.Text == "")
                MessageBox.Show("Please input a title!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Questionnaire.Questions.Count == 0)
                MessageBox.Show("Please have at least one question!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    Questionnaire.Name = Title.Text;
                    SaveFile.FileName = Title.Text;
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(SaveFile.FileName, JsonConvert.SerializeObject(Questionnaire, Formatting.Indented));
                        MessageBox.Show("File saved.", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else return;
                }
                catch (JsonWriterException) { MessageBox.Show("Invalid file", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            var newForm = new Answer();
            newForm.Show();
        }
    }
}