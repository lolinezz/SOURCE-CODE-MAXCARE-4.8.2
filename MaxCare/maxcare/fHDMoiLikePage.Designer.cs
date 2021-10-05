namespace maxcare
{
	// Token: 0x020000C2 RID: 194
	public partial class fHDMoiLikePage : global::System.Windows.Forms.Form
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x000DA320 File Offset: 0x000D8520
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000DA380 File Offset: 0x000D8580
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
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.txtIdPage = new global::System.Windows.Forms.TextBox();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(359, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Mời like Page";
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
			this.panel1.Controls.Add(this.txtIdPage);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 222);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.nudDelayTo.Location = new global::System.Drawing.Point(205, 136);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(36, 23);
			this.nudDelayTo.TabIndex = 2;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(28, 138);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(100, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Thời gian delay:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(247, 138);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(31, 16);
			this.label3.TabIndex = 35;
			this.label3.Text = "giây";
			this.label4.Location = new global::System.Drawing.Point(173, 138);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(29, 16);
			this.label4.TabIndex = 37;
			this.label4.Text = "đến";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(134, 136);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(36, 23);
			this.nudDelayFrom.TabIndex = 1;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(28, 78);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(90, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Nhập ID Page:";
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(205, 107);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudSoLuongTo;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudSoLuongTo.Name = "nudSoLuongTo";
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(36, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(134, 107);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudSoLuongFrom;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudSoLuongFrom.Name = "nudSoLuongFrom";
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(36, 23);
			this.nudSoLuongFrom.TabIndex = 1;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(134, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label13.Location = new global::System.Drawing.Point(173, 109);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(29, 16);
			this.label13.TabIndex = 37;
			this.label13.Text = "đến";
			this.label13.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(247, 109);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(40, 16);
			this.label11.TabIndex = 35;
			this.label11.Text = "người";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(27, 109);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(102, 16);
			this.label9.TabIndex = 32;
			this.label9.Text = "Số bạn cần mời:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(193, 181);
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
			this.btnAdd.Location = new global::System.Drawing.Point(86, 181);
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
			this.txtIdPage.Location = new global::System.Drawing.Point(134, 78);
			this.txtIdPage.Name = "txtIdPage";
			this.txtIdPage.Size = new global::System.Drawing.Size(194, 23);
			this.txtIdPage.TabIndex = 38;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 222);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDMoiLikePage";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400097A RID: 2426
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400097B RID: 2427
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400097C RID: 2428
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400097D RID: 2429
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400097E RID: 2430
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400097F RID: 2431
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000980 RID: 2432
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000981 RID: 2433
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000982 RID: 2434
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000983 RID: 2435
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000984 RID: 2436
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000985 RID: 2437
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000986 RID: 2438
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000987 RID: 2439
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04000988 RID: 2440
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x04000989 RID: 2441
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400098A RID: 2442
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400098B RID: 2443
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400098C RID: 2444
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x0400098D RID: 2445
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400098E RID: 2446
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400098F RID: 2447
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000990 RID: 2448
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000991 RID: 2449
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000992 RID: 2450
		private global::System.Windows.Forms.TextBox txtIdPage;
	}
}
