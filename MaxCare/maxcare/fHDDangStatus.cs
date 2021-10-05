using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
	// Token: 0x02000103 RID: 259
	public partial class fHDDangStatus : Form
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x00175BC4 File Offset: 0x00173DC4
		public fHDDangStatus(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDDangStatus.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDDangStatus").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDDangStatus', '{  \"ckbVanBan\": \"False\",\"txtNoiDung\": \"\",   \"ckbAnh\": \"False\",\"txtPathAnh\":\"\",\"nudSoLuongAnh\": \"1\",  \"ckbVideo\": \"False\",\"txtPathVideo\":\"\",\"nudSoLuongVideo\": \"1\"}', 'Đăng status');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDDangStatus");
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

		// Token: 0x06000ADE RID: 2782 RVA: 0x00175E0C File Offset: 0x0017400C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label17);
			Language.GetValue(this.label18);
			Language.GetValue(this.label16);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.ckbVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbAnh);
			Language.GetValue(this.label3);
			Language.GetValue(this.label21);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbUseBackground);
			Language.GetValue(this.ckbVideo);
			Language.GetValue(this.label7);
			Language.GetValue(this.label22);
			Language.GetValue(this.label5);
			Language.GetValue(this.label6);
			Language.GetValue(this.ckbTag);
			Language.GetValue(this.label10);
			Language.GetValue(this.label13);
			Language.GetValue(this.label12);
			Language.GetValue(this.rbUidBanBe);
			Language.GetValue(this.rbUidTuNhap);
			Language.GetValue(this.lbUid);
			Language.GetValue(this.label11);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0017604C File Offset: 0x0017424C
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 1);
				this.nudKhoangCachFrom.Value = this.setting.GetValueInt("nudKhoangCachFrom", 5);
				this.nudKhoangCachTo.Value = this.setting.GetValueInt("nudKhoangCachTo", 10);
				this.ckbVanBan.Checked = this.setting.GetValueBool("ckbVanBan", false);
				this.ckbUseBackground.Checked = this.setting.GetValueBool("ckbUseBackground", false);
				this.txtNoiDung.Text = this.setting.GetValue("txtNoiDung", "");
				this.ckbAnh.Checked = this.setting.GetValueBool("ckbAnh", false);
				this.ckbVideo.Checked = this.setting.GetValueBool("ckbVideo", false);
				this.nudSoLuongAnhFrom.Value = this.setting.GetValueInt("nudSoLuongAnhFrom", 1);
				this.nudSoLuongAnhTo.Value = this.setting.GetValueInt("nudSoLuongAnhTo", 1);
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
				bool flag2 = this.setting.GetValueInt("typeUidTag", 0) == 0;
				if (flag2)
				{
					this.rbUidBanBe.Checked = true;
				}
				else
				{
					this.rbUidTuNhap.Checked = true;
				}
				this.ckbTag.Checked = this.setting.GetValueBool("ckbTag", false);
				this.txtUidTag.Text = this.setting.GetValue("txtUidTag", "");
				this.nudUidFrom.Value = this.setting.GetValueInt("nudUidFrom", 1);
				this.nudUidTo.Value = this.setting.GetValueInt("nudUidTo", 1);
			}
			catch (Exception ex)
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00176640 File Offset: 0x00174840
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
				bool flag2 = this.ckbAnh.Checked && !Directory.Exists(this.txtPathAnh.Text.Trim());
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Đường dẫn ảnh không tồn tại!"), 3);
				}
				else
				{
					bool flag3 = this.ckbVideo.Checked && !Directory.Exists(this.txtPathVideo.Text.Trim());
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Đường dẫn video không tồn tại!"), 3);
					}
					else
					{
						JSON_Settings json_Settings = new JSON_Settings();
						json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
						json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
						json_Settings.Update("nudKhoangCachFrom", this.nudKhoangCachFrom.Value);
						json_Settings.Update("nudKhoangCachTo", this.nudKhoangCachTo.Value);
						json_Settings.Update("ckbVanBan", this.ckbVanBan.Checked);
						json_Settings.Update("ckbUseBackground", this.ckbUseBackground.Checked);
						json_Settings.Update("ckbAnh", this.ckbAnh.Checked);
						json_Settings.Update("ckbVideo", this.ckbVideo.Checked);
						json_Settings.Update("nudSoLuongAnhFrom", this.nudSoLuongAnhFrom.Value);
						json_Settings.Update("nudSoLuongAnhTo", this.nudSoLuongAnhTo.Value);
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
						bool checked2 = this.rbUidBanBe.Checked;
						if (checked2)
						{
							json_Settings.Update("typeUidTag", 0);
						}
						else
						{
							bool checked3 = this.rbUidTuNhap.Checked;
							if (checked3)
							{
								json_Settings.Update("typeUidTag", 1);
							}
						}
						json_Settings.Update("ckbTag", this.ckbTag.Checked);
						json_Settings.Update("txtUidTag", this.txtUidTag.Text.Trim());
						json_Settings.Update("nudUidFrom", this.nudUidFrom.Value);
						json_Settings.Update("nudUidTo", this.nudUidTo.Value);
						string fullString = json_Settings.GetFullString();
						bool flag4 = this.type == 0;
						if (flag4)
						{
							bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
							if (flag5)
							{
								bool flag6 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
								if (flag6)
								{
									fHDDangStatus.isSave = true;
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
							bool flag7 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
							if (flag7)
							{
								bool flag8 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
								if (flag8)
								{
									fHDDangStatus.isSave = true;
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
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00176D6C File Offset: 0x00174F6C
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

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00176E30 File Offset: 0x00175030
		private void CheckedChangeFull()
		{
			this.ckbVanBan_CheckedChanged(null, null);
			this.ckbAnh_CheckedChanged(null, null);
			this.ckbVideo_CheckedChanged(null, null);
			this.ckbTag_CheckedChanged(null, null);
			this.rbUidTuNhap_CheckedChanged(null, null);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00176E84 File Offset: 0x00175084
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
			bool flag = !this.ckbVanBan.Checked;
			if (flag)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00176EE8 File Offset: 0x001750E8
		private void ckbAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbAnh.Checked;
			bool @checked = this.ckbAnh.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00176F44 File Offset: 0x00175144
		private void ckbVideo_CheckedChanged(object sender, EventArgs e)
		{
			this.plVideo.Enabled = this.ckbVideo.Checked;
			bool @checked = this.ckbVideo.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00176FA0 File Offset: 0x001751A0
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00176FBC File Offset: 0x001751BC
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

		// Token: 0x06000AEA RID: 2794 RVA: 0x001770B8 File Offset: 0x001752B8
		private void UpdateSoLuongUid()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtUidTag.Lines.ToList<string>();
				}
				else
				{
					list = this.txtUidTag.Text.Split(new string[]
					{
						"\n|\n"
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lbUid.Text = string.Format(Language.GetValue("Danh sách Uid ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x001771B4 File Offset: 0x001753B4
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathAnh.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x001771D8 File Offset: 0x001753D8
		private void metroButton2_Click(object sender, EventArgs e)
		{
			this.txtPathVideo.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x001771FC File Offset: 0x001753FC
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00177270 File Offset: 0x00175470
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 325;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00177294 File Offset: 0x00175494
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 276;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00176FA0 File Offset: 0x001751A0
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00176FA0 File Offset: 0x001751A0
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x001772B8 File Offset: 0x001754B8
		private void ckbTag_CheckedChanged(object sender, EventArgs e)
		{
			this.plTag.Enabled = this.ckbTag.Checked;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x001772E8 File Offset: 0x001754E8
		private void txtUid_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongUid();
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00054604 File Offset: 0x00052804
		private void lbUid_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00054604 File Offset: 0x00052804
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00177304 File Offset: 0x00175504
		private void rbUidTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.plUidTuNhap.Enabled = this.rbUidTuNhap.Checked;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00054604 File Offset: 0x00052804
		private void txtPathAnh_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00177334 File Offset: 0x00175534
		private void button2_Click_1(object sender, EventArgs e)
		{
			string s = string.Concat(new string[]
			{
				Language.GetValue("Có thể dùng:"),
				Environment.NewLine,
				Language.GetValue("- [full_name] để thay thế họ tên của tài khoản!"),
				Environment.NewLine,
				Language.GetValue("- [name] để thay thế tên của tài khoản!")
			});
			MessageBoxHelper.ShowMessageBox(s, 1);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x001773DC File Offset: 0x001755DC
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00177420 File Offset: 0x00175620
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x04001047 RID: 4167
		private JSON_Settings setting;

		// Token: 0x04001048 RID: 4168
		private string id_KichBan;

		// Token: 0x04001049 RID: 4169
		private string id_TuongTac;

		// Token: 0x0400104A RID: 4170
		private string Id_HanhDong;

		// Token: 0x0400104B RID: 4171
		private int type;

		// Token: 0x0400104C RID: 4172
		public static bool isSave;
	}
}
