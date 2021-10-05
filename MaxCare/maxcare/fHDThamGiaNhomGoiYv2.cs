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
	// Token: 0x020000B6 RID: 182
	public partial class fHDThamGiaNhomGoiYv2 : Form
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x000B10BC File Offset: 0x000AF2BC
		public fHDThamGiaNhomGoiYv2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDThamGiaNhomGoiYv2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDThamGiaNhomGoiYv2").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomGoiYv2', 'Tham gia nhóm gợi ý v2');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDThamGiaNhomGoiYv2");
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

		// Token: 0x060006E0 RID: 1760 RVA: 0x000B1304 File Offset: 0x000AF504
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
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000B13F0 File Offset: 0x000AF5F0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 3);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 5);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbTuDongTraLoiCauHoi.Checked = this.setting.GetValueBool("ckbTuDongTraLoiCauHoi", false);
				this.txtCauTraLoi.Text = this.setting.GetValue("txtCauTraLoi", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000B15C8 File Offset: 0x000AF7C8
		private void CheckedChangeFull()
		{
			this.ckbTuongTac_CheckedChanged(null, null);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000B15E4 File Offset: 0x000AF7E4
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
				bool @checked = this.ckbTuDongTraLoiCauHoi.Checked;
				if (@checked)
				{
					List<string> list = this.txtCauTraLoi.Lines.ToList<string>();
					list = MCommon.Common.RemoveEmptyItems(list);
					bool flag2 = list.Count == 0;
					if (flag2)
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
				json_Settings.Update("ckbTuDongTraLoiCauHoi", this.ckbTuDongTraLoiCauHoi.Checked);
				json_Settings.Update("txtCauTraLoi", this.txtCauTraLoi.Text.Trim());
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
							fHDThamGiaNhomGoiYv2.isSave = true;
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
							fHDThamGiaNhomGoiYv2.isSave = true;
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

		// Token: 0x060006E5 RID: 1765 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000B195C File Offset: 0x000AFB5C
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

		// Token: 0x060006E7 RID: 1767 RVA: 0x000B1A20 File Offset: 0x000AFC20
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

		// Token: 0x060006E8 RID: 1768 RVA: 0x000B1AB4 File Offset: 0x000AFCB4
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTac.Enabled = this.ckbTuDongTraLoiCauHoi.Checked;
		}

		// Token: 0x04000774 RID: 1908
		private JSON_Settings setting;

		// Token: 0x04000775 RID: 1909
		private string id_KichBan;

		// Token: 0x04000776 RID: 1910
		private string id_TuongTac;

		// Token: 0x04000777 RID: 1911
		private string Id_HanhDong;

		// Token: 0x04000778 RID: 1912
		private int type;

		// Token: 0x04000779 RID: 1913
		public static bool isSave;
	}
}
