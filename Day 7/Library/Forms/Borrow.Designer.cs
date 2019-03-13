namespace Library.Forms
{
    partial class Borrow
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookType = new System.Windows.Forms.TextBox();
            this.BookGenre = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BorrowBook = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 1;
            label1.Text = "Length of read";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 24);
            label2.TabIndex = 2;
            label2.Text = "Borrow Book";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(136, 72);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 13);
            label5.TabIndex = 1;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 72);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 13);
            label6.TabIndex = 1;
            label6.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(136, 33);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 1;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 13);
            label3.TabIndex = 1;
            label3.Text = "Title";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(16, 127);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(240, 20);
            this.DateTimePicker.TabIndex = 0;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(139, 49);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.ReadOnly = true;
            this.BookAuthor.Size = new System.Drawing.Size(117, 20);
            this.BookAuthor.TabIndex = 3;
            // 
            // BookType
            // 
            this.BookType.Location = new System.Drawing.Point(139, 88);
            this.BookType.Name = "BookType";
            this.BookType.ReadOnly = true;
            this.BookType.Size = new System.Drawing.Size(117, 20);
            this.BookType.TabIndex = 3;
            // 
            // BookGenre
            // 
            this.BookGenre.Location = new System.Drawing.Point(16, 88);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.ReadOnly = true;
            this.BookGenre.Size = new System.Drawing.Size(117, 20);
            this.BookGenre.TabIndex = 3;
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(16, 49);
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Size = new System.Drawing.Size(117, 20);
            this.BookName.TabIndex = 3;
            // 
            // BorrowBook
            // 
            this.BorrowBook.Location = new System.Drawing.Point(180, 154);
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.Size = new System.Drawing.Size(75, 23);
            this.BorrowBook.TabIndex = 4;
            this.BorrowBook.Text = "Borrow";
            this.BorrowBook.UseVisualStyleBackColor = true;
            this.BorrowBook.Click += new System.EventHandler(this.BorrowBook_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 191);
            this.Controls.Add(this.BorrowBook);
            this.Controls.Add(label3);
            this.Controls.Add(this.BookName);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(this.BookGenre);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(label6);
            this.Controls.Add(this.BookType);
            this.Controls.Add(label5);
            this.Controls.Add(label1);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.TextBox BookType;
        private System.Windows.Forms.TextBox BookGenre;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Button BorrowBook;
    }
}