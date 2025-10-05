      using ExaminationSystem.Data;
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
//Testing commit wuth git
namespace ExaminationSystem.Forms.TeacherForn
{
    public partial class teacherExam : Form
    {
        public teacherExam()
        {
            InitializeComponent();
            this.Load += new EventHandler(teacherExam_Load);

            txtExamTitle.KeyDown += txtExamTitle_KeyDown;
            cmbSubject.KeyDown += cmbSubject_KeyDown;
            numQuestionCount.Enter += PerformFocus;
            numQuestionCount.KeyDown += numQuestionCount_KeyDown;

            numDurationMinutes.Enter += PerformFocus;
            numDurationMinutes.KeyDown += numDurationMinutes_KeyDown;
        }

        private void teacherExam_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            ClearFields();
        }
        void LoadSubjects()
        {
            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    var subjects = context.Subjects
                        .Select(s => new { Id = s.Id, Name = s.Name })
                        .ToList();

                    cmbSubject.DataSource = subjects;
                    cmbSubject.DisplayMember = "Name";
                    cmbSubject.ValueMember = "Id";

                    if (subjects.Any())
                    {
                        cmbSubject.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveExam.Enabled = false;
            }
        }

        void ClearFields()
        {
            txtExamTitle.Text = "";

            numQuestionCount.Value = numQuestionCount.Minimum;
            numDurationMinutes.Value = numDurationMinutes.Minimum;

            rbPractice.Checked = false;
            rbFinal.Checked = false;

            if (cmbSubject.Items.Count > 0)
            {
                cmbSubject.SelectedIndex = 0;
            }

            txtExamTitle.Focus();
        }

        void SaveExamToDatabase(Exam examToSave)
        {
            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    context.Exams.Add(examToSave);
                    context.SaveChanges();

                    MessageBox.Show("Exam Created Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error While Saving: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamTitle.Text))
            {
                MessageBox.Show("Please Enter Exam Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtExamTitle.Focus();
                return;
            }

            if (cmbSubject.SelectedValue == null || cmbSubject.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Please Choose Subject Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return;
            }
            Exam newExam;
            if (rbPractice.Checked)
            {
                newExam = new PracticeExam();
            }
            else if (rbFinal.Checked)
            {
                newExam = new FinalExam();
            }
            else
            {
                MessageBox.Show("Please Choose Exam Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newExam.Title = txtExamTitle.Text;
            newExam.SubjectId = (int)cmbSubject.SelectedValue;
            newExam.NumberOfQuestions = (int)numQuestionCount.Value;

            int durationMinutes = (int)numDurationMinutes.Value;
            newExam.Duration = TimeSpan.FromMinutes(durationMinutes);
            newExam.Mode = ExamMode.Queued;

            SaveExamToDatabase(newExam);
        }
        private void PerformFocus(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            if (nud != null)
            {
                nud.Select(0, nud.Text.Length);
            }
        }
        private void txtExamTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cmbSubject.Focus();
            }
        }

        private void cmbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                numQuestionCount.Focus();
            }
        }

        private void numQuestionCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                numDurationMinutes.Focus();
            }
        }

        private void numDurationMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSaveExam.PerformClick();
            }
        }
    }
}