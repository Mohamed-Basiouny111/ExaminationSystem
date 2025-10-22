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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnOpenStatusForm = new Button();
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
            panel1.Size = new Size(531, 125);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 37);
            label4.Name = "label4";
            label4.Size = new Size(162, 36);
            label4.TabIndex = 23;
            label4.Text = "Exam Title";
            // 
            // txtExamTitle
            // 
            txtExamTitle.Font = new Font("Cambria", 18F, FontStyle.Bold);
            txtExamTitle.Location = new Point(229, 35);
            txtExamTitle.Multiline = true;
            txtExamTitle.Name = "txtExamTitle";
            txtExamTitle.Size = new Size(259, 63);
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
            panel2.Location = new Point(86, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(957, 125);
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
            Duration.Location = new Point(433, 77);
            Duration.Name = "Duration";
            Duration.Size = new Size(273, 36);
            Duration.TabIndex = 29;
            Duration.Text = "Duration(Minutes)";
            // 
            // numDurationMinutes
            // 
            numDurationMinutes.Font = new Font("Cambria", 16F, FontStyle.Bold);
            numDurationMinutes.Location = new Point(757, 13);
            numDurationMinutes.Name = "numDurationMinutes";
            numDurationMinutes.Size = new Size(151, 39);
            numDurationMinutes.TabIndex = 28;
            numDurationMinutes.Enter += PerformFocus;
            numDurationMinutes.KeyDown += numQuestionCount_KeyDown;
            // 
            // numQuestionCount
            // 
            numQuestionCount.Font = new Font("Cambria", 16F, FontStyle.Bold);
            numQuestionCount.Location = new Point(757, 74);
            numQuestionCount.Name = "numQuestionCount";
            numQuestionCount.Size = new Size(151, 39);
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
            cmbSubject.Font = new Font("Cambria", 16F, FontStyle.Bold);
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "JS", "OOP", "C#" });
            cmbSubject.Location = new Point(24, 61);
            cmbSubject.MaxDropDownItems = 10;
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(367, 40);
            cmbSubject.TabIndex = 24;
            cmbSubject.KeyDown += cmbSubject_KeyDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbFinal);
            panel3.Controls.Add(rbPractice);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(537, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(758, 109);
            panel3.TabIndex = 1;
            // 
            // rbFinal
            // 
            rbFinal.AutoSize = true;
            rbFinal.BackColor = Color.White;
            rbFinal.Font = new Font("Cambria", 18F, FontStyle.Bold);
            rbFinal.Location = new Point(467, 31);
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
            rbPractice.Location = new Point(209, 31);
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
            btnSaveExam.Location = new Point(110, 273);
            btnSaveExam.Name = "btnSaveExam";
            btnSaveExam.Size = new Size(208, 79);
            btnSaveExam.TabIndex = 2;
            btnSaveExam.Text = "Save";
            btnSaveExam.UseVisualStyleBackColor = false;
            btnSaveExam.Click += btnSaveExam_Click;
            // 
            // dgvExams
            // 
            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dgvExams.AllowUserToOrderColumns = true;
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExams.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExams.BackgroundColor = Color.White;
            dgvExams.BorderStyle = BorderStyle.Fixed3D;
            dgvExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExams.GridColor = Color.Black;
            dgvExams.Location = new Point(86, 372);
            dgvExams.Margin = new Padding(3, 4, 3, 4);
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dgvExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvExams.RowHeadersWidth = 30;
            dgvExams.Size = new Size(985, 473);
            dgvExams.TabIndex = 120;
            dgvExams.DoubleClick += dgvExams_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 150, 136);
            btnDelete.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnDelete.Location = new Point(538, 273);
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
            btnCancel.Location = new Point(325, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(208, 79);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOpenStatusForm
            // 
            btnOpenStatusForm.BackColor = Color.FromArgb(0, 150, 136);
            btnOpenStatusForm.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnOpenStatusForm.Location = new Point(761, 273);
            btnOpenStatusForm.Name = "btnOpenStatusForm";
            btnOpenStatusForm.Size = new Size(215, 79);
            btnOpenStatusForm.TabIndex = 121;
            btnOpenStatusForm.Text = "Change Mode";
            btnOpenStatusForm.UseVisualStyleBackColor = false;
            btnOpenStatusForm.Click += btnOpenStatusForm_Click;
            // 
            // teacherExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(1310, 896);
            Controls.Add(btnOpenStatusForm);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(dgvExams);
            Controls.Add(btnSaveExam);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "teacherExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Exam";
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
        private Button btnOpenStatusForm;
    }
}