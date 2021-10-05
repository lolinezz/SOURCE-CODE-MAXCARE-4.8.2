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
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000B5 RID: 181
	public partial class fHDShareBaiv2 : Form
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x000AC694 File Offset: 0x000AA894
		public fHDShareBaiv2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDShareBaiv2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = base.Name.Substring(1);
			string text2 = "Share bài v2";
			bool flag = InteractSQL.GetTuongTac("", text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(string.Concat(new string[]
				{
					"INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('",
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

		// Token: 0x060006C6 RID: 1734 RVA: 0x000AC924 File Offset: 0x000AAB24
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.ckbShareBaiLenTuong);
			Language.GetValue(this.ckbShareBaiLenNhom);
			Language.GetValue(this.label26);
			Language.GetValue(this.label24);
			Language.GetValue(this.label25);
			Language.GetValue(this.ckbOnlyShareNhomKhongKiemDuyet);
			Language.GetValue(this.ckbShareBaiLenPage);
			Language.GetValue(this.label21);
			Language.GetValue(this.label23);
			Language.GetValue(this.label22);
			Language.GetValue(this.label2);
			Language.GetValue(this.ckbVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			Language.GetValue(this.rbNganCachMoiDong);
			Language.GetValue(this.rbNganCachKyTu);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000ACACC File Offset: 0x000AACCC
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbShareBaiLenTuong.Checked = this.setting.GetValueBool("ckbShareBaiLenTuong", false);
				this.ckbShareBaiLenNhom.Checked = this.setting.GetValueBool("ckbShareBaiLenNhom", false);
				this.ckbOnlyShareNhomKhongKiemDuyet.Checked = this.setting.GetValueBool("ckbOnlyShareNhomKhongKiemDuyet", false);
				this.nudCountGroupFrom.Value = this.setting.GetValueInt("nudCountGroupFrom", 1);
				this.nudCountGroupTo.Value = this.setting.GetValueInt("nudCountGroupTo", 1);
				this.ckbShareBaiLenPage.Checked = this.setting.GetValueBool("ckbShareBaiLenPage", false);
				this.nudCountPageFrom.Value = this.setting.GetValueInt("nudCountPageFrom", 1);
				this.nudCountPageTo.Value = this.setting.GetValueInt("nudCountPageTo", 1);
				this.txtLinkChiaSe.Text = this.setting.GetValue("txtLinkChiaSe", "");
				this.ckbKhongPhaiLinkFacebook.Checked = this.setting.GetValueBool("ckbKhongPhaiLinkFacebook", false);
				this.ckbVanBan.Checked = this.setting.GetValueBool("ckbVanBan", false);
				this.txtNoiDung.Text = this.setting.GetValue("txtNoiDung", "");
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

		// Token: 0x060006C8 RID: 1736 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000ACEFC File Offset: 0x000AB0FC
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
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				json_Settings.Update("ckbShareBaiLenTuong", this.ckbShareBaiLenTuong.Checked);
				json_Settings.Update("ckbShareBaiLenNhom", this.ckbShareBaiLenNhom.Checked);
				json_Settings.Update("ckbOnlyShareNhomKhongKiemDuyet", this.ckbOnlyShareNhomKhongKiemDuyet.Checked);
				json_Settings.Update("nudCountGroupFrom", this.nudCountGroupFrom.Value);
				json_Settings.Update("nudCountGroupTo", this.nudCountGroupTo.Value);
				json_Settings.Update("ckbShareBaiLenPage", this.ckbShareBaiLenPage.Checked);
				json_Settings.Update("nudCountPageFrom", this.nudCountPageFrom.Value);
				json_Settings.Update("nudCountPageTo", this.nudCountPageTo.Value);
				json_Settings.Update("txtLinkChiaSe", this.txtLinkChiaSe.Text.Trim());
				json_Settings.Update("ckbKhongPhaiLinkFacebook", this.ckbKhongPhaiLinkFacebook.Checked);
				json_Settings.Update("ckbVanBan", this.ckbVanBan.Checked);
				json_Settings.Update("txtNoiDung", this.txtNoiDung.Text.Trim());
				int num = 0;
				bool @checked = this.rbNganCachKyTu.Checked;
				if (@checked)
				{
					num = 1;
				}
				json_Settings.Update("typeNganCach", num);
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
							fHDShareBaiv2.isSave = true;
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
							fHDShareBaiv2.isSave = true;
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

		// Token: 0x060006CA RID: 1738 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000AD3C8 File Offset: 0x000AB5C8
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

		// Token: 0x060006CC RID: 1740 RVA: 0x000AD48C File Offset: 0x000AB68C
		private void CheckedChangeFull()
		{
			this.rbMfb_CheckedChanged(null, null);
			this.rbWww_CheckedChanged(null, null);
			this.ckbShareBaiLenTuong_CheckedChanged(null, null);
			this.ckbDangBaiLenNhom_CheckedChanged(null, null);
			this.ckbDangBaiLenPage_CheckedChanged(null, null);
			this.ckbVanBan_CheckedChanged(null, null);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000AD4F0 File Offset: 0x000AB6F0
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000AD520 File Offset: 0x000AB720
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000AD53C File Offset: 0x000AB73C
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

		// Token: 0x060006D0 RID: 1744 RVA: 0x000AD638 File Offset: 0x000AB838
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000AD6AC File Offset: 0x000AB8AC
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 216;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000AD6D0 File Offset: 0x000AB8D0
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 169;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000AD6F4 File Offset: 0x000AB8F4
		private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenNhom.Enabled = this.ckbShareBaiLenNhom.Checked;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000AD724 File Offset: 0x000AB924
		private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenPage.Enabled = this.ckbShareBaiLenPage.Checked;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000AD754 File Offset: 0x000AB954
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000AD798 File Offset: 0x000AB998
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000AD520 File Offset: 0x000AB720
		private void rbNganCachMoiDong_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000AD520 File Offset: 0x000AB720
		private void rbNganCachKyTu_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbShareBaiLenTuong_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00054604 File Offset: 0x00052804
		private void rbMfb_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00054604 File Offset: 0x00052804
		private void rbWww_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000AD7C4 File Offset: 0x000AB9C4
		private void txtLinkChiaSe_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtLinkChiaSe.Lines.ToList<string>();
			list = MCommon.Common.RemoveEmptyItems(list);
			this.label2.Text = string.Format("Link bài cần share ({0}):", list.Count);
		}

		// Token: 0x0400073B RID: 1851
		private JSON_Settings setting;

		// Token: 0x0400073C RID: 1852
		private string id_KichBan;

		// Token: 0x0400073D RID: 1853
		private string id_TuongTac;

		// Token: 0x0400073E RID: 1854
		private string Id_HanhDong;

		// Token: 0x0400073F RID: 1855
		private int type;

		// Token: 0x04000740 RID: 1856
		public static bool isSave;
	}
}
