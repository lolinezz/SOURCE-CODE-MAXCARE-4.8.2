namespace maxcare
{
	// Token: 0x02000180 RID: 384
	public partial class fUpdateData : global::System.Windows.Forms.Form
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x002BDE54 File Offset: 0x002BC054
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x002BDEB4 File Offset: 0x002BC0B4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fUpdateData));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.cbbTypeUpdate = new global::MetroFramework.Controls.MetroComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txbData = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.cbbTypeProxy = new global::System.Windows.Forms.ComboBox();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(416, 38);
			this.bunifuCards1.TabIndex = 12;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(416, 32);
			this.pnlHeader.TabIndex = 9;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnMinimize.Image");
			this.btnMinimize.Location = new global::System.Drawing.Point(382, -1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 32);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 79;
			this.pictureBox1.TabStop = false;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(416, 32);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.cbbTypeUpdate.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbTypeUpdate.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbTypeUpdate.FormattingEnabled = true;
			this.cbbTypeUpdate.ItemHeight = 19;
			this.cbbTypeUpdate.Items.AddRange(new object[]
			{
				"Token",
				"Cookie",
				"Password",
				"Mail|pass",
				"PassMail",
				"2FA",
				"Birthday",
				"Useragent",
				"Proxy",
				"Notes"
			});
			this.cbbTypeUpdate.Location = new global::System.Drawing.Point(146, 43);
			this.cbbTypeUpdate.Name = "cbbTypeUpdate";
			this.cbbTypeUpdate.Size = new global::System.Drawing.Size(238, 25);
			this.cbbTypeUpdate.TabIndex = 13;
			this.cbbTypeUpdate.UseSelectable = true;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(34, 51);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(106, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Dữ liệu cập nhật:";
			this.txbData.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txbData.Location = new global::System.Drawing.Point(146, 79);
			this.txbData.Name = "txbData";
			this.txbData.Size = new global::System.Drawing.Size(238, 23);
			this.txbData.TabIndex = 15;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(34, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(85, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Nhập dữ liệu:";
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(209, 145);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(111, 145);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "Lưu";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(34, 111);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(71, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Loại proxy:";
			this.cbbTypeProxy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbTypeProxy.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbTypeProxy.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cbbTypeProxy.FormattingEnabled = true;
			this.cbbTypeProxy.Items.AddRange(new object[]
			{
				"HTTP",
				"Sock5"
			});
			this.cbbTypeProxy.Location = new global::System.Drawing.Point(146, 108);
			this.cbbTypeProxy.Name = "cbbTypeProxy";
			this.cbbTypeProxy.Size = new global::System.Drawing.Size(130, 24);
			this.cbbTypeProxy.TabIndex = 124;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(416, 188);
			base.Controls.Add(this.cbbTypeProxy);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.txbData);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cbbTypeUpdate);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fUpdateData";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fUpdateData";
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001A9A RID: 6810
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001A9B RID: 6811
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001A9C RID: 6812
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001A9D RID: 6813
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001A9E RID: 6814
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04001A9F RID: 6815
		private global::MetroFramework.Controls.MetroComboBox cbbTypeUpdate;

		// Token: 0x04001AA0 RID: 6816
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001AA1 RID: 6817
		private global::System.Windows.Forms.TextBox txbData;

		// Token: 0x04001AA2 RID: 6818
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001AA3 RID: 6819
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001AA4 RID: 6820
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001AA5 RID: 6821
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001AA6 RID: 6822
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001AA7 RID: 6823
		private global::System.Windows.Forms.ComboBox cbbTypeProxy;
	}
}
