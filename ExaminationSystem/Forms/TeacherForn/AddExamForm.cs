using ExaminationSystem.Data;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Forms.TeacherForn
{
    public partial class teacherExam : Form
    {
        private bool IsEditing = false;
        private int ExamToEditId = -1;
        private int CurrentUserId = -1;

        private const string AdminRole = "Admin";
        private string CurrentUserRole = string.Empty;

        public teacherExam()
        {
            InitializeComponent();

            this.Load += new EventHandler(teacherExam_Load);

            if (int.TryParse(GlobalData.CurrentUserId, out int userId))
            {
                this.CurrentUserId = userId;
            }

            this.CurrentUserRole = GlobalData.UserMission;

            txtExamTitle.KeyDown += txtExamTitle_KeyDown;
            cmbSubject.KeyDown += cmbSubject_KeyDown;
            numQuestionCount.Enter += PerformFocus;
            numQuestionCount.KeyDown += numQuestionCount_KeyDown;
            numDurationMinutes.Enter += PerformFocus;
            numDurationMinutes.KeyDown += numDurationMinutes_KeyDown;

            btnSaveExam.Click += btnSaveExam_Click;
            btnDelete.Click += btnDelete_Click;
            btnCancel.Click += btnCancel_Click;
            dgvExams.DoubleClick += dgvExams_DoubleClick;

            if (this.CurrentUserId <= 0)
            {
                MessageBox.Show("User ID is not set or invalid. Please ensure you are logged in.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveExam.Enabled = false;
            }
        }

        private void teacherExam_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            ClearFields();
            LoadExams();
            SetFormMode(false);
        }

        private void SetFormMode(bool isEditing)
        {
            IsEditing = isEditing;

            if (IsEditing)
            {
                btnSaveExam.Text = "Update Exam";
                btnCancel.Visible = true;
            }
            else
            {
                btnSaveExam.Text = "Save Exam";
                btnCancel.Visible = false;
                ExamToEditId = -1;
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
            SetFormMode(false);
        }

        private bool IsDuplicateTitle(string title, int subjectId, int examIdToIgnore = -1)
        {
            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    return context.Exams
                                  .Any(ex => ex.Title == title.Trim()
                                             && ex.SubjectId == subjectId
                                             && ex.Id != examIdToIgnore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking duplicate title: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
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
                        btnSaveExam.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No subjects found in the database. Please add subjects first.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSaveExam.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}\n\nCheck if the 'Subjects' table exists and contains data.", "Database Error - Subjects Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveExam.Enabled = false;
            }
        }

        void LoadExams()
        {
            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    IQueryable<Exam> examsQuery = context.Exams;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExams.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an exam to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int examIdToDelete = (int)dgvExams.SelectedRows[0].Cells["Id"].Value;
            string examTitle = dgvExams.SelectedRows[0].Cells["Title"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the exam: {examTitle}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new ExaminationSystemContext())
                    {
                        var examToDelete = context.Exams.FirstOrDefault(e => e.Id == examIdToDelete);

                        if (examToDelete != null && examToDelete.UserId != this.CurrentUserId && this.CurrentUserRole != AdminRole)
                        {
                            MessageBox.Show("You can only delete exams that you created.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        if (examToDelete != null)
                        {
                            context.Exams.Remove(examToDelete);
                            context.SaveChanges();

                            MessageBox.Show("Exam deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadExams();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting exam: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvExams_DoubleClick(object sender, EventArgs e)
        {
            if (dgvExams.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvExams.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;

                try
                {
                    using (var context = new ExaminationSystemContext())
                    {
                        var exam = context.Exams.FirstOrDefault(e => e.Id == id);

                        if (exam != null && exam.UserId != this.CurrentUserId && this.CurrentUserRole != AdminRole)
                        {
                            MessageBox.Show("You can only edit exams that you created.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        if (exam != null)
                        {
                            txtExamTitle.Text = exam.Title;
                            cmbSubject.SelectedValue = exam.SubjectId;
                            numQuestionCount.Value = exam.NumberOfQuestions;
                            numDurationMinutes.Value = (decimal)exam.Duration.TotalMinutes;

                            if (exam is FinalExam)
                            {
                                rbFinal.Checked = true;
                                rbPractice.Checked = false;
                            }
                            else if (exam is PracticeExam)
                            {
                                rbPractice.Checked = true;
                                rbFinal.Checked = false;
                            }

                            ExamToEditId = id;
                            SetFormMode(true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading exam details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void UpdateExamInDatabase(Exam updatedExam)
        {
            if (this.CurrentUserId <= 0) return;

            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    var existingExam = context.Exams.Find(updatedExam.Id);

                    if (existingExam != null)
                    {
                        existingExam.Title = updatedExam.Title;
                        existingExam.SubjectId = updatedExam.SubjectId;
                        existingExam.NumberOfQuestions = updatedExam.NumberOfQuestions;
                        existingExam.Duration = updatedExam.Duration;
                        existingExam.Mode = updatedExam.Mode;

                        context.SaveChanges();

                        MessageBox.Show("Exam Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadExams();
                    }
                }
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException != null ? ex.InnerException.Message : "No further details available.";
                MessageBox.Show($"Error While Updating: Failed to update changes. Inner Error: {innerMessage}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SaveExamToDatabase(Exam examToSave)
        {
            if (this.CurrentUserId <= 0) return;

            try
            {
                using (var context = new ExaminationSystemContext())
                {
                    examToSave.UserId = this.CurrentUserId;

                    context.Exams.Add(examToSave);
                    context.SaveChanges();

                    MessageBox.Show("Exam Created Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadExams();
                }
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException != null ? ex.InnerException.Message : "No further details available.";
                MessageBox.Show($"Error While Saving: Failed to save changes. Inner Error: {innerMessage}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            if (this.CurrentUserId <= 0)
            {
                MessageBox.Show("Cannot proceed. User ID is missing or invalid. Please log in again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string examTitle = txtExamTitle.Text.Trim();

            if (cmbSubject.SelectedValue == null || cmbSubject.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Please choose a Subject Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return;
            }

            int selectedSubjectId = (int)cmbSubject.SelectedValue;

            if (string.IsNullOrWhiteSpace(examTitle))
            {
                MessageBox.Show("Please Enter Exam Title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamTitle.Focus();
                return;
            }

            int idToCheck = IsEditing ? ExamToEditId : -1;
            if (IsDuplicateTitle(examTitle, selectedSubjectId, idToCheck))
            {
                MessageBox.Show("An exam with this title already exists for this subject. Please choose a different title.", "Duplicate Title Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamTitle.Focus();
                return;
            }

            Exam exam;
            if (rbPractice.Checked)
            {
                exam = new PracticeExam();
            }
            else if (rbFinal.Checked)
            {
                exam = new FinalExam();
            }
            else
            {
                MessageBox.Show("Please Choose Exam Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            exam.Title = examTitle;
            exam.SubjectId = selectedSubjectId;
            exam.NumberOfQuestions = (int)numQuestionCount.Value;
            exam.Duration = TimeSpan.FromMinutes((int)numDurationMinutes.Value);
            exam.Mode = ExamMode.Queued;

            exam.UserId = this.CurrentUserId;

            if (IsEditing)
            {
                exam.Id = ExamToEditId;
                UpdateExamInDatabase(exam);
            }
            else
            {
                SaveExamToDatabase(exam);
            }
        }

        private void PerformFocus(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            if (nud != null) { nud.Select(0, nud.Text.Length); }
        }
        private void txtExamTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { e.SuppressKeyPress = true; cmbSubject.Focus(); }
        }
        private void cmbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { e.SuppressKeyPress = true; numQuestionCount.Focus(); }
        }
        private void numQuestionCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { e.SuppressKeyPress = true; numDurationMinutes.Focus(); }
        }
        private void numDurationMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { e.SuppressKeyPress = true; btnSaveExam.PerformClick(); }
        }
    }
}
