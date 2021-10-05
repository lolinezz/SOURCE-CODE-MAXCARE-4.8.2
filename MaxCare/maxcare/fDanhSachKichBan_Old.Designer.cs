namespace maxcare
{
	// Token: 0x020000FA RID: 250
	public partial class fDanhSachKichBan_Old : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x00150870 File Offset: 0x0014EA70
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x001508D0 File Offset: 0x0014EAD0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvKichBan = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_KichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgvHanhDong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId_HanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenHanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKichBan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanhDong)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ToolTipTitle = "Chú thích";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(771, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Quản lý kịch bản";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(771, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(742, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 77;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtgvKichBan);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(308, 559);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách kịch bản";
            // 
            // dtgvKichBan
            // 
            this.dtgvKichBan.AllowUserToAddRows = false;
            this.dtgvKichBan.AllowUserToDeleteRows = false;
            this.dtgvKichBan.AllowUserToResizeRows = false;
            this.dtgvKichBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKichBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKichBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cId_KichBan,
            this.cTenKichBan});
            this.dtgvKichBan.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgvKichBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKichBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvKichBan.Location = new System.Drawing.Point(3, 20);
            this.dtgvKichBan.MultiSelect = false;
            this.dtgvKichBan.Name = "dtgvKichBan";
            this.dtgvKichBan.RowHeadersVisible = false;
            this.dtgvKichBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKichBan.Size = new System.Drawing.Size(302, 535);
            this.dtgvKichBan.TabIndex = 76;
            this.dtgvKichBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKichBan_CellClick);
            this.dtgvKichBan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvKichBan_KeyDown);
            this.dtgvKichBan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtgvKichBan_KeyUp);
            // 
            // cStt
            // 
            this.cStt.HeaderText = "STT";
            this.cStt.Name = "cStt";
            this.cStt.Width = 35;
            // 
            // cId_KichBan
            // 
            this.cId_KichBan.HeaderText = "Column1";
            this.cId_KichBan.Name = "cId_KichBan";
            this.cId_KichBan.Visible = false;
            // 
            // cTenKichBan
            // 
            this.cTenKichBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenKichBan.HeaderText = "Tên kịch bản";
            this.cTenKichBan.Name = "cTenKichBan";
            this.cTenKichBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.nhânBảnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm kịch bản";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sửaToolStripMenuItem.Text = "Sửa tên kịch bản";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.xóaToolStripMenuItem.Text = "Xóa kịch bản";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // nhânBảnToolStripMenuItem
            // 
            this.nhânBảnToolStripMenuItem.Name = "nhânBảnToolStripMenuItem";
            this.nhânBảnToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nhânBảnToolStripMenuItem.Text = "Nhân bản";
            this.nhânBảnToolStripMenuItem.Click += new System.EventHandler(this.nhânBảnToolStripMenuItem_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(774, 37);
            this.bunifuCards1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dtgvHanhDong);
            this.groupBox2.Location = new System.Drawing.Point(338, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(427, 559);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hành động";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(382, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 38);
            this.button3.TabIndex = 78;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(382, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 38);
            this.button2.TabIndex = 78;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgvHanhDong
            // 
            this.dtgvHanhDong.AllowUserToAddRows = false;
            this.dtgvHanhDong.AllowUserToDeleteRows = false;
            this.dtgvHanhDong.AllowUserToResizeRows = false;
            this.dtgvHanhDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHanhDong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHanhDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHanhDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHanhDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cId_HanhDong,
            this.cTenHanhDong,
            this.cTheLoai});
            this.dtgvHanhDong.ContextMenuStrip = this.contextMenuStrip2;
            this.dtgvHanhDong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvHanhDong.Location = new System.Drawing.Point(6, 20);
            this.dtgvHanhDong.MultiSelect = false;
            this.dtgvHanhDong.Name = "dtgvHanhDong";
            this.dtgvHanhDong.RowHeadersVisible = false;
            this.dtgvHanhDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHanhDong.Size = new System.Drawing.Size(373, 535);
            this.dtgvHanhDong.TabIndex = 77;
            this.dtgvHanhDong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgvHanhDong_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // cId_HanhDong
            // 
            this.cId_HanhDong.HeaderText = "Column1";
            this.cId_HanhDong.Name = "cId_HanhDong";
            this.cId_HanhDong.Visible = false;
            // 
            // cTenHanhDong
            // 
            this.cTenHanhDong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenHanhDong.HeaderText = "Tên hành động";
            this.cTenHanhDong.Name = "cTenHanhDong";
            this.cTenHanhDong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cTheLoai
            // 
            this.cTheLoai.HeaderText = "Loại tương tác";
            this.cTheLoai.Name = "cTheLoai";
            this.cTheLoai.Width = 175;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(166, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem1.Text = "Thêm hành động";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem3.Text = "Sửa hành động";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem4.Text = "Xóa hành động";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem2.Text = "Nhân bản";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 607);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fDanhSachKichBan_Old
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fDanhSachKichBan_Old";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fDanhSachKichBan_Paint);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKichBan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanhDong)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000E73 RID: 3699
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000E74 RID: 3700
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000E75 RID: 3701
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000E76 RID: 3702
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000E77 RID: 3703
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000E78 RID: 3704
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000E79 RID: 3705
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000E7A RID: 3706
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000E7B RID: 3707
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000E7C RID: 3708
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000E7D RID: 3709
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000E7E RID: 3710
		public global::System.Windows.Forms.DataGridView dtgvKichBan;

		// Token: 0x04000E7F RID: 3711
		public global::System.Windows.Forms.DataGridView dtgvHanhDong;

		// Token: 0x04000E80 RID: 3712
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000E81 RID: 3713
		private global::System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;

		// Token: 0x04000E82 RID: 3714
		private global::System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;

		// Token: 0x04000E83 RID: 3715
		private global::System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;

		// Token: 0x04000E84 RID: 3716
		private global::System.Windows.Forms.ToolStripMenuItem nhânBảnToolStripMenuItem;

		// Token: 0x04000E85 RID: 3717
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000E86 RID: 3718
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000E87 RID: 3719
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

		// Token: 0x04000E88 RID: 3720
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x04000E89 RID: 3721
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

		// Token: 0x04000E8A RID: 3722
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

		// Token: 0x04000E8B RID: 3723
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x04000E8C RID: 3724
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x04000E8D RID: 3725
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId_HanhDong;

		// Token: 0x04000E8E RID: 3726
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTenHanhDong;

		// Token: 0x04000E8F RID: 3727
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTheLoai;

		// Token: 0x04000E90 RID: 3728
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000E91 RID: 3729
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x04000E92 RID: 3730
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId_KichBan;

		// Token: 0x04000E93 RID: 3731
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTenKichBan;
	}
}
