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
	// Token: 0x020000B3 RID: 179
	public partial class fHDKetBanTheoTuKhoav2 : Form
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x000A773C File Offset: 0x000A593C
		public fHDKetBanTheoTuKhoav2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDKetBanTheoTuKhoav2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDKetBanTheoTuKhoav2").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanTheoTuKhoav2', 'Kết bạn theo từ khóa v2');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDKetBanTheoTuKhoav2");
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

		// Token: 0x060006AF RID: 1711 RVA: 0x000A7984 File Offset: 0x000A5B84
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
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000A7A60 File Offset: 0x000A5C60
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 3);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 2);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 4);
				this.txtTuKhoa.Text = this.setting.GetValue("txtTuKhoa", "");
			}
			catch
			{
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000A7BF0 File Offset: 0x000A5DF0
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
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập từ khóa!"), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("txtTuKhoa", this.txtTuKhoa.Text.Trim());
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
								fHDKetBanTheoTuKhoav2.isSave = true;
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
								fHDKetBanTheoTuKhoav2.isSave = true;
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

		// Token: 0x060006B3 RID: 1715 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000A7F1C File Offset: 0x000A611C
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

		// Token: 0x060006B5 RID: 1717 RVA: 0x000A7FE0 File Offset: 0x000A61E0
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

		// Token: 0x040006F8 RID: 1784
		private JSON_Settings setting;

		// Token: 0x040006F9 RID: 1785
		private string id_KichBan;

		// Token: 0x040006FA RID: 1786
		private string id_TuongTac;

		// Token: 0x040006FB RID: 1787
		private string Id_HanhDong;

		// Token: 0x040006FC RID: 1788
		private int type;

		// Token: 0x040006FD RID: 1789
		public static bool isSave;
	}
}
