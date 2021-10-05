using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x0200008D RID: 141
	public partial class fCauHinhQuetNhom : Form
	{
		// Token: 0x0600053E RID: 1342 RVA: 0x00072638 File Offset: 0x00070838
		public fCauHinhQuetNhom()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings("configGeneral", false);
			fCauHinhQuetNhom.isOK = false;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0007268C File Offset: 0x0007088C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000726D0 File Offset: 0x000708D0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool @checked = this.rbXuatNhomKiemDuyet.Checked;
			if (!@checked)
			{
				bool checked2 = this.rbXuatNhomKhongKiemDuyet.Checked;
				if (checked2)
				{
				}
			}
			this.settings.Save("");
			fCauHinhQuetNhom.isOK = true;
			base.Close();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00072760 File Offset: 0x00070960
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			int valueInt = this.settings.GetValueInt("typeQuetNhom", 0);
			bool flag = valueInt == 0;
			if (flag)
			{
				this.rbXuatAll.Checked = true;
			}
			else
			{
				bool flag2 = valueInt == 1;
				if (flag2)
				{
					this.rbXuatNhomKiemDuyet.Checked = true;
				}
				else
				{
					this.rbXuatNhomKhongKiemDuyet.Checked = true;
				}
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00072804 File Offset: 0x00070A04
		private void metroButton1_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fCauHinhChung());
		}

		// Token: 0x0400045C RID: 1116
		public static bool isOK;

		// Token: 0x0400045D RID: 1117
		private JSON_Settings settings;
	}
}
