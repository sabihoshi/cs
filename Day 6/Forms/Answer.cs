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

        public static Questionnaire Quiz = new Questionnaire();
        public int pageCurrent = 1;
        public static int pageMax = 0;
        public static int[] answers;
        public static DateTime start = DateTime.Now;

        private void OnTimerElapsed(object sender, EventArgs e)
        {
            TimeElapsed.Text = (DateTime.Now - start).ToString(@"mm\:ss");
        }

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
                Quiz = JsonConvert.DeserializeObject<Questionnaire>(buffer);
                QuizLabel.Text = Quiz.Name;
            }
            catch (JsonReaderException) { MessageBox.Show("Invalid file", "Open file", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            catch (ArgumentNullException) { return; }
            start = DateTime.Now;
            ChoiceA.Enabled = true;
            ChoiceB.Enabled = true;
            ChoiceC.Enabled = true;
            ChoiceD.Enabled = true;
            QuizTimer.Enabled = true;
            Next.Enabled = true;
            pageMax = Quiz.Questions.Count;
            answers = Enumerable.Repeat(-1, pageMax).ToArray();
            QuizProgress.Step = 100 / pageMax;
            UpdateQuestion();
        }

        public void UpdateQuestion()
        {
            PageNo.Text = $"{pageCurrent}/{pageMax}";
            Question questionCurrent = Quiz.Questions[pageCurrent - 1];
            QuestionBox.Text = questionCurrent.Description;

            if (pageCurrent == 1)
                Back.Enabled = false;
            else
                Back.Enabled = true;
            if (pageCurrent == pageMax)
                Next.Text = "Submit";
            else
                Next.Text = "Next";

            ChoiceA.Text = questionCurrent.Choices[0];
            ChoiceB.Text = questionCurrent.Choices[1];
            ChoiceC.Text = questionCurrent.Choices[2];
            ChoiceD.Text = questionCurrent.Choices[3];
            int c = answers[pageCurrent - 1];
            ChoiceA.Checked = c == 0;
            ChoiceB.Checked = c == 1;
            ChoiceC.Checked = c == 2;
            ChoiceD.Checked = c == 3;
        }

        private int ChoiceMade()
        {
            if (ChoiceA.Checked)
                return 0;
            else if (ChoiceB.Checked)
                return 1;
            else if (ChoiceC.Checked)
                return 2;
            else if (ChoiceD.Checked)
                return 3;
            else
                return -1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            answers[pageCurrent - 1] = ChoiceMade();
            pageCurrent--;
            QuizProgress.Increment(-QuizProgress.Step);
            UpdateQuestion();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            answers[pageCurrent - 1] = ChoiceMade();
            if (pageCurrent == pageMax)
            {
                if (answers.Any(c => c == -1))
                {
                    string result = string.Join(", ", answers.Where(x => x == -1).Select((x, i) => i + 1));
                    if (MessageBox.Show($"Your answer in {result} is empty", "Continue?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                }
                Hide();
                var newForm = new Results();
                newForm.Show();
                return;
            }
            pageCurrent++;
            QuizProgress.PerformStep();
            UpdateQuestion();
        }

        private void createAQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var newForm = new Editor();
            newForm.Show();
        }
    }
}