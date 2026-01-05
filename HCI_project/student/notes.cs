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
    public partial class notes : Form
    {
        MyDbContext dbContext = new MyDbContext();

        public notes()
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

        private void notes_Load(object sender, EventArgs e)
        {
            try
            {
                int currentStudentId = UserSession.loger.UserId;

                // 2. Query the Notes table
                var myNotes = dbContext.Notes
                    .Where(n => n.UserId == currentStudentId)
                    .Select(n => new
                    {
                        // REPLACE these with the actual property names in your Note class
                      Course = n.Course.Name,
                        Content = n.Content,
                          // If you have a date column
                    })
                    .ToList();

                // 3. Bind to the DataGridView
                dataGridView1.DataSource = myNotes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notes: " + ex.Message);
            }
        }
    }
    }
