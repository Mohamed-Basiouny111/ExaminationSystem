namespace ExaminationSystem
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            panelMenu = new Panel();
            btnLogout = new Button();
            btnUpdateMode = new Button();
            btnAddUser = new Button();
            btnShowAnswer = new Button();
            btnExamAttempt = new Button();
            btnAddExam = new Button();
            btnQuesTF = new Button();
            btnQuesOne = new Button();
            btnQuesAll = new Button();
            btnAddSub = new Button();
            panelLogo = new Panel();
            LName = new Label();
            profile = new Button();
            button1 = new Button();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            bntMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            LTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnUpdateMode);
            panelMenu.Controls.Add(btnAddUser);
            panelMenu.Controls.Add(btnShowAnswer);
            panelMenu.Controls.Add(btnExamAttempt);
            panelMenu.Controls.Add(btnAddExam);
            panelMenu.Controls.Add(btnQuesTF);
            panelMenu.Controls.Add(btnQuesOne);
            panelMenu.Controls.Add(btnQuesAll);
            panelMenu.Controls.Add(btnAddSub);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(276, 644);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.MistyRose;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 616);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(18, 0, 0, 0);
            btnLogout.Size = new Size(276, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdateMode
            // 
            btnUpdateMode.Dock = DockStyle.Top;
            btnUpdateMode.FlatAppearance.BorderSize = 0;
            btnUpdateMode.FlatStyle = FlatStyle.Flat;
            btnUpdateMode.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateMode.ForeColor = Color.MistyRose;
            btnUpdateMode.Image = Properties.Resources.menu__3_;
            btnUpdateMode.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateMode.Location = new Point(0, 565);
            btnUpdateMode.Margin = new Padding(3, 2, 3, 2);
            btnUpdateMode.Name = "btnUpdateMode";
            btnUpdateMode.Padding = new Padding(18, 0, 0, 0);
            btnUpdateMode.Size = new Size(276, 51);
            btnUpdateMode.TabIndex = 10;
            btnUpdateMode.Text = "Update Mode";
            btnUpdateMode.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateMode.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateMode.UseVisualStyleBackColor = true;
            btnUpdateMode.Click += btnUpdateMode_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Dock = DockStyle.Top;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.MistyRose;
            btnAddUser.Image = Properties.Resources.add_user__1___1_;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(0, 514);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Padding = new Padding(18, 0, 0, 0);
            btnAddUser.Size = new Size(276, 51);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Users";
            btnAddUser.TextAlign = ContentAlignment.MiddleLeft;
            btnAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.Dock = DockStyle.Top;
            btnShowAnswer.FlatAppearance.BorderSize = 0;
            btnShowAnswer.FlatStyle = FlatStyle.Flat;
            btnShowAnswer.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            btnShowAnswer.ForeColor = Color.MistyRose;
            btnShowAnswer.Image = (Image)resources.GetObject("btnShowAnswer.Image");
            btnShowAnswer.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowAnswer.Location = new Point(0, 461);
            btnShowAnswer.Margin = new Padding(3, 2, 3, 2);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Padding = new Padding(18, 0, 0, 0);
            btnShowAnswer.Size = new Size(276, 53);
            btnShowAnswer.TabIndex = 9;
            btnShowAnswer.Text = "Show Answers";
            btnShowAnswer.TextAlign = ContentAlignment.MiddleLeft;
            btnShowAnswer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShowAnswer.UseVisualStyleBackColor = true;
            btnShowAnswer.Click += btnShowAnswer_Click;
            // 
            // btnExamAttempt
            // 
            btnExamAttempt.Dock = DockStyle.Top;
            btnExamAttempt.FlatAppearance.BorderSize = 0;
            btnExamAttempt.FlatStyle = FlatStyle.Flat;
            btnExamAttempt.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            btnExamAttempt.ForeColor = Color.MistyRose;
            btnExamAttempt.Image = Properties.Resources.login__2_;
            btnExamAttempt.ImageAlign = ContentAlignment.MiddleLeft;
            btnExamAttempt.Location = new Point(0, 408);
            btnExamAttempt.Margin = new Padding(3, 2, 3, 2);
            btnExamAttempt.Name = "btnExamAttempt";
            btnExamAttempt.Padding = new Padding(18, 0, 0, 0);
            btnExamAttempt.Size = new Size(276, 53);
            btnExamAttempt.TabIndex = 9;
            btnExamAttempt.Text = "Exam Attempt";
            btnExamAttempt.TextAlign = ContentAlignment.MiddleLeft;
            btnExamAttempt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExamAttempt.UseVisualStyleBackColor = true;
            btnExamAttempt.Click += btnExamAttempt_Click;
            // 
            // btnAddExam
            // 
            btnAddExam.Dock = DockStyle.Top;
            btnAddExam.FlatAppearance.BorderSize = 0;
            btnAddExam.FlatStyle = FlatStyle.Flat;
            btnAddExam.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            btnAddExam.ForeColor = Color.MistyRose;
            btnAddExam.Image = Properties.Resources.icons8_add_50;
            btnAddExam.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddExam.Location = new Point(0, 357);
            btnAddExam.Margin = new Padding(3, 2, 3, 2);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Padding = new Padding(18, 0, 0, 0);
            btnAddExam.Size = new Size(276, 51);
            btnAddExam.TabIndex = 6;
            btnAddExam.Text = "Add Exam";
            btnAddExam.TextAlign = ContentAlignment.MiddleLeft;
            btnAddExam.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddExam.UseVisualStyleBackColor = true;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // btnQuesTF
            // 
            btnQuesTF.Dock = DockStyle.Top;
            btnQuesTF.FlatAppearance.BorderSize = 0;
            btnQuesTF.FlatStyle = FlatStyle.Flat;
            btnQuesTF.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            btnQuesTF.ForeColor = Color.MistyRose;
            btnQuesTF.Image = Properties.Resources.edit__2_;
            btnQuesTF.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuesTF.Location = new Point(0, 306);
            btnQuesTF.Margin = new Padding(3, 2, 3, 2);
            btnQuesTF.Name = "btnQuesTF";
            btnQuesTF.Padding = new Padding(18, 0, 0, 0);
            btnQuesTF.Size = new Size(276, 51);
            btnQuesTF.TabIndex = 4;
            btnQuesTF.Text = "Question T or F";
            btnQuesTF.TextAlign = ContentAlignment.MiddleLeft;
            btnQuesTF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuesTF.UseVisualStyleBackColor = true;
            btnQuesTF.Click += btnAddQuesTF_Click;
            // 
            // btnQuesOne
            // 
            btnQuesOne.Dock = DockStyle.Top;
            btnQuesOne.FlatAppearance.BorderSize = 0;
            btnQuesOne.FlatStyle = FlatStyle.Flat;
            btnQuesOne.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            btnQuesOne.ForeColor = Color.MistyRose;
            btnQuesOne.Image = Properties.Resources.option;
            btnQuesOne.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuesOne.Location = new Point(0, 255);
            btnQuesOne.Margin = new Padding(3, 2, 3, 2);
            btnQuesOne.Name = "btnQuesOne";
            btnQuesOne.Padding = new Padding(18, 0, 0, 0);
            btnQuesOne.Size = new Size(276, 51);
            btnQuesOne.TabIndex = 3;
            btnQuesOne.Text = "Question Choose One";
            btnQuesOne.TextAlign = ContentAlignment.MiddleLeft;
            btnQuesOne.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuesOne.UseVisualStyleBackColor = true;
            btnQuesOne.Click += btnAddQuesOne_Click;
            // 
            // btnQuesAll
            // 
            btnQuesAll.Dock = DockStyle.Top;
            btnQuesAll.FlatAppearance.BorderSize = 0;
            btnQuesAll.FlatStyle = FlatStyle.Flat;
            btnQuesAll.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuesAll.ForeColor = Color.MistyRose;
            btnQuesAll.Image = Properties.Resources.edit__2_;
            btnQuesAll.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuesAll.Location = new Point(0, 195);
            btnQuesAll.Margin = new Padding(3, 2, 3, 2);
            btnQuesAll.Name = "btnQuesAll";
            btnQuesAll.Padding = new Padding(18, 0, 0, 0);
            btnQuesAll.Size = new Size(276, 60);
            btnQuesAll.TabIndex = 2;
            btnQuesAll.Text = "Question Choose All";
            btnQuesAll.TextAlign = ContentAlignment.MiddleLeft;
            btnQuesAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuesAll.UseVisualStyleBackColor = true;
            btnQuesAll.Click += btnAddQuesAll_Click;
            // 
            // btnAddSub
            // 
            btnAddSub.Dock = DockStyle.Top;
            btnAddSub.FlatAppearance.BorderSize = 0;
            btnAddSub.FlatStyle = FlatStyle.Flat;
            btnAddSub.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            btnAddSub.ForeColor = Color.MistyRose;
            btnAddSub.Image = (Image)resources.GetObject("btnAddSub.Image");
            btnAddSub.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddSub.Location = new Point(0, 142);
            btnAddSub.Margin = new Padding(3, 2, 3, 2);
            btnAddSub.Name = "btnAddSub";
            btnAddSub.Padding = new Padding(18, 0, 0, 0);
            btnAddSub.Size = new Size(276, 53);
            btnAddSub.TabIndex = 1;
            btnAddSub.Text = "Add Subject";
            btnAddSub.TextAlign = ContentAlignment.MiddleLeft;
            btnAddSub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddSub.UseVisualStyleBackColor = true;
            btnAddSub.Click += btnAddSub_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 59);
            panelLogo.Controls.Add(LName);
            panelLogo.Controls.Add(profile);
            panelLogo.Controls.Add(button1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ImeMode = ImeMode.On;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(276, 142);
            panelLogo.TabIndex = 0;
            // 
            // LName
            // 
            LName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LName.AutoSize = true;
            LName.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LName.ForeColor = SystemColors.ControlLight;
            LName.Location = new Point(89, 11);
            LName.Name = "LName";
            LName.Size = new Size(75, 28);
            LName.TabIndex = 2;
            LName.Text = "Name";
            // 
            // profile
            // 
            profile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profile.BackColor = Color.White;
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.Location = new Point(89, 53);
            profile.Margin = new Padding(3, 2, 3, 2);
            profile.Name = "profile";
            profile.Size = new Size(97, 85);
            profile.TabIndex = 1;
            profile.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(347, -6);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(bntMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(LTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(276, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(797, 65);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseChildForm.ForeColor = Color.White;
            btnCloseChildForm.Location = new Point(29, 20);
            btnCloseChildForm.Margin = new Padding(3, 2, 3, 2);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(26, 39);
            btnCloseChildForm.TabIndex = 4;
            btnCloseChildForm.Text = "x";
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // bntMinimize
            // 
            bntMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntMinimize.FlatAppearance.BorderSize = 0;
            bntMinimize.FlatStyle = FlatStyle.Flat;
            bntMinimize.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntMinimize.ForeColor = Color.White;
            bntMinimize.Location = new Point(683, 2);
            bntMinimize.Margin = new Padding(3, 2, 3, 2);
            bntMinimize.Name = "bntMinimize";
            bntMinimize.Size = new Size(26, 46);
            bntMinimize.TabIndex = 3;
            bntMinimize.Text = "o";
            bntMinimize.UseVisualStyleBackColor = true;
            bntMinimize.Click += bntMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(714, 2);
            btnMaximize.Margin = new Padding(3, 2, 3, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(26, 46);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "o";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click_1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(746, 2);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 46);
            btnClose.TabIndex = 1;
            btnClose.Text = "o";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // LTitle
            // 
            LTitle.Anchor = AnchorStyles.None;
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Cambria", 18F, FontStyle.Bold);
            LTitle.ForeColor = SystemColors.ButtonFace;
            LTitle.Location = new Point(366, 20);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(77, 28);
            LTitle.TabIndex = 0;
            LTitle.Text = "Home";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(276, 65);
            panelDesktopPane.Margin = new Padding(3, 2, 3, 2);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(797, 579);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 644);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 479);
            Name = "FormBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBaseTeacher";
            Load += FormBase_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnAddSub;
        private Panel panelLogo;
        private Button btnLogout;
        private Button btnQuesTF;
        private Button btnQuesOne;
        private Button btnQuesAll;
        private Panel panelTitleBar;
        private Label LTitle;
        private Button profile;
        private Button button1;
        private Label LName;
        private Panel panelDesktopPane;
        private Button btnAddExam;
        private Button btnClose;
        private Button bntMinimize;
        private Button btnMaximize;
        private Button btnCloseChildForm;
        private Button btnAddUser;

        private Button btnExamAttempt;
        

        private Button btnShowAnswer;
        private Button btnUpdateMode;
    }
}