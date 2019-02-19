namespace Login
{
    partial class Confirmation
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
            System.Windows.Forms.Label Label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.UserPassLbl = new System.Windows.Forms.Label();
            this.LoginStart = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.Transparent;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.Location = new System.Drawing.Point(20, 9);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(300, 62);
            Label1.TabIndex = 4;
            Label1.Text = "Login again to confirm your identity";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(25, 99);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(295, 20);
            this.UserName.TabIndex = 1;
            this.UserName.WordWrap = false;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLbl.Location = new System.Drawing.Point(22, 83);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(55, 13);
            this.UserNameLbl.TabIndex = 2;
            this.UserNameLbl.Text = "Username";
            // 
            // UserPass
            // 
            this.UserPass.Location = new System.Drawing.Point(25, 138);
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
            this.UserPassLbl.Location = new System.Drawing.Point(22, 122);
            this.UserPassLbl.Name = "UserPassLbl";
            this.UserPassLbl.Size = new System.Drawing.Size(53, 13);
            this.UserPassLbl.TabIndex = 2;
            this.UserPassLbl.Text = "Password";
            // 
            // LoginStart
            // 
            this.LoginStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginStart.Location = new System.Drawing.Point(239, 164);
            this.LoginStart.Name = "LoginStart";
            this.LoginStart.Size = new System.Drawing.Size(81, 25);
            this.LoginStart.TabIndex = 3;
            this.LoginStart.Text = "Login";
            this.LoginStart.UseVisualStyleBackColor = false;
            this.LoginStart.Click += new System.EventHandler(this.LoginStart_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::GitHubPseudo.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(347, 201);
            this.Controls.Add(Label1);
            this.Controls.Add(this.LoginStart);
            this.Controls.Add(this.UserPassLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmation";
            this.Text = "GitHubPub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Label UserPassLbl;
        private System.Windows.Forms.Button LoginStart;
    }
}

