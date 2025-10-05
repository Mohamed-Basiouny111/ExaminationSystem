using ExaminationSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ExaminationSystem.Forms
{
    public partial class LoginForm : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public static string UserName = "";
        public static int UserId = 0;
        public static string UserMission = "";

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Clear();
        }
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtpass.Focus();
                txtpass.Select();
                txtpass.SelectAll();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (this.txtpass.UseSystemPasswordChar == false)
            {
                this.txtpass.UseSystemPasswordChar = true;
                this.btnShowPass.Image = global::ExaminationSystem.Properties.Resources.eye__1_;
            }
            else
            {
                this.txtpass.UseSystemPasswordChar = false;
                this.btnShowPass.Image = global::ExaminationSystem.Properties.Resources.eye__2___1_;

            }
        }

        public string Encrypt(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }

        private void Clear()
        {
            txtUserName.Text = txtpass.Text = "";
            txtUserName.Focus();
            txtUserName.Select();
            txtUserName.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" && txtUserName.Text == "")
            {
                MessageBox.Show("Please enter your data.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Clear();
                return;
            }

            var result = db.Users
                         .FirstOrDefault(u => u.UserName == txtUserName.Text && u.PasswordHash == Encrypt(txtpass.Text));
            if (result != null)
            {
                UserName = result.UserName;
                UserId = result.Id;
                UserMission = result.Role;

                this.Close();
                Thread th = new Thread(openForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Please check your login details and try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return;
            }
        }

        void openForm()
        {
            Application.Run(new FormBase());
        }
    }
}
