﻿namespace Quiz.Forms
{
    partial class Answer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Answer));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuizLabel = new System.Windows.Forms.Label();
            this.ChoiceA = new System.Windows.Forms.RadioButton();
            this.QuestionBox = new System.Windows.Forms.GroupBox();
            this.ChoiceD = new System.Windows.Forms.RadioButton();
            this.ChoiceC = new System.Windows.Forms.RadioButton();
            this.ChoiceB = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.PageNo = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.QuizTimer = new System.Windows.Forms.Timer(this.components);
            this.QuizProgress = new System.Windows.Forms.ProgressBar();
            this.TimeElapsed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            this.QuestionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quizToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(545, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAQuizToolStripMenuItem,
            this.createAQuizToolStripMenuItem});
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.quizToolStripMenuItem.Text = "Quiz";
            // 
            // openAQuizToolStripMenuItem
            // 
            this.openAQuizToolStripMenuItem.Name = "openAQuizToolStripMenuItem";
            this.openAQuizToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openAQuizToolStripMenuItem.Text = "Open a quiz";
            this.openAQuizToolStripMenuItem.Click += new System.EventHandler(this.openAQuizToolStripMenuItem_Click);
            // 
            // createAQuizToolStripMenuItem
            // 
            this.createAQuizToolStripMenuItem.Name = "createAQuizToolStripMenuItem";
            this.createAQuizToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.createAQuizToolStripMenuItem.Text = "Create a quiz";
            this.createAQuizToolStripMenuItem.Click += new System.EventHandler(this.createAQuizToolStripMenuItem_Click);
            // 
            // QuizLabel
            // 
            this.QuizLabel.AutoSize = true;
            this.QuizLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.QuizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuizLabel.Location = new System.Drawing.Point(15, 41);
            this.QuizLabel.Name = "QuizLabel";
            this.QuizLabel.Size = new System.Drawing.Size(56, 25);
            this.QuizLabel.TabIndex = 1;
            this.QuizLabel.Text = "Quiz";
            // 
            // ChoiceA
            // 
            this.ChoiceA.AutoSize = true;
            this.ChoiceA.Enabled = false;
            this.ChoiceA.Location = new System.Drawing.Point(21, 56);
            this.ChoiceA.Name = "ChoiceA";
            this.ChoiceA.Size = new System.Drawing.Size(32, 17);
            this.ChoiceA.TabIndex = 2;
            this.ChoiceA.TabStop = true;
            this.ChoiceA.Text = "A";
            this.ChoiceA.UseVisualStyleBackColor = true;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuestionBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.QuestionBox.Controls.Add(this.ChoiceD);
            this.QuestionBox.Controls.Add(this.ChoiceC);
            this.QuestionBox.Controls.Add(this.ChoiceB);
            this.QuestionBox.Controls.Add(this.ChoiceA);
            this.QuestionBox.Location = new System.Drawing.Point(17, 84);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(512, 150);
            this.QuestionBox.TabIndex = 3;
            this.QuestionBox.TabStop = false;
            this.QuestionBox.Text = "Question";
            // 
            // ChoiceD
            // 
            this.ChoiceD.AutoSize = true;
            this.ChoiceD.Enabled = false;
            this.ChoiceD.Location = new System.Drawing.Point(21, 125);
            this.ChoiceD.Name = "ChoiceD";
            this.ChoiceD.Size = new System.Drawing.Size(33, 17);
            this.ChoiceD.TabIndex = 2;
            this.ChoiceD.TabStop = true;
            this.ChoiceD.Text = "D";
            this.ChoiceD.UseVisualStyleBackColor = true;
            // 
            // ChoiceC
            // 
            this.ChoiceC.AutoSize = true;
            this.ChoiceC.Enabled = false;
            this.ChoiceC.Location = new System.Drawing.Point(21, 102);
            this.ChoiceC.Name = "ChoiceC";
            this.ChoiceC.Size = new System.Drawing.Size(32, 17);
            this.ChoiceC.TabIndex = 2;
            this.ChoiceC.TabStop = true;
            this.ChoiceC.Text = "C";
            this.ChoiceC.UseVisualStyleBackColor = true;
            // 
            // ChoiceB
            // 
            this.ChoiceB.AutoSize = true;
            this.ChoiceB.Enabled = false;
            this.ChoiceB.Location = new System.Drawing.Point(21, 79);
            this.ChoiceB.Name = "ChoiceB";
            this.ChoiceB.Size = new System.Drawing.Size(32, 17);
            this.ChoiceB.TabIndex = 2;
            this.ChoiceB.TabStop = true;
            this.ChoiceB.Text = "B";
            this.ChoiceB.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back.Enabled = false;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(17, 240);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.BackColor = System.Drawing.SystemColors.Control;
            this.Next.Enabled = false;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(454, 240);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // PageNo
            // 
            this.PageNo.AutoSize = true;
            this.PageNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.PageNo.Location = new System.Drawing.Point(392, 245);
            this.PageNo.Name = "PageNo";
            this.PageNo.Size = new System.Drawing.Size(32, 13);
            this.PageNo.TabIndex = 5;
            this.PageNo.Text = "Page";
            // 
            // OpenFile
            // 
            this.OpenFile.DefaultExt = "json";
            this.OpenFile.FileName = "FileName";
            this.OpenFile.Filter = "JSON Files|*.json";
            // 
            // QuizTimer
            // 
            this.QuizTimer.Interval = 1000;
            this.QuizTimer.Tick += new System.EventHandler(this.OnTimerElapsed);
            // 
            // QuizProgress
            // 
            this.QuizProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuizProgress.ForeColor = System.Drawing.Color.Green;
            this.QuizProgress.Location = new System.Drawing.Point(98, 240);
            this.QuizProgress.Name = "QuizProgress";
            this.QuizProgress.Size = new System.Drawing.Size(288, 23);
            this.QuizProgress.TabIndex = 0;
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.AutoSize = true;
            this.TimeElapsed.BackColor = System.Drawing.Color.MidnightBlue;
            this.TimeElapsed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeElapsed.Location = new System.Drawing.Point(451, 41);
            this.TimeElapsed.Name = "TimeElapsed";
            this.TimeElapsed.Size = new System.Drawing.Size(34, 13);
            this.TimeElapsed.TabIndex = 6;
            this.TimeElapsed.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 53);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Location = new System.Drawing.Point(1, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(544, 197);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 274);
            this.Controls.Add(this.TimeElapsed);
            this.Controls.Add(this.PageNo);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.QuizLabel);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.QuizProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Answer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz ";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.QuestionBox.ResumeLayout(false);
            this.QuestionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAQuizToolStripMenuItem;
        private System.Windows.Forms.Label QuizLabel;
        private System.Windows.Forms.RadioButton ChoiceA;
        private System.Windows.Forms.GroupBox QuestionBox;
        private System.Windows.Forms.RadioButton ChoiceD;
        private System.Windows.Forms.RadioButton ChoiceC;
        private System.Windows.Forms.RadioButton ChoiceB;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label PageNo;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Timer QuizTimer;
        private System.Windows.Forms.ProgressBar QuizProgress;
        private System.Windows.Forms.Label TimeElapsed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

