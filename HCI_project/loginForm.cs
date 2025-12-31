using HCI_project.admin;
using HCI_project.Models;
using HCI_project.student;

namespace HCI_project
{
    public partial class loginForm : Form
    {

        MyDbContext dbContext=new MyDbContext();
        public loginForm()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm nextForm = new registerForm();


            nextForm.Show();


            this.Hide();

        }

        private void btnSaveLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in both username and password.");
                return;
            }
            else
            {
                User loginUser = dbContext.Users.FirstOrDefault(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text);
                if (loginUser != null && loginUser.Isadmin == true)
                {

                    adminhomeform nextForm = new adminhomeform();


                    nextForm.Show();
                    this.Hide();


                }
                else if (loginUser != null && loginUser.Isadmin == false)
                {

                    stuhomeform nextForm = new stuhomeform();


                    nextForm.Show();
                    this.Hide();


                }
                else 
                {
                    MessageBox.Show("wrong user name or password.");
                    return;


                }
            }

           
        }
    }
    }

