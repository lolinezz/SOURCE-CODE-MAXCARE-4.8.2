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
	// Token: 0x020000FD RID: 253
	public partial class fHDSeedingByVideo : Form
	{
		// Token: 0x06000A5A RID: 2650 RVA: 0x0015ACA8 File Offset: 0x00158EA8
		public fHDSeedingByVideo(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDSeedingByVideo.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDSeedingByVideo").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSeedingByVideo', 'Seeding bằng video');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDSeedingByVideo");
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

		// Token: 0x06000A5B RID: 2651 RVA: 0x0015AEF4 File Offset: 0x001590F4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label2);
			Language.GetValue(this.label10);
			Language.GetValue(this.label10);
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label11);
			Language.GetValue(this.label8);
			Language.GetValue(this.rbNganCachMoiDong);
			Language.GetValue(this.rbNganCachKyTu);
			Language.GetValue(this.ckbSendVideo);
			Language.GetValue(this.button3);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0015B034 File Offset: 0x00159234
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.txtIdPost.Text = this.setting.GetValue("txtIdPost", "");
				this.ckbSendVideo.Checked = this.setting.GetValueBool("ckbSendVideo", false);
				this.txtVideo.Text = this.setting.GetValue("txtVideo", "");
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

		// Token: 0x06000A5D RID: 2653 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0015B2C4 File Offset: 0x001594C4
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
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("ckbComment", this.ckbComment.Checked);
					json_Settings.Update("txtComment", this.txtComment.Text.Trim());
					json_Settings.Update("txtIdPost", this.txtIdPost.Text.Trim());
					json_Settings.Update("ckbSendVideo", this.ckbSendVideo.Checked);
					json_Settings.Update("txtVideo", this.txtVideo.Text.Trim());
					int num = 0;
					bool checked2 = this.rbNganCachKyTu.Checked;
					if (checked2)
					{
						num = 1;
					}
					json_Settings.Update("typeNganCach", num);
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
								fHDSeedingByVideo.isSave = true;
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
								fHDSeedingByVideo.isSave = true;
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

		// Token: 0x06000A5F RID: 2655 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0015B718 File Offset: 0x00159918
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

		// Token: 0x06000A61 RID: 2657 RVA: 0x0015B7DC File Offset: 0x001599DC
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

		// Token: 0x06000A62 RID: 2658 RVA: 0x0015B870 File Offset: 0x00159A70
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0015B89C File Offset: 0x00159A9C
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0015B8CC File Offset: 0x00159ACC
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

		// Token: 0x06000A66 RID: 2662 RVA: 0x0015B960 File Offset: 0x00159B60
		private void button3_Click(object sender, EventArgs e)
		{
			this.txtVideo.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0015B984 File Offset: 0x00159B84
		private void ckbSendVideo_CheckedChanged(object sender, EventArgs e)
		{
			this.plVideo.Enabled = this.ckbSendVideo.Checked;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00054604 File Offset: 0x00052804
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000EFD RID: 3837
		private JSON_Settings setting;

		// Token: 0x04000EFE RID: 3838
		private string id_KichBan;

		// Token: 0x04000EFF RID: 3839
		private string id_TuongTac;

		// Token: 0x04000F00 RID: 3840
		private string Id_HanhDong;

		// Token: 0x04000F01 RID: 3841
		private int type;

		// Token: 0x04000F02 RID: 3842
		public static bool isSave;
	}
}
