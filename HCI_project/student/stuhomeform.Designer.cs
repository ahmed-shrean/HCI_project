namespace HCI_project.student
{
    partial class stuhomeform
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblGPA = new Label();
            btnCourses = new Button();
            btnNotes = new Button();
            btnGrades = new Button();
            btnLogout = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAddCourse = new Button();
            btnAddNote = new Button();
            btnAddTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(224, 274);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(65, 15);
            lblGPA.TabIndex = 0;
            lblGPA.Text = "your gpa is";
            lblGPA.Click += labGPA_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(46, 12);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(115, 50);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "my courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(46, 112);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(115, 50);
            btnNotes.TabIndex = 2;
            btnNotes.Text = "notes";
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnGrades
            // 
            btnGrades.Location = new Point(46, 239);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(115, 50);
            btnGrades.TabIndex = 4;
            btnGrades.Text = "grades";
            btnGrades.UseVisualStyleBackColor = true;
            btnGrades.Click += btnGrades_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(34, 403);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 208);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(342, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(425, 219);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(421, 376);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(115, 50);
            btnAddCourse.TabIndex = 8;
            btnAddCourse.Text = "add course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(197, 376);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(115, 50);
            btnAddNote.TabIndex = 9;
            btnAddNote.Text = "add note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(600, 376);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(115, 50);
            btnAddTask.TabIndex = 10;
            btnAddTask.Text = "add task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // stuhomeform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddTask);
            Controls.Add(btnAddNote);
            Controls.Add(btnAddCourse);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnGrades);
            Controls.Add(btnNotes);
            Controls.Add(btnCourses);
            Controls.Add(lblGPA);
            Name = "stuhomeform";
            Text = "stuhomeform";
            Load += stuhomeform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGPA;
        private Button btnCourses;
        private Button btnNotes;
        private Button btnGrades;
        private Button btnLogout;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAddCourse;
        private Button btnAddNote;
        private Button btnAddTask;
    }
}