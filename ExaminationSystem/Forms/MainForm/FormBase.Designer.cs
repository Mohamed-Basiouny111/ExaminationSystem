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
            btnAddUser = new Button();
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
            panelMenu.Controls.Add(btnAddUser);
            panelMenu.Controls.Add(btnAddExam);
            panelMenu.Controls.Add(btnQuesTF);
            panelMenu.Controls.Add(btnQuesOne);
            panelMenu.Controls.Add(btnQuesAll);
            panelMenu.Controls.Add(btnAddSub);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(316, 753);
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
            btnLogout.Location = new Point(0, 554);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(21, 0, 0, 0);
            btnLogout.Size = new Size(316, 60);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
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
            btnAddUser.Location = new Point(0, 494);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Padding = new Padding(21, 0, 0, 0);
            btnAddUser.Size = new Size(316, 60);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Users";
            btnAddUser.TextAlign = ContentAlignment.MiddleLeft;
            btnAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
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
            btnAddExam.Location = new Point(0, 434);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Padding = new Padding(21, 0, 0, 0);
            btnAddExam.Size = new Size(316, 60);
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
            btnQuesTF.Location = new Point(0, 374);
            btnQuesTF.Name = "btnQuesTF";
            btnQuesTF.Padding = new Padding(21, 0, 0, 0);
            btnQuesTF.Size = new Size(316, 60);
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
            btnQuesOne.Location = new Point(0, 314);
            btnQuesOne.Name = "btnQuesOne";
            btnQuesOne.Padding = new Padding(21, 0, 0, 0);
            btnQuesOne.Size = new Size(316, 60);
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
            btnQuesAll.Location = new Point(0, 242);
            btnQuesAll.Name = "btnQuesAll";
            btnQuesAll.Padding = new Padding(21, 0, 0, 0);
            btnQuesAll.Size = new Size(316, 72);
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
            btnAddSub.Location = new Point(0, 179);
            btnAddSub.Name = "btnAddSub";
            btnAddSub.Padding = new Padding(21, 0, 0, 0);
            btnAddSub.Size = new Size(316, 63);
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
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(316, 179);
            panelLogo.TabIndex = 0;
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LName.ForeColor = SystemColors.ControlLight;
            LName.Location = new Point(59, 9);
            LName.Name = "LName";
            LName.Size = new Size(94, 36);
            LName.TabIndex = 2;
            LName.Text = "Name";
            // 
            // profile
            // 
            profile.BackColor = Color.White;
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.Location = new Point(42, 49);
            profile.Name = "profile";
            profile.Size = new Size(111, 113);
            profile.TabIndex = 1;
            profile.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(397, -8);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
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
            panelTitleBar.Location = new Point(316, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1066, 87);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseChildForm.ForeColor = Color.White;
            btnCloseChildForm.Location = new Point(33, 27);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(30, 52);
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
            bntMinimize.Location = new Point(936, 3);
            bntMinimize.Name = "bntMinimize";
            bntMinimize.Size = new Size(30, 37);
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
            btnMaximize.Location = new Point(971, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 37);
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
            btnClose.Location = new Point(1008, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 37);
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
            LTitle.Location = new Point(496, 27);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(97, 36);
            LTitle.TabIndex = 0;
            LTitle.Text = "Home";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(316, 87);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1066, 666);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1000, 626);
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
    }
}