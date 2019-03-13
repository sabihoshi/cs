namespace Library.Forms
{
    partial class Interface
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookList = new System.Windows.Forms.ListBox();
            this.GenreName = new System.Windows.Forms.ComboBox();
            this.TypeName = new System.Windows.Forms.ComboBox();
            this.NameCheck = new System.Windows.Forms.CheckBox();
            this.AuthorCheck = new System.Windows.Forms.CheckBox();
            this.GenreCheck = new System.Windows.Forms.CheckBox();
            this.TypeCheck = new System.Windows.Forms.CheckBox();
            this.ReadBook = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 18);
            label2.TabIndex = 3;
            label2.Text = "Find a book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 3;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 128);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 168);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 13);
            label5.TabIndex = 3;
            label5.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 13);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(334, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnABookToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // returnABookToolStripMenuItem
            // 
            this.returnABookToolStripMenuItem.Name = "returnABookToolStripMenuItem";
            this.returnABookToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.returnABookToolStripMenuItem.Text = "Return a book...";
            this.returnABookToolStripMenuItem.Click += new System.EventHandler(this.returnABookToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(12, 105);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(112, 20);
            this.AuthorName.TabIndex = 6;
            this.AuthorName.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(12, 66);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(112, 20);
            this.BookName.TabIndex = 6;
            this.BookName.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(151, 58);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(171, 147);
            this.BookList.Sorted = true;
            this.BookList.TabIndex = 8;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // GenreName
            // 
            this.GenreName.FormattingEnabled = true;
            this.GenreName.Location = new System.Drawing.Point(12, 144);
            this.GenreName.Name = "GenreName";
            this.GenreName.Size = new System.Drawing.Size(112, 21);
            this.GenreName.Sorted = true;
            this.GenreName.TabIndex = 9;
            this.GenreName.SelectionChangeCommitted += new System.EventHandler(this.FilterChanged);
            // 
            // TypeName
            // 
            this.TypeName.FormattingEnabled = true;
            this.TypeName.Location = new System.Drawing.Point(12, 184);
            this.TypeName.Name = "TypeName";
            this.TypeName.Size = new System.Drawing.Size(112, 21);
            this.TypeName.Sorted = true;
            this.TypeName.TabIndex = 9;
            this.TypeName.SelectionChangeCommitted += new System.EventHandler(this.FilterChanged);
            // 
            // NameCheck
            // 
            this.NameCheck.AutoSize = true;
            this.NameCheck.Location = new System.Drawing.Point(130, 72);
            this.NameCheck.Name = "NameCheck";
            this.NameCheck.Size = new System.Drawing.Size(15, 14);
            this.NameCheck.TabIndex = 10;
            this.NameCheck.UseVisualStyleBackColor = true;
            this.NameCheck.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // AuthorCheck
            // 
            this.AuthorCheck.AutoSize = true;
            this.AuthorCheck.Location = new System.Drawing.Point(130, 111);
            this.AuthorCheck.Name = "AuthorCheck";
            this.AuthorCheck.Size = new System.Drawing.Size(15, 14);
            this.AuthorCheck.TabIndex = 10;
            this.AuthorCheck.UseVisualStyleBackColor = true;
            this.AuthorCheck.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // GenreCheck
            // 
            this.GenreCheck.AutoSize = true;
            this.GenreCheck.Location = new System.Drawing.Point(130, 151);
            this.GenreCheck.Name = "GenreCheck";
            this.GenreCheck.Size = new System.Drawing.Size(15, 14);
            this.GenreCheck.TabIndex = 10;
            this.GenreCheck.UseVisualStyleBackColor = true;
            this.GenreCheck.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // TypeCheck
            // 
            this.TypeCheck.AutoSize = true;
            this.TypeCheck.Location = new System.Drawing.Point(130, 191);
            this.TypeCheck.Name = "TypeCheck";
            this.TypeCheck.Size = new System.Drawing.Size(15, 14);
            this.TypeCheck.TabIndex = 10;
            this.TypeCheck.UseVisualStyleBackColor = true;
            this.TypeCheck.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // ReadBook
            // 
            this.ReadBook.Enabled = false;
            this.ReadBook.Location = new System.Drawing.Point(247, 211);
            this.ReadBook.Name = "ReadBook";
            this.ReadBook.Size = new System.Drawing.Size(75, 23);
            this.ReadBook.TabIndex = 11;
            this.ReadBook.Text = "Read";
            this.ReadBook.UseVisualStyleBackColor = true;
            this.ReadBook.Click += new System.EventHandler(this.ReadBook_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 252);
            this.Controls.Add(this.ReadBook);
            this.Controls.Add(this.TypeCheck);
            this.Controls.Add(this.GenreCheck);
            this.Controls.Add(this.AuthorCheck);
            this.Controls.Add(this.NameCheck);
            this.Controls.Add(this.TypeName);
            this.Controls.Add(this.GenreName);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(label2);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnABookToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.ComboBox GenreName;
        private System.Windows.Forms.ComboBox TypeName;
        private System.Windows.Forms.CheckBox NameCheck;
        private System.Windows.Forms.CheckBox AuthorCheck;
        private System.Windows.Forms.CheckBox GenreCheck;
        private System.Windows.Forms.CheckBox TypeCheck;
        private System.Windows.Forms.Button ReadBook;
    }
}