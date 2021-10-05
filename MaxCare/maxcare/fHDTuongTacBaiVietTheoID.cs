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
	// Token: 0x020000B8 RID: 184
	public partial class fHDTuongTacBaiVietTheoID : Form
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x000B6934 File Offset: 0x000B4B34
		public fHDTuongTacBaiVietTheoID(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDTuongTacBaiVietTheoID.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDTuongTacBaiVietTheoID").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietTheoID', 'Tương tác bài viết theo ID');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDTuongTacBaiVietTheoID");
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

		// Token: 0x060006FA RID: 1786 RVA: 0x000B6B7C File Offset: 0x000B4D7C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label2);
			Language.GetValue(this.label10);
			Language.GetValue(this.label3);
			Language.GetValue(this.label9);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbInteract);
			Language.GetValue(this.ckbShareWall);
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label11);
			Language.GetValue(this.label8);
			Language.GetValue(this.rbNganCachMoiDong);
			Language.GetValue(this.button2);
			Language.GetValue(this.rbNganCachKyTu);
			Language.GetValue(this.button3);
			Language.GetValue(this.ckbSendAnh);
			Language.GetValue(this.label12);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			Language.GetValue(this.label13);
			Language.GetValue(this.rbCommentTheoThuTu);
			Language.GetValue(this.rbCommentNgauNhien);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000B6D78 File Offset: 0x000B4F78
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudTimeFrom.Value = this.setting.GetValueInt("nudTimeFrom", 3);
				this.nudTimeTo.Value = this.setting.GetValueInt("nudTimeTo", 5);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.nudSoLuongUidFrom.Value = this.setting.GetValueInt("nudSoLuongUidFrom", 1);
				this.nudSoLuongUidTo.Value = this.setting.GetValueInt("nudSoLuongUidTo", 3);
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbShareWall.Checked = this.setting.GetValueBool("ckbShareWall", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.txtIdPost.Text = this.setting.GetValue("txtIdPost", "");
				this.ckbTuDongXoa.Checked = this.setting.GetValueBool("ckbTuDongXoa", false);
				this.ckbSendAnh.Checked = this.setting.GetValueBool("ckbSendAnh", false);
				this.txtAnh.Text = this.setting.GetValue("txtAnh", "");
				bool flag = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
				bool flag2 = this.setting.GetValueInt("typeComment", 0) == 1;
				if (flag2)
				{
					this.rbCommentNgauNhien.Checked = true;
				}
				else
				{
					this.rbCommentTheoThuTu.Checked = true;
				}
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000B7224 File Offset: 0x000B5424
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
				List<string> list = this.txtIdPost.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Id bài viết cần tương tác!"), 3);
				}
				else
				{
					bool @checked = this.ckbComment.Checked;
					if (@checked)
					{
						List<string> list2 = this.txtComment.Lines.ToList<string>();
						list2 = MCommon.Common.RemoveEmptyItems(list2);
						bool flag3 = list2.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudTimeFrom", this.nudTimeFrom.Value);
					json_Settings.Update("nudTimeTo", this.nudTimeTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("nudSoLuongUidFrom", this.nudSoLuongUidFrom.Value);
					json_Settings.Update("nudSoLuongUidTo", this.nudSoLuongUidTo.Value);
					json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
					json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
					json_Settings.Update("ckbComment", this.ckbComment.Checked);
					json_Settings.Update("txtComment", this.txtComment.Text.Trim());
					json_Settings.Update("txtIdPost", this.txtIdPost.Text.Trim());
					json_Settings.Update("ckbTuDongXoa", this.ckbTuDongXoa.Checked);
					json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
					json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
					int num = 0;
					bool checked2 = this.rbNganCachKyTu.Checked;
					if (checked2)
					{
						num = 1;
					}
					json_Settings.Update("typeNganCach", num);
					int num2 = 0;
					bool checked3 = this.rbCommentNgauNhien.Checked;
					if (checked3)
					{
						num2 = 1;
					}
					json_Settings.Update("typeComment", num2);
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
								fHDTuongTacBaiVietTheoID.isSave = true;
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
								fHDTuongTacBaiVietTheoID.isSave = true;
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

		// Token: 0x060006FE RID: 1790 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000B7818 File Offset: 0x000B5A18
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

		// Token: 0x06000700 RID: 1792 RVA: 0x000B78DC File Offset: 0x000B5ADC
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000B7970 File Offset: 0x000B5B70
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000B799C File Offset: 0x000B5B9C
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000B79CC File Offset: 0x000B5BCC
		private void txtIdPost_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtIdPost.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label2.Text = string.Format(Language.GetValue("Danh sách ID bài viết ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000B7A60 File Offset: 0x000B5C60
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00054604 File Offset: 0x00052804
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00054604 File Offset: 0x00052804
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00054604 File Offset: 0x00052804
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00054604 File Offset: 0x00052804
		private void label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00054604 File Offset: 0x00052804
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000B7A90 File Offset: 0x000B5C90
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 195;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000B7AB4 File Offset: 0x000B5CB4
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 237;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000B7AD8 File Offset: 0x000B5CD8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000B7B1C File Offset: 0x000B5D1C
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x040007BD RID: 1981
		private JSON_Settings setting;

		// Token: 0x040007BE RID: 1982
		private string id_KichBan;

		// Token: 0x040007BF RID: 1983
		private string id_TuongTac;

		// Token: 0x040007C0 RID: 1984
		private string Id_HanhDong;

		// Token: 0x040007C1 RID: 1985
		private int type;

		// Token: 0x040007C2 RID: 1986
		public static bool isSave;
	}
}
