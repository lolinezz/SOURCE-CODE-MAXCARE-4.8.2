namespace maxcare
{
	// Token: 0x02000127 RID: 295
	public partial class fImportAccount : global::System.Windows.Forms.Form
	{
		// Token: 0x06000D95 RID: 3477 RVA: 0x001F9050 File Offset: 0x001F7250
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x001F90B0 File Offset: 0x001F72B0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblWallDie = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblWallLive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDinhDangNhap = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbDinhDang3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbDinhDang5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ckbCheckThongTin = new System.Windows.Forms.CheckBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.plDinhDangNhap = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
            this.cbbDinhDang9 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbbThuMuc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbAccount = new System.Windows.Forms.RichTextBox();
            this.lblKhongCheckDuoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plDinhDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(953, 37);
            this.bunifuCards1.TabIndex = 11;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(953, 31);
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
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(921, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(953, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Nhập Tài Khoản";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAdd.Location = new System.Drawing.Point(364, 491);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(478, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.lblSuccess.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.lblSuccess.Location = new System.Drawing.Point(106, 51);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(19, 19);
            this.lblSuccess.TabIndex = 23;
            this.lblSuccess.Text = "0";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(218, 51);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(19, 19);
            this.lblError.TabIndex = 24;
            this.lblError.Text = "0";
            // 
            // lblWallDie
            // 
            this.lblWallDie.AutoSize = true;
            this.lblWallDie.BackColor = System.Drawing.SystemColors.Control;
            this.lblWallDie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallDie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWallDie.Location = new System.Drawing.Point(498, 51);
            this.lblWallDie.Name = "lblWallDie";
            this.lblWallDie.Size = new System.Drawing.Size(19, 19);
            this.lblWallDie.TabIndex = 25;
            this.lblWallDie.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblTotal.Location = new System.Drawing.Point(842, 51);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 19);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "0";
            // 
            // lblWallLive
            // 
            this.lblWallLive.AutoSize = true;
            this.lblWallLive.BackColor = System.Drawing.SystemColors.Control;
            this.lblWallLive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallLive.ForeColor = System.Drawing.Color.Green;
            this.lblWallLive.Location = new System.Drawing.Point(361, 51);
            this.lblWallLive.Name = "lblWallLive";
            this.lblWallLive.Size = new System.Drawing.Size(19, 19);
            this.lblWallLive.TabIndex = 29;
            this.lblWallLive.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Thành công:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(170, 53);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Lỗi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(295, 53);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Wall Live:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(438, 53);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Wall Die:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(783, 53);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tổng số:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(15, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(924, 28);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "Định dạng nhập:";
            // 
            // cbbDinhDangNhap
            // 
            this.cbbDinhDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDangNhap.FormattingEnabled = true;
            this.cbbDinhDangNhap.Items.AddRange(new object[] {
            "Uid|Pass|2FA",
            "Cookie",
            "Uid|Pass",
            "Uid|Pass|Token|Cookie",
            "Uid|Pass|Token|Cookie|Email|Pass Email",
            "Uid|Pass|Token|Cookie|Email|Pass Email|2FA",
            "Other..."});
            this.cbbDinhDangNhap.Location = new System.Drawing.Point(117, 394);
            this.cbbDinhDangNhap.Name = "cbbDinhDangNhap";
            this.cbbDinhDangNhap.Size = new System.Drawing.Size(269, 22);
            this.cbbDinhDangNhap.TabIndex = 40;
            this.cbbDinhDangNhap.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDangNhap_SelectedIndexChanged);
            // 
            // cbbDinhDang1
            // 
            this.cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang1.FormattingEnabled = true;
            this.cbbDinhDang1.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang1.Location = new System.Drawing.Point(3, 3);
            this.cbbDinhDang1.Name = "cbbDinhDang1";
            this.cbbDinhDang1.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang1.TabIndex = 40;
            this.cbbDinhDang1.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(81, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "|";
            // 
            // cbbDinhDang2
            // 
            this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang2.FormattingEnabled = true;
            this.cbbDinhDang2.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang2.Location = new System.Drawing.Point(96, 3);
            this.cbbDinhDang2.Name = "cbbDinhDang2";
            this.cbbDinhDang2.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang2.TabIndex = 40;
            this.cbbDinhDang2.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(174, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "|";
            // 
            // cbbDinhDang3
            // 
            this.cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang3.FormattingEnabled = true;
            this.cbbDinhDang3.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang3.Location = new System.Drawing.Point(189, 3);
            this.cbbDinhDang3.Name = "cbbDinhDang3";
            this.cbbDinhDang3.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang3.TabIndex = 40;
            this.cbbDinhDang3.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(267, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "|";
            // 
            // cbbDinhDang4
            // 
            this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang4.FormattingEnabled = true;
            this.cbbDinhDang4.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang4.Location = new System.Drawing.Point(282, 3);
            this.cbbDinhDang4.Name = "cbbDinhDang4";
            this.cbbDinhDang4.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang4.TabIndex = 40;
            this.cbbDinhDang4.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(360, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "|";
            // 
            // cbbDinhDang5
            // 
            this.cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang5.FormattingEnabled = true;
            this.cbbDinhDang5.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang5.Location = new System.Drawing.Point(375, 3);
            this.cbbDinhDang5.Name = "cbbDinhDang5";
            this.cbbDinhDang5.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang5.TabIndex = 40;
            this.cbbDinhDang5.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(453, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 19);
            this.label13.TabIndex = 41;
            this.label13.Text = "|";
            // 
            // cbbDinhDang6
            // 
            this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang6.FormattingEnabled = true;
            this.cbbDinhDang6.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang6.Location = new System.Drawing.Point(468, 3);
            this.cbbDinhDang6.Name = "cbbDinhDang6";
            this.cbbDinhDang6.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang6.TabIndex = 40;
            this.cbbDinhDang6.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label14.Location = new System.Drawing.Point(546, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 19);
            this.label14.TabIndex = 41;
            this.label14.Text = "|";
            // 
            // cbbDinhDang7
            // 
            this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang7.FormattingEnabled = true;
            this.cbbDinhDang7.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang7.Location = new System.Drawing.Point(561, 3);
            this.cbbDinhDang7.Name = "cbbDinhDang7";
            this.cbbDinhDang7.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang7.TabIndex = 40;
            this.cbbDinhDang7.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 457);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 14);
            this.label15.TabIndex = 39;
            this.label15.Text = "Tùy chọn:";
            // 
            // ckbCheckThongTin
            // 
            this.ckbCheckThongTin.AutoSize = true;
            this.ckbCheckThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCheckThongTin.Location = new System.Drawing.Point(117, 456);
            this.ckbCheckThongTin.Name = "ckbCheckThongTin";
            this.ckbCheckThongTin.Size = new System.Drawing.Size(355, 18);
            this.ckbCheckThongTin.TabIndex = 43;
            this.ckbCheckThongTin.Text = "Check thông tin (Check Wall, Tên, Giới tính, Bạn bè, Nhóm)";
            this.ckbCheckThongTin.UseVisualStyleBackColor = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // plDinhDangNhap
            // 
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang1);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang2);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang3);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang4);
            this.plDinhDangNhap.Controls.Add(this.label18);
            this.plDinhDangNhap.Controls.Add(this.label14);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang5);
            this.plDinhDangNhap.Controls.Add(this.label17);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang8);
            this.plDinhDangNhap.Controls.Add(this.label13);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang6);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang9);
            this.plDinhDangNhap.Controls.Add(this.label12);
            this.plDinhDangNhap.Controls.Add(this.cbbDinhDang7);
            this.plDinhDangNhap.Controls.Add(this.label11);
            this.plDinhDangNhap.Controls.Add(this.label9);
            this.plDinhDangNhap.Controls.Add(this.label10);
            this.plDinhDangNhap.Location = new System.Drawing.Point(114, 420);
            this.plDinhDangNhap.Name = "plDinhDangNhap";
            this.plDinhDangNhap.Size = new System.Drawing.Size(834, 28);
            this.plDinhDangNhap.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label18.Location = new System.Drawing.Point(732, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 19);
            this.label18.TabIndex = 41;
            this.label18.Text = "|";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label17.Location = new System.Drawing.Point(639, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 19);
            this.label17.TabIndex = 41;
            this.label17.Text = "|";
            // 
            // cbbDinhDang8
            // 
            this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang8.FormattingEnabled = true;
            this.cbbDinhDang8.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang8.Location = new System.Drawing.Point(654, 3);
            this.cbbDinhDang8.Name = "cbbDinhDang8";
            this.cbbDinhDang8.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang8.TabIndex = 40;
            this.cbbDinhDang8.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // cbbDinhDang9
            // 
            this.cbbDinhDang9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbDinhDang9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDang9.FormattingEnabled = true;
            this.cbbDinhDang9.Items.AddRange(new object[] {
            "Uid",
            "Pass",
            "Token",
            "Cookie",
            "Email",
            "Pass Email",
            "2FA",
            "Useragent",
            "Proxy",
            "Birthday"});
            this.cbbDinhDang9.Location = new System.Drawing.Point(747, 3);
            this.cbbDinhDang9.Name = "cbbDinhDang9";
            this.cbbDinhDang9.Size = new System.Drawing.Size(78, 22);
            this.cbbDinhDang9.TabIndex = 40;
            this.cbbDinhDang9.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDang1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 14);
            this.label16.TabIndex = 39;
            this.label16.Text = "Chọn thư mục:";
            // 
            // cbbThuMuc
            // 
            this.cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThuMuc.DropDownWidth = 269;
            this.cbbThuMuc.FormattingEnabled = true;
            this.cbbThuMuc.Location = new System.Drawing.Point(117, 365);
            this.cbbThuMuc.Name = "cbbThuMuc";
            this.cbbThuMuc.Size = new System.Drawing.Size(201, 22);
            this.cbbThuMuc.TabIndex = 40;
            this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbbThuMuc_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(324, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 25);
            this.button1.TabIndex = 45;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbAccount
            // 
            this.txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAccount.Location = new System.Drawing.Point(15, 120);
            this.txbAccount.Name = "txbAccount";
            this.txbAccount.Size = new System.Drawing.Size(924, 238);
            this.txbAccount.TabIndex = 48;
            this.txbAccount.Text = "";
            this.txbAccount.WordWrap = false;
            this.txbAccount.TextChanged += new System.EventHandler(this.TxbAccount_TextChanged);
            // 
            // lblKhongCheckDuoc
            // 
            this.lblKhongCheckDuoc.AutoSize = true;
            this.lblKhongCheckDuoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblKhongCheckDuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhongCheckDuoc.ForeColor = System.Drawing.Color.Maroon;
            this.lblKhongCheckDuoc.Location = new System.Drawing.Point(705, 51);
            this.lblKhongCheckDuoc.Name = "lblKhongCheckDuoc";
            this.lblKhongCheckDuoc.Size = new System.Drawing.Size(19, 19);
            this.lblKhongCheckDuoc.TabIndex = 25;
            this.lblKhongCheckDuoc.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(578, 53);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Không Check được:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fImportAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 535);
            this.Controls.Add(this.txbAccount);
            this.Controls.Add(this.plDinhDangNhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckbCheckThongTin);
            this.Controls.Add(this.cbbThuMuc);
            this.Controls.Add(this.cbbDinhDangNhap);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWallLive);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblKhongCheckDuoc);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblWallDie);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fImportAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập tài khoản";
            this.Load += new System.EventHandler(this.fImportAccount_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plDinhDangNhap.ResumeLayout(false);
            this.plDinhDangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040016A9 RID: 5801
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040016AA RID: 5802
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040016AB RID: 5803
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040016AC RID: 5804
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040016AD RID: 5805
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040016AE RID: 5806
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040016AF RID: 5807
		private global::System.Windows.Forms.Label lblSuccess;

		// Token: 0x040016B0 RID: 5808
		private global::System.Windows.Forms.Label lblError;

		// Token: 0x040016B1 RID: 5809
		private global::System.Windows.Forms.Label lblWallDie;

		// Token: 0x040016B2 RID: 5810
		private global::System.Windows.Forms.Label lblTotal;

		// Token: 0x040016B3 RID: 5811
		private global::System.Windows.Forms.Label lblWallLive;

		// Token: 0x040016B4 RID: 5812
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040016B5 RID: 5813
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040016B6 RID: 5814
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040016B7 RID: 5815
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040016B8 RID: 5816
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040016B9 RID: 5817
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040016BA RID: 5818
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040016BB RID: 5819
		private global::System.Windows.Forms.ComboBox cbbDinhDangNhap;

		// Token: 0x040016BC RID: 5820
		private global::System.Windows.Forms.ComboBox cbbDinhDang1;

		// Token: 0x040016BD RID: 5821
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040016BE RID: 5822
		private global::System.Windows.Forms.ComboBox cbbDinhDang2;

		// Token: 0x040016BF RID: 5823
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040016C0 RID: 5824
		private global::System.Windows.Forms.ComboBox cbbDinhDang3;

		// Token: 0x040016C1 RID: 5825
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040016C2 RID: 5826
		private global::System.Windows.Forms.ComboBox cbbDinhDang4;

		// Token: 0x040016C3 RID: 5827
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040016C4 RID: 5828
		private global::System.Windows.Forms.ComboBox cbbDinhDang5;

		// Token: 0x040016C5 RID: 5829
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040016C6 RID: 5830
		private global::System.Windows.Forms.ComboBox cbbDinhDang6;

		// Token: 0x040016C7 RID: 5831
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040016C8 RID: 5832
		private global::System.Windows.Forms.ComboBox cbbDinhDang7;

		// Token: 0x040016C9 RID: 5833
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040016CA RID: 5834
		private global::System.Windows.Forms.CheckBox ckbCheckThongTin;

		// Token: 0x040016CB RID: 5835
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040016CC RID: 5836
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040016CD RID: 5837
		private global::System.Windows.Forms.Panel plDinhDangNhap;

		// Token: 0x040016CE RID: 5838
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040016CF RID: 5839
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040016D0 RID: 5840
		private global::System.Windows.Forms.ComboBox cbbThuMuc;

		// Token: 0x040016D1 RID: 5841
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040016D2 RID: 5842
		private global::System.Windows.Forms.RichTextBox txbAccount;

		// Token: 0x040016D3 RID: 5843
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040016D4 RID: 5844
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040016D5 RID: 5845
		private global::System.Windows.Forms.ComboBox cbbDinhDang8;

		// Token: 0x040016D6 RID: 5846
		private global::System.Windows.Forms.ComboBox cbbDinhDang9;

		// Token: 0x040016D7 RID: 5847
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040016D8 RID: 5848
		private global::System.Windows.Forms.Label lblKhongCheckDuoc;

		// Token: 0x040016D9 RID: 5849
		private global::System.Windows.Forms.Label label2;
	}
}
