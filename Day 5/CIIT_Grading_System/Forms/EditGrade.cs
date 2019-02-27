using CIIT_Grading_System.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CIIT_Grading_System.Forms
{
    public partial class EditGrade : Form
    {
        public EditGrade()
        {
            InitializeComponent();
        }

        private int quizCount = 0;
        private int activityCount = 0;

        private void QuizScore_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(QuizTotal.Text) < Convert.ToInt32(QuizScore.Text))
                QuizTotal.Text = QuizScore.Text;
        }

        private void QuizAdd_Click(object sender, EventArgs e)
        {
            activityCount++;
            QuizList.Items.Add(String.Format("Quiz #{0}", activityCount));
        }

        private void EditGrade_Load(object sender, EventArgs e)
        {
        }

        private void ClassroomList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TermList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}