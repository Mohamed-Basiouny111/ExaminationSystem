using ExaminationSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.ExamForm
{
    public partial class PracticeExamResult : Form
    {
        private readonly int _examAttemptId;
        private ExaminationSystemContext db = new ExaminationSystemContext();
        public PracticeExamResult()
        {
            InitializeComponent();
        }
        public PracticeExamResult(int examAttemptId)
        {
            InitializeComponent();
            _examAttemptId = examAttemptId;
        }

        
        private void dgvResullt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PracticeExamResult_Load(object sender, EventArgs e)
        {
            LoadPracticeResult();
        }

        private void LoadPracticeResult()
        {
              var attempt = db.ExamAttempts
                .Where(a => a.Id == _examAttemptId)
                .Select(a => new
                {
                    ExamTitle = a.Exam.Title,
                    TotalMarks = a.Exam.Questions.Sum(q => q.Marks),
                    Score = a.Score,
                    Questions = a.Exam.Questions.Select(q => new
                    {
                        QuestionHeader = q.Header,
                        CorrectAnswers = q.Answers.Where(ans => ans.IsCorrect).Select(ans => ans.Text).ToList(),
                        StudentAnswers = a.StudentAnswers
                            .Where(sa => sa.QuestionId == q.Id && sa.AnswerId != null)
                            .Select(sa => sa.Answer.Text).ToList()
                    }).ToList()
                })
                .FirstOrDefault();

            if (attempt == null)
            {
                MessageBox.Show("Practice result not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPracticeExamTitle.Text = $"Practice Exam Results - {attempt.ExamTitle}";
            lblScore.Text = $"Total Score: {attempt.Score} / {attempt.TotalMarks}";

            dgvResullt.Rows.Clear();

            
            foreach (var q in attempt.Questions)
            {
                string yourAnswer = q.StudentAnswers.Any() ? string.Join(", ", q.StudentAnswers) : "(No answer)";
                string correctAnswer = string.Join(", ", q.CorrectAnswers);

                bool isCorrect = q.StudentAnswers.OrderBy(x => x).SequenceEqual(q.CorrectAnswers.OrderBy(x => x));

                int rowIndex = dgvResullt.Rows.Add(q.QuestionHeader, yourAnswer, correctAnswer);

                dgvResullt.Rows[rowIndex].DefaultCellStyle.ForeColor = isCorrect ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}
