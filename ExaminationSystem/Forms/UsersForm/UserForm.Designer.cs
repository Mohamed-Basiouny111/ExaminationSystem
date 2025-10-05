namespace ExaminationSystem.Forms.UsersForm
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            txtPassword = new TextBox();
            label3 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            txtUserName = new TextBox();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvUser = new DataGridView();
            Delete = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            PasswordHash = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnSearch = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtSearch = new TextBox();
            label1 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnPrev = new Button();
            btnNext = new Button();
            btnRef = new Button();
            btnDSave = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            cbxUserType = new ComboBox();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtFullName = new TextBox();
            lblName = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 791);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.44165F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4235144F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.11378F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.2111244F));
            tableLayoutPanel1.Size = new Size(950, 791);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(txtPassword, 0, 1);
            tableLayoutPanel9.Controls.Add(label3, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(478, 93);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 41.97531F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 58.02469F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(469, 115);
            tableLayoutPanel9.TabIndex = 60;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Calibri", 16F, FontStyle.Bold);
            txtPassword.Location = new Point(40, 51);
            txtPassword.Margin = new Padding(40, 3, 20, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(409, 40);
            txtPassword.TabIndex = 11;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // label3
            // 
            label3.AccessibleName = "";
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 16F, FontStyle.Bold);
            label3.Location = new Point(173, 5);
            label3.Margin = new Padding(3, 5, 3, 3);
            label3.Name = "label3";
            label3.Size = new Size(122, 33);
            label3.TabIndex = 10;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(txtUserName, 0, 1);
            tableLayoutPanel8.Controls.Add(label2, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 93);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 41.97531F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 58.02469F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(469, 115);
            tableLayoutPanel8.TabIndex = 59;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Font = new Font("Calibri", 16F, FontStyle.Bold);
            txtUserName.Location = new Point(20, 51);
            txtUserName.Margin = new Padding(20, 3, 40, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(409, 40);
            txtUserName.TabIndex = 13;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // label2
            // 
            label2.AccessibleName = "Employee Name";
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold);
            label2.Location = new Point(164, 5);
            label2.Margin = new Padding(3, 5, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(141, 33);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvUser, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 293);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.20202F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7474747F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 65.05051F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(944, 495);
            tableLayoutPanel4.TabIndex = 56;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToOrderColumns = true;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.Fixed3D;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 18F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Delete, Edit, id, FullName, PasswordHash, Role });
            dgvUser.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 18F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = ".........";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.GridColor = Color.Black;
            dgvUser.Location = new Point(3, 176);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 18F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUser.RowHeadersWidth = 30;
            dgvUser.Size = new Size(938, 316);
            dgvUser.TabIndex = 120;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Delete.Frozen = true;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.delete__5_;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            Delete.ToolTipText = "Delete This Product";
            Delete.Width = 104;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.edit__2_1;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            Edit.Width = 71;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.FillWeight = 65.17767F;
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.ToolTipText = "Full Name";
            // 
            // PasswordHash
            // 
            PasswordHash.DataPropertyName = "PasswordHash";
            PasswordHash.HeaderText = "PasswordHash";
            PasswordHash.MinimumWidth = 6;
            PasswordHash.Name = "PasswordHash";
            PasswordHash.ReadOnly = true;
            PasswordHash.Visible = false;
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.02752F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.97248F));
            tableLayoutPanel5.Controls.Add(btnSearch, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(50, 0);
            tableLayoutPanel5.Margin = new Padding(50, 0, 50, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel5.Size = new Size(844, 100);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleName = "Search";
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.BackColor = Color.FromArgb(255, 249, 245);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnSearch.FlatAppearance.BorderSize = 10;
            btnSearch.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnSearch.Image = Properties.Resources.magnifying_glass__1_;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(626, 15);
            btnSearch.Margin = new Padding(10, 15, 3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(154, 82);
            btnSearch.TabIndex = 56;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(txtSearch, 0, 1);
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Margin = new Padding(3, 3, 3, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 44.44F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 55.56F));
            tableLayoutPanel6.Size = new Size(610, 97);
            tableLayoutPanel6.TabIndex = 55;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Calibri", 16F, FontStyle.Bold);
            txtSearch.Location = new Point(10, 46);
            txtSearch.Margin = new Padding(10, 3, 10, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(590, 40);
            txtSearch.TabIndex = 2;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AccessibleName = "Employee Name";
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold);
            label1.Location = new Point(176, 5);
            label1.Margin = new Padding(3, 5, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(258, 33);
            label1.TabIndex = 1;
            label1.Text = "Search By Name Or Id";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(btnPrev, 0, 0);
            tableLayoutPanel7.Controls.Add(btnNext, 0, 0);
            tableLayoutPanel7.Controls.Add(btnRef, 2, 0);
            tableLayoutPanel7.Controls.Add(btnDSave, 3, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 100);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(944, 73);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // btnPrev
            // 
            btnPrev.AccessibleName = "Previous";
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrev.BackColor = Color.FromArgb(255, 249, 245);
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnPrev.FlatAppearance.BorderSize = 10;
            btnPrev.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnPrev.Image = Properties.Resources.fast_forward_double_right_arrows_symbol__3_;
            btnPrev.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrev.Location = new Point(246, 5);
            btnPrev.Margin = new Padding(10, 3, 3, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(164, 65);
            btnPrev.TabIndex = 55;
            btnPrev.Text = "Previous";
            btnPrev.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.AccessibleName = "Next";
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(255, 249, 245);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnNext.FlatAppearance.BorderSize = 10;
            btnNext.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnNext.Image = Properties.Resources.fast_forward_double_right_arrows_symbol__2___1_1;
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(79, 5);
            btnNext.Margin = new Padding(10, 3, 10, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(147, 65);
            btnNext.TabIndex = 54;
            btnNext.Text = "Next";
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnRef
            // 
            btnRef.AccessibleName = "Refresh";
            btnRef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRef.BackColor = Color.FromArgb(255, 249, 245);
            btnRef.Cursor = Cursors.Hand;
            btnRef.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnRef.FlatAppearance.BorderSize = 10;
            btnRef.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnRef.Image = Properties.Resources.refresh_page_option__1_1;
            btnRef.ImageAlign = ContentAlignment.MiddleLeft;
            btnRef.Location = new Point(472, 5);
            btnRef.Margin = new Padding(0, 3, 3, 3);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(181, 65);
            btnRef.TabIndex = 56;
            btnRef.Text = "Refresh";
            btnRef.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRef.UseVisualStyleBackColor = false;
            btnRef.Click += btnRef_Click;
            // 
            // btnDSave
            // 
            btnDSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDSave.BackgroundImage = Properties.Resources.download;
            btnDSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnDSave.Cursor = Cursors.Hand;
            btnDSave.FlatAppearance.BorderSize = 0;
            btnDSave.FlatStyle = FlatStyle.Popup;
            btnDSave.Location = new Point(883, 5);
            btnDSave.Margin = new Padding(10, 3, 3, 3);
            btnDSave.Name = "btnDSave";
            btnDSave.Size = new Size(58, 65);
            btnDSave.TabIndex = 57;
            btnDSave.UseVisualStyleBackColor = true;
            btnDSave.Click += btnDSave_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(cbxUserType, 0, 1);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(478, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 41.97531F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 58.02469F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(469, 84);
            tableLayoutPanel3.TabIndex = 55;
            // 
            // cbxUserType
            // 
            cbxUserType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbxUserType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxUserType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUserType.Font = new Font("Calibri", 16F, FontStyle.Bold);
            cbxUserType.FormattingEnabled = true;
            cbxUserType.Items.AddRange(new object[] { "Student", "Teacher", "Admin" });
            cbxUserType.Location = new Point(40, 38);
            cbxUserType.Margin = new Padding(40, 3, 20, 3);
            cbxUserType.Name = "cbxUserType";
            cbxUserType.Size = new Size(409, 41);
            cbxUserType.TabIndex = 12;
            cbxUserType.KeyDown += cbxUserType_KeyDown;
            // 
            // label5
            // 
            label5.AccessibleName = "Kind";
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 16F, FontStyle.Bold);
            label5.Location = new Point(172, 5);
            label5.Margin = new Padding(3, 5, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(125, 27);
            label5.TabIndex = 10;
            label5.Text = "User Role";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(txtFullName, 0, 1);
            tableLayoutPanel2.Controls.Add(lblName, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 41.97531F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 58.02469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(469, 84);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.Font = new Font("Calibri", 16F, FontStyle.Bold);
            txtFullName.Location = new Point(20, 38);
            txtFullName.Margin = new Padding(20, 3, 40, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(409, 40);
            txtFullName.TabIndex = 12;
            txtFullName.TextAlign = HorizontalAlignment.Center;
            txtFullName.KeyDown += txtFullName_KeyDown;
            // 
            // lblName
            // 
            lblName.AccessibleName = "Employee Name";
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Calibri", 16F, FontStyle.Bold);
            lblName.Location = new Point(170, 5);
            lblName.Margin = new Padding(3, 5, 3, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(128, 27);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.AccessibleName = "Add Employee";
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.FromArgb(255, 249, 245);
            tableLayoutPanel1.SetColumnSpan(btnSave, 2);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnSave.FlatAppearance.BorderSize = 10;
            btnSave.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnSave.Image = Properties.Resources.add_user__1___1_;
            btnSave.Location = new Point(380, 221);
            btnSave.Margin = new Padding(3, 10, 3, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 64);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(950, 791);
            Controls.Add(panel1);
            Font = new Font("Calibri", 20F, FontStyle.Bold);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtSearch;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnPrev;
        private Button btnNext;
        private Button btnRef;
        private Button btnDSave;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblName;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox txtPassword;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label2;
        private TextBox txtFullName;
        private TextBox txtUserName;
        private ComboBox cbxUserType;
        private DataGridView dgvUser;
        private DataGridViewImageColumn Delete;
        private DataGridViewImageColumn Edit;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn PasswordHash;
        private DataGridViewTextBoxColumn Role;
    }
}