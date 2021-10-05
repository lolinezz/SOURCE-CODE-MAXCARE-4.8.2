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

namespace maxcare
{
	// Token: 0x020000D0 RID: 208
	public partial class fHDPhanHoiBinhLuan : Form
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x0010A5A4 File Offset: 0x001087A4
		public fHDPhanHoiBinhLuan(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDPhanHoiBinhLuan.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = base.Name.Substring(1);
			string text2 = "Phản hồi bình luận";
			bool flag = InteractSQL.GetTuongTac("", text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(string.Concat(new string[]
				{
					"INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('",
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

		// Token: 0x0600088B RID: 2187 RVA: 0x0010A834 File Offset: 0x00108A34
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label2);
			Language.GetValue(this.label10);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0010A8DC File Offset: 0x00108ADC
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 3);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbGanThe.Checked = this.setting.GetValueBool("ckbGanThe", false);
				this.ckbCommentImage.Checked = this.setting.GetValueBool("ckbCommentImage", false);
				this.txtPath.Text = this.setting.GetValue("txtPath", "");
				this.ckbCommentText.Checked = this.setting.GetValueBool("ckbCommentText", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.txtUid.Text = this.setting.GetValue("txtUid", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0010ABC0 File Offset: 0x00108DC0
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
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Uid cá nhân!"), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("ckbGanThe", this.ckbGanThe.Checked);
					json_Settings.Update("ckbCommentImage", this.ckbCommentImage.Checked);
					json_Settings.Update("txtPath", this.txtPath.Text);
					json_Settings.Update("ckbCommentText", this.ckbCommentText.Checked);
					json_Settings.Update("txtComment", this.txtComment.Text);
					json_Settings.Update("txtUid", this.txtUid.Text.Trim());
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
								fHDPhanHoiBinhLuan.isSave = true;
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
								fHDPhanHoiBinhLuan.isSave = true;
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

		// Token: 0x0600088F RID: 2191 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0010AFD8 File Offset: 0x001091D8
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

		// Token: 0x06000891 RID: 2193 RVA: 0x0010B09C File Offset: 0x0010929C
		private void CheckedChangeFull()
		{
			this.ckbCommentImage_CheckedChanged(null, null);
			this.ckbCommentText_CheckedChanged(null, null);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0010B0C8 File Offset: 0x001092C8
		private void txtIdPost_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label2.Text = string.Format(Language.GetValue("Danh sách ID Comment ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0010B15C File Offset: 0x0010935C
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblComment.Text = string.Format(Language.GetValue("Danh sách comment ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0010B1F0 File Offset: 0x001093F0
		private void ckbCommentImage_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPath.Enabled = this.ckbCommentImage.Checked;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0010B220 File Offset: 0x00109420
		private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x04000BE7 RID: 3047
		private JSON_Settings setting;

		// Token: 0x04000BE8 RID: 3048
		private string id_KichBan;

		// Token: 0x04000BE9 RID: 3049
		private string id_TuongTac;

		// Token: 0x04000BEA RID: 3050
		private string Id_HanhDong;

		// Token: 0x04000BEB RID: 3051
		private int type;

		// Token: 0x04000BEC RID: 3052
		public static bool isSave;
	}
}
