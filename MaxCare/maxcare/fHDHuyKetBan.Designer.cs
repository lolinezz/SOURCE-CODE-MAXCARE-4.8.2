namespace maxcare
{
	// Token: 0x0200010C RID: 268
	public partial class fHDHuyKetBan : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x00199EE8 File Offset: 0x001980E8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00199F48 File Offset: 0x00198148
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDHuyKetBan));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label12 = new global::System.Windows.Forms.Label();
			this.txtUidKhongHuyKetBan = new global::System.Windows.Forms.RichTextBox();
			this.plHuyTheoUid = new global::System.Windows.Forms.Panel();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtUid = new global::System.Windows.Forms.RichTextBox();
			this.plHuyNgauNhien = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.rbHuyTheoUid = new global::System.Windows.Forms.RadioButton();
			this.rbHuyNgauNhien = new global::System.Windows.Forms.RadioButton();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plHuyTheoUid.SuspendLayout();
			this.plHuyNgauNhien.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(687, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Hủy kết bạn";
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
			this.pnlHeader.Size = new global::System.Drawing.Size(687, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(656, 1);
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
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.txtUidKhongHuyKetBan);
			this.panel1.Controls.Add(this.plHuyTheoUid);
			this.panel1.Controls.Add(this.plHuyNgauNhien);
			this.panel1.Controls.Add(this.rbHuyTheoUid);
			this.panel1.Controls.Add(this.rbHuyNgauNhien);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(690, 411);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.label12.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(539, 324);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(103, 16);
			this.label12.TabIndex = 115;
			this.label12.Text = "(Mỗi Uid 1 dòng)";
			this.label12.Click += new global::System.EventHandler(this.label12_Click);
			this.txtUidKhongHuyKetBan.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtUidKhongHuyKetBan.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUidKhongHuyKetBan.Location = new global::System.Drawing.Point(385, 102);
			this.txtUidKhongHuyKetBan.Name = "txtUidKhongHuyKetBan";
			this.txtUidKhongHuyKetBan.Size = new global::System.Drawing.Size(253, 221);
			this.txtUidKhongHuyKetBan.TabIndex = 117;
			this.txtUidKhongHuyKetBan.Text = "";
			this.txtUidKhongHuyKetBan.WordWrap = false;
			this.txtUidKhongHuyKetBan.TextChanged += new global::System.EventHandler(this.txtUidKhongHuyKetBan_TextChanged);
			this.plHuyTheoUid.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plHuyTheoUid.Controls.Add(this.lblStatus);
			this.plHuyTheoUid.Controls.Add(this.label9);
			this.plHuyTheoUid.Controls.Add(this.txtUid);
			this.plHuyTheoUid.Location = new global::System.Drawing.Point(59, 208);
			this.plHuyTheoUid.Name = "plHuyTheoUid";
			this.plHuyTheoUid.Size = new global::System.Drawing.Size(267, 134);
			this.plHuyTheoUid.TabIndex = 118;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(3, 3);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(209, 16);
			this.lblStatus.TabIndex = 116;
			this.lblStatus.Text = "Danh sách Uid cần hủy kết bạn (0):";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(161, 112);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(103, 16);
			this.label9.TabIndex = 115;
			this.label9.Text = "(Mỗi Uid 1 dòng)";
			this.txtUid.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUid.Location = new global::System.Drawing.Point(7, 23);
			this.txtUid.Name = "txtUid";
			this.txtUid.Size = new global::System.Drawing.Size(253, 86);
			this.txtUid.TabIndex = 117;
			this.txtUid.Text = "";
			this.txtUid.WordWrap = false;
			this.txtUid.TextChanged += new global::System.EventHandler(this.txtUid_TextChanged);
			this.plHuyNgauNhien.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plHuyNgauNhien.Controls.Add(this.label2);
			this.plHuyNgauNhien.Controls.Add(this.label4);
			this.plHuyNgauNhien.Controls.Add(this.label3);
			this.plHuyNgauNhien.Controls.Add(this.nudSoLuongFrom);
			this.plHuyNgauNhien.Controls.Add(this.nudSoLuongTo);
			this.plHuyNgauNhien.Location = new global::System.Drawing.Point(59, 155);
			this.plHuyNgauNhien.Name = "plHuyNgauNhien";
			this.plHuyNgauNhien.Size = new global::System.Drawing.Size(267, 27);
			this.plHuyNgauNhien.TabIndex = 118;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(64, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Số lượng:";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(225, 3);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(29, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "bạn";
			this.label3.Location = new global::System.Drawing.Point(135, 3);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(73, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudSoLuongFrom;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudSoLuongFrom.Name = "nudSoLuongFrom";
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongFrom.TabIndex = 1;
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(167, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSoLuongTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.rbHuyTheoUid.AutoSize = true;
			this.rbHuyTheoUid.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbHuyTheoUid.Location = new global::System.Drawing.Point(46, 185);
			this.rbHuyTheoUid.Name = "rbHuyTheoUid";
			this.rbHuyTheoUid.Size = new global::System.Drawing.Size(146, 20);
			this.rbHuyTheoUid.TabIndex = 47;
			this.rbHuyTheoUid.Text = "Hủy kết bạn theo UID";
			this.rbHuyTheoUid.UseVisualStyleBackColor = true;
			this.rbHuyTheoUid.CheckedChanged += new global::System.EventHandler(this.rbHuyTheoUid_CheckedChanged);
			this.rbHuyNgauNhien.AutoSize = true;
			this.rbHuyNgauNhien.Checked = true;
			this.rbHuyNgauNhien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbHuyNgauNhien.Location = new global::System.Drawing.Point(46, 132);
			this.rbHuyNgauNhien.Name = "rbHuyNgauNhien";
			this.rbHuyNgauNhien.Size = new global::System.Drawing.Size(177, 20);
			this.rbHuyNgauNhien.TabIndex = 47;
			this.rbHuyNgauNhien.TabStop = true;
			this.rbHuyNgauNhien.Text = "Ngẫu nhiên danh sách bạn";
			this.rbHuyNgauNhien.UseVisualStyleBackColor = true;
			this.rbHuyNgauNhien.CheckedChanged += new global::System.EventHandler(this.rbHuyNgauNhien_CheckedChanged);
			this.nudDelayTo.Location = new global::System.Drawing.Point(226, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudDelayTo;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(132, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudDelayFrom;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.label7.Location = new global::System.Drawing.Point(192, 80);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 46;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(285, 80);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 45;
			this.label6.Text = "giây";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(382, 83);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(223, 16);
			this.label10.TabIndex = 44;
			this.label10.Text = "Danh sách UID bạn bè cần giữ lại (0):";
			this.label10.Click += new global::System.EventHandler(this.label10_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(27, 110);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(135, 16);
			this.label8.TabIndex = 44;
			this.label8.Text = "Tùy chọn hủy kết bạn:";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 80);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(90, 16);
			this.label5.TabIndex = 44;
			this.label5.Text = "Thời gian chờ:";
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(132, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
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
			this.btnCancel.Location = new global::System.Drawing.Point(352, 364);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(245, 364);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 6;
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(687, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(690, 411);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDHuyKetBan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plHuyTheoUid.ResumeLayout(false);
			this.plHuyTheoUid.PerformLayout();
			this.plHuyNgauNhien.ResumeLayout(false);
			this.plHuyNgauNhien.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04001201 RID: 4609
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001202 RID: 4610
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001203 RID: 4611
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001204 RID: 4612
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001205 RID: 4613
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001206 RID: 4614
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04001207 RID: 4615
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001208 RID: 4616
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001209 RID: 4617
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400120A RID: 4618
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400120B RID: 4619
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400120C RID: 4620
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400120D RID: 4621
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400120E RID: 4622
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400120F RID: 4623
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001210 RID: 4624
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001211 RID: 4625
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001212 RID: 4626
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001213 RID: 4627
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04001214 RID: 4628
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04001215 RID: 4629
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001216 RID: 4630
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001217 RID: 4631
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001218 RID: 4632
		private global::System.Windows.Forms.RadioButton rbHuyTheoUid;

		// Token: 0x04001219 RID: 4633
		private global::System.Windows.Forms.RadioButton rbHuyNgauNhien;

		// Token: 0x0400121A RID: 4634
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400121B RID: 4635
		private global::System.Windows.Forms.Panel plHuyTheoUid;

		// Token: 0x0400121C RID: 4636
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400121D RID: 4637
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400121E RID: 4638
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x0400121F RID: 4639
		private global::System.Windows.Forms.Panel plHuyNgauNhien;

		// Token: 0x04001220 RID: 4640
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04001221 RID: 4641
		private global::System.Windows.Forms.RichTextBox txtUidKhongHuyKetBan;

		// Token: 0x04001222 RID: 4642
		private global::System.Windows.Forms.Label label10;
	}
}
