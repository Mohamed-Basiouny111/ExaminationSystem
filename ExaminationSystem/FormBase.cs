using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(210, 193, 182);
                    currentButton.ForeColor = Color.White;
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
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

       
    }
}
