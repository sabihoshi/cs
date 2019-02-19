namespace Login
{
    partial class NewUser
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
            System.Windows.Forms.Label UserPassLbl;
            System.Windows.Forms.Label UserNameLbl;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.LoginStart = new System.Windows.Forms.Button();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassCheck = new System.Windows.Forms.TextBox();
            UserPassLbl = new System.Windows.Forms.Label();
            UserNameLbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginStart
            // 
            this.LoginStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginStart.Location = new System.Drawing.Point(234, 199);
            this.LoginStart.Name = "LoginStart";
            this.LoginStart.Size = new System.Drawing.Size(81, 25);
            this.LoginStart.TabIndex = 4;
            this.LoginStart.Text = "Create";
            this.LoginStart.UseVisualStyleBackColor = false;
            this.LoginStart.Click += new System.EventHandler(this.LoginStart_Click);
            // 
            // UserPassLbl
            // 
            UserPassLbl.AutoSize = true;
            UserPassLbl.BackColor = System.Drawing.Color.Transparent;
            UserPassLbl.Location = new System.Drawing.Point(17, 98);
            UserPassLbl.Name = "UserPassLbl";
            UserPassLbl.Size = new System.Drawing.Size(53, 13);
            UserPassLbl.TabIndex = 5;
            UserPassLbl.Text = "Password";
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.BackColor = System.Drawing.Color.Transparent;
            UserNameLbl.Location = new System.Drawing.Point(17, 59);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new System.Drawing.Size(55, 13);
            UserNameLbl.TabIndex = 6;
            UserNameLbl.Text = "Username";
            // 
            // UserPass
            // 
            this.UserPass.Location = new System.Drawing.Point(20, 114);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(295, 20);
            this.UserPass.TabIndex = 2;
            this.UserPass.UseSystemPasswordChar = true;
            this.UserPass.WordWrap = false;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(20, 75);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(295, 20);
            this.UserName.TabIndex = 1;
            this.UserName.WordWrap = false;
            // 
            // UserPassCheck
            // 
            this.UserPassCheck.Location = new System.Drawing.Point(20, 153);
            this.UserPassCheck.Name = "UserPassCheck";
            this.UserPassCheck.Size = new System.Drawing.Size(295, 20);
            this.UserPassCheck.TabIndex = 3;
            this.UserPassCheck.UseSystemPasswordChar = true;
            this.UserPassCheck.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(17, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 13);
            label1.TabIndex = 5;
            label1.Text = "Re-enter Password";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(332, 252);
            this.Controls.Add(this.LoginStart);
            this.Controls.Add(label1);
            this.Controls.Add(UserPassLbl);
            this.Controls.Add(this.UserPassCheck);
            this.Controls.Add(UserNameLbl);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.Text = "Create an Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginStart;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassCheck;
    }
}