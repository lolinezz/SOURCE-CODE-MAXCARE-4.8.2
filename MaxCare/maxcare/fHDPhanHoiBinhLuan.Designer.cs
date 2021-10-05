namespace maxcare
{
	// Token: 0x020000D0 RID: 208
	public partial class fHDPhanHoiBinhLuan : global::System.Windows.Forms.Form
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0010B250 File Offset: 0x00109450
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0010B2B0 File Offset: 0x001094B0
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
			this.txtUid = new global::System.Windows.Forms.RichTextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.txtComment = new global::System.Windows.Forms.RichTextBox();
			this.lblComment = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtPath = new global::System.Windows.Forms.TextBox();
			this.ckbCommentText = new global::System.Windows.Forms.CheckBox();
			this.ckbCommentImage = new global::System.Windows.Forms.CheckBox();
			this.ckbGanThe = new global::System.Windows.Forms.CheckBox();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(775, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Phản hồi bình luận";
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
			this.pnlHeader.Size = new global::System.Drawing.Size(775, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(744, 1);
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
			this.panel1.Controls.Add(this.txtUid);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.txtPath);
			this.panel1.Controls.Add(this.ckbCommentText);
			this.panel1.Controls.Add(this.ckbCommentImage);
			this.panel1.Controls.Add(this.ckbGanThe);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(778, 547);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.txtUid.Location = new global::System.Drawing.Point(442, 103);
			this.txtUid.Name = "txtUid";
			this.txtUid.Size = new global::System.Drawing.Size(302, 366);
			this.txtUid.TabIndex = 56;
			this.txtUid.Text = "";
			this.txtUid.TextChanged += new global::System.EventHandler(this.txtIdPost_TextChanged);
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.linkLabel1);
			this.panel2.Controls.Add(this.txtComment);
			this.panel2.Controls.Add(this.lblComment);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Location = new global::System.Drawing.Point(43, 221);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(363, 262);
			this.panel2.TabIndex = 54;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Location = new global::System.Drawing.Point(271, 236);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel1.TabIndex = 191;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Random icon";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.txtComment.Location = new global::System.Drawing.Point(7, 23);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new global::System.Drawing.Size(346, 210);
			this.txtComment.TabIndex = 55;
			this.txtComment.Text = "";
			this.txtComment.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.lblComment.AutoSize = true;
			this.lblComment.Location = new global::System.Drawing.Point(4, 4);
			this.lblComment.Name = "lblComment";
			this.lblComment.Size = new global::System.Drawing.Size(150, 16);
			this.lblComment.TabIndex = 53;
			this.lblComment.Text = "Danh sách comment (0):";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(9, 236);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(238, 16);
			this.label9.TabIndex = 52;
			this.label9.Text = "(Mỗi nội dung 1 dòng, spin text {a|b|c})";
			this.txtPath.Location = new global::System.Drawing.Point(162, 168);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new global::System.Drawing.Size(235, 23);
			this.txtPath.TabIndex = 50;
			this.ckbCommentText.AutoSize = true;
			this.ckbCommentText.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCommentText.Location = new global::System.Drawing.Point(32, 196);
			this.ckbCommentText.Name = "ckbCommentText";
			this.ckbCommentText.Size = new global::System.Drawing.Size(128, 20);
			this.ckbCommentText.TabIndex = 49;
			this.ckbCommentText.Text = "Bình luận văn bản";
			this.ckbCommentText.UseVisualStyleBackColor = true;
			this.ckbCommentText.CheckedChanged += new global::System.EventHandler(this.ckbCommentText_CheckedChanged);
			this.ckbCommentImage.AutoSize = true;
			this.ckbCommentImage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCommentImage.Location = new global::System.Drawing.Point(32, 170);
			this.ckbCommentImage.Name = "ckbCommentImage";
			this.ckbCommentImage.Size = new global::System.Drawing.Size(104, 20);
			this.ckbCommentImage.TabIndex = 48;
			this.ckbCommentImage.Text = "Bình luận ảnh";
			this.ckbCommentImage.UseVisualStyleBackColor = true;
			this.ckbCommentImage.CheckedChanged += new global::System.EventHandler(this.ckbCommentImage_CheckedChanged);
			this.ckbGanThe.AutoSize = true;
			this.ckbGanThe.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbGanThe.Location = new global::System.Drawing.Point(32, 144);
			this.ckbGanThe.Name = "ckbGanThe";
			this.ckbGanThe.Size = new global::System.Drawing.Size(122, 20);
			this.ckbGanThe.TabIndex = 47;
			this.ckbGanThe.Text = "Tự động gắn thẻ";
			this.ckbGanThe.UseVisualStyleBackColor = true;
			this.nudSoLuongTo.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(259, 82);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudSoLuongTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 43;
			this.nudSoLuongFrom.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(162, 82);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSoLuongFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudSoLuongFrom.Name = "nudSoLuongFrom";
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongFrom.TabIndex = 42;
			this.label3.Location = new global::System.Drawing.Point(224, 84);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 46;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(317, 84);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(61, 16);
			this.label4.TabIndex = 45;
			this.label4.Text = "comment";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(29, 84);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(102, 16);
			this.label8.TabIndex = 44;
			this.label8.Text = "Số comment/ID:";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(439, 472);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(156, 16);
			this.label10.TabIndex = 39;
			this.label10.Text = "(Mỗi ID Comment 1 dòng)";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(437, 84);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(168, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "Danh sách ID Comment (0):";
			this.nudDelayTo.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nudDelayTo.Location = new global::System.Drawing.Point(259, 114);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudDelayTo;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudDelayFrom.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(162, 114);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudDelayFrom;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(162, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(216, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(224, 116);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(317, 116);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(29, 116);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(100, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = "Thời gian delay:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(397, 505);
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
			this.btnAdd.Location = new global::System.Drawing.Point(290, 505);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(775, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(778, 547);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDPhanHoiBinhLuan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000BED RID: 3053
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000BEE RID: 3054
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000BEF RID: 3055
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000BF0 RID: 3056
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000BF1 RID: 3057
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000BF2 RID: 3058
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000BF3 RID: 3059
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000BF4 RID: 3060
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000BF5 RID: 3061
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000BF6 RID: 3062
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000BF7 RID: 3063
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000BF8 RID: 3064
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000BF9 RID: 3065
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000BFA RID: 3066
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000BFB RID: 3067
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000BFC RID: 3068
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000BFD RID: 3069
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000BFE RID: 3070
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000BFF RID: 3071
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000C00 RID: 3072
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000C01 RID: 3073
		private global::System.Windows.Forms.CheckBox ckbCommentImage;

		// Token: 0x04000C02 RID: 3074
		private global::System.Windows.Forms.CheckBox ckbGanThe;

		// Token: 0x04000C03 RID: 3075
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04000C04 RID: 3076
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04000C05 RID: 3077
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000C06 RID: 3078
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000C07 RID: 3079
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000C08 RID: 3080
		private global::System.Windows.Forms.TextBox txtPath;

		// Token: 0x04000C09 RID: 3081
		private global::System.Windows.Forms.CheckBox ckbCommentText;

		// Token: 0x04000C0A RID: 3082
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000C0B RID: 3083
		private global::System.Windows.Forms.Label lblComment;

		// Token: 0x04000C0C RID: 3084
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000C0D RID: 3085
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x04000C0E RID: 3086
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000C0F RID: 3087
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
