namespace maxcare
{
	// Token: 0x020000E5 RID: 229
	public partial class fCauHinhTuongTac : global::System.Windows.Forms.Form
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x00121E34 File Offset: 0x00120034
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00121E94 File Offset: 0x00120094
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTuongTacNhanh = new System.Windows.Forms.RadioButton();
            this.rbTuongTacKichBan = new System.Windows.Forms.RadioButton();
            this.btnCauHinhTuongTacNhanh = new MetroFramework.Controls.MetroButton();
            this.plTuongTacKichBan = new System.Windows.Forms.Panel();
            this.ckbRandomHanhDong = new System.Windows.Forms.CheckBox();
            this.cbbKichBan = new System.Windows.Forms.ComboBox();
            this.btnQuanLyKichBan = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbLoginWWW = new System.Windows.Forms.RadioButton();
            this.rbLoginMFB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbCreateProfile = new System.Windows.Forms.CheckBox();
            this.ckbGetCookie = new System.Windows.Forms.CheckBox();
            this.ckbCreateShortcut = new System.Windows.Forms.CheckBox();
            this.ckbRepeatAll = new System.Windows.Forms.CheckBox();
            this.ckbAllowFollow = new System.Windows.Forms.CheckBox();
            this.ckbAutoLinkInstagram = new System.Windows.Forms.CheckBox();
            this.ckbLogOutOldDevice = new System.Windows.Forms.CheckBox();
            this.ckbLogOut = new System.Windows.Forms.CheckBox();
            this.ckbCapNhatThongTin = new System.Windows.Forms.CheckBox();
            this.ckbGetToken = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plShowNangCao = new System.Windows.Forms.Panel();
            this.ckbBatThongBaoDangNhap = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbLoginEmailPass = new System.Windows.Forms.RadioButton();
            this.rbLoginUidPass = new System.Windows.Forms.RadioButton();
            this.rbLoginCookie = new System.Windows.Forms.RadioButton();
            this.btnShowNangCao = new System.Windows.Forms.Button();
            this.ckbReviewTag = new System.Windows.Forms.CheckBox();
            this.plShowCoBan = new System.Windows.Forms.Panel();
            this.plRepeatAll = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDelayTurnFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDelayTurnTo = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudSoLuotChay = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShowCoBan = new System.Windows.Forms.Button();
            this.ckbDontSaveBrowser = new System.Windows.Forms.CheckBox();
            this.ckbCheckLiveUid = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.plTuongTacKichBan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.plShowNangCao.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plShowCoBan.SuspendLayout();
            this.plRepeatAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTurnFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTurnTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuotChay)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(2, 1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(440, 38);
            this.bunifuCards1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(440, 32);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(406, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(440, 32);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Cấu hình Tương tác";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(226, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(122, 443);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.rbTuongTacNhanh);
            this.groupBox2.Controls.Add(this.rbTuongTacKichBan);
            this.groupBox2.Controls.Add(this.btnCauHinhTuongTacNhanh);
            this.groupBox2.Controls.Add(this.plTuongTacKichBan);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 139);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn kiểu tương tác";
            // 
            // rbTuongTacNhanh
            // 
            this.rbTuongTacNhanh.AutoSize = true;
            this.rbTuongTacNhanh.Checked = true;
            this.rbTuongTacNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTuongTacNhanh.Location = new System.Drawing.Point(17, 23);
            this.rbTuongTacNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTuongTacNhanh.Name = "rbTuongTacNhanh";
            this.rbTuongTacNhanh.Size = new System.Drawing.Size(122, 20);
            this.rbTuongTacNhanh.TabIndex = 0;
            this.rbTuongTacNhanh.TabStop = true;
            this.rbTuongTacNhanh.Text = "Tương tác nhanh";
            this.rbTuongTacNhanh.UseVisualStyleBackColor = true;
            this.rbTuongTacNhanh.CheckedChanged += new System.EventHandler(this.rbTuongTacNhanh_CheckedChanged);
            // 
            // rbTuongTacKichBan
            // 
            this.rbTuongTacKichBan.AutoSize = true;
            this.rbTuongTacKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTuongTacKichBan.Location = new System.Drawing.Point(17, 46);
            this.rbTuongTacKichBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTuongTacKichBan.Name = "rbTuongTacKichBan";
            this.rbTuongTacKichBan.Size = new System.Drawing.Size(301, 20);
            this.rbTuongTacKichBan.TabIndex = 0;
            this.rbTuongTacKichBan.TabStop = true;
            this.rbTuongTacKichBan.Text = "Tương tác theo kịch bản (Khuyến khích sử dụng)";
            this.rbTuongTacKichBan.UseVisualStyleBackColor = true;
            this.rbTuongTacKichBan.CheckedChanged += new System.EventHandler(this.rbTuongTacKichBan_CheckedChanged);
            // 
            // btnCauHinhTuongTacNhanh
            // 
            this.btnCauHinhTuongTacNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauHinhTuongTacNhanh.Location = new System.Drawing.Point(141, 22);
            this.btnCauHinhTuongTacNhanh.Name = "btnCauHinhTuongTacNhanh";
            this.btnCauHinhTuongTacNhanh.TabIndex = 1;
            this.btnCauHinhTuongTacNhanh.Text = "Cấu hình";
            this.btnCauHinhTuongTacNhanh.UseSelectable = true;
            this.btnCauHinhTuongTacNhanh.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // plTuongTacKichBan
            // 
            this.plTuongTacKichBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacKichBan.Controls.Add(this.ckbRandomHanhDong);
            this.plTuongTacKichBan.Controls.Add(this.cbbKichBan);
            this.plTuongTacKichBan.Controls.Add(this.btnQuanLyKichBan);
            this.plTuongTacKichBan.Controls.Add(this.label1);
            this.plTuongTacKichBan.Location = new System.Drawing.Point(37, 70);
            this.plTuongTacKichBan.Name = "plTuongTacKichBan";
            this.plTuongTacKichBan.Size = new System.Drawing.Size(376, 63);
            this.plTuongTacKichBan.TabIndex = 2;
            // 
            // ckbRandomHanhDong
            // 
            this.ckbRandomHanhDong.AutoSize = true;
            this.ckbRandomHanhDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbRandomHanhDong.Location = new System.Drawing.Point(7, 35);
            this.ckbRandomHanhDong.Name = "ckbRandomHanhDong";
            this.ckbRandomHanhDong.Size = new System.Drawing.Size(199, 20);
            this.ckbRandomHanhDong.TabIndex = 2;
            this.ckbRandomHanhDong.Text = "Random thứ tự các hành động";
            this.ckbRandomHanhDong.UseVisualStyleBackColor = true;
            // 
            // cbbKichBan
            // 
            this.cbbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbKichBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKichBan.DropDownWidth = 200;
            this.cbbKichBan.FormattingEnabled = true;
            this.cbbKichBan.Location = new System.Drawing.Point(103, 5);
            this.cbbKichBan.Name = "cbbKichBan";
            this.cbbKichBan.Size = new System.Drawing.Size(161, 24);
            this.cbbKichBan.TabIndex = 1;
            // 
            // btnQuanLyKichBan
            // 
            this.btnQuanLyKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKichBan.Location = new System.Drawing.Point(270, 5);
            this.btnQuanLyKichBan.Name = "btnQuanLyKichBan";
            this.btnQuanLyKichBan.Size = new System.Drawing.Size(100, 25);
            this.btnQuanLyKichBan.TabIndex = 1;
            this.btnQuanLyKichBan.Text = "Quản lý kịch bản";
            this.btnQuanLyKichBan.UseSelectable = true;
            this.btnQuanLyKichBan.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn kịch bản:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbLoginWWW);
            this.panel3.Controls.Add(this.rbLoginMFB);
            this.panel3.Location = new System.Drawing.Point(134, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 26);
            this.panel3.TabIndex = 5;
            // 
            // rbLoginWWW
            // 
            this.rbLoginWWW.AutoSize = true;
            this.rbLoginWWW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLoginWWW.Location = new System.Drawing.Point(129, 3);
            this.rbLoginWWW.Name = "rbLoginWWW";
            this.rbLoginWWW.Size = new System.Drawing.Size(98, 20);
            this.rbLoginWWW.TabIndex = 4;
            this.rbLoginWWW.Text = "www.fb.com";
            this.rbLoginWWW.UseVisualStyleBackColor = true;
            // 
            // rbLoginMFB
            // 
            this.rbLoginMFB.AutoSize = true;
            this.rbLoginMFB.Checked = true;
            this.rbLoginMFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLoginMFB.Location = new System.Drawing.Point(3, 3);
            this.rbLoginMFB.Name = "rbLoginMFB";
            this.rbLoginMFB.Size = new System.Drawing.Size(119, 20);
            this.rbLoginMFB.TabIndex = 4;
            this.rbLoginMFB.TabStop = true;
            this.rbLoginMFB.Text = "m.facebook.com";
            this.rbLoginMFB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trang đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiểu đăng nhập:";
            // 
            // ckbCreateProfile
            // 
            this.ckbCreateProfile.AutoSize = true;
            this.ckbCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCreateProfile.Location = new System.Drawing.Point(16, 31);
            this.ckbCreateProfile.Name = "ckbCreateProfile";
            this.ckbCreateProfile.Size = new System.Drawing.Size(186, 20);
            this.ckbCreateProfile.TabIndex = 2;
            this.ckbCreateProfile.Text = "Tự động tạo Profile khi chạy";
            this.ckbCreateProfile.UseVisualStyleBackColor = true;
            // 
            // ckbGetCookie
            // 
            this.ckbGetCookie.AutoSize = true;
            this.ckbGetCookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGetCookie.Location = new System.Drawing.Point(222, 31);
            this.ckbGetCookie.Name = "ckbGetCookie";
            this.ckbGetCookie.Size = new System.Drawing.Size(186, 20);
            this.ckbGetCookie.TabIndex = 2;
            this.ckbGetCookie.Text = "Tự động lấy Cookie khi chạy";
            this.ckbGetCookie.UseVisualStyleBackColor = true;
            // 
            // ckbCreateShortcut
            // 
            this.ckbCreateShortcut.AutoSize = true;
            this.ckbCreateShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCreateShortcut.Location = new System.Drawing.Point(16, 108);
            this.ckbCreateShortcut.Name = "ckbCreateShortcut";
            this.ckbCreateShortcut.Size = new System.Drawing.Size(197, 20);
            this.ckbCreateShortcut.TabIndex = 2;
            this.ckbCreateShortcut.Text = "Tự động tạo Shortcut Chrome";
            this.ckbCreateShortcut.UseVisualStyleBackColor = true;
            this.ckbCreateShortcut.Click += new System.EventHandler(this.ckbCreateShortcut_Click);
            // 
            // ckbRepeatAll
            // 
            this.ckbRepeatAll.AutoSize = true;
            this.ckbRepeatAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbRepeatAll.Location = new System.Drawing.Point(16, 109);
            this.ckbRepeatAll.Name = "ckbRepeatAll";
            this.ckbRepeatAll.Size = new System.Drawing.Size(344, 20);
            this.ckbRepeatAll.TabIndex = 2;
            this.ckbRepeatAll.Text = "Chạy tương tác lại toàn bộ tài khoản sau khi hoàn thành";
            this.ckbRepeatAll.UseVisualStyleBackColor = true;
            this.ckbRepeatAll.CheckedChanged += new System.EventHandler(this.ckbRepeatAll_CheckedChanged);
            // 
            // ckbAllowFollow
            // 
            this.ckbAllowFollow.AutoSize = true;
            this.ckbAllowFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAllowFollow.Location = new System.Drawing.Point(227, 108);
            this.ckbAllowFollow.Name = "ckbAllowFollow";
            this.ckbAllowFollow.Size = new System.Drawing.Size(187, 20);
            this.ckbAllowFollow.TabIndex = 2;
            this.ckbAllowFollow.Text = "Cho phép người khác Follow";
            this.ckbAllowFollow.UseVisualStyleBackColor = true;
            // 
            // ckbAutoLinkInstagram
            // 
            this.ckbAutoLinkInstagram.AutoSize = true;
            this.ckbAutoLinkInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoLinkInstagram.Location = new System.Drawing.Point(227, 163);
            this.ckbAutoLinkInstagram.Name = "ckbAutoLinkInstagram";
            this.ckbAutoLinkInstagram.Size = new System.Drawing.Size(181, 20);
            this.ckbAutoLinkInstagram.TabIndex = 2;
            this.ckbAutoLinkInstagram.Text = "Tự động liên kết Instagram";
            this.ckbAutoLinkInstagram.UseVisualStyleBackColor = true;
            this.ckbAutoLinkInstagram.Visible = false;
            this.ckbAutoLinkInstagram.CheckedChanged += new System.EventHandler(this.ckbAutoLinkInstagram_CheckedChanged);
            // 
            // ckbLogOutOldDevice
            // 
            this.ckbLogOutOldDevice.AutoSize = true;
            this.ckbLogOutOldDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLogOutOldDevice.Location = new System.Drawing.Point(227, 84);
            this.ckbLogOutOldDevice.Name = "ckbLogOutOldDevice";
            this.ckbLogOutOldDevice.Size = new System.Drawing.Size(166, 20);
            this.ckbLogOutOldDevice.TabIndex = 2;
            this.ckbLogOutOldDevice.Text = "Đăng xuất hết thiết bị cũ";
            this.ckbLogOutOldDevice.UseVisualStyleBackColor = true;
            // 
            // ckbLogOut
            // 
            this.ckbLogOut.AutoSize = true;
            this.ckbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLogOut.Location = new System.Drawing.Point(222, 57);
            this.ckbLogOut.Name = "ckbLogOut";
            this.ckbLogOut.Size = new System.Drawing.Size(186, 20);
            this.ckbLogOut.TabIndex = 2;
            this.ckbLogOut.Text = "Đăng xuất sau khi tương tác";
            this.ckbLogOut.UseVisualStyleBackColor = true;
            // 
            // ckbCapNhatThongTin
            // 
            this.ckbCapNhatThongTin.AutoSize = true;
            this.ckbCapNhatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCapNhatThongTin.Location = new System.Drawing.Point(16, 57);
            this.ckbCapNhatThongTin.Name = "ckbCapNhatThongTin";
            this.ckbCapNhatThongTin.Size = new System.Drawing.Size(181, 20);
            this.ckbCapNhatThongTin.TabIndex = 2;
            this.ckbCapNhatThongTin.Text = "Tự động cập nhật thông tin";
            this.ckbCapNhatThongTin.UseVisualStyleBackColor = true;
            this.ckbCapNhatThongTin.Click += new System.EventHandler(this.ckbCapNhatThongTin_Click);
            // 
            // ckbGetToken
            // 
            this.ckbGetToken.AutoSize = true;
            this.ckbGetToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGetToken.Location = new System.Drawing.Point(16, 84);
            this.ckbGetToken.Name = "ckbGetToken";
            this.ckbGetToken.Size = new System.Drawing.Size(183, 20);
            this.ckbGetToken.TabIndex = 2;
            this.ckbGetToken.Text = "Tự động lấy Token khi chạy";
            this.ckbGetToken.UseVisualStyleBackColor = true;
            this.ckbGetToken.Click += new System.EventHandler(this.ckbGetToken_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.plShowNangCao);
            this.panel1.Controls.Add(this.plShowCoBan);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 485);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plShowNangCao
            // 
            this.plShowNangCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.plShowNangCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plShowNangCao.Controls.Add(this.ckbBatThongBaoDangNhap);
            this.plShowNangCao.Controls.Add(this.panel2);
            this.plShowNangCao.Controls.Add(this.panel3);
            this.plShowNangCao.Controls.Add(this.btnShowNangCao);
            this.plShowNangCao.Controls.Add(this.ckbAutoLinkInstagram);
            this.plShowNangCao.Controls.Add(this.ckbReviewTag);
            this.plShowNangCao.Controls.Add(this.ckbAllowFollow);
            this.plShowNangCao.Controls.Add(this.ckbGetToken);
            this.plShowNangCao.Controls.Add(this.label2);
            this.plShowNangCao.Controls.Add(this.ckbLogOutOldDevice);
            this.plShowNangCao.Controls.Add(this.ckbCreateShortcut);
            this.plShowNangCao.Controls.Add(this.label3);
            this.plShowNangCao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plShowNangCao.Location = new System.Drawing.Point(11, 253);
            this.plShowNangCao.MaximumSize = new System.Drawing.Size(420, 162);
            this.plShowNangCao.MinimumSize = new System.Drawing.Size(420, 27);
            this.plShowNangCao.Name = "plShowNangCao";
            this.plShowNangCao.Size = new System.Drawing.Size(420, 28);
            this.plShowNangCao.TabIndex = 3;
            // 
            // ckbBatThongBaoDangNhap
            // 
            this.ckbBatThongBaoDangNhap.AutoSize = true;
            this.ckbBatThongBaoDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbBatThongBaoDangNhap.Location = new System.Drawing.Point(227, 134);
            this.ckbBatThongBaoDangNhap.Name = "ckbBatThongBaoDangNhap";
            this.ckbBatThongBaoDangNhap.Size = new System.Drawing.Size(169, 20);
            this.ckbBatThongBaoDangNhap.TabIndex = 7;
            this.ckbBatThongBaoDangNhap.Text = "Bật thông báo đăng nhập";
            this.ckbBatThongBaoDangNhap.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbLoginEmailPass);
            this.panel2.Controls.Add(this.rbLoginUidPass);
            this.panel2.Controls.Add(this.rbLoginCookie);
            this.panel2.Location = new System.Drawing.Point(134, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 26);
            this.panel2.TabIndex = 6;
            // 
            // rbLoginEmailPass
            // 
            this.rbLoginEmailPass.AutoSize = true;
            this.rbLoginEmailPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLoginEmailPass.Location = new System.Drawing.Point(93, 3);
            this.rbLoginEmailPass.Name = "rbLoginEmailPass";
            this.rbLoginEmailPass.Size = new System.Drawing.Size(88, 20);
            this.rbLoginEmailPass.TabIndex = 4;
            this.rbLoginEmailPass.Text = "Email|Pass";
            this.rbLoginEmailPass.UseVisualStyleBackColor = true;
            // 
            // rbLoginUidPass
            // 
            this.rbLoginUidPass.AutoSize = true;
            this.rbLoginUidPass.Checked = true;
            this.rbLoginUidPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLoginUidPass.Location = new System.Drawing.Point(3, 3);
            this.rbLoginUidPass.Name = "rbLoginUidPass";
            this.rbLoginUidPass.Size = new System.Drawing.Size(75, 20);
            this.rbLoginUidPass.TabIndex = 4;
            this.rbLoginUidPass.TabStop = true;
            this.rbLoginUidPass.Text = "Uid|Pass";
            this.rbLoginUidPass.UseVisualStyleBackColor = true;
            // 
            // rbLoginCookie
            // 
            this.rbLoginCookie.AutoSize = true;
            this.rbLoginCookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLoginCookie.Location = new System.Drawing.Point(196, 3);
            this.rbLoginCookie.Name = "rbLoginCookie";
            this.rbLoginCookie.Size = new System.Drawing.Size(63, 20);
            this.rbLoginCookie.TabIndex = 4;
            this.rbLoginCookie.Text = "Cookie";
            this.rbLoginCookie.UseVisualStyleBackColor = true;
            // 
            // btnShowNangCao
            // 
            this.btnShowNangCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowNangCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowNangCao.FlatAppearance.BorderSize = 0;
            this.btnShowNangCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNangCao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNangCao.ForeColor = System.Drawing.Color.Black;
            this.btnShowNangCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowNangCao.Location = new System.Drawing.Point(0, 0);
            this.btnShowNangCao.Name = "btnShowNangCao";
            this.btnShowNangCao.Size = new System.Drawing.Size(418, 26);
            this.btnShowNangCao.TabIndex = 2;
            this.btnShowNangCao.Text = "Cấu hình nâng cao";
            this.btnShowNangCao.UseVisualStyleBackColor = false;
            this.btnShowNangCao.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbReviewTag
            // 
            this.ckbReviewTag.AutoSize = true;
            this.ckbReviewTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbReviewTag.Location = new System.Drawing.Point(16, 134);
            this.ckbReviewTag.Name = "ckbReviewTag";
            this.ckbReviewTag.Size = new System.Drawing.Size(188, 20);
            this.ckbReviewTag.TabIndex = 2;
            this.ckbReviewTag.Text = "Bật duyệt bài viết trên tường";
            this.ckbReviewTag.UseVisualStyleBackColor = true;
            // 
            // plShowCoBan
            // 
            this.plShowCoBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plShowCoBan.Controls.Add(this.plRepeatAll);
            this.plShowCoBan.Controls.Add(this.ckbGetCookie);
            this.plShowCoBan.Controls.Add(this.ckbCreateProfile);
            this.plShowCoBan.Controls.Add(this.btnShowCoBan);
            this.plShowCoBan.Controls.Add(this.ckbDontSaveBrowser);
            this.plShowCoBan.Controls.Add(this.ckbCheckLiveUid);
            this.plShowCoBan.Controls.Add(this.ckbCapNhatThongTin);
            this.plShowCoBan.Controls.Add(this.ckbRepeatAll);
            this.plShowCoBan.Controls.Add(this.ckbLogOut);
            this.plShowCoBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plShowCoBan.Location = new System.Drawing.Point(11, 44);
            this.plShowCoBan.MaximumSize = new System.Drawing.Size(420, 203);
            this.plShowCoBan.MinimumSize = new System.Drawing.Size(420, 27);
            this.plShowCoBan.Name = "plShowCoBan";
            this.plShowCoBan.Size = new System.Drawing.Size(420, 203);
            this.plShowCoBan.TabIndex = 3;
            // 
            // plRepeatAll
            // 
            this.plRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plRepeatAll.Controls.Add(this.label6);
            this.plRepeatAll.Controls.Add(this.label4);
            this.plRepeatAll.Controls.Add(this.nudDelayTurnFrom);
            this.plRepeatAll.Controls.Add(this.label5);
            this.plRepeatAll.Controls.Add(this.nudDelayTurnTo);
            this.plRepeatAll.Controls.Add(this.label11);
            this.plRepeatAll.Controls.Add(this.nudSoLuotChay);
            this.plRepeatAll.Controls.Add(this.label10);
            this.plRepeatAll.Location = new System.Drawing.Point(36, 131);
            this.plRepeatAll.Name = "plRepeatAll";
            this.plRepeatAll.Size = new System.Drawing.Size(376, 64);
            this.plRepeatAll.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượt chạy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chờ chạy lượt tiếp theo:";
            // 
            // nudDelayTurnFrom
            // 
            this.nudDelayTurnFrom.Location = new System.Drawing.Point(154, 32);
            this.nudDelayTurnFrom.Name = "nudDelayTurnFrom";
            this.nudDelayTurnFrom.Size = new System.Drawing.Size(65, 23);
            this.nudDelayTurnFrom.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(222, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "lượt";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudDelayTurnTo
            // 
            this.nudDelayTurnTo.Location = new System.Drawing.Point(252, 32);
            this.nudDelayTurnTo.Name = "nudDelayTurnTo";
            this.nudDelayTurnTo.Size = new System.Drawing.Size(65, 23);
            this.nudDelayTurnTo.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "phút";
            // 
            // nudSoLuotChay
            // 
            this.nudSoLuotChay.Location = new System.Drawing.Point(154, 4);
            this.nudSoLuotChay.Name = "nudSoLuotChay";
            this.nudSoLuotChay.Size = new System.Drawing.Size(65, 23);
            this.nudSoLuotChay.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(222, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "đến";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowCoBan
            // 
            this.btnShowCoBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowCoBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCoBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowCoBan.FlatAppearance.BorderSize = 0;
            this.btnShowCoBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCoBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCoBan.ForeColor = System.Drawing.Color.Black;
            this.btnShowCoBan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowCoBan.Location = new System.Drawing.Point(0, 0);
            this.btnShowCoBan.Name = "btnShowCoBan";
            this.btnShowCoBan.Size = new System.Drawing.Size(418, 25);
            this.btnShowCoBan.TabIndex = 2;
            this.btnShowCoBan.Text = "Cấu hình cơ bản";
            this.btnShowCoBan.UseVisualStyleBackColor = false;
            this.btnShowCoBan.Click += new System.EventHandler(this.button5_Click);
            // 
            // ckbDontSaveBrowser
            // 
            this.ckbDontSaveBrowser.AutoSize = true;
            this.ckbDontSaveBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbDontSaveBrowser.Location = new System.Drawing.Point(222, 83);
            this.ckbDontSaveBrowser.Name = "ckbDontSaveBrowser";
            this.ckbDontSaveBrowser.Size = new System.Drawing.Size(199, 20);
            this.ckbDontSaveBrowser.TabIndex = 2;
            this.ckbDontSaveBrowser.Text = "Không lưu trình duyệt khi login";
            this.ckbDontSaveBrowser.UseVisualStyleBackColor = true;
            // 
            // ckbCheckLiveUid
            // 
            this.ckbCheckLiveUid.AutoSize = true;
            this.ckbCheckLiveUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCheckLiveUid.Location = new System.Drawing.Point(16, 83);
            this.ckbCheckLiveUid.Name = "ckbCheckLiveUid";
            this.ckbCheckLiveUid.Size = new System.Drawing.Size(192, 20);
            this.ckbCheckLiveUid.TabIndex = 2;
            this.ckbCheckLiveUid.Text = "Check Live Uid trước khi chạy";
            this.ckbCheckLiveUid.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // fCauHinhTuongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 485);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCauHinhTuongTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fCauHinhTuongTac_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.plTuongTacKichBan.ResumeLayout(false);
            this.plTuongTacKichBan.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.plShowNangCao.ResumeLayout(false);
            this.plShowNangCao.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plShowCoBan.ResumeLayout(false);
            this.plShowCoBan.PerformLayout();
            this.plRepeatAll.ResumeLayout(false);
            this.plRepeatAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTurnFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTurnTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuotChay)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000CEF RID: 3311
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CF0 RID: 3312
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000CF1 RID: 3313
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000CF2 RID: 3314
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000CF3 RID: 3315
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000CF4 RID: 3316
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000CF5 RID: 3317
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000CF6 RID: 3318
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000CF7 RID: 3319
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000CF8 RID: 3320
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000CF9 RID: 3321
		private global::System.Windows.Forms.RadioButton rbTuongTacNhanh;

		// Token: 0x04000CFA RID: 3322
		private global::System.Windows.Forms.RadioButton rbTuongTacKichBan;

		// Token: 0x04000CFB RID: 3323
		private global::MetroFramework.Controls.MetroButton btnCauHinhTuongTacNhanh;

		// Token: 0x04000CFC RID: 3324
		private global::System.Windows.Forms.Panel plTuongTacKichBan;

		// Token: 0x04000CFD RID: 3325
		private global::System.Windows.Forms.CheckBox ckbRandomHanhDong;

		// Token: 0x04000CFE RID: 3326
		private global::System.Windows.Forms.ComboBox cbbKichBan;

		// Token: 0x04000CFF RID: 3327
		private global::MetroFramework.Controls.MetroButton btnQuanLyKichBan;

		// Token: 0x04000D00 RID: 3328
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D01 RID: 3329
		private global::System.Windows.Forms.CheckBox ckbCreateProfile;

		// Token: 0x04000D02 RID: 3330
		private global::System.Windows.Forms.CheckBox ckbGetCookie;

		// Token: 0x04000D03 RID: 3331
		private global::System.Windows.Forms.CheckBox ckbCapNhatThongTin;

		// Token: 0x04000D04 RID: 3332
		private global::System.Windows.Forms.CheckBox ckbGetToken;

		// Token: 0x04000D05 RID: 3333
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000D06 RID: 3334
		private global::System.Windows.Forms.CheckBox ckbRepeatAll;

		// Token: 0x04000D07 RID: 3335
		private global::System.Windows.Forms.CheckBox ckbLogOut;

		// Token: 0x04000D08 RID: 3336
		private global::System.Windows.Forms.CheckBox ckbLogOutOldDevice;

		// Token: 0x04000D09 RID: 3337
		private global::System.Windows.Forms.CheckBox ckbAutoLinkInstagram;

		// Token: 0x04000D0A RID: 3338
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000D0B RID: 3339
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D0C RID: 3340
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000D0D RID: 3341
		private global::System.Windows.Forms.RadioButton rbLoginWWW;

		// Token: 0x04000D0E RID: 3342
		private global::System.Windows.Forms.RadioButton rbLoginMFB;

		// Token: 0x04000D0F RID: 3343
		private global::System.Windows.Forms.CheckBox ckbCreateShortcut;

		// Token: 0x04000D10 RID: 3344
		private global::System.Windows.Forms.CheckBox ckbAllowFollow;

		// Token: 0x04000D11 RID: 3345
		private global::System.Windows.Forms.Panel plShowCoBan;

		// Token: 0x04000D12 RID: 3346
		private global::System.Windows.Forms.Button btnShowCoBan;

		// Token: 0x04000D13 RID: 3347
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000D14 RID: 3348
		private global::System.Windows.Forms.Panel plShowNangCao;

		// Token: 0x04000D15 RID: 3349
		private global::System.Windows.Forms.Button btnShowNangCao;

		// Token: 0x04000D16 RID: 3350
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x04000D17 RID: 3351
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000D18 RID: 3352
		private global::System.Windows.Forms.RadioButton rbLoginEmailPass;

		// Token: 0x04000D19 RID: 3353
		private global::System.Windows.Forms.RadioButton rbLoginUidPass;

		// Token: 0x04000D1A RID: 3354
		private global::System.Windows.Forms.RadioButton rbLoginCookie;

		// Token: 0x04000D1B RID: 3355
		private global::System.Windows.Forms.Panel plRepeatAll;

		// Token: 0x04000D1C RID: 3356
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000D1D RID: 3357
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000D1E RID: 3358
		private global::System.Windows.Forms.NumericUpDown nudDelayTurnFrom;

		// Token: 0x04000D1F RID: 3359
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000D20 RID: 3360
		private global::System.Windows.Forms.NumericUpDown nudDelayTurnTo;

		// Token: 0x04000D21 RID: 3361
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000D22 RID: 3362
		private global::System.Windows.Forms.NumericUpDown nudSoLuotChay;

		// Token: 0x04000D23 RID: 3363
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000D24 RID: 3364
		private global::System.Windows.Forms.CheckBox ckbReviewTag;

		// Token: 0x04000D25 RID: 3365
		private global::System.Windows.Forms.CheckBox ckbCheckLiveUid;

		// Token: 0x04000D26 RID: 3366
		private global::System.Windows.Forms.CheckBox ckbDontSaveBrowser;

		// Token: 0x04000D27 RID: 3367
		private global::System.Windows.Forms.CheckBox ckbBatThongBaoDangNhap;
	}
}
