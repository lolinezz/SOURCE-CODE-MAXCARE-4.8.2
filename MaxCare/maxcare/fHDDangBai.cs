using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000C4 RID: 196
	public partial class fHDDangBai : Form
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x000E4024 File Offset: 0x000E2224
		public fHDDangBai(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDDangBai.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = base.Name.Substring(1);
			bool flag = InteractSQL.GetTuongTac("", text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', 'Đăng bài theo ID');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", text);
				jsonStringOrPathFile = tuongTac.Rows[0]["CauHinh"].ToString();
				this.id_TuongTac = tuongTac.Rows[0]["Id_TuongTac"].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0]["MoTa"].ToString());
			}
			else
			{
				bool flag3 = type == 1;
				if (flag3)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					jsonStringOrPathFile = hanhDongById.Rows[0]["CauHinh"].ToString();
					this.btnAdd.Text = Language.GetValue("Cập nhật");
					this.txtTenHanhDong.Text = hanhDongById.Rows[0]["TenHanhDong"].ToString();
				}
			}
			this.setting = new JSON_Settings(jsonStringOrPathFile, true);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000E4270 File Offset: 0x000E2470
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.ckbDangBaiLenTuong);
			Language.GetValue(this.ckbDangBaiLenNhom);
			Language.GetValue(this.label26);
			Language.GetValue(this.label24);
			Language.GetValue(this.label25);
			Language.GetValue(this.ckbOnlyDangNhomKhongKiemDuyet);
			Language.GetValue(this.ckbDangBaiLenPage);
			Language.GetValue(this.label21);
			Language.GetValue(this.label23);
			Language.GetValue(this.label22);
			Language.GetValue(this.ckbVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbUseBackground);
			Language.GetValue(this.ckbAnh);
			Language.GetValue(this.label3);
			Language.GetValue(this.label2);
			Language.GetValue(this.label10);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbVideo);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label11);
			Language.GetValue(this.label5);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			Language.GetValue(this.rbNganCachMoiDong);
			Language.GetValue(this.rbNganCachKyTu);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000E44C0 File Offset: 0x000E26C0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbDangBaiLenTuong.Checked = this.setting.GetValueBool("ckbDangBaiLenTuong", false);
				this.ckbDangBaiLenNhom.Checked = this.setting.GetValueBool("ckbDangBaiLenNhom", false);
				this.ckbOnlyDangNhomKhongKiemDuyet.Checked = this.setting.GetValueBool("ckbOnlyDangNhomKhongKiemDuyet", false);
				this.nudCountGroupFrom.Value = this.setting.GetValueInt("nudCountGroupFrom", 1);
				this.nudCountGroupTo.Value = this.setting.GetValueInt("nudCountGroupTo", 1);
				this.ckbDangBaiLenPage.Checked = this.setting.GetValueBool("ckbDangBaiLenPage", false);
				this.nudCountPageFrom.Value = this.setting.GetValueInt("nudCountPageFrom", 1);
				this.nudCountPageTo.Value = this.setting.GetValueInt("nudCountPageTo", 1);
				this.ckbVanBan.Checked = this.setting.GetValueBool("ckbVanBan", false);
				this.ckbUseBackground.Checked = this.setting.GetValueBool("ckbUseBackground", false);
				this.txtNoiDung.Text = this.setting.GetValue("txtNoiDung", "");
				this.ckbAnh.Checked = this.setting.GetValueBool("ckbAnh", false);
				this.ckbVideo.Checked = this.setting.GetValueBool("ckbVideo", false);
				this.nudSoLuongAnhFrom.Value = this.setting.GetValueInt("nudSoLuongAnhFrom", 1);
				this.nudSoLuongAnhTo.Value = this.setting.GetValueInt("nudSoLuongAnhTo", 1);
				this.ckbUseAvatar.Checked = this.setting.GetValueBool("ckbUseAvatar", false);
				this.nudSoLuongVideoFrom.Value = this.setting.GetValueInt("nudSoLuongVideoFrom", 1);
				this.nudSoLuongVideoTo.Value = this.setting.GetValueInt("nudSoLuongVideoTo", 1);
				this.txtPathAnh.Text = this.setting.GetValue("txtPathAnh", "");
				this.txtPathVideo.Text = this.setting.GetValue("txtPathVideo", "");
				bool flag = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
			}
			catch (Exception ex)
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000E4AEC File Offset: 0x000E2CEC
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtTenHanhDong.Text.Trim();
			bool flag = text == "";
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập tên hành động!"), 3);
			}
			else
			{
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				json_Settings.Update("ckbDangBaiLenTuong", this.ckbDangBaiLenTuong.Checked);
				json_Settings.Update("ckbDangBaiLenNhom", this.ckbDangBaiLenNhom.Checked);
				json_Settings.Update("ckbOnlyDangNhomKhongKiemDuyet", this.ckbOnlyDangNhomKhongKiemDuyet.Checked);
				json_Settings.Update("nudCountGroupFrom", this.nudCountGroupFrom.Value);
				json_Settings.Update("nudCountGroupTo", this.nudCountGroupTo.Value);
				json_Settings.Update("ckbDangBaiLenPage", this.ckbDangBaiLenPage.Checked);
				json_Settings.Update("nudCountPageFrom", this.nudCountPageFrom.Value);
				json_Settings.Update("nudCountPageTo", this.nudCountPageTo.Value);
				json_Settings.Update("ckbVanBan", this.ckbVanBan.Checked);
				json_Settings.Update("ckbUseBackground", this.ckbUseBackground.Checked);
				json_Settings.Update("ckbAnh", this.ckbAnh.Checked);
				json_Settings.Update("ckbVideo", this.ckbVideo.Checked);
				json_Settings.Update("nudSoLuongAnhFrom", this.nudSoLuongAnhFrom.Value);
				json_Settings.Update("nudSoLuongAnhTo", this.nudSoLuongAnhTo.Value);
				json_Settings.Update("ckbUseAvatar", this.ckbUseAvatar.Checked);
				json_Settings.Update("nudSoLuongVideoFrom", this.nudSoLuongVideoFrom.Value);
				json_Settings.Update("nudSoLuongVideoTo", this.nudSoLuongVideoTo.Value);
				json_Settings.Update("txtNoiDung", this.txtNoiDung.Text.Trim());
				json_Settings.Update("txtPathAnh", this.txtPathAnh.Text.Trim());
				json_Settings.Update("txtPathVideo", this.txtPathVideo.Text.Trim());
				int num = 0;
				bool @checked = this.rbNganCachKyTu.Checked;
				if (@checked)
				{
					num = 1;
				}
				json_Settings.Update("typeNganCach", num);
				string fullString = json_Settings.GetFullString();
				bool flag2 = this.type == 0;
				if (flag2)
				{
					bool flag3 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
					if (flag3)
					{
						bool flag4 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag4)
						{
							fHDDangBai.isSave = true;
							base.Close();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Thêm thất bại, vui lòng thử lại sau!"), 2);
						}
					}
				}
				else
				{
					bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
					if (flag5)
					{
						bool flag6 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
						if (flag6)
						{
							fHDDangBai.isSave = true;
							base.Close();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Cập nhật thất bại, vui lòng thử lại sau!"), 2);
						}
					}
				}
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000E5140 File Offset: 0x000E3340
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

		// Token: 0x060007DB RID: 2011 RVA: 0x000E5204 File Offset: 0x000E3404
		private void CheckedChangeFull()
		{
			this.ckbDangBaiLenNhom_CheckedChanged(null, null);
			this.ckbDangBaiLenPage_CheckedChanged(null, null);
			this.ckbVanBan_CheckedChanged(null, null);
			this.ckbAnh_CheckedChanged(null, null);
			this.ckbVideo_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000E5268 File Offset: 0x000E3468
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
			bool flag = !this.ckbVanBan.Checked;
			if (flag)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000E52CC File Offset: 0x000E34CC
		private void ckbAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbAnh.Checked;
			bool @checked = this.ckbAnh.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000E5328 File Offset: 0x000E3528
		private void ckbVideo_CheckedChanged(object sender, EventArgs e)
		{
			this.plVideo.Enabled = this.ckbVideo.Checked;
			bool @checked = this.ckbVideo.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000E5384 File Offset: 0x000E3584
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000E53A0 File Offset: 0x000E35A0
		private void UpdateSoLuongBinhLuan()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtNoiDung.Lines.ToList<string>();
				}
				else
				{
					list = this.txtNoiDung.Text.Split(new string[]
					{
						"\n|\n"
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách nội dung ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000E549C File Offset: 0x000E369C
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathAnh.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000E54C0 File Offset: 0x000E36C0
		private void metroButton2_Click(object sender, EventArgs e)
		{
			this.txtPathVideo.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000E54E4 File Offset: 0x000E36E4
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000E5558 File Offset: 0x000E3758
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 279;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000E557C File Offset: 0x000E377C
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 196;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000E5384 File Offset: 0x000E3584
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000E5384 File Offset: 0x000E3584
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000E55A0 File Offset: 0x000E37A0
		private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenNhom.Enabled = this.ckbDangBaiLenNhom.Checked;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000E55D0 File Offset: 0x000E37D0
		private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenPage.Enabled = this.ckbDangBaiLenPage.Checked;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000E5600 File Offset: 0x000E3800
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000E5644 File Offset: 0x000E3844
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000E5384 File Offset: 0x000E3584
		private void rbNganCachMoiDong_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000E5384 File Offset: 0x000E3584
		private void rbNganCachKyTu_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000E5670 File Offset: 0x000E3870
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = !this.ckbUseAvatar.Checked;
		}

		// Token: 0x040009F4 RID: 2548
		private JSON_Settings setting;

		// Token: 0x040009F5 RID: 2549
		private string id_KichBan;

		// Token: 0x040009F6 RID: 2550
		private string id_TuongTac;

		// Token: 0x040009F7 RID: 2551
		private string Id_HanhDong;

		// Token: 0x040009F8 RID: 2552
		private int type;

		// Token: 0x040009F9 RID: 2553
		public static bool isSave;
	}
}
