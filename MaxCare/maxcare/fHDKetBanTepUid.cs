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
	// Token: 0x02000113 RID: 275
	public partial class fHDKetBanTepUid : Form
	{
		// Token: 0x06000BEE RID: 3054 RVA: 0x001ADA4C File Offset: 0x001ABC4C
		public fHDKetBanTepUid(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDKetBanTepUid.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDKetBanTepUid");
				json = tuongTac.Rows[0]["CauHinh"].ToString();
				this.id_TuongTac = tuongTac.Rows[0]["Id_TuongTac"].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0]["MoTa"].ToString());
			}
			else
			{
				bool flag2 = type == 1;
				if (flag2)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					json = hanhDongById.Rows[0]["CauHinh"].ToString();
					this.btnAdd.Text = Language.GetValue("Cập nhật");
					this.txtTenHanhDong.Text = hanhDongById.Rows[0]["TenHanhDong"].ToString();
				}
			}
			this.setting = JObject.Parse(json);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x001ADC30 File Offset: 0x001ABE30
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
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbTuDongXoaUid);
			Language.GetValue(this.ckbTuongTac);
			Language.GetValue(this.label19);
			Language.GetValue(this.label67);
			Language.GetValue(this.label54);
			Language.GetValue(this.label46);
			Language.GetValue(this.label48);
			Language.GetValue(this.label47);
			Language.GetValue(this.ckbTuongTacComment);
			Language.GetValue(this.lblStatusComment);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x001ADDB4 File Offset: 0x001ABFB4
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.ckbTuDongXoaUid.Checked = Convert.ToBoolean(this.setting["ckbKetBanTrungNhau"]);
				this.txtUid.Text = this.setting["txtUid"].ToString();
				this.ckbTuongTac.Checked = Convert.ToBoolean(this.setting["ckbTuongTac"]);
				this.nudSoLuongBaiVietFrom.Value = Convert.ToInt32(this.setting["nudSoLuongBaiVietFrom"]);
				this.nudSoLuongBaiVietTo.Value = Convert.ToInt32(this.setting["nudSoLuongBaiVietTo"]);
				this.nudTuongTacDelayFrom.Value = Convert.ToInt32(this.setting["nudTuongTacDelayFrom"]);
				this.nudTuongTacDelayTo.Value = Convert.ToInt32(this.setting["nudTuongTacDelayTo"]);
				this.ckbTuongTacLike.Checked = Convert.ToBoolean(this.setting["ckbTuongTacLike"]);
				this.ckbTuongTacComment.Checked = Convert.ToBoolean(this.setting["ckbTuongTacComment"]);
				this.ckbTuDongXoaUid.Checked = Convert.ToBoolean(this.setting["ckbTuDongXoaUid"]);
				this.txtComment.Text = this.setting["txtComment"].ToString();
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x001AE1A0 File Offset: 0x001AC3A0
		private void CheckedChangeFull()
		{
			this.ckbTuongTac_CheckedChanged(null, null);
			this.ckbTuongTacComment_CheckedChanged(null, null);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x001AE1CC File Offset: 0x001AC3CC
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
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách uid cần kết bạn!"), 3);
				}
				else
				{
					bool flag3 = this.ckbTuongTac.Checked && this.ckbTuongTacComment.Checked;
					if (flag3)
					{
						list = this.txtComment.Lines.ToList<string>();
						list = MCommon.Common.RemoveEmptyItems(list);
						bool flag4 = list.Count == 0;
						if (flag4)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("ckbKetBanTrungNhau", this.ckbTuDongXoaUid.Checked);
					json_Settings.Update("txtUid", this.txtUid.Text.Trim());
					json_Settings.Update("ckbTuongTac", this.ckbTuongTac.Checked);
					json_Settings.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
					json_Settings.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
					json_Settings.Update("nudTuongTacDelayFrom", this.nudTuongTacDelayFrom.Value);
					json_Settings.Update("nudTuongTacDelayTo", this.nudTuongTacDelayTo.Value);
					json_Settings.Update("ckbTuongTacLike", this.ckbTuongTacLike.Checked);
					json_Settings.Update("ckbTuongTacComment", this.ckbTuongTacComment.Checked);
					json_Settings.Update("txtComment", this.txtComment.Text.Trim());
					json_Settings.Update("ckbTuDongXoaUid", this.ckbTuDongXoaUid.Checked);
					string fullString = json_Settings.GetFullString();
					bool flag5 = this.type == 0;
					if (flag5)
					{
						bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
						if (flag6)
						{
							bool flag7 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
							if (flag7)
							{
								fHDKetBanTepUid.isSave = true;
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
						bool flag8 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
						if (flag8)
						{
							bool flag9 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
							if (flag9)
							{
								fHDKetBanTepUid.isSave = true;
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

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x001AE778 File Offset: 0x001AC978
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

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x001AE83C File Offset: 0x001ACA3C
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách Uid cần kết bạn ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x001AE8D0 File Offset: 0x001ACAD0
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusComment.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x001AE964 File Offset: 0x001ACB64
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTac.Enabled = this.ckbTuongTac.Checked;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x001AE994 File Offset: 0x001ACB94
		private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacComment.Enabled = this.ckbTuongTacComment.Checked;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x04001307 RID: 4871
		private JObject setting;

		// Token: 0x04001308 RID: 4872
		private string id_KichBan;

		// Token: 0x04001309 RID: 4873
		private string id_TuongTac;

		// Token: 0x0400130A RID: 4874
		private string Id_HanhDong;

		// Token: 0x0400130B RID: 4875
		private int type;

		// Token: 0x0400130C RID: 4876
		public static bool isSave;
	}
}
