using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.Exam_Status_Form
{
    public partial class ExamStatusForm : Form
    {
        private const string AdminRole = "Admin";
        private int CurrentUserId = -1;
        private string CurrentUserRole = string.Empty;
        private int SelectedExamId = -1;

        public ExamStatusForm()
        {
            InitializeComponent();

            this.CurrentUserId = LoginForm.UserId;
            this.CurrentUserRole = LoginForm.UserMission;
            //LoadExamModes();

            this.Load += new EventHandler(ExamStatusForm_Load);
            dgvExams.SelectionChanged += dgvExams_SelectionChanged;

            btnUpdateStatus.Click += btnUpdateStatus_Click;
        }
        private void ExamStatusForm_Load(object sender, EventArgs e)
        {
            LoadExams();
            LoadExamModes();
            SetInitialState();
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExams.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvExams.SelectedRows[0];

                if (row.Cells["Id"].Value == null)
                {
                    SelectedExamId = -1;
                    lblSelectedExamTitle.Text = "No Exam Selected (Invalid Row)";
                    SetInitialState();
                    return;
                }

                SelectedExamId = (int)row.Cells["Id"].Value;

                string examTitle = row.Cells["Title"].Value?.ToString() ?? "N/A";
                lblSelectedExamTitle.Text = $"Selected Exam: {examTitle}";

                string currentMode = row.Cells["Mode"].Value?.ToString() ?? ExamMode.Queued.ToString();
                if (Enum.TryParse(currentMode, out ExamMode mode))
                {
                    cmbExamMode.SelectedItem = mode;
                }

                btnUpdateStatus.Enabled = true;
                cmbExamMode.Enabled = true;
            }
            else
            {
                SelectedExamId = -1;

                lblSelectedExamTitle.Text = "No Exam Selected";
                SetInitialState();
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (SelectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbExamMode.SelectedItem == null)
            {
                MessageBox.Show("Please select a new mode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExamMode newMode = (ExamMode)cmbExamMode.SelectedItem;
            UpdateExamStatus(SelectedExamId, newMode);
        }

        private void SetInitialState()
        {
            btnUpdateStatus.Enabled = false;
            cmbExamMode.Enabled = false;
        }

        void LoadExamModes()
        {
            cmbExamMode.DataSource = Enum.GetValues(typeof(ExamMode));
            cmbExamMode.SelectedIndex = -1;
        }

        void LoadExams()
        {
            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    IQueryable<Exam> examsQuery = context.Exams.Include(e => e.Subject);

                    if (this.CurrentUserRole != AdminRole)
                    {
                        examsQuery = examsQuery.Where(e => e.UserId == this.CurrentUserId);
                    }

                    var exams = examsQuery
                        .Select(e => new
                        {
                            Id = e.Id,
                            Title = e.Title,
                            Subject = e.Subject.Name,
                            Type = (e is FinalExam) ? "Final" : "Practice",
                            Questions = e.NumberOfQuestions,
                            Duration = e.Duration.TotalMinutes + " min",
                            Mode = e.Mode.ToString()
                        })
                        .ToList();

                    dgvExams.DataSource = exams;
                    dgvExams.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    if (dgvExams.Columns.Contains("Id"))
                    {
                        dgvExams.Columns["Id"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading exams: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateExamStatus(int examId, ExamMode newMode)
        {
            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    var examToUpdate = context.Exams.Find(examId);

                    if (examToUpdate != null)
                    {
                        if (examToUpdate.UserId != this.CurrentUserId && this.CurrentUserRole != AdminRole)
                        {
                            MessageBox.Show("You do not have permission to update this exam's status.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        if (examToUpdate.Mode == newMode)
                        {
                            MessageBox.Show($"Exam status is already '{newMode}'.", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        examToUpdate.Mode = newMode;
                        context.SaveChanges();

                        MessageBox.Show($"Exam status updated to '{newMode}' successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadExams();
                    }
                    else
                    {
                        MessageBox.Show("Exam not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating exam status: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}