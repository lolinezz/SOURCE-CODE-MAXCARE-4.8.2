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
	// Token: 0x020000F4 RID: 244
	public partial class fNhapDuLieu1 : Form
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x0014A2B0 File Offset: 0x001484B0
		public fNhapDuLieu1(string linkPath, string title = "Nhập danh sách Uid cần clone", string status = "Danh sách Uid", string footer = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> lstData = null)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			MCommon.Common.CreateFile(linkPath);
			this.linkPath = linkPath;
			this.status = status;
			this.lblTitle.Text = title;
			this.lblStatus.Text = status + " (0):";
			this.lblFooter.Text = footer;
			bool flag = lstData != null;
			if (flag)
			{
				File.WriteAllLines(linkPath, lstData);
				this.txtComment.Lines = lstData.ToArray();
			}
			else
			{
				this.txtComment.Lines = File.ReadAllLines(linkPath);
			}
			this.TxtComment_TextChanged(null, null);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0014A3B4 File Offset: 0x001485B4
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.lblFooter);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00054604 File Offset: 0x00052804
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0014A418 File Offset: 0x00148618
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

		// Token: 0x060009F4 RID: 2548 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0014A4D4 File Offset: 0x001486D4
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = this.status + " (" + list.Count.ToString() + "):";
			}
			catch
			{
			}
		}

		// Token: 0x04000E41 RID: 3649
		private string linkPath = "";

		// Token: 0x04000E42 RID: 3650
		private string status = "";
	}
}
