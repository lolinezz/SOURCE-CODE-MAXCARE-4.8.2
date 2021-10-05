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
	// Token: 0x020000C7 RID: 199
	public partial class fHDThamGiaNhomUidv2 : Form
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x000EE4D0 File Offset: 0x000EC6D0
		public fHDThamGiaNhomUidv2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDThamGiaNhomUidv2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDThamGiaNhomUidv2").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomUidv2', 'Tham gia nhóm theo tệp UID v2');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDThamGiaNhomUidv2");
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

		// Token: 0x06000808 RID: 2056 RVA: 0x000EE6F0 File Offset: 0x000EC8F0
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
			Language.GetValue(this.ckbTuDongTraLoiCauHoi);
			Language.GetValue(this.lblStatusComment);
			Language.GetValue(this.label9);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbTuDongXoaUid);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000EE810 File Offset: 0x000ECA10
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 2);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbTuDongXoaUid.Checked = this.setting.GetValueBool("ckbThamGiaNhomTrungNhau", false);
				this.txtUid.Text = this.setting.GetValue("txtUid", "");
				this.ckbTuDongTraLoiCauHoi.Checked = this.setting.GetValueBool("ckbTuDongTraLoiCauHoi", false);
				this.ckbTuDongXoaUid.Checked = this.setting.GetValueBool("ckbTuDongXoaUid", false);
				this.txtCauTraLoi.Text = this.setting.GetValue("txtCauTraLoi", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000EEAA8 File Offset: 0x000ECCA8
		private void CheckedChangeFull()
		{
			this.ckbTuongTac_CheckedChanged(null, null);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000EEAC4 File Offset: 0x000ECCC4
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
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách uid nhóm!"), 3);
				}
				else
				{
					bool @checked = this.ckbTuDongTraLoiCauHoi.Checked;
					if (@checked)
					{
						list = this.txtCauTraLoi.Lines.ToList<string>();
						list = MCommon.Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách câu trả lời!"), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("ckbThamGiaNhomTrungNhau", this.ckbTuDongXoaUid.Checked);
					json_Settings.Update("txtUid", this.txtUid.Text.Trim());
					json_Settings.Update("ckbTuDongTraLoiCauHoi", this.ckbTuDongTraLoiCauHoi.Checked);
					json_Settings.Update("ckbTuDongXoaUid", this.ckbTuDongXoaUid.Checked);
					json_Settings.Update("txtCauTraLoi", this.txtCauTraLoi.Text.Trim());
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
								fHDThamGiaNhomUidv2.isSave = true;
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
								fHDThamGiaNhomUidv2.isSave = true;
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

		// Token: 0x0600080D RID: 2061 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000EEF2C File Offset: 0x000ED12C
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

		// Token: 0x0600080F RID: 2063 RVA: 0x000EEFF0 File Offset: 0x000ED1F0
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách Uid nhóm cần tham gia ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000EF084 File Offset: 0x000ED284
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtCauTraLoi.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusComment.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000EF118 File Offset: 0x000ED318
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTac.Enabled = this.ckbTuDongTraLoiCauHoi.Checked;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00054604 File Offset: 0x00052804
		private void label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00054604 File Offset: 0x00052804
		private void lblStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000A79 RID: 2681
		private JSON_Settings setting;

		// Token: 0x04000A7A RID: 2682
		private string id_KichBan;

		// Token: 0x04000A7B RID: 2683
		private string id_TuongTac;

		// Token: 0x04000A7C RID: 2684
		private string Id_HanhDong;

		// Token: 0x04000A7D RID: 2685
		private int type;

		// Token: 0x04000A7E RID: 2686
		public static bool isSave;
	}
}
