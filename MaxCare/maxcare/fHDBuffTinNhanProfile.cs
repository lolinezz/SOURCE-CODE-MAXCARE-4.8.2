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
	// Token: 0x02000101 RID: 257
	public partial class fHDBuffTinNhanProfile : Form
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x00169120 File Offset: 0x00167320
		public fHDBuffTinNhanProfile(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBuffTinNhanProfile.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDBuffTinNhanProfile").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffTinNhanProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\", \"nudSoLuongAnhFrom\": \"1\", \"nudSoLuongAnhTo\": \"1\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",  \"txtUid\": \"\",  \"ckbNhanTinVanBan\": \"True\",  \"txtNoiDung\": \"hello\",  \"ckbSendAnh\": \"False\",  \"txtAnh\": \"\",  \"ckbTuDongXoaUid\": \"False\"}', 'Buff Tin nhắn Profile');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBuffTinNhanProfile");
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

		// Token: 0x06000A9B RID: 2715 RVA: 0x00169368 File Offset: 0x00167568
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.lblStatusUid);
			Language.GetValue(this.label2);
			Language.GetValue(this.ckbTuDongXoaUid);
			Language.GetValue(this.ckbNhanTinVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbSendAnh);
			Language.GetValue(this.label10);
			Language.GetValue(this.label3);
			Language.GetValue(this.label9);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbTuongTacKhiNhanTin);
			Language.GetValue(this.label15);
			Language.GetValue(this.rbTuongTacTruocKhiNhanTin);
			Language.GetValue(this.rbTuongTacSauKhiNhanTin);
			Language.GetValue(this.label16);
			Language.GetValue(this.label14);
			Language.GetValue(this.label12);
			Language.GetValue(this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
			Language.GetValue(this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00169564 File Offset: 0x00167764
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongUidFrom.Value = this.setting.GetValueInt("nudSoLuongUidFrom", 1);
				this.nudSoLuongUidTo.Value = this.setting.GetValueInt("nudSoLuongUidTo", 3);
				this.nudSoLuongAnhFrom.Value = this.setting.GetValueInt("nudSoLuongAnhFrom", 1);
				this.nudSoLuongAnhTo.Value = this.setting.GetValueInt("nudSoLuongAnhTo", 1);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.txtUid.Text = this.setting.GetValue("txtUid", "");
				this.ckbAddFriend.Checked = this.setting.GetValueBool("ckbAddFriend", false);
				this.ckbNhanTinVanBan.Checked = this.setting.GetValueBool("ckbNhanTinVanBan", false);
				this.txtNoiDung.Text = this.setting.GetValue("txtNoiDung", "");
				this.ckbSendAnh.Checked = this.setting.GetValueBool("ckbSendAnh", false);
				this.txtAnh.Text = this.setting.GetValue("txtAnh", "");
				this.ckbTuongTacKhiNhanTin.Checked = this.setting.GetValueBool("ckbTuongTacKhiNhanTin", false);
				bool flag = this.setting.GetValueInt("typeTuongTacKhiNhanTin", 0) == 0;
				if (flag)
				{
					this.rbTuongTacTruocKhiNhanTin.Checked = true;
				}
				else
				{
					this.rbTuongTacSauKhiNhanTin.Checked = true;
				}
				this.ckbTuongTacKhiNhanTinLike.Checked = this.setting.GetValueBool("ckbTuongTacKhiNhanTinLike", false);
				this.ckbTuongTacKhiNhanTinComment.Checked = this.setting.GetValueBool("ckbTuongTacKhiNhanTinComment", false);
				this.txtTuongTacKhiNhanTinComment.Text = this.setting.GetValue("txtTuongTacKhiNhanTinComment", "");
				bool flag2 = this.setting.GetValueInt("typeNganCachComment", 0) == 1;
				if (flag2)
				{
					this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked = true;
				}
				else
				{
					this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
				}
				this.ckbTuDongXoaUid.Checked = this.setting.GetValueBool("ckbTuDongXoaUid", false);
				bool flag3 = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag3)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00169B38 File Offset: 0x00167D38
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
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Uid!"), 3);
				}
				else
				{
					bool @checked = this.ckbNhanTinVanBan.Checked;
					if (@checked)
					{
						list = this.txtNoiDung.Lines.ToList<string>();
						list = MCommon.Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung tin nhắn!"), 3);
							return;
						}
					}
					bool checked2 = this.ckbSendAnh.Checked;
					if (checked2)
					{
						bool flag4 = this.txtAnh.Text.Trim().Length == 0;
						if (flag4)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn folder ảnh!"), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongUidFrom", this.nudSoLuongUidFrom.Value);
					json_Settings.Update("nudSoLuongUidTo", this.nudSoLuongUidTo.Value);
					json_Settings.Update("nudSoLuongAnhFrom", this.nudSoLuongAnhFrom.Value);
					json_Settings.Update("nudSoLuongAnhTo", this.nudSoLuongAnhTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("txtUid", this.txtUid.Text.Trim());
					json_Settings.Update("ckbAddFriend", this.ckbAddFriend.Checked);
					json_Settings.Update("ckbNhanTinVanBan", this.ckbNhanTinVanBan.Checked);
					json_Settings.Update("txtNoiDung", this.txtNoiDung.Text.Trim());
					json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
					json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
					json_Settings.Update("ckbTuDongXoaUid", this.ckbTuDongXoaUid.Checked);
					json_Settings.Update("ckbTuongTacKhiNhanTin", this.ckbTuongTacKhiNhanTin.Checked);
					bool checked3 = this.rbTuongTacTruocKhiNhanTin.Checked;
					if (checked3)
					{
						json_Settings.Update("typeTuongTacKhiNhanTin", 0);
					}
					else
					{
						json_Settings.Update("typeTuongTacKhiNhanTin", 1);
					}
					json_Settings.Update("ckbTuongTacKhiNhanTinLike", this.ckbTuongTacKhiNhanTinLike.Checked);
					json_Settings.Update("ckbTuongTacKhiNhanTinComment", this.ckbTuongTacKhiNhanTinComment.Checked);
					json_Settings.Update("txtTuongTacKhiNhanTinComment", this.txtTuongTacKhiNhanTinComment.Text.Trim());
					int num = 0;
					bool checked4 = this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked;
					if (checked4)
					{
						num = 1;
					}
					json_Settings.Update("typeNganCachComment", num);
					int num2 = 0;
					bool checked5 = this.rbNganCachKyTu.Checked;
					if (checked5)
					{
						num2 = 1;
					}
					json_Settings.Update("typeNganCach", num2);
					string fullString = json_Settings.GetFullString();
					bool flag5 = this.type == 0;
					if (flag5)
					{
						bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
						if (flag6)
						{
							bool flag7 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
							if (flag7)
							{
								fHDBuffTinNhanProfile.isSave = true;
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
						bool flag8 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
						if (flag8)
						{
							bool flag9 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
							if (flag9)
							{
								fHDBuffTinNhanProfile.isSave = true;
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

		// Token: 0x06000A9F RID: 2719 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0016A298 File Offset: 0x00168498
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

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0016A35C File Offset: 0x0016855C
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0016A378 File Offset: 0x00168578
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
				this.lblStatus.Text = string.Format(Language.GetValue("Nội dung tin nhắn ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0016A474 File Offset: 0x00168674
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbTuongTacTruocKhiNhanTin_CheckedChanged(null, null);
			this.ckbTuongTacTruocKhiNhanTinComment_CheckedChanged(null, null);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0016A4BC File Offset: 0x001686BC
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbNhanTinVanBan.Checked;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0016A4EC File Offset: 0x001686EC
		private void txtUid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusUid.Text = string.Format(Language.GetValue("Danh sách Uid cá nhân cần nhắn tin ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0016A580 File Offset: 0x00168780
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0016A5B0 File Offset: 0x001687B0
		private void button2_Click(object sender, EventArgs e)
		{
			this.txtAnh.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0016A5D4 File Offset: 0x001687D4
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 235;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0016A5F8 File Offset: 0x001687F8
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 185;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0016A35C File Offset: 0x0016855C
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0016A35C File Offset: 0x0016855C
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0016A61C File Offset: 0x0016881C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0016A690 File Offset: 0x00168890
		private void ckbTuongTacTruocKhiNhanTin_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacTruocKhiNhanTin.Enabled = this.ckbTuongTacKhiNhanTin.Checked;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0016A6C0 File Offset: 0x001688C0
		private void ckbTuongTacTruocKhiNhanTinComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacTruocKhiNhanTinComment.Enabled = this.ckbTuongTacKhiNhanTinComment.Checked;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0016A6F0 File Offset: 0x001688F0
		private void button2_Click_1(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtTuongTacKhiNhanTinComment.Focus();
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0016A734 File Offset: 0x00168934
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtTuongTacKhiNhanTinComment.Focus();
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x000C2390 File Offset: 0x000C0590
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox("Có thể dùng [u] để thay thế tên của UID!", 1);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0016A760 File Offset: 0x00168960
		private void button6_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0016A794 File Offset: 0x00168994
		private void button5_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
		}

		// Token: 0x04000FB7 RID: 4023
		private JSON_Settings setting;

		// Token: 0x04000FB8 RID: 4024
		private string id_KichBan;

		// Token: 0x04000FB9 RID: 4025
		private string id_TuongTac;

		// Token: 0x04000FBA RID: 4026
		private string Id_HanhDong;

		// Token: 0x04000FBB RID: 4027
		private int type;

		// Token: 0x04000FBC RID: 4028
		public static bool isSave;
	}
}
