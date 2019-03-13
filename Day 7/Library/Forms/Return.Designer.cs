namespace Library.Forms
{
    partial class Return
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.ReturnBook = new System.Windows.Forms.Button();
            this.TypeCheck = new System.Windows.Forms.CheckBox();
            this.GenreCheck = new System.Windows.Forms.CheckBox();
            this.AuthorCheck = new System.Windows.Forms.CheckBox();
            this.NameCheck = new System.Windows.Forms.CheckBox();
            this.TypeName = new System.Windows.Forms.ComboBox();
            this.GenreName = new System.Windows.Forms.ComboBox();
            this.BookList = new System.Windows.Forms.ListBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.AuthorName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 18);
            label2.TabIndex = 12;
            label2.Text = "Find a book";
            // 
            // ReturnBook
            // 
            this.ReturnBook.Enabled = false;
            this.ReturnBook.Location = new System.Drawing.Point(247, 196);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(75, 23);
            this.ReturnBook.TabIndex = 22;
            this.ReturnBook.Text = "Return";
            this.ReturnBook.UseVisualStyleBackColor = true;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // TypeCheck
            // 
            this.TypeCheck.AutoSize = true;
            this.TypeCheck.Location = new System.Drawing.Point(130, 176);
            this.TypeCheck.Name = "TypeCheck";
            this.TypeCheck.Size = new System.Drawing.Size(15, 14);
            this.TypeCheck.TabIndex = 18;
            this.TypeCheck.UseVisualStyleBackColor = true;
            // 
            // GenreCheck
            // 
            this.GenreCheck.AutoSize = true;
            this.GenreCheck.Location = new System.Drawing.Point(130, 136);
            this.GenreCheck.Name = "GenreCheck";
            this.GenreCheck.Size = new System.Drawing.Size(15, 14);
            this.GenreCheck.TabIndex = 19;
            this.GenreCheck.UseVisualStyleBackColor = true;
            // 
            // AuthorCheck
            // 
            this.AuthorCheck.AutoSize = true;
            this.AuthorCheck.Location = new System.Drawing.Point(130, 96);
            this.AuthorCheck.Name = "AuthorCheck";
            this.AuthorCheck.Size = new System.Drawing.Size(15, 14);
            this.AuthorCheck.TabIndex = 20;
            this.AuthorCheck.UseVisualStyleBackColor = true;
            // 
            // NameCheck
            // 
            this.NameCheck.AutoSize = true;
            this.NameCheck.Location = new System.Drawing.Point(130, 57);
            this.NameCheck.Name = "NameCheck";
            this.NameCheck.Size = new System.Drawing.Size(15, 14);
            this.NameCheck.TabIndex = 21;
            this.NameCheck.UseVisualStyleBackColor = true;
            // 
            // TypeName
            // 
            this.TypeName.FormattingEnabled = true;
            this.TypeName.Location = new System.Drawing.Point(12, 169);
            this.TypeName.Name = "TypeName";
            this.TypeName.Size = new System.Drawing.Size(112, 21);
            this.TypeName.Sorted = true;
            this.TypeName.TabIndex = 16;
            // 
            // GenreName
            // 
            this.GenreName.FormattingEnabled = true;
            this.GenreName.Location = new System.Drawing.Point(12, 129);
            this.GenreName.Name = "GenreName";
            this.GenreName.Size = new System.Drawing.Size(112, 21);
            this.GenreName.Sorted = true;
            this.GenreName.TabIndex = 17;
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(151, 43);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(171, 147);
            this.BookList.Sorted = true;
            this.BookList.TabIndex = 15;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(12, 51);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(112, 20);
            this.BookName.TabIndex = 13;
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(12, 90);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(112, 20);
            this.AuthorName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 153);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 13);
            label5.TabIndex = 23;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 113);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 24;
            label4.Text = "Genre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 13);
            label1.TabIndex = 25;
            label1.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 26;
            label3.Text = "Author";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 235);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(this.ReturnBook);
            this.Controls.Add(this.TypeCheck);
            this.Controls.Add(this.GenreCheck);
            this.Controls.Add(this.AuthorCheck);
            this.Controls.Add(this.NameCheck);
            this.Controls.Add(this.TypeName);
            this.Controls.Add(this.GenreName);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBook;
        private System.Windows.Forms.CheckBox TypeCheck;
        private System.Windows.Forms.CheckBox GenreCheck;
        private System.Windows.Forms.CheckBox AuthorCheck;
        private System.Windows.Forms.CheckBox NameCheck;
        private System.Windows.Forms.ComboBox TypeName;
        private System.Windows.Forms.ComboBox GenreName;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox AuthorName;
    }
}