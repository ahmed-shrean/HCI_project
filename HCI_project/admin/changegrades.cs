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






        // --- 5. EDIT BUTTON: Update the database ---
        private void btnEdit_Click(object sender, EventArgs e) // Rename button1 to btnEdit
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

        // --- 6. DELETE BUTTON: Remove the grade ---
        private void btnDelete_Click(object sender, EventArgs e) // Rename button2 to btnDelete
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

        // Navigation (Home Button)
        private void btnHome_Click(object sender, EventArgs e)
        {
            adminhomeform home = new adminhomeform();
            home.Show();
            this.Close();
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudent.DataSource = null;
            cmbExam.DataSource = null;
            txtScore.Text = "";
            txtMaxScore.Text = "";

            if (cmbCourses.SelectedIndex != -1)
            {
                int selectedCourseId = (int)cmbCourses.SelectedValue;

                // Query StudentCourses to find users linked to this Course ID
                var enrolledStudents = dbContext.StudentCourses
                                      .Where(sc => sc.CourseId == selectedCourseId)
                                      .Select(sc => sc.User) // Select the User object
                                      .ToList();

                cmbStudent.DataSource = enrolledStudents;
                cmbStudent.DisplayMember = "UserName";
                cmbStudent.ValueMember = "UserId";
                cmbStudent.SelectedIndex = -1;
            }
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset lower fields
            cmbExam.DataSource = null;
            txtScore.Text = "";
            txtMaxScore.Text = "";

            if (cmbStudent.SelectedIndex != -1 && cmbCourses.SelectedIndex != -1)
            {
                int courseId = (int)cmbCourses.SelectedValue;
                int studentId = (int)cmbStudent.SelectedValue;

                // Find all grades for this specific student in this specific course
                var existingGrades = dbContext.Grades
                                     .Where(g => g.CourseId == courseId && g.UserId == studentId)
                                     .ToList();

                // We bind the GRADE object itself to the dropdown
                // This is a smart trick: The "Value" is the GradeId unique key
                cmbExam.DataSource = existingGrades;
                cmbExam.DisplayMember = "ExamName"; // Show "Midterm", "Final", etc.
                cmbExam.ValueMember = "GradeId";    // Save the primary key
                cmbExam.SelectedIndex = -1;
            }
        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExam.SelectedIndex != -1)
            {
                // Retrieve the Grade object directly from the ComboBox
                // (Because we set the DataSource to a list of Grade objects)
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
    }
    }
