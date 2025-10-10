namespace ExaminationSystem.Forms.Question
{
    partial class ChooseOneQuestionForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtMarks = new TextBox();
            txtHeader = new TextBox();
            btnAddQuestion = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnResetSearch = new Button();
            btnAddAnswer = new Button();
            cmbAssignExam = new ComboBox();
            label4 = new Label();
            txtAnswer = new TextBox();
            rtbBody = new RichTextBox();
            label2 = new Label();
            lstAnswers = new ListBox();
            btnDeleteAnswer = new Button();
            label6 = new Label();
            label3 = new Label();
            dgvQs = new DataGridView();
            Display = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            Header = new DataGridViewTextBoxColumn();
            Body = new DataGridViewTextBoxColumn();
            examBindingSource = new BindingSource(components);
            chooseOneQuestionBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chooseOneQuestionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33223F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.332222F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33555F));
            tableLayoutPanel1.Controls.Add(txtMarks, 1, 1);
            tableLayoutPanel1.Controls.Add(txtHeader, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAddQuestion, 1, 5);
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 6);
            tableLayoutPanel1.Controls.Add(txtSearch, 1, 6);
            tableLayoutPanel1.Controls.Add(btnResetSearch, 0, 6);
            tableLayoutPanel1.Controls.Add(btnAddAnswer, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbAssignExam, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(txtAnswer, 2, 3);
            tableLayoutPanel1.Controls.Add(rtbBody, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(lstAnswers, 2, 4);
            tableLayoutPanel1.Controls.Add(btnDeleteAnswer, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9946384F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8392859F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.248827F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.1141548F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9178085F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(831, 351);
            tableLayoutPanel1.TabIndex = 141;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 44);
            label1.TabIndex = 132;
            label1.Text = "Header";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMarks
            // 
            txtMarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMarks.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtMarks.Location = new Point(279, 46);
            txtMarks.Margin = new Padding(3, 2, 3, 2);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(270, 33);
            txtMarks.TabIndex = 130;
            txtMarks.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeader
            // 
            txtHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHeader.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtHeader.Location = new Point(3, 46);
            txtHeader.Margin = new Padding(3, 2, 3, 2);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(270, 33);
            txtHeader.TabIndex = 127;
            txtHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.FromArgb(0, 150, 136);
            btnAddQuestion.Dock = DockStyle.Fill;
            btnAddQuestion.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnAddQuestion.Image = Properties.Resources.icons8_add_50;
            btnAddQuestion.Location = new Point(279, 221);
            btnAddQuestion.Margin = new Padding(3, 2, 3, 2);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(270, 62);
            btnAddQuestion.TabIndex = 135;
            btnAddQuestion.Text = "save question";
            btnAddQuestion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnSearch.Image = Properties.Resources.magnifying_glass__1_;
            btnSearch.Location = new Point(555, 287);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(273, 62);
            btnSearch.TabIndex = 147;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtSearch.Location = new Point(279, 301);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 33);
            txtSearch.TabIndex = 149;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // btnResetSearch
            // 
            btnResetSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnResetSearch.Dock = DockStyle.Fill;
            btnResetSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnResetSearch.Image = Properties.Resources.refresh_page_option__1_;
            btnResetSearch.Location = new Point(3, 287);
            btnResetSearch.Margin = new Padding(3, 2, 3, 2);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(270, 62);
            btnResetSearch.TabIndex = 150;
            btnResetSearch.Text = "Refresh";
            btnResetSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnResetSearch.UseVisualStyleBackColor = false;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.BackColor = Color.FromArgb(0, 150, 136);
            btnAddAnswer.Dock = DockStyle.Fill;
            btnAddAnswer.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnAddAnswer.Image = Properties.Resources.tick_box_32;
            btnAddAnswer.Location = new Point(279, 118);
            btnAddAnswer.Margin = new Padding(3, 2, 3, 2);
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.Size = new Size(270, 51);
            btnAddAnswer.TabIndex = 139;
            btnAddAnswer.Text = "add option";
            btnAddAnswer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddAnswer.UseVisualStyleBackColor = false;
            btnAddAnswer.Click += btnAddAnswer_Click;
            // 
            // cmbAssignExam
            // 
            cmbAssignExam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbAssignExam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssignExam.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            cmbAssignExam.FormattingEnabled = true;
            cmbAssignExam.Location = new Point(555, 46);
            cmbAssignExam.Margin = new Padding(3, 2, 3, 2);
            cmbAssignExam.Name = "cmbAssignExam";
            cmbAssignExam.Size = new Size(273, 34);
            cmbAssignExam.TabIndex = 141;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label4.Location = new Point(555, 74);
            label4.Name = "label4";
            label4.Size = new Size(273, 42);
            label4.TabIndex = 136;
            label4.Text = "Answer";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtAnswer.Location = new Point(555, 118);
            txtAnswer.Margin = new Padding(3, 2, 3, 2);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(273, 33);
            txtAnswer.TabIndex = 138;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            // 
            // rtbBody
            // 
            rtbBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbBody.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            rtbBody.Location = new Point(3, 118);
            rtbBody.Margin = new Padding(3, 2, 3, 2);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(270, 51);
            rtbBody.TabIndex = 128;
            rtbBody.Text = "";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(270, 42);
            label2.TabIndex = 133;
            label2.Text = "Body";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstAnswers
            // 
            lstAnswers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAnswers.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            lstAnswers.FormattingEnabled = true;
            lstAnswers.Location = new Point(555, 173);
            lstAnswers.Margin = new Padding(3, 2, 3, 2);
            lstAnswers.Name = "lstAnswers";
            lstAnswers.Size = new Size(273, 30);
            lstAnswers.TabIndex = 140;
            // 
            // btnDeleteAnswer
            // 
            btnDeleteAnswer.BackColor = Color.FromArgb(0, 150, 136);
            btnDeleteAnswer.Dock = DockStyle.Fill;
            btnDeleteAnswer.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnDeleteAnswer.Image = Properties.Resources.delete__5_;
            btnDeleteAnswer.Location = new Point(279, 173);
            btnDeleteAnswer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAnswer.Name = "btnDeleteAnswer";
            btnDeleteAnswer.Size = new Size(270, 44);
            btnDeleteAnswer.TabIndex = 151;
            btnDeleteAnswer.Text = "delete option";
            btnDeleteAnswer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeleteAnswer.UseVisualStyleBackColor = false;
            btnDeleteAnswer.Click += btnDeleteAnswer_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label6.Location = new Point(555, 0);
            label6.Name = "label6";
            label6.Size = new Size(273, 44);
            label6.TabIndex = 142;
            label6.Text = "Assign To Exam";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label3.Location = new Point(279, 0);
            label3.Name = "label3";
            label3.Size = new Size(270, 44);
            label3.TabIndex = 134;
            label3.Text = "Mark";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvQs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvQs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQs.Columns.AddRange(new DataGridViewColumn[] { Display, Delete, Id, Header, Body });
            dgvQs.Cursor = Cursors.Hand;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.NullValue = ".........";
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvQs.DefaultCellStyle = dataGridViewCellStyle11;
            dgvQs.Dock = DockStyle.Bottom;
            dgvQs.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvQs.GridColor = Color.Black;
            dgvQs.Location = new Point(0, 351);
            dgvQs.Margin = new Padding(3, 2, 3, 2);
            dgvQs.Name = "dgvQs";
            dgvQs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Calibri", 18F, FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvQs.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvQs.RowHeadersWidth = 30;
            dgvQs.Size = new Size(831, 242);
            dgvQs.TabIndex = 140;
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
            Header.DataPropertyName = "Header";
            Header.HeaderText = "Header";
            Header.MinimumWidth = 6;
            Header.Name = "Header";
            Header.ReadOnly = true;
            // 
            // Body
            // 
            Body.DataPropertyName = "Body";
            Body.HeaderText = "Body";
            Body.MinimumWidth = 6;
            Body.Name = "Body";
            Body.ReadOnly = true;
            // 
            // examBindingSource
            // 
            examBindingSource.DataSource = typeof(Models.Exam);
            // 
            // chooseOneQuestionBindingSource
            // 
            chooseOneQuestionBindingSource.DataSource = typeof(Models.ChooseOneQuestion);
            // 
            // ChooseOneQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 593);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvQs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChooseOneQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose One Question";
            Load += ChooseOneQuestionForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQs).EndInit();
            ((System.ComponentModel.ISupportInitialize)examBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)chooseOneQuestionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtAnswer;
        private Label label1;
        private Label label3;
        private TextBox txtMarks;
        private TextBox txtHeader;
        private Label label2;
        private RichTextBox rtbBody;
        private Label label4;
        private Button btnAddQuestion;
        private DataGridView dgvQs;
        private ListBox lstAnswers;
        private Button btnAddAnswer;
        private ComboBox cmbAssignExam;
        private Label label6;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnResetSearch;
        private BindingSource chooseOneQuestionBindingSource;
        private BindingSource examBindingSource;
        private Button btnDeleteAnswer;
        private DataGridViewImageColumn Display;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Header;
        private DataGridViewTextBoxColumn Body;
    }
}