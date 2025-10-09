namespace ExaminationSystem.Forms.Question
{
    partial class ChooseAllQuestionForm
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
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtMarks = new TextBox();
            txtHeader = new TextBox();
            label2 = new Label();
            rtbBody = new RichTextBox();
            label4 = new Label();
            txtAnswer = new TextBox();
            btnAddQuestion = new Button();
            lstAnswers = new ListBox();
            label6 = new Label();
            cmbAssignExam = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnResetSearch = new Button();
            btnAddAnswer = new Button();
            dgvQs = new DataGridView();
            Display = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Header = new DataGridViewTextBoxColumn();
            Body = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQs).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3322258F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.332222F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33555F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(txtMarks, 1, 2);
            tableLayoutPanel1.Controls.Add(txtHeader, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(rtbBody, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtAnswer, 0, 4);
            tableLayoutPanel1.Controls.Add(btnAddQuestion, 1, 6);
            tableLayoutPanel1.Controls.Add(lstAnswers, 0, 5);
            tableLayoutPanel1.Controls.Add(label6, 2, 3);
            tableLayoutPanel1.Controls.Add(cmbAssignExam, 2, 4);
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 7);
            tableLayoutPanel1.Controls.Add(txtSearch, 1, 7);
            tableLayoutPanel1.Controls.Add(btnResetSearch, 0, 7);
            tableLayoutPanel1.Controls.Add(btnAddAnswer, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9167557F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4445219F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2666664F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1944447F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.01389F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.51389F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(950, 421);
            tableLayoutPanel1.TabIndex = 143;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label1.Location = new Point(3, 51);
            label1.Name = "label1";
            label1.Size = new Size(310, 30);
            label1.TabIndex = 132;
            label1.Text = "Header";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label3.Location = new Point(319, 51);
            label3.Name = "label3";
            label3.Size = new Size(310, 30);
            label3.TabIndex = 134;
            label3.Text = "Mark";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(319, 0);
            label5.Name = "label5";
            label5.Size = new Size(310, 51);
            label5.TabIndex = 137;
            label5.Text = "Choose All Questions";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMarks
            // 
            txtMarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMarks.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtMarks.Location = new Point(319, 84);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(310, 39);
            txtMarks.TabIndex = 130;
            txtMarks.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeader
            // 
            txtHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHeader.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtHeader.Location = new Point(3, 84);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(310, 39);
            txtHeader.TabIndex = 127;
            txtHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label2.Location = new Point(635, 51);
            label2.Name = "label2";
            label2.Size = new Size(312, 30);
            label2.TabIndex = 133;
            label2.Text = "Body";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtbBody
            // 
            rtbBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbBody.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            rtbBody.Location = new Point(635, 84);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(312, 29);
            rtbBody.TabIndex = 128;
            rtbBody.Text = "";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label4.Location = new Point(3, 116);
            label4.Name = "label4";
            label4.Size = new Size(310, 38);
            label4.TabIndex = 136;
            label4.Text = "Answer";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtAnswer.Location = new Point(3, 157);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(310, 39);
            txtAnswer.TabIndex = 138;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddQuestion.BackColor = Color.FromArgb(0, 150, 136);
            btnAddQuestion.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnAddQuestion.Image = Properties.Resources.icons8_add_50;
            btnAddQuestion.ImageAlign = ContentAlignment.MiddleRight;
            btnAddQuestion.Location = new Point(319, 293);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(310, 59);
            btnAddQuestion.TabIndex = 135;
            btnAddQuestion.Text = "Add new question";
            btnAddQuestion.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // lstAnswers
            // 
            lstAnswers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAnswers.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            lstAnswers.FormattingEnabled = true;
            lstAnswers.Location = new Point(3, 206);
            lstAnswers.Name = "lstAnswers";
            lstAnswers.Size = new Size(310, 68);
            lstAnswers.TabIndex = 140;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            label6.Location = new Point(635, 116);
            label6.Name = "label6";
            label6.Size = new Size(312, 38);
            label6.TabIndex = 144;
            label6.Text = "Assign To Exam";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbAssignExam
            // 
            cmbAssignExam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbAssignExam.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssignExam.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            cmbAssignExam.FormattingEnabled = true;
            cmbAssignExam.Location = new Point(635, 157);
            cmbAssignExam.Name = "cmbAssignExam";
            cmbAssignExam.Size = new Size(312, 40);
            cmbAssignExam.TabIndex = 143;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnSearch.Image = Properties.Resources.magnifying_glass__1_;
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(635, 361);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(0, 0, 10, 0);
            btnSearch.Size = new Size(312, 57);
            btnSearch.TabIndex = 146;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            txtSearch.Location = new Point(319, 370);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(310, 39);
            txtSearch.TabIndex = 148;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // btnResetSearch
            // 
            btnResetSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnResetSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnResetSearch.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnResetSearch.Image = Properties.Resources.refresh_page_option__1_;
            btnResetSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnResetSearch.Location = new Point(3, 361);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Padding = new Padding(0, 0, 10, 0);
            btnResetSearch.Size = new Size(310, 57);
            btnResetSearch.TabIndex = 149;
            btnResetSearch.Text = "Refresh";
            btnResetSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnResetSearch.UseVisualStyleBackColor = false;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddAnswer.BackColor = Color.FromArgb(0, 150, 136);
            btnAddAnswer.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
            btnAddAnswer.Image = Properties.Resources.tick_box_32;
            btnAddAnswer.Location = new Point(319, 157);
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.Size = new Size(310, 43);
            btnAddAnswer.TabIndex = 139;
            btnAddAnswer.Text = "add option";
            btnAddAnswer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddAnswer.UseVisualStyleBackColor = false;
            btnAddAnswer.Click += btnAddAnswer_Click;
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
            dataGridViewCellStyle1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dataGridViewCellStyle2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = ".........";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQs.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQs.Dock = DockStyle.Bottom;
            dgvQs.GridColor = Color.Black;
            dgvQs.Location = new Point(0, 421);
            dgvQs.Name = "dgvQs";
            dgvQs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 18F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQs.RowHeadersWidth = 30;
            dgvQs.Size = new Size(950, 370);
            dgvQs.TabIndex = 142;
            dgvQs.CellContentClick += dgvQs_CellContentClick;
            dgvQs.CellValueChanged += dgvQs_CellValueChanged;
            dgvQs.CurrentCellDirtyStateChanged += dgvQs_CurrentCellDirtyStateChanged;
            // 
            // Display
            // 
            Display.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Display.FillWeight = 50F;
            Display.HeaderText = "Display";
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
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
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
            // ChooseAllQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 791);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvQs);
            Name = "ChooseAllQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseAllQuestionForm";
            Load += ChooseAllQuestionForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label5;
        private TextBox txtMarks;
        private TextBox txtHeader;
        private Label label2;
        private RichTextBox rtbBody;
        private Label label4;
        private Button btnAddQuestion;
        private TextBox txtAnswer;
        private ListBox lstAnswers;
        private Button btnAddAnswer;
        private DataGridView dgvQs;
        private DataGridViewButtonColumn Display;
        private DataGridViewButtonColumn Delete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Header;
        private DataGridViewTextBoxColumn Body;
        private Label label6;
        private ComboBox cmbAssignExam;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnResetSearch;
    }
}