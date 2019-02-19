namespace Login
{
    partial class Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.GitHub = new System.Windows.Forms.PictureBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.UserPassLbl = new System.Windows.Forms.Label();
            this.LoginStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // GitHub
            // 
            this.GitHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GitHub.BackColor = System.Drawing.Color.Transparent;
            this.GitHub.Image = ((System.Drawing.Image)(resources.GetObject("GitHub.Image")));
            this.GitHub.Location = new System.Drawing.Point(25, 12);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(298, 84);
            this.GitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHub.TabIndex = 0;
            this.GitHub.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(25, 135);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(295, 20);
            this.UserName.TabIndex = 1;
            this.UserName.WordWrap = false;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLbl.Location = new System.Drawing.Point(22, 119);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(55, 13);
            this.UserNameLbl.TabIndex = 2;
            this.UserNameLbl.Text = "Username";
            // 
            // UserPass
            // 
            this.UserPass.Location = new System.Drawing.Point(25, 174);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(295, 20);
            this.UserPass.TabIndex = 2;
            this.UserPass.UseSystemPasswordChar = true;
            this.UserPass.WordWrap = false;
            // 
            // UserPassLbl
            // 
            this.UserPassLbl.AutoSize = true;
            this.UserPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserPassLbl.Location = new System.Drawing.Point(22, 158);
            this.UserPassLbl.Name = "UserPassLbl";
            this.UserPassLbl.Size = new System.Drawing.Size(53, 13);
            this.UserPassLbl.TabIndex = 2;
            this.UserPassLbl.Text = "Password";
            // 
            // LoginStart
            // 
            this.LoginStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginStart.Location = new System.Drawing.Point(239, 200);
            this.LoginStart.Name = "LoginStart";
            this.LoginStart.Size = new System.Drawing.Size(81, 25);
            this.LoginStart.TabIndex = 3;
            this.LoginStart.Text = "Login";
            this.LoginStart.UseVisualStyleBackColor = false;
            this.LoginStart.Click += new System.EventHandler(this.LoginStart_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.LoginStart);
            this.Controls.Add(this.UserPassLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.GitHub);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entry";
            this.Text = "GitHubPub";
            this.Load += new System.EventHandler(this.Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GitHub;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Label UserPassLbl;
        private System.Windows.Forms.Button LoginStart;
    }
}

