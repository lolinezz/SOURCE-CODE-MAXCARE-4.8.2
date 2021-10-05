namespace maxcare
{
	// Token: 0x0200008B RID: 139
	public partial class fChonThuMuc : global::System.Windows.Forms.Form
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x0006F0A8 File Offset: 0x0006D2A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0006F108 File Offset: 0x0006D308
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fChonThuMuc));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblCountTotal = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lblCountChoose = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.dtgvAcc = new global::System.Windows.Forms.DataGridView();
			this.cChose = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cStt = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cThuMuc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(317, 34);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(317, 28);
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
			this.btnMinimize.Location = new global::System.Drawing.Point(285, 0);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(317, 28);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Chọn Danh sách thư mục";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(156, 280);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(52, 280);
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
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(145, 252);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(59, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tổng số:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblCountTotal.AutoSize = true;
			this.lblCountTotal.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCountTotal.ForeColor = global::System.Drawing.Color.DarkRed;
			this.lblCountTotal.Location = new global::System.Drawing.Point(203, 253);
			this.lblCountTotal.Name = "lblCountTotal";
			this.lblCountTotal.Size = new global::System.Drawing.Size(15, 16);
			this.lblCountTotal.TabIndex = 6;
			this.lblCountTotal.Text = "0";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(49, 252);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(60, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Đã chọn:";
			this.lblCountChoose.AutoSize = true;
			this.lblCountChoose.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCountChoose.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.lblCountChoose.Location = new global::System.Drawing.Point(107, 253);
			this.lblCountChoose.Name = "lblCountChoose";
			this.lblCountChoose.Size = new global::System.Drawing.Size(15, 16);
			this.lblCountChoose.TabIndex = 6;
			this.lblCountChoose.Text = "0";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label2.Location = new global::System.Drawing.Point(12, 227);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(178, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "(Click đúp vào dòng để chọn!)";
			this.dtgvAcc.AllowUserToAddRows = false;
			this.dtgvAcc.AllowUserToDeleteRows = false;
			this.dtgvAcc.AllowUserToResizeRows = false;
			this.dtgvAcc.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dtgvAcc.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvAcc.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cChose,
				this.cStt,
				this.cId,
				this.cThuMuc
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvAcc.Location = new global::System.Drawing.Point(15, 40);
			this.dtgvAcc.Name = "dtgvAcc";
			this.dtgvAcc.ReadOnly = true;
			this.dtgvAcc.RowHeadersVisible = false;
			this.dtgvAcc.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvAcc.Size = new global::System.Drawing.Size(287, 184);
			this.dtgvAcc.TabIndex = 7;
			this.dtgvAcc.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
			this.dtgvAcc.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
			this.dtgvAcc.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvAcc_CellValueChanged);
			this.cChose.HeaderText = "";
			this.cChose.Name = "cChose";
			this.cChose.ReadOnly = true;
			this.cChose.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.cChose.Width = 30;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
			this.cStt.HeaderText = "STT";
			this.cStt.Name = "cStt";
			this.cStt.ReadOnly = true;
			this.cStt.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.cStt.Width = 35;
			this.cId.HeaderText = "Id";
			this.cId.Name = "cId";
			this.cId.ReadOnly = true;
			this.cId.Visible = false;
			this.cId.Width = 90;
			this.cThuMuc.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cThuMuc.HeaderText = "Thư mục";
			this.cThuMuc.Name = "cThuMuc";
			this.cThuMuc.ReadOnly = true;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkBox1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBox1.Location = new global::System.Drawing.Point(25, 45);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(15, 14);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Click += new global::System.EventHandler(this.checkBox1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(317, 322);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.dtgvAcc);
			base.Controls.Add(this.lblCountChoose);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.lblCountTotal);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fChonThuMuc";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fClearProfile_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000432 RID: 1074
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000433 RID: 1075
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000434 RID: 1076
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000435 RID: 1077
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000436 RID: 1078
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000437 RID: 1079
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000438 RID: 1080
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000439 RID: 1081
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400043A RID: 1082
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400043B RID: 1083
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400043C RID: 1084
		private global::System.Windows.Forms.Label lblCountTotal;

		// Token: 0x0400043D RID: 1085
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400043E RID: 1086
		private global::System.Windows.Forms.Label lblCountChoose;

		// Token: 0x0400043F RID: 1087
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000440 RID: 1088
		public global::System.Windows.Forms.DataGridView dtgvAcc;

		// Token: 0x04000441 RID: 1089
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000442 RID: 1090
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn cChose;

		// Token: 0x04000443 RID: 1091
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x04000444 RID: 1092
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x04000445 RID: 1093
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cThuMuc;
	}
}
