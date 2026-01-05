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
    public partial class adminhomeform : Form
    {
        public adminhomeform()
        {
            InitializeComponent();
        }

        private void btnCoursesEdit_Click(object sender, EventArgs e)
        {
            editecouresForm nextForm = new editecouresForm();


            nextForm.Show();


            this.Close();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            gradesEditFirm nextForm = new gradesEditFirm();


            nextForm.Show();


            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.loger = null;

            loginForm nextForm = new loginForm();


            nextForm.Show();


            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            addcourseForm nextForm = new addcourseForm();


            nextForm.Show();


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changegrades nextForm = new changegrades();


            nextForm.Show();


            this.Close();
        }
    }
}
