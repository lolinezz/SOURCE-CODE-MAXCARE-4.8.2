namespace maxcare
{
	// Token: 0x020000CD RID: 205
	public partial class fHDXoaBaiPage : global::System.Windows.Forms.Form
	{
		// Token: 0x06000875 RID: 2165 RVA: 0x00104330 File Offset: 0x00102530
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00104390 File Offset: 0x00102590
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
			this.nudSoLuongBaiTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongBaiFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtIdPage = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.ckbPageProfile = new global::System.Windows.Forms.CheckBox();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiFrom).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(359, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cấu hình Xóa bài viết trên Fanpage";
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
			this.panel1.Controls.Add(this.ckbPageProfile);
			this.panel1.Controls.Add(this.nudSoLuongBaiTo);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudSoLuongBaiFrom);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.txtIdPage);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(362, 237);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.nudSoLuongBaiTo.Location = new global::System.Drawing.Point(229, 129);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudSoLuongBaiTo;
			int[] array = new int[4];
			array[0] = 999999;
			this.nudSoLuongBaiTo.Name = "nudSoLuongBaiTo";
			this.nudSoLuongBaiTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongBaiTo.TabIndex = 4;
			this.nudDelayTo.Location = new global::System.Drawing.Point(229, 158);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			this.nudDelayTo.Name = "nudDelayTo";
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 4;
			this.nudSoLuongBaiFrom.Location = new global::System.Drawing.Point(132, 129);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudSoLuongBaiFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
			this.nudSoLuongBaiFrom.Name = "nudSoLuongBaiFrom";
			this.nudSoLuongBaiFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongBaiFrom.TabIndex = 3;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(132, 158);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudDelayFrom;
			int[] array4 = new int[4];
			array4[0] = 999999;
			this.nudDelayFrom.Name = "nudDelayFrom";
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 3;
			this.txtIdPage.Location = new global::System.Drawing.Point(132, 78);
			this.txtIdPage.Name = "txtIdPage";
			this.txtIdPage.Size = new global::System.Drawing.Size(194, 23);
			this.txtIdPage.TabIndex = 0;
			this.label8.Location = new global::System.Drawing.Point(194, 131);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(29, 16);
			this.label8.TabIndex = 38;
			this.label8.Text = "đến";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(132, 49);
			this.txtTenHanhDong.Name = "txtTenHanhDong";
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(287, 131);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(25, 16);
			this.label4.TabIndex = 36;
			this.label4.Text = "bài";
			this.label7.Location = new global::System.Drawing.Point(194, 160);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "đến";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(287, 160);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = "giây";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(27, 131);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(85, 16);
			this.label3.TabIndex = 34;
			this.label3.Text = "Số lượng bài:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 81);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 16);
			this.label2.TabIndex = 31;
			this.label2.Text = "ID Page:";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 160);
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
			this.btnCancel.Location = new global::System.Drawing.Point(189, 195);
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
			this.btnAdd.Location = new global::System.Drawing.Point(82, 195);
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
			this.ckbPageProfile.AutoSize = true;
			this.ckbPageProfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbPageProfile.Location = new global::System.Drawing.Point(132, 103);
			this.ckbPageProfile.Name = "ckbPageProfile";
			this.ckbPageProfile.Size = new global::System.Drawing.Size(135, 20);
			this.ckbPageProfile.TabIndex = 39;
			this.ckbPageProfile.Text = "Đây là page profile";
			this.ckbPageProfile.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 237);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fHDXoaBaiPage";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình tương tác";
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000B90 RID: 2960
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000B91 RID: 2961
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000B92 RID: 2962
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000B93 RID: 2963
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000B94 RID: 2964
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000B95 RID: 2965
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000B96 RID: 2966
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x04000B97 RID: 2967
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000B98 RID: 2968
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000B99 RID: 2969
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000B9A RID: 2970
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000B9B RID: 2971
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000B9C RID: 2972
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000B9D RID: 2973
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000B9E RID: 2974
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000B9F RID: 2975
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000BA0 RID: 2976
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000BA1 RID: 2977
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000BA2 RID: 2978
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiTo;

		// Token: 0x04000BA3 RID: 2979
		private global::System.Windows.Forms.NumericUpDown nudSoLuongBaiFrom;

		// Token: 0x04000BA4 RID: 2980
		private global::System.Windows.Forms.TextBox txtIdPage;

		// Token: 0x04000BA5 RID: 2981
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000BA6 RID: 2982
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000BA7 RID: 2983
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000BA8 RID: 2984
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000BA9 RID: 2985
		private global::System.Windows.Forms.CheckBox ckbPageProfile;
	}
}
