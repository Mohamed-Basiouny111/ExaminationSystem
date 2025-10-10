using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.Question
{
    public partial class ChooseOneQuestionForm : Form
    {
        private readonly int CurrentUserId;
        private readonly string CurrentUserRole;
        private const string AdminRole = "Admin";
        private const string TeacherRole = "Teacher";
        private const string StudentRole = "Student";
        private int? CurrentQuestionId = null;


        private bool accessDenied = false;

        public ChooseOneQuestionForm()
        {
            InitializeComponent();

            CurrentUserId = LoginForm.UserId;
            CurrentUserRole = LoginForm.UserMission ?? string.Empty;

            if (CurrentUserRole.Equals(StudentRole, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Unauthorized access. You do not have permission to view this page.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                accessDenied = true;
                return;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (accessDenied)
            {
                this.BeginInvoke(new Action(() => this.Close()));
                return;
            }
            base.OnLoad(e);

            LoadExamComboBox();
            LoadQuestions();
        }

        private void ChooseOneQuestionForm_Load(object sender, EventArgs e)
        {
            //LoadExamComboBox();
            //LoadQuestions();
        }

        private void LoadExamComboBox()
        {
            using (var context = new ExaminationSystemContext())
            {
                IQueryable<Exam> examsQuery = context.Exams;

                if (CurrentUserRole.Equals(TeacherRole, StringComparison.OrdinalIgnoreCase))
                {
                    examsQuery = examsQuery.Where(e => e.UserId == CurrentUserId);
                }

                var exams = examsQuery.ToList();
                exams.Insert(0, new Exam { Id = 0, Title = "<None>" });

                cmbAssignExam.DisplayMember = "Title";
                cmbAssignExam.ValueMember = "Id";
                cmbAssignExam.DataSource = exams;
                cmbAssignExam.SelectedIndex = 0;
            }
        }

        private void LoadQuestions()
        {
            dgvQs.Rows.Clear();

            using (var context = new ExaminationSystemContext())
            {
                var exams = context.Exams.ToList();
                // exams.Insert(0, new Exam { Id = 0, Title = "<None>" });

                if (dgvQs.Columns["AddToExam"] == null)
                {
                    var examColumn = new DataGridViewComboBoxColumn
                    {
                        Name = "AddToExam",
                        HeaderText = "Assign to Exam",
                        DisplayMember = "Title",
                        ValueMember = "Id",
                        DataSource = exams,
                        FlatStyle = FlatStyle.Standard,
                        DefaultCellStyle = { NullValue = "<None>" }
                    };

                    dgvQs.Columns.Insert(2, examColumn);
                }
                else
                {
                    ((DataGridViewComboBoxColumn)dgvQs.Columns["AddToExam"]).DataSource = exams;
                }

                IQueryable<ChooseOneQuestion> query = context.Questions
                    .OfType<ChooseOneQuestion>()
                    .Include(q => q.Answers)
                    .Include(q => q.Exam);

                if (CurrentUserRole.Equals(TeacherRole, StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(q => q.Exam != null && q.Exam.UserId == CurrentUserId);
                }

                var questions = query.Select(q => new
                {
                    q.Id,
                    q.Header,
                    q.Body,
                    ExamId = q.ExamId
                }).ToList();

                foreach (var q in questions)
                {
                    int rowIndex = dgvQs.Rows.Add(null, null, null, q.Id, q.Header, q.Body);
                    dgvQs.Rows[rowIndex].Cells["AddToExam"].Value = q.ExamId;
                }

                if (dgvQs.Columns["Id"] != null)
                    dgvQs.Columns["Id"].Visible = false;
            }
        }

        private void dgvQs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvQs.IsCurrentCellDirty)
            {
                dgvQs.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvQs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvQs.Columns[e.ColumnIndex].Name != "AddToExam") return;

            int questionId = (int)dgvQs.Rows[e.RowIndex].Cells["Id"].Value;
            var selectedValue = dgvQs.Rows[e.RowIndex].Cells["AddToExam"].Value;

            using (var context = new ExaminationSystemContext())
            {
                var question = context.Questions.Include(q => q.Exam).FirstOrDefault(q => q.Id == questionId);
                if (question == null) return;

                int? newExamId = selectedValue == null ? null : (int?)selectedValue;

                if (CurrentUserRole.Equals(TeacherRole, StringComparison.OrdinalIgnoreCase) && newExamId != null)
                {
                    var exam = context.Exams.Find(newExamId);
                    if (exam == null || exam.UserId != CurrentUserId)
                    {
                        MessageBox.Show("You can only assign questions to your own exams.",
                            "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadQuestions();
                        return;
                    }
                }

                question.ExamId = newExamId;
                context.SaveChanges();
            }
        }

        private void dgvQs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvQs.Columns[e.ColumnIndex].Name;
            int questionId = (int)dgvQs.Rows[e.RowIndex].Cells["Id"].Value;

            using (var context = new ExaminationSystemContext())
            {
                var question = context.Questions
                    .Include(q => q.Answers)
                    .Include(q => q.Exam)
                    .FirstOrDefault(q => q.Id == questionId);
                if (question == null) return;

                if (colName == "Display")
                {
                    CurrentQuestionId = question.Id;

                    // Fill the form fields
                    txtHeader.Text = question.Header;
                    rtbBody.Text = question.Body;
                    txtMarks.Text = question.Marks.ToString();
                    cmbAssignExam.SelectedValue = question.ExamId ?? 0;

                    lstAnswers.Items.Clear();
                    foreach (var ans in question.Answers)
                    {
                        int index = lstAnswers.Items.Add(ans.Text);
                        if (ans.IsCorrect)
                            lstAnswers.SetSelected(index, true);
                    }

                }

                else if (colName == "Delete")
                {
                    if (CurrentUserRole.Equals(TeacherRole, StringComparison.OrdinalIgnoreCase))
                    {
                        if (question.Exam == null || question.Exam.UserId != CurrentUserId)
                        {
                            MessageBox.Show("You can only delete your own questions.",
                                "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    var result = MessageBox.Show("Are you sure you want to delete this question?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        context.Answers.RemoveRange(question.Answers);
                        context.Questions.Remove(question);
                        context.SaveChanges();
                        LoadQuestions();
                    }
                }
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (CurrentUserRole.Equals(StudentRole, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You are not authorized to add or update questions.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate inputs
            if (cmbAssignExam.SelectedValue == null || (int)cmbAssignExam.SelectedValue == 0)
            {
                MessageBox.Show("Please assign the question to an exam.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHeader.Text) ||
                string.IsNullOrWhiteSpace(rtbBody.Text) ||
                string.IsNullOrWhiteSpace(txtMarks.Text) ||
                lstAnswers.Items.Count == 0 ||
                lstAnswers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please fill in all fields, add answers, and select correct ones.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtMarks.Text, out int marks))
            {
                MessageBox.Show("Marks must be a number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedExamId = (int)cmbAssignExam.SelectedValue;
            using (var context = new ExaminationSystemContext())
            {
                if (CurrentUserRole.Equals(TeacherRole, StringComparison.OrdinalIgnoreCase) && selectedExamId != 0)
                {
                    var exam = context.Exams.Find(selectedExamId);
                    if (exam == null || exam.UserId != CurrentUserId)
                    {
                        MessageBox.Show("You can only modify questions in your own exams.",
                            "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (CurrentQuestionId == null)
                {
                    var question = new ChooseOneQuestion
                    {
                        Header = txtHeader.Text.Trim(),
                        Body = rtbBody.Text.Trim(),
                        Marks = marks,
                        ExamId = selectedExamId == 0 ? null : (int?)selectedExamId
                    };

                    // Add answers
                    for (int i = 0; i < lstAnswers.Items.Count; i++)
                    {
                        question.Answers.Add(new Answer
                        {
                            Text = lstAnswers.Items[i].ToString(),
                            IsCorrect = lstAnswers.SelectedIndices.Contains(i),
                            Question = question
                        });
                    }

                    context.Questions.Add(question);
                    context.SaveChanges();
                    MessageBox.Show("Question added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var existing = context.Questions
                        .OfType<ChooseOneQuestion>()
                        .Include(q => q.Answers)
                        .FirstOrDefault(q => q.Id == CurrentQuestionId);

                    if (existing == null)
                    {
                        MessageBox.Show("Question not found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    existing.Header = txtHeader.Text.Trim();
                    existing.Body = rtbBody.Text.Trim();
                    existing.Marks = marks;
                    existing.ExamId = selectedExamId == 0 ? null : (int?)selectedExamId;

                    // Remove old answers
                    context.Answers.RemoveRange(existing.Answers);

                    // Add new answers
                    for (int i = 0; i < lstAnswers.Items.Count; i++)
                    {
                        existing.Answers.Add(new Answer
                        {
                            Text = lstAnswers.Items[i].ToString(),
                            IsCorrect = lstAnswers.SelectedIndices.Contains(i),
                            QuestionId = existing.Id
                        });
                    }

                    context.SaveChanges();
                    MessageBox.Show("Question updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Reset form
            ClearForm();
            LoadQuestions();
        }


        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                lstAnswers.Items.Add(txtAnswer.Text.Trim());
                txtAnswer.Clear();
            }
            else
            {
                MessageBox.Show("Answer text cannot be empty.", "Validation Error");
            }
        }


        private void SearchQuestions(string searchText)
        {
            if (CurrentUserRole.Equals(StudentRole, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You are not authorized to search questions.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvQs.Rows.Clear();

            using (var context = new ExaminationSystemContext())
            {
                var exams = context.Exams.ToList();
                exams.Insert(0, new Exam { Id = 0, Title = "<None>" });

                DataGridViewComboBoxColumn examColumn;
                if (dgvQs.Columns["AddToExam"] == null)
                {
                    examColumn = new DataGridViewComboBoxColumn
                    {
                        Name = "AddToExam",
                        HeaderText = "Assign to Exam",
                        DisplayMember = "Title",
                        ValueMember = "Id",
                        DataSource = exams,
                        FlatStyle = FlatStyle.Standard,
                        DefaultCellStyle = { NullValue = "<None>" }
                    };
                    dgvQs.Columns.Insert(2, examColumn);
                }
                else
                {
                    examColumn = (DataGridViewComboBoxColumn)dgvQs.Columns["AddToExam"];
                    examColumn.DataSource = exams;
                }

                IQueryable<ChooseOneQuestion> query = context.Questions
                    .OfType<ChooseOneQuestion>()
                    .Include(q => q.Answers)
                    .Include(q => q.Exam);

                if (CurrentUserRole.Equals(TeacherRole, StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(q => q.Exam != null && q.Exam.UserId == CurrentUserId);
                }

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    searchText = searchText.Trim().ToLower();
                    query = query.Where(q => q.Header.ToLower().Contains(searchText) || q.Body.ToLower().Contains(searchText));
                }

                var questions = query.Select(q => new
                {
                    q.Id,
                    q.Header,
                    q.Body,
                    ExamId = q.ExamId
                }).ToList();

                foreach (var q in questions)
                {
                    int rowIndex = dgvQs.Rows.Add("Display", "Delete", null, q.Id, q.Header, q.Body);
                    dgvQs.Rows[rowIndex].Cells["AddToExam"].Value = q.ExamId;
                }

                if (dgvQs.Columns["Id"] != null)
                    dgvQs.Columns["Id"].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            SearchQuestions(searchText);
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadQuestions();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {

            if (lstAnswers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one answer to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete the selected answer(s)?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var selectedAnswers = lstAnswers.SelectedItems.Cast<object>().ToList();

            foreach (var ans in selectedAnswers)
            {
                lstAnswers.Items.Remove(ans);
            }

        }


        private void ClearForm()
        {
            txtHeader.Clear();
            rtbBody.Clear();
            txtMarks.Clear();
            lstAnswers.Items.Clear();
            cmbAssignExam.SelectedIndex = 0;
            CurrentQuestionId = null;
        }

    }
}
