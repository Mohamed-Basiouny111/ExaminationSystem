namespace ExaminationSystem.Forms.Question
{
    partial class QuestionDisplayForm
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
            lstAnswers = new ListBox();
            label4 = new Label();
            btnupdate = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMarks = new TextBox();
            txtHeader = new TextBox();
            rtbBody = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstAnswers
            // 
            lstAnswers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAnswers.FormattingEnabled = true;
            lstAnswers.Location = new Point(375, 176);
            lstAnswers.Name = "lstAnswers";
            lstAnswers.Size = new Size(367, 104);
            lstAnswers.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label4.Location = new Point(375, 115);
            label4.Name = "label4";
            label4.Size = new Size(367, 58);
            label4.TabIndex = 146;
            label4.Text = "Answer";
            // 
            // btnupdate
            // 
            btnupdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnupdate.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(375, 296);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(367, 93);
            btnupdate.TabIndex = 145;
            btnupdate.Text = "Update question";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label3.Location = new Point(375, 0);
            label3.Name = "label3";
            label3.Size = new Size(367, 39);
            label3.TabIndex = 144;
            label3.Text = "Mark";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label2.Location = new Point(3, 115);
            label2.Name = "label2";
            label2.Size = new Size(366, 58);
            label2.TabIndex = 143;
            label2.Text = "Body";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 39);
            label1.TabIndex = 142;
            label1.Text = "Header";
            // 
            // txtMarks
            // 
            txtMarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMarks.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            txtMarks.Location = new Point(375, 42);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(367, 40);
            txtMarks.TabIndex = 140;
            // 
            // txtHeader
            // 
            txtHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHeader.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            txtHeader.Location = new Point(3, 42);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(366, 40);
            txtHeader.TabIndex = 137;
            // 
            // rtbBody
            // 
            rtbBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbBody.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            rtbBody.Location = new Point(3, 176);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(366, 114);
            rtbBody.TabIndex = 138;
            rtbBody.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtHeader, 0, 1);
            tableLayoutPanel1.Controls.Add(rtbBody, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(txtMarks, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(lstAnswers, 1, 3);
            tableLayoutPanel1.Controls.Add(btnupdate, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.2857132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.71429F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.Size = new Size(745, 392);
            tableLayoutPanel1.TabIndex = 147;
            // 
            // QuestionDisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(787, 497);
            MinimumSize = new Size(787, 497);
            Name = "QuestionDisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuestionDisplayForm";
            Load += QuestionDisplayForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private Label txtBody;
        private ListBox lstAnswers;
        private Label label4;
        private Button btnupdate;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbFalse;
        private TextBox txtMarks;
        private RadioButton rbTrue;
        private TextBox txtHeader;
        private RichTextBox rtbBody;
        private TableLayoutPanel tableLayoutPanel1;
    }
}