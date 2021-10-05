using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008E RID: 142
	public partial class fNhapPassKhoiPhuc : Form
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x00073C58 File Offset: 0x00071E58
		public fNhapPassKhoiPhuc()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings("configGeneral", false);
			fNhapPassKhoiPhuc.isOK = false;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00073CAC File Offset: 0x00071EAC
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00073CF0 File Offset: 0x00071EF0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int num = 0;
			bool @checked = this.rbPassNgauNhien.Checked;
			if (@checked)
			{
				num = 1;
			}
			this.settings.Update("typePass", num);
			this.settings.Update("txtPass", this.txtPass.Text);
			this.settings.Save("");
			fNhapPassKhoiPhuc.isOK = true;
			base.Close();
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00073DC0 File Offset: 0x00071FC0
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			int valueInt = this.settings.GetValueInt("typePass", 0);
			bool flag = valueInt == 0;
			if (flag)
			{
				this.rbPassTuDat.Checked = true;
			}
			else
			{
				this.rbPassNgauNhien.Checked = true;
			}
			this.txtPass.Text = this.settings.GetValue("txtPass", "");
			this.rbPassTuDat_CheckedChanged(null, null);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00073E94 File Offset: 0x00072094
		private void rbPassTuDat_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPass.Enabled = this.rbPassTuDat.Checked;
		}

		// Token: 0x0400046D RID: 1133
		public static bool isOK;

		// Token: 0x0400046E RID: 1134
		private JSON_Settings settings;
	}
}
