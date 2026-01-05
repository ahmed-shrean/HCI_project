using HCI_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore; // ADD THIS // Necessary for .Include if needed
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_project.admin
{
    public partial class changegrades : Form
    {
        MyDbContext dbContext = new MyDbContext();

        public changegrades()
        {
            InitializeComponent();
        }

        // --- 1. FORM LOAD: Fill the first box (Courses) ---
        private void changegrades_Load(object sender, EventArgs e)
        {
            var courses = dbContext.Courses.ToList();

            cmbCourses.DataSource = courses;
            cmbCourses.DisplayMember = "Name";
            cmbCourses.ValueMember = "CourseId";

            // Clear selections
            cmbCourses.SelectedIndex = -1;
            cmbStudent.DataSource = null; // Clear students until course is picked
            cmbExam.DataSource = null;    // Clear exams until student is picked
        }
        private void txtscore_TextChanged(object sender, EventArgs e)
        {
            // Leave this empty if you don't need it
        }
        // --- 2. COURSE SELECTED: Fill Student list with only enrolled students ---






        private void btnHome_Click(object sender, EventArgs e)
        {
            adminhomeform home = new adminhomeform();
            home.Show();
            this.Close();
        }


        private void btnedite_Click(object sender, EventArgs e)
        {
            if (cmbExam.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an exam to edit.");
                return;
            }

            try
            {
                int gradeId = (int)cmbExam.SelectedValue;

                // Find the record in the database
                var gradeToEdit = dbContext.Grades.Find(gradeId);

                if (gradeToEdit != null)
                {
                    // Update values
                    gradeToEdit.Score = Convert.ToDouble(txtScore.Text);
                    gradeToEdit.MaxScore = Convert.ToInt32(txtMaxScore.Text);

                    // Validation: Score cannot be > Max
                    if (gradeToEdit.Score > gradeToEdit.MaxScore)
                    {
                        MessageBox.Show("Score cannot be higher than Max Score.");
                        return;
                    }

                    dbContext.SaveChanges();
                    MessageBox.Show("Grade updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (cmbExam.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this grade?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            try
            {
                int gradeId = (int)cmbExam.SelectedValue;
                var gradeToDelete = dbContext.Grades.Find(gradeId);

                if (gradeToDelete != null)
                {
                    dbContext.Grades.Remove(gradeToDelete);
                    dbContext.SaveChanges();

                    MessageBox.Show("Grade deleted.");

                    // Refresh the list so the deleted exam disappears
                    // We trigger the event manually to reload
                    cmbStudent_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbCourses_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudent.DataSource = null;
            cmbExam.DataSource = null;
            txtScore.Text = "";
            txtMaxScore.Text = "";

            if (cmbCourses.SelectedValue == null || !(cmbCourses.SelectedValue is int))
                return;

            int selectedCourseId = (int)cmbCourses.SelectedValue;

            var enrolledStudents = dbContext.StudentCourses
                .Include(sc => sc.User)
                .Where(sc => sc.CourseId == selectedCourseId)
                .Select(sc => sc.User)
                .Distinct() // Avoid duplicates
                .ToList();

            if (enrolledStudents.Count == 0)
            {
                MessageBox.Show("No students enrolled in this course.");
                return;
            }

            cmbStudent.DataSource = enrolledStudents;
            cmbStudent.DisplayMember = "UserName";
            cmbStudent.ValueMember = "UserId";
            cmbStudent.SelectedIndex = -1;
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbExam.DataSource = null;
            txtScore.Text = "";
            txtMaxScore.Text = "";

            if (!(cmbCourses.SelectedValue is int) || !(cmbStudent.SelectedValue is int))
                return;

            int courseId = (int)cmbCourses.SelectedValue;
            int studentId = (int)cmbStudent.SelectedValue;

            var existingGrades = dbContext.Grades
                .Where(g => g.CourseId == courseId && g.UserId == studentId)
                .ToList();

            if (existingGrades.Count == 0)
            {
                MessageBox.Show("No grades found for this student in this course.");
                return;
            }

            cmbExam.DataSource = existingGrades;
            cmbExam.DisplayMember = "ExamName";
            cmbExam.ValueMember = "GradeId";
            cmbExam.SelectedIndex = -1;
        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExam.SelectedIndex != -1)
            {
                Grade selectedGrade = (Grade)cmbExam.SelectedItem;
                txtScore.Text = selectedGrade.Score.ToString();
                txtMaxScore.Text = selectedGrade.MaxScore.ToString();
            }
            else
            {
                txtScore.Text = "";
                txtMaxScore.Text = "";
            }
        }
    }
}