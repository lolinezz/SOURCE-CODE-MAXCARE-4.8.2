using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000DB RID: 219
	public partial class fTienIchCheckImapHotmail : Form
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x00002FB0 File Offset: 0x000011B0
		public fTienIchCheckImapHotmail()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00111C60 File Offset: 0x0010FE60
		private void ChangeLanguage()
		{
			Language.GetValue(this.rbNhapTuFile);
			Language.GetValue(this.btnNhapTuFile);
			Language.GetValue(this.rbTuNhap);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00111CA4 File Offset: 0x0010FEA4
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				string text = this.txtNhapTuFile.Text.Trim();
				bool @checked = this.rbNhapTuFile.Checked;
				if (@checked)
				{
					bool flag = text.EndsWith(".txt");
					if (flag)
					{
						bool flag2 = !File.Exists(text);
						if (flag2)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("File dữ liệu nhập không tồn tại!"), 2);
						}
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("File nhập vào chỉ hỗ trợ đối với File (.txt)!"), 2);
					}
				}
				bool checked2 = this.rbNhapTuFile.Checked;
				if (checked2)
				{
					list = File.ReadAllLines(text).ToList<string>();
				}
				else
				{
					bool checked3 = this.rbTuNhap.Checked;
					if (checked3)
					{
						list = this.txtInput.Lines.ToList<string>();
					}
				}
				int iThread = 0;
				int num = 10;
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
						string mail = list[i++];
						new Thread(delegate()
						{
							bool flag4 = this.CheckAccountMail(mail);
							if (flag4)
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

		// Token: 0x060008D1 RID: 2257 RVA: 0x00111F84 File Offset: 0x00110184
		private void AddRowIntoTextbox(RichTextBox txt, string content)
		{
			txt.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				RichTextBox txt2 = txt;
				txt2.Text = txt2.Text + content + "\r\n";
			}));
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00111FC8 File Offset: 0x001101C8
		private bool CheckAccountMail(string mail)
		{
			bool result;
			try
			{
				string[] array = mail.Split(new char[]
				{
					'|'
				});
				string imap = "";
				string text = array[0];
				string text2 = array[1];
				bool flag = text == "" || text2 == "";
				if (flag)
				{
					result = false;
				}
				else
				{
					bool flag2 = array.Length > 2;
					if (flag2)
					{
						imap = array[2];
					}
					result = (MCommon.Common.CheckAccountHotmail(text, text2, imap) == "1");
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x001120E8 File Offset: 0x001102E8
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtInput.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.rbTuNhap.Text = string.Format(Language.GetValue("Tự nhập ({0})"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0011217C File Offset: 0x0011037C
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
			this.btnNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x001121CC File Offset: 0x001103CC
		private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.txtInput.Enabled = this.rbTuNhap.Checked;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x001121FC File Offset: 0x001103FC
		private void btnNhapTuFile_Click(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Text = MCommon.Common.SelectFile("Chọn File txt", "txt Files (*.txt)|*.txt|");
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0011224C File Offset: 0x0011044C
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtDaTao.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.grDaTao.Text = string.Format(Language.GetValue("Live ({0})"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x001122E0 File Offset: 0x001104E0
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
			this.radioButton1_CheckedChanged(null, null);
			this.rbTuNhap_CheckedChanged(null, null);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0011230C File Offset: 0x0011050C
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtChuaTao.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.grChuaTao.Text = string.Format(Language.GetValue("Die ({0})"), list.Count.ToString());
			}
			catch
			{
			}
		}
	}
}
