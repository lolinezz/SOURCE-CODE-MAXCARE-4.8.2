namespace maxcare
{
	// Token: 0x0200012D RID: 301
	public partial class fCauHinhChung : global::System.Windows.Forms.Form
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x0020327C File Offset: 0x0020147C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x002032DC File Offset: 0x002014DC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.nudInteractThread = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudHideThread = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPathProfile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtApiKeyMinProxy = new System.Windows.Forms.RichTextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.nudLuongPerIPMinProxy = new System.Windows.Forms.NumericUpDown();
            this.rbMinProxy = new System.Windows.Forms.RadioButton();
            this.plVitech = new System.Windows.Forms.Panel();
            this.txtListProxyVitech = new System.Windows.Forms.RichTextBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.nudLuongPerIPVitech = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.txtApiVitech = new System.Windows.Forms.TextBox();
            this.grChrome = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.plSizeChrome = new System.Windows.Forms.Panel();
            this.rbTocDoGoNhanh = new System.Windows.Forms.RadioButton();
            this.rbTocDoGoBinhThuong = new System.Windows.Forms.RadioButton();
            this.rbTocDoGoCham = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.plSapXepCuaSoChrome = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbColumnChrome = new System.Windows.Forms.ComboBox();
            this.cbbRowChrome = new System.Windows.Forms.ComboBox();
            this.plAddChromeVaoFormView = new System.Windows.Forms.Panel();
            this.nudWidthChrome = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.nudHeighChrome = new System.Windows.Forms.NumericUpDown();
            this.AddFileAccount = new MetroFramework.Controls.MetroButton();
            this.btnDown = new MetroFramework.Controls.MetroButton();
            this.btnUp = new MetroFramework.Controls.MetroButton();
            this.nudDelayCloseChromeFrom = new System.Windows.Forms.NumericUpDown();
            this.nudDelayCloseChromeTo = new System.Windows.Forms.NumericUpDown();
            this.nudDelayOpenChromeFrom = new System.Windows.Forms.NumericUpDown();
            this.nudDelayOpenChromeTo = new System.Windows.Forms.NumericUpDown();
            this.plLinkToOtherBrowser = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLinkToOtherBrowser = new System.Windows.Forms.TextBox();
            this.rbChromium = new System.Windows.Forms.RadioButton();
            this.rbChrome = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ckbShowImageInteract = new System.Windows.Forms.CheckBox();
            this.ckbAddChromeIntoForm = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbbSizeChrome = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.plUsePortable = new System.Windows.Forms.Panel();
            this.txtPathToPortableZip = new System.Windows.Forms.TextBox();
            this.lblFileZip = new System.Windows.Forms.Label();
            this.ckbUsePortable = new System.Windows.Forms.CheckBox();
            this.cbbHostpot = new System.Windows.Forms.ComboBox();
            this.rbVitech = new System.Windows.Forms.RadioButton();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.plNordVPN = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNordVPN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbPhanBietMauNen = new System.Windows.Forms.RadioButton();
            this.rbPhanBietMauChu = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnSSH = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbHotspot = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbNordVPN = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbSSH = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbExpressVPN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.plXproxy = new System.Windows.Forms.Panel();
            this.ckbWaitDoneAllXproxy = new System.Windows.Forms.CheckBox();
            this.txtListProxy = new System.Windows.Forms.RichTextBox();
            this.rbSock5Proxy = new System.Windows.Forms.RadioButton();
            this.rbHttpProxy = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudDelayResetXProxy = new System.Windows.Forms.NumericUpDown();
            this.nudLuongPerIPXProxy = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtServiceURLXProxy = new System.Windows.Forms.TextBox();
            this.plProxyv6 = new System.Windows.Forms.Panel();
            this.txtListProxyv6 = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label39 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.nudLuongPerIPProxyv6 = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.txtApiProxyv6 = new System.Windows.Forms.TextBox();
            this.rbProxyv6 = new System.Windows.Forms.RadioButton();
            this.plShopLike = new System.Windows.Forms.Panel();
            this.txtApiShopLike = new System.Windows.Forms.RichTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.nudLuongPerIPShopLike = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.rbShopLike = new System.Windows.Forms.RadioButton();
            this.nudDelayCheckIP = new System.Windows.Forms.NumericUpDown();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label38 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.plTMProxy = new System.Windows.Forms.Panel();
            this.ckbWaitDoneAllTMProxy = new System.Windows.Forms.CheckBox();
            this.txtApiKeyTMProxy = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.nudLuongPerIPTMProxy = new System.Windows.Forms.NumericUpDown();
            this.plCheckDoiIP = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.nudChangeIpCount = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.plTinsoft = new System.Windows.Forms.Panel();
            this.ckbWaitDoneAllTinsoft = new System.Windows.Forms.CheckBox();
            this.plApiProxy = new System.Windows.Forms.Panel();
            this.lblCountApiProxy = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtApiProxy = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.plApiUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApiUser = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbbLocationTinsoft = new System.Windows.Forms.ComboBox();
            this.rbApiProxy = new System.Windows.Forms.RadioButton();
            this.rbApiUser = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudLuongPerIPTinsoft = new System.Windows.Forms.NumericUpDown();
            this.rbTMProxy = new System.Windows.Forms.RadioButton();
            this.plDcom = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtUrlHilink = new System.Windows.Forms.TextBox();
            this.txtProfileNameDcom = new System.Windows.Forms.TextBox();
            this.rbDcomHilink = new System.Windows.Forms.RadioButton();
            this.label36 = new System.Windows.Forms.Label();
            this.rbDcomThuong = new System.Windows.Forms.RadioButton();
            this.rbDcom = new System.Windows.Forms.RadioButton();
            this.rbTinsoft = new System.Windows.Forms.RadioButton();
            this.rbProxy = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbXproxy = new System.Windows.Forms.RadioButton();
            this.rbHma = new System.Windows.Forms.RadioButton();
            this.ckbKhongCheckIP = new System.Windows.Forms.CheckBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudInteractThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHideThread)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPMinProxy)).BeginInit();
            this.plVitech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPVitech)).BeginInit();
            this.grChrome.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plSizeChrome.SuspendLayout();
            this.plSapXepCuaSoChrome.SuspendLayout();
            this.plAddChromeVaoFormView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthChrome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeighChrome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayCloseChromeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayCloseChromeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayOpenChromeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayOpenChromeTo)).BeginInit();
            this.plLinkToOtherBrowser.SuspendLayout();
            this.plUsePortable.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.plNordVPN.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.plXproxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayResetXProxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPXProxy)).BeginInit();
            this.plProxyv6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPProxyv6)).BeginInit();
            this.plShopLike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPShopLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayCheckIP)).BeginInit();
            this.plTMProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTMProxy)).BeginInit();
            this.plCheckDoiIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeIpCount)).BeginInit();
            this.plTinsoft.SuspendLayout();
            this.plApiProxy.SuspendLayout();
            this.plApiUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTinsoft)).BeginInit();
            this.plDcom.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(575, 38);
            this.bunifuCards1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số luồng chạy trình duyệt:";
            // 
            // nudInteractThread
            // 
            this.nudInteractThread.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInteractThread.Location = new System.Drawing.Point(207, 25);
            this.nudInteractThread.Name = "nudInteractThread";
            this.nudInteractThread.Size = new System.Drawing.Size(89, 23);
            this.nudInteractThread.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Luồng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Luồng";
            // 
            // nudHideThread
            // 
            this.nudHideThread.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHideThread.Location = new System.Drawing.Point(207, 53);
            this.nudHideThread.Name = "nudHideThread";
            this.nudHideThread.Size = new System.Drawing.Size(89, 23);
            this.nudHideThread.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Help;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số luồng chạy ẩn (?):";
            this.toolTip1.SetToolTip(this.label6, "Là số luồng khi chạy các chức năng không liên quan gì đến trình duyệt.\r" +
        "\nVí dụ như: Check wall, Check Avatar,...\r\n(Khuyến cáo nên để 10 luồng)");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Đường dẫn folder profile:";
            // 
            // txbPathProfile
            // 
            this.txbPathProfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPathProfile.Location = new System.Drawing.Point(207, 81);
            this.txbPathProfile.Name = "txbPathProfile";
            this.txbPathProfile.Size = new System.Drawing.Size(358, 23);
            this.txbPathProfile.TabIndex = 32;
            this.txbPathProfile.Click += new System.EventHandler(this.txbPathProfile_Click);
            this.txbPathProfile.TextChanged += new System.EventHandler(this.txbPathProfile_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.rbMinProxy);
            this.panel1.Controls.Add(this.plVitech);
            this.panel1.Controls.Add(this.grChrome);
            this.panel1.Controls.Add(this.cbbHostpot);
            this.panel1.Controls.Add(this.rbVitech);
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.plNordVPN);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnSSH);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.rbHotspot);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.rbNordVPN);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.rbSSH);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.rbExpressVPN);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 703);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtApiKeyMinProxy);
            this.panel5.Controls.Add(this.label49);
            this.panel5.Controls.Add(this.label50);
            this.panel5.Controls.Add(this.nudLuongPerIPMinProxy);
            this.panel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel5.Location = new System.Drawing.Point(295, 735);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 170);
            this.panel5.TabIndex = 153;
            this.panel5.Visible = false;
            // 
            // txtApiKeyMinProxy
            // 
            this.txtApiKeyMinProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiKeyMinProxy.Location = new System.Drawing.Point(6, 23);
            this.txtApiKeyMinProxy.Name = "txtApiKeyMinProxy";
            this.txtApiKeyMinProxy.Size = new System.Drawing.Size(253, 118);
            this.txtApiKeyMinProxy.TabIndex = 144;
            this.txtApiKeyMinProxy.Text = "";
            this.txtApiKeyMinProxy.WordWrap = false;
            this.txtApiKeyMinProxy.TextChanged += new System.EventHandler(this.txtApiKeyMinProxy_TextChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label49.Location = new System.Drawing.Point(3, 2);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(111, 16);
            this.label49.TabIndex = 79;
            this.label49.Text = "Nhập API KEY (0):";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label50.Location = new System.Drawing.Point(8, 144);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(79, 16);
            this.label50.TabIndex = 139;
            this.label50.Text = "Số luồng/IP:";
            // 
            // nudLuongPerIPMinProxy
            // 
            this.nudLuongPerIPMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPMinProxy.Location = new System.Drawing.Point(93, 143);
            this.nudLuongPerIPMinProxy.Name = "nudLuongPerIPMinProxy";
            this.nudLuongPerIPMinProxy.Size = new System.Drawing.Size(67, 23);
            this.nudLuongPerIPMinProxy.TabIndex = 140;
            // 
            // rbMinProxy
            // 
            this.rbMinProxy.AutoSize = true;
            this.rbMinProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbMinProxy.Location = new System.Drawing.Point(295, 712);
            this.rbMinProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMinProxy.Name = "rbMinProxy";
            this.rbMinProxy.Size = new System.Drawing.Size(77, 20);
            this.rbMinProxy.TabIndex = 152;
            this.rbMinProxy.Text = "MinProxy";
            this.rbMinProxy.UseVisualStyleBackColor = true;
            this.rbMinProxy.Visible = false;
            this.rbMinProxy.CheckedChanged += new System.EventHandler(this.rbMinProxy_CheckedChanged);
            // 
            // plVitech
            // 
            this.plVitech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plVitech.Controls.Add(this.txtListProxyVitech);
            this.plVitech.Controls.Add(this.radioButton9);
            this.plVitech.Controls.Add(this.radioButton10);
            this.plVitech.Controls.Add(this.label40);
            this.plVitech.Controls.Add(this.label41);
            this.plVitech.Controls.Add(this.label42);
            this.plVitech.Controls.Add(this.nudLuongPerIPVitech);
            this.plVitech.Controls.Add(this.label46);
            this.plVitech.Controls.Add(this.txtApiVitech);
            this.plVitech.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plVitech.Location = new System.Drawing.Point(11, 736);
            this.plVitech.Name = "plVitech";
            this.plVitech.Size = new System.Drawing.Size(266, 170);
            this.plVitech.TabIndex = 151;
            this.plVitech.Visible = false;
            // 
            // txtListProxyVitech
            // 
            this.txtListProxyVitech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListProxyVitech.Location = new System.Drawing.Point(6, 71);
            this.txtListProxyVitech.Name = "txtListProxyVitech";
            this.txtListProxyVitech.Size = new System.Drawing.Size(255, 68);
            this.txtListProxyVitech.TabIndex = 144;
            this.txtListProxyVitech.Text = "";
            this.txtListProxyVitech.WordWrap = false;
            this.txtListProxyVitech.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton9.Enabled = false;
            this.radioButton9.Location = new System.Drawing.Point(137, 28);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(60, 20);
            this.radioButton9.TabIndex = 82;
            this.radioButton9.Text = "Sock5";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton10.Location = new System.Drawing.Point(74, 28);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(49, 20);
            this.radioButton10.TabIndex = 82;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Http";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label40.Location = new System.Drawing.Point(3, 28);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 16);
            this.label40.TabIndex = 79;
            this.label40.Text = "Loại Proxy:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label41.Location = new System.Drawing.Point(3, 50);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(98, 16);
            this.label41.TabIndex = 79;
            this.label41.Text = "Nhập Proxy (0):";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label42.Location = new System.Drawing.Point(5, 143);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 16);
            this.label42.TabIndex = 139;
            this.label42.Text = "Số luồng/IP:";
            // 
            // nudLuongPerIPVitech
            // 
            this.nudLuongPerIPVitech.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPVitech.Location = new System.Drawing.Point(90, 142);
            this.nudLuongPerIPVitech.Name = "nudLuongPerIPVitech";
            this.nudLuongPerIPVitech.Size = new System.Drawing.Size(67, 23);
            this.nudLuongPerIPVitech.TabIndex = 140;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label46.Location = new System.Drawing.Point(3, 5);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(56, 16);
            this.label46.TabIndex = 79;
            this.label46.Text = "API Key:";
            // 
            // txtApiVitech
            // 
            this.txtApiVitech.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtApiVitech.ForeColor = System.Drawing.Color.Black;
            this.txtApiVitech.Location = new System.Drawing.Point(74, 2);
            this.txtApiVitech.Name = "txtApiVitech";
            this.txtApiVitech.Size = new System.Drawing.Size(187, 23);
            this.txtApiVitech.TabIndex = 81;
            // 
            // grChrome
            // 
            this.grChrome.Controls.Add(this.panel3);
            this.grChrome.Controls.Add(this.plSizeChrome);
            this.grChrome.Controls.Add(this.plSapXepCuaSoChrome);
            this.grChrome.Controls.Add(this.plAddChromeVaoFormView);
            this.grChrome.Controls.Add(this.AddFileAccount);
            this.grChrome.Controls.Add(this.btnDown);
            this.grChrome.Controls.Add(this.btnUp);
            this.grChrome.Controls.Add(this.nudDelayCloseChromeFrom);
            this.grChrome.Controls.Add(this.nudDelayCloseChromeTo);
            this.grChrome.Controls.Add(this.nudDelayOpenChromeFrom);
            this.grChrome.Controls.Add(this.nudDelayOpenChromeTo);
            this.grChrome.Controls.Add(this.plLinkToOtherBrowser);
            this.grChrome.Controls.Add(this.rbChromium);
            this.grChrome.Controls.Add(this.rbChrome);
            this.grChrome.Controls.Add(this.label22);
            this.grChrome.Controls.Add(this.label15);
            this.grChrome.Controls.Add(this.ckbShowImageInteract);
            this.grChrome.Controls.Add(this.ckbAddChromeIntoForm);
            this.grChrome.Controls.Add(this.label32);
            this.grChrome.Controls.Add(this.cbbSizeChrome);
            this.grChrome.Controls.Add(this.label31);
            this.grChrome.Controls.Add(this.label29);
            this.grChrome.Controls.Add(this.label2);
            this.grChrome.Controls.Add(this.label21);
            this.grChrome.Controls.Add(this.label20);
            this.grChrome.Controls.Add(this.label34);
            this.grChrome.Controls.Add(this.button6);
            this.grChrome.Controls.Add(this.plUsePortable);
            this.grChrome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grChrome.Location = new System.Drawing.Point(7, 156);
            this.grChrome.Name = "grChrome";
            this.grChrome.Size = new System.Drawing.Size(568, 233);
            this.grChrome.TabIndex = 38;
            this.grChrome.TabStop = false;
            this.grChrome.Text = "Cấu hình chrome";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Location = new System.Drawing.Point(32, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 25);
            this.panel3.TabIndex = 156;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 143;
            this.button1.Text = "Check Chromedriver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Location = new System.Drawing.Point(191, 4);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(222, 16);
            this.linkLabel2.TabIndex = 147;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Hướng dẫn cập nhật ChromeDriver(?)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // plSizeChrome
            // 
            this.plSizeChrome.Controls.Add(this.rbTocDoGoNhanh);
            this.plSizeChrome.Controls.Add(this.rbTocDoGoBinhThuong);
            this.plSizeChrome.Controls.Add(this.rbTocDoGoCham);
            this.plSizeChrome.Controls.Add(this.label30);
            this.plSizeChrome.Location = new System.Drawing.Point(32, 169);
            this.plSizeChrome.Name = "plSizeChrome";
            this.plSizeChrome.Size = new System.Drawing.Size(463, 25);
            this.plSizeChrome.TabIndex = 155;
            // 
            // rbTocDoGoNhanh
            // 
            this.rbTocDoGoNhanh.AutoSize = true;
            this.rbTocDoGoNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTocDoGoNhanh.Location = new System.Drawing.Point(378, 2);
            this.rbTocDoGoNhanh.Name = "rbTocDoGoNhanh";
            this.rbTocDoGoNhanh.Size = new System.Drawing.Size(62, 20);
            this.rbTocDoGoNhanh.TabIndex = 34;
            this.rbTocDoGoNhanh.Text = "Nhanh";
            this.rbTocDoGoNhanh.UseVisualStyleBackColor = true;
            // 
            // rbTocDoGoBinhThuong
            // 
            this.rbTocDoGoBinhThuong.AutoSize = true;
            this.rbTocDoGoBinhThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTocDoGoBinhThuong.Location = new System.Drawing.Point(268, 2);
            this.rbTocDoGoBinhThuong.Name = "rbTocDoGoBinhThuong";
            this.rbTocDoGoBinhThuong.Size = new System.Drawing.Size(94, 20);
            this.rbTocDoGoBinhThuong.TabIndex = 34;
            this.rbTocDoGoBinhThuong.Text = "Bình thường";
            this.rbTocDoGoBinhThuong.UseVisualStyleBackColor = true;
            // 
            // rbTocDoGoCham
            // 
            this.rbTocDoGoCham.AutoSize = true;
            this.rbTocDoGoCham.Checked = true;
            this.rbTocDoGoCham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTocDoGoCham.Location = new System.Drawing.Point(193, 2);
            this.rbTocDoGoCham.Name = "rbTocDoGoCham";
            this.rbTocDoGoCham.Size = new System.Drawing.Size(59, 20);
            this.rbTocDoGoCham.TabIndex = 34;
            this.rbTocDoGoCham.TabStop = true;
            this.rbTocDoGoCham.Text = "Chậm";
            this.rbTocDoGoCham.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(-3, 4);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(174, 16);
            this.label30.TabIndex = 33;
            this.label30.Text = "Tùy chỉnh tốc độ gõ văn bản:";
            // 
            // plSapXepCuaSoChrome
            // 
            this.plSapXepCuaSoChrome.Controls.Add(this.label10);
            this.plSapXepCuaSoChrome.Controls.Add(this.label11);
            this.plSapXepCuaSoChrome.Controls.Add(this.cbbColumnChrome);
            this.plSapXepCuaSoChrome.Controls.Add(this.cbbRowChrome);
            this.plSapXepCuaSoChrome.Location = new System.Drawing.Point(26, 77);
            this.plSapXepCuaSoChrome.Name = "plSapXepCuaSoChrome";
            this.plSapXepCuaSoChrome.Size = new System.Drawing.Size(358, 29);
            this.plSapXepCuaSoChrome.TabIndex = 157;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Sắp xếp cửa sổ chrome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(245, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "X";
            // 
            // cbbColumnChrome
            // 
            this.cbbColumnChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbColumnChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColumnChrome.FormattingEnabled = true;
            this.cbbColumnChrome.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbColumnChrome.Location = new System.Drawing.Point(200, 2);
            this.cbbColumnChrome.Name = "cbbColumnChrome";
            this.cbbColumnChrome.Size = new System.Drawing.Size(41, 24);
            this.cbbColumnChrome.TabIndex = 145;
            // 
            // cbbRowChrome
            // 
            this.cbbRowChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbRowChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRowChrome.FormattingEnabled = true;
            this.cbbRowChrome.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbbRowChrome.Location = new System.Drawing.Point(272, 2);
            this.cbbRowChrome.Name = "cbbRowChrome";
            this.cbbRowChrome.Size = new System.Drawing.Size(41, 24);
            this.cbbRowChrome.TabIndex = 145;
            // 
            // plAddChromeVaoFormView
            // 
            this.plAddChromeVaoFormView.Controls.Add(this.nudWidthChrome);
            this.plAddChromeVaoFormView.Controls.Add(this.label35);
            this.plAddChromeVaoFormView.Controls.Add(this.label33);
            this.plAddChromeVaoFormView.Controls.Add(this.nudHeighChrome);
            this.plAddChromeVaoFormView.Location = new System.Drawing.Point(219, 48);
            this.plAddChromeVaoFormView.Name = "plAddChromeVaoFormView";
            this.plAddChromeVaoFormView.Size = new System.Drawing.Size(175, 27);
            this.plAddChromeVaoFormView.TabIndex = 156;
            // 
            // nudWidthChrome
            // 
            this.nudWidthChrome.Location = new System.Drawing.Point(41, 2);
            this.nudWidthChrome.Name = "nudWidthChrome";
            this.nudWidthChrome.Size = new System.Drawing.Size(53, 23);
            this.nudWidthChrome.TabIndex = 151;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(95, 2);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(23, 23);
            this.label35.TabIndex = 33;
            this.label35.Text = "X";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(3, 4);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 16);
            this.label33.TabIndex = 33;
            this.label33.Text = "Size:";
            // 
            // nudHeighChrome
            // 
            this.nudHeighChrome.Location = new System.Drawing.Point(118, 2);
            this.nudHeighChrome.Name = "nudHeighChrome";
            this.nudHeighChrome.Size = new System.Drawing.Size(53, 23);
            this.nudHeighChrome.TabIndex = 151;
            // 
            // AddFileAccount
            // 
            this.AddFileAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddFileAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFileAccount.Location = new System.Drawing.Point(415, 169);
            this.AddFileAccount.Name = "AddFileAccount";
            this.AddFileAccount.Size = new System.Drawing.Size(25, 25);
            this.AddFileAccount.TabIndex = 154;
            this.AddFileAccount.UseSelectable = true;
            this.AddFileAccount.Click += new System.EventHandler(this.AddFileAccount_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(512, 8);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 152;
            this.btnDown.UseSelectable = true;
            this.btnDown.Visible = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(543, 8);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 153;
            this.btnUp.UseSelectable = true;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // nudDelayCloseChromeFrom
            // 
            this.nudDelayCloseChromeFrom.Location = new System.Drawing.Point(226, 140);
            this.nudDelayCloseChromeFrom.Name = "nudDelayCloseChromeFrom";
            this.nudDelayCloseChromeFrom.Size = new System.Drawing.Size(41, 23);
            this.nudDelayCloseChromeFrom.TabIndex = 151;
            // 
            // nudDelayCloseChromeTo
            // 
            this.nudDelayCloseChromeTo.Location = new System.Drawing.Point(298, 140);
            this.nudDelayCloseChromeTo.Name = "nudDelayCloseChromeTo";
            this.nudDelayCloseChromeTo.Size = new System.Drawing.Size(41, 23);
            this.nudDelayCloseChromeTo.TabIndex = 151;
            // 
            // nudDelayOpenChromeFrom
            // 
            this.nudDelayOpenChromeFrom.Location = new System.Drawing.Point(226, 111);
            this.nudDelayOpenChromeFrom.Name = "nudDelayOpenChromeFrom";
            this.nudDelayOpenChromeFrom.Size = new System.Drawing.Size(41, 23);
            this.nudDelayOpenChromeFrom.TabIndex = 151;
            // 
            // nudDelayOpenChromeTo
            // 
            this.nudDelayOpenChromeTo.Location = new System.Drawing.Point(298, 111);
            this.nudDelayOpenChromeTo.Name = "nudDelayOpenChromeTo";
            this.nudDelayOpenChromeTo.Size = new System.Drawing.Size(41, 23);
            this.nudDelayOpenChromeTo.TabIndex = 151;
            // 
            // plLinkToOtherBrowser
            // 
            this.plLinkToOtherBrowser.Controls.Add(this.label19);
            this.plLinkToOtherBrowser.Controls.Add(this.txtLinkToOtherBrowser);
            this.plLinkToOtherBrowser.Location = new System.Drawing.Point(186, 287);
            this.plLinkToOtherBrowser.Name = "plLinkToOtherBrowser";
            this.plLinkToOtherBrowser.Size = new System.Drawing.Size(348, 26);
            this.plLinkToOtherBrowser.TabIndex = 150;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 16);
            this.label19.TabIndex = 148;
            this.label19.Text = "Đường dẫn:";
            // 
            // txtLinkToOtherBrowser
            // 
            this.txtLinkToOtherBrowser.Location = new System.Drawing.Point(83, 1);
            this.txtLinkToOtherBrowser.Name = "txtLinkToOtherBrowser";
            this.txtLinkToOtherBrowser.Size = new System.Drawing.Size(256, 23);
            this.txtLinkToOtherBrowser.TabIndex = 149;
            // 
            // rbChromium
            // 
            this.rbChromium.AutoSize = true;
            this.rbChromium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbChromium.Location = new System.Drawing.Point(268, 265);
            this.rbChromium.Name = "rbChromium";
            this.rbChromium.Size = new System.Drawing.Size(266, 20);
            this.rbChromium.TabIndex = 147;
            this.rbChromium.Text = "Khác (Chromium, Brave, Cốc cốc, Slimjet)";
            this.rbChromium.UseVisualStyleBackColor = true;
            this.rbChromium.CheckedChanged += new System.EventHandler(this.rbChrome_CheckedChanged);
            // 
            // rbChrome
            // 
            this.rbChrome.AutoSize = true;
            this.rbChrome.Checked = true;
            this.rbChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbChrome.Location = new System.Drawing.Point(191, 265);
            this.rbChrome.Name = "rbChrome";
            this.rbChrome.Size = new System.Drawing.Size(71, 20);
            this.rbChrome.TabIndex = 147;
            this.rbChrome.TabStop = true;
            this.rbChrome.Text = "Chrome";
            this.rbChrome.UseVisualStyleBackColor = true;
            this.rbChrome.CheckedChanged += new System.EventHandler(this.rbChrome_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 238);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 16);
            this.label22.TabIndex = 146;
            this.label22.Text = "Nhập Extension (.crx):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 146;
            this.label15.Text = "Chọn trình duyệt:";
            // 
            // ckbShowImageInteract
            // 
            this.ckbShowImageInteract.AutoSize = true;
            this.ckbShowImageInteract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShowImageInteract.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowImageInteract.Location = new System.Drawing.Point(32, 22);
            this.ckbShowImageInteract.Name = "ckbShowImageInteract";
            this.ckbShowImageInteract.Size = new System.Drawing.Size(184, 20);
            this.ckbShowImageInteract.TabIndex = 112;
            this.ckbShowImageInteract.Text = "Hiện ảnh khi mở trình duyệt";
            this.ckbShowImageInteract.UseVisualStyleBackColor = true;
            // 
            // ckbAddChromeIntoForm
            // 
            this.ckbAddChromeIntoForm.AutoSize = true;
            this.ckbAddChromeIntoForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAddChromeIntoForm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAddChromeIntoForm.Location = new System.Drawing.Point(32, 50);
            this.ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
            this.ckbAddChromeIntoForm.Size = new System.Drawing.Size(188, 20);
            this.ckbAddChromeIntoForm.TabIndex = 112;
            this.ckbAddChromeIntoForm.Text = "Add Chrome vào Form View";
            this.ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
            this.ckbAddChromeIntoForm.CheckedChanged += new System.EventHandler(this.ckbAddChromeIntoForm_CheckedChanged);
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(269, 142);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 16);
            this.label32.TabIndex = 33;
            this.label32.Text = "đến";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSizeChrome
            // 
            this.cbbSizeChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSizeChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSizeChrome.DropDownWidth = 200;
            this.cbbSizeChrome.FormattingEnabled = true;
            this.cbbSizeChrome.Location = new System.Drawing.Point(226, 169);
            this.cbbSizeChrome.Name = "cbbSizeChrome";
            this.cbbSizeChrome.Size = new System.Drawing.Size(183, 24);
            this.cbbSizeChrome.TabIndex = 145;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(341, 142);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 16);
            this.label31.TabIndex = 33;
            this.label31.Text = "giây";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(269, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 16);
            this.label29.TabIndex = 33;
            this.label29.Text = "đến";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Delay đóng chrome:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(341, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 16);
            this.label21.TabIndex = 33;
            this.label21.Text = "giây";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(29, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "Delay mở chrome:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(31, 167);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(161, 16);
            this.label34.TabIndex = 33;
            this.label34.Text = "Kích thước cửa số chrome:";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(190, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 27);
            this.button6.TabIndex = 143;
            this.button6.Text = "Nhập";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // plUsePortable
            // 
            this.plUsePortable.Controls.Add(this.txtPathToPortableZip);
            this.plUsePortable.Controls.Add(this.lblFileZip);
            this.plUsePortable.Controls.Add(this.ckbUsePortable);
            this.plUsePortable.Location = new System.Drawing.Point(32, 200);
            this.plUsePortable.Name = "plUsePortable";
            this.plUsePortable.Size = new System.Drawing.Size(530, 25);
            this.plUsePortable.TabIndex = 155;
            this.plUsePortable.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtPathToPortableZip
            // 
            this.txtPathToPortableZip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToPortableZip.Location = new System.Drawing.Point(194, 1);
            this.txtPathToPortableZip.Name = "txtPathToPortableZip";
            this.txtPathToPortableZip.Size = new System.Drawing.Size(333, 23);
            this.txtPathToPortableZip.TabIndex = 32;
            this.txtPathToPortableZip.Click += new System.EventHandler(this.txbPathProfile_Click);
            // 
            // lblFileZip
            // 
            this.lblFileZip.AutoSize = true;
            this.lblFileZip.Location = new System.Drawing.Point(139, 4);
            this.lblFileZip.Name = "lblFileZip";
            this.lblFileZip.Size = new System.Drawing.Size(53, 16);
            this.lblFileZip.TabIndex = 113;
            this.lblFileZip.Text = "File zip:";
            // 
            // ckbUsePortable
            // 
            this.ckbUsePortable.AutoSize = true;
            this.ckbUsePortable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbUsePortable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUsePortable.Location = new System.Drawing.Point(0, 3);
            this.ckbUsePortable.Name = "ckbUsePortable";
            this.ckbUsePortable.Size = new System.Drawing.Size(126, 20);
            this.ckbUsePortable.TabIndex = 112;
            this.ckbUsePortable.Text = "Sử dụng Portable";
            this.ckbUsePortable.UseVisualStyleBackColor = true;
            this.ckbUsePortable.CheckedChanged += new System.EventHandler(this.ckbUsePortable_CheckedChanged);
            // 
            // cbbHostpot
            // 
            this.cbbHostpot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbHostpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHostpot.Enabled = false;
            this.cbbHostpot.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbHostpot.ForeColor = System.Drawing.Color.Black;
            this.cbbHostpot.FormattingEnabled = true;
            this.cbbHostpot.Items.AddRange(new object[] {
            "Chỉ trong quốc gia đang chọn",
            "Toàn bộ quốc gia"});
            this.cbbHostpot.Location = new System.Drawing.Point(1177, 563);
            this.cbbHostpot.Name = "cbbHostpot";
            this.cbbHostpot.Size = new System.Drawing.Size(229, 24);
            this.cbbHostpot.TabIndex = 144;
            // 
            // rbVitech
            // 
            this.rbVitech.AutoSize = true;
            this.rbVitech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVitech.Enabled = false;
            this.rbVitech.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbVitech.Location = new System.Drawing.Point(11, 712);
            this.rbVitech.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVitech.Name = "rbVitech";
            this.rbVitech.Size = new System.Drawing.Size(146, 20);
            this.rbVitech.TabIndex = 150;
            this.rbVitech.Text = "VitechCheap(Sắp có)";
            this.rbVitech.UseVisualStyleBackColor = true;
            this.rbVitech.Visible = false;
            this.rbVitech.CheckedChanged += new System.EventHandler(this.rbVitech_CheckedChanged);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards2.Controls.Add(this.pnlHeader);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1156, 37);
            this.bunifuCards2.TabIndex = 40;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1156, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1125, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 77;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(1156, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cấu hình chung";
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
            this.btnCancel.Location = new System.Drawing.Point(583, 661);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Enabled = false;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(1176, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 30);
            this.panel2.TabIndex = 142;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "Đường dẫn:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(87, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 83;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(483, 661);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // plNordVPN
            // 
            this.plNordVPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plNordVPN.Controls.Add(this.label14);
            this.plNordVPN.Controls.Add(this.txtNordVPN);
            this.plNordVPN.Enabled = false;
            this.plNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plNordVPN.Location = new System.Drawing.Point(1176, 475);
            this.plNordVPN.Name = "plNordVPN";
            this.plNordVPN.Size = new System.Drawing.Size(232, 30);
            this.plNordVPN.TabIndex = 142;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "Đường dẫn:";
            // 
            // txtNordVPN
            // 
            this.txtNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNordVPN.ForeColor = System.Drawing.Color.Black;
            this.txtNordVPN.Location = new System.Drawing.Point(87, 2);
            this.txtNordVPN.Name = "txtNordVPN";
            this.txtNordVPN.Size = new System.Drawing.Size(142, 23);
            this.txtNordVPN.TabIndex = 83;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(7, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 55);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình khác";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbPhanBietMauNen);
            this.panel4.Controls.Add(this.rbPhanBietMauChu);
            this.panel4.Location = new System.Drawing.Point(253, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 24);
            this.panel4.TabIndex = 156;
            // 
            // rbPhanBietMauNen
            // 
            this.rbPhanBietMauNen.AutoSize = true;
            this.rbPhanBietMauNen.Checked = true;
            this.rbPhanBietMauNen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPhanBietMauNen.Location = new System.Drawing.Point(3, 3);
            this.rbPhanBietMauNen.Name = "rbPhanBietMauNen";
            this.rbPhanBietMauNen.Size = new System.Drawing.Size(131, 20);
            this.rbPhanBietMauNen.TabIndex = 34;
            this.rbPhanBietMauNen.TabStop = true;
            this.rbPhanBietMauNen.Text = "Đổi màu nền dòng";
            this.rbPhanBietMauNen.UseVisualStyleBackColor = true;
            // 
            // rbPhanBietMauChu
            // 
            this.rbPhanBietMauChu.AutoSize = true;
            this.rbPhanBietMauChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPhanBietMauChu.Location = new System.Drawing.Point(176, 2);
            this.rbPhanBietMauChu.Name = "rbPhanBietMauChu";
            this.rbPhanBietMauChu.Size = new System.Drawing.Size(99, 20);
            this.rbPhanBietMauChu.TabIndex = 34;
            this.rbPhanBietMauChu.Text = "Đổi màu chữ";
            this.rbPhanBietMauChu.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(29, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(224, 16);
            this.label23.TabIndex = 33;
            this.label23.Text = "Phân biệt màu [Tình trạng tài khoản]:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudHideThread);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbPathProfile);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudInteractThread);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(7, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 111);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấu hình chung";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(508, 80);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 25);
            this.button9.TabIndex = 143;
            this.button9.Text = "Chọn";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSSH
            // 
            this.btnSSH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSSH.Enabled = false;
            this.btnSSH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSSH.ForeColor = System.Drawing.Color.Black;
            this.btnSSH.Location = new System.Drawing.Point(1263, 508);
            this.btnSSH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSSH.Name = "btnSSH";
            this.btnSSH.Size = new System.Drawing.Size(106, 26);
            this.btnSSH.TabIndex = 130;
            this.btnSSH.Text = "Nhập IP SSH";
            this.btnSSH.UseVisualStyleBackColor = true;
            this.btnSSH.Click += new System.EventHandler(this.btnSSH_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Enabled = false;
            this.radioButton4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton4.Location = new System.Drawing.Point(1162, 426);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(131, 20);
            this.radioButton4.TabIndex = 133;
            this.radioButton4.Text = "Đổi IP ExpressVPN";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbHotspot
            // 
            this.rbHotspot.AutoSize = true;
            this.rbHotspot.Enabled = false;
            this.rbHotspot.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbHotspot.Location = new System.Drawing.Point(1162, 539);
            this.rbHotspot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHotspot.Name = "rbHotspot";
            this.rbHotspot.Size = new System.Drawing.Size(146, 20);
            this.rbHotspot.TabIndex = 135;
            this.rbHotspot.Text = "Đổi IP Hotspot Shield";
            this.rbHotspot.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.Enabled = false;
            this.radioButton5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton5.Location = new System.Drawing.Point(1162, 511);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(88, 20);
            this.radioButton5.TabIndex = 132;
            this.radioButton5.Text = "Đổi IP SSH";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rbNordVPN
            // 
            this.rbNordVPN.AutoSize = true;
            this.rbNordVPN.Enabled = false;
            this.rbNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNordVPN.Location = new System.Drawing.Point(1162, 451);
            this.rbNordVPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNordVPN.Name = "rbNordVPN";
            this.rbNordVPN.Size = new System.Drawing.Size(114, 20);
            this.rbNordVPN.TabIndex = 134;
            this.rbNordVPN.Text = "Đổi IP NordVPN";
            this.rbNordVPN.UseVisualStyleBackColor = true;
            this.rbNordVPN.CheckedChanged += new System.EventHandler(this.rbNordVPN_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton2.Location = new System.Drawing.Point(1162, 539);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 20);
            this.radioButton2.TabIndex = 135;
            this.radioButton2.Text = "Đổi IP Hotspot Shield";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbSSH
            // 
            this.rbSSH.AutoSize = true;
            this.rbSSH.Enabled = false;
            this.rbSSH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbSSH.Location = new System.Drawing.Point(1162, 511);
            this.rbSSH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSSH.Name = "rbSSH";
            this.rbSSH.Size = new System.Drawing.Size(88, 20);
            this.rbSSH.TabIndex = 132;
            this.rbSSH.Text = "Đổi IP SSH";
            this.rbSSH.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Enabled = false;
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton3.Location = new System.Drawing.Point(1162, 451);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(114, 20);
            this.radioButton3.TabIndex = 134;
            this.radioButton3.Text = "Đổi IP NordVPN";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbNordVPN_CheckedChanged);
            // 
            // rbExpressVPN
            // 
            this.rbExpressVPN.AutoSize = true;
            this.rbExpressVPN.Enabled = false;
            this.rbExpressVPN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbExpressVPN.Location = new System.Drawing.Point(1162, 426);
            this.rbExpressVPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbExpressVPN.Name = "rbExpressVPN";
            this.rbExpressVPN.Size = new System.Drawing.Size(131, 20);
            this.rbExpressVPN.TabIndex = 133;
            this.rbExpressVPN.Text = "Đổi IP ExpressVPN";
            this.rbExpressVPN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.plXproxy);
            this.groupBox3.Controls.Add(this.plProxyv6);
            this.groupBox3.Controls.Add(this.rbProxyv6);
            this.groupBox3.Controls.Add(this.plShopLike);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.rbShopLike);
            this.groupBox3.Controls.Add(this.nudDelayCheckIP);
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.plTMProxy);
            this.groupBox3.Controls.Add(this.plCheckDoiIP);
            this.groupBox3.Controls.Add(this.plTinsoft);
            this.groupBox3.Controls.Add(this.rbTMProxy);
            this.groupBox3.Controls.Add(this.plDcom);
            this.groupBox3.Controls.Add(this.rbDcom);
            this.groupBox3.Controls.Add(this.rbTinsoft);
            this.groupBox3.Controls.Add(this.rbProxy);
            this.groupBox3.Controls.Add(this.rbNone);
            this.groupBox3.Controls.Add(this.rbXproxy);
            this.groupBox3.Controls.Add(this.rbHma);
            this.groupBox3.Controls.Add(this.ckbKhongCheckIP);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(581, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 607);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cấu hình đổi IP";
            // 
            // plXproxy
            // 
            this.plXproxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plXproxy.Controls.Add(this.ckbWaitDoneAllXproxy);
            this.plXproxy.Controls.Add(this.txtListProxy);
            this.plXproxy.Controls.Add(this.rbSock5Proxy);
            this.plXproxy.Controls.Add(this.rbHttpProxy);
            this.plXproxy.Controls.Add(this.label16);
            this.plXproxy.Controls.Add(this.metroButton1);
            this.plXproxy.Controls.Add(this.label17);
            this.plXproxy.Controls.Add(this.label52);
            this.plXproxy.Controls.Add(this.label51);
            this.plXproxy.Controls.Add(this.label18);
            this.plXproxy.Controls.Add(this.nudDelayResetXProxy);
            this.plXproxy.Controls.Add(this.nudLuongPerIPXProxy);
            this.plXproxy.Controls.Add(this.label13);
            this.plXproxy.Controls.Add(this.txtServiceURLXProxy);
            this.plXproxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plXproxy.Location = new System.Drawing.Point(322, 82);
            this.plXproxy.Name = "plXproxy";
            this.plXproxy.Size = new System.Drawing.Size(240, 170);
            this.plXproxy.TabIndex = 142;
            this.plXproxy.Click += new System.EventHandler(this.plXproxy_Click);
            // 
            // ckbWaitDoneAllXproxy
            // 
            this.ckbWaitDoneAllXproxy.AutoSize = true;
            this.ckbWaitDoneAllXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbWaitDoneAllXproxy.Location = new System.Drawing.Point(108, 49);
            this.ckbWaitDoneAllXproxy.Name = "ckbWaitDoneAllXproxy";
            this.ckbWaitDoneAllXproxy.Size = new System.Drawing.Size(129, 20);
            this.ckbWaitDoneAllXproxy.TabIndex = 145;
            this.ckbWaitDoneAllXproxy.Text = "Đợi chạy xong hết";
            this.ckbWaitDoneAllXproxy.UseVisualStyleBackColor = true;
            this.ckbWaitDoneAllXproxy.Visible = false;
            // 
            // txtListProxy
            // 
            this.txtListProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListProxy.Location = new System.Drawing.Point(6, 71);
            this.txtListProxy.Name = "txtListProxy";
            this.txtListProxy.Size = new System.Drawing.Size(229, 68);
            this.txtListProxy.TabIndex = 144;
            this.txtListProxy.Text = "";
            this.txtListProxy.WordWrap = false;
            this.txtListProxy.TextChanged += new System.EventHandler(this.txtListProxy_TextChanged);
            // 
            // rbSock5Proxy
            // 
            this.rbSock5Proxy.AutoSize = true;
            this.rbSock5Proxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSock5Proxy.Location = new System.Drawing.Point(153, 28);
            this.rbSock5Proxy.Name = "rbSock5Proxy";
            this.rbSock5Proxy.Size = new System.Drawing.Size(60, 20);
            this.rbSock5Proxy.TabIndex = 82;
            this.rbSock5Proxy.Text = "Sock5";
            this.rbSock5Proxy.UseVisualStyleBackColor = true;
            // 
            // rbHttpProxy
            // 
            this.rbHttpProxy.AutoSize = true;
            this.rbHttpProxy.Checked = true;
            this.rbHttpProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHttpProxy.Location = new System.Drawing.Point(90, 28);
            this.rbHttpProxy.Name = "rbHttpProxy";
            this.rbHttpProxy.Size = new System.Drawing.Size(49, 20);
            this.rbHttpProxy.TabIndex = 82;
            this.rbHttpProxy.TabStop = true;
            this.rbHttpProxy.Text = "Http";
            this.rbHttpProxy.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(3, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 16);
            this.label16.TabIndex = 79;
            this.label16.Text = "Loại Proxy:";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(209, 141);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(25, 25);
            this.metroButton1.TabIndex = 152;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(3, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 16);
            this.label17.TabIndex = 79;
            this.label17.Text = "Nhập Proxy (0):";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label52.Location = new System.Drawing.Point(199, 174);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(33, 16);
            this.label52.TabIndex = 139;
            this.label52.Text = "phút";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label51.Location = new System.Drawing.Point(5, 172);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(139, 16);
            this.label51.TabIndex = 139;
            this.label51.Text = "Chờ reset proxy tối đa:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(5, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 16);
            this.label18.TabIndex = 139;
            this.label18.Text = "Số luồng/IP:";
            // 
            // nudDelayResetXProxy
            // 
            this.nudDelayResetXProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudDelayResetXProxy.Location = new System.Drawing.Point(144, 170);
            this.nudDelayResetXProxy.Name = "nudDelayResetXProxy";
            this.nudDelayResetXProxy.Size = new System.Drawing.Size(50, 23);
            this.nudDelayResetXProxy.TabIndex = 140;
            // 
            // nudLuongPerIPXProxy
            // 
            this.nudLuongPerIPXProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPXProxy.Location = new System.Drawing.Point(90, 142);
            this.nudLuongPerIPXProxy.Name = "nudLuongPerIPXProxy";
            this.nudLuongPerIPXProxy.Size = new System.Drawing.Size(67, 23);
            this.nudLuongPerIPXProxy.TabIndex = 140;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 79;
            this.label13.Text = "Service URL:";
            // 
            // txtServiceURLXProxy
            // 
            this.txtServiceURLXProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtServiceURLXProxy.ForeColor = System.Drawing.Color.Black;
            this.txtServiceURLXProxy.Location = new System.Drawing.Point(90, 2);
            this.txtServiceURLXProxy.Name = "txtServiceURLXProxy";
            this.txtServiceURLXProxy.Size = new System.Drawing.Size(145, 23);
            this.txtServiceURLXProxy.TabIndex = 81;
            // 
            // plProxyv6
            // 
            this.plProxyv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plProxyv6.Controls.Add(this.txtListProxyv6);
            this.plProxyv6.Controls.Add(this.radioButton1);
            this.plProxyv6.Controls.Add(this.radioButton6);
            this.plProxyv6.Controls.Add(this.label39);
            this.plProxyv6.Controls.Add(this.label43);
            this.plProxyv6.Controls.Add(this.label44);
            this.plProxyv6.Controls.Add(this.nudLuongPerIPProxyv6);
            this.plProxyv6.Controls.Add(this.label45);
            this.plProxyv6.Controls.Add(this.txtApiProxyv6);
            this.plProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plProxyv6.Location = new System.Drawing.Point(324, 427);
            this.plProxyv6.Name = "plProxyv6";
            this.plProxyv6.Size = new System.Drawing.Size(240, 170);
            this.plProxyv6.TabIndex = 151;
            // 
            // txtListProxyv6
            // 
            this.txtListProxyv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListProxyv6.Location = new System.Drawing.Point(6, 71);
            this.txtListProxyv6.Name = "txtListProxyv6";
            this.txtListProxyv6.Size = new System.Drawing.Size(229, 68);
            this.txtListProxyv6.TabIndex = 144;
            this.txtListProxyv6.Text = "";
            this.txtListProxyv6.WordWrap = false;
            this.txtListProxyv6.TextChanged += new System.EventHandler(this.txtListProxyv6_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(138, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 20);
            this.radioButton1.TabIndex = 82;
            this.radioButton1.Text = "Sock5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.Location = new System.Drawing.Point(75, 28);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(49, 20);
            this.radioButton6.TabIndex = 82;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Http";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label39.Location = new System.Drawing.Point(3, 28);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(71, 16);
            this.label39.TabIndex = 79;
            this.label39.Text = "Loại Proxy:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label43.Location = new System.Drawing.Point(3, 50);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(98, 16);
            this.label43.TabIndex = 79;
            this.label43.Text = "Nhập Proxy (0):";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label44.Location = new System.Drawing.Point(5, 143);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 16);
            this.label44.TabIndex = 139;
            this.label44.Text = "Số luồng/IP:";
            // 
            // nudLuongPerIPProxyv6
            // 
            this.nudLuongPerIPProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPProxyv6.Location = new System.Drawing.Point(90, 142);
            this.nudLuongPerIPProxyv6.Name = "nudLuongPerIPProxyv6";
            this.nudLuongPerIPProxyv6.Size = new System.Drawing.Size(67, 23);
            this.nudLuongPerIPProxyv6.TabIndex = 140;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label45.Location = new System.Drawing.Point(3, 5);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(56, 16);
            this.label45.TabIndex = 79;
            this.label45.Text = "API Key:";
            // 
            // txtApiProxyv6
            // 
            this.txtApiProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtApiProxyv6.ForeColor = System.Drawing.Color.Black;
            this.txtApiProxyv6.Location = new System.Drawing.Point(75, 2);
            this.txtApiProxyv6.Name = "txtApiProxyv6";
            this.txtApiProxyv6.Size = new System.Drawing.Size(160, 23);
            this.txtApiProxyv6.TabIndex = 81;
            // 
            // rbProxyv6
            // 
            this.rbProxyv6.AutoSize = true;
            this.rbProxyv6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbProxyv6.Location = new System.Drawing.Point(324, 404);
            this.rbProxyv6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbProxyv6.Name = "rbProxyv6";
            this.rbProxyv6.Size = new System.Drawing.Size(92, 20);
            this.rbProxyv6.TabIndex = 150;
            this.rbProxyv6.Text = "Proxyv6.net";
            this.rbProxyv6.UseVisualStyleBackColor = true;
            this.rbProxyv6.CheckedChanged += new System.EventHandler(this.rbProxyv6_CheckedChanged);
            // 
            // plShopLike
            // 
            this.plShopLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plShopLike.Controls.Add(this.txtApiShopLike);
            this.plShopLike.Controls.Add(this.label47);
            this.plShopLike.Controls.Add(this.label48);
            this.plShopLike.Controls.Add(this.nudLuongPerIPShopLike);
            this.plShopLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plShopLike.Location = new System.Drawing.Point(31, 428);
            this.plShopLike.Name = "plShopLike";
            this.plShopLike.Size = new System.Drawing.Size(266, 169);
            this.plShopLike.TabIndex = 153;
            // 
            // txtApiShopLike
            // 
            this.txtApiShopLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiShopLike.Location = new System.Drawing.Point(6, 21);
            this.txtApiShopLike.Name = "txtApiShopLike";
            this.txtApiShopLike.Size = new System.Drawing.Size(255, 113);
            this.txtApiShopLike.TabIndex = 144;
            this.txtApiShopLike.Text = "";
            this.txtApiShopLike.WordWrap = false;
            this.txtApiShopLike.TextChanged += new System.EventHandler(this.txtApiProxyShopLike_TextChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label47.Location = new System.Drawing.Point(3, 2);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(111, 16);
            this.label47.TabIndex = 79;
            this.label47.Text = "Nhập API KEY (0):";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label48.Location = new System.Drawing.Point(3, 143);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(79, 16);
            this.label48.TabIndex = 139;
            this.label48.Text = "Số luồng/IP:";
            // 
            // nudLuongPerIPShopLike
            // 
            this.nudLuongPerIPShopLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPShopLike.Location = new System.Drawing.Point(88, 140);
            this.nudLuongPerIPShopLike.Name = "nudLuongPerIPShopLike";
            this.nudLuongPerIPShopLike.Size = new System.Drawing.Size(67, 23);
            this.nudLuongPerIPShopLike.TabIndex = 140;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label37.Location = new System.Drawing.Point(319, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(162, 16);
            this.label37.TabIndex = 139;
            this.label37.Text = "Delay Check IP sau khi đổi:";
            // 
            // rbShopLike
            // 
            this.rbShopLike.AutoSize = true;
            this.rbShopLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbShopLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbShopLike.Location = new System.Drawing.Point(32, 404);
            this.rbShopLike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbShopLike.Name = "rbShopLike";
            this.rbShopLike.Size = new System.Drawing.Size(166, 20);
            this.rbShopLike.TabIndex = 152;
            this.rbShopLike.Text = "http://proxy.shoplike.vn/";
            this.rbShopLike.UseVisualStyleBackColor = true;
            this.rbShopLike.CheckedChanged += new System.EventHandler(this.rbShopLike_CheckedChanged);
            // 
            // nudDelayCheckIP
            // 
            this.nudDelayCheckIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudDelayCheckIP.Location = new System.Drawing.Point(483, 23);
            this.nudDelayCheckIP.Name = "nudDelayCheckIP";
            this.nudDelayCheckIP.Size = new System.Drawing.Size(46, 23);
            this.nudDelayCheckIP.TabIndex = 140;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Location = new System.Drawing.Point(215, 214);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(86, 16);
            this.linkLabel3.TabIndex = 147;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Hướng dẫn(?)";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label38.Location = new System.Drawing.Point(531, 25);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(31, 16);
            this.label38.TabIndex = 141;
            this.label38.Text = "giây";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(481, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 16);
            this.linkLabel1.TabIndex = 147;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hướng dẫn(?)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // plTMProxy
            // 
            this.plTMProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTMProxy.Controls.Add(this.ckbWaitDoneAllTMProxy);
            this.plTMProxy.Controls.Add(this.txtApiKeyTMProxy);
            this.plTMProxy.Controls.Add(this.label24);
            this.plTMProxy.Controls.Add(this.button8);
            this.plTMProxy.Controls.Add(this.label25);
            this.plTMProxy.Controls.Add(this.nudLuongPerIPTMProxy);
            this.plTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTMProxy.Location = new System.Drawing.Point(322, 278);
            this.plTMProxy.Name = "plTMProxy";
            this.plTMProxy.Size = new System.Drawing.Size(240, 123);
            this.plTMProxy.TabIndex = 146;
            this.plTMProxy.Click += new System.EventHandler(this.plTMProxy_Click);
            // 
            // ckbWaitDoneAllTMProxy
            // 
            this.ckbWaitDoneAllTMProxy.AutoSize = true;
            this.ckbWaitDoneAllTMProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbWaitDoneAllTMProxy.Location = new System.Drawing.Point(115, 1);
            this.ckbWaitDoneAllTMProxy.Name = "ckbWaitDoneAllTMProxy";
            this.ckbWaitDoneAllTMProxy.Size = new System.Drawing.Size(129, 20);
            this.ckbWaitDoneAllTMProxy.TabIndex = 145;
            this.ckbWaitDoneAllTMProxy.Text = "Đợi chạy xong hết";
            this.ckbWaitDoneAllTMProxy.UseVisualStyleBackColor = true;
            this.ckbWaitDoneAllTMProxy.Visible = false;
            // 
            // txtApiKeyTMProxy
            // 
            this.txtApiKeyTMProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApiKeyTMProxy.Location = new System.Drawing.Point(6, 23);
            this.txtApiKeyTMProxy.Name = "txtApiKeyTMProxy";
            this.txtApiKeyTMProxy.Size = new System.Drawing.Size(175, 68);
            this.txtApiKeyTMProxy.TabIndex = 144;
            this.txtApiKeyTMProxy.Text = "";
            this.txtApiKeyTMProxy.WordWrap = false;
            this.txtApiKeyTMProxy.TextChanged += new System.EventHandler(this.txtApiKeyTMProxy_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label24.Location = new System.Drawing.Point(3, 2);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 16);
            this.label24.TabIndex = 79;
            this.label24.Text = "Nhập API KEY (0):";
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(183, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 27);
            this.button8.TabIndex = 143;
            this.button8.Text = "Check";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label25.Location = new System.Drawing.Point(5, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 16);
            this.label25.TabIndex = 139;
            this.label25.Text = "Số luồng/IP:";
            // 
            // nudLuongPerIPTMProxy
            // 
            this.nudLuongPerIPTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPTMProxy.Location = new System.Drawing.Point(90, 94);
            this.nudLuongPerIPTMProxy.Name = "nudLuongPerIPTMProxy";
            this.nudLuongPerIPTMProxy.Size = new System.Drawing.Size(67, 23);
            this.nudLuongPerIPTMProxy.TabIndex = 140;
            // 
            // plCheckDoiIP
            // 
            this.plCheckDoiIP.Controls.Add(this.button5);
            this.plCheckDoiIP.Controls.Add(this.label26);
            this.plCheckDoiIP.Controls.Add(this.nudChangeIpCount);
            this.plCheckDoiIP.Controls.Add(this.label27);
            this.plCheckDoiIP.Location = new System.Drawing.Point(25, 48);
            this.plCheckDoiIP.Name = "plCheckDoiIP";
            this.plCheckDoiIP.Size = new System.Drawing.Size(270, 27);
            this.plCheckDoiIP.TabIndex = 146;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(193, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 27);
            this.button5.TabIndex = 143;
            this.button5.Text = "Test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label26.Location = new System.Drawing.Point(3, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 16);
            this.label26.TabIndex = 139;
            this.label26.Text = "Thay đổi IP sau:";
            // 
            // nudChangeIpCount
            // 
            this.nudChangeIpCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudChangeIpCount.Location = new System.Drawing.Point(106, 3);
            this.nudChangeIpCount.Name = "nudChangeIpCount";
            this.nudChangeIpCount.Size = new System.Drawing.Size(46, 23);
            this.nudChangeIpCount.TabIndex = 140;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label27.Location = new System.Drawing.Point(154, 5);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 16);
            this.label27.TabIndex = 141;
            this.label27.Text = "lượt";
            // 
            // plTinsoft
            // 
            this.plTinsoft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTinsoft.Controls.Add(this.ckbWaitDoneAllTinsoft);
            this.plTinsoft.Controls.Add(this.plApiProxy);
            this.plTinsoft.Controls.Add(this.plApiUser);
            this.plTinsoft.Controls.Add(this.cbbLocationTinsoft);
            this.plTinsoft.Controls.Add(this.rbApiProxy);
            this.plTinsoft.Controls.Add(this.rbApiUser);
            this.plTinsoft.Controls.Add(this.label7);
            this.plTinsoft.Controls.Add(this.label8);
            this.plTinsoft.Controls.Add(this.nudLuongPerIPTinsoft);
            this.plTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plTinsoft.Location = new System.Drawing.Point(31, 236);
            this.plTinsoft.Name = "plTinsoft";
            this.plTinsoft.Size = new System.Drawing.Size(266, 165);
            this.plTinsoft.TabIndex = 142;
            this.plTinsoft.Click += new System.EventHandler(this.plTinsoft_Click);
            // 
            // ckbWaitDoneAllTinsoft
            // 
            this.ckbWaitDoneAllTinsoft.AutoSize = true;
            this.ckbWaitDoneAllTinsoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbWaitDoneAllTinsoft.Location = new System.Drawing.Point(132, 3);
            this.ckbWaitDoneAllTinsoft.Name = "ckbWaitDoneAllTinsoft";
            this.ckbWaitDoneAllTinsoft.Size = new System.Drawing.Size(129, 20);
            this.ckbWaitDoneAllTinsoft.TabIndex = 145;
            this.ckbWaitDoneAllTinsoft.Text = "Đợi chạy xong hết";
            this.ckbWaitDoneAllTinsoft.UseVisualStyleBackColor = true;
            this.ckbWaitDoneAllTinsoft.Visible = false;
            // 
            // plApiProxy
            // 
            this.plApiProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plApiProxy.Controls.Add(this.lblCountApiProxy);
            this.plApiProxy.Controls.Add(this.label28);
            this.plApiProxy.Controls.Add(this.txtApiProxy);
            this.plApiProxy.Controls.Add(this.button7);
            this.plApiProxy.Location = new System.Drawing.Point(6, 77);
            this.plApiProxy.Name = "plApiProxy";
            this.plApiProxy.Size = new System.Drawing.Size(257, 58);
            this.plApiProxy.TabIndex = 35;
            // 
            // lblCountApiProxy
            // 
            this.lblCountApiProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCountApiProxy.Location = new System.Drawing.Point(1, 24);
            this.lblCountApiProxy.Name = "lblCountApiProxy";
            this.lblCountApiProxy.Size = new System.Drawing.Size(32, 16);
            this.lblCountApiProxy.TabIndex = 82;
            this.lblCountApiProxy.Text = "(0)";
            this.lblCountApiProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label28.Location = new System.Drawing.Point(1, 5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 16);
            this.label28.TabIndex = 82;
            this.label28.Text = "API:";
            // 
            // txtApiProxy
            // 
            this.txtApiProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtApiProxy.ForeColor = System.Drawing.Color.Black;
            this.txtApiProxy.Location = new System.Drawing.Point(35, 2);
            this.txtApiProxy.Multiline = true;
            this.txtApiProxy.Name = "txtApiProxy";
            this.txtApiProxy.Size = new System.Drawing.Size(165, 51);
            this.txtApiProxy.TabIndex = 83;
            this.txtApiProxy.WordWrap = false;
            this.txtApiProxy.TextChanged += new System.EventHandler(this.txtApiProxy_TextChanged);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(203, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 27);
            this.button7.TabIndex = 143;
            this.button7.Text = "Check";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // plApiUser
            // 
            this.plApiUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plApiUser.Controls.Add(this.label1);
            this.plApiUser.Controls.Add(this.txtApiUser);
            this.plApiUser.Controls.Add(this.button3);
            this.plApiUser.Location = new System.Drawing.Point(6, 24);
            this.plApiUser.Name = "plApiUser";
            this.plApiUser.Size = new System.Drawing.Size(257, 29);
            this.plApiUser.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "API:";
            // 
            // txtApiUser
            // 
            this.txtApiUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtApiUser.ForeColor = System.Drawing.Color.Black;
            this.txtApiUser.Location = new System.Drawing.Point(35, 2);
            this.txtApiUser.Name = "txtApiUser";
            this.txtApiUser.Size = new System.Drawing.Size(165, 23);
            this.txtApiUser.TabIndex = 83;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(203, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 27);
            this.button3.TabIndex = 143;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbbLocationTinsoft
            // 
            this.cbbLocationTinsoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbLocationTinsoft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocationTinsoft.DropDownWidth = 120;
            this.cbbLocationTinsoft.FormattingEnabled = true;
            this.cbbLocationTinsoft.Location = new System.Drawing.Point(61, 137);
            this.cbbLocationTinsoft.Name = "cbbLocationTinsoft";
            this.cbbLocationTinsoft.Size = new System.Drawing.Size(67, 24);
            this.cbbLocationTinsoft.TabIndex = 84;
            // 
            // rbApiProxy
            // 
            this.rbApiProxy.AutoSize = true;
            this.rbApiProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbApiProxy.Location = new System.Drawing.Point(3, 56);
            this.rbApiProxy.Name = "rbApiProxy";
            this.rbApiProxy.Size = new System.Drawing.Size(136, 20);
            this.rbApiProxy.TabIndex = 34;
            this.rbApiProxy.Text = "Sử dụng Api Proxy:";
            this.rbApiProxy.UseVisualStyleBackColor = true;
            this.rbApiProxy.CheckedChanged += new System.EventHandler(this.rbApiProxy_CheckedChanged);
            // 
            // rbApiUser
            // 
            this.rbApiUser.AutoSize = true;
            this.rbApiUser.Checked = true;
            this.rbApiUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbApiUser.Location = new System.Drawing.Point(3, 3);
            this.rbApiUser.Name = "rbApiUser";
            this.rbApiUser.Size = new System.Drawing.Size(131, 20);
            this.rbApiUser.TabIndex = 34;
            this.rbApiUser.TabStop = true;
            this.rbApiUser.Text = "Sử dụng Api User:";
            this.rbApiUser.UseVisualStyleBackColor = true;
            this.rbApiUser.CheckedChanged += new System.EventHandler(this.rbApiUser_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(134, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 139;
            this.label8.Text = "Số luồng/IP:";
            this.toolTip1.SetToolTip(this.label8, "Là số tài khoản cùng chạy trên 1 Proxy (hay 1 IP)");
            // 
            // nudLuongPerIPTinsoft
            // 
            this.nudLuongPerIPTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudLuongPerIPTinsoft.Location = new System.Drawing.Point(216, 138);
            this.nudLuongPerIPTinsoft.Name = "nudLuongPerIPTinsoft";
            this.nudLuongPerIPTinsoft.Size = new System.Drawing.Size(46, 23);
            this.nudLuongPerIPTinsoft.TabIndex = 140;
            // 
            // rbTMProxy
            // 
            this.rbTMProxy.AutoSize = true;
            this.rbTMProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbTMProxy.Location = new System.Drawing.Point(322, 255);
            this.rbTMProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTMProxy.Name = "rbTMProxy";
            this.rbTMProxy.Size = new System.Drawing.Size(148, 20);
            this.rbTMProxy.TabIndex = 145;
            this.rbTMProxy.Text = "https://tmproxy.com/";
            this.rbTMProxy.UseVisualStyleBackColor = true;
            this.rbTMProxy.CheckedChanged += new System.EventHandler(this.rbTMProxy_CheckedChanged);
            // 
            // plDcom
            // 
            this.plDcom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDcom.Controls.Add(this.button4);
            this.plDcom.Controls.Add(this.txtUrlHilink);
            this.plDcom.Controls.Add(this.txtProfileNameDcom);
            this.plDcom.Controls.Add(this.rbDcomHilink);
            this.plDcom.Controls.Add(this.label36);
            this.plDcom.Controls.Add(this.rbDcomThuong);
            this.plDcom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plDcom.Location = new System.Drawing.Point(32, 152);
            this.plDcom.Name = "plDcom";
            this.plDcom.Size = new System.Drawing.Size(265, 57);
            this.plDcom.TabIndex = 131;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(72, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 25);
            this.button4.TabIndex = 143;
            this.button4.Text = "Lấy tên Dcom";
            this.toolTip1.SetToolTip(this.button4, "Lấy tên dcom");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtUrlHilink
            // 
            this.txtUrlHilink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUrlHilink.ForeColor = System.Drawing.Color.Black;
            this.txtUrlHilink.Location = new System.Drawing.Point(171, 30);
            this.txtUrlHilink.Name = "txtUrlHilink";
            this.txtUrlHilink.Size = new System.Drawing.Size(91, 23);
            this.txtUrlHilink.TabIndex = 81;
            // 
            // txtProfileNameDcom
            // 
            this.txtProfileNameDcom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtProfileNameDcom.ForeColor = System.Drawing.Color.Black;
            this.txtProfileNameDcom.Location = new System.Drawing.Point(171, 2);
            this.txtProfileNameDcom.Name = "txtProfileNameDcom";
            this.txtProfileNameDcom.Size = new System.Drawing.Size(91, 23);
            this.txtProfileNameDcom.TabIndex = 81;
            // 
            // rbDcomHilink
            // 
            this.rbDcomHilink.AutoSize = true;
            this.rbDcomHilink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDcomHilink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbDcomHilink.Location = new System.Drawing.Point(5, 31);
            this.rbDcomHilink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDcomHilink.Name = "rbDcomHilink";
            this.rbDcomHilink.Size = new System.Drawing.Size(56, 20);
            this.rbDcomHilink.TabIndex = 136;
            this.rbDcomHilink.Text = "Hilink";
            this.rbDcomHilink.UseVisualStyleBackColor = true;
            this.rbDcomHilink.CheckedChanged += new System.EventHandler(this.rbDcomHilink_CheckedChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label36.Location = new System.Drawing.Point(69, 33);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(102, 16);
            this.label36.TabIndex = 79;
            this.label36.Text = "Đường dẫn URL:";
            // 
            // rbDcomThuong
            // 
            this.rbDcomThuong.AutoSize = true;
            this.rbDcomThuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDcomThuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbDcomThuong.Location = new System.Drawing.Point(5, 3);
            this.rbDcomThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDcomThuong.Name = "rbDcomThuong";
            this.rbDcomThuong.Size = new System.Drawing.Size(70, 20);
            this.rbDcomThuong.TabIndex = 136;
            this.rbDcomThuong.Text = "Thường";
            this.rbDcomThuong.UseVisualStyleBackColor = true;
            this.rbDcomThuong.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbDcom
            // 
            this.rbDcom.AutoSize = true;
            this.rbDcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDcom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbDcom.Location = new System.Drawing.Point(31, 129);
            this.rbDcom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDcom.Name = "rbDcom";
            this.rbDcom.Size = new System.Drawing.Size(96, 20);
            this.rbDcom.TabIndex = 137;
            this.rbDcom.Text = "Đổi IP Dcom";
            this.rbDcom.UseVisualStyleBackColor = true;
            this.rbDcom.CheckedChanged += new System.EventHandler(this.rbDcom_CheckedChanged);
            // 
            // rbTinsoft
            // 
            this.rbTinsoft.AutoSize = true;
            this.rbTinsoft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbTinsoft.Location = new System.Drawing.Point(31, 212);
            this.rbTinsoft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTinsoft.Name = "rbTinsoft";
            this.rbTinsoft.Size = new System.Drawing.Size(168, 20);
            this.rbTinsoft.TabIndex = 134;
            this.rbTinsoft.Text = "https://tinsoftproxy.com/";
            this.rbTinsoft.UseVisualStyleBackColor = true;
            this.rbTinsoft.CheckedChanged += new System.EventHandler(this.rbTinsoft_CheckedChanged);
            // 
            // rbProxy
            // 
            this.rbProxy.AutoSize = true;
            this.rbProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbProxy.Location = new System.Drawing.Point(31, 104);
            this.rbProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbProxy.Name = "rbProxy";
            this.rbProxy.Size = new System.Drawing.Size(109, 20);
            this.rbProxy.TabIndex = 136;
            this.rbProxy.Text = "Sử dụng Proxy";
            this.rbProxy.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNone.Location = new System.Drawing.Point(31, 80);
            this.rbNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(97, 20);
            this.rbNone.TabIndex = 136;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "Không đổi IP";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // rbXproxy
            // 
            this.rbXproxy.AutoSize = true;
            this.rbXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbXproxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbXproxy.Location = new System.Drawing.Point(322, 58);
            this.rbXproxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbXproxy.Name = "rbXproxy";
            this.rbXproxy.Size = new System.Drawing.Size(224, 20);
            this.rbXproxy.TabIndex = 138;
            this.rbXproxy.Text = "Xproxy, Mobi, OBC, Eager, S Proxy";
            this.rbXproxy.UseVisualStyleBackColor = true;
            this.rbXproxy.CheckedChanged += new System.EventHandler(this.rbXproxy_CheckedChanged);
            // 
            // rbHma
            // 
            this.rbHma.AutoSize = true;
            this.rbHma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbHma.Location = new System.Drawing.Point(207, 104);
            this.rbHma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHma.Name = "rbHma";
            this.rbHma.Size = new System.Drawing.Size(90, 20);
            this.rbHma.TabIndex = 138;
            this.rbHma.Text = "Đổi IP HMA";
            this.rbHma.UseVisualStyleBackColor = true;
            this.rbHma.CheckedChanged += new System.EventHandler(this.rbHma_CheckedChanged);
            // 
            // ckbKhongCheckIP
            // 
            this.ckbKhongCheckIP.AutoSize = true;
            this.ckbKhongCheckIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKhongCheckIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKhongCheckIP.Location = new System.Drawing.Point(31, 24);
            this.ckbKhongCheckIP.Name = "ckbKhongCheckIP";
            this.ckbKhongCheckIP.Size = new System.Drawing.Size(199, 20);
            this.ckbKhongCheckIP.TabIndex = 112;
            this.ckbKhongCheckIP.Text = "Không Check IP trước khi chạy";
            this.ckbKhongCheckIP.UseVisualStyleBackColor = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // fCauHinhChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCauHinhChung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.FConfigGenneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInteractThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHideThread)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPMinProxy)).EndInit();
            this.plVitech.ResumeLayout(false);
            this.plVitech.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPVitech)).EndInit();
            this.grChrome.ResumeLayout(false);
            this.grChrome.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.plSizeChrome.ResumeLayout(false);
            this.plSizeChrome.PerformLayout();
            this.plSapXepCuaSoChrome.ResumeLayout(false);
            this.plSapXepCuaSoChrome.PerformLayout();
            this.plAddChromeVaoFormView.ResumeLayout(false);
            this.plAddChromeVaoFormView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthChrome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeighChrome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayCloseChromeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayCloseChromeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayOpenChromeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayOpenChromeTo)).EndInit();
            this.plLinkToOtherBrowser.ResumeLayout(false);
            this.plLinkToOtherBrowser.PerformLayout();
            this.plUsePortable.ResumeLayout(false);
            this.plUsePortable.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.plNordVPN.ResumeLayout(false);
            this.plNordVPN.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.plXproxy.ResumeLayout(false);
            this.plXproxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayResetXProxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPXProxy)).EndInit();
            this.plProxyv6.ResumeLayout(false);
            this.plProxyv6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPProxyv6)).EndInit();
            this.plShopLike.ResumeLayout(false);
            this.plShopLike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPShopLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayCheckIP)).EndInit();
            this.plTMProxy.ResumeLayout(false);
            this.plTMProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTMProxy)).EndInit();
            this.plCheckDoiIP.ResumeLayout(false);
            this.plCheckDoiIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeIpCount)).EndInit();
            this.plTinsoft.ResumeLayout(false);
            this.plTinsoft.PerformLayout();
            this.plApiProxy.ResumeLayout(false);
            this.plApiProxy.PerformLayout();
            this.plApiUser.ResumeLayout(false);
            this.plApiUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongPerIPTinsoft)).EndInit();
            this.plDcom.ResumeLayout(false);
            this.plDcom.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x040016F3 RID: 5875
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040016F4 RID: 5876
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040016F5 RID: 5877
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040016F6 RID: 5878
		private global::System.Windows.Forms.NumericUpDown nudInteractThread;

		// Token: 0x040016F7 RID: 5879
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040016F8 RID: 5880
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040016F9 RID: 5881
		private global::System.Windows.Forms.NumericUpDown nudHideThread;

		// Token: 0x040016FA RID: 5882
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040016FB RID: 5883
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040016FC RID: 5884
		private global::System.Windows.Forms.TextBox txbPathProfile;

		// Token: 0x040016FD RID: 5885
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040016FE RID: 5886
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040016FF RID: 5887
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04001700 RID: 5888
		private global::System.Windows.Forms.CheckBox ckbShowImageInteract;

		// Token: 0x04001701 RID: 5889
		private global::System.Windows.Forms.ComboBox cbbHostpot;

		// Token: 0x04001702 RID: 5890
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04001703 RID: 5891
		private global::System.Windows.Forms.Panel plNordVPN;

		// Token: 0x04001704 RID: 5892
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04001705 RID: 5893
		private global::System.Windows.Forms.TextBox txtNordVPN;

		// Token: 0x04001706 RID: 5894
		private global::System.Windows.Forms.Panel plDcom;

		// Token: 0x04001707 RID: 5895
		private global::System.Windows.Forms.TextBox txtProfileNameDcom;

		// Token: 0x04001708 RID: 5896
		private global::System.Windows.Forms.Button btnSSH;

		// Token: 0x04001709 RID: 5897
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400170A RID: 5898
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400170B RID: 5899
		private global::System.Windows.Forms.RadioButton rbSSH;

		// Token: 0x0400170C RID: 5900
		private global::System.Windows.Forms.RadioButton rbExpressVPN;

		// Token: 0x0400170D RID: 5901
		private global::System.Windows.Forms.NumericUpDown nudChangeIpCount;

		// Token: 0x0400170E RID: 5902
		private global::System.Windows.Forms.RadioButton rbNordVPN;

		// Token: 0x0400170F RID: 5903
		private global::System.Windows.Forms.RadioButton rbHotspot;

		// Token: 0x04001710 RID: 5904
		private global::System.Windows.Forms.RadioButton rbDcom;

		// Token: 0x04001711 RID: 5905
		private global::System.Windows.Forms.RadioButton rbHma;

		// Token: 0x04001712 RID: 5906
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001713 RID: 5907
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04001714 RID: 5908
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001715 RID: 5909
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04001716 RID: 5910
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04001717 RID: 5911
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001718 RID: 5912
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001719 RID: 5913
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400171A RID: 5914
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400171B RID: 5915
		private global::System.Windows.Forms.Panel plTinsoft;

		// Token: 0x0400171C RID: 5916
		private global::System.Windows.Forms.ComboBox cbbLocationTinsoft;

		// Token: 0x0400171D RID: 5917
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400171E RID: 5918
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400171F RID: 5919
		private global::System.Windows.Forms.TextBox txtApiUser;

		// Token: 0x04001720 RID: 5920
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001721 RID: 5921
		private global::System.Windows.Forms.NumericUpDown nudLuongPerIPTinsoft;

		// Token: 0x04001722 RID: 5922
		private global::System.Windows.Forms.RadioButton rbTinsoft;

		// Token: 0x04001723 RID: 5923
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04001724 RID: 5924
		private global::System.Windows.Forms.ComboBox cbbRowChrome;

		// Token: 0x04001725 RID: 5925
		private global::System.Windows.Forms.ComboBox cbbColumnChrome;

		// Token: 0x04001726 RID: 5926
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001727 RID: 5927
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04001728 RID: 5928
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04001729 RID: 5929
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400172A RID: 5930
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400172B RID: 5931
		private global::System.Windows.Forms.RadioButton radioButton5;

		// Token: 0x0400172C RID: 5932
		private global::System.Windows.Forms.RadioButton radioButton4;

		// Token: 0x0400172D RID: 5933
		private global::System.Windows.Forms.RadioButton radioButton3;

		// Token: 0x0400172E RID: 5934
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x0400172F RID: 5935
		private global::System.Windows.Forms.GroupBox grChrome;

		// Token: 0x04001730 RID: 5936
		private global::System.Windows.Forms.Panel plXproxy;

		// Token: 0x04001731 RID: 5937
		private global::System.Windows.Forms.RadioButton rbSock5Proxy;

		// Token: 0x04001732 RID: 5938
		private global::System.Windows.Forms.RadioButton rbHttpProxy;

		// Token: 0x04001733 RID: 5939
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04001734 RID: 5940
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04001735 RID: 5941
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04001736 RID: 5942
		private global::System.Windows.Forms.TextBox txtServiceURLXProxy;

		// Token: 0x04001737 RID: 5943
		private global::System.Windows.Forms.RadioButton rbXproxy;

		// Token: 0x04001738 RID: 5944
		private global::System.Windows.Forms.RichTextBox txtListProxy;

		// Token: 0x04001739 RID: 5945
		private global::System.Windows.Forms.Label label18;

		// Token: 0x0400173A RID: 5946
		private global::System.Windows.Forms.NumericUpDown nudLuongPerIPXProxy;

		// Token: 0x0400173B RID: 5947
		private global::System.Windows.Forms.Panel plCheckDoiIP;

		// Token: 0x0400173C RID: 5948
		private global::System.Windows.Forms.RadioButton rbProxy;

		// Token: 0x0400173D RID: 5949
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400173E RID: 5950
		private global::System.Windows.Forms.RadioButton rbChromium;

		// Token: 0x0400173F RID: 5951
		private global::System.Windows.Forms.RadioButton rbChrome;

		// Token: 0x04001740 RID: 5952
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04001741 RID: 5953
		private global::System.Windows.Forms.TextBox txtLinkToOtherBrowser;

		// Token: 0x04001742 RID: 5954
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04001743 RID: 5955
		private global::System.Windows.Forms.Panel plLinkToOtherBrowser;

		// Token: 0x04001744 RID: 5956
		private global::System.Windows.Forms.NumericUpDown nudDelayOpenChromeTo;

		// Token: 0x04001745 RID: 5957
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04001746 RID: 5958
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04001747 RID: 5959
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04001748 RID: 5960
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04001749 RID: 5961
		private global::System.Windows.Forms.Panel plTMProxy;

		// Token: 0x0400174A RID: 5962
		private global::System.Windows.Forms.RichTextBox txtApiKeyTMProxy;

		// Token: 0x0400174B RID: 5963
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400174C RID: 5964
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400174D RID: 5965
		private global::System.Windows.Forms.NumericUpDown nudLuongPerIPTMProxy;

		// Token: 0x0400174E RID: 5966
		private global::System.Windows.Forms.RadioButton rbTMProxy;

		// Token: 0x0400174F RID: 5967
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04001750 RID: 5968
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04001751 RID: 5969
		private global::System.Windows.Forms.RadioButton rbPhanBietMauChu;

		// Token: 0x04001752 RID: 5970
		private global::System.Windows.Forms.RadioButton rbPhanBietMauNen;

		// Token: 0x04001753 RID: 5971
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04001754 RID: 5972
		private global::System.Windows.Forms.LinkLabel linkLabel3;

		// Token: 0x04001755 RID: 5973
		private global::System.Windows.Forms.Panel plApiProxy;

		// Token: 0x04001756 RID: 5974
		private global::System.Windows.Forms.Label lblCountApiProxy;

		// Token: 0x04001757 RID: 5975
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04001758 RID: 5976
		private global::System.Windows.Forms.TextBox txtApiProxy;

		// Token: 0x04001759 RID: 5977
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400175A RID: 5978
		private global::System.Windows.Forms.Panel plApiUser;

		// Token: 0x0400175B RID: 5979
		private global::System.Windows.Forms.RadioButton rbApiProxy;

		// Token: 0x0400175C RID: 5980
		private global::System.Windows.Forms.RadioButton rbApiUser;

		// Token: 0x0400175D RID: 5981
		private global::System.Windows.Forms.CheckBox ckbWaitDoneAllXproxy;

		// Token: 0x0400175E RID: 5982
		private global::System.Windows.Forms.NumericUpDown nudDelayOpenChromeFrom;

		// Token: 0x0400175F RID: 5983
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04001760 RID: 5984
		private global::System.Windows.Forms.CheckBox ckbWaitDoneAllTinsoft;

		// Token: 0x04001761 RID: 5985
		private global::System.Windows.Forms.CheckBox ckbWaitDoneAllTMProxy;

		// Token: 0x04001762 RID: 5986
		private global::System.Windows.Forms.NumericUpDown nudDelayCloseChromeFrom;

		// Token: 0x04001763 RID: 5987
		private global::System.Windows.Forms.NumericUpDown nudDelayCloseChromeTo;

		// Token: 0x04001764 RID: 5988
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04001765 RID: 5989
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04001766 RID: 5990
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001767 RID: 5991
		private global::System.Windows.Forms.ComboBox cbbSizeChrome;

		// Token: 0x04001768 RID: 5992
		private global::System.Windows.Forms.Label label34;

		// Token: 0x04001769 RID: 5993
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x0400176A RID: 5994
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x0400176B RID: 5995
		private global::MetroFramework.Controls.MetroButton AddFileAccount;

		// Token: 0x0400176C RID: 5996
		private global::System.Windows.Forms.Panel plSizeChrome;

		// Token: 0x0400176D RID: 5997
		private global::System.Windows.Forms.RadioButton rbTocDoGoNhanh;

		// Token: 0x0400176E RID: 5998
		private global::System.Windows.Forms.RadioButton rbTocDoGoBinhThuong;

		// Token: 0x0400176F RID: 5999
		private global::System.Windows.Forms.RadioButton rbTocDoGoCham;

		// Token: 0x04001770 RID: 6000
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04001771 RID: 6001
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04001772 RID: 6002
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04001773 RID: 6003
		private global::System.Windows.Forms.NumericUpDown nudHeighChrome;

		// Token: 0x04001774 RID: 6004
		private global::System.Windows.Forms.NumericUpDown nudWidthChrome;

		// Token: 0x04001775 RID: 6005
		private global::System.Windows.Forms.CheckBox ckbAddChromeIntoForm;

		// Token: 0x04001776 RID: 6006
		private global::System.Windows.Forms.Label label33;

		// Token: 0x04001777 RID: 6007
		private global::System.Windows.Forms.Label label35;

		// Token: 0x04001778 RID: 6008
		private global::System.Windows.Forms.Panel plAddChromeVaoFormView;

		// Token: 0x04001779 RID: 6009
		private global::System.Windows.Forms.Button button9;

		// Token: 0x0400177A RID: 6010
		private global::System.Windows.Forms.CheckBox ckbKhongCheckIP;

		// Token: 0x0400177B RID: 6011
		private global::System.Windows.Forms.Panel plSapXepCuaSoChrome;

		// Token: 0x0400177C RID: 6012
		private global::System.Windows.Forms.Panel plUsePortable;

		// Token: 0x0400177D RID: 6013
		private global::System.Windows.Forms.Label lblFileZip;

		// Token: 0x0400177E RID: 6014
		private global::System.Windows.Forms.CheckBox ckbUsePortable;

		// Token: 0x0400177F RID: 6015
		private global::System.Windows.Forms.TextBox txtPathToPortableZip;

		// Token: 0x04001780 RID: 6016
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04001781 RID: 6017
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001782 RID: 6018
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x04001783 RID: 6019
		private global::System.Windows.Forms.RadioButton rbNone;

		// Token: 0x04001784 RID: 6020
		private global::System.Windows.Forms.TextBox txtUrlHilink;

		// Token: 0x04001785 RID: 6021
		private global::System.Windows.Forms.RadioButton rbDcomHilink;

		// Token: 0x04001786 RID: 6022
		private global::System.Windows.Forms.Label label36;

		// Token: 0x04001787 RID: 6023
		private global::System.Windows.Forms.RadioButton rbDcomThuong;

		// Token: 0x04001788 RID: 6024
		private global::System.Windows.Forms.Label label37;

		// Token: 0x04001789 RID: 6025
		private global::System.Windows.Forms.NumericUpDown nudDelayCheckIP;

		// Token: 0x0400178A RID: 6026
		private global::System.Windows.Forms.Label label38;

		// Token: 0x0400178B RID: 6027
		private global::System.Windows.Forms.Panel plVitech;

		// Token: 0x0400178C RID: 6028
		private global::System.Windows.Forms.RichTextBox txtListProxyVitech;

		// Token: 0x0400178D RID: 6029
		private global::System.Windows.Forms.RadioButton radioButton9;

		// Token: 0x0400178E RID: 6030
		private global::System.Windows.Forms.RadioButton radioButton10;

		// Token: 0x0400178F RID: 6031
		private global::System.Windows.Forms.Label label40;

		// Token: 0x04001790 RID: 6032
		private global::System.Windows.Forms.Label label41;

		// Token: 0x04001791 RID: 6033
		private global::System.Windows.Forms.Label label42;

		// Token: 0x04001792 RID: 6034
		private global::System.Windows.Forms.NumericUpDown nudLuongPerIPVitech;

		// Token: 0x04001793 RID: 6035
		private global::System.Windows.Forms.Label label46;

		// Token: 0x04001794 RID: 6036
		private global::System.Windows.Forms.TextBox txtApiVitech;

		// Token: 0x04001795 RID: 6037
		private global::System.Windows.Forms.Panel plProxyv6;

		// Token: 0x04001796 RID: 6038
		private global::System.Windows.Forms.RichTextBox txtListProxyv6;

		// Token: 0x04001797 RID: 6039
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x04001798 RID: 6040
		private global::System.Windows.Forms.RadioButton radioButton6;

		// Token: 0x04001799 RID: 6041
		private global::System.Windows.Forms.Label label39;

		// Token: 0x0400179A RID: 6042
		private global::System.Windows.Forms.Label label43;

		// Token: 0x0400179B RID: 6043
		private global::System.Windows.Forms.Label label44;

		// Token: 0x0400179C RID: 6044
		private global::System.Windows.Forms.NumericUpDown nudLuongPerIPProxyv6;

		// Token: 0x0400179D RID: 6045
		private global::System.Windows.Forms.Label label45;

		// Token: 0x0400179E RID: 6046
		private global::System.Windows.Forms.TextBox txtApiProxyv6;

		// Token: 0x0400179F RID: 6047
		private global::System.Windows.Forms.RadioButton rbVitech;

		// Token: 0x040017A0 RID: 6048
		private global::System.Windows.Forms.RadioButton rbProxyv6;

		// Token: 0x040017A1 RID: 6049
		private global::System.Windows.Forms.Panel plShopLike;

		// Token: 0x040017A2 RID: 6050
		private global::System.Windows.Forms.RichTextBox txtApiShopLike;

		// Token: 0x040017A3 RID: 6051
		private global::System.Windows.Forms.Label label47;

		// Token: 0x040017A4 RID: 6052
		private global::System.Windows.Forms.Label label48;

		// Token: 0x040017A5 RID: 6053
		private global::System.Windows.Forms.NumericUpDown nudLuongPerIPShopLike;

		// Token: 0x040017A6 RID: 6054
		private global::System.Windows.Forms.RadioButton rbShopLike;

		// Token: 0x040017A7 RID: 6055
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x040017A8 RID: 6056
		private global::System.Windows.Forms.RichTextBox txtApiKeyMinProxy;

		// Token: 0x040017A9 RID: 6057
		private global::System.Windows.Forms.Label label49;

		// Token: 0x040017AA RID: 6058
		private global::System.Windows.Forms.Label label50;

		// Token: 0x040017AB RID: 6059
		private global::System.Windows.Forms.NumericUpDown nudLuongPerIPMinProxy;

		// Token: 0x040017AC RID: 6060
		private global::System.Windows.Forms.RadioButton rbMinProxy;

		// Token: 0x040017AD RID: 6061
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x040017AE RID: 6062
		private global::System.Windows.Forms.Label label52;

		// Token: 0x040017AF RID: 6063
		private global::System.Windows.Forms.Label label51;

		// Token: 0x040017B0 RID: 6064
		private global::System.Windows.Forms.NumericUpDown nudDelayResetXProxy;
	}
}
