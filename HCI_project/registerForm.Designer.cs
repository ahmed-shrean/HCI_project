namespace HCI_project
{
    partial class registerForm
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
            btnSaveRegister = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtemail = new TextBox();
            label3 = new Label();
            radStudent = new RadioButton();
            radAdmin = new RadioButton();
            SuspendLayout();
            // 
            // btnSaveRegister
            // 
            btnSaveRegister.Location = new Point(301, 336);
            btnSaveRegister.Name = "btnSaveRegister";
            btnSaveRegister.Size = new Size(75, 23);
            btnSaveRegister.TabIndex = 9;
            btnSaveRegister.Text = "save";
            btnSaveRegister.UseVisualStyleBackColor = true;
            btnSaveRegister.Click += btnSaveRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(301, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(301, 69);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 152);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 77);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 5;
            label1.Text = "User name";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(307, 221);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(100, 23);
            txtemail.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 229);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "email";
            // 
            // radStudent
            // 
            radStudent.AutoSize = true;
            radStudent.Location = new Point(413, 305);
            radStudent.Name = "radStudent";
            radStudent.Size = new Size(65, 19);
            radStudent.TabIndex = 12;
            radStudent.TabStop = true;
            radStudent.Text = "student";
            radStudent.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            radAdmin.AutoSize = true;
            radAdmin.Location = new Point(176, 305);
            radAdmin.Name = "radAdmin";
            radAdmin.Size = new Size(59, 19);
            radAdmin.TabIndex = 13;
            radAdmin.TabStop = true;
            radAdmin.Text = "admin";
            radAdmin.UseVisualStyleBackColor = true;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radAdmin);
            Controls.Add(radStudent);
            Controls.Add(txtemail);
            Controls.Add(label3);
            Controls.Add(btnSaveRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registerForm";
            Text = "registerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveRegister;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private TextBox txtemail;
        private Label label3;
        private RadioButton radStudent;
        private RadioButton radAdmin;
    }
}