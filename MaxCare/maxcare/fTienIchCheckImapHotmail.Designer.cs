namespace maxcare
{
	// Token: 0x020000DB RID: 219
	public partial class fTienIchCheckImapHotmail : global::System.Windows.Forms.Form
	{
		// Token: 0x060008DB RID: 2267 RVA: 0x001123A0 File Offset: 0x001105A0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00112400 File Offset: 0x00110600
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.grChuaTao = new global::System.Windows.Forms.GroupBox();
			this.txtChuaTao = new global::System.Windows.Forms.RichTextBox();
			this.grDaTao = new global::System.Windows.Forms.GroupBox();
			this.txtDaTao = new global::System.Windows.Forms.RichTextBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnNhapTuFile = new global::MetroFramework.Controls.MetroButton();
			this.txtInput = new global::System.Windows.Forms.RichTextBox();
			this.txtNhapTuFile = new global::System.Windows.Forms.TextBox();
			this.rbTuNhap = new global::System.Windows.Forms.RadioButton();
			this.rbNhapTuFile = new global::System.Windows.Forms.RadioButton();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards2 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.lblTitle = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.grChuaTao.SuspendLayout();
			this.grDaTao.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.bunifuCards2.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(466, 47);
			this.bunifuCards1.TabIndex = 12;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.grChuaTao);
			this.panel1.Controls.Add(this.grDaTao);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(795, 404);
			this.panel1.TabIndex = 37;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.lblStatus.AutoSize = true;
			this.lblStatus.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.lblStatus.Location = new global::System.Drawing.Point(480, 59);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(71, 16);
			this.lblStatus.TabIndex = 52;
			this.lblStatus.Text = "Checking...";
			this.lblStatus.Visible = false;
			this.grChuaTao.Controls.Add(this.txtChuaTao);
			this.grChuaTao.ForeColor = global::System.Drawing.Color.DarkRed;
			this.grChuaTao.Location = new global::System.Drawing.Point(566, 91);
			this.grChuaTao.Name = "grChuaTao";
			this.grChuaTao.Size = new global::System.Drawing.Size(221, 307);
			this.grChuaTao.TabIndex = 51;
			this.grChuaTao.TabStop = false;
			this.grChuaTao.Text = "Die (0)";
			this.txtChuaTao.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtChuaTao.Location = new global::System.Drawing.Point(3, 19);
			this.txtChuaTao.Name = "txtChuaTao";
			this.txtChuaTao.Size = new global::System.Drawing.Size(215, 285);
			this.txtChuaTao.TabIndex = 50;
			this.txtChuaTao.Text = "";
			this.txtChuaTao.WordWrap = false;
			this.txtChuaTao.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
			this.grDaTao.Controls.Add(this.txtDaTao);
			this.grDaTao.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.grDaTao.Location = new global::System.Drawing.Point(339, 91);
			this.grDaTao.Name = "grDaTao";
			this.grDaTao.Size = new global::System.Drawing.Size(221, 307);
			this.grDaTao.TabIndex = 51;
			this.grDaTao.TabStop = false;
			this.grDaTao.Text = "Live (0)";
			this.txtDaTao.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtDaTao.Location = new global::System.Drawing.Point(3, 19);
			this.txtDaTao.Name = "txtDaTao";
			this.txtDaTao.Size = new global::System.Drawing.Size(215, 285);
			this.txtDaTao.TabIndex = 50;
			this.txtDaTao.Text = "";
			this.txtDaTao.WordWrap = false;
			this.txtDaTao.TextChanged += new global::System.EventHandler(this.txtOutput_TextChanged);
			this.groupBox1.Controls.Add(this.btnNhapTuFile);
			this.groupBox1.Controls.Add(this.txtInput);
			this.groupBox1.Controls.Add(this.txtNhapTuFile);
			this.groupBox1.Controls.Add(this.rbTuNhap);
			this.groupBox1.Controls.Add(this.rbNhapTuFile);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(316, 358);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input: Email|Pass mail hoặc Email|Pass mail|Imap";
			this.btnNhapTuFile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnNhapTuFile.Location = new global::System.Drawing.Point(243, 22);
			this.btnNhapTuFile.Name = "btnNhapTuFile";
			this.btnNhapTuFile.Size = new global::System.Drawing.Size(64, 24);
			this.btnNhapTuFile.TabIndex = 2;
			this.btnNhapTuFile.Text = "Chọn";
			this.btnNhapTuFile.UseSelectable = true;
			this.btnNhapTuFile.Click += new global::System.EventHandler(this.btnNhapTuFile_Click);
			this.txtInput.Location = new global::System.Drawing.Point(30, 75);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new global::System.Drawing.Size(277, 277);
			this.txtInput.TabIndex = 50;
			this.txtInput.Text = "";
			this.txtInput.WordWrap = false;
			this.txtInput.TextChanged += new global::System.EventHandler(this.TxtComment_TextChanged);
			this.txtNhapTuFile.Location = new global::System.Drawing.Point(110, 22);
			this.txtNhapTuFile.Name = "txtNhapTuFile";
			this.txtNhapTuFile.Size = new global::System.Drawing.Size(127, 23);
			this.txtNhapTuFile.TabIndex = 1;
			this.rbTuNhap.AutoSize = true;
			this.rbTuNhap.Checked = true;
			this.rbTuNhap.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbTuNhap.Location = new global::System.Drawing.Point(9, 49);
			this.rbTuNhap.Name = "rbTuNhap";
			this.rbTuNhap.Size = new global::System.Drawing.Size(95, 20);
			this.rbTuNhap.TabIndex = 0;
			this.rbTuNhap.TabStop = true;
			this.rbTuNhap.Text = "Tự nhập (0)";
			this.rbTuNhap.UseVisualStyleBackColor = true;
			this.rbTuNhap.CheckedChanged += new global::System.EventHandler(this.rbTuNhap_CheckedChanged);
			this.rbNhapTuFile.AutoSize = true;
			this.rbNhapTuFile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNhapTuFile.Location = new global::System.Drawing.Point(9, 23);
			this.rbNhapTuFile.Name = "rbNhapTuFile";
			this.rbNhapTuFile.Size = new global::System.Drawing.Size(95, 20);
			this.rbNhapTuFile.TabIndex = 0;
			this.rbNhapTuFile.Text = "Nhập từ File";
			this.rbNhapTuFile.UseVisualStyleBackColor = true;
			this.rbNhapTuFile.CheckedChanged += new global::System.EventHandler(this.radioButton1_CheckedChanged);
			this.btnAdd.BackColor = global::System.Drawing.Color.Green;
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(339, 49);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(135, 36);
			this.btnAdd.TabIndex = 45;
			this.btnAdd.Text = "Check";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
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
			this.bunifuCards2.Size = new global::System.Drawing.Size(793, 37);
			this.bunifuCards2.TabIndex = 43;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.lblTitle);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(793, 31);
			this.pnlHeader.TabIndex = 9;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(762, 1);
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
			this.lblTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTitle.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.lblTitle.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.Black;
			this.lblTitle.Location = new global::System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(793, 31);
			this.lblTitle.TabIndex = 12;
			this.lblTitle.Text = "Check có thể kết nối Email bằng Imap không?";
			this.lblTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.lblTitle;
			this.bunifuDragControl1.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(795, 404);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.bunifuCards1);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fTienIchCheckImapHotmail";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cấu hình chung";
			base.Load += new global::System.EventHandler(this.fTienIchLocTrung_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.grChuaTao.ResumeLayout(false);
			this.grDaTao.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.bunifuCards2.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C4C RID: 3148
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000C4D RID: 3149
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000C4E RID: 3150
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000C4F RID: 3151
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000C50 RID: 3152
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000C51 RID: 3153
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000C52 RID: 3154
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000C53 RID: 3155
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000C54 RID: 3156
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000C55 RID: 3157
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000C56 RID: 3158
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblTitle;

		// Token: 0x04000C57 RID: 3159
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000C58 RID: 3160
		private global::System.Windows.Forms.RichTextBox txtInput;

		// Token: 0x04000C59 RID: 3161
		private global::System.Windows.Forms.GroupBox grDaTao;

		// Token: 0x04000C5A RID: 3162
		private global::System.Windows.Forms.RichTextBox txtDaTao;

		// Token: 0x04000C5B RID: 3163
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000C5C RID: 3164
		private global::MetroFramework.Controls.MetroButton btnNhapTuFile;

		// Token: 0x04000C5D RID: 3165
		private global::System.Windows.Forms.TextBox txtNhapTuFile;

		// Token: 0x04000C5E RID: 3166
		private global::System.Windows.Forms.RadioButton rbTuNhap;

		// Token: 0x04000C5F RID: 3167
		private global::System.Windows.Forms.RadioButton rbNhapTuFile;

		// Token: 0x04000C60 RID: 3168
		private global::System.Windows.Forms.GroupBox grChuaTao;

		// Token: 0x04000C61 RID: 3169
		private global::System.Windows.Forms.RichTextBox txtChuaTao;

		// Token: 0x04000C62 RID: 3170
		private global::System.Windows.Forms.Label lblStatus;
	}
}
