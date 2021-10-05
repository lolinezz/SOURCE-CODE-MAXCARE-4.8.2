using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000DF RID: 223
	public partial class fTienIchLocTrung : Form
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x0000301A File Offset: 0x0000121A
		public fTienIchLocTrung()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00114038 File Offset: 0x00112238
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.rbNhapTuFile);
			Language.GetValue(this.btnNhapTuFile);
			Language.GetValue(this.rbTuNhap);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0011408C File Offset: 0x0011228C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> source = new List<string>();
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
					source = File.ReadAllLines(text).ToList<string>();
				}
				else
				{
					bool checked3 = this.rbTuNhap.Checked;
					if (checked3)
					{
						source = this.txtInput.Lines.ToList<string>();
					}
				}
				List<string> list = source.Distinct<string>().ToList<string>();
				this.txtOutput.Lines = list.ToArray();
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã lọc xong!"), 1);
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00114258 File Offset: 0x00112458
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

		// Token: 0x060008E9 RID: 2281 RVA: 0x001142EC File Offset: 0x001124EC
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
			this.btnNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0011433C File Offset: 0x0011253C
		private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.txtInput.Enabled = this.rbTuNhap.Checked;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0011436C File Offset: 0x0011256C
		private void btnNhapTuFile_Click(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Text = MCommon.Common.SelectFile("Chọn File txt", "txt Files (*.txt)|*.txt|");
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x001143BC File Offset: 0x001125BC
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtOutput.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.groupBox2.Text = string.Format("Output ({0})", list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0011444C File Offset: 0x0011264C
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
			this.radioButton1_CheckedChanged(null, null);
			this.rbTuNhap_CheckedChanged(null, null);
		}
	}
}
