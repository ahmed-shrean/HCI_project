using HCI_project.admin;
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
    }
}
