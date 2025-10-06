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
            button2 = new Button();
            btnShowResult = new Button();
            btnDeleteorView = new Button();
            btnUpdateQues = new Button();
            btnAddQues = new Button();
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
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnShowResult);
            panelMenu.Controls.Add(btnDeleteorView);
            panelMenu.Controls.Add(btnUpdateQues);
            panelMenu.Controls.Add(btnAddQues);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(192, 565);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnLogout.ForeColor = Color.MistyRose;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 359);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(18, 0, 0, 0);
            btnLogout.Size = new Size(192, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 18F, FontStyle.Bold);
            button2.ForeColor = Color.MistyRose;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 314);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(18, 0, 0, 0);
            button2.Size = new Size(192, 45);
            button2.TabIndex = 6;
            button2.Text = "Users";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnShowResult
            // 
            btnShowResult.Dock = DockStyle.Top;
            btnShowResult.FlatAppearance.BorderSize = 0;
            btnShowResult.FlatStyle = FlatStyle.Flat;
            btnShowResult.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnShowResult.ForeColor = Color.MistyRose;
            btnShowResult.Image = (Image)resources.GetObject("btnShowResult.Image");
            btnShowResult.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowResult.Location = new Point(0, 269);
            btnShowResult.Margin = new Padding(3, 2, 3, 2);
            btnShowResult.Name = "btnShowResult";
            btnShowResult.Padding = new Padding(18, 0, 0, 0);
            btnShowResult.Size = new Size(192, 45);
            btnShowResult.TabIndex = 4;
            btnShowResult.Text = "Report";
            btnShowResult.TextAlign = ContentAlignment.MiddleLeft;
            btnShowResult.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShowResult.UseVisualStyleBackColor = true;
            btnShowResult.Click += btnShowResult_Click;
            // 
            // btnDeleteorView
            // 
            btnDeleteorView.Dock = DockStyle.Top;
            btnDeleteorView.FlatAppearance.BorderSize = 0;
            btnDeleteorView.FlatStyle = FlatStyle.Flat;
            btnDeleteorView.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnDeleteorView.ForeColor = Color.MistyRose;
            btnDeleteorView.Image = Properties.Resources.delete__4_;
            btnDeleteorView.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteorView.Location = new Point(0, 224);
            btnDeleteorView.Margin = new Padding(3, 2, 3, 2);
            btnDeleteorView.Name = "btnDeleteorView";
            btnDeleteorView.Padding = new Padding(18, 0, 0, 0);
            btnDeleteorView.Size = new Size(192, 45);
            btnDeleteorView.TabIndex = 3;
            btnDeleteorView.Text = "Delete  ";
            btnDeleteorView.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteorView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteorView.UseVisualStyleBackColor = true;
            btnDeleteorView.Click += btnDeleteorView_Click;
            // 
            // btnUpdateQues
            // 
            btnUpdateQues.Dock = DockStyle.Top;
            btnUpdateQues.FlatAppearance.BorderSize = 0;
            btnUpdateQues.FlatStyle = FlatStyle.Flat;
            btnUpdateQues.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnUpdateQues.ForeColor = Color.MistyRose;
            btnUpdateQues.Image = (Image)resources.GetObject("btnUpdateQues.Image");
            btnUpdateQues.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateQues.Location = new Point(0, 179);
            btnUpdateQues.Margin = new Padding(3, 2, 3, 2);
            btnUpdateQues.Name = "btnUpdateQues";
            btnUpdateQues.Padding = new Padding(18, 0, 0, 0);
            btnUpdateQues.Size = new Size(192, 45);
            btnUpdateQues.TabIndex = 2;
            btnUpdateQues.Text = "Update ";
            btnUpdateQues.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateQues.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateQues.UseVisualStyleBackColor = true;
            btnUpdateQues.Click += btnUpdateQues_Click;
            // 
            // btnAddQues
            // 
            btnAddQues.Dock = DockStyle.Top;
            btnAddQues.FlatAppearance.BorderSize = 0;
            btnAddQues.FlatStyle = FlatStyle.Flat;
            btnAddQues.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnAddQues.ForeColor = Color.MistyRose;
            btnAddQues.Image = (Image)resources.GetObject("btnAddQues.Image");
            btnAddQues.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddQues.Location = new Point(0, 134);
            btnAddQues.Margin = new Padding(3, 2, 3, 2);
            btnAddQues.Name = "btnAddQues";
            btnAddQues.Padding = new Padding(18, 0, 0, 0);
            btnAddQues.Size = new Size(192, 45);
            btnAddQues.TabIndex = 1;
            btnAddQues.Text = "Add Question";
            btnAddQues.TextAlign = ContentAlignment.MiddleLeft;
            btnAddQues.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddQues.UseVisualStyleBackColor = true;
            btnAddQues.Click += btnAddQues_Click;
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
            panelLogo.Size = new Size(192, 134);
            panelLogo.TabIndex = 0;
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LName.ForeColor = SystemColors.ControlLight;
            LName.Location = new Point(52, 7);
            LName.Name = "LName";
            LName.Size = new Size(75, 28);
            LName.TabIndex = 2;
            LName.Text = "Name";
            // 
            // profile
            // 
            profile.BackColor = Color.White;
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.Location = new Point(37, 37);
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
            panelTitleBar.Location = new Point(192, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1017, 65);
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
            bntMinimize.Location = new Point(903, 2);
            bntMinimize.Margin = new Padding(3, 2, 3, 2);
            bntMinimize.Name = "bntMinimize";
            bntMinimize.Size = new Size(26, 28);
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
            btnMaximize.Location = new Point(934, 2);
            btnMaximize.Margin = new Padding(3, 2, 3, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(26, 28);
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
            btnClose.Location = new Point(966, 2);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 28);
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
            LTitle.Location = new Point(476, 20);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(77, 28);
            LTitle.TabIndex = 0;
            LTitle.Text = "Home";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(192, 65);
            panelDesktopPane.Margin = new Padding(3, 2, 3, 2);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1017, 500);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 565);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 481);
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
        private Button btnAddQues;
        private Panel panelLogo;
        private Button btnLogout;
        private Button btnShowResult;
        private Button btnDeleteorView;
        private Button btnUpdateQues;
        private Panel panelTitleBar;
        private Label LTitle;
        private Button profile;
        private Button button1;
        private Label LName;
        private Panel panelDesktopPane;
        private Button button2;
        private Button btnClose;
        private Button bntMinimize;
        private Button btnMaximize;
        private Button btnCloseChildForm;
    }
}