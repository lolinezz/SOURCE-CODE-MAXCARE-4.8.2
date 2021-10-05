using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x020000A4 RID: 164
	public partial class fLocTheoDanhSachUid : Form
	{
		// Token: 0x0600061B RID: 1563 RVA: 0x00002D8F File Offset: 0x00000F8F
		public fLocTheoDanhSachUid()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fLocTheoDanhSachUid.lstUID = new List<string>();
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0008CE90 File Offset: 0x0008B090
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0008CEF4 File Offset: 0x0008B0F4
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập thêm UID!"), 3);
				}
				else
				{
					fLocTheoDanhSachUid.lstUID = MCommon.Common.CloneList(list);
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0008CFC4 File Offset: 0x0008B1C4
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách UID ({0}):"), list.Count);
			}
			catch
			{
			}
		}

		// Token: 0x040005A8 RID: 1448
		public static List<string> lstUID = new List<string>();

        private void fLocTheoDanhSachUid_Load(object sender, EventArgs e)
        {

        }
    }
}
