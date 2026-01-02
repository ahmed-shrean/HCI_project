namespace HCI_project.student
{
    partial class grades
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
            btnhome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 103);
            label1.Name = "label1";
            label1.Size = new Size(309, 15);
            label1.TabIndex = 0;
            label1.Text = "جدول بيظهر اسم الامتحان و تبع انهى ماده و كم الدرجه النعائيه ";
            // 
            // btnhome
            // 
            btnhome.Location = new Point(40, 28);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 2;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // grades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnhome);
            Controls.Add(label1);
            Name = "grades";
            Text = "grades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnhome;
    }
}