using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.Question
{
    public partial class TrueFalseQuestionForm : Form
    {
        private readonly int CurrentUserId;
        private readonly string CurrentUserRole;
        private const string AdminRole = "Admin";
        private const string TeacherRole = "Teacher";
        private const string StudentRole = "Student";

        private bool accessDenied = false;

        public TrueFalseQuestionForm()
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

        private void TrueFalseQuestionForm_Load(object sender, EventArgs e)
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

                IQueryable<TrueFalseQuestion> query = context.Questions
                    .OfType<TrueFalseQuestion>()
                    .Include(q => q.Answers)
                    .Include(q => q.Exam);

                // Teachers: only questions linked to their exams
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
                    int rowIndex = dgvQs.Rows.Add("Display", "Delete", null, q.Id, q.Header, q.Body);
                    dgvQs.Rows[rowIndex].Cells["AddToExam"].Value = q.ExamId;
                }

                if (dgvQs.Columns["Id"] != null)
                    dgvQs.Columns["Id"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CurrentUserRole.Equals(StudentRole, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You are not authorized to add questions.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbAssignExam.SelectedValue == null || (int)cmbAssignExam.SelectedValue == 0)
            {
                MessageBox.Show("Please assign the question to an exam.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAssignExam.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHeader.Text) ||
                string.IsNullOrWhiteSpace(rtbBody.Text) ||
                string.IsNullOrWhiteSpace(txtMarks.Text) ||
                (!rbTrue.Checked && !rbFalse.Checked))
            {
                MessageBox.Show("Please fill in all fields and select the correct answer.",
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
                        MessageBox.Show("You can only add questions to your own exams.",
                            "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var question = new TrueFalseQuestion
                {
                    Header = txtHeader.Text.Trim(),
                    Body = rtbBody.Text.Trim(),
                    Marks = marks,
                    ExamId = selectedExamId == 0 ? null : (int?)selectedExamId
                };

                question.Answers.Add(new Answer { Text = "True", IsCorrect = rbTrue.Checked, Question = question });
                question.Answers.Add(new Answer { Text = "False", IsCorrect = rbFalse.Checked, Question = question });

                context.Questions.Add(question);
                context.SaveChanges();
            }

            MessageBox.Show("True/False question saved successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtHeader.Clear();
            rtbBody.Clear();
            txtMarks.Clear();
            rbTrue.Checked = false;
            rbFalse.Checked = false;
            cmbAssignExam.SelectedIndex = 0;
            LoadQuestions();
        }

        private void dgvQs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvQs.Columns[e.ColumnIndex].Name != "AddToExam") return;

            int questionId = (int)dgvQs.Rows[e.RowIndex].Cells["Id"].Value;
            var selectedValue = dgvQs.Rows[e.RowIndex].Cells["AddToExam"].Value;

            using (var context = new ExaminationSystemContext())
            {
                var question = context.Questions
                    .Include(q => q.Exam)
                    .FirstOrDefault(q => q.Id == questionId);
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
                    new QuestionDisplayForm(question).ShowDialog();
                    LoadQuestions();
                }
                else if (colName == "Delete")
                {
                    // Teacher can only delete own questions
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


        private void dgvQs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvQs.IsCurrentCellDirty)
            {
                dgvQs.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

                IQueryable<TrueFalseQuestion> query = context.Questions
                    .OfType<TrueFalseQuestion>()
                    .Include(q => q.Answers)
                    .Include(q => q.Exam);

                if (CurrentUserRole.Equals(TeacherRole, StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(q => q.Exam != null && q.Exam.UserId == CurrentUserId);
                }

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    searchText = searchText.Trim().ToLower();
                    query = query.Where(q =>
                        q.Header.ToLower().Contains(searchText) ||
                        q.Body.ToLower().Contains(searchText));
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

    }
}

    