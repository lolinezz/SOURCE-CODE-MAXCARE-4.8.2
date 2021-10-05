namespace maxcare
{
	// Token: 0x02000070 RID: 112
	public partial class fEditFile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00055B8C File Offset: 0x00053D8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00055BEC File Offset: 0x00053DEC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fEditFile));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.txtNameFileOld = new global::MetroFramework.Controls.MetroTextBox();
			this.txtNameFileNew = new global::MetroFramework.Controls.MetroTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(396, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(396, 32);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(4, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 77;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Location = new global::System.Drawing.Point(362, -2);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(396, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Cập nhật Tên thư mục";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(204, 138);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(100, 138);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Cập nhật";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label1.Location = new global::System.Drawing.Point(33, 69);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(103, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Tên thư mục cũ:";
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.txtNameFileOld.CustomButton.Image = null;
			this.txtNameFileOld.CustomButton.Location = new global::System.Drawing.Point(187, 1);
			this.txtNameFileOld.CustomButton.Name = "";
			this.txtNameFileOld.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.txtNameFileOld.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.txtNameFileOld.CustomButton.TabIndex = 1;
			this.txtNameFileOld.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.txtNameFileOld.CustomButton.UseSelectable = true;
			this.txtNameFileOld.CustomButton.Visible = false;
			this.txtNameFileOld.Enabled = false;
			this.txtNameFileOld.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.txtNameFileOld.Lines = new string[0];
			this.txtNameFileOld.Location = new global::System.Drawing.Point(150, 66);
			this.txtNameFileOld.MaxLength = 32767;
			this.txtNameFileOld.Name = "txtNameFileOld";
			this.txtNameFileOld.PasswordChar = '\0';
			this.txtNameFileOld.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.txtNameFileOld.SelectedText = "";
			this.txtNameFileOld.SelectionLength = 0;
			this.txtNameFileOld.SelectionStart = 0;
			this.txtNameFileOld.ShortcutsEnabled = true;
			this.txtNameFileOld.Size = new global::System.Drawing.Size(209, 23);
			this.txtNameFileOld.TabIndex = 2;
			this.txtNameFileOld.UseSelectable = true;
			this.txtNameFileOld.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtNameFileOld.WaterMarkFont = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNameFileOld.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txbNameFile_KeyDown);
			this.txtNameFileNew.CustomButton.Image = null;
			this.txtNameFileNew.CustomButton.Location = new global::System.Drawing.Point(187, 1);
			this.txtNameFileNew.CustomButton.Name = "";
			this.txtNameFileNew.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.txtNameFileNew.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.txtNameFileNew.CustomButton.TabIndex = 1;
			this.txtNameFileNew.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.txtNameFileNew.CustomButton.UseSelectable = true;
			this.txtNameFileNew.CustomButton.Visible = false;
			this.txtNameFileNew.Lines = new string[0];
			this.txtNameFileNew.Location = new global::System.Drawing.Point(150, 95);
			this.txtNameFileNew.MaxLength = 32767;
			this.txtNameFileNew.Name = "txtNameFileNew";
			this.txtNameFileNew.PasswordChar = '\0';
			this.txtNameFileNew.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.txtNameFileNew.SelectedText = "";
			this.txtNameFileNew.SelectionLength = 0;
			this.txtNameFileNew.SelectionStart = 0;
			this.txtNameFileNew.ShortcutsEnabled = true;
			this.txtNameFileNew.Size = new global::System.Drawing.Size(209, 23);
			this.txtNameFileNew.TabIndex = 2;
			this.txtNameFileNew.UseSelectable = true;
			this.txtNameFileNew.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.txtNameFileNew.WaterMarkFont = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNameFileNew.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txbNameFile_KeyDown);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label2.Location = new global::System.Drawing.Point(33, 98);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(111, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Tên thư mục mới:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(396, 182);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.txtNameFileNew);
			base.Controls.Add(this.txtNameFileOld);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fEditFile";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			base.Load += new global::System.EventHandler(this.fEditFile_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400033E RID: 830
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400033F RID: 831
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000341 RID: 833
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000346 RID: 838
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000347 RID: 839
		private global::MetroFramework.Controls.MetroTextBox txtNameFileOld;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000349 RID: 841
		private global::MetroFramework.Controls.MetroTextBox txtNameFileNew;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Forms.Label label2;
	}
}
