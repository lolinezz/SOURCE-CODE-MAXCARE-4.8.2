namespace maxcare
{
	// Token: 0x020000E3 RID: 227
	public partial class fCauHinhTaoShortcut : global::System.Windows.Forms.Form
	{
		// Token: 0x0600091D RID: 2333 RVA: 0x0011B930 File Offset: 0x00119B30
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0011B990 File Offset: 0x00119B90
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fCauHinhTaoShortcut));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtPathShortcut = new global::MetroFramework.Controls.MetroTextBox();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtPathChromeOrigin = new global::MetroFramework.Controls.MetroTextBox();
			this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(594, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(594, 32);
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
			this.btnMinimize.Location = new global::System.Drawing.Point(562, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 32);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(594, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Cấu hình tạo Shortcut Chrome";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(303, 139);
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
			this.btnAdd.Location = new global::System.Drawing.Point(199, 139);
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
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(33, 60);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(105, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nơi lưu Shortcut:";
			this.txtPathShortcut.CustomButton.Image = null;
			this.txtPathShortcut.CustomButton.Location = new global::System.Drawing.Point(330, 1);
			this.txtPathShortcut.CustomButton.Name = "";
			this.txtPathShortcut.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.txtPathShortcut.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.txtPathShortcut.CustomButton.TabIndex = 1;
			this.txtPathShortcut.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.txtPathShortcut.CustomButton.UseSelectable = true;
			this.txtPathShortcut.CustomButton.Visible = false;
			this.txtPathShortcut.Lines = new string[0];
			this.txtPathShortcut.Location = new global::System.Drawing.Point(157, 58);
			this.txtPathShortcut.MaxLength = 32767;
			this.txtPathShortcut.Name = "txtPathShortcut";
			this.txtPathShortcut.PasswordChar = '\0';
			this.txtPathShortcut.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.txtPathShortcut.SelectedText = "";
			this.txtPathShortcut.SelectionLength = 0;
			this.txtPathShortcut.SelectionStart = 0;
			this.txtPathShortcut.ShortcutsEnabled = true;
			this.txtPathShortcut.Size = new global::System.Drawing.Size(352, 23);
			this.txtPathShortcut.TabIndex = 6;
			this.txtPathShortcut.UseSelectable = true;
			this.txtPathShortcut.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtPathShortcut.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.metroButton1.Location = new global::System.Drawing.Point(515, 58);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(47, 24);
			this.metroButton1.TabIndex = 7;
			this.metroButton1.Text = "Chọn";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(33, 91);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(125, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Đường dẫn Chrome:";
			this.txtPathChromeOrigin.CustomButton.Image = null;
			this.txtPathChromeOrigin.CustomButton.Location = new global::System.Drawing.Point(330, 1);
			this.txtPathChromeOrigin.CustomButton.Name = "";
			this.txtPathChromeOrigin.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.txtPathChromeOrigin.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.txtPathChromeOrigin.CustomButton.TabIndex = 1;
			this.txtPathChromeOrigin.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.txtPathChromeOrigin.CustomButton.UseSelectable = true;
			this.txtPathChromeOrigin.CustomButton.Visible = false;
			this.txtPathChromeOrigin.Lines = new string[]
			{
				"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"
			};
			this.txtPathChromeOrigin.Location = new global::System.Drawing.Point(157, 89);
			this.txtPathChromeOrigin.MaxLength = 32767;
			this.txtPathChromeOrigin.Name = "txtPathChromeOrigin";
			this.txtPathChromeOrigin.PasswordChar = '\0';
			this.txtPathChromeOrigin.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.txtPathChromeOrigin.SelectedText = "";
			this.txtPathChromeOrigin.SelectionLength = 0;
			this.txtPathChromeOrigin.SelectionStart = 0;
			this.txtPathChromeOrigin.ShortcutsEnabled = true;
			this.txtPathChromeOrigin.Size = new global::System.Drawing.Size(352, 23);
			this.txtPathChromeOrigin.TabIndex = 6;
			this.txtPathChromeOrigin.Text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
			this.txtPathChromeOrigin.UseSelectable = true;
			this.txtPathChromeOrigin.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtPathChromeOrigin.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.metroButton2.Location = new global::System.Drawing.Point(515, 89);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new global::System.Drawing.Size(47, 24);
			this.metroButton2.TabIndex = 7;
			this.metroButton2.Text = "Chọn";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(594, 187);
			base.Controls.Add(this.metroButton2);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.txtPathChromeOrigin);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.txtPathShortcut);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fCauHinhTaoShortcut";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fClearProfile_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CBC RID: 3260
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000CBD RID: 3261
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000CBE RID: 3262
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000CBF RID: 3263
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000CC0 RID: 3264
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000CC1 RID: 3265
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000CC2 RID: 3266
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000CC3 RID: 3267
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000CC4 RID: 3268
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000CC5 RID: 3269
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000CC6 RID: 3270
		private global::MetroFramework.Controls.MetroTextBox txtPathShortcut;

		// Token: 0x04000CC7 RID: 3271
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04000CC8 RID: 3272
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000CC9 RID: 3273
		private global::MetroFramework.Controls.MetroTextBox txtPathChromeOrigin;

		// Token: 0x04000CCA RID: 3274
		private global::MetroFramework.Controls.MetroButton metroButton2;
	}
}
