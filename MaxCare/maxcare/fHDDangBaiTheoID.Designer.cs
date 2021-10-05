namespace maxcare
{
	// Token: 0x020000AF RID: 175
	public partial class fHDDangBaiTheoID : global::System.Windows.Forms.Form
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x0009E014 File Offset: 0x0009C214
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0009E074 File Offset: 0x0009C274
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbDelete = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plDangBaiLenPage = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
            this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNhapNhom = new MetroFramework.Controls.MetroButton();
            this.rbNhomTuNhap = new System.Windows.Forms.RadioButton();
            this.rbNgauNhienNhomThamGia = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.ckbOnlyDangNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
            this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
            this.nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ckbDangBaiLenPage = new System.Windows.Forms.CheckBox();
            this.ckbDangBaiLenNhom = new System.Windows.Forms.CheckBox();
            this.ckbDangBaiLenTuong = new System.Windows.Forms.CheckBox();
            this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenHanhDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.plDangBaiLenPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageFrom)).BeginInit();
            this.plDangBaiLenNhom.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(372, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình Đăng bài theo ID";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(372, 31);
            this.pnlHeader.TabIndex = 9;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(342, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ckbDelete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdPost);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.nudDelayTo);
            this.panel1.Controls.Add(this.nudDelayFrom);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtTenHanhDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 642);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ckbDelete
            // 
            this.ckbDelete.AutoSize = true;
            this.ckbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDelete.Location = new System.Drawing.Point(13, 567);
            this.ckbDelete.Name = "ckbDelete";
            this.ckbDelete.Size = new System.Drawing.Size(140, 20);
            this.ckbDelete.TabIndex = 65;
            this.ckbDelete.Text = "Tự động xóa id post";
            this.ckbDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Danh sách ID post:";
            // 
            // txtIdPost
            // 
            this.txtIdPost.Location = new System.Drawing.Point(13, 406);
            this.txtIdPost.Multiline = true;
            this.txtIdPost.Name = "txtIdPost";
            this.txtIdPost.Size = new System.Drawing.Size(348, 155);
            this.txtIdPost.TabIndex = 63;
            this.txtIdPost.TextChanged += new System.EventHandler(this.txtIdPost_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plDangBaiLenPage);
            this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
            this.groupBox2.Controls.Add(this.ckbDangBaiLenPage);
            this.groupBox2.Controls.Add(this.ckbDangBaiLenNhom);
            this.groupBox2.Controls.Add(this.ckbDangBaiLenTuong);
            this.groupBox2.Location = new System.Drawing.Point(14, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 277);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn đăng";
            // 
            // plDangBaiLenPage
            // 
            this.plDangBaiLenPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDangBaiLenPage.Controls.Add(this.label21);
            this.plDangBaiLenPage.Controls.Add(this.label22);
            this.plDangBaiLenPage.Controls.Add(this.nudCountPageTo);
            this.plDangBaiLenPage.Controls.Add(this.label23);
            this.plDangBaiLenPage.Controls.Add(this.nudCountPageFrom);
            this.plDangBaiLenPage.Location = new System.Drawing.Point(25, 243);
            this.plDangBaiLenPage.Name = "plDangBaiLenPage";
            this.plDangBaiLenPage.Size = new System.Drawing.Size(310, 27);
            this.plDangBaiLenPage.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 16);
            this.label21.TabIndex = 49;
            this.label21.Text = "Số lượng page:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(261, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 16);
            this.label22.TabIndex = 50;
            this.label22.Text = "page";
            // 
            // nudCountPageTo
            // 
            this.nudCountPageTo.Location = new System.Drawing.Point(205, 1);
            this.nudCountPageTo.Name = "nudCountPageTo";
            this.nudCountPageTo.Size = new System.Drawing.Size(56, 23);
            this.nudCountPageTo.TabIndex = 48;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(170, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 16);
            this.label23.TabIndex = 51;
            this.label23.Text = "đến";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCountPageFrom
            // 
            this.nudCountPageFrom.Location = new System.Drawing.Point(108, 1);
            this.nudCountPageFrom.Name = "nudCountPageFrom";
            this.nudCountPageFrom.Size = new System.Drawing.Size(56, 23);
            this.nudCountPageFrom.TabIndex = 47;
            // 
            // plDangBaiLenNhom
            // 
            this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDangBaiLenNhom.Controls.Add(this.panel4);
            this.plDangBaiLenNhom.Controls.Add(this.label27);
            this.plDangBaiLenNhom.Controls.Add(this.ckbOnlyDangNhomKhongKiemDuyet);
            this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
            this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
            this.plDangBaiLenNhom.Controls.Add(this.label24);
            this.plDangBaiLenNhom.Controls.Add(this.label25);
            this.plDangBaiLenNhom.Controls.Add(this.label26);
            this.plDangBaiLenNhom.Location = new System.Drawing.Point(25, 80);
            this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
            this.plDangBaiLenNhom.Size = new System.Drawing.Size(310, 131);
            this.plDangBaiLenNhom.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnNhapNhom);
            this.panel4.Controls.Add(this.rbNhomTuNhap);
            this.panel4.Controls.Add(this.rbNgauNhienNhomThamGia);
            this.panel4.Location = new System.Drawing.Point(20, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 50);
            this.panel4.TabIndex = 57;
            // 
            // btnNhapNhom
            // 
            this.btnNhapNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapNhom.Location = new System.Drawing.Point(205, 23);
            this.btnNhapNhom.Name = "btnNhapNhom";
            this.btnNhapNhom.TabIndex = 1;
            this.btnNhapNhom.Text = "Nhập";
            this.btnNhapNhom.UseSelectable = true;
            this.btnNhapNhom.Click += new System.EventHandler(this.btnNhapNhom_Click);
            // 
            // rbNhomTuNhap
            // 
            this.rbNhomTuNhap.AutoSize = true;
            this.rbNhomTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNhomTuNhap.Location = new System.Drawing.Point(4, 25);
            this.rbNhomTuNhap.Name = "rbNhomTuNhap";
            this.rbNhomTuNhap.Size = new System.Drawing.Size(176, 20);
            this.rbNhomTuNhap.TabIndex = 0;
            this.rbNhomTuNhap.Text = "Nhóm do người dùng nhập";
            this.rbNhomTuNhap.UseVisualStyleBackColor = true;
            this.rbNhomTuNhap.CheckedChanged += new System.EventHandler(this.rbNhomTuNhap_CheckedChanged);
            // 
            // rbNgauNhienNhomThamGia
            // 
            this.rbNgauNhienNhomThamGia.AutoSize = true;
            this.rbNgauNhienNhomThamGia.Checked = true;
            this.rbNgauNhienNhomThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNgauNhienNhomThamGia.Location = new System.Drawing.Point(4, 3);
            this.rbNgauNhienNhomThamGia.Name = "rbNgauNhienNhomThamGia";
            this.rbNgauNhienNhomThamGia.Size = new System.Drawing.Size(197, 20);
            this.rbNgauNhienNhomThamGia.TabIndex = 0;
            this.rbNgauNhienNhomThamGia.TabStop = true;
            this.rbNgauNhienNhomThamGia.Text = "Ngẫu nhiên nhóm đã tham gia";
            this.rbNgauNhienNhomThamGia.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(4, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(154, 16);
            this.label27.TabIndex = 58;
            this.label27.Text = "Tùy chọn nhóm để share:";
            // 
            // ckbOnlyDangNhomKhongKiemDuyet
            // 
            this.ckbOnlyDangNhomKhongKiemDuyet.AutoSize = true;
            this.ckbOnlyDangNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbOnlyDangNhomKhongKiemDuyet.Location = new System.Drawing.Point(7, 110);
            this.ckbOnlyDangNhomKhongKiemDuyet.Name = "ckbOnlyDangNhomKhongKiemDuyet";
            this.ckbOnlyDangNhomKhongKiemDuyet.Size = new System.Drawing.Size(216, 20);
            this.ckbOnlyDangNhomKhongKiemDuyet.TabIndex = 2;
            this.ckbOnlyDangNhomKhongKiemDuyet.Text = "Chỉ đăng nhóm không kiểm duyệt";
            this.ckbOnlyDangNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // nudCountGroupTo
            // 
            this.nudCountGroupTo.Location = new System.Drawing.Point(205, 5);
            this.nudCountGroupTo.Name = "nudCountGroupTo";
            this.nudCountGroupTo.Size = new System.Drawing.Size(56, 23);
            this.nudCountGroupTo.TabIndex = 53;
            // 
            // nudCountGroupFrom
            // 
            this.nudCountGroupFrom.Location = new System.Drawing.Point(108, 5);
            this.nudCountGroupFrom.Name = "nudCountGroupFrom";
            this.nudCountGroupFrom.Size = new System.Drawing.Size(56, 23);
            this.nudCountGroupFrom.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(170, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 16);
            this.label24.TabIndex = 56;
            this.label24.Text = "đến";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(261, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 16);
            this.label25.TabIndex = 55;
            this.label25.Text = "nhóm";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 16);
            this.label26.TabIndex = 54;
            this.label26.Text = "Số lượng nhóm:";
            // 
            // ckbDangBaiLenPage
            // 
            this.ckbDangBaiLenPage.AutoSize = true;
            this.ckbDangBaiLenPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDangBaiLenPage.Location = new System.Drawing.Point(11, 217);
            this.ckbDangBaiLenPage.Name = "ckbDangBaiLenPage";
            this.ckbDangBaiLenPage.Size = new System.Drawing.Size(130, 20);
            this.ckbDangBaiLenPage.TabIndex = 0;
            this.ckbDangBaiLenPage.Text = "Đăng bài lên page";
            this.ckbDangBaiLenPage.UseVisualStyleBackColor = true;
            this.ckbDangBaiLenPage.CheckedChanged += new System.EventHandler(this.ckbDangBaiLenPage_CheckedChanged);
            // 
            // ckbDangBaiLenNhom
            // 
            this.ckbDangBaiLenNhom.AutoSize = true;
            this.ckbDangBaiLenNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDangBaiLenNhom.Location = new System.Drawing.Point(11, 54);
            this.ckbDangBaiLenNhom.Name = "ckbDangBaiLenNhom";
            this.ckbDangBaiLenNhom.Size = new System.Drawing.Size(134, 20);
            this.ckbDangBaiLenNhom.TabIndex = 0;
            this.ckbDangBaiLenNhom.Text = "Đăng bài lên nhóm";
            this.ckbDangBaiLenNhom.UseVisualStyleBackColor = true;
            this.ckbDangBaiLenNhom.CheckedChanged += new System.EventHandler(this.ckbDangBaiLenNhom_CheckedChanged);
            // 
            // ckbDangBaiLenTuong
            // 
            this.ckbDangBaiLenTuong.AutoSize = true;
            this.ckbDangBaiLenTuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDangBaiLenTuong.Location = new System.Drawing.Point(11, 23);
            this.ckbDangBaiLenTuong.Name = "ckbDangBaiLenTuong";
            this.ckbDangBaiLenTuong.Size = new System.Drawing.Size(135, 20);
            this.ckbDangBaiLenTuong.TabIndex = 0;
            this.ckbDangBaiLenTuong.Text = "Đăng bài lên tường";
            this.ckbDangBaiLenTuong.UseVisualStyleBackColor = true;
            // 
            // nudDelayTo
            // 
            this.nudDelayTo.Location = new System.Drawing.Point(222, 79);
            this.nudDelayTo.Name = "nudDelayTo";
            this.nudDelayTo.Size = new System.Drawing.Size(58, 23);
            this.nudDelayTo.TabIndex = 58;
            // 
            // nudDelayFrom
            // 
            this.nudDelayFrom.Location = new System.Drawing.Point(125, 79);
            this.nudDelayFrom.Name = "nudDelayFrom";
            this.nudDelayFrom.Size = new System.Drawing.Size(58, 23);
            this.nudDelayFrom.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(187, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 16);
            this.label20.TabIndex = 61;
            this.label20.Text = "đến";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(286, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 16);
            this.label19.TabIndex = 60;
            this.label19.Text = "giây";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 16);
            this.label15.TabIndex = 59;
            this.label15.Text = "Khoảng cách đăng:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(92, 600);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenHanhDong
            // 
            this.txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
            this.txtTenHanhDong.Name = "txtTenHanhDong";
            this.txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
            this.txtTenHanhDong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên hành động:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(191, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.button1);
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(375, 37);
            this.bunifuCards1.TabIndex = 28;
            // 
            // fHDDangBaiTheoID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 642);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHDDangBaiTheoID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.plDangBaiLenPage.ResumeLayout(false);
            this.plDangBaiLenPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPageFrom)).EndInit();
            this.plDangBaiLenNhom.ResumeLayout(false);
            this.plDangBaiLenNhom.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountGroupFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayFrom)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x04000675 RID: 1653
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000676 RID: 1654
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000677 RID: 1655
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000678 RID: 1656
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000679 RID: 1657
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400067A RID: 1658
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400067B RID: 1659
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400067C RID: 1660
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400067D RID: 1661
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400067E RID: 1662
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400067F RID: 1663
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000680 RID: 1664
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000681 RID: 1665
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000682 RID: 1666
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000683 RID: 1667
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000684 RID: 1668
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000685 RID: 1669
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000686 RID: 1670
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000687 RID: 1671
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000688 RID: 1672
		private global::System.Windows.Forms.Panel plDangBaiLenPage;

		// Token: 0x04000689 RID: 1673
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400068A RID: 1674
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400068B RID: 1675
		private global::System.Windows.Forms.NumericUpDown nudCountPageTo;

		// Token: 0x0400068C RID: 1676
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400068D RID: 1677
		private global::System.Windows.Forms.NumericUpDown nudCountPageFrom;

		// Token: 0x0400068E RID: 1678
		private global::System.Windows.Forms.Panel plDangBaiLenNhom;

		// Token: 0x0400068F RID: 1679
		private global::System.Windows.Forms.NumericUpDown nudCountGroupTo;

		// Token: 0x04000690 RID: 1680
		private global::System.Windows.Forms.NumericUpDown nudCountGroupFrom;

		// Token: 0x04000691 RID: 1681
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000692 RID: 1682
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000693 RID: 1683
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000694 RID: 1684
		private global::System.Windows.Forms.CheckBox ckbDangBaiLenNhom;

		// Token: 0x04000695 RID: 1685
		private global::System.Windows.Forms.CheckBox ckbDangBaiLenTuong;

		// Token: 0x04000696 RID: 1686
		private global::System.Windows.Forms.CheckBox ckbOnlyDangNhomKhongKiemDuyet;

		// Token: 0x04000697 RID: 1687
		private global::System.Windows.Forms.CheckBox ckbDelete;

		// Token: 0x04000698 RID: 1688
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000699 RID: 1689
		private global::System.Windows.Forms.TextBox txtIdPost;

		// Token: 0x0400069A RID: 1690
		private global::System.Windows.Forms.CheckBox ckbDangBaiLenPage;

		// Token: 0x0400069B RID: 1691
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400069C RID: 1692
		private global::MetroFramework.Controls.MetroButton btnNhapNhom;

		// Token: 0x0400069D RID: 1693
		private global::System.Windows.Forms.RadioButton rbNhomTuNhap;

		// Token: 0x0400069E RID: 1694
		private global::System.Windows.Forms.RadioButton rbNgauNhienNhomThamGia;

		// Token: 0x0400069F RID: 1695
		private global::System.Windows.Forms.Label label27;
	}
}
