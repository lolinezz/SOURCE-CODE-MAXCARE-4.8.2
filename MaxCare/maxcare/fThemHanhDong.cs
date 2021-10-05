using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000121 RID: 289
	public partial class fThemHanhDong : Form
	{
		// Token: 0x06000CBB RID: 3259 RVA: 0x0000327E File Offset: 0x0000147E
		public fThemHanhDong(string id_KichBan)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.id_KichBan = id_KichBan;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x001D973C File Offset: 0x001D793C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.btnDocThongBao);
			Language.GetValue(this.metroButton2);
			Language.GetValue(this.metroButton3);
			Language.GetValue(this.metroButton12);
			Language.GetValue(this.metroButton11);
			Language.GetValue(this.metroButton10);
			Language.GetValue(this.metroButton4);
			Language.GetValue(this.metroButton19);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.metroButton29);
			Language.GetValue(this.metroButton34);
			Language.GetValue(this.metroButton8);
			Language.GetValue(this.metroButton7);
			Language.GetValue(this.metroButton6);
			Language.GetValue(this.metroButton5);
			Language.GetValue(this.groupBox4);
			Language.GetValue(this.metroButton14);
			Language.GetValue(this.metroButton13);
			Language.GetValue(this.metroButton18);
			Language.GetValue(this.metroButton16);
			Language.GetValue(this.metroButton9);
			Language.GetValue(this.metroButton15);
			Language.GetValue(this.metroButton17);
			Language.GetValue(this.groupBox5);
			Language.GetValue(this.metroButton38);
			Language.GetValue(this.metroButton23);
			Language.GetValue(this.metroButton21);
			Language.GetValue(this.metroButton22);
			Language.GetValue(this.metroButton20);
			Language.GetValue(this.groupBox3);
			Language.GetValue(this.metroButton26);
			Language.GetValue(this.metroButton25);
			Language.GetValue(this.metroButton31);
			Language.GetValue(this.metroButton27);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.metroButton24);
			Language.GetValue(this.metroButton36);
			Language.GetValue(this.metroButton37);
			Language.GetValue(this.groupBox6);
			Language.GetValue(this.metroButton28);
			Language.GetValue(this.metroButton32);
			Language.GetValue(this.metroButton33);
			Language.GetValue(this.metroButton35);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x001D9A48 File Offset: 0x001D7C48
		private void btnDocThongBao_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDocThongBao(this.id_KichBan, 0, ""));
			bool isSave = fHDDocThongBao.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x001D9AA0 File Offset: 0x001D7CA0
		private void metroButton2_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXemStory(this.id_KichBan, 0, ""));
			bool isSave = fHDXemStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x001D9AF8 File Offset: 0x001D7CF8
		private void metroButton3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXemWatch(this.id_KichBan, 0, ""));
			bool isSave = fHDXemWatch.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x001D9B50 File Offset: 0x001D7D50
		private void metroButton12_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDNhanTinBanBe(this.id_KichBan, 0, ""));
			bool isSave = fHDNhanTinBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x001D9BA8 File Offset: 0x001D7DA8
		private void metroButton11_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDChocBanBe(this.id_KichBan, 0, ""));
			bool isSave = fHDChocBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x001D9C00 File Offset: 0x001D7E00
		private void metroButton10_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDChucMungSinhNhat(this.id_KichBan, 0, ""));
			bool isSave = fHDChucMungSinhNhat.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x001D9C58 File Offset: 0x001D7E58
		private void metroButton4_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDPhanHoiTinNhan(this.id_KichBan, 0, ""));
			bool isSave = fHDPhanHoiTinNhan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x001D9CB0 File Offset: 0x001D7EB0
		private void metroButton8_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBaiVietNewsfeed(this.id_KichBan, 0, ""));
			bool isSave = fHDBaiVietNewsfeed.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x001D9D08 File Offset: 0x001D7F08
		private void metroButton7_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBaiVietBanBe(this.id_KichBan, 0, ""));
			bool isSave = fHDBaiVietBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x001D9D60 File Offset: 0x001D7F60
		private void metroButton6_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBaiVietNhom(this.id_KichBan, 0, ""));
			bool isSave = fHDBaiVietNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x001D9DB8 File Offset: 0x001D7FB8
		private void metroButton5_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBaiVietFanpage(this.id_KichBan, 0, ""));
			bool isSave = fHDBaiVietFanpage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x001D9E10 File Offset: 0x001D8010
		private void metroButton14_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanTheoTuKhoa(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanTheoTuKhoa.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x001D9E68 File Offset: 0x001D8068
		private void metroButton13_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanGoiY(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanGoiY.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00054604 File Offset: 0x00052804
		private void groupBox5_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x001D9EC0 File Offset: 0x001D80C0
		private void metroButton18_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXacNhanKetBan(this.id_KichBan, 0, ""));
			bool isSave = fHDXacNhanKetBan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x001D9F18 File Offset: 0x001D8118
		private void metroButton9_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanTepUid(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanTepUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x001D9F70 File Offset: 0x001D8170
		private void metroButton16_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanThanhVienNhom(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanThanhVienNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x001D9FC8 File Offset: 0x001D81C8
		private void metroButton15_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDHuyLoiMoiKetBan(this.id_KichBan, 0, ""));
			bool isSave = fHDHuyLoiMoiKetBan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x001DA020 File Offset: 0x001D8220
		private void metroButton17_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDHuyKetBan(this.id_KichBan, 0, ""));
			bool isSave = fHDHuyKetBan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x001DA078 File Offset: 0x001D8278
		private void metroButton23_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomUid(this.id_KichBan, 0, ""));
			bool isSave = fHDThamGiaNhomUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x001DA0D0 File Offset: 0x001D82D0
		private void metroButton19_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanVoiBanBeCuaUid(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanVoiBanBeCuaUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x001DA128 File Offset: 0x001D8328
		private void metroButton23_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomTuKhoa(this.id_KichBan, 0, ""));
			bool isSave = fHDThamGiaNhomTuKhoa.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x001DA180 File Offset: 0x001D8380
		private void metroButton22_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDRoiNhom(this.id_KichBan, 0, ""));
			bool isSave = fHDRoiNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x001DA1D8 File Offset: 0x001D83D8
		private void metroButton20_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDMoiBanBeVaoNhom(this.id_KichBan, 0, ""));
			bool isSave = fHDMoiBanBeVaoNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x001DA230 File Offset: 0x001D8430
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			bool flag = this.panel1.BorderStyle == BorderStyle.FixedSingle;
			if (flag)
			{
				int num = 1;
				int num2 = num / 2;
				using (Pen pen = new Pen(Color.DarkViolet, (float)num))
				{
					e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, this.panel1.ClientSize.Width - num, this.panel1.ClientSize.Height - num));
				}
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x001DA2F4 File Offset: 0x001D84F4
		private void metroButton1_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDTuongTacNewsfeed(this.id_KichBan, 0, ""));
			bool isSave = fHDTuongTacNewsfeed.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x001DA34C File Offset: 0x001D854C
		private void metroButton26_Click(object sender, EventArgs e)
		{
			try
			{
				MCommon.Common.ShowForm(new fHDBuffLikeComment(this.id_KichBan, 0, ""));
				bool isSave = fHDBuffLikeComment.isSave;
				if (isSave)
				{
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(ex, "metroButton26_Click");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng liên hệ Admin!"), 2);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x001DA40C File Offset: 0x001D860C
		private void metroButton31_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBuffFollowLikePage(this.id_KichBan, 0, ""));
			bool isSave = fHDBuffFollowLikePage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x001DA464 File Offset: 0x001D8664
		private void metroButton25_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBuffFollowCaNhan(this.id_KichBan, 0, ""));
			bool isSave = fHDBuffFollowCaNhan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x001DA4BC File Offset: 0x001D86BC
		private void metroButton28_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBackupData(this.id_KichBan, 0, ""));
			bool isSave = fHDBackupData.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x001DA514 File Offset: 0x001D8714
		private void metroButton19_Click_2(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDangStatus(this.id_KichBan, 0, ""));
			bool isSave = fHDDangStatus.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x001DA56C File Offset: 0x001D876C
		private void metroButton24_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDSpamBaiViet(this.id_KichBan, 0, ""));
			bool isSave = fHDSpamBaiViet.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x001DA5C4 File Offset: 0x001D87C4
		private void metroButton27_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBuffTinNhanProfile(this.id_KichBan, 0, ""));
			bool isSave = fHDBuffTinNhanProfile.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x001DA61C File Offset: 0x001D881C
		private void metroButton1_Click_2(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDSeedingByVideo(this.id_KichBan, 0, ""));
			bool isSave = fHDSeedingByVideo.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x001DA674 File Offset: 0x001D8874
		private void metroButton32_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDTruyCapWebsite(this.id_KichBan, 0, ""));
			bool isSave = fHDTruyCapWebsite.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x001DA6CC File Offset: 0x001D88CC
		private void metroButton32_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDTimKiemGoogle(this.id_KichBan, 0, ""));
			bool isSave = fHDTimKiemGoogle.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x001DA724 File Offset: 0x001D8924
		private void metroButton34_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDTuongTacBanBe(this.id_KichBan, 0, ""));
			bool isSave = fHDTuongTacBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x001DA77C File Offset: 0x001D897C
		private void metroButton30_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanTepUidNew(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanTepUidNew.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x001DA7D4 File Offset: 0x001D89D4
		private void metroButton35_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDNghiGiaiLao(this.id_KichBan, 0, ""));
			bool isSave = fHDNghiGiaiLao.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x001DA82C File Offset: 0x001D8A2C
		private void metroButton36_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDangBai(this.id_KichBan, 0, ""));
			bool isSave = fHDDangBai.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x001DA884 File Offset: 0x001D8A84
		private void metroButton37_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDShareBai(this.id_KichBan, 0, ""));
			bool isSave = fHDShareBai.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x001DA8DC File Offset: 0x001D8ADC
		private void metroButton38_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomGoiY(this.id_KichBan, 0, ""));
			bool isSave = fHDThamGiaNhomGoiY.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x001DA934 File Offset: 0x001D8B34
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				base.Height = 508;
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x001DA98C File Offset: 0x001D8B8C
		private void metroButton40_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanNewfeed(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanNewfeed.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x001DA9E4 File Offset: 0x001D8BE4
		private void metroButton41_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanVoiBanCuaBanBe(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanVoiBanCuaBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x001DA0D0 File Offset: 0x001D82D0
		private void metroButton39_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanVoiBanBeCuaUid(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanVoiBanBeCuaUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x001DAA3C File Offset: 0x001D8C3C
		private void metroButton30_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXemStoryChiDinh(this.id_KichBan, 0, ""));
			bool isSave = fHDXemStoryChiDinh.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x001DAA94 File Offset: 0x001D8C94
		private void metroButton40_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDangStory(this.id_KichBan, 0, ""));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton42_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x001DAAEC File Offset: 0x001D8CEC
		private void metroButton40_Click_2(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDocThongBaov2(this.id_KichBan, 0, ""));
			bool isSave = fHDDocThongBaov2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x001DAB44 File Offset: 0x001D8D44
		private void metroButton43_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanTepUidv2(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanTepUidv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x001DAB9C File Offset: 0x001D8D9C
		private void metroButton42_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDTuongTacNewsfeedv2(this.id_KichBan, 0, ""));
			bool isSave = fHDTuongTacNewsfeedv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x001DABF4 File Offset: 0x001D8DF4
		private void metroButton44_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomUidv2(this.id_KichBan, 0, ""));
			bool isSave = fHDThamGiaNhomUidv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x001DAC4C File Offset: 0x001D8E4C
		private void metroButton45_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDangStatusV2(this.id_KichBan, 0, ""));
			bool isSave = fHDDangStatusV2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x001DACA4 File Offset: 0x001D8EA4
		private void metroButton46_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDTuongTacBaiVietNhomv2(this.id_KichBan, 0, ""));
			bool isSave = fHDTuongTacBaiVietNhomv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x001DACFC File Offset: 0x001D8EFC
		private void metroButton47_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXacNhanKetBanv2(this.id_KichBan, 0, ""));
			bool isSave = fHDXacNhanKetBanv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x001DAD54 File Offset: 0x001D8F54
		private void metroButton49_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBuffViewVideo(this.id_KichBan, 0, ""));
			bool isSave = fHDBuffViewVideo.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x001DADAC File Offset: 0x001D8FAC
		private void metroButton48_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDTuongTacBaiVietTheoID(this.id_KichBan, 0, ""));
			bool isSave = fHDTuongTacBaiVietTheoID.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x001DAE04 File Offset: 0x001D9004
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			base.Width = 1462;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton52_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x001DAE24 File Offset: 0x001D9024
		private void metroButton54_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanTheoTuKhoav2(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanTheoTuKhoav2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x001DAE7C File Offset: 0x001D907C
		private void metroButton55_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanGoiYv2(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x001DAED4 File Offset: 0x001D90D4
		private void metroButton56_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDMoiLikePage(this.id_KichBan, 0, ""));
			bool isSave = fHDMoiLikePage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x001DAA94 File Offset: 0x001D8C94
		private void metroButton57_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDangStory(this.id_KichBan, 0, ""));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x001DAF2C File Offset: 0x001D912C
		private void metroButton59_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomTuKhoav2(this.id_KichBan, 0, ""));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x001DAF84 File Offset: 0x001D9184
		private void metroButton30_Click_2(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXoaBaiPage(this.id_KichBan, 0, ""));
			bool isSave = fHDXoaBaiPage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x001DAFDC File Offset: 0x001D91DC
		private void metroButton58_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomGoiYv2(this.id_KichBan, 0, ""));
			bool isSave = fHDThamGiaNhomGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x001DAE7C File Offset: 0x001D907C
		private void metroButton30_Click_3(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanGoiYv2(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x001DAE24 File Offset: 0x001D9024
		private void metroButton57_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDKetBanTheoTuKhoav2(this.id_KichBan, 0, ""));
			bool isSave = fHDKetBanTheoTuKhoav2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x001DAA3C File Offset: 0x001D8C3C
		private void metroButton61_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXemStoryChiDinh(this.id_KichBan, 0, ""));
			bool isSave = fHDXemStoryChiDinh.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x001DAA94 File Offset: 0x001D8C94
		private void metroButton62_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDangStory(this.id_KichBan, 0, ""));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x001DB034 File Offset: 0x001D9234
		private void metroButton50_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXemStoryv2(this.id_KichBan, 0, ""));
			bool isSave = fHDXemStoryv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x001DB08C File Offset: 0x001D928C
		private void metroButton51_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXemWatchv2(this.id_KichBan, 0, ""));
			bool isSave = fHDXemWatchv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton54_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton55_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x001DB0E4 File Offset: 0x001D92E4
		private void metroButton30_Click_5(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDXoaBaiTuong(this.id_KichBan, 0, ""));
			bool isSave = fHDXoaBaiTuong.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x001DB13C File Offset: 0x001D933C
		private void metroButton52_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomTuKhoav2(this.id_KichBan, 0, ""));
			bool isSave = fHDThamGiaNhomTuKhoav2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x001DAFDC File Offset: 0x001D91DC
		private void metroButton53_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDThamGiaNhomGoiYv2(this.id_KichBan, 0, ""));
			bool isSave = fHDThamGiaNhomGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton57_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x001DB194 File Offset: 0x001D9394
		private void metroButton58_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDPhanHoiBinhLuan(this.id_KichBan, 0, ""));
			bool isSave = fHDPhanHoiBinhLuan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x001DB1EC File Offset: 0x001D93EC
		private void metroButton57_Click_3(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDHuyLikePage(this.id_KichBan, 0, ""));
			bool isSave = fHDHuyLikePage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x001DB244 File Offset: 0x001D9444
		private void metroButton59_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDBaiVietTrenTuong(this.id_KichBan, 0, ""));
			bool isSave = fHDBaiVietTrenTuong.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x001DB29C File Offset: 0x001D949C
		private void metroButton60_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDDangBaiTheoID(this.id_KichBan, 0, ""));
			bool isSave = fHDDangBaiTheoID.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x001DB2F4 File Offset: 0x001D94F4
		private void metroButton61_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDChangeSoThich(this.id_KichBan, 0, ""));
			bool isSave = fHDChangeSoThich.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x001DB34C File Offset: 0x001D954C
		private void metroButton62_Click_1(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDChangeTenPhu(this.id_KichBan, 0, ""));
			bool isSave = fHDChangeTenPhu.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x001DB3A4 File Offset: 0x001D95A4
		private void metroButton63_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHDLinkToInstagram(this.id_KichBan, 0, ""));
			bool isSave = fHDLinkToInstagram.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x0400153E RID: 5438
		private string id_KichBan;

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
