namespace HCI_project.admin
{
    partial class editecouresForm
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
            edite = new Button();
            button1 = new Button();
            label1 = new Label();
            txtCourseCode = new TextBox();
            label3 = new Label();
            btnhome = new Button();
            cmbCourses = new ComboBox();
            label2 = new Label();
            txtCreditHours = new TextBox();
            SuspendLayout();
            // 
            // edite
            // 
            edite.Location = new Point(154, 345);
            edite.Name = "edite";
            edite.Size = new Size(75, 23);
            edite.TabIndex = 7;
            edite.Text = "edite";
            edite.UseVisualStyleBackColor = true;
            edite.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(402, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 102);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "course name";
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(285, 154);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(100, 23);
            txtCourseCode.TabIndex = 10;
            txtCourseCode.TextChanged += txtCourseCode_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 154);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "code";
            // 
            // btnhome
            // 
            btnhome.Location = new Point(22, 23);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 12;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(285, 102);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(121, 23);
            cmbCourses.TabIndex = 13;
            cmbCourses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 225);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 14;
            label2.Text = "creadit hourse";
            // 
            // txtCreditHours
            // 
            txtCreditHours.Location = new Point(285, 222);
            txtCreditHours.Name = "txtCreditHours";
            txtCreditHours.Size = new Size(100, 23);
            txtCreditHours.TabIndex = 15;
            txtCreditHours.KeyPress += txtCreditHours_KeyPress;
            // 
            // editecouresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCreditHours);
            Controls.Add(label2);
            Controls.Add(cmbCourses);
            Controls.Add(btnhome);
            Controls.Add(txtCourseCode);
            Controls.Add(label3);
            Controls.Add(edite);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "editecouresForm";
            Text = "changecouresForm";
            Load += addcouresForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button edite;
        private Button button1;
        private Label label1;
        private TextBox txtCourseCode;
        private Label label3;
        private Button btnhome;
        private ComboBox cmbCourses;
        private Label label2;
        private TextBox txtCreditHours;
    }
}