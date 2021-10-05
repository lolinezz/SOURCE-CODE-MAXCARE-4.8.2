namespace maxcare
{
	// Token: 0x02000100 RID: 256
	public partial class fHDTuongTacNewsfeed : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A98 RID: 2712 RVA: 0x00164F80 File Offset: 0x00163180
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00164FE0 File Offset: 0x001631E0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDTuongTacNewsfeed));
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
			this.label8 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.plAnh = new global::System.Windows.Forms.Panel();
			this.txtAnh = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.ckbCommentText = new global::System.Windows.Forms.CheckBox();
			this.ckbSendAnh = new global::System.Windows.Forms.CheckBox();
			this.plCountComment = new global::System.Windows.Forms.Panel();
			this.nudCountCommentFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.nudCountCommentTo = new global::System.Windows.Forms.NumericUpDown();
			this.plCountShareWall = new global::System.Windows.Forms.Panel();
			this.nudCountShareFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.nudCountShareTo = new global::System.Windows.Forms.NumericUpDown();
			this.plCountLike = new global::System.Windows.Forms.Panel();
			this.nudCountLikeFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.nudCountLikeTo = new global::System.Windows.Forms.NumericUpDown();
			this.ckbComment = new global::System.Windows.Forms.CheckBox();
			this.ckbShareWall = new global::System.Windows.Forms.CheckBox();
			this.ckbInteract = new global::System.Windows.Forms.CheckBox();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTimeTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudTimeFrom = new global::System.Windows.Forms.NumericUpDown();
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
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plComment.SuspendLayout();
			this.plCommentText.SuspendLayout();
			this.plAnh.SuspendLayout();
			this.plCountComment.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
			this.plCountShareWall.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareTo).BeginInit();
			this.plCountLike.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(373, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Newsfeed";
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
			this.pnlHeader.Size = new global::System.Drawing.Size(373, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(342, 1);
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
			this.panel1.Controls.Add(this.plCountShareWall);
			this.panel1.Controls.Add(this.plCountLike);
			this.panel1.Controls.Add(this.ckbComment);
			this.panel1.Controls.Add(this.ckbShareWall);
			this.panel1.Controls.Add(this.ckbInteract);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudTimeTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.nudTimeFrom);
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
			this.panel1.Size = new global::System.Drawing.Size(376, 550);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plComment.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plComment.Controls.Add(this.plCommentText);
			this.plComment.Controls.Add(this.label17);
			this.plComment.Controls.Add(this.plAnh);
			this.plComment.Controls.Add(this.ckbCommentText);
			this.plComment.Controls.Add(this.ckbSendAnh);
			this.plComment.Controls.Add(this.plCountComment);
			this.plComment.Location = new global::System.Drawing.Point(30, 215);
			this.plComment.Name = "plComment";
			this.plComment.Size = new global::System.Drawing.Size(315, 282);
			this.plComment.TabIndex = 169;
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
			this.plCommentText.Controls.Add(this.label8);
			this.plCommentText.Controls.Add(this.label15);
			this.plCommentText.Controls.Add(this.lblStatus);
			this.plCommentText.Location = new global::System.Drawing.Point(26, 53);
			this.plCommentText.Name = "plCommentText";
			this.plCommentText.Size = new global::System.Drawing.Size(281, 161);
			this.plCommentText.TabIndex = 42;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Location = new global::System.Drawing.Point(167, 141);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel1.TabIndex = 109;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Random icon";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(228, 183);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(21, 23);
			this.button3.TabIndex = 107;
			this.button3.Text = "?";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button4.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(228, 160);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(21, 23);
			this.button4.TabIndex = 108;
			this.button4.Text = "?";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(250, 138);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(23, 23);
			this.button2.TabIndex = 96;
			this.button2.Text = "?";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.txtComment.Location = new global::System.Drawing.Point(7, 27);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new global::System.Drawing.Size(266, 111);
			this.txtComment.TabIndex = 106;
			this.txtComment.Text = "";
			this.txtComment.WordWrap = false;
			this.txtComment.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.btnDown.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDown.Location = new global::System.Drawing.Point(224, -1);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new global::System.Drawing.Size(25, 25);
			this.btnDown.TabIndex = 7;
			this.btnDown.UseSelectable = true;
			this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
			this.btnUp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnUp.Location = new global::System.Drawing.Point(255, -1);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new global::System.Drawing.Size(25, 25);
			this.btnUp.TabIndex = 7;
			this.btnUp.UseSelectable = true;
			this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
			this.rbNganCachKyTu.AutoSize = true;
			this.rbNganCachKyTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachKyTu.Location = new global::System.Drawing.Point(69, 182);
			this.rbNganCachKyTu.Name = "rbNganCachKyTu";
			this.rbNganCachKyTu.Size = new global::System.Drawing.Size(160, 20);
			this.rbNganCachKyTu.TabIndex = 6;
			this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
			this.rbNganCachKyTu.UseVisualStyleBackColor = true;
			this.rbNganCachKyTu.CheckedChanged += new global::System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
			this.rbNganCachMoiDong.AutoSize = true;
			this.rbNganCachMoiDong.Checked = true;
			this.rbNganCachMoiDong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachMoiDong.Location = new global::System.Drawing.Point(69, 161);
			this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
			this.rbNganCachMoiDong.Size = new global::System.Drawing.Size(156, 20);
			this.rbNganCachMoiDong.TabIndex = 5;
			this.rbNganCachMoiDong.TabStop = true;
			this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
			this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
			this.rbNganCachMoiDong.CheckedChanged += new global::System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(4, 161);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(65, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Tùy chọn:";
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(4, 141);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(144, 16);
			this.label15.TabIndex = 0;
			this.label15.Text = "(Spin nội dung {a|b|c})";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(3, 5);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(140, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Nội dung bình luận (0):";
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(5, 6);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(64, 16);
			this.label17.TabIndex = 32;
			this.label17.Text = "Số lượng:";
			this.plAnh.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plAnh.Controls.Add(this.txtAnh);
			this.plAnh.Controls.Add(this.label16);
			this.plAnh.Enabled = false;
			this.plAnh.Location = new global::System.Drawing.Point(26, 244);
			this.plAnh.Name = "plAnh";
			this.plAnh.Size = new global::System.Drawing.Size(281, 31);
			this.plAnh.TabIndex = 168;
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
			this.ckbCommentText.AutoSize = true;
			this.ckbCommentText.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCommentText.Location = new global::System.Drawing.Point(8, 31);
			this.ckbCommentText.Name = "ckbCommentText";
			this.ckbCommentText.Size = new global::System.Drawing.Size(128, 20);
			this.ckbCommentText.TabIndex = 7;
			this.ckbCommentText.Text = "Bình luận văn bản";
			this.ckbCommentText.UseVisualStyleBackColor = true;
			this.ckbCommentText.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.ckbSendAnh.AutoSize = true;
			this.ckbSendAnh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbSendAnh.Location = new global::System.Drawing.Point(8, 220);
			this.ckbSendAnh.Name = "ckbSendAnh";
			this.ckbSendAnh.Size = new global::System.Drawing.Size(104, 20);
			this.ckbSendAnh.TabIndex = 167;
			this.ckbSendAnh.Text = "Bình luận ảnh";
			this.ckbSendAnh.UseVisualStyleBackColor = true;
			this.ckbSendAnh.CheckedChanged += new global::System.EventHandler(this.ckbSendAnh_CheckedChanged);
			this.plCountComment.Controls.Add(this.nudCountCommentFrom);
			this.plCountComment.Controls.Add(this.label13);
			this.plCountComment.Controls.Add(this.label14);
			this.plCountComment.Controls.Add(this.nudCountCommentTo);
			this.plCountComment.Location = new global::System.Drawing.Point(105, 3);
			this.plCountComment.Name = "plCountComment";
			this.plCountComment.Size = new global::System.Drawing.Size(195, 25);
			this.plCountComment.TabIndex = 41;
			this.nudCountCommentFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudCountCommentFrom;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudCountCommentFrom.Name = "nudCountCommentFrom";
			this.nudCountCommentFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountCommentFrom.TabIndex = 1;
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(157, 3);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(25, 16);
			this.label13.TabIndex = 35;
			this.label13.Text = "lần";
			this.label14.Location = new global::System.Drawing.Point(63, 3);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(29, 16);
			this.label14.TabIndex = 37;
			this.label14.Text = "đến";
			this.label14.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudCountCommentTo.Location = new global::System.Drawing.Point(98, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudCountCommentTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudCountCommentTo.Name = "nudCountCommentTo";
			this.nudCountCommentTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountCommentTo.TabIndex = 2;
			this.plCountShareWall.Controls.Add(this.nudCountShareFrom);
			this.plCountShareWall.Controls.Add(this.label11);
			this.plCountShareWall.Controls.Add(this.label12);
			this.plCountShareWall.Controls.Add(this.nudCountShareTo);
			this.plCountShareWall.Location = new global::System.Drawing.Point(136, 162);
			this.plCountShareWall.Name = "plCountShareWall";
			this.plCountShareWall.Size = new global::System.Drawing.Size(195, 25);
			this.plCountShareWall.TabIndex = 40;
			this.nudCountShareFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudCountShareFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudCountShareFrom.Name = "nudCountShareFrom";
			this.nudCountShareFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountShareFrom.TabIndex = 1;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(157, 3);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(25, 16);
			this.label11.TabIndex = 35;
			this.label11.Text = "lần";
			this.label12.Location = new global::System.Drawing.Point(63, 3);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(29, 16);
			this.label12.TabIndex = 37;
			this.label12.Text = "đến";
			this.label12.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudCountShareTo.Location = new global::System.Drawing.Point(98, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudCountShareTo;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudCountShareTo.Name = "nudCountShareTo";
			this.nudCountShareTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountShareTo.TabIndex = 2;
			this.plCountLike.Controls.Add(this.nudCountLikeFrom);
			this.plCountLike.Controls.Add(this.label9);
			this.plCountLike.Controls.Add(this.label10);
			this.plCountLike.Controls.Add(this.nudCountLikeTo);
			this.plCountLike.Location = new global::System.Drawing.Point(136, 133);
			this.plCountLike.Name = "plCountLike";
			this.plCountLike.Size = new global::System.Drawing.Size(195, 25);
			this.plCountLike.TabIndex = 39;
			this.nudCountLikeFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudCountLikeFrom;
			int[] array5 = new int[4];
			array5[0] = 999999;
			this.nudCountLikeFrom.Name = "nudCountLikeFrom";
			this.nudCountLikeFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountLikeFrom.TabIndex = 1;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(157, 3);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(25, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = "lần";
			this.label10.Location = new global::System.Drawing.Point(63, 3);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(29, 16);
			this.label10.TabIndex = 37;
			this.label10.Text = "đến";
			this.label10.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudCountLikeTo.Location = new global::System.Drawing.Point(98, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudCountLikeTo;
			int[] array6 = new int[4];
			array6[0] = 999999;
			this.nudCountLikeTo.Name = "nudCountLikeTo";
			this.nudCountLikeTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountLikeTo.TabIndex = 2;
			this.ckbComment.AutoSize = true;
			this.ckbComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbComment.Location = new global::System.Drawing.Point(30, 193);
			this.ckbComment.Name = "ckbComment";
			this.ckbComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbComment.TabIndex = 7;
			this.ckbComment.Text = "Comment";
			this.ckbComment.UseVisualStyleBackColor = true;
			this.ckbComment.CheckedChanged += new global::System.EventHandler(this.ckbComment_CheckedChanged);
			this.ckbShareWall.AutoSize = true;
			this.ckbShareWall.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbShareWall.Location = new global::System.Drawing.Point(30, 164);
			this.ckbShareWall.Name = "ckbShareWall";
			this.ckbShareWall.Size = new global::System.Drawing.Size(90, 20);
			this.ckbShareWall.TabIndex = 6;
			this.ckbShareWall.Text = "Share Wall";
			this.ckbShareWall.UseVisualStyleBackColor = true;
			this.ckbShareWall.CheckedChanged += new global::System.EventHandler(this.ckbShareWall_CheckedChanged);
			this.ckbInteract.AutoSize = true;
			this.ckbInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbInteract.Location = new global::System.Drawing.Point(30, 135);
			this.ckbInteract.Name = "ckbInteract";
			this.ckbInteract.Size = new global::System.Drawing.Size(49, 20);
			this.ckbInteract.TabIndex = 5;
			this.ckbInteract.Text = "Like";
			this.ckbInteract.UseVisualStyleBackColor = true;
			this.ckbInteract.CheckedChanged += new global::System.EventHandler(this.ckbInteract_CheckedChanged);
			this.nudDelayTo.Location = new global::System.Drawing.Point(234, 105);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudDelayTo;
			int[] array7 = new int[4];
			array7[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudTimeTo.Location = new global::System.Drawing.Point(234, 77);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudTimeTo;
			int[] array8 = new int[4];
			array8[0] = 999999;
			this.nudTimeTo.Name = "nudTimeTo";
			this.nudTimeTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudTimeTo.TabIndex = 2;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(137, 105);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.nudDelayFrom;
			int[] array9 = new int[4];
			array9[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.nudTimeFrom.Location = new global::System.Drawing.Point(137, 77);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.nudTimeFrom;
			int[] array10 = new int[4];
			array10[0] = 999999;
			this.nudTimeFrom.Name = "nudTimeFrom";
			this.nudTimeFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudTimeFrom.TabIndex = 1;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(137, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(199, 107);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Location = new global::System.Drawing.Point(199, 79);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(292, 107);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(292, 79);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(31, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "giây";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 107);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(111, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = "Khoảng cách lướt:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 79);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(92, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Thời gian lướt:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(195, 509);
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
			this.btnAdd.Location = new global::System.Drawing.Point(88, 509);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(373, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(376, 550);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDTuongTacNewsfeed";
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
			this.plCountComment.ResumeLayout(false);
			this.plCountComment.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
			this.plCountShareWall.ResumeLayout(false);
			this.plCountShareWall.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareTo).EndInit();
			this.plCountLike.ResumeLayout(false);
			this.plCountLike.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000F7A RID: 3962
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000F7B RID: 3963
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000F7C RID: 3964
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000F7D RID: 3965
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000F7E RID: 3966
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000F7F RID: 3967
		private global::System.Windows.Forms.NumericUpDown nudTimeTo;

		// Token: 0x04000F80 RID: 3968
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000F81 RID: 3969
		private global::System.Windows.Forms.NumericUpDown nudTimeFrom;

		// Token: 0x04000F82 RID: 3970
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000F83 RID: 3971
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000F84 RID: 3972
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000F85 RID: 3973
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000F86 RID: 3974
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000F87 RID: 3975
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000F88 RID: 3976
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F89 RID: 3977
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F8A RID: 3978
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000F8B RID: 3979
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000F8C RID: 3980
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000F8D RID: 3981
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000F8E RID: 3982
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F8F RID: 3983
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000F90 RID: 3984
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000F91 RID: 3985
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04000F92 RID: 3986
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04000F93 RID: 3987
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x04000F94 RID: 3988
		private global::System.Windows.Forms.Panel plCountComment;

		// Token: 0x04000F95 RID: 3989
		private global::System.Windows.Forms.NumericUpDown nudCountCommentFrom;

		// Token: 0x04000F96 RID: 3990
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000F97 RID: 3991
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000F98 RID: 3992
		private global::System.Windows.Forms.NumericUpDown nudCountCommentTo;

		// Token: 0x04000F99 RID: 3993
		private global::System.Windows.Forms.Panel plCountShareWall;

		// Token: 0x04000F9A RID: 3994
		private global::System.Windows.Forms.NumericUpDown nudCountShareFrom;

		// Token: 0x04000F9B RID: 3995
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000F9C RID: 3996
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000F9D RID: 3997
		private global::System.Windows.Forms.NumericUpDown nudCountShareTo;

		// Token: 0x04000F9E RID: 3998
		private global::System.Windows.Forms.Panel plCountLike;

		// Token: 0x04000F9F RID: 3999
		private global::System.Windows.Forms.NumericUpDown nudCountLikeFrom;

		// Token: 0x04000FA0 RID: 4000
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000FA1 RID: 4001
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000FA2 RID: 4002
		private global::System.Windows.Forms.NumericUpDown nudCountLikeTo;

		// Token: 0x04000FA3 RID: 4003
		private global::System.Windows.Forms.Panel plCommentText;

		// Token: 0x04000FA4 RID: 4004
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000FA5 RID: 4005
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04000FA6 RID: 4006
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04000FA7 RID: 4007
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000FA8 RID: 4008
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000FA9 RID: 4009
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000FAA RID: 4010
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000FAB RID: 4011
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000FAC RID: 4012
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000FAD RID: 4013
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000FAE RID: 4014
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000FAF RID: 4015
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000FB0 RID: 4016
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x04000FB1 RID: 4017
		private global::System.Windows.Forms.TextBox txtAnh;

		// Token: 0x04000FB2 RID: 4018
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000FB3 RID: 4019
		private global::System.Windows.Forms.CheckBox ckbSendAnh;

		// Token: 0x04000FB4 RID: 4020
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000FB5 RID: 4021
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000FB6 RID: 4022
		private global::System.Windows.Forms.CheckBox ckbCommentText;
	}
}
