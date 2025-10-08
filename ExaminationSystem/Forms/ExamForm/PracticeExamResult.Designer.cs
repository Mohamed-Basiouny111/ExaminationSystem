namespace ExaminationSystem.Forms.ExamForm
{
    partial class PracticeExamResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPracticeExamTitle = new Label();
            dgvResullt = new DataGridView();
            Question = new DataGridViewTextBoxColumn();
            StdAnswer = new DataGridViewTextBoxColumn();
            CorrectAnswer = new DataGridViewTextBoxColumn();
            lblScore = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResullt).BeginInit();
            SuspendLayout();
            // 
            // lblPracticeExamTitle
            // 
            lblPracticeExamTitle.AutoSize = true;
            lblPracticeExamTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPracticeExamTitle.Location = new Point(308, 24);
            lblPracticeExamTitle.Name = "lblPracticeExamTitle";
            lblPracticeExamTitle.Size = new Size(261, 32);
            lblPracticeExamTitle.TabIndex = 1;
            lblPracticeExamTitle.Text = "Practice Exam Results";
            // 
            // dgvResullt
            // 
            dgvResullt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResullt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResullt.Columns.AddRange(new DataGridViewColumn[] { Question, StdAnswer, CorrectAnswer });
            dgvResullt.Location = new Point(21, 86);
            dgvResullt.Name = "dgvResullt";
            dgvResullt.RowHeadersWidth = 51;
            dgvResullt.Size = new Size(767, 249);
            dgvResullt.TabIndex = 2;
            dgvResullt.CellContentClick += dgvResullt_CellContentClick;
            // 
            // Question
            // 
            Question.HeaderText = "Question";
            Question.MinimumWidth = 6;
            Question.Name = "Question";
            // 
            // StdAnswer
            // 
            StdAnswer.HeaderText = "Student Answer";
            StdAnswer.MinimumWidth = 6;
            StdAnswer.Name = "StdAnswer";
            // 
            // CorrectAnswer
            // 
            CorrectAnswer.HeaderText = "Correct Answer";
            CorrectAnswer.MinimumWidth = 6;
            CorrectAnswer.Name = "CorrectAnswer";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblScore.Location = new Point(48, 380);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(151, 32);
            lblScore.TabIndex = 3;
            lblScore.Text = "Total Scores";
            // 
            // PracticeExamResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblScore);
            Controls.Add(dgvResullt);
            Controls.Add(lblPracticeExamTitle);
            Name = "PracticeExamResult";
            Text = "PracticeExamResult";
            Load += PracticeExamResult_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResullt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPracticeExamTitle;
        private DataGridView dgvResullt;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn StdAnswer;
        private DataGridViewTextBoxColumn CorrectAnswer;
        private Label lblScore;
    }
}