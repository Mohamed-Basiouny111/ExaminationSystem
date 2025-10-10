namespace ExaminationSystem.Forms.Question
{
    partial class TrueFalseQuestionForm
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
            dgvQs = new DataGridView();
            Display = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            Header = new DataGridViewTextBoxColumn();
            Body = new DataGridViewTextBoxColumn();
            txtHeader = new TextBox();
            txtMarks = new TextBox();
            rtbBody = new RichTextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            rbFalse = new RadioButton();
            rbTrue = new RadioButton();
            label2 = new Label();
            btnadd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSearch = new Button();
            btnResetSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            cmbAssignExam = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvQs).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvQs
            // 
            dgvQs.AllowUserToAddRows = false;
            dgvQs.AllowUserToDeleteRows = false;
            dgvQs.AllowUserToOrderColumns = true;
            dgvQs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQs.BackgroundColor = Color.White;
            dgvQs.BorderStyle = BorderStyle.Fixed3D;
            dgvQs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQs.Columns.AddRange(new DataGridViewColumn[] { Display, Delete, Id, Header, Body });
            dgvQs.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = ".........";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQs.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQs.Dock = DockStyle.Bottom;
            dgvQs.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvQs.GridColor = Color.Black;
            dgvQs.Location = new Point(0, 306);
            dgvQs.Margin = new Padding(3, 2, 3, 2);
            dgvQs.Name = "dgvQs";
            dgvQs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvQs.RowHeadersWidth = 30;
            dgvQs.Size = new Size(831, 280);
            dgvQs.TabIndex = 125;
            dgvQs.CellContentClick += dgvQs_CellContentClick;
            dgvQs.CellValueChanged += dgvQs_CellValueChanged;
            dgvQs.CurrentCellDirtyStateChanged += dgvQs_CurrentCellDirtyStateChanged;
            // 
            // Display
            // 
            Display.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Display.FillWeight = 50F;
            Display.HeaderText = "Edit";
            Display.Image = Properties.Resources.edit__2_1;
            Display.MinimumWidth = 6;
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.Resizable = DataGridViewTriState.True;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Delete.FillWeight = 50F;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete__5_;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Header
            // 
            Header.HeaderText = "Header";
            Header.MinimumWidth = 6;
            Header.Name = "Header";
            Header.ReadOnly = true;
            // 
            // Body
            // 
            Body.HeaderText = "Body";
            Body.MinimumWidth = 6;
            Body.Name = "Body";
            Body.ReadOnly = true;
            // 
            // txtHeader
            // 
            txtHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHeader.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtHeader.Location = new Point(3, 32);
            txtHeader.Margin = new Padding(3, 2, 3, 2);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(270, 33);
            txtHeader.TabIndex = 127;
            txtHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMarks
            // 
            txtMarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMarks.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtMarks.Location = new Point(279, 32);
            txtMarks.Margin = new Padding(3, 2, 3, 2);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(270, 33);
            txtMarks.TabIndex = 130;
            txtMarks.TextAlign = HorizontalAlignment.Center;
            // 
            // rtbBody
            // 
            rtbBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbBody.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            rtbBody.Location = new Point(3, 110);
            rtbBody.Margin = new Padding(3, 2, 3, 2);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(270, 56);
            rtbBody.TabIndex = 128;
            rtbBody.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label3.Location = new Point(279, 0);
            label3.Name = "label3";
            label3.Size = new Size(270, 30);
            label3.TabIndex = 134;
            label3.Text = "Mark";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 30);
            label1.TabIndex = 132;
            label1.Text = "Header";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label4.Location = new Point(279, 72);
            label4.Name = "label4";
            label4.Size = new Size(270, 36);
            label4.TabIndex = 136;
            label4.Text = "Answer";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbFalse
            // 
            rbFalse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbFalse.AutoSize = true;
            rbFalse.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            rbFalse.Location = new Point(650, 110);
            rbFalse.Margin = new Padding(3, 2, 3, 2);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(82, 56);
            rbFalse.TabIndex = 131;
            rbFalse.TabStop = true;
            rbFalse.Text = "False";
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            rbTrue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rbTrue.AutoSize = true;
            rbTrue.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            rbTrue.Location = new Point(375, 110);
            rbTrue.Margin = new Padding(3, 2, 3, 2);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(78, 56);
            rbTrue.TabIndex = 129;
            rbTrue.TabStop = true;
            rbTrue.Text = "True";
            rbTrue.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(270, 36);
            label2.TabIndex = 133;
            label2.Text = "Body";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(0, 150, 136);
            btnadd.Dock = DockStyle.Fill;
            btnadd.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnadd.Image = Properties.Resources.icons8_add_50;
            btnadd.ImageAlign = ContentAlignment.MiddleRight;
            btnadd.Location = new Point(279, 170);
            btnadd.Margin = new Padding(3, 2, 3, 2);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(270, 63);
            btnadd.TabIndex = 135;
            btnadd.Text = "save question";
            btnadd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33223F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.332222F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33555F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(txtMarks, 1, 1);
            tableLayoutPanel1.Controls.Add(txtHeader, 0, 1);
            tableLayoutPanel1.Controls.Add(btnadd, 1, 4);
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 5);
            tableLayoutPanel1.Controls.Add(btnResetSearch, 0, 5);
            tableLayoutPanel1.Controls.Add(txtSearch, 1, 5);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(cmbAssignExam, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(rbFalse, 2, 3);
            tableLayoutPanel1.Controls.Add(rbTrue, 1, 3);
            tableLayoutPanel1.Controls.Add(rtbBody, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.6965885F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.14516F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.32258F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.4032249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.6290321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(831, 306);
            tableLayoutPanel1.TabIndex = 139;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnSearch.Image = Properties.Resources.magnifying_glass__1_;
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(555, 237);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(0, 0, 9, 0);
            btnSearch.Size = new Size(273, 67);
            btnSearch.TabIndex = 145;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnResetSearch
            // 
            btnResetSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnResetSearch.Dock = DockStyle.Fill;
            btnResetSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnResetSearch.Image = Properties.Resources.refresh_page_option__1_;
            btnResetSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnResetSearch.Location = new Point(3, 237);
            btnResetSearch.Margin = new Padding(3, 2, 3, 2);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Padding = new Padding(0, 0, 9, 0);
            btnResetSearch.Size = new Size(270, 67);
            btnResetSearch.TabIndex = 146;
            btnResetSearch.Text = "Refresh";
            btnResetSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnResetSearch.UseVisualStyleBackColor = false;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(279, 254);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 33);
            txtSearch.TabIndex = 147;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label6.Location = new Point(555, 0);
            label6.Name = "label6";
            label6.Size = new Size(273, 30);
            label6.TabIndex = 144;
            label6.Text = "Assign To Exam";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbAssignExam
            // 
            cmbAssignExam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbAssignExam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssignExam.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAssignExam.FormattingEnabled = true;
            cmbAssignExam.Location = new Point(555, 32);
            cmbAssignExam.Margin = new Padding(3, 2, 3, 2);
            cmbAssignExam.Name = "cmbAssignExam";
            cmbAssignExam.Size = new Size(273, 30);
            cmbAssignExam.TabIndex = 143;
            // 
            // TrueFalseQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 586);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvQs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TrueFalseQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "True & False Questions";
            Load += TrueFalseQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQs).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvQs;
        private TextBox txtHeader;
        private TextBox txtMarks;
        private RichTextBox rtbBody;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label4;
        private RadioButton rbFalse;
        private RadioButton rbTrue;
        private Label label2;
        private Button btnadd;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbAssignExam;
        private Label label6;
        private Button btnSearch;
        private Button btnResetSearch;
        private TextBox txtSearch;
        private DataGridViewImageColumn Display;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Header;
        private DataGridViewTextBoxColumn Body;
    }
}