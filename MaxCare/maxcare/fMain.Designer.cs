namespace maxcare
{
	// Token: 0x0200012F RID: 303
	public partial class fMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F67 RID: 3943 RVA: 0x002AA550 File Offset: 0x002A8750
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x002AA5B0 File Offset: 0x002A87B0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fMain));
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
			this.cStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctmsAcc = new global::MetroFramework.Controls.MetroContextMenu(this.components);
			this.chọnLiveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.liveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tinhTrangToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trạngTháiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bỏChọnTấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
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
			this.mởTrìnhDuyệtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởLuônToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.càiĐặtCấuHìnhMởToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaTàiKhoảnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraWallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkInfoUIDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkAvatarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProfileToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraMailpassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProxyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.câpNhâtThôngTinCaNhânToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sưDungTokenTrungGianToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sửDụngCookieTrungGianToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cậpNhậtDữLiệuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cậpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mậtKhẩuToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tựĐộngLấyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenEAAAAZToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenBussinessToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhậpDữLiệuToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mailKhôiPhụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.passMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mã2FAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.useragentToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.proxyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ghiChuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ngàySinhToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chuyểnThưMụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.locTrungToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.taoShortcutChromeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tảiXuốngAvatarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loginHotmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loginYandexToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loginGmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFormQuảnLýTinNhắnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.khôiPhụcMậtKhẩuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đổiPassHotmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.profileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tạoProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đăngNhâpBăngUidpassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đăngNhâpBăngCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.donDepProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaCacheToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.taoFileHTMLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởThưMụcBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFileHTMLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFolderBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.htmlToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fileTxtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thưMụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaDữLiệuBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dọnDẹpBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giaiCheckpointToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giảiCheckpintNgàySinhToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giảiCP282ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tảiLạiDanhSáchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.lblNotify = new global::System.Windows.Forms.LinkLabel();
			this.lblStatusUpdate = new global::System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.càiĐặtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.taiKhoanĐaXoaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tiệnÍchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkLiveUidToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProxyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkHotmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lọcTrùngDữLiệuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xửLýChuỗiOnlineToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.liênHệToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.grQuanLyThuMuc = new global::System.Windows.Forms.GroupBox();
			this.btnLoadAcc = new global::MetroFramework.Controls.MetroButton();
			this.btnEditFile = new global::MetroFramework.Controls.MetroButton();
			this.btnDeleteFile = new global::MetroFramework.Controls.MetroButton();
			this.AddFileAccount = new global::MetroFramework.Controls.MetroButton();
			this.cbbTinhTrang = new global::MetroFramework.Controls.MetroComboBox();
			this.cbbThuMuc = new global::MetroFramework.Controls.MetroComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button9 = new global::System.Windows.Forms.Button();
			this.grTimKiem = new global::System.Windows.Forms.GroupBox();
			this.BtnSearch = new global::MetroFramework.Controls.MetroButton();
			this.cbbSearch = new global::System.Windows.Forms.ComboBox();
			this.txbSearch = new global::WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblKey = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel8 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.txbUid = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblUser = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel9 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel10 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblDateExpried = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountSelect = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel7 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountTotal = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.btnViewLivestream = new global::System.Windows.Forms.Button();
			this.btnShare = new global::System.Windows.Forms.Button();
			this.btnPost = new global::System.Windows.Forms.Button();
			this.btnPause = new global::System.Windows.Forms.Button();
			this.btnInteract = new global::System.Windows.Forms.Button();
			this.plChucNang = new global::System.Windows.Forms.Panel();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.btnRandomIndexRow = new global::MetroFramework.Controls.MetroButton();
			this.plTrangThai = new global::System.Windows.Forms.Panel();
			this.lblTrangThai = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
			this.ctmsAcc.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.grQuanLyThuMuc.SuspendLayout();
			this.grTimKiem.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.plChucNang.SuspendLayout();
			this.plTrangThai.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.dtgvAcc.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtgvAcc.Location = new global::System.Drawing.Point(9, 156);
			this.dtgvAcc.Name = "dtgvAcc";
			this.dtgvAcc.RowHeadersVisible = false;
			this.dtgvAcc.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvAcc.Size = new global::System.Drawing.Size(1225, 423);
			this.dtgvAcc.TabIndex = 0;

			this.cChose.HeaderText = "Chọn";
			this.cChose.Name = "cChose";
			this.cChose.Width = 40;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
			this.cStt.HeaderText = "STT";
			this.cStt.Name = "cStt";
			this.cStt.Width = 35;
			this.cId.HeaderText = "Id";
			this.cId.Name = "cId";
			this.cId.Visible = false;
			this.cId.Width = 90;
			this.cUid.HeaderText = "UID";
			this.cUid.Name = "cUid";
			this.cUid.Width = 80;
			this.cToken.HeaderText = "Token";
			this.cToken.Name = "cToken";
			this.cToken.Width = 70;
			this.cCookies.HeaderText = "Cookie";
			this.cCookies.Name = "cCookies";
			this.cCookies.Width = 70;
			this.cEmail.HeaderText = "Email";
			this.cEmail.Name = "cEmail";
			this.cEmail.Width = 60;
			this.cPhone.HeaderText = "Phone";
			this.cPhone.Name = "cPhone";
			this.cPhone.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPhone.Visible = false;
			this.cPhone.Width = 90;
			this.cName.HeaderText = "Tên";
			this.cName.Name = "cName";
			this.cName.Width = 70;
			this.cFollow.HeaderText = "Theo dõi";
			this.cFollow.Name = "cFollow";
			this.cFollow.Width = 80;
			this.cFriend.HeaderText = "Bạn bè";
			this.cFriend.Name = "cFriend";
			this.cFriend.Width = 70;
			this.cGroup.HeaderText = "Nhóm";
			this.cGroup.Name = "cGroup";
			this.cGroup.Width = 60;
			this.cBirthday.HeaderText = "Ngày sinh";
			this.cBirthday.Name = "cBirthday";
			this.cBirthday.Width = 90;
			this.cGender.HeaderText = "Giới Tính";
			this.cGender.Name = "cGender";
			this.cGender.Width = 80;
			this.cPassword.HeaderText = "Mật khẩu";
			this.cPassword.Name = "cPassword";
			this.cPassword.Visible = false;
			this.cPassword.Width = 70;
			this.cMailRecovery.HeaderText = "Email khôi phục";
			this.cMailRecovery.Name = "cMailRecovery";
			this.cMailRecovery.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cMailRecovery.Visible = false;
			this.cMailRecovery.Width = 120;
			this.cPassMail.HeaderText = "Mật khẩu mail";
			this.cPassMail.Name = "cPassMail";
			this.cPassMail.Visible = false;
			this.cPassMail.Width = 120;
			this.cBackup.HeaderText = "Backup";
			this.cBackup.Name = "cBackup";
			this.cBackup.Width = 70;
			this.cFa2.HeaderText = "Mã 2FA";
			this.cFa2.Name = "cFa2";
			this.cFa2.Width = 65;
			this.cUseragent.HeaderText = "Useragent";
			this.cUseragent.Name = "cUseragent";
			this.cUseragent.Width = 70;
			this.cProxy.HeaderText = "Proxy";
			this.cProxy.Name = "cProxy";
			this.cProxy.Width = 55;
			this.cDateCreateAcc.HeaderText = "Ngày tạo";
			this.cDateCreateAcc.Name = "cDateCreateAcc";
			this.cDateCreateAcc.Width = 85;
			this.cAvatar.HeaderText = "Avatar";
			this.cAvatar.Name = "cAvatar";
			this.cAvatar.Width = 50;
			this.cProfile.HeaderText = "Profile";
			this.cProfile.Name = "cProfile";
			this.cProfile.Width = 50;
			this.cThuMuc.HeaderText = "Thư mục";
			this.cThuMuc.Name = "cThuMuc";
			this.cInteractEnd.HeaderText = "Lần tương tác cuối";
			this.cInteractEnd.Name = "cInteractEnd";
			this.cInfo.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cInfo.HeaderText = "Tình Trạng";
			this.cInfo.Name = "cInfo";
			this.cInfo.Width = 90;
			this.cGhiChu.HeaderText = "Ghi Chú";
			this.cGhiChu.Name = "cGhiChu";
			this.cStatus.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cStatus.HeaderText = "Trạng Thái";
			this.cStatus.MinimumWidth = 200;
			this.cStatus.Name = "cStatus";
			this.ctmsAcc.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chọnLiveToolStripMenuItem,
				this.bỏChọnTấtCảToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.mởTrìnhDuyệtToolStripMenuItem,
				this.xóaTàiKhoảnToolStripMenuItem,
				this.checkCookieToolStripMenuItem,
				this.câpNhâtThôngTinCaNhânToolStripMenuItem,
				this.cậpNhậtDữLiệuToolStripMenuItem,
				this.chuyểnThưMụcToolStripMenuItem,
				this.chứcNăngToolStripMenuItem1,
				this.profileToolStripMenuItem,
				this.backupToolStripMenuItem,
				this.giaiCheckpointToolStripMenuItem,
				this.tảiLạiDanhSáchToolStripMenuItem
			});
			this.ctmsAcc.Name = "ctmsAcc";
			this.ctmsAcc.Size = new global::System.Drawing.Size(175, 312);
			this.chọnLiveToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tấtCảToolStripMenuItem,
				this.liveToolStripMenuItem,
				this.tinhTrangToolStripMenuItem,
				this.trạngTháiToolStripMenuItem
			});
			this.chọnLiveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chọnLiveToolStripMenuItem.Image");
			this.chọnLiveToolStripMenuItem.Name = "chọnLiveToolStripMenuItem";
			this.chọnLiveToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.chọnLiveToolStripMenuItem.Text = "Chọn";
			this.tấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tấtCảToolStripMenuItem.Image");
			this.tấtCảToolStripMenuItem.Name = "tấtCảToolStripMenuItem";
			this.tấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.tấtCảToolStripMenuItem.Text = "Tất cả";
			this.liveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("liveToolStripMenuItem.Image");
			this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
			this.liveToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.liveToolStripMenuItem.Text = "Bôi đen";
		
			this.tinhTrangToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tinhTrangToolStripMenuItem.Image");
			this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
			this.tinhTrangToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.tinhTrangToolStripMenuItem.Text = "Tình trạng";
			this.trạngTháiToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("trạngTháiToolStripMenuItem.Image");
			this.trạngTháiToolStripMenuItem.Name = "trạngTháiToolStripMenuItem";
			this.trạngTháiToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.trạngTháiToolStripMenuItem.Text = "Trạng thái";
	
			this.bỏChọnTấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
			this.bỏChọnTấtCảToolStripMenuItem.Name = "bỏChọnTấtCảToolStripMenuItem";
			this.bỏChọnTấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.bỏChọnTấtCảToolStripMenuItem.Text = "Bỏ chọn tất cả";
			
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
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
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
			this.maBaoMât6SôToolStripMenuItem.Text = "Mã bảo mật 6 số từ 2FA";
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
			this.đinhDangKhacToolStripMenuItem.Text = "Other...";
		
			this.mởTrìnhDuyệtToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mởLuônToolStripMenuItem,
				this.càiĐặtCấuHìnhMởToolStripMenuItem
			});
			this.mởTrìnhDuyệtToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mởTrìnhDuyệtToolStripMenuItem.Image");
			this.mởTrìnhDuyệtToolStripMenuItem.Name = "mởTrìnhDuyệtToolStripMenuItem";
			this.mởTrìnhDuyệtToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.mởTrìnhDuyệtToolStripMenuItem.Text = "Mở trình duyệt";
			this.mởLuônToolStripMenuItem.Name = "mởLuônToolStripMenuItem";
			this.mởLuônToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.mởLuônToolStripMenuItem.Text = "Tiến hành mở";
		
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Name = "càiĐặtCấuHìnhMởToolStripMenuItem";
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Text = "Cài đặt cấu hình mở";
		
			this.xóaTàiKhoảnToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("xóaTàiKhoảnToolStripMenuItem.Image");
			this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
			this.xóaTàiKhoảnToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản";
	
			this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.kiểmTraWallToolStripMenuItem,
				this.checkInfoUIDToolStripMenuItem,
				this.kiểmTraTokenToolStripMenuItem,
				this.kiểmTraCookieToolStripMenuItem,
				this.checkAvatarToolStripMenuItem,
				this.checkProfileToolStripMenuItem1,
				this.checkBackupToolStripMenuItem1,
				this.kiểmTraMailpassMailToolStripMenuItem,
				this.checkProxyToolStripMenuItem
			});
			this.checkCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("checkCookieToolStripMenuItem.Image");
			this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
			this.checkCookieToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
		
			this.kiểmTraWallToolStripMenuItem.Name = "kiểmTraWallToolStripMenuItem";
			this.kiểmTraWallToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraWallToolStripMenuItem.Text = "Check Wall";
			this.kiểmTraWallToolStripMenuItem.ToolTipText = "Không cần dùng token";
		
			this.checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
			this.checkInfoUIDToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.checkInfoUIDToolStripMenuItem.Text = "Check Info UID";
			this.checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCập nhật thông tin: Họ tên, Giớ́i tính, [Email], [Bạn bè], [Nhóm], [Ngày sinh]";
		
			this.kiểmTraTokenToolStripMenuItem.Name = "kiểmTraTokenToolStripMenuItem";
			this.kiểmTraTokenToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraTokenToolStripMenuItem.Text = "Check Token";

			this.kiểmTraCookieToolStripMenuItem.Name = "kiểmTraCookieToolStripMenuItem";
			this.kiểmTraCookieToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraCookieToolStripMenuItem.Text = "Check Cookie";
		
			this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
			this.checkAvatarToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.checkAvatarToolStripMenuItem.Text = "Check Avatar";

			this.checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
			this.checkProfileToolStripMenuItem1.Size = new global::System.Drawing.Size(153, 22);
			this.checkProfileToolStripMenuItem1.Text = "Check Profile";
			
			this.checkBackupToolStripMenuItem1.Name = "checkBackupToolStripMenuItem1";
			this.checkBackupToolStripMenuItem1.Size = new global::System.Drawing.Size(153, 22);
			this.checkBackupToolStripMenuItem1.Text = "Check Backup";
		
			this.kiểmTraMailpassMailToolStripMenuItem.Name = "kiểmTraMailpassMailToolStripMenuItem";
			this.kiểmTraMailpassMailToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraMailpassMailToolStripMenuItem.Text = "Mail|pass Mail";
		
			this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
			this.checkProxyToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.checkProxyToolStripMenuItem.Text = "Check Proxy";
	
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.sưDungTokenTrungGianToolStripMenuItem,
				this.sửDụngCookieTrungGianToolStripMenuItem
			});
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("câpNhâtThôngTinCaNhânToolStripMenuItem.Image");
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Name = "câpNhâtThôngTinCaNhânToolStripMenuItem";
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Text = "Cập nhật thông tin";
			this.sưDungTokenTrungGianToolStripMenuItem.Name = "sưDungTokenTrungGianToolStripMenuItem";
			this.sưDungTokenTrungGianToolStripMenuItem.Size = new global::System.Drawing.Size(216, 22);
			this.sưDungTokenTrungGianToolStripMenuItem.Text = "Sử dụng Token trung gian";
			this.sưDungTokenTrungGianToolStripMenuItem.ToolTipText = "Cập nhật thông tin: Họ tên, Giớ́i tính, [Email], [Bạn bè], [Nhóm], [Ngày sinh]";
			
			this.sửDụngCookieTrungGianToolStripMenuItem.Name = "sửDụngCookieTrungGianToolStripMenuItem";
			this.sửDụngCookieTrungGianToolStripMenuItem.Size = new global::System.Drawing.Size(216, 22);
			this.sửDụngCookieTrungGianToolStripMenuItem.Text = "Sử dụng Cookie trung gian";
		
			this.cậpNhậtDữLiệuToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cậpToolStripMenuItem,
				this.mậtKhẩuToolStripMenuItem1,
				this.tokenToolStripMenuItem2,
				this.cookieToolStripMenuItem3,
				this.mailKhôiPhụcToolStripMenuItem,
				this.passMailToolStripMenuItem,
				this.mã2FAToolStripMenuItem,
				this.useragentToolStripMenuItem,
				this.proxyToolStripMenuItem,
				this.ghiChuToolStripMenuItem,
				this.ngàySinhToolStripMenuItem
			});
			this.cậpNhậtDữLiệuToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cậpNhậtDữLiệuToolStripMenuItem.Image");
			this.cậpNhậtDữLiệuToolStripMenuItem.Name = "cậpNhậtDữLiệuToolStripMenuItem";
			this.cậpNhậtDữLiệuToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.cậpNhậtDữLiệuToolStripMenuItem.Text = "Cập nhật dữ liệu";
			this.cậpToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_multiline_text_32px;
			this.cậpToolStripMenuItem.Name = "cậpToolStripMenuItem";
			this.cậpToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.cậpToolStripMenuItem.Text = "Cập nhật hàng loạt theo UID";
			this.mậtKhẩuToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mậtKhẩuToolStripMenuItem1.Image");
			this.mậtKhẩuToolStripMenuItem1.Name = "mậtKhẩuToolStripMenuItem1";
			this.mậtKhẩuToolStripMenuItem1.Size = new global::System.Drawing.Size(224, 22);
			this.mậtKhẩuToolStripMenuItem1.Text = "Password";
			this.tokenToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tựĐộngLấyToolStripMenuItem1,
				this.nhậpDữLiệuToolStripMenuItem2
			});
			this.tokenToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tokenToolStripMenuItem2.Image");
			this.tokenToolStripMenuItem2.Name = "tokenToolStripMenuItem2";
			this.tokenToolStripMenuItem2.Size = new global::System.Drawing.Size(224, 22);
			this.tokenToolStripMenuItem2.Text = "Token";
			this.tựĐộngLấyToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tokenEAAAAZToolStripMenuItem,
				this.tokenBussinessToolStripMenuItem
			});
			this.tựĐộngLấyToolStripMenuItem1.Name = "tựĐộngLấyToolStripMenuItem1";
			this.tựĐộngLấyToolStripMenuItem1.Size = new global::System.Drawing.Size(142, 22);
			this.tựĐộngLấyToolStripMenuItem1.Text = "Tự động lấy";
			this.tokenEAAAAZToolStripMenuItem.Name = "tokenEAAAAZToolStripMenuItem";
			this.tokenEAAAAZToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.tokenEAAAAZToolStripMenuItem.Text = "Token EAAAAZ";
			this.tokenEAAAAZToolStripMenuItem.ToolTipText = "Sử dụng cookie";
			this.tokenBussinessToolStripMenuItem.Name = "tokenBussinessToolStripMenuItem";
			this.tokenBussinessToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.tokenBussinessToolStripMenuItem.Text = "Token EAAG";
			this.tokenBussinessToolStripMenuItem.ToolTipText = "Sử dụng cookie";
			this.nhậpDữLiệuToolStripMenuItem2.Name = "nhậpDữLiệuToolStripMenuItem2";
			this.nhậpDữLiệuToolStripMenuItem2.Size = new global::System.Drawing.Size(142, 22);
			this.nhậpDữLiệuToolStripMenuItem2.Text = "Nhập dữ liệu";
			this.cookieToolStripMenuItem3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cookieToolStripMenuItem3.Image");
			this.cookieToolStripMenuItem3.Name = "cookieToolStripMenuItem3";
			this.cookieToolStripMenuItem3.Size = new global::System.Drawing.Size(224, 22);
			this.cookieToolStripMenuItem3.Text = "Cookie";
			this.mailKhôiPhụcToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mailKhôiPhụcToolStripMenuItem.Image");
			this.mailKhôiPhụcToolStripMenuItem.Name = "mailKhôiPhụcToolStripMenuItem";
			this.mailKhôiPhụcToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.mailKhôiPhụcToolStripMenuItem.Text = "Email|Pass Email";
			this.passMailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_1password;
			this.passMailToolStripMenuItem.Name = "passMailToolStripMenuItem";
			this.passMailToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.passMailToolStripMenuItem.Text = "Pass Mail";
			this.mã2FAToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("mã2FAToolStripMenuItem.Image");
			this.mã2FAToolStripMenuItem.Name = "mã2FAToolStripMenuItem";
			this.mã2FAToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.mã2FAToolStripMenuItem.Text = "Mã 2FA";
			this.useragentToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("useragentToolStripMenuItem.Image");
			this.useragentToolStripMenuItem.Name = "useragentToolStripMenuItem";
			this.useragentToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.useragentToolStripMenuItem.Text = "Useragent";
			this.proxyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("proxyToolStripMenuItem.Image");
			this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
			this.proxyToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.proxyToolStripMenuItem.Text = "Proxy";
			this.ghiChuToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_note_48px;
			this.ghiChuToolStripMenuItem.Name = "ghiChuToolStripMenuItem";
			this.ghiChuToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.ghiChuToolStripMenuItem.Text = "Ghi chú";
			this.ngàySinhToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_calendar_5_48px;
			this.ngàySinhToolStripMenuItem.Name = "ngàySinhToolStripMenuItem";
			this.ngàySinhToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.ngàySinhToolStripMenuItem.Text = "Ngày sinh";
			this.chuyểnThưMụcToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chuyểnThưMụcToolStripMenuItem.Image");
			this.chuyểnThưMụcToolStripMenuItem.Name = "chuyểnThưMụcToolStripMenuItem";
			this.chuyểnThưMụcToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.chuyểnThưMụcToolStripMenuItem.Text = "Chuyển thư mục";
			this.chứcNăngToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.locTrungToolStripMenuItem,
				this.taoShortcutChromeToolStripMenuItem,
				this.tảiXuốngAvatarToolStripMenuItem,
				this.loginHotmailToolStripMenuItem,
				this.loginYandexToolStripMenuItem,
				this.toolStripMenuItem1,
				this.loginGmailToolStripMenuItem,
				this.lToolStripMenuItem,
				this.mởFormQuảnLýTinNhắnToolStripMenuItem,
				this.khôiPhụcMậtKhẩuToolStripMenuItem,
				this.đổiPassHotmailToolStripMenuItem
			});
			this.chứcNăngToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chứcNăngToolStripMenuItem1.Image");
			this.chứcNăngToolStripMenuItem1.Name = "chứcNăngToolStripMenuItem1";
			this.chứcNăngToolStripMenuItem1.Size = new global::System.Drawing.Size(174, 22);
			this.chứcNăngToolStripMenuItem1.Text = "Chức năng";
			this.locTrungToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("locTrungToolStripMenuItem.Image");
			this.locTrungToolStripMenuItem.Name = "locTrungToolStripMenuItem";
			this.locTrungToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.locTrungToolStripMenuItem.Text = "Lọc trùng tài khoản";
			this.taoShortcutChromeToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_chrome_25px;
			this.taoShortcutChromeToolStripMenuItem.Name = "taoShortcutChromeToolStripMenuItem";
			this.taoShortcutChromeToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.taoShortcutChromeToolStripMenuItem.Text = "Tạo Shortcut Chrome";
			this.tảiXuốngAvatarToolStripMenuItem.Image = global::maxcare.Properties.Resources.client_management_25px;
			this.tảiXuốngAvatarToolStripMenuItem.Name = "tảiXuốngAvatarToolStripMenuItem";
			this.tảiXuốngAvatarToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.tảiXuốngAvatarToolStripMenuItem.Text = "Tải xuống avatar";
			this.loginHotmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_microsoft_outlook_48px;
			this.loginHotmailToolStripMenuItem.Name = "loginHotmailToolStripMenuItem";
			this.loginHotmailToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.loginHotmailToolStripMenuItem.Text = "Login Hotmail";
			this.loginYandexToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_yandex_international_32px;
			this.loginYandexToolStripMenuItem.Name = "loginYandexToolStripMenuItem";
			this.loginYandexToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.loginYandexToolStripMenuItem.Text = "Login Yandex";
			this.toolStripMenuItem1.Image = global::maxcare.Properties.Resources.icons8_gmail;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(215, 22);
			this.toolStripMenuItem1.Text = "Login Gmail";
			this.loginGmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_gmail;
			this.loginGmailToolStripMenuItem.Name = "loginGmailToolStripMenuItem";
			this.loginGmailToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.loginGmailToolStripMenuItem.Text = "Login Gmail (Dùng Profile)";
			this.lToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_mail_filter_24px1;
			this.lToolStripMenuItem.Name = "lToolStripMenuItem";
			this.lToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.lToolStripMenuItem.Text = "Lọc danh sách theo UID";
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_group_message;
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Name = "mởFormQuảnLýTinNhắnToolStripMenuItem";
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Text = "Mở form quản lý tin nhắn";
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_reset_1;
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Name = "khôiPhụcMậtKhẩuToolStripMenuItem";
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Text = "Khôi phục mật khẩu";
			this.đổiPassHotmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.password_25px;
			this.đổiPassHotmailToolStripMenuItem.Name = "đổiPassHotmailToolStripMenuItem";
			this.đổiPassHotmailToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.đổiPassHotmailToolStripMenuItem.Text = "Đổi pass hotmail";
			this.profileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tạoProfileToolStripMenuItem,
				this.checkProfileToolStripMenuItem,
				this.xóaProfileToolStripMenuItem,
				this.donDepProfileToolStripMenuItem,
				this.xóaCacheToolStripMenuItem,
				this.copyProfileToolStripMenuItem
			});
			this.profileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("profileToolStripMenuItem.Image");
			this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
			this.profileToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.profileToolStripMenuItem.Text = "Profile Chrome";
			this.tạoProfileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.đăngNhâpBăngUidpassToolStripMenuItem,
				this.đăngNhâpBăngCookieToolStripMenuItem
			});
			this.tạoProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tạoProfileToolStripMenuItem.Image");
			this.tạoProfileToolStripMenuItem.Name = "tạoProfileToolStripMenuItem";
			this.tạoProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.tạoProfileToolStripMenuItem.Text = "Tạo profile";
			this.đăngNhâpBăngUidpassToolStripMenuItem.Name = "đăngNhâpBăngUidpassToolStripMenuItem";
			this.đăngNhâpBăngUidpassToolStripMenuItem.Size = new global::System.Drawing.Size(233, 22);
			this.đăngNhâpBăngUidpassToolStripMenuItem.Text = "Đăng nhập bằng uid|pass (bỏ)";
			this.đăngNhâpBăngUidpassToolStripMenuItem.Visible = false;
			this.đăngNhâpBăngCookieToolStripMenuItem.Name = "đăngNhâpBăngCookieToolStripMenuItem";
			this.đăngNhâpBăngCookieToolStripMenuItem.Size = new global::System.Drawing.Size(233, 22);
			this.đăngNhâpBăngCookieToolStripMenuItem.Text = "Đăng nhập bằng cookie (bỏ)";
			this.đăngNhâpBăngCookieToolStripMenuItem.Visible = false;
			this.checkProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("checkProfileToolStripMenuItem.Image");
			this.checkProfileToolStripMenuItem.Name = "checkProfileToolStripMenuItem";
			this.checkProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.checkProfileToolStripMenuItem.Text = "Check profile";
			this.xóaProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("xóaProfileToolStripMenuItem.Image");
			this.xóaProfileToolStripMenuItem.Name = "xóaProfileToolStripMenuItem";
			this.xóaProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.xóaProfileToolStripMenuItem.Text = "Xóa profile";
			this.donDepProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("donDepProfileToolStripMenuItem.Image");
			this.donDepProfileToolStripMenuItem.Name = "donDepProfileToolStripMenuItem";
			this.donDepProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.donDepProfileToolStripMenuItem.Text = "Dọn dẹp profile";
			this.xóaCacheToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_delete_bin1;
			this.xóaCacheToolStripMenuItem.Name = "xóaCacheToolStripMenuItem";
			this.xóaCacheToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.xóaCacheToolStripMenuItem.Text = "Xóa Cache Profile";
			this.copyProfileToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_documents_folder_50px;
			this.copyProfileToolStripMenuItem.Name = "copyProfileToolStripMenuItem";
			this.copyProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.copyProfileToolStripMenuItem.Text = "Copy Profile";
			this.backupToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.backupCookieToolStripMenuItem,
				this.taoFileHTMLToolStripMenuItem,
				this.checkBackupToolStripMenuItem,
				this.mởThưMụcBackupToolStripMenuItem,
				this.backupToolStripMenuItem1,
				this.xóaDữLiệuBackupToolStripMenuItem,
				this.dọnDẹpBackupToolStripMenuItem
			});
			this.backupToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("backupToolStripMenuItem.Image");
			this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
			this.backupToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.backupToolStripMenuItem.Text = "Backup dữ liệu";
			this.backupCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("backupCookieToolStripMenuItem.Image");
			this.backupCookieToolStripMenuItem.Name = "backupCookieToolStripMenuItem";
			this.backupCookieToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.backupCookieToolStripMenuItem.Text = "Tiến hành Backup";
			this.taoFileHTMLToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("taoFileHTMLToolStripMenuItem.Image");
			this.taoFileHTMLToolStripMenuItem.Name = "taoFileHTMLToolStripMenuItem";
			this.taoFileHTMLToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.taoFileHTMLToolStripMenuItem.Text = "Tạo File HTML";
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
				this.fileTxtToolStripMenuItem,
				this.thưMụcToolStripMenuItem
			});
			this.backupToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("backupToolStripMenuItem1.Image");
			this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
			this.backupToolStripMenuItem1.Size = new global::System.Drawing.Size(183, 22);
			this.backupToolStripMenuItem1.Text = "Copy dữ liệu Backup";
			this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
			this.htmlToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.htmlToolStripMenuItem.Text = "File html";
			this.fileTxtToolStripMenuItem.Name = "fileTxtToolStripMenuItem";
			this.fileTxtToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.fileTxtToolStripMenuItem.Text = "File txt";
			this.thưMụcToolStripMenuItem.Name = "thưMụcToolStripMenuItem";
			this.thưMụcToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.thưMụcToolStripMenuItem.Text = "Folder Backup";
			this.xóaDữLiệuBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.close_window_25px;
			this.xóaDữLiệuBackupToolStripMenuItem.Name = "xóaDữLiệuBackupToolStripMenuItem";
			this.xóaDữLiệuBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.xóaDữLiệuBackupToolStripMenuItem.Text = "Xóa dữ liệu Backup";
			this.dọnDẹpBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_broom;
			this.dọnDẹpBackupToolStripMenuItem.Name = "dọnDẹpBackupToolStripMenuItem";
			this.dọnDẹpBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.dọnDẹpBackupToolStripMenuItem.Text = "Dọn dẹp Backup";
			this.giaiCheckpointToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.giảiCheckpintNgàySinhToolStripMenuItem,
				this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem,
				this.gửiOTPVềMailMbasicbetaToolStripMenuItem,
				this.giảiCP282ToolStripMenuItem
			});
			this.giaiCheckpointToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("giaiCheckpointToolStripMenuItem.Image");
			this.giaiCheckpointToolStripMenuItem.Name = "giaiCheckpointToolStripMenuItem";
			this.giaiCheckpointToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.giaiCheckpointToolStripMenuItem.Text = "Giải Checkpoint";
			this.giảiCheckpintNgàySinhToolStripMenuItem.Name = "giảiCheckpintNgàySinhToolStripMenuItem";
			this.giảiCheckpintNgàySinhToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.giảiCheckpintNgàySinhToolStripMenuItem.Text = "Ngày sinh (Giao diện cũ)";
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem.Name = "gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem";
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem.Text = "Gửi OTP về mail (hotmail/yandex)";
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem.Name = "gửiOTPVềMailMbasicbetaToolStripMenuItem";
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem.Text = "Gửi OTP về mail mbasic";
			this.giảiCP282ToolStripMenuItem.Name = "giảiCP282ToolStripMenuItem";
			this.giảiCP282ToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.giảiCP282ToolStripMenuItem.Text = "Giải CP 282";
			this.tảiLạiDanhSáchToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
			this.tảiLạiDanhSáchToolStripMenuItem.Name = "tảiLạiDanhSáchToolStripMenuItem";
			this.tảiLạiDanhSáchToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.tảiLạiDanhSáchToolStripMenuItem.Text = "Tải lại danh sách";
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.pnlHeader;
			this.bunifuDragControl1.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.lblNotify);
			this.pnlHeader.Controls.Add(this.lblStatusUpdate);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(2, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(1242, 29);
			this.pnlHeader.TabIndex = 0;
			this.lblNotify.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblNotify.AutoSize = true;
			this.lblNotify.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblNotify.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblNotify.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblNotify.LinkColor = global::System.Drawing.Color.Red;
			this.lblNotify.Location = new global::System.Drawing.Point(715, 6);
			this.lblNotify.Name = "lblNotify";
			this.lblNotify.Size = new global::System.Drawing.Size(428, 16);
			this.lblNotify.TabIndex = 13;
			this.lblNotify.TabStop = true;
			this.lblNotify.Text = "Hiện tại MIN SOFTWARE đã có phần mềm nuôi nick trên giả lập LDPlayer!";
			this.lblNotify.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblNotify.Visible = false;
			this.lblStatusUpdate.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblStatusUpdate.AutoSize = true;
			this.lblStatusUpdate.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblStatusUpdate.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatusUpdate.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblStatusUpdate.LinkColor = global::System.Drawing.Color.Red;
			this.lblStatusUpdate.Location = new global::System.Drawing.Point(835, 6);
			this.lblStatusUpdate.Name = "lblStatusUpdate";
			this.lblStatusUpdate.Size = new global::System.Drawing.Size(308, 16);
			this.lblStatusUpdate.TabIndex = 13;
			this.lblStatusUpdate.TabStop = true;
			this.lblStatusUpdate.Text = "Đã có bản update mới, xem chi tiết nội dung update!";
			this.lblStatusUpdate.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblStatusUpdate.Visible = false;
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
			this.button2.Location = new global::System.Drawing.Point(1146, 0);
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
			this.button1.Location = new global::System.Drawing.Point(1178, 0);
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
			this.btnMinimize.Location = new global::System.Drawing.Point(1210, 0);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(576, 16);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = "MAX CARE 4.8.2 - Phần Mềm Quản Lý Và Chăm Sóc Tài Khoản Facebook - MIN SOFTWARE";
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.RoyalBlue;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(1, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(1243, 38);
			this.bunifuCards1.TabIndex = 0;
			this.menuStrip1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = global::System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.hệThốngToolStripMenuItem,
				this.càiĐặtToolStripMenuItem,
				this.thoátToolStripMenuItem,
				this.taiKhoanĐaXoaToolStripMenuItem,
				this.tiệnÍchToolStripMenuItem,
				this.liênHệToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(1, 37);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new global::System.Drawing.Size(1241, 25);
			this.menuStrip1.Stretch = false;
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.hệThốngToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_job;
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new global::System.Drawing.Size(124, 21);
			this.hệThốngToolStripMenuItem.Text = "Cấu hình chung";
			this.càiĐặtToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_opposite_opinion;
			this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
			this.càiĐặtToolStripMenuItem.Size = new global::System.Drawing.Size(144, 21);
			this.càiĐặtToolStripMenuItem.Text = "Cấu hình tương tác";
			this.càiĐặtToolStripMenuItem.TextDirection = global::System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.thoátToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_show_property_48px;
			this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			this.thoátToolStripMenuItem.Size = new global::System.Drawing.Size(132, 21);
			this.thoátToolStripMenuItem.Text = "Cấu hình hiển thị";
			this.taiKhoanĐaXoaToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_delete_bin_21;
			this.taiKhoanĐaXoaToolStripMenuItem.Name = "taiKhoanĐaXoaToolStripMenuItem";
			this.taiKhoanĐaXoaToolStripMenuItem.Size = new global::System.Drawing.Size(134, 21);
			this.taiKhoanĐaXoaToolStripMenuItem.Text = "Tài khoản đã xóa";
			this.tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.checkLiveUidToolStripMenuItem,
				this.checkProxyToolStripMenuItem1,
				this.checkHotmailToolStripMenuItem,
				this.lọcTrùngDữLiệuToolStripMenuItem,
				this.xửLýChuỗiOnlineToolStripMenuItem
			});
			this.tiệnÍchToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_circled_menu;
			this.tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
			this.tiệnÍchToolStripMenuItem.Size = new global::System.Drawing.Size(81, 21);
			this.tiệnÍchToolStripMenuItem.Text = "Tiện ích";
			this.checkLiveUidToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_checkmark_26px;
			this.checkLiveUidToolStripMenuItem.Name = "checkLiveUidToolStripMenuItem";
			this.checkLiveUidToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.checkLiveUidToolStripMenuItem.Text = "Check Live Uid";
			this.checkProxyToolStripMenuItem1.Image = global::maxcare.Properties.Resources.icons8_cloud_firewall_64px1;
			this.checkProxyToolStripMenuItem1.Name = "checkProxyToolStripMenuItem1";
			this.checkProxyToolStripMenuItem1.Size = new global::System.Drawing.Size(260, 22);
			this.checkProxyToolStripMenuItem1.Text = "Check Proxy";
			this.checkHotmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_mail;
			this.checkHotmailToolStripMenuItem.Name = "checkHotmailToolStripMenuItem";
			this.checkHotmailToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.checkHotmailToolStripMenuItem.Text = "Check Connect email bằng Imap";
			this.lọcTrùngDữLiệuToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_mail_filter_24px;
			this.lọcTrùngDữLiệuToolStripMenuItem.Name = "lọcTrùngDữLiệuToolStripMenuItem";
			this.lọcTrùngDữLiệuToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.lọcTrùngDữLiệuToolStripMenuItem.Text = "Lọc trùng dữ liệu";
			this.xửLýChuỗiOnlineToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_rss;
			this.xửLýChuỗiOnlineToolStripMenuItem.Name = "xửLýChuỗiOnlineToolStripMenuItem";
			this.xửLýChuỗiOnlineToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.xửLýChuỗiOnlineToolStripMenuItem.Text = "Xử lý chuỗi cơ bản";
			this.liênHệToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_safety_float;
			this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
			this.liênHệToolStripMenuItem.Size = new global::System.Drawing.Size(77, 21);
			this.liênHệToolStripMenuItem.Text = "Liên hệ";
			this.grQuanLyThuMuc.Controls.Add(this.btnLoadAcc);
			this.grQuanLyThuMuc.Controls.Add(this.btnEditFile);
			this.grQuanLyThuMuc.Controls.Add(this.btnDeleteFile);
			this.grQuanLyThuMuc.Controls.Add(this.AddFileAccount);
			this.grQuanLyThuMuc.Controls.Add(this.cbbTinhTrang);
			this.grQuanLyThuMuc.Controls.Add(this.cbbThuMuc);
			this.grQuanLyThuMuc.Controls.Add(this.label2);
			this.grQuanLyThuMuc.Controls.Add(this.label1);
			this.grQuanLyThuMuc.Controls.Add(this.button9);
			this.grQuanLyThuMuc.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grQuanLyThuMuc.Location = new global::System.Drawing.Point(572, 65);
			this.grQuanLyThuMuc.Name = "grQuanLyThuMuc";
			this.grQuanLyThuMuc.Size = new global::System.Drawing.Size(662, 53);
			this.grQuanLyThuMuc.TabIndex = 5;
			this.grQuanLyThuMuc.TabStop = false;
			this.grQuanLyThuMuc.Text = "Quản lý thư mục";
			this.btnLoadAcc.BackgroundImage = global::maxcare.Properties.Resources.available_updates_25px;
			this.btnLoadAcc.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.btnLoadAcc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnLoadAcc.Location = new global::System.Drawing.Point(498, 19);
			this.btnLoadAcc.Name = "btnLoadAcc";
			this.btnLoadAcc.Size = new global::System.Drawing.Size(25, 25);
			this.btnLoadAcc.TabIndex = 6;
			this.toolTip1.SetToolTip(this.btnLoadAcc, "Load lại danh sách");
			this.btnLoadAcc.UseSelectable = true;
			this.btnEditFile.BackColor = global::System.Drawing.Color.Gray;
			this.btnEditFile.BackgroundImage = global::maxcare.Properties.Resources.icons8_edit_24px1;
			this.btnEditFile.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.btnEditFile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnEditFile.Enabled = false;
			this.btnEditFile.Location = new global::System.Drawing.Point(435, 19);
			this.btnEditFile.Name = "btnEditFile";
			this.btnEditFile.Size = new global::System.Drawing.Size(25, 25);
			this.btnEditFile.TabIndex = 5;
			this.toolTip1.SetToolTip(this.btnEditFile, "Sửa tên thư mục");
			this.btnEditFile.UseSelectable = true;
			this.btnDeleteFile.BackColor = global::System.Drawing.Color.Gray;
			this.btnDeleteFile.BackgroundImage = global::maxcare.Properties.Resources.icons8_subtract_25px;
			this.btnDeleteFile.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.btnDeleteFile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDeleteFile.Enabled = false;
			this.btnDeleteFile.Location = new global::System.Drawing.Point(466, 19);
			this.btnDeleteFile.Name = "btnDeleteFile";
			this.btnDeleteFile.Size = new global::System.Drawing.Size(25, 25);
			this.btnDeleteFile.TabIndex = 5;
			this.toolTip1.SetToolTip(this.btnDeleteFile, "Xóa thư mục");
			this.btnDeleteFile.UseSelectable = true;
			this.AddFileAccount.BackgroundImage = global::maxcare.Properties.Resources.icons8_plus_math_25px1;
			this.AddFileAccount.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.AddFileAccount.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.AddFileAccount.Location = new global::System.Drawing.Point(404, 19);
			this.AddFileAccount.Name = "AddFileAccount";
			this.AddFileAccount.Size = new global::System.Drawing.Size(25, 25);
			this.AddFileAccount.TabIndex = 4;
			this.toolTip1.SetToolTip(this.AddFileAccount, "Thêm thư mục");
			this.AddFileAccount.UseSelectable = true;
			this.cbbTinhTrang.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbTinhTrang.DropDownWidth = 300;
			this.cbbTinhTrang.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbTinhTrang.FormattingEnabled = true;
			this.cbbTinhTrang.ItemHeight = 19;
			this.cbbTinhTrang.Items.AddRange(new object[]
			{
				"[Tất cả tình trạng]"
			});
			this.cbbTinhTrang.Location = new global::System.Drawing.Point(277, 19);
			this.cbbTinhTrang.Name = "cbbTinhTrang";
			this.cbbTinhTrang.Size = new global::System.Drawing.Size(121, 25);
			this.cbbTinhTrang.TabIndex = 3;
			this.cbbTinhTrang.UseSelectable = true;
			this.cbbThuMuc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbThuMuc.DropDownWidth = 350;
			this.cbbThuMuc.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbThuMuc.FormattingEnabled = true;
			this.cbbThuMuc.ItemHeight = 19;
			this.cbbThuMuc.Location = new global::System.Drawing.Point(72, 19);
			this.cbbThuMuc.Name = "cbbThuMuc";
			this.cbbThuMuc.Size = new global::System.Drawing.Size(167, 25);
			this.cbbThuMuc.TabIndex = 1;
			this.cbbThuMuc.UseSelectable = true;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(241, 22);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(32, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lọc:";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(8, 23);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thư mục:";
			this.button9.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button9.BackColor = global::System.Drawing.Color.White;
			this.button9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button9.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.Image = global::maxcare.Properties.Resources.upload_to_ftp_25px;
			this.button9.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.Location = new global::System.Drawing.Point(530, 18);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(130, 27);
			this.button9.TabIndex = 7;
			this.button9.Text = "Nhập tài khoản";
			this.button9.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button9.UseVisualStyleBackColor = true;
			this.grTimKiem.Controls.Add(this.BtnSearch);
			this.grTimKiem.Controls.Add(this.cbbSearch);
			this.grTimKiem.Controls.Add(this.txbSearch);
			this.grTimKiem.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grTimKiem.Location = new global::System.Drawing.Point(282, 65);
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
			this.statusStrip1.BackColor = global::System.Drawing.SystemColors.Control;
			this.statusStrip1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1,
				this.lblStatus,
				this.toolStripStatusLabel3,
				this.lblKey,
				this.toolStripStatusLabel8,
				this.txbUid,
				this.lblUser,
				this.toolStripStatusLabel9,
				this.toolStripStatusLabel10,
				this.lblDateExpried,
				this.toolStripStatusLabel5,
				this.lblCountSelect,
				this.toolStripStatusLabel7,
				this.lblCountTotal
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 586);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(1242, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(79, 17);
			this.toolStripStatusLabel1.Text = "Trạng thái:";
			this.lblStatus.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.ForeColor = global::System.Drawing.Color.Green;
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(97, 17);
			this.lblStatus.Text = "Đang kiểm tra...";
			this.toolStripStatusLabel3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(82, 17);
			this.toolStripStatusLabel3.Text = "Mã thiết bị:";
			this.lblKey.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblKey.ForeColor = global::System.Drawing.Color.Teal;
			this.lblKey.Name = "lblKey";
			this.lblKey.Size = new global::System.Drawing.Size(49, 17);
			this.lblKey.Text = "******";
			this.toolStripStatusLabel8.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
			this.toolStripStatusLabel8.Size = new global::System.Drawing.Size(42, 17);
			this.toolStripStatusLabel8.Text = "User:";
			this.txbUid.Name = "txbUid";
			this.txbUid.Size = new global::System.Drawing.Size(0, 17);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new global::System.Drawing.Size(56, 17);
			this.lblUser.Text = "******";
			this.toolStripStatusLabel9.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel9.IsLink = true;
			this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
			this.toolStripStatusLabel9.Size = new global::System.Drawing.Size(66, 17);
			this.toolStripStatusLabel9.Text = "Đăng xuất";
			this.toolStripStatusLabel10.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
			this.toolStripStatusLabel10.Size = new global::System.Drawing.Size(99, 17);
			this.toolStripStatusLabel10.Text = "Ngày hết hạn:";
			this.lblDateExpried.Name = "lblDateExpried";
			this.lblDateExpried.Size = new global::System.Drawing.Size(74, 17);
			this.lblDateExpried.Text = "20/10/2020";
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
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl2.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 0;
			this.toolTip1.ReshowDelay = 40;
			this.btnViewLivestream.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnViewLivestream.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnViewLivestream.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnViewLivestream.Image");
			this.btnViewLivestream.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnViewLivestream.Location = new global::System.Drawing.Point(275, 1);
			this.btnViewLivestream.Name = "btnViewLivestream";
			this.btnViewLivestream.Size = new global::System.Drawing.Size(128, 29);
			this.btnViewLivestream.TabIndex = 4;
			this.btnViewLivestream.Text = "Auto xem live";
			this.btnViewLivestream.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnViewLivestream, "Chức năng tự động xem livestream");
			this.btnViewLivestream.UseVisualStyleBackColor = false;
			this.btnShare.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnShare.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnShare.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnShare.Image");
			this.btnShare.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnShare.Location = new global::System.Drawing.Point(139, 1);
			this.btnShare.Name = "btnShare";
			this.btnShare.Size = new global::System.Drawing.Size(128, 29);
			this.btnShare.TabIndex = 1;
			this.btnShare.Text = "Auto chia sẻ";
			this.btnShare.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnShare, "Chức năng tự động chia sẻ");
			this.btnShare.UseVisualStyleBackColor = false;
			this.btnPost.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPost.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnPost.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnPost.Image");
			this.btnPost.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnPost.Location = new global::System.Drawing.Point(3, 1);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new global::System.Drawing.Size(128, 29);
			this.btnPost.TabIndex = 0;
			this.btnPost.Text = "Auto đăng bài";
			this.btnPost.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnPost, "Chức năng tự động đăng bài");
			this.btnPost.UseVisualStyleBackColor = false;
			this.btnPause.BackColor = global::System.Drawing.Color.White;
			this.btnPause.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPause.Enabled = false;
			this.btnPause.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnPause.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnPause.Image");
			this.btnPause.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnPause.Location = new global::System.Drawing.Point(145, 79);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new global::System.Drawing.Size(128, 32);
			this.btnPause.TabIndex = 3;
			this.btnPause.Text = "Dừng Tương Tác";
			this.btnPause.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnPause, "Dừng tương tác");
			this.btnInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnInteract.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnInteract.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnInteract.Image");
			this.btnInteract.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnInteract.Location = new global::System.Drawing.Point(9, 79);
			this.btnInteract.Name = "btnInteract";
			this.btnInteract.Size = new global::System.Drawing.Size(128, 32);
			this.btnInteract.TabIndex = 2;
			this.btnInteract.Text = "Chạy Tương Tác";
			this.btnInteract.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnInteract, "Bắt đầu chạy tương tác");
			this.btnInteract.UseVisualStyleBackColor = false;
			this.plChucNang.Controls.Add(this.button8);
			this.plChucNang.Controls.Add(this.button4);
			this.plChucNang.Controls.Add(this.button7);
			this.plChucNang.Controls.Add(this.btnViewLivestream);
			this.plChucNang.Controls.Add(this.button6);
			this.plChucNang.Controls.Add(this.btnShare);
			this.plChucNang.Controls.Add(this.btnPost);
			this.plChucNang.Location = new global::System.Drawing.Point(6, 120);
			this.plChucNang.Name = "plChucNang";
			this.plChucNang.Size = new global::System.Drawing.Size(805, 30);
			this.plChucNang.TabIndex = 6;
			this.button8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button8.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button8.Image");
			this.button8.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button8.Location = new global::System.Drawing.Point(997, 1);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(128, 29);
			this.button8.TabIndex = 8;
			this.button8.Text = "Marketplace";
			this.button8.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = false;
			this.button4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button4.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button4.Image");
			this.button4.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button4.Location = new global::System.Drawing.Point(411, 1);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(128, 29);
			this.button4.TabIndex = 5;
			this.button4.Text = "Đổi thông tin";
			this.button4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = false;
			this.button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button7.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button7.Image");
			this.button7.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new global::System.Drawing.Point(686, 1);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(105, 29);
			this.button7.TabIndex = 7;
			this.button7.Text = "Nhập Proxy";
			this.button7.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			this.button6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button6.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button6.Image");
			this.button6.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new global::System.Drawing.Point(547, 1);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(131, 29);
			this.button6.TabIndex = 6;
			this.button6.Text = "Nhập Useragent";
			this.button6.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button6.UseVisualStyleBackColor = false;
			this.metroButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.metroButton1.Location = new global::System.Drawing.Point(1112, 121);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(122, 29);
			this.metroButton1.TabIndex = 7;
			this.metroButton1.Text = "Close Chromedriver";
			this.metroButton1.UseSelectable = true;
			this.btnRandomIndexRow.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.btnRandomIndexRow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnRandomIndexRow.Location = new global::System.Drawing.Point(1015, 121);
			this.btnRandomIndexRow.Name = "btnRandomIndexRow";
			this.btnRandomIndexRow.Size = new global::System.Drawing.Size(88, 29);
			this.btnRandomIndexRow.TabIndex = 7;
			this.btnRandomIndexRow.Text = "Random";
			this.btnRandomIndexRow.UseSelectable = true;
			this.plTrangThai.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.plTrangThai.BackColor = global::System.Drawing.Color.Gainsboro;
			this.plTrangThai.Controls.Add(this.lblTrangThai);
			this.plTrangThai.Location = new global::System.Drawing.Point(868, 36);
			this.plTrangThai.Name = "plTrangThai";
			this.plTrangThai.Size = new global::System.Drawing.Size(373, 26);
			this.plTrangThai.TabIndex = 10;
			this.plTrangThai.Visible = false;
			this.lblTrangThai.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblTrangThai.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTrangThai.Location = new global::System.Drawing.Point(0, 0);
			this.lblTrangThai.Name = "lblTrangThai";
			this.lblTrangThai.Size = new global::System.Drawing.Size(373, 26);
			this.lblTrangThai.TabIndex = 0;
			this.lblTrangThai.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1244, 610);
			this.panel1.TabIndex = 11;
			this.timer1.Enabled = true;
			this.timer1.Interval = 1800000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1244, 610);
			base.Controls.Add(this.plTrangThai);
			base.Controls.Add(this.btnRandomIndexRow);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.plChucNang);
			base.Controls.Add(this.grTimKiem);
			base.Controls.Add(this.btnPause);
			base.Controls.Add(this.btnInteract);
			base.Controls.Add(this.grQuanLyThuMuc);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.dtgvAcc);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "fMain";
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
			this.grQuanLyThuMuc.PerformLayout();
			this.grTimKiem.ResumeLayout(false);
			this.grTimKiem.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.plChucNang.ResumeLayout(false);
			this.plTrangThai.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040018D2 RID: 6354
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040018D4 RID: 6356
		public global::System.Windows.Forms.DataGridView dtgvAcc;

		// Token: 0x040018D5 RID: 6357
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040018D6 RID: 6358
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040018D7 RID: 6359
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040018D8 RID: 6360
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040018D9 RID: 6361
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040018DA RID: 6362
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040018DB RID: 6363
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040018DC RID: 6364
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040018DD RID: 6365
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x040018DE RID: 6366
		private global::System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;

		// Token: 0x040018DF RID: 6367
		private global::System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;

		// Token: 0x040018E0 RID: 6368
		private global::System.Windows.Forms.GroupBox grQuanLyThuMuc;

		// Token: 0x040018E1 RID: 6369
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040018E2 RID: 6370
		private global::MetroFramework.Controls.MetroComboBox cbbThuMuc;

		// Token: 0x040018E3 RID: 6371
		private global::MetroFramework.Controls.MetroContextMenu ctmsAcc;

		// Token: 0x040018E4 RID: 6372
		private global::System.Windows.Forms.ToolStripMenuItem chọnLiveToolStripMenuItem;

		// Token: 0x040018E5 RID: 6373
		private global::System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;

		// Token: 0x040018E6 RID: 6374
		private global::System.Windows.Forms.ToolStripMenuItem mởTrìnhDuyệtToolStripMenuItem;

		// Token: 0x040018E7 RID: 6375
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x040018E8 RID: 6376
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem;

		// Token: 0x040018E9 RID: 6377
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;

		// Token: 0x040018EA RID: 6378
		private global::System.Windows.Forms.ToolStripMenuItem uidPassToolStripMenuItem;

		// Token: 0x040018EB RID: 6379
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		// Token: 0x040018EC RID: 6380
		private global::System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;

		// Token: 0x040018ED RID: 6381
		private global::System.Windows.Forms.ToolStripMenuItem chuyểnThưMụcToolStripMenuItem;

		// Token: 0x040018EE RID: 6382
		private global::System.Windows.Forms.ToolStripMenuItem checkCookieToolStripMenuItem;

		// Token: 0x040018EF RID: 6383
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;

		// Token: 0x040018F0 RID: 6384
		private global::System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;

		// Token: 0x040018F1 RID: 6385
		private global::System.Windows.Forms.ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;

		// Token: 0x040018F2 RID: 6386
		private global::System.Windows.Forms.ToolStripMenuItem passToolStripMenuItem;

		// Token: 0x040018F3 RID: 6387
		private global::System.Windows.Forms.Button btnInteract;

		// Token: 0x040018F4 RID: 6388
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraCookieToolStripMenuItem;

		// Token: 0x040018F5 RID: 6389
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTokenToolStripMenuItem;

		// Token: 0x040018F6 RID: 6390
		private global::System.Windows.Forms.ToolStripMenuItem tảiLạiDanhSáchToolStripMenuItem;

		// Token: 0x040018F7 RID: 6391
		private global::System.Windows.Forms.ToolStripMenuItem cậpNhậtDữLiệuToolStripMenuItem;

		// Token: 0x040018F8 RID: 6392
		private global::System.Windows.Forms.ToolStripMenuItem mậtKhẩuToolStripMenuItem1;

		// Token: 0x040018F9 RID: 6393
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem2;

		// Token: 0x040018FA RID: 6394
		private global::System.Windows.Forms.ToolStripMenuItem tựĐộngLấyToolStripMenuItem1;

		// Token: 0x040018FB RID: 6395
		private global::System.Windows.Forms.ToolStripMenuItem tokenBussinessToolStripMenuItem;

		// Token: 0x040018FC RID: 6396
		private global::System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem2;

		// Token: 0x040018FD RID: 6397
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem3;

		// Token: 0x040018FE RID: 6398
		private global::System.Windows.Forms.Button btnPause;

		// Token: 0x040018FF RID: 6399
		private global::System.Windows.Forms.ToolStripMenuItem backupCookieToolStripMenuItem;

		// Token: 0x04001900 RID: 6400
		private global::System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem1;

		// Token: 0x04001901 RID: 6401
		private global::System.Windows.Forms.ToolStripMenuItem mailPassMailToolStripMenuItem;

		// Token: 0x04001902 RID: 6402
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

		// Token: 0x04001903 RID: 6403
		private global::System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

		// Token: 0x04001904 RID: 6404
		private global::System.Windows.Forms.ToolStripMenuItem tạoProfileToolStripMenuItem;

		// Token: 0x04001905 RID: 6405
		private global::System.Windows.Forms.ToolStripMenuItem trạngTháiToolStripMenuItem;

		// Token: 0x04001906 RID: 6406
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraWallToolStripMenuItem;

		// Token: 0x04001907 RID: 6407
		private global::System.Windows.Forms.GroupBox grTimKiem;

		// Token: 0x04001908 RID: 6408
		private global::WindowsFormsControlLibrary1.BunifuCustomTextbox txbSearch;

		// Token: 0x04001909 RID: 6409
		private global::System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;

		// Token: 0x0400190A RID: 6410
		private global::System.Windows.Forms.ToolStripMenuItem mailKhôiPhụcToolStripMenuItem;

		// Token: 0x0400190B RID: 6411
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

		// Token: 0x0400190C RID: 6412
		private global::System.Windows.Forms.Button btnShare;

		// Token: 0x0400190D RID: 6413
		private global::System.Windows.Forms.Button btnPost;

		// Token: 0x0400190E RID: 6414
		private global::System.Windows.Forms.Button btnViewLivestream;

		// Token: 0x0400190F RID: 6415
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04001910 RID: 6416
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04001911 RID: 6417
		private global::System.Windows.Forms.ToolStripStatusLabel lblStatus;

		// Token: 0x04001912 RID: 6418
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x04001913 RID: 6419
		private global::System.Windows.Forms.ToolStripStatusLabel lblKey;

		// Token: 0x04001914 RID: 6420
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;

		// Token: 0x04001915 RID: 6421
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountTotal;

		// Token: 0x04001916 RID: 6422
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;

		// Token: 0x04001917 RID: 6423
		private global::System.Windows.Forms.ToolStripStatusLabel txbUid;

		// Token: 0x04001918 RID: 6424
		private global::System.Windows.Forms.ToolStripStatusLabel lblUser;

		// Token: 0x04001919 RID: 6425
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;

		// Token: 0x0400191A RID: 6426
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;

		// Token: 0x0400191B RID: 6427
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;

		// Token: 0x0400191C RID: 6428
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountSelect;

		// Token: 0x0400191D RID: 6429
		private global::System.Windows.Forms.ToolStripMenuItem xóaProfileToolStripMenuItem;

		// Token: 0x0400191E RID: 6430
		private global::System.Windows.Forms.ToolStripMenuItem checkProfileToolStripMenuItem;

		// Token: 0x0400191F RID: 6431
		private global::System.Windows.Forms.ToolStripMenuItem fAToolStripMenuItem;

		// Token: 0x04001920 RID: 6432
		private global::System.Windows.Forms.ToolStripMenuItem đăngNhâpBăngUidpassToolStripMenuItem;

		// Token: 0x04001921 RID: 6433
		private global::System.Windows.Forms.ToolStripMenuItem đăngNhâpBăngCookieToolStripMenuItem;

		// Token: 0x04001922 RID: 6434
		private global::System.Windows.Forms.ToolStripMenuItem tinhTrangToolStripMenuItem;

		// Token: 0x04001923 RID: 6435
		private global::System.Windows.Forms.ToolStripMenuItem locTrungToolStripMenuItem;

		// Token: 0x04001924 RID: 6436
		private global::System.Windows.Forms.ToolStripMenuItem uidPass2FaToolStripMenuItem;

		// Token: 0x04001925 RID: 6437
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001926 RID: 6438
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04001927 RID: 6439
		private global::System.Windows.Forms.ToolStripMenuItem taoFileHTMLToolStripMenuItem;

		// Token: 0x04001928 RID: 6440
		private global::System.Windows.Forms.ToolStripMenuItem đinhDangKhacToolStripMenuItem;

		// Token: 0x04001929 RID: 6441
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;

		// Token: 0x0400192A RID: 6442
		private global::System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;

		// Token: 0x0400192B RID: 6443
		private global::System.Windows.Forms.ToolStripMenuItem thưMụcToolStripMenuItem;

		// Token: 0x0400192C RID: 6444
		private global::System.Windows.Forms.ToolStripMenuItem tokenEAAAAZToolStripMenuItem;

		// Token: 0x0400192D RID: 6445
		private global::System.Windows.Forms.ToolStripMenuItem câpNhâtThôngTinCaNhânToolStripMenuItem;

		// Token: 0x0400192E RID: 6446
		private global::System.Windows.Forms.ToolStripMenuItem sưDungTokenTrungGianToolStripMenuItem;

		// Token: 0x0400192F RID: 6447
		private global::System.Windows.Forms.ToolStripMenuItem maBaoMât6SôToolStripMenuItem;

		// Token: 0x04001930 RID: 6448
		private global::System.Windows.Forms.ToolStripMenuItem donDepProfileToolStripMenuItem;

		// Token: 0x04001931 RID: 6449
		private global::System.Windows.Forms.Panel plChucNang;

		// Token: 0x04001932 RID: 6450
		private global::System.Windows.Forms.ToolStripMenuItem mã2FAToolStripMenuItem;

		// Token: 0x04001933 RID: 6451
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04001934 RID: 6452
		private global::System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;

		// Token: 0x04001935 RID: 6453
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04001936 RID: 6454
		private global::System.Windows.Forms.ToolStripMenuItem useragentToolStripMenuItem;

		// Token: 0x04001937 RID: 6455
		private global::System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;

		// Token: 0x04001938 RID: 6456
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04001939 RID: 6457
		private global::System.Windows.Forms.ToolStripMenuItem useragentToolStripMenuItem1;

		// Token: 0x0400193A RID: 6458
		private global::System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem1;

		// Token: 0x0400193B RID: 6459
		private global::System.Windows.Forms.ToolStripMenuItem giaiCheckpointToolStripMenuItem;

		// Token: 0x0400193C RID: 6460
		private global::System.Windows.Forms.ComboBox cbbSearch;

		// Token: 0x0400193D RID: 6461
		private global::System.Windows.Forms.ToolStripMenuItem mởThưMụcBackupToolStripMenuItem;

		// Token: 0x0400193E RID: 6462
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400193F RID: 6463
		private global::System.Windows.Forms.ToolStripMenuItem ghiChuToolStripMenuItem;

		// Token: 0x04001940 RID: 6464
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04001941 RID: 6465
		private global::System.Windows.Forms.ToolStripMenuItem ngàySinhToolStripMenuItem;

		// Token: 0x04001942 RID: 6466
		private global::MetroFramework.Controls.MetroButton AddFileAccount;

		// Token: 0x04001943 RID: 6467
		private global::MetroFramework.Controls.MetroButton btnDeleteFile;

		// Token: 0x04001944 RID: 6468
		private global::MetroFramework.Controls.MetroButton btnLoadAcc;

		// Token: 0x04001945 RID: 6469
		private global::MetroFramework.Controls.MetroComboBox cbbTinhTrang;

		// Token: 0x04001946 RID: 6470
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001947 RID: 6471
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04001948 RID: 6472
		private global::System.Windows.Forms.ToolStripMenuItem taoShortcutChromeToolStripMenuItem;

		// Token: 0x04001949 RID: 6473
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraMailpassMailToolStripMenuItem;

		// Token: 0x0400194A RID: 6474
		private global::System.Windows.Forms.ToolStripMenuItem loginHotmailToolStripMenuItem;

		// Token: 0x0400194B RID: 6475
		private global::MetroFramework.Controls.MetroButton BtnSearch;

		// Token: 0x0400194C RID: 6476
		private global::MetroFramework.Controls.MetroButton btnRandomIndexRow;

		// Token: 0x0400194D RID: 6477
		private global::System.Windows.Forms.Panel plTrangThai;

		// Token: 0x0400194E RID: 6478
		private global::System.Windows.Forms.Label lblTrangThai;

		// Token: 0x0400194F RID: 6479
		private global::System.Windows.Forms.ToolStripMenuItem uidToolStripMenuItem;

		// Token: 0x04001950 RID: 6480
		private global::System.Windows.Forms.ToolStripMenuItem checkAvatarToolStripMenuItem;

		// Token: 0x04001951 RID: 6481
		private global::System.Windows.Forms.ToolStripMenuItem checkProxyToolStripMenuItem;

		// Token: 0x04001952 RID: 6482
		private global::System.Windows.Forms.ToolStripMenuItem checkProfileToolStripMenuItem1;

		// Token: 0x04001953 RID: 6483
		private global::System.Windows.Forms.ToolStripMenuItem tảiXuốngAvatarToolStripMenuItem;

		// Token: 0x04001954 RID: 6484
		private global::System.Windows.Forms.ToolStripMenuItem xóaDữLiệuBackupToolStripMenuItem;

		// Token: 0x04001955 RID: 6485
		private global::System.Windows.Forms.ToolStripMenuItem mởFolderBackupToolStripMenuItem;

		// Token: 0x04001956 RID: 6486
		private global::System.Windows.Forms.ToolStripMenuItem mởFileHTMLToolStripMenuItem;

		// Token: 0x04001957 RID: 6487
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem;

		// Token: 0x04001958 RID: 6488
		private global::System.Windows.Forms.ToolStripMenuItem checkInfoUIDToolStripMenuItem;

		// Token: 0x04001959 RID: 6489
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem1;

		// Token: 0x0400195A RID: 6490
		private global::System.Windows.Forms.ToolStripMenuItem taiKhoanĐaXoaToolStripMenuItem;

		// Token: 0x0400195B RID: 6491
		private global::System.Windows.Forms.ToolStripMenuItem xóaCacheToolStripMenuItem;

		// Token: 0x0400195C RID: 6492
		private global::System.Windows.Forms.ToolStripMenuItem tiệnÍchToolStripMenuItem;

		// Token: 0x0400195D RID: 6493
		private global::System.Windows.Forms.ToolStripMenuItem lọcTrùngDữLiệuToolStripMenuItem;

		// Token: 0x0400195E RID: 6494
		private global::System.Windows.Forms.ToolStripMenuItem xửLýChuỗiOnlineToolStripMenuItem;

		// Token: 0x0400195F RID: 6495
		private global::System.Windows.Forms.ToolStripMenuItem checkHotmailToolStripMenuItem;

		// Token: 0x04001960 RID: 6496
		private global::MetroFramework.Controls.MetroButton btnEditFile;

		// Token: 0x04001961 RID: 6497
		private global::System.Windows.Forms.ToolStripMenuItem checkProxyToolStripMenuItem1;

		// Token: 0x04001962 RID: 6498
		private global::System.Windows.Forms.ToolStripMenuItem sửDụngCookieTrungGianToolStripMenuItem;

		// Token: 0x04001963 RID: 6499
		private global::System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;

		// Token: 0x04001964 RID: 6500
		private global::System.Windows.Forms.ToolStripMenuItem giảiCheckpintNgàySinhToolStripMenuItem;

		// Token: 0x04001965 RID: 6501
		private global::System.Windows.Forms.ToolStripMenuItem cậpToolStripMenuItem;

		// Token: 0x04001966 RID: 6502
		private global::System.Windows.Forms.ToolStripMenuItem loginYandexToolStripMenuItem;

		// Token: 0x04001967 RID: 6503
		private global::System.Windows.Forms.ToolStripMenuItem gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem;

		// Token: 0x04001968 RID: 6504
		private global::System.Windows.Forms.ToolStripMenuItem copyProfileToolStripMenuItem;

		// Token: 0x04001969 RID: 6505
		private global::System.Windows.Forms.ToolStripMenuItem checkLiveUidToolStripMenuItem;

		// Token: 0x0400196A RID: 6506
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400196B RID: 6507
		private global::System.Windows.Forms.ToolStripMenuItem càiĐặtCấuHìnhMởToolStripMenuItem;

		// Token: 0x0400196C RID: 6508
		private global::System.Windows.Forms.ToolStripMenuItem mởLuônToolStripMenuItem;

		// Token: 0x0400196D RID: 6509
		private global::System.Windows.Forms.ToolStripMenuItem dọnDẹpBackupToolStripMenuItem;

		// Token: 0x0400196E RID: 6510
		private global::System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;

		// Token: 0x0400196F RID: 6511
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn cChose;

		// Token: 0x04001970 RID: 6512
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x04001971 RID: 6513
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x04001972 RID: 6514
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUid;

		// Token: 0x04001973 RID: 6515
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cToken;

		// Token: 0x04001974 RID: 6516
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cCookies;

		// Token: 0x04001975 RID: 6517
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cEmail;

		// Token: 0x04001976 RID: 6518
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPhone;

		// Token: 0x04001977 RID: 6519
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cName;

		// Token: 0x04001978 RID: 6520
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFollow;

		// Token: 0x04001979 RID: 6521
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFriend;

		// Token: 0x0400197A RID: 6522
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGroup;

		// Token: 0x0400197B RID: 6523
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;

		// Token: 0x0400197C RID: 6524
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGender;

		// Token: 0x0400197D RID: 6525
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassword;

		// Token: 0x0400197E RID: 6526
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cMailRecovery;

		// Token: 0x0400197F RID: 6527
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassMail;

		// Token: 0x04001980 RID: 6528
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBackup;

		// Token: 0x04001981 RID: 6529
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFa2;

		// Token: 0x04001982 RID: 6530
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUseragent;

		// Token: 0x04001983 RID: 6531
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProxy;

		// Token: 0x04001984 RID: 6532
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cDateCreateAcc;

		// Token: 0x04001985 RID: 6533
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cAvatar;

		// Token: 0x04001986 RID: 6534
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProfile;

		// Token: 0x04001987 RID: 6535
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cThuMuc;

		// Token: 0x04001988 RID: 6536
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInteractEnd;

		// Token: 0x04001989 RID: 6537
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInfo;

		// Token: 0x0400198A RID: 6538
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;

		// Token: 0x0400198B RID: 6539
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStatus;

		// Token: 0x0400198C RID: 6540
		public global::System.Windows.Forms.ToolStripStatusLabel lblDateExpried;

		// Token: 0x0400198D RID: 6541
		private global::System.Windows.Forms.ToolStripMenuItem fileTxtToolStripMenuItem;

		// Token: 0x0400198E RID: 6542
		private global::System.Windows.Forms.LinkLabel lblStatusUpdate;

		// Token: 0x0400198F RID: 6543
		private global::System.Windows.Forms.LinkLabel lblNotify;

		// Token: 0x04001990 RID: 6544
		private global::System.Windows.Forms.ToolStripMenuItem loginGmailToolStripMenuItem;

		// Token: 0x04001991 RID: 6545
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04001992 RID: 6546
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x04001993 RID: 6547
		private global::System.Windows.Forms.ToolStripMenuItem passMailToolStripMenuItem;

		// Token: 0x04001994 RID: 6548
		private global::System.Windows.Forms.ToolStripMenuItem mởFormQuảnLýTinNhắnToolStripMenuItem;

		// Token: 0x04001995 RID: 6549
		private global::System.Windows.Forms.ToolStripMenuItem khôiPhụcMậtKhẩuToolStripMenuItem;

		// Token: 0x04001996 RID: 6550
		private global::System.Windows.Forms.ToolStripMenuItem gửiOTPVềMailMbasicbetaToolStripMenuItem;

		// Token: 0x04001997 RID: 6551
		private global::System.Windows.Forms.ToolStripMenuItem đổiPassHotmailToolStripMenuItem;

		// Token: 0x04001998 RID: 6552
		private global::System.Windows.Forms.ToolStripMenuItem giảiCP282ToolStripMenuItem;
	}
}
