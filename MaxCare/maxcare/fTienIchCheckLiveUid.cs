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
	// Token: 0x020000D3 RID: 211
	public partial class fTienIchCheckLiveUid : Form
	{
		// Token: 0x060008A5 RID: 2213 RVA: 0x00002EDC File Offset: 0x000010DC
		public fTienIchCheckLiveUid()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0010DAD0 File Offset: 0x0010BCD0
		private void ChangeLanguage()
		{
			Language.GetValue(this.groupBox1);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0010DAF0 File Offset: 0x0010BCF0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				list = this.txtInput.Lines.ToList<string>();
				int iThread = 0;
				int num = Convert.ToInt32(this.nudThread.Value);
				bool flag = num == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Số luồng phải >0, vui lòng nhập lại!"), 3);
				}
				else
				{
					bool flag2 = list.Count < num;
					if (flag2)
					{
						num = list.Count;
					}
					this.lblStatus.Invoke(new MethodInvoker(delegate()
					{
						this.lblStatus.Visible = true;
					}));
					int i = 0;
					while (i < list.Count)
					{
						bool flag3 = iThread < num;
						if (flag3)
						{
							Interlocked.Increment(ref iThread);
							string uid = list[i++];
							new Thread(delegate()
							{
								string text = CommonRequest.CheckLiveWall(uid);
								bool flag4 = text.StartsWith("0|");
								if (flag4)
								{
									this.AddRowIntoTextbox(this.txtDie, uid);
								}
								else
								{
									bool flag5 = text.StartsWith("1|");
									if (flag5)
									{
										this.AddRowIntoTextbox(this.txtLive, uid);
									}
									else
									{
										this.AddRowIntoTextbox(this.txtKhongCheckDuoc, uid);
									}
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
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0010DD30 File Offset: 0x0010BF30
		private void AddRowIntoTextbox(RichTextBox txt, string content)
		{
			txt.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				RichTextBox txt2 = txt;
				txt2.Text = txt2.Text + content + "\r\n";
			}));
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0010DD74 File Offset: 0x0010BF74
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtInput.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.groupBox1.Text = string.Format(Language.GetValue("Nhập Uid ({0})"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0010DE08 File Offset: 0x0010C008
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtLive.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.grDaTao.Text = "LIVE (" + list.Count.ToString() + ")";
			}
			catch
			{
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00054604 File Offset: 0x00052804
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0010DEAC File Offset: 0x0010C0AC
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtDie.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.grChuaTao.Text = "DIE (" + list.Count.ToString() + ")";
			}
			catch
			{
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0010DF50 File Offset: 0x0010C150
		private void txtKhongCheckDuoc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtKhongCheckDuoc.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.grKhongCheckDuoc.Text = string.Format(Language.GetValue("Không check được ({0})"), list.Count.ToString());
			}
			catch
			{
			}
		}
	}
}
