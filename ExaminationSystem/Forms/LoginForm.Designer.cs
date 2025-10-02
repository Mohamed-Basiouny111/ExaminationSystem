namespace ExaminationSystem.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            selectuserCB = new ComboBox();
            panel1 = new Panel();
            Showandhidecheckbox = new CheckBox();
            btnlogin = new Button();
            teacherpasswordtb = new TextBox();
            teacherusernametb = new TextBox();
            wronglabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            studentShowandhidecheckbox = new CheckBox();
            button1 = new Button();
            studentpasstextbox = new TextBox();
            studentusernametb = new TextBox();
            wronglabel2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 42);
            label1.Name = "label1";
            label1.Size = new Size(507, 44);
            label1.TabIndex = 0;
            label1.Text = "Exam Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 142);
            label2.Name = "label2";
            label2.Size = new Size(252, 38);
            label2.TabIndex = 1;
            label2.Text = "Select User Type";
            // 
            // selectuserCB
            // 
            selectuserCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectuserCB.FormattingEnabled = true;
            selectuserCB.Items.AddRange(new object[] { "Student ", "Teacher" });
            selectuserCB.Location = new Point(435, 225);
            selectuserCB.Name = "selectuserCB";
            selectuserCB.Size = new Size(391, 36);
            selectuserCB.TabIndex = 2;
            selectuserCB.SelectedIndexChanged += selectuserCB_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(Showandhidecheckbox);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(teacherpasswordtb);
            panel1.Controls.Add(teacherusernametb);
            panel1.Controls.Add(wronglabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(435, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 442);
            panel1.TabIndex = 3;
            // 
            // Showandhidecheckbox
            // 
            Showandhidecheckbox.AutoSize = true;
            Showandhidecheckbox.Location = new Point(128, 290);
            Showandhidecheckbox.Name = "Showandhidecheckbox";
            Showandhidecheckbox.Size = new Size(132, 24);
            Showandhidecheckbox.TabIndex = 4;
            Showandhidecheckbox.Text = "Show Password";
            Showandhidecheckbox.UseVisualStyleBackColor = true;
            Showandhidecheckbox.CheckedChanged += Showandhidecheckbox_CheckedChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.LimeGreen;
            btnlogin.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            btnlogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(84, 335);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(220, 41);
            btnlogin.TabIndex = 10;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // teacherpasswordtb
            // 
            teacherpasswordtb.BorderStyle = BorderStyle.FixedSingle;
            teacherpasswordtb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacherpasswordtb.Location = new Point(21, 242);
            teacherpasswordtb.Name = "teacherpasswordtb";
            teacherpasswordtb.PasswordChar = '*';
            teacherpasswordtb.Size = new Size(355, 34);
            teacherpasswordtb.TabIndex = 9;
            teacherpasswordtb.TextAlign = HorizontalAlignment.Center;
            // 
            // teacherusernametb
            // 
            teacherusernametb.BorderStyle = BorderStyle.FixedSingle;
            teacherusernametb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacherusernametb.Location = new Point(21, 144);
            teacherusernametb.Name = "teacherusernametb";
            teacherusernametb.Size = new Size(355, 34);
            teacherusernametb.TabIndex = 8;
            teacherusernametb.TextAlign = HorizontalAlignment.Center;
            // 
            // wronglabel
            // 
            wronglabel.AutoSize = true;
            wronglabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            wronglabel.ForeColor = Color.Red;
            wronglabel.Location = new Point(69, 413);
            wronglabel.Name = "wronglabel";
            wronglabel.Size = new Size(247, 20);
            wronglabel.TabIndex = 7;
            wronglabel.Text = "Wrong Username OR password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(148, 202);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 6;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 107);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 53);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 4;
            label3.Text = "Teacher Login";
            // 
            // panel2
            // 
            panel2.Controls.Add(studentShowandhidecheckbox);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(studentpasstextbox);
            panel2.Controls.Add(studentusernametb);
            panel2.Controls.Add(wronglabel2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(435, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 442);
            panel2.TabIndex = 11;
            // 
            // studentShowandhidecheckbox
            // 
            studentShowandhidecheckbox.AutoSize = true;
            studentShowandhidecheckbox.Location = new Point(128, 290);
            studentShowandhidecheckbox.Name = "studentShowandhidecheckbox";
            studentShowandhidecheckbox.Size = new Size(132, 24);
            studentShowandhidecheckbox.TabIndex = 4;
            studentShowandhidecheckbox.Text = "Show Password";
            studentShowandhidecheckbox.UseVisualStyleBackColor = true;
            studentShowandhidecheckbox.CheckedChanged += studentShowandhidecheckbox_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 64, 0);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(84, 335);
            button1.Name = "button1";
            button1.Size = new Size(220, 41);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // studentpasstextbox
            // 
            studentpasstextbox.BorderStyle = BorderStyle.FixedSingle;
            studentpasstextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentpasstextbox.Location = new Point(21, 242);
            studentpasstextbox.Name = "studentpasstextbox";
            studentpasstextbox.PasswordChar = '*';
            studentpasstextbox.Size = new Size(355, 34);
            studentpasstextbox.TabIndex = 9;
            studentpasstextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // studentusernametb
            // 
            studentusernametb.BorderStyle = BorderStyle.FixedSingle;
            studentusernametb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentusernametb.Location = new Point(21, 144);
            studentusernametb.Name = "studentusernametb";
            studentusernametb.Size = new Size(355, 34);
            studentusernametb.TabIndex = 8;
            studentusernametb.TextAlign = HorizontalAlignment.Center;
            // 
            // wronglabel2
            // 
            wronglabel2.AutoSize = true;
            wronglabel2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            wronglabel2.ForeColor = Color.Red;
            wronglabel2.Location = new Point(69, 413);
            wronglabel2.Name = "wronglabel2";
            wronglabel2.Size = new Size(247, 20);
            wronglabel2.TabIndex = 7;
            wronglabel2.Text = "Wrong Username OR password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(148, 202);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(148, 107);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 5;
            label8.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(128, 53);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 4;
            label9.Text = "Student Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 813);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(selectuserCB);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox selectuserCB;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox teacherpasswordtb;
        private TextBox teacherusernametb;
        private Label wronglabel;
        private Button btnlogin;
        private CheckBox Showandhidecheckbox;
        private Panel panel2;
        private CheckBox studentShowandhidecheckbox;
        private Button button1;
        private TextBox studentpasstextbox;
        private TextBox studentusernametb;
        private Label wronglabel2;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}