namespace maxcare
{
	// Token: 0x020000A0 RID: 160
	public partial class fViewChrome : global::System.Windows.Forms.Form
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x0008CB48 File Offset: 0x0008AD48
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0008CBA8 File Offset: 0x0008ADA8
		private void InitializeComponent()
		{
            this.panelListDevice = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelListDevice
            // 
            this.panelListDevice.AutoScroll = true;
            this.panelListDevice.BackColor = System.Drawing.Color.White;
            this.panelListDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListDevice.Location = new System.Drawing.Point(0, 0);
            this.panelListDevice.Name = "panelListDevice";
            this.panelListDevice.Padding = new System.Windows.Forms.Padding(10);
            this.panelListDevice.Size = new System.Drawing.Size(933, 554);
            this.panelListDevice.TabIndex = 1;
            this.panelListDevice.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListDevice_Paint);
            // 
            // fViewChrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.panelListDevice);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fViewChrome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện Chrome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fViewChrome_Load);
            this.ResumeLayout(false);

		}

		// Token: 0x0400059B RID: 1435
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400059C RID: 1436
		private global::System.Windows.Forms.FlowLayoutPanel panelListDevice;
	}
}
