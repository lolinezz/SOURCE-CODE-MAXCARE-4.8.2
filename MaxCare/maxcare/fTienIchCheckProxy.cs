using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000D7 RID: 215
	public partial class fTienIchCheckProxy : Form
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00002F46 File Offset: 0x00001146
		public fTienIchCheckProxy()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0010FC94 File Offset: 0x0010DE94
		private void ChangeLanguage()
		{
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label3);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0010FCC4 File Offset: 0x0010DEC4
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				int typeProxy = this.cbbTypeProxy.SelectedIndex;
				List<string> list = new List<string>();
				list = this.txtInput.Lines.ToList<string>();
				int iThread = 0;
				int num = 10;
				this.lblStatus.Invoke(new MethodInvoker(delegate()
				{
					this.lblStatus.Visible = true;
				}));
				int i = 0;
				while (i < list.Count)
				{
					bool flag = iThread < num;
					if (flag)
					{
						Interlocked.Increment(ref iThread);
						string mail = list[i++];
						new Thread(delegate()
						{
							bool flag2 = this.CheckAccountMail(mail, typeProxy);
							if (flag2)
							{
								this.AddRowIntoTextbox(this.txtDaTao, mail);
							}
							else
							{
								this.AddRowIntoTextbox(this.txtChuaTao, mail);
							}
							Interlocked.Decrement(ref iThread);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						MCommon.Common.DelayTime(1.0);
					}
				}
				while (iThread > 0)
				{
					MCommon.Common.DelayTime(1.0);
				}
				this.lblStatus.Invoke(new MethodInvoker(delegate()
				{
					this.lblStatus.Visible = false;
				}));
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã check xong!"), 1);
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0010FEB4 File Offset: 0x0010E0B4
		private void AddRowIntoTextbox(RichTextBox txt, string content)
		{
			txt.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				RichTextBox txt2 = txt;
				txt2.Text = txt2.Text + content + "\r\n";
			}));
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0010FEF8 File Offset: 0x0010E0F8
		private bool CheckAccountMail(string proxy, int typeProxy)
		{
			try
			{
				bool flag = MCommon.Common.CheckProxy(proxy, typeProxy) != "";
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0010FF78 File Offset: 0x0010E178
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtInput.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.groupBox1.Text = string.Format(Language.GetValue("Nhập Proxy ({0})"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0011000C File Offset: 0x0010E20C
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtDaTao.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.grDaTao.Text = "LIVE (" + list.Count.ToString() + ")";
			}
			catch
			{
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x001100B0 File Offset: 0x0010E2B0
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x001100D4 File Offset: 0x0010E2D4
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtChuaTao.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.grChuaTao.Text = "DIE (" + list.Count.ToString() + ")";
			}
			catch
			{
			}
		}
	}
}
