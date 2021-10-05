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
	// Token: 0x020000BE RID: 190
	public partial class fHDHuyKetBanNhanh : Form
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x000CDD2C File Offset: 0x000CBF2C
		public fHDHuyKetBanNhanh(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDHuyKetBanNhanh.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDHuyKetBanNhanh").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDHuyKetBanNhanh', 'Hủy kết bạn nhanh');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDHuyKetBanNhanh");
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

		// Token: 0x06000774 RID: 1908 RVA: 0x000CDF74 File Offset: 0x000CC174
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label8);
			Language.GetValue(this.rbHuyNgauNhien);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.rbHuyTheoUid);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label9);
			Language.GetValue(this.label10);
			Language.GetValue(this.label12);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000CE0A4 File Offset: 0x000CC2A4
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 0);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 0);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 0);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 0);
				bool flag = this.setting.GetValueInt("typeHuyKetBan", 0) == 0;
				if (flag)
				{
					this.rbHuyNgauNhien.Checked = true;
				}
				else
				{
					this.rbHuyTheoUid.Checked = true;
				}
				this.txtUid.Text = this.setting.GetValue("txtUid", "");
				this.txtUidKhongHuyKetBan.Text = this.setting.GetValue("txtUidKhongHuyKetBan", "");
				this.rbHuyNgauNhien_CheckedChanged(null, null);
				this.rbHuyTheoUid_CheckedChanged(null, null);
			}
			catch
			{
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000CE304 File Offset: 0x000CC504
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
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
				json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				bool @checked = this.rbHuyNgauNhien.Checked;
				if (@checked)
				{
					json_Settings.Update("typeHuyKetBan", 0);
				}
				else
				{
					json_Settings.Update("typeHuyKetBan", 1);
				}
				json_Settings.Update("txtUid", this.txtUid.Text);
				json_Settings.Update("txtUidKhongHuyKetBan", this.txtUidKhongHuyKetBan.Text);
				string fullString = json_Settings.GetFullString();
				bool flag2 = this.type == 0;
				if (flag2)
				{
					bool flag3 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
					if (flag3)
					{
						bool flag4 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag4)
						{
							fHDHuyKetBanNhanh.isSave = true;
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
					bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
					if (flag5)
					{
						bool flag6 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
						if (flag6)
						{
							fHDHuyKetBanNhanh.isSave = true;
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

		// Token: 0x06000778 RID: 1912 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000CE660 File Offset: 0x000CC860
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

		// Token: 0x0600077A RID: 1914 RVA: 0x000CE724 File Offset: 0x000CC924
		private void txtUid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách Uid cần hủy kết bạn ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000CE7B8 File Offset: 0x000CC9B8
		private void rbHuyNgauNhien_CheckedChanged(object sender, EventArgs e)
		{
			this.plHuyNgauNhien.Enabled = this.rbHuyNgauNhien.Checked;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000CE7E8 File Offset: 0x000CC9E8
		private void rbHuyTheoUid_CheckedChanged(object sender, EventArgs e)
		{
			this.plHuyTheoUid.Enabled = this.rbHuyTheoUid.Checked;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000CE818 File Offset: 0x000CCA18
		private void txtUidKhongHuyKetBan_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUidKhongHuyKetBan.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label10.Text = string.Format(Language.GetValue("Danh sách UID bạn bè cần giữ lại ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00054604 File Offset: 0x00052804
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00054604 File Offset: 0x00052804
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040008D8 RID: 2264
		private JSON_Settings setting;

		// Token: 0x040008D9 RID: 2265
		private string id_KichBan;

		// Token: 0x040008DA RID: 2266
		private string id_TuongTac;

		// Token: 0x040008DB RID: 2267
		private string Id_HanhDong;

		// Token: 0x040008DC RID: 2268
		private int type;

		// Token: 0x040008DD RID: 2269
		public static bool isSave;
	}
}
