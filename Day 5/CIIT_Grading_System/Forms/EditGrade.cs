using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}