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
            btnShowResult = new Button();
            btnDeleteorView = new Button();
            btnUpdateQues = new Button();
            btnAddQues = new Button();
            panelLogo = new Panel();
            LName = new Label();
            profile = new Button();
            button1 = new Button();
            panel1 = new Panel();
            LTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnShowResult);
            panelMenu.Controls.Add(btnDeleteorView);
            panelMenu.Controls.Add(btnUpdateQues);
            panelMenu.Controls.Add(btnAddQues);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 581);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnLogout.ForeColor = Color.MistyRose;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 418);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(17, 0, 0, 0);
            btnLogout.Size = new Size(220, 60);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnShowResult
            // 
            btnShowResult.Dock = DockStyle.Top;
            btnShowResult.FlatAppearance.BorderSize = 0;
            btnShowResult.FlatStyle = FlatStyle.Flat;
            btnShowResult.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnShowResult.ForeColor = Color.MistyRose;
            btnShowResult.Image = (Image)resources.GetObject("btnShowResult.Image");
            btnShowResult.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowResult.Location = new Point(0, 358);
            btnShowResult.Name = "btnShowResult";
            btnShowResult.Padding = new Padding(17, 0, 0, 0);
            btnShowResult.Size = new Size(220, 60);
            btnShowResult.TabIndex = 4;
            btnShowResult.Text = "Show Result";
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
            btnDeleteorView.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDeleteorView.ForeColor = Color.MistyRose;
            btnDeleteorView.Image = Properties.Resources.delete__4_;
            btnDeleteorView.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteorView.Location = new Point(0, 298);
            btnDeleteorView.Name = "btnDeleteorView";
            btnDeleteorView.Padding = new Padding(17, 0, 0, 0);
            btnDeleteorView.Size = new Size(220, 60);
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
            btnUpdateQues.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnUpdateQues.ForeColor = Color.MistyRose;
            btnUpdateQues.Image = (Image)resources.GetObject("btnUpdateQues.Image");
            btnUpdateQues.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateQues.Location = new Point(0, 238);
            btnUpdateQues.Name = "btnUpdateQues";
            btnUpdateQues.Padding = new Padding(17, 0, 0, 0);
            btnUpdateQues.Size = new Size(220, 60);
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
            btnAddQues.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAddQues.ForeColor = Color.MistyRose;
            btnAddQues.Image = (Image)resources.GetObject("btnAddQues.Image");
            btnAddQues.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddQues.Location = new Point(0, 178);
            btnAddQues.Name = "btnAddQues";
            btnAddQues.Padding = new Padding(17, 0, 0, 0);
            btnAddQues.Size = new Size(220, 60);
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
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 178);
            panelLogo.TabIndex = 0;
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LName.ForeColor = SystemColors.ControlLight;
            LName.Location = new Point(59, 9);
            LName.Name = "LName";
            LName.Size = new Size(75, 31);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(210, 193, 182);
            panel1.Controls.Add(LTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 87);
            panel1.TabIndex = 1;
            // 
            // LTitle
            // 
            LTitle.Anchor = AnchorStyles.None;
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTitle.ForeColor = SystemColors.ButtonFace;
            LTitle.Location = new Point(451, 26);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(89, 32);
            LTitle.TabIndex = 0;
            LTitle.Text = "Home";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 87);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(977, 494);
            panelDesktopPane.TabIndex = 2;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 581);
            Controls.Add(panelDesktopPane);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1000, 628);
            Name = "FormBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBaseTeacher";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label LTitle;
        private Button profile;
        private Button button1;
        private Label LName;
        private Panel panelDesktopPane;
    }
}