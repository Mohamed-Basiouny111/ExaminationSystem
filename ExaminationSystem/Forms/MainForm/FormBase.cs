using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using ExaminationSystem.Data;
using ExaminationSystem.Forms;
using ExaminationSystem.Forms.ExamForm;
using ExaminationSystem.Forms.Question;
using ExaminationSystem.Forms.ReportForms;
using ExaminationSystem.Forms.Subject;
using ExaminationSystem.Forms.TeacherForn;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExaminationSystem
{
    public partial class FormBase : Form
    {
        private Button currentButton;
        private Form activeForm;
        private ExaminationSystemContext db = new ExaminationSystemContext();
        // login student property used in start exam



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
            panelDesktopPane.Controls.Clear();

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

      

       

      

       

        public void btnCloseChildForm_Click(object sender, EventArgs e)
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
                btnAddUser.Visible = false;

            }
            else if (LoginForm.UserMission == "Student")
            {
                btnAddSub.Visible = false;
                btnQuesAll.Visible = false;
                btnQuesOne.Visible = false;
                btnQuesTF.Visible = false;
                btnAddExam.Visible = false;
                btnAddUser.Visible = false;

                var exams = db.Exams.Where(x => x.Mode.Equals(ExamMode.Starting)).Select(x => x).ToList();

                foreach (var item in exams)
                {
                    var examAteend = db.ExamAttempts.Where(x => item.Id == x.ExamId && x.StudentId == LoginForm.UserId).Select(x => x).ToList();

                    if (examAteend.Count > 0)
                    {

                        Button btn = new Button();
                        btn.Text = item.Title;
                        btn.Dock = DockStyle.Top;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Font = new Font("Cambria", 18F, FontStyle.Bold);
                        btn.ForeColor = Color.Black;
                        btn.Image = Properties.Resources.login__2_;
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                        btn.Location = new Point(0, 0);
                        btn.Name = item.Title;
                        btn.Padding = new Padding(21, 0, 0, 0);
                        btn.Size = new Size(1163, 60);
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                        btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                        btn.UseVisualStyleBackColor = true;

                        // Fix: Use a lambda to capture the correct examId and userId for the event handler
                        btn.Click += (s, ev) => btnStartExam(s, LoginForm.UserId, item.Id);


                        this.panelDesktopPane.Controls.Add(btn);
                    }
                    else
                    {
                        break;
                    }



                }

            }

        }






        private void btnStartExam(object sender, int userId, int examId)
        {

            OpenChildForm(new ExamForm2(userId, examId), sender);

        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectForm() , sender);
        }

        private void btnAddQuesAll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChooseAllQuestionForm(), sender);
        }

        private void btnAddQuesOne_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChooseOneQuestionForm(), sender);
        }

        private void btnAddQuesTF_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrueFalseQuestionForm(), sender);
        }


        private void btnAddExam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new teacherExam() , sender);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();

        }
    }
}
