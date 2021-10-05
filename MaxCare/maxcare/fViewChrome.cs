using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using maxcare.Helper;

namespace maxcare
{
	// Token: 0x020000A0 RID: 160
	public partial class fViewChrome : Form
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x00002D14 File Offset: 0x00000F14
		public fViewChrome()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fViewChrome.remote = this;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0008C888 File Offset: 0x0008AA88
		private void ChangeLanguage()
		{
			Language.GetValue(this);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0008C8A4 File Offset: 0x0008AAA4
		public void AddChromeIntoPanel(IntPtr MainWindowHandle, int indexDevice, int width, int heigh, int x = -10, int y = -30)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				User32Helper.SetParent(MainWindowHandle, (from Control h in this.panelListDevice.Controls
				where h.Tag.Equals(indexDevice)
				select h).FirstOrDefault<Control>().Handle);
				User32Helper.MoveWindow(MainWindowHandle, x, y, width, heigh, true);
			}));
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0008C924 File Offset: 0x0008AB24
		public void RemovePanelDevice(int indexDevice)
		{
			Control ctr = this.panelListDevice.Controls["dv" + indexDevice.ToString()];
			this.panelListDevice.Invoke(new MethodInvoker(delegate()
			{
				this.panelListDevice.Controls.Remove(ctr);
			}));
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0008C9A4 File Offset: 0x0008ABA4
		public void AddPanelDevice(int indexDevice, int width, int heigh)
		{
			Panel panel = new Panel();
			panel.Name = "dv" + indexDevice.ToString();
			panel.Tag = indexDevice;
			panel.Size = new Size(width, heigh);
			panel.BackColor = Color.White;
			panel.BorderStyle = BorderStyle.FixedSingle;
			base.Invoke(new MethodInvoker(delegate()
			{
				this.panelListDevice.Controls.Add(panel);
			}));
			for (int i = 0; i < 10; i++)
			{
				bool flag = this.panelListDevice.Controls["dv" + indexDevice.ToString()] != null;
				if (flag)
				{
					break;
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0008CAE8 File Offset: 0x0008ACE8
		private void TurnOffDevice(object sender, EventArgs e)
		{
			this.RemovePanelDevice(Convert.ToInt32((sender as PictureBox).Name.Replace("pic", "")));
		}

		// Token: 0x0400059A RID: 1434
		public static fViewChrome remote;

        private void panelListDevice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fViewChrome_Load(object sender, EventArgs e)
        {

        }
    }
}
