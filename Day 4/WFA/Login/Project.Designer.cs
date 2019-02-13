namespace Login
{
    partial class Project
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
            this.ProjectList = new System.Windows.Forms.ComboBox();
            this.ProjectLbl = new System.Windows.Forms.Label();
            this.LengthLbl = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.LengthList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ProjectList
            // 
            this.ProjectList.FormattingEnabled = true;
            this.ProjectList.Items.AddRange(new object[] {
            "...",
            "C#",
            "C++",
            "Python",
            "BBTag"});
            this.ProjectList.Location = new System.Drawing.Point(12, 25);
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.Size = new System.Drawing.Size(97, 21);
            this.ProjectList.TabIndex = 0;
            this.ProjectList.Text = "...";
            // 
            // ProjectLbl
            // 
            this.ProjectLbl.AutoSize = true;
            this.ProjectLbl.Location = new System.Drawing.Point(12, 9);
            this.ProjectLbl.Name = "ProjectLbl";
            this.ProjectLbl.Size = new System.Drawing.Size(28, 13);
            this.ProjectLbl.TabIndex = 1;
            this.ProjectLbl.Text = "Plan";
            // 
            // LengthLbl
            // 
            this.LengthLbl.AutoSize = true;
            this.LengthLbl.Location = new System.Drawing.Point(12, 58);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(40, 13);
            this.LengthLbl.TabIndex = 1;
            this.LengthLbl.Text = "Length";
            // 
            // richTextBox
            // 
            this.richTextBox.Enabled = false;
            this.richTextBox.Location = new System.Drawing.Point(122, 26);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(163, 327);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // LengthList
            // 
            this.LengthList.FormattingEnabled = true;
            this.LengthList.Items.AddRange(new object[] {
            "...",
            "1 month",
            "3 months",
            "6 months",
            "1 year"});
            this.LengthList.Location = new System.Drawing.Point(12, 74);
            this.LengthList.Name = "LengthList";
            this.LengthList.Size = new System.Drawing.Size(97, 21);
            this.LengthList.TabIndex = 3;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 372);
            this.Controls.Add(this.LengthList);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.LengthLbl);
            this.Controls.Add(this.ProjectLbl);
            this.Controls.Add(this.ProjectList);
            this.Name = "Project";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProjectList;
        private System.Windows.Forms.Label ProjectLbl;
        private System.Windows.Forms.Label LengthLbl;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox LengthList;
    }
}