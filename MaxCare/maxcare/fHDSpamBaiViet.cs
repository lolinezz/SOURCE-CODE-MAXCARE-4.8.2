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
	// Token: 0x02000102 RID: 258
	public partial class fHDSpamBaiViet : Form
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x0016F5B0 File Offset: 0x0016D7B0
		public fHDSpamBaiViet(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDSpamBaiViet.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = "HDSpamBaiViet";
			string text2 = "Spam bài viết";
			bool flag = InteractSQL.GetTuongTac("", text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(string.Concat(new string[]
				{
					"INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('",
					text,
					"', '",
					text2,
					"');"
				}));
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

		// Token: 0x06000ABA RID: 2746 RVA: 0x0016F848 File Offset: 0x0016DA48
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

		// Token: 0x06000ABB RID: 2747 RVA: 0x0016FA44 File Offset: 0x0016DC44
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongUidFrom.Value = this.setting.GetValueInt("nudSoLuongUidFrom", 1);
				this.nudSoLuongUidTo.Value = this.setting.GetValueInt("nudSoLuongUidTo", 1);
				this.nudSoLuongBaiVietFrom.Value = this.setting.GetValueInt("nudSoLuongBaiVietFrom", 1);
				this.nudSoLuongBaiVietTo.Value = this.setting.GetValueInt("nudSoLuongBaiVietTo", 3);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 2);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
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
				this.ckbBoQua.Checked = this.setting.GetValueBool("ckbBoQua", false);
				this.nudBoQuaFrom.Value = this.setting.GetValueInt("nudBoQuaFrom", 1);
				this.nudBoQuaTo.Value = this.setting.GetValueInt("nudBoQuaTo", 1);
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

		// Token: 0x06000ABC RID: 2748 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0016FFF8 File Offset: 0x0016E1F8
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
						json_Settings.Update("ckbAutoDeleteComment", this.ckbAutoDeleteComment.Checked);
						json_Settings.Update("txtComment", this.txtComment.Text.Trim());
						json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
						json_Settings.Update("ckbTuDongXoaUid", this.ckbTuDongXoaUid.Checked);
						json_Settings.Update("ckbBoQua", this.ckbBoQua.Checked);
						json_Settings.Update("nudBoQuaFrom", this.nudBoQuaFrom.Value);
						json_Settings.Update("nudBoQuaTo", this.nudBoQuaTo.Value);
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
							fHDSpamBaiViet.isSave = true;
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
						json_Settings2.Update("ckbAutoDeleteComment", this.ckbAutoDeleteComment.Checked);
						json_Settings2.Update("txtComment", this.txtComment.Text.Trim());
						json_Settings2.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings2.Update("txtAnh", this.txtAnh.Text.Trim());
						json_Settings2.Update("ckbTuDongXoaUid", this.ckbTuDongXoaUid.Checked);
						json_Settings2.Update("ckbBoQua", this.ckbBoQua.Checked);
						json_Settings2.Update("nudBoQuaFrom", this.nudBoQuaFrom.Value);
						json_Settings2.Update("nudBoQuaTo", this.nudBoQuaTo.Value);
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
							fHDSpamBaiViet.isSave = true;
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

		// Token: 0x06000ABE RID: 2750 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00170F18 File Offset: 0x0016F118
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

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00170FDC File Offset: 0x0016F1DC
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00170FF8 File Offset: 0x0016F1F8
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

		// Token: 0x06000AC3 RID: 2755 RVA: 0x001710F4 File Offset: 0x0016F2F4
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.rbFileUid_CheckedChanged(null, null);
			this.rbListUid_CheckedChanged(null, null);
			this.ckbBoQua_CheckedChanged(null, null);
			this.ckbTheoThuTu_CheckedChanged(null, null);
			this.ckbTuDongXoaUid_CheckedChanged(null, null);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00171164 File Offset: 0x0016F364
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00171194 File Offset: 0x0016F394
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

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00171228 File Offset: 0x0016F428
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00171258 File Offset: 0x0016F458
		private void button2_Click(object sender, EventArgs e)
		{
			this.txtAnh.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0017127C File Offset: 0x0016F47C
		private void panel1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x001712C4 File Offset: 0x0016F4C4
		private void btnChooseFileUid_Click(object sender, EventArgs e)
		{
			this.txtPathFileUid.Text = MCommon.Common.SelectFile("Chọn File txt", "txt Files (*.txt)|*.txt|");
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00171314 File Offset: 0x0016F514
		private void rbFileUid_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPathFileUid.Enabled = this.rbFileUid.Checked;
			this.btnChooseFileUid.Enabled = this.rbFileUid.Checked;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00171364 File Offset: 0x0016F564
		private void rbListUid_CheckedChanged(object sender, EventArgs e)
		{
			this.txtUid.Enabled = this.rbListUid.Checked;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00171394 File Offset: 0x0016F594
		private void button2_Click_1(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x001713D8 File Offset: 0x0016F5D8
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000C2314 File Offset: 0x000C0514
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + Language.GetValue("Ví dụ") + ": 15465478242/posts", 1);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00170FDC File Offset: 0x0016F1DC
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00170FDC File Offset: 0x0016F1DC
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000C2390 File Offset: 0x000C0590
		private void button5_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox("Có thể dùng [u] để thay thế tên của UID!", 1);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00171404 File Offset: 0x0016F604
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 215;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00171428 File Offset: 0x0016F628
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 193;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0017144C File Offset: 0x0016F64C
		private void ckbBoQua_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbBoQua.Checked;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbTheoThuTu_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbTuDongXoaUid_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04001002 RID: 4098
		private JSON_Settings setting;

		// Token: 0x04001003 RID: 4099
		private string id_KichBan;

		// Token: 0x04001004 RID: 4100
		private string id_TuongTac;

		// Token: 0x04001005 RID: 4101
		private string Id_HanhDong;

		// Token: 0x04001006 RID: 4102
		private int type;

		// Token: 0x04001007 RID: 4103
		public static bool isSave;
	}
}
