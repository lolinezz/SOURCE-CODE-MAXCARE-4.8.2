namespace maxcare
{
	// Token: 0x0200011A RID: 282
	public partial class fHDNhanTinBanBe : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C4B RID: 3147 RVA: 0x001C0FCC File Offset: 0x001BF1CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x001C102C File Offset: 0x001BF22C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDNhanTinBanBe));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.plUidChiDinh = new global::System.Windows.Forms.Panel();
			this.txtUidChiDinh = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.lblStatusUid = new global::System.Windows.Forms.Label();
			this.rbUidChiDinh = new global::System.Windows.Forms.RadioButton();
			this.rbTrucTuyen = new global::System.Windows.Forms.RadioButton();
			this.rbNgauNhien = new global::System.Windows.Forms.RadioButton();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtTinNhan = new global::System.Windows.Forms.TextBox();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label8 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plUidChiDinh.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(687, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Nhắn tin bạn bè";
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
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.plUidChiDinh);
			this.panel1.Controls.Add(this.rbUidChiDinh);
			this.panel1.Controls.Add(this.rbTrucTuyen);
			this.panel1.Controls.Add(this.rbNgauNhien);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtTinNhan);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(690, 349);
			this.panel1.TabIndex = 0;
			this.panel1.Click += new global::System.EventHandler(this.panel1_Click);
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(304, 265);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(23, 23);
			this.button2.TabIndex = 47;
			this.button2.Text = "?";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.plUidChiDinh.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plUidChiDinh.Controls.Add(this.txtUidChiDinh);
			this.plUidChiDinh.Controls.Add(this.label10);
			this.plUidChiDinh.Controls.Add(this.lblStatusUid);
			this.plUidChiDinh.Location = new global::System.Drawing.Point(375, 120);
			this.plUidChiDinh.Name = "plUidChiDinh";
			this.plUidChiDinh.Size = new global::System.Drawing.Size(281, 164);
			this.plUidChiDinh.TabIndex = 49;
			this.txtUidChiDinh.Location = new global::System.Drawing.Point(7, 27);
			this.txtUidChiDinh.Multiline = true;
			this.txtUidChiDinh.Name = "txtUidChiDinh";
			this.txtUidChiDinh.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtUidChiDinh.Size = new global::System.Drawing.Size(266, 111);
			this.txtUidChiDinh.TabIndex = 1;
			this.txtUidChiDinh.WordWrap = false;
			this.txtUidChiDinh.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged_1);
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(4, 141);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(105, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "(Mỗi UID 1 dòng)";
			this.lblStatusUid.AutoSize = true;
			this.lblStatusUid.Location = new global::System.Drawing.Point(3, 5);
			this.lblStatusUid.Name = "lblStatusUid";
			this.lblStatusUid.Size = new global::System.Drawing.Size(117, 16);
			this.lblStatusUid.TabIndex = 0;
			this.lblStatusUid.Text = "Danh sách UID (0):";
			this.rbUidChiDinh.AutoSize = true;
			this.rbUidChiDinh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbUidChiDinh.Location = new global::System.Drawing.Point(375, 94);
			this.rbUidChiDinh.Name = "rbUidChiDinh";
			this.rbUidChiDinh.Size = new global::System.Drawing.Size(94, 20);
			this.rbUidChiDinh.TabIndex = 48;
			this.rbUidChiDinh.Text = "UID chỉ định";
			this.rbUidChiDinh.UseVisualStyleBackColor = true;
			this.rbUidChiDinh.CheckedChanged += new global::System.EventHandler(this.rbUidChiDinh_CheckedChanged);
			this.rbTrucTuyen.AutoSize = true;
			this.rbTrucTuyen.Checked = true;
			this.rbTrucTuyen.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbTrucTuyen.Location = new global::System.Drawing.Point(479, 94);
			this.rbTrucTuyen.Name = "rbTrucTuyen";
			this.rbTrucTuyen.Size = new global::System.Drawing.Size(187, 20);
			this.rbTrucTuyen.TabIndex = 48;
			this.rbTrucTuyen.TabStop = true;
			this.rbTrucTuyen.Text = "Đang trực tuyến (Chưa làm)";
			this.rbTrucTuyen.UseVisualStyleBackColor = true;
			this.rbTrucTuyen.Visible = false;
			this.rbTrucTuyen.CheckedChanged += new global::System.EventHandler(this.rbNgauNhien_CheckedChanged);
			this.rbNgauNhien.AutoSize = true;
			this.rbNgauNhien.Checked = true;
			this.rbNgauNhien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNgauNhien.Location = new global::System.Drawing.Point(375, 71);
			this.rbNgauNhien.Name = "rbNgauNhien";
			this.rbNgauNhien.Size = new global::System.Drawing.Size(177, 20);
			this.rbNgauNhien.TabIndex = 48;
			this.rbNgauNhien.TabStop = true;
			this.rbNgauNhien.Text = "Ngẫu nhiên danh sách bạn";
			this.rbNgauNhien.UseVisualStyleBackColor = true;
			this.rbNgauNhien.CheckedChanged += new global::System.EventHandler(this.rbNgauNhien_CheckedChanged);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(372, 49);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(173, 16);
			this.label9.TabIndex = 47;
			this.label9.Text = "Tùy chọn đối tượng nhắn tin:";
			this.txtTinNhan.Location = new global::System.Drawing.Point(31, 158);
			this.txtTinNhan.Multiline = true;
			this.txtTinNhan.Name = "txtTinNhan";
			this.txtTinNhan.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtTinNhan.Size = new global::System.Drawing.Size(295, 107);
			this.txtTinNhan.TabIndex = 5;
			this.txtTinNhan.WordWrap = false;
			this.txtTinNhan.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.nudDelayTo.Location = new global::System.Drawing.Point(229, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(27, 268);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(144, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "(Spin nội dung {a|b|c})";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(27, 139);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(143, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Danh sách tin nhắn (0):";
			this.nudDelayFrom.Location = new global::System.Drawing.Point(132, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(194, 113);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 46;
			this.label7.Text = "đến";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(290, 113);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 45;
			this.label6.Text = "giây";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 113);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(90, 16);
			this.label5.TabIndex = 44;
			this.label5.Text = "Thời gian chờ:";
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(229, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudSoLuongTo;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(132, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudSoLuongFrom;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudSoLuongFrom.Name = "nudSoLuongFrom";
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongFrom.TabIndex = 1;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(132, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(194, 82);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(290, 82);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(29, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "bạn";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(89, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Số lượng bạn:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(353, 305);
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
			this.btnAdd.Location = new global::System.Drawing.Point(246, 305);
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
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Location = new global::System.Drawing.Point(220, 268);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel1.TabIndex = 189;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Random icon";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(690, 349);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDNhanTinBanBe";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plUidChiDinh.ResumeLayout(false);
			this.plUidChiDinh.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04001404 RID: 5124
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001405 RID: 5125
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001406 RID: 5126
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001407 RID: 5127
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001408 RID: 5128
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001409 RID: 5129
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x0400140A RID: 5130
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400140B RID: 5131
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400140C RID: 5132
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400140D RID: 5133
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400140E RID: 5134
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400140F RID: 5135
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001410 RID: 5136
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001411 RID: 5137
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001412 RID: 5138
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001413 RID: 5139
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001414 RID: 5140
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001415 RID: 5141
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001416 RID: 5142
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001417 RID: 5143
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04001418 RID: 5144
		private global::System.Windows.Forms.TextBox txtTinNhan;

		// Token: 0x04001419 RID: 5145
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400141A RID: 5146
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400141B RID: 5147
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400141C RID: 5148
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400141D RID: 5149
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400141E RID: 5150
		private global::System.Windows.Forms.RadioButton rbUidChiDinh;

		// Token: 0x0400141F RID: 5151
		private global::System.Windows.Forms.RadioButton rbNgauNhien;

		// Token: 0x04001420 RID: 5152
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001421 RID: 5153
		private global::System.Windows.Forms.Panel plUidChiDinh;

		// Token: 0x04001422 RID: 5154
		private global::System.Windows.Forms.TextBox txtUidChiDinh;

		// Token: 0x04001423 RID: 5155
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001424 RID: 5156
		private global::System.Windows.Forms.Label lblStatusUid;

		// Token: 0x04001425 RID: 5157
		private global::System.Windows.Forms.RadioButton rbTrucTuyen;

		// Token: 0x04001426 RID: 5158
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001427 RID: 5159
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
