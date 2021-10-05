using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000A5 RID: 165
	public partial class fNhapCookieTrungGian : Form
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x0008E09C File Offset: 0x0008C29C
		public fNhapCookieTrungGian()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings("configGeneral", false);
			this.ChangeLanguage();
			fNhapCookieTrungGian.isOK = false;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0008E0F0 File Offset: 0x0008C2F0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0008E154 File Offset: 0x0008C354
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update("cookie", this.txtCookie.Text);
			this.settings.Save("");
			fNhapCookieTrungGian.isOK = true;
			base.Close();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0008E1D4 File Offset: 0x0008C3D4
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.txtCookie.Text = this.settings.GetValue("cookie", "");
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0008E230 File Offset: 0x0008C430
		private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
		{
			bool flag = CommonRequest.CheckLiveCookie(this.txtCookie.Text, "", "", 0).StartsWith("1|");
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox("Cookie live!", 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox("Cookie die!", 1);
			}
		}

		// Token: 0x040005B5 RID: 1461
		public static bool isOK;

		// Token: 0x040005B6 RID: 1462
		private JSON_Settings settings;
	}
}
