namespace maxcare
{
	// Token: 0x02000091 RID: 145
	public partial class fDanhSachChuDe : global::System.Windows.Forms.Form
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0007AD4C File Offset: 0x00078F4C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0007ADAC File Offset: 0x00078FAC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCountChuDe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvChuDe = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuDe)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(0, 47);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 317);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards2.Controls.Add(this.pnlHeader);
            this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(327, 37);
            this.bunifuCards2.TabIndex = 43;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(327, 31);
            this.pnlHeader.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(296, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 77;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(899, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(327, 31);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Danh sách chủ đề";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblCountChuDe);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvChuDe);
            this.groupBox2.Location = new System.Drawing.Point(6, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(311, 269);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chủ đề";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // lblCountChuDe
            // 
            this.lblCountChuDe.AutoSize = true;
            this.lblCountChuDe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCountChuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblCountChuDe.Location = new System.Drawing.Point(273, 248);
            this.lblCountChuDe.Name = "lblCountChuDe";
            this.lblCountChuDe.Size = new System.Drawing.Size(15, 16);
            this.lblCountChuDe.TabIndex = 78;
            this.lblCountChuDe.Text = "0";
            this.lblCountChuDe.Click += new System.EventHandler(this.lblCountChuDe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(231, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 79;
            this.label7.Text = "Tổng:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvChuDe
            // 
            this.dgvChuDe.AllowUserToAddRows = false;
            this.dgvChuDe.AllowUserToDeleteRows = false;
            this.dgvChuDe.AllowUserToResizeRows = false;
            this.dgvChuDe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChuDe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChuDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuDe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.dgvChuDe.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvChuDe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChuDe.Location = new System.Drawing.Point(9, 23);
            this.dgvChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvChuDe.MultiSelect = false;
            this.dgvChuDe.Name = "dgvChuDe";
            this.dgvChuDe.RowHeadersVisible = false;
            this.dgvChuDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuDe.Size = new System.Drawing.Size(293, 221);
            this.dgvChuDe.TabIndex = 76;
            this.dgvChuDe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuDe_CellContentClick);
            this.dgvChuDe.Click += new System.EventHandler(this.dgvChuDe_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên chủ đề";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.tảiLạiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 92);
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm chủ đề";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sửaToolStripMenuItem.Text = "Sửa tên chủ đề";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.xóaToolStripMenuItem.Text = "Xóa chủ đề";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.tảiLạiToolStripMenuItem.Text = "Làm mới danh sách";
            this.tảiLạiToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiToolStripMenuItem_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // fDanhSachChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fDanhSachChuDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.fDanhSachChuDe_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuDe)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040004BF RID: 1215
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040004C0 RID: 1216
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040004C1 RID: 1217
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040004C2 RID: 1218
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040004C3 RID: 1219
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x040004C4 RID: 1220
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040004C5 RID: 1221
		public global::System.Windows.Forms.DataGridView dgvChuDe;

		// Token: 0x040004C6 RID: 1222
		private global::System.Windows.Forms.Label lblCountChuDe;

		// Token: 0x040004C7 RID: 1223
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040004C8 RID: 1224
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x040004C9 RID: 1225
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040004CA RID: 1226
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040004CB RID: 1227
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040004CC RID: 1228
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040004CD RID: 1229
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040004CE RID: 1230
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x040004CF RID: 1231
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x040004D0 RID: 1232
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040004D1 RID: 1233
		private global::System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;

		// Token: 0x040004D2 RID: 1234
		private global::System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;

		// Token: 0x040004D3 RID: 1235
		private global::System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;

		// Token: 0x040004D4 RID: 1236
		private global::System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
	}
}
