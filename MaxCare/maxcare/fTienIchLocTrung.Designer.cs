namespace maxcare
{
	// Token: 0x020000DF RID: 223
	public partial class fTienIchLocTrung : global::System.Windows.Forms.Form
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x00114478 File Offset: 0x00112678
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x001144D8 File Offset: 0x001126D8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhapTuFile = new MetroFramework.Controls.MetroButton();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtNhapTuFile = new System.Windows.Forms.TextBox();
            this.rbTuNhap = new System.Windows.Forms.RadioButton();
            this.rbNhapTuFile = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.bunifuCards1.Size = new System.Drawing.Size(509, 47);
            this.bunifuCards1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bunifuCards2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 270);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(469, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 223);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output (0)";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 22);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(349, 194);
            this.txtOutput.TabIndex = 50;
            this.txtOutput.Text = "";
            this.txtOutput.WordWrap = false;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNhapTuFile);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.txtNhapTuFile);
            this.groupBox1.Controls.Add(this.rbTuNhap);
            this.groupBox1.Controls.Add(this.rbNhapTuFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 223);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnNhapTuFile
            // 
            this.btnNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapTuFile.Location = new System.Drawing.Point(287, 22);
            this.btnNhapTuFile.Name = "btnNhapTuFile";
            this.btnNhapTuFile.Size = new System.Drawing.Size(65, 24);
            this.btnNhapTuFile.TabIndex = 2;
            this.btnNhapTuFile.Text = "Chọn";
            this.btnNhapTuFile.UseSelectable = true;
            this.btnNhapTuFile.Click += new System.EventHandler(this.btnNhapTuFile_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 75);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(322, 141);
            this.txtInput.TabIndex = 50;
            this.txtInput.Text = "";
            this.txtInput.WordWrap = false;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtComment_TextChanged);
            // 
            // txtNhapTuFile
            // 
            this.txtNhapTuFile.Location = new System.Drawing.Point(110, 22);
            this.txtNhapTuFile.Name = "txtNhapTuFile";
            this.txtNhapTuFile.Size = new System.Drawing.Size(171, 23);
            this.txtNhapTuFile.TabIndex = 1;
            // 
            // rbTuNhap
            // 
            this.rbTuNhap.AutoSize = true;
            this.rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTuNhap.Location = new System.Drawing.Point(9, 49);
            this.rbTuNhap.Name = "rbTuNhap";
            this.rbTuNhap.Size = new System.Drawing.Size(94, 20);
            this.rbTuNhap.TabIndex = 0;
            this.rbTuNhap.Text = "Tự nhập (0)";
            this.rbTuNhap.UseVisualStyleBackColor = true;
            this.rbTuNhap.CheckedChanged += new System.EventHandler(this.rbTuNhap_CheckedChanged);
            // 
            // rbNhapTuFile
            // 
            this.rbNhapTuFile.AutoSize = true;
            this.rbNhapTuFile.Checked = true;
            this.rbNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNhapTuFile.Location = new System.Drawing.Point(9, 23);
            this.rbNhapTuFile.Name = "rbNhapTuFile";
            this.rbNhapTuFile.Size = new System.Drawing.Size(94, 20);
            this.rbNhapTuFile.TabIndex = 0;
            this.rbNhapTuFile.TabStop = true;
            this.rbNhapTuFile.Text = "Nhập từ File";
            this.rbNhapTuFile.UseVisualStyleBackColor = true;
            this.rbNhapTuFile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(379, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 29);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Start";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.bunifuCards2.Size = new System.Drawing.Size(836, 37);
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
            this.pnlHeader.Size = new System.Drawing.Size(836, 31);
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
            this.button2.Location = new System.Drawing.Point(805, 1);
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
            this.lblTitle.Size = new System.Drawing.Size(836, 31);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Lọc trùng dữ liệu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // fTienIchLocTrung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTienIchLocTrung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình chung";
            this.Load += new System.EventHandler(this.fTienIchLocTrung_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		// Token: 0x04000C69 RID: 3177
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C6A RID: 3178
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000C6B RID: 3179
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000C6C RID: 3180
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000C6D RID: 3181
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000C6E RID: 3182
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000C6F RID: 3183
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000C70 RID: 3184
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000C71 RID: 3185
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000C72 RID: 3186
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000C73 RID: 3187
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblTitle;

		// Token: 0x04000C74 RID: 3188
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000C75 RID: 3189
		private global::System.Windows.Forms.RichTextBox txtInput;

		// Token: 0x04000C76 RID: 3190
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000C77 RID: 3191
		private global::System.Windows.Forms.RichTextBox txtOutput;

		// Token: 0x04000C78 RID: 3192
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000C79 RID: 3193
		private global::MetroFramework.Controls.MetroButton btnNhapTuFile;

		// Token: 0x04000C7A RID: 3194
		private global::System.Windows.Forms.TextBox txtNhapTuFile;

		// Token: 0x04000C7B RID: 3195
		private global::System.Windows.Forms.RadioButton rbTuNhap;

		// Token: 0x04000C7C RID: 3196
		private global::System.Windows.Forms.RadioButton rbNhapTuFile;
	}
}
