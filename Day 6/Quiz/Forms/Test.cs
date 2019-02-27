using Newtonsoft.Json;
using Quiz.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        public Questionnaires Quizzes = new Questionnaires();

        // private void Form1_Load(object sender, EventArgs e)
        // {
        //     q.CreateQuestion("Brass gets discoloured in air because of the presence of which of the following gases in air?");
        //     q.Questions.FirstOrDefault(q => q.Name == 1).CreateChoice(new List<string> { "Oxygen", "Hydrogen Sulphide", "Nitrogen", "Carbon // Dioxide" });
        //
        //     q.CreateQuestion("Which of the following is used in pencils?");
        //     q.Questions.FirstOrDefault(q => q.Name == 2).CreateChoice(new List<string> { "Graphite", "Silicon", "Carbon", "Phosphorous" });
        //
        //     q.CreateQuestion("Chlorophyll is a naturally occurring chelate compound in which central metal?");
        //     q.Questions.FirstOrDefault(q => q.Name == 3).CreateChoice(new List<string> { "Copper", "Magnesium", "Iron", "Calcium" });
        //
        //     q.CreateQuestion("Which of the following is a non metal that remains liquid at room temperature?");
        //     q.Questions.FirstOrDefault(q => q.Name == 4).CreateChoice(new List<string> { "Phophorus", "Chlorine", "Helium", "Bromine" });
        //
        //     q.CreateQuestion("Which of the following metals forms an amalgam with other metals?");
        //     q.Questions.FirstOrDefault(q => q.Name == 5).CreateChoice(new List<string> { "Mercury", "Tin", "Lead", "Zinc" });
        //
        //     q.CreateQuestion("Chemical formula for water is?");
        //     q.Questions.FirstOrDefault(q => q.Name == 6).CreateChoice(new List<string> { "NaAl02", "Al2O3", "CaSiO3", "H2O" });
        //
        //     q.CreateQuestion("Quartz crystals normally used in quartz clocks etc. is chemically");
        //     q.Questions.FirstOrDefault(q => q.Name == 7).CreateChoice(new List<string> { "Silicon Dioxide", "Germanium Oxide", "A mixture of / Germanium /Oxide and Silicon Dioxide", "Sodium Silicate" });
        //
        //     File.WriteAllText("./test.json", JsonConvert.SerializeObject(q));
        // }

        public int pageCurrent = 0;

        private void openAQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buffer = "";
            string fileName = "";
            if (OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var sr = new
                StreamReader(OpenFile.FileName);
                fileName = OpenFile.SafeFileName;
                buffer = sr.ReadToEnd();
                sr.Close();
            }
            QuizLabel.Text = fileName;
            Quizzes = JsonConvert.DeserializeObject<Questionnaires>(buffer);
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
    }
}