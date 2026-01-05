namespace HCI_project.admin
{
    partial class adminhomeform
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
            btnGrades = new Button();
            btnCoursesEdit = new Button();
            btnLogout = new Button();
            btnAddCourse = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnGrades
            // 
            btnGrades.Location = new Point(54, 167);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(115, 50);
            btnGrades.TabIndex = 9;
            btnGrades.Text = "add grades";
            btnGrades.UseVisualStyleBackColor = true;
            btnGrades.Click += btnGrades_Click;
            // 
            // btnCoursesEdit
            // 
            btnCoursesEdit.Location = new Point(514, 200);
            btnCoursesEdit.Name = "btnCoursesEdit";
            btnCoursesEdit.Size = new Size(115, 50);
            btnCoursesEdit.TabIndex = 6;
            btnCoursesEdit.Text = "edite or delete courses";
            btnCoursesEdit.UseVisualStyleBackColor = true;
            btnCoursesEdit.Click += btnCoursesEdit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(54, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(514, 293);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(115, 50);
            btnAddCourse.TabIndex = 11;
            btnAddCourse.Text = "add course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // button1
            // 
            button1.Location = new Point(54, 293);
            button1.Name = "button1";
            button1.Size = new Size(115, 50);
            button1.TabIndex = 12;
            button1.Text = "edite and delete grades";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adminhomeform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAddCourse);
            Controls.Add(btnLogout);
            Controls.Add(btnGrades);
            Controls.Add(btnCoursesEdit);
            Name = "adminhomeform";
            Text = "adminhomeform";
            ResumeLayout(false);
        }

        #endregion
        private Button btnGrades;
        private Button btnCoursesEdit;
        private Button btnLogout;
        private Button btnAddCourse;
        private Button button1;
    }
}