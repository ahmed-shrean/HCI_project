namespace HCI_project.admin
{
    partial class addcouresForm
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            txtCourseCode = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnhome = new Button();
            cmbCourses = new ComboBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(145, 237);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(393, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 218);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 11;
            label4.Text = "لما يختار الماده بيظهر الكود";
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
            // addcouresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCourses);
            Controls.Add(btnhome);
            Controls.Add(label4);
            Controls.Add(txtCourseCode);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "addcouresForm";
            Text = "addcouresForm";
            Load += addcouresForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox txtCourseCode;
        private Label label3;
        private Label label4;
        private Button btnhome;
        private ComboBox cmbCourses;
    }
}