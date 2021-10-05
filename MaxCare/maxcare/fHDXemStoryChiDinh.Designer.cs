namespace maxcare
{
	// Token: 0x020000CB RID: 203
	public partial class fHDXemStoryChiDinh : global::System.Windows.Forms.Form
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x000FD330 File Offset: 0x000FB530
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000FD390 File Offset: 0x000FB590
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDXemStoryChiDinh));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plComment = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtComment = new global::System.Windows.Forms.TextBox();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.plInteract = new global::System.Windows.Forms.Panel();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label26 = new global::System.Windows.Forms.Label();
			this.label27 = new global::System.Windows.Forms.Label();
			this.label28 = new global::System.Windows.Forms.Label();
			this.label29 = new global::System.Windows.Forms.Label();
			this.label30 = new global::System.Windows.Forms.Label();
			this.ckbGian = new global::System.Windows.Forms.CheckBox();
			this.ckbBuon = new global::System.Windows.Forms.CheckBox();
			this.ckbWow = new global::System.Windows.Forms.CheckBox();
			this.ckbHaha = new global::System.Windows.Forms.CheckBox();
			this.ckbThuong = new global::System.Windows.Forms.CheckBox();
			this.ckbTym = new global::System.Windows.Forms.CheckBox();
			this.ckbLike = new global::System.Windows.Forms.CheckBox();
			this.label32 = new global::System.Windows.Forms.Label();
			this.ckbComment = new global::System.Windows.Forms.CheckBox();
			this.ckbInteract = new global::System.Windows.Forms.CheckBox();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.txtLinkStory = new global::System.Windows.Forms.TextBox();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plComment.SuspendLayout();
			this.plInteract.SuspendLayout();
			this.bunifuCards1.SuspendLayout();
			base.SuspendLayout();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(359, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Xem Story";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pnlHeader;
			this.bunifuDragControl2.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(359, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(328, 1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(30, 30);
			this.button1.TabIndex = 77;
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtLinkStory);
			this.panel1.Controls.Add(this.plComment);
			this.panel1.Controls.Add(this.plInteract);
			this.panel1.Controls.Add(this.ckbComment);
			this.panel1.Controls.Add(this.ckbInteract);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 266);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plComment.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plComment.Controls.Add(this.button2);
			this.plComment.Controls.Add(this.label8);
			this.plComment.Controls.Add(this.txtComment);
			this.plComment.Controls.Add(this.lblStatus);
			this.plComment.Location = new global::System.Drawing.Point(48, 378);
			this.plComment.Name = "plComment";
			this.plComment.Size = new global::System.Drawing.Size(278, 164);
			this.plComment.TabIndex = 8;
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(246, 2);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(23, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "?";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(3, 141);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(266, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
			this.txtComment.Location = new global::System.Drawing.Point(7, 27);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtComment.Size = new global::System.Drawing.Size(261, 111);
			this.txtComment.TabIndex = 1;
			this.txtComment.WordWrap = false;
			this.txtComment.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(3, 5);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(140, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Nội dung bình luận (0):";
			this.plInteract.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plInteract.Controls.Add(this.label25);
			this.plInteract.Controls.Add(this.label26);
			this.plInteract.Controls.Add(this.label27);
			this.plInteract.Controls.Add(this.label28);
			this.plInteract.Controls.Add(this.label29);
			this.plInteract.Controls.Add(this.label30);
			this.plInteract.Controls.Add(this.ckbGian);
			this.plInteract.Controls.Add(this.ckbBuon);
			this.plInteract.Controls.Add(this.ckbWow);
			this.plInteract.Controls.Add(this.ckbHaha);
			this.plInteract.Controls.Add(this.ckbThuong);
			this.plInteract.Controls.Add(this.ckbTym);
			this.plInteract.Controls.Add(this.ckbLike);
			this.plInteract.Controls.Add(this.label32);
			this.plInteract.Location = new global::System.Drawing.Point(48, 309);
			this.plInteract.Name = "plInteract";
			this.plInteract.Size = new global::System.Drawing.Size(278, 40);
			this.plInteract.TabIndex = 6;
			this.label25.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label25.Location = new global::System.Drawing.Point(4, 1);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(30, 16);
			this.label25.TabIndex = 0;
			this.label25.Text = "Like";
			this.label25.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label25.Click += new global::System.EventHandler(this.label25_Click);
			this.label26.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label26.Location = new global::System.Drawing.Point(40, 1);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(33, 16);
			this.label26.TabIndex = 2;
			this.label26.Text = "Tym";
			this.label26.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label26.Click += new global::System.EventHandler(this.label26_Click);
			this.label27.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label27.Location = new global::System.Drawing.Point(75, 1);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(52, 16);
			this.label27.TabIndex = 4;
			this.label27.Text = "Thương";
			this.label27.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label27.Click += new global::System.EventHandler(this.label27_Click);
			this.label28.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label28.Location = new global::System.Drawing.Point(128, 1);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(37, 16);
			this.label28.TabIndex = 6;
			this.label28.Text = "Haha";
			this.label28.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label28.Click += new global::System.EventHandler(this.label28_Click);
			this.label29.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label29.Location = new global::System.Drawing.Point(167, 1);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(37, 16);
			this.label29.TabIndex = 8;
			this.label29.Text = "Wow";
			this.label29.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label29.Click += new global::System.EventHandler(this.label29_Click);
			this.label30.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label30.Location = new global::System.Drawing.Point(206, 1);
			this.label30.Name = "label30";
			this.label30.Size = new global::System.Drawing.Size(36, 16);
			this.label30.TabIndex = 10;
			this.label30.Text = "Buồn";
			this.label30.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label30.Click += new global::System.EventHandler(this.label30_Click);
			this.ckbGian.AutoSize = true;
			this.ckbGian.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbGian.Location = new global::System.Drawing.Point(252, 20);
			this.ckbGian.Name = "ckbGian";
			this.ckbGian.Size = new global::System.Drawing.Size(15, 14);
			this.ckbGian.TabIndex = 13;
			this.ckbGian.UseVisualStyleBackColor = true;
			this.ckbBuon.AutoSize = true;
			this.ckbBuon.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbBuon.Location = new global::System.Drawing.Point(218, 20);
			this.ckbBuon.Name = "ckbBuon";
			this.ckbBuon.Size = new global::System.Drawing.Size(15, 14);
			this.ckbBuon.TabIndex = 11;
			this.ckbBuon.UseVisualStyleBackColor = true;
			this.ckbWow.AutoSize = true;
			this.ckbWow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbWow.Location = new global::System.Drawing.Point(179, 20);
			this.ckbWow.Name = "ckbWow";
			this.ckbWow.Size = new global::System.Drawing.Size(15, 14);
			this.ckbWow.TabIndex = 9;
			this.ckbWow.UseVisualStyleBackColor = true;
			this.ckbHaha.AutoSize = true;
			this.ckbHaha.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbHaha.Location = new global::System.Drawing.Point(139, 20);
			this.ckbHaha.Name = "ckbHaha";
			this.ckbHaha.Size = new global::System.Drawing.Size(15, 14);
			this.ckbHaha.TabIndex = 7;
			this.ckbHaha.UseVisualStyleBackColor = true;
			this.ckbThuong.AutoSize = true;
			this.ckbThuong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbThuong.Location = new global::System.Drawing.Point(94, 20);
			this.ckbThuong.Name = "ckbThuong";
			this.ckbThuong.Size = new global::System.Drawing.Size(15, 14);
			this.ckbThuong.TabIndex = 5;
			this.ckbThuong.UseVisualStyleBackColor = true;
			this.ckbTym.AutoSize = true;
			this.ckbTym.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTym.Location = new global::System.Drawing.Point(48, 20);
			this.ckbTym.Name = "ckbTym";
			this.ckbTym.Size = new global::System.Drawing.Size(15, 14);
			this.ckbTym.TabIndex = 3;
			this.ckbTym.UseVisualStyleBackColor = true;
			this.ckbLike.AutoSize = true;
			this.ckbLike.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbLike.Location = new global::System.Drawing.Point(11, 20);
			this.ckbLike.Name = "ckbLike";
			this.ckbLike.Size = new global::System.Drawing.Size(15, 14);
			this.ckbLike.TabIndex = 1;
			this.ckbLike.UseVisualStyleBackColor = true;
			this.label32.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label32.Location = new global::System.Drawing.Point(242, 1);
			this.label32.Name = "label32";
			this.label32.Size = new global::System.Drawing.Size(33, 16);
			this.label32.TabIndex = 12;
			this.label32.Text = "Giận";
			this.label32.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label32.Click += new global::System.EventHandler(this.label32_Click);
			this.ckbComment.AutoSize = true;
			this.ckbComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbComment.Location = new global::System.Drawing.Point(30, 353);
			this.ckbComment.Name = "ckbComment";
			this.ckbComment.Size = new global::System.Drawing.Size(131, 20);
			this.ckbComment.TabIndex = 7;
			this.ckbComment.Text = "Tự động bình luận";
			this.ckbComment.UseVisualStyleBackColor = true;
			this.ckbComment.CheckedChanged += new global::System.EventHandler(this.ckbComment_CheckedChanged);
			this.ckbInteract.AutoSize = true;
			this.ckbInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbInteract.Location = new global::System.Drawing.Point(30, 285);
			this.ckbInteract.Name = "ckbInteract";
			this.ckbInteract.Size = new global::System.Drawing.Size(113, 20);
			this.ckbInteract.TabIndex = 5;
			this.ckbInteract.Text = "Bày tỏ cảm xúc";
			this.ckbInteract.UseVisualStyleBackColor = true;
			this.ckbInteract.CheckedChanged += new global::System.EventHandler(this.ckbInteract_CheckedChanged);
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(132, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 78);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(116, 16);
			this.label2.TabIndex = 31;
			this.label2.Text = "Danh sách link (0):";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(27, 52);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(99, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = "Tên hành động:";
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(189, 224);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(82, 224);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.DarkViolet;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(1, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(359, 37);
			this.bunifuCards1.TabIndex = 28;
			this.txtLinkStory.Location = new global::System.Drawing.Point(30, 98);
			this.txtLinkStory.Multiline = true;
			this.txtLinkStory.Name = "txtLinkStory";
			this.txtLinkStory.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtLinkStory.Size = new global::System.Drawing.Size(296, 111);
			this.txtLinkStory.TabIndex = 32;
			this.txtLinkStory.WordWrap = false;
			this.txtLinkStory.TextChanged += new global::System.EventHandler(this.txtLinkStory_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 266);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDXemStoryChiDinh";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plComment.ResumeLayout(false);
			this.plComment.PerformLayout();
			this.plInteract.ResumeLayout(false);
			this.plInteract.PerformLayout();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000B32 RID: 2866
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000B33 RID: 2867
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000B34 RID: 2868
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000B35 RID: 2869
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000B36 RID: 2870
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000B37 RID: 2871
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000B38 RID: 2872
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000B39 RID: 2873
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000B3A RID: 2874
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000B3B RID: 2875
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000B3C RID: 2876
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000B3D RID: 2877
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000B3E RID: 2878
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000B3F RID: 2879
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000B40 RID: 2880
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000B41 RID: 2881
		private global::System.Windows.Forms.Panel plInteract;

		// Token: 0x04000B42 RID: 2882
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000B43 RID: 2883
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000B44 RID: 2884
		private global::System.Windows.Forms.Label label27;

		// Token: 0x04000B45 RID: 2885
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04000B46 RID: 2886
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04000B47 RID: 2887
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000B48 RID: 2888
		private global::System.Windows.Forms.CheckBox ckbGian;

		// Token: 0x04000B49 RID: 2889
		private global::System.Windows.Forms.CheckBox ckbBuon;

		// Token: 0x04000B4A RID: 2890
		private global::System.Windows.Forms.CheckBox ckbWow;

		// Token: 0x04000B4B RID: 2891
		private global::System.Windows.Forms.CheckBox ckbHaha;

		// Token: 0x04000B4C RID: 2892
		private global::System.Windows.Forms.CheckBox ckbThuong;

		// Token: 0x04000B4D RID: 2893
		private global::System.Windows.Forms.CheckBox ckbTym;

		// Token: 0x04000B4E RID: 2894
		private global::System.Windows.Forms.CheckBox ckbLike;

		// Token: 0x04000B4F RID: 2895
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04000B50 RID: 2896
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04000B51 RID: 2897
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04000B52 RID: 2898
		private global::System.Windows.Forms.TextBox txtComment;

		// Token: 0x04000B53 RID: 2899
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000B54 RID: 2900
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000B55 RID: 2901
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000B56 RID: 2902
		private global::System.Windows.Forms.TextBox txtLinkStory;
	}
}
