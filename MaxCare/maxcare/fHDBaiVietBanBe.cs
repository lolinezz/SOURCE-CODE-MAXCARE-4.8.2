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
	// Token: 0x0200011C RID: 284
	public partial class fHDBaiVietBanBe : Form
	{
		// Token: 0x06000C56 RID: 3158 RVA: 0x001C595C File Offset: 0x001C3B5C
		public fHDBaiVietBanBe(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBaiVietBanBe.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string jsonStringOrPathFile = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBaiVietBanBe");
				jsonStringOrPathFile = tuongTac.Rows[0]["CauHinh"].ToString();
				this.id_TuongTac = tuongTac.Rows[0]["Id_TuongTac"].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0]["MoTa"].ToString());
			}
			else
			{
				bool flag2 = type == 1;
				if (flag2)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					jsonStringOrPathFile = hanhDongById.Rows[0]["CauHinh"].ToString();
					this.btnAdd.Text = Language.GetValue("Cập nhật");
					this.txtTenHanhDong.Text = hanhDongById.Rows[0]["TenHanhDong"].ToString();
				}
			}
			this.setting = new JSON_Settings(jsonStringOrPathFile, true);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x001C5B40 File Offset: 0x001C3D40
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label68);
			Language.GetValue(this.label19);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.ckbShareWall);
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x001C5C80 File Offset: 0x001C3E80
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongBanBeFrom.Value = this.setting.GetValueInt("nudSoLuongBanBeFrom", 3);
				this.nudSoLuongBanBeTo.Value = this.setting.GetValueInt("nudSoLuongBanBeTo", 5);
				this.nudSoLuongBaiVietFrom.Value = this.setting.GetValueInt("nudSoLuongBaiVietFrom", 3);
				this.nudSoLuongBaiVietTo.Value = this.setting.GetValueInt("nudSoLuongBaiVietTo", 3);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbShareWall.Checked = this.setting.GetValueBool("ckbShareWall", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.ckbCommentText.Checked = this.setting.GetValueBool("ckbCommentText", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				bool flag = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
				this.ckbSendAnh.Checked = this.setting.GetValueBool("ckbSendAnh", false);
				this.txtAnh.Text = this.setting.GetValue("txtAnh", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x001C6078 File Offset: 0x001C4278
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
						bool @checked = this.ckbComment.Checked;
						if (@checked)
						{
							List<string> list = this.txtComment.Lines.ToList<string>();
							list = MCommon.Common.RemoveEmptyItems(list);
							bool flag4 = list.Count == 0;
							if (flag4)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
								return;
							}
						}
						JSON_Settings json_Settings = new JSON_Settings();
						json_Settings.Update("nudSoLuongBanBeFrom", this.nudSoLuongBanBeFrom.Value);
						json_Settings.Update("nudSoLuongBanBeTo", this.nudSoLuongBanBeTo.Value);
						json_Settings.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
						json_Settings.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
						json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings.Update("ckbComment", this.ckbComment.Checked);
						json_Settings.Update("ckbCommentText", this.ckbCommentText.Checked);
						json_Settings.Update("txtComment", this.txtComment.Text.Trim());
						int num = 0;
						bool checked2 = this.rbNganCachKyTu.Checked;
						if (checked2)
						{
							num = 1;
						}
						json_Settings.Update("typeNganCach", num);
						json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
						string fullString = json_Settings.GetFullString();
						bool flag5 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag5)
						{
							fHDBaiVietBanBe.isSave = true;
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
				bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
				if (flag6)
				{
					string text2 = this.txtTenHanhDong.Text.Trim();
					bool flag7 = text2 == "";
					if (flag7)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập tên hành động!"), 3);
					}
					else
					{
						bool checked3 = this.ckbComment.Checked;
						if (checked3)
						{
							List<string> list2 = this.txtComment.Lines.ToList<string>();
							list2 = MCommon.Common.RemoveEmptyItems(list2);
							bool flag8 = list2.Count == 0;
							if (flag8)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
								return;
							}
						}
						JSON_Settings json_Settings2 = new JSON_Settings();
						json_Settings2.Update("nudSoLuongBanBeFrom", this.nudSoLuongBanBeFrom.Value);
						json_Settings2.Update("nudSoLuongBanBeTo", this.nudSoLuongBanBeTo.Value);
						json_Settings2.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
						json_Settings2.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
						json_Settings2.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings2.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings2.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings2.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings2.Update("ckbComment", this.ckbComment.Checked);
						json_Settings2.Update("ckbCommentText", this.ckbCommentText.Checked);
						json_Settings2.Update("txtComment", this.txtComment.Text.Trim());
						int num2 = 0;
						bool checked4 = this.rbNganCachKyTu.Checked;
						if (checked4)
						{
							num2 = 1;
						}
						json_Settings2.Update("typeNganCach", num2);
						json_Settings2.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings2.Update("txtAnh", this.txtAnh.Text.Trim());
						string fullString2 = json_Settings2.GetFullString();
						bool flag9 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text2, fullString2);
						if (flag9)
						{
							fHDBaiVietBanBe.isSave = true;
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

		// Token: 0x06000C5B RID: 3163 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x001C695C File Offset: 0x001C4B5C
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

		// Token: 0x06000C5D RID: 3165 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x001C6A20 File Offset: 0x001C4C20
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x001C6A3C File Offset: 0x001C4C3C
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

		// Token: 0x06000C60 RID: 3168 RVA: 0x001C6B38 File Offset: 0x001C4D38
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbCommentText_CheckedChanged(null, null);
			this.ckbSendAnh_CheckedChanged(null, null);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x001C6B80 File Offset: 0x001C4D80
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x001C6BB0 File Offset: 0x001C4DB0
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 163;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x001C6BD4 File Offset: 0x001C4DD4
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 207;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x001C6BF8 File Offset: 0x001C4DF8
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x001C6A20 File Offset: 0x001C4C20
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x001C6A20 File Offset: 0x001C4C20
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x001C6C6C File Offset: 0x001C4E6C
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x001C6CB0 File Offset: 0x001C4EB0
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x001C6CDC File Offset: 0x001C4EDC
		private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x001C6D0C File Offset: 0x001C4F0C
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x04001445 RID: 5189
		private JSON_Settings setting;

		// Token: 0x04001446 RID: 5190
		private string id_KichBan;

		// Token: 0x04001447 RID: 5191
		private string id_TuongTac;

		// Token: 0x04001448 RID: 5192
		private string Id_HanhDong;

		// Token: 0x04001449 RID: 5193
		private int type;

		// Token: 0x0400144A RID: 5194
		public static bool isSave;
	}
}
