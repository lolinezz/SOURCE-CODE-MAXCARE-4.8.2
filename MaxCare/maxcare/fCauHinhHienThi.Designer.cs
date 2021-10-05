namespace maxcare
{
	// Token: 0x020000E4 RID: 228
	public partial class fCauHinhHienThi : global::System.Windows.Forms.Form
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x0011DC24 File Offset: 0x0011BE24
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0011DC84 File Offset: 0x0011BE84
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fCauHinhHienThi));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.lblStatus = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.ckbToken = new global::System.Windows.Forms.CheckBox();
			this.ckbCookie = new global::System.Windows.Forms.CheckBox();
			this.ckbEmail = new global::System.Windows.Forms.CheckBox();
			this.ckbTen = new global::System.Windows.Forms.CheckBox();
			this.ckbBanBe = new global::System.Windows.Forms.CheckBox();
			this.ckbNhom = new global::System.Windows.Forms.CheckBox();
			this.ckbNgaySinh = new global::System.Windows.Forms.CheckBox();
			this.ckbGioiTinh = new global::System.Windows.Forms.CheckBox();
			this.ckbMatKhau = new global::System.Windows.Forms.CheckBox();
			this.ckbMatKhauMail = new global::System.Windows.Forms.CheckBox();
			this.ckbBackup = new global::System.Windows.Forms.CheckBox();
			this.ckbMa2FA = new global::System.Windows.Forms.CheckBox();
			this.ckbUseragent = new global::System.Windows.Forms.CheckBox();
			this.ckbProxy = new global::System.Windows.Forms.CheckBox();
			this.ckbNgayTao = new global::System.Windows.Forms.CheckBox();
			this.ckbAvatar = new global::System.Windows.Forms.CheckBox();
			this.ckbProfile = new global::System.Windows.Forms.CheckBox();
			this.ckbTinhTrang = new global::System.Windows.Forms.CheckBox();
			this.ckbGhiChu = new global::System.Windows.Forms.CheckBox();
			this.ckbThuMuc = new global::System.Windows.Forms.CheckBox();
			this.ckbFollow = new global::System.Windows.Forms.CheckBox();
			this.ckbInteractEnd = new global::System.Windows.Forms.CheckBox();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(479, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(479, 32);
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
			this.btnMinimize.Location = new global::System.Drawing.Point(447, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 32);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(479, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Cấu hình hiển thị";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(247, 253);
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
			this.btnAdd.Location = new global::System.Drawing.Point(143, 253);
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
			this.lblStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStatus.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.lblStatus.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.ForeColor = global::System.Drawing.Color.Black;
			this.lblStatus.Location = new global::System.Drawing.Point(51, 41);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(384, 32);
			this.lblStatus.TabIndex = 21;
			this.lblStatus.Text = "Vui lòng chọn những cột cần hiển thị!";
			this.lblStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStatus.Click += new global::System.EventHandler(this.bunifuCustomLabel2_Click);
			this.ckbToken.AutoSize = true;
			this.ckbToken.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbToken.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbToken.Location = new global::System.Drawing.Point(31, 85);
			this.ckbToken.Name = "ckbToken";
			this.ckbToken.Size = new global::System.Drawing.Size(62, 20);
			this.ckbToken.TabIndex = 22;
			this.ckbToken.Text = "Token";
			this.ckbToken.UseVisualStyleBackColor = true;
			this.ckbCookie.AutoSize = true;
			this.ckbCookie.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCookie.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbCookie.Location = new global::System.Drawing.Point(31, 111);
			this.ckbCookie.Name = "ckbCookie";
			this.ckbCookie.Size = new global::System.Drawing.Size(65, 20);
			this.ckbCookie.TabIndex = 22;
			this.ckbCookie.Text = "Cookie";
			this.ckbCookie.UseVisualStyleBackColor = true;
			this.ckbEmail.AutoSize = true;
			this.ckbEmail.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbEmail.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbEmail.Location = new global::System.Drawing.Point(31, 137);
			this.ckbEmail.Name = "ckbEmail";
			this.ckbEmail.Size = new global::System.Drawing.Size(58, 20);
			this.ckbEmail.TabIndex = 22;
			this.ckbEmail.Text = "Email";
			this.ckbEmail.UseVisualStyleBackColor = true;
			this.ckbTen.AutoSize = true;
			this.ckbTen.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTen.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbTen.Location = new global::System.Drawing.Point(31, 163);
			this.ckbTen.Name = "ckbTen";
			this.ckbTen.Size = new global::System.Drawing.Size(49, 20);
			this.ckbTen.TabIndex = 22;
			this.ckbTen.Text = "Tên";
			this.ckbTen.UseVisualStyleBackColor = true;
			this.ckbBanBe.AutoSize = true;
			this.ckbBanBe.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbBanBe.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbBanBe.Location = new global::System.Drawing.Point(31, 215);
			this.ckbBanBe.Name = "ckbBanBe";
			this.ckbBanBe.Size = new global::System.Drawing.Size(66, 20);
			this.ckbBanBe.TabIndex = 22;
			this.ckbBanBe.Text = "Bạn bè";
			this.ckbBanBe.UseVisualStyleBackColor = true;
			this.ckbNhom.AutoSize = true;
			this.ckbNhom.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbNhom.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbNhom.Location = new global::System.Drawing.Point(128, 85);
			this.ckbNhom.Name = "ckbNhom";
			this.ckbNhom.Size = new global::System.Drawing.Size(60, 20);
			this.ckbNhom.TabIndex = 22;
			this.ckbNhom.Text = "Nhóm";
			this.ckbNhom.UseVisualStyleBackColor = true;
			this.ckbNgaySinh.AutoSize = true;
			this.ckbNgaySinh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbNgaySinh.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbNgaySinh.Location = new global::System.Drawing.Point(128, 111);
			this.ckbNgaySinh.Name = "ckbNgaySinh";
			this.ckbNgaySinh.Size = new global::System.Drawing.Size(82, 20);
			this.ckbNgaySinh.TabIndex = 22;
			this.ckbNgaySinh.Text = "Ngày sinh";
			this.ckbNgaySinh.UseVisualStyleBackColor = true;
			this.ckbGioiTinh.AutoSize = true;
			this.ckbGioiTinh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbGioiTinh.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbGioiTinh.Location = new global::System.Drawing.Point(128, 137);
			this.ckbGioiTinh.Name = "ckbGioiTinh";
			this.ckbGioiTinh.Size = new global::System.Drawing.Size(73, 20);
			this.ckbGioiTinh.TabIndex = 22;
			this.ckbGioiTinh.Text = "Giới tính";
			this.ckbGioiTinh.UseVisualStyleBackColor = true;
			this.ckbMatKhau.AutoSize = true;
			this.ckbMatKhau.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbMatKhau.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbMatKhau.Location = new global::System.Drawing.Point(128, 163);
			this.ckbMatKhau.Name = "ckbMatKhau";
			this.ckbMatKhau.Size = new global::System.Drawing.Size(79, 20);
			this.ckbMatKhau.TabIndex = 22;
			this.ckbMatKhau.Text = "Mật khẩu";
			this.ckbMatKhau.UseVisualStyleBackColor = true;
			this.ckbMatKhauMail.AutoSize = true;
			this.ckbMatKhauMail.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbMatKhauMail.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbMatKhauMail.Location = new global::System.Drawing.Point(128, 189);
			this.ckbMatKhauMail.Name = "ckbMatKhauMail";
			this.ckbMatKhauMail.Size = new global::System.Drawing.Size(107, 20);
			this.ckbMatKhauMail.TabIndex = 22;
			this.ckbMatKhauMail.Text = "Mật khẩu mail";
			this.ckbMatKhauMail.UseVisualStyleBackColor = true;
			this.ckbBackup.AutoSize = true;
			this.ckbBackup.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbBackup.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbBackup.Location = new global::System.Drawing.Point(128, 215);
			this.ckbBackup.Name = "ckbBackup";
			this.ckbBackup.Size = new global::System.Drawing.Size(67, 20);
			this.ckbBackup.TabIndex = 22;
			this.ckbBackup.Text = "Backup";
			this.ckbBackup.UseVisualStyleBackColor = true;
			this.ckbMa2FA.AutoSize = true;
			this.ckbMa2FA.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbMa2FA.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbMa2FA.Location = new global::System.Drawing.Point(253, 85);
			this.ckbMa2FA.Name = "ckbMa2FA";
			this.ckbMa2FA.Size = new global::System.Drawing.Size(70, 20);
			this.ckbMa2FA.TabIndex = 22;
			this.ckbMa2FA.Text = "Mã 2FA";
			this.ckbMa2FA.UseVisualStyleBackColor = true;
			this.ckbUseragent.AutoSize = true;
			this.ckbUseragent.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbUseragent.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbUseragent.Location = new global::System.Drawing.Point(253, 111);
			this.ckbUseragent.Name = "ckbUseragent";
			this.ckbUseragent.Size = new global::System.Drawing.Size(85, 20);
			this.ckbUseragent.TabIndex = 22;
			this.ckbUseragent.Text = "Useragent";
			this.ckbUseragent.UseVisualStyleBackColor = true;
			this.ckbProxy.AutoSize = true;
			this.ckbProxy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbProxy.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbProxy.Location = new global::System.Drawing.Point(253, 137);
			this.ckbProxy.Name = "ckbProxy";
			this.ckbProxy.Size = new global::System.Drawing.Size(58, 20);
			this.ckbProxy.TabIndex = 22;
			this.ckbProxy.Text = "Proxy";
			this.ckbProxy.UseVisualStyleBackColor = true;
			this.ckbNgayTao.AutoSize = true;
			this.ckbNgayTao.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbNgayTao.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbNgayTao.Location = new global::System.Drawing.Point(253, 163);
			this.ckbNgayTao.Name = "ckbNgayTao";
			this.ckbNgayTao.Size = new global::System.Drawing.Size(77, 20);
			this.ckbNgayTao.TabIndex = 22;
			this.ckbNgayTao.Text = "Ngày tạo";
			this.ckbNgayTao.UseVisualStyleBackColor = true;
			this.ckbAvatar.AutoSize = true;
			this.ckbAvatar.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAvatar.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbAvatar.Location = new global::System.Drawing.Point(253, 189);
			this.ckbAvatar.Name = "ckbAvatar";
			this.ckbAvatar.Size = new global::System.Drawing.Size(64, 20);
			this.ckbAvatar.TabIndex = 22;
			this.ckbAvatar.Text = "Avatar";
			this.ckbAvatar.UseVisualStyleBackColor = true;
			this.ckbProfile.AutoSize = true;
			this.ckbProfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbProfile.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbProfile.Location = new global::System.Drawing.Point(253, 215);
			this.ckbProfile.Name = "ckbProfile";
			this.ckbProfile.Size = new global::System.Drawing.Size(63, 20);
			this.ckbProfile.TabIndex = 22;
			this.ckbProfile.Text = "Profile";
			this.ckbProfile.UseVisualStyleBackColor = true;
			this.ckbTinhTrang.AutoSize = true;
			this.ckbTinhTrang.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTinhTrang.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbTinhTrang.Location = new global::System.Drawing.Point(355, 111);
			this.ckbTinhTrang.Name = "ckbTinhTrang";
			this.ckbTinhTrang.Size = new global::System.Drawing.Size(86, 20);
			this.ckbTinhTrang.TabIndex = 22;
			this.ckbTinhTrang.Text = "Tình trạng";
			this.ckbTinhTrang.UseVisualStyleBackColor = true;
			this.ckbGhiChu.AutoSize = true;
			this.ckbGhiChu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbGhiChu.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbGhiChu.Location = new global::System.Drawing.Point(355, 163);
			this.ckbGhiChu.Name = "ckbGhiChu";
			this.ckbGhiChu.Size = new global::System.Drawing.Size(69, 20);
			this.ckbGhiChu.TabIndex = 22;
			this.ckbGhiChu.Text = "Ghi chú";
			this.ckbGhiChu.UseVisualStyleBackColor = true;
			this.ckbThuMuc.AutoSize = true;
			this.ckbThuMuc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbThuMuc.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbThuMuc.Location = new global::System.Drawing.Point(355, 137);
			this.ckbThuMuc.Name = "ckbThuMuc";
			this.ckbThuMuc.Size = new global::System.Drawing.Size(78, 20);
			this.ckbThuMuc.TabIndex = 22;
			this.ckbThuMuc.Text = "Thư mục";
			this.ckbThuMuc.UseVisualStyleBackColor = true;
			this.ckbFollow.AutoSize = true;
			this.ckbFollow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbFollow.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbFollow.Location = new global::System.Drawing.Point(31, 189);
			this.ckbFollow.Name = "ckbFollow";
			this.ckbFollow.Size = new global::System.Drawing.Size(77, 20);
			this.ckbFollow.TabIndex = 22;
			this.ckbFollow.Text = "Theo dõi";
			this.ckbFollow.UseVisualStyleBackColor = true;
			this.ckbInteractEnd.AutoSize = true;
			this.ckbInteractEnd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbInteractEnd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbInteractEnd.Location = new global::System.Drawing.Point(355, 85);
			this.ckbInteractEnd.Name = "ckbInteractEnd";
			this.ckbInteractEnd.Size = new global::System.Drawing.Size(112, 20);
			this.ckbInteractEnd.TabIndex = 22;
			this.ckbInteractEnd.Text = "Tương tác cuối";
			this.ckbInteractEnd.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(479, 295);
			base.Controls.Add(this.ckbThuMuc);
			base.Controls.Add(this.ckbGhiChu);
			base.Controls.Add(this.ckbInteractEnd);
			base.Controls.Add(this.ckbTinhTrang);
			base.Controls.Add(this.ckbProfile);
			base.Controls.Add(this.ckbAvatar);
			base.Controls.Add(this.ckbNgayTao);
			base.Controls.Add(this.ckbProxy);
			base.Controls.Add(this.ckbUseragent);
			base.Controls.Add(this.ckbMa2FA);
			base.Controls.Add(this.ckbBackup);
			base.Controls.Add(this.ckbMatKhauMail);
			base.Controls.Add(this.ckbMatKhau);
			base.Controls.Add(this.ckbGioiTinh);
			base.Controls.Add(this.ckbNgaySinh);
			base.Controls.Add(this.ckbNhom);
			base.Controls.Add(this.ckbFollow);
			base.Controls.Add(this.ckbBanBe);
			base.Controls.Add(this.ckbTen);
			base.Controls.Add(this.ckbEmail);
			base.Controls.Add(this.ckbCookie);
			base.Controls.Add(this.ckbToken);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fCauHinhHienThi";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fClearProfile_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CCC RID: 3276
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CCD RID: 3277
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000CCE RID: 3278
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000CCF RID: 3279
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000CD0 RID: 3280
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000CD1 RID: 3281
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000CD2 RID: 3282
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000CD3 RID: 3283
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000CD4 RID: 3284
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblStatus;

		// Token: 0x04000CD5 RID: 3285
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000CD6 RID: 3286
		private global::System.Windows.Forms.CheckBox ckbToken;

		// Token: 0x04000CD7 RID: 3287
		private global::System.Windows.Forms.CheckBox ckbCookie;

		// Token: 0x04000CD8 RID: 3288
		private global::System.Windows.Forms.CheckBox ckbEmail;

		// Token: 0x04000CD9 RID: 3289
		private global::System.Windows.Forms.CheckBox ckbTen;

		// Token: 0x04000CDA RID: 3290
		private global::System.Windows.Forms.CheckBox ckbBanBe;

		// Token: 0x04000CDB RID: 3291
		private global::System.Windows.Forms.CheckBox ckbNhom;

		// Token: 0x04000CDC RID: 3292
		private global::System.Windows.Forms.CheckBox ckbNgaySinh;

		// Token: 0x04000CDD RID: 3293
		private global::System.Windows.Forms.CheckBox ckbGioiTinh;

		// Token: 0x04000CDE RID: 3294
		private global::System.Windows.Forms.CheckBox ckbMatKhau;

		// Token: 0x04000CDF RID: 3295
		private global::System.Windows.Forms.CheckBox ckbMatKhauMail;

		// Token: 0x04000CE0 RID: 3296
		private global::System.Windows.Forms.CheckBox ckbBackup;

		// Token: 0x04000CE1 RID: 3297
		private global::System.Windows.Forms.CheckBox ckbMa2FA;

		// Token: 0x04000CE2 RID: 3298
		private global::System.Windows.Forms.CheckBox ckbUseragent;

		// Token: 0x04000CE3 RID: 3299
		private global::System.Windows.Forms.CheckBox ckbProxy;

		// Token: 0x04000CE4 RID: 3300
		private global::System.Windows.Forms.CheckBox ckbNgayTao;

		// Token: 0x04000CE5 RID: 3301
		private global::System.Windows.Forms.CheckBox ckbAvatar;

		// Token: 0x04000CE6 RID: 3302
		private global::System.Windows.Forms.CheckBox ckbProfile;

		// Token: 0x04000CE7 RID: 3303
		private global::System.Windows.Forms.CheckBox ckbTinhTrang;

		// Token: 0x04000CE8 RID: 3304
		private global::System.Windows.Forms.CheckBox ckbGhiChu;

		// Token: 0x04000CE9 RID: 3305
		private global::System.Windows.Forms.CheckBox ckbThuMuc;

		// Token: 0x04000CEA RID: 3306
		private global::System.Windows.Forms.CheckBox ckbFollow;

		// Token: 0x04000CEB RID: 3307
		private global::System.Windows.Forms.CheckBox ckbInteractEnd;
	}
}
