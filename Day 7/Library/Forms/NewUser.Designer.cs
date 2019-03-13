namespace Library.Forms
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label UserPassLbl;
            System.Windows.Forms.Label UserNameLbl;
            this.LoginStart = new System.Windows.Forms.Button();
            this.UserPassCheck = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            UserPassLbl = new System.Windows.Forms.Label();
            UserNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(10, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(195, 29);
            label2.TabIndex = 15;
            label2.Text = "Account Creation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 13);
            label1.TabIndex = 12;
            label1.Text = "Re-enter Password";
            // 
            // UserPassLbl
            // 
            UserPassLbl.AutoSize = true;
            UserPassLbl.BackColor = System.Drawing.Color.Transparent;
            UserPassLbl.ForeColor = System.Drawing.Color.White;
            UserPassLbl.Location = new System.Drawing.Point(12, 99);
            UserPassLbl.Name = "UserPassLbl";
            UserPassLbl.Size = new System.Drawing.Size(53, 13);
            UserPassLbl.TabIndex = 13;
            UserPassLbl.Text = "Password";
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.BackColor = System.Drawing.Color.Transparent;
            UserNameLbl.ForeColor = System.Drawing.Color.White;
            UserNameLbl.Location = new System.Drawing.Point(12, 60);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new System.Drawing.Size(55, 13);
            UserNameLbl.TabIndex = 14;
            UserNameLbl.Text = "Username";
            // 
            // LoginStart
            // 
            this.LoginStart.BackColor = System.Drawing.Color.White;
            this.LoginStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginStart.Location = new System.Drawing.Point(164, 180);
            this.LoginStart.Name = "LoginStart";
            this.LoginStart.Size = new System.Drawing.Size(81, 25);
            this.LoginStart.TabIndex = 4;
            this.LoginStart.Text = "Create";
            this.LoginStart.UseVisualStyleBackColor = false;
            this.LoginStart.Click += new System.EventHandler(this.LoginStart_Click);
            // 
            // UserPassCheck
            // 
            this.UserPassCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPassCheck.Location = new System.Drawing.Point(12, 154);
            this.UserPassCheck.Name = "UserPassCheck";
            this.UserPassCheck.Size = new System.Drawing.Size(233, 20);
            this.UserPassCheck.TabIndex = 3;
            this.UserPassCheck.UseSystemPasswordChar = true;
            this.UserPassCheck.WordWrap = false;
            // 
            // UserPass
            // 
            this.PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWord.Location = new System.Drawing.Point(12, 115);
            this.PassWord.Name = "UserPass";
            this.PassWord.Size = new System.Drawing.Size(233, 20);
            this.PassWord.TabIndex = 2;
            this.PassWord.UseSystemPasswordChar = true;
            this.PassWord.WordWrap = false;
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Location = new System.Drawing.Point(12, 76);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(233, 20);
            this.UserName.TabIndex = 1;
            this.UserName.WordWrap = false;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(257, 217);
            this.Controls.Add(label2);
            this.Controls.Add(this.LoginStart);
            this.Controls.Add(label1);
            this.Controls.Add(UserPassLbl);
            this.Controls.Add(this.UserPassCheck);
            this.Controls.Add(UserNameLbl);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginStart;
        private System.Windows.Forms.TextBox UserPassCheck;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.TextBox UserName;
    }
}