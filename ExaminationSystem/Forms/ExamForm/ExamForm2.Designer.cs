namespace ExaminationSystem.Forms.ExamForm
{
    partial class ExamForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQuestionHeader;
        private System.Windows.Forms.Label lblQuestionBody;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblExamTitle = new Label();
            lblTotalQuestions = new Label();
            lblCurrentQuestion = new Label();
            lblTimer = new Label();
            pnlAnswers = new Panel();
            btnNext = new Button();
            btnPrevious = new Button();
            btnSubmit = new Button();
            lblQuestionHeader = new Label();
            lblQuestionBody = new Label();
            SuspendLayout();
            // 
            // lblExamTitle
            // 
            lblExamTitle.AutoSize = true;
            lblExamTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblExamTitle.Location = new Point(20, 10);
            lblExamTitle.Name = "lblExamTitle";
            lblExamTitle.Size = new Size(132, 32);
            lblExamTitle.TabIndex = 0;
            lblExamTitle.Text = "Exam Title";
            // 
            // lblTotalQuestions
            // 
            lblTotalQuestions.AutoSize = true;
            lblTotalQuestions.Location = new Point(300, 45);
            lblTotalQuestions.Name = "lblTotalQuestions";
            lblTotalQuestions.Size = new Size(126, 20);
            lblTotalQuestions.TabIndex = 2;
            lblTotalQuestions.Text = "Total Questions: 0";
            // 
            // lblCurrentQuestion
            // 
            lblCurrentQuestion.AutoSize = true;
            lblCurrentQuestion.Location = new Point(450, 45);
            lblCurrentQuestion.Name = "lblCurrentQuestion";
            lblCurrentQuestion.Size = new Size(113, 20);
            lblCurrentQuestion.TabIndex = 3;
            lblCurrentQuestion.Text = "Question 1 of N";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimer.Location = new Point(650, 10);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(80, 23);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "00:00:00";
            // 
            // pnlAnswers
            // 
            pnlAnswers.BorderStyle = BorderStyle.FixedSingle;
            pnlAnswers.Location = new Point(20, 150);
            pnlAnswers.Name = "pnlAnswers";
            pnlAnswers.Size = new Size(740, 320);
            pnlAnswers.TabIndex = 7;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(160, 485);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(120, 35);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(20, 485);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(120, 35);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(640, 485);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 35);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit Exam";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblQuestionHeader
            // 
            lblQuestionHeader.AutoSize = true;
            lblQuestionHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuestionHeader.Location = new Point(20, 80);
            lblQuestionHeader.Name = "lblQuestionHeader";
            lblQuestionHeader.Size = new Size(168, 28);
            lblQuestionHeader.TabIndex = 5;
            lblQuestionHeader.Text = "Question header";
            // 
            // lblQuestionBody
            // 
            lblQuestionBody.AutoSize = true;
            lblQuestionBody.Location = new Point(20, 110);
            lblQuestionBody.MaximumSize = new Size(740, 0);
            lblQuestionBody.Name = "lblQuestionBody";
            lblQuestionBody.Size = new Size(106, 20);
            lblQuestionBody.TabIndex = 6;
            lblQuestionBody.Text = "Question body";
            // 
            // ExamForm2
            // 
            ClientSize = new Size(993, 541);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(pnlAnswers);
            Controls.Add(lblQuestionBody);
            Controls.Add(lblQuestionHeader);
            Controls.Add(lblTimer);
            Controls.Add(lblCurrentQuestion);
            Controls.Add(lblTotalQuestions);
            Controls.Add(lblExamTitle);
            Name = "ExamForm2";
            Text = "Take Exam";
            Load += ExamForm2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
