namespace maxcare
{
	// Token: 0x020000FD RID: 253
	public partial class fHDSeedingByVideo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x0015B9B4 File Offset: 0x00159BB4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0015BA14 File Offset: 0x00159C14
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDSeedingByVideo));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plComment = new global::System.Windows.Forms.Panel();
			this.rbNganCachKyTu = new global::System.Windows.Forms.RadioButton();
			this.rbNganCachMoiDong = new global::System.Windows.Forms.RadioButton();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtComment = new global::System.Windows.Forms.RichTextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.plVideo = new global::System.Windows.Forms.Panel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.txtVideo = new global::System.Windows.Forms.TextBox();
			this.txtIdPost = new global::System.Windows.Forms.RichTextBox();
			this.ckbSendVideo = new global::System.Windows.Forms.CheckBox();
			this.ckbComment = new global::System.Windows.Forms.CheckBox();
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
			this.plComment.SuspendLayout();
			this.plVideo.SuspendLayout();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(684, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Seeding bài viết";
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
			this.pnlHeader.Size = new global::System.Drawing.Size(684, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(653, 1);
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
			this.panel1.Controls.Add(this.plVideo);
			this.panel1.Controls.Add(this.txtIdPost);
			this.panel1.Controls.Add(this.ckbSendVideo);
			this.panel1.Controls.Add(this.ckbComment);
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
			this.panel1.Size = new global::System.Drawing.Size(687, 437);
			this.panel1.TabIndex = 0;
			this.panel1.Click += new global::System.EventHandler(this.panel1_Click);
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plComment.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plComment.Controls.Add(this.rbNganCachKyTu);
			this.plComment.Controls.Add(this.rbNganCachMoiDong);
			this.plComment.Controls.Add(this.label8);
			this.plComment.Controls.Add(this.txtComment);
			this.plComment.Controls.Add(this.label11);
			this.plComment.Controls.Add(this.lblStatus);
			this.plComment.Location = new global::System.Drawing.Point(371, 104);
			this.plComment.Name = "plComment";
			this.plComment.Size = new global::System.Drawing.Size(281, 193);
			this.plComment.TabIndex = 164;
			this.rbNganCachKyTu.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.rbNganCachKyTu.AutoSize = true;
			this.rbNganCachKyTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachKyTu.Location = new global::System.Drawing.Point(70, 168);
			this.rbNganCachKyTu.Name = "rbNganCachKyTu";
			this.rbNganCachKyTu.Size = new global::System.Drawing.Size(203, 20);
			this.rbNganCachKyTu.TabIndex = 3;
			this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
			this.rbNganCachKyTu.UseVisualStyleBackColor = true;
			this.rbNganCachMoiDong.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.rbNganCachMoiDong.AutoSize = true;
			this.rbNganCachMoiDong.Checked = true;
			this.rbNganCachMoiDong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachMoiDong.Location = new global::System.Drawing.Point(70, 147);
			this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
			this.rbNganCachMoiDong.Size = new global::System.Drawing.Size(171, 20);
			this.rbNganCachMoiDong.TabIndex = 3;
			this.rbNganCachMoiDong.TabStop = true;
			this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
			this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
			this.label8.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(4, 147);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(65, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "Tùy chọn:";
			this.txtComment.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtComment.Location = new global::System.Drawing.Point(7, 25);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new global::System.Drawing.Size(263, 99);
			this.txtComment.TabIndex = 1;
			this.txtComment.Text = "";
			this.txtComment.WordWrap = false;
			this.label11.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(5, 127);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(134, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "Spin nội dung {a|b|c}";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(3, 5);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(119, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Nội dung bình luận:";
			this.plVideo.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plVideo.Controls.Add(this.button3);
			this.plVideo.Controls.Add(this.txtVideo);
			this.plVideo.Enabled = false;
			this.plVideo.Location = new global::System.Drawing.Point(371, 325);
			this.plVideo.Name = "plVideo";
			this.plVideo.Size = new global::System.Drawing.Size(281, 31);
			this.plVideo.TabIndex = 166;
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button3.Location = new global::System.Drawing.Point(217, 2);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(59, 25);
			this.button3.TabIndex = 156;
			this.button3.Text = "Chọn";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.txtVideo.Location = new global::System.Drawing.Point(3, 3);
			this.txtVideo.Name = "txtVideo";
			this.txtVideo.Size = new global::System.Drawing.Size(208, 23);
			this.txtVideo.TabIndex = 155;
			this.txtIdPost.Location = new global::System.Drawing.Point(30, 129);
			this.txtIdPost.Name = "txtIdPost";
			this.txtIdPost.Size = new global::System.Drawing.Size(297, 230);
			this.txtIdPost.TabIndex = 1;
			this.txtIdPost.Text = "";
			this.txtIdPost.WordWrap = false;
			this.txtIdPost.TextChanged += new global::System.EventHandler(this.txtIdPost_TextChanged);
			this.ckbSendVideo.AutoSize = true;
			this.ckbSendVideo.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbSendVideo.Location = new global::System.Drawing.Point(353, 303);
			this.ckbSendVideo.Name = "ckbSendVideo";
			this.ckbSendVideo.Size = new global::System.Drawing.Size(113, 20);
			this.ckbSendVideo.TabIndex = 165;
			this.ckbSendVideo.Text = "Bình luận video";
			this.ckbSendVideo.UseVisualStyleBackColor = true;
			this.ckbSendVideo.CheckedChanged += new global::System.EventHandler(this.ckbSendVideo_CheckedChanged);
			this.ckbComment.AutoSize = true;
			this.ckbComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbComment.Location = new global::System.Drawing.Point(353, 79);
			this.ckbComment.Name = "ckbComment";
			this.ckbComment.Size = new global::System.Drawing.Size(128, 20);
			this.ckbComment.TabIndex = 163;
			this.ckbComment.Text = "Bình luận văn bản";
			this.ckbComment.UseVisualStyleBackColor = true;
			this.ckbComment.CheckedChanged += new global::System.EventHandler(this.ckbComment_CheckedChanged);
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(27, 362);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(97, 16);
			this.label10.TabIndex = 39;
			this.label10.Text = "(Mỗi ID 1 dòng)";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 108);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(154, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "Danh sách ID bài viết (0):";
			this.nudDelayTo.Location = new global::System.Drawing.Point(231, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(134, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(134, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(196, 80);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(292, 80);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 80);
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
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(343, 395);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(236, 395);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(684, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(687, 437);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDSeedingByVideo";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plComment.ResumeLayout(false);
			this.plComment.PerformLayout();
			this.plVideo.ResumeLayout(false);
			this.plVideo.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000F03 RID: 3843
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000F04 RID: 3844
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000F05 RID: 3845
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000F06 RID: 3846
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000F07 RID: 3847
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000F08 RID: 3848
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000F09 RID: 3849
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000F0A RID: 3850
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000F0B RID: 3851
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000F0C RID: 3852
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000F0D RID: 3853
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F0E RID: 3854
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000F0F RID: 3855
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000F10 RID: 3856
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000F11 RID: 3857
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000F12 RID: 3858
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F13 RID: 3859
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000F14 RID: 3860
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000F15 RID: 3861
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000F16 RID: 3862
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F17 RID: 3863
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x04000F18 RID: 3864
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000F19 RID: 3865
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000F1A RID: 3866
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000F1B RID: 3867
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000F1C RID: 3868
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000F1D RID: 3869
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000F1E RID: 3870
		private global::System.Windows.Forms.Panel plVideo;

		// Token: 0x04000F1F RID: 3871
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000F20 RID: 3872
		private global::System.Windows.Forms.TextBox txtVideo;

		// Token: 0x04000F21 RID: 3873
		private global::System.Windows.Forms.RichTextBox txtIdPost;

		// Token: 0x04000F22 RID: 3874
		private global::System.Windows.Forms.CheckBox ckbSendVideo;

		// Token: 0x04000F23 RID: 3875
		private global::System.Windows.Forms.CheckBox ckbComment;
	}
}
