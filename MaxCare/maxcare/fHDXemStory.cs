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
	// Token: 0x0200011F RID: 287
	public partial class fHDXemStory : Form
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x001D32A8 File Offset: 0x001D14A8
		public fHDXemStory(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDXemStory.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDXemStory");
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

		// Token: 0x06000C9E RID: 3230 RVA: 0x001D348C File Offset: 0x001D168C
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
			Language.GetValue(this.ckbInteract);
			Language.GetValue(this.label26);
			Language.GetValue(this.label27);
			Language.GetValue(this.label30);
			Language.GetValue(this.label32);
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x001D35E0 File Offset: 0x001D17E0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.ckbInteract.Checked = Convert.ToBoolean(this.setting["ckbInteract"]);
				string text = this.setting["typeReaction"].ToString();
				List<CheckBox> list = new List<CheckBox>
				{
					this.ckbLike,
					this.ckbTym,
					this.ckbThuong,
					this.ckbHaha,
					this.ckbWow,
					this.ckbBuon,
					this.ckbGian
				};
				for (int i = 0; i < list.Count; i++)
				{
					bool flag = text.Contains(i.ToString());
					if (flag)
					{
						list[i].Checked = true;
					}
				}
				this.ckbComment.Checked = Convert.ToBoolean(this.setting["ckbComment"]);
				this.txtComment.Text = this.setting["txtComment"].ToString();
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x001D38DC File Offset: 0x001D1ADC
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
				bool @checked = this.ckbComment.Checked;
				if (@checked)
				{
					List<string> list = this.txtComment.Lines.ToList<string>();
					list = MCommon.Common.RemoveEmptyItems(list);
					bool flag2 = list.Count == 0;
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
						return;
					}
				}
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
				json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
				string text2 = "";
				List<CheckBox> list2 = new List<CheckBox>
				{
					this.ckbLike,
					this.ckbTym,
					this.ckbThuong,
					this.ckbHaha,
					this.ckbWow,
					this.ckbBuon,
					this.ckbGian
				};
				for (int i = 0; i < list2.Count; i++)
				{
					bool checked2 = list2[i].Checked;
					if (checked2)
					{
						text2 += i.ToString();
					}
				}
				json_Settings.Update("typeReaction", text2);
				json_Settings.Update("ckbComment", this.ckbComment.Checked);
				json_Settings.Update("txtComment", this.txtComment.Text.Trim());
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
							fHDXemStory.isSave = true;
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
							fHDXemStory.isSave = true;
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

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x001D3D90 File Offset: 0x001D1F90
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

		// Token: 0x06000CA4 RID: 3236 RVA: 0x001D3E54 File Offset: 0x001D2054
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x001D3EE8 File Offset: 0x001D20E8
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x001D3F14 File Offset: 0x001D2114
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
			this.plInteract.Enabled = this.ckbInteract.Checked;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x001D3F44 File Offset: 0x001D2144
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x001D3F74 File Offset: 0x001D2174
		private void label25_Click(object sender, EventArgs e)
		{
			this.ckbLike.Checked = !this.ckbLike.Checked;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x001D3FAC File Offset: 0x001D21AC
		private void label26_Click(object sender, EventArgs e)
		{
			this.ckbTym.Checked = !this.ckbTym.Checked;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x001D3FE4 File Offset: 0x001D21E4
		private void label27_Click(object sender, EventArgs e)
		{
			this.ckbThuong.Checked = !this.ckbThuong.Checked;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x001D401C File Offset: 0x001D221C
		private void label28_Click(object sender, EventArgs e)
		{
			this.ckbHaha.Checked = !this.ckbHaha.Checked;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x001D4054 File Offset: 0x001D2254
		private void label29_Click(object sender, EventArgs e)
		{
			this.ckbWow.Checked = !this.ckbWow.Checked;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x001D408C File Offset: 0x001D228C
		private void label30_Click(object sender, EventArgs e)
		{
			this.ckbBuon.Checked = !this.ckbBuon.Checked;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x001D40C4 File Offset: 0x001D22C4
		private void label32_Click(object sender, EventArgs e)
		{
			this.ckbGian.Checked = !this.ckbGian.Checked;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000F9444 File Offset: 0x000F7644
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng story!"), 1);
		}

		// Token: 0x040014EB RID: 5355
		private JObject setting;

		// Token: 0x040014EC RID: 5356
		private string id_KichBan;

		// Token: 0x040014ED RID: 5357
		private string id_TuongTac;

		// Token: 0x040014EE RID: 5358
		private string Id_HanhDong;

		// Token: 0x040014EF RID: 5359
		private int type;

		// Token: 0x040014F0 RID: 5360
		public static bool isSave;
	}
}
