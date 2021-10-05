namespace maxcare
{
	// Token: 0x020000FF RID: 255
	public partial class fHDTimKiemGoogle : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A7E RID: 2686 RVA: 0x001616D8 File Offset: 0x0015F8D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00161738 File Offset: 0x0015F938
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDTimKiemGoogle));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.txtTuKhoa = new global::System.Windows.Forms.RichTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.nudCountTimeScrollTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountLinkClickTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountPageTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountTuKhoaTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountTimeScrollFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountLinkClickFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountPageFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountTuKhoaFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaFrom).BeginInit();
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
			this.bunifuCustomLabel1.Text = "Cấu hình Tìm kiếm Google";
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
			this.panel1.Controls.Add(this.txtTuKhoa);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.nudCountTimeScrollTo);
			this.panel1.Controls.Add(this.nudCountLinkClickTo);
			this.panel1.Controls.Add(this.nudCountPageTo);
			this.panel1.Controls.Add(this.nudCountTuKhoaTo);
			this.panel1.Controls.Add(this.nudCountTimeScrollFrom);
			this.panel1.Controls.Add(this.nudCountLinkClickFrom);
			this.panel1.Controls.Add(this.nudCountPageFrom);
			this.panel1.Controls.Add(this.nudCountTuKhoaFrom);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 428);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.txtTuKhoa.Location = new global::System.Drawing.Point(30, 94);
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.Size = new global::System.Drawing.Size(298, 142);
			this.txtTuKhoa.TabIndex = 42;
			this.txtTuKhoa.Text = "";
			this.txtTuKhoa.WordWrap = false;
			this.txtTuKhoa.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(28, 239);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(134, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = "(Mỗi nội dung 1 dòng)";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(27, 75);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(202, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Danh sách Từ khóa|Link Web (0):";
			this.nudCountTimeScrollTo.Location = new global::System.Drawing.Point(263, 344);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudCountTimeScrollTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
			this.nudCountTimeScrollTo.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountTimeScrollTo.TabIndex = 2;
			this.nudCountLinkClickTo.Location = new global::System.Drawing.Point(263, 316);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudCountLinkClickTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudCountLinkClickTo.Name = "nudCountLinkClickTo";
			this.nudCountLinkClickTo.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountLinkClickTo.TabIndex = 2;
			this.nudCountPageTo.Location = new global::System.Drawing.Point(263, 288);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudCountPageTo;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudCountPageTo.Name = "nudCountPageTo";
			this.nudCountPageTo.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountPageTo.TabIndex = 2;
			this.nudCountTuKhoaTo.Location = new global::System.Drawing.Point(263, 260);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudCountTuKhoaTo;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudCountTuKhoaTo.Name = "nudCountTuKhoaTo";
			this.nudCountTuKhoaTo.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountTuKhoaTo.TabIndex = 2;
			this.nudCountTimeScrollFrom.Location = new global::System.Drawing.Point(192, 344);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudCountTimeScrollFrom;
			int[] array5 = new int[4];
			array5[0] = 999999;
			this.nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
			this.nudCountTimeScrollFrom.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountTimeScrollFrom.TabIndex = 1;
			this.nudCountLinkClickFrom.Location = new global::System.Drawing.Point(192, 316);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudCountLinkClickFrom;
			int[] array6 = new int[4];
			array6[0] = 999999;
			this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
			this.nudCountLinkClickFrom.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountLinkClickFrom.TabIndex = 1;
			this.nudCountPageFrom.Location = new global::System.Drawing.Point(192, 288);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudCountPageFrom;
			int[] array7 = new int[4];
			array7[0] = 999999;
			this.nudCountPageFrom.Name = "nudCountPageFrom";
			this.nudCountPageFrom.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountPageFrom.TabIndex = 1;
			this.nudCountTuKhoaFrom.Location = new global::System.Drawing.Point(192, 260);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudCountTuKhoaFrom;
			int[] array8 = new int[4];
			array8[0] = 999999;
			this.nudCountTuKhoaFrom.Name = "nudCountTuKhoaFrom";
			this.nudCountTuKhoaFrom.Size = new global::System.Drawing.Size(36, 23);
			this.nudCountTuKhoaFrom.TabIndex = 1;
			this.label4.Location = new global::System.Drawing.Point(231, 346);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(29, 16);
			this.label4.TabIndex = 37;
			this.label4.Text = "đến";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(134, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label17.Location = new global::System.Drawing.Point(231, 318);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(29, 16);
			this.label17.TabIndex = 37;
			this.label17.Text = "đến";
			this.label17.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label14.Location = new global::System.Drawing.Point(231, 290);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(29, 16);
			this.label14.TabIndex = 37;
			this.label14.Text = "đến";
			this.label14.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(299, 346);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(31, 16);
			this.label3.TabIndex = 35;
			this.label3.Text = "giây";
			this.label13.Location = new global::System.Drawing.Point(231, 262);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(29, 16);
			this.label13.TabIndex = 37;
			this.label13.Text = "đến";
			this.label13.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(299, 318);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(27, 16);
			this.label16.TabIndex = 35;
			this.label16.Text = "link";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(299, 290);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(38, 16);
			this.label12.TabIndex = 35;
			this.label12.Text = "trang";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(299, 262);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(51, 16);
			this.label11.TabIndex = 35;
			this.label11.Text = "từ khóa";
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(28, 318);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(165, 16);
			this.label15.TabIndex = 34;
			this.label15.Text = "Click random link trên web:";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(27, 290);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(151, 16);
			this.label10.TabIndex = 34;
			this.label10.Text = "Số trang tìm kiếm tối đa:";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(27, 262);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(121, 16);
			this.label9.TabIndex = 32;
			this.label9.Text = "Số từ khóa cần tìm:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 346);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(147, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Thời gian lướt trên web:";
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
			this.btnCancel.Location = new global::System.Drawing.Point(189, 384);
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
			this.btnAdd.Location = new global::System.Drawing.Point(82, 384);
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
			base.ClientSize = new global::System.Drawing.Size(362, 428);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDTimKiemGoogle";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000F50 RID: 3920
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000F51 RID: 3921
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000F52 RID: 3922
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000F53 RID: 3923
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000F54 RID: 3924
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000F55 RID: 3925
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000F56 RID: 3926
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F57 RID: 3927
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000F58 RID: 3928
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000F59 RID: 3929
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000F5A RID: 3930
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000F5B RID: 3931
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000F5C RID: 3932
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000F5D RID: 3933
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000F5E RID: 3934
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000F5F RID: 3935
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000F60 RID: 3936
		private global::System.Windows.Forms.RichTextBox txtTuKhoa;

		// Token: 0x04000F61 RID: 3937
		private global::System.Windows.Forms.NumericUpDown nudCountTimeScrollTo;

		// Token: 0x04000F62 RID: 3938
		private global::System.Windows.Forms.NumericUpDown nudCountLinkClickTo;

		// Token: 0x04000F63 RID: 3939
		private global::System.Windows.Forms.NumericUpDown nudCountPageTo;

		// Token: 0x04000F64 RID: 3940
		private global::System.Windows.Forms.NumericUpDown nudCountTuKhoaTo;

		// Token: 0x04000F65 RID: 3941
		private global::System.Windows.Forms.NumericUpDown nudCountTimeScrollFrom;

		// Token: 0x04000F66 RID: 3942
		private global::System.Windows.Forms.NumericUpDown nudCountLinkClickFrom;

		// Token: 0x04000F67 RID: 3943
		private global::System.Windows.Forms.NumericUpDown nudCountPageFrom;

		// Token: 0x04000F68 RID: 3944
		private global::System.Windows.Forms.NumericUpDown nudCountTuKhoaFrom;

		// Token: 0x04000F69 RID: 3945
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000F6A RID: 3946
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000F6B RID: 3947
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000F6C RID: 3948
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000F6D RID: 3949
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000F6E RID: 3950
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000F6F RID: 3951
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000F70 RID: 3952
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000F71 RID: 3953
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000F72 RID: 3954
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000F73 RID: 3955
		private global::System.Windows.Forms.Label label9;
	}
}
