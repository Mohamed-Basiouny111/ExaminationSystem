using ClosedXML.Excel;
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

namespace ExaminationSystem.Forms.ReportForms
{
    public partial class StudentAnswerForm : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public StudentAnswerForm()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            if (LoginForm.UserMission == "Admin")
            {
                dgvUser.DataSource = db.StudentAnswers
                      .Include(a => a.Question)
                      .Include(a => a.Answer)
                      .Include(a => a.ExamAttempt)
                      .ThenInclude(u => u.Student)
                      .ThenInclude(u => u.Exam)
                      .ThenInclude(u => u.User)
                      .Select(a => new
                      {
                          a.Id,
                          StudentName = a.ExamAttempt.Student.UserName,
                          ExamTitle = a.ExamAttempt.Exam.Title,
                          Teacher = a.ExamAttempt.Exam.User.UserName,
                          Question = a.Question.Body,
                          StudentAnswer = a.Answer.Text,
                          a.AnsweredAt
                      }).OrderByDescending(x => x.Id).Take(100).ToList();
            }
            else
            {
                dgvUser.DataSource = db.StudentAnswers
                      .Include(a => a.Question)
                      .Include(a => a.Answer)
                      .Include(a => a.ExamAttempt)
                      .ThenInclude(u => u.Student)
                      .ThenInclude(u => u.Exam)
                      .ThenInclude(u => u.User)
                      .Select(a => new
                      {
                          a.Id,
                          StudentName = a.ExamAttempt.Student.UserName,
                          ExamTitle = a.ExamAttempt.Exam.Title,
                          Teacher = a.ExamAttempt.Exam.User.UserName,
                          Question = a.Question.Body,
                          StudentAnswer = a.Answer.Text,
                          a.AnsweredAt
                      }).Where(u => u.Teacher == LoginForm.UserName).OrderByDescending(x => x.Id).Take(100).ToList();
            }
            dgvUser.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUser.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvUser.ClearSelection();

            txtSearch.Text = "";
            txtSearch.Focus();
            txtSearch.Select();
            txtSearch.SelectAll();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            j = Math.Max(j - 1, 0);

            if (LoginForm.UserMission == "Admin")
            {
                dgvUser.DataSource = db.StudentAnswers
                     .Include(a => a.Question)
                     .Include(a => a.Answer)
                     .Include(a => a.ExamAttempt)
                     .ThenInclude(u => u.Student)
                     .ThenInclude(u => u.Exam)
                     .ThenInclude(u => u.User)
                     .Select(a => new
                     {
                         a.Id,
                         StudentName = a.ExamAttempt.Student.UserName,
                         ExamTitle = a.ExamAttempt.Exam.Title,
                         Teacher = a.ExamAttempt.Exam.User.UserName,
                         Question = a.Question.Body,
                         StudentAnswer = a.Answer.Text,
                         a.AnsweredAt
                     }).OrderByDescending(x => x.Id).Take(100).Skip(j * 100).Take(100).ToList();
            }
            else
            {
                dgvUser.DataSource = db.StudentAnswers
                     .Include(a => a.Question)
                     .Include(a => a.Answer)
                     .Include(a => a.ExamAttempt)
                     .ThenInclude(u => u.Student)
                     .ThenInclude(u => u.Exam)
                     .ThenInclude(u => u.User)
                     .Select(a => new
                     {
                         a.Id,
                         StudentName = a.ExamAttempt.Student.UserName,
                         ExamTitle = a.ExamAttempt.Exam.Title,
                         Teacher = a.ExamAttempt.Exam.User.UserName,
                         Question = a.Question.Body,
                         StudentAnswer = a.Answer.Text,
                         a.AnsweredAt
                     }).Where(u => u.Teacher == LoginForm.UserName).OrderByDescending(x => x.Id).Take(100).Skip(j * 100).Take(100).ToList();
            }

        }
        int j = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            j++;
            if (LoginForm.UserMission == "Admin")
            {
                dgvUser.DataSource = db.StudentAnswers
                     .Include(a => a.Question)
                     .Include(a => a.Answer)
                     .Include(a => a.ExamAttempt)
                     .ThenInclude(u => u.Student)
                     .ThenInclude(u => u.Exam)
                     .ThenInclude(u => u.User)
                     .Select(a => new
                     {
                         a.Id,
                         StudentName = a.ExamAttempt.Student.UserName,
                         ExamTitle = a.ExamAttempt.Exam.Title,
                         Teacher = a.ExamAttempt.Exam.User.UserName,
                         Question = a.Question.Body,
                         StudentAnswer = a.Answer.Text,
                         a.AnsweredAt
                     }).OrderByDescending(x => x.Id).Skip(j * 100).Take(100).ToList();
            }
            else
            {
                dgvUser.DataSource = db.StudentAnswers
                     .Include(a => a.Question)
                     .Include(a => a.Answer)
                     .Include(a => a.ExamAttempt)
                     .ThenInclude(u => u.Student)
                     .ThenInclude(u => u.Exam)
                     .ThenInclude(u => u.User)
                     .Select(a => new
                     {
                         a.Id,
                         StudentName = a.ExamAttempt.Student.UserName,
                         ExamTitle = a.ExamAttempt.Exam.Title,
                         Teacher = a.ExamAttempt.Exam.User.UserName,
                         Question = a.Question.Body,
                         StudentAnswer = a.Answer.Text,
                         a.AnsweredAt
                     }).Where(u => u.Teacher == LoginForm.UserName).OrderByDescending(x => x.Id).Skip(j * 100).Take(100).ToList();
            }
        }

        private void btnDSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { FileName = "ExportedData", DefaultExt = "xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Export");

                        // العناوين
                        for (int i = 0; i < dgvUser.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvUser.Columns[i].HeaderText;
                        }

                        // البيانات
                        for (int r = 0; r < dgvUser.Rows.Count; r++)
                        {
                            for (int c = 0; c < dgvUser.Columns.Count; c++)
                            {
                                worksheet.Cell(r + 2, c + 1).Value = dgvUser.Rows[r].Cells[c].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Successfully");
                    }
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Complete Your Data", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                return;
            }

            string searchText = txtSearch.Text.Trim();

            var query = db.StudentAnswers
                      .Include(a => a.Question)
                      .Include(a => a.Answer)
                      .Include(a => a.ExamAttempt)
                      .ThenInclude(u => u.Student)
                      .ThenInclude(u => u.Exam)
                      .ThenInclude(u => u.User)
                      .Select(a => new
                      {
                          a.Id,
                          StudentName = a.ExamAttempt.Student.UserName,
                          ExamTitle = a.ExamAttempt.Exam.Title,
                          Teacher = a.ExamAttempt.Exam.User.UserName,
                          Question = a.Question.Body,
                          StudentAnswer = a.Answer.Text,
                          a.AnsweredAt
                      });

            if (LoginForm.UserMission != "Admin")
            {
                query = query.Where(a => a.Teacher == LoginForm.UserName);
            }
          


            query = query.Where(a => a.ExamTitle.Contains(searchText) || a.StudentName.Contains(txtSearch.Text));



            dgvUser.DataSource = query
                .OrderByDescending(x => x.Id)
                .ToList();
        }
    }
}
