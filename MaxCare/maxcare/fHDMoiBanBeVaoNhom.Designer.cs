namespace maxcare
{
	// Token: 0x0200010F RID: 271
	public partial class fHDMoiBanBeVaoNhom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BC9 RID: 3017 RVA: 0x001A3C58 File Offset: 0x001A1E58
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x001A3CB8 File Offset: 0x001A1EB8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDMoiBanBeVaoNhom));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.rbInviteSuggest = new global::System.Windows.Forms.RadioButton();
			this.rbInviteRandom = new global::System.Windows.Forms.RadioButton();
			this.txtUid = new global::System.Windows.Forms.RichTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(359, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Mời bạn bè vào nhóm";
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
			this.panel1.Controls.Add(this.rbInviteSuggest);
			this.panel1.Controls.Add(this.rbInviteRandom);
			this.panel1.Controls.Add(this.txtUid);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 410);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.rbInviteSuggest.AutoSize = true;
			this.rbInviteSuggest.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbInviteSuggest.Location = new global::System.Drawing.Point(132, 161);
			this.rbInviteSuggest.Name = "rbInviteSuggest";
			this.rbInviteSuggest.Size = new global::System.Drawing.Size(136, 20);
			this.rbInviteSuggest.TabIndex = 115;
			this.rbInviteSuggest.Text = "Gợi ý của Facebook";
			this.rbInviteSuggest.UseVisualStyleBackColor = true;
			this.rbInviteRandom.AutoSize = true;
			this.rbInviteRandom.Checked = true;
			this.rbInviteRandom.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbInviteRandom.Location = new global::System.Drawing.Point(132, 138);
			this.rbInviteRandom.Name = "rbInviteRandom";
			this.rbInviteRandom.Size = new global::System.Drawing.Size(113, 20);
			this.rbInviteRandom.TabIndex = 115;
			this.rbInviteRandom.TabStop = true;
			this.rbInviteRandom.Text = "Mời ngẫu nhiên";
			this.rbInviteRandom.UseVisualStyleBackColor = true;
			this.txtUid.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUid.Location = new global::System.Drawing.Point(31, 203);
			this.txtUid.Name = "txtUid";
			this.txtUid.Size = new global::System.Drawing.Size(295, 136);
			this.txtUid.TabIndex = 114;
			this.txtUid.Text = "";
			this.txtUid.WordWrap = false;
			this.txtUid.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(28, 342);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(103, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "(Mỗi Uid 1 dòng)";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 140);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(90, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tùy chọn mời:";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(27, 183);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(200, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Danh sách Uid nhóm cần mời (0):";
			this.nudDelayTo.Location = new global::System.Drawing.Point(229, 109);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 2;
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(229, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSoLuongTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(132, 109);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudDelayFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 1;
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
			this.label9.Location = new global::System.Drawing.Point(194, 111);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(29, 16);
			this.label9.TabIndex = 37;
			this.label9.Text = "đến";
			this.label9.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Location = new global::System.Drawing.Point(194, 82);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "đến";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(287, 111);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(31, 16);
			this.label7.TabIndex = 35;
			this.label7.Text = "giây";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(287, 82);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(29, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "bạn";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(27, 111);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(100, 16);
			this.label6.TabIndex = 32;
			this.label6.Text = "Thời gian delay:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(101, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Số lượng/nhóm:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(191, 370);
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
			this.btnAdd.Location = new global::System.Drawing.Point(80, 370);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(359, 37);
			this.bunifuCards1.TabIndex = 28;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 0;
			this.toolTip1.InitialDelay = 0;
			this.toolTip1.ReshowDelay = 0;
			this.toolTip1.ShowAlways = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 410);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDMoiBanBeVaoNhom";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04001280 RID: 4736
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001281 RID: 4737
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001282 RID: 4738
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001283 RID: 4739
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001284 RID: 4740
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001285 RID: 4741
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04001286 RID: 4742
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04001287 RID: 4743
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001288 RID: 4744
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04001289 RID: 4745
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400128A RID: 4746
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400128B RID: 4747
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400128C RID: 4748
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400128D RID: 4749
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400128E RID: 4750
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400128F RID: 4751
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001290 RID: 4752
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001291 RID: 4753
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001292 RID: 4754
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001293 RID: 4755
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04001294 RID: 4756
		private global::System.Windows.Forms.RichTextBox txtUid;

		// Token: 0x04001295 RID: 4757
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04001296 RID: 4758
		private global::System.Windows.Forms.RadioButton rbInviteSuggest;

		// Token: 0x04001297 RID: 4759
		private global::System.Windows.Forms.RadioButton rbInviteRandom;

		// Token: 0x04001298 RID: 4760
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001299 RID: 4761
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400129A RID: 4762
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x0400129B RID: 4763
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400129C RID: 4764
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400129D RID: 4765
		private global::System.Windows.Forms.Label label6;
	}
}
