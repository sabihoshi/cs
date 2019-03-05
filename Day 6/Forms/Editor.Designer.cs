namespace Quiz.Forms
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label QuizLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.PageNo = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.ChoiceD = new System.Windows.Forms.RadioButton();
            this.ChoiceC = new System.Windows.Forms.RadioButton();
            this.ChoiceB = new System.Windows.Forms.RadioButton();
            this.QuestionBox = new System.Windows.Forms.GroupBox();
            this.ChoiceA = new System.Windows.Forms.RadioButton();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewQuestion = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.Question = new System.Windows.Forms.TextBox();
            this.TextB = new System.Windows.Forms.TextBox();
            this.TextA = new System.Windows.Forms.TextBox();
            this.TextD = new System.Windows.Forms.TextBox();
            this.TextC = new System.Windows.Forms.TextBox();
            this.RemoveQuestion = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            QuizLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.QuestionBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // QuizLabel
            // 
            QuizLabel.AutoSize = true;
            QuizLabel.BackColor = System.Drawing.Color.MidnightBlue;
            QuizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            QuizLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            QuizLabel.Location = new System.Drawing.Point(25, 55);
            QuizLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            QuizLabel.Name = "QuizLabel";
            QuizLabel.Size = new System.Drawing.Size(70, 31);
            QuizLabel.TabIndex = 7;
            QuizLabel.Text = "Quiz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightSlateGray;
            label1.Location = new System.Drawing.Point(481, 43);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 17);
            label1.TabIndex = 11;
            label1.Text = "Quiz Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.LightSlateGray;
            label2.Location = new System.Drawing.Point(481, 91);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 17);
            label2.TabIndex = 11;
            label2.Text = "Question";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.LightSlateGray;
            label4.Location = new System.Drawing.Point(481, 150);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 17);
            label4.TabIndex = 11;
            label4.Text = "Choices";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.LightSlateGray;
            label3.Location = new System.Drawing.Point(627, 177);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 17);
            label3.TabIndex = 11;
            label3.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.LightSlateGray;
            label5.Location = new System.Drawing.Point(627, 206);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(17, 17);
            label5.TabIndex = 11;
            label5.Text = "B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.LightSlateGray;
            label6.Location = new System.Drawing.Point(627, 236);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(17, 17);
            label6.TabIndex = 11;
            label6.Text = "C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.LightSlateGray;
            label7.Location = new System.Drawing.Point(627, 265);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(18, 17);
            label7.TabIndex = 11;
            label7.Text = "D";
            // 
            // PageNo
            // 
            this.PageNo.AutoSize = true;
            this.PageNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.PageNo.Location = new System.Drawing.Point(339, 313);
            this.PageNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageNo.Name = "PageNo";
            this.PageNo.Size = new System.Drawing.Size(41, 17);
            this.PageNo.TabIndex = 11;
            this.PageNo.Text = "Page";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.Control;
            this.Next.Enabled = false;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(611, 300);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 28);
            this.Next.TabIndex = 11;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Enabled = false;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(28, 300);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 28);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ChoiceD
            // 
            this.ChoiceD.AutoSize = true;
            this.ChoiceD.Location = new System.Drawing.Point(28, 154);
            this.ChoiceD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoiceD.Name = "ChoiceD";
            this.ChoiceD.Size = new System.Drawing.Size(39, 21);
            this.ChoiceD.TabIndex = 9;
            this.ChoiceD.TabStop = true;
            this.ChoiceD.Text = "D";
            this.ChoiceD.UseVisualStyleBackColor = true;
            this.ChoiceD.CheckedChanged += new System.EventHandler(this.Choice_CorrectAnswer);
            // 
            // ChoiceC
            // 
            this.ChoiceC.AutoSize = true;
            this.ChoiceC.Location = new System.Drawing.Point(28, 126);
            this.ChoiceC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoiceC.Name = "ChoiceC";
            this.ChoiceC.Size = new System.Drawing.Size(38, 21);
            this.ChoiceC.TabIndex = 8;
            this.ChoiceC.TabStop = true;
            this.ChoiceC.Text = "C";
            this.ChoiceC.UseVisualStyleBackColor = true;
            this.ChoiceC.CheckedChanged += new System.EventHandler(this.Choice_CorrectAnswer);
            // 
            // ChoiceB
            // 
            this.ChoiceB.AutoSize = true;
            this.ChoiceB.Location = new System.Drawing.Point(28, 97);
            this.ChoiceB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoiceB.Name = "ChoiceB";
            this.ChoiceB.Size = new System.Drawing.Size(38, 21);
            this.ChoiceB.TabIndex = 7;
            this.ChoiceB.TabStop = true;
            this.ChoiceB.Text = "B";
            this.ChoiceB.UseVisualStyleBackColor = true;
            this.ChoiceB.CheckedChanged += new System.EventHandler(this.Choice_CorrectAnswer);
            // 
            // QuestionBox
            // 
            this.QuestionBox.Controls.Add(this.ChoiceD);
            this.QuestionBox.Controls.Add(this.ChoiceC);
            this.QuestionBox.Controls.Add(this.ChoiceB);
            this.QuestionBox.Controls.Add(this.ChoiceA);
            this.QuestionBox.Location = new System.Drawing.Point(28, 108);
            this.QuestionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuestionBox.Size = new System.Drawing.Size(368, 185);
            this.QuestionBox.TabIndex = 8;
            this.QuestionBox.TabStop = false;
            this.QuestionBox.Text = "Question";
            // 
            // ChoiceA
            // 
            this.ChoiceA.AutoSize = true;
            this.ChoiceA.Location = new System.Drawing.Point(28, 69);
            this.ChoiceA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoiceA.Name = "ChoiceA";
            this.ChoiceA.Size = new System.Drawing.Size(38, 21);
            this.ChoiceA.TabIndex = 6;
            this.ChoiceA.TabStop = true;
            this.ChoiceA.Text = "A";
            this.ChoiceA.UseVisualStyleBackColor = true;
            this.ChoiceA.CheckedChanged += new System.EventHandler(this.Choice_CorrectAnswer);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "FileName";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(780, 28);
            this.MenuStrip.TabIndex = 6;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExistingQuizToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openExistingQuizToolStripMenuItem
            // 
            this.openExistingQuizToolStripMenuItem.Name = "openExistingQuizToolStripMenuItem";
            this.openExistingQuizToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.openExistingQuizToolStripMenuItem.Text = "Open Existing Quiz";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPageToolStripMenuItem,
            this.deletePageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addPageToolStripMenuItem
            // 
            this.addPageToolStripMenuItem.Name = "addPageToolStripMenuItem";
            this.addPageToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.addPageToolStripMenuItem.Text = "Add Page";
            this.addPageToolStripMenuItem.Click += new System.EventHandler(this.NewQuestion_Click);
            // 
            // deletePageToolStripMenuItem
            // 
            this.deletePageToolStripMenuItem.Name = "deletePageToolStripMenuItem";
            this.deletePageToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.deletePageToolStripMenuItem.Text = "Delete Page";
            this.deletePageToolStripMenuItem.Click += new System.EventHandler(this.RemoveQuestion_Click);
            // 
            // NewQuestion
            // 
            this.NewQuestion.Location = new System.Drawing.Point(719, 300);
            this.NewQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewQuestion.Name = "NewQuestion";
            this.NewQuestion.Size = new System.Drawing.Size(32, 28);
            this.NewQuestion.TabIndex = 12;
            this.NewQuestion.Text = "+";
            this.NewQuestion.UseVisualStyleBackColor = true;
            this.NewQuestion.Click += new System.EventHandler(this.NewQuestion_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(485, 63);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(132, 22);
            this.Title.TabIndex = 0;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // Question
            // 
            this.Question.Enabled = false;
            this.Question.Location = new System.Drawing.Point(485, 111);
            this.Question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(132, 22);
            this.Question.TabIndex = 1;
            this.Question.TextChanged += new System.EventHandler(this.Question_TextChanged);
            // 
            // TextB
            // 
            this.TextB.Enabled = false;
            this.TextB.Location = new System.Drawing.Point(485, 202);
            this.TextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextB.Name = "TextB";
            this.TextB.Size = new System.Drawing.Size(132, 22);
            this.TextB.TabIndex = 3;
            this.TextB.TextChanged += new System.EventHandler(this.Choice_TextChanged);
            // 
            // TextA
            // 
            this.TextA.Enabled = false;
            this.TextA.Location = new System.Drawing.Point(485, 174);
            this.TextA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextA.Name = "TextA";
            this.TextA.Size = new System.Drawing.Size(132, 22);
            this.TextA.TabIndex = 2;
            this.TextA.TextChanged += new System.EventHandler(this.Choice_TextChanged);
            // 
            // TextD
            // 
            this.TextD.Enabled = false;
            this.TextD.Location = new System.Drawing.Point(485, 258);
            this.TextD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextD.Name = "TextD";
            this.TextD.Size = new System.Drawing.Size(132, 22);
            this.TextD.TabIndex = 5;
            this.TextD.TextChanged += new System.EventHandler(this.Choice_TextChanged);
            // 
            // TextC
            // 
            this.TextC.Enabled = false;
            this.TextC.Location = new System.Drawing.Point(485, 230);
            this.TextC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextC.Name = "TextC";
            this.TextC.Size = new System.Drawing.Size(132, 22);
            this.TextC.TabIndex = 4;
            this.TextC.TextChanged += new System.EventHandler(this.Choice_TextChanged);
            // 
            // RemoveQuestion
            // 
            this.RemoveQuestion.Enabled = false;
            this.RemoveQuestion.Location = new System.Drawing.Point(571, 300);
            this.RemoveQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveQuestion.Name = "RemoveQuestion";
            this.RemoveQuestion.Size = new System.Drawing.Size(32, 28);
            this.RemoveQuestion.TabIndex = 12;
            this.RemoveQuestion.Text = "-";
            this.RemoveQuestion.UseVisualStyleBackColor = true;
            this.RemoveQuestion.Click += new System.EventHandler(this.RemoveQuestion_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "json";
            this.SaveFile.Filter = "JSON files|*.json";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 70);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(780, 316);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox3.Location = new System.Drawing.Point(453, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 316);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 343);
            this.Controls.Add(this.TextC);
            this.Controls.Add(this.TextD);
            this.Controls.Add(this.TextA);
            this.Controls.Add(this.TextB);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RemoveQuestion);
            this.Controls.Add(this.NewQuestion);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.PageNo);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(QuizLabel);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Editor";
            this.Text = "Quiz Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.QuestionBox.ResumeLayout(false);
            this.QuestionBox.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PageNo;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RadioButton ChoiceD;
        private System.Windows.Forms.RadioButton ChoiceC;
        private System.Windows.Forms.RadioButton ChoiceB;
        private System.Windows.Forms.GroupBox QuestionBox;
        private System.Windows.Forms.RadioButton ChoiceA;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPageToolStripMenuItem;
        private System.Windows.Forms.Button NewQuestion;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.TextBox TextB;
        private System.Windows.Forms.TextBox TextA;
        private System.Windows.Forms.TextBox TextD;
        private System.Windows.Forms.TextBox TextC;
        private System.Windows.Forms.ToolStripMenuItem deletePageToolStripMenuItem;
        private System.Windows.Forms.Button RemoveQuestion;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}