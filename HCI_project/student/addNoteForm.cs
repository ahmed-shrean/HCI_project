using HCI_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace HCI_project.student
{
    public partial class addNoteForm : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public addNoteForm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            stuhomeform nextForm = new stuhomeform();


            nextForm.Show();


            this.Close();
        }

        private void addNoteForm_Load(object sender, EventArgs e)
        {
            var courses = dbContext.Courses.ToList();

            cmbCourses.DataSource = courses;
            cmbCourses.DisplayMember = "Name"; // Ensure this matches your DB column (e.g. "Name" or "CourseName")
            cmbCourses.ValueMember = "CourseId";
            cmbCourses.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex != -1)
            {
                // Recover the full Course object
                Course selectedCourse = (Course)cmbCourses.SelectedItem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Please select a course and write a note.");
                return;
            }

            try
            {
                int currentUserId = UserSession.loger.UserId; // Get logged-in student ID
                int selectedCourseId = Convert.ToInt32(cmbCourses.SelectedValue);

                // Create the Note object
                Note newNote = new Note()
                {
                    Content = txtContent.Text,
                    CourseId = selectedCourseId,
                    UserId = currentUserId
                };

                // Save to DB
                dbContext.Notes.Add(newNote);
                dbContext.SaveChanges();

                MessageBox.Show("Note added successfully!");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding note: " + ex.Message);
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            txtContent.Height = 120;
        }
    }
}
    