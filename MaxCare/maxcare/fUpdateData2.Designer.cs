namespace maxcare
{
	// Token: 0x0200009F RID: 159
	public partial class fUpdateData2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x0008B480 File Offset: 0x00089680
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0008B4E0 File Offset: 0x000896E0
		private void InitializeComponent()
		{
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbbTypeUpdate = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTypeProxy = new System.Windows.Forms.ComboBox();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(416, 38);
            this.bunifuCards1.TabIndex = 12;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(416, 32);
            this.pnlHeader.TabIndex = 9;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(382, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
  
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(416, 32);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbTypeUpdate
            // 
            this.cbbTypeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeUpdate.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbbTypeUpdate.FormattingEnabled = true;
            this.cbbTypeUpdate.ItemHeight = 19;
            this.cbbTypeUpdate.Items.AddRange(new object[] {
            "Token",
            "Cookie",
            "Password",
            "Mail|pass",
            "PassMail",
            "2FA",
            "Birthday",
            "Useragent",
            "Proxy",
            "Notes"});
            this.cbbTypeUpdate.Location = new System.Drawing.Point(146, 43);
            this.cbbTypeUpdate.Name = "cbbTypeUpdate";
            this.cbbTypeUpdate.Size = new System.Drawing.Size(238, 25);
            this.cbbTypeUpdate.TabIndex = 13;
            this.cbbTypeUpdate.UseSelectable = true;
   
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dữ liệu cập nhật:";
            // 
            // txbData
            // 
            this.txbData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(146, 79);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(238, 23);
            this.txbData.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhập dữ liệu:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(209, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
         
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(229)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(111, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 29);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = false;
        
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Loại proxy:";
            // 
            // cbbTypeProxy
            // 
            this.cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeProxy.FormattingEnabled = true;
            this.cbbTypeProxy.Items.AddRange(new object[] {
            "HTTP",
            "Sock5"});
            this.cbbTypeProxy.Location = new System.Drawing.Point(146, 108);
            this.cbbTypeProxy.Name = "cbbTypeProxy";
            this.cbbTypeProxy.Size = new System.Drawing.Size(130, 24);
            this.cbbTypeProxy.TabIndex = 124;
            // 
            // fUpdateData2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 188);
            this.Controls.Add(this.cbbTypeProxy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTypeUpdate);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fUpdateData2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fUpdateData";
       
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400058C RID: 1420
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400058D RID: 1421
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400058E RID: 1422
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400058F RID: 1423
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000590 RID: 1424
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000591 RID: 1425
		private global::MetroFramework.Controls.MetroComboBox cbbTypeUpdate;

		// Token: 0x04000592 RID: 1426
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000593 RID: 1427
		private global::System.Windows.Forms.TextBox txbData;

		// Token: 0x04000594 RID: 1428
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000595 RID: 1429
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000596 RID: 1430
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000597 RID: 1431
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000598 RID: 1432
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000599 RID: 1433
		private global::System.Windows.Forms.ComboBox cbbTypeProxy;
	}
}
