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
    public partial class addcouresForm : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public addcouresForm()
        {
            InitializeComponent();
        }



        private void addcouresForm_Load(object sender, EventArgs e)
        {
            var courses = dbContext.Courses.ToList();

            cmbCourses.DataSource = courses;

            cmbCourses.DisplayMember = "CourseName";

            cmbCourses.ValueMember = "CourseId";

            cmbCourses.SelectedIndex = -1;


            txtCourseCode.ReadOnly = true;
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
                // 1. Recover the full Course object from the selected item
                // We cast (convert) the generic object back to your 'Course' class
                Course selectedCourse = (Course)cmbCourses.SelectedItem;

                // 2. Put the course Code into the text box
                // (Make sure to replace 'txtCourseCode' with the real name of your TextBox)
                txtCourseCode.Text = selectedCourse.Code;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
