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
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x02000109 RID: 265
	public partial class fHDBaiVietNewsfeedv2 : Form
	{
		// Token: 0x06000B5A RID: 2906 RVA: 0x0018EB44 File Offset: 0x0018CD44
		public fHDBaiVietNewsfeedv2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBaiVietNewsfeedv2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDBaiVietNewsfeedv2").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBaiVietNewsfeedv2', 'Bài viết Newsfeed v2');");
			}
			string json = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBaiVietNewsfeedv2");
				json = tuongTac.Rows[0]["CauHinh"].ToString();
				this.id_TuongTac = tuongTac.Rows[0]["Id_TuongTac"].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0]["MoTa"].ToString());
			}
			else
			{
				bool flag3 = type == 1;
				if (flag3)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					json = hanhDongById.Rows[0]["CauHinh"].ToString();
					this.btnAdd.Text = Language.GetValue("Cập nhật");
					this.txtTenHanhDong.Text = hanhDongById.Rows[0]["TenHanhDong"].ToString();
				}
			}
			this.setting = JObject.Parse(json);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0018ED8C File Offset: 0x0018CF8C
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
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0018EE88 File Offset: 0x0018D088
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudTimeFrom.Value = Convert.ToInt32(this.setting["nudTimeFrom"]);
				this.nudTimeTo.Value = Convert.ToInt32(this.setting["nudTimeTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.ckbInteract.Checked = Convert.ToBoolean(this.setting["ckbInteract"]);
				this.ckbShareWall.Checked = Convert.ToBoolean(this.setting["ckbShareWall"]);
				this.ckbComment.Checked = Convert.ToBoolean(this.setting["ckbComment"]);
				this.txtComment.Text = this.setting["txtComment"].ToString();
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0018F0C4 File Offset: 0x0018D2C4
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
						json_Settings.Update("nudTimeFrom", this.nudTimeFrom.Value);
						json_Settings.Update("nudTimeTo", this.nudTimeTo.Value);
						json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings.Update("ckbComment", this.ckbComment.Checked);
						json_Settings.Update("txtComment", this.txtComment.Text.Trim());
						string fullString = json_Settings.GetFullString();
						bool flag5 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag5)
						{
							fHDBaiVietNewsfeedv2.isSave = true;
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
						bool checked2 = this.ckbComment.Checked;
						if (checked2)
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
						json_Settings2.Update("nudTimeFrom", this.nudTimeFrom.Value);
						json_Settings2.Update("nudTimeTo", this.nudTimeTo.Value);
						json_Settings2.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings2.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings2.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings2.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings2.Update("ckbComment", this.ckbComment.Checked);
						json_Settings2.Update("txtComment", this.txtComment.Text.Trim());
						string fullString2 = json_Settings2.GetFullString();
						bool flag9 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text2, fullString2);
						if (flag9)
						{
							fHDBaiVietNewsfeedv2.isSave = true;
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

		// Token: 0x06000B5F RID: 2911 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0018F724 File Offset: 0x0018D924
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

		// Token: 0x06000B61 RID: 2913 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0018F7E8 File Offset: 0x0018D9E8
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

		// Token: 0x06000B63 RID: 2915 RVA: 0x0018F87C File Offset: 0x0018DA7C
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0018F8A8 File Offset: 0x0018DAA8
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x0400117B RID: 4475
		private JObject setting;

		// Token: 0x0400117C RID: 4476
		private string id_KichBan;

		// Token: 0x0400117D RID: 4477
		private string id_TuongTac;

		// Token: 0x0400117E RID: 4478
		private string Id_HanhDong;

		// Token: 0x0400117F RID: 4479
		private int type;

		// Token: 0x04001180 RID: 4480
		public static bool isSave;
	}
}
