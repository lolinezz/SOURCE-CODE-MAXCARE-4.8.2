namespace maxcare
{
	// Token: 0x02000092 RID: 146
	public partial class fSuaBaiViet : global::System.Windows.Forms.Form
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x0007CDE8 File Offset: 0x0007AFE8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0007CE48 File Offset: 0x0007B048
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.txtConten = new global::System.Windows.Forms.RichTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.metroButton3 = new global::MetroFramework.Controls.MetroButton();
			this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.lblNanh = new global::System.Windows.Forms.Label();
			this.dgvPic = new global::System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtName = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cbbChuDe = new global::System.Windows.Forms.ComboBox();
			this.bunifuCards2 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.thêmMớiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPic).BeginInit();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(46, 47);
			this.bunifuCards1.TabIndex = 12;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtConten);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.metroButton3);
			this.panel1.Controls.Add(this.metroButton2);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.lblNanh);
			this.panel1.Controls.Add(this.dgvPic);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbbChuDe);
			this.panel1.Controls.Add(this.bunifuCards2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(375, 414);
			this.panel1.TabIndex = 37;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.txtConten.Location = new global::System.Drawing.Point(89, 184);
			this.txtConten.Name = "txtConten";
			this.txtConten.Size = new global::System.Drawing.Size(271, 149);
			this.txtConten.TabIndex = 119;
			this.txtConten.Text = "";
			this.txtConten.WordWrap = false;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(86, 336);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(134, 16);
			this.label8.TabIndex = 117;
			this.label8.Text = "Spin nội dung {a|b|c}";
			this.metroButton3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.metroButton3.Location = new global::System.Drawing.Point(330, 148);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new global::System.Drawing.Size(30, 30);
			this.metroButton3.TabIndex = 113;
			this.metroButton3.UseSelectable = true;
			this.metroButton3.Click += new global::System.EventHandler(this.btnDelLink_Click);
			this.metroButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.metroButton2.Location = new global::System.Drawing.Point(330, 109);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new global::System.Drawing.Size(30, 30);
			this.metroButton2.TabIndex = 113;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new global::System.EventHandler(this.btnAddLink_Click);
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(192, 370);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 103;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnEdit_Click);
			this.button1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(85, 370);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(92, 29);
			this.button1.TabIndex = 102;
			this.button1.Text = "Cập nhật";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.lblNanh.AutoSize = true;
			this.lblNanh.Location = new global::System.Drawing.Point(11, 109);
			this.lblNanh.Name = "lblNanh";
			this.lblNanh.Size = new global::System.Drawing.Size(56, 16);
			this.lblNanh.TabIndex = 90;
			this.lblNanh.Text = "Ảnh (0):";
			this.lblNanh.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.dgvPic.AllowUserToAddRows = false;
			this.dgvPic.AllowUserToDeleteRows = false;
			this.dgvPic.AllowUserToResizeColumns = false;
			this.dgvPic.AllowUserToResizeRows = false;
			this.dgvPic.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvPic.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPic.ColumnHeadersVisible = false;
			this.dgvPic.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn4
			});
			this.dgvPic.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.dgvPic.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPic.Location = new global::System.Drawing.Point(90, 109);
			this.dgvPic.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvPic.Name = "dgvPic";
			this.dgvPic.RowHeadersVisible = false;
			this.dgvPic.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPic.Size = new global::System.Drawing.Size(236, 69);
			this.dgvPic.TabIndex = 83;
			this.dgvPic.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPic_CellDoubleClick);
			this.dataGridViewTextBoxColumn4.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Day";
			this.dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
			this.dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.txtName.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtName.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtName.Location = new global::System.Drawing.Point(90, 78);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new global::System.Drawing.Size(269, 23);
			this.txtName.TabIndex = 87;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label2.Location = new global::System.Drawing.Point(11, 187);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(63, 16);
			this.label2.TabIndex = 86;
			this.label2.Text = "Nội dung:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label5.Location = new global::System.Drawing.Point(11, 81);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(56, 16);
			this.label5.TabIndex = 85;
			this.label5.Text = "Tiêu đề:";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(11, 50);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 16);
			this.label1.TabIndex = 81;
			this.label1.Text = "Chủ đề:";
			this.cbbChuDe.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbChuDe.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbChuDe.Enabled = false;
			this.cbbChuDe.FormattingEnabled = true;
			this.cbbChuDe.Location = new global::System.Drawing.Point(90, 47);
			this.cbbChuDe.Name = "cbbChuDe";
			this.cbbChuDe.Size = new global::System.Drawing.Size(269, 24);
			this.cbbChuDe.TabIndex = 80;
			this.cbbChuDe.SelectedIndexChanged += new global::System.EventHandler(this.cbbChuDe_SelectedIndexChanged);
			this.cbbChuDe.Click += new global::System.EventHandler(this.cbbChuDe_Click);
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
			this.bunifuCards2.Size = new global::System.Drawing.Size(373, 37);
			this.bunifuCards2.TabIndex = 43;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(373, 31);
			this.pnlHeader.TabIndex = 9;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(342, 1);
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
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(373, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Sửa bình luận";
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
			base.ClientSize = new global::System.Drawing.Size(375, 414);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.bunifuCards1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fSuaBaiViet";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cấu hình chung";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.fSuaBaiViet_FormClosed);
			base.Load += new global::System.EventHandler(this.FConfigGenneral_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPic).EndInit();
			this.bunifuCards2.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040004D6 RID: 1238
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040004D7 RID: 1239
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040004D8 RID: 1240
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040004D9 RID: 1241
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040004DA RID: 1242
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040004DB RID: 1243
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040004DC RID: 1244
		private global::System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;

		// Token: 0x040004DD RID: 1245
		private global::System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;

		// Token: 0x040004DE RID: 1246
		private global::System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;

		// Token: 0x040004DF RID: 1247
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004E0 RID: 1248
		private global::System.Windows.Forms.ComboBox cbbChuDe;

		// Token: 0x040004E1 RID: 1249
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x040004E2 RID: 1250
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040004E3 RID: 1251
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040004E4 RID: 1252
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040004E5 RID: 1253
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040004E6 RID: 1254
		private global::System.Windows.Forms.Label lblNanh;

		// Token: 0x040004E7 RID: 1255
		private global::System.Windows.Forms.DataGridView dgvPic;

		// Token: 0x040004E8 RID: 1256
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x040004E9 RID: 1257
		private global::System.Windows.Forms.TextBox txtName;

		// Token: 0x040004EA RID: 1258
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040004EB RID: 1259
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040004EC RID: 1260
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040004ED RID: 1261
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040004EE RID: 1262
		private global::MetroFramework.Controls.MetroButton metroButton2;

		// Token: 0x040004EF RID: 1263
		private global::MetroFramework.Controls.MetroButton metroButton3;

		// Token: 0x040004F0 RID: 1264
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040004F1 RID: 1265
		private global::System.Windows.Forms.RichTextBox txtConten;
	}
}
