namespace maxcare
{
	// Token: 0x020000B0 RID: 176
	public partial class fHDGiaiCheckpoint : global::System.Windows.Forms.Form
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x000A17C8 File Offset: 0x0009F9C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000A1828 File Offset: 0x0009FA28
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
			this.txtImage = new global::System.Windows.Forms.TextBox();
			this.ckbImage = new global::System.Windows.Forms.CheckBox();
			this.txtPhone = new global::System.Windows.Forms.TextBox();
			this.ckbPhone = new global::System.Windows.Forms.CheckBox();
			this.txtCaptcha = new global::System.Windows.Forms.TextBox();
			this.ckbCaptcha = new global::System.Windows.Forms.CheckBox();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
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
			this.bunifuCustomLabel1.Text = "Cấu hình Giải Checkpoint";
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
			this.panel1.Controls.Add(this.txtImage);
			this.panel1.Controls.Add(this.ckbImage);
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.ckbPhone);
			this.panel1.Controls.Add(this.txtCaptcha);
			this.panel1.Controls.Add(this.ckbCaptcha);
			this.panel1.Controls.Add(this.txtTenHanhDong);
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
			this.txtImage.Location = new global::System.Drawing.Point(122, 138);
			this.txtImage.Name = "txtImage";
			this.txtImage.Size = new global::System.Drawing.Size(220, 23);
			this.txtImage.TabIndex = 37;
			this.ckbImage.AutoSize = true;
			this.ckbImage.Location = new global::System.Drawing.Point(20, 140);
			this.ckbImage.Name = "ckbImage";
			this.ckbImage.Size = new global::System.Drawing.Size(72, 20);
			this.ckbImage.TabIndex = 36;
			this.ckbImage.Text = "Up ảnh:";
			this.ckbImage.UseVisualStyleBackColor = true;
			this.ckbImage.CheckedChanged += new global::System.EventHandler(this.ckbImage_CheckedChanged);
			this.txtPhone.Location = new global::System.Drawing.Point(122, 109);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new global::System.Drawing.Size(220, 23);
			this.txtPhone.TabIndex = 35;
			this.ckbPhone.AutoSize = true;
			this.ckbPhone.Location = new global::System.Drawing.Point(20, 111);
			this.ckbPhone.Name = "ckbPhone";
			this.ckbPhone.Size = new global::System.Drawing.Size(94, 20);
			this.ckbPhone.TabIndex = 34;
			this.ckbPhone.Text = "Thêm SĐT:";
			this.ckbPhone.UseVisualStyleBackColor = true;
			this.ckbPhone.CheckedChanged += new global::System.EventHandler(this.ckbPhone_CheckedChanged);
			this.txtCaptcha.Location = new global::System.Drawing.Point(122, 80);
			this.txtCaptcha.Name = "txtCaptcha";
			this.txtCaptcha.Size = new global::System.Drawing.Size(220, 23);
			this.txtCaptcha.TabIndex = 33;
			this.ckbCaptcha.AutoSize = true;
			this.ckbCaptcha.Location = new global::System.Drawing.Point(20, 82);
			this.ckbCaptcha.Name = "ckbCaptcha";
			this.ckbCaptcha.Size = new global::System.Drawing.Size(101, 20);
			this.ckbCaptcha.TabIndex = 32;
			this.ckbCaptcha.Text = "Giải captcha:";
			this.ckbCaptcha.UseVisualStyleBackColor = true;
			this.ckbCaptcha.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(122, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(220, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(17, 52);
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
			this.btnCancel.Location = new global::System.Drawing.Point(191, 180);
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
			this.btnAdd.Location = new global::System.Drawing.Point(84, 180);
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
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 222);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDGiaiCheckpoint";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040006A6 RID: 1702
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040006A7 RID: 1703
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040006A8 RID: 1704
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040006A9 RID: 1705
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040006AA RID: 1706
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040006AB RID: 1707
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040006AC RID: 1708
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040006AD RID: 1709
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040006AE RID: 1710
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040006AF RID: 1711
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040006B0 RID: 1712
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040006B1 RID: 1713
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040006B2 RID: 1714
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040006B3 RID: 1715
		private global::System.Windows.Forms.CheckBox ckbCaptcha;

		// Token: 0x040006B4 RID: 1716
		private global::System.Windows.Forms.TextBox txtImage;

		// Token: 0x040006B5 RID: 1717
		private global::System.Windows.Forms.CheckBox ckbImage;

		// Token: 0x040006B6 RID: 1718
		private global::System.Windows.Forms.TextBox txtPhone;

		// Token: 0x040006B7 RID: 1719
		private global::System.Windows.Forms.CheckBox ckbPhone;

		// Token: 0x040006B8 RID: 1720
		private global::System.Windows.Forms.TextBox txtCaptcha;
	}
}
