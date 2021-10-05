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
	// Token: 0x02000117 RID: 279
	public partial class fHDKetBanTheoTuKhoa : Form
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x001B8C98 File Offset: 0x001B6E98
		public fHDKetBanTheoTuKhoa(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDKetBanTheoTuKhoa.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDKetBanTheoTuKhoa");
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

		// Token: 0x06000C1A RID: 3098 RVA: 0x001B8E7C File Offset: 0x001B707C
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

		// Token: 0x06000C1B RID: 3099 RVA: 0x001B8F58 File Offset: 0x001B7158
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.txtTuKhoa.Text = this.setting["txtTuKhoa"].ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x001B90D8 File Offset: 0x001B72D8
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
								fHDKetBanTheoTuKhoa.isSave = true;
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
								fHDKetBanTheoTuKhoa.isSave = true;
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

		// Token: 0x06000C1E RID: 3102 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x001B9404 File Offset: 0x001B7604
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

		// Token: 0x06000C20 RID: 3104 RVA: 0x001B94C8 File Offset: 0x001B76C8
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

		// Token: 0x0400139A RID: 5018
		private JObject setting;

		// Token: 0x0400139B RID: 5019
		private string id_KichBan;

		// Token: 0x0400139C RID: 5020
		private string id_TuongTac;

		// Token: 0x0400139D RID: 5021
		private string Id_HanhDong;

		// Token: 0x0400139E RID: 5022
		private int type;

		// Token: 0x0400139F RID: 5023
		public static bool isSave;
	}
}
