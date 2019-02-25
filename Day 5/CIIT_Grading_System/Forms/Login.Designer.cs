namespace CIIT_Grading_System.Forms
{
    partial class Login
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.LinkLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = global::CIIT_Grading_System.Properties.Resources.CIIT_FULL_LOGO;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.MaximumSize = new System.Drawing.Size(269, 76);
            pictureBox1.MinimumSize = new System.Drawing.Size(269, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(269, 76);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 114);
            label1.MaximumSize = new System.Drawing.Size(55, 13);
            label1.MinimumSize = new System.Drawing.Size(55, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 153);
            label2.MaximumSize = new System.Drawing.Size(55, 13);
            label2.MinimumSize = new System.Drawing.Size(55, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Location = new System.Drawing.Point(15, 130);
            this.UserName.MaximumSize = new System.Drawing.Size(266, 20);
            this.UserName.MinimumSize = new System.Drawing.Size(266, 20);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(266, 20);
            this.UserName.TabIndex = 1;
            // 
            // UserPass
            // 
            this.UserPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPass.Location = new System.Drawing.Point(15, 169);
            this.UserPass.MaximumSize = new System.Drawing.Size(266, 20);
            this.UserPass.MinimumSize = new System.Drawing.Size(266, 20);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(266, 20);
            this.UserPass.TabIndex = 2;
            this.UserPass.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(185, 207);
            this.LoginButton.MaximumSize = new System.Drawing.Size(95, 27);
            this.LoginButton.MinimumSize = new System.Drawing.Size(95, 27);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(95, 27);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewUserButton.AutoSize = true;
            this.NewUserButton.BackColor = System.Drawing.Color.Transparent;
            this.NewUserButton.LinkColor = System.Drawing.Color.Aqua;
            this.NewUserButton.Location = new System.Drawing.Point(12, 214);
            this.NewUserButton.MaximumSize = new System.Drawing.Size(93, 13);
            this.NewUserButton.MinimumSize = new System.Drawing.Size(93, 13);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(93, 13);
            this.NewUserButton.TabIndex = 4;
            this.NewUserButton.TabStop = true;
            this.NewUserButton.Text = "Create a new user";
            this.NewUserButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUserButton_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CIIT_Grading_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 246);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(label2);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(309, 285);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel NewUserButton;
    }
}