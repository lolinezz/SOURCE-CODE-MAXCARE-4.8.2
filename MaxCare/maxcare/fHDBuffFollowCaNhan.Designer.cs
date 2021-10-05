namespace maxcare
{
	// Token: 0x02000107 RID: 263
	public partial class fHDBuffFollowCaNhan : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x001875FC File Offset: 0x001857FC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0018765C File Offset: 0x0018585C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDBuffFollowCaNhan));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtUid = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			this.bunifuCards1.SuspendLayout();
			base.SuspendLayout();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(359, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Buff Follow cá nhân";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pnlHeader;
			this.bunifuDragControl2.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(359, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(328, 1);
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
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtUid);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 391);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(28, 322);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(103, 16);
			this.label10.TabIndex = 39;
			this.label10.Text = "(Mỗi Uid 1 dòng)";
			this.txtUid.Location = new global::System.Drawing.Point(31, 125);
			this.txtUid.Multiline = true;
			this.txtUid.Name = "txtUid";
			this.txtUid.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtUid.Size = new global::System.Drawing.Size(297, 194);
			this.txtUid.TabIndex = 41;
			this.txtUid.WordWrap = false;
			this.txtUid.TextChanged += new global::System.EventHandler(this.txtIdPost_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 105);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(166, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "Danh sách Uid Cá nhân (0):";
			this.nudDelayTo.Location = new global::System.Drawing.Point(231, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(134, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(134, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(196, 80);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(289, 80);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 80);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(100, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = "Thời gian delay:";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(27, 52);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(99, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = "Tên hành động:";
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(188, 347);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(81, 347);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(359, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 391);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDBuffFollowCaNhan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400111E RID: 4382
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400111F RID: 4383
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001120 RID: 4384
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001121 RID: 4385
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001122 RID: 4386
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04001123 RID: 4387
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04001124 RID: 4388
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001125 RID: 4389
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001126 RID: 4390
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001127 RID: 4391
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001128 RID: 4392
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001129 RID: 4393
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400112A RID: 4394
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400112B RID: 4395
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400112C RID: 4396
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400112D RID: 4397
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400112E RID: 4398
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400112F RID: 4399
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001130 RID: 4400
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001131 RID: 4401
		private global::System.Windows.Forms.TextBox txtUid;

		// Token: 0x04001132 RID: 4402
		private global::System.Windows.Forms.Label label2;
	}
}
