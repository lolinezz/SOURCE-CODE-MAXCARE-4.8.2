namespace maxcare
{
	// Token: 0x02000068 RID: 104
	public partial class fCapNhatDuLieu : global::System.Windows.Forms.Form
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x0004CDC4 File Offset: 0x0004AFC4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0004CE24 File Offset: 0x0004B024
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fCapNhatDuLieu));
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.cbbDinhDangNhap = new global::System.Windows.Forms.ComboBox();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.txbAccount = new global::System.Windows.Forms.RichTextBox();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.ctmsDevice = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.chọnToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tấtCảToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bôiĐenToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tàiKhoản0ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tàiKhoản1ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tạoThiếtBịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaThiếtBịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loadDanhSachThiêtBiToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lblSuccess = new global::System.Windows.Forms.Label();
			this.lblError = new global::System.Windows.Forms.Label();
			this.lblTotal = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.plDinhDangNhap = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang1 = new global::System.Windows.Forms.ComboBox();
			this.cbbDinhDang2 = new global::System.Windows.Forms.ComboBox();
			this.cbbDinhDang3 = new global::System.Windows.Forms.ComboBox();
			this.cbbDinhDang4 = new global::System.Windows.Forms.ComboBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang5 = new global::System.Windows.Forms.ComboBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang8 = new global::System.Windows.Forms.ComboBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang6 = new global::System.Windows.Forms.ComboBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.cbbDinhDang7 = new global::System.Windows.Forms.ComboBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.cbbTypeProxy = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.ctmsDevice.SuspendLayout();
			this.plDinhDangNhap.SuspendLayout();
			base.SuspendLayout();
			this.btnAdd.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(335, 460);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(97, 31);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Lưu";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(452, 460);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(97, 31);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.label8.Location = new global::System.Drawing.Point(9, 367);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(97, 14);
			this.label8.TabIndex = 39;
			this.label8.Text = "Chọn định dạng:";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.cbbDinhDangNhap.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDangNhap.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDangNhap.FormattingEnabled = true;
			this.cbbDinhDangNhap.Items.AddRange(new object[]
			{
				"Uid|Pass",
				"Uid|Pass|2FA",
				"Uid|Pass|Token|Cookie",
				"Uid|Pass|Token|Cookie|Email|Pass Email",
				"Uid|Pass|Token|Cookie|Email|Pass Email|2FA",
				"Other..."
			});
			this.cbbDinhDangNhap.Location = new global::System.Drawing.Point(112, 364);
			this.cbbDinhDangNhap.Name = "cbbDinhDangNhap";
			this.cbbDinhDangNhap.Size = new global::System.Drawing.Size(269, 22);
			this.cbbDinhDangNhap.TabIndex = 40;
			this.cbbDinhDangNhap.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDangNhap_SelectedIndexChanged);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(885, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pnlHeader;
			this.bunifuDragControl2.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox2);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(885, 31);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox2.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox2.Location = new global::System.Drawing.Point(2, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 79;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(-156, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 78;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Location = new global::System.Drawing.Point(853, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(30, 30);
			this.btnMinimize.TabIndex = 77;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.btnMinimize_Click);
			this.txbAccount.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbAccount.Location = new global::System.Drawing.Point(12, 77);
			this.txbAccount.Name = "txbAccount";
			this.txbAccount.Size = new global::System.Drawing.Size(863, 277);
			this.txbAccount.TabIndex = 48;
			this.txbAccount.Text = "";
			this.txbAccount.WordWrap = false;
			this.txbAccount.TextChanged += new global::System.EventHandler(this.TxbAccount_TextChanged);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.DarkViolet;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(885, 37);
			this.bunifuCards1.TabIndex = 49;
			this.ctmsDevice.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ctmsDevice.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chọnToolStripMenuItem1,
				this.toolStripMenuItem2,
				this.tạoThiếtBịToolStripMenuItem,
				this.xóaThiếtBịToolStripMenuItem,
				this.loadDanhSachThiêtBiToolStripMenuItem1
			});
			this.ctmsDevice.Name = "ctmsAcc";
			this.ctmsDevice.Size = new global::System.Drawing.Size(179, 114);
			this.chọnToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tấtCảToolStripMenuItem1,
				this.bôiĐenToolStripMenuItem1,
				this.tàiKhoản0ToolStripMenuItem,
				this.tàiKhoản1ToolStripMenuItem
			});
			this.chọnToolStripMenuItem1.Name = "chọnToolStripMenuItem1";
			this.chọnToolStripMenuItem1.Size = new global::System.Drawing.Size(178, 22);
			this.chọnToolStripMenuItem1.Text = "Chọn";
			this.tấtCảToolStripMenuItem1.Name = "tấtCảToolStripMenuItem1";
			this.tấtCảToolStripMenuItem1.Size = new global::System.Drawing.Size(143, 22);
			this.tấtCảToolStripMenuItem1.Text = "Tất cả";
			this.bôiĐenToolStripMenuItem1.Name = "bôiĐenToolStripMenuItem1";
			this.bôiĐenToolStripMenuItem1.Size = new global::System.Drawing.Size(143, 22);
			this.bôiĐenToolStripMenuItem1.Text = "Bôi đen";
			this.tàiKhoản0ToolStripMenuItem.Name = "tàiKhoản0ToolStripMenuItem";
			this.tàiKhoản0ToolStripMenuItem.Size = new global::System.Drawing.Size(143, 22);
			this.tàiKhoản0ToolStripMenuItem.Text = "Tài khoản=0";
			this.tàiKhoản1ToolStripMenuItem.Name = "tàiKhoản1ToolStripMenuItem";
			this.tàiKhoản1ToolStripMenuItem.Size = new global::System.Drawing.Size(143, 22);
			this.tàiKhoản1ToolStripMenuItem.Text = "Tài khoản=1";
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(178, 22);
			this.toolStripMenuItem2.Text = "Bỏ chọn tất cả";
			this.tạoThiếtBịToolStripMenuItem.Name = "tạoThiếtBịToolStripMenuItem";
			this.tạoThiếtBịToolStripMenuItem.Size = new global::System.Drawing.Size(178, 22);
			this.tạoThiếtBịToolStripMenuItem.Text = "Tạo thiết bị";
			this.xóaThiếtBịToolStripMenuItem.Name = "xóaThiếtBịToolStripMenuItem";
			this.xóaThiếtBịToolStripMenuItem.Size = new global::System.Drawing.Size(178, 22);
			this.xóaThiếtBịToolStripMenuItem.Text = "Xóa thiết bị";
			this.loadDanhSachThiêtBiToolStripMenuItem1.Name = "loadDanhSachThiêtBiToolStripMenuItem1";
			this.loadDanhSachThiêtBiToolStripMenuItem1.Size = new global::System.Drawing.Size(178, 22);
			this.loadDanhSachThiêtBiToolStripMenuItem1.Text = "Làm mới danh sách";
			this.label3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label3.Location = new global::System.Drawing.Point(443, 50);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(87, 16);
			this.label3.TabIndex = 55;
			this.label3.Text = "Thành công:";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblSuccess.AutoSize = true;
			this.lblSuccess.BackColor = global::System.Drawing.SystemColors.Control;
			this.lblSuccess.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblSuccess.ForeColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.lblSuccess.Location = new global::System.Drawing.Point(526, 47);
			this.lblSuccess.Name = "lblSuccess";
			this.lblSuccess.Size = new global::System.Drawing.Size(19, 19);
			this.lblSuccess.TabIndex = 50;
			this.lblSuccess.Text = "0";
			this.lblError.AutoSize = true;
			this.lblError.BackColor = global::System.Drawing.SystemColors.Control;
			this.lblError.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblError.ForeColor = global::System.Drawing.Color.FromArgb(192, 64, 0);
			this.lblError.Location = new global::System.Drawing.Point(649, 47);
			this.lblError.Name = "lblError";
			this.lblError.Size = new global::System.Drawing.Size(19, 19);
			this.lblError.TabIndex = 51;
			this.lblError.Text = "0";
			this.lblTotal.AutoSize = true;
			this.lblTotal.BackColor = global::System.Drawing.SystemColors.Control;
			this.lblTotal.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTotal.ForeColor = global::System.Drawing.Color.Teal;
			this.lblTotal.Location = new global::System.Drawing.Point(809, 48);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new global::System.Drawing.Size(19, 19);
			this.lblTotal.TabIndex = 53;
			this.lblTotal.Text = "0";
			this.label4.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label4.Location = new global::System.Drawing.Point(600, 50);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(52, 16);
			this.label4.TabIndex = 56;
			this.label4.Text = "Lỗi:";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label7.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label7.Location = new global::System.Drawing.Point(749, 50);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(63, 16);
			this.label7.TabIndex = 59;
			this.label7.Text = "Tổng số:";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblStatus.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.lblStatus.Location = new global::System.Drawing.Point(12, 44);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(227, 28);
			this.lblStatus.TabIndex = 60;
			this.lblStatus.Text = "Nhập thông tin tài khoản:";
			this.lblStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plDinhDangNhap.Controls.Add(this.cbbTypeProxy);
			this.plDinhDangNhap.Controls.Add(this.label2);
			this.plDinhDangNhap.Controls.Add(this.label1);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang1);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang2);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang3);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang4);
			this.plDinhDangNhap.Controls.Add(this.label14);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang5);
			this.plDinhDangNhap.Controls.Add(this.label17);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang8);
			this.plDinhDangNhap.Controls.Add(this.label13);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang6);
			this.plDinhDangNhap.Controls.Add(this.label12);
			this.plDinhDangNhap.Controls.Add(this.cbbDinhDang7);
			this.plDinhDangNhap.Controls.Add(this.label11);
			this.plDinhDangNhap.Controls.Add(this.label9);
			this.plDinhDangNhap.Controls.Add(this.label10);
			this.plDinhDangNhap.Location = new global::System.Drawing.Point(102, 392);
			this.plDinhDangNhap.Name = "plDinhDangNhap";
			this.plDinhDangNhap.Size = new global::System.Drawing.Size(777, 62);
			this.plDinhDangNhap.TabIndex = 61;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label1.Location = new global::System.Drawing.Point(5, 3);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(39, 19);
			this.label1.TabIndex = 42;
			this.label1.Text = "Uid|";
			this.cbbDinhDang1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang1.FormattingEnabled = true;
			this.cbbDinhDang1.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang1.Location = new global::System.Drawing.Point(44, 3);
			this.cbbDinhDang1.Name = "cbbDinhDang1";
			this.cbbDinhDang1.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang1.TabIndex = 40;
			this.cbbDinhDang1.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.cbbDinhDang2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang2.FormattingEnabled = true;
			this.cbbDinhDang2.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang2.Location = new global::System.Drawing.Point(137, 3);
			this.cbbDinhDang2.Name = "cbbDinhDang2";
			this.cbbDinhDang2.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang2.TabIndex = 40;
			this.cbbDinhDang2.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.cbbDinhDang3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang3.FormattingEnabled = true;
			this.cbbDinhDang3.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang3.Location = new global::System.Drawing.Point(230, 3);
			this.cbbDinhDang3.Name = "cbbDinhDang3";
			this.cbbDinhDang3.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang3.TabIndex = 40;
			this.cbbDinhDang3.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.cbbDinhDang4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang4.FormattingEnabled = true;
			this.cbbDinhDang4.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang4.Location = new global::System.Drawing.Point(323, 3);
			this.cbbDinhDang4.Name = "cbbDinhDang4";
			this.cbbDinhDang4.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang4.TabIndex = 40;
			this.cbbDinhDang4.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label14.Location = new global::System.Drawing.Point(587, 3);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(15, 19);
			this.label14.TabIndex = 41;
			this.label14.Text = "|";
			this.cbbDinhDang5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang5.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang5.FormattingEnabled = true;
			this.cbbDinhDang5.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang5.Location = new global::System.Drawing.Point(416, 3);
			this.cbbDinhDang5.Name = "cbbDinhDang5";
			this.cbbDinhDang5.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang5.TabIndex = 40;
			this.cbbDinhDang5.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label17.Location = new global::System.Drawing.Point(680, 3);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(15, 19);
			this.label17.TabIndex = 41;
			this.label17.Text = "|";
			this.cbbDinhDang8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang8.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang8.FormattingEnabled = true;
			this.cbbDinhDang8.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang8.Location = new global::System.Drawing.Point(695, 3);
			this.cbbDinhDang8.Name = "cbbDinhDang8";
			this.cbbDinhDang8.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang8.TabIndex = 40;
			this.cbbDinhDang8.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label13.Location = new global::System.Drawing.Point(494, 3);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(15, 19);
			this.label13.TabIndex = 41;
			this.label13.Text = "|";
			this.cbbDinhDang6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang6.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang6.FormattingEnabled = true;
			this.cbbDinhDang6.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang6.Location = new global::System.Drawing.Point(509, 3);
			this.cbbDinhDang6.Name = "cbbDinhDang6";
			this.cbbDinhDang6.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang6.TabIndex = 40;
			this.cbbDinhDang6.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label12.Location = new global::System.Drawing.Point(401, 3);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(15, 19);
			this.label12.TabIndex = 41;
			this.label12.Text = "|";
			this.cbbDinhDang7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbDinhDang7.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDinhDang7.FormattingEnabled = true;
			this.cbbDinhDang7.Items.AddRange(new object[]
			{
				"Uid",
				"Pass",
				"Token",
				"Cookie",
				"Email",
				"Pass Email",
				"2FA",
				"Useragent",
				"Proxy"
			});
			this.cbbDinhDang7.Location = new global::System.Drawing.Point(602, 3);
			this.cbbDinhDang7.Name = "cbbDinhDang7";
			this.cbbDinhDang7.Size = new global::System.Drawing.Size(78, 22);
			this.cbbDinhDang7.TabIndex = 40;
			this.cbbDinhDang7.SelectedIndexChanged += new global::System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label11.Location = new global::System.Drawing.Point(308, 3);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(15, 19);
			this.label11.TabIndex = 41;
			this.label11.Text = "|";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label9.Location = new global::System.Drawing.Point(122, 3);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(15, 19);
			this.label9.TabIndex = 41;
			this.label9.Text = "|";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Tahoma", 12f);
			this.label10.Location = new global::System.Drawing.Point(215, 3);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(15, 19);
			this.label10.TabIndex = 41;
			this.label10.Text = "|";
			this.cbbTypeProxy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbTypeProxy.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbTypeProxy.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbTypeProxy.FormattingEnabled = true;
			this.cbbTypeProxy.Items.AddRange(new object[]
			{
				"HTTP",
				"Sock5"
			});
			this.cbbTypeProxy.Location = new global::System.Drawing.Point(85, 33);
			this.cbbTypeProxy.Name = "cbbTypeProxy";
			this.cbbTypeProxy.Size = new global::System.Drawing.Size(130, 24);
			this.cbbTypeProxy.TabIndex = 126;
			this.cbbTypeProxy.Visible = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(7, 36);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(71, 16);
			this.label2.TabIndex = 125;
			this.label2.Text = "Loại proxy:";
			this.label2.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 14f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(885, 502);
			base.Controls.Add(this.plDinhDangNhap);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.lblSuccess);
			base.Controls.Add(this.lblError);
			base.Controls.Add(this.lblTotal);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.txbAccount);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.cbbDinhDangNhap);
			base.Controls.Add(this.label8);
			this.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fCapNhatDuLieu";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nhập tài khoản";
			base.Load += new global::System.EventHandler(this.fCapNhatDuLieu_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.ctmsDevice.ResumeLayout(false);
			this.plDinhDangNhap.ResumeLayout(false);
			this.plDinhDangNhap.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002CA RID: 714
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.ComboBox cbbDinhDangNhap;

		// Token: 0x040002CF RID: 719
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040002D0 RID: 720
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.RichTextBox txbAccount;

		// Token: 0x040002D2 RID: 722
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040002D3 RID: 723
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040002D4 RID: 724
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040002D5 RID: 725
		private global::System.Windows.Forms.ContextMenuStrip ctmsDevice;

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.ToolStripMenuItem chọnToolStripMenuItem1;

		// Token: 0x040002D7 RID: 727
		private global::System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem1;

		// Token: 0x040002D8 RID: 728
		private global::System.Windows.Forms.ToolStripMenuItem bôiĐenToolStripMenuItem1;

		// Token: 0x040002D9 RID: 729
		private global::System.Windows.Forms.ToolStripMenuItem tàiKhoản0ToolStripMenuItem;

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.ToolStripMenuItem tàiKhoản1ToolStripMenuItem;

		// Token: 0x040002DB RID: 731
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.ToolStripMenuItem tạoThiếtBịToolStripMenuItem;

		// Token: 0x040002DD RID: 733
		private global::System.Windows.Forms.ToolStripMenuItem xóaThiếtBịToolStripMenuItem;

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Forms.ToolStripMenuItem loadDanhSachThiêtBiToolStripMenuItem1;

		// Token: 0x040002DF RID: 735
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002E0 RID: 736
		private global::System.Windows.Forms.Label lblSuccess;

		// Token: 0x040002E1 RID: 737
		private global::System.Windows.Forms.Label lblError;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Forms.Label lblTotal;

		// Token: 0x040002E3 RID: 739
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040002E5 RID: 741
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040002E9 RID: 745
		private global::System.Windows.Forms.Panel plDinhDangNhap;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002EB RID: 747
		private global::System.Windows.Forms.ComboBox cbbDinhDang1;

		// Token: 0x040002EC RID: 748
		private global::System.Windows.Forms.ComboBox cbbDinhDang2;

		// Token: 0x040002ED RID: 749
		private global::System.Windows.Forms.ComboBox cbbDinhDang3;

		// Token: 0x040002EE RID: 750
		private global::System.Windows.Forms.ComboBox cbbDinhDang4;

		// Token: 0x040002EF RID: 751
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040002F0 RID: 752
		private global::System.Windows.Forms.ComboBox cbbDinhDang5;

		// Token: 0x040002F1 RID: 753
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040002F2 RID: 754
		private global::System.Windows.Forms.ComboBox cbbDinhDang8;

		// Token: 0x040002F3 RID: 755
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040002F4 RID: 756
		private global::System.Windows.Forms.ComboBox cbbDinhDang6;

		// Token: 0x040002F5 RID: 757
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040002F6 RID: 758
		private global::System.Windows.Forms.ComboBox cbbDinhDang7;

		// Token: 0x040002F7 RID: 759
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040002F8 RID: 760
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.ComboBox cbbTypeProxy;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.Label label2;
	}
}
