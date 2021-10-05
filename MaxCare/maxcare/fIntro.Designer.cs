namespace maxcare
{
	// Token: 0x020000F9 RID: 249
	public partial class fIntro : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x0014D038 File Offset: 0x0014B238
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0014D098 File Offset: 0x0014B298
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIntro));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar.Location = new System.Drawing.Point(38, 506);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(723, 23);
            this.progressBar.Step = 50;
            this.progressBar.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(611, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đang kiểm tra thông tin...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(235, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Liên hệ code tool theo yêu cầu:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.linkLabel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(266, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 65);
            this.panel3.TabIndex = 16;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(94, 32);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(180, 25);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "http://bit.ly/MINSoft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotline:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fanpage:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(94, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "035.839.4040";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(235, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Liên hệ hỗ trợ phần mềm:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(266, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 95);
            this.panel2.TabIndex = 17;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(94, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 25);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://minsoftware.vn/";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(94, 63);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(180, 25);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://bit.ly/MINSoft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Website:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hotline:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fanpage:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(94, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "0969.078.803";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(235, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(526, 77);
            this.label12.TabIndex = 20;
            this.label12.Text = "Chú ý: Ngiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố" +
    " tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trướ" +
    "c pháp luật.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(9, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(77, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(801, 541);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fIntro";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra thông tin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Intro_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000E5B RID: 3675
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000E5C RID: 3676
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000E5D RID: 3677
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000E5E RID: 3678
		private global::MetroFramework.Controls.MetroProgressBar progressBar;

		// Token: 0x04000E5F RID: 3679
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000E60 RID: 3680
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x04000E61 RID: 3681
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000E62 RID: 3682
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000E63 RID: 3683
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000E64 RID: 3684
		private global::System.Windows.Forms.LinkLabel linkLabel4;

		// Token: 0x04000E65 RID: 3685
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000E66 RID: 3686
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000E67 RID: 3687
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000E68 RID: 3688
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000E69 RID: 3689
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000E6A RID: 3690
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000E6B RID: 3691
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x04000E6C RID: 3692
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000E6D RID: 3693
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000E6E RID: 3694
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000E6F RID: 3695
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000E70 RID: 3696
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000E71 RID: 3697
		private global::System.Windows.Forms.Label label12;
	}
}
