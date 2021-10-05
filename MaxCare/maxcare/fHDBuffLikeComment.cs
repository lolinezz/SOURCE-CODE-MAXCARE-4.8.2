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
	// Token: 0x02000108 RID: 264
	public partial class fHDBuffLikeComment : Form
	{
		// Token: 0x06000B3C RID: 2876 RVA: 0x00188E08 File Offset: 0x00187008
		public fHDBuffLikeComment(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBuffLikeComment.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDBuffLikeComment").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffLikeComment', 'Buff Like, Comment');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBuffLikeComment");
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

		// Token: 0x06000B3D RID: 2877 RVA: 0x00189050 File Offset: 0x00187250
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

		// Token: 0x06000B3E RID: 2878 RVA: 0x0018924C File Offset: 0x0018744C
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
				this.ckbCommentText.Checked = this.setting.GetValueBool("ckbCommentText", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.txtIdPost.Text = this.setting.GetValue("txtIdPost", "");
				this.ckbTag.Checked = this.setting.GetValueBool("ckbTag", false);
				this.nudSoLuongTagFrom.Value = this.setting.GetValueInt("nudSoLuongTagFrom", 3);
				this.nudSoLuongTagTo.Value = this.setting.GetValueInt("nudSoLuongTagTo", 5);
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
				this.ckbAutoDeleteComment.Checked = this.setting.GetValueBool("ckbAutoDeleteComment", false);
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x001897EC File Offset: 0x001879EC
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
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Id bài viết cần buff like, comment!"), 3);
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
					json_Settings.Update("ckbCommentText", this.ckbCommentText.Checked);
					json_Settings.Update("txtComment", this.txtComment.Text.Trim());
					json_Settings.Update("txtIdPost", this.txtIdPost.Text.Trim());
					json_Settings.Update("ckbTag", this.ckbTag.Checked);
					json_Settings.Update("nudSoLuongTagFrom", this.nudSoLuongTagFrom.Value);
					json_Settings.Update("nudSoLuongTagTo", this.nudSoLuongTagTo.Value);
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
					json_Settings.Update("ckbAutoDeleteComment", this.ckbAutoDeleteComment.Checked);
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
								fHDBuffLikeComment.isSave = true;
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
								fHDBuffLikeComment.isSave = true;
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

		// Token: 0x06000B41 RID: 2881 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00189EA4 File Offset: 0x001880A4
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

		// Token: 0x06000B43 RID: 2883 RVA: 0x00189F68 File Offset: 0x00188168
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

		// Token: 0x06000B44 RID: 2884 RVA: 0x00189FFC File Offset: 0x001881FC
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
			this.ckbTag_CheckedChanged(null, null);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0018A044 File Offset: 0x00188244
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0018A074 File Offset: 0x00188274
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

		// Token: 0x06000B48 RID: 2888 RVA: 0x0018A108 File Offset: 0x00188308
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00054604 File Offset: 0x00052804
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00054604 File Offset: 0x00052804
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00054604 File Offset: 0x00052804
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00054604 File Offset: 0x00052804
		private void label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00054604 File Offset: 0x00052804
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0018A138 File Offset: 0x00188338
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 195;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0018A15C File Offset: 0x0018835C
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 267;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0018A180 File Offset: 0x00188380
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0018A1C4 File Offset: 0x001883C4
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0018A1F0 File Offset: 0x001883F0
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0018A220 File Offset: 0x00188420
		private void ckbTag_CheckedChanged(object sender, EventArgs e)
		{
			this.plTag.Enabled = this.ckbTag.Checked;
		}

		// Token: 0x04001133 RID: 4403
		private JSON_Settings setting;

		// Token: 0x04001134 RID: 4404
		private string id_KichBan;

		// Token: 0x04001135 RID: 4405
		private string id_TuongTac;

		// Token: 0x04001136 RID: 4406
		private string Id_HanhDong;

		// Token: 0x04001137 RID: 4407
		private int type;

		// Token: 0x04001138 RID: 4408
		public static bool isSave;
	}
}
