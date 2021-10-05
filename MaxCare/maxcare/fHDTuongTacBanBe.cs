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
	// Token: 0x020000FC RID: 252
	public partial class fHDTuongTacBanBe : Form
	{
		// Token: 0x06000A40 RID: 2624 RVA: 0x00154FC4 File Offset: 0x001531C4
		public fHDTuongTacBanBe(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDTuongTacBanBe.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDTuongTacBanBe").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBanBe', 'Tương tác Bạn bè');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDTuongTacBanBe");
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

		// Token: 0x06000A41 RID: 2625 RVA: 0x00155210 File Offset: 0x00153410
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label68);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label21);
			Language.GetValue(this.label16);
			Language.GetValue(this.label18);
			Language.GetValue(this.label20);
			Language.GetValue(this.label15);
			Language.GetValue(this.label17);
			Language.GetValue(this.label10);
			Language.GetValue(this.label2);
			Language.GetValue(this.label12);
			Language.GetValue(this.label11);
			Language.GetValue(this.label14);
			Language.GetValue(this.label13);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x001553A8 File Offset: 0x001535A8
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongBanBeFrom.Value = this.setting.GetValueInt("nudSoLuongBanBeFrom", 1);
				this.nudSoLuongBanBeTo.Value = this.setting.GetValueInt("nudSoLuongBanBeTo", 3);
				this.nudTimeFrom.Value = this.setting.GetValueInt("nudTimeFrom", 10);
				this.nudTimeTo.Value = this.setting.GetValueInt("nudTimeTo", 30);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 1);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 3);
				this.nudCountLikeFrom.Value = this.setting.GetValueInt("nudCountLikeFrom", 1);
				this.nudCountLikeTo.Value = this.setting.GetValueInt("nudCountLikeTo", 3);
				this.nudCountShareFrom.Value = this.setting.GetValueInt("nudCountShareFrom", 1);
				this.nudCountShareTo.Value = this.setting.GetValueInt("nudCountShareTo", 3);
				this.nudCountCommentFrom.Value = this.setting.GetValueInt("nudCountCommentFrom", 1);
				this.nudCountCommentTo.Value = this.setting.GetValueInt("nudCountCommentTo", 3);
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbShareWall.Checked = this.setting.GetValueBool("ckbShareWall", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.ckbCommentText.Checked = this.setting.GetValueBool("ckbCommentText", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
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
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00155920 File Offset: 0x00153B20
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
				bool @checked = this.ckbComment.Checked;
				if (@checked)
				{
					List<string> list = this.txtComment.Lines.ToList<string>();
					list = MCommon.Common.RemoveEmptyItems(list);
					bool flag2 = list.Count == 0;
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
						return;
					}
				}
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update("nudSoLuongBanBeFrom", this.nudSoLuongBanBeFrom.Value);
				json_Settings.Update("nudSoLuongBanBeTo", this.nudSoLuongBanBeTo.Value);
				json_Settings.Update("nudTimeFrom", this.nudTimeFrom.Value);
				json_Settings.Update("nudTimeTo", this.nudTimeTo.Value);
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
				json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
				json_Settings.Update("ckbComment", this.ckbComment.Checked);
				json_Settings.Update("ckbCommentText", this.ckbCommentText.Checked);
				json_Settings.Update("txtComment", this.txtComment.Text.Trim());
				json_Settings.Update("nudCountLikeFrom", this.nudCountLikeFrom.Value);
				json_Settings.Update("nudCountLikeTo", this.nudCountLikeTo.Value);
				json_Settings.Update("nudCountShareFrom", this.nudCountShareFrom.Value);
				json_Settings.Update("nudCountShareTo", this.nudCountShareTo.Value);
				json_Settings.Update("nudCountCommentFrom", this.nudCountCommentFrom.Value);
				json_Settings.Update("nudCountCommentTo", this.nudCountCommentTo.Value);
				json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
				json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
				int num = 0;
				bool checked2 = this.rbNganCachKyTu.Checked;
				if (checked2)
				{
					num = 1;
				}
				json_Settings.Update("typeNganCach", num);
				string fullString = json_Settings.GetFullString();
				bool flag3 = this.type == 0;
				if (flag3)
				{
					bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
					if (flag4)
					{
						bool flag5 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag5)
						{
							fHDTuongTacBanBe.isSave = true;
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
					bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
					if (flag6)
					{
						bool flag7 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
						if (flag7)
						{
							fHDTuongTacBanBe.isSave = true;
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

		// Token: 0x06000A45 RID: 2629 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00155F60 File Offset: 0x00154160
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

		// Token: 0x06000A47 RID: 2631 RVA: 0x00156024 File Offset: 0x00154224
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00156040 File Offset: 0x00154240
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

		// Token: 0x06000A49 RID: 2633 RVA: 0x0015613C File Offset: 0x0015433C
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbShareWall_CheckedChanged(null, null);
			this.ckbCommentText_CheckedChanged(null, null);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00156184 File Offset: 0x00154384
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x001561B4 File Offset: 0x001543B4
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 162;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x001561D8 File Offset: 0x001543D8
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 210;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x001561FC File Offset: 0x001543FC
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00156024 File Offset: 0x00154224
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00156024 File Offset: 0x00154224
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00156270 File Offset: 0x00154470
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountLike.Enabled = this.ckbInteract.Checked;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x001562A0 File Offset: 0x001544A0
		private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountShareWall.Enabled = this.ckbShareWall.Checked;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x001562D0 File Offset: 0x001544D0
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00156314 File Offset: 0x00154514
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00156340 File Offset: 0x00154540
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00156370 File Offset: 0x00154570
		private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x04000EB4 RID: 3764
		private JSON_Settings setting;

		// Token: 0x04000EB5 RID: 3765
		private string id_KichBan;

		// Token: 0x04000EB6 RID: 3766
		private string id_TuongTac;

		// Token: 0x04000EB7 RID: 3767
		private string Id_HanhDong;

		// Token: 0x04000EB8 RID: 3768
		private int type;

		// Token: 0x04000EB9 RID: 3769
		public static bool isSave;
	}
}
