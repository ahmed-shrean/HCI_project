namespace HCI_project.student
{
    partial class courseform
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
            label1.Location = new Point(170, 88);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 0;
            label1.Text = "اعمل جدول يطلع المواد و مجموع الدرجات فيها";
            // 
            // btnhome
            // 
            btnhome.Location = new Point(29, 30);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(75, 23);
            btnhome.TabIndex = 1;
            btnhome.Text = "home";
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // courseform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnhome);
            Controls.Add(label1);
            Name = "courseform";
            Text = "courseform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnhome;
    }
}