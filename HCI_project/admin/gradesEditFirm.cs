using HCI_project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_project.admin
{
    public partial class gradesEditFirm : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public gradesEditFirm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gradesEditFirm_Load(object sender, EventArgs e)
        {
            var courses = dbContext.Courses.ToList();

             cmbCourses.DataSource = courses;

            cmbCourses.DisplayMember = "CourseName";

             cmbCourses.ValueMember = "CourseId";

            cmbCourses.SelectedIndex = -1;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            adminhomeform nextForm = new adminhomeform();


            nextForm.Show();


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtexname.Text) ||
                string.IsNullOrWhiteSpace(txtstuname.Text) ||
                string.IsNullOrWhiteSpace(txtscore.Text) ||
                string.IsNullOrWhiteSpace(txtmaxscore.Text) ||
                cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all places and select a course.");
                return;
            }

            try
            {
                double score = Convert.ToDouble(txtscore.Text);
                int maxScore = Convert.ToInt32(txtmaxscore.Text);

                if (score > maxScore)
                {
                    MessageBox.Show("Score cannot be greater than Max Score!");
                    return;
                }

                
                var student = dbContext.Users.FirstOrDefault(u => u.UserName == txtstuname.Text);
                if (student == null)
                {
                    MessageBox.Show("Student not found!");
                    return;
                }

                int selectedCourseId = Convert.ToInt32(cmbCourses.SelectedValue);

                Grade newgrade = new Grade()
                {
                    Score = score,
                    MaxScore = maxScore,
                    ExamName = txtexname.Text,
                    UserId = student.UserId,
                    CourseId = selectedCourseId // Assign the ID directly
                };

                dbContext.Grades.Add(newgrade);
                dbContext.SaveChanges();

                MessageBox.Show("Grade added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmaxscore_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmaxscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        

        private void comCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
