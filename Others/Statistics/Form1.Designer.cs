namespace Statistics
{
    partial class Statistic
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
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.ReplacementCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.GetResults = new MaterialSkin.Controls.MaterialFlatButton();
            this.SampleSize = new System.Windows.Forms.NumericUpDown();
            this.SampleBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SampleSize)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(13, 62);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(184, 26);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "";
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(203, 62);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(268, 204);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.Text = "";
            // 
            // ReplacementCheck
            // 
            this.ReplacementCheck.AutoSize = true;
            this.ReplacementCheck.Checked = true;
            this.ReplacementCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplacementCheck.Depth = 0;
            this.ReplacementCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.ReplacementCheck.Location = new System.Drawing.Point(162, 279);
            this.ReplacementCheck.Margin = new System.Windows.Forms.Padding(0);
            this.ReplacementCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ReplacementCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReplacementCheck.Name = "ReplacementCheck";
            this.ReplacementCheck.Ripple = true;
            this.ReplacementCheck.Size = new System.Drawing.Size(111, 30);
            this.ReplacementCheck.TabIndex = 1;
            this.ReplacementCheck.Text = "Replacement";
            this.ReplacementCheck.UseVisualStyleBackColor = true;
            // 
            // GetResults
            // 
            this.GetResults.AutoSize = true;
            this.GetResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetResults.Depth = 0;
            this.GetResults.Location = new System.Drawing.Point(13, 275);
            this.GetResults.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GetResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.GetResults.Name = "GetResults";
            this.GetResults.Primary = false;
            this.GetResults.Size = new System.Drawing.Size(145, 36);
            this.GetResults.TabIndex = 2;
            this.GetResults.Text = "Calculate Sample";
            this.GetResults.UseVisualStyleBackColor = true;
            this.GetResults.Click += new System.EventHandler(this.GetResults_Click);
            // 
            // SampleSize
            // 
            this.SampleSize.Location = new System.Drawing.Point(13, 320);
            this.SampleSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SampleSize.Name = "SampleSize";
            this.SampleSize.Size = new System.Drawing.Size(120, 20);
            this.SampleSize.TabIndex = 3;
            this.SampleSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SampleBox
            // 
            this.SampleBox.Location = new System.Drawing.Point(12, 94);
            this.SampleBox.Name = "SampleBox";
            this.SampleBox.ReadOnly = true;
            this.SampleBox.Size = new System.Drawing.Size(184, 172);
            this.SampleBox.TabIndex = 0;
            this.SampleBox.Text = "";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 374);
            this.Controls.Add(this.SampleSize);
            this.Controls.Add(this.GetResults);
            this.Controls.Add(this.ReplacementCheck);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.SampleBox);
            this.Controls.Add(this.InputBox);
            this.Name = "Statistic";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SampleSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.RichTextBox OutputBox;
        private MaterialSkin.Controls.MaterialCheckBox ReplacementCheck;
        private MaterialSkin.Controls.MaterialFlatButton GetResults;
        private System.Windows.Forms.NumericUpDown SampleSize;
        private System.Windows.Forms.RichTextBox SampleBox;
    }
}

