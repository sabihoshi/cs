namespace CIIT_Grading_System.Forms
{
    partial class AddStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudents));
            this.ClassroomList = new System.Windows.Forms.ComboBox();
            this.StudentList = new System.Windows.Forms.ListBox();
            this.AddStudent = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(145, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 4;
            label2.Text = "Classroom";
            // 
            // ClassroomList
            // 
            this.ClassroomList.FormattingEnabled = true;
            this.ClassroomList.Location = new System.Drawing.Point(12, 12);
            this.ClassroomList.Name = "ClassroomList";
            this.ClassroomList.Size = new System.Drawing.Size(127, 21);
            this.ClassroomList.TabIndex = 0;
            this.ClassroomList.SelectedIndexChanged += new System.EventHandler(this.ClassroomList_SelectedIndexChanged);
            // 
            // StudentList
            // 
            this.StudentList.BackColor = System.Drawing.Color.White;
            this.StudentList.FormattingEnabled = true;
            this.StudentList.Location = new System.Drawing.Point(14, 70);
            this.StudentList.Name = "StudentList";
            this.StudentList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.StudentList.Size = new System.Drawing.Size(225, 225);
            this.StudentList.Sorted = true;
            this.StudentList.TabIndex = 1;
            // 
            // AddStudent
            // 
            this.AddStudent.AutoSize = true;
            this.AddStudent.BackColor = System.Drawing.SystemColors.Control;
            this.AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent.Location = new System.Drawing.Point(145, 39);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(76, 25);
            this.AddStudent.TabIndex = 5;
            this.AddStudent.Text = "Add student";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(12, 39);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(127, 20);
            this.StudentName.TabIndex = 6;
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::CIIT_Grading_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(251, 302);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(label2);
            this.Controls.Add(this.ClassroomList);
            this.Controls.Add(this.StudentList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudents";
            this.Text = "AddStudents";
            this.Load += new System.EventHandler(this.AddStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ClassroomList;
        private System.Windows.Forms.ListBox StudentList;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.TextBox StudentName;
    }
}