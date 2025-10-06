namespace ExaminationSystem.Forms.ExamForm
{
    partial class ExamForm
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
            WelcomeLabel = new Label();
            TodaysDatelabel = new Label();
            Date = new Label();
            label1 = new Label();
            Noofquestionslabel = new Label();
            label2 = new Label();
            Currentquestionlabel = new Label();
            label3 = new Label();
            label4 = new Label();
            totaltimelabel = new Label();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(460, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(113, 31);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome";
            // 
            // TodaysDatelabel
            // 
            TodaysDatelabel.AutoSize = true;
            TodaysDatelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TodaysDatelabel.Location = new Point(1000, 9);
            TodaysDatelabel.Name = "TodaysDatelabel";
            TodaysDatelabel.Size = new Size(57, 28);
            TodaysDatelabel.TabIndex = 1;
            TodaysDatelabel.Text = "Date";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.Location = new Point(869, 9);
            Date.Name = "Date";
            Date.Size = new Size(125, 28);
            Date.TabIndex = 2;
            Date.Text = "Exam Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 3;
            label1.Text = "Total Questions :";
            // 
            // Noofquestionslabel
            // 
            Noofquestionslabel.AutoSize = true;
            Noofquestionslabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Noofquestionslabel.Location = new Point(188, 55);
            Noofquestionslabel.Name = "Noofquestionslabel";
            Noofquestionslabel.Size = new Size(24, 28);
            Noofquestionslabel.TabIndex = 4;
            Noofquestionslabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 5;
            label2.Text = "Question Number: ";
            label2.Click += label2_Click;
            // 
            // Currentquestionlabel
            // 
            Currentquestionlabel.AutoSize = true;
            Currentquestionlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Currentquestionlabel.Location = new Point(201, 96);
            Currentquestionlabel.Name = "Currentquestionlabel";
            Currentquestionlabel.Size = new Size(24, 28);
            Currentquestionlabel.TabIndex = 6;
            Currentquestionlabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(869, 55);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 7;
            label3.Text = "Total time : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(869, 96);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 8;
            label4.Text = "Remaining Time :";
            // 
            // totaltimelabel
            // 
            totaltimelabel.AutoSize = true;
            totaltimelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totaltimelabel.Location = new Point(1000, 55);
            totaltimelabel.Name = "totaltimelabel";
            totaltimelabel.Size = new Size(24, 28);
            totaltimelabel.TabIndex = 9;
            totaltimelabel.Text = "0";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 539);
            Controls.Add(totaltimelabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Currentquestionlabel);
            Controls.Add(label2);
            Controls.Add(Noofquestionslabel);
            Controls.Add(label1);
            Controls.Add(Date);
            Controls.Add(TodaysDatelabel);
            Controls.Add(WelcomeLabel);
            Name = "ExamForm";
            Text = "ExamForm";
            Load += ExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Label TodaysDatelabel;
        private Label Date;
        private Label label1;
        private Label Noofquestionslabel;
        private Label label2;
        private Label Currentquestionlabel;
        private Label label3;
        private Label label4;
        private Label totaltimelabel;
    }
}