namespace maxcare
{
	// Token: 0x020000F3 RID: 243
	public partial class fNhapDuLieu2 : global::System.Windows.Forms.Form
	{
		// Token: 0x060009E9 RID: 2537 RVA: 0x001485F8 File Offset: 0x001467F8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00148658 File Offset: 0x00146858
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dtgvDanhSach = new global::System.Windows.Forms.DataGridView();
			this.cSTT = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cChiTiet = new global::System.Windows.Forms.DataGridViewButtonColumn();
			this.cSua = new global::System.Windows.Forms.DataGridViewButtonColumn();
			this.cXoa = new global::System.Windows.Forms.DataGridViewButtonColumn();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.txtContent = new global::System.Windows.Forms.TextBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.bunifuCards2 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.lblTitle = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.btnHuy = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvDanhSach).BeginInit();
			this.groupBox2.SuspendLayout();
			this.bunifuCards2.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(425, 47);
			this.bunifuCards1.TabIndex = 12;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.bunifuCards2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(754, 388);
			this.panel1.TabIndex = 37;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.groupBox1.Controls.Add(this.dtgvDanhSach);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(284, 339);
			this.groupBox1.TabIndex = 50;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Danh sách nội dung";
			this.dtgvDanhSach.AllowUserToAddRows = false;
			this.dtgvDanhSach.AllowUserToDeleteRows = false;
			this.dtgvDanhSach.AllowUserToResizeRows = false;
			this.dtgvDanhSach.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dtgvDanhSach.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvDanhSach.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cSTT,
				this.cName,
				this.cChiTiet,
				this.cSua,
				this.cXoa
			});
			this.dtgvDanhSach.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtgvDanhSach.Location = new global::System.Drawing.Point(6, 22);
			this.dtgvDanhSach.Name = "dtgvDanhSach";
			this.dtgvDanhSach.RowHeadersVisible = false;
			this.dtgvDanhSach.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvDanhSach.Size = new global::System.Drawing.Size(272, 277);
			this.dtgvDanhSach.TabIndex = 76;
			this.dtgvDanhSach.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellContentClick);
			this.dtgvDanhSach.CellMouseEnter += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellMouseEnter);
			this.dtgvDanhSach.MouseHover += new global::System.EventHandler(this.dtgvDanhSach_MouseHover);
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cSTT.DefaultCellStyle = dataGridViewCellStyle2;
			this.cSTT.HeaderText = "STT";
			this.cSTT.Name = "cSTT";
			this.cSTT.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cSTT.Width = 40;
			this.cName.HeaderText = "Tên file";
			this.cName.Name = "cName";
			this.cName.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cName.Visible = false;
			this.cChiTiet.HeaderText = "Chi tiết";
			this.cChiTiet.Name = "cChiTiet";
			this.cChiTiet.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.cChiTiet.Width = 80;
			this.cSua.HeaderText = "Sửa";
			this.cSua.Name = "cSua";
			this.cSua.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.cSua.Width = 71;
			this.cXoa.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cXoa.HeaderText = "Xóa";
			this.cXoa.Name = "cXoa";
			this.cXoa.Resizable = global::System.Windows.Forms.DataGridViewTriState.True;
			this.btnAdd.BackColor = global::System.Drawing.Color.Green;
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(186, 303);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 45;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.groupBox2.Controls.Add(this.txtContent);
			this.groupBox2.Controls.Add(this.btnHuy);
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Location = new global::System.Drawing.Point(293, 43);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(455, 339);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chi tiết";
			this.txtContent.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtContent.Location = new global::System.Drawing.Point(5, 22);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.ReadOnly = true;
			this.txtContent.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtContent.Size = new global::System.Drawing.Size(444, 277);
			this.txtContent.TabIndex = 48;
			this.txtContent.WordWrap = false;
			this.txtContent.TextChanged += new global::System.EventHandler(this.TxtComment_TextChanged);
			this.btnSave.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSave.Enabled = false;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.ForeColor = global::System.Drawing.Color.White;
			this.btnSave.Location = new global::System.Drawing.Point(256, 304);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(92, 29);
			this.btnSave.TabIndex = 45;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.bunifuCards2.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards2.BorderRadius = 0;
			this.bunifuCards2.BottomSahddow = true;
			this.bunifuCards2.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards2.Controls.Add(this.pnlHeader);
			this.bunifuCards2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards2.LeftSahddow = false;
			this.bunifuCards2.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards2.Name = "bunifuCards2";
			this.bunifuCards2.RightSahddow = true;
			this.bunifuCards2.ShadowDepth = 20;
			this.bunifuCards2.Size = new global::System.Drawing.Size(752, 37);
			this.bunifuCards2.TabIndex = 43;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.lblTitle);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(752, 31);
			this.pnlHeader.TabIndex = 9;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(721, 1);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(30, 30);
			this.button2.TabIndex = 77;
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Location = new global::System.Drawing.Point(899, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(30, 30);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.lblTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTitle.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.lblTitle.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.Black;
			this.lblTitle.Location = new global::System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(752, 31);
			this.lblTitle.TabIndex = 12;
			this.lblTitle.Text = "Nhập nội dung comment";
			this.lblTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.lblTitle;
			this.bunifuDragControl1.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			this.btnHuy.BackColor = global::System.Drawing.Color.FromArgb(128, 64, 0);
			this.btnHuy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnHuy.Enabled = false;
			this.btnHuy.FlatAppearance.BorderSize = 0;
			this.btnHuy.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnHuy.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnHuy.ForeColor = global::System.Drawing.Color.White;
			this.btnHuy.Location = new global::System.Drawing.Point(357, 304);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new global::System.Drawing.Size(92, 29);
			this.btnHuy.TabIndex = 45;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new global::System.EventHandler(this.btnHuy_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(754, 388);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.bunifuCards1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fNhapDuLieu2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình chung";
			base.Load += new global::System.EventHandler(this.FConfigGenneral_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dtgvDanhSach).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.bunifuCards2.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000E2A RID: 3626
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000E2B RID: 3627
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000E2C RID: 3628
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000E2D RID: 3629
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000E2E RID: 3630
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000E2F RID: 3631
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000E30 RID: 3632
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000E31 RID: 3633
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000E32 RID: 3634
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000E33 RID: 3635
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000E34 RID: 3636
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblTitle;

		// Token: 0x04000E35 RID: 3637
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000E36 RID: 3638
		private global::System.Windows.Forms.TextBox txtContent;

		// Token: 0x04000E37 RID: 3639
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000E38 RID: 3640
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000E39 RID: 3641
		public global::System.Windows.Forms.DataGridView dtgvDanhSach;

		// Token: 0x04000E3A RID: 3642
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000E3B RID: 3643
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cSTT;

		// Token: 0x04000E3C RID: 3644
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cName;

		// Token: 0x04000E3D RID: 3645
		private global::System.Windows.Forms.DataGridViewButtonColumn cChiTiet;

		// Token: 0x04000E3E RID: 3646
		private global::System.Windows.Forms.DataGridViewButtonColumn cSua;

		// Token: 0x04000E3F RID: 3647
		private global::System.Windows.Forms.DataGridViewButtonColumn cXoa;

		// Token: 0x04000E40 RID: 3648
		private global::System.Windows.Forms.Button btnHuy;
	}
}
