using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;

namespace maxcare
{
	// Token: 0x0200009E RID: 158
	public partial class fContact : Form
	{
		// Token: 0x060005FA RID: 1530 RVA: 0x00002CB5 File Offset: 0x00000EB5
		public fContact()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00089094 File Offset: 0x00087294
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label10);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00054604 File Offset: 0x00052804
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000890D8 File Offset: 0x000872D8
		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = (sender as LinkLabel).Text;
			try
			{
				Process.Start("chrome.exe", text);
			}
			catch
			{
				Process.Start(text);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000890D8 File Offset: 0x000872D8
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = (sender as LinkLabel).Text;
			try
			{
				Process.Start("chrome.exe", text);
			}
			catch
			{
				Process.Start(text);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x000890D8 File Offset: 0x000872D8
		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = (sender as LinkLabel).Text;
			try
			{
				Process.Start("chrome.exe", text);
			}
			catch
			{
				Process.Start(text);
			}
		}
	}
}
