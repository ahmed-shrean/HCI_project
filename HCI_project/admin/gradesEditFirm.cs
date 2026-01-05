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
            cmbCourses.DisplayMember = "Name";
            cmbCourses.ValueMember = "CourseId";
            cmbCourses.SelectedIndex = -1;

            // --- 2. Load Students (THIS WAS MISSING) ---
            // We assume 'comboBox1' is the dropdown for Student Name shown in your image
            // We filter to get only Users who are NOT admins (if you want all users, remove the .Where part)
            var students = dbContext.Users
                            .Where(u => u.Isadmin == false || u.Isadmin == null)
                            .ToList();

            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "UserName"; // Show the name
            comboBox1.ValueMember = "UserId";     // Save the ID in the background
            comboBox1.SelectedIndex = -1;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            adminhomeform nextForm = new adminhomeform();


            nextForm.Show();


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Basic Validation
            if (string.IsNullOrWhiteSpace(txtexname.Text) ||
                string.IsNullOrWhiteSpace(txtscore.Text) ||
                string.IsNullOrWhiteSpace(txtmaxscore.Text) ||
                cmbCourses.SelectedIndex == -1 ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all places, select a course, and select a student.");
                return;
            }

            try
            {
                int selectedCourseId = Convert.ToInt32(cmbCourses.SelectedValue);
                int selectedStudentId = Convert.ToInt32(comboBox1.SelectedValue);

                // --- NEW SAFETY CHECK ---
                // Check if the student is actually enrolled in this specific course
                bool isEnrolled = dbContext.StudentCourses.Any(sc =>
                    sc.UserId == selectedStudentId && sc.CourseId == selectedCourseId);

                if (!isEnrolled)
                {
                    MessageBox.Show("This student is NOT registered for the selected course! You cannot add a grade.");
                    return; // Stop the code here
                }
                // ------------------------

                double score = Convert.ToDouble(txtscore.Text);
                int maxScore = Convert.ToInt32(txtmaxscore.Text);

                if (score > maxScore)
                {
                    MessageBox.Show("Score cannot be greater than Max Score!");
                    return;
                }

                // Create Grade
                Grade newgrade = new Grade()
                {
                    Score = score,
                    MaxScore = maxScore,
                    ExamName = txtexname.Text,
                    UserId = selectedStudentId,
                    CourseId = selectedCourseId
                };

                dbContext.Grades.Add(newgrade);
                dbContext.SaveChanges();

                MessageBox.Show("Grade added successfully!");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
