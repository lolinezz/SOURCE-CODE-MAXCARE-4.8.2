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
	// Token: 0x0200011E RID: 286
	public partial class fHDXemWatch : Form
	{
		// Token: 0x06000C8C RID: 3212 RVA: 0x001CEAB8 File Offset: 0x001CCCB8
		public fHDXemWatch(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDXemWatch.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string jsonStringOrPathFile = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDXemWatch");
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

		// Token: 0x06000C8D RID: 3213 RVA: 0x001CEC9C File Offset: 0x001CCE9C
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
			Language.GetValue(this.label10);
			Language.GetValue(this.label9);
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

		// Token: 0x06000C8E RID: 3214 RVA: 0x001CEDF0 File Offset: 0x001CCFF0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 0);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 0);
				this.nudTimeWatchFrom.Value = this.setting.GetValueInt("nudTimeWatchFrom", 0);
				this.nudTimeWatchTo.Value = this.setting.GetValueInt("nudTimeWatchTo", 0);
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.ckbShareWall.Checked = this.setting.GetValueBool("ckbShareWall", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.nudCountLikeFrom.Value = this.setting.GetValueInt("nudCountLikeFrom", 1);
				this.nudCountLikeTo.Value = this.setting.GetValueInt("nudCountLikeTo", 3);
				this.nudCountShareFrom.Value = this.setting.GetValueInt("nudCountShareFrom", 1);
				this.nudCountShareTo.Value = this.setting.GetValueInt("nudCountShareTo", 3);
				this.nudCountCommentFrom.Value = this.setting.GetValueInt("nudCountCommentFrom", 1);
				this.nudCountCommentTo.Value = this.setting.GetValueInt("nudCountCommentTo", 3);
				this.ckbFollow.Checked = this.setting.GetValueBool("ckbFollow", false);
				this.nudFollowFrom.Value = this.setting.GetValueInt("nudFollowFrom", 1);
				this.nudFollowTo.Value = this.setting.GetValueInt("nudFollowTo", 2);
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x001CF278 File Offset: 0x001CD478
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
				json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
				json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
				json_Settings.Update("nudTimeWatchFrom", this.nudTimeWatchFrom.Value);
				json_Settings.Update("nudTimeWatchTo", this.nudTimeWatchTo.Value);
				json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
				json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
				json_Settings.Update("ckbComment", this.ckbComment.Checked);
				json_Settings.Update("txtComment", this.txtComment.Text.Trim());
				json_Settings.Update("nudCountLikeFrom", this.nudCountLikeFrom.Value);
				json_Settings.Update("nudCountLikeTo", this.nudCountLikeTo.Value);
				json_Settings.Update("nudCountShareFrom", this.nudCountShareFrom.Value);
				json_Settings.Update("nudCountShareTo", this.nudCountShareTo.Value);
				json_Settings.Update("nudCountCommentFrom", this.nudCountCommentFrom.Value);
				json_Settings.Update("nudCountCommentTo", this.nudCountCommentTo.Value);
				json_Settings.Update("ckbFollow", this.ckbFollow.Checked);
				json_Settings.Update("nudFollowFrom", this.nudFollowFrom.Value);
				json_Settings.Update("nudFollowTo", this.nudFollowTo.Value);
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
							fHDXemWatch.isSave = true;
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
							fHDXemWatch.isSave = true;
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

		// Token: 0x06000C91 RID: 3217 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x001CF80C File Offset: 0x001CDA0C
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

		// Token: 0x06000C93 RID: 3219 RVA: 0x001CF8D0 File Offset: 0x001CDAD0
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

		// Token: 0x06000C94 RID: 3220 RVA: 0x001CF964 File Offset: 0x001CDB64
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged_1(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbShareWall_CheckedChanged(null, null);
			this.ckbFollow_CheckedChanged(null, null);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x001CF9AC File Offset: 0x001CDBAC
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
			this.plCountComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x001CF9FC File Offset: 0x001CDBFC
		private void ckbInteract_CheckedChanged_1(object sender, EventArgs e)
		{
			this.plCountLike.Enabled = this.ckbInteract.Checked;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x001CFA2C File Offset: 0x001CDC2C
		private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountShareWall.Enabled = this.ckbShareWall.Checked;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x001CFA5C File Offset: 0x001CDC5C
		private void ckbFollow_CheckedChanged(object sender, EventArgs e)
		{
			this.plFollow.Enabled = this.ckbFollow.Checked;
		}

		// Token: 0x040014B0 RID: 5296
		private JSON_Settings setting;

		// Token: 0x040014B1 RID: 5297
		private string id_KichBan;

		// Token: 0x040014B2 RID: 5298
		private string id_TuongTac;

		// Token: 0x040014B3 RID: 5299
		private string Id_HanhDong;

		// Token: 0x040014B4 RID: 5300
		private int type;

		// Token: 0x040014B5 RID: 5301
		public static bool isSave;
	}
}
