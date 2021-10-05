namespace maxcare
{
	// Token: 0x020000E7 RID: 231
	public partial class fChonKichBan : global::System.Windows.Forms.Form
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x00126BF4 File Offset: 0x00124DF4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00126C54 File Offset: 0x00124E54
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fChonKichBan));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.dtgvKichBan = new global::System.Windows.Forms.DataGridView();
			this.cStt = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cIdKichBan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTenKichBan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.lblCountAcc = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.dtgvKichBanChoose = new global::System.Windows.Forms.DataGridView();
			this.cSTTChoose = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cIdKichBanChoose = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTenKichBanChoose = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvKichBan).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvKichBanChoose).BeginInit();
			base.SuspendLayout();
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			this.toolTip1.ToolTipTitle = "Chú thích";
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(696, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Chọn danh sách kịch bản chạy";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pnlHeader;
			this.bunifuDragControl2.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(696, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(667, 2);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(30, 30);
			this.button1.TabIndex = 77;
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.groupBox1.BackColor = global::System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dtgvKichBan);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 41);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new global::System.Drawing.Size(308, 302);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách kịch bản";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(3, 281);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(193, 16);
			this.label2.TabIndex = 81;
			this.label2.Text = "(Click đúp vào kịch bản để chọn)";
			this.dtgvKichBan.AllowUserToAddRows = false;
			this.dtgvKichBan.AllowUserToDeleteRows = false;
			this.dtgvKichBan.AllowUserToResizeRows = false;
			this.dtgvKichBan.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dtgvKichBan.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvKichBan.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cStt,
				this.cIdKichBan,
				this.cTenKichBan
			});
			this.dtgvKichBan.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtgvKichBan.Location = new global::System.Drawing.Point(6, 20);
			this.dtgvKichBan.MultiSelect = false;
			this.dtgvKichBan.Name = "dtgvKichBan";
			this.dtgvKichBan.RowHeadersVisible = false;
			this.dtgvKichBan.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvKichBan.Size = new global::System.Drawing.Size(296, 258);
			this.dtgvKichBan.TabIndex = 76;
			this.dtgvKichBan.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKichBan_CellDoubleClick);
			this.cStt.HeaderText = "STT";
			this.cStt.Name = "cStt";
			this.cStt.Width = 35;
			this.cIdKichBan.HeaderText = "Id kịch bản";
			this.cIdKichBan.Name = "cIdKichBan";
			this.cIdKichBan.Visible = false;
			this.cTenKichBan.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cTenKichBan.HeaderText = "Tên kịch bản";
			this.cTenKichBan.Name = "cTenKichBan";
			this.cTenKichBan.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.DarkViolet;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(1, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(699, 37);
			this.bunifuCards1.TabIndex = 12;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(702, 391);
			this.panel1.TabIndex = 13;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(359, 350);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnSave.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.ForeColor = global::System.Drawing.Color.White;
			this.btnSave.Location = new global::System.Drawing.Point(252, 350);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(92, 29);
			this.btnSave.TabIndex = 21;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.groupBox2.BackColor = global::System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.lblCountAcc);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.dtgvKichBanChoose);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Location = new global::System.Drawing.Point(325, 40);
			this.groupBox2.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new global::System.Drawing.Size(363, 302);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kịch bản cần chạy";
			this.lblCountAcc.AutoSize = true;
			this.lblCountAcc.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.lblCountAcc.ForeColor = global::System.Drawing.Color.Blue;
			this.lblCountAcc.Location = new global::System.Drawing.Point(297, 281);
			this.lblCountAcc.Name = "lblCountAcc";
			this.lblCountAcc.Size = new global::System.Drawing.Size(16, 16);
			this.lblCountAcc.TabIndex = 82;
			this.lblCountAcc.Text = "0";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label7.Location = new global::System.Drawing.Point(255, 281);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(44, 16);
			this.label7.TabIndex = 83;
			this.label7.Text = "Tổng:";
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(4, 282);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(186, 16);
			this.label1.TabIndex = 81;
			this.label1.Text = "(Click đúp vào kịch bản để xóa)";
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button3.Location = new global::System.Drawing.Point(314, 64);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(41, 38);
			this.button3.TabIndex = 78;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.dtgvKichBanChoose.AllowUserToAddRows = false;
			this.dtgvKichBanChoose.AllowUserToDeleteRows = false;
			this.dtgvKichBanChoose.AllowUserToResizeRows = false;
			this.dtgvKichBanChoose.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvKichBanChoose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvKichBanChoose.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvKichBanChoose.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cSTTChoose,
				this.cIdKichBanChoose,
				this.cTenKichBanChoose
			});
			this.dtgvKichBanChoose.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtgvKichBanChoose.Location = new global::System.Drawing.Point(6, 20);
			this.dtgvKichBanChoose.MultiSelect = false;
			this.dtgvKichBanChoose.Name = "dtgvKichBanChoose";
			this.dtgvKichBanChoose.RowHeadersVisible = false;
			this.dtgvKichBanChoose.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvKichBanChoose.Size = new global::System.Drawing.Size(302, 258);
			this.dtgvKichBanChoose.TabIndex = 76;
			this.dtgvKichBanChoose.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dtgvKichBanChoose.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvKichBanChoose_RowsAdded);
			this.dtgvKichBanChoose.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvKichBanChoose_RowsRemoved);
			this.cSTTChoose.HeaderText = "STT";
			this.cSTTChoose.Name = "cSTTChoose";
			this.cSTTChoose.Width = 35;
			this.cIdKichBanChoose.HeaderText = "Id kịch bản";
			this.cIdKichBanChoose.Name = "cIdKichBanChoose";
			this.cIdKichBanChoose.Visible = false;
			this.cTenKichBanChoose.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cTenKichBanChoose.HeaderText = "Tên kịch bản";
			this.cTenKichBanChoose.Name = "cTenKichBanChoose";
			this.cTenKichBanChoose.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Location = new global::System.Drawing.Point(314, 19);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(41, 38);
			this.button2.TabIndex = 78;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(702, 391);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fChonKichBan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvKichBan).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvKichBanChoose).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000D2B RID: 3371
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D2C RID: 3372
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000D2D RID: 3373
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000D2E RID: 3374
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000D2F RID: 3375
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000D30 RID: 3376
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000D31 RID: 3377
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000D32 RID: 3378
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000D33 RID: 3379
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000D34 RID: 3380
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000D35 RID: 3381
		public global::System.Windows.Forms.DataGridView dtgvKichBan;

		// Token: 0x04000D36 RID: 3382
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000D37 RID: 3383
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000D38 RID: 3384
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000D39 RID: 3385
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000D3A RID: 3386
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D3B RID: 3387
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000D3C RID: 3388
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000D3D RID: 3389
		private global::System.Windows.Forms.Label lblCountAcc;

		// Token: 0x04000D3E RID: 3390
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000D3F RID: 3391
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D40 RID: 3392
		public global::System.Windows.Forms.DataGridView dtgvKichBanChoose;

		// Token: 0x04000D41 RID: 3393
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x04000D42 RID: 3394
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cIdKichBan;

		// Token: 0x04000D43 RID: 3395
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTenKichBan;

		// Token: 0x04000D44 RID: 3396
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cSTTChoose;

		// Token: 0x04000D45 RID: 3397
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cIdKichBanChoose;

		// Token: 0x04000D46 RID: 3398
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTenKichBanChoose;
	}
}
