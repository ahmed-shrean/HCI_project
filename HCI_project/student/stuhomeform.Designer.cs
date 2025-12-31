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
            labGPA = new Label();
            btnCourses = new Button();
            btnNotes = new Button();
            btnGrades = new Button();
            btnLogout = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labGPA
            // 
            labGPA.AutoSize = true;
            labGPA.Location = new Point(334, 55);
            labGPA.Name = "labGPA";
            labGPA.Size = new Size(65, 15);
            labGPA.TabIndex = 0;
            labGPA.Text = "your gpa is";
            labGPA.Click += labGPA_Click;
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
            // 
            // btnGrades
            // 
            btnGrades.Location = new Point(46, 239);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(115, 50);
            btnGrades.TabIndex = 4;
            btnGrades.Text = "grades";
            btnGrades.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(34, 403);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "log out";
            btnLogout.UseVisualStyleBackColor = true;
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(293, 237);
            dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 222);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "حط التسكات في الجدول";
            label2.Click += label2_Click;
            // 
            // stuhomeform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnGrades);
            Controls.Add(btnNotes);
            Controls.Add(btnCourses);
            Controls.Add(labGPA);
            Name = "stuhomeform";
            Text = "stuhomeform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labGPA;
        private Button btnCourses;
        private Button btnNotes;
        private Button btnGrades;
        private Button btnLogout;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
    }
}