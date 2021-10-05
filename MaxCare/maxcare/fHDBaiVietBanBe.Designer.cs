namespace maxcare
{
	// Token: 0x0200011C RID: 284
	public partial class fHDBaiVietBanBe : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C6E RID: 3182 RVA: 0x001C6D3C File Offset: 0x001C4F3C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x001C6D9C File Offset: 0x001C4F9C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDBaiVietBanBe));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plComment = new global::System.Windows.Forms.Panel();
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
			this.plAnh = new global::System.Windows.Forms.Panel();
			this.txtAnh = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.ckbSendAnh = new global::System.Windows.Forms.CheckBox();
			this.ckbCommentText = new global::System.Windows.Forms.CheckBox();
			this.label49 = new global::System.Windows.Forms.Label();
			this.nudSoLuongBanBeFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label68 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.nudSoLuongBanBeTo = new global::System.Windows.Forms.NumericUpDown();
			this.label66 = new global::System.Windows.Forms.Label();
			this.ckbComment = new global::System.Windows.Forms.CheckBox();
			this.ckbShareWall = new global::System.Windows.Forms.CheckBox();
			this.ckbInteract = new global::System.Windows.Forms.CheckBox();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongBaiVietTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongBaiVietFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plComment.SuspendLayout();
			this.plCommentText.SuspendLayout();
			this.plAnh.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).BeginInit();
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
			this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Bạn bè";
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
			this.panel1.Controls.Add(this.label49);
			this.panel1.Controls.Add(this.nudSoLuongBanBeFrom);
			this.panel1.Controls.Add(this.label68);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.nudSoLuongBanBeTo);
			this.panel1.Controls.Add(this.label66);
			this.panel1.Controls.Add(this.ckbComment);
			this.panel1.Controls.Add(this.ckbShareWall);
			this.panel1.Controls.Add(this.ckbInteract);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudSoLuongBaiVietTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.nudSoLuongBaiVietFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 559);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plComment.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plComment.Controls.Add(this.plCommentText);
			this.plComment.Controls.Add(this.plAnh);
			this.plComment.Controls.Add(this.ckbSendAnh);
			this.plComment.Controls.Add(this.ckbCommentText);
			this.plComment.Location = new global::System.Drawing.Point(31, 246);
			this.plComment.Name = "plComment";
			this.plComment.Size = new global::System.Drawing.Size(306, 262);
			this.plComment.TabIndex = 106;
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
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Location = new global::System.Drawing.Point(163, 142);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel1.TabIndex = 176;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Random icon";
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(227, 185);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(21, 23);
			this.button3.TabIndex = 127;
			this.button3.Text = "?";
			this.button3.UseVisualStyleBackColor = true;
			this.button4.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button4.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(227, 162);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(21, 23);
			this.button4.TabIndex = 128;
			this.button4.Text = "?";
			this.button4.UseVisualStyleBackColor = true;
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(247, 139);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(23, 23);
			this.button2.TabIndex = 126;
			this.button2.Text = "?";
			this.button2.UseVisualStyleBackColor = true;
			this.txtComment.Location = new global::System.Drawing.Point(7, 27);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new global::System.Drawing.Size(263, 111);
			this.txtComment.TabIndex = 114;
			this.txtComment.Text = "";
			this.txtComment.WordWrap = false;
			this.btnDown.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDown.Location = new global::System.Drawing.Point(221, -1);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new global::System.Drawing.Size(25, 25);
			this.btnDown.TabIndex = 112;
			this.btnDown.UseSelectable = true;
			this.btnUp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnUp.Location = new global::System.Drawing.Point(252, -1);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new global::System.Drawing.Size(25, 25);
			this.btnUp.TabIndex = 113;
			this.btnUp.UseSelectable = true;
			this.rbNganCachKyTu.AutoSize = true;
			this.rbNganCachKyTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachKyTu.Location = new global::System.Drawing.Point(68, 182);
			this.rbNganCachKyTu.Name = "rbNganCachKyTu";
			this.rbNganCachKyTu.Size = new global::System.Drawing.Size(160, 20);
			this.rbNganCachKyTu.TabIndex = 111;
			this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
			this.rbNganCachKyTu.UseVisualStyleBackColor = true;
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
			this.ckbSendAnh.AutoSize = true;
			this.ckbSendAnh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbSendAnh.Location = new global::System.Drawing.Point(4, 199);
			this.ckbSendAnh.Name = "ckbSendAnh";
			this.ckbSendAnh.Size = new global::System.Drawing.Size(104, 20);
			this.ckbSendAnh.TabIndex = 10;
			this.ckbSendAnh.Text = "Bình luận ảnh";
			this.ckbSendAnh.UseVisualStyleBackColor = true;
			this.ckbSendAnh.CheckedChanged += new global::System.EventHandler(this.ckbSendAnh_CheckedChanged);
			this.ckbCommentText.AutoSize = true;
			this.ckbCommentText.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCommentText.Location = new global::System.Drawing.Point(4, 4);
			this.ckbCommentText.Name = "ckbCommentText";
			this.ckbCommentText.Size = new global::System.Drawing.Size(128, 20);
			this.ckbCommentText.TabIndex = 9;
			this.ckbCommentText.Text = "Bình luận văn bản";
			this.ckbCommentText.UseVisualStyleBackColor = true;
			this.ckbCommentText.CheckedChanged += new global::System.EventHandler(this.ckbCommentText_CheckedChanged);
			this.label49.AutoSize = true;
			this.label49.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label49.Location = new global::System.Drawing.Point(27, 81);
			this.label49.Name = "label49";
			this.label49.Size = new global::System.Drawing.Size(107, 16);
			this.label49.TabIndex = 92;
			this.label49.Text = "Số lượng bạn bè:";
			this.nudSoLuongBanBeFrom.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudSoLuongBanBeFrom.Location = new global::System.Drawing.Point(135, 79);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudSoLuongBanBeFrom;
			int[] array = new int[4];
			array[0] = 99999;
			this.nudSoLuongBanBeFrom.Name = "nudSoLuongBanBeFrom";
			this.nudSoLuongBanBeFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongBanBeFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSoLuongBanBeFrom;
			int[] array2 = new int[4];
			array2[0] = 5;
			this.label68.AutoSize = true;
			this.label68.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label68.Location = new global::System.Drawing.Point(290, 81);
			this.label68.Name = "label68";
			this.label68.Size = new global::System.Drawing.Size(29, 16);
			this.label68.TabIndex = 99;
			this.label68.Text = "bạn";
			this.label19.AutoSize = true;
			this.label19.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label19.Location = new global::System.Drawing.Point(27, 112);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(99, 16);
			this.label19.TabIndex = 101;
			this.label19.Text = "Số bài viết/bạn:";
			this.nudSoLuongBanBeTo.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudSoLuongBanBeTo.Location = new global::System.Drawing.Point(232, 79);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudSoLuongBanBeTo;
			int[] array3 = new int[4];
			array3[0] = 99999;
			this.nudSoLuongBanBeTo.Name = "nudSoLuongBanBeTo";
			this.nudSoLuongBanBeTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongBanBeTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudSoLuongBanBeTo;
			int[] array4 = new int[4];
			array4[0] = 10;
			this.label66.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label66.Location = new global::System.Drawing.Point(197, 81);
			this.label66.Name = "label66";
			this.label66.Size = new global::System.Drawing.Size(29, 16);
			this.label66.TabIndex = 105;
			this.label66.Text = "đến";
			this.label66.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ckbComment.AutoSize = true;
			this.ckbComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbComment.Location = new global::System.Drawing.Point(30, 223);
			this.ckbComment.Name = "ckbComment";
			this.ckbComment.Size = new global::System.Drawing.Size(131, 20);
			this.ckbComment.TabIndex = 9;
			this.ckbComment.Text = "Tự động bình luận";
			this.ckbComment.UseVisualStyleBackColor = true;
			this.ckbComment.CheckedChanged += new global::System.EventHandler(this.ckbComment_CheckedChanged);
			this.ckbShareWall.AutoSize = true;
			this.ckbShareWall.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbShareWall.Location = new global::System.Drawing.Point(30, 197);
			this.ckbShareWall.Name = "ckbShareWall";
			this.ckbShareWall.Size = new global::System.Drawing.Size(123, 20);
			this.ckbShareWall.TabIndex = 8;
			this.ckbShareWall.Text = "Chia sẻ về tường";
			this.ckbShareWall.UseVisualStyleBackColor = true;
			this.ckbInteract.AutoSize = true;
			this.ckbInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbInteract.Location = new global::System.Drawing.Point(30, 171);
			this.ckbInteract.Name = "ckbInteract";
			this.ckbInteract.Size = new global::System.Drawing.Size(49, 20);
			this.ckbInteract.TabIndex = 7;
			this.ckbInteract.Text = "Like";
			this.ckbInteract.UseVisualStyleBackColor = true;
			this.nudDelayTo.Location = new global::System.Drawing.Point(232, 140);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudDelayTo;
			int[] array5 = new int[4];
			array5[0] = 99999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 6;
			this.nudSoLuongBaiVietTo.Location = new global::System.Drawing.Point(232, 110);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudSoLuongBaiVietTo;
			int[] array6 = new int[4];
			array6[0] = 99999;
			this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
			this.nudSoLuongBaiVietTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongBaiVietTo.TabIndex = 4;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(135, 140);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudDelayFrom;
			int[] array7 = new int[4];
			array7[0] = 99999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 5;
			this.nudSoLuongBaiVietFrom.Location = new global::System.Drawing.Point(135, 110);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudSoLuongBaiVietFrom;
			int[] array8 = new int[4];
			array8[0] = 99999;
			this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
			this.nudSoLuongBaiVietFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongBaiVietFrom.TabIndex = 3;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(135, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(197, 142);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Location = new global::System.Drawing.Point(197, 112);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(290, 142);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(290, 112);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(25, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "bài";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 142);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(90, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = "Thời gian chờ:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(189, 514);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 12;
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
			this.btnAdd.Location = new global::System.Drawing.Point(82, 514);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 11;
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
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 559);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDBaiVietBanBe";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plComment.ResumeLayout(false);
			this.plComment.PerformLayout();
			this.plCommentText.ResumeLayout(false);
			this.plCommentText.PerformLayout();
			this.plAnh.ResumeLayout(false);
			this.plAnh.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400144B RID: 5195
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400144C RID: 5196
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400144D RID: 5197
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400144E RID: 5198
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400144F RID: 5199
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04001450 RID: 5200
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietTo;

		// Token: 0x04001451 RID: 5201
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04001452 RID: 5202
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiVietFrom;

		// Token: 0x04001453 RID: 5203
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001454 RID: 5204
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001455 RID: 5205
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001456 RID: 5206
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001457 RID: 5207
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001458 RID: 5208
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001459 RID: 5209
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400145A RID: 5210
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400145B RID: 5211
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400145C RID: 5212
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400145D RID: 5213
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400145E RID: 5214
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400145F RID: 5215
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001460 RID: 5216
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001461 RID: 5217
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04001462 RID: 5218
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04001463 RID: 5219
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x04001464 RID: 5220
		private global::System.Windows.Forms.Label label49;

		// Token: 0x04001465 RID: 5221
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBanBeFrom;

		// Token: 0x04001466 RID: 5222
		private global::System.Windows.Forms.Label label68;

		// Token: 0x04001467 RID: 5223
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04001468 RID: 5224
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBanBeTo;

		// Token: 0x04001469 RID: 5225
		private global::System.Windows.Forms.Label label66;

		// Token: 0x0400146A RID: 5226
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x0400146B RID: 5227
		private global::System.Windows.Forms.Panel plCommentText;

		// Token: 0x0400146C RID: 5228
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400146D RID: 5229
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400146E RID: 5230
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400146F RID: 5231
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001470 RID: 5232
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04001471 RID: 5233
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04001472 RID: 5234
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04001473 RID: 5235
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04001474 RID: 5236
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04001475 RID: 5237
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001476 RID: 5238
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001477 RID: 5239
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04001478 RID: 5240
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x04001479 RID: 5241
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x0400147A RID: 5242
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400147B RID: 5243
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x0400147C RID: 5244
		private global::System.Windows.Forms.CheckBox ckbCommentText;
	}
}
