using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
	// Token: 0x020000BC RID: 188
	public partial class fHDDangStatusV2 : Form
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x000C7B68 File Offset: 0x000C5D68
		public fHDDangStatusV2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDDangStatusV2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = "HDDangStatusV2";
			string text2 = "Đăng status v2";
			bool flag = InteractSQL.GetTuongTac("", text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(string.Concat(new string[]
				{
					"INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('",
					text,
					"', '",
					text2,
					"');"
				}));
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", text);
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

		// Token: 0x06000752 RID: 1874 RVA: 0x000C7E00 File Offset: 0x000C6000
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label17);
			Language.GetValue(this.label18);
			Language.GetValue(this.label16);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.ckbVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbAnh);
			Language.GetValue(this.label3);
			Language.GetValue(this.label21);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000C7F40 File Offset: 0x000C6140
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 1);
				this.nudKhoangCachFrom.Value = this.setting.GetValueInt("nudKhoangCachFrom", 5);
				this.nudKhoangCachTo.Value = this.setting.GetValueInt("nudKhoangCachTo", 10);
				this.ckbVanBan.Checked = this.setting.GetValueBool("ckbVanBan", false);
				this.txtNoiDung.Text = this.setting.GetValue("txtNoiDung", "");
				this.ckbAnh.Checked = this.setting.GetValueBool("ckbAnh", false);
				this.ckbDangAnhTheoThuTu.Checked = this.setting.GetValueBool("ckbDangAnhTheoThuTu", false);
				this.nudSoLuongAnhFrom.Value = this.setting.GetValueInt("nudSoLuongAnhFrom", 1);
				this.nudSoLuongAnhTo.Value = this.setting.GetValueInt("nudSoLuongAnhTo", 1);
				this.txtPathAnh.Text = this.setting.GetValue("txtPathAnh", "");
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
			catch (Exception ex)
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000C82C0 File Offset: 0x000C64C0
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
				bool flag2 = !Directory.Exists(this.txtPathAnh.Text.Trim()) && this.ckbAnh.Checked;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Đường dẫn ảnh không tồn tại!"), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudKhoangCachFrom", this.nudKhoangCachFrom.Value);
					json_Settings.Update("nudKhoangCachTo", this.nudKhoangCachTo.Value);
					json_Settings.Update("ckbVanBan", this.ckbVanBan.Checked);
					json_Settings.Update("ckbAnh", this.ckbAnh.Checked);
					json_Settings.Update("ckbDangAnhTheoThuTu", this.ckbDangAnhTheoThuTu.Checked);
					json_Settings.Update("nudSoLuongAnhFrom", this.nudSoLuongAnhFrom.Value);
					json_Settings.Update("nudSoLuongAnhTo", this.nudSoLuongAnhTo.Value);
					json_Settings.Update("txtNoiDung", this.txtNoiDung.Text.Trim());
					json_Settings.Update("txtPathAnh", this.txtPathAnh.Text.Trim());
					int num = 0;
					bool @checked = this.rbNganCachKyTu.Checked;
					if (@checked)
					{
						num = 1;
					}
					json_Settings.Update("typeNganCach", num);
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
								fHDDangStatusV2.isSave = true;
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
								fHDDangStatusV2.isSave = true;
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

		// Token: 0x06000756 RID: 1878 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000C8768 File Offset: 0x000C6968
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

		// Token: 0x06000758 RID: 1880 RVA: 0x000C882C File Offset: 0x000C6A2C
		private void CheckedChangeFull()
		{
			this.ckbVanBan_CheckedChanged(null, null);
			this.ckbAnh_CheckedChanged(null, null);
			this.rbUidTuNhap_CheckedChanged(null, null);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000C8864 File Offset: 0x000C6A64
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000C8894 File Offset: 0x000C6A94
		private void ckbAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbAnh.Checked;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000C88C4 File Offset: 0x000C6AC4
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000C88E0 File Offset: 0x000C6AE0
		private void UpdateSoLuongBinhLuan()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtNoiDung.Lines.ToList<string>();
				}
				else
				{
					list = this.txtNoiDung.Text.Split(new string[]
					{
						"\n|\n"
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách nội dung ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000C89DC File Offset: 0x000C6BDC
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000C8A50 File Offset: 0x000C6C50
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 235;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000C8A74 File Offset: 0x000C6C74
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 187;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000C88C4 File Offset: 0x000C6AC4
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000C88C4 File Offset: 0x000C6AC4
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00054604 File Offset: 0x00052804
		private void rbUidTuNhap_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00054604 File Offset: 0x00052804
		private void txtPathAnh_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00054604 File Offset: 0x00052804
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000C8A98 File Offset: 0x000C6C98
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000C8ADC File Offset: 0x000C6CDC
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x04000888 RID: 2184
		private JSON_Settings setting;

		// Token: 0x04000889 RID: 2185
		private string id_KichBan;

		// Token: 0x0400088A RID: 2186
		private string id_TuongTac;

		// Token: 0x0400088B RID: 2187
		private string Id_HanhDong;

		// Token: 0x0400088C RID: 2188
		private int type;

		// Token: 0x0400088D RID: 2189
		public static bool isSave;
	}
}
