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
	// Token: 0x020000B7 RID: 183
	public partial class fHDThamGiaNhomTuKhoav2 : Form
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x000B3AD8 File Offset: 0x000B1CD8
		public fHDThamGiaNhomTuKhoav2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDThamGiaNhomTuKhoav2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDThamGiaNhomTuKhoav2").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomTuKhoav2', 'Tham gia nhóm theo từ khóa v2');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDThamGiaNhomTuKhoav2");
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

		// Token: 0x060006EC RID: 1772 RVA: 0x000B3D20 File Offset: 0x000B1F20
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
			Language.GetValue(this.ckbTuDongTraLoiCauHoi);
			Language.GetValue(this.lblStatusComment);
			Language.GetValue(this.label9);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000B3E30 File Offset: 0x000B2030
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 3);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 2);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 4);
				this.txtTuKhoa.Text = this.setting.GetValue("txtTuKhoa", "");
				this.ckbTuDongTraLoiCauHoi.Checked = this.setting.GetValueBool("ckbTuDongTraLoiCauHoi", false);
				this.txtCauTraLoi.Text = this.setting.GetValue("txtCauTraLoi", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000B4050 File Offset: 0x000B2250
		private void CheckedChangeFull()
		{
			this.ckbTuongTac_CheckedChanged(null, null);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000B406C File Offset: 0x000B226C
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
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách từ khóa!"), 3);
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
					json_Settings.Update("txtTuKhoa", this.txtTuKhoa.Text.Trim());
					json_Settings.Update("ckbTuDongTraLoiCauHoi", this.ckbTuDongTraLoiCauHoi.Checked);
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
								fHDThamGiaNhomTuKhoav2.isSave = true;
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
								fHDThamGiaNhomTuKhoav2.isSave = true;
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

		// Token: 0x060006F1 RID: 1777 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000B4474 File Offset: 0x000B2674
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

		// Token: 0x060006F3 RID: 1779 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000B4538 File Offset: 0x000B2738
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách từ khóa ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000B45CC File Offset: 0x000B27CC
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

		// Token: 0x060006F6 RID: 1782 RVA: 0x000B4660 File Offset: 0x000B2860
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTac.Enabled = this.ckbTuDongTraLoiCauHoi.Checked;
		}

		// Token: 0x04000797 RID: 1943
		private JSON_Settings setting;

		// Token: 0x04000798 RID: 1944
		private string id_KichBan;

		// Token: 0x04000799 RID: 1945
		private string id_TuongTac;

		// Token: 0x0400079A RID: 1946
		private string Id_HanhDong;

		// Token: 0x0400079B RID: 1947
		private int type;

		// Token: 0x0400079C RID: 1948
		public static bool isSave;
	}
}
