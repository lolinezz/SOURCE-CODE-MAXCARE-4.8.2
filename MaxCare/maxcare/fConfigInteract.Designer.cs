namespace maxcare
{
	// Token: 0x0200012E RID: 302
	public partial class fConfigInteract : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E12 RID: 3602 RVA: 0x00215A6C File Offset: 0x00213C6C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00215ACC File Offset: 0x00213CCC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.plTuongTacCMSN = new System.Windows.Forms.Panel();
            this.rbTuongTacCMSNDangBai = new System.Windows.Forms.RadioButton();
            this.rbTuongTacCMSNNhanTin = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.nudTuongTacCMSNSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.nudTuongTacCMSNDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.nudTuongTacCMSNSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label79 = new System.Windows.Forms.Label();
            this.nudTuongTacCMSNDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.plTuongTacNhanTin = new System.Windows.Forms.Panel();
            this.btnInbox = new System.Windows.Forms.Button();
            this.label92 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.nudTuongTacNhanTinSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.nudTuongTacNhanTinDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label84 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.nudTuongTacNhanTinDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacNhanTinSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label83 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.plTuongTacChoc = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.nudTuongTacChocSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.nudTuongTacChocSoLuongDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label82 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.nudTuongTacChocSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label81 = new System.Windows.Forms.Label();
            this.nudTuongTacChocSoLuongDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.ckbTuongTacNhanTin = new System.Windows.Forms.CheckBox();
            this.ckbTuongTacChoc = new System.Windows.Forms.CheckBox();
            this.ckbTuongTacCMSN = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.plTuongTacFanpage = new System.Windows.Forms.Panel();
            this.label91 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.nudTuongTacFanpageSoLuongPageFrom = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.nudTuongTacFanpageSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
            this.ckbTuongTacFanpageComment = new System.Windows.Forms.CheckBox();
            this.btnTuongTacFanpageComment = new System.Windows.Forms.Button();
            this.ckbTuongTacFanpageLike = new System.Windows.Forms.CheckBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.nudTuongTacFanpageDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacFanpageDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacFanpageSoLuongPageTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacFanpageSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
            this.label86 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.plTuongTacGroup = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.nudTuongTacGroupSoLuongNhomFrom = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nudTuongTacGroupSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
            this.ckbTuongTacGroupComment = new System.Windows.Forms.CheckBox();
            this.btnTuongTacGroupComment = new System.Windows.Forms.Button();
            this.ckbTuongTacGroupLike = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.nudTuongTacGroupSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacGroupDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.nudTuongTacGroupDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.nudTuongTacGroupSoLuongNhomTo = new System.Windows.Forms.NumericUpDown();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.plTuongTacFriend = new System.Windows.Forms.Panel();
            this.label49 = new System.Windows.Forms.Label();
            this.nudTuongTacFriendSoLuongBanBeFrom = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.nudTuongTacFriendSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
            this.ckbTuongTacFriendComment = new System.Windows.Forms.CheckBox();
            this.btnTuongTacFriendComment = new System.Windows.Forms.Button();
            this.ckbTuongTacFriendLike = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.nudTuongTacFriendDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacFriendSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacFriendSoLuongBanBeTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacFriendDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.plTuongTacNewsfeed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTuongTacNewsfeedSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.ckbTuongTacNewsfeedComment = new System.Windows.Forms.CheckBox();
            this.btnTuongTacNewsfeedComment = new System.Windows.Forms.Button();
            this.ckbTuongTacNewsfeedLike = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.nudTuongTacNewsfeedDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacNewsfeedSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudTuongTacNewsfeedDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label64 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ckbTuongTacFanpage = new System.Windows.Forms.CheckBox();
            this.ckbTuongTacGroup = new System.Windows.Forms.CheckBox();
            this.ckbTuongTacNewsfeed = new System.Windows.Forms.CheckBox();
            this.ckbTuongTacFriend = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ckbKetBanTuKhoa = new System.Windows.Forms.CheckBox();
            this.plKetBanTepUid = new System.Windows.Forms.Panel();
            this.ckbKetBanTepUidTrungNhau = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudKetBanTepUidSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.nudKetBanTepUidDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudKetBanTepUidDelayTo = new System.Windows.Forms.NumericUpDown();
            this.nudKetBanTepUidSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label73 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.plKetBanTuKhoa = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtKetBanTuKhoaTuKhoa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudKetBanTuKhoaSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudKetBanTuKhoaDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudKetBanTuKhoaSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label69 = new System.Windows.Forms.Label();
            this.nudKetBanTuKhoaDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ckbKetBanGoiY = new System.Windows.Forms.CheckBox();
            this.plXacNhanKetBan = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.nudXacNhanKetBanSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.nudXacNhanKetBanDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudXacNhanKetBanDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.nudXacNhanKetBanSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label75 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.plKetBanGoiY = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKetBanGoiYSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudKetBanGoiYDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudKetBanGoiYDelayTo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudKetBanGoiYSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.label71 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.ckbKetBanTepUid = new System.Windows.Forms.CheckBox();
            this.ckbXacNhanKetBan = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ckbThamGiaNhom = new System.Windows.Forms.CheckBox();
            this.plThamGiaNhom = new System.Windows.Forms.Panel();
            this.ckbThamGiaNhomTrungNhau = new System.Windows.Forms.CheckBox();
            this.ckbThamGiaNhomTraLoiCauHoi = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudThamGiaNhomSoLuongFrom = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.nudThamGiaNhomDelayFrom = new System.Windows.Forms.NumericUpDown();
            this.nudThamGiaNhomSoLuongTo = new System.Windows.Forms.NumericUpDown();
            this.nudThamGiaNhomDelayTo = new System.Windows.Forms.NumericUpDown();
            this.btnThamGiaNhomTraLoiCauHoi = new System.Windows.Forms.Button();
            this.label77 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.plTuongTacCMSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNDelayTo)).BeginInit();
            this.plTuongTacNhanTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinSoLuongTo)).BeginInit();
            this.plTuongTacChoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongDelayTo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.plTuongTacFanpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongPageFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongBaiVietFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongPageTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongBaiVietTo)).BeginInit();
            this.plTuongTacGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongNhomFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongBaiVietFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongBaiVietTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongNhomTo)).BeginInit();
            this.plTuongTacFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBanBeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBaiVietFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBaiVietTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBanBeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendDelayTo)).BeginInit();
            this.plTuongTacNewsfeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedDelayTo)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.plKetBanTepUid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidSoLuongTo)).BeginInit();
            this.plKetBanTuKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaDelayTo)).BeginInit();
            this.plXacNhanKetBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanSoLuongTo)).BeginInit();
            this.plKetBanGoiY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYDelayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYSoLuongTo)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.plThamGiaNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomSoLuongFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomDelayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomSoLuongTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomDelayTo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1012, 38);
            this.bunifuCards1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1012, 30);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(980, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Cấu hình Tương tác nhanh";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(980, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(513, 675);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(409, 675);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.plTuongTacCMSN);
            this.groupBox5.Controls.Add(this.plTuongTacNhanTin);
            this.groupBox5.Controls.Add(this.plTuongTacChoc);
            this.groupBox5.Controls.Add(this.ckbTuongTacNhanTin);
            this.groupBox5.Controls.Add(this.ckbTuongTacChoc);
            this.groupBox5.Controls.Add(this.ckbTuongTacCMSN);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(662, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 381);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tương tác bạn bè";
            // 
            // plTuongTacCMSN
            // 
            this.plTuongTacCMSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacCMSN.Controls.Add(this.rbTuongTacCMSNDangBai);
            this.plTuongTacCMSN.Controls.Add(this.rbTuongTacCMSNNhanTin);
            this.plTuongTacCMSN.Controls.Add(this.label11);
            this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNSoLuongFrom);
            this.plTuongTacCMSN.Controls.Add(this.button2);
            this.plTuongTacCMSN.Controls.Add(this.label28);
            this.plTuongTacCMSN.Controls.Add(this.label35);
            this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNDelayFrom);
            this.plTuongTacCMSN.Controls.Add(this.label10);
            this.plTuongTacCMSN.Controls.Add(this.label80);
            this.plTuongTacCMSN.Controls.Add(this.label37);
            this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNSoLuongTo);
            this.plTuongTacCMSN.Controls.Add(this.label79);
            this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNDelayTo);
            this.plTuongTacCMSN.Controls.Add(this.label45);
            this.plTuongTacCMSN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTacCMSN.Location = new System.Drawing.Point(42, 256);
            this.plTuongTacCMSN.Name = "plTuongTacCMSN";
            this.plTuongTacCMSN.Size = new System.Drawing.Size(288, 118);
            this.plTuongTacCMSN.TabIndex = 5;
            // 
            // rbTuongTacCMSNDangBai
            // 
            this.rbTuongTacCMSNDangBai.AutoSize = true;
            this.rbTuongTacCMSNDangBai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTuongTacCMSNDangBai.Location = new System.Drawing.Point(199, 59);
            this.rbTuongTacCMSNDangBai.Name = "rbTuongTacCMSNDangBai";
            this.rbTuongTacCMSNDangBai.Size = new System.Drawing.Size(76, 20);
            this.rbTuongTacCMSNDangBai.TabIndex = 4;
            this.rbTuongTacCMSNDangBai.Text = "Đăng bài";
            this.rbTuongTacCMSNDangBai.UseVisualStyleBackColor = true;
            // 
            // rbTuongTacCMSNNhanTin
            // 
            this.rbTuongTacCMSNNhanTin.AutoSize = true;
            this.rbTuongTacCMSNNhanTin.Checked = true;
            this.rbTuongTacCMSNNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTuongTacCMSNNhanTin.Location = new System.Drawing.Point(122, 61);
            this.rbTuongTacCMSNNhanTin.Name = "rbTuongTacCMSNNhanTin";
            this.rbTuongTacCMSNNhanTin.Size = new System.Drawing.Size(72, 20);
            this.rbTuongTacCMSNNhanTin.TabIndex = 3;
            this.rbTuongTacCMSNNhanTin.TabStop = true;
            this.rbTuongTacCMSNNhanTin.Text = "Nhắn tin";
            this.rbTuongTacCMSNNhanTin.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 89;
            this.label11.Text = "Số lượng bạn bè";
            // 
            // nudTuongTacCMSNSoLuongFrom
            // 
            this.nudTuongTacCMSNSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacCMSNSoLuongFrom.Location = new System.Drawing.Point(122, 4);
            this.nudTuongTacCMSNSoLuongFrom.Name = "nudTuongTacCMSNSoLuongFrom";
            this.nudTuongTacCMSNSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacCMSNSoLuongFrom.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(122, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Nhập";
            this.toolTip1.SetToolTip(this.button2, "Nhập danh sách nội dung chúc mừng sinh nhật");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label28.Location = new System.Drawing.Point(7, 61);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 16);
            this.label28.TabIndex = 89;
            this.label28.Text = "Hình thức:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label35.Location = new System.Drawing.Point(7, 36);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(99, 16);
            this.label35.TabIndex = 89;
            this.label35.Text = "Thời gian delay:";
            // 
            // nudTuongTacCMSNDelayFrom
            // 
            this.nudTuongTacCMSNDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacCMSNDelayFrom.Location = new System.Drawing.Point(122, 33);
            this.nudTuongTacCMSNDelayFrom.Name = "nudTuongTacCMSNDelayFrom";
            this.nudTuongTacCMSNDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacCMSNDelayFrom.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(7, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "Nội dung:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label80.Location = new System.Drawing.Point(246, 8);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(28, 16);
            this.label80.TabIndex = 91;
            this.label80.Text = "bạn";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label37.Location = new System.Drawing.Point(246, 38);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(30, 16);
            this.label37.TabIndex = 91;
            this.label37.Text = "giây";
            // 
            // nudTuongTacCMSNSoLuongTo
            // 
            this.nudTuongTacCMSNSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacCMSNSoLuongTo.Location = new System.Drawing.Point(199, 4);
            this.nudTuongTacCMSNSoLuongTo.Name = "nudTuongTacCMSNSoLuongTo";
            this.nudTuongTacCMSNSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacCMSNSoLuongTo.TabIndex = 2;
            // 
            // label79
            // 
            this.label79.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label79.Location = new System.Drawing.Point(167, 8);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(29, 16);
            this.label79.TabIndex = 91;
            this.label79.Text = "đến";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTuongTacCMSNDelayTo
            // 
            this.nudTuongTacCMSNDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacCMSNDelayTo.Location = new System.Drawing.Point(199, 33);
            this.nudTuongTacCMSNDelayTo.Name = "nudTuongTacCMSNDelayTo";
            this.nudTuongTacCMSNDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacCMSNDelayTo.TabIndex = 2;
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label45.Location = new System.Drawing.Point(167, 38);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(29, 16);
            this.label45.TabIndex = 91;
            this.label45.Text = "đến";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plTuongTacNhanTin
            // 
            this.plTuongTacNhanTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacNhanTin.Controls.Add(this.btnInbox);
            this.plTuongTacNhanTin.Controls.Add(this.label92);
            this.plTuongTacNhanTin.Controls.Add(this.label41);
            this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinSoLuongFrom);
            this.plTuongTacNhanTin.Controls.Add(this.label42);
            this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinDelayFrom);
            this.plTuongTacNhanTin.Controls.Add(this.label84);
            this.plTuongTacNhanTin.Controls.Add(this.label43);
            this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinDelayTo);
            this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinSoLuongTo);
            this.plTuongTacNhanTin.Controls.Add(this.label83);
            this.plTuongTacNhanTin.Controls.Add(this.label44);
            this.plTuongTacNhanTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTacNhanTin.Location = new System.Drawing.Point(42, 45);
            this.plTuongTacNhanTin.Name = "plTuongTacNhanTin";
            this.plTuongTacNhanTin.Size = new System.Drawing.Size(288, 90);
            this.plTuongTacNhanTin.TabIndex = 1;
            // 
            // btnInbox
            // 
            this.btnInbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.Location = new System.Drawing.Point(122, 2);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(78, 27);
            this.btnInbox.TabIndex = 1;
            this.btnInbox.Text = "Nhập";
            this.toolTip1.SetToolTip(this.btnInbox, "Nhập danh sách tin nhắn");
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label92.Location = new System.Drawing.Point(3, 6);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(121, 16);
            this.label92.TabIndex = 0;
            this.label92.Text = "Danh sách tin nhắn:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label41.Location = new System.Drawing.Point(3, 36);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(106, 16);
            this.label41.TabIndex = 89;
            this.label41.Text = "Số lượng bạn bè:";
            // 
            // nudTuongTacNhanTinSoLuongFrom
            // 
            this.nudTuongTacNhanTinSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNhanTinSoLuongFrom.Location = new System.Drawing.Point(123, 33);
            this.nudTuongTacNhanTinSoLuongFrom.Name = "nudTuongTacNhanTinSoLuongFrom";
            this.nudTuongTacNhanTinSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacNhanTinSoLuongFrom.TabIndex = 0;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label42.Location = new System.Drawing.Point(3, 63);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(99, 16);
            this.label42.TabIndex = 89;
            this.label42.Text = "Thời gian delay:";
            // 
            // nudTuongTacNhanTinDelayFrom
            // 
            this.nudTuongTacNhanTinDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNhanTinDelayFrom.Location = new System.Drawing.Point(123, 60);
            this.nudTuongTacNhanTinDelayFrom.Name = "nudTuongTacNhanTinDelayFrom";
            this.nudTuongTacNhanTinDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacNhanTinDelayFrom.TabIndex = 2;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label84.Location = new System.Drawing.Point(247, 37);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(28, 16);
            this.label84.TabIndex = 91;
            this.label84.Text = "bạn";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label43.Location = new System.Drawing.Point(247, 65);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(30, 16);
            this.label43.TabIndex = 91;
            this.label43.Text = "giây";
            // 
            // nudTuongTacNhanTinDelayTo
            // 
            this.nudTuongTacNhanTinDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNhanTinDelayTo.Location = new System.Drawing.Point(200, 61);
            this.nudTuongTacNhanTinDelayTo.Name = "nudTuongTacNhanTinDelayTo";
            this.nudTuongTacNhanTinDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacNhanTinDelayTo.TabIndex = 3;
            // 
            // nudTuongTacNhanTinSoLuongTo
            // 
            this.nudTuongTacNhanTinSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNhanTinSoLuongTo.Location = new System.Drawing.Point(200, 33);
            this.nudTuongTacNhanTinSoLuongTo.Name = "nudTuongTacNhanTinSoLuongTo";
            this.nudTuongTacNhanTinSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacNhanTinSoLuongTo.TabIndex = 2;
            // 
            // label83
            // 
            this.label83.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label83.Location = new System.Drawing.Point(168, 37);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(29, 16);
            this.label83.TabIndex = 91;
            this.label83.Text = "đến";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label44.Location = new System.Drawing.Point(168, 65);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(29, 16);
            this.label44.TabIndex = 91;
            this.label44.Text = "đến";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plTuongTacChoc
            // 
            this.plTuongTacChoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacChoc.Controls.Add(this.label36);
            this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongFrom);
            this.plTuongTacChoc.Controls.Add(this.label38);
            this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongDelayFrom);
            this.plTuongTacChoc.Controls.Add(this.label82);
            this.plTuongTacChoc.Controls.Add(this.label39);
            this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongTo);
            this.plTuongTacChoc.Controls.Add(this.label81);
            this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongDelayTo);
            this.plTuongTacChoc.Controls.Add(this.label40);
            this.plTuongTacChoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTacChoc.Location = new System.Drawing.Point(42, 163);
            this.plTuongTacChoc.Name = "plTuongTacChoc";
            this.plTuongTacChoc.Size = new System.Drawing.Size(288, 65);
            this.plTuongTacChoc.TabIndex = 3;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label36.Location = new System.Drawing.Point(3, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(106, 16);
            this.label36.TabIndex = 89;
            this.label36.Text = "Số lượng bạn bè:";
            // 
            // nudTuongTacChocSoLuongFrom
            // 
            this.nudTuongTacChocSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacChocSoLuongFrom.Location = new System.Drawing.Point(122, 5);
            this.nudTuongTacChocSoLuongFrom.Name = "nudTuongTacChocSoLuongFrom";
            this.nudTuongTacChocSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacChocSoLuongFrom.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label38.Location = new System.Drawing.Point(3, 37);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(99, 16);
            this.label38.TabIndex = 89;
            this.label38.Text = "Thời gian delay:";
            // 
            // nudTuongTacChocSoLuongDelayFrom
            // 
            this.nudTuongTacChocSoLuongDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacChocSoLuongDelayFrom.Location = new System.Drawing.Point(122, 34);
            this.nudTuongTacChocSoLuongDelayFrom.Name = "nudTuongTacChocSoLuongDelayFrom";
            this.nudTuongTacChocSoLuongDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacChocSoLuongDelayFrom.TabIndex = 1;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label82.Location = new System.Drawing.Point(246, 10);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(28, 16);
            this.label82.TabIndex = 91;
            this.label82.Text = "bạn";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label39.Location = new System.Drawing.Point(246, 39);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(30, 16);
            this.label39.TabIndex = 91;
            this.label39.Text = "giây";
            // 
            // nudTuongTacChocSoLuongTo
            // 
            this.nudTuongTacChocSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacChocSoLuongTo.Location = new System.Drawing.Point(199, 5);
            this.nudTuongTacChocSoLuongTo.Name = "nudTuongTacChocSoLuongTo";
            this.nudTuongTacChocSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacChocSoLuongTo.TabIndex = 2;
            // 
            // label81
            // 
            this.label81.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label81.Location = new System.Drawing.Point(167, 10);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(29, 16);
            this.label81.TabIndex = 91;
            this.label81.Text = "đến";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTuongTacChocSoLuongDelayTo
            // 
            this.nudTuongTacChocSoLuongDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacChocSoLuongDelayTo.Location = new System.Drawing.Point(199, 34);
            this.nudTuongTacChocSoLuongDelayTo.Name = "nudTuongTacChocSoLuongDelayTo";
            this.nudTuongTacChocSoLuongDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacChocSoLuongDelayTo.TabIndex = 2;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label40.Location = new System.Drawing.Point(167, 39);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(29, 16);
            this.label40.TabIndex = 91;
            this.label40.Text = "đến";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbTuongTacNhanTin
            // 
            this.ckbTuongTacNhanTin.AutoSize = true;
            this.ckbTuongTacNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacNhanTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacNhanTin.Location = new System.Drawing.Point(23, 22);
            this.ckbTuongTacNhanTin.Name = "ckbTuongTacNhanTin";
            this.ckbTuongTacNhanTin.Size = new System.Drawing.Size(73, 20);
            this.ckbTuongTacNhanTin.TabIndex = 0;
            this.ckbTuongTacNhanTin.Text = "Nhắn tin";
            this.ckbTuongTacNhanTin.UseVisualStyleBackColor = true;
            this.ckbTuongTacNhanTin.CheckedChanged += new System.EventHandler(this.ckbTuongTacNhanTin_CheckedChanged);
            // 
            // ckbTuongTacChoc
            // 
            this.ckbTuongTacChoc.AutoSize = true;
            this.ckbTuongTacChoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacChoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacChoc.Location = new System.Drawing.Point(23, 140);
            this.ckbTuongTacChoc.Name = "ckbTuongTacChoc";
            this.ckbTuongTacChoc.Size = new System.Drawing.Size(97, 20);
            this.ckbTuongTacChoc.TabIndex = 2;
            this.ckbTuongTacChoc.Text = "Chọc bạn bè";
            this.ckbTuongTacChoc.UseVisualStyleBackColor = true;
            this.ckbTuongTacChoc.CheckedChanged += new System.EventHandler(this.ckbTuongTacChoc_CheckedChanged);
            // 
            // ckbTuongTacCMSN
            // 
            this.ckbTuongTacCMSN.AutoSize = true;
            this.ckbTuongTacCMSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacCMSN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacCMSN.Location = new System.Drawing.Point(23, 233);
            this.ckbTuongTacCMSN.Name = "ckbTuongTacCMSN";
            this.ckbTuongTacCMSN.Size = new System.Drawing.Size(147, 20);
            this.ckbTuongTacCMSN.TabIndex = 4;
            this.ckbTuongTacCMSN.Text = "Chúc mừng sinh nhật";
            this.ckbTuongTacCMSN.UseVisualStyleBackColor = true;
            this.ckbTuongTacCMSN.CheckedChanged += new System.EventHandler(this.ckbTuongTacCMSN_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plTuongTacFanpage);
            this.groupBox4.Controls.Add(this.plTuongTacGroup);
            this.groupBox4.Controls.Add(this.plTuongTacFriend);
            this.groupBox4.Controls.Add(this.plTuongTacNewsfeed);
            this.groupBox4.Controls.Add(this.ckbTuongTacFanpage);
            this.groupBox4.Controls.Add(this.ckbTuongTacGroup);
            this.groupBox4.Controls.Add(this.ckbTuongTacNewsfeed);
            this.groupBox4.Controls.Add(this.ckbTuongTacFriend);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(7, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(649, 381);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tương tác bài viết";
            // 
            // plTuongTacFanpage
            // 
            this.plTuongTacFanpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacFanpage.Controls.Add(this.label91);
            this.plTuongTacFanpage.Controls.Add(this.label56);
            this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongPageFrom);
            this.plTuongTacFanpage.Controls.Add(this.label58);
            this.plTuongTacFanpage.Controls.Add(this.button7);
            this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongBaiVietFrom);
            this.plTuongTacFanpage.Controls.Add(this.ckbTuongTacFanpageComment);
            this.plTuongTacFanpage.Controls.Add(this.btnTuongTacFanpageComment);
            this.plTuongTacFanpage.Controls.Add(this.ckbTuongTacFanpageLike);
            this.plTuongTacFanpage.Controls.Add(this.label59);
            this.plTuongTacFanpage.Controls.Add(this.label60);
            this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageDelayFrom);
            this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageDelayTo);
            this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongPageTo);
            this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongBaiVietTo);
            this.plTuongTacFanpage.Controls.Add(this.label86);
            this.plTuongTacFanpage.Controls.Add(this.label62);
            this.plTuongTacFanpage.Controls.Add(this.label57);
            this.plTuongTacFanpage.Controls.Add(this.label87);
            this.plTuongTacFanpage.Controls.Add(this.label85);
            this.plTuongTacFanpage.Controls.Add(this.label61);
            this.plTuongTacFanpage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTacFanpage.Location = new System.Drawing.Point(41, 198);
            this.plTuongTacFanpage.Name = "plTuongTacFanpage";
            this.plTuongTacFanpage.Size = new System.Drawing.Size(278, 176);
            this.plTuongTacFanpage.TabIndex = 97;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label91.Location = new System.Drawing.Point(7, 8);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(89, 16);
            this.label91.TabIndex = 0;
            this.label91.Text = "Nhập ID Page:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label56.Location = new System.Drawing.Point(7, 38);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(95, 16);
            this.label56.TabIndex = 0;
            this.label56.Text = "Số lượng page:";
            // 
            // nudTuongTacFanpageSoLuongPageFrom
            // 
            this.nudTuongTacFanpageSoLuongPageFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFanpageSoLuongPageFrom.Location = new System.Drawing.Point(117, 35);
            this.nudTuongTacFanpageSoLuongPageFrom.Name = "nudTuongTacFanpageSoLuongPageFrom";
            this.nudTuongTacFanpageSoLuongPageFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacFanpageSoLuongPageFrom.TabIndex = 1;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label58.Location = new System.Drawing.Point(7, 67);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(105, 16);
            this.label58.TabIndex = 89;
            this.label58.Text = "Số bài viết/page:";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.Location = new System.Drawing.Point(116, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 27);
            this.button7.TabIndex = 2;
            this.button7.Text = "Nhập";
            this.toolTip1.SetToolTip(this.button7, "Nhập danh sách ID Page");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // nudTuongTacFanpageSoLuongBaiVietFrom
            // 
            this.nudTuongTacFanpageSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFanpageSoLuongBaiVietFrom.Location = new System.Drawing.Point(117, 64);
            this.nudTuongTacFanpageSoLuongBaiVietFrom.Name = "nudTuongTacFanpageSoLuongBaiVietFrom";
            this.nudTuongTacFanpageSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacFanpageSoLuongBaiVietFrom.TabIndex = 3;
            // 
            // ckbTuongTacFanpageComment
            // 
            this.ckbTuongTacFanpageComment.AutoSize = true;
            this.ckbTuongTacFanpageComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacFanpageComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacFanpageComment.Location = new System.Drawing.Point(117, 144);
            this.ckbTuongTacFanpageComment.Name = "ckbTuongTacFanpageComment";
            this.ckbTuongTacFanpageComment.Size = new System.Drawing.Size(81, 20);
            this.ckbTuongTacFanpageComment.TabIndex = 7;
            this.ckbTuongTacFanpageComment.Text = "Comment";
            this.ckbTuongTacFanpageComment.UseVisualStyleBackColor = true;
            this.ckbTuongTacFanpageComment.CheckedChanged += new System.EventHandler(this.ckbTuongTacFanpageComment_CheckedChanged);
            // 
            // btnTuongTacFanpageComment
            // 
            this.btnTuongTacFanpageComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuongTacFanpageComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuongTacFanpageComment.Location = new System.Drawing.Point(208, 140);
            this.btnTuongTacFanpageComment.Name = "btnTuongTacFanpageComment";
            this.btnTuongTacFanpageComment.Size = new System.Drawing.Size(58, 27);
            this.btnTuongTacFanpageComment.TabIndex = 8;
            this.btnTuongTacFanpageComment.Text = "Nhập";
            this.toolTip1.SetToolTip(this.btnTuongTacFanpageComment, "Nhập danh sách bình luận");
            this.btnTuongTacFanpageComment.UseVisualStyleBackColor = true;
            this.btnTuongTacFanpageComment.Click += new System.EventHandler(this.button6_Click);
            // 
            // ckbTuongTacFanpageLike
            // 
            this.ckbTuongTacFanpageLike.AutoSize = true;
            this.ckbTuongTacFanpageLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacFanpageLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacFanpageLike.Location = new System.Drawing.Point(117, 121);
            this.ckbTuongTacFanpageLike.Name = "ckbTuongTacFanpageLike";
            this.ckbTuongTacFanpageLike.Size = new System.Drawing.Size(48, 20);
            this.ckbTuongTacFanpageLike.TabIndex = 6;
            this.ckbTuongTacFanpageLike.Text = "Like";
            this.ckbTuongTacFanpageLike.UseVisualStyleBackColor = true;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label59.Location = new System.Drawing.Point(7, 122);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(93, 16);
            this.label59.TabIndex = 89;
            this.label59.Text = "Loại tương tác:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label60.Location = new System.Drawing.Point(7, 96);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(99, 16);
            this.label60.TabIndex = 89;
            this.label60.Text = "Thời gian delay:";
            // 
            // nudTuongTacFanpageDelayFrom
            // 
            this.nudTuongTacFanpageDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFanpageDelayFrom.Location = new System.Drawing.Point(117, 93);
            this.nudTuongTacFanpageDelayFrom.Name = "nudTuongTacFanpageDelayFrom";
            this.nudTuongTacFanpageDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacFanpageDelayFrom.TabIndex = 4;
            // 
            // nudTuongTacFanpageDelayTo
            // 
            this.nudTuongTacFanpageDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFanpageDelayTo.Location = new System.Drawing.Point(194, 94);
            this.nudTuongTacFanpageDelayTo.Name = "nudTuongTacFanpageDelayTo";
            this.nudTuongTacFanpageDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacFanpageDelayTo.TabIndex = 5;
            // 
            // nudTuongTacFanpageSoLuongPageTo
            // 
            this.nudTuongTacFanpageSoLuongPageTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFanpageSoLuongPageTo.Location = new System.Drawing.Point(194, 36);
            this.nudTuongTacFanpageSoLuongPageTo.Name = "nudTuongTacFanpageSoLuongPageTo";
            this.nudTuongTacFanpageSoLuongPageTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacFanpageSoLuongPageTo.TabIndex = 4;
            // 
            // nudTuongTacFanpageSoLuongBaiVietTo
            // 
            this.nudTuongTacFanpageSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFanpageSoLuongBaiVietTo.Location = new System.Drawing.Point(194, 65);
            this.nudTuongTacFanpageSoLuongBaiVietTo.Name = "nudTuongTacFanpageSoLuongBaiVietTo";
            this.nudTuongTacFanpageSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacFanpageSoLuongBaiVietTo.TabIndex = 4;
            // 
            // label86
            // 
            this.label86.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label86.Location = new System.Drawing.Point(162, 38);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(29, 16);
            this.label86.TabIndex = 91;
            this.label86.Text = "đến";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label62.Location = new System.Drawing.Point(162, 98);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(29, 16);
            this.label62.TabIndex = 91;
            this.label62.Text = "đến";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label57.Location = new System.Drawing.Point(162, 67);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(29, 16);
            this.label57.TabIndex = 91;
            this.label57.Text = "đến";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label87.Location = new System.Drawing.Point(239, 38);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(35, 16);
            this.label87.TabIndex = 89;
            this.label87.Text = "page";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label85.Location = new System.Drawing.Point(239, 67);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(24, 16);
            this.label85.TabIndex = 89;
            this.label85.Text = "bài";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label61.Location = new System.Drawing.Point(239, 98);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(30, 16);
            this.label61.TabIndex = 91;
            this.label61.Text = "giây";
            // 
            // plTuongTacGroup
            // 
            this.plTuongTacGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacGroup.Controls.Add(this.label7);
            this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongNhomFrom);
            this.plTuongTacGroup.Controls.Add(this.label18);
            this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongBaiVietFrom);
            this.plTuongTacGroup.Controls.Add(this.ckbTuongTacGroupComment);
            this.plTuongTacGroup.Controls.Add(this.btnTuongTacGroupComment);
            this.plTuongTacGroup.Controls.Add(this.ckbTuongTacGroupLike);
            this.plTuongTacGroup.Controls.Add(this.label50);
            this.plTuongTacGroup.Controls.Add(this.label51);
            this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongBaiVietTo);
            this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupDelayFrom);
            this.plTuongTacGroup.Controls.Add(this.label55);
            this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupDelayTo);
            this.plTuongTacGroup.Controls.Add(this.label53);
            this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongNhomTo);
            this.plTuongTacGroup.Controls.Add(this.label88);
            this.plTuongTacGroup.Controls.Add(this.label89);
            this.plTuongTacGroup.Controls.Add(this.label90);
            this.plTuongTacGroup.Controls.Add(this.label52);
            this.plTuongTacGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTacGroup.Location = new System.Drawing.Point(358, 225);
            this.plTuongTacGroup.Name = "plTuongTacGroup";
            this.plTuongTacGroup.Size = new System.Drawing.Size(278, 149);
            this.plTuongTacGroup.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 89;
            this.label7.Text = "Số lượng nhóm:";
            // 
            // nudTuongTacGroupSoLuongNhomFrom
            // 
            this.nudTuongTacGroupSoLuongNhomFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacGroupSoLuongNhomFrom.Location = new System.Drawing.Point(117, 5);
            this.nudTuongTacGroupSoLuongNhomFrom.Name = "nudTuongTacGroupSoLuongNhomFrom";
            this.nudTuongTacGroupSoLuongNhomFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacGroupSoLuongNhomFrom.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(7, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 16);
            this.label18.TabIndex = 89;
            this.label18.Text = "Số bài viết/nhóm:";
            // 
            // nudTuongTacGroupSoLuongBaiVietFrom
            // 
            this.nudTuongTacGroupSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacGroupSoLuongBaiVietFrom.Location = new System.Drawing.Point(117, 34);
            this.nudTuongTacGroupSoLuongBaiVietFrom.Name = "nudTuongTacGroupSoLuongBaiVietFrom";
            this.nudTuongTacGroupSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacGroupSoLuongBaiVietFrom.TabIndex = 1;
            // 
            // ckbTuongTacGroupComment
            // 
            this.ckbTuongTacGroupComment.AutoSize = true;
            this.ckbTuongTacGroupComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacGroupComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacGroupComment.Location = new System.Drawing.Point(117, 117);
            this.ckbTuongTacGroupComment.Name = "ckbTuongTacGroupComment";
            this.ckbTuongTacGroupComment.Size = new System.Drawing.Size(81, 20);
            this.ckbTuongTacGroupComment.TabIndex = 5;
            this.ckbTuongTacGroupComment.Text = "Comment";
            this.ckbTuongTacGroupComment.UseVisualStyleBackColor = true;
            this.ckbTuongTacGroupComment.CheckedChanged += new System.EventHandler(this.ckbTuongTacGroupComment_CheckedChanged);
            // 
            // btnTuongTacGroupComment
            // 
            this.btnTuongTacGroupComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuongTacGroupComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuongTacGroupComment.Location = new System.Drawing.Point(208, 113);
            this.btnTuongTacGroupComment.Name = "btnTuongTacGroupComment";
            this.btnTuongTacGroupComment.Size = new System.Drawing.Size(58, 27);
            this.btnTuongTacGroupComment.TabIndex = 6;
            this.btnTuongTacGroupComment.Text = "Nhập";
            this.toolTip1.SetToolTip(this.btnTuongTacGroupComment, "Nhập danh sách bình luận");
            this.btnTuongTacGroupComment.UseVisualStyleBackColor = true;
            this.btnTuongTacGroupComment.Click += new System.EventHandler(this.button4_Click);
            // 
            // ckbTuongTacGroupLike
            // 
            this.ckbTuongTacGroupLike.AutoSize = true;
            this.ckbTuongTacGroupLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacGroupLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacGroupLike.Location = new System.Drawing.Point(117, 92);
            this.ckbTuongTacGroupLike.Name = "ckbTuongTacGroupLike";
            this.ckbTuongTacGroupLike.Size = new System.Drawing.Size(48, 20);
            this.ckbTuongTacGroupLike.TabIndex = 4;
            this.ckbTuongTacGroupLike.Text = "Like";
            this.ckbTuongTacGroupLike.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label50.Location = new System.Drawing.Point(7, 93);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(93, 16);
            this.label50.TabIndex = 89;
            this.label50.Text = "Loại tương tác:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label51.Location = new System.Drawing.Point(7, 66);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(99, 16);
            this.label51.TabIndex = 89;
            this.label51.Text = "Thời gian delay:";
            // 
            // nudTuongTacGroupSoLuongBaiVietTo
            // 
            this.nudTuongTacGroupSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacGroupSoLuongBaiVietTo.Location = new System.Drawing.Point(194, 35);
            this.nudTuongTacGroupSoLuongBaiVietTo.Name = "nudTuongTacGroupSoLuongBaiVietTo";
            this.nudTuongTacGroupSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacGroupSoLuongBaiVietTo.TabIndex = 2;
            // 
            // nudTuongTacGroupDelayFrom
            // 
            this.nudTuongTacGroupDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacGroupDelayFrom.Location = new System.Drawing.Point(117, 63);
            this.nudTuongTacGroupDelayFrom.Name = "nudTuongTacGroupDelayFrom";
            this.nudTuongTacGroupDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacGroupDelayFrom.TabIndex = 2;
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label55.Location = new System.Drawing.Point(162, 38);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(29, 16);
            this.label55.TabIndex = 91;
            this.label55.Text = "đến";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTuongTacGroupDelayTo
            // 
            this.nudTuongTacGroupDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacGroupDelayTo.Location = new System.Drawing.Point(194, 64);
            this.nudTuongTacGroupDelayTo.Name = "nudTuongTacGroupDelayTo";
            this.nudTuongTacGroupDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacGroupDelayTo.TabIndex = 3;
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label53.Location = new System.Drawing.Point(162, 68);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(29, 16);
            this.label53.TabIndex = 91;
            this.label53.Text = "đến";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTuongTacGroupSoLuongNhomTo
            // 
            this.nudTuongTacGroupSoLuongNhomTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacGroupSoLuongNhomTo.Location = new System.Drawing.Point(194, 5);
            this.nudTuongTacGroupSoLuongNhomTo.Name = "nudTuongTacGroupSoLuongNhomTo";
            this.nudTuongTacGroupSoLuongNhomTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacGroupSoLuongNhomTo.TabIndex = 4;
            // 
            // label88
            // 
            this.label88.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label88.Location = new System.Drawing.Point(162, 8);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(29, 16);
            this.label88.TabIndex = 91;
            this.label88.Text = "đến";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label89.Location = new System.Drawing.Point(239, 8);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(39, 16);
            this.label89.TabIndex = 89;
            this.label89.Text = "nhóm";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label90.Location = new System.Drawing.Point(240, 38);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(24, 16);
            this.label90.TabIndex = 91;
            this.label90.Text = "bài";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label52.Location = new System.Drawing.Point(240, 68);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(30, 16);
            this.label52.TabIndex = 91;
            this.label52.Text = "giây";
            // 
            // plTuongTacFriend
            // 
            this.plTuongTacFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacFriend.Controls.Add(this.label49);
            this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBanBeFrom);
            this.plTuongTacFriend.Controls.Add(this.label19);
            this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBaiVietFrom);
            this.plTuongTacFriend.Controls.Add(this.ckbTuongTacFriendComment);
            this.plTuongTacFriend.Controls.Add(this.btnTuongTacFriendComment);
            this.plTuongTacFriend.Controls.Add(this.ckbTuongTacFriendLike);
            this.plTuongTacFriend.Controls.Add(this.label33);
            this.plTuongTacFriend.Controls.Add(this.label46);
            this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendDelayFrom);
            this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBaiVietTo);
            this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBanBeTo);
            this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendDelayTo);
            this.plTuongTacFriend.Controls.Add(this.label67);
            this.plTuongTacFriend.Controls.Add(this.label66);
            this.plTuongTacFriend.Controls.Add(this.label48);
            this.plTuongTacFriend.Controls.Add(this.label68);
            this.plTuongTacFriend.Controls.Add(this.label54);
            this.plTuongTacFriend.Controls.Add(this.label47);
            this.plTuongTacFriend.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTacFriend.Location = new System.Drawing.Point(356, 46);
            this.plTuongTacFriend.Name = "plTuongTacFriend";
            this.plTuongTacFriend.Size = new System.Drawing.Size(278, 151);
            this.plTuongTacFriend.TabIndex = 4;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label49.Location = new System.Drawing.Point(7, 8);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(106, 16);
            this.label49.TabIndex = 0;
            this.label49.Text = "Số lượng bạn bè:";
            // 
            // nudTuongTacFriendSoLuongBanBeFrom
            // 
            this.nudTuongTacFriendSoLuongBanBeFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFriendSoLuongBanBeFrom.Location = new System.Drawing.Point(117, 5);
            this.nudTuongTacFriendSoLuongBanBeFrom.Name = "nudTuongTacFriendSoLuongBanBeFrom";
            this.nudTuongTacFriendSoLuongBanBeFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacFriendSoLuongBanBeFrom.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(7, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 16);
            this.label19.TabIndex = 89;
            this.label19.Text = "Số bài viết/bạn:";
            // 
            // nudTuongTacFriendSoLuongBaiVietFrom
            // 
            this.nudTuongTacFriendSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFriendSoLuongBaiVietFrom.Location = new System.Drawing.Point(117, 34);
            this.nudTuongTacFriendSoLuongBaiVietFrom.Name = "nudTuongTacFriendSoLuongBaiVietFrom";
            this.nudTuongTacFriendSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacFriendSoLuongBaiVietFrom.TabIndex = 2;
            // 
            // ckbTuongTacFriendComment
            // 
            this.ckbTuongTacFriendComment.AutoSize = true;
            this.ckbTuongTacFriendComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacFriendComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacFriendComment.Location = new System.Drawing.Point(117, 118);
            this.ckbTuongTacFriendComment.Name = "ckbTuongTacFriendComment";
            this.ckbTuongTacFriendComment.Size = new System.Drawing.Size(81, 20);
            this.ckbTuongTacFriendComment.TabIndex = 6;
            this.ckbTuongTacFriendComment.Text = "Comment";
            this.ckbTuongTacFriendComment.UseVisualStyleBackColor = true;
            this.ckbTuongTacFriendComment.CheckedChanged += new System.EventHandler(this.ckbTuongTacFriendComment_CheckedChanged);
            // 
            // btnTuongTacFriendComment
            // 
            this.btnTuongTacFriendComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuongTacFriendComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuongTacFriendComment.Location = new System.Drawing.Point(208, 114);
            this.btnTuongTacFriendComment.Name = "btnTuongTacFriendComment";
            this.btnTuongTacFriendComment.Size = new System.Drawing.Size(58, 27);
            this.btnTuongTacFriendComment.TabIndex = 7;
            this.btnTuongTacFriendComment.Text = "Nhập";
            this.toolTip1.SetToolTip(this.btnTuongTacFriendComment, "Nhập danh sách bình luận");
            this.btnTuongTacFriendComment.UseVisualStyleBackColor = true;
            this.btnTuongTacFriendComment.Click += new System.EventHandler(this.button3_Click);
            // 
            // ckbTuongTacFriendLike
            // 
            this.ckbTuongTacFriendLike.AutoSize = true;
            this.ckbTuongTacFriendLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacFriendLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacFriendLike.Location = new System.Drawing.Point(117, 93);
            this.ckbTuongTacFriendLike.Name = "ckbTuongTacFriendLike";
            this.ckbTuongTacFriendLike.Size = new System.Drawing.Size(48, 20);
            this.ckbTuongTacFriendLike.TabIndex = 5;
            this.ckbTuongTacFriendLike.Text = "Like";
            this.ckbTuongTacFriendLike.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label33.Location = new System.Drawing.Point(7, 94);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 16);
            this.label33.TabIndex = 89;
            this.label33.Text = "Loại tương tác:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label46.Location = new System.Drawing.Point(7, 66);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(99, 16);
            this.label46.TabIndex = 89;
            this.label46.Text = "Thời gian delay:";
            // 
            // nudTuongTacFriendDelayFrom
            // 
            this.nudTuongTacFriendDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFriendDelayFrom.Location = new System.Drawing.Point(117, 63);
            this.nudTuongTacFriendDelayFrom.Name = "nudTuongTacFriendDelayFrom";
            this.nudTuongTacFriendDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacFriendDelayFrom.TabIndex = 3;
            // 
            // nudTuongTacFriendSoLuongBaiVietTo
            // 
            this.nudTuongTacFriendSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFriendSoLuongBaiVietTo.Location = new System.Drawing.Point(194, 35);
            this.nudTuongTacFriendSoLuongBaiVietTo.Name = "nudTuongTacFriendSoLuongBaiVietTo";
            this.nudTuongTacFriendSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacFriendSoLuongBaiVietTo.TabIndex = 4;
            // 
            // nudTuongTacFriendSoLuongBanBeTo
            // 
            this.nudTuongTacFriendSoLuongBanBeTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFriendSoLuongBanBeTo.Location = new System.Drawing.Point(194, 6);
            this.nudTuongTacFriendSoLuongBanBeTo.Name = "nudTuongTacFriendSoLuongBanBeTo";
            this.nudTuongTacFriendSoLuongBanBeTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacFriendSoLuongBanBeTo.TabIndex = 4;
            // 
            // nudTuongTacFriendDelayTo
            // 
            this.nudTuongTacFriendDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacFriendDelayTo.Location = new System.Drawing.Point(194, 64);
            this.nudTuongTacFriendDelayTo.Name = "nudTuongTacFriendDelayTo";
            this.nudTuongTacFriendDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacFriendDelayTo.TabIndex = 4;
            // 
            // label67
            // 
            this.label67.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label67.Location = new System.Drawing.Point(162, 37);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(29, 16);
            this.label67.TabIndex = 91;
            this.label67.Text = "đến";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label66.Location = new System.Drawing.Point(162, 8);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(29, 16);
            this.label66.TabIndex = 91;
            this.label66.Text = "đến";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label48.Location = new System.Drawing.Point(162, 68);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(29, 16);
            this.label48.TabIndex = 91;
            this.label48.Text = "đến";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label68.Location = new System.Drawing.Point(240, 8);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(28, 16);
            this.label68.TabIndex = 89;
            this.label68.Text = "bạn";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label54.Location = new System.Drawing.Point(240, 37);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(24, 16);
            this.label54.TabIndex = 89;
            this.label54.Text = "bài";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label47.Location = new System.Drawing.Point(240, 68);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(30, 16);
            this.label47.TabIndex = 91;
            this.label47.Text = "giây";
            // 
            // plTuongTacNewsfeed
            // 
            this.plTuongTacNewsfeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTuongTacNewsfeed.Controls.Add(this.label1);
            this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedSoLuongFrom);
            this.plTuongTacNewsfeed.Controls.Add(this.ckbTuongTacNewsfeedComment);
            this.plTuongTacNewsfeed.Controls.Add(this.btnTuongTacNewsfeedComment);
            this.plTuongTacNewsfeed.Controls.Add(this.ckbTuongTacNewsfeedLike);
            this.plTuongTacNewsfeed.Controls.Add(this.label8);
            this.plTuongTacNewsfeed.Controls.Add(this.label24);
            this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedDelayFrom);
            this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedSoLuongTo);
            this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedDelayTo);
            this.plTuongTacNewsfeed.Controls.Add(this.label64);
            this.plTuongTacNewsfeed.Controls.Add(this.label25);
            this.plTuongTacNewsfeed.Controls.Add(this.label65);
            this.plTuongTacNewsfeed.Controls.Add(this.label29);
            this.plTuongTacNewsfeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTuongTacNewsfeed.Location = new System.Drawing.Point(41, 46);
            this.plTuongTacNewsfeed.Name = "plTuongTacNewsfeed";
            this.plTuongTacNewsfeed.Size = new System.Drawing.Size(278, 123);
            this.plTuongTacNewsfeed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Số lượng bài viết:";
            // 
            // nudTuongTacNewsfeedSoLuongFrom
            // 
            this.nudTuongTacNewsfeedSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNewsfeedSoLuongFrom.Location = new System.Drawing.Point(117, 6);
            this.nudTuongTacNewsfeedSoLuongFrom.Name = "nudTuongTacNewsfeedSoLuongFrom";
            this.nudTuongTacNewsfeedSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacNewsfeedSoLuongFrom.TabIndex = 0;
            // 
            // ckbTuongTacNewsfeedComment
            // 
            this.ckbTuongTacNewsfeedComment.AutoSize = true;
            this.ckbTuongTacNewsfeedComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacNewsfeedComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacNewsfeedComment.Location = new System.Drawing.Point(117, 90);
            this.ckbTuongTacNewsfeedComment.Name = "ckbTuongTacNewsfeedComment";
            this.ckbTuongTacNewsfeedComment.Size = new System.Drawing.Size(81, 20);
            this.ckbTuongTacNewsfeedComment.TabIndex = 4;
            this.ckbTuongTacNewsfeedComment.Text = "Comment";
            this.ckbTuongTacNewsfeedComment.UseVisualStyleBackColor = true;
            this.ckbTuongTacNewsfeedComment.CheckedChanged += new System.EventHandler(this.ckbTuongTacNewsfeedComment_CheckedChanged);
            // 
            // btnTuongTacNewsfeedComment
            // 
            this.btnTuongTacNewsfeedComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuongTacNewsfeedComment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTuongTacNewsfeedComment.Location = new System.Drawing.Point(208, 86);
            this.btnTuongTacNewsfeedComment.Name = "btnTuongTacNewsfeedComment";
            this.btnTuongTacNewsfeedComment.Size = new System.Drawing.Size(58, 27);
            this.btnTuongTacNewsfeedComment.TabIndex = 5;
            this.btnTuongTacNewsfeedComment.Text = "Nhập";
            this.toolTip1.SetToolTip(this.btnTuongTacNewsfeedComment, "Nhập danh sách bình luận");
            this.btnTuongTacNewsfeedComment.UseVisualStyleBackColor = true;
            this.btnTuongTacNewsfeedComment.Click += new System.EventHandler(this.btnOpenComment_Click_1);
            // 
            // ckbTuongTacNewsfeedLike
            // 
            this.ckbTuongTacNewsfeedLike.AutoSize = true;
            this.ckbTuongTacNewsfeedLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacNewsfeedLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacNewsfeedLike.Location = new System.Drawing.Point(117, 65);
            this.ckbTuongTacNewsfeedLike.Name = "ckbTuongTacNewsfeedLike";
            this.ckbTuongTacNewsfeedLike.Size = new System.Drawing.Size(48, 20);
            this.ckbTuongTacNewsfeedLike.TabIndex = 3;
            this.ckbTuongTacNewsfeedLike.Text = "Like";
            this.ckbTuongTacNewsfeedLike.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(7, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 89;
            this.label8.Text = "Loại tương tác:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label24.Location = new System.Drawing.Point(7, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 16);
            this.label24.TabIndex = 89;
            this.label24.Text = "Thời gian delay:";
            // 
            // nudTuongTacNewsfeedDelayFrom
            // 
            this.nudTuongTacNewsfeedDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNewsfeedDelayFrom.Location = new System.Drawing.Point(117, 36);
            this.nudTuongTacNewsfeedDelayFrom.Name = "nudTuongTacNewsfeedDelayFrom";
            this.nudTuongTacNewsfeedDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudTuongTacNewsfeedDelayFrom.TabIndex = 1;
            // 
            // nudTuongTacNewsfeedSoLuongTo
            // 
            this.nudTuongTacNewsfeedSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNewsfeedSoLuongTo.Location = new System.Drawing.Point(194, 7);
            this.nudTuongTacNewsfeedSoLuongTo.Name = "nudTuongTacNewsfeedSoLuongTo";
            this.nudTuongTacNewsfeedSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacNewsfeedSoLuongTo.TabIndex = 2;
            // 
            // nudTuongTacNewsfeedDelayTo
            // 
            this.nudTuongTacNewsfeedDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudTuongTacNewsfeedDelayTo.Location = new System.Drawing.Point(194, 37);
            this.nudTuongTacNewsfeedDelayTo.Name = "nudTuongTacNewsfeedDelayTo";
            this.nudTuongTacNewsfeedDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudTuongTacNewsfeedDelayTo.TabIndex = 2;
            // 
            // label64
            // 
            this.label64.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label64.Location = new System.Drawing.Point(162, 11);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(29, 16);
            this.label64.TabIndex = 91;
            this.label64.Text = "đến";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label25.Location = new System.Drawing.Point(162, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 16);
            this.label25.TabIndex = 91;
            this.label25.Text = "đến";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label65.Location = new System.Drawing.Point(240, 11);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(24, 16);
            this.label65.TabIndex = 91;
            this.label65.Text = "bài";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label29.Location = new System.Drawing.Point(240, 40);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 16);
            this.label29.TabIndex = 91;
            this.label29.Text = "giây";
            // 
            // ckbTuongTacFanpage
            // 
            this.ckbTuongTacFanpage.AutoSize = true;
            this.ckbTuongTacFanpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacFanpage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacFanpage.Location = new System.Drawing.Point(21, 175);
            this.ckbTuongTacFanpage.Name = "ckbTuongTacFanpage";
            this.ckbTuongTacFanpage.Size = new System.Drawing.Size(75, 20);
            this.ckbTuongTacFanpage.TabIndex = 7;
            this.ckbTuongTacFanpage.Text = "Fanpage";
            this.ckbTuongTacFanpage.UseVisualStyleBackColor = true;
            this.ckbTuongTacFanpage.CheckedChanged += new System.EventHandler(this.ckbTuongTacFanpage_CheckedChanged);
            // 
            // ckbTuongTacGroup
            // 
            this.ckbTuongTacGroup.AutoSize = true;
            this.ckbTuongTacGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacGroup.Location = new System.Drawing.Point(338, 204);
            this.ckbTuongTacGroup.Name = "ckbTuongTacGroup";
            this.ckbTuongTacGroup.Size = new System.Drawing.Size(60, 20);
            this.ckbTuongTacGroup.TabIndex = 5;
            this.ckbTuongTacGroup.Text = "Group";
            this.ckbTuongTacGroup.UseVisualStyleBackColor = true;
            this.ckbTuongTacGroup.CheckedChanged += new System.EventHandler(this.ckbTuongTacGroup_CheckedChanged);
            // 
            // ckbTuongTacNewsfeed
            // 
            this.ckbTuongTacNewsfeed.AutoSize = true;
            this.ckbTuongTacNewsfeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacNewsfeed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacNewsfeed.Location = new System.Drawing.Point(23, 22);
            this.ckbTuongTacNewsfeed.Name = "ckbTuongTacNewsfeed";
            this.ckbTuongTacNewsfeed.Size = new System.Drawing.Size(82, 20);
            this.ckbTuongTacNewsfeed.TabIndex = 0;
            this.ckbTuongTacNewsfeed.Text = "Newsfeed";
            this.ckbTuongTacNewsfeed.UseVisualStyleBackColor = true;
            this.ckbTuongTacNewsfeed.CheckedChanged += new System.EventHandler(this.ckbTuongTacNewsfeed_CheckedChanged);
            // 
            // ckbTuongTacFriend
            // 
            this.ckbTuongTacFriend.AutoSize = true;
            this.ckbTuongTacFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTuongTacFriend.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTuongTacFriend.Location = new System.Drawing.Point(338, 22);
            this.ckbTuongTacFriend.Name = "ckbTuongTacFriend";
            this.ckbTuongTacFriend.Size = new System.Drawing.Size(62, 20);
            this.ckbTuongTacFriend.TabIndex = 3;
            this.ckbTuongTacFriend.Text = "Friend";
            this.ckbTuongTacFriend.UseVisualStyleBackColor = true;
            this.ckbTuongTacFriend.CheckedChanged += new System.EventHandler(this.ckbTuongTacFriend_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ckbKetBanTuKhoa);
            this.groupBox8.Controls.Add(this.plKetBanTepUid);
            this.groupBox8.Controls.Add(this.plKetBanTuKhoa);
            this.groupBox8.Controls.Add(this.ckbKetBanGoiY);
            this.groupBox8.Controls.Add(this.plXacNhanKetBan);
            this.groupBox8.Controls.Add(this.plKetBanGoiY);
            this.groupBox8.Controls.Add(this.ckbKetBanTepUid);
            this.groupBox8.Controls.Add(this.ckbXacNhanKetBan);
            this.groupBox8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox8.Location = new System.Drawing.Point(7, 424);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(649, 243);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kết bạn";
            // 
            // ckbKetBanTuKhoa
            // 
            this.ckbKetBanTuKhoa.AutoSize = true;
            this.ckbKetBanTuKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKetBanTuKhoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbKetBanTuKhoa.Location = new System.Drawing.Point(23, 20);
            this.ckbKetBanTuKhoa.Name = "ckbKetBanTuKhoa";
            this.ckbKetBanTuKhoa.Size = new System.Drawing.Size(145, 20);
            this.ckbKetBanTuKhoa.TabIndex = 0;
            this.ckbKetBanTuKhoa.Text = "Kết bạn theo từ khóa";
            this.ckbKetBanTuKhoa.UseVisualStyleBackColor = true;
            this.ckbKetBanTuKhoa.CheckedChanged += new System.EventHandler(this.ckbKetBanTuKhoa_CheckedChanged);
            // 
            // plKetBanTepUid
            // 
            this.plKetBanTepUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plKetBanTepUid.Controls.Add(this.ckbKetBanTepUidTrungNhau);
            this.plKetBanTepUid.Controls.Add(this.label17);
            this.plKetBanTepUid.Controls.Add(this.label20);
            this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidSoLuongFrom);
            this.plKetBanTepUid.Controls.Add(this.label21);
            this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidDelayFrom);
            this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidDelayTo);
            this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidSoLuongTo);
            this.plKetBanTepUid.Controls.Add(this.label73);
            this.plKetBanTepUid.Controls.Add(this.button8);
            this.plKetBanTepUid.Controls.Add(this.label23);
            this.plKetBanTepUid.Controls.Add(this.label22);
            this.plKetBanTepUid.Controls.Add(this.label74);
            this.plKetBanTepUid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plKetBanTepUid.Location = new System.Drawing.Point(358, 43);
            this.plKetBanTepUid.Name = "plKetBanTepUid";
            this.plKetBanTepUid.Size = new System.Drawing.Size(278, 105);
            this.plKetBanTepUid.TabIndex = 5;
            // 
            // ckbKetBanTepUidTrungNhau
            // 
            this.ckbKetBanTepUidTrungNhau.AutoSize = true;
            this.ckbKetBanTepUidTrungNhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKetBanTepUidTrungNhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbKetBanTepUidTrungNhau.Location = new System.Drawing.Point(10, 82);
            this.ckbKetBanTepUidTrungNhau.Name = "ckbKetBanTepUidTrungNhau";
            this.ckbKetBanTepUidTrungNhau.Size = new System.Drawing.Size(192, 20);
            this.ckbKetBanTepUidTrungNhau.TabIndex = 112;
            this.ckbKetBanTepUidTrungNhau.Text = "Cho phép kết bạn trùng nhau";
            this.ckbKetBanTepUidTrungNhau.UseVisualStyleBackColor = true;
            this.ckbKetBanTepUidTrungNhau.CheckedChanged += new System.EventHandler(this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(7, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 16);
            this.label17.TabIndex = 89;
            this.label17.Text = "Nhập tệp UID:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(7, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 16);
            this.label20.TabIndex = 89;
            this.label20.Text = "Số lượng:";
            // 
            // nudKetBanTepUidSoLuongFrom
            // 
            this.nudKetBanTepUidSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTepUidSoLuongFrom.Location = new System.Drawing.Point(117, 31);
            this.nudKetBanTepUidSoLuongFrom.Name = "nudKetBanTepUidSoLuongFrom";
            this.nudKetBanTepUidSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudKetBanTepUidSoLuongFrom.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.Location = new System.Drawing.Point(7, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 16);
            this.label21.TabIndex = 89;
            this.label21.Text = "Thời gian delay:";
            // 
            // nudKetBanTepUidDelayFrom
            // 
            this.nudKetBanTepUidDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTepUidDelayFrom.Location = new System.Drawing.Point(117, 57);
            this.nudKetBanTepUidDelayFrom.Name = "nudKetBanTepUidDelayFrom";
            this.nudKetBanTepUidDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudKetBanTepUidDelayFrom.TabIndex = 2;
            // 
            // nudKetBanTepUidDelayTo
            // 
            this.nudKetBanTepUidDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTepUidDelayTo.Location = new System.Drawing.Point(194, 58);
            this.nudKetBanTepUidDelayTo.Name = "nudKetBanTepUidDelayTo";
            this.nudKetBanTepUidDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudKetBanTepUidDelayTo.TabIndex = 3;
            // 
            // nudKetBanTepUidSoLuongTo
            // 
            this.nudKetBanTepUidSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTepUidSoLuongTo.Location = new System.Drawing.Point(194, 32);
            this.nudKetBanTepUidSoLuongTo.Name = "nudKetBanTepUidSoLuongTo";
            this.nudKetBanTepUidSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudKetBanTepUidSoLuongTo.TabIndex = 3;
            // 
            // label73
            // 
            this.label73.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label73.Location = new System.Drawing.Point(162, 36);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(29, 16);
            this.label73.TabIndex = 91;
            this.label73.Text = "đến";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button8.Location = new System.Drawing.Point(116, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 27);
            this.button8.TabIndex = 0;
            this.button8.Text = "Nhập";
            this.toolTip1.SetToolTip(this.button8, "Nhập danh sách UID cần kết bạn");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label23.Location = new System.Drawing.Point(162, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 16);
            this.label23.TabIndex = 91;
            this.label23.Text = "đến";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label22.Location = new System.Drawing.Point(239, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 16);
            this.label22.TabIndex = 91;
            this.label22.Text = "giây";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label74.Location = new System.Drawing.Point(239, 36);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(28, 16);
            this.label74.TabIndex = 91;
            this.label74.Text = "bạn";
            // 
            // plKetBanTuKhoa
            // 
            this.plKetBanTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plKetBanTuKhoa.Controls.Add(this.pictureBox2);
            this.plKetBanTuKhoa.Controls.Add(this.txtKetBanTuKhoaTuKhoa);
            this.plKetBanTuKhoa.Controls.Add(this.label16);
            this.plKetBanTuKhoa.Controls.Add(this.label3);
            this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaSoLuongFrom);
            this.plKetBanTuKhoa.Controls.Add(this.label9);
            this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaDelayFrom);
            this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaSoLuongTo);
            this.plKetBanTuKhoa.Controls.Add(this.label69);
            this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaDelayTo);
            this.plKetBanTuKhoa.Controls.Add(this.label15);
            this.plKetBanTuKhoa.Controls.Add(this.label70);
            this.plKetBanTuKhoa.Controls.Add(this.label14);
            this.plKetBanTuKhoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plKetBanTuKhoa.Location = new System.Drawing.Point(41, 43);
            this.plKetBanTuKhoa.Name = "plKetBanTuKhoa";
            this.plKetBanTuKhoa.Size = new System.Drawing.Size(278, 91);
            this.plKetBanTuKhoa.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(249, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Có thể nhập nhiều từ khóa, ngăn cách nhau bởi dấu |");
            // 
            // txtKetBanTuKhoaTuKhoa
            // 
            this.txtKetBanTuKhoaTuKhoa.Location = new System.Drawing.Point(117, 4);
            this.txtKetBanTuKhoaTuKhoa.Name = "txtKetBanTuKhoaTuKhoa";
            this.txtKetBanTuKhoaTuKhoa.Size = new System.Drawing.Size(129, 23);
            this.txtKetBanTuKhoaTuKhoa.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(7, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "Từ khóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Số lượng:";
            // 
            // nudKetBanTuKhoaSoLuongFrom
            // 
            this.nudKetBanTuKhoaSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTuKhoaSoLuongFrom.Location = new System.Drawing.Point(117, 32);
            this.nudKetBanTuKhoaSoLuongFrom.Name = "nudKetBanTuKhoaSoLuongFrom";
            this.nudKetBanTuKhoaSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudKetBanTuKhoaSoLuongFrom.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(7, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Thời gian delay:";
            // 
            // nudKetBanTuKhoaDelayFrom
            // 
            this.nudKetBanTuKhoaDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTuKhoaDelayFrom.Location = new System.Drawing.Point(117, 62);
            this.nudKetBanTuKhoaDelayFrom.Name = "nudKetBanTuKhoaDelayFrom";
            this.nudKetBanTuKhoaDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudKetBanTuKhoaDelayFrom.TabIndex = 2;
            // 
            // nudKetBanTuKhoaSoLuongTo
            // 
            this.nudKetBanTuKhoaSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTuKhoaSoLuongTo.Location = new System.Drawing.Point(194, 32);
            this.nudKetBanTuKhoaSoLuongTo.Name = "nudKetBanTuKhoaSoLuongTo";
            this.nudKetBanTuKhoaSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudKetBanTuKhoaSoLuongTo.TabIndex = 3;
            // 
            // label69
            // 
            this.label69.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label69.Location = new System.Drawing.Point(162, 36);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(29, 16);
            this.label69.TabIndex = 91;
            this.label69.Text = "đến";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudKetBanTuKhoaDelayTo
            // 
            this.nudKetBanTuKhoaDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanTuKhoaDelayTo.Location = new System.Drawing.Point(194, 62);
            this.nudKetBanTuKhoaDelayTo.Name = "nudKetBanTuKhoaDelayTo";
            this.nudKetBanTuKhoaDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudKetBanTuKhoaDelayTo.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(162, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 16);
            this.label15.TabIndex = 91;
            this.label15.Text = "đến";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label70.Location = new System.Drawing.Point(239, 36);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(28, 16);
            this.label70.TabIndex = 91;
            this.label70.Text = "bạn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(239, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 16);
            this.label14.TabIndex = 91;
            this.label14.Text = "giây";
            // 
            // ckbKetBanGoiY
            // 
            this.ckbKetBanGoiY.AutoSize = true;
            this.ckbKetBanGoiY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKetBanGoiY.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbKetBanGoiY.Location = new System.Drawing.Point(23, 140);
            this.ckbKetBanGoiY.Name = "ckbKetBanGoiY";
            this.ckbKetBanGoiY.Size = new System.Drawing.Size(129, 20);
            this.ckbKetBanGoiY.TabIndex = 2;
            this.ckbKetBanGoiY.Text = "Kết bạn theo gợi ý";
            this.ckbKetBanGoiY.UseVisualStyleBackColor = true;
            this.ckbKetBanGoiY.CheckedChanged += new System.EventHandler(this.ckbKetBanGoiY_CheckedChanged);
            // 
            // plXacNhanKetBan
            // 
            this.plXacNhanKetBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plXacNhanKetBan.Controls.Add(this.label26);
            this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanSoLuongFrom);
            this.plXacNhanKetBan.Controls.Add(this.label27);
            this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanDelayFrom);
            this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanDelayTo);
            this.plXacNhanKetBan.Controls.Add(this.label31);
            this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanSoLuongTo);
            this.plXacNhanKetBan.Controls.Add(this.label75);
            this.plXacNhanKetBan.Controls.Add(this.label30);
            this.plXacNhanKetBan.Controls.Add(this.label76);
            this.plXacNhanKetBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plXacNhanKetBan.Location = new System.Drawing.Point(358, 176);
            this.plXacNhanKetBan.Name = "plXacNhanKetBan";
            this.plXacNhanKetBan.Size = new System.Drawing.Size(278, 61);
            this.plXacNhanKetBan.TabIndex = 97;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label26.Location = new System.Drawing.Point(7, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 16);
            this.label26.TabIndex = 89;
            this.label26.Text = "Số lượng:";
            // 
            // nudXacNhanKetBanSoLuongFrom
            // 
            this.nudXacNhanKetBanSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudXacNhanKetBanSoLuongFrom.Location = new System.Drawing.Point(117, 4);
            this.nudXacNhanKetBanSoLuongFrom.Name = "nudXacNhanKetBanSoLuongFrom";
            this.nudXacNhanKetBanSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudXacNhanKetBanSoLuongFrom.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label27.Location = new System.Drawing.Point(7, 34);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 16);
            this.label27.TabIndex = 89;
            this.label27.Text = "Thời gian delay:";
            // 
            // nudXacNhanKetBanDelayFrom
            // 
            this.nudXacNhanKetBanDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudXacNhanKetBanDelayFrom.Location = new System.Drawing.Point(117, 31);
            this.nudXacNhanKetBanDelayFrom.Name = "nudXacNhanKetBanDelayFrom";
            this.nudXacNhanKetBanDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudXacNhanKetBanDelayFrom.TabIndex = 1;
            // 
            // nudXacNhanKetBanDelayTo
            // 
            this.nudXacNhanKetBanDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudXacNhanKetBanDelayTo.Location = new System.Drawing.Point(194, 32);
            this.nudXacNhanKetBanDelayTo.Name = "nudXacNhanKetBanDelayTo";
            this.nudXacNhanKetBanDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudXacNhanKetBanDelayTo.TabIndex = 2;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label31.Location = new System.Drawing.Point(162, 36);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 16);
            this.label31.TabIndex = 91;
            this.label31.Text = "đến";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudXacNhanKetBanSoLuongTo
            // 
            this.nudXacNhanKetBanSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudXacNhanKetBanSoLuongTo.Location = new System.Drawing.Point(194, 5);
            this.nudXacNhanKetBanSoLuongTo.Name = "nudXacNhanKetBanSoLuongTo";
            this.nudXacNhanKetBanSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudXacNhanKetBanSoLuongTo.TabIndex = 3;
            // 
            // label75
            // 
            this.label75.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label75.Location = new System.Drawing.Point(162, 9);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(29, 16);
            this.label75.TabIndex = 91;
            this.label75.Text = "đến";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label30.Location = new System.Drawing.Point(239, 36);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 16);
            this.label30.TabIndex = 91;
            this.label30.Text = "giây";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label76.Location = new System.Drawing.Point(239, 9);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(28, 16);
            this.label76.TabIndex = 91;
            this.label76.Text = "bạn";
            // 
            // plKetBanGoiY
            // 
            this.plKetBanGoiY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plKetBanGoiY.Controls.Add(this.label2);
            this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYSoLuongFrom);
            this.plKetBanGoiY.Controls.Add(this.label4);
            this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYDelayFrom);
            this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYDelayTo);
            this.plKetBanGoiY.Controls.Add(this.label6);
            this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYSoLuongTo);
            this.plKetBanGoiY.Controls.Add(this.label71);
            this.plKetBanGoiY.Controls.Add(this.label5);
            this.plKetBanGoiY.Controls.Add(this.label72);
            this.plKetBanGoiY.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plKetBanGoiY.Location = new System.Drawing.Point(41, 162);
            this.plKetBanGoiY.Name = "plKetBanGoiY";
            this.plKetBanGoiY.Size = new System.Drawing.Size(278, 64);
            this.plKetBanGoiY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Số lượng:";
            // 
            // nudKetBanGoiYSoLuongFrom
            // 
            this.nudKetBanGoiYSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanGoiYSoLuongFrom.Location = new System.Drawing.Point(117, 4);
            this.nudKetBanGoiYSoLuongFrom.Name = "nudKetBanGoiYSoLuongFrom";
            this.nudKetBanGoiYSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudKetBanGoiYSoLuongFrom.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Thời gian delay:";
            // 
            // nudKetBanGoiYDelayFrom
            // 
            this.nudKetBanGoiYDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanGoiYDelayFrom.Location = new System.Drawing.Point(117, 33);
            this.nudKetBanGoiYDelayFrom.Name = "nudKetBanGoiYDelayFrom";
            this.nudKetBanGoiYDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudKetBanGoiYDelayFrom.TabIndex = 1;
            // 
            // nudKetBanGoiYDelayTo
            // 
            this.nudKetBanGoiYDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanGoiYDelayTo.Location = new System.Drawing.Point(194, 34);
            this.nudKetBanGoiYDelayTo.Name = "nudKetBanGoiYDelayTo";
            this.nudKetBanGoiYDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudKetBanGoiYDelayTo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(162, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 91;
            this.label6.Text = "đến";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudKetBanGoiYSoLuongTo
            // 
            this.nudKetBanGoiYSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudKetBanGoiYSoLuongTo.Location = new System.Drawing.Point(194, 5);
            this.nudKetBanGoiYSoLuongTo.Name = "nudKetBanGoiYSoLuongTo";
            this.nudKetBanGoiYSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudKetBanGoiYSoLuongTo.TabIndex = 3;
            // 
            // label71
            // 
            this.label71.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label71.Location = new System.Drawing.Point(162, 9);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(29, 16);
            this.label71.TabIndex = 91;
            this.label71.Text = "đến";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(239, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "giây";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label72.Location = new System.Drawing.Point(239, 9);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(28, 16);
            this.label72.TabIndex = 91;
            this.label72.Text = "bạn";
            // 
            // ckbKetBanTepUid
            // 
            this.ckbKetBanTepUid.AutoSize = true;
            this.ckbKetBanTepUid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKetBanTepUid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbKetBanTepUid.Location = new System.Drawing.Point(338, 20);
            this.ckbKetBanTepUid.Name = "ckbKetBanTepUid";
            this.ckbKetBanTepUid.Size = new System.Drawing.Size(144, 20);
            this.ckbKetBanTepUid.TabIndex = 4;
            this.ckbKetBanTepUid.Text = "Kết bạn theo tệp UID";
            this.ckbKetBanTepUid.UseVisualStyleBackColor = true;
            this.ckbKetBanTepUid.CheckedChanged += new System.EventHandler(this.ckbKetBanTepUid_CheckedChanged);
            // 
            // ckbXacNhanKetBan
            // 
            this.ckbXacNhanKetBan.AutoSize = true;
            this.ckbXacNhanKetBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbXacNhanKetBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbXacNhanKetBan.Location = new System.Drawing.Point(338, 154);
            this.ckbXacNhanKetBan.Name = "ckbXacNhanKetBan";
            this.ckbXacNhanKetBan.Size = new System.Drawing.Size(125, 20);
            this.ckbXacNhanKetBan.TabIndex = 6;
            this.ckbXacNhanKetBan.Text = "Xác nhận kết bạn";
            this.ckbXacNhanKetBan.UseVisualStyleBackColor = true;
            this.ckbXacNhanKetBan.CheckedChanged += new System.EventHandler(this.ckbXacNhanKetBan_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ckbThamGiaNhom);
            this.groupBox7.Controls.Add(this.plThamGiaNhom);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox7.Location = new System.Drawing.Point(662, 424);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(344, 243);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tham gia nhóm";
            // 
            // ckbThamGiaNhom
            // 
            this.ckbThamGiaNhom.AutoSize = true;
            this.ckbThamGiaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbThamGiaNhom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbThamGiaNhom.Location = new System.Drawing.Point(23, 22);
            this.ckbThamGiaNhom.Name = "ckbThamGiaNhom";
            this.ckbThamGiaNhom.Size = new System.Drawing.Size(183, 20);
            this.ckbThamGiaNhom.TabIndex = 0;
            this.ckbThamGiaNhom.Text = "Tham gia nhóm theo tệp ID";
            this.ckbThamGiaNhom.UseVisualStyleBackColor = true;
            this.ckbThamGiaNhom.CheckedChanged += new System.EventHandler(this.ckbThamGiaNhom_CheckedChanged);
            // 
            // plThamGiaNhom
            // 
            this.plThamGiaNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plThamGiaNhom.Controls.Add(this.ckbThamGiaNhomTrungNhau);
            this.plThamGiaNhom.Controls.Add(this.ckbThamGiaNhomTraLoiCauHoi);
            this.plThamGiaNhom.Controls.Add(this.label12);
            this.plThamGiaNhom.Controls.Add(this.label13);
            this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomSoLuongFrom);
            this.plThamGiaNhom.Controls.Add(this.label32);
            this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomDelayFrom);
            this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomSoLuongTo);
            this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomDelayTo);
            this.plThamGiaNhom.Controls.Add(this.btnThamGiaNhomTraLoiCauHoi);
            this.plThamGiaNhom.Controls.Add(this.label77);
            this.plThamGiaNhom.Controls.Add(this.button1);
            this.plThamGiaNhom.Controls.Add(this.label63);
            this.plThamGiaNhom.Controls.Add(this.label78);
            this.plThamGiaNhom.Controls.Add(this.label34);
            this.plThamGiaNhom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plThamGiaNhom.Location = new System.Drawing.Point(39, 43);
            this.plThamGiaNhom.Name = "plThamGiaNhom";
            this.plThamGiaNhom.Size = new System.Drawing.Size(291, 148);
            this.plThamGiaNhom.TabIndex = 1;
            // 
            // ckbThamGiaNhomTrungNhau
            // 
            this.ckbThamGiaNhomTrungNhau.AutoSize = true;
            this.ckbThamGiaNhomTrungNhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbThamGiaNhomTrungNhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbThamGiaNhomTrungNhau.Location = new System.Drawing.Point(10, 92);
            this.ckbThamGiaNhomTrungNhau.Name = "ckbThamGiaNhomTrungNhau";
            this.ckbThamGiaNhomTrungNhau.Size = new System.Drawing.Size(236, 20);
            this.ckbThamGiaNhomTrungNhau.TabIndex = 112;
            this.ckbThamGiaNhomTrungNhau.Text = "Cho phép tham gia nhóm trùng nhau";
            this.ckbThamGiaNhomTrungNhau.UseVisualStyleBackColor = true;
            this.ckbThamGiaNhomTrungNhau.CheckedChanged += new System.EventHandler(this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
            // 
            // ckbThamGiaNhomTraLoiCauHoi
            // 
            this.ckbThamGiaNhomTraLoiCauHoi.AutoSize = true;
            this.ckbThamGiaNhomTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbThamGiaNhomTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbThamGiaNhomTraLoiCauHoi.Location = new System.Drawing.Point(10, 118);
            this.ckbThamGiaNhomTraLoiCauHoi.Name = "ckbThamGiaNhomTraLoiCauHoi";
            this.ckbThamGiaNhomTraLoiCauHoi.Size = new System.Drawing.Size(156, 20);
            this.ckbThamGiaNhomTraLoiCauHoi.TabIndex = 112;
            this.ckbThamGiaNhomTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
            this.ckbThamGiaNhomTraLoiCauHoi.UseVisualStyleBackColor = true;
            this.ckbThamGiaNhomTraLoiCauHoi.CheckedChanged += new System.EventHandler(this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(10, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 89;
            this.label12.Text = "Nhập tệp ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(10, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 89;
            this.label13.Text = "Số lượng:";
            // 
            // nudThamGiaNhomSoLuongFrom
            // 
            this.nudThamGiaNhomSoLuongFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudThamGiaNhomSoLuongFrom.Location = new System.Drawing.Point(127, 33);
            this.nudThamGiaNhomSoLuongFrom.Name = "nudThamGiaNhomSoLuongFrom";
            this.nudThamGiaNhomSoLuongFrom.Size = new System.Drawing.Size(42, 23);
            this.nudThamGiaNhomSoLuongFrom.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label32.Location = new System.Drawing.Point(10, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 16);
            this.label32.TabIndex = 89;
            this.label32.Text = "Thời gian delay:";
            // 
            // nudThamGiaNhomDelayFrom
            // 
            this.nudThamGiaNhomDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudThamGiaNhomDelayFrom.Location = new System.Drawing.Point(127, 62);
            this.nudThamGiaNhomDelayFrom.Name = "nudThamGiaNhomDelayFrom";
            this.nudThamGiaNhomDelayFrom.Size = new System.Drawing.Size(42, 23);
            this.nudThamGiaNhomDelayFrom.TabIndex = 2;
            // 
            // nudThamGiaNhomSoLuongTo
            // 
            this.nudThamGiaNhomSoLuongTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudThamGiaNhomSoLuongTo.Location = new System.Drawing.Point(204, 32);
            this.nudThamGiaNhomSoLuongTo.Name = "nudThamGiaNhomSoLuongTo";
            this.nudThamGiaNhomSoLuongTo.Size = new System.Drawing.Size(47, 23);
            this.nudThamGiaNhomSoLuongTo.TabIndex = 3;
            // 
            // nudThamGiaNhomDelayTo
            // 
            this.nudThamGiaNhomDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudThamGiaNhomDelayTo.Location = new System.Drawing.Point(204, 62);
            this.nudThamGiaNhomDelayTo.Name = "nudThamGiaNhomDelayTo";
            this.nudThamGiaNhomDelayTo.Size = new System.Drawing.Size(47, 23);
            this.nudThamGiaNhomDelayTo.TabIndex = 3;
            // 
            // btnThamGiaNhomTraLoiCauHoi
            // 
            this.btnThamGiaNhomTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThamGiaNhomTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThamGiaNhomTraLoiCauHoi.Location = new System.Drawing.Point(170, 114);
            this.btnThamGiaNhomTraLoiCauHoi.Name = "btnThamGiaNhomTraLoiCauHoi";
            this.btnThamGiaNhomTraLoiCauHoi.Size = new System.Drawing.Size(103, 27);
            this.btnThamGiaNhomTraLoiCauHoi.TabIndex = 4;
            this.btnThamGiaNhomTraLoiCauHoi.Text = "Nhập nội dung";
            this.toolTip1.SetToolTip(this.btnThamGiaNhomTraLoiCauHoi, "Nhập danh sách nội dung câu trả lời");
            this.btnThamGiaNhomTraLoiCauHoi.UseVisualStyleBackColor = true;
            this.btnThamGiaNhomTraLoiCauHoi.Click += new System.EventHandler(this.button5_Click);
            // 
            // label77
            // 
            this.label77.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label77.Location = new System.Drawing.Point(172, 37);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(29, 16);
            this.label77.TabIndex = 91;
            this.label77.Text = "đến";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(126, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nhập";
            this.toolTip1.SetToolTip(this.button1, "Nhập danh sách ID nhóm cần tham gia");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label63
            // 
            this.label63.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label63.Location = new System.Drawing.Point(172, 65);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(29, 16);
            this.label63.TabIndex = 91;
            this.label63.Text = "đến";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label78.Location = new System.Drawing.Point(250, 37);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(39, 16);
            this.label78.TabIndex = 91;
            this.label78.Text = "nhóm";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label34.Location = new System.Drawing.Point(250, 65);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(30, 16);
            this.label34.TabIndex = 91;
            this.label34.Text = "giây";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.ToolTipTitle = "Chú thích";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // fConfigInteract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 716);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fConfigInteract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tương tác";
            this.Load += new System.EventHandler(this.FConfigInteract_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.plTuongTacCMSN.ResumeLayout(false);
            this.plTuongTacCMSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacCMSNDelayTo)).EndInit();
            this.plTuongTacNhanTin.ResumeLayout(false);
            this.plTuongTacNhanTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNhanTinSoLuongTo)).EndInit();
            this.plTuongTacChoc.ResumeLayout(false);
            this.plTuongTacChoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacChocSoLuongDelayTo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.plTuongTacFanpage.ResumeLayout(false);
            this.plTuongTacFanpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongPageFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongBaiVietFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongPageTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFanpageSoLuongBaiVietTo)).EndInit();
            this.plTuongTacGroup.ResumeLayout(false);
            this.plTuongTacGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongNhomFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongBaiVietFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongBaiVietTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacGroupSoLuongNhomTo)).EndInit();
            this.plTuongTacFriend.ResumeLayout(false);
            this.plTuongTacFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBanBeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBaiVietFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBaiVietTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendSoLuongBanBeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacFriendDelayTo)).EndInit();
            this.plTuongTacNewsfeed.ResumeLayout(false);
            this.plTuongTacNewsfeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuongTacNewsfeedDelayTo)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.plKetBanTepUid.ResumeLayout(false);
            this.plKetBanTepUid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTepUidSoLuongTo)).EndInit();
            this.plKetBanTuKhoa.ResumeLayout(false);
            this.plKetBanTuKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanTuKhoaDelayTo)).EndInit();
            this.plXacNhanKetBan.ResumeLayout(false);
            this.plXacNhanKetBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXacNhanKetBanSoLuongTo)).EndInit();
            this.plKetBanGoiY.ResumeLayout(false);
            this.plKetBanGoiY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYDelayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKetBanGoiYSoLuongTo)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.plThamGiaNhom.ResumeLayout(false);
            this.plThamGiaNhom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomSoLuongFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomDelayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomSoLuongTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamGiaNhomDelayTo)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x040017B2 RID: 6066
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040017B3 RID: 6067
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040017B4 RID: 6068
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040017B5 RID: 6069
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040017B6 RID: 6070
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040017B7 RID: 6071
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040017B8 RID: 6072
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040017B9 RID: 6073
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x040017BA RID: 6074
		private global::System.Windows.Forms.Panel plTuongTacCMSN;

		// Token: 0x040017BB RID: 6075
		private global::System.Windows.Forms.RadioButton rbTuongTacCMSNDangBai;

		// Token: 0x040017BC RID: 6076
		private global::System.Windows.Forms.RadioButton rbTuongTacCMSNNhanTin;

		// Token: 0x040017BD RID: 6077
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040017BE RID: 6078
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNSoLuongFrom;

		// Token: 0x040017BF RID: 6079
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040017C0 RID: 6080
		private global::System.Windows.Forms.Label label28;

		// Token: 0x040017C1 RID: 6081
		private global::System.Windows.Forms.Label label35;

		// Token: 0x040017C2 RID: 6082
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNDelayFrom;

		// Token: 0x040017C3 RID: 6083
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040017C4 RID: 6084
		private global::System.Windows.Forms.Label label37;

		// Token: 0x040017C5 RID: 6085
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNDelayTo;

		// Token: 0x040017C6 RID: 6086
		private global::System.Windows.Forms.Label label45;

		// Token: 0x040017C7 RID: 6087
		private global::System.Windows.Forms.Panel plTuongTacNhanTin;

		// Token: 0x040017C8 RID: 6088
		private global::System.Windows.Forms.Button btnInbox;

		// Token: 0x040017C9 RID: 6089
		private global::System.Windows.Forms.Label label41;

		// Token: 0x040017CA RID: 6090
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinSoLuongFrom;

		// Token: 0x040017CB RID: 6091
		private global::System.Windows.Forms.Label label42;

		// Token: 0x040017CC RID: 6092
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinDelayFrom;

		// Token: 0x040017CD RID: 6093
		private global::System.Windows.Forms.Label label43;

		// Token: 0x040017CE RID: 6094
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinDelayTo;

		// Token: 0x040017CF RID: 6095
		private global::System.Windows.Forms.Label label44;

		// Token: 0x040017D0 RID: 6096
		private global::System.Windows.Forms.Panel plTuongTacChoc;

		// Token: 0x040017D1 RID: 6097
		private global::System.Windows.Forms.Label label36;

		// Token: 0x040017D2 RID: 6098
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongFrom;

		// Token: 0x040017D3 RID: 6099
		private global::System.Windows.Forms.Label label38;

		// Token: 0x040017D4 RID: 6100
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongDelayFrom;

		// Token: 0x040017D5 RID: 6101
		private global::System.Windows.Forms.Label label39;

		// Token: 0x040017D6 RID: 6102
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongDelayTo;

		// Token: 0x040017D7 RID: 6103
		private global::System.Windows.Forms.Label label40;

		// Token: 0x040017D8 RID: 6104
		private global::System.Windows.Forms.CheckBox ckbTuongTacNhanTin;

		// Token: 0x040017D9 RID: 6105
		private global::System.Windows.Forms.CheckBox ckbTuongTacChoc;

		// Token: 0x040017DA RID: 6106
		private global::System.Windows.Forms.CheckBox ckbTuongTacCMSN;

		// Token: 0x040017DB RID: 6107
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040017DC RID: 6108
		private global::System.Windows.Forms.Panel plTuongTacFanpage;

		// Token: 0x040017DD RID: 6109
		private global::System.Windows.Forms.Label label56;

		// Token: 0x040017DE RID: 6110
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongPageFrom;

		// Token: 0x040017DF RID: 6111
		private global::System.Windows.Forms.Label label58;

		// Token: 0x040017E0 RID: 6112
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongBaiVietFrom;

		// Token: 0x040017E1 RID: 6113
		private global::System.Windows.Forms.CheckBox ckbTuongTacFanpageComment;

		// Token: 0x040017E2 RID: 6114
		private global::System.Windows.Forms.Button button7;

		// Token: 0x040017E3 RID: 6115
		private global::System.Windows.Forms.Button btnTuongTacFanpageComment;

		// Token: 0x040017E4 RID: 6116
		private global::System.Windows.Forms.CheckBox ckbTuongTacFanpageLike;

		// Token: 0x040017E5 RID: 6117
		private global::System.Windows.Forms.Label label59;

		// Token: 0x040017E6 RID: 6118
		private global::System.Windows.Forms.Label label60;

		// Token: 0x040017E7 RID: 6119
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageDelayFrom;

		// Token: 0x040017E8 RID: 6120
		private global::System.Windows.Forms.Label label61;

		// Token: 0x040017E9 RID: 6121
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageDelayTo;

		// Token: 0x040017EA RID: 6122
		private global::System.Windows.Forms.Label label62;

		// Token: 0x040017EB RID: 6123
		private global::System.Windows.Forms.Panel plTuongTacGroup;

		// Token: 0x040017EC RID: 6124
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040017ED RID: 6125
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongNhomFrom;

		// Token: 0x040017EE RID: 6126
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040017EF RID: 6127
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongBaiVietFrom;

		// Token: 0x040017F0 RID: 6128
		private global::System.Windows.Forms.CheckBox ckbTuongTacGroupComment;

		// Token: 0x040017F1 RID: 6129
		private global::System.Windows.Forms.Button btnTuongTacGroupComment;

		// Token: 0x040017F2 RID: 6130
		private global::System.Windows.Forms.CheckBox ckbTuongTacGroupLike;

		// Token: 0x040017F3 RID: 6131
		private global::System.Windows.Forms.Label label50;

		// Token: 0x040017F4 RID: 6132
		private global::System.Windows.Forms.Label label51;

		// Token: 0x040017F5 RID: 6133
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupDelayFrom;

		// Token: 0x040017F6 RID: 6134
		private global::System.Windows.Forms.Label label52;

		// Token: 0x040017F7 RID: 6135
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupDelayTo;

		// Token: 0x040017F8 RID: 6136
		private global::System.Windows.Forms.Label label53;

		// Token: 0x040017F9 RID: 6137
		private global::System.Windows.Forms.Panel plTuongTacFriend;

		// Token: 0x040017FA RID: 6138
		private global::System.Windows.Forms.Label label49;

		// Token: 0x040017FB RID: 6139
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBanBeFrom;

		// Token: 0x040017FC RID: 6140
		private global::System.Windows.Forms.Label label54;

		// Token: 0x040017FD RID: 6141
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040017FE RID: 6142
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBaiVietFrom;

		// Token: 0x040017FF RID: 6143
		private global::System.Windows.Forms.CheckBox ckbTuongTacFriendComment;

		// Token: 0x04001800 RID: 6144
		private global::System.Windows.Forms.Button btnTuongTacFriendComment;

		// Token: 0x04001801 RID: 6145
		private global::System.Windows.Forms.CheckBox ckbTuongTacFriendLike;

		// Token: 0x04001802 RID: 6146
		private global::System.Windows.Forms.Label label33;

		// Token: 0x04001803 RID: 6147
		private global::System.Windows.Forms.Label label46;

		// Token: 0x04001804 RID: 6148
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendDelayFrom;

		// Token: 0x04001805 RID: 6149
		private global::System.Windows.Forms.Label label47;

		// Token: 0x04001806 RID: 6150
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendDelayTo;

		// Token: 0x04001807 RID: 6151
		private global::System.Windows.Forms.Label label48;

		// Token: 0x04001808 RID: 6152
		private global::System.Windows.Forms.Panel plTuongTacNewsfeed;

		// Token: 0x04001809 RID: 6153
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400180A RID: 6154
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedSoLuongFrom;

		// Token: 0x0400180B RID: 6155
		private global::System.Windows.Forms.CheckBox ckbTuongTacNewsfeedComment;

		// Token: 0x0400180C RID: 6156
		private global::System.Windows.Forms.Button btnTuongTacNewsfeedComment;

		// Token: 0x0400180D RID: 6157
		private global::System.Windows.Forms.CheckBox ckbTuongTacNewsfeedLike;

		// Token: 0x0400180E RID: 6158
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400180F RID: 6159
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04001810 RID: 6160
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedDelayFrom;

		// Token: 0x04001811 RID: 6161
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04001812 RID: 6162
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedDelayTo;

		// Token: 0x04001813 RID: 6163
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04001814 RID: 6164
		private global::System.Windows.Forms.CheckBox ckbTuongTacFanpage;

		// Token: 0x04001815 RID: 6165
		private global::System.Windows.Forms.CheckBox ckbTuongTacGroup;

		// Token: 0x04001816 RID: 6166
		private global::System.Windows.Forms.CheckBox ckbTuongTacNewsfeed;

		// Token: 0x04001817 RID: 6167
		private global::System.Windows.Forms.CheckBox ckbTuongTacFriend;

		// Token: 0x04001818 RID: 6168
		private global::System.Windows.Forms.GroupBox groupBox8;

		// Token: 0x04001819 RID: 6169
		private global::System.Windows.Forms.CheckBox ckbKetBanGoiY;

		// Token: 0x0400181A RID: 6170
		private global::System.Windows.Forms.CheckBox ckbXacNhanKetBan;

		// Token: 0x0400181B RID: 6171
		private global::System.Windows.Forms.CheckBox ckbKetBanTepUid;

		// Token: 0x0400181C RID: 6172
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400181D RID: 6173
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x0400181E RID: 6174
		private global::System.Windows.Forms.CheckBox ckbThamGiaNhom;

		// Token: 0x0400181F RID: 6175
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04001820 RID: 6176
		private global::System.Windows.Forms.CheckBox ckbKetBanTuKhoa;

		// Token: 0x04001821 RID: 6177
		private global::System.Windows.Forms.Panel plKetBanTepUid;

		// Token: 0x04001822 RID: 6178
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04001823 RID: 6179
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04001824 RID: 6180
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidSoLuongFrom;

		// Token: 0x04001825 RID: 6181
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04001826 RID: 6182
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidDelayFrom;

		// Token: 0x04001827 RID: 6183
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04001828 RID: 6184
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidDelayTo;

		// Token: 0x04001829 RID: 6185
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400182A RID: 6186
		private global::System.Windows.Forms.Panel plKetBanTuKhoa;

		// Token: 0x0400182B RID: 6187
		private global::System.Windows.Forms.TextBox txtKetBanTuKhoaTuKhoa;

		// Token: 0x0400182C RID: 6188
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400182D RID: 6189
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400182E RID: 6190
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaSoLuongFrom;

		// Token: 0x0400182F RID: 6191
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001830 RID: 6192
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaDelayFrom;

		// Token: 0x04001831 RID: 6193
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04001832 RID: 6194
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaDelayTo;

		// Token: 0x04001833 RID: 6195
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04001834 RID: 6196
		private global::System.Windows.Forms.Panel plXacNhanKetBan;

		// Token: 0x04001835 RID: 6197
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04001836 RID: 6198
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanSoLuongFrom;

		// Token: 0x04001837 RID: 6199
		private global::System.Windows.Forms.Label label27;

		// Token: 0x04001838 RID: 6200
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanDelayFrom;

		// Token: 0x04001839 RID: 6201
		private global::System.Windows.Forms.Label label30;

		// Token: 0x0400183A RID: 6202
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanDelayTo;

		// Token: 0x0400183B RID: 6203
		private global::System.Windows.Forms.Label label31;

		// Token: 0x0400183C RID: 6204
		private global::System.Windows.Forms.Panel plKetBanGoiY;

		// Token: 0x0400183D RID: 6205
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400183E RID: 6206
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYSoLuongFrom;

		// Token: 0x0400183F RID: 6207
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001840 RID: 6208
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYDelayFrom;

		// Token: 0x04001841 RID: 6209
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001842 RID: 6210
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYDelayTo;

		// Token: 0x04001843 RID: 6211
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001844 RID: 6212
		private global::System.Windows.Forms.Panel plThamGiaNhom;

		// Token: 0x04001845 RID: 6213
		private global::System.Windows.Forms.CheckBox ckbThamGiaNhomTraLoiCauHoi;

		// Token: 0x04001846 RID: 6214
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04001847 RID: 6215
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04001848 RID: 6216
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomSoLuongFrom;

		// Token: 0x04001849 RID: 6217
		private global::System.Windows.Forms.Label label32;

		// Token: 0x0400184A RID: 6218
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomDelayFrom;

		// Token: 0x0400184B RID: 6219
		private global::System.Windows.Forms.Label label34;

		// Token: 0x0400184C RID: 6220
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomDelayTo;

		// Token: 0x0400184D RID: 6221
		private global::System.Windows.Forms.Button btnThamGiaNhomTraLoiCauHoi;

		// Token: 0x0400184E RID: 6222
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400184F RID: 6223
		private global::System.Windows.Forms.Label label63;

		// Token: 0x04001850 RID: 6224
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001851 RID: 6225
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001852 RID: 6226
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001853 RID: 6227
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04001854 RID: 6228
		private global::System.Windows.Forms.CheckBox ckbKetBanTepUidTrungNhau;

		// Token: 0x04001855 RID: 6229
		private global::System.Windows.Forms.CheckBox ckbThamGiaNhomTrungNhau;

		// Token: 0x04001856 RID: 6230
		private global::System.Windows.Forms.Label label80;

		// Token: 0x04001857 RID: 6231
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNSoLuongTo;

		// Token: 0x04001858 RID: 6232
		private global::System.Windows.Forms.Label label79;

		// Token: 0x04001859 RID: 6233
		private global::System.Windows.Forms.Label label84;

		// Token: 0x0400185A RID: 6234
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinSoLuongTo;

		// Token: 0x0400185B RID: 6235
		private global::System.Windows.Forms.Label label83;

		// Token: 0x0400185C RID: 6236
		private global::System.Windows.Forms.Label label82;

		// Token: 0x0400185D RID: 6237
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongTo;

		// Token: 0x0400185E RID: 6238
		private global::System.Windows.Forms.Label label81;

		// Token: 0x0400185F RID: 6239
		private global::System.Windows.Forms.Label label87;

		// Token: 0x04001860 RID: 6240
		private global::System.Windows.Forms.Label label85;

		// Token: 0x04001861 RID: 6241
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongPageTo;

		// Token: 0x04001862 RID: 6242
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongBaiVietTo;

		// Token: 0x04001863 RID: 6243
		private global::System.Windows.Forms.Label label86;

		// Token: 0x04001864 RID: 6244
		private global::System.Windows.Forms.Label label57;

		// Token: 0x04001865 RID: 6245
		private global::System.Windows.Forms.Label label89;

		// Token: 0x04001866 RID: 6246
		private global::System.Windows.Forms.Label label90;

		// Token: 0x04001867 RID: 6247
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongBaiVietTo;

		// Token: 0x04001868 RID: 6248
		private global::System.Windows.Forms.Label label55;

		// Token: 0x04001869 RID: 6249
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongNhomTo;

		// Token: 0x0400186A RID: 6250
		private global::System.Windows.Forms.Label label88;

		// Token: 0x0400186B RID: 6251
		private global::System.Windows.Forms.Label label68;

		// Token: 0x0400186C RID: 6252
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBaiVietTo;

		// Token: 0x0400186D RID: 6253
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBanBeTo;

		// Token: 0x0400186E RID: 6254
		private global::System.Windows.Forms.Label label67;

		// Token: 0x0400186F RID: 6255
		private global::System.Windows.Forms.Label label66;

		// Token: 0x04001870 RID: 6256
		private global::System.Windows.Forms.Label label65;

		// Token: 0x04001871 RID: 6257
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedSoLuongTo;

		// Token: 0x04001872 RID: 6258
		private global::System.Windows.Forms.Label label64;

		// Token: 0x04001873 RID: 6259
		private global::System.Windows.Forms.Label label74;

		// Token: 0x04001874 RID: 6260
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidSoLuongTo;

		// Token: 0x04001875 RID: 6261
		private global::System.Windows.Forms.Label label73;

		// Token: 0x04001876 RID: 6262
		private global::System.Windows.Forms.Label label70;

		// Token: 0x04001877 RID: 6263
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaSoLuongTo;

		// Token: 0x04001878 RID: 6264
		private global::System.Windows.Forms.Label label69;

		// Token: 0x04001879 RID: 6265
		private global::System.Windows.Forms.Label label76;

		// Token: 0x0400187A RID: 6266
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanSoLuongTo;

		// Token: 0x0400187B RID: 6267
		private global::System.Windows.Forms.Label label75;

		// Token: 0x0400187C RID: 6268
		private global::System.Windows.Forms.Label label72;

		// Token: 0x0400187D RID: 6269
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYSoLuongTo;

		// Token: 0x0400187E RID: 6270
		private global::System.Windows.Forms.Label label71;

		// Token: 0x0400187F RID: 6271
		private global::System.Windows.Forms.Label label78;

		// Token: 0x04001880 RID: 6272
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomSoLuongTo;

		// Token: 0x04001881 RID: 6273
		private global::System.Windows.Forms.Label label77;

		// Token: 0x04001882 RID: 6274
		private global::System.Windows.Forms.Label label92;

		// Token: 0x04001883 RID: 6275
		private global::System.Windows.Forms.Label label91;
	}
}
