namespace HCI_project.student
{
    partial class addtaskForm
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
            btnhome = new Button();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            cmbCourses = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnhome
            // 
            btnhome.Location = new Point(25, 23);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 20;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(311, 168);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 18;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(311, 113);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 171);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 16;
            label3.Text = "discreption";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 121);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 15;
            label2.Text = "titel";
            // 
            // button2
            // 
            button2.Location = new Point(180, 336);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(311, 52);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(121, 23);
            cmbCourses.TabIndex = 12;
            cmbCourses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 60);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 11;
            label1.Text = "course name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(311, 229);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 237);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 22;
            label4.Text = "deadline";
            // 
            // addtaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnhome);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(cmbCourses);
            Controls.Add(label1);
            Name = "addtaskForm";
            Text = "addtaskForm";
            Load += addtaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhome;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Button button2;
        private ComboBox cmbCourses;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
    }
}