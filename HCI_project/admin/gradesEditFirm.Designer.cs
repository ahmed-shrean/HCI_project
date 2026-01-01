namespace HCI_project.admin
{
    partial class gradesEditFirm
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
            add = new Button();
            cmbCourses = new ComboBox();
            label1 = new Label();
            btnhome = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtscore = new TextBox();
            txtstuname = new TextBox();
            txtexname = new TextBox();
            txtmaxscore = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(194, 375);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 15;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += button2_Click;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(266, 72);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(121, 23);
            cmbCourses.TabIndex = 13;
            cmbCourses.SelectedIndexChanged += comCourse_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 75);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 12;
            label1.Text = "course name";
            label1.Click += label1_Click;
            // 
            // btnhome
            // 
            btnhome.Location = new Point(36, 29);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 19;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 251);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 20;
            label2.Text = "student score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 184);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 21;
            label3.Text = "student name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 124);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 22;
            label5.Text = "exam name";
            // 
            // txtscore
            // 
            txtscore.Location = new Point(266, 248);
            txtscore.Name = "txtscore";
            txtscore.Size = new Size(100, 23);
            txtscore.TabIndex = 24;
            txtscore.KeyPress += txtscore_KeyPress;
            // 
            // txtstuname
            // 
            txtstuname.Location = new Point(266, 181);
            txtstuname.Name = "txtstuname";
            txtstuname.Size = new Size(100, 23);
            txtstuname.TabIndex = 25;
            // 
            // txtexname
            // 
            txtexname.Location = new Point(266, 124);
            txtexname.Name = "txtexname";
            txtexname.Size = new Size(100, 23);
            txtexname.TabIndex = 26;
            txtexname.TextChanged += textBox3_TextChanged;
            // 
            // txtmaxscore
            // 
            txtmaxscore.Location = new Point(268, 301);
            txtmaxscore.Name = "txtmaxscore";
            txtmaxscore.Size = new Size(100, 23);
            txtmaxscore.TabIndex = 28;
            txtmaxscore.TextChanged += txtmaxscore_TextChanged;
            txtmaxscore.KeyPress += txtmaxscore_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 304);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 27;
            label7.Text = "max score";
            // 
            // gradesEditFirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtmaxscore);
            Controls.Add(label7);
            Controls.Add(txtexname);
            Controls.Add(txtstuname);
            Controls.Add(txtscore);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnhome);
            Controls.Add(add);
            Controls.Add(cmbCourses);
            Controls.Add(label1);
            Name = "gradesEditFirm";
            Text = "gradesEditFirm";
            Load += gradesEditFirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button add;
        private ComboBox cmbCourses;
        private Label label1;
        private Button btnhome;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtscore;
        private TextBox txtstuname;
        private TextBox txtexname;
        private TextBox txtmaxscore;
        private Label label7;
    }
}