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
            System.Windows.Forms.PictureBox GitHub;
            System.Windows.Forms.Label UserNameLbl;
            System.Windows.Forms.Label UserPassLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.LoginStart = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.LinkLabel();
            GitHub = new System.Windows.Forms.PictureBox();
            UserNameLbl = new System.Windows.Forms.Label();
            UserPassLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(GitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // GitHub
            // 
            GitHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            GitHub.BackColor = System.Drawing.Color.Transparent;
            GitHub.Image = global::GitHubPseudo.Properties.Resources.logo;
            GitHub.Location = new System.Drawing.Point(25, 12);
            GitHub.Name = "GitHub";
            GitHub.Size = new System.Drawing.Size(298, 84);
            GitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            GitHub.TabIndex = 0;
            GitHub.TabStop = false;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.BackColor = System.Drawing.Color.Transparent;
            UserNameLbl.Location = new System.Drawing.Point(22, 119);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new System.Drawing.Size(55, 13);
            UserNameLbl.TabIndex = 2;
            UserNameLbl.Text = "Username";
            // 
            // UserPassLbl
            // 
            UserPassLbl.AutoSize = true;
            UserPassLbl.BackColor = System.Drawing.Color.Transparent;
            UserPassLbl.Location = new System.Drawing.Point(22, 158);
            UserPassLbl.Name = "UserPassLbl";
            UserPassLbl.Size = new System.Drawing.Size(53, 13);
            UserPassLbl.TabIndex = 2;
            UserPassLbl.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(25, 135);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(295, 20);
            this.UserName.TabIndex = 1;
            this.UserName.WordWrap = false;
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
            // CreateAccountButton
            // 
            this.CreateAccountButton.AutoSize = true;
            this.CreateAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.Location = new System.Drawing.Point(22, 206);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(95, 13);
            this.CreateAccountButton.TabIndex = 4;
            this.CreateAccountButton.TabStop = true;
            this.CreateAccountButton.Text = "Create an account";
            this.CreateAccountButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountButton_LinkClicked);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::GitHubPseudo.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.LoginStart);
            this.Controls.Add(UserPassLbl);
            this.Controls.Add(UserNameLbl);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(GitHub);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entry";
            this.Text = "GitHubPub";
            this.Load += new System.EventHandler(this.Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(GitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Button LoginStart;
        private System.Windows.Forms.LinkLabel CreateAccountButton;
    }
}

