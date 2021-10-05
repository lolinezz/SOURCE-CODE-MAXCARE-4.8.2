namespace maxcare
{
	// Token: 0x0200008E RID: 142
	public partial class fNhapPassKhoiPhuc : global::System.Windows.Forms.Form
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x00073EC4 File Offset: 0x000720C4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00073F24 File Offset: 0x00072124
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fNhapPassKhoiPhuc));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.rbPassNgauNhien = new global::System.Windows.Forms.RadioButton();
			this.rbPassTuDat = new global::System.Windows.Forms.RadioButton();
			this.txtPass = new global::System.Windows.Forms.TextBox();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(313, 34);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(311, 28);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Location = new global::System.Drawing.Point(279, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 28);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnMinimize_Click);
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(311, 28);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Tùy chọn mật khẩu";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(162, 102);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(58, 102);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Lưu";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.rbPassNgauNhien.AutoSize = true;
			this.rbPassNgauNhien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbPassNgauNhien.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbPassNgauNhien.Location = new global::System.Drawing.Point(12, 73);
			this.rbPassNgauNhien.Name = "rbPassNgauNhien";
			this.rbPassNgauNhien.Size = new global::System.Drawing.Size(119, 20);
			this.rbPassNgauNhien.TabIndex = 5;
			this.rbPassNgauNhien.TabStop = true;
			this.rbPassNgauNhien.Text = "Pass ngẫu nhiên";
			this.rbPassNgauNhien.UseVisualStyleBackColor = true;
			this.rbPassTuDat.AutoSize = true;
			this.rbPassTuDat.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbPassTuDat.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbPassTuDat.Location = new global::System.Drawing.Point(12, 43);
			this.rbPassTuDat.Name = "rbPassTuDat";
			this.rbPassTuDat.Size = new global::System.Drawing.Size(95, 20);
			this.rbPassTuDat.TabIndex = 6;
			this.rbPassTuDat.TabStop = true;
			this.rbPassTuDat.Text = "Pass tự đặt:";
			this.rbPassTuDat.UseVisualStyleBackColor = true;
			this.rbPassTuDat.CheckedChanged += new global::System.EventHandler(this.rbPassTuDat_CheckedChanged);
			this.txtPass.Location = new global::System.Drawing.Point(131, 44);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new global::System.Drawing.Size(168, 20);
			this.txtPass.TabIndex = 7;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(313, 137);
			base.Controls.Add(this.txtPass);
			base.Controls.Add(this.rbPassTuDat);
			base.Controls.Add(this.rbPassNgauNhien);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fNhapPassKhoiPhuc";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fClearProfile_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400046F RID: 1135
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000470 RID: 1136
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000471 RID: 1137
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000472 RID: 1138
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000473 RID: 1139
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000474 RID: 1140
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000475 RID: 1141
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000476 RID: 1142
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000477 RID: 1143
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000478 RID: 1144
		private global::System.Windows.Forms.RadioButton rbPassNgauNhien;

		// Token: 0x04000479 RID: 1145
		private global::System.Windows.Forms.RadioButton rbPassTuDat;

		// Token: 0x0400047A RID: 1146
		private global::System.Windows.Forms.TextBox txtPass;
	}
}
