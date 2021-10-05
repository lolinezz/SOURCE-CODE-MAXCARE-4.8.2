namespace maxcare
{
	// Token: 0x02000093 RID: 147
	public partial class fSuaChuDe : global::System.Windows.Forms.Form
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x0007EFB4 File Offset: 0x0007D1B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0007F014 File Offset: 0x0007D214
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.txtChude = new global::MetroFramework.Controls.MetroTextBox();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.txtNewChuDe = new global::MetroFramework.Controls.MetroTextBox();
			this.bunifuCards2 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.thêmMớiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.bunifuCards2.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(0, 47);
			this.bunifuCards1.TabIndex = 12;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.txtChude);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.txtNewChuDe);
			this.panel1.Controls.Add(this.bunifuCards2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(329, 164);
			this.panel1.TabIndex = 37;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label1.Location = new global::System.Drawing.Point(28, 49);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(94, 16);
			this.label1.TabIndex = 47;
			this.label1.Text = "Tên chủ đề cũ:";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label2.Location = new global::System.Drawing.Point(28, 78);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(102, 16);
			this.label2.TabIndex = 47;
			this.label2.Text = "Tên chủ đề mới:";
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(173, 116);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 46;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click_1);
			this.txtChude.CustomButton.Image = null;
			this.txtChude.CustomButton.Location = new global::System.Drawing.Point(131, 1);
			this.txtChude.CustomButton.Name = "";
			this.txtChude.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.txtChude.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.txtChude.CustomButton.TabIndex = 1;
			this.txtChude.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.txtChude.CustomButton.UseSelectable = true;
			this.txtChude.CustomButton.Visible = false;
			this.txtChude.Lines = new string[0];
			this.txtChude.Location = new global::System.Drawing.Point(138, 46);
			this.txtChude.MaxLength = 32767;
			this.txtChude.Name = "txtChude";
			this.txtChude.PasswordChar = '\0';
			this.txtChude.ReadOnly = true;
			this.txtChude.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.txtChude.SelectedText = "";
			this.txtChude.SelectionLength = 0;
			this.txtChude.SelectionStart = 0;
			this.txtChude.ShortcutsEnabled = true;
			this.txtChude.Size = new global::System.Drawing.Size(153, 23);
			this.txtChude.TabIndex = 44;
			this.txtChude.UseSelectable = true;
			this.txtChude.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtChude.WaterMarkFont = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(69, 116);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 45;
			this.btnAdd.Text = "Cập nhật";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.txtNewChuDe.CustomButton.Image = null;
			this.txtNewChuDe.CustomButton.Location = new global::System.Drawing.Point(131, 1);
			this.txtNewChuDe.CustomButton.Name = "";
			this.txtNewChuDe.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.txtNewChuDe.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.txtNewChuDe.CustomButton.TabIndex = 1;
			this.txtNewChuDe.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.txtNewChuDe.CustomButton.UseSelectable = true;
			this.txtNewChuDe.CustomButton.Visible = false;
			this.txtNewChuDe.Lines = new string[0];
			this.txtNewChuDe.Location = new global::System.Drawing.Point(138, 75);
			this.txtNewChuDe.MaxLength = 32767;
			this.txtNewChuDe.Name = "txtNewChuDe";
			this.txtNewChuDe.PasswordChar = '\0';
			this.txtNewChuDe.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.txtNewChuDe.SelectedText = "";
			this.txtNewChuDe.SelectionLength = 0;
			this.txtNewChuDe.SelectionStart = 0;
			this.txtNewChuDe.ShortcutsEnabled = true;
			this.txtNewChuDe.Size = new global::System.Drawing.Size(153, 23);
			this.txtNewChuDe.TabIndex = 44;
			this.txtNewChuDe.UseSelectable = true;
			this.txtNewChuDe.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtNewChuDe.WaterMarkFont = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCards2.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards2.BorderRadius = 0;
			this.bunifuCards2.BottomSahddow = true;
			this.bunifuCards2.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards2.Controls.Add(this.pnlHeader);
			this.bunifuCards2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards2.LeftSahddow = false;
			this.bunifuCards2.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards2.Name = "bunifuCards2";
			this.bunifuCards2.RightSahddow = true;
			this.bunifuCards2.ShadowDepth = 20;
			this.bunifuCards2.Size = new global::System.Drawing.Size(327, 37);
			this.bunifuCards2.TabIndex = 43;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(327, 31);
			this.pnlHeader.TabIndex = 9;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(296, 1);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(30, 30);
			this.button2.TabIndex = 77;
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Location = new global::System.Drawing.Point(899, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(30, 30);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(327, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cập nhật chủ đề";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.thêmMớiToolStripMenuItem,
				this.sửaToolStripMenuItem,
				this.xóaToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(153, 70);
			this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
			this.thêmMớiToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.thêmMớiToolStripMenuItem.Text = "Thêm chủ đề";
			this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
			this.sửaToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.sửaToolStripMenuItem.Text = "Sửa tên chủ đề";
			this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
			this.xóaToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.xóaToolStripMenuItem.Text = "Xóa chủ đề";
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(329, 164);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.bunifuCards1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fSuaChuDe";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình chung";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.fSuaChuDe_FormClosing);
			base.Load += new global::System.EventHandler(this.FConfigGenneral_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.bunifuCards2.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040004F2 RID: 1266
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040004F3 RID: 1267
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040004F4 RID: 1268
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040004F5 RID: 1269
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040004F6 RID: 1270
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040004F7 RID: 1271
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x040004F8 RID: 1272
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040004F9 RID: 1273
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040004FA RID: 1274
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040004FB RID: 1275
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040004FC RID: 1276
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040004FD RID: 1277
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040004FE RID: 1278
		private global::System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;

		// Token: 0x040004FF RID: 1279
		private global::System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;

		// Token: 0x04000500 RID: 1280
		private global::System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;

		// Token: 0x04000501 RID: 1281
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000502 RID: 1282
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000503 RID: 1283
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000504 RID: 1284
		private global::MetroFramework.Controls.MetroTextBox txtNewChuDe;

		// Token: 0x04000505 RID: 1285
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000506 RID: 1286
		private global::MetroFramework.Controls.MetroTextBox txtChude;
	}
}
