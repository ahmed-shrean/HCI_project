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
    public partial class grades : Form
    {
        MyDbContext dbContext = new MyDbContext();

        public grades()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            stuhomeform nextForm = new stuhomeform();


            nextForm.Show();


            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grades_Load(object sender, EventArgs e)
        {
            try
            {
                int currentStudentId = UserSession.loger.UserId;

                // 2. Query the Grades table
                var myGrades = dbContext.Grades
                    .Where(g => g.UserId == currentStudentId) // Filter by logged-in student
                    .Select(g => new
                    {
                        // Select the columns you want to see
                        Course = g.Course.Name, // Get the Course Name from the relation
                        Exam = g.ExamName,
                        Score = g.Score,
                        Max = g.MaxScore
                    })
                    .ToList();

                // 3. Bind to the DataGridView
                dataGridView1.DataSource = myGrades;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message);
            }
        }
    }
}
