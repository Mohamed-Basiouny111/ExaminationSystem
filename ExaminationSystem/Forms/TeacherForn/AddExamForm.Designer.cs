namespace ExaminationSystem.Forms.TeacherForn
{
    partial class teacherExam
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
            panel1 = new Panel();
            label4 = new Label();
            txtExamTitle = new TextBox();
            panel2 = new Panel();
            Nquestions = new Label();
            Duration = new Label();
            numDurationMinutes = new NumericUpDown();
            numQuestionCount = new NumericUpDown();
            label6 = new Label();
            cmbSubject = new ComboBox();
            panel3 = new Panel();
            rbFinal = new RadioButton();
            rbPractice = new RadioButton();
            label1 = new Label();
            btnSaveExam = new Button();
            dgvExams = new DataGridView();
            btnDelete = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDurationMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuestionCount).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtExamTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 125);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 38);
            label4.Name = "label4";
            label4.Size = new Size(162, 36);
            label4.TabIndex = 23;
            label4.Text = "Exam Title";
            // 
            // txtExamTitle
            // 
            txtExamTitle.Font = new Font("Cambria", 18F, FontStyle.Bold);
            txtExamTitle.Location = new Point(228, 35);
            txtExamTitle.Multiline = true;
            txtExamTitle.Name = "txtExamTitle";
            txtExamTitle.Size = new Size(259, 62);
            txtExamTitle.TabIndex = 14;
            txtExamTitle.Enter += PerformFocus;
            txtExamTitle.KeyDown += txtExamTitle_KeyDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(Nquestions);
            panel2.Controls.Add(Duration);
            panel2.Controls.Add(numDurationMinutes);
            panel2.Controls.Add(numQuestionCount);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmbSubject);
            panel2.Location = new Point(0, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 204);
            panel2.TabIndex = 0;
            // 
            // Nquestions
            // 
            Nquestions.AutoSize = true;
            Nquestions.BackColor = SystemColors.ControlLightLight;
            Nquestions.Font = new Font("Cambria", 18F, FontStyle.Bold);
            Nquestions.Location = new Point(433, 16);
            Nquestions.Name = "Nquestions";
            Nquestions.Size = new Size(304, 36);
            Nquestions.TabIndex = 26;
            Nquestions.Text = "Number of questions";
            // 
            // Duration
            // 
            Duration.AutoSize = true;
            Duration.BackColor = SystemColors.HighlightText;
            Duration.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Duration.Location = new Point(433, 154);
            Duration.Name = "Duration";
            Duration.Size = new Size(273, 36);
            Duration.TabIndex = 29;
            Duration.Text = "Duration(Minutes)";
            // 
            // numDurationMinutes
            // 
            numDurationMinutes.Location = new Point(787, 25);
            numDurationMinutes.Name = "numDurationMinutes";
            numDurationMinutes.Size = new Size(150, 27);
            numDurationMinutes.TabIndex = 28;
            numDurationMinutes.Enter += PerformFocus;
            numDurationMinutes.KeyDown += numQuestionCount_KeyDown;
            // 
            // numQuestionCount
            // 
            numQuestionCount.Location = new Point(787, 163);
            numQuestionCount.Name = "numQuestionCount";
            numQuestionCount.Size = new Size(150, 27);
            numQuestionCount.TabIndex = 27;
            numQuestionCount.Enter += PerformFocus;
            numQuestionCount.KeyDown += numDurationMinutes_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HighlightText;
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label6.Location = new Point(24, 25);
            label6.Name = "label6";
            label6.Size = new Size(202, 36);
            label6.TabIndex = 25;
            label6.Text = "Subject Name";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FlatStyle = FlatStyle.Popup;
            cmbSubject.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "JS", "OOP", "C#" });
            cmbSubject.Location = new Point(24, 61);
            cmbSubject.MaxDropDownItems = 10;
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(368, 30);
            cmbSubject.TabIndex = 24;
            cmbSubject.KeyDown += cmbSubject_KeyDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbFinal);
            panel3.Controls.Add(rbPractice);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 341);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 110);
            panel3.TabIndex = 1;
            // 
            // rbFinal
            // 
            rbFinal.AutoSize = true;
            rbFinal.BackColor = Color.White;
            rbFinal.Font = new Font("Cambria", 18F, FontStyle.Bold);
            rbFinal.Location = new Point(542, 35);
            rbFinal.Name = "rbFinal";
            rbFinal.Size = new Size(188, 40);
            rbFinal.TabIndex = 26;
            rbFinal.TabStop = true;
            rbFinal.Text = "Final Exam";
            rbFinal.UseVisualStyleBackColor = false;
            // 
            // rbPractice
            // 
            rbPractice.AutoSize = true;
            rbPractice.BackColor = Color.White;
            rbPractice.Font = new Font("Cambria", 18F, FontStyle.Bold);
            rbPractice.Location = new Point(257, 35);
            rbPractice.Name = "rbPractice";
            rbPractice.Size = new Size(230, 40);
            rbPractice.TabIndex = 25;
            rbPractice.TabStop = true;
            rbPractice.Text = "Practice Exam";
            rbPractice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 24;
            label1.Text = "Exam Type";
            // 
            // btnSaveExam
            // 
            btnSaveExam.BackColor = Color.FromArgb(0, 150, 136);
            btnSaveExam.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnSaveExam.Location = new Point(85, 507);
            btnSaveExam.Name = "btnSaveExam";
            btnSaveExam.Size = new Size(208, 79);
            btnSaveExam.TabIndex = 2;
            btnSaveExam.Text = "Save";
            btnSaveExam.UseVisualStyleBackColor = false;
            btnSaveExam.Click += btnSaveExam_Click;
            // 
            // dgvExams
            // 
            dgvExams.BackgroundColor = SystemColors.ControlLightLight;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(1011, 35);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 51;
            dgvExams.Size = new Size(651, 544);
            dgvExams.TabIndex = 3;
            dgvExams.DoubleClick += dgvExams_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 150, 136);
            btnDelete.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnDelete.Location = new Point(572, 507);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 79);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 150, 136);
            btnCancel.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnCancel.Location = new Point(323, 507);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(208, 79);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // teacherExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(1734, 896);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(dgvExams);
            Controls.Add(btnSaveExam);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "teacherExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExamForm";
            Load += teacherExam_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDurationMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuestionCount).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtExamTitle;
        private Label label4;
        private Label label6;
        public ComboBox cmbSubject;
        private Label Nquestions;
        private Label Duration;
        private NumericUpDown numDurationMinutes;
        private NumericUpDown numQuestionCount;
        private Panel panel3;
        private Label label1;
        private RadioButton rbFinal;
        private RadioButton rbPractice;
        private Button btnSaveExam;
        private DataGridView dgvExams;
        private Button btnDelete;
        private Button btnCancel;
    }
}