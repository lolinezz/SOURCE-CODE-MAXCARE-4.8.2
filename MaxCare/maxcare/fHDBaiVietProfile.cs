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
using MCommon;

namespace maxcare
{
	// Token: 0x020000BA RID: 186
	public partial class fHDBaiVietProfile : Form
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x000C06B4 File Offset: 0x000BE8B4
		public fHDBaiVietProfile(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBaiVietProfile.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDBaiVietProfile").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBaiVietProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\",  \"nudSoLuongBaiVietFrom\": \"1\",  \"nudSoLuongBaiVietTo\": \"3\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",\"txtUid\": \"\",  \"ckbInteract\": \"True\",  \"ckbShareWall\": \"False\",  \"ckbComment\": \"False\",  \"txtComment\": \"\"}', 'Bài viết Profile');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBaiVietProfile");
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

		// Token: 0x0600072A RID: 1834 RVA: 0x000C0900 File Offset: 0x000BEB00
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label19);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label10);
			Language.GetValue(this.button4);
			Language.GetValue(this.rbFileUid);
			Language.GetValue(this.btnChooseFileUid);
			Language.GetValue(this.rbListUid);
			Language.GetValue(this.ckbTuDongXoaUid);
			Language.GetValue(this.ckbRandomGoVanBan);
			Language.GetValue(this.ckbInteract);
			Language.GetValue(this.ckbShareWall);
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label9);
			Language.GetValue(this.rbNganCachMoiDong);
			Language.GetValue(this.button2);
			Language.GetValue(this.rbNganCachKyTu);
			Language.GetValue(this.button3);
			Language.GetValue(this.ckbSendAnh);
			Language.GetValue(this.label12);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000C0B0C File Offset: 0x000BED0C
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongUidFrom.Value = this.setting.GetValueInt("nudSoLuongUidFrom", 0);
				this.nudSoLuongUidTo.Value = this.setting.GetValueInt("nudSoLuongUidTo", 0);
				this.nudSoLuongBaiVietFrom.Value = this.setting.GetValueInt("nudSoLuongBaiVietFrom", 0);
				this.nudSoLuongBaiVietTo.Value = this.setting.GetValueInt("nudSoLuongBaiVietTo", 0);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 0);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 0);
				int valueInt = this.setting.GetValueInt("typeListUid", 0);
				bool flag = valueInt == 1;
				if (flag)
				{
					this.rbFileUid.Checked = true;
				}
				else
				{
					this.rbListUid.Checked = true;
				}
				this.txtPathFileUid.Text = this.setting.GetValue("txtPathFileUid", "");
				this.txtUid.Text = this.setting.GetValue("txtUid", "");
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbShareWall.Checked = this.setting.GetValueBool("ckbShareWall", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.ckbSendAnh.Checked = this.setting.GetValueBool("ckbSendAnh", false);
				this.txtAnh.Text = this.setting.GetValue("txtAnh", "");
				this.ckbTuDongXoaUid.Checked = this.setting.GetValueBool("ckbTuDongXoaUid", false);
				this.ckbRandomGoVanBan.Checked = this.setting.GetValueBool("ckbRandomGoVanBan", false);
				bool flag2 = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag2)
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

		// Token: 0x0600072C RID: 1836 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000C1040 File Offset: 0x000BF240
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.type == 0;
			if (flag)
			{
				bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
				if (flag2)
				{
					string text = this.txtTenHanhDong.Text.Trim();
					bool flag3 = text == "";
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập tên hành động!"), 3);
					}
					else
					{
						bool @checked = this.rbFileUid.Checked;
						if (@checked)
						{
							bool flag4 = this.txtPathFileUid.Text.Trim() == "";
							if (flag4)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn File Uid!"), 3);
								return;
							}
						}
						else
						{
							List<string> list = this.txtUid.Lines.ToList<string>();
							list = MCommon.Common.RemoveEmptyItems(list);
							bool flag5 = list.Count == 0;
							if (flag5)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Uid!"), 3);
								return;
							}
						}
						bool checked2 = this.ckbComment.Checked;
						if (checked2)
						{
							List<string> list2 = this.txtComment.Lines.ToList<string>();
							list2 = MCommon.Common.RemoveEmptyItems(list2);
							bool flag6 = list2.Count == 0;
							if (flag6)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
								return;
							}
						}
						bool checked3 = this.ckbSendAnh.Checked;
						if (checked3)
						{
							bool flag7 = this.txtAnh.Text.Trim().Length == 0;
							if (flag7)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn folder ảnh!"), 3);
								return;
							}
						}
						JSON_Settings json_Settings = new JSON_Settings();
						json_Settings.Update("nudSoLuongUidFrom", this.nudSoLuongUidFrom.Value);
						json_Settings.Update("nudSoLuongUidTo", this.nudSoLuongUidTo.Value);
						json_Settings.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
						json_Settings.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
						json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
						bool checked4 = this.rbFileUid.Checked;
						if (checked4)
						{
							json_Settings.Update("typeListUid", 1);
						}
						else
						{
							json_Settings.Update("typeListUid", 0);
						}
						json_Settings.Update("txtPathFileUid", this.txtPathFileUid.Text.Trim());
						json_Settings.Update("txtUid", this.txtUid.Text.Trim());
						json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings.Update("ckbComment", this.ckbComment.Checked);
						json_Settings.Update("txtComment", this.txtComment.Text.Trim());
						json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
						json_Settings.Update("ckbTuDongXoaUid", this.ckbTuDongXoaUid.Checked);
						json_Settings.Update("ckbRandomGoVanBan", this.ckbRandomGoVanBan.Checked);
						int num = 0;
						bool checked5 = this.rbNganCachKyTu.Checked;
						if (checked5)
						{
							num = 1;
						}
						json_Settings.Update("typeNganCach", num);
						string fullString = json_Settings.GetFullString();
						bool flag8 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag8)
						{
							fHDBaiVietProfile.isSave = true;
							base.Close();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Thêm thất bại, vui lòng thử lại sau!"), 2);
						}
					}
				}
			}
			else
			{
				bool flag9 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
				if (flag9)
				{
					string text2 = this.txtTenHanhDong.Text.Trim();
					bool flag10 = text2 == "";
					if (flag10)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập tên hành động!"), 3);
					}
					else
					{
						bool checked6 = this.rbFileUid.Checked;
						if (checked6)
						{
							bool flag11 = this.txtPathFileUid.Text.Trim() == "";
							if (flag11)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn File Uid!"), 3);
								return;
							}
						}
						else
						{
							List<string> list3 = this.txtUid.Lines.ToList<string>();
							list3 = MCommon.Common.RemoveEmptyItems(list3);
							bool flag12 = list3.Count == 0;
							if (flag12)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Uid!"), 3);
								return;
							}
						}
						bool checked7 = this.ckbComment.Checked;
						if (checked7)
						{
							List<string> list4 = this.txtComment.Lines.ToList<string>();
							list4 = MCommon.Common.RemoveEmptyItems(list4);
							bool flag13 = list4.Count == 0;
							if (flag13)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
								return;
							}
						}
						bool checked8 = this.ckbSendAnh.Checked;
						if (checked8)
						{
							bool flag14 = this.txtAnh.Text.Trim().Length == 0;
							if (flag14)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn folder ảnh!"), 3);
								return;
							}
						}
						JSON_Settings json_Settings2 = new JSON_Settings();
						json_Settings2.Update("nudSoLuongUidFrom", this.nudSoLuongUidFrom.Value);
						json_Settings2.Update("nudSoLuongUidTo", this.nudSoLuongUidTo.Value);
						json_Settings2.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
						json_Settings2.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
						json_Settings2.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings2.Update("nudDelayTo", this.nudDelayTo.Value);
						bool checked9 = this.rbFileUid.Checked;
						if (checked9)
						{
							json_Settings2.Update("typeListUid", 1);
						}
						else
						{
							json_Settings2.Update("typeListUid", 0);
						}
						json_Settings2.Update("txtPathFileUid", this.txtPathFileUid.Text.Trim());
						json_Settings2.Update("txtUid", this.txtUid.Text.Trim());
						json_Settings2.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings2.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings2.Update("ckbComment", this.ckbComment.Checked);
						json_Settings2.Update("txtComment", this.txtComment.Text.Trim());
						json_Settings2.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings2.Update("txtAnh", this.txtAnh.Text.Trim());
						json_Settings2.Update("ckbTuDongXoaUid", this.ckbTuDongXoaUid.Checked);
						json_Settings2.Update("ckbRandomGoVanBan", this.ckbRandomGoVanBan.Checked);
						int num2 = 0;
						bool checked10 = this.rbNganCachKyTu.Checked;
						if (checked10)
						{
							num2 = 1;
						}
						json_Settings2.Update("typeNganCach", num2);
						json_Settings2.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings2.Update("txtAnh", this.txtAnh.Text.Trim());
						string fullString2 = json_Settings2.GetFullString();
						bool flag15 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text2, fullString2);
						if (flag15)
						{
							fHDBaiVietProfile.isSave = true;
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

		// Token: 0x0600072E RID: 1838 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000C1E38 File Offset: 0x000C0038
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

		// Token: 0x06000730 RID: 1840 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000C1EFC File Offset: 0x000C00FC
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000C1F18 File Offset: 0x000C0118
		private void UpdateSoLuongBinhLuan()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtComment.Lines.ToList<string>();
				}
				else
				{
					list = this.txtComment.Text.Split(new string[]
					{
						"\n|\n"
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000C2014 File Offset: 0x000C0214
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.rbFileUid_CheckedChanged(null, null);
			this.rbListUid_CheckedChanged(null, null);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000C205C File Offset: 0x000C025C
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000C208C File Offset: 0x000C028C
		private void txtUid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.rbListUid.Text = string.Format(Language.GetValue("Nhập (Mỗi Uid 1 dòng) ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000C2120 File Offset: 0x000C0320
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000C2150 File Offset: 0x000C0350
		private void button2_Click(object sender, EventArgs e)
		{
			this.txtAnh.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000C2174 File Offset: 0x000C0374
		private void panel1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbRandomGoVanBan.Visible = true;
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000C21D4 File Offset: 0x000C03D4
		private void btnChooseFileUid_Click(object sender, EventArgs e)
		{
			this.txtPathFileUid.Text = MCommon.Common.SelectFile("Chọn File txt", "txt Files (*.txt)|*.txt|");
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000C2224 File Offset: 0x000C0424
		private void rbFileUid_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPathFileUid.Enabled = this.rbFileUid.Checked;
			this.btnChooseFileUid.Enabled = this.rbFileUid.Checked;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000C2274 File Offset: 0x000C0474
		private void rbListUid_CheckedChanged(object sender, EventArgs e)
		{
			this.txtUid.Enabled = this.rbListUid.Checked;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000C22A4 File Offset: 0x000C04A4
		private void button2_Click_1(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000C22E8 File Offset: 0x000C04E8
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000C2314 File Offset: 0x000C0514
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + Language.GetValue("Ví dụ") + ": 15465478242/posts", 1);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000C1EFC File Offset: 0x000C00FC
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000C1EFC File Offset: 0x000C00FC
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000C2390 File Offset: 0x000C0590
		private void button5_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox("Có thể dùng [u] để thay thế tên của UID!", 1);
		}

		// Token: 0x04000836 RID: 2102
		private JSON_Settings setting;

		// Token: 0x04000837 RID: 2103
		private string id_KichBan;

		// Token: 0x04000838 RID: 2104
		private string id_TuongTac;

		// Token: 0x04000839 RID: 2105
		private string Id_HanhDong;

		// Token: 0x0400083A RID: 2106
		private int type;

		// Token: 0x0400083B RID: 2107
		public static bool isSave;
	}
}
