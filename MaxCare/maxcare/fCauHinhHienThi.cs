using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;

namespace maxcare
{
	// Token: 0x020000E4 RID: 228
	public partial class fCauHinhHienThi : Form
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00003063 File Offset: 0x00001263
		public fCauHinhHienThi()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings("configDatagridview", false);
			this.ChangeLanguage();
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0011D070 File Offset: 0x0011B270
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.ckbTen);
			Language.GetValue(this.ckbFollow);
			Language.GetValue(this.ckbBanBe);
			Language.GetValue(this.ckbNhom);
			Language.GetValue(this.ckbNgaySinh);
			Language.GetValue(this.ckbGioiTinh);
			Language.GetValue(this.ckbMatKhau);
			Language.GetValue(this.ckbMatKhauMail);
			Language.GetValue(this.ckbMa2FA);
			Language.GetValue(this.ckbNgayTao);
			Language.GetValue(this.ckbInteractEnd);
			Language.GetValue(this.ckbTinhTrang);
			Language.GetValue(this.ckbThuMuc);
			Language.GetValue(this.ckbGhiChu);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0011D1B0 File Offset: 0x0011B3B0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update("cToken", this.ckbToken.Checked);
			this.settings.Update("ckbCookie", this.ckbCookie.Checked);
			this.settings.Update("ckbEmail", this.ckbEmail.Checked);
			this.settings.Update("ckbTen", this.ckbTen.Checked);
			this.settings.Update("ckbBanBe", this.ckbBanBe.Checked);
			this.settings.Update("ckbNhom", this.ckbNhom.Checked);
			this.settings.Update("ckbNgaySinh", this.ckbNgaySinh.Checked);
			this.settings.Update("ckbGioiTinh", this.ckbGioiTinh.Checked);
			this.settings.Update("ckbMatKhau", this.ckbMatKhau.Checked);
			this.settings.Update("ckbMatKhauMail", this.ckbMatKhauMail.Checked);
			this.settings.Update("ckbBackup", this.ckbBackup.Checked);
			this.settings.Update("ckbMa2FA", this.ckbMa2FA.Checked);
			this.settings.Update("ckbUseragent", this.ckbUseragent.Checked);
			this.settings.Update("ckbProxy", this.ckbProxy.Checked);
			this.settings.Update("ckbNgayTao", this.ckbNgayTao.Checked);
			this.settings.Update("ckbAvatar", this.ckbAvatar.Checked);
			this.settings.Update("ckbProfile", this.ckbProfile.Checked);
			this.settings.Update("ckbTinhTrang", this.ckbTinhTrang.Checked);
			this.settings.Update("ckbThuMuc", this.ckbThuMuc.Checked);
			this.settings.Update("ckbGhiChu", this.ckbGhiChu.Checked);
			this.settings.Update("ckbFollow", this.ckbFollow.Checked);
			this.settings.Update("ckbInteractEnd", this.ckbInteractEnd.Checked);
			this.settings.Save("");
			base.Close();
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00054604 File Offset: 0x00052804
		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0011D704 File Offset: 0x0011B904
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.ckbToken.Checked = this.settings.GetValueBool("cToken", false);
			this.ckbCookie.Checked = this.settings.GetValueBool("ckbCookie", false);
			this.ckbEmail.Checked = this.settings.GetValueBool("ckbEmail", false);
			this.ckbTen.Checked = this.settings.GetValueBool("ckbTen", false);
			this.ckbBanBe.Checked = this.settings.GetValueBool("ckbBanBe", false);
			this.ckbNhom.Checked = this.settings.GetValueBool("ckbNhom", false);
			this.ckbNgaySinh.Checked = this.settings.GetValueBool("ckbNgaySinh", false);
			this.ckbGioiTinh.Checked = this.settings.GetValueBool("ckbGioiTinh", false);
			this.ckbMatKhau.Checked = this.settings.GetValueBool("ckbMatKhau", false);
			this.ckbMatKhauMail.Checked = this.settings.GetValueBool("ckbMatKhauMail", false);
			this.ckbBackup.Checked = this.settings.GetValueBool("ckbBackup", false);
			this.ckbMa2FA.Checked = this.settings.GetValueBool("ckbMa2FA", false);
			this.ckbUseragent.Checked = this.settings.GetValueBool("ckbUseragent", false);
			this.ckbProxy.Checked = this.settings.GetValueBool("ckbProxy", false);
			this.ckbNgayTao.Checked = this.settings.GetValueBool("ckbNgayTao", false);
			this.ckbAvatar.Checked = this.settings.GetValueBool("ckbAvatar", false);
			this.ckbProfile.Checked = this.settings.GetValueBool("ckbProfile", false);
			this.ckbTinhTrang.Checked = this.settings.GetValueBool("ckbTinhTrang", false);
			this.ckbThuMuc.Checked = this.settings.GetValueBool("ckbThuMuc", false);
			this.ckbGhiChu.Checked = this.settings.GetValueBool("ckbGhiChu", false);
			this.ckbFollow.Checked = this.settings.GetValueBool("ckbFollow", false);
			this.ckbInteractEnd.Checked = this.settings.GetValueBool("ckbInteractEnd", false);
		}

		// Token: 0x04000CCB RID: 3275
		private JSON_Settings settings;
	}
}
