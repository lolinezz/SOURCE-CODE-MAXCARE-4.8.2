using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x0200012E RID: 302
	public partial class fConfigInteract : Form
	{
		// Token: 0x06000DEA RID: 3562 RVA: 0x0000347A File Offset: 0x0000167A
		public fConfigInteract()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings("configInteract", false);
			this.ChangeLanguage();
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00212018 File Offset: 0x00210218
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox4);
			Language.GetValue(this.ckbTuongTacNewsfeed);
			Language.GetValue(this.label1);
			Language.GetValue(this.label64);
			Language.GetValue(this.label65);
			Language.GetValue(this.label24);
			Language.GetValue(this.label25);
			Language.GetValue(this.label29);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnTuongTacNewsfeedComment);
			Language.GetValue(this.ckbTuongTacFriend);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label68);
			Language.GetValue(this.label19);
			Language.GetValue(this.label67);
			Language.GetValue(this.label54);
			Language.GetValue(this.label46);
			Language.GetValue(this.label48);
			Language.GetValue(this.label47);
			Language.GetValue(this.label33);
			Language.GetValue(this.btnTuongTacFriendComment);
			Language.GetValue(this.ckbTuongTacFanpage);
			Language.GetValue(this.label91);
			Language.GetValue(this.button7);
			Language.GetValue(this.label56);
			Language.GetValue(this.label86);
			Language.GetValue(this.label87);
			Language.GetValue(this.label58);
			Language.GetValue(this.label57);
			Language.GetValue(this.label85);
			Language.GetValue(this.label60);
			Language.GetValue(this.label62);
			Language.GetValue(this.label61);
			Language.GetValue(this.label59);
			Language.GetValue(this.btnTuongTacFanpageComment);
			Language.GetValue(this.ckbTuongTacGroup);
			Language.GetValue(this.label7);
			Language.GetValue(this.label88);
			Language.GetValue(this.label89);
			Language.GetValue(this.label18);
			Language.GetValue(this.label55);
			Language.GetValue(this.label90);
			Language.GetValue(this.label51);
			Language.GetValue(this.label53);
			Language.GetValue(this.label52);
			Language.GetValue(this.label50);
			Language.GetValue(this.btnTuongTacGroupComment);
			Language.GetValue(this.groupBox5);
			Language.GetValue(this.ckbTuongTacNhanTin);
			Language.GetValue(this.label92);
			Language.GetValue(this.btnInbox);
			Language.GetValue(this.label41);
			Language.GetValue(this.label83);
			Language.GetValue(this.label84);
			Language.GetValue(this.label42);
			Language.GetValue(this.label44);
			Language.GetValue(this.label43);
			Language.GetValue(this.ckbTuongTacChoc);
			Language.GetValue(this.label36);
			Language.GetValue(this.label81);
			Language.GetValue(this.label82);
			Language.GetValue(this.label38);
			Language.GetValue(this.label40);
			Language.GetValue(this.label39);
			Language.GetValue(this.ckbTuongTacCMSN);
			Language.GetValue(this.label11);
			Language.GetValue(this.label79);
			Language.GetValue(this.label80);
			Language.GetValue(this.label35);
			Language.GetValue(this.label45);
			Language.GetValue(this.label37);
			Language.GetValue(this.label28);
			Language.GetValue(this.rbTuongTacCMSNNhanTin);
			Language.GetValue(this.rbTuongTacCMSNDangBai);
			Language.GetValue(this.label10);
			Language.GetValue(this.button2);
			Language.GetValue(this.groupBox8);
			Language.GetValue(this.ckbKetBanTuKhoa);
			Language.GetValue(this.label16);
			Language.GetValue(this.pictureBox2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label69);
			Language.GetValue(this.label70);
			Language.GetValue(this.label9);
			Language.GetValue(this.label15);
			Language.GetValue(this.label14);
			Language.GetValue(this.ckbKetBanGoiY);
			Language.GetValue(this.label2);
			Language.GetValue(this.label71);
			Language.GetValue(this.label72);
			Language.GetValue(this.label4);
			Language.GetValue(this.label6);
			Language.GetValue(this.label5);
			Language.GetValue(this.ckbKetBanTepUid);
			Language.GetValue(this.label17);
			Language.GetValue(this.button8);
			Language.GetValue(this.label20);
			Language.GetValue(this.label73);
			Language.GetValue(this.label74);
			Language.GetValue(this.label21);
			Language.GetValue(this.label23);
			Language.GetValue(this.label22);
			Language.GetValue(this.ckbKetBanTepUidTrungNhau);
			Language.GetValue(this.ckbXacNhanKetBan);
			Language.GetValue(this.label26);
			Language.GetValue(this.label75);
			Language.GetValue(this.label76);
			Language.GetValue(this.label31);
			Language.GetValue(this.label30);
			Language.GetValue(this.groupBox7);
			Language.GetValue(this.label12);
			Language.GetValue(this.button1);
			Language.GetValue(this.label13);
			Language.GetValue(this.label77);
			Language.GetValue(this.label78);
			Language.GetValue(this.label32);
			Language.GetValue(this.label63);
			Language.GetValue(this.label34);
			Language.GetValue(this.ckbThamGiaNhom);
			Language.GetValue(this.ckbThamGiaNhomTrungNhau);
			Language.GetValue(this.ckbThamGiaNhomTraLoiCauHoi);
			Language.GetValue(this.btnThamGiaNhomTraLoiCauHoi);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00212884 File Offset: 0x00210A84
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			this.LoadSetting();
			this.CheckedChangedFull();
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x002128AC File Offset: 0x00210AAC
		private void LoadSetting()
		{
			this.ckbTuongTacNewsfeed.Checked = this.settings.GetValueBool("ckbTuongTacNewsfeed", false);
			this.nudTuongTacNewsfeedSoLuongFrom.Value = this.settings.GetValueInt("nudTuongTacNewsfeedSoLuongFrom", 1);
			this.nudTuongTacNewsfeedSoLuongTo.Value = this.settings.GetValueInt("nudTuongTacNewsfeedSoLuongTo", 3);
			this.nudTuongTacNewsfeedDelayFrom.Value = this.settings.GetValueInt("nudTuongTacNewsfeedDelayFrom", 2);
			this.nudTuongTacNewsfeedDelayTo.Value = this.settings.GetValueInt("nudTuongTacNewsfeedDelayTo", 5);
			this.ckbTuongTacNewsfeedLike.Checked = this.settings.GetValueBool("ckbTuongTacNewsfeedLike", true);
			this.ckbTuongTacNewsfeedComment.Checked = this.settings.GetValueBool("ckbTuongTacNewsfeedComment", false);
			this.ckbTuongTacFriend.Checked = this.settings.GetValueBool("ckbTuongTacFriend", false);
			this.nudTuongTacFriendSoLuongBanBeFrom.Value = this.settings.GetValueInt("nudTuongTacFriendSoLuongBanBe", 1);
			this.nudTuongTacFriendSoLuongBaiVietFrom.Value = this.settings.GetValueInt("nudTuongTacFriendSoLuongBaiVietFrom", 1);
			this.nudTuongTacFriendSoLuongBaiVietTo.Value = this.settings.GetValueInt("nudTuongTacFriendSoLuongBaiVietTo", 3);
			this.nudTuongTacFriendDelayFrom.Value = this.settings.GetValueInt("nudTuongTacFriendDelayFrom", 2);
			this.nudTuongTacFriendDelayTo.Value = this.settings.GetValueInt("nudTuongTacFriendDelayTo", 5);
			this.ckbTuongTacFriendLike.Checked = this.settings.GetValueBool("ckbTuongTacFriendLike", true);
			this.ckbTuongTacFriendComment.Checked = this.settings.GetValueBool("ckbTuongTacFriendComment", true);
			this.ckbTuongTacGroup.Checked = this.settings.GetValueBool("ckbTuongTacGroup", false);
			this.nudTuongTacGroupSoLuongNhomFrom.Value = this.settings.GetValueInt("nudTuongTacGroupSoLuongNhomFrom", 1);
			this.nudTuongTacGroupSoLuongNhomTo.Value = this.settings.GetValueInt("nudTuongTacGroupSoLuongNhomTo", 3);
			this.nudTuongTacGroupSoLuongBaiVietFrom.Value = this.settings.GetValueInt("nudTuongTacGroupSoLuongBaiVietFrom", 1);
			this.nudTuongTacGroupSoLuongBaiVietTo.Value = this.settings.GetValueInt("nudTuongTacGroupSoLuongBaiVietTo", 1);
			this.nudTuongTacGroupDelayFrom.Value = this.settings.GetValueInt("nudTuongTacGroupDelayFrom", 2);
			this.nudTuongTacGroupDelayTo.Value = this.settings.GetValueInt("nudTuongTacGroupDelayTo", 5);
			this.ckbTuongTacGroupLike.Checked = this.settings.GetValueBool("ckbTuongTacGroupLike", true);
			this.ckbTuongTacGroupComment.Checked = this.settings.GetValueBool("ckbTuongTacGroupComment", false);
			this.ckbTuongTacFanpage.Checked = this.settings.GetValueBool("ckbTuongTacFanpage", false);
			this.nudTuongTacFanpageSoLuongPageFrom.Value = this.settings.GetValueInt("nudTuongTacFanpageSoLuongPageFrom", 1);
			this.nudTuongTacFanpageSoLuongPageTo.Value = this.settings.GetValueInt("nudTuongTacFanpageSoLuongPageTo", 1);
			this.nudTuongTacFanpageSoLuongBaiVietFrom.Value = this.settings.GetValueInt("nudTuongTacFanpageSoLuongBaiVietFrom", 2);
			this.nudTuongTacFanpageSoLuongBaiVietTo.Value = this.settings.GetValueInt("nudTuongTacFanpageSoLuongBaiVietTo", 2);
			this.nudTuongTacFanpageDelayFrom.Value = this.settings.GetValueInt("nudTuongTacFanpageDelayFrom", 2);
			this.nudTuongTacFanpageDelayTo.Value = this.settings.GetValueInt("nudTuongTacFanpageDelayTo", 5);
			this.ckbTuongTacFanpageLike.Checked = this.settings.GetValueBool("ckbTuongTacFanpageLike", true);
			this.ckbTuongTacFanpageComment.Checked = this.settings.GetValueBool("ckbTuongTacFanpageComment", false);
			this.ckbKetBanTuKhoa.Checked = this.settings.GetValueBool("ckbKetBanTuKhoa", false);
			this.txtKetBanTuKhoaTuKhoa.Text = this.settings.GetValue("txtKetBanTuKhoaTuKhoa", "");
			this.nudKetBanTuKhoaSoLuongFrom.Value = this.settings.GetValueInt("nudKetBanTuKhoaSoLuongFrom", 1);
			this.nudKetBanTuKhoaSoLuongTo.Value = this.settings.GetValueInt("nudKetBanTuKhoaSoLuongTo", 3);
			this.nudKetBanTuKhoaDelayFrom.Value = this.settings.GetValueInt("nudKetBanTuKhoaDelayFrom", 2);
			this.nudKetBanTuKhoaDelayTo.Value = this.settings.GetValueInt("nudKetBanTuKhoaDelayTo", 5);
			this.ckbKetBanGoiY.Checked = this.settings.GetValueBool("ckbKetBanGoiY", false);
			this.nudKetBanGoiYSoLuongFrom.Value = this.settings.GetValueInt("nudKetBanGoiYSoLuongFrom", 1);
			this.nudKetBanGoiYSoLuongTo.Value = this.settings.GetValueInt("nudKetBanGoiYSoLuongTo", 3);
			this.nudKetBanGoiYDelayFrom.Value = this.settings.GetValueInt("nudKetBanGoiYDelayFrom", 2);
			this.nudKetBanGoiYDelayTo.Value = this.settings.GetValueInt("nudKetBanGoiYDelayTo", 5);
			this.ckbKetBanTepUid.Checked = this.settings.GetValueBool("ckbKetBanTepUid", false);
			this.nudKetBanTepUidSoLuongFrom.Value = this.settings.GetValueInt("nudKetBanTepUidSoLuongFrom", 1);
			this.nudKetBanTepUidSoLuongTo.Value = this.settings.GetValueInt("nudKetBanTepUidSoLuongTo", 3);
			this.nudKetBanTepUidDelayFrom.Value = this.settings.GetValueInt("nudKetBanTepUidDelayFrom", 2);
			this.nudKetBanTepUidDelayTo.Value = this.settings.GetValueInt("nudKetBanTepUidDelayTo", 5);
			this.ckbKetBanTepUidTrungNhau.Checked = this.settings.GetValueBool("ckbKetBanTepUidTrungNhau", false);
			this.ckbXacNhanKetBan.Checked = this.settings.GetValueBool("ckbXacNhanKetBan", false);
			this.nudXacNhanKetBanSoLuongFrom.Value = this.settings.GetValueInt("nudXacNhanKetBanSoLuongFrom", 1);
			this.nudXacNhanKetBanSoLuongTo.Value = this.settings.GetValueInt("nudXacNhanKetBanSoLuongTo", 3);
			this.nudXacNhanKetBanDelayFrom.Value = this.settings.GetValueInt("nudXacNhanKetBanDelayFrom", 2);
			this.nudXacNhanKetBanDelayTo.Value = this.settings.GetValueInt("nudXacNhanKetBanDelayTo", 5);
			this.ckbTuongTacNhanTin.Checked = this.settings.GetValueBool("ckbTuongTacNhanTin", false);
			this.nudTuongTacNhanTinSoLuongFrom.Value = this.settings.GetValueInt("nudTuongTacNhanTinSoLuongFrom", 1);
			this.nudTuongTacNhanTinSoLuongTo.Value = this.settings.GetValueInt("nudTuongTacNhanTinSoLuongTo", 3);
			this.nudTuongTacNhanTinDelayFrom.Value = this.settings.GetValueInt("nudTuongTacNhanTinDelayFrom", 2);
			this.nudTuongTacNhanTinDelayTo.Value = this.settings.GetValueInt("nudTuongTacNhanTinDelayTo", 5);
			this.ckbTuongTacChoc.Checked = this.settings.GetValueBool("ckbTuongTacChoc", false);
			this.nudTuongTacChocSoLuongFrom.Value = this.settings.GetValueInt("nudTuongTacChocSoLuongFrom", 1);
			this.nudTuongTacChocSoLuongTo.Value = this.settings.GetValueInt("nudTuongTacChocSoLuongTo", 3);
			this.nudTuongTacChocSoLuongDelayFrom.Value = this.settings.GetValueInt("nudTuongTacChocSoLuongDelayFrom", 2);
			this.nudTuongTacChocSoLuongDelayTo.Value = this.settings.GetValueInt("nudTuongTacChocSoLuongDelayTo", 5);
			this.ckbTuongTacCMSN.Checked = this.settings.GetValueBool("ckbTuongTacCMSN", false);
			this.nudTuongTacCMSNSoLuongFrom.Value = this.settings.GetValueInt("nudTuongTacCMSNSoLuongFrom", 1);
			this.nudTuongTacCMSNSoLuongTo.Value = this.settings.GetValueInt("nudTuongTacCMSNSoLuongTo", 3);
			this.nudTuongTacCMSNDelayFrom.Value = this.settings.GetValueInt("nudTuongTacCMSNDelayFrom", 2);
			this.nudTuongTacCMSNDelayTo.Value = this.settings.GetValueInt("nudTuongTacCMSNDelayTo", 5);
			bool flag = this.settings.GetValueInt("TuongTacCMSNTypeAction", 0) == 0;
			if (flag)
			{
				this.rbTuongTacCMSNNhanTin.Checked = true;
			}
			else
			{
				this.rbTuongTacCMSNDangBai.Checked = true;
			}
			this.ckbThamGiaNhom.Checked = this.settings.GetValueBool("ckbThamGiaNhom", false);
			this.nudThamGiaNhomSoLuongFrom.Value = this.settings.GetValueInt("nudThamGiaNhomSoLuongFrom", 1);
			this.nudThamGiaNhomSoLuongTo.Value = this.settings.GetValueInt("nudThamGiaNhomSoLuongTo", 3);
			this.nudThamGiaNhomDelayFrom.Value = this.settings.GetValueInt("nudThamGiaNhomDelayFrom", 2);
			this.nudThamGiaNhomDelayTo.Value = this.settings.GetValueInt("nudThamGiaNhomDelayTo", 5);
			this.ckbThamGiaNhomTraLoiCauHoi.Checked = this.settings.GetValueBool("ckbThamGiaNhomTraLoiCauHoi", false);
			this.ckbThamGiaNhomTrungNhau.Checked = this.settings.GetValueBool("ckbThamGiaNhomTrungNhau", false);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00213BFC File Offset: 0x00211DFC
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update("ckbTuongTacNewsfeed", this.ckbTuongTacNewsfeed.Checked);
			this.settings.Update("nudTuongTacNewsfeedSoLuongFrom", Convert.ToInt32(this.nudTuongTacNewsfeedSoLuongFrom.Value));
			this.settings.Update("nudTuongTacNewsfeedSoLuongTo", Convert.ToInt32(this.nudTuongTacNewsfeedSoLuongTo.Value));
			this.settings.Update("nudTuongTacNewsfeedDelayFrom", Convert.ToInt32(this.nudTuongTacNewsfeedDelayFrom.Value));
			this.settings.Update("nudTuongTacNewsfeedDelayTo", Convert.ToInt32(this.nudTuongTacNewsfeedDelayTo.Value));
			this.settings.Update("ckbTuongTacNewsfeedLike", this.ckbTuongTacNewsfeedLike.Checked);
			this.settings.Update("ckbTuongTacNewsfeedComment", this.ckbTuongTacNewsfeedComment.Checked);
			this.settings.Update("ckbTuongTacFriend", this.ckbTuongTacFriend.Checked);
			this.settings.Update("nudTuongTacFriendSoLuongBanBeFrom", Convert.ToInt32(this.nudTuongTacFriendSoLuongBanBeFrom.Value));
			this.settings.Update("nudTuongTacFriendSoLuongBanBeTo", Convert.ToInt32(this.nudTuongTacFriendSoLuongBanBeTo.Value));
			this.settings.Update("nudTuongTacFriendSoLuongBaiVietFrom", Convert.ToInt32(this.nudTuongTacFriendSoLuongBaiVietFrom.Value));
			this.settings.Update("nudTuongTacFriendSoLuongBaiVietTo", Convert.ToInt32(this.nudTuongTacFriendSoLuongBaiVietTo.Value));
			this.settings.Update("nudTuongTacFriendDelayFrom", Convert.ToInt32(this.nudTuongTacFriendDelayFrom.Value));
			this.settings.Update("nudTuongTacFriendDelayTo", Convert.ToInt32(this.nudTuongTacFriendDelayTo.Value));
			this.settings.Update("ckbTuongTacFriendLike", this.ckbTuongTacFriendLike.Checked);
			this.settings.Update("ckbTuongTacFriendComment", this.ckbTuongTacFriendComment.Checked);
			this.settings.Update("ckbTuongTacGroup", this.ckbTuongTacGroup.Checked);
			this.settings.Update("nudTuongTacGroupSoLuongNhomFrom", Convert.ToInt32(this.nudTuongTacGroupSoLuongNhomFrom.Value));
			this.settings.Update("nudTuongTacGroupSoLuongNhomTo", Convert.ToInt32(this.nudTuongTacGroupSoLuongNhomTo.Value));
			this.settings.Update("nudTuongTacGroupSoLuongBaiVietFrom", Convert.ToInt32(this.nudTuongTacGroupSoLuongBaiVietFrom.Value));
			this.settings.Update("nudTuongTacGroupSoLuongBaiVietTo", Convert.ToInt32(this.nudTuongTacGroupSoLuongBaiVietTo.Value));
			this.settings.Update("nudTuongTacGroupDelayFrom", Convert.ToInt32(this.nudTuongTacGroupDelayFrom.Value));
			this.settings.Update("nudTuongTacGroupDelayTo", Convert.ToInt32(this.nudTuongTacGroupDelayTo.Value));
			this.settings.Update("ckbTuongTacGroupLike", this.ckbTuongTacGroupLike.Checked);
			this.settings.Update("ckbTuongTacGroupComment", this.ckbTuongTacGroupComment.Checked);
			this.settings.Update("ckbTuongTacFanpage", this.ckbTuongTacFanpage.Checked);
			this.settings.Update("nudTuongTacFanpageSoLuongPageFrom", Convert.ToInt32(this.nudTuongTacFanpageSoLuongPageFrom.Value));
			this.settings.Update("nudTuongTacFanpageSoLuongPageTo", Convert.ToInt32(this.nudTuongTacFanpageSoLuongPageTo.Value));
			this.settings.Update("nudTuongTacFanpageSoLuongBaiVietFrom", Convert.ToInt32(this.nudTuongTacFanpageSoLuongBaiVietFrom.Value));
			this.settings.Update("nudTuongTacFanpageSoLuongBaiVietTo", Convert.ToInt32(this.nudTuongTacFanpageSoLuongBaiVietTo.Value));
			this.settings.Update("nudTuongTacFanpageDelayFrom", Convert.ToInt32(this.nudTuongTacFanpageDelayFrom.Value));
			this.settings.Update("nudTuongTacFanpageDelayTo", Convert.ToInt32(this.nudTuongTacFanpageDelayTo.Value));
			this.settings.Update("ckbTuongTacFanpageLike", this.ckbTuongTacFanpageLike.Checked);
			this.settings.Update("ckbTuongTacFanpageComment", this.ckbTuongTacFanpageComment.Checked);
			this.settings.Update("ckbKetBanTuKhoa", this.ckbKetBanTuKhoa.Checked);
			this.settings.Update("txtKetBanTuKhoaTuKhoa", this.txtKetBanTuKhoaTuKhoa.Text);
			this.settings.Update("nudKetBanTuKhoaSoLuongFrom", Convert.ToInt32(this.nudKetBanTuKhoaSoLuongFrom.Value));
			this.settings.Update("nudKetBanTuKhoaSoLuongTo", Convert.ToInt32(this.nudKetBanTuKhoaSoLuongTo.Value));
			this.settings.Update("nudKetBanTuKhoaDelayFrom", Convert.ToInt32(this.nudKetBanTuKhoaDelayFrom.Value));
			this.settings.Update("nudKetBanTuKhoaDelayTo", Convert.ToInt32(this.nudKetBanTuKhoaDelayTo.Value));
			this.settings.Update("ckbKetBanGoiY", this.ckbKetBanGoiY.Checked);
			this.settings.Update("nudKetBanGoiYSoLuongFrom", Convert.ToInt32(this.nudKetBanGoiYSoLuongFrom.Value));
			this.settings.Update("nudKetBanGoiYSoLuongTo", Convert.ToInt32(this.nudKetBanGoiYSoLuongTo.Value));
			this.settings.Update("nudKetBanGoiYDelayFrom", Convert.ToInt32(this.nudKetBanGoiYDelayFrom.Value));
			this.settings.Update("nudKetBanGoiYDelayTo", Convert.ToInt32(this.nudKetBanGoiYDelayTo.Value));
			this.settings.Update("ckbKetBanTepUid", this.ckbKetBanTepUid.Checked);
			this.settings.Update("nudKetBanTepUidSoLuongFrom", Convert.ToInt32(this.nudKetBanTepUidSoLuongFrom.Value));
			this.settings.Update("nudKetBanTepUidSoLuongTo", Convert.ToInt32(this.nudKetBanTepUidSoLuongTo.Value));
			this.settings.Update("nudKetBanTepUidDelayFrom", Convert.ToInt32(this.nudKetBanTepUidDelayFrom.Value));
			this.settings.Update("nudKetBanTepUidDelayTo", Convert.ToInt32(this.nudKetBanTepUidDelayTo.Value));
			this.settings.Update("ckbKetBanTepUidTrungNhau", this.ckbKetBanTepUidTrungNhau.Checked);
			this.settings.Update("ckbXacNhanKetBan", this.ckbXacNhanKetBan.Checked);
			this.settings.Update("nudXacNhanKetBanSoLuongFrom", Convert.ToInt32(this.nudXacNhanKetBanSoLuongFrom.Value));
			this.settings.Update("nudXacNhanKetBanSoLuongTo", Convert.ToInt32(this.nudXacNhanKetBanSoLuongTo.Value));
			this.settings.Update("nudXacNhanKetBanDelayFrom", Convert.ToInt32(this.nudXacNhanKetBanDelayFrom.Value));
			this.settings.Update("nudXacNhanKetBanDelayTo", Convert.ToInt32(this.nudXacNhanKetBanDelayTo.Value));
			this.settings.Update("ckbTuongTacNhanTin", this.ckbTuongTacNhanTin.Checked);
			this.settings.Update("nudTuongTacNhanTinSoLuongFrom", Convert.ToInt32(this.nudTuongTacNhanTinSoLuongFrom.Value));
			this.settings.Update("nudTuongTacNhanTinSoLuongTo", Convert.ToInt32(this.nudTuongTacNhanTinSoLuongTo.Value));
			this.settings.Update("nudTuongTacNhanTinDelayFrom", Convert.ToInt32(this.nudTuongTacNhanTinDelayFrom.Value));
			this.settings.Update("nudTuongTacNhanTinDelayTo", Convert.ToInt32(this.nudTuongTacNhanTinDelayTo.Value));
			this.settings.Update("ckbTuongTacChoc", this.ckbTuongTacChoc.Checked);
			this.settings.Update("nudTuongTacChocSoLuongFrom", Convert.ToInt32(this.nudTuongTacChocSoLuongFrom.Value));
			this.settings.Update("nudTuongTacChocSoLuongTo", Convert.ToInt32(this.nudTuongTacChocSoLuongTo.Value));
			this.settings.Update("nudTuongTacChocSoLuongDelayFrom", Convert.ToInt32(this.nudTuongTacChocSoLuongDelayFrom.Value));
			this.settings.Update("nudTuongTacChocSoLuongDelayTo", Convert.ToInt32(this.nudTuongTacChocSoLuongDelayTo.Value));
			this.settings.Update("ckbTuongTacCMSN", this.ckbTuongTacCMSN.Checked);
			this.settings.Update("nudTuongTacCMSNSoLuongFrom", Convert.ToInt32(this.nudTuongTacCMSNSoLuongFrom.Value));
			this.settings.Update("nudTuongTacCMSNSoLuongTo", Convert.ToInt32(this.nudTuongTacCMSNSoLuongTo.Value));
			this.settings.Update("nudTuongTacCMSNDelayFrom", Convert.ToInt32(this.nudTuongTacCMSNDelayFrom.Value));
			this.settings.Update("nudTuongTacCMSNDelayTo", Convert.ToInt32(this.nudTuongTacCMSNDelayTo.Value));
			bool @checked = this.rbTuongTacCMSNNhanTin.Checked;
			if (@checked)
			{
				this.settings.Update("TuongTacCMSNTypeAction", 0);
			}
			else
			{
				this.settings.Update("TuongTacCMSNTypeAction", 1);
			}
			this.settings.Update("ckbThamGiaNhom", this.ckbThamGiaNhom.Checked);
			this.settings.Update("nudThamGiaNhomSoLuongFrom", Convert.ToInt32(this.nudThamGiaNhomSoLuongFrom.Value));
			this.settings.Update("nudThamGiaNhomSoLuongTo", Convert.ToInt32(this.nudThamGiaNhomSoLuongTo.Value));
			this.settings.Update("nudThamGiaNhomDelayFrom", Convert.ToInt32(this.nudThamGiaNhomDelayFrom.Value));
			this.settings.Update("nudThamGiaNhomDelayTo", Convert.ToInt32(this.nudThamGiaNhomDelayTo.Value));
			this.settings.Update("ckbThamGiaNhomTraLoiCauHoi", this.ckbThamGiaNhomTraLoiCauHoi.Checked);
			this.settings.Update("ckbThamGiaNhomTrungNhau", this.ckbThamGiaNhomTrungNhau.Checked);
			this.settings.Save("");
			bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Lưu thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00214FE8 File Offset: 0x002131E8
		private void BtnOpenComment_Click(object sender, EventArgs e)
		{
			Process.Start("comments.txt");
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00215014 File Offset: 0x00213214
		private void BtnUploadUid_Click(object sender, EventArgs e)
		{
			Process.Start("uidadddfriend.txt");
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00215040 File Offset: 0x00213240
		private void BtnUploadGroup_Click(object sender, EventArgs e)
		{
			Process.Start("groups.txt");
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0021506C File Offset: 0x0021326C
		private void Button1_Click(object sender, EventArgs e)
		{
			Process.Start("inboxs.txt");
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00215098 File Offset: 0x00213298
		private void CheckedChangedFull()
		{
			this.ckbTuongTacNewsfeed_CheckedChanged(null, null);
			this.ckbTuongTacFriend_CheckedChanged(null, null);
			this.ckbTuongTacGroup_CheckedChanged(null, null);
			this.ckbTuongTacFanpage_CheckedChanged(null, null);
			this.ckbKetBanTuKhoa_CheckedChanged(null, null);
			this.ckbKetBanTepUid_CheckedChanged(null, null);
			this.ckbKetBanGoiY_CheckedChanged(null, null);
			this.ckbTuongTacNhanTin_CheckedChanged(null, null);
			this.ckbTuongTacChoc_CheckedChanged(null, null);
			this.ckbTuongTacCMSN_CheckedChanged(null, null);
			this.ckbThamGiaNhom_CheckedChanged(null, null);
			this.ckbXacNhanKetBan_CheckedChanged(null, null);
			this.ckbTuongTacNewsfeedComment_CheckedChanged(null, null);
			this.ckbTuongTacFriendComment_CheckedChanged(null, null);
			this.ckbTuongTacGroupComment_CheckedChanged(null, null);
			this.ckbTuongTacFanpageComment_CheckedChanged(null, null);
			this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged(null, null);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00215194 File Offset: 0x00213394
		private void ckbTuongTacNewsfeed_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacNewsfeed.Enabled = this.ckbTuongTacNewsfeed.Checked;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x002151C4 File Offset: 0x002133C4
		private void ckbTuongTacFriend_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacFriend.Enabled = this.ckbTuongTacFriend.Checked;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x002151F4 File Offset: 0x002133F4
		private void ckbTuongTacGroup_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacGroup.Enabled = this.ckbTuongTacGroup.Checked;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00215224 File Offset: 0x00213424
		private void ckbTuongTacFanpage_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacFanpage.Enabled = this.ckbTuongTacFanpage.Checked;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00215254 File Offset: 0x00213454
		private void ckbKetBanTuKhoa_CheckedChanged(object sender, EventArgs e)
		{
			this.plKetBanTuKhoa.Enabled = this.ckbKetBanTuKhoa.Checked;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00215284 File Offset: 0x00213484
		private void ckbKetBanTepUid_CheckedChanged(object sender, EventArgs e)
		{
			this.plKetBanTepUid.Enabled = this.ckbKetBanTepUid.Checked;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x002152B4 File Offset: 0x002134B4
		private void ckbKetBanGoiY_CheckedChanged(object sender, EventArgs e)
		{
			this.plKetBanGoiY.Enabled = this.ckbKetBanGoiY.Checked;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x002152E4 File Offset: 0x002134E4
		private void ckbTuongTacNhanTin_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacNhanTin.Enabled = this.ckbTuongTacNhanTin.Checked;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00215314 File Offset: 0x00213514
		private void ckbTuongTacChoc_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacChoc.Enabled = this.ckbTuongTacChoc.Checked;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00215344 File Offset: 0x00213544
		private void ckbTuongTacCMSN_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacCMSN.Enabled = this.ckbTuongTacCMSN.Checked;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00215374 File Offset: 0x00213574
		private void ckbThamGiaNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plThamGiaNhom.Enabled = this.ckbThamGiaNhom.Checked;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x002153A4 File Offset: 0x002135A4
		private void ckbXacNhanKetBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plXacNhanKetBan.Enabled = this.ckbXacNhanKetBan.Checked;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x002153D4 File Offset: 0x002135D4
		private void btnOpenComment_Click_1(object sender, EventArgs e)
		{
			this.OpenFile("newsfeedcomments", Language.GetValue("Nhập danh sách bình luận"), Language.GetValue("Danh sách bình luận"), Language.GetValue("(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})"));
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00215454 File Offset: 0x00213654
		private void OpenFile(string nameFile, string title, string status, string footer)
		{
			try
			{
				string text = "reactions\\" + nameFile + ".txt";
				bool flag = !File.Exists(text);
				if (flag)
				{
					MCommon.Common.CreateFile(text);
				}
				MCommon.Common.ShowForm(new fNhapDuLieu1(text, title, status, footer, null));
			}
			catch
			{
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x002154FC File Offset: 0x002136FC
		private void button3_Click(object sender, EventArgs e)
		{
			this.OpenFile("friendcomments", Language.GetValue("Nhập danh sách bình luận"), Language.GetValue("Danh sách bình luận"), Language.GetValue("(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})"));
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0021557C File Offset: 0x0021377C
		private void button4_Click(object sender, EventArgs e)
		{
			this.OpenFile("groupcomments", Language.GetValue("Nhập danh sách bình luận"), Language.GetValue("Danh sách bình luận"), Language.GetValue("(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})"));
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x002155FC File Offset: 0x002137FC
		private void button7_Click(object sender, EventArgs e)
		{
			this.OpenFile("pages", Language.GetValue("Nhập danh sách ID page"), Language.GetValue("Danh sách ID page"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0021567C File Offset: 0x0021387C
		private void button6_Click(object sender, EventArgs e)
		{
			this.OpenFile("pagecomments", Language.GetValue("Nhập danh sách bình luận"), Language.GetValue("Danh sách bình luận"), Language.GetValue("(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})"));
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x002156FC File Offset: 0x002138FC
		private void btnInbox_Click(object sender, EventArgs e)
		{
			this.OpenFile("message", Language.GetValue("Nhập danh sách tin nhắn"), Language.GetValue("Danh sách tin nhắn"), Language.GetValue("(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})"));
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0021577C File Offset: 0x0021397C
		private void button2_Click(object sender, EventArgs e)
		{
			this.OpenFile("birthdaycontent", Language.GetValue("Nhập danh sách lời chúc"), Language.GetValue("Danh sách lời chúc"), Language.GetValue("(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})"));
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x002157FC File Offset: 0x002139FC
		private void button8_Click(object sender, EventArgs e)
		{
			this.OpenFile("idFriend", Language.GetValue("Nhập danh sách UID cần kết bạn"), Language.GetValue("Danh sách UID"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0021587C File Offset: 0x00213A7C
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.OpenFile("idGroup", Language.GetValue("Nhập danh sách ID nhóm cần tham gia"), Language.GetValue("Danh sách ID nhóm"), Language.GetValue("(Mỗi nội dung 1 dòng)"));
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x002158FC File Offset: 0x00213AFC
		private void button5_Click(object sender, EventArgs e)
		{
			this.OpenFile("answer", Language.GetValue("Nhập danh sách câu trả lời"), Language.GetValue("Danh sách câu trả lời"), Language.GetValue("(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})"));
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0021597C File Offset: 0x00213B7C
		private void ckbTuongTacNewsfeedComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacNewsfeedComment.Enabled = this.ckbTuongTacNewsfeedComment.Checked;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x002159AC File Offset: 0x00213BAC
		private void ckbTuongTacFriendComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacFriendComment.Enabled = this.ckbTuongTacFriendComment.Checked;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x002159DC File Offset: 0x00213BDC
		private void ckbTuongTacGroupComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacGroupComment.Enabled = this.ckbTuongTacGroupComment.Checked;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00215A0C File Offset: 0x00213C0C
		private void ckbTuongTacFanpageComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacFanpageComment.Enabled = this.ckbTuongTacFanpageComment.Checked;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00215A3C File Offset: 0x00213C3C
		private void ckbThamGiaNhomTraLoiCauHoi_CheckedChanged(object sender, EventArgs e)
		{
			this.btnThamGiaNhomTraLoiCauHoi.Enabled = this.ckbThamGiaNhomTraLoiCauHoi.Checked;
		}

		// Token: 0x040017B1 RID: 6065
		private JSON_Settings settings;

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
