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
            cours_code = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBox1 = new ComboBox();
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
            // 
            // cours_code
            // 
            cours_code.Location = new Point(285, 89);
            cours_code.Name = "cours_code";
            cours_code.Size = new Size(100, 23);
            cours_code.TabIndex = 18;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(285, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            // 
            // addNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnhome);
            Controls.Add(cours_code);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "addNoteForm";
            Text = "addNoteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhome;
        private TextBox cours_code;
        private Label label3;
        private Button button2;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBox1;
    }
}