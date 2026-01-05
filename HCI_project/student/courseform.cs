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

namespace HCI_project.student
{
    public partial class courseform : Form
    {
        // 1. Create the database connection
        MyDbContext dbContext = new MyDbContext();

        public courseform()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            stuhomeform nextForm = new stuhomeform();
            nextForm.Show();
            this.Close();
        }

        private void courseform_Load(object sender, EventArgs e)
        {
           

            try
            {
                // 3. Get the ID of the current student
                int currentStudentId = UserSession.loger.UserId;

                // 4. Query the StudentCourses table
                // We filter by the current student's ID
                var myCourses = dbContext.StudentCourses
                    .Where(sc => sc.UserId == currentStudentId)
                    .Select(sc => new
                    {
                        CourseName = sc.Course.Name,
                        Code = sc.Course.Code,      
                        CreditHours = sc.Course.CreditHours
                    })
                    .ToList();

                // 5. Put the data into the DataGridView
                // Replace 'dataGridView1' with the actual name of your table in the design
                dataGridView1.DataSource = myCourses;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }
    }
}
