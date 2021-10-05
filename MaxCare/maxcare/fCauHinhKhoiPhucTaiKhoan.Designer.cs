namespace maxcare
{
	// Token: 0x0200008A RID: 138
	public partial class fCauHinhKhoiPhucTaiKhoan : global::System.Windows.Forms.Form
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x0006D12C File Offset: 0x0006B32C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0006D18C File Offset: 0x0006B38C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fCauHinhKhoiPhucTaiKhoan));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.rbThuMucCu = new global::System.Windows.Forms.RadioButton();
			this.rbThuMucKhac = new global::System.Windows.Forms.RadioButton();
			this.button1 = new global::System.Windows.Forms.Button();
			this.cbbThuMuc = new global::System.Windows.Forms.ComboBox();
			this.plThuMucKhac = new global::System.Windows.Forms.Panel();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.plThuMucKhac.SuspendLayout();
			base.SuspendLayout();
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(365, 34);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(365, 28);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Location = new global::System.Drawing.Point(333, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 28);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnMinimize_Click);
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(365, 28);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Cấu hình Khôi phục tài khoản";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(188, 162);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(84, 162);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Lưu";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.rbThuMucCu.AutoSize = true;
			this.rbThuMucCu.Checked = true;
			this.rbThuMucCu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbThuMucCu.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbThuMucCu.Location = new global::System.Drawing.Point(36, 56);
			this.rbThuMucCu.Name = "rbThuMucCu";
			this.rbThuMucCu.Size = new global::System.Drawing.Size(166, 20);
			this.rbThuMucCu.TabIndex = 5;
			this.rbThuMucCu.TabStop = true;
			this.rbThuMucCu.Text = "Khôi phục về thư mục cũ";
			this.rbThuMucCu.UseVisualStyleBackColor = true;
			this.rbThuMucKhac.AutoSize = true;
			this.rbThuMucKhac.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbThuMucKhac.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbThuMucKhac.Location = new global::System.Drawing.Point(36, 82);
			this.rbThuMucKhac.Name = "rbThuMucKhac";
			this.rbThuMucKhac.Size = new global::System.Drawing.Size(180, 20);
			this.rbThuMucKhac.TabIndex = 5;
			this.rbThuMucKhac.Text = "Chuyển sang thư mục khác";
			this.rbThuMucKhac.UseVisualStyleBackColor = true;
			this.rbThuMucKhac.CheckedChanged += new global::System.EventHandler(this.rbThuMucKhac_CheckedChanged);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(210, 2);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(62, 27);
			this.button1.TabIndex = 48;
			this.button1.Text = "Thêm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.cbbThuMuc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbThuMuc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbThuMuc.DropDownWidth = 269;
			this.cbbThuMuc.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbThuMuc.FormattingEnabled = true;
			this.cbbThuMuc.Location = new global::System.Drawing.Point(3, 3);
			this.cbbThuMuc.Name = "cbbThuMuc";
			this.cbbThuMuc.Size = new global::System.Drawing.Size(201, 24);
			this.cbbThuMuc.TabIndex = 47;
			this.plThuMucKhac.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plThuMucKhac.Controls.Add(this.cbbThuMuc);
			this.plThuMucKhac.Controls.Add(this.button1);
			this.plThuMucKhac.Location = new global::System.Drawing.Point(55, 108);
			this.plThuMucKhac.Name = "plThuMucKhac";
			this.plThuMucKhac.Size = new global::System.Drawing.Size(278, 33);
			this.plThuMucKhac.TabIndex = 49;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(365, 205);
			base.Controls.Add(this.plThuMucKhac);
			base.Controls.Add(this.rbThuMucKhac);
			base.Controls.Add(this.rbThuMucCu);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fCauHinhKhoiPhucTaiKhoan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fClearProfile_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.plThuMucKhac.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000420 RID: 1056
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000421 RID: 1057
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000422 RID: 1058
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000423 RID: 1059
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000424 RID: 1060
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000426 RID: 1062
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000427 RID: 1063
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000428 RID: 1064
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000429 RID: 1065
		private global::System.Windows.Forms.RadioButton rbThuMucCu;

		// Token: 0x0400042A RID: 1066
		private global::System.Windows.Forms.RadioButton rbThuMucKhac;

		// Token: 0x0400042B RID: 1067
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400042C RID: 1068
		private global::System.Windows.Forms.ComboBox cbbThuMuc;

		// Token: 0x0400042D RID: 1069
		private global::System.Windows.Forms.Panel plThuMucKhac;
	}
}
