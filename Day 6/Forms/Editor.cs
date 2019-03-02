using Quiz.Classes;
using System;
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
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
        }

        private void Choice_TextChanged(object sender, EventArgs e)
        {
            ChoiceA.Text = A.Text;
            ChoiceB.Text = B.Text;
            ChoiceC.Text = C.Text;
            ChoiceD.Text = D.Text;
        }

        public int correctAnswer;

        private void Choice_CorrectAnswer(object sender, EventArgs e)
        {
            if (sender == A)
                correctAnswer = 0;
            else if (sender == B)
                correctAnswer = 1;
            else if (sender == C)
                correctAnswer = 2;
            else if (sender == D)
                correctAnswer = 3;
        }

        private void NewQuestion_Click(object sender, EventArgs e)
        {
            Questionnaire.Name = Title.Text;
            Questionnaire.Questions.Add(new Questions(Question.Text, correctAnswer, A.Text, B.Text, C.Text, D.Text));
        }
    }
}