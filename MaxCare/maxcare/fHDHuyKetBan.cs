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
	// Token: 0x0200010C RID: 268
	public partial class fHDHuyKetBan : Form
	{
		// Token: 0x06000B90 RID: 2960 RVA: 0x001993CC File Offset: 0x001975CC
		public fHDHuyKetBan(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDHuyKetBan.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string jsonStringOrPathFile = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDHuyKetBan");
				jsonStringOrPathFile = tuongTac.Rows[0]["CauHinh"].ToString();
				this.id_TuongTac = tuongTac.Rows[0]["Id_TuongTac"].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0]["MoTa"].ToString());
			}
			else
			{
				bool flag2 = type == 1;
				if (flag2)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					jsonStringOrPathFile = hanhDongById.Rows[0]["CauHinh"].ToString();
					this.btnAdd.Text = Language.GetValue("Cập nhật");
					this.txtTenHanhDong.Text = hanhDongById.Rows[0]["TenHanhDong"].ToString();
				}
			}
			this.setting = new JSON_Settings(jsonStringOrPathFile, true);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x001995B0 File Offset: 0x001977B0
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

		// Token: 0x06000B92 RID: 2962 RVA: 0x001996E0 File Offset: 0x001978E0
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

		// Token: 0x06000B93 RID: 2963 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00199940 File Offset: 0x00197B40
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
							fHDHuyKetBan.isSave = true;
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
							fHDHuyKetBan.isSave = true;
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

		// Token: 0x06000B95 RID: 2965 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00199C9C File Offset: 0x00197E9C
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

		// Token: 0x06000B97 RID: 2967 RVA: 0x00199D60 File Offset: 0x00197F60
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

		// Token: 0x06000B98 RID: 2968 RVA: 0x00199DF4 File Offset: 0x00197FF4
		private void rbHuyNgauNhien_CheckedChanged(object sender, EventArgs e)
		{
			this.plHuyNgauNhien.Enabled = this.rbHuyNgauNhien.Checked;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00199E24 File Offset: 0x00198024
		private void rbHuyTheoUid_CheckedChanged(object sender, EventArgs e)
		{
			this.plHuyTheoUid.Enabled = this.rbHuyTheoUid.Checked;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00199E54 File Offset: 0x00198054
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

		// Token: 0x06000B9B RID: 2971 RVA: 0x00054604 File Offset: 0x00052804
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00054604 File Offset: 0x00052804
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040011FB RID: 4603
		private JSON_Settings setting;

		// Token: 0x040011FC RID: 4604
		private string id_KichBan;

		// Token: 0x040011FD RID: 4605
		private string id_TuongTac;

		// Token: 0x040011FE RID: 4606
		private string Id_HanhDong;

		// Token: 0x040011FF RID: 4607
		private int type;

		// Token: 0x04001200 RID: 4608
		public static bool isSave;
	}
}
