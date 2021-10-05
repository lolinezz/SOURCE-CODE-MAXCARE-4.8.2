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
	// Token: 0x020000C3 RID: 195
	public partial class fHDShareBai : Form
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x000DBE78 File Offset: 0x000DA078
		public fHDShareBai(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDShareBai.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = base.Name.Substring(1);
			string text2 = "Share bài";
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

		// Token: 0x060007AD RID: 1965 RVA: 0x000DC114 File Offset: 0x000DA314
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

		// Token: 0x060007AE RID: 1966 RVA: 0x000DC2BC File Offset: 0x000DA4BC
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbShareBaiLenTuong.Checked = this.setting.GetValueBool("ckbShareBaiLenTuong", false);
				this.ckbShareBaiLenNhom.Checked = this.setting.GetValueBool("ckbShareBaiLenNhom", false);
				this.nudCountGroupFrom.Value = this.setting.GetValueInt("nudCountGroupFrom", 1);
				this.nudCountGroupTo.Value = this.setting.GetValueInt("nudCountGroupTo", 1);
				int valueInt = this.setting.GetValueInt("typeShare", 0);
				bool flag = valueInt == 0;
				if (flag)
				{
					this.rbRandom.Checked = true;
				}
				else
				{
					this.rbTuNhap.Checked = true;
				}
				this.ckbCauHinhNangCao.Checked = this.setting.GetValueBool("ckbCauHinhNangCao", false);
				this.ckbOnlyShareNhomKhongKiemDuyet.Checked = this.setting.GetValueBool("ckbOnlyShareNhomKhongKiemDuyet", false);
				this.ckbUuTienNhomNhieuThanhVien.Checked = this.setting.GetValueBool("ckbUuTienNhomNhieuThanhVien", false);
				this.ckbKhongShareTrung.Checked = this.setting.GetValueBool("ckbKhongShareTrung", false);
				this.ckbTuongTac.Checked = this.setting.GetValueBool("ckbTuongTac", false);
				this.nudTuongTacFrom.Value = this.setting.GetValueInt("nudTuongTacFrom", 3);
				this.nudTuongTacTo.Value = this.setting.GetValueInt("nudTuongTacTo", 5);
				this.nudTuongTacDelayFrom.Value = this.setting.GetValueInt("nudTuongTacDelayFrom", 5);
				this.nudTuongTacDelayTo.Value = this.setting.GetValueInt("nudTuongTacDelayTo", 7);
				this.ckbTuongTacLike.Checked = this.setting.GetValueBool("ckbTuongTacLike", false);
				this.ckbTuongTacComment.Checked = this.setting.GetValueBool("ckbTuongTacComment", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.ckbShareBaiLenPage.Checked = this.setting.GetValueBool("ckbShareBaiLenPage", false);
				this.nudCountPageFrom.Value = this.setting.GetValueInt("nudCountPageFrom", 1);
				this.nudCountPageTo.Value = this.setting.GetValueInt("nudCountPageTo", 1);
				this.txtLinkChiaSe.Text = this.setting.GetValue("txtLinkChiaSe", "");
				this.rbShareThuong.Checked = this.setting.GetValueBool("rbShareThuong", true);
				this.rbShareVip.Checked = this.setting.GetValueBool("rbShareVip", false);
				this.ckbKhongPhaiLinkFacebook.Checked = this.setting.GetValueBool("ckbKhongPhaiLinkFacebook", false);
				this.ckbVanBan.Checked = this.setting.GetValueBool("ckbVanBan", false);
				this.txtNoiDung.Text = this.setting.GetValue("txtNoiDung", "");
				bool flag2 = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag2)
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

		// Token: 0x060007AF RID: 1967 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000DCA7C File Offset: 0x000DAC7C
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
				json_Settings.Update("nudCountGroupFrom", this.nudCountGroupFrom.Value);
				json_Settings.Update("nudCountGroupTo", this.nudCountGroupTo.Value);
				int num = 0;
				bool @checked = this.rbTuNhap.Checked;
				if (@checked)
				{
					num = 1;
				}
				json_Settings.Update("typeShare", num);
				json_Settings.Update("lstNhomTuNhap", this.lstNhomTuNhap);
				json_Settings.Update("ckbCauHinhNangCao", this.ckbCauHinhNangCao.Checked);
				json_Settings.Update("ckbOnlyShareNhomKhongKiemDuyet", this.ckbOnlyShareNhomKhongKiemDuyet.Checked);
				json_Settings.Update("ckbUuTienNhomNhieuThanhVien", this.ckbUuTienNhomNhieuThanhVien.Checked);
				json_Settings.Update("ckbKhongShareTrung", this.ckbKhongShareTrung.Checked);
				json_Settings.Update("ckbTuongTac", this.ckbTuongTac.Checked);
				json_Settings.Update("nudTuongTacFrom", this.nudTuongTacFrom.Value);
				json_Settings.Update("nudTuongTacTo", this.nudTuongTacFrom.Value);
				json_Settings.Update("nudTuongTacDelayFrom", this.nudTuongTacDelayFrom.Value);
				json_Settings.Update("nudTuongTacDelayTo", this.nudTuongTacDelayTo.Value);
				json_Settings.Update("ckbTuongTacLike", this.ckbTuongTacLike.Checked);
				json_Settings.Update("ckbTuongTacComment", this.ckbTuongTacComment.Checked);
				json_Settings.Update("txtComment", this.txtComment.Text);
				json_Settings.Update("ckbShareBaiLenPage", this.ckbShareBaiLenPage.Checked);
				json_Settings.Update("nudCountPageFrom", this.nudCountPageFrom.Value);
				json_Settings.Update("nudCountPageTo", this.nudCountPageTo.Value);
				json_Settings.Update("txtLinkChiaSe", this.txtLinkChiaSe.Text.Trim());
				json_Settings.Update("rbShareThuong", this.rbShareThuong.Checked);
				json_Settings.Update("rbShareVip", this.rbShareVip.Checked);
				json_Settings.Update("ckbKhongPhaiLinkFacebook", this.ckbKhongPhaiLinkFacebook.Checked);
				json_Settings.Update("ckbVanBan", this.ckbVanBan.Checked);
				json_Settings.Update("txtNoiDung", this.txtNoiDung.Text.Trim());
				int num2 = 0;
				bool checked2 = this.rbNganCachKyTu.Checked;
				if (checked2)
				{
					num2 = 1;
				}
				json_Settings.Update("typeNganCach", num2);
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
							fHDShareBai.isSave = true;
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
							fHDShareBai.isSave = true;
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

		// Token: 0x060007B1 RID: 1969 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000DD234 File Offset: 0x000DB434
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

		// Token: 0x060007B3 RID: 1971 RVA: 0x000DD2F8 File Offset: 0x000DB4F8
		private void CheckedChangeFull()
		{
			this.rbMfb_CheckedChanged(null, null);
			this.rbWww_CheckedChanged(null, null);
			this.ckbShareBaiLenTuong_CheckedChanged(null, null);
			this.ckbDangBaiLenNhom_CheckedChanged(null, null);
			this.ckbDangBaiLenPage_CheckedChanged(null, null);
			this.ckbVanBan_CheckedChanged(null, null);
			this.rbShareThuong_CheckedChanged(null, null);
			this.rbShareVip_CheckedChanged(null, null);
			this.ckbTuongTac_CheckedChanged(null, null);
			this.ckbTuongTacComment_CheckedChanged(null, null);
			this.rbTuNhap_CheckedChanged(null, null);
			this.ckbCauHinhNangCao_CheckedChanged(null, null);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000DD3B0 File Offset: 0x000DB5B0
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000DD3E0 File Offset: 0x000DB5E0
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000DD3FC File Offset: 0x000DB5FC
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

		// Token: 0x060007B7 RID: 1975 RVA: 0x000DD4F8 File Offset: 0x000DB6F8
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000DD56C File Offset: 0x000DB76C
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 216;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000DD590 File Offset: 0x000DB790
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 169;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000DD5B4 File Offset: 0x000DB7B4
		private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenNhom.Enabled = this.ckbShareBaiLenNhom.Checked;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000DD5E4 File Offset: 0x000DB7E4
		private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenPage.Enabled = this.ckbShareBaiLenPage.Checked;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000DD614 File Offset: 0x000DB814
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000DD658 File Offset: 0x000DB858
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000DD3E0 File Offset: 0x000DB5E0
		private void rbNganCachMoiDong_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000DD3E0 File Offset: 0x000DB5E0
		private void rbNganCachKyTu_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbShareBaiLenTuong_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00054604 File Offset: 0x00052804
		private void rbMfb_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00054604 File Offset: 0x00052804
		private void rbWww_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x000DD684 File Offset: 0x000DB884
		private void txtLinkChiaSe_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtLinkChiaSe.Lines.ToList<string>();
			list = MCommon.Common.RemoveEmptyItems(list);
			this.label2.Text = string.Format("Link bài cần share ({0}):", list.Count);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000DD6E8 File Offset: 0x000DB8E8
		private void rbShareVip_CheckedChanged(object sender, EventArgs e)
		{
			this.ckbKhongPhaiLinkFacebook.Enabled = !this.rbShareVip.Checked;
			bool @checked = this.rbShareVip.Checked;
			if (@checked)
			{
				this.ckbKhongPhaiLinkFacebook.Checked = false;
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbKhongPhaiLinkFacebook_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00054604 File Offset: 0x00052804
		private void rbShareThuong_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000DD74C File Offset: 0x000DB94C
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plInteractGroup.Enabled = this.ckbTuongTac.Checked;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00054604 File Offset: 0x00052804
		private void btnComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000DD77C File Offset: 0x000DB97C
		private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbTuongTacComment.Checked;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000DD7AC File Offset: 0x000DB9AC
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			list = this.txtComment.Lines.ToList<string>();
			list = MCommon.Common.RemoveEmptyItems(list);
			this.lblComment.Text = string.Format(Language.GetValue("Danh sách comment ({0}):"), list.Count.ToString());
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000DD81C File Offset: 0x000DBA1C
		private void button6_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"), 1);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000DD81C File Offset: 0x000DBA1C
		private void button7_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"), 1);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000DD850 File Offset: 0x000DBA50
		private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.button8.Enabled = this.rbTuNhap.Checked;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000DD880 File Offset: 0x000DBA80
		private void ckbCauHinhNangCao_CheckedChanged(object sender, EventArgs e)
		{
			this.panel4.Enabled = this.ckbCauHinhNangCao.Checked;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000DD8B0 File Offset: 0x000DBAB0
		private void button8_Click(object sender, EventArgs e)
		{
			string text = Guid.NewGuid().ToString() + ".txt";
			MCommon.Common.ShowForm(new fNhapDuLieu1(text, "Nhập danh sách ID nhóm", "Danh sách ID nhóm", "(Mỗi nội dung 1 dòng)", this.lstNhomTuNhap));
			this.lstNhomTuNhap = File.ReadAllLines(text).ToList<string>();
			try
			{
				File.Delete(text);
			}
			catch
			{
			}
		}

		// Token: 0x04000993 RID: 2451
		private JSON_Settings setting;

		// Token: 0x04000994 RID: 2452
		private string id_KichBan;

		// Token: 0x04000995 RID: 2453
		private string id_TuongTac;

		// Token: 0x04000996 RID: 2454
		private string Id_HanhDong;

		// Token: 0x04000997 RID: 2455
		private int type;

		// Token: 0x04000998 RID: 2456
		public static bool isSave;

		// Token: 0x04000999 RID: 2457
		private List<string> lstNhomTuNhap = new List<string>();
	}
}
