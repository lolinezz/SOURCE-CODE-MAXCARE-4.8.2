using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000E1 RID: 225
	public partial class fNhapTokenTrungGian_DownAvatar : Form
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x00118FC8 File Offset: 0x001171C8
		public fNhapTokenTrungGian_DownAvatar()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings("configGeneral", false);
			fNhapTokenTrungGian_DownAvatar.isOK = false;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0011901C File Offset: 0x0011721C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00119080 File Offset: 0x00117280
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update("pathFolderAvatar", this.txtPathFolder.Text);
			this.settings.Save("");
			fNhapTokenTrungGian_DownAvatar.isOK = true;
			base.Close();
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00119100 File Offset: 0x00117300
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.txtPathFolder.Text = this.settings.GetValue("pathFolderAvatar", "");
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00054604 File Offset: 0x00052804
		private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0011915C File Offset: 0x0011735C
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathFolder.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x04000C9D RID: 3229
		public static bool isOK;

		// Token: 0x04000C9E RID: 3230
		private JSON_Settings settings;
	}
}
