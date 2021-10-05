namespace maxcare
{
	// Token: 0x02000071 RID: 113
	public partial class fBin : global::System.Windows.Forms.Form
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x00064DF0 File Offset: 0x00062FF0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00064E50 File Offset: 0x00063050
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fBin));
			this.dtgvAcc = new global::System.Windows.Forms.DataGridView();
			this.cChose = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cStt = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUid = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cToken = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCookies = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cEmail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPhone = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFollow = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFriend = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGroup = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cBirthday = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGender = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPassword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMailRecovery = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPassMail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cBackup = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFa2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUseragent = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProxy = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDateCreateAcc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAvatar = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProfile = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cThuMuc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cInteractEnd = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cInfo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGhiChu = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDateDelete = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctmsAcc = new global::MetroFramework.Controls.MetroContextMenu(this.components);
			this.chọnLiveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.liveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tinhTrangToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trạngTháiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bỏChọnTấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.khôiPhucTaiKhoanToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaTàiKhoảnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởTrìnhDuyệtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tiếnHànhMởToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.càiĐặtCấuHìnhMởToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.passToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.maBaoMât6SôToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPass2FaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mailPassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassTokenCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassTokenCookieMailPassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.useragentToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.proxyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đinhDangKhacToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraWallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkInfoUIDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkAvatarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProfileToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTàiKhoảnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraMailpassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProxyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.profileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.donDepProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởThưMụcBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFileHTMLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFolderBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.htmlToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thưMụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaDữLiệuBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tảiLạiDanhSáchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.thoátToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.grQuanLyThuMuc = new global::System.Windows.Forms.GroupBox();
			this.btnLoadAcc = new global::MetroFramework.Controls.MetroButton();
			this.cbbTinhTrang = new global::MetroFramework.Controls.MetroComboBox();
			this.cbbThuMuc = new global::MetroFramework.Controls.MetroComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.grTimKiem = new global::System.Windows.Forms.GroupBox();
			this.BtnSearch = new global::MetroFramework.Controls.MetroButton();
			this.cbbSearch = new global::System.Windows.Forms.ComboBox();
			this.txbSearch = new global::WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel5 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountSelect = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel7 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountTotal = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
			this.ctmsAcc.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.grQuanLyThuMuc.SuspendLayout();
			this.grTimKiem.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dtgvAcc.AllowUserToAddRows = false;
			this.dtgvAcc.AllowUserToDeleteRows = false;
			this.dtgvAcc.AllowUserToResizeRows = false;
			this.dtgvAcc.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.dtgvAcc.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dtgvAcc.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvAcc.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cChose,
				this.cStt,
				this.cId,
				this.cUid,
				this.cToken,
				this.cCookies,
				this.cEmail,
				this.cPhone,
				this.cName,
				this.cFollow,
				this.cFriend,
				this.cGroup,
				this.cBirthday,
				this.cGender,
				this.cPassword,
				this.cMailRecovery,
				this.cPassMail,
				this.cBackup,
				this.cFa2,
				this.cUseragent,
				this.cProxy,
				this.cDateCreateAcc,
				this.cAvatar,
				this.cProfile,
				this.cThuMuc,
				this.cInteractEnd,
				this.cInfo,
				this.cGhiChu,
				this.cDateDelete,
				this.cStatus
			});
			this.dtgvAcc.ContextMenuStrip = this.ctmsAcc;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvAcc.Location = new global::System.Drawing.Point(2, 124);
			this.dtgvAcc.Name = "dtgvAcc";
			this.dtgvAcc.ReadOnly = true;
			this.dtgvAcc.RowHeadersVisible = false;
			this.dtgvAcc.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvAcc.Size = new global::System.Drawing.Size(1199, 461);
			this.dtgvAcc.TabIndex = 0;
			this.cChose.HeaderText = "Chọn";
			this.cChose.Name = "cChose";
			this.cChose.ReadOnly = true;
			this.cChose.Width = 40;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
			this.cStt.HeaderText = "STT";
			this.cStt.Name = "cStt";
			this.cStt.ReadOnly = true;
			this.cStt.Width = 35;
			this.cId.HeaderText = "Id";
			this.cId.Name = "cId";
			this.cId.ReadOnly = true;
			this.cId.Visible = false;
			this.cId.Width = 90;
			this.cUid.HeaderText = "UID";
			this.cUid.Name = "cUid";
			this.cUid.ReadOnly = true;
			this.cUid.Width = 80;
			this.cToken.HeaderText = "Token";
			this.cToken.Name = "cToken";
			this.cToken.ReadOnly = true;
			this.cToken.Width = 70;
			this.cCookies.HeaderText = "Cookie";
			this.cCookies.Name = "cCookies";
			this.cCookies.ReadOnly = true;
			this.cCookies.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cCookies.Width = 70;
			this.cEmail.HeaderText = "Email";
			this.cEmail.Name = "cEmail";
			this.cEmail.ReadOnly = true;
			this.cEmail.Width = 60;
			this.cPhone.HeaderText = "Phone";
			this.cPhone.Name = "cPhone";
			this.cPhone.ReadOnly = true;
			this.cPhone.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPhone.Visible = false;
			this.cPhone.Width = 90;
			this.cName.HeaderText = "Tên";
			this.cName.Name = "cName";
			this.cName.ReadOnly = true;
			this.cName.Width = 70;
			this.cFollow.HeaderText = "Theo dõi";
			this.cFollow.Name = "cFollow";
			this.cFollow.ReadOnly = true;
			this.cFollow.Width = 80;
			this.cFriend.HeaderText = "Bạn bè";
			this.cFriend.Name = "cFriend";
			this.cFriend.ReadOnly = true;
			this.cFriend.Width = 70;
			this.cGroup.HeaderText = "Nhóm";
			this.cGroup.Name = "cGroup";
			this.cGroup.ReadOnly = true;
			this.cGroup.Width = 60;
			this.cBirthday.HeaderText = "Ngày sinh";
			this.cBirthday.Name = "cBirthday";
			this.cBirthday.ReadOnly = true;
			this.cBirthday.Width = 90;
			this.cGender.HeaderText = "Giới Tính";
			this.cGender.Name = "cGender";
			this.cGender.ReadOnly = true;
			this.cGender.Width = 80;
			this.cPassword.HeaderText = "Mật khẩu";
			this.cPassword.Name = "cPassword";
			this.cPassword.ReadOnly = true;
			this.cPassword.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPassword.Visible = false;
			this.cPassword.Width = 70;
			this.cMailRecovery.HeaderText = "Email khôi phục";
			this.cMailRecovery.Name = "cMailRecovery";
			this.cMailRecovery.ReadOnly = true;
			this.cMailRecovery.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cMailRecovery.Visible = false;
			this.cMailRecovery.Width = 120;
			this.cPassMail.HeaderText = "Mật khẩu mail";
			this.cPassMail.Name = "cPassMail";
			this.cPassMail.ReadOnly = true;
			this.cPassMail.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPassMail.Visible = false;
			this.cPassMail.Width = 120;
			this.cBackup.HeaderText = "Backup";
			this.cBackup.Name = "cBackup";
			this.cBackup.ReadOnly = true;
			this.cBackup.Width = 70;
			this.cFa2.HeaderText = "Mã 2FA";
			this.cFa2.Name = "cFa2";
			this.cFa2.ReadOnly = true;
			this.cFa2.Width = 65;
			this.cUseragent.HeaderText = "Useragent";
			this.cUseragent.Name = "cUseragent";
			this.cUseragent.ReadOnly = true;
			this.cUseragent.Width = 70;
			this.cProxy.HeaderText = "Proxy";
			this.cProxy.Name = "cProxy";
			this.cProxy.ReadOnly = true;
			this.cProxy.Width = 55;
			this.cDateCreateAcc.HeaderText = "Ngày tạo";
			this.cDateCreateAcc.Name = "cDateCreateAcc";
			this.cDateCreateAcc.ReadOnly = true;
			this.cDateCreateAcc.Width = 85;
			this.cAvatar.HeaderText = "Avatar";
			this.cAvatar.Name = "cAvatar";
			this.cAvatar.ReadOnly = true;
			this.cAvatar.Width = 50;
			this.cProfile.HeaderText = "Profile";
			this.cProfile.Name = "cProfile";
			this.cProfile.ReadOnly = true;
			this.cProfile.Width = 50;
			this.cThuMuc.HeaderText = "Thư mục";
			this.cThuMuc.Name = "cThuMuc";
			this.cThuMuc.ReadOnly = true;
			this.cInteractEnd.HeaderText = "Lần tương tác cuối";
			this.cInteractEnd.Name = "cInteractEnd";
			this.cInteractEnd.ReadOnly = true;
			this.cInfo.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cInfo.HeaderText = "Tình Trạng";
			this.cInfo.Name = "cInfo";
			this.cInfo.ReadOnly = true;
			this.cInfo.Width = 90;
			this.cGhiChu.HeaderText = "Ghi Chú";
			this.cGhiChu.Name = "cGhiChu";
			this.cGhiChu.ReadOnly = true;
			this.cDateDelete.HeaderText = "Thời gian xóa";
			this.cDateDelete.Name = "cDateDelete";
			this.cDateDelete.ReadOnly = true;
			this.cDateDelete.Width = 111;
			this.cStatus.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cStatus.HeaderText = "Trạng Thái";
			this.cStatus.Name = "cStatus";
			this.cStatus.ReadOnly = true;
			this.ctmsAcc.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chọnLiveToolStripMenuItem,
				this.bỏChọnTấtCảToolStripMenuItem,
				this.khôiPhucTaiKhoanToolStripMenuItem,
				this.xóaTàiKhoảnToolStripMenuItem,
				this.mởTrìnhDuyệtToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.checkCookieToolStripMenuItem,
				this.profileToolStripMenuItem,
				this.backupToolStripMenuItem,
				this.tảiLạiDanhSáchToolStripMenuItem
			});
			this.ctmsAcc.Name = "ctmsAcc";
			this.ctmsAcc.Size = new global::System.Drawing.Size(198, 224);
			this.chọnLiveToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tấtCảToolStripMenuItem,
				this.liveToolStripMenuItem,
				this.tinhTrangToolStripMenuItem,
				this.trạngTháiToolStripMenuItem
			});
			this.chọnLiveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chọnLiveToolStripMenuItem.Image");
			this.chọnLiveToolStripMenuItem.Name = "chọnLiveToolStripMenuItem";
			this.chọnLiveToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.chọnLiveToolStripMenuItem.Text = "Chọn";
			this.tấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tấtCảToolStripMenuItem.Image");
			this.tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
			this.tấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.tấtCảToolStripMenuItem.Text = "Tất cả";
			this.liveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("liveToolStripMenuItem.Image");
			this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
			this.liveToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.liveToolStripMenuItem.Text = "Bôi đen";
			this.tinhTrangToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tinhTrangToolStripMenuItem.Image");
			this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
			this.tinhTrangToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.tinhTrangToolStripMenuItem.Text = "Tình trạng";
			this.trạngTháiToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("trạngTháiToolStripMenuItem.Image");
			this.trạngTháiToolStripMenuItem.Name = "trạngTháiToolStripMenuItem";
			this.trạngTháiToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.trạngTháiToolStripMenuItem.Text = "Trạng thái";
			this.bỏChọnTấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
			this.bỏChọnTấtCảToolStripMenuItem.Name = "bỏChọnTấtCảToolStripMenuItem";
			this.bỏChọnTấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.bỏChọnTấtCảToolStripMenuItem.Text = "Bỏ chọn tất cả";
			this.khôiPhucTaiKhoanToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_sync;
			this.khôiPhucTaiKhoanToolStripMenuItem.Name = "khôiPhucTaiKhoanToolStripMenuItem";
			this.khôiPhucTaiKhoanToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.khôiPhucTaiKhoanToolStripMenuItem.Text = "Khôi phục tài khoản";
			this.xóaTàiKhoảnToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_delete_bin;
			this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
			this.xóaTàiKhoảnToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản vĩnh viễn";
			this.mởTrìnhDuyệtToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tiếnHànhMởToolStripMenuItem,
				this.càiĐặtCấuHìnhMởToolStripMenuItem
			});
			this.mởTrìnhDuyệtToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mởTrìnhDuyệtToolStripMenuItem.Image");
			this.mởTrìnhDuyệtToolStripMenuItem.Name = "mởTrìnhDuyệtToolStripMenuItem";
			this.mởTrìnhDuyệtToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.mởTrìnhDuyệtToolStripMenuItem.Text = "Mở trình duyệt";
			this.tiếnHànhMởToolStripMenuItem.Name = "tiếnHànhMởToolStripMenuItem";
			this.tiếnHànhMởToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.tiếnHànhMởToolStripMenuItem.Text = "Tiến hành mở";
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Name = "càiĐặtCấuHìnhMởToolStripMenuItem";
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Text = "Cài đặt cấu hình mở";
			this.copyToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.uidToolStripMenuItem,
				this.passToolStripMenuItem,
				this.tokenToolStripMenuItem,
				this.cookieToolStripMenuItem,
				this.mailToolStripMenuItem,
				this.fAToolStripMenuItem,
				this.maBaoMât6SôToolStripMenuItem,
				this.uidPassToolStripMenuItem,
				this.uidPass2FaToolStripMenuItem,
				this.mailPassMailToolStripMenuItem,
				this.uidPassTokenCookieToolStripMenuItem,
				this.uidPassTokenCookieMailPassMailToolStripMenuItem,
				this.uidPassTokenCookieMailPassMail2faToolStripMenuItem,
				this.useragentToolStripMenuItem1,
				this.proxyToolStripMenuItem1,
				this.đinhDangKhacToolStripMenuItem
			});
			this.copyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("copyToolStripMenuItem.Image");
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.uidToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uidToolStripMenuItem.Image");
			this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
			this.uidToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidToolStripMenuItem.Text = "Uid";
			this.passToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("passToolStripMenuItem.Image");
			this.passToolStripMenuItem.Name = "passToolStripMenuItem";
			this.passToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.passToolStripMenuItem.Text = "Pass";
			this.tokenToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tokenToolStripMenuItem.Image");
			this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
			this.tokenToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.tokenToolStripMenuItem.Text = "Token";
			this.cookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cookieToolStripMenuItem.Image");
			this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
			this.cookieToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.cookieToolStripMenuItem.Text = "Cookie";
			this.mailToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mailToolStripMenuItem.Image");
			this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
			this.mailToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.mailToolStripMenuItem.Text = "Email";

			this.fAToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("fAToolStripMenuItem.Image");
			this.fAToolStripMenuItem.Name = "fAToolStripMenuItem";
			this.fAToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.fAToolStripMenuItem.Text = "2FA";

			this.maBaoMât6SôToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("maBaoMât6SôToolStripMenuItem.Image");
			this.maBaoMât6SôToolStripMenuItem.Name = "maBaoMât6SôToolStripMenuItem";
			this.maBaoMât6SôToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.maBaoMât6SôToolStripMenuItem.Text = "Mã bảo mật 6 số";
	
			this.uidPassToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uidPassToolStripMenuItem.Image");
			this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
			this.uidPassToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassToolStripMenuItem.Text = "Uid|Pass";

			this.uidPass2FaToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uidPass2FaToolStripMenuItem.Image");
			this.uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
			this.uidPass2FaToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
		
			this.mailPassMailToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mailPassMailToolStripMenuItem.Image");
			this.mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
			this.mailPassMailToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.mailPassMailToolStripMenuItem.Text = "Mail|Pass mail";
		
			this.uidPassTokenCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
			this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
			this.uidPassTokenCookieToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassTokenCookieToolStripMenuItem.Text = "Uid|Pass|Token|Cookie";

			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";

			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";

			this.useragentToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("useragentToolStripMenuItem1.Image");
			this.useragentToolStripMenuItem1.Name = "useragentToolStripMenuItem1";
			this.useragentToolStripMenuItem1.Size = new global::System.Drawing.Size(289, 22);
			this.useragentToolStripMenuItem1.Text = "Useragent";

			this.proxyToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("proxyToolStripMenuItem1.Image");
			this.proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
			this.proxyToolStripMenuItem1.Size = new global::System.Drawing.Size(289, 22);
			this.proxyToolStripMenuItem1.Text = "Proxy";
	
			this.đinhDangKhacToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("đinhDangKhacToolStripMenuItem.Image");
			this.đinhDangKhacToolStripMenuItem.Name = "đinhDangKhacToolStripMenuItem";
			this.đinhDangKhacToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.đinhDangKhacToolStripMenuItem.Text = "Định dạng khác...";
	
			this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.kiểmTraWallToolStripMenuItem,
				this.checkInfoUIDToolStripMenuItem,
				this.kiểmTraTokenToolStripMenuItem,
				this.kiểmTraCookieToolStripMenuItem,
				this.checkAvatarToolStripMenuItem,
				this.checkProfileToolStripMenuItem1,
				this.checkBackupToolStripMenuItem1,
				this.kiểmTraTàiKhoảnToolStripMenuItem,
				this.kiểmTraMailpassMailToolStripMenuItem,
				this.checkProxyToolStripMenuItem
			});
			this.checkCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("checkCookieToolStripMenuItem.Image");
			this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
			this.checkCookieToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
			this.kiểmTraWallToolStripMenuItem.Name = "kiểmTraWallToolStripMenuItem";
			this.kiểmTraWallToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraWallToolStripMenuItem.Text = "Check Wall";
			this.kiểmTraWallToolStripMenuItem.ToolTipText = "Không cần dùng token";
	
			this.checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
			this.checkInfoUIDToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.checkInfoUIDToolStripMenuItem.Text = "Check Info UID";
			this.checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCập nhật thông tin: Họ tên, Giớ́i tính, [Email], [Bạn bè], [Nhóm], [Ngày sinh]";
				this.kiểmTraTokenToolStripMenuItem.Name = "kiểmTraTokenToolStripMenuItem";
			this.kiểmTraTokenToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraTokenToolStripMenuItem.Text = "Check Token";
			
			this.kiểmTraCookieToolStripMenuItem.Name = "kiểmTraCookieToolStripMenuItem";
			this.kiểmTraCookieToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraCookieToolStripMenuItem.Text = "Check Cookie";
			
			this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
			this.checkAvatarToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.checkAvatarToolStripMenuItem.Text = "Check Avatar";
	
			this.checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
			this.checkProfileToolStripMenuItem1.Size = new global::System.Drawing.Size(164, 22);
			this.checkProfileToolStripMenuItem1.Text = "Check Profile";
		
			this.checkBackupToolStripMenuItem1.Name = "checkBackupToolStripMenuItem1";
			this.checkBackupToolStripMenuItem1.Size = new global::System.Drawing.Size(164, 22);
			this.checkBackupToolStripMenuItem1.Text = "Check Backup";
			
			this.kiểmTraTàiKhoảnToolStripMenuItem.Name = "kiểmTraTàiKhoảnToolStripMenuItem";
			this.kiểmTraTàiKhoảnToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraTàiKhoảnToolStripMenuItem.Text = "Dạng checkpoint";
			this.kiểmTraTàiKhoảnToolStripMenuItem.ToolTipText = "Chỉ sử dụng khi tài khoản đã bị checkpoint!";
		
			this.kiểmTraMailpassMailToolStripMenuItem.Name = "kiểmTraMailpassMailToolStripMenuItem";
			this.kiểmTraMailpassMailToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraMailpassMailToolStripMenuItem.Text = "Mail|pass Mail";
		
			this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
			this.checkProxyToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.checkProxyToolStripMenuItem.Text = "Check Proxy";

			this.profileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.xóaProfileToolStripMenuItem,
				this.donDepProfileToolStripMenuItem
			});
			this.profileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("profileToolStripMenuItem.Image");
			this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
			this.profileToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.profileToolStripMenuItem.Text = "Profile Chrome";
			this.xóaProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("xóaProfileToolStripMenuItem.Image");
			this.xóaProfileToolStripMenuItem.Name = "xóaProfileToolStripMenuItem";
			this.xóaProfileToolStripMenuItem.Size = new global::System.Drawing.Size(156, 22);
			this.xóaProfileToolStripMenuItem.Text = "Xóa profile";

			this.donDepProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("donDepProfileToolStripMenuItem.Image");
			this.donDepProfileToolStripMenuItem.Name = "donDepProfileToolStripMenuItem";
			this.donDepProfileToolStripMenuItem.Size = new global::System.Drawing.Size(156, 22);
			this.donDepProfileToolStripMenuItem.Text = "Dọn dẹp profile";
	
			this.backupToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.checkBackupToolStripMenuItem,
				this.mởThưMụcBackupToolStripMenuItem,
				this.backupToolStripMenuItem1,
				this.xóaDữLiệuBackupToolStripMenuItem
			});
			this.backupToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("backupToolStripMenuItem.Image");
			this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
			this.backupToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.backupToolStripMenuItem.Text = "Backup dữ liệu";
			this.checkBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.find_and_replace_25px;
			this.checkBackupToolStripMenuItem.Name = "checkBackupToolStripMenuItem";
			this.checkBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.checkBackupToolStripMenuItem.Text = "Check Backup";
	
			this.mởThưMụcBackupToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mởFileHTMLToolStripMenuItem,
				this.mởFolderBackupToolStripMenuItem
			});
			this.mởThưMụcBackupToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mởThưMụcBackupToolStripMenuItem.Image");
			this.mởThưMụcBackupToolStripMenuItem.Name = "mởThưMụcBackupToolStripMenuItem";
			this.mởThưMụcBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.mởThưMụcBackupToolStripMenuItem.Text = "Mở dữ liêu Backup";
			this.mởFileHTMLToolStripMenuItem.Name = "mởFileHTMLToolStripMenuItem";
			this.mởFileHTMLToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.mởFileHTMLToolStripMenuItem.Text = "File HTML";
		
			this.mởFolderBackupToolStripMenuItem.Name = "mởFolderBackupToolStripMenuItem";
			this.mởFolderBackupToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.mởFolderBackupToolStripMenuItem.Text = "Folder Backup";
		
			this.backupToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.htmlToolStripMenuItem,
				this.thưMụcToolStripMenuItem
			});
			this.backupToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("backupToolStripMenuItem1.Image");
			this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
			this.backupToolStripMenuItem1.Size = new global::System.Drawing.Size(183, 22);
			this.backupToolStripMenuItem1.Text = "Copy dữ liệu Backup";
			this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
			this.htmlToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.htmlToolStripMenuItem.Text = "File HTML";
		
			this.thưMụcToolStripMenuItem.Name = "thưMụcToolStripMenuItem";
			this.thưMụcToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.thưMụcToolStripMenuItem.Text = "Folder Backup";
		
			this.xóaDữLiệuBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.close_window_25px;
			this.xóaDữLiệuBackupToolStripMenuItem.Name = "xóaDữLiệuBackupToolStripMenuItem";
			this.xóaDữLiệuBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.xóaDữLiệuBackupToolStripMenuItem.Text = "Xóa dữ liệu Backup";
	
			this.tảiLạiDanhSáchToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
			this.tảiLạiDanhSáchToolStripMenuItem.Name = "tảiLạiDanhSáchToolStripMenuItem";
			this.tảiLạiDanhSáchToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.tảiLạiDanhSáchToolStripMenuItem.Text = "Tải lại danh sách";

			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.pnlHeader;
			this.bunifuDragControl1.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(1203, 29);
			this.pnlHeader.TabIndex = 0;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(6, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
	
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button2.Image");
			this.button2.Location = new global::System.Drawing.Point(1107, 0);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(32, 29);
			this.button2.TabIndex = 0;
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
		
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.Location = new global::System.Drawing.Point(1139, 0);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(32, 29);
			this.button1.TabIndex = 1;
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
	
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnMinimize.Image");
			this.btnMinimize.Location = new global::System.Drawing.Point(1171, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 29);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
	
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(43, 6);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(186, 16);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = "Danh sách tài khoản đã xóa";
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.DarkRed;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(1204, 38);
			this.bunifuCards1.TabIndex = 0;
			this.menuStrip1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = global::System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.thoátToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 37);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new global::System.Drawing.Size(1201, 25);
			this.menuStrip1.Stretch = false;
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.thoátToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_show_property_48px;
			this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			this.thoátToolStripMenuItem.Size = new global::System.Drawing.Size(132, 21);
			this.thoátToolStripMenuItem.Text = "Cấu hình hiển thị";
		
			this.grQuanLyThuMuc.Controls.Add(this.btnLoadAcc);
			this.grQuanLyThuMuc.Controls.Add(this.cbbTinhTrang);
			this.grQuanLyThuMuc.Controls.Add(this.cbbThuMuc);
			this.grQuanLyThuMuc.Controls.Add(this.label2);
			this.grQuanLyThuMuc.Controls.Add(this.label1);
			this.grQuanLyThuMuc.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grQuanLyThuMuc.Location = new global::System.Drawing.Point(292, 65);
			this.grQuanLyThuMuc.Name = "grQuanLyThuMuc";
			this.grQuanLyThuMuc.Size = new global::System.Drawing.Size(445, 53);
			this.grQuanLyThuMuc.TabIndex = 5;
			this.grQuanLyThuMuc.TabStop = false;
			this.grQuanLyThuMuc.Text = "Quản lý thư mục";
			this.btnLoadAcc.BackgroundImage = global::maxcare.Properties.Resources.available_updates_25px;
			this.btnLoadAcc.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.btnLoadAcc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnLoadAcc.Location = new global::System.Drawing.Point(416, 19);
			this.btnLoadAcc.Name = "btnLoadAcc";
			this.btnLoadAcc.Size = new global::System.Drawing.Size(25, 25);
			this.btnLoadAcc.TabIndex = 6;
			this.toolTip1.SetToolTip(this.btnLoadAcc, "Load lại danh sách");
			this.btnLoadAcc.UseSelectable = true;
	
			this.cbbTinhTrang.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbTinhTrang.DropDownWidth = 300;
			this.cbbTinhTrang.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbTinhTrang.FormattingEnabled = true;
			this.cbbTinhTrang.ItemHeight = 19;
			this.cbbTinhTrang.Items.AddRange(new object[]
			{
				"[Tất cả tình trạng]"
			});
			this.cbbTinhTrang.Location = new global::System.Drawing.Point(289, 19);
			this.cbbTinhTrang.Name = "cbbTinhTrang";
			this.cbbTinhTrang.Size = new global::System.Drawing.Size(121, 25);
			this.cbbTinhTrang.TabIndex = 3;
			this.cbbTinhTrang.UseSelectable = true;

			this.cbbThuMuc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbThuMuc.DropDownWidth = 350;
			this.cbbThuMuc.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbThuMuc.FormattingEnabled = true;
			this.cbbThuMuc.ItemHeight = 19;
			this.cbbThuMuc.Items.AddRange(new object[]
			{
				"[Tất cả thư mục]"
			});
			this.cbbThuMuc.Location = new global::System.Drawing.Point(72, 19);
			this.cbbThuMuc.Name = "cbbThuMuc";
			this.cbbThuMuc.Size = new global::System.Drawing.Size(173, 25);
			this.cbbThuMuc.TabIndex = 1;
			this.cbbThuMuc.UseSelectable = true;

			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(249, 22);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(42, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lọc:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(8, 23);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thư mục:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.grTimKiem.Controls.Add(this.BtnSearch);
			this.grTimKiem.Controls.Add(this.cbbSearch);
			this.grTimKiem.Controls.Add(this.txbSearch);
			this.grTimKiem.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grTimKiem.Location = new global::System.Drawing.Point(2, 65);
			this.grTimKiem.Name = "grTimKiem";
			this.grTimKiem.Size = new global::System.Drawing.Size(284, 53);
			this.grTimKiem.TabIndex = 4;
			this.grTimKiem.TabStop = false;
			this.grTimKiem.Text = "Tìm kiếm";
			this.BtnSearch.BackgroundImage = global::maxcare.Properties.Resources.icons8_search_24px_1;
			this.BtnSearch.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.BtnSearch.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.BtnSearch.Location = new global::System.Drawing.Point(253, 18);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new global::System.Drawing.Size(24, 24);
			this.BtnSearch.TabIndex = 2;
			this.BtnSearch.UseSelectable = true;
	
			this.cbbSearch.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbSearch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbSearch.DropDownWidth = 100;
			this.cbbSearch.FormattingEnabled = true;
			this.cbbSearch.Location = new global::System.Drawing.Point(12, 18);
			this.cbbSearch.Name = "cbbSearch";
			this.cbbSearch.Size = new global::System.Drawing.Size(86, 24);
			this.cbbSearch.TabIndex = 0;
			this.txbSearch.BorderColor = global::System.Drawing.Color.SeaGreen;
			this.txbSearch.Location = new global::System.Drawing.Point(104, 19);
			this.txbSearch.Name = "txbSearch";
			this.txbSearch.Size = new global::System.Drawing.Size(143, 23);
			this.txbSearch.TabIndex = 1;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl2.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 0;
			this.toolTip1.ReshowDelay = 40;
			this.statusStrip1.BackColor = global::System.Drawing.SystemColors.Control;
			this.statusStrip1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel5,
				this.lblCountSelect,
				this.toolStripStatusLabel7,
				this.lblCountTotal
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 588);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(1204, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel5.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new global::System.Drawing.Size(66, 17);
			this.toolStripStatusLabel5.Text = "Đã chọn:";
			this.lblCountSelect.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCountSelect.ForeColor = global::System.Drawing.Color.FromArgb(0, 64, 0);
			this.lblCountSelect.Name = "lblCountSelect";
			this.lblCountSelect.Size = new global::System.Drawing.Size(16, 17);
			this.lblCountSelect.Text = "0";
			this.toolStripStatusLabel7.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
			this.toolStripStatusLabel7.Size = new global::System.Drawing.Size(53, 17);
			this.toolStripStatusLabel7.Text = "Tất cả:";
			this.lblCountTotal.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCountTotal.ForeColor = global::System.Drawing.Color.Maroon;
			this.lblCountTotal.Name = "lblCountTotal";
			this.lblCountTotal.Size = new global::System.Drawing.Size(16, 17);
			this.lblCountTotal.Text = "0";
			this.button9.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button9.BackColor = global::System.Drawing.Color.White;
			this.button9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button9.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.Image = global::maxcare.Properties.Resources.icons8_sync;
			this.button9.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.Location = new global::System.Drawing.Point(836, 78);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(158, 34);
			this.button9.TabIndex = 12;
			this.button9.Text = "Khôi phục tài khoản";
			this.button9.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button9.UseVisualStyleBackColor = true;
		
			this.button3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button3.BackColor = global::System.Drawing.Color.White;
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Image = global::maxcare.Properties.Resources.icons8_delete_bin;
			this.button3.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new global::System.Drawing.Point(1000, 78);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(201, 34);
			this.button3.TabIndex = 12;
			this.button3.Text = "Xóa tài khoản vĩnh viễn";
			this.button3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = true;
	
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.BackColor = global::System.Drawing.SystemColors.Control;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Location = new global::System.Drawing.Point(688, 591);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(515, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "[Bôi đen nhiều dòng rồi nhấn phím Space] hoặc [Click đúp vào tài khoản] để tích chọn!";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;

			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1204, 610);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.grTimKiem);
			base.Controls.Add(this.grQuanLyThuMuc);
			base.Controls.Add(this.dtgvAcc);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.menuStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "fBin";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MAX CARE";

			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
			this.ctmsAcc.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.grQuanLyThuMuc.ResumeLayout(false);
			this.grTimKiem.ResumeLayout(false);
			this.grTimKiem.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400036B RID: 875
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400036C RID: 876
		public global::System.Windows.Forms.DataGridView dtgvAcc;

		// Token: 0x0400036D RID: 877
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400036E RID: 878
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400036F RID: 879
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000370 RID: 880
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000371 RID: 881
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000372 RID: 882
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000373 RID: 883
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000374 RID: 884
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000375 RID: 885
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000376 RID: 886
		private global::System.Windows.Forms.GroupBox grQuanLyThuMuc;

		// Token: 0x04000377 RID: 887
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000378 RID: 888
		private global::MetroFramework.Controls.MetroComboBox cbbThuMuc;

		// Token: 0x04000379 RID: 889
		private global::MetroFramework.Controls.MetroContextMenu ctmsAcc;

		// Token: 0x0400037A RID: 890
		private global::System.Windows.Forms.ToolStripMenuItem chọnLiveToolStripMenuItem;

		// Token: 0x0400037B RID: 891
		private global::System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;

		// Token: 0x0400037C RID: 892
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x0400037D RID: 893
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem;

		// Token: 0x0400037E RID: 894
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;

		// Token: 0x0400037F RID: 895
		private global::System.Windows.Forms.ToolStripMenuItem uidPassToolStripMenuItem;

		// Token: 0x04000380 RID: 896
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		// Token: 0x04000381 RID: 897
		private global::System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;

		// Token: 0x04000382 RID: 898
		private global::System.Windows.Forms.ToolStripMenuItem checkCookieToolStripMenuItem;

		// Token: 0x04000383 RID: 899
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;

		// Token: 0x04000384 RID: 900
		private global::System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;

		// Token: 0x04000385 RID: 901
		private global::System.Windows.Forms.ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;

		// Token: 0x04000386 RID: 902
		private global::System.Windows.Forms.ToolStripMenuItem passToolStripMenuItem;

		// Token: 0x04000387 RID: 903
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraCookieToolStripMenuItem;

		// Token: 0x04000388 RID: 904
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTokenToolStripMenuItem;

		// Token: 0x04000389 RID: 905
		private global::System.Windows.Forms.ToolStripMenuItem tảiLạiDanhSáchToolStripMenuItem;

		// Token: 0x0400038A RID: 906
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTàiKhoảnToolStripMenuItem;

		// Token: 0x0400038B RID: 907
		private global::System.Windows.Forms.ToolStripMenuItem mailPassMailToolStripMenuItem;

		// Token: 0x0400038C RID: 908
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

		// Token: 0x0400038D RID: 909
		private global::System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

		// Token: 0x0400038E RID: 910
		private global::System.Windows.Forms.ToolStripMenuItem trạngTháiToolStripMenuItem;

		// Token: 0x0400038F RID: 911
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraWallToolStripMenuItem;

		// Token: 0x04000390 RID: 912
		private global::System.Windows.Forms.GroupBox grTimKiem;

		// Token: 0x04000391 RID: 913
		private global::WindowsFormsControlLibrary1.BunifuCustomTextbox txbSearch;

		// Token: 0x04000392 RID: 914
		private global::System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;

		// Token: 0x04000393 RID: 915
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

		// Token: 0x04000394 RID: 916
		private global::System.Windows.Forms.ToolStripMenuItem xóaProfileToolStripMenuItem;

		// Token: 0x04000395 RID: 917
		private global::System.Windows.Forms.ToolStripMenuItem fAToolStripMenuItem;

		// Token: 0x04000396 RID: 918
		private global::System.Windows.Forms.ToolStripMenuItem tinhTrangToolStripMenuItem;

		// Token: 0x04000397 RID: 919
		private global::System.Windows.Forms.ToolStripMenuItem uidPass2FaToolStripMenuItem;

		// Token: 0x04000398 RID: 920
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000399 RID: 921
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400039A RID: 922
		private global::System.Windows.Forms.ToolStripMenuItem đinhDangKhacToolStripMenuItem;

		// Token: 0x0400039B RID: 923
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;

		// Token: 0x0400039C RID: 924
		private global::System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;

		// Token: 0x0400039D RID: 925
		private global::System.Windows.Forms.ToolStripMenuItem thưMụcToolStripMenuItem;

		// Token: 0x0400039E RID: 926
		private global::System.Windows.Forms.ToolStripMenuItem maBaoMât6SôToolStripMenuItem;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.Forms.ToolStripMenuItem donDepProfileToolStripMenuItem;

		// Token: 0x040003A0 RID: 928
		private global::System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;

		// Token: 0x040003A1 RID: 929
		private global::System.Windows.Forms.ToolStripMenuItem useragentToolStripMenuItem1;

		// Token: 0x040003A2 RID: 930
		private global::System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem1;

		// Token: 0x040003A3 RID: 931
		private global::System.Windows.Forms.ComboBox cbbSearch;

		// Token: 0x040003A4 RID: 932
		private global::System.Windows.Forms.ToolStripMenuItem mởThưMụcBackupToolStripMenuItem;

		// Token: 0x040003A5 RID: 933
		private global::MetroFramework.Controls.MetroButton btnLoadAcc;

		// Token: 0x040003A6 RID: 934
		private global::MetroFramework.Controls.MetroComboBox cbbTinhTrang;

		// Token: 0x040003A7 RID: 935
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003A8 RID: 936
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraMailpassMailToolStripMenuItem;

		// Token: 0x040003A9 RID: 937
		private global::MetroFramework.Controls.MetroButton BtnSearch;

		// Token: 0x040003AA RID: 938
		private global::System.Windows.Forms.ToolStripMenuItem uidToolStripMenuItem;

		// Token: 0x040003AB RID: 939
		private global::System.Windows.Forms.ToolStripMenuItem checkAvatarToolStripMenuItem;

		// Token: 0x040003AC RID: 940
		private global::System.Windows.Forms.ToolStripMenuItem checkProxyToolStripMenuItem;

		// Token: 0x040003AD RID: 941
		private global::System.Windows.Forms.ToolStripMenuItem checkProfileToolStripMenuItem1;

		// Token: 0x040003AE RID: 942
		private global::System.Windows.Forms.ToolStripMenuItem xóaDữLiệuBackupToolStripMenuItem;

		// Token: 0x040003AF RID: 943
		private global::System.Windows.Forms.ToolStripMenuItem mởFolderBackupToolStripMenuItem;

		// Token: 0x040003B0 RID: 944
		private global::System.Windows.Forms.ToolStripMenuItem mởFileHTMLToolStripMenuItem;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem;

		// Token: 0x040003B2 RID: 946
		private global::System.Windows.Forms.ToolStripMenuItem checkInfoUIDToolStripMenuItem;

		// Token: 0x040003B3 RID: 947
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem1;

		// Token: 0x040003B4 RID: 948
		private global::System.Windows.Forms.ToolStripMenuItem khôiPhucTaiKhoanToolStripMenuItem;

		// Token: 0x040003B5 RID: 949
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040003B6 RID: 950
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;

		// Token: 0x040003B7 RID: 951
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountSelect;

		// Token: 0x040003B8 RID: 952
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;

		// Token: 0x040003B9 RID: 953
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountTotal;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn cChose;

		// Token: 0x040003BB RID: 955
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x040003BC RID: 956
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x040003BD RID: 957
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUid;

		// Token: 0x040003BE RID: 958
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cToken;

		// Token: 0x040003BF RID: 959
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cCookies;

		// Token: 0x040003C0 RID: 960
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cEmail;

		// Token: 0x040003C1 RID: 961
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPhone;

		// Token: 0x040003C2 RID: 962
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cName;

		// Token: 0x040003C3 RID: 963
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFollow;

		// Token: 0x040003C4 RID: 964
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFriend;

		// Token: 0x040003C5 RID: 965
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGroup;

		// Token: 0x040003C6 RID: 966
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;

		// Token: 0x040003C7 RID: 967
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGender;

		// Token: 0x040003C8 RID: 968
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassword;

		// Token: 0x040003C9 RID: 969
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cMailRecovery;

		// Token: 0x040003CA RID: 970
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassMail;

		// Token: 0x040003CB RID: 971
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBackup;

		// Token: 0x040003CC RID: 972
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFa2;

		// Token: 0x040003CD RID: 973
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUseragent;

		// Token: 0x040003CE RID: 974
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProxy;

		// Token: 0x040003CF RID: 975
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cDateCreateAcc;

		// Token: 0x040003D0 RID: 976
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cAvatar;

		// Token: 0x040003D1 RID: 977
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProfile;

		// Token: 0x040003D2 RID: 978
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cThuMuc;

		// Token: 0x040003D3 RID: 979
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInteractEnd;

		// Token: 0x040003D4 RID: 980
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInfo;

		// Token: 0x040003D5 RID: 981
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;

		// Token: 0x040003D6 RID: 982
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cDateDelete;

		// Token: 0x040003D7 RID: 983
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStatus;

		// Token: 0x040003D8 RID: 984
		private global::System.Windows.Forms.Button button9;

		// Token: 0x040003D9 RID: 985
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040003DA RID: 986
		private global::System.Windows.Forms.ToolStripMenuItem mởTrìnhDuyệtToolStripMenuItem;

		// Token: 0x040003DB RID: 987
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.Forms.ToolStripMenuItem tiếnHànhMởToolStripMenuItem;

		// Token: 0x040003DD RID: 989
		private global::System.Windows.Forms.ToolStripMenuItem càiĐặtCấuHìnhMởToolStripMenuItem;
	}
}
