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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtpass = new TextBox();
            btnLogin = new Button();
            btnShowPass = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 249, 245);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cambria", 21F, FontStyle.Bold);
            label1.Location = new Point(470, 53);
            label1.Name = "label1";
            label1.Size = new Size(448, 43);
            label1.TabIndex = 0;
            label1.Text = "Exam Management System";
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 732);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 732);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 249, 245);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 375);
            label2.Name = "label2";
            label2.Size = new Size(150, 38);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 249, 245);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(614, 201);
            label3.Name = "label3";
            label3.Size = new Size(160, 38);
            label3.TabIndex = 13;
            label3.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Font = new Font("Cambria", 20F, FontStyle.Bold);
            txtUserName.Location = new Point(514, 253);
            txtUserName.Margin = new Padding(23, 4, 46, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(354, 47);
            txtUserName.TabIndex = 14;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // txtpass
            // 
            txtpass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Cursor = Cursors.IBeam;
            txtpass.Font = new Font("Cambria", 20F, FontStyle.Bold);
            txtpass.Location = new Point(514, 428);
            txtpass.Margin = new Padding(23, 4, 46, 4);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(354, 47);
            txtpass.TabIndex = 15;
            txtpass.TextAlign = HorizontalAlignment.Center;
            txtpass.UseSystemPasswordChar = true;
            txtpass.KeyDown += txtpass_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.AccessibleName = "";
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.FromArgb(255, 249, 245);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(214, 183, 162);
            btnLogin.FlatAppearance.BorderSize = 3;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 183, 162);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 183, 162);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnLogin.Location = new Point(590, 548);
            btnLogin.Margin = new Padding(3, 11, 3, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 103);
            btnLogin.TabIndex = 53;
            btnLogin.Text = "Sign In";
            btnLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.Transparent;
            btnShowPass.Cursor = Cursors.Hand;
            btnShowPass.FlatAppearance.BorderSize = 0;
            btnShowPass.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnShowPass.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPass.ForeColor = Color.Black;
            btnShowPass.Location = new Point(445, 420);
            btnShowPass.Margin = new Padding(3, 4, 3, 4);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Padding = new Padding(0, 4, 3, 4);
            btnShowPass.Size = new Size(70, 63);
            btnShowPass.TabIndex = 28;
            btnShowPass.TextAlign = ContentAlignment.MiddleRight;
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(889, 732);
            Controls.Add(btnLogin);
            Controls.Add(txtpass);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(btnShowPass);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MaximumSize = new Size(911, 783);
            MinimizeBox = false;
            MinimumSize = new Size(911, 783);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtpass;
        private Button btnLogin;
        private Button btnShowPass;
        private PictureBox pictureBox1;
    }
}