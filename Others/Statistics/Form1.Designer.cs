namespace Statistics
{
    partial class Form1
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
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.SampleSize = new System.Windows.Forms.NumericUpDown();
            this.GetResult = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.ReplacementCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SampleSize)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 77);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(159, 194);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "";
            // 
            // SampleSize
            // 
            this.SampleSize.Location = new System.Drawing.Point(50, 278);
            this.SampleSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SampleSize.Name = "SampleSize";
            this.SampleSize.Size = new System.Drawing.Size(120, 20);
            this.SampleSize.TabIndex = 1;
            this.SampleSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(94, 305);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(75, 23);
            this.GetResult.TabIndex = 2;
            this.GetResult.Text = "Get Sample";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(177, 77);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(157, 194);
            this.ResultBox.TabIndex = 3;
            this.ResultBox.Text = "";
            // 
            // ReplacementCheck
            // 
            this.ReplacementCheck.AutoSize = true;
            this.ReplacementCheck.Checked = true;
            this.ReplacementCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplacementCheck.Location = new System.Drawing.Point(12, 309);
            this.ReplacementCheck.Name = "ReplacementCheck";
            this.ReplacementCheck.Size = new System.Drawing.Size(74, 17);
            this.ReplacementCheck.TabIndex = 4;
            this.ReplacementCheck.Text = "Repetition";
            this.ReplacementCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReplacementCheck);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.SampleSize);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SampleSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.NumericUpDown SampleSize;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.CheckBox ReplacementCheck;
        private System.Windows.Forms.Button GetResult;
    }
}

