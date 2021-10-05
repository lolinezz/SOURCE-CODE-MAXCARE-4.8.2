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
	// Token: 0x020000FE RID: 254
	public partial class fHDTruyCapWebsite : Form
	{
		// Token: 0x06000A6C RID: 2668 RVA: 0x0015DEDC File Offset: 0x0015C0DC
		public fHDTruyCapWebsite(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDTruyCapWebsite.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDTruyCapWebsite").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTruyCapWebsite', 'Truy cập Website');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDTruyCapWebsite");
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

		// Token: 0x06000A6D RID: 2669 RVA: 0x0015E104 File Offset: 0x0015C304
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.label9);
			Language.GetValue(this.label13);
			Language.GetValue(this.label11);
			Language.GetValue(this.label15);
			Language.GetValue(this.label17);
			Language.GetValue(this.label16);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.label3);
			Language.GetValue(this.ckbLuot);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0015E224 File Offset: 0x0015C424
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudCountLinkFrom.Value = this.setting.GetValueInt("nudCountLinkFrom", 1);
				this.nudCountLinkTo.Value = this.setting.GetValueInt("nudCountLinkTo", 1);
				this.nudCountLinkClickFrom.Value = this.setting.GetValueInt("nudCountLinkClickFrom", 3);
				this.nudCountLinkClickTo.Value = this.setting.GetValueInt("nudCountLinkClickTo", 5);
				this.nudCountTimeScrollFrom.Value = this.setting.GetValueInt("nudCountTimeScrollFrom", 30);
				this.nudCountTimeScrollTo.Value = this.setting.GetValueInt("nudCountTimeScrollTo", 30);
				this.txtLinkWeb.Text = this.setting.GetValue("txtLinkWeb", "");
				this.ckbLuot.Checked = this.setting.GetValueBool("ckbLuot", true);
			}
			catch
			{
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0015E470 File Offset: 0x0015C670
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
				json_Settings.Update("nudCountLinkFrom", this.nudCountLinkFrom.Value);
				json_Settings.Update("nudCountLinkTo", this.nudCountLinkTo.Value);
				json_Settings.Update("nudCountLinkClickFrom", this.nudCountLinkClickFrom.Value);
				json_Settings.Update("nudCountLinkClickTo", this.nudCountLinkClickTo.Value);
				json_Settings.Update("nudCountTimeScrollFrom", this.nudCountTimeScrollFrom.Value);
				json_Settings.Update("nudCountTimeScrollTo", this.nudCountTimeScrollTo.Value);
				json_Settings.Update("txtLinkWeb", this.txtLinkWeb.Text.Trim());
				json_Settings.Update("ckbLuot", this.ckbLuot.Checked);
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
							fHDTruyCapWebsite.isSave = true;
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
							fHDTruyCapWebsite.isSave = true;
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

		// Token: 0x06000A71 RID: 2673 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0015E7D0 File Offset: 0x0015C9D0
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

		// Token: 0x06000A73 RID: 2675 RVA: 0x0015E894 File Offset: 0x0015CA94
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtLinkWeb.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách Link Web ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x04000F24 RID: 3876
		private JSON_Settings setting = null;

		// Token: 0x04000F25 RID: 3877
		private string id_KichBan;

		// Token: 0x04000F26 RID: 3878
		private string id_TuongTac;

		// Token: 0x04000F27 RID: 3879
		private string Id_HanhDong;

		// Token: 0x04000F28 RID: 3880
		private int type;

		// Token: 0x04000F29 RID: 3881
		public static bool isSave;
	}
}
