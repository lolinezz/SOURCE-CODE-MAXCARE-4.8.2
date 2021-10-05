namespace maxcare
{
	// Token: 0x020000A9 RID: 169
	public partial class fShowProgressBar : global::System.Windows.Forms.Form
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x00094D6C File Offset: 0x00092F6C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00094DCC File Offset: 0x00092FCC
		private void InitializeComponent()
		{
			this.lblproccess = new global::System.Windows.Forms.Label();
			this.progressBar1 = new global::MetroFramework.Controls.MetroProgressBar();
			base.SuspendLayout();
			this.lblproccess.AutoSize = true;
			this.lblproccess.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblproccess.Location = new global::System.Drawing.Point(34, 22);
			this.lblproccess.Name = "lblproccess";
			this.lblproccess.Size = new global::System.Drawing.Size(189, 16);
			this.lblproccess.TabIndex = 1;
			this.lblproccess.Text = "Đang copy, vui lòng chờ (0/0)...";
			this.progressBar1.Location = new global::System.Drawing.Point(37, 52);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(219, 23);
			this.progressBar1.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			base.ClientSize = new global::System.Drawing.Size(294, 104);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.lblproccess);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fShowProgressBar";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_progress";
			base.Load += new global::System.EventHandler(this.frm_progress_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000603 RID: 1539
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000604 RID: 1540
		private global::System.Windows.Forms.Label lblproccess;

		// Token: 0x04000605 RID: 1541
		private global::MetroFramework.Controls.MetroProgressBar progressBar1;
	}
}
