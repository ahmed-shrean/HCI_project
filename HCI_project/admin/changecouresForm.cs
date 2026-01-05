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
    public partial class editecouresForm : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public editecouresForm()
        {
            InitializeComponent();
        }



        private void addcouresForm_Load(object sender, EventArgs e)
        {
            var courses = dbContext.Courses.ToList();

            cmbCourses.DataSource = courses;

            cmbCourses.DisplayMember = "Name";

            cmbCourses.ValueMember = "CourseId";

            cmbCourses.SelectedIndex = -1;


          
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            adminhomeform nextForm = new adminhomeform();


            nextForm.Show();


            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex != -1)
            {
                // 1. Get the selected course object
                Course selectedCourse = (Course)cmbCourses.SelectedItem;

                // 2. Fill the TextBoxes
                txtCourseCode.Text = selectedCourse.Code;

                // Convert the integer/double to string for the text box
                txtCreditHours.Text = selectedCourse.CreditHours.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course to edit.");
                return;
            }

            try
            {
                // 2. Get the ID of the selected course
                int courseId = (int)cmbCourses.SelectedValue;

                // 3. Find the course in the database
                var courseToEdit = dbContext.Courses.Find(courseId);

                if (courseToEdit != null)
                {
                    // 4. Update the values
                    courseToEdit.Code = txtCourseCode.Text;
                    courseToEdit.CreditHours = int.Parse(txtCreditHours.Text); // Ensure this is a number

                    // Note: If you want to edit the Name, you need a separate TextBox for it.
                    // Currently, the ComboBox is only for *selecting*, not editing the name.

                    // 5. Save changes
                    dbContext.SaveChanges();
                    MessageBox.Show("Course updated successfully!");

                    // Optional: Refresh the ComboBox text if needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating course: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            // 2. Ask for confirmation (Safety Step)
            var result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // 3. Get the ID
                int courseId = (int)cmbCourses.SelectedValue;

                // 4. Find the course
                var courseToDelete = dbContext.Courses.Find(courseId);

                if (courseToDelete != null)
                {
                    // 5. Remove and Save
                    dbContext.Courses.Remove(courseToDelete);
                    dbContext.SaveChanges();

                    MessageBox.Show("Course deleted successfully!");

                    // 6. Refresh the ComboBox list
                    // We need to reload the list so the deleted course disappears
                    addcouresForm_Load(sender, e);

                    // Clear text boxes
                    txtCourseCode.Text = "";
                    txtCreditHours.Text = "";
                }
            }
            catch (Exception ex)
            {
                // This usually happens if students are already enrolled in the course
                MessageBox.Show("Cannot delete this course because it is in use (students or grades are linked to it).");
            }
        }

        private void txtCreditHours_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the key is NOT a number AND NOT a control key (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Stop the character from being entered
                e.Handled = true;
            }

        }

        private void txtCourseCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

