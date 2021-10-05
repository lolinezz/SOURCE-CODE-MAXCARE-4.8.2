namespace maxcare
{
	// Token: 0x0200008D RID: 141
	public partial class fCauHinhQuetNhom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00072820 File Offset: 0x00070A20
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00072880 File Offset: 0x00070A80
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fCauHinhQuetNhom));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.rbXuatAll = new global::System.Windows.Forms.RadioButton();
			this.rbXuatNhomKiemDuyet = new global::System.Windows.Forms.RadioButton();
			this.rbXuatNhomKhongKiemDuyet = new global::System.Windows.Forms.RadioButton();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(354, 34);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(352, 28);
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

			this.btnMinimize.Location = new global::System.Drawing.Point(320, 0);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(352, 28);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Tùy chọn mật khẩu";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(186, 191);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(82, 191);
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
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(99, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cấu hình đổi IP:";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(12, 95);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(65, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tùy chọn:";
			this.rbXuatAll.AutoSize = true;
			this.rbXuatAll.Checked = true;
			this.rbXuatAll.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbXuatAll.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbXuatAll.Location = new global::System.Drawing.Point(129, 93);
			this.rbXuatAll.Name = "rbXuatAll";
			this.rbXuatAll.Size = new global::System.Drawing.Size(124, 20);
			this.rbXuatAll.TabIndex = 8;
			this.rbXuatAll.TabStop = true;
			this.rbXuatAll.Text = "Xuất tất cả nhóm";
			this.rbXuatAll.UseVisualStyleBackColor = true;
			this.rbXuatNhomKiemDuyet.AutoSize = true;
			this.rbXuatNhomKiemDuyet.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbXuatNhomKiemDuyet.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbXuatNhomKiemDuyet.Location = new global::System.Drawing.Point(129, 119);
			this.rbXuatNhomKiemDuyet.Name = "rbXuatNhomKiemDuyet";
			this.rbXuatNhomKiemDuyet.Size = new global::System.Drawing.Size(174, 20);
			this.rbXuatNhomKiemDuyet.TabIndex = 9;
			this.rbXuatNhomKiemDuyet.Text = "Chỉ xuất nhóm kiểm duyệt";
			this.rbXuatNhomKiemDuyet.UseVisualStyleBackColor = true;
			this.rbXuatNhomKhongKiemDuyet.AutoSize = true;
			this.rbXuatNhomKhongKiemDuyet.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbXuatNhomKhongKiemDuyet.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbXuatNhomKhongKiemDuyet.Location = new global::System.Drawing.Point(129, 145);
			this.rbXuatNhomKhongKiemDuyet.Name = "rbXuatNhomKhongKiemDuyet";
			this.rbXuatNhomKhongKiemDuyet.Size = new global::System.Drawing.Size(212, 20);
			this.rbXuatNhomKhongKiemDuyet.TabIndex = 10;
			this.rbXuatNhomKhongKiemDuyet.Text = "Chỉ xuất nhóm không kiểm duyệt";
			this.rbXuatNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
			this.metroButton1.Location = new global::System.Drawing.Point(129, 49);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(75, 23);
			this.metroButton1.TabIndex = 11;
			this.metroButton1.Text = "Cấu hình";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(354, 228);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.rbXuatNhomKhongKiemDuyet);
			base.Controls.Add(this.rbXuatNhomKiemDuyet);
			base.Controls.Add(this.rbXuatAll);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			this.Cursor = global::System.Windows.Forms.Cursors.Hand;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fCauHinhQuetNhom";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fClearProfile_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400045E RID: 1118
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400045F RID: 1119
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000460 RID: 1120
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000461 RID: 1121
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000462 RID: 1122
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000463 RID: 1123
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000464 RID: 1124
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000465 RID: 1125
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000466 RID: 1126
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000467 RID: 1127
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000468 RID: 1128
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000469 RID: 1129
		private global::System.Windows.Forms.RadioButton rbXuatAll;

		// Token: 0x0400046A RID: 1130
		private global::System.Windows.Forms.RadioButton rbXuatNhomKiemDuyet;

		// Token: 0x0400046B RID: 1131
		private global::System.Windows.Forms.RadioButton rbXuatNhomKhongKiemDuyet;

		// Token: 0x0400046C RID: 1132
		private global::MetroFramework.Controls.MetroButton metroButton1;
	}
}
