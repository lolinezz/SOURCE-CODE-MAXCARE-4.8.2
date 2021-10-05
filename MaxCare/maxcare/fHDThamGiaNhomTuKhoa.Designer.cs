namespace maxcare
{
	// Token: 0x0200010E RID: 270
	public partial class fHDThamGiaNhomTuKhoa : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BBF RID: 3007 RVA: 0x001A0FA8 File Offset: 0x0019F1A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x001A1008 File Offset: 0x0019F208
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDThamGiaNhomTuKhoa));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plTuongTac = new global::System.Windows.Forms.Panel();
			this.txtCauTraLoi = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.lblStatusComment = new global::System.Windows.Forms.Label();
			this.ckbTuDongTraLoiCauHoi = new global::System.Windows.Forms.CheckBox();
			this.txtTuKhoa = new global::System.Windows.Forms.RichTextBox();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label8 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plTuongTac.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(687, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Tham gia nhóm theo từ khóa";
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
			this.pnlHeader.Size = new global::System.Drawing.Size(687, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(656, 1);
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
			this.panel1.Controls.Add(this.plTuongTac);
			this.panel1.Controls.Add(this.ckbTuDongTraLoiCauHoi);
			this.panel1.Controls.Add(this.txtTuKhoa);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(690, 375);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plTuongTac.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTac.Controls.Add(this.txtCauTraLoi);
			this.plTuongTac.Controls.Add(this.label9);
			this.plTuongTac.Controls.Add(this.lblStatusComment);
			this.plTuongTac.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTac.Location = new global::System.Drawing.Point(367, 74);
			this.plTuongTac.Name = "plTuongTac";
			this.plTuongTac.Size = new global::System.Drawing.Size(310, 238);
			this.plTuongTac.TabIndex = 116;
			this.txtCauTraLoi.Location = new global::System.Drawing.Point(7, 25);
			this.txtCauTraLoi.Multiline = true;
			this.txtCauTraLoi.Name = "txtCauTraLoi";
			this.txtCauTraLoi.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtCauTraLoi.Size = new global::System.Drawing.Size(294, 190);
			this.txtCauTraLoi.TabIndex = 1;
			this.txtCauTraLoi.WordWrap = false;
			this.txtCauTraLoi.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged_1);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(3, 218);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(266, 16);
			this.label9.TabIndex = 0;
			this.label9.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
			this.lblStatusComment.AutoSize = true;
			this.lblStatusComment.Location = new global::System.Drawing.Point(3, 4);
			this.lblStatusComment.Name = "lblStatusComment";
			this.lblStatusComment.Size = new global::System.Drawing.Size(154, 16);
			this.lblStatusComment.TabIndex = 0;
			this.lblStatusComment.Text = "Danh sách câu trả lời (0):";
			this.ckbTuDongTraLoiCauHoi.AutoSize = true;
			this.ckbTuDongTraLoiCauHoi.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuDongTraLoiCauHoi.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuDongTraLoiCauHoi.Location = new global::System.Drawing.Point(349, 51);
			this.ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
			this.ckbTuDongTraLoiCauHoi.Size = new global::System.Drawing.Size(157, 20);
			this.ckbTuDongTraLoiCauHoi.TabIndex = 115;
			this.ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
			this.ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
			this.ckbTuDongTraLoiCauHoi.CheckedChanged += new global::System.EventHandler(this.ckbTuongTac_CheckedChanged);
			this.txtTuKhoa.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTuKhoa.Location = new global::System.Drawing.Point(31, 159);
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.Size = new global::System.Drawing.Size(295, 136);
			this.txtTuKhoa.TabIndex = 114;
			this.txtTuKhoa.Text = "";
			this.txtTuKhoa.WordWrap = false;
			this.txtTuKhoa.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.nudDelayTo.Location = new global::System.Drawing.Point(229, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(28, 296);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(260, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "(Mỗi từ khóa 1 dòng, spin nội dung {a|b|c})";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(27, 139);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(140, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Danh sách từ khóa (0):";
			this.nudDelayFrom.Location = new global::System.Drawing.Point(132, 111);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.label7.Location = new global::System.Drawing.Point(194, 113);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 46;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(287, 113);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 45;
			this.label6.Text = "giây";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 113);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(90, 16);
			this.label5.TabIndex = 44;
			this.label5.Text = "Thời gian chờ:";
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(229, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudSoLuongTo;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
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
			this.label3.Location = new global::System.Drawing.Point(194, 82);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(287, 82);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(40, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "nhóm";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(64, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Số lượng:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(354, 329);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(247, 329);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 6;
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(687, 37);
			this.bunifuCards1.TabIndex = 28;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 0;
			this.toolTip1.InitialDelay = 0;
			this.toolTip1.ReshowDelay = 0;
			this.toolTip1.ShowAlways = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(690, 375);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDThamGiaNhomTuKhoa";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plTuongTac.ResumeLayout(false);
			this.plTuongTac.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400125A RID: 4698
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400125B RID: 4699
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400125C RID: 4700
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400125D RID: 4701
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400125E RID: 4702
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x0400125F RID: 4703
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04001260 RID: 4704
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001261 RID: 4705
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001262 RID: 4706
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001263 RID: 4707
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001264 RID: 4708
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001265 RID: 4709
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001266 RID: 4710
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001267 RID: 4711
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001268 RID: 4712
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001269 RID: 4713
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400126A RID: 4714
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400126B RID: 4715
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400126C RID: 4716
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400126D RID: 4717
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400126E RID: 4718
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400126F RID: 4719
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04001270 RID: 4720
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001271 RID: 4721
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04001272 RID: 4722
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001273 RID: 4723
		private global::System.Windows.Forms.RichTextBox txtTuKhoa;

		// Token: 0x04001274 RID: 4724
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04001275 RID: 4725
		private global::System.Windows.Forms.Panel plTuongTac;

		// Token: 0x04001276 RID: 4726
		private global::System.Windows.Forms.CheckBox ckbTuDongTraLoiCauHoi;

		// Token: 0x04001277 RID: 4727
		private global::System.Windows.Forms.TextBox txtCauTraLoi;

		// Token: 0x04001278 RID: 4728
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001279 RID: 4729
		private global::System.Windows.Forms.Label lblStatusComment;
	}
}
