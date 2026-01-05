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

namespace HCI_project.student
{
    public partial class addCoursesForm : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public addCoursesForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            stuhomeform nextForm = new stuhomeform();


            nextForm.Show();


            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course to enroll.");
                return;
            }

            try
            {
                int currentUserId = UserSession.loger.UserId; // Get logged-in student ID
                int selectedCourseId = Convert.ToInt32(cmbCourses.SelectedValue);

                // 2. Check if already enrolled (Prevent Duplicates)
                bool alreadyEnrolled = dbContext.StudentCourses.Any(sc =>
                    sc.UserId == currentUserId &&
                    sc.CourseId == selectedCourseId);

                if (alreadyEnrolled)
                {
                    MessageBox.Show("You are already enrolled in this course!");
                    return;
                }

                // 3. Create the enrollment record
                StudentCourse newEnrollment = new StudentCourse()
                {
                    UserId = currentUserId,
                    CourseId = selectedCourseId
                };

                // 4. Save to Database
                dbContext.StudentCourses.Add(newEnrollment);
                dbContext.SaveChanges();

                MessageBox.Show("Course added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
            }
        }

        private void addCoursesForm_Load(object sender, EventArgs e)
        {
            var courses = dbContext.Courses.ToList();

            cmbCourses.DataSource = courses;

            cmbCourses.DisplayMember = "Name";

            cmbCourses.ValueMember = "CourseId";

            cmbCourses.SelectedIndex = -1;

            txtCode.ReadOnly = true;
            txtCreditHour.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex != -1)
            {
                // 1. Get the selected Course
                Course selectedCourse = (Course)cmbCourses.SelectedItem;

                // 2. Fill the boxes
                txtCode.Text = selectedCourse.Code;
                txtCreditHour.Text = selectedCourse.CreditHours.ToString();
            }
            else
            {
                // 3. IMPORTANT: Clear the boxes if nothing is selected
                // This fixes the issue of seeing data on load
                txtCode.Text = "";
                txtCreditHour.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            try
            {
                int currentUserId = UserSession.loger.UserId;
                int selectedCourseId = Convert.ToInt32(cmbCourses.SelectedValue);

                // 2. Find the specific enrollment record
                var enrollmentToRemove = dbContext.StudentCourses
                    .FirstOrDefault(sc => sc.UserId == currentUserId && sc.CourseId == selectedCourseId);

                if (enrollmentToRemove == null)
                {
                    MessageBox.Show("You are not enrolled in this course, so you cannot delete it.");
                    return;
                }

                // 3. Remove and Save
                dbContext.StudentCourses.Remove(enrollmentToRemove);
                dbContext.SaveChanges();

                MessageBox.Show("Course deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting course: " + ex.Message);
            }
        }
    }
}
