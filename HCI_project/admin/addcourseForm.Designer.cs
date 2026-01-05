namespace HCI_project.admin
{
    partial class addcourseForm
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
            txtCreditHours = new TextBox();
            label2 = new Label();
            btnhome = new Button();
            txtCourseCode = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // txtCreditHours
            // 
            txtCreditHours.Location = new Point(288, 220);
            txtCreditHours.Name = "txtCreditHours";
            txtCreditHours.Size = new Size(100, 23);
            txtCreditHours.TabIndex = 24;
            txtCreditHours.TextChanged += txtCreditHours_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 223);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 23;
            label2.Text = "creadit hourse";
            // 
            // btnhome
            // 
            btnhome.Location = new Point(25, 21);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 21;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(288, 152);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(100, 23);
            txtCourseCode.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 155);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 19;
            label3.Text = "code";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(405, 343);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 100);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 16;
            label1.Text = "course name";
            // 
            // txtName
            // 
            txtName.Location = new Point(288, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 25;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // addcourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(txtCreditHours);
            Controls.Add(label2);
            Controls.Add(btnhome);
            Controls.Add(txtCourseCode);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "addcourseForm";
            Text = "addcourseForm";
            Load += addcourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCreditHours;
        private Label label2;
        private Button btnhome;
        private TextBox txtCourseCode;
        private Label label3;
        private Button btnAdd;
        private Label label1;
        private TextBox txtName;
    }
}