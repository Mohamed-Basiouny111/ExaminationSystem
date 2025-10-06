using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using ExaminationSystem.BL.UserLayer;
using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.ReportForms
{
    public partial class ExamAttemptForm : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();

        public ExamAttemptForm()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            #region Before Role
            //dgvUser.DataSource = db.ExamAttempts
            //          .Include(a => a.Student)
            //          .Include(a => a.Exam)
            //          .ThenInclude(u => u.User)
            //          .Select(a => new
            //          {
            //              a.Id,
            //              a.StudentId,
            //              ExamTitle = a.Exam.Title,
            //              ExamType = EF.Property<string>(a.Exam, "ExamType"),
            //              a.Score,
            //              a.StartedAt,
            //              a.FinishedAt
            //               ,
            //              Teacher = a.Exam.User.UserName
            //          }).OrderByDescending(x => x.Id).Take(100).ToList(); 
            #endregion

            if (LoginForm.UserMission == "Admin")
            {
                dgvUser.DataSource = db.ExamAttempts
                      .Include(a => a.Student)
                      .Include(a => a.Exam)
                      .ThenInclude(u => u.User)
                      .Select(a => new
                      {
                          a.Id,
                          StudentName = a.Student.FullName,
                          ExamTitle = a.Exam.Title,
                          ExamType = EF.Property<string>(a.Exam, "ExamType"),
                          a.Score,
                          a.StartedAt,
                          a.FinishedAt
                           ,
                          Teacher = a.Exam.User.UserName
                      }).OrderByDescending(x => x.Id).Take(100).ToList();
            }
            else
            {
                dgvUser.DataSource = db.ExamAttempts
                     .Include(a => a.Student)
                     .Include(a => a.Exam)
                     .ThenInclude(u => u.User)
                     .Select(a => new
                     {
                         a.Id,
                         StudentName = a.Student.FullName,
                         ExamTitle = a.Exam.Title,
                         ExamType = EF.Property<string>(a.Exam, "ExamType"),
                         a.Score,
                         a.StartedAt,
                         a.FinishedAt
                         ,
                         Teacher = a.Exam.User.UserName
                     }).Where(u => u.Teacher == LoginForm.UserName).OrderByDescending(x => x.Id).Take(100).ToList();
            }


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

            #region Befor Role

            //dgvUser.DataSource = db.ExamAttempts
            //        .Include(a => a.Student)
            //        .Include(a => a.Exam)
            //        .ThenInclude(u => u.User)
            //        .Select(a => new
            //        {
            //            a.Id,
            //            a.StudentId,
            //            ExamTitle = a.Exam.Title,
            //            ExamType = EF.Property<string>(a.Exam, "ExamType"),
            //            a.Score,
            //            a.StartedAt,
            //            a.FinishedAt
            //             ,
            //            Teacher = a.Exam.User.UserName
            //        }).OrderByDescending(x => x.Id).Take(100).Skip(j * 100).Take(100).ToList(); 
            #endregion

            if (LoginForm.UserMission == "Admin")
            {
                dgvUser.DataSource = db.ExamAttempts
                      .Include(a => a.Student)
                      .Include(a => a.Exam)
                      .ThenInclude(u => u.User)
                      .Select(a => new
                      {
                          a.Id,
                          StudentName = a.Student.FullName,
                          ExamTitle = a.Exam.Title,
                          ExamType = EF.Property<string>(a.Exam, "ExamType"),
                          a.Score,
                          a.StartedAt,
                          a.FinishedAt
                           ,
                          Teacher = a.Exam.User.UserName
                      }).OrderByDescending(x => x.Id).Take(100).Skip(j * 100).Take(100).ToList();
            }
            else
            {
                dgvUser.DataSource = db.ExamAttempts
                     .Include(a => a.Student)
                     .Include(a => a.Exam)
                     .ThenInclude(u => u.User)
                     .Select(a => new
                     {
                         a.Id,
                         StudentName = a.Student.FullName,
                         ExamTitle = a.Exam.Title,
                         ExamType = EF.Property<string>(a.Exam, "ExamType"),
                         a.Score,
                         a.StartedAt,
                         a.FinishedAt
                         ,
                         Teacher = a.Exam.User.UserName
                     }).Where(u => u.Teacher == LoginForm.UserName).OrderByDescending(x => x.Id).Take(100).Skip(j * 100).Take(100).ToList();
            }

        }
        int j = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            j++;
            #region Befor Role
            //dgvUser.DataSource = db.ExamAttempts
            //         .Include(a => a.Student)
            //         .Include(a => a.Exam)
            //         .ThenInclude(u => u.User)
            //         .Select(a => new
            //         {
            //             a.Id,
            //             a.StudentId,
            //             ExamTitle = a.Exam.Title,
            //             ExamType = EF.Property<string>(a.Exam, "ExamType"),
            //             a.Score,
            //             a.StartedAt,
            //             a.FinishedAt
            //              ,
            //             Teacher = a.Exam.User.UserName
            //         }).OrderByDescending(x => x.Id).Take(100).Skip(j * 100).Take(100).ToList(); 
            #endregion

            if (LoginForm.UserMission == "Admin")
            {
                dgvUser.DataSource = db.ExamAttempts
                      .Include(a => a.Student)
                      .Include(a => a.Exam)
                      .ThenInclude(u => u.User)
                      .Select(a => new
                      {
                          a.Id,
                          StudentName = a.Student.FullName,
                          ExamTitle = a.Exam.Title,
                          ExamType = EF.Property<string>(a.Exam, "ExamType"),
                          a.Score,
                          a.StartedAt,
                          a.FinishedAt
                           ,
                          Teacher = a.Exam.User.UserName
                      }).OrderByDescending(x => x.Id).Skip(j * 100).Take(100).ToList();
            }
            else
            {
                dgvUser.DataSource = db.ExamAttempts
                     .Include(a => a.Student)
                     .Include(a => a.Exam)
                     .ThenInclude(u => u.User)
                     .Select(a => new
                     {
                         a.Id,
                         StudentName = a.Student.FullName,
                         ExamTitle = a.Exam.Title,
                         ExamType = EF.Property<string>(a.Exam, "ExamType"),
                         a.Score,
                         a.StartedAt,
                         a.FinishedAt
                         ,
                         Teacher = a.Exam.User.UserName
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
        #region Before Role

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtSearch.Text))
        //    {
        //        MessageBox.Show("Complete Your Data", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        Clear();
        //        return;
        //    }

        //    string searchText = txtSearch.Text.Trim();
        //    bool isId = int.TryParse(searchText, out int id);

        //    var query = db.ExamAttempts
        //        .Include(a => a.Student)
        //        .Include(a => a.Exam)
        //        .ThenInclude(e => e.User)
        //        .Select(a => new
        //        {
        //            a.Id,
        //            a.StudentId,
        //            ExamTitle = a.Exam.Title,
        //            ExamType = EF.Property<string>(a.Exam, "ExamType"),
        //            a.Score,
        //            a.StartedAt,
        //            a.FinishedAt,
        //            Teacher = a.Exam.User.UserName
        //        });

        //    if (isId)
        //    {
        //        query = query.Where(s => s.StudentId == id);
        //    }
        //    else
        //    {
        //        query = query.Where(s => s.ExamTitle.Contains(searchText));
        //    }

        //    dgvUser.DataSource = query
        //        .OrderByDescending(x => x.Id)
        //        .ToList();



        //}

        #endregion



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Complete Your Data", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                return;
            }

            string searchText = txtSearch.Text.Trim();

            var query = db.ExamAttempts
                .Include(a => a.Student)
                .Include(a => a.Exam)
                .ThenInclude(e => e.User)
                .Select(a => new
                {
                    a.Id,
                    a.StudentId,
                    StudentName = a.Student.FullName,
                    ExamTitle = a.Exam.Title,
                    ExamType = EF.Property<string>(a.Exam, "ExamType"),
                    a.Score,
                    a.StartedAt,
                    a.FinishedAt,
                    Teacher = a.Exam.User.UserName
                });

            if (LoginForm.UserMission != "Admin")
            {
                query = query.Where(a => a.Teacher == LoginForm.UserName);
            }

          
                query = query.Where(a => a.ExamTitle.Contains(searchText) || a.StudentName.Contains(txtSearch.Text));
            


            dgvUser.DataSource = query
                .OrderByDescending(x => x.Id)
                .Take(100)
                .ToList();
        }

    }
}
