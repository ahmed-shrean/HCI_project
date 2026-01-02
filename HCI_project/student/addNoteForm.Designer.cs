namespace HCI_project.student
{
    partial class addNoteForm
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
            txtContent = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbCourses = new ComboBox();
            SuspendLayout();
            // 
            // btnhome
            // 
            btnhome.Location = new Point(12, 23);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 20;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(285, 69);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(230, 23);
            txtContent.TabIndex = 18;
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 163);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 16;
            label3.Text = "course";
            // 
            // button2
            // 
            button2.Location = new Point(285, 321);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 92);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 11;
            label1.Text = "contant";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(285, 163);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(121, 23);
            cmbCourses.TabIndex = 21;
            cmbCourses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // addNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCourses);
            Controls.Add(btnhome);
            Controls.Add(txtContent);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "addNoteForm";
            Text = "addNoteForm";
            Load += addNoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhome;
        private TextBox txtContent;
        private Label label3;
        private Button button2;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbCourses;
    }
}