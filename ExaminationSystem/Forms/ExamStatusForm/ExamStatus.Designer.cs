namespace ExaminationSystem.Forms.Exam_Status_Form
{
    partial class ExamStatusForm
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
            dgvExams = new DataGridView();
            btnUpdateStatus = new Button();
            label1 = new Label();
            lblSelectedExamTitle = new Label();
            cmbExamMode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.Font = new Font("Cambria", 18F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cambria", 18F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExams.GridColor = Color.Black;
            dgvExams.Location = new Point(12, 245);
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dgvExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvExams.RowHeadersWidth = 30;
            dgvExams.Size = new Size(1045, 454);
            dgvExams.TabIndex = 120;
            dgvExams.SelectionChanged += dgvExams_SelectionChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdateStatus.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnUpdateStatus.Location = new Point(354, 138);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(268, 79);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Mode";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 36);
            label1.TabIndex = 3;
            label1.Text = "Select New Status";
            // 
            // lblSelectedExamTitle
            // 
            lblSelectedExamTitle.AutoSize = true;
            lblSelectedExamTitle.BackColor = Color.White;
            lblSelectedExamTitle.Font = new Font("Cambria", 18F, FontStyle.Bold);
            lblSelectedExamTitle.Location = new Point(570, 56);
            lblSelectedExamTitle.Name = "lblSelectedExamTitle";
            lblSelectedExamTitle.Size = new Size(257, 36);
            lblSelectedExamTitle.TabIndex = 121;
            lblSelectedExamTitle.Text = "No Exam Selected";
            // 
            // cmbExamMode
            // 
            cmbExamMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExamMode.FlatStyle = FlatStyle.Popup;
            cmbExamMode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbExamMode.FormattingEnabled = true;
            cmbExamMode.Items.AddRange(new object[] { "Queued", "Starting", "Finished" });
            cmbExamMode.Location = new Point(130, 48);
            cmbExamMode.MaxDropDownItems = 10;
            cmbExamMode.Name = "cmbExamMode";
            cmbExamMode.Size = new Size(368, 30);
            cmbExamMode.TabIndex = 122;
            // 
            // ExamStatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(1075, 734);
            Controls.Add(cmbExamMode);
            Controls.Add(lblSelectedExamTitle);
            Controls.Add(label1);
            Controls.Add(btnUpdateStatus);
            Controls.Add(dgvExams);
            Name = "ExamStatusForm";
            Text = "ExamStatusForm";
            Load += ExamStatusForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvExams;
        private Button btnUpdateStatus;
        private Label label1;
        private Label lblSelectedExamTitle;
        public ComboBox cmbExamMode;
    }
}