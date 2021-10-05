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
	// Token: 0x020000FF RID: 255
	public partial class fHDTimKiemGoogle : Form
	{
		// Token: 0x06000A76 RID: 2678 RVA: 0x00160BFC File Offset: 0x0015EDFC
		public fHDTimKiemGoogle(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDTimKiemGoogle.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDTimKiemGoogle").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTimKiemGoogle', 'Tìm kiếm Google');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDTimKiemGoogle");
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

		// Token: 0x06000A77 RID: 2679 RVA: 0x00160E20 File Offset: 0x0015F020
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.label9);
			Language.GetValue(this.label13);
			Language.GetValue(this.label11);
			Language.GetValue(this.label10);
			Language.GetValue(this.label14);
			Language.GetValue(this.label12);
			Language.GetValue(this.label15);
			Language.GetValue(this.label17);
			Language.GetValue(this.label16);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00160F60 File Offset: 0x0015F160
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudCountTuKhoaFrom.Value = this.setting.GetValueInt("nudCountTuKhoaFrom", 1);
				this.nudCountTuKhoaTo.Value = this.setting.GetValueInt("nudCountTuKhoaTo", 1);
				this.nudCountPageFrom.Value = this.setting.GetValueInt("nudCountPageFrom", 3);
				this.nudCountPageTo.Value = this.setting.GetValueInt("nudCountPageTo", 3);
				this.nudCountLinkClickFrom.Value = this.setting.GetValueInt("nudCountLinkClickFrom", 3);
				this.nudCountLinkClickTo.Value = this.setting.GetValueInt("nudCountLinkClickTo", 5);
				this.nudCountTimeScrollFrom.Value = this.setting.GetValueInt("nudCountTimeScrollFrom", 30);
				this.nudCountTimeScrollTo.Value = this.setting.GetValueInt("nudCountTimeScrollTo", 30);
				this.txtTuKhoa.Text = this.setting.GetValue("txtTuKhoa", "");
			}
			catch
			{
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x001611F0 File Offset: 0x0015F3F0
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
				json_Settings.Update("nudCountTuKhoaFrom", this.nudCountTuKhoaFrom.Value);
				json_Settings.Update("nudCountTuKhoaTo", this.nudCountTuKhoaTo.Value);
				json_Settings.Update("nudCountPageFrom", this.nudCountPageFrom.Value);
				json_Settings.Update("nudCountPageTo", this.nudCountPageTo.Value);
				json_Settings.Update("nudCountLinkClickFrom", this.nudCountLinkClickFrom.Value);
				json_Settings.Update("nudCountLinkClickTo", this.nudCountLinkClickTo.Value);
				json_Settings.Update("nudCountTimeScrollFrom", this.nudCountTimeScrollFrom.Value);
				json_Settings.Update("nudCountTimeScrollTo", this.nudCountTimeScrollTo.Value);
				json_Settings.Update("txtTuKhoa", this.txtTuKhoa.Text.Trim());
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
							fHDTimKiemGoogle.isSave = true;
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
							fHDTimKiemGoogle.isSave = true;
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

		// Token: 0x06000A7B RID: 2683 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00161580 File Offset: 0x0015F780
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

		// Token: 0x06000A7D RID: 2685 RVA: 0x00161644 File Offset: 0x0015F844
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách Từ khóa|Link Web ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x04000F4A RID: 3914
		private JSON_Settings setting = null;

		// Token: 0x04000F4B RID: 3915
		private string id_KichBan;

		// Token: 0x04000F4C RID: 3916
		private string id_TuongTac;

		// Token: 0x04000F4D RID: 3917
		private string Id_HanhDong;

		// Token: 0x04000F4E RID: 3918
		private int type;

		// Token: 0x04000F4F RID: 3919
		public static bool isSave;
	}
}
