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
	// Token: 0x02000119 RID: 281
	public partial class fHDNhanTinPage : Form
	{
		// Token: 0x06000C2F RID: 3119 RVA: 0x001BDA40 File Offset: 0x001BBC40
		public fHDNhanTinPage(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDNhanTinPage.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDNhanTinPage");
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

		// Token: 0x06000C30 RID: 3120 RVA: 0x001BDC24 File Offset: 0x001BBE24
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
			Language.GetValue(this.lblStatusPage);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x001BDD10 File Offset: 0x001BBF10
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.txtIdPage.Text = this.setting["txtIdPage"].ToString();
				this.txtTinNhan.Text = this.setting["txtTinNhan"].ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x001BDECC File Offset: 0x001BC0CC
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
				List<string> list = this.txtIdPage.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách ID Page!"), 3);
				}
				else
				{
					list = this.txtTinNhan.Lines.ToList<string>();
					list = MCommon.Common.RemoveEmptyItems(list);
					bool flag3 = list.Count == 0;
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung tin nhắn!"), 3);
					}
					else
					{
						JSON_Settings json_Settings = new JSON_Settings();
						json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
						json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
						json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings.Update("txtIdPage", this.txtIdPage.Text.Trim());
						json_Settings.Update("txtTinNhan", this.txtTinNhan.Text.Trim());
						string fullString = json_Settings.GetFullString();
						bool flag4 = this.type == 0;
						if (flag4)
						{
							bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
							if (flag5)
							{
								bool flag6 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
								if (flag6)
								{
									fHDNhanTinPage.isSave = true;
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
							bool flag7 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
							if (flag7)
							{
								bool flag8 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
								if (flag8)
								{
									fHDNhanTinPage.isSave = true;
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
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x001BE288 File Offset: 0x001BC488
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

		// Token: 0x06000C36 RID: 3126 RVA: 0x001BE34C File Offset: 0x001BC54C
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTinNhan.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách tin nhắn ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x001BE3E0 File Offset: 0x001BC5E0
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtIdPage.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusPage.Text = string.Format(Language.GetValue("Danh sách ID Page ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x040013DC RID: 5084
		private JObject setting;

		// Token: 0x040013DD RID: 5085
		private string id_KichBan;

		// Token: 0x040013DE RID: 5086
		private string id_TuongTac;

		// Token: 0x040013DF RID: 5087
		private string Id_HanhDong;

		// Token: 0x040013E0 RID: 5088
		private int type;

		// Token: 0x040013E1 RID: 5089
		public static bool isSave;
	}
}
