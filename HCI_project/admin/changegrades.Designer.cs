namespace HCI_project.admin
{
    partial class changegrades
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
            txtMaxScore = new TextBox();
            label7 = new Label();
            txtScore = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnhome = new Button();
            btnedite = new Button();
            label1 = new Label();
            btndelete = new Button();
            cmbCourses = new ComboBox();
            cmbStudent = new ComboBox();
            cmbExam = new ComboBox();
            SuspendLayout();
            // 
            // txtMaxScore
            // 
            txtMaxScore.Location = new Point(276, 295);
            txtMaxScore.Name = "txtMaxScore";
            txtMaxScore.Size = new Size(100, 23);
            txtMaxScore.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(124, 298);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 39;
            label7.Text = "max score";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(274, 242);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 37;
            txtScore.TextChanged += txtscore_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 184);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 36;
            label5.Text = "exam name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 126);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 35;
            label3.Text = "student name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 245);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 34;
            label2.Text = "student score";
            // 
            // btnhome
            // 
            btnhome.Location = new Point(44, 23);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 33;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            // 
            // btnedite
            // 
            btnedite.Location = new Point(175, 376);
            btnedite.Name = "btnedite";
            btnedite.Size = new Size(75, 23);
            btnedite.TabIndex = 32;
            btnedite.Text = "edite";
            btnedite.UseVisualStyleBackColor = true;
            btnedite.Click += btnedite_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 69);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 30;
            label1.Text = "course name";
            // 
            // btndelete
            // 
            btndelete.Location = new Point(392, 376);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 42;
            btndelete.Text = "delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click_1;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(274, 66);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(121, 23);
            cmbCourses.TabIndex = 43;
            cmbCourses.SelectedIndexChanged += cmbCourses_SelectedIndexChanged;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(276, 126);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(121, 23);
            cmbStudent.TabIndex = 44;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // cmbExam
            // 
            cmbExam.FormattingEnabled = true;
            cmbExam.Location = new Point(274, 181);
            cmbExam.Name = "cmbExam";
            cmbExam.Size = new Size(121, 23);
            cmbExam.TabIndex = 45;
            cmbExam.SelectedIndexChanged += cmbExam_SelectedIndexChanged;
            // 
            // changegrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbExam);
            Controls.Add(cmbStudent);
            Controls.Add(cmbCourses);
            Controls.Add(btndelete);
            Controls.Add(txtMaxScore);
            Controls.Add(label7);
            Controls.Add(txtScore);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnhome);
            Controls.Add(btnedite);
            Controls.Add(label1);
            Name = "changegrades";
            Text = "delete";
            Load += changegrades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMaxScore;
        private Label label7;
        private TextBox txtScore;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnhome;
        private Button btnedite;
        private Label label1;
        private Button btndelete;
        private ComboBox cmbCourses;
        private ComboBox cmbStudent;
        private ComboBox cmbExam;
    }
}