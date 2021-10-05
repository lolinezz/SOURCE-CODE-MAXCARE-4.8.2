namespace maxcare
{
	// Token: 0x0200009E RID: 158
	public partial class fContact : global::System.Windows.Forms.Form
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x00089144 File Offset: 0x00087344
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000891A4 File Offset: 0x000873A4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fContact));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.linkLabel4 = new global::System.Windows.Forms.LinkLabel();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			base.SuspendLayout();
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(1, 0);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(808, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new global::System.Drawing.Size(808, 32);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Location = new global::System.Drawing.Point(775, -1);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(808, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Thông tin liên hệ";
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(809, 522);
			this.panel1.TabIndex = 5;
			this.label12.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.Red;
			this.label12.Location = new global::System.Drawing.Point(243, 429);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(524, 77);
			this.label12.TabIndex = 21;
			this.label12.Text = "Chú ý: Ngiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.";
			this.label12.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.FromArgb(192, 64, 0);
			this.label10.Location = new global::System.Drawing.Point(238, 335);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(274, 25);
			this.label10.TabIndex = 14;
			this.label10.Text = "Liên hệ code tool theo yêu cầu:";
			this.panel3.BackColor = global::System.Drawing.Color.White;
			this.panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.linkLabel4);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new global::System.Drawing.Point(269, 361);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(498, 65);
			this.panel3.TabIndex = 13;
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel4.Location = new global::System.Drawing.Point(94, 32);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new global::System.Drawing.Size(180, 25);
			this.linkLabel4.TabIndex = 9;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "http://bit.ly/MINSoft";
			this.linkLabel4.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.Black;
			this.label7.Location = new global::System.Drawing.Point(3, 5);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(77, 25);
			this.label7.TabIndex = 2;
			this.label7.Text = "Hotline:";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.Black;
			this.label8.Location = new global::System.Drawing.Point(3, 32);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(87, 25);
			this.label8.TabIndex = 2;
			this.label8.Text = "Fanpage:";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.Black;
			this.label9.Location = new global::System.Drawing.Point(94, 5);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(120, 25);
			this.label9.TabIndex = 2;
			this.label9.Text = "035.839.4040";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(192, 64, 0);
			this.label1.Location = new global::System.Drawing.Point(238, 211);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(228, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Liên hệ hỗ trợ phần mềm:";
			this.panel2.BackColor = global::System.Drawing.Color.White;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.linkLabel1);
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Location = new global::System.Drawing.Point(269, 237);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(498, 95);
			this.panel2.TabIndex = 13;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel1.Location = new global::System.Drawing.Point(94, 6);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(207, 25);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://minsoftware.vn/";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel2.Location = new global::System.Drawing.Point(94, 63);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new global::System.Drawing.Size(180, 25);
			this.linkLabel2.TabIndex = 9;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "http://bit.ly/MINSoft";
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Black;
			this.label3.Location = new global::System.Drawing.Point(3, 6);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(83, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Website:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Black;
			this.label4.Location = new global::System.Drawing.Point(3, 36);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(77, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Hotline:";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Black;
			this.label6.Location = new global::System.Drawing.Point(3, 63);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(87, 25);
			this.label6.TabIndex = 2;
			this.label6.Text = "Fanpage:";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Black;
			this.label5.Location = new global::System.Drawing.Point(94, 36);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(120, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "0969.078.803";
			this.pictureBox2.Location = new global::System.Drawing.Point(12, 214);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(220, 238);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			this.pictureBox3.Location = new global::System.Drawing.Point(84, 47);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(620, 130);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(809, 522);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "fContact";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "fAddFile";
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000572 RID: 1394
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000573 RID: 1395
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000574 RID: 1396
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000575 RID: 1397
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000576 RID: 1398
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000577 RID: 1399
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000578 RID: 1400
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000579 RID: 1401
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400057A RID: 1402
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400057B RID: 1403
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400057C RID: 1404
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400057D RID: 1405
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400057E RID: 1406
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400057F RID: 1407
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000580 RID: 1408
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000581 RID: 1409
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000582 RID: 1410
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000583 RID: 1411
		private global::System.Windows.Forms.LinkLabel linkLabel4;

		// Token: 0x04000584 RID: 1412
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000585 RID: 1413
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000586 RID: 1414
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000587 RID: 1415
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000588 RID: 1416
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x04000589 RID: 1417
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400058A RID: 1418
		public global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
