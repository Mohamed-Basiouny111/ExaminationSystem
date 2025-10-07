namespace ExaminationSystem.Forms.Subject
{
    partial class SubjectForm
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
            btnSave = new Button();
            btnNext = new Button();
            btnRef = new Button();
            btnDSave = new Button();
            dgvUser = new DataGridView();
            Delete = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            btnPrev = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            SubName = new Label();
            txtSubjectName = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.AccessibleName = "Add Employee";
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            tableLayoutPanel1.SetColumnSpan(btnSave, 2);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnSave.FlatAppearance.BorderSize = 10;
            btnSave.Font = new Font("Cambria", 16F, FontStyle.Bold);
            btnSave.Image = Properties.Resources.add_user__1___1_;
            btnSave.Location = new Point(307, 101);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(265, 56);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnNext.Location = new Point(17, 5);
            btnNext.Margin = new Padding(17, 5, 17, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(183, 52);
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
            btnRef.Location = new Point(434, 5);
            btnRef.Margin = new Padding(0, 5, 5, 5);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(202, 52);
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
            btnDSave.Location = new Point(810, 5);
            btnDSave.Margin = new Padding(17, 5, 5, 5);
            btnDSave.Name = "btnDSave";
            btnDSave.Size = new Size(54, 52);
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
            dataGridViewCellStyle1.Font = new Font("Cambria", 16F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Delete, Edit, id, FullName });
            dgvUser.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cambria", 16F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = ".........";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.GridColor = Color.Black;
            dgvUser.Location = new Point(5, 151);
            dgvUser.Margin = new Padding(5);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUser.RowHeadersWidth = 30;
            dgvUser.Size = new Size(859, 165);
            dgvUser.TabIndex = 120;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Delete.Frozen = true;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete__5_;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            Delete.ToolTipText = "Delete This Product";
            Delete.Width = 85;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.edit__2_1;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            Edit.Width = 59;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.FillWeight = 65.17767F;
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "Name";
            FullName.HeaderText = "Subject Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.ToolTipText = "Subject Name";
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
            btnPrev.Location = new Point(234, 5);
            btnPrev.Margin = new Padding(17, 5, 5, 5);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(195, 52);
            btnPrev.TabIndex = 55;
            btnPrev.Text = "Previous";
            btnPrev.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txtSearch.Location = new Point(17, 40);
            txtSearch.Margin = new Padding(17, 5, 17, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(465, 32);
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
            label1.Location = new Point(127, 7);
            label1.Margin = new Padding(5, 7, 5, 5);
            label1.Name = "label1";
            label1.Size = new Size(244, 23);
            label1.TabIndex = 1;
            label1.Text = "Search By Subject Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleName = "Search";
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnSearch.FlatAppearance.BorderSize = 10;
            btnSearch.Font = new Font("Cambria", 16F, FontStyle.Bold);
            btnSearch.Image = Properties.Resources.magnifying_glass__1_;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(526, 22);
            btnSearch.Margin = new Padding(17, 22, 5, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 57);
            btnSearch.TabIndex = 56;
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
            tableLayoutPanel6.Location = new Point(5, 5);
            tableLayoutPanel6.Margin = new Padding(5, 5, 5, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 44.44F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 55.56F));
            tableLayoutPanel6.Size = new Size(499, 79);
            tableLayoutPanel6.TabIndex = 55;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.02752F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.97248F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(btnSearch, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(86, 0);
            tableLayoutPanel5.Margin = new Padding(86, 0, 86, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 122F));
            tableLayoutPanel5.Size = new Size(697, 84);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel7.Controls.Add(btnNext, 0, 0);
            tableLayoutPanel7.Controls.Add(btnRef, 2, 0);
            tableLayoutPanel7.Controls.Add(btnDSave, 3, 0);
            tableLayoutPanel7.Controls.Add(btnPrev, 1, 0);
            tableLayoutPanel7.Location = new Point(0, 84);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(869, 62);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvUser, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(5, 168);
            tableLayoutPanel4.Margin = new Padding(5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 26.2390671F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6261673F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 54.20561F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel4.Size = new Size(869, 321);
            tableLayoutPanel4.TabIndex = 56;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4331989F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5627527F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.00405F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(879, 494);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.Controls.Add(SubName, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSubjectName, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 5);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5116272F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4883728F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new Size(869, 86);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // SubName
            // 
            SubName.AccessibleName = "Employee Name";
            SubName.Anchor = AnchorStyles.Top;
            SubName.AutoSize = true;
            SubName.BackColor = Color.Transparent;
            SubName.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            SubName.Location = new Point(363, 7);
            SubName.Margin = new Padding(5, 7, 5, 5);
            SubName.Name = "SubName";
            SubName.Size = new Size(143, 25);
            SubName.TabIndex = 1;
            SubName.Text = "Subject Name";
            SubName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSubjectName.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            txtSubjectName.Location = new Point(60, 45);
            txtSubjectName.Margin = new Padding(60, 5, 60, 5);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(749, 32);
            txtSubjectName.TabIndex = 12;
            txtSubjectName.TextAlign = HorizontalAlignment.Center;
            txtSubjectName.TextChanged += txtFullName_TextChanged;
            txtSubjectName.KeyDown += txtSubjectName_KeyDown;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 494);
            panel1.TabIndex = 6;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(879, 494);
            Controls.Add(panel1);
            Font = new Font("Cambria", 16F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "SubjectForm";
            Text = "Subject";
            Load += SubjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvUser;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtSearch;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnPrev;
        private Button btnNext;
        private Button btnRef;
        private Button btnDSave;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtSubjectName;
        private Label SubName;
        private DataGridViewImageColumn Delete;
        private DataGridViewImageColumn Edit;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn FullName;
    }
}