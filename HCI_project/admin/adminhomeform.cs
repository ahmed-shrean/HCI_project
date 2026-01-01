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
            addcouresForm nextForm = new addcouresForm();


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
    }
}
