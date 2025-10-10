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
            dgvExams.Location = new Point(10, 184);
            dgvExams.Margin = new Padding(3, 2, 3, 2);
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dgvExams.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvExams.RowHeadersWidth = 30;
            dgvExams.Size = new Size(914, 340);
            dgvExams.TabIndex = 120;
            dgvExams.SelectionChanged += dgvExams_SelectionChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdateStatus.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnUpdateStatus.Location = new Point(310, 104);
            btnUpdateStatus.Margin = new Padding(3, 2, 3, 2);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(234, 59);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Mode";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label1.Location = new Point(114, 7);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 3;
            label1.Text = "Select New Status";
            // 
            // lblSelectedExamTitle
            // 
            lblSelectedExamTitle.AutoSize = true;
            lblSelectedExamTitle.BackColor = Color.White;
            lblSelectedExamTitle.Font = new Font("Cambria", 18F, FontStyle.Bold);
            lblSelectedExamTitle.Location = new Point(499, 42);
            lblSelectedExamTitle.Name = "lblSelectedExamTitle";
            lblSelectedExamTitle.Size = new Size(205, 28);
            lblSelectedExamTitle.TabIndex = 121;
            lblSelectedExamTitle.Text = "No Exam Selected";
            // 
            // cmbExamMode
            // 
            cmbExamMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExamMode.FlatStyle = FlatStyle.Popup;
            cmbExamMode.Font = new Font("Cambria", 18F, FontStyle.Bold);
            cmbExamMode.FormattingEnabled = true;
            cmbExamMode.Items.AddRange(new object[] { "Queued", "Starting", "Finished" });
            cmbExamMode.Location = new Point(114, 36);
            cmbExamMode.Margin = new Padding(3, 2, 3, 2);
            cmbExamMode.MaxDropDownItems = 10;
            cmbExamMode.Name = "cmbExamMode";
            cmbExamMode.Size = new Size(322, 36);
            cmbExamMode.TabIndex = 122;
            // 
            // ExamStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(941, 550);
            Controls.Add(cmbExamMode);
            Controls.Add(lblSelectedExamTitle);
            Controls.Add(label1);
            Controls.Add(btnUpdateStatus);
            Controls.Add(dgvExams);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExamStatusForm";
            Text = "Exam Status";
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