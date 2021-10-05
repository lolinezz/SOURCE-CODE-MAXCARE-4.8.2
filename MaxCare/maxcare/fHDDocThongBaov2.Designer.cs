namespace maxcare
{
	// Token: 0x020000BD RID: 189
	public partial class fHDDocThongBaov2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x000CC36C File Offset: 0x000CA56C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000CC3CC File Offset: 0x000CA5CC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
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
			this.bunifuCustomLabel1.Text = "Cấu hình Đọc thông báo v2";
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
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 188);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.nudDelayTo.Location = new global::System.Drawing.Point(216, 109);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 6;
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(216, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSoLuongTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(122, 109);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudDelayFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 5;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(122, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudSoLuongFrom;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudSoLuongFrom.Name = "nudSoLuongFrom";
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongFrom.TabIndex = 1;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(122, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(222, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(182, 111);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Location = new global::System.Drawing.Point(182, 82);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(277, 111);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(274, 82);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(65, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "thông báo";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(17, 111);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(90, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = "Thời gian chờ:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(17, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(64, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Số lượng:";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(17, 52);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(99, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = "Tên hành động:";
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(187, 148);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(83, 148);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 7;
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
			this.bunifuCards1.TabIndex = 9;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 188);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDDocThongBaov2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040008C1 RID: 2241
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040008C2 RID: 2242
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040008C3 RID: 2243
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040008C4 RID: 2244
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040008C5 RID: 2245
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x040008C6 RID: 2246
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x040008C7 RID: 2247
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x040008C8 RID: 2248
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x040008C9 RID: 2249
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040008CA RID: 2250
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040008CB RID: 2251
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040008CC RID: 2252
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040008CD RID: 2253
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040008CE RID: 2254
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040008CF RID: 2255
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040008D0 RID: 2256
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040008D1 RID: 2257
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040008D2 RID: 2258
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040008D3 RID: 2259
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040008D4 RID: 2260
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040008D5 RID: 2261
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040008D6 RID: 2262
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040008D7 RID: 2263
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
	}
}
