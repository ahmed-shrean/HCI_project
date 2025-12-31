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
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnhome = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(194, 375);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(442, 375);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            
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
            // textBox1
            // 
            textBox1.Location = new Point(266, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 28;
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
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnhome);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "gradesEditFirm";
            Text = "gradesEditFirm";
            Load += gradesEditFirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnhome;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
    }
}