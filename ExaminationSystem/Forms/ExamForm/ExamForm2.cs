using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ExaminationSystem.Data;
using ExaminationSystem.Models;

namespace ExaminationSystem.Forms.ExamForm
{
    public partial class ExamForm2 : Form
    {
        private readonly int _studentId;
        private readonly int _examId;
        private ExaminationSystemContext db = new ExaminationSystemContext();

        private Exam _exam;
        private List<Question> _questions = new List<Question>();
        private int _currentIndex = 0;
        private ExamAttempt _currentAttempt;

        private System.Windows.Forms.Timer _timer;
        private int _remainingSeconds;

        public ExamForm2(int studentId, int examId)
        {
            InitializeComponent();
            _studentId = studentId;
            _examId = examId;
        }

        private void ExamForm2_Load(object sender, EventArgs e)
        {
            LoadExamAndQuestions();
            CreateExamAttempt();
            DisplayQuestion();
            StartTimer();
        }

        private void LoadExamAndQuestions()
        {
           _exam = db.Exams
                .Where(e => e.Id == _examId)
                .Select(e => new Exam
                {
                    Id = e.Id,
                    Title = e.Title,
                    NumberOfQuestions = e.NumberOfQuestions,
                    Duration = e.Duration,
                    Mode = e.Mode,
                    SubjectId = e.SubjectId,
                    Questions = e.Questions.OrderBy(q => q.Id).Select(q => new Question
                    {
                        Id = q.Id,
                        Header = q.Header,
                        Body = q.Body,
                        Marks = q.Marks,
                        Answers = q.Answers.Select(a => new Answer
                        {
                            Id = a.Id,
                            Text = a.Text,
                            IsCorrect = a.IsCorrect,
                            QuestionId = a.QuestionId
                        }).ToList()
                    }).ToList()
                })
                .FirstOrDefault();

            if (_exam == null)
            {
                MessageBox.Show("Exam not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _questions = _exam.Questions ?? new List<Question>();

          
            lblExamTitle.Text = _exam.Title;
            lblTotalQuestions.Text = $"Total Questions: {_questions.Count}";
            lblCurrentQuestion.Text = $"Question {1} of {_questions.Count}";

            //Removed Student Name

            //var student = db.Users.FirstOrDefault(u => u.Id == _studentId);
            //lblStudentName.Text = student?.FullName ?? "Unknown Student";
        }

        private void CreateExamAttempt()
        {
            _currentAttempt = new ExamAttempt
            {
                ExamId = _exam.Id,
                StudentId = _studentId,
                StartedAt = DateTime.Now,
                Score = 0
            };

            db.ExamAttempts.Add(_currentAttempt);
            db.SaveChanges(); 
        }

        private void DisplayQuestion()
        {
            pnlAnswers.Controls.Clear();

            if (_questions == null || _questions.Count == 0)
            {
                lblQuestionHeader.Text = "No questions available.";
                lblQuestionBody.Text = "";
                return;
            }

            var q = _questions[_currentIndex];
            lblQuestionHeader.Text = q.Header;
            lblQuestionBody.Text = q.Body;
            lblCurrentQuestion.Text = $"Question {_currentIndex + 1} of {_questions.Count}";

            var existingAnswers = db.StudentAnswers
                .Where(sa => sa.ExamAttemptId == _currentAttempt.Id && sa.QuestionId == q.Id)
                .Select(sa => sa.AnswerId)
                .ToList();

            int top = 10;
            string qType = q.GetType().Name;

          
            if (qType.Contains("ChooseOne"))
            {
                foreach (var ans in q.Answers)
                {
                    RadioButton rb = new RadioButton
                    {
                        Text = ans.Text,
                        Tag = ans.Id,
                        AutoSize = true,
                        Top = top,
                        Left = 10
                    };
                    if (existingAnswers.Contains(ans.Id)) rb.Checked = true;
                    pnlAnswers.Controls.Add(rb);
                    top += 30;
                }
            }
            else if (qType.Contains("ChooseAll"))
            {
                foreach (var ans in q.Answers)
                {
                    CheckBox cb = new CheckBox
                    {
                        Text = ans.Text,
                        Tag = ans.Id,
                        AutoSize = true,
                        Top = top,
                        Left = 10
                    };
                    if (existingAnswers.Contains(ans.Id)) cb.Checked = true;
                    pnlAnswers.Controls.Add(cb);
                    top += 30;
                }
            }
            else if (qType.Contains("TrueFalse"))
            {
                foreach (var ans in q.Answers)
                {
                    RadioButton rb = new RadioButton
                    {
                        Text = ans.Text,
                        Tag = ans.Id,
                        AutoSize = true,
                        Top = top,
                        Left = 10
                    };
                    if (existingAnswers.Contains(ans.Id)) rb.Checked = true;
                    pnlAnswers.Controls.Add(rb);
                    top += 30;
                }

                if (q.Answers == null || q.Answers.Count == 0)
                {
                    RadioButton rTrue = new RadioButton { Text = "True", AutoSize = true, Top = top, Left = 10 };
                    top += 30;
                    RadioButton rFalse = new RadioButton { Text = "False", AutoSize = true, Top = top, Left = 10 };
                    pnlAnswers.Controls.Add(rTrue);
                    pnlAnswers.Controls.Add(rFalse);
                }
            }
            else
            {
                foreach (var ans in q.Answers)
                {
                    RadioButton rb = new RadioButton
                    {
                        Text = ans.Text,
                        Tag = ans.Id,
                        AutoSize = true,
                        Top = top,
                        Left = 10
                    };
                    if (existingAnswers.Contains(ans.Id)) rb.Checked = true;
                    pnlAnswers.Controls.Add(rb);
                    top += 30;
                }
            }

            btnPrevious.Enabled = _currentIndex > 0;
            btnNext.Enabled = _currentIndex < _questions.Count - 1;
        }

        private void SaveCurrentSelection()
        {
            if (_questions == null || !_questions.Any()) return;

            var q = _questions[_currentIndex];
            List<int> selectedAnswerIds = new List<int>();

            foreach (Control c in pnlAnswers.Controls)
            {
                if (c is RadioButton rb && rb.Checked && rb.Tag is int aid)
                    selectedAnswerIds.Add(aid);
                else if (c is CheckBox cb && cb.Checked && cb.Tag is int aid2)
                    selectedAnswerIds.Add(aid2);
            }

            var existing = db.StudentAnswers
                .Where(sa => sa.ExamAttemptId == _currentAttempt.Id && sa.QuestionId == q.Id)
                .ToList();

            if (existing.Any())
            {
                db.StudentAnswers.RemoveRange(existing);
                db.SaveChanges();
            }

            foreach (var aid in selectedAnswerIds)
            {
                var sa = new StudentAnswer
                {
                    ExamAttemptId = _currentAttempt.Id,
                    QuestionId = q.Id,
                    AnswerId = aid,
                    AnsweredAt = DateTime.Now
                };
                db.StudentAnswers.Add(sa);
            }

            db.SaveChanges();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            if (_currentIndex < _questions.Count - 1)
            {
                _currentIndex++;
                DisplayQuestion();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            if (_currentIndex > 0)
            {
                _currentIndex--;
                DisplayQuestion();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            _timer?.Stop();

            CalculateScoreAndFinish();

            var totalMarks = _questions.Sum(q => q.Marks);
            var message = $"Exam submitted successfully.\nScore: {_currentAttempt.Score} / {totalMarks}";
            MessageBox.Show(message, "Exam Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            if (_exam is PracticeExam)
            {
                ShowCorrectAnswersDetails();
            }

            this.Close();
        }

        private void CalculateScoreAndFinish()
        {
            double totalScore = 0;

            foreach (var q in _questions)
            {
                var correctIds = q.Answers.Where(a => a.IsCorrect).Select(a => a.Id).OrderBy(x => x).ToList();
                var studentIds = db.StudentAnswers
                    .Where(sa => sa.ExamAttemptId == _currentAttempt.Id && sa.QuestionId == q.Id && sa.AnswerId != null)
                    .Select(sa => sa.AnswerId.Value)
                    .OrderBy(x => x)
                    .ToList();

                bool equal = correctIds.SequenceEqual(studentIds);
                if (equal)
                    totalScore += q.Marks;
            }

            _currentAttempt.Score = totalScore;
            _currentAttempt.FinishedAt = DateTime.Now;

            db.ExamAttempts.Update(_currentAttempt);
            db.SaveChanges();
        }

        private void ShowCorrectAnswersDetails()
        {
            var sb = new System.Text.StringBuilder();

            foreach (var q in _questions)
            {
                sb.AppendLine($"Q: {q.Header}");
                var correct = q.Answers.Where(a => a.IsCorrect).Select(a => a.Text).ToList();
                sb.AppendLine("Correct: " + string.Join(", ", correct));

                var studentAns = db.StudentAnswers
                    .Where(sa => sa.ExamAttemptId == _currentAttempt.Id && sa.QuestionId == q.Id && sa.AnswerId != null)
                    .Select(sa => sa.Answer.Text)
                    .ToList();

                sb.AppendLine("Your Answer: " + (studentAns.Any() ? string.Join(", ", studentAns) : "(no answer)"));
                sb.AppendLine(new string('-', 30));
            }

            var detailsForm = new Form
            {
                Text = "Practice - Correct Answers",
                Width = 600,
                Height = 600,
                StartPosition = FormStartPosition.CenterParent
            };
            var txt = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Both,
                Text = sb.ToString()
            };
            detailsForm.Controls.Add(txt);
            detailsForm.ShowDialog();
        }

        private void StartTimer()
        {
            _remainingSeconds = (int)_exam.Duration.TotalSeconds;
            lblTimer.Text = TimeSpan.FromSeconds(_remainingSeconds).ToString(@"hh\:mm\:ss");

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += (s, ev) =>
            {
                _remainingSeconds--;
                lblTimer.Text = TimeSpan.FromSeconds(_remainingSeconds).ToString(@"hh\:mm\:ss");
                if (_remainingSeconds <= 0)
                {
                    _timer.Stop();
                    MessageBox.Show("Time is up. Your exam will be submitted automatically.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveCurrentSelection();
                    CalculateScoreAndFinish();

                    if (_exam is PracticeExam)
                    {
                        ShowCorrectAnswersDetails();
                    }

                    this.Close();
                }
            };
            _timer.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _timer?.Stop();
            db?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
