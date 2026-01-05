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

namespace HCI_project
{
    public partial class registerForm : Form
    {
        MyDbContext dbContext = new MyDbContext();
        public registerForm()
        {
            InitializeComponent();
        }

        private void btnSaveRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Please fill all places .");
                return;
            }
            if (!radAdmin.Checked && !radStudent.Checked)
            {
                MessageBox.Show("Please choose your role  .");
                return;
            }
            else
            {
                try
                {

                    bool isUserAdmin = false;
                    if (radAdmin.Checked)
                    {
                        isUserAdmin = true;
                    }
                    User newUser = new User()
                    {
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                        Email = txtemail.Text,
                        Isadmin = isUserAdmin
                    };

                    dbContext.Users.Add(newUser);


                    dbContext.SaveChanges();


                    MessageBox.Show("Registration successful!");
                    loginForm nextForm = new loginForm();


                    nextForm.Show();


                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm nextForm = new loginForm();


            nextForm.Show();


            this.Close();
        }
    }
}
