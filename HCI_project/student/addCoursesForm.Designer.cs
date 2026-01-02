namespace HCI_project.student
{
    partial class addCoursesForm
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
            label1 = new Label();
            cmbCourses = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtCreditHour = new TextBox();
            txtCode = new TextBox();
            label4 = new Label();
            btnhome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 78);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "course name";
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(311, 78);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(121, 23);
            cmbCourses.TabIndex = 1;
            cmbCourses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(428, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(180, 305);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 204);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "creadet hour";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 149);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "code";
            // 
            // txtCreditHour
            // 
            txtCreditHour.Location = new Point(311, 209);
            txtCreditHour.Name = "txtCreditHour";
            txtCreditHour.Size = new Size(100, 23);
            txtCreditHour.TabIndex = 7;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(311, 149);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 271);
            label4.Name = "label4";
            label4.Size = new Size(230, 15);
            label4.TabIndex = 9;
            label4.Text = "لما يختار الماده بيظهر الكود الساعات المعتمده";
            // 
            // btnhome
            // 
            btnhome.Location = new Point(32, 42);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 10;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // addCoursesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnhome);
            Controls.Add(label4);
            Controls.Add(txtCode);
            Controls.Add(txtCreditHour);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbCourses);
            Controls.Add(label1);
            Name = "addCoursesForm";
            Text = "addCoursesForm";
            Load += addCoursesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCourses;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox txtCreditHour;
        private TextBox txtCode;
        private Label label4;
        private Button btnhome;
    }
}