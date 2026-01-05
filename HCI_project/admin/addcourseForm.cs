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

namespace HCI_project.admin
{
    public partial class addcourseForm : Form
    {
        MyDbContext dbContext = new MyDbContext();

        public addcourseForm()
        {
            InitializeComponent();
        }
        private void txtCreditHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key entered is NOT a number AND NOT a control key (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Stop the character from being entered into the box
                e.Handled = true;
            }
        }

        private void txtCreditHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtCourseCode.Text) ||
        string.IsNullOrWhiteSpace(txtCreditHours.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // 2. Convert Credit Hours to a number
                // We use int.Parse because we know it's a number (thanks to the KeyPress code you added earlier!)
                int credits = int.Parse(txtCreditHours.Text);

                // 3. Optional: Check if a course with this Code already exists
                // This prevents adding "CS101" twice.
                bool exists = dbContext.Courses.Any(c => c.Code == txtCourseCode.Text);
                if (exists)
                {
                    MessageBox.Show("A course with this Code already exists!");
                    return;
                }

                // 4. Create the new Course object
                Course newCourse = new Course()
                {
                    Name = txtName.Text,
                    Code = txtCourseCode.Text,       // Ensure this matches your Class property (e.g., .Code or .CourseCode)
                    CreditHours = credits            // Ensure this matches your Class property
                };

                // 5. Save to the Database
                dbContext.Courses.Add(newCourse);
                dbContext.SaveChanges();

                // 6. Success Feedback
                MessageBox.Show("New course added successfully!");

                // 7. Clear the boxes so the user can add another one
                txtName.Text = "";
                txtCourseCode.Text = "";
                txtCreditHours.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            adminhomeform nextForm = new adminhomeform();


            nextForm.Show();


            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addcourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

