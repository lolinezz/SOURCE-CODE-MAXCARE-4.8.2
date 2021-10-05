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
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x0200010D RID: 269
	public partial class fHDRoiNhom : Form
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x0019C490 File Offset: 0x0019A690
		public fHDRoiNhom(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDRoiNhom.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDRoiNhom");
				json = tuongTac.Rows[0]["CauHinh"].ToString();
				this.id_TuongTac = tuongTac.Rows[0]["Id_TuongTac"].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0]["MoTa"].ToString());
			}
			else
			{
				bool flag2 = type == 1;
				if (flag2)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					json = hanhDongById.Rows[0]["CauHinh"].ToString();
					this.btnAdd.Text = Language.GetValue("Cập nhật");
					this.txtTenHanhDong.Text = hanhDongById.Rows[0]["TenHanhDong"].ToString();
				}
			}
			this.setting = JObject.Parse(json);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0019C674 File Offset: 0x0019A874
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
			Language.GetValue(this.label9);
			Language.GetValue(this.rbNgauNhien);
			Language.GetValue(this.rbNhomKiemDuyet);
			Language.GetValue(this.rbRoiTheoDieuKien);
			Language.GetValue(this.ckbDieuKienThanhVien);
			Language.GetValue(this.ckbDieuKienTuKhoa);
			Language.GetValue(this.lblStatusUid);
			Language.GetValue(this.label10);
			Language.GetValue(this.label8);
			Language.GetValue(this.label12);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0019C7D8 File Offset: 0x0019A9D8
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				bool flag = Convert.ToInt32(this.setting["typeRoiNhom"]) == 0;
				if (flag)
				{
					this.rbNgauNhien.Checked = true;
				}
				else
				{
					bool flag2 = Convert.ToInt32(this.setting["typeRoiNhom"]) == 1;
					if (flag2)
					{
						this.rbNhomKiemDuyet.Checked = true;
					}
					else
					{
						this.rbRoiTheoDieuKien.Checked = true;
					}
				}
				this.ckbDieuKienThanhVien.Checked = Convert.ToBoolean(this.setting["ckbDieuKienThanhVien"]);
				this.nudThanhVienToiDa.Value = Convert.ToInt32(this.setting["nudThanhVienToiDa"]);
				this.ckbDieuKienTuKhoa.Checked = Convert.ToBoolean(this.setting["ckbDieuKienTuKhoa"]);
				this.txtTuKhoa.Text = this.setting["txtTuKhoa"].ToString();
				this.txtIDNhomGiuLai.Text = this.setting["txtIDNhomGiuLai"].ToString();
				this.ckbDieuKienID.Checked = Convert.ToBoolean(this.setting["ckbDieuKienID"]);
				this.txtIdNhomRoi.Text = this.setting["txtIdNhomRoi"].ToString();
			}
			catch
			{
			}
			this.CheckedChangedFull();
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0019CB88 File Offset: 0x0019AD88
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
				bool @checked = this.rbRoiTheoDieuKien.Checked;
				if (@checked)
				{
					bool flag2 = !this.ckbDieuKienThanhVien.Checked && !this.ckbDieuKienTuKhoa.Checked && !this.ckbDieuKienID.Checked;
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn ít nhất một điều kiện rời nhóm!"), 3);
						return;
					}
					bool checked2 = this.ckbDieuKienTuKhoa.Checked;
					if (checked2)
					{
						List<string> list = this.txtTuKhoa.Lines.ToList<string>();
						list = MCommon.Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách từ khóa!"), 3);
							return;
						}
					}
					else
					{
						bool checked3 = this.ckbDieuKienID.Checked;
						if (checked3)
						{
							List<string> list2 = this.txtIdNhomRoi.Lines.ToList<string>();
							list2 = MCommon.Common.RemoveEmptyItems(list2);
							bool flag4 = list2.Count == 0;
							if (flag4)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách nhóm cần rời!"), 3);
								return;
							}
						}
					}
				}
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
				json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				bool checked4 = this.rbNgauNhien.Checked;
				if (checked4)
				{
					json_Settings.Update("typeRoiNhom", 0);
				}
				else
				{
					bool checked5 = this.rbNhomKiemDuyet.Checked;
					if (checked5)
					{
						json_Settings.Update("typeRoiNhom", 1);
					}
					else
					{
						json_Settings.Update("typeRoiNhom", 2);
					}
				}
				json_Settings.Update("ckbDieuKienThanhVien", this.ckbDieuKienThanhVien.Checked);
				json_Settings.Update("nudThanhVienToiDa", this.nudThanhVienToiDa.Value);
				json_Settings.Update("ckbDieuKienTuKhoa", this.ckbDieuKienTuKhoa.Checked);
				json_Settings.Update("txtTuKhoa", this.txtTuKhoa.Text.Trim());
				json_Settings.Update("txtIDNhomGiuLai", this.txtIDNhomGiuLai.Text);
				json_Settings.Update("ckbDieuKienID", this.ckbDieuKienID.Checked);
				json_Settings.Update("txtIdNhomRoi", this.txtIdNhomRoi.Text.Trim());
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
							fHDRoiNhom.isSave = true;
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
							fHDRoiNhom.isSave = true;
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

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0019D1BC File Offset: 0x0019B3BC
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

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0019D280 File Offset: 0x0019B480
		private void rbUidChiDinh_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckTypeDoiTuong();
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0019D29C File Offset: 0x0019B49C
		private void CheckTypeDoiTuong()
		{
			this.plUidChiDinh.Enabled = this.rbRoiTheoDieuKien.Checked;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0019D2CC File Offset: 0x0019B4CC
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusUid.Text = string.Format(Language.GetValue("Danh sách từ khóa ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0019D360 File Offset: 0x0019B560
		private void CheckedChangedFull()
		{
			this.ckbThanhVienToiDa_CheckedChanged(null, null);
			this.ckbDieuKienTuKhoa_CheckedChanged(null, null);
			this.CheckTypeDoiTuong();
			this.txtIdNhomRoi_TextChanged(null, null);
			this.ckbDieuKienID_CheckedChanged(null, null);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0019D3B4 File Offset: 0x0019B5B4
		private void ckbThanhVienToiDa_CheckedChanged(object sender, EventArgs e)
		{
			this.nudThanhVienToiDa.Enabled = this.ckbDieuKienThanhVien.Checked;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0019D3E4 File Offset: 0x0019B5E4
		private void ckbDieuKienTuKhoa_CheckedChanged(object sender, EventArgs e)
		{
			this.plDieuKienTuKhoa.Enabled = this.ckbDieuKienTuKhoa.Checked;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00054604 File Offset: 0x00052804
		private void label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0019D414 File Offset: 0x0019B614
		private void txtUidKhongHuyKetBan_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtIDNhomGiuLai.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label8.Text = string.Format(Language.GetValue("Danh sách ID nhóm cần giữ lại ({0}):"), list.Count);
			}
			catch
			{
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00054604 File Offset: 0x00052804
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0019D4A4 File Offset: 0x0019B6A4
		private void txtIdNhomRoi_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtIdNhomRoi.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label11.Text = string.Format(Language.GetValue("Danh sách ID nhóm ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0019D538 File Offset: 0x0019B738
		private void ckbDieuKienID_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbDieuKienID.Checked;
		}

		// Token: 0x04001223 RID: 4643
		private JObject setting;

		// Token: 0x04001224 RID: 4644
		private string id_KichBan;

		// Token: 0x04001225 RID: 4645
		private string id_TuongTac;

		// Token: 0x04001226 RID: 4646
		private string Id_HanhDong;

		// Token: 0x04001227 RID: 4647
		private int type;

		// Token: 0x04001228 RID: 4648
		public static bool isSave;
	}
}
