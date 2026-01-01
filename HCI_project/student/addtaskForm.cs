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

            cmbCourses.DisplayMember = "CourseName";

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
            { if (dateTimePicker1.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Please choose valid DATE.");
                    return;
                }
                try { int currentUserId = UserSession.loger.UserId;

                    HCI_project.Models.Task newTask = new HCI_project.Models.Task()
                    {
                        Title = txtTitle.Text,
                        Description = txtDescription.Text,
                        Deadline = dateTimePicker1.Value,
                        IsCompleted = false,
                        CourseId = Convert.ToInt32(cmbCourses.ValueMember),
                        UserId = currentUserId
                    };

                    // 5. SAVE TO DATABASE
                    dbContext.Tasks.Add(newTask);
                    dbContext.SaveChanges();

                    MessageBox.Show("Task added successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            
            
            }
            else
            {
                MessageBox.Show("Please fill all places .");
                return;
            }


        }
    }
}
