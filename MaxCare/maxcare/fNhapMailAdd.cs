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

namespace maxcare
{
	// Token: 0x0200008C RID: 140
	public partial class fNhapMailAdd : Form
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x00070A74 File Offset: 0x0006EC74
		public fNhapMailAdd()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			MCommon.Common.CreateFile(this.linkPath);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00070AE0 File Offset: 0x0006ECE0
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.lblFooter);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00070B44 File Offset: 0x0006ED44
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			this.txtComment.Lines = File.ReadAllLines(this.linkPath);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00054604 File Offset: 0x00052804
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00070B74 File Offset: 0x0006ED74
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				File.WriteAllText(this.linkPath, this.txtComment.Text.Trim());
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Lưu thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
				if (flag)
				{
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00070C30 File Offset: 0x0006EE30
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = "Danh sách Email (" + list.Count.ToString() + "):";
			}
			catch
			{
			}
		}

		// Token: 0x04000446 RID: 1094
		private string linkPath = "configschange\\addmail\\hotmail.txt";

		// Token: 0x04000447 RID: 1095
		private string status = "";
	}
}
