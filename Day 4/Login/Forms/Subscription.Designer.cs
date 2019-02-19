namespace Login
{
    partial class Subscription
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
            System.Windows.Forms.Label ProjectLbl;
            System.Windows.Forms.Label LengthLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subscription));
            this.ProjectList = new System.Windows.Forms.ComboBox();
            this.LengthList = new System.Windows.Forms.ComboBox();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.SubTextBox = new System.Windows.Forms.Label();
            ProjectLbl = new System.Windows.Forms.Label();
            LengthLbl = new System.Windows.Forms.Label();
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
            this.ProjectList.SelectedIndexChanged += new System.EventHandler(this.ProjectList_SelectedIndexChanged);
            // 
            // ProjectLbl
            // 
            ProjectLbl.AutoSize = true;
            ProjectLbl.Location = new System.Drawing.Point(12, 9);
            ProjectLbl.Name = "ProjectLbl";
            ProjectLbl.Size = new System.Drawing.Size(28, 13);
            ProjectLbl.TabIndex = 1;
            ProjectLbl.Text = "Plan";
            // 
            // LengthLbl
            // 
            LengthLbl.AutoSize = true;
            LengthLbl.Location = new System.Drawing.Point(12, 49);
            LengthLbl.Name = "LengthLbl";
            LengthLbl.Size = new System.Drawing.Size(40, 13);
            LengthLbl.TabIndex = 1;
            LengthLbl.Text = "Length";
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
            this.LengthList.Location = new System.Drawing.Point(12, 65);
            this.LengthList.Name = "LengthList";
            this.LengthList.Size = new System.Drawing.Size(97, 21);
            this.LengthList.TabIndex = 3;
            this.LengthList.SelectedIndexChanged += new System.EventHandler(this.LengthList_SelectedIndexChanged);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Enabled = false;
            this.PurchaseButton.Location = new System.Drawing.Point(35, 138);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(74, 24);
            this.PurchaseButton.TabIndex = 4;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // SubTextBox
            // 
            this.SubTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SubTextBox.Location = new System.Drawing.Point(115, 9);
            this.SubTextBox.Name = "SubTextBox";
            this.SubTextBox.Size = new System.Drawing.Size(172, 153);
            this.SubTextBox.TabIndex = 5;
            // 
            // Subscription
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(299, 174);
            this.Controls.Add(this.SubTextBox);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.LengthList);
            this.Controls.Add(LengthLbl);
            this.Controls.Add(ProjectLbl);
            this.Controls.Add(this.ProjectList);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subscription";
            this.Text = "Buy Subscription";
            this.Load += new System.EventHandler(this.Subscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProjectList;
        private System.Windows.Forms.ComboBox LengthList;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Label SubTextBox;
    }
}