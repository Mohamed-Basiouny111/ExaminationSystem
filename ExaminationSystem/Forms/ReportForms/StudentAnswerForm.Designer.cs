namespace ExaminationSystem.Forms.ReportForms
{
    partial class StudentAnswerForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnSearch = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvUser = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            StudentId = new DataGridViewTextBoxColumn();
            colExam = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Question = new DataGridViewTextBoxColumn();
            colsAnswer = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnPrev = new Button();
            btnNext = new Button();
            btnRef = new Button();
            btnDSave = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 973F));
            tableLayoutPanel1.Size = new Size(1091, 973);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(dgvUser, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 4);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8121548F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7071819F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 73.3425446F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.Size = new Size(1085, 965);
            tableLayoutPanel4.TabIndex = 56;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.65827F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.34173F));
            tableLayoutPanel5.Controls.Add(btnSearch, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(57, 0);
            tableLayoutPanel5.Margin = new Padding(57, 0, 57, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel5.Size = new Size(971, 133);
            tableLayoutPanel5.TabIndex = 121;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleName = "Search";
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnSearch.FlatAppearance.BorderSize = 10;
            btnSearch.Font = new Font("Cambria", 16F, FontStyle.Bold);
            btnSearch.Image = Properties.Resources.magnifying_glass__1_;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(13, 17);
            btnSearch.Margin = new Padding(11, 17, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(213, 112);
            btnSearch.TabIndex = 57;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(txtSearch, 0, 1);
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(232, 4);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 44.44F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 55.56F));
            tableLayoutPanel6.Size = new Size(736, 129);
            tableLayoutPanel6.TabIndex = 55;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txtSearch.Location = new Point(11, 61);
            txtSearch.Margin = new Padding(11, 4, 11, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(714, 38);
            txtSearch.TabIndex = 2;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AccessibleName = "Employee Name";
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label1.Location = new Point(161, 5);
            label1.Margin = new Padding(3, 5, 3, 4);
            label1.Name = "label1";
            label1.Size = new Size(414, 32);
            label1.TabIndex = 1;
            label1.Text = "Search By Sudent Name Or Exam";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToOrderColumns = true;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.Fixed3D;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 18F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { id, StudentId, colExam, Column4, Question, colsAnswer, Column2 });
            dgvUser.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cambria", 18F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = ".........";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.GridColor = Color.Black;
            dgvUser.Location = new Point(3, 259);
            dgvUser.Margin = new Padding(3, 4, 3, 4);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Cambria", 18F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUser.RowHeadersWidth = 30;
            dgvUser.Size = new Size(1079, 702);
            dgvUser.TabIndex = 120;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            id.DataPropertyName = "Id";
            id.FillWeight = 65.17767F;
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 72;
            // 
            // StudentId
            // 
            StudentId.DataPropertyName = "StudentName";
            StudentId.HeaderText = "Student Name";
            StudentId.MinimumWidth = 6;
            StudentId.Name = "StudentId";
            StudentId.ReadOnly = true;
            StudentId.ToolTipText = "Student Name";
            // 
            // colExam
            // 
            colExam.DataPropertyName = "ExamTitle";
            colExam.HeaderText = "Exam";
            colExam.MinimumWidth = 6;
            colExam.Name = "colExam";
            colExam.ReadOnly = true;
            colExam.ToolTipText = "Exam";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Teacher";
            Column4.HeaderText = "Teacher";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.ToolTipText = "Teacher";
            // 
            // Question
            // 
            Question.DataPropertyName = "Question";
            Question.HeaderText = "Question";
            Question.MinimumWidth = 6;
            Question.Name = "Question";
            Question.ReadOnly = true;
            Question.ToolTipText = "Question";
            // 
            // colsAnswer
            // 
            colsAnswer.DataPropertyName = "StudentAnswer";
            colsAnswer.HeaderText = "Student Answer";
            colsAnswer.MinimumWidth = 6;
            colsAnswer.Name = "colsAnswer";
            colsAnswer.ReadOnly = true;
            colsAnswer.ToolTipText = "Student Answer";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "AnsweredAt";
            Column2.HeaderText = "Answered At";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.ToolTipText = "Answered At";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel7.Controls.Add(btnPrev, 0, 0);
            tableLayoutPanel7.Controls.Add(btnNext, 0, 0);
            tableLayoutPanel7.Controls.Add(btnRef, 2, 0);
            tableLayoutPanel7.Controls.Add(btnDSave, 3, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 133);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1085, 122);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // btnPrev
            // 
            btnPrev.AccessibleName = "Previous";
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrev.BackColor = Color.FromArgb(0, 150, 136);
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnPrev.FlatAppearance.BorderSize = 10;
            btnPrev.Font = new Font("Cambria", 16F, FontStyle.Bold);
            btnPrev.Image = Properties.Resources.fast_forward_double_right_arrows_symbol__3_;
            btnPrev.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrev.Location = new Point(282, 33);
            btnPrev.Margin = new Padding(11, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(199, 85);
            btnPrev.TabIndex = 55;
            btnPrev.Text = "Previous";
            btnPrev.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.AccessibleName = "Next";
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(0, 150, 136);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnNext.FlatAppearance.BorderSize = 10;
            btnNext.Font = new Font("Cambria", 16F, FontStyle.Bold);
            btnNext.Image = Properties.Resources.fast_forward_double_right_arrows_symbol__2___1_1;
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(81, 33);
            btnNext.Margin = new Padding(11, 4, 11, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(179, 85);
            btnNext.TabIndex = 54;
            btnNext.Text = "Next";
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnRef
            // 
            btnRef.AccessibleName = "Refresh";
            btnRef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRef.BackColor = Color.FromArgb(0, 150, 136);
            btnRef.Cursor = Cursors.Hand;
            btnRef.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnRef.FlatAppearance.BorderSize = 10;
            btnRef.Font = new Font("Cambria", 16F, FontStyle.Bold);
            btnRef.Image = Properties.Resources.refresh_page_option__1_1;
            btnRef.ImageAlign = ContentAlignment.MiddleLeft;
            btnRef.Location = new Point(542, 33);
            btnRef.Margin = new Padding(0, 4, 3, 4);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(218, 85);
            btnRef.TabIndex = 56;
            btnRef.Text = "Refresh";
            btnRef.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRef.UseVisualStyleBackColor = false;
            btnRef.Click += btnRef_Click;
            // 
            // btnDSave
            // 
            btnDSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDSave.BackColor = Color.FromArgb(0, 150, 136);
            btnDSave.BackgroundImage = Properties.Resources.download;
            btnDSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnDSave.Cursor = Cursors.Hand;
            btnDSave.FlatAppearance.BorderSize = 0;
            btnDSave.FlatStyle = FlatStyle.Popup;
            btnDSave.Location = new Point(1016, 33);
            btnDSave.Margin = new Padding(11, 4, 3, 4);
            btnDSave.Name = "btnDSave";
            btnDSave.Size = new Size(66, 85);
            btnDSave.TabIndex = 57;
            btnDSave.UseVisualStyleBackColor = false;
            btnDSave.Click += btnDSave_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 973);
            panel1.TabIndex = 7;
            // 
            // StudentAnswerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(1091, 973);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentAnswerForm";
            Text = "Student Answer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvUser;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnPrev;
        private Button btnNext;
        private Button btnRef;
        private Button btnDSave;
        private Panel panel1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn colExam;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn colsAnswer;
        private DataGridViewTextBoxColumn Column2;
    }
}