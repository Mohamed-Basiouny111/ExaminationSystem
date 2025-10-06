using DocumentFormat.OpenXml.Drawing;
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
            var Query = db.ExamAttempts.Include(s => s.Student)
                .Include(x => x.Exam)
                .ThenInclude(u => u.User)
               .Select(
                x => new
                {
                    x.Id,
                    StudentName = x.Student.UserName,
                    Exam = x.Exam.Title,
                    ExamType = EF.Property<string>(x.Exam, "ExamType"),
                    x.Score,
                    x.StartedAt,
                    x.FinishedAt
                });

            if (LoginForm.UserMission == "Admin")
            {

            }
             
            var QList = Query.OrderBy(x => x.Id).Take(100).ToList();
            dgvUser.DataSource = QList;
            dgvUser.ClearSelection();

            txtSearch.Text = "";
            txtSearch.Focus();
            txtSearch.Select();
            txtSearch.SelectAll();
        }
    }
}
