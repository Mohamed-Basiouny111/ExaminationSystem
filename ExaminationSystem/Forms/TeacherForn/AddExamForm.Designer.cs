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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDurationMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuestionCount).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtExamTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1596, 125);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 38);
            label4.Name = "label4";
            label4.Size = new Size(189, 42);
            label4.TabIndex = 23;
            label4.Text = "Exam Title";
            // 
            // txtExamTitle
            // 
            txtExamTitle.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExamTitle.Location = new Point(322, 12);
            txtExamTitle.Multiline = true;
            txtExamTitle.Name = "txtExamTitle";
            txtExamTitle.Size = new Size(1135, 107);
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
            panel2.Size = new Size(1596, 262);
            panel2.TabIndex = 0;
            // 
            // Nquestions
            // 
            Nquestions.AutoSize = true;
            Nquestions.BackColor = SystemColors.ControlLightLight;
            Nquestions.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nquestions.Location = new Point(634, 73);
            Nquestions.Name = "Nquestions";
            Nquestions.Size = new Size(343, 42);
            Nquestions.TabIndex = 26;
            Nquestions.Text = "Number of questions";
            // 
            // Duration
            // 
            Duration.AutoSize = true;
            Duration.BackColor = SystemColors.HighlightText;
            Duration.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Duration.Location = new Point(1040, 73);
            Duration.Name = "Duration";
            Duration.Size = new Size(316, 42);
            Duration.TabIndex = 29;
            Duration.Text = "Duration(Minutes)";
            // 
            // numDurationMinutes
            // 
            numDurationMinutes.Location = new Point(743, 198);
            numDurationMinutes.Name = "numDurationMinutes";
            numDurationMinutes.Size = new Size(150, 27);
            numDurationMinutes.TabIndex = 28;
            numDurationMinutes.Enter += PerformFocus;
            numDurationMinutes.KeyDown += numQuestionCount_KeyDown;
            // 
            // numQuestionCount
            // 
            numQuestionCount.Location = new Point(1114, 198);
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
            label6.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(67, 73);
            label6.Name = "label6";
            label6.Size = new Size(237, 42);
            label6.TabIndex = 25;
            label6.Text = "Subject Name";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSubject
            // 
            cmbSubject.DrawMode = DrawMode.OwnerDrawVariable;
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FlatStyle = FlatStyle.Popup;
            cmbSubject.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "JS", "OOP", "C#" });
            cmbSubject.Location = new Point(67, 118);
            cmbSubject.MaxDropDownItems = 10;
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(368, 51);
            cmbSubject.TabIndex = 24;
            cmbSubject.KeyDown += cmbSubject_KeyDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbFinal);
            panel3.Controls.Add(rbPractice);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 399);
            panel3.Name = "panel3";
            panel3.Size = new Size(1596, 125);
            panel3.TabIndex = 1;
            // 
            // rbFinal
            // 
            rbFinal.AutoSize = true;
            rbFinal.BackColor = Color.White;
            rbFinal.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFinal.Location = new Point(727, 46);
            rbFinal.Name = "rbFinal";
            rbFinal.Size = new Size(207, 42);
            rbFinal.TabIndex = 26;
            rbFinal.TabStop = true;
            rbFinal.Text = "Final Exam";
            rbFinal.UseVisualStyleBackColor = false;
            // 
            // rbPractice
            // 
            rbPractice.AutoSize = true;
            rbPractice.BackColor = Color.White;
            rbPractice.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPractice.Location = new Point(351, 46);
            rbPractice.Name = "rbPractice";
            rbPractice.Size = new Size(250, 42);
            rbPractice.TabIndex = 25;
            rbPractice.TabStop = true;
            rbPractice.Text = "Practice Exam";
            rbPractice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 45);
            label1.Name = "label1";
            label1.Size = new Size(194, 42);
            label1.TabIndex = 24;
            label1.Text = "Exam Type";
            // 
            // btnSaveExam
            // 
            btnSaveExam.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveExam.Location = new Point(583, 548);
            btnSaveExam.Name = "btnSaveExam";
            btnSaveExam.Size = new Size(259, 96);
            btnSaveExam.TabIndex = 2;
            btnSaveExam.Text = "Save Exam";
            btnSaveExam.UseVisualStyleBackColor = true;
            btnSaveExam.Click += btnSaveExam_Click;
            // 
            // teacherExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(1596, 896);
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
    }
}