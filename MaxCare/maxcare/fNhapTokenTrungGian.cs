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
	// Token: 0x020000E2 RID: 226
	public partial class fNhapTokenTrungGian : Form
	{
		// Token: 0x0600090B RID: 2315 RVA: 0x0011A1AC File Offset: 0x001183AC
		public fNhapTokenTrungGian()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings("configGeneral", false);
			fNhapTokenTrungGian.isOK = false;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0011A200 File Offset: 0x00118400
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnCheckLiveTokenTg);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0011A264 File Offset: 0x00118464
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update("token", this.token.Text);
			this.settings.Save("");
			fNhapTokenTrungGian.isOK = true;
			base.Close();
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0011A2E4 File Offset: 0x001184E4
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.token.Text = this.settings.GetValue("token", "");
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0011A340 File Offset: 0x00118540
		private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
		{
			bool flag = CommonRequest.CheckLiveToken("", this.token.Text, "", "", 0);
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox("Token live!", 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox("Token die!", 1);
			}
		}

		// Token: 0x04000CAB RID: 3243
		public static bool isOK;

		// Token: 0x04000CAC RID: 3244
		private JSON_Settings settings;
	}
}
