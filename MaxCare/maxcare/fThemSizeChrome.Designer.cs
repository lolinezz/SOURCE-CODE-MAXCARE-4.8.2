namespace maxcare
{
	// Token: 0x020000E0 RID: 224
	public partial class fThemSizeChrome : global::System.Windows.Forms.Form
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x00116C00 File Offset: 0x00114E00
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00116C60 File Offset: 0x00114E60
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPixelRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grChiTiet = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPixelRatio = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).BeginInit();
            this.grChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bunifuCards1.Size = new System.Drawing.Size(415, 47);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grDanhSach);
            this.panel1.Controls.Add(this.grChiTiet);
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 388);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dtgvDanhSach);
            this.grDanhSach.Controls.Add(this.btnAdd);
            this.grDanhSach.Location = new System.Drawing.Point(3, 43);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Size = new System.Drawing.Size(473, 339);
            this.grDanhSach.TabIndex = 50;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách Kích thước Chrome";
            // 
            // dtgvDanhSach
            // 
            this.dtgvDanhSach.AllowUserToAddRows = false;
            this.dtgvDanhSach.AllowUserToDeleteRows = false;
            this.dtgvDanhSach.AllowUserToResizeRows = false;
            this.dtgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.cName,
            this.cSize,
            this.cPixelRatio,
            this.cSua,
            this.cXoa});
            this.dtgvDanhSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvDanhSach.Location = new System.Drawing.Point(6, 22);
            this.dtgvDanhSach.Name = "dtgvDanhSach";
            this.dtgvDanhSach.RowHeadersVisible = false;
            this.dtgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSach.Size = new System.Drawing.Size(461, 277);
            this.dtgvDanhSach.TabIndex = 76;
            this.dtgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellClick);
            this.dtgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellContentClick);
            this.dtgvDanhSach.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellMouseEnter);
            // 
            // cSTT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSTT.DefaultCellStyle = dataGridViewCellStyle2;
            this.cSTT.HeaderText = "STT";
            this.cSTT.Name = "cSTT";
            this.cSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSTT.Width = 40;
            // 
            // cName
            // 
            this.cName.HeaderText = "Tên";
            this.cName.Name = "cName";
            this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cSize
            // 
            this.cSize.HeaderText = "Kích thước";
            this.cSize.Name = "cSize";
            this.cSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSize.Width = 80;
            // 
            // cPixelRatio
            // 
            this.cPixelRatio.HeaderText = "Pixel Ratio";
            this.cPixelRatio.Name = "cPixelRatio";
            this.cPixelRatio.Width = 90;
            // 
            // cSua
            // 
            this.cSua.HeaderText = "Sửa";
            this.cSua.Name = "cSua";
            this.cSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSua.Width = 71;
            // 
            // cXoa
            // 
            this.cXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cXoa.HeaderText = "Xóa";
            this.cXoa.Name = "cXoa";
            this.cXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(375, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // grChiTiet
            // 
            this.grChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grChiTiet.Controls.Add(this.nudHeight);
            this.grChiTiet.Controls.Add(this.nudWidth);
            this.grChiTiet.Controls.Add(this.label11);
            this.grChiTiet.Controls.Add(this.txtPixelRatio);
            this.grChiTiet.Controls.Add(this.txtTen);
            this.grChiTiet.Controls.Add(this.label3);
            this.grChiTiet.Controls.Add(this.label2);
            this.grChiTiet.Controls.Add(this.label1);
            this.grChiTiet.Controls.Add(this.btnHuy);
            this.grChiTiet.Controls.Add(this.btnSave);
            this.grChiTiet.Enabled = false;
            this.grChiTiet.Location = new System.Drawing.Point(482, 44);
            this.grChiTiet.Name = "grChiTiet";
            this.grChiTiet.Size = new System.Drawing.Size(256, 177);
            this.grChiTiet.TabIndex = 50;
            this.grChiTiet.TabStop = false;
            this.grChiTiet.Text = "Chi tiết";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(181, 64);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(59, 23);
            this.nudHeight.TabIndex = 49;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(95, 64);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(59, 23);
            this.nudWidth.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(156, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 23);
            this.label11.TabIndex = 48;
            this.label11.Text = "X";
            // 
            // txtPixelRatio
            // 
            this.txtPixelRatio.Location = new System.Drawing.Point(95, 96);
            this.txtPixelRatio.Name = "txtPixelRatio";
            this.txtPixelRatio.Size = new System.Drawing.Size(59, 23);
            this.txtPixelRatio.TabIndex = 47;
            this.txtPixelRatio.Text = "3";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(95, 29);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(145, 23);
            this.txtTen.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Pixel Ratio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Kích thước:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tên:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(148, 136);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 29);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(47, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.bunifuCards2.Size = new System.Drawing.Size(742, 37);
            this.bunifuCards2.TabIndex = 43;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.button2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(742, 31);
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
            this.button2.Location = new System.Drawing.Point(711, 1);
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
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(742, 31);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Danh sách Kích thước Chrome";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblTitle;
            this.bunifuDragControl1.Vertical = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // fThemSizeChrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThemSizeChrome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.FConfigGenneral_Load);
            this.panel1.ResumeLayout(false);
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).EndInit();
            this.grChiTiet.ResumeLayout(false);
            this.grChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000C7E RID: 3198
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C7F RID: 3199
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000C80 RID: 3200
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000C81 RID: 3201
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000C82 RID: 3202
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000C83 RID: 3203
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000C84 RID: 3204
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000C85 RID: 3205
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000C86 RID: 3206
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000C87 RID: 3207
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000C88 RID: 3208
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblTitle;

		// Token: 0x04000C89 RID: 3209
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000C8A RID: 3210
		private global::System.Windows.Forms.GroupBox grDanhSach;

		// Token: 0x04000C8B RID: 3211
		private global::System.Windows.Forms.GroupBox grChiTiet;

		// Token: 0x04000C8C RID: 3212
		public global::System.Windows.Forms.DataGridView dtgvDanhSach;

		// Token: 0x04000C8D RID: 3213
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000C8E RID: 3214
		private global::System.Windows.Forms.Button btnHuy;

		// Token: 0x04000C8F RID: 3215
		private global::System.Windows.Forms.TextBox txtTen;

		// Token: 0x04000C90 RID: 3216
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000C91 RID: 3217
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000C92 RID: 3218
		private global::System.Windows.Forms.NumericUpDown nudHeight;

		// Token: 0x04000C93 RID: 3219
		private global::System.Windows.Forms.NumericUpDown nudWidth;

		// Token: 0x04000C94 RID: 3220
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000C95 RID: 3221
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000C96 RID: 3222
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cSTT;

		// Token: 0x04000C97 RID: 3223
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cName;

		// Token: 0x04000C98 RID: 3224
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cSize;

		// Token: 0x04000C99 RID: 3225
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPixelRatio;

		// Token: 0x04000C9A RID: 3226
		private global::System.Windows.Forms.DataGridViewButtonColumn cSua;

		// Token: 0x04000C9B RID: 3227
		private global::System.Windows.Forms.DataGridViewButtonColumn cXoa;

		// Token: 0x04000C9C RID: 3228
		private global::System.Windows.Forms.TextBox txtPixelRatio;
	}
}
