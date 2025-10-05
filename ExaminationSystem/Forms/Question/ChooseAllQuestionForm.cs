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

namespace ExaminationSystem.Forms.Question
{
    public partial class ChooseAllQuestionForm : Form
    {
        public ChooseAllQuestionForm()
        {
            InitializeComponent();
            lstAnswers.SelectionMode = SelectionMode.MultiSimple;

            


        }

        private void ChooseAllQuestionForm_Load(object sender, EventArgs e)
        {
            LoadQuestions();
            LoadExamComboBox();
        }

        private void LoadExamComboBox()
        {
            using (var context = new ExaminationSystemContext())
            {
                var exams = context.Exams.ToList();
                exams.Insert(0, new Exam { Id = 0, Title = "<None>" }); // placeholder

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
                        DefaultCellStyle = { NullValue = "<None>" } // what to show if ExamId is null
                    };

                    dgvQs.Columns.Insert(2, examColumn);
                }
                else
                {
                    // refresh datasource if exams changed
                    ((DataGridViewComboBoxColumn)dgvQs.Columns["AddToExam"]).DataSource = exams;
                }


                var questions = context.Questions
                    .OfType<ChooseAllQuestion>()
                    .Include(q => q.Answers)
                    .Include(q => q.Exam)
                    .Select(q => new
                    {
                        q.Id,
                        q.Header,
                        q.Body,
                        ExamId = q.ExamId
                    })
                    .ToList();

                foreach (var q in questions)
                {
                    int rowIndex = dgvQs.Rows.Add("Display", "Delete", null, q.Id, q.Header, q.Body);
                    var row = dgvQs.Rows[rowIndex];

                    // set combo box value to the exam id (current assigned exam)
                    row.Cells["AddToExam"].Value = q.ExamId;
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

            if (dgvQs.Columns[e.ColumnIndex].Name == "AddToExam")
            {
                int questionId = (int)dgvQs.Rows[e.RowIndex].Cells["Id"].Value;
                var selectedValue = dgvQs.Rows[e.RowIndex].Cells["AddToExam"].Value;

                using (var context = new ExaminationSystemContext())
                {
                    var question = context.Questions.SingleOrDefault(q => q.Id == questionId);
                    if (question != null)
                    {
                        if (selectedValue == null)
                            question.ExamId = null;
                        else
                            question.ExamId = (int)selectedValue;


                        context.SaveChanges();
                    }
                }
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
                    .SingleOrDefault(q => q.Id == questionId);

                if (question == null) return;

                if (colName == "Display")
                {
                    var displayForm = new QuestionDisplayForm(question);
                    displayForm.ShowDialog();
                    LoadQuestions();
                }
                else if (colName == "Delete")
                {
                    context.Answers.RemoveRange(question.Answers);
                    context.Questions.Remove(question);
                    context.SaveChanges();
                    LoadQuestions();
                }
               
            }
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

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeader.Text) ||
                string.IsNullOrWhiteSpace(rtbBody.Text) ||
                string.IsNullOrWhiteSpace(txtMarks.Text) ||
                lstAnswers.Items.Count == 0 ||
                lstAnswers.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please fill in all fields, add at least one answer, and select the correct ones.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMarks.Text, out int marks))
            {
                MessageBox.Show("Marks must be a number.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ExaminationSystemContext())
            {
                var question = new ChooseAllQuestion
                {
                    Header = txtHeader.Text.Trim(),
                    Body = rtbBody.Text.Trim(),
                    Marks = marks,
                    ExamId = (int)cmbAssignExam.SelectedValue == 0 ? null : (int?)cmbAssignExam.SelectedValue
                };

                // Add all answers from the listbox
                for (int i = 0; i < lstAnswers.Items.Count; i++)
                {
                    var ans = new Answer
                    {
                        Text = lstAnswers.Items[i].ToString(),
                        IsCorrect = lstAnswers.SelectedIndices.Contains(i),
                        Question = question
                    };
                    question.Answers.Add(ans);
                }

                context.Questions.Add(question);
                context.SaveChanges();
            }


            MessageBox.Show("Choose All Question saved successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadQuestions();

            txtHeader.Clear();
            rtbBody.Clear();
            txtMarks.Clear();
            lstAnswers.Items.Clear();
            cmbAssignExam.SelectedIndex = 0;

        }
    }
}