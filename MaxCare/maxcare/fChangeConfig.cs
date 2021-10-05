using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000124 RID: 292
	public partial class fChangeConfig : Form
	{
		// Token: 0x06000D2C RID: 3372 RVA: 0x001E6820 File Offset: 0x001E4A20
		public fChangeConfig()
		{
			this.InitializeComponent();
			this.Load_cbbNgonNgu();
			this.settings = new JSON_Settings("configChange", false);
			this.LoadSettings();
			this.CheckedChangedFull();
			this.ChangeLanguage();
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x001E6880 File Offset: 0x001E4A80
		private void Load_cbbNgonNgu()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			List<string> listCountryCountryCode = SetupFolder.GetListCountryCountryCode();
			for (int i = 0; i < listCountryCountryCode.Count; i++)
			{
				string[] array = listCountryCountryCode[i].Split(new char[]
				{
					'|'
				});
				dictionary.Add(array[0], array[1]);
			}
			this.cbbNgonNgu.DataSource = new BindingSource(dictionary, null);
			this.cbbNgonNgu.ValueMember = "Key";
			this.cbbNgonNgu.DisplayMember = "Value";
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x001E6960 File Offset: 0x001E4B60
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox5);
			Language.GetValue(this.label10);
			Language.GetValue(this.label11);
			Language.GetValue(this.label14);
			Language.GetValue(this.label12);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.ckbCreateProfile);
			Language.GetValue(this.groupBox3);
			Language.GetValue(this.ckbDoiNgonNgu);
			Language.GetValue(this.ckbAddPhone);
			Language.GetValue(this.ckbDoiAvatar);
			Language.GetValue(this.ckbDoiAnhBia);
			Language.GetValue(this.ckbAutoDeleteFile);
			Language.GetValue(this.rdAnhNguoiDungDat);
			Language.GetValue(this.rdAnhNgheThuat);
			Language.GetValue(this.ckbThemMoTa);
			Language.GetValue(this.btnThemMoTa);
			Language.GetValue(this.ckbDoiNgaySinh);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label5);
			Language.GetValue(this.label6);
			Language.GetValue(this.label7);
			Language.GetValue(this.label8);
			Language.GetValue(this.label9);
			Language.GetValue(this.label13);
			Language.GetValue(this.ckbCapNhatThongTin);
			Language.GetValue(this.btnCapNhatThongTin);
			Language.GetValue(this.button3);
			Language.GetValue(this.button4);
			Language.GetValue(this.button5);
			Language.GetValue(this.button9);
			Language.GetValue(this.ckbAddMail);
			Language.GetValue(this.btnNhapHotmail);
			Language.GetValue(this.ckbAnMailMoi);
			Language.GetValue(this.ckbXoaMailCu);
			Language.GetValue(this.ckbDoiTen);
			Language.GetValue(this.rdTenTuDat);
			Language.GetValue(this.button6);
			Language.GetValue(this.button7);
			Language.GetValue(this.button8);
			Language.GetValue(this.rdTenRandom);
			Language.GetValue(this.rdTenRandomViet);
			Language.GetValue(this.rdTenRandomNgoai);
			Language.GetValue(this.ckb2fa);
			Language.GetValue(this.rdBat2fa);
			Language.GetValue(this.rdTat2fa);
			Language.GetValue(this.ckbDoiPass);
			Language.GetValue(this.rdPassTuNhap);
			Language.GetValue(this.btnNhapPass);
			Language.GetValue(this.rdPassRandom);
			Language.GetValue(this.ckbXoaSdt);
			Language.GetValue(this.ckbLogOut);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x001E6D38 File Offset: 0x001E4F38
		private void LoadSettings()
		{
			this.nudThread.Value = this.settings.GetValueInt("change_nudThread", 3);
			this.ckbVerify.Checked = this.settings.GetValueBool("change_ckbVerify", false);
			this.ckbDoiNgonNgu.Checked = this.settings.GetValueBool("change_ckbDoiNgonNgu", false);
			this.cbbNgonNgu.SelectedValue = this.settings.GetValue("change_cbbNgonNgu", "vi_VN");
			this.ckbAddPhone.Checked = this.settings.GetValueBool("change_ckbAddPhone", false);
			this.txtPhone.Text = this.settings.GetValue("change_txtPhone", "09xxxxxxxx");
			this.txtPathAvatar.Text = this.settings.GetValue("change_txtPathAvatar", "");
			this.txtPathCover.Text = this.settings.GetValue("change_txtPathCover", "");
			this.ckbDoiAvatar.Checked = this.settings.GetValueBool("change_ckbDoiAvatar", false);
			this.ckbAvatarThuTu.Checked = this.settings.GetValueBool("change_ckbAvatarThuTu", false);
			this.ckbDoiAnhBia.Checked = this.settings.GetValueBool("change_ckbDoiAnhBia", false);
			int valueInt = this.settings.GetValueInt("change_typeUpCover", 0);
			bool flag = valueInt == 0;
			if (flag)
			{
				this.rdAnhNguoiDungDat.Checked = true;
			}
			else
			{
				this.rdAnhNgheThuat.Checked = true;
			}
			this.ckbCoverThuTu.Checked = this.settings.GetValueBool("change_ckbCoverThuTu", false);
			this.ckbThemMoTa.Checked = this.settings.GetValueBool("change_ckbThemMoTa", false);
			this.ckbCapNhatThongTin.Checked = this.settings.GetValueBool("change_ckbCapNhatThongTin", false);
			this.ckbDoiNgaySinh.Checked = this.settings.GetValueBool("change_ckbDoiNgaySinh", false);
			this.nudNgayFrom.Value = this.settings.GetValueInt("change_nudNgayFrom", 1);
			this.nudNgayTo.Value = this.settings.GetValueInt("change_nudNgayTo", 30);
			this.nudThangFrom.Value = this.settings.GetValueInt("change_nudThangFrom", 1);
			this.nudThangTo.Value = this.settings.GetValueInt("change_nudThangTo", 12);
			this.nudNamFrom.Value = this.settings.GetValueInt("change_nudNamFrom", 1980);
			this.nudNamTo.Value = this.settings.GetValueInt("change_nudNamTo", 2000);
			this.ckbGioiTinh.Checked = this.settings.GetValueBool("change_ckbGioiTinh", false);
			int valueInt2 = this.settings.GetValueInt("change_typeGioiTinh", 0);
			bool flag2 = valueInt2 == 0;
			if (flag2)
			{
				this.rbNu.Checked = true;
			}
			else
			{
				bool flag3 = valueInt2 == 1;
				if (flag3)
				{
					this.rbNam.Checked = true;
				}
			}
			this.ckbDoiTen.Checked = this.settings.GetValueBool("change_ckbDoiTen", false);
			int valueInt3 = this.settings.GetValueInt("change_typeDatTen", 0);
			bool flag4 = valueInt3 == 0;
			if (flag4)
			{
				this.rdTenTuDat.Checked = true;
			}
			else
			{
				this.rdTenRandom.Checked = true;
			}
			int valueInt4 = this.settings.GetValueInt("change_typeTenRandom", 0);
			bool flag5 = valueInt4 == 0;
			if (flag5)
			{
				this.rdTenRandomViet.Checked = true;
			}
			else
			{
				this.rdTenRandomNgoai.Checked = true;
			}
			this.ckbDoiPass.Checked = this.settings.GetValueBool("change_ckbDoiPass", false);
			int valueInt5 = this.settings.GetValueInt("change_typeDoiPass", 0);
			bool flag6 = valueInt5 == 0;
			if (flag6)
			{
				this.rdPassTuNhap.Checked = true;
			}
			else
			{
				this.rdPassRandom.Checked = true;
			}
			this.ckbChangePassLinkHacked.Checked = this.settings.GetValueBool("change_ckbDoiPassUseLinkHacked", false);
			this.ckb2fa.Checked = this.settings.GetValueBool("change_ckb2fa", false);
			int valueInt6 = this.settings.GetValueInt("change_type2fa", 0);
			bool flag7 = valueInt6 == 0;
			if (flag7)
			{
				this.rdBat2fa.Checked = true;
			}
			else
			{
				this.rdTat2fa.Checked = true;
			}
			this.ckbAddMail.Checked = this.settings.GetValueBool("ckbAddMail", false);
			this.ckbMailVip.Checked = this.settings.GetValueBool("ckbMailVip", false);
			this.ckbXoaMailCu.Checked = this.settings.GetValueBool("ckbXoaMailCu", false);
			this.ckbAnMailMoi.Checked = this.settings.GetValueBool("ckbAnMailMoi", false);
			this.ckbCloseChrome.Checked = this.settings.GetValueBool("ckbCloseChrome", false);
			this.ckbAddMailLinkHacked.Checked = this.settings.GetValueBool("ckbAddMailLinkHacked", false);
			this.txtPassMailHacked.Text = this.settings.GetValue("txtPassMailHacked", "");
			this.ckbRandomPassMailHacked.Checked = this.settings.GetValueBool("ckbRandomPassMailHacked", false);
			this.ckbAnMailAll.Checked = this.settings.GetValueBool("ckbAnMailAll", false);
			this.ckbXoaMailCu2.Checked = this.settings.GetValueBool("ckbXoaMailCu2", false);
			this.ckbLogOut.Checked = this.settings.GetValueBool("ckbLogOut", false);
			this.ckbXoaSdt.Checked = this.settings.GetValueBool("ckbXoaSdt", false);
			this.ckbXoaMail.Checked = this.settings.GetValueBool("ckbXoaMail", false);
			int valueInt7 = this.settings.GetValueInt("xoaMail", 0);
			bool flag8 = valueInt7 == 1;
			if (flag8)
			{
				this.rdXoaLinkHacked.Checked = true;
			}
			else
			{
				this.rdXoaTrucTiep.Checked = true;
			}
			this.ckbPassRandomXoaMail.Checked = this.settings.GetValueBool("ckbPassRandomXoaMail", false);
			this.ckbAutoDeleteFile.Checked = this.settings.GetValueBool("ckbAutoDeleteFile", false);
			bool flag9 = this.settings.GetValueInt("typeLogin", 0) == 0;
			if (flag9)
			{
				this.rbLoginUidPass.Checked = true;
			}
			else
			{
				this.rbLoginCookie.Checked = true;
			}
			bool flag10 = this.settings.GetValueInt("typeBrowserLogin", 0) == 0;
			if (flag10)
			{
				this.rbLoginMFB.Checked = true;
			}
			else
			{
				this.rbLoginWWW.Checked = true;
			}
			this.ckbCreateProfile.Checked = this.settings.GetValueBool("ckbCreateProfile", false);
			this.ckbGiaiCheckPoint.Checked = this.settings.GetValueBool("change_ckbGiaiCheckPoint", false);
			this.ckbXoaThietBiTinCay.Checked = this.settings.GetValueBool("change_ckbXoaThietBiTinCay", false);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x001E7BC8 File Offset: 0x001E5DC8
		private void SaveSettings()
		{
			this.settings.Update("change_nudThread", Convert.ToInt32(this.nudThread.Value));
			this.settings.Update("change_ckbVerify", this.ckbVerify.Checked);
			this.settings.Update("change_ckbDoiNgonNgu", this.ckbDoiNgonNgu.Checked);
			this.settings.Update("change_cbbNgonNgu", this.cbbNgonNgu.SelectedValue);
			this.settings.Update("change_ckbAddPhone", this.ckbAddPhone.Checked);
			this.settings.Update("change_txtPhone", this.txtPhone.Text);
			this.settings.Update("change_txtPathAvatar", this.txtPathAvatar.Text);
			this.settings.Update("change_ckbAvatarThuTu", this.ckbAvatarThuTu.Checked);
			this.settings.Update("change_txtPathCover", this.txtPathCover.Text);
			this.settings.Update("change_ckbDoiAvatar", this.ckbDoiAvatar.Checked);
			this.settings.Update("change_ckbDoiAnhBia", this.ckbDoiAnhBia.Checked);
			int num = 0;
			bool @checked = this.rdAnhNgheThuat.Checked;
			if (@checked)
			{
				num = 1;
			}
			this.settings.Update("change_typeUpCover", num);
			this.settings.Update("change_ckbThemMoTa", this.ckbThemMoTa.Checked);
			this.settings.Update("change_ckbCapNhatThongTin", this.ckbCapNhatThongTin.Checked);
			this.settings.Update("change_ckbCoverThuTu", this.ckbCoverThuTu.Checked);
			this.settings.Update("change_ckbDoiNgaySinh", this.ckbDoiNgaySinh.Checked);
			this.settings.Update("change_nudNgayFrom", Convert.ToInt32(this.nudNgayFrom.Value));
			this.settings.Update("change_nudNgayTo", Convert.ToInt32(this.nudNgayTo.Value));
			this.settings.Update("change_nudThangFrom", Convert.ToInt32(this.nudThangFrom.Value));
			this.settings.Update("change_nudThangTo", Convert.ToInt32(this.nudThangTo.Value));
			this.settings.Update("change_nudNamFrom", Convert.ToInt32(this.nudNamFrom.Value));
			this.settings.Update("change_nudNamTo", Convert.ToInt32(this.nudNamTo.Value));
			this.settings.Update("change_ckbGioiTinh", this.ckbGioiTinh.Checked);
			int num2 = 0;
			bool checked2 = this.rbNam.Checked;
			if (checked2)
			{
				num2 = 1;
			}
			this.settings.Update("change_typeGioiTinh", num2);
			this.settings.Update("change_ckbDoiTen", this.ckbDoiTen.Checked);
			int num3 = 0;
			bool checked3 = this.rdTenRandom.Checked;
			if (checked3)
			{
				num3 = 1;
			}
			this.settings.Update("change_typeDatTen", num3);
			int num4 = 0;
			bool checked4 = this.rdTenRandomNgoai.Checked;
			if (checked4)
			{
				num4 = 1;
			}
			this.settings.Update("change_typeTenRandom", num4);
			this.settings.Update("change_ckbDoiPass", this.ckbDoiPass.Checked);
			int num5 = 0;
			bool checked5 = this.rdPassRandom.Checked;
			if (checked5)
			{
				num5 = 1;
			}
			this.settings.Update("change_typeDoiPass", num5);
			this.settings.Update("change_ckbDoiPassUseLinkHacked", this.ckbChangePassLinkHacked.Checked);
			this.settings.Update("change_ckb2fa", this.ckb2fa.Checked);
			int num6 = 0;
			bool checked6 = this.rdTat2fa.Checked;
			if (checked6)
			{
				num6 = 1;
			}
			this.settings.Update("change_type2fa", num6);
			this.settings.Update("ckbAddMail", this.ckbAddMail.Checked.ToString());
			this.settings.Update("themMail", 1);
			this.settings.Update("ckbMailVip", this.ckbMailVip.Checked.ToString());
			this.settings.Update("ckbXoaMailCu", this.ckbXoaMailCu.Checked.ToString());
			this.settings.Update("ckbAnMailMoi", this.ckbAnMailMoi.Checked.ToString());
			this.settings.Update("ckbCloseChrome", this.ckbCloseChrome.Checked.ToString());
			this.settings.Update("ckbAddMailLinkHacked", this.ckbAddMailLinkHacked.Checked.ToString());
			this.settings.Update("txtPassMailHacked", this.txtPassMailHacked.Text.Trim());
			this.settings.Update("ckbRandomPassMailHacked", this.ckbRandomPassMailHacked.Checked);
			this.settings.Update("ckbAnMailAll", this.ckbAnMailAll.Checked);
			this.settings.Update("ckbXoaMailCu2", this.ckbXoaMailCu2.Checked);
			this.settings.Update("ckbLogOut", this.ckbLogOut.Checked.ToString());
			this.settings.Update("ckbXoaSdt", this.ckbXoaSdt.Checked);
			this.settings.Update("ckbXoaMail", this.ckbXoaMail.Checked);
			int num7 = 0;
			bool checked7 = this.rdXoaLinkHacked.Checked;
			if (checked7)
			{
				num7 = 1;
			}
			this.settings.Update("xoaMail", num7.ToString());
			this.settings.Update("ckbPassRandomXoaMail", this.ckbPassRandomXoaMail.Checked);
			this.settings.Update("ckbAutoDeleteFile", this.ckbAutoDeleteFile.Checked);
			bool checked8 = this.rbLoginUidPass.Checked;
			if (checked8)
			{
				this.settings.Update("typeLogin", 0);
			}
			else
			{
				this.settings.Update("typeLogin", 1);
			}
			int num8 = this.rbLoginMFB.Checked ? 0 : 1;
			this.settings.Update("typeBrowserLogin", num8);
			this.settings.Update("ckbCreateProfile", this.ckbCreateProfile.Checked);
			this.settings.Update("change_ckbGiaiCheckPoint", this.ckbGiaiCheckPoint.Checked);
			this.settings.Update("change_ckbXoaThietBiTinCay", this.ckbXoaThietBiTinCay.Checked);
			this.settings.Save("");
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00054604 File Offset: 0x00052804
		private void fShareConfig_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00072804 File Offset: 0x00070A04
		private void btnOpenShare_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fCauHinhChung());
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00054604 File Offset: 0x00052804
		private void groupBox5_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00054604 File Offset: 0x00052804
		private void ChứcNăngToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x001E898C File Offset: 0x001E6B8C
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveSettings();
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Lưu thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
				if (flag)
				{
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x001E8A30 File Offset: 0x001E6C30
		private void CheckedChangedFull()
		{
			this.ckbDoiNgonNgu_CheckedChanged(null, null);
			this.ckbAddPhone_CheckedChanged(null, null);
			this.ckbDoiAvatar_CheckedChanged(null, null);
			this.ckbDoiAnhBia_CheckedChanged(null, null);
			this.rdAnhNguoiDungDat_CheckedChanged(null, null);
			this.ckbThemMoTa_CheckedChanged(null, null);
			this.ckbCapNhatThongTin_CheckedChanged(null, null);
			this.ckbDoiTen_CheckedChanged(null, null);
			this.rdTenTuDat_CheckedChanged(null, null);
			this.rdTenRandom_CheckedChanged(null, null);
			this.ckbDoiPass_CheckedChanged(null, null);
			this.rdPassTuNhap_CheckedChanged(null, null);
			this.ckb2fa_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
			this.ckbAddMail_CheckedChanged(null, null);
			this.rdXoaLinkHacked_CheckedChanged(null, null);
			this.ckbXoaMail_CheckedChanged(null, null);
			this.ckbPassRandomXoaMail_CheckedChanged(null, null);
			this.ckbCloseChrome_CheckedChanged(null, null);
			this.ckbGioiTinh_CheckedChanged(null, null);
			this.ckbGiaiCheckPoint_CheckedChanged(null, null);
			this.ckbAnMailMoi_CheckedChanged(null, null);
			this.ckbXoaMailCu_CheckedChanged(null, null);
			this.ckbAnMailAll_CheckedChanged(null, null);
			this.ckbXoaMailCu2_CheckedChanged(null, null);
			this.ckbAddMailLinkHacked_CheckedChanged(null, null);
			this.ckbRandomPassMailHacked_CheckedChanged(null, null);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x001E8BB8 File Offset: 0x001E6DB8
		private void ckbDoiNgonNgu_CheckedChanged(object sender, EventArgs e)
		{
			this.cbbNgonNgu.Enabled = this.ckbDoiNgonNgu.Checked;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x001E8BE8 File Offset: 0x001E6DE8
		private void ckbAddPhone_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPhone.Enabled = this.ckbAddPhone.Checked;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x001E8C18 File Offset: 0x001E6E18
		private void ckbDoiAvatar_CheckedChanged(object sender, EventArgs e)
		{
			this.plAvatar.Enabled = this.ckbDoiAvatar.Checked;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x001E8C48 File Offset: 0x001E6E48
		private void ckbDoiAnhBia_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiAnhBia.Enabled = this.ckbDoiAnhBia.Checked;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x001E8C78 File Offset: 0x001E6E78
		private void rdAnhNguoiDungDat_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPathCover.Enabled = this.rdAnhNguoiDungDat.Checked;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x001E8CA8 File Offset: 0x001E6EA8
		private void ckbThemMoTa_CheckedChanged(object sender, EventArgs e)
		{
			this.btnThemMoTa.Enabled = this.ckbThemMoTa.Checked;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x001E8CD8 File Offset: 0x001E6ED8
		private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
		{
			this.panel3.Enabled = this.ckbCapNhatThongTin.Checked;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x001E8D08 File Offset: 0x001E6F08
		private void ckbDoiTen_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiTen.Enabled = this.ckbDoiTen.Checked;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x001E8D38 File Offset: 0x001E6F38
		private void rdTenTuDat_CheckedChanged(object sender, EventArgs e)
		{
			this.plTenTuDat.Enabled = this.rdTenTuDat.Checked;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x001E8D68 File Offset: 0x001E6F68
		private void rdTenRandom_CheckedChanged(object sender, EventArgs e)
		{
			this.plTenNgauNhien.Enabled = this.rdTenRandom.Checked;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x001E8D98 File Offset: 0x001E6F98
		private void ckbDoiPass_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiMatKhau.Enabled = this.ckbDoiPass.Checked;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x001E8DC8 File Offset: 0x001E6FC8
		private void rdPassTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.btnNhapPass.Enabled = this.rdPassTuNhap.Checked;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x001E8DF8 File Offset: 0x001E6FF8
		private void btnOpenAvatar_Click(object sender, EventArgs e)
		{
			this.txtPathAvatar.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x001E8E1C File Offset: 0x001E701C
		private void btnAnhNguoiDungDat_Click(object sender, EventArgs e)
		{
			Process.Start("configschange\\anhbia");
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x001E8E48 File Offset: 0x001E7048
		private void btnThemMoTa_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fNhapDuLieu2("configschange\\tieusu", Language.GetValue("Nhập danh sách tiểu sử")));
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x001E8E90 File Offset: 0x001E7090
		private void btnCapNhatThongTin_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\thongtincanhan\\NoiLamViec.txt", Language.GetValue("Nhập danh sách Nơi làm việc"), Language.GetValue("Danh sách từ khóa"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x001E8F08 File Offset: 0x001E7108
		private void button6_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\doiten\\ho.txt", Language.GetValue("Nhập danh sách Họ"), Language.GetValue("Danh sách Họ"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x001E8F80 File Offset: 0x001E7180
		private void button7_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\doiten\\tendem.txt", Language.GetValue("Nhập danh sách Tên đệm"), Language.GetValue("Danh sách Tên đệm"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x001E8FF8 File Offset: 0x001E71F8
		private void button8_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\doiten\\ten.txt", Language.GetValue("Nhập danh sách Tên"), Language.GetValue("Danh sách Tên"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x001E9070 File Offset: 0x001E7270
		private void btnNhapPass_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\doimk.txt", Language.GetValue("Nhập danh sách mật khẩu cần đổi"), Language.GetValue("Danh sách mật khẩu"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x001E90E8 File Offset: 0x001E72E8
		private void ckb2fa_CheckedChanged(object sender, EventArgs e)
		{
			this.pl2fa.Enabled = this.ckb2fa.Checked;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x001E9118 File Offset: 0x001E7318
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.panel1.Enabled = this.ckbDoiNgaySinh.Checked;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x001E9148 File Offset: 0x001E7348
		private void btnOpenCover_Click(object sender, EventArgs e)
		{
			this.txtPathCover.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x001E916C File Offset: 0x001E736C
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\thongtincanhan\\QueQuan.txt", Language.GetValue("Nhập danh sách Quê quán"), Language.GetValue("Danh sách từ khóa"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x001E91E4 File Offset: 0x001E73E4
		private void button4_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\thongtincanhan\\ThanhPho.txt", Language.GetValue("Nhập danh sách Thành phố"), Language.GetValue("Danh sách từ khóa"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x001E925C File Offset: 0x001E745C
		private void button5_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\thongtincanhan\\TruongDH.txt", Language.GetValue("Nhập danh sách Trường ĐH"), Language.GetValue("Danh sách từ khóa"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x001E92D4 File Offset: 0x001E74D4
		private void button9_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\thongtincanhan\\TruongTHPT.txt", Language.GetValue("Nhập danh sách Trường THPT"), Language.GetValue("Danh sách từ khóa"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x001E934C File Offset: 0x001E754C
		private void btnNhapHotmail_Click(object sender, EventArgs e)
		{
			MCommon.Common.CreateFolder("configschange\\addmail");
			MCommon.Common.ShowForm(new fNhapMailAdd());
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x001E9380 File Offset: 0x001E7580
		private void ckbAddMail_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiMail.Enabled = this.ckbAddMail.Checked;
			this.ckbXoaMailCu2.Enabled = !this.ckbAddMail.Checked;
			this.ckbAnMailAll.Enabled = !this.ckbAddMail.Checked;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x001E9400 File Offset: 0x001E7600
		private void btnNhapPassXoaMail_Click(object sender, EventArgs e)
		{
			MCommon.Common.OpenFileAndPressData("configschange\\doimk2.txt", Language.GetValue("Nhập danh sách mật khẩu mới"), Language.GetValue("Danh sách mật khẩu"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x001E9478 File Offset: 0x001E7678
		private void ckbXoaMail_CheckedChanged(object sender, EventArgs e)
		{
			this.plXoaMail.Enabled = this.ckbXoaMail.Checked;
			bool @checked = this.ckbXoaMail.Checked;
			if (@checked)
			{
				bool flag = this.ckbAddMail.Checked && this.ckbXoaMailCu.Checked;
				if (flag)
				{
					this.ckbXoaMailCu.Checked = false;
				}
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x001E950C File Offset: 0x001E770C
		private void rdXoaLinkHacked_CheckedChanged(object sender, EventArgs e)
		{
			this.plXoaMailLinkHacked.Enabled = this.rdXoaLinkHacked.Checked;
			bool @checked = this.rdXoaLinkHacked.Checked;
			if (@checked)
			{
				this.ckbDoiPass.Checked = false;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x001E9568 File Offset: 0x001E7768
		private void ckbPassRandomXoaMail_CheckedChanged(object sender, EventArgs e)
		{
			this.btnNhapPassXoaMail.Enabled = !this.ckbPassRandomXoaMail.Checked;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x001E95A0 File Offset: 0x001E77A0
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbAutoDeleteFile.Visible = true;
			}
			bool flag2 = (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control;
			if (flag2)
			{
				this.panel6.Visible = true;
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbCloseChrome_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x001E964C File Offset: 0x001E784C
		private void button1_Click(object sender, EventArgs e)
		{
			MCommon.Common.CreateFolder("configschange\\verify");
			MCommon.Common.ShowForm(new fNhapDuLieu1("configschange\\verify\\hotmail.txt", "Nhập danh sách hotmail/outlook dùng để verify", "Danh sách email|pass mail", "(Mỗi nội dung 1 dòng)", null));
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x001E96D8 File Offset: 0x001E78D8
		private void ckbVerify_CheckedChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = this.ckbVerify.Checked;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x001E9708 File Offset: 0x001E7908
		private void ckbGioiTinh_CheckedChanged(object sender, EventArgs e)
		{
			this.panel5.Enabled = this.ckbGioiTinh.Checked;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x001E9738 File Offset: 0x001E7938
		private void ckbGiaiCheckPoint_CheckedChanged(object sender, EventArgs e)
		{
			this.btnConfigCheckpoint.Enabled = this.ckbGiaiCheckPoint.Checked;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x001E9768 File Offset: 0x001E7968
		private void btnConfigCheckpoint_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fCheckPoint());
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00054604 File Offset: 0x00052804
		private void groupBox3_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00054604 File Offset: 0x00052804
		private void plDoiMail_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbAnMailMoi_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbXoaMailCu_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbAnMailAll_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbXoaMailCu2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x001E9784 File Offset: 0x001E7984
		private void ckbAddMailLinkHacked_CheckedChanged(object sender, EventArgs e)
		{
			this.plPassMailHacked.Enabled = this.ckbAddMailLinkHacked.Checked;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x001E97B4 File Offset: 0x001E79B4
		private void ckbRandomPassMailHacked_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPassMailHacked.Enabled = !this.ckbRandomPassMailHacked.Checked;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00054604 File Offset: 0x00052804
		private void plDoiMatKhau_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x040015C3 RID: 5571
		private JSON_Settings settings;

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
