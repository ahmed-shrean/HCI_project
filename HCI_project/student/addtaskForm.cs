using HCI_project.admin;
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

    public partial class addtaskForm : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public addtaskForm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            stuhomeform nextForm = new stuhomeform();


            nextForm.Show();


            this.Close();
        }

        private void addtaskForm_Load(object sender, EventArgs e)
        {
            var courses = dbContext.Courses.ToList();

            cmbCourses.DataSource = courses;

            cmbCourses.DisplayMember = "Name";

            cmbCourses.ValueMember = "CourseId";

            cmbCourses.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text) ||
            string.IsNullOrWhiteSpace(txtTitle.Text) ||
            cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all places and select a course.");
                return;
            }

            // B. Date Validation
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please choose a valid DATE.");
                return;
            }

            try
            {
                int currentUserId = UserSession.loger.UserId;

                HCI_project.Models.Task newTask = new HCI_project.Models.Task()
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Deadline = dateTimePicker1.Value,
                    IsCompleted = false,

                    // C. CRITICAL FIX: Use 'SelectedValue', not 'ValueMember'
                    CourseId = Convert.ToInt32(cmbCourses.SelectedValue),

                    UserId = currentUserId
                };

                dbContext.Tasks.Add(newTask);
                dbContext.SaveChanges();

                MessageBox.Show("Task added successfully!");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}