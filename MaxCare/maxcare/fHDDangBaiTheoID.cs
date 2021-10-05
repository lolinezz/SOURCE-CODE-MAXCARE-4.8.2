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
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000AF RID: 175
	public partial class fHDDangBaiTheoID : Form
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x0009D17C File Offset: 0x0009B37C
		public fHDDangBaiTheoID(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDDangBaiTheoID.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = base.Name.Substring(1);
			bool flag = InteractSQL.GetTuongTac("", text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', 'Đăng bài clone ID');");
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

		// Token: 0x06000682 RID: 1666 RVA: 0x0009D3D4 File Offset: 0x0009B5D4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.ckbDangBaiLenTuong);
			Language.GetValue(this.ckbDangBaiLenNhom);
			Language.GetValue(this.label26);
			Language.GetValue(this.label24);
			Language.GetValue(this.label25);
			Language.GetValue(this.ckbOnlyDangNhomKhongKiemDuyet);
			Language.GetValue(this.ckbDangBaiLenPage);
			Language.GetValue(this.label21);
			Language.GetValue(this.label23);
			Language.GetValue(this.label22);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0009D514 File Offset: 0x0009B714
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.ckbDangBaiLenTuong.Checked = this.setting.GetValueBool("ckbDangBaiLenTuong", false);
				this.ckbDangBaiLenNhom.Checked = this.setting.GetValueBool("ckbDangBaiLenNhom", false);
				int valueInt = this.setting.GetValueInt("typePost", 0);
				bool flag = valueInt == 0;
				if (flag)
				{
					this.rbNgauNhienNhomThamGia.Checked = true;
				}
				else
				{
					this.rbNhomTuNhap.Checked = true;
				}
				this.ckbOnlyDangNhomKhongKiemDuyet.Checked = this.setting.GetValueBool("ckbOnlyDangNhomKhongKiemDuyet", false);
				this.nudCountGroupFrom.Value = this.setting.GetValueInt("nudCountGroupFrom", 1);
				this.nudCountGroupTo.Value = this.setting.GetValueInt("nudCountGroupTo", 1);
				this.ckbDangBaiLenPage.Checked = this.setting.GetValueBool("ckbDangBaiLenPage", false);
				this.nudCountPageFrom.Value = this.setting.GetValueInt("nudCountPageFrom", 1);
				this.nudCountPageTo.Value = this.setting.GetValueInt("nudCountPageTo", 1);
				this.txtIdPost.Text = this.setting.GetValue("txtIdPost", "");
				this.ckbDelete.Checked = this.setting.GetValueBool("ckbDelete", false);
			}
			catch (Exception ex)
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
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
				bool flag2 = this.txtIdPost.Text == "";
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập id post cần clone!"), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("ckbDangBaiLenTuong", this.ckbDangBaiLenTuong.Checked);
					json_Settings.Update("ckbDangBaiLenNhom", this.ckbDangBaiLenNhom.Checked);
					int num = 0;
					bool @checked = this.rbNhomTuNhap.Checked;
					if (@checked)
					{
						num = 1;
					}
					json_Settings.Update("typePost", num);
					json_Settings.Update("lstNhomTuNhap", this.lstNhomTuNhap);
					json_Settings.Update("ckbOnlyDangNhomKhongKiemDuyet", this.ckbOnlyDangNhomKhongKiemDuyet.Checked);
					json_Settings.Update("nudCountGroupFrom", this.nudCountGroupFrom.Value);
					json_Settings.Update("nudCountGroupTo", this.nudCountGroupTo.Value);
					json_Settings.Update("ckbDangBaiLenPage", this.ckbDangBaiLenPage.Checked);
					json_Settings.Update("nudCountPageFrom", this.nudCountPageFrom.Value);
					json_Settings.Update("nudCountPageTo", this.nudCountPageTo.Value);
					json_Settings.Update("txtIdPost", this.txtIdPost.Text.Trim());
					json_Settings.Update("ckbDelete", this.ckbDelete.Checked);
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
								fHDDangBaiTheoID.isSave = true;
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
								fHDDangBaiTheoID.isSave = true;
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

		// Token: 0x06000686 RID: 1670 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0009DDB0 File Offset: 0x0009BFB0
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

		// Token: 0x06000688 RID: 1672 RVA: 0x0009DE74 File Offset: 0x0009C074
		private void CheckedChangeFull()
		{
			this.ckbDangBaiLenNhom_CheckedChanged(null, null);
			this.ckbDangBaiLenPage_CheckedChanged(null, null);
			this.rbNhomTuNhap_CheckedChanged(null, null);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0009DEAC File Offset: 0x0009C0AC
		private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenNhom.Enabled = this.ckbDangBaiLenNhom.Checked;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0009DEDC File Offset: 0x0009C0DC
		private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenPage.Enabled = this.ckbDangBaiLenPage.Checked;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0009DF0C File Offset: 0x0009C10C
		private void btnNhapNhom_Click(object sender, EventArgs e)
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

		// Token: 0x0600068C RID: 1676 RVA: 0x0009DFE4 File Offset: 0x0009C1E4
		private void rbNhomTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.btnNhapNhom.Enabled = this.rbNhomTuNhap.Checked;
		}

		// Token: 0x0400066E RID: 1646
		private JSON_Settings setting;

		// Token: 0x0400066F RID: 1647
		private string id_KichBan;

		// Token: 0x04000670 RID: 1648
		private string id_TuongTac;

		// Token: 0x04000671 RID: 1649
		private string Id_HanhDong;

		// Token: 0x04000672 RID: 1650
		private int type;

		// Token: 0x04000673 RID: 1651
		public static bool isSave;

		// Token: 0x04000674 RID: 1652
		private List<string> lstNhomTuNhap = new List<string>();

        private void txtIdPost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
