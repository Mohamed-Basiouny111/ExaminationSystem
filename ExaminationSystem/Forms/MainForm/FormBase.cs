using ExaminationSystem.Forms;
using ExaminationSystem.Forms.ReportForms;
using ExaminationSystem.Forms.UsersForm;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class FormBase : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormBase()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            LName.Text = LoginForm.UserName;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 150, 136);
                    currentButton.ForeColor = Color.White;
                    //  this.panelDesktopPane.Controls.Add(childForm);
                    //this.panelDesktopPane.Tag = childForm;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }

            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.MistyRose;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        // to run content of menu in panel desktop
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LTitle.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        }

        private void btnAddQues_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnUpdateQues_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDeleteorView_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ExamAttemptForm(), sender);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            LTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }



        #region customise btn window state
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }
        #endregion




        private void FormBase_Load(object sender, EventArgs e)
        {
            if (LoginForm.UserMission == "Admin")
            {
                //Example For Condition
               
            }
            else if (LoginForm.UserMission == "Teacher")
            {
                button2.Visible = false;
            }
            else if (LoginForm.UserMission == "Student")
            {
                button2.Visible = false;
            }




        }
    }
}
