using ExaminationSystem.BL.UserLayer;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            wronglabel.Visible = false;
        }

        private void selectuserCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectuserCB.SelectedIndex == 0)    //student
            {
                panel2.Visible = true;
                panel1.Visible = false;
                wronglabel2.Visible = false;
            }
            else if (selectuserCB.SelectedIndex == 1)   //teacher
            {
                panel1.Visible = true;
                panel2.Visible = false;
                wronglabel.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = false;
                wronglabel2.Visible = false;
                wronglabel.Visible = false;
            }
        }

        private void Showandhidecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Showandhidecheckbox.Checked == true)
            {
                teacherpasswordtb.PasswordChar = '\0';
                Showandhidecheckbox.Text = "Hide password";
            }
            else
            {
                teacherpasswordtb.PasswordChar = '*';
                Showandhidecheckbox.Text = "Show password";
            }
        }

        private void studentShowandhidecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (studentShowandhidecheckbox.Checked == true)
            {
                studentpasstextbox.PasswordChar = '\0';
                studentShowandhidecheckbox.Text = "Hide password";
            }
            else
            {
                studentpasstextbox.PasswordChar = '*';
                studentShowandhidecheckbox.Text = "Show password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string username = studentusernametb.Text.Trim();
            //string password = teacherpasswordtb.Text;

            //wronglabel.Visible = false;

            //if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            //{
            //    wronglabel.Text = "Please enter both username and password.";
            //    wronglabel.Visible = true;
            //    return;
            //}

            //User authenticatedUser = UserLayerBL.AuthenticateUser(username, password);

            //if (authenticatedUser != null)
            //{
            //    GlobalData.CurrentUserId = authenticatedUser.Id.ToString();
            //    GlobalData.UserMission = authenticatedUser.Role; // Sets to "Admin" or "Teacher"

            //    if (authenticatedUser.Role == "Admin" || authenticatedUser.Role == "Teacher")
            //    {
            //        TeacherForn.teacherExam teacherForm = new TeacherForn.teacherExam();
            //        teacherForm.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        wronglabel.Text = "Your role is not authorized for this application.";
            //        wronglabel.Visible = true;
            //    }
            //}
            //else
            //{
            //    wronglabel.Text = "Wrong username or password.";
            //    wronglabel.Visible = true;
            //}
        }
    }
}
