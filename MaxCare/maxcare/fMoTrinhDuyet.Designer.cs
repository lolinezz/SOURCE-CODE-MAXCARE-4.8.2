namespace maxcare
{
	// Token: 0x020000A6 RID: 166
	public partial class fMoTrinhDuyet : global::System.Windows.Forms.Form
	{
		// Token: 0x06000638 RID: 1592 RVA: 0x0008FCD8 File Offset: 0x0008DED8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0008FD38 File Offset: 0x0008DF38
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.ckbAddChromeIntoForm = new System.Windows.Forms.CheckBox();
            this.ckbLoginHotmail = new System.Windows.Forms.CheckBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnCauHinh = new MetroFramework.Controls.MetroButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbLoginWWW = new System.Windows.Forms.RadioButton();
            this.rbLoginMFB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbAutoOpenLink = new System.Windows.Forms.CheckBox();
            this.ckbAutoCloseChromeLoginFail = new System.Windows.Forms.CheckBox();
            this.ckbKhongLuuTrinhDuyet = new System.Windows.Forms.CheckBox();
            this.ckbGetCookie = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbSuDungProfile = new System.Windows.Forms.RadioButton();
            this.rbKhongDungProfile = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbLoginEmailPass = new System.Windows.Forms.RadioButton();
            this.rbLoginUidPass = new System.Windows.Forms.RadioButton();
            this.rbLoginCookie = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.plSapXepCuaSoChrome.SuspendLayout();
            this.plAddChromeVaoFormView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthChrome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeighChrome)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(452, 38);
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
            this.pnlHeader.Size = new System.Drawing.Size(452, 32);
            this.pnlHeader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(419, -1);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(452, 32);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Cấu hình Mở trình duyệt";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCancel.Location = new System.Drawing.Point(233, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.plSapXepCuaSoChrome);
            this.panel1.Controls.Add(this.plAddChromeVaoFormView);
            this.panel1.Controls.Add(this.ckbAddChromeIntoForm);
            this.panel1.Controls.Add(this.ckbLoginHotmail);
            this.panel1.Controls.Add(this.txtLink);
            this.panel1.Controls.Add(this.btnCauHinh);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ckbAutoOpenLink);
            this.panel1.Controls.Add(this.ckbAutoCloseChromeLoginFail);
            this.panel1.Controls.Add(this.ckbKhongLuuTrinhDuyet);
            this.panel1.Controls.Add(this.ckbGetCookie);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 423);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // plSapXepCuaSoChrome
            // 
            this.plSapXepCuaSoChrome.Controls.Add(this.label10);
            this.plSapXepCuaSoChrome.Controls.Add(this.label11);
            this.plSapXepCuaSoChrome.Controls.Add(this.cbbColumnChrome);
            this.plSapXepCuaSoChrome.Controls.Add(this.cbbRowChrome);
            this.plSapXepCuaSoChrome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plSapXepCuaSoChrome.Location = new System.Drawing.Point(32, 212);
            this.plSapXepCuaSoChrome.Name = "plSapXepCuaSoChrome";
            this.plSapXepCuaSoChrome.Size = new System.Drawing.Size(358, 28);
            this.plSapXepCuaSoChrome.TabIndex = 159;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
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
            this.plAddChromeVaoFormView.Location = new System.Drawing.Point(224, 185);
            this.plAddChromeVaoFormView.Name = "plAddChromeVaoFormView";
            this.plAddChromeVaoFormView.Size = new System.Drawing.Size(175, 27);
            this.plAddChromeVaoFormView.TabIndex = 158;
            // 
            // nudWidthChrome
            // 
            this.nudWidthChrome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label33.Size = new System.Drawing.Size(36, 16);
            this.label33.TabIndex = 33;
            this.label33.Text = "Size:";
            // 
            // nudHeighChrome
            // 
            this.nudHeighChrome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeighChrome.Location = new System.Drawing.Point(118, 2);
            this.nudHeighChrome.Name = "nudHeighChrome";
            this.nudHeighChrome.Size = new System.Drawing.Size(53, 23);
            this.nudHeighChrome.TabIndex = 151;
            // 
            // ckbAddChromeIntoForm
            // 
            this.ckbAddChromeIntoForm.AutoSize = true;
            this.ckbAddChromeIntoForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAddChromeIntoForm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAddChromeIntoForm.Location = new System.Drawing.Point(37, 187);
            this.ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
            this.ckbAddChromeIntoForm.Size = new System.Drawing.Size(187, 20);
            this.ckbAddChromeIntoForm.TabIndex = 157;
            this.ckbAddChromeIntoForm.Text = "Add Chrome vào Form View";
            this.ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
            this.ckbAddChromeIntoForm.CheckedChanged += new System.EventHandler(this.ckbAddChromeIntoForm_CheckedChanged);
            // 
            // ckbLoginHotmail
            // 
            this.ckbLoginHotmail.AutoSize = true;
            this.ckbLoginHotmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLoginHotmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLoginHotmail.Location = new System.Drawing.Point(37, 346);
            this.ckbLoginHotmail.Name = "ckbLoginHotmail";
            this.ckbLoginHotmail.Size = new System.Drawing.Size(184, 20);
            this.ckbLoginHotmail.TabIndex = 25;
            this.ckbLoginHotmail.Text = "Tự động đăng nhập hotmail";
            this.ckbLoginHotmail.UseVisualStyleBackColor = true;
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(183, 318);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(233, 23);
            this.txtLink.TabIndex = 24;
            this.txtLink.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauHinh.Location = new System.Drawing.Point(160, 62);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.TabIndex = 5;
            this.btnCauHinh.Text = "Cấu hình";
            this.btnCauHinh.UseSelectable = true;
            this.btnCauHinh.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbLoginWWW);
            this.panel5.Controls.Add(this.rbLoginMFB);
            this.panel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(157, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 26);
            this.panel5.TabIndex = 23;
            // 
            // rbLoginWWW
            // 
            this.rbLoginWWW.AutoSize = true;
            this.rbLoginWWW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLoginWWW.Location = new System.Drawing.Point(127, 3);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Trang đăng nhập:";
            // 
            // ckbAutoOpenLink
            // 
            this.ckbAutoOpenLink.AutoSize = true;
            this.ckbAutoOpenLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoOpenLink.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAutoOpenLink.Location = new System.Drawing.Point(37, 320);
            this.ckbAutoOpenLink.Name = "ckbAutoOpenLink";
            this.ckbAutoOpenLink.Size = new System.Drawing.Size(149, 20);
            this.ckbAutoOpenLink.TabIndex = 21;
            this.ckbAutoOpenLink.Text = "Tự động mở website:";
            this.ckbAutoOpenLink.UseVisualStyleBackColor = true;
            this.ckbAutoOpenLink.CheckedChanged += new System.EventHandler(this.ckbAutoOpenLink_CheckedChanged);
            // 
            // ckbAutoCloseChromeLoginFail
            // 
            this.ckbAutoCloseChromeLoginFail.AutoSize = true;
            this.ckbAutoCloseChromeLoginFail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoCloseChromeLoginFail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAutoCloseChromeLoginFail.Location = new System.Drawing.Point(37, 294);
            this.ckbAutoCloseChromeLoginFail.Name = "ckbAutoCloseChromeLoginFail";
            this.ckbAutoCloseChromeLoginFail.Size = new System.Drawing.Size(326, 20);
            this.ckbAutoCloseChromeLoginFail.TabIndex = 21;
            this.ckbAutoCloseChromeLoginFail.Text = "Tự động đóng những tab chrome đăng nhập thất bại";
            this.ckbAutoCloseChromeLoginFail.UseVisualStyleBackColor = true;
            // 
            // ckbKhongLuuTrinhDuyet
            // 
            this.ckbKhongLuuTrinhDuyet.AutoSize = true;
            this.ckbKhongLuuTrinhDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbKhongLuuTrinhDuyet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKhongLuuTrinhDuyet.Location = new System.Drawing.Point(37, 242);
            this.ckbKhongLuuTrinhDuyet.Name = "ckbKhongLuuTrinhDuyet";
            this.ckbKhongLuuTrinhDuyet.Size = new System.Drawing.Size(232, 20);
            this.ckbKhongLuuTrinhDuyet.TabIndex = 21;
            this.ckbKhongLuuTrinhDuyet.Text = "Không lưu trình duyệt khi đăng nhập";
            this.ckbKhongLuuTrinhDuyet.UseVisualStyleBackColor = true;
            // 
            // ckbGetCookie
            // 
            this.ckbGetCookie.AutoSize = true;
            this.ckbGetCookie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGetCookie.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGetCookie.Location = new System.Drawing.Point(37, 268);
            this.ckbGetCookie.Name = "ckbGetCookie";
            this.ckbGetCookie.Size = new System.Drawing.Size(344, 20);
            this.ckbGetCookie.TabIndex = 21;
            this.ckbGetCookie.Text = "Tự động cập nhật Cookie sau khi đăng nhập thành công";
            this.ckbGetCookie.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(125, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbSuDungProfile);
            this.panel3.Controls.Add(this.rbKhongDungProfile);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(157, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 26);
            this.panel3.TabIndex = 8;
            // 
            // rbSuDungProfile
            // 
            this.rbSuDungProfile.AutoSize = true;
            this.rbSuDungProfile.Checked = true;
            this.rbSuDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSuDungProfile.Location = new System.Drawing.Point(3, 3);
            this.rbSuDungProfile.Name = "rbSuDungProfile";
            this.rbSuDungProfile.Size = new System.Drawing.Size(113, 20);
            this.rbSuDungProfile.TabIndex = 4;
            this.rbSuDungProfile.TabStop = true;
            this.rbSuDungProfile.Text = "Sử dụng Profile";
            this.rbSuDungProfile.UseVisualStyleBackColor = true;
            // 
            // rbKhongDungProfile
            // 
            this.rbKhongDungProfile.AutoSize = true;
            this.rbKhongDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbKhongDungProfile.Location = new System.Drawing.Point(127, 3);
            this.rbKhongDungProfile.Name = "rbKhongDungProfile";
            this.rbKhongDungProfile.Size = new System.Drawing.Size(132, 20);
            this.rbKhongDungProfile.TabIndex = 4;
            this.rbKhongDungProfile.Text = "Không dùng Profile";
            this.rbKhongDungProfile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbLoginEmailPass);
            this.panel2.Controls.Add(this.rbLoginUidPass);
            this.panel2.Controls.Add(this.rbLoginCookie);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(157, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 26);
            this.panel2.TabIndex = 8;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cấu hình đổi IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tùy chọn Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kiểu đăng nhập:";
            // 
            // fMoTrinhDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 423);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMoTrinhDuyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.Load += new System.EventHandler(this.fMoTrinhDuyet_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plSapXepCuaSoChrome.ResumeLayout(false);
            this.plSapXepCuaSoChrome.PerformLayout();
            this.plAddChromeVaoFormView.ResumeLayout(false);
            this.plAddChromeVaoFormView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthChrome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeighChrome)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x040005C4 RID: 1476
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040005C5 RID: 1477
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040005C6 RID: 1478
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040005C7 RID: 1479
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040005C8 RID: 1480
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040005C9 RID: 1481
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040005CA RID: 1482
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040005CB RID: 1483
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040005CC RID: 1484
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040005CD RID: 1485
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040005CE RID: 1486
		private global::System.Windows.Forms.RadioButton rbSuDungProfile;

		// Token: 0x040005CF RID: 1487
		private global::System.Windows.Forms.RadioButton rbKhongDungProfile;

		// Token: 0x040005D0 RID: 1488
		private global::MetroFramework.Controls.MetroButton btnCauHinh;

		// Token: 0x040005D1 RID: 1489
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040005D2 RID: 1490
		private global::System.Windows.Forms.RadioButton rbLoginEmailPass;

		// Token: 0x040005D3 RID: 1491
		private global::System.Windows.Forms.RadioButton rbLoginUidPass;

		// Token: 0x040005D4 RID: 1492
		private global::System.Windows.Forms.RadioButton rbLoginCookie;

		// Token: 0x040005D5 RID: 1493
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040005D6 RID: 1494
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040005D7 RID: 1495
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040005D8 RID: 1496
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040005D9 RID: 1497
		private global::System.Windows.Forms.CheckBox ckbGetCookie;

		// Token: 0x040005DA RID: 1498
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x040005DB RID: 1499
		private global::System.Windows.Forms.RadioButton rbLoginWWW;

		// Token: 0x040005DC RID: 1500
		private global::System.Windows.Forms.RadioButton rbLoginMFB;

		// Token: 0x040005DD RID: 1501
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040005DE RID: 1502
		private global::System.Windows.Forms.CheckBox ckbAutoCloseChromeLoginFail;

		// Token: 0x040005DF RID: 1503
		private global::System.Windows.Forms.TextBox txtLink;

		// Token: 0x040005E0 RID: 1504
		private global::System.Windows.Forms.CheckBox ckbAutoOpenLink;

		// Token: 0x040005E1 RID: 1505
		private global::System.Windows.Forms.CheckBox ckbKhongLuuTrinhDuyet;

		// Token: 0x040005E2 RID: 1506
		private global::System.Windows.Forms.CheckBox ckbLoginHotmail;

		// Token: 0x040005E3 RID: 1507
		private global::System.Windows.Forms.Panel plAddChromeVaoFormView;

		// Token: 0x040005E4 RID: 1508
		private global::System.Windows.Forms.NumericUpDown nudWidthChrome;

		// Token: 0x040005E5 RID: 1509
		private global::System.Windows.Forms.Label label35;

		// Token: 0x040005E6 RID: 1510
		private global::System.Windows.Forms.Label label33;

		// Token: 0x040005E7 RID: 1511
		private global::System.Windows.Forms.NumericUpDown nudHeighChrome;

		// Token: 0x040005E8 RID: 1512
		private global::System.Windows.Forms.CheckBox ckbAddChromeIntoForm;

		// Token: 0x040005E9 RID: 1513
		private global::System.Windows.Forms.Panel plSapXepCuaSoChrome;

		// Token: 0x040005EA RID: 1514
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040005EB RID: 1515
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040005EC RID: 1516
		private global::System.Windows.Forms.ComboBox cbbColumnChrome;

		// Token: 0x040005ED RID: 1517
		private global::System.Windows.Forms.ComboBox cbbRowChrome;
	}
}
