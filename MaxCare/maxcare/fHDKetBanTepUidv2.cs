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
	// Token: 0x020000C0 RID: 192
	public partial class fHDKetBanTepUidv2 : Form
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x000D3284 File Offset: 0x000D1484
		public fHDKetBanTepUidv2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDKetBanTepUidv2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDKetBanTepUidv2").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanTepUidv2', 'Kết bạn theo tệp Uid v2');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDKetBanTepUidv2");
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

		// Token: 0x0600078C RID: 1932 RVA: 0x000D34CC File Offset: 0x000D16CC
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
			Language.GetValue(this.label9);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000D3664 File Offset: 0x000D1864
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 2);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbTuDongXoaUid.Checked = this.setting.GetValueBool("ckbKetBanTrungNhau", false);
				this.txtUid.Text = this.setting.GetValue("txtUid", "");
				this.ckbTuongTac.Checked = this.setting.GetValueBool("ckbTuongTac", false);
				this.nudSoLuongBaiVietFrom.Value = this.setting.GetValueInt("nudSoLuongBaiVietFrom", 1);
				this.nudSoLuongBaiVietTo.Value = this.setting.GetValueInt("nudSoLuongBaiVietTo", 3);
				this.nudTuongTacDelayFrom.Value = this.setting.GetValueInt("nudTuongTacDelayFrom", 3);
				this.nudTuongTacDelayTo.Value = this.setting.GetValueInt("nudTuongTacDelayTo", 5);
				this.ckbTuongTacLike.Checked = this.setting.GetValueBool("ckbTuongTacLike", false);
				this.ckbTuongTacComment.Checked = this.setting.GetValueBool("ckbTuongTacComment", false);
				this.ckbTuDongXoaUid.Checked = this.setting.GetValueBool("ckbTuDongXoaUid", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000D3A70 File Offset: 0x000D1C70
		private void CheckedChangeFull()
		{
			this.ckbTuongTac_CheckedChanged(null, null);
			this.ckbTuongTacComment_CheckedChanged(null, null);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000D3A9C File Offset: 0x000D1C9C
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
								fHDKetBanTepUidv2.isSave = true;
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
								fHDKetBanTepUidv2.isSave = true;
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

		// Token: 0x06000791 RID: 1937 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000D4048 File Offset: 0x000D2248
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

		// Token: 0x06000793 RID: 1939 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000D410C File Offset: 0x000D230C
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

		// Token: 0x06000795 RID: 1941 RVA: 0x000D41A0 File Offset: 0x000D23A0
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

		// Token: 0x06000796 RID: 1942 RVA: 0x000D4234 File Offset: 0x000D2434
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTac.Enabled = this.ckbTuongTac.Checked;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000D4264 File Offset: 0x000D2464
		private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacComment.Enabled = this.ckbTuongTacComment.Checked;
		}

		// Token: 0x04000920 RID: 2336
		private JSON_Settings setting;

		// Token: 0x04000921 RID: 2337
		private string id_KichBan;

		// Token: 0x04000922 RID: 2338
		private string id_TuongTac;

		// Token: 0x04000923 RID: 2339
		private string Id_HanhDong;

		// Token: 0x04000924 RID: 2340
		private int type;

		// Token: 0x04000925 RID: 2341
		public static bool isSave;
	}
}
