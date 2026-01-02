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
    public partial class stuhomeform : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public stuhomeform()
        {
            InitializeComponent();
        }

        private void labGPA_Click(object sender, EventArgs e)
        {

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            courseform nextForm = new courseform();


            nextForm.Show();


            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm nextForm = new loginForm();


            nextForm.Show();


            this.Close();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            notes nextForm = new notes();


            nextForm.Show();


            this.Close();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            grades nextForm = new grades();


            nextForm.Show();


            this.Close();
        }

        private void stuhomeform_Load(object sender, EventArgs e)
        {
            CalculateAndDisplayGPA();
        }
        private void CalculateAndDisplayGPA()
        {
            try
            {
                // 1. Get all grades for the current user
                int currentUserId = UserSession.loger.UserId;
                var userGrades = dbContext.Grades
                                          .Where(g => g.UserId == currentUserId)
                                          .ToList();

                if (userGrades.Count == 0)
                {
                    lblGPA.Text = "GPA: 0.00";
                    return;
                }

                double totalPoints = 0;
                int count = 0;

                // 2. Loop through each grade to calculate GPA points
                foreach (var grade in userGrades)
                {
                    if (grade.MaxScore == 0) continue; // Prevent division by zero

                    // Calculate percentage (e.g., 85.0)
                    double percentage = (grade.Score / grade.MaxScore) * 100;

                    // Convert to 4.0 Scale
                    double gpaPoint = ConvertToGPA(percentage);

                    totalPoints += gpaPoint;
                    count++;
                }

                // 3. Calculate Average
                double finalGPA = count > 0 ? totalPoints / count : 0.0;

                // 4. Display in Label (Formatted to 2 decimal places, e.g., "3.56")
                lblGPA.Text = finalGPA.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating GPA: " + ex.Message);
            }
        }

        // Helper function: Standard 4.0 Scale
        private double ConvertToGPA(double percentage)
        {
            if (percentage >= 90) return 4.0;       // A
            else if (percentage >= 85) return 3.7;  // A-
            else if (percentage >= 80) return 3.3;  // B+
            else if (percentage >= 75) return 3.0;  // B
            else if (percentage >= 70) return 2.7;  // B-
            else if (percentage >= 65) return 2.3;  // C+
            else if (percentage >= 60) return 2.0;  // C
            else if (percentage >= 50) return 1.0;  // D
            else return 0.0;                        // F
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            addNoteForm nextForm = new addNoteForm();


            nextForm.Show();


            this.Hide();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            addCoursesForm nextForm = new addCoursesForm();


            nextForm.Show();


            this.Hide();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            addtaskForm nextForm = new addtaskForm();


            nextForm.Show();


            this.Hide();

        }
    }
}
