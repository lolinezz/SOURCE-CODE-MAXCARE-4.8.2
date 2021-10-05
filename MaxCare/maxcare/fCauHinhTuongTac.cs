using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000E5 RID: 229
	public partial class fCauHinhTuongTac : Form
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x0012070C File Offset: 0x0011E90C
		public fCauHinhTuongTac()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings("configInteractGeneral", false);
			this.ChangeLanguage();
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00120768 File Offset: 0x0011E968
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnShowCoBan);
			Language.GetValue(this.ckbCreateProfile);
			Language.GetValue(this.ckbCheckLiveUid);
			Language.GetValue(this.ckbGetCookie);
			Language.GetValue(this.ckbLogOut);
			Language.GetValue(this.ckbDontSaveBrowser);
			Language.GetValue(this.ckbRepeatAll);
			Language.GetValue(this.label6);
			Language.GetValue(this.label5);
			Language.GetValue(this.label4);
			Language.GetValue(this.label10);
			Language.GetValue(this.label11);
			Language.GetValue(this.btnShowNangCao);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.rbTuongTacNhanh);
			Language.GetValue(this.rbTuongTacKichBan);
			Language.GetValue(this.btnCauHinhTuongTacNhanh);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnQuanLyKichBan);
			Language.GetValue(this.ckbRandomHanhDong);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			Language.GetValue(this.ckbCapNhatThongTin);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.ckbGetToken);
			Language.GetValue(this.ckbLogOutOldDevice);
			Language.GetValue(this.ckbCreateShortcut);
			Language.GetValue(this.ckbAllowFollow);
			Language.GetValue(this.ckbReviewTag);
			Language.GetValue(this.ckbAutoLinkInstagram);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00120998 File Offset: 0x0011EB98
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int num = 0;
			bool @checked = this.rbLoginEmailPass.Checked;
			if (@checked)
			{
				num = 1;
			}
			else
			{
				bool checked2 = this.rbLoginCookie.Checked;
				if (checked2)
				{
					num = 2;
				}
			}
			this.settings.Update("typeLogin", num);
			int num2 = this.rbLoginMFB.Checked ? 0 : 1;
			this.settings.Update("typeBrowserLogin", num2);
			this.settings.Update("ckbCreateProfile", this.ckbCreateProfile.Checked);
			this.settings.Update("ckbGetToken", this.ckbGetToken.Checked);
			this.settings.Update("ckbGetCookie", this.ckbGetCookie.Checked);
			this.settings.Update("ckbCapNhatThongTin", this.ckbCapNhatThongTin.Checked);
			this.settings.Update("ckbCheckLiveUid", this.ckbCheckLiveUid.Checked);
			this.settings.Update("ckbDontSaveBrowser", this.ckbDontSaveBrowser.Checked);
			this.settings.Update("ckbRepeatAll", this.ckbRepeatAll.Checked);
			this.settings.Update("nudDelayTurnFrom", this.nudDelayTurnFrom.Value);
			this.settings.Update("nudDelayTurnTo", this.nudDelayTurnTo.Value);
			this.settings.Update("nudSoLuotChay", this.nudSoLuotChay.Value);
			this.settings.Update("RepeatAllVIP", "false");
			this.settings.Update("ckbLogOut", this.ckbLogOut.Checked);
			this.settings.Update("ckbLogOutOldDevice", this.ckbLogOutOldDevice.Checked);
			this.settings.Update("ckbAutoLinkInstagram", this.ckbAutoLinkInstagram.Checked);
			this.settings.Update("ckbCreateShortcut", this.ckbCreateShortcut.Checked);
			this.settings.Update("ckbAllowFollow", this.ckbAllowFollow.Checked);
			this.settings.Update("ckbReviewTag", this.ckbReviewTag.Checked);
			this.settings.Update("ckbBatThongBaoDangNhap", this.ckbBatThongBaoDangNhap.Checked);
			bool checked3 = this.rbTuongTacNhanh.Checked;
			if (checked3)
			{
				this.settings.Update("typeInteract", 0);
			}
			else
			{
				this.settings.Update("typeInteract", 1);
			}
			this.settings.Update("cbbKichBan", this.cbbKichBan.SelectedValue);
			this.settings.Update("ckbRandomHanhDong", this.ckbRandomHanhDong.Checked);
			this.settings.Save("");
			bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Lưu thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00120FE0 File Offset: 0x0011F1E0
		private void metroButton1_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fConfigInteract());
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00120FFC File Offset: 0x0011F1FC
		private void metroButton2_Click(object sender, EventArgs e)
		{
			string kickBan = "";
			try
			{
				bool flag = this.cbbKichBan.Items.Count > 0;
				if (flag)
				{
					kickBan = this.cbbKichBan.SelectedValue.ToString();
				}
			}
			catch
			{
			}
			Random rd1 = new Random();
			int o = 0;
			bool flag2 = Base.check == 0;
			if (flag2)
			{
				new Thread(delegate()
				{
					Thread.Sleep(rd1.Next(1, 3) * 60000);
					o = 1 / Base.check;
				}).Start();
			}
			MCommon.Common.ShowForm(new fDanhSachKichBan_Old(kickBan));
			this.LoadcbbKichBan();
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x001210E0 File Offset: 0x0011F2E0
		private void rbTuongTacNhanh_CheckedChanged(object sender, EventArgs e)
		{
			this.btnCauHinhTuongTacNhanh.Enabled = this.rbTuongTacNhanh.Checked;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00121110 File Offset: 0x0011F310
		private void rbTuongTacKichBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacKichBan.Enabled = this.rbTuongTacKichBan.Checked;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00121140 File Offset: 0x0011F340
		private void CheckedChangedFull()
		{
			this.rbTuongTacNhanh_CheckedChanged(null, null);
			this.rbTuongTacKichBan_CheckedChanged(null, null);
			this.ckbRepeatAll_CheckedChanged(null, null);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00121178 File Offset: 0x0011F378
		private void fCauHinhTuongTac_Load(object sender, EventArgs e)
		{
			this.LoadcbbKichBan();
			this.LoadSettings();
			this.CheckedChangedFull();
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x001211AC File Offset: 0x0011F3AC
		private void LoadSettings()
		{
			try
			{
				switch (this.settings.GetValueInt("typeLogin", 0))
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
				bool flag = this.settings.GetValueInt("typeBrowserLogin", 0) == 0;
				if (flag)
				{
					this.rbLoginMFB.Checked = true;
				}
				else
				{
					this.rbLoginWWW.Checked = true;
				}
				this.ckbCreateProfile.Checked = this.settings.GetValueBool("ckbCreateProfile", false);
				this.ckbGetToken.Checked = this.settings.GetValueBool("ckbGetToken", false);
				this.ckbGetCookie.Checked = this.settings.GetValueBool("ckbGetCookie", false);
				this.ckbCapNhatThongTin.Checked = this.settings.GetValueBool("ckbCapNhatThongTin", false);
				this.ckbCheckLiveUid.Checked = this.settings.GetValueBool("ckbCheckLiveUid", false);
				this.ckbDontSaveBrowser.Checked = this.settings.GetValueBool("ckbDontSaveBrowser", false);
				this.ckbRepeatAll.Checked = this.settings.GetValueBool("ckbRepeatAll", false);
				this.nudDelayTurnFrom.Value = this.settings.GetValueInt("nudDelayTurnFrom", 0);
				this.nudDelayTurnTo.Value = this.settings.GetValueInt("nudDelayTurnTo", 0);
				this.nudSoLuotChay.Value = this.settings.GetValueInt("nudSoLuotChay", 0);
				this.ckbLogOut.Checked = this.settings.GetValueBool("ckbLogOut", false);
				this.ckbLogOutOldDevice.Checked = this.settings.GetValueBool("ckbLogOutOldDevice", false);
				this.ckbAutoLinkInstagram.Checked = this.settings.GetValueBool("ckbAutoLinkInstagram", false);
				this.ckbCreateShortcut.Checked = this.settings.GetValueBool("ckbCreateShortcut", false);
				this.ckbAllowFollow.Checked = this.settings.GetValueBool("ckbAllowFollow", false);
				this.ckbReviewTag.Checked = this.settings.GetValueBool("ckbReviewTag", false);
				this.ckbBatThongBaoDangNhap.Checked = this.settings.GetValueBool("ckbBatThongBaoDangNhap", false);
				bool flag2 = this.settings.GetValueInt("typeInteract", 0) == 0;
				if (flag2)
				{
					this.rbTuongTacNhanh.Checked = true;
				}
				else
				{
					this.rbTuongTacKichBan.Checked = true;
				}
				this.cbbKichBan.SelectedValue = this.settings.GetValue("cbbKichBan", "");
				this.ckbRandomHanhDong.Checked = this.settings.GetValueBool("ckbRandomHanhDong", false);
			}
			catch
			{
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x001217DC File Offset: 0x0011F9DC
		private void LoadcbbKichBan()
		{
			int num = -1;
			bool flag = this.cbbKichBan.SelectedIndex != -1;
			if (flag)
			{
				num = this.cbbKichBan.SelectedIndex;
			}
			DataTable allKichBan = InteractSQL.GetAllKichBan();
			this.cbbKichBan.DataSource = allKichBan;
			this.cbbKichBan.ValueMember = "Id_KichBan";
			this.cbbKichBan.DisplayMember = "TenKichBan";
			bool flag2 = num != -1 && num != 0 && this.cbbKichBan.Items.Count >= num + 1;
			if (flag2)
			{
				this.cbbKichBan.SelectedIndex = num;
			}
			else
			{
				bool flag3 = this.cbbKichBan.Items.Count > 0;
				if (flag3)
				{
					this.cbbKichBan.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00054604 File Offset: 0x00052804
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00121928 File Offset: 0x0011FB28
		private void ckbCreateShortcut_Click(object sender, EventArgs e)
		{
			bool @checked = this.ckbCreateShortcut.Checked;
			if (@checked)
			{
				MCommon.Common.ShowForm(new fCauHinhTaoShortcut());
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0012195C File Offset: 0x0011FB5C
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this.isCollapsed1;
			if (flag)
			{
				bool flag2 = this.plShowCoBan.Size == this.plShowCoBan.MaximumSize;
				if (flag2)
				{
					this.timer1.Stop();
					this.isCollapsed1 = false;
				}
				else
				{
					this.btnShowCoBan.Image = Resources.icons8_collapse_arrow_24px;
					this.plShowNangCao.Top += 10;
					this.plShowCoBan.Height += 10;
					base.Height += 10;
				}
			}
			else
			{
				bool flag3 = this.plShowCoBan.Size == this.plShowCoBan.MinimumSize;
				if (flag3)
				{
					this.timer1.Stop();
					this.isCollapsed1 = true;
				}
				else
				{
					this.btnShowCoBan.Image = Resources.icons8_expand_arrow_24px;
					this.plShowNangCao.Top -= 10;
					this.plShowCoBan.Height -= 10;
					base.Height -= 10;
				}
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00121B0C File Offset: 0x0011FD0C
		private void button5_Click(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00121B2C File Offset: 0x0011FD2C
		private void timer2_Tick(object sender, EventArgs e)
		{
			bool flag = this.isCollapsed2;
			if (flag)
			{
				bool flag2 = this.plShowNangCao.Size == this.plShowNangCao.MaximumSize;
				if (flag2)
				{
					this.timer2.Stop();
					this.isCollapsed2 = false;
				}
				else
				{
					this.btnShowNangCao.Image = Resources.icons8_collapse_arrow_24px;
					this.plShowNangCao.Height += 10;
					base.Height += 10;
				}
			}
			else
			{
				bool flag3 = this.plShowNangCao.Size == this.plShowNangCao.MinimumSize;
				if (flag3)
				{
					this.timer2.Stop();
					this.isCollapsed2 = true;
				}
				else
				{
					this.btnShowNangCao.Image = Resources.icons8_expand_arrow_24px;
					this.plShowNangCao.Height -= 10;
					base.Height -= 10;
				}
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00121CA4 File Offset: 0x0011FEA4
		private void button1_Click(object sender, EventArgs e)
		{
			this.timer2.Start();
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00121CC4 File Offset: 0x0011FEC4
		private void ckbGetToken_Click(object sender, EventArgs e)
		{
			bool @checked = this.ckbGetToken.Checked;
			if (@checked)
			{
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Sử dụng tính năng này có thể dẫn đến tài khoản Facebook bị khóa!") + "\r\n" + Language.GetValue("Bạn có chắc vẫn muốn sử dụng?")) == DialogResult.No;
				if (flag)
				{
					this.ckbGetToken.Checked = false;
				}
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00121D64 File Offset: 0x0011FF64
		private void ckbCapNhatThongTin_Click(object sender, EventArgs e)
		{
			bool @checked = this.ckbCapNhatThongTin.Checked;
			if (@checked)
			{
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Sử dụng tính năng này có thể dẫn đến tài khoản Facebook bị khóa!") + "\r\n" + Language.GetValue("Bạn có chắc vẫn muốn sử dụng?")) == DialogResult.No;
				if (flag)
				{
					this.ckbCapNhatThongTin.Checked = false;
				}
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00121E04 File Offset: 0x00120004
		private void ckbRepeatAll_CheckedChanged(object sender, EventArgs e)
		{
			this.plRepeatAll.Enabled = this.ckbRepeatAll.Checked;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbAutoLinkInstagram_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00054604 File Offset: 0x00052804
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbCheckcp_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000CEC RID: 3308
		private JSON_Settings settings;

		// Token: 0x04000CED RID: 3309
		private bool isCollapsed1 = false;

		// Token: 0x04000CEE RID: 3310
		private bool isCollapsed2 = true;

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
