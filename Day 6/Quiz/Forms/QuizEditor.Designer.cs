namespace Quiz.Forms
{
    partial class QuizEditor
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PageNo = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.ChoiceD = new System.Windows.Forms.RadioButton();
            this.ChoiceC = new System.Windows.Forms.RadioButton();
            this.ChoiceB = new System.Windows.Forms.RadioButton();
            this.QuestionBox = new System.Windows.Forms.GroupBox();
            this.ChoiceA = new System.Windows.Forms.RadioButton();
            this.QuizLabel = new System.Windows.Forms.Label();
            this.HardMode = new System.Windows.Forms.ToolStripMenuItem();
            this.EasyMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createAQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuestionBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageNo
            // 
            this.PageNo.AutoSize = true;
            this.PageNo.Location = new System.Drawing.Point(254, 254);
            this.PageNo.Name = "PageNo";
            this.PageNo.Size = new System.Drawing.Size(32, 13);
            this.PageNo.TabIndex = 11;
            this.PageNo.Text = "Page";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.Control;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(458, 244);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 9;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.Enabled = false;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(21, 244);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // ChoiceD
            // 
            this.ChoiceD.AutoSize = true;
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
            this.ChoiceB.Location = new System.Drawing.Point(21, 79);
            this.ChoiceB.Name = "ChoiceB";
            this.ChoiceB.Size = new System.Drawing.Size(32, 17);
            this.ChoiceB.TabIndex = 2;
            this.ChoiceB.TabStop = true;
            this.ChoiceB.Text = "B";
            this.ChoiceB.UseVisualStyleBackColor = true;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Controls.Add(this.ChoiceD);
            this.QuestionBox.Controls.Add(this.ChoiceC);
            this.QuestionBox.Controls.Add(this.ChoiceB);
            this.QuestionBox.Controls.Add(this.ChoiceA);
            this.QuestionBox.Location = new System.Drawing.Point(21, 88);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(276, 150);
            this.QuestionBox.TabIndex = 8;
            this.QuestionBox.TabStop = false;
            this.QuestionBox.Text = "Question";
            // 
            // ChoiceA
            // 
            this.ChoiceA.AutoSize = true;
            this.ChoiceA.Location = new System.Drawing.Point(21, 56);
            this.ChoiceA.Name = "ChoiceA";
            this.ChoiceA.Size = new System.Drawing.Size(32, 17);
            this.ChoiceA.TabIndex = 2;
            this.ChoiceA.TabStop = true;
            this.ChoiceA.Text = "A";
            this.ChoiceA.UseVisualStyleBackColor = true;
            // 
            // QuizLabel
            // 
            this.QuizLabel.AutoSize = true;
            this.QuizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLabel.Location = new System.Drawing.Point(19, 45);
            this.QuizLabel.Name = "QuizLabel";
            this.QuizLabel.Size = new System.Drawing.Size(56, 25);
            this.QuizLabel.TabIndex = 7;
            this.QuizLabel.Text = "Quiz";
            // 
            // HardMode
            // 
            this.HardMode.Name = "HardMode";
            this.HardMode.Size = new System.Drawing.Size(123, 22);
            this.HardMode.Text = "Hardcore";
            // 
            // EasyMode
            // 
            this.EasyMode.Name = "EasyMode";
            this.EasyMode.Size = new System.Drawing.Size(123, 22);
            this.EasyMode.Text = "Easy";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EasyMode,
            this.HardMode});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Mode";
            // 
            // createAQuizToolStripMenuItem
            // 
            this.createAQuizToolStripMenuItem.Name = "createAQuizToolStripMenuItem";
            this.createAQuizToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createAQuizToolStripMenuItem.Text = "Create a quiz";
            // 
            // openAQuizToolStripMenuItem
            // 
            this.openAQuizToolStripMenuItem.Name = "openAQuizToolStripMenuItem";
            this.openAQuizToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAQuizToolStripMenuItem.Text = "Open a quiz";
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAQuizToolStripMenuItem,
            this.createAQuizToolStripMenuItem,
            this.toolStripMenuItem1});
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.quizToolStripMenuItem.Text = "Quiz";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "FileName";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.quizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExistingQuizToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openExistingQuizToolStripMenuItem
            // 
            this.openExistingQuizToolStripMenuItem.Name = "openExistingQuizToolStripMenuItem";
            this.openExistingQuizToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openExistingQuizToolStripMenuItem.Text = "Open Existing Quiz";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // addPageToolStripMenuItem
            // 
            this.addPageToolStripMenuItem.Name = "addPageToolStripMenuItem";
            this.addPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPageToolStripMenuItem.Text = "Add Page";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quiz Title";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Question";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(364, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choices";
            this.label4.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(364, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(364, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(364, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "A";
            this.label3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "B";
            this.label5.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "C";
            this.label6.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "D";
            this.label7.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // QuizEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 279);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PageNo);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.QuizLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "QuizEdit";
            this.Text = "Quiz Editor";
            this.QuestionBox.ResumeLayout(false);
            this.QuestionBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PageNo;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RadioButton ChoiceD;
        private System.Windows.Forms.RadioButton ChoiceC;
        private System.Windows.Forms.RadioButton ChoiceB;
        private System.Windows.Forms.GroupBox QuestionBox;
        private System.Windows.Forms.RadioButton ChoiceA;
        private System.Windows.Forms.Label QuizLabel;
        private System.Windows.Forms.ToolStripMenuItem HardMode;
        private System.Windows.Forms.ToolStripMenuItem EasyMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createAQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPageToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}