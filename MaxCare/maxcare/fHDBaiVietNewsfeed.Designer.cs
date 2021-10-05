namespace maxcare
{
	// Token: 0x0200011D RID: 285
	public partial class fHDBaiVietNewsfeed : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C8A RID: 3210 RVA: 0x001CB808 File Offset: 0x001C9A08
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x001CB868 File Offset: 0x001C9A68
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDBaiVietNewsfeed));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plCommentText = new global::System.Windows.Forms.Panel();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.txtComment = new global::System.Windows.Forms.RichTextBox();
			this.btnDown = new global::MetroFramework.Controls.MetroButton();
			this.btnUp = new global::MetroFramework.Controls.MetroButton();
			this.rbNganCachKyTu = new global::System.Windows.Forms.RadioButton();
			this.rbNganCachMoiDong = new global::System.Windows.Forms.RadioButton();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.ckbComment = new global::System.Windows.Forms.CheckBox();
			this.ckbShareWall = new global::System.Windows.Forms.CheckBox();
			this.ckbInteract = new global::System.Windows.Forms.CheckBox();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.plComment = new global::System.Windows.Forms.Panel();
			this.ckbCommentText = new global::System.Windows.Forms.CheckBox();
			this.ckbSendAnh = new global::System.Windows.Forms.CheckBox();
			this.plAnh = new global::System.Windows.Forms.Panel();
			this.txtAnh = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plCommentText.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.plComment.SuspendLayout();
			this.plAnh.SuspendLayout();
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
			this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Newsfeed";
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
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.plComment);
			this.panel1.Controls.Add(this.ckbComment);
			this.panel1.Controls.Add(this.ckbShareWall);
			this.panel1.Controls.Add(this.ckbInteract);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 524);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plCommentText.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plCommentText.Controls.Add(this.linkLabel1);
			this.plCommentText.Controls.Add(this.button3);
			this.plCommentText.Controls.Add(this.button4);
			this.plCommentText.Controls.Add(this.button2);
			this.plCommentText.Controls.Add(this.txtComment);
			this.plCommentText.Controls.Add(this.btnDown);
			this.plCommentText.Controls.Add(this.btnUp);
			this.plCommentText.Controls.Add(this.rbNganCachKyTu);
			this.plCommentText.Controls.Add(this.rbNganCachMoiDong);
			this.plCommentText.Controls.Add(this.label9);
			this.plCommentText.Controls.Add(this.label8);
			this.plCommentText.Controls.Add(this.lblStatus);
			this.plCommentText.Location = new global::System.Drawing.Point(24, 29);
			this.plCommentText.Name = "plCommentText";
			this.plCommentText.Size = new global::System.Drawing.Size(278, 164);
			this.plCommentText.TabIndex = 8;
			this.plCommentText.Paint += new global::System.Windows.Forms.PaintEventHandler(this.plComment_Paint);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Location = new global::System.Drawing.Point(163, 142);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel1.TabIndex = 176;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Random icon";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(227, 185);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(21, 23);
			this.button3.TabIndex = 127;
			this.button3.Text = "?";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button4.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(227, 162);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(21, 23);
			this.button4.TabIndex = 128;
			this.button4.Text = "?";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(247, 139);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(23, 23);
			this.button2.TabIndex = 126;
			this.button2.Text = "?";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.txtComment.Location = new global::System.Drawing.Point(7, 27);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new global::System.Drawing.Size(263, 111);
			this.txtComment.TabIndex = 114;
			this.txtComment.Text = "";
			this.txtComment.WordWrap = false;
			this.txtComment.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged_1);
			this.btnDown.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDown.Location = new global::System.Drawing.Point(221, -1);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new global::System.Drawing.Size(25, 25);
			this.btnDown.TabIndex = 112;
			this.btnDown.UseSelectable = true;
			this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
			this.btnUp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnUp.Location = new global::System.Drawing.Point(252, -1);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new global::System.Drawing.Size(25, 25);
			this.btnUp.TabIndex = 113;
			this.btnUp.UseSelectable = true;
			this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
			this.rbNganCachKyTu.AutoSize = true;
			this.rbNganCachKyTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachKyTu.Location = new global::System.Drawing.Point(68, 182);
			this.rbNganCachKyTu.Name = "rbNganCachKyTu";
			this.rbNganCachKyTu.Size = new global::System.Drawing.Size(160, 20);
			this.rbNganCachKyTu.TabIndex = 111;
			this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
			this.rbNganCachKyTu.UseVisualStyleBackColor = true;
			this.rbNganCachKyTu.CheckedChanged += new global::System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
			this.rbNganCachMoiDong.AutoSize = true;
			this.rbNganCachMoiDong.Checked = true;
			this.rbNganCachMoiDong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachMoiDong.Location = new global::System.Drawing.Point(68, 161);
			this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
			this.rbNganCachMoiDong.Size = new global::System.Drawing.Size(156, 20);
			this.rbNganCachMoiDong.TabIndex = 110;
			this.rbNganCachMoiDong.TabStop = true;
			this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
			this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
			this.rbNganCachMoiDong.CheckedChanged += new global::System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(3, 161);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(65, 16);
			this.label9.TabIndex = 109;
			this.label9.Text = "Tùy chọn:";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(3, 142);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(144, 16);
			this.label8.TabIndex = 107;
			this.label8.Text = "(Spin nội dung {a|b|c})";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(4, 4);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(140, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Nội dung bình luận (0):";
			this.ckbComment.AutoSize = true;
			this.ckbComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbComment.Location = new global::System.Drawing.Point(30, 193);
			this.ckbComment.Name = "ckbComment";
			this.ckbComment.Size = new global::System.Drawing.Size(131, 20);
			this.ckbComment.TabIndex = 7;
			this.ckbComment.Text = "Tự động bình luận";
			this.ckbComment.UseVisualStyleBackColor = true;
			this.ckbComment.CheckedChanged += new global::System.EventHandler(this.ckbComment_CheckedChanged);
			this.ckbShareWall.AutoSize = true;
			this.ckbShareWall.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbShareWall.Location = new global::System.Drawing.Point(30, 167);
			this.ckbShareWall.Name = "ckbShareWall";
			this.ckbShareWall.Size = new global::System.Drawing.Size(123, 20);
			this.ckbShareWall.TabIndex = 6;
			this.ckbShareWall.Text = "Chia sẻ về tường";
			this.ckbShareWall.UseVisualStyleBackColor = true;
			this.ckbInteract.AutoSize = true;
			this.ckbInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbInteract.Location = new global::System.Drawing.Point(30, 141);
			this.ckbInteract.Name = "ckbInteract";
			this.ckbInteract.Size = new global::System.Drawing.Size(49, 20);
			this.ckbInteract.TabIndex = 5;
			this.ckbInteract.Text = "Like";
			this.ckbInteract.UseVisualStyleBackColor = true;
			this.nudDelayTo.Location = new global::System.Drawing.Point(229, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(229, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSoLuongTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(132, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudDelayFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(132, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudSoLuongFrom;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudSoLuongFrom.Name = "nudSoLuongFrom";
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongFrom.TabIndex = 1;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(132, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(194, 113);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Location = new global::System.Drawing.Point(194, 82);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(290, 113);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(290, 82);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(25, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "bài";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 113);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(90, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = "Thời gian chờ:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(109, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Số lượng bài viết:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(189, 481);
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
			this.btnAdd.Location = new global::System.Drawing.Point(82, 481);
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
			this.plComment.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plComment.Controls.Add(this.plCommentText);
			this.plComment.Controls.Add(this.plAnh);
			this.plComment.Controls.Add(this.ckbSendAnh);
			this.plComment.Controls.Add(this.ckbCommentText);
			this.plComment.Location = new global::System.Drawing.Point(30, 213);
			this.plComment.Name = "plComment";
			this.plComment.Size = new global::System.Drawing.Size(306, 262);
			this.plComment.TabIndex = 39;
			this.plComment.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.ckbCommentText.AutoSize = true;
			this.ckbCommentText.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCommentText.Location = new global::System.Drawing.Point(4, 4);
			this.ckbCommentText.Name = "ckbCommentText";
			this.ckbCommentText.Size = new global::System.Drawing.Size(128, 20);
			this.ckbCommentText.TabIndex = 9;
			this.ckbCommentText.Text = "Bình luận văn bản";
			this.ckbCommentText.UseVisualStyleBackColor = true;
			this.ckbCommentText.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.ckbSendAnh.AutoSize = true;
			this.ckbSendAnh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbSendAnh.Location = new global::System.Drawing.Point(4, 199);
			this.ckbSendAnh.Name = "ckbSendAnh";
			this.ckbSendAnh.Size = new global::System.Drawing.Size(104, 20);
			this.ckbSendAnh.TabIndex = 10;
			this.ckbSendAnh.Text = "Bình luận ảnh";
			this.ckbSendAnh.UseVisualStyleBackColor = true;
			this.ckbSendAnh.CheckedChanged += new global::System.EventHandler(this.ckbSendAnh_CheckedChanged);
			this.plAnh.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plAnh.Controls.Add(this.txtAnh);
			this.plAnh.Controls.Add(this.label16);
			this.plAnh.Enabled = false;
			this.plAnh.Location = new global::System.Drawing.Point(21, 223);
			this.plAnh.Name = "plAnh";
			this.plAnh.Size = new global::System.Drawing.Size(281, 31);
			this.plAnh.TabIndex = 169;
			this.txtAnh.Location = new global::System.Drawing.Point(136, 3);
			this.txtAnh.Name = "txtAnh";
			this.txtAnh.Size = new global::System.Drawing.Size(140, 23);
			this.txtAnh.TabIndex = 155;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(3, 6);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(138, 16);
			this.label16.TabIndex = 39;
			this.label16.Text = "Đường dẫn folder ảnh:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 524);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDBaiVietNewsfeed";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plCommentText.ResumeLayout(false);
			this.plCommentText.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.plComment.ResumeLayout(false);
			this.plComment.PerformLayout();
			this.plAnh.ResumeLayout(false);
			this.plAnh.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04001483 RID: 5251
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001484 RID: 5252
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001485 RID: 5253
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001486 RID: 5254
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001487 RID: 5255
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04001488 RID: 5256
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001489 RID: 5257
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400148A RID: 5258
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x0400148B RID: 5259
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400148C RID: 5260
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400148D RID: 5261
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400148E RID: 5262
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400148F RID: 5263
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001490 RID: 5264
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001491 RID: 5265
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001492 RID: 5266
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001493 RID: 5267
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001494 RID: 5268
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001495 RID: 5269
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001496 RID: 5270
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001497 RID: 5271
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001498 RID: 5272
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001499 RID: 5273
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400149A RID: 5274
		private global::System.Windows.Forms.Panel plCommentText;

		// Token: 0x0400149B RID: 5275
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400149C RID: 5276
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x0400149D RID: 5277
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x0400149E RID: 5278
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x0400149F RID: 5279
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x040014A0 RID: 5280
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x040014A1 RID: 5281
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x040014A2 RID: 5282
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x040014A3 RID: 5283
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x040014A4 RID: 5284
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040014A5 RID: 5285
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040014A6 RID: 5286
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040014A7 RID: 5287
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040014A8 RID: 5288
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040014A9 RID: 5289
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x040014AA RID: 5290
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x040014AB RID: 5291
		private global::System.Windows.Forms.CheckBox ckbCommentText;

		// Token: 0x040014AC RID: 5292
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x040014AD RID: 5293
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x040014AE RID: 5294
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x040014AF RID: 5295
		private global::System.Windows.Forms.Label label16;
	}
}
