namespace maxcare
{
	// Token: 0x020000C8 RID: 200
	public partial class fHDTuongTacNewsfeedv2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x000F293C File Offset: 0x000F0B3C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000F299C File Offset: 0x000F0B9C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plComment = new global::System.Windows.Forms.Panel();
			this.txtComment = new global::System.Windows.Forms.RichTextBox();
			this.btnDown = new global::MetroFramework.Controls.MetroButton();
			this.btnUp = new global::MetroFramework.Controls.MetroButton();
			this.rbNganCachKyTu = new global::System.Windows.Forms.RadioButton();
			this.rbNganCachMoiDong = new global::System.Windows.Forms.RadioButton();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.plCountComment = new global::System.Windows.Forms.Panel();
			this.nudCountCommentFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.nudCountCommentTo = new global::System.Windows.Forms.NumericUpDown();
			this.plCountLike = new global::System.Windows.Forms.Panel();
			this.nudCountLikeFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.nudCountLikeTo = new global::System.Windows.Forms.NumericUpDown();
			this.ckbComment = new global::System.Windows.Forms.CheckBox();
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
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.ckbLike = new global::System.Windows.Forms.CheckBox();
			this.ckbLove = new global::System.Windows.Forms.CheckBox();
			this.ckbCare = new global::System.Windows.Forms.CheckBox();
			this.ckbHaha = new global::System.Windows.Forms.CheckBox();
			this.ckbWow = new global::System.Windows.Forms.CheckBox();
			this.ckbSad = new global::System.Windows.Forms.CheckBox();
			this.ckbAngry = new global::System.Windows.Forms.CheckBox();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plComment.SuspendLayout();
			this.plCountComment.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
			this.plCountLike.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.panel2.SuspendLayout();
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
			this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Newsfeed v2";
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
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.plComment);
			this.panel1.Controls.Add(this.plCountComment);
			this.panel1.Controls.Add(this.plCountLike);
			this.panel1.Controls.Add(this.ckbComment);
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
			this.panel1.Size = new global::System.Drawing.Size(362, 468);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plComment.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plComment.Controls.Add(this.txtComment);
			this.plComment.Controls.Add(this.btnDown);
			this.plComment.Controls.Add(this.btnUp);
			this.plComment.Controls.Add(this.rbNganCachKyTu);
			this.plComment.Controls.Add(this.rbNganCachMoiDong);
			this.plComment.Controls.Add(this.label8);
			this.plComment.Controls.Add(this.label15);
			this.plComment.Controls.Add(this.lblStatus);
			this.plComment.Location = new global::System.Drawing.Point(50, 255);
			this.plComment.Name = "plComment";
			this.plComment.Size = new global::System.Drawing.Size(281, 163);
			this.plComment.TabIndex = 42;
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
			this.btnDown.Visible = false;
			this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
			this.btnUp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnUp.Location = new global::System.Drawing.Point(255, -1);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new global::System.Drawing.Size(25, 25);
			this.btnUp.TabIndex = 7;
			this.btnUp.UseSelectable = true;
			this.btnUp.Visible = false;
			this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
			this.rbNganCachKyTu.AutoSize = true;
			this.rbNganCachKyTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachKyTu.Location = new global::System.Drawing.Point(69, 182);
			this.rbNganCachKyTu.Name = "rbNganCachKyTu";
			this.rbNganCachKyTu.Size = new global::System.Drawing.Size(203, 20);
			this.rbNganCachKyTu.TabIndex = 6;
			this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
			this.rbNganCachKyTu.UseVisualStyleBackColor = true;
			this.rbNganCachKyTu.CheckedChanged += new global::System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
			this.rbNganCachMoiDong.AutoSize = true;
			this.rbNganCachMoiDong.Checked = true;
			this.rbNganCachMoiDong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachMoiDong.Location = new global::System.Drawing.Point(69, 161);
			this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
			this.rbNganCachMoiDong.Size = new global::System.Drawing.Size(171, 20);
			this.rbNganCachMoiDong.TabIndex = 5;
			this.rbNganCachMoiDong.TabStop = true;
			this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
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
			this.label15.Size = new global::System.Drawing.Size(266, 16);
			this.label15.TabIndex = 0;
			this.label15.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(3, 5);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(140, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Nội dung bình luận (0):";
			this.plCountComment.Controls.Add(this.nudCountCommentFrom);
			this.plCountComment.Controls.Add(this.label13);
			this.plCountComment.Controls.Add(this.label14);
			this.plCountComment.Controls.Add(this.nudCountCommentTo);
			this.plCountComment.Location = new global::System.Drawing.Point(136, 226);
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
			this.plCountLike.Controls.Add(this.nudCountLikeFrom);
			this.plCountLike.Controls.Add(this.label9);
			this.plCountLike.Controls.Add(this.label10);
			this.plCountLike.Controls.Add(this.nudCountLikeTo);
			this.plCountLike.Location = new global::System.Drawing.Point(136, 133);
			this.plCountLike.Name = "plCountLike";
			this.plCountLike.Size = new global::System.Drawing.Size(195, 25);
			this.plCountLike.TabIndex = 39;
			this.nudCountLikeFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudCountLikeFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
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
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudCountLikeTo;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudCountLikeTo.Name = "nudCountLikeTo";
			this.nudCountLikeTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountLikeTo.TabIndex = 2;
			this.ckbComment.AutoSize = true;
			this.ckbComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbComment.Location = new global::System.Drawing.Point(30, 228);
			this.ckbComment.Name = "ckbComment";
			this.ckbComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbComment.TabIndex = 7;
			this.ckbComment.Text = "Comment";
			this.ckbComment.UseVisualStyleBackColor = true;
			this.ckbComment.CheckedChanged += new global::System.EventHandler(this.ckbComment_CheckedChanged);
			this.ckbInteract.AutoSize = true;
			this.ckbInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbInteract.Location = new global::System.Drawing.Point(30, 135);
			this.ckbInteract.Name = "ckbInteract";
			this.ckbInteract.Size = new global::System.Drawing.Size(105, 20);
			this.ckbInteract.TabIndex = 5;
			this.ckbInteract.Text = "Thả cảm xúc:";
			this.ckbInteract.UseVisualStyleBackColor = true;
			this.ckbInteract.CheckedChanged += new global::System.EventHandler(this.ckbInteract_CheckedChanged);
			this.nudDelayTo.Location = new global::System.Drawing.Point(234, 105);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudDelayTo;
			int[] array5 = new int[4];
			array5[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudTimeTo.Location = new global::System.Drawing.Point(234, 77);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudTimeTo;
			int[] array6 = new int[4];
			array6[0] = 999999;
			this.nudTimeTo.Name = "nudTimeTo";
			this.nudTimeTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudTimeTo.TabIndex = 2;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(137, 105);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudDelayFrom;
			int[] array7 = new int[4];
			array7[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.nudTimeFrom.Location = new global::System.Drawing.Point(137, 77);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudTimeFrom;
			int[] array8 = new int[4];
			array8[0] = 999999;
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
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(189, 428);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(82, 428);
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
			this.panel2.Controls.Add(this.ckbAngry);
			this.panel2.Controls.Add(this.ckbSad);
			this.panel2.Controls.Add(this.ckbWow);
			this.panel2.Controls.Add(this.ckbHaha);
			this.panel2.Controls.Add(this.ckbCare);
			this.panel2.Controls.Add(this.ckbLove);
			this.panel2.Controls.Add(this.ckbLike);
			this.panel2.Location = new global::System.Drawing.Point(50, 161);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(281, 51);
			this.panel2.TabIndex = 43;
			this.ckbLike.AutoSize = true;
			this.ckbLike.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbLike.Location = new global::System.Drawing.Point(3, 3);
			this.ckbLike.Name = "ckbLike";
			this.ckbLike.Size = new global::System.Drawing.Size(49, 20);
			this.ckbLike.TabIndex = 6;
			this.ckbLike.Text = "Like";
			this.ckbLike.UseVisualStyleBackColor = true;
			this.ckbLove.AutoSize = true;
			this.ckbLove.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbLove.Location = new global::System.Drawing.Point(73, 3);
			this.ckbLove.Name = "ckbLove";
			this.ckbLove.Size = new global::System.Drawing.Size(52, 20);
			this.ckbLove.TabIndex = 7;
			this.ckbLove.Text = "Tym";
			this.ckbLove.UseVisualStyleBackColor = true;
			this.ckbCare.AutoSize = true;
			this.ckbCare.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCare.Location = new global::System.Drawing.Point(142, 3);
			this.ckbCare.Name = "ckbCare";
			this.ckbCare.Size = new global::System.Drawing.Size(71, 20);
			this.ckbCare.TabIndex = 8;
			this.ckbCare.Text = "Thương";
			this.ckbCare.UseVisualStyleBackColor = true;
			this.ckbHaha.AutoSize = true;
			this.ckbHaha.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbHaha.Location = new global::System.Drawing.Point(222, 3);
			this.ckbHaha.Name = "ckbHaha";
			this.ckbHaha.Size = new global::System.Drawing.Size(56, 20);
			this.ckbHaha.TabIndex = 9;
			this.ckbHaha.Text = "Haha";
			this.ckbHaha.UseVisualStyleBackColor = true;
			this.ckbWow.AutoSize = true;
			this.ckbWow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbWow.Location = new global::System.Drawing.Point(3, 29);
			this.ckbWow.Name = "ckbWow";
			this.ckbWow.Size = new global::System.Drawing.Size(56, 20);
			this.ckbWow.TabIndex = 10;
			this.ckbWow.Text = "Wow";
			this.ckbWow.UseVisualStyleBackColor = true;
			this.ckbSad.AutoSize = true;
			this.ckbSad.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbSad.Location = new global::System.Drawing.Point(73, 29);
			this.ckbSad.Name = "ckbSad";
			this.ckbSad.Size = new global::System.Drawing.Size(55, 20);
			this.ckbSad.TabIndex = 11;
			this.ckbSad.Text = "Buồn";
			this.ckbSad.UseVisualStyleBackColor = true;
			this.ckbAngry.AutoSize = true;
			this.ckbAngry.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAngry.Location = new global::System.Drawing.Point(142, 29);
			this.ckbAngry.Name = "ckbAngry";
			this.ckbAngry.Size = new global::System.Drawing.Size(73, 20);
			this.ckbAngry.TabIndex = 12;
			this.ckbAngry.Text = "Phẫn nộ";
			this.ckbAngry.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 468);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDTuongTacNewsfeedv2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plComment.ResumeLayout(false);
			this.plComment.PerformLayout();
			this.plCountComment.ResumeLayout(false);
			this.plCountComment.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
			this.plCountLike.ResumeLayout(false);
			this.plCountLike.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000AA6 RID: 2726
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000AA7 RID: 2727
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000AA8 RID: 2728
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000AA9 RID: 2729
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000AAA RID: 2730
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000AAB RID: 2731
		private global::System.Windows.Forms.NumericUpDown nudTimeTo;

		// Token: 0x04000AAC RID: 2732
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000AAD RID: 2733
		private global::System.Windows.Forms.NumericUpDown nudTimeFrom;

		// Token: 0x04000AAE RID: 2734
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000AAF RID: 2735
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000AB0 RID: 2736
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000AB1 RID: 2737
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000AB2 RID: 2738
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000AB3 RID: 2739
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000AB4 RID: 2740
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000AB5 RID: 2741
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000AB6 RID: 2742
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000AB7 RID: 2743
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000AB8 RID: 2744
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000AB9 RID: 2745
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000ABA RID: 2746
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000ABB RID: 2747
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000ABC RID: 2748
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000ABD RID: 2749
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x04000ABE RID: 2750
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x04000ABF RID: 2751
		private global::System.Windows.Forms.Panel plCountComment;

		// Token: 0x04000AC0 RID: 2752
		private global::System.Windows.Forms.NumericUpDown nudCountCommentFrom;

		// Token: 0x04000AC1 RID: 2753
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000AC2 RID: 2754
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000AC3 RID: 2755
		private global::System.Windows.Forms.NumericUpDown nudCountCommentTo;

		// Token: 0x04000AC4 RID: 2756
		private global::System.Windows.Forms.Panel plCountLike;

		// Token: 0x04000AC5 RID: 2757
		private global::System.Windows.Forms.NumericUpDown nudCountLikeFrom;

		// Token: 0x04000AC6 RID: 2758
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000AC7 RID: 2759
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000AC8 RID: 2760
		private global::System.Windows.Forms.NumericUpDown nudCountLikeTo;

		// Token: 0x04000AC9 RID: 2761
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000ACA RID: 2762
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000ACB RID: 2763
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04000ACC RID: 2764
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04000ACD RID: 2765
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000ACE RID: 2766
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000ACF RID: 2767
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000AD0 RID: 2768
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000AD1 RID: 2769
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000AD2 RID: 2770
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000AD3 RID: 2771
		private global::System.Windows.Forms.CheckBox ckbAngry;

		// Token: 0x04000AD4 RID: 2772
		private global::System.Windows.Forms.CheckBox ckbSad;

		// Token: 0x04000AD5 RID: 2773
		private global::System.Windows.Forms.CheckBox ckbWow;

		// Token: 0x04000AD6 RID: 2774
		private global::System.Windows.Forms.CheckBox ckbHaha;

		// Token: 0x04000AD7 RID: 2775
		private global::System.Windows.Forms.CheckBox ckbCare;

		// Token: 0x04000AD8 RID: 2776
		private global::System.Windows.Forms.CheckBox ckbLove;

		// Token: 0x04000AD9 RID: 2777
		private global::System.Windows.Forms.CheckBox ckbLike;
	}
}
