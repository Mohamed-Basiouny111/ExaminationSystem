namespace ExaminationSystem.Forms.ReportForms
{
    partial class ExamAttemptForm
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
            btnNext = new Button();
            btnRef = new Button();
            btnDSave = new Button();
            dgvUser = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            StudentId = new DataGridViewTextBoxColumn();
            colExam = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ExamType = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnPrev = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnSearch = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtSearch = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            btnNext.Location = new Point(67, 25);
            btnNext.Margin = new Padding(10, 3, 10, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(176, 64);
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
            btnRef.Location = new Point(506, 25);
            btnRef.Margin = new Padding(0, 3, 3, 3);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(210, 64);
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
            btnDSave.Location = new Point(952, 25);
            btnDSave.Margin = new Padding(10, 3, 3, 3);
            btnDSave.Name = "btnDSave";
            btnDSave.Size = new Size(58, 64);
            btnDSave.TabIndex = 57;
            btnDSave.UseVisualStyleBackColor = false;
            btnDSave.Click += btnDSave_Click;
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
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { id, StudentId, colExam, Column4, ExamType, Column1, Column2, Column3 });
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
            dgvUser.Location = new Point(3, 195);
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
            dgvUser.Size = new Size(1007, 526);
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
            id.Width = 59;
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
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.ToolTipText = "Teacher";
            // 
            // ExamType
            // 
            ExamType.DataPropertyName = "ExamType";
            ExamType.HeaderText = "Exam Type";
            ExamType.MinimumWidth = 6;
            ExamType.Name = "ExamType";
            ExamType.ReadOnly = true;
            ExamType.ToolTipText = "ExamType";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Score";
            Column1.HeaderText = "Student Score";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.ToolTipText = "Student Score";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "StartedAt";
            Column2.HeaderText = "StartedAt";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.ToolTipText = "StartedAt";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "FinishedAt";
            Column3.HeaderText = "FinishedAt";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.ToolTipText = "FinishedAt";
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
            btnPrev.Location = new Point(263, 25);
            btnPrev.Margin = new Padding(10, 3, 3, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(193, 64);
            btnPrev.TabIndex = 55;
            btnPrev.Text = "Previous";
            btnPrev.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(btnPrev, 0, 0);
            tableLayoutPanel7.Controls.Add(btnNext, 0, 0);
            tableLayoutPanel7.Controls.Add(btnRef, 2, 0);
            tableLayoutPanel7.Controls.Add(btnDSave, 3, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 100);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1013, 92);
            tableLayoutPanel7.TabIndex = 2;
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
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8121548F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7071819F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 73.3425446F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel4.Size = new Size(1013, 724);
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
            tableLayoutPanel5.Location = new Point(50, 0);
            tableLayoutPanel5.Margin = new Padding(50, 0, 50, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel5.Size = new Size(913, 100);
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
            btnSearch.Location = new Point(23, 13);
            btnSearch.Margin = new Padding(10, 13, 3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(190, 84);
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
            tableLayoutPanel6.Location = new Point(219, 3);
            tableLayoutPanel6.Margin = new Padding(3, 3, 3, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 44.44F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 55.56F));
            tableLayoutPanel6.Size = new Size(691, 97);
            tableLayoutPanel6.TabIndex = 55;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txtSearch.Location = new Point(10, 46);
            txtSearch.Margin = new Padding(10, 3, 10, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(671, 32);
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
            label1.Location = new Point(180, 4);
            label1.Margin = new Padding(3, 4, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(330, 25);
            label1.TabIndex = 1;
            label1.Text = "Search By Sudent Name Or Exam";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 730);
            panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1019, 730);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ExamAttemptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(1019, 730);
            Controls.Add(panel1);
            Name = "ExamAttemptForm";
            Text = "Exam Attempt Report";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvUser;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnPrev;
        private Button btnNext;
        private Button btnRef;
        private Button btnDSave;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtSearch;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn colExam;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn ExamType;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}