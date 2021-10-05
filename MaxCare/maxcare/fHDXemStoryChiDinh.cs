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
	// Token: 0x020000CB RID: 203
	public partial class fHDXemStoryChiDinh : Form
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x000FC568 File Offset: 0x000FA768
		public fHDXemStoryChiDinh(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDXemStoryChiDinh.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDXemStoryChiDinh").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXemStoryChiDinh','Xem story chỉ định');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDXemStoryChiDinh");
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

		// Token: 0x06000849 RID: 2121 RVA: 0x000FC7B0 File Offset: 0x000FA9B0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
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

		// Token: 0x0600084A RID: 2122 RVA: 0x000FC8AC File Offset: 0x000FAAAC
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtLinkStory.Text = this.setting.GetValue("txtLinkStory", "");
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				string value = this.setting.GetValue("typeReaction", "");
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
					bool flag = value.Contains(i.ToString());
					if (flag)
					{
						list[i].Checked = true;
					}
				}
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000FCB14 File Offset: 0x000FAD14
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
				json_Settings.Update("txtLinkStory", this.txtLinkStory.Text);
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
							fHDXemStoryChiDinh.isSave = true;
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
							fHDXemStoryChiDinh.isSave = true;
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

		// Token: 0x0600084D RID: 2125 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000FCF30 File Offset: 0x000FB130
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

		// Token: 0x0600084F RID: 2127 RVA: 0x000FCFF4 File Offset: 0x000FB1F4
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

		// Token: 0x06000850 RID: 2128 RVA: 0x000FD088 File Offset: 0x000FB288
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000FD0B4 File Offset: 0x000FB2B4
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
			this.plInteract.Enabled = this.ckbInteract.Checked;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000FD0E4 File Offset: 0x000FB2E4
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000FD114 File Offset: 0x000FB314
		private void label25_Click(object sender, EventArgs e)
		{
			this.ckbLike.Checked = !this.ckbLike.Checked;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000FD14C File Offset: 0x000FB34C
		private void label26_Click(object sender, EventArgs e)
		{
			this.ckbTym.Checked = !this.ckbTym.Checked;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000FD184 File Offset: 0x000FB384
		private void label27_Click(object sender, EventArgs e)
		{
			this.ckbThuong.Checked = !this.ckbThuong.Checked;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000FD1BC File Offset: 0x000FB3BC
		private void label28_Click(object sender, EventArgs e)
		{
			this.ckbHaha.Checked = !this.ckbHaha.Checked;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000FD1F4 File Offset: 0x000FB3F4
		private void label29_Click(object sender, EventArgs e)
		{
			this.ckbWow.Checked = !this.ckbWow.Checked;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000FD22C File Offset: 0x000FB42C
		private void label30_Click(object sender, EventArgs e)
		{
			this.ckbBuon.Checked = !this.ckbBuon.Checked;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000FD264 File Offset: 0x000FB464
		private void label32_Click(object sender, EventArgs e)
		{
			this.ckbGian.Checked = !this.ckbGian.Checked;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000F9444 File Offset: 0x000F7644
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng story!"), 1);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000FD29C File Offset: 0x000FB49C
		private void txtLinkStory_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtLinkStory.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label2.Text = string.Format(Language.GetValue("Danh sách link ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x04000B2C RID: 2860
		private JSON_Settings setting;

		// Token: 0x04000B2D RID: 2861
		private string id_KichBan;

		// Token: 0x04000B2E RID: 2862
		private string id_TuongTac;

		// Token: 0x04000B2F RID: 2863
		private string Id_HanhDong;

		// Token: 0x04000B30 RID: 2864
		private int type;

		// Token: 0x04000B31 RID: 2865
		public static bool isSave;
	}
}
