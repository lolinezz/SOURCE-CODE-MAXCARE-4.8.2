namespace maxcare
{
	// Token: 0x0200010D RID: 269
	public partial class fHDRoiNhom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BB1 RID: 2993 RVA: 0x0019D568 File Offset: 0x0019B768
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0019D5C8 File Offset: 0x0019B7C8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDRoiNhom));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label12 = new global::System.Windows.Forms.Label();
			this.txtIDNhomGiuLai = new global::System.Windows.Forms.RichTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.plUidChiDinh = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txtIdNhomRoi = new global::System.Windows.Forms.TextBox();
			this.ckbDieuKienID = new global::System.Windows.Forms.CheckBox();
			this.plDieuKienTuKhoa = new global::System.Windows.Forms.Panel();
			this.lblStatusUid = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtTuKhoa = new global::System.Windows.Forms.TextBox();
			this.ckbDieuKienTuKhoa = new global::System.Windows.Forms.CheckBox();
			this.ckbDieuKienThanhVien = new global::System.Windows.Forms.CheckBox();
			this.nudThanhVienToiDa = new global::System.Windows.Forms.NumericUpDown();
			this.rbRoiTheoDieuKien = new global::System.Windows.Forms.RadioButton();
			this.rbNhomKiemDuyet = new global::System.Windows.Forms.RadioButton();
			this.rbNgauNhien = new global::System.Windows.Forms.RadioButton();
			this.label9 = new global::System.Windows.Forms.Label();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
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
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plUidChiDinh.SuspendLayout();
			this.panel2.SuspendLayout();
			this.plDieuKienTuKhoa.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudThanhVienToiDa).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(669, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Rời nhóm";
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
			this.pnlHeader.Size = new global::System.Drawing.Size(669, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(638, 1);
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
			this.panel1.Controls.Add(this.txtIDNhomGiuLai);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.plUidChiDinh);
			this.panel1.Controls.Add(this.rbRoiTheoDieuKien);
			this.panel1.Controls.Add(this.rbNhomKiemDuyet);
			this.panel1.Controls.Add(this.rbNgauNhien);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.nudDelayTo);
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
			this.panel1.Size = new global::System.Drawing.Size(672, 672);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(30, 585);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(97, 16);
			this.label12.TabIndex = 119;
			this.label12.Text = "(Mỗi ID 1 dòng)";
			this.label12.Click += new global::System.EventHandler(this.label12_Click);
			this.txtIDNhomGiuLai.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIDNhomGiuLai.Location = new global::System.Drawing.Point(33, 169);
			this.txtIDNhomGiuLai.Name = "txtIDNhomGiuLai";
			this.txtIDNhomGiuLai.Size = new global::System.Drawing.Size(253, 413);
			this.txtIDNhomGiuLai.TabIndex = 120;
			this.txtIDNhomGiuLai.Text = "";
			this.txtIDNhomGiuLai.WordWrap = false;
			this.txtIDNhomGiuLai.TextChanged += new global::System.EventHandler(this.txtUidKhongHuyKetBan_TextChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(30, 150);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(208, 16);
			this.label8.TabIndex = 118;
			this.label8.Text = "Danh sách ID nhóm cần giữ lại (0):";
			this.label8.Click += new global::System.EventHandler(this.label8_Click);
			this.plUidChiDinh.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plUidChiDinh.Controls.Add(this.panel2);
			this.plUidChiDinh.Controls.Add(this.ckbDieuKienID);
			this.plUidChiDinh.Controls.Add(this.plDieuKienTuKhoa);
			this.plUidChiDinh.Controls.Add(this.ckbDieuKienTuKhoa);
			this.plUidChiDinh.Controls.Add(this.ckbDieuKienThanhVien);
			this.plUidChiDinh.Controls.Add(this.nudThanhVienToiDa);
			this.plUidChiDinh.Location = new global::System.Drawing.Point(350, 174);
			this.plUidChiDinh.Name = "plUidChiDinh";
			this.plUidChiDinh.Size = new global::System.Drawing.Size(295, 424);
			this.plUidChiDinh.TabIndex = 49;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.txtIdNhomRoi);
			this.panel2.Location = new global::System.Drawing.Point(20, 247);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(265, 160);
			this.panel2.TabIndex = 52;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(3, 3);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(145, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "Danh sách ID nhóm (0):";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(4, 139);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(133, 16);
			this.label13.TabIndex = 0;
			this.label13.Text = "(Mỗi ID nhóm 1 dòng)";
			this.txtIdNhomRoi.Location = new global::System.Drawing.Point(7, 25);
			this.txtIdNhomRoi.Multiline = true;
			this.txtIdNhomRoi.Name = "txtIdNhomRoi";
			this.txtIdNhomRoi.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtIdNhomRoi.Size = new global::System.Drawing.Size(253, 111);
			this.txtIdNhomRoi.TabIndex = 1;
			this.txtIdNhomRoi.WordWrap = false;
			this.txtIdNhomRoi.TextChanged += new global::System.EventHandler(this.txtIdNhomRoi_TextChanged);
			this.ckbDieuKienID.AutoSize = true;
			this.ckbDieuKienID.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbDieuKienID.Location = new global::System.Drawing.Point(6, 221);
			this.ckbDieuKienID.Name = "ckbDieuKienID";
			this.ckbDieuKienID.Size = new global::System.Drawing.Size(126, 20);
			this.ckbDieuKienID.TabIndex = 51;
			this.ckbDieuKienID.Text = "Rời theo ID nhóm";
			this.ckbDieuKienID.UseVisualStyleBackColor = true;
			this.ckbDieuKienID.CheckedChanged += new global::System.EventHandler(this.ckbDieuKienID_CheckedChanged);
			this.plDieuKienTuKhoa.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plDieuKienTuKhoa.Controls.Add(this.lblStatusUid);
			this.plDieuKienTuKhoa.Controls.Add(this.label10);
			this.plDieuKienTuKhoa.Controls.Add(this.txtTuKhoa);
			this.plDieuKienTuKhoa.Location = new global::System.Drawing.Point(24, 55);
			this.plDieuKienTuKhoa.Name = "plDieuKienTuKhoa";
			this.plDieuKienTuKhoa.Size = new global::System.Drawing.Size(265, 160);
			this.plDieuKienTuKhoa.TabIndex = 50;
			this.lblStatusUid.AutoSize = true;
			this.lblStatusUid.Location = new global::System.Drawing.Point(3, 3);
			this.lblStatusUid.Name = "lblStatusUid";
			this.lblStatusUid.Size = new global::System.Drawing.Size(140, 16);
			this.lblStatusUid.TabIndex = 0;
			this.lblStatusUid.Text = "Danh sách từ khóa (0):";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(4, 139);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(128, 16);
			this.label10.TabIndex = 0;
			this.label10.Text = "(Mỗi từ khóa 1 dòng)";
			this.txtTuKhoa.Location = new global::System.Drawing.Point(7, 25);
			this.txtTuKhoa.Multiline = true;
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtTuKhoa.Size = new global::System.Drawing.Size(253, 111);
			this.txtTuKhoa.TabIndex = 1;
			this.txtTuKhoa.WordWrap = false;
			this.txtTuKhoa.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged_1);
			this.ckbDieuKienTuKhoa.AutoSize = true;
			this.ckbDieuKienTuKhoa.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbDieuKienTuKhoa.Location = new global::System.Drawing.Point(6, 29);
			this.ckbDieuKienTuKhoa.Name = "ckbDieuKienTuKhoa";
			this.ckbDieuKienTuKhoa.Size = new global::System.Drawing.Size(210, 20);
			this.ckbDieuKienTuKhoa.TabIndex = 2;
			this.ckbDieuKienTuKhoa.Text = "Tên nhóm có chứa từ khóa sau:";
			this.ckbDieuKienTuKhoa.UseVisualStyleBackColor = true;
			this.ckbDieuKienTuKhoa.CheckedChanged += new global::System.EventHandler(this.ckbDieuKienTuKhoa_CheckedChanged);
			this.ckbDieuKienThanhVien.AutoSize = true;
			this.ckbDieuKienThanhVien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbDieuKienThanhVien.Location = new global::System.Drawing.Point(6, 3);
			this.ckbDieuKienThanhVien.Name = "ckbDieuKienThanhVien";
			this.ckbDieuKienThanhVien.Size = new global::System.Drawing.Size(182, 20);
			this.ckbDieuKienThanhVien.TabIndex = 2;
			this.ckbDieuKienThanhVien.Text = "Số lượng thành viên ít hơn:";
			this.ckbDieuKienThanhVien.UseVisualStyleBackColor = true;
			this.ckbDieuKienThanhVien.CheckedChanged += new global::System.EventHandler(this.ckbThanhVienToiDa_CheckedChanged);
			this.nudThanhVienToiDa.Location = new global::System.Drawing.Point(197, 2);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudThanhVienToiDa;
			int[] array = new int[4];
			array[0] = 999999999;
			this.nudThanhVienToiDa.Name = "nudThanhVienToiDa";
			this.nudThanhVienToiDa.Size = new global::System.Drawing.Size(92, 23);
			this.nudThanhVienToiDa.TabIndex = 1;
			this.rbRoiTheoDieuKien.AutoSize = true;
			this.rbRoiTheoDieuKien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbRoiTheoDieuKien.Location = new global::System.Drawing.Point(350, 150);
			this.rbRoiTheoDieuKien.Name = "rbRoiTheoDieuKien";
			this.rbRoiTheoDieuKien.Size = new global::System.Drawing.Size(164, 20);
			this.rbRoiTheoDieuKien.TabIndex = 48;
			this.rbRoiTheoDieuKien.Text = "Rời nhóm theo điều kiện";
			this.rbRoiTheoDieuKien.UseVisualStyleBackColor = true;
			this.rbRoiTheoDieuKien.CheckedChanged += new global::System.EventHandler(this.rbUidChiDinh_CheckedChanged);
			this.rbNhomKiemDuyet.AutoSize = true;
			this.rbNhomKiemDuyet.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNhomKiemDuyet.Location = new global::System.Drawing.Point(350, 126);
			this.rbNhomKiemDuyet.Name = "rbNhomKiemDuyet";
			this.rbNhomKiemDuyet.Size = new global::System.Drawing.Size(191, 20);
			this.rbNhomKiemDuyet.TabIndex = 48;
			this.rbNhomKiemDuyet.Text = "Rời nhóm kiểm duyệt bài viết";
			this.rbNhomKiemDuyet.UseVisualStyleBackColor = true;
			this.rbNgauNhien.AutoSize = true;
			this.rbNgauNhien.Checked = true;
			this.rbNgauNhien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNgauNhien.Location = new global::System.Drawing.Point(350, 102);
			this.rbNgauNhien.Name = "rbNgauNhien";
			this.rbNgauNhien.Size = new global::System.Drawing.Size(188, 20);
			this.rbNgauNhien.TabIndex = 48;
			this.rbNgauNhien.TabStop = true;
			this.rbNgauNhien.Text = "Ngẫu nhiên danh sách nhóm";
			this.rbNgauNhien.UseVisualStyleBackColor = true;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(347, 80);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(138, 16);
			this.label9.TabIndex = 47;
			this.label9.Text = "Tùy chọn nhóm để rời:";
			this.nudDelayTo.Location = new global::System.Drawing.Point(229, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(132, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudDelayFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.label7.Location = new global::System.Drawing.Point(194, 113);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 46;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(287, 113);
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
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudSoLuongTo;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(132, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudSoLuongFrom;
			int[] array5 = new int[4];
			array5[0] = 999999;
			this.nudSoLuongFrom.Name = "nudSoLuongFrom";
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongFrom.TabIndex = 1;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(132, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label3.Location = new global::System.Drawing.Point(194, 82);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(287, 82);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(40, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "nhóm";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(100, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Số lượng nhóm:";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(27, 52);
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
			this.btnCancel.Location = new global::System.Drawing.Point(363, 630);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 7;
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
			this.btnAdd.Location = new global::System.Drawing.Point(256, 630);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(669, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(672, 672);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDRoiNhom";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plUidChiDinh.ResumeLayout(false);
			this.plUidChiDinh.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.plDieuKienTuKhoa.ResumeLayout(false);
			this.plDieuKienTuKhoa.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudThanhVienToiDa).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04001229 RID: 4649
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400122A RID: 4650
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400122B RID: 4651
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400122C RID: 4652
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400122D RID: 4653
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x0400122E RID: 4654
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x0400122F RID: 4655
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001230 RID: 4656
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001231 RID: 4657
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001232 RID: 4658
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001233 RID: 4659
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001234 RID: 4660
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001235 RID: 4661
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001236 RID: 4662
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001237 RID: 4663
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001238 RID: 4664
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001239 RID: 4665
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400123A RID: 4666
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400123B RID: 4667
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400123C RID: 4668
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400123D RID: 4669
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400123E RID: 4670
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400123F RID: 4671
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001240 RID: 4672
		private global::System.Windows.Forms.RadioButton rbRoiTheoDieuKien;

		// Token: 0x04001241 RID: 4673
		private global::System.Windows.Forms.RadioButton rbNgauNhien;

		// Token: 0x04001242 RID: 4674
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001243 RID: 4675
		private global::System.Windows.Forms.Panel plUidChiDinh;

		// Token: 0x04001244 RID: 4676
		private global::System.Windows.Forms.TextBox txtTuKhoa;

		// Token: 0x04001245 RID: 4677
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001246 RID: 4678
		private global::System.Windows.Forms.Label lblStatusUid;

		// Token: 0x04001247 RID: 4679
		private global::System.Windows.Forms.Panel plDieuKienTuKhoa;

		// Token: 0x04001248 RID: 4680
		private global::System.Windows.Forms.CheckBox ckbDieuKienTuKhoa;

		// Token: 0x04001249 RID: 4681
		private global::System.Windows.Forms.CheckBox ckbDieuKienThanhVien;

		// Token: 0x0400124A RID: 4682
		private global::System.Windows.Forms.NumericUpDown nudThanhVienToiDa;

		// Token: 0x0400124B RID: 4683
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400124C RID: 4684
		private global::System.Windows.Forms.RichTextBox txtIDNhomGiuLai;

		// Token: 0x0400124D RID: 4685
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400124E RID: 4686
		private global::System.Windows.Forms.RadioButton rbNhomKiemDuyet;

		// Token: 0x0400124F RID: 4687
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04001250 RID: 4688
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04001251 RID: 4689
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04001252 RID: 4690
		private global::System.Windows.Forms.TextBox txtIdNhomRoi;

		// Token: 0x04001253 RID: 4691
		private global::System.Windows.Forms.CheckBox ckbDieuKienID;
	}
}
