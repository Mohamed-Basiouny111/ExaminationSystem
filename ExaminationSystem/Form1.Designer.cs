namespace ExaminationSystem
{
    partial class FormName
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
            txtSearch = new TextBox();
            label1 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnPrev = new Button();
            btnNext = new Button();
            btnRef = new Button();
            btnDSave = new Button();
            btnSearch = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtPrice = new TextBox();
            label5 = new Label();
            cbxExTy = new ComboBox();
            btnSave = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            label2 = new Label();
            txtDes = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            id = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colDes = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblName = new Label();
            panel1 = new Panel();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Calibri", 20F, FontStyle.Bold);
            txtSearch.Location = new Point(10, 54);
            txtSearch.Margin = new Padding(10, 3, 10, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(553, 48);
            txtSearch.TabIndex = 2;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AccessibleName = "Employee Name";
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 5);
            label1.Margin = new Padding(3, 5, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 1;
            label1.Text = "كود أو بنــد المصروفــات ";
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
            tableLayoutPanel7.Location = new Point(0, 120);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(894, 77);
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
            btnPrev.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrev.Location = new Point(480, 9);
            btnPrev.Margin = new Padding(10, 3, 3, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(181, 65);
            btnPrev.TabIndex = 55;
            btnPrev.Text = "السابق";
            btnPrev.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.AccessibleName = "Next";
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(255, 249, 245);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnNext.FlatAppearance.BorderSize = 10;
            btnNext.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ImageAlign = ContentAlignment.MiddleLeft;
            btnNext.Location = new Point(681, 9);
            btnNext.Margin = new Padding(10, 3, 10, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(181, 65);
            btnNext.TabIndex = 54;
            btnNext.Text = "التالى";
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnRef
            // 
            btnRef.AccessibleName = "Refresh";
            btnRef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRef.BackColor = Color.FromArgb(255, 249, 245);
            btnRef.Cursor = Cursors.Hand;
            btnRef.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnRef.FlatAppearance.BorderSize = 10;
            btnRef.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRef.ImageAlign = ContentAlignment.MiddleLeft;
            btnRef.Location = new Point(267, 9);
            btnRef.Margin = new Padding(0, 3, 3, 3);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(181, 65);
            btnRef.TabIndex = 56;
            btnRef.Text = "تحديث ";
            btnRef.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRef.UseVisualStyleBackColor = false;
            // 
            // btnDSave
            // 
            btnDSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnDSave.Cursor = Cursors.Hand;
            btnDSave.FlatAppearance.BorderSize = 0;
            btnDSave.FlatStyle = FlatStyle.Popup;
            btnDSave.Location = new Point(3, 9);
            btnDSave.Margin = new Padding(10, 3, 3, 3);
            btnDSave.Name = "btnDSave";
            btnDSave.Size = new Size(58, 65);
            btnDSave.TabIndex = 57;
            btnDSave.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleName = "Search";
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.BackColor = Color.FromArgb(255, 249, 245);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 249, 245);
            btnSearch.FlatAppearance.BorderSize = 10;
            btnSearch.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(51, 15);
            btnSearch.Margin = new Padding(10, 15, 3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(154, 102);
            btnSearch.TabIndex = 56;
            btnSearch.Text = "بحـــــث";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(txtPrice, 0, 1);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 41.97531F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 58.02469F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(444, 94);
            tableLayoutPanel3.TabIndex = 55;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(20, 42);
            txtPrice.Margin = new Padding(40, 3, 20, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(384, 44);
            txtPrice.TabIndex = 11;
            txtPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AccessibleName = "Kind";
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 17F, FontStyle.Bold);
            label5.Location = new Point(175, 5);
            label5.Margin = new Padding(3, 5, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(95, 31);
            label5.TabIndex = 10;
            label5.Text = "الــقـيمــــــة";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxExTy
            // 
            cbxExTy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbxExTy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxExTy.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxExTy.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxExTy.FormattingEnabled = true;
            cbxExTy.Location = new Point(40, 42);
            cbxExTy.Margin = new Padding(20, 3, 40, 3);
            cbxExTy.Name = "cbxExTy";
            cbxExTy.RightToLeft = RightToLeft.Yes;
            cbxExTy.Size = new Size(384, 45);
            cbxExTy.TabIndex = 11;
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
            btnSave.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(311, 217);
            btnSave.Margin = new Padding(3, 10, 3, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(279, 70);
            btnSave.TabIndex = 52;
            btnSave.Text = "حفـــــــــظ ";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel10, 2);
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(label2, 0, 0);
            tableLayoutPanel10.Controls.Add(txtDes, 0, 1);
            tableLayoutPanel10.Location = new Point(168, 103);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 44.66019F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 55.33981F));
            tableLayoutPanel10.Size = new Size(565, 101);
            tableLayoutPanel10.TabIndex = 54;
            // 
            // label2
            // 
            label2.AccessibleName = "Notes";
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 17F, FontStyle.Bold);
            label2.Location = new Point(230, 10);
            label2.Margin = new Padding(3, 10, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 62;
            label2.Text = "مـلاحظــــة";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDes
            // 
            txtDes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDes.BackColor = Color.White;
            txtDes.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDes.Location = new Point(20, 48);
            txtDes.Margin = new Padding(20, 3, 20, 3);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.ScrollBars = ScrollBars.Both;
            txtDes.Size = new Size(525, 50);
            txtDes.TabIndex = 61;
            txtDes.Text = "لا يوجــد";
            txtDes.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(txtSearch, 0, 1);
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(218, 3);
            tableLayoutPanel6.Margin = new Padding(3, 3, 3, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 44.44F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 55.56F));
            tableLayoutPanel6.Size = new Size(573, 117);
            tableLayoutPanel6.TabIndex = 55;
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
            tableLayoutPanel5.Size = new Size(794, 120);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 308);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 21.35231F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 13.68421F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 65.08772F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(894, 566);
            tableLayoutPanel4.TabIndex = 56;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 20F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete, Edit, id, colPrice, colDes, colDate });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 20F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = ".........";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(3, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(888, 363);
            dataGridView1.TabIndex = 119;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Delete.Frozen = true;
            Delete.HeaderText = "حــذف";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            Delete.ToolTipText = "Delete This Product";
            Delete.Width = 97;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Edit.HeaderText = "تعديل";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            Edit.Width = 95;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.FillWeight = 65.17767F;
            id.HeaderText = "الكـــود";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colPrice.DataPropertyName = "UnitPrice";
            colPrice.HeaderText = "الــقـيمــــــة";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.ToolTipText = "الــقـيمــــــة";
            colPrice.Width = 137;
            // 
            // colDes
            // 
            colDes.DataPropertyName = "Description";
            colDes.HeaderText = "مـلاحظــــة";
            colDes.MinimumWidth = 6;
            colDes.Name = "colDes";
            colDes.ReadOnly = true;
            colDes.ToolTipText = "مـلاحظــــة";
            // 
            // colDate
            // 
            colDate.DataPropertyName = "CreatedDate";
            colDate.HeaderText = "التاريــــخ";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.ToolTipText = "التاريــــخ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.44165F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.27477F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.26126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.87415F));
            tableLayoutPanel1.Size = new Size(900, 877);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblName, 0, 0);
            tableLayoutPanel2.Controls.Add(cbxExTy, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(453, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 41.97531F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 58.02469F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(444, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AccessibleName = "Employee Name";
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Calibri", 17F, FontStyle.Bold);
            lblName.Location = new Point(135, 5);
            lblName.Margin = new Padding(3, 5, 3, 3);
            lblName.Name = "lblName";
            lblName.Size = new Size(174, 31);
            lblName.TabIndex = 1;
            lblName.Text = "بنــد المصروفــات";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 877);
            panel1.TabIndex = 4;
            // 
            // FormName
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 245);
            ClientSize = new Size(900, 877);
            Controls.Add(panel1);
            Font = new Font("Calibri", 20F, FontStyle.Bold);
            Margin = new Padding(7, 8, 7, 8);
            MinimumSize = new Size(916, 916);
            Name = "FormName";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سجــل المصروفــات";
            Load += FormName_Load_1;
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxExTy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewImageColumn Delete;
        private DataGridViewImageColumn Edit;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colDes;
        private DataGridViewTextBoxColumn colDate;
    }

}
