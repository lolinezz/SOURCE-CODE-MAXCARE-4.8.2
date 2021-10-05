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
	// Token: 0x0200011D RID: 285
	public partial class fHDBaiVietNewsfeed : Form
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x001CA4FC File Offset: 0x001C86FC
		public fHDBaiVietNewsfeed(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBaiVietNewsfeed.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string jsonStringOrPathFile = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBaiVietNewsfeed");
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

		// Token: 0x06000C71 RID: 3185 RVA: 0x001CA6E0 File Offset: 0x001C88E0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
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

		// Token: 0x06000C72 RID: 3186 RVA: 0x001CA7F0 File Offset: 0x001C89F0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 3);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 5);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 5);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 7);
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

		// Token: 0x06000C73 RID: 3187 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x001CAB68 File Offset: 0x001C8D68
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
						json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
						json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
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
							fHDBaiVietNewsfeed.isSave = true;
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
						json_Settings2.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
						json_Settings2.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
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
							fHDBaiVietNewsfeed.isSave = true;
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

		// Token: 0x06000C75 RID: 3189 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x001CB388 File Offset: 0x001C9588
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

		// Token: 0x06000C77 RID: 3191 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x001CB44C File Offset: 0x001C964C
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

		// Token: 0x06000C79 RID: 3193 RVA: 0x001CB4E0 File Offset: 0x001C96E0
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.rbNganCachMoiDong_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
			this.ckbSendAnh_CheckedChanged(null, null);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x001CB534 File Offset: 0x001C9734
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x001CB564 File Offset: 0x001C9764
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x001CB580 File Offset: 0x001C9780
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

		// Token: 0x06000C7E RID: 3198 RVA: 0x001CB67C File Offset: 0x001C987C
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 207;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x001CB6A0 File Offset: 0x001C98A0
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 165;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x001CB564 File Offset: 0x001C9764
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x001CB6C4 File Offset: 0x001C98C4
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x001CB738 File Offset: 0x001C9938
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x001CB77C File Offset: 0x001C997C
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00054604 File Offset: 0x00052804
		private void plComment_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00054604 File Offset: 0x00052804
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x001CB7A8 File Offset: 0x001C99A8
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x001CB7D8 File Offset: 0x001C99D8
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x0400147D RID: 5245
		private JSON_Settings setting;

		// Token: 0x0400147E RID: 5246
		private string id_KichBan;

		// Token: 0x0400147F RID: 5247
		private string id_TuongTac;

		// Token: 0x04001480 RID: 5248
		private string Id_HanhDong;

		// Token: 0x04001481 RID: 5249
		private int type;

		// Token: 0x04001482 RID: 5250
		public static bool isSave;
	}
}
