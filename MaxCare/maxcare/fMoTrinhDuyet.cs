using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000A6 RID: 166
	public partial class fMoTrinhDuyet : Form
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public fMoTrinhDuyet()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fMoTrinhDuyet.isOK = false;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0008F2A4 File Offset: 0x0008D4A4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnCauHinh);
			Language.GetValue(this.label1);
			Language.GetValue(this.rbSuDungProfile);
			Language.GetValue(this.rbKhongDungProfile);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbKhongLuuTrinhDuyet);
			Language.GetValue(this.ckbGetCookie);
			Language.GetValue(this.ckbAutoCloseChromeLoginFail);
			Language.GetValue(this.ckbAutoOpenLink);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00072804 File Offset: 0x00070A04
		private void metroButton1_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fCauHinhChung());
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0008F3A0 File Offset: 0x0008D5A0
		private void fMoTrinhDuyet_Load(object sender, EventArgs e)
		{
			JSON_Settings json_Settings = new JSON_Settings("configOpenBrowser", false);
			bool valueBool = json_Settings.GetValueBool("isUseProfile", true);
			if (valueBool)
			{
				this.rbSuDungProfile.Checked = true;
			}
			else
			{
				this.rbKhongDungProfile.Checked = true;
			}
			bool flag = json_Settings.GetValueInt("typeBrowserLogin", 0) == 0;
			if (flag)
			{
				this.rbLoginMFB.Checked = true;
			}
			else
			{
				this.rbLoginWWW.Checked = true;
			}
			switch (json_Settings.GetValueInt("typeLogin", 0))
			{
			case 0:
				this.rbLoginUidPass.Checked = true;
				break;
			case 1:
				this.rbLoginEmailPass.Checked = true;
				break;
			case 2:
				this.rbLoginCookie.Checked = true;
				break;
			}
			this.ckbAddChromeIntoForm.Checked = json_Settings.GetValueBool("ckbAddChromeIntoForm", false);
			this.nudWidthChrome.Value = json_Settings.GetValueInt("nudWidthChrome", 520);
			this.nudHeighChrome.Value = json_Settings.GetValueInt("nudHeighChrome", 480);
			this.cbbColumnChrome.Text = ((json_Settings.GetValue("cbbColumnChrome", "") == "") ? "5" : json_Settings.GetValue("cbbColumnChrome", ""));
			this.cbbRowChrome.Text = ((json_Settings.GetValue("cbbRowChrome", "") == "") ? "2" : json_Settings.GetValue("cbbRowChrome", ""));
			this.ckbKhongLuuTrinhDuyet.Checked = json_Settings.GetValueBool("ckbKhongLuuTrinhDuyet", false);
			this.ckbGetCookie.Checked = json_Settings.GetValueBool("isGetCookie", false);
			this.ckbAutoCloseChromeLoginFail.Checked = json_Settings.GetValueBool("isAutoCloseChromeLoginFail", false);
			this.ckbAutoOpenLink.Checked = json_Settings.GetValueBool("ckbAutoOpenLink", false);
			this.txtLink.Text = json_Settings.GetValue("txtLink", "");
			this.ckbLoginHotmail.Checked = json_Settings.GetValueBool("ckbLoginHotmail", false);
			this.ckbAutoOpenLink_CheckedChanged(null, null);
			this.ckbCaptcha_CheckedChanged(null, null);
			this.ckbAddChromeIntoForm_CheckedChanged(null, null);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0008F868 File Offset: 0x0008DA68
		private void btnSave_Click(object sender, EventArgs e)
		{
			JSON_Settings json_Settings = new JSON_Settings("configOpenBrowser", false);
			bool @checked = this.rbSuDungProfile.Checked;
			if (@checked)
			{
				json_Settings.Update("isUseProfile", true);
			}
			else
			{
				json_Settings.Update("isUseProfile", false);
			}
			bool checked2 = this.rbLoginUidPass.Checked;
			if (checked2)
			{
				json_Settings.Update("typeLogin", 0);
			}
			else
			{
				bool checked3 = this.rbLoginEmailPass.Checked;
				if (checked3)
				{
					json_Settings.Update("typeLogin", 1);
				}
				else
				{
					json_Settings.Update("typeLogin", 2);
				}
			}
			bool checked4 = this.rbLoginMFB.Checked;
			if (checked4)
			{
				json_Settings.Update("typeBrowserLogin", 0);
			}
			else
			{
				json_Settings.Update("typeBrowserLogin", 1);
			}
			json_Settings.Update("ckbAddChromeIntoForm", this.ckbAddChromeIntoForm.Checked);
			json_Settings.Update("nudWidthChrome", this.nudWidthChrome.Value);
			json_Settings.Update("nudHeighChrome", this.nudHeighChrome.Value);
			json_Settings.Update("cbbColumnChrome", this.cbbColumnChrome.Text);
			json_Settings.Update("cbbRowChrome", this.cbbRowChrome.Text);
			json_Settings.Update("isGetCookie", this.ckbGetCookie.Checked);
			json_Settings.Update("ckbKhongLuuTrinhDuyet", this.ckbKhongLuuTrinhDuyet.Checked);
			json_Settings.Update("isAutoCloseChromeLoginFail", this.ckbAutoCloseChromeLoginFail.Checked);
			json_Settings.Update("ckbAutoOpenLink", this.ckbAutoOpenLink.Checked);
			json_Settings.Update("txtLink", this.txtLink.Text);
			json_Settings.Update("ckbLoginHotmail", this.ckbLoginHotmail.Checked);
			json_Settings.Save("");
			fMoTrinhDuyet.isOK = true;
			base.Close();
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00054604 File Offset: 0x00052804
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0008FC50 File Offset: 0x0008DE50
		private void ckbAutoOpenLink_CheckedChanged(object sender, EventArgs e)
		{
			this.txtLink.Enabled = this.ckbAutoOpenLink.Checked;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbCaptcha_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0008FC80 File Offset: 0x0008DE80
		private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
		{
			this.plAddChromeVaoFormView.Enabled = this.ckbAddChromeIntoForm.Checked;
			this.plSapXepCuaSoChrome.Enabled = !this.ckbAddChromeIntoForm.Checked;
		}

		// Token: 0x040005C3 RID: 1475
		public static bool isOK;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
