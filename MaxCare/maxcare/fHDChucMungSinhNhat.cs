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
	// Token: 0x0200010B RID: 267
	public partial class fHDChucMungSinhNhat : Form
	{
		// Token: 0x06000B84 RID: 2948 RVA: 0x00196994 File Offset: 0x00194B94
		public fHDChucMungSinhNhat(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDChucMungSinhNhat.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDChucMungSinhNhat");
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

		// Token: 0x06000B85 RID: 2949 RVA: 0x00196B78 File Offset: 0x00194D78
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
			Language.GetValue(this.label28);
			Language.GetValue(this.rbNhanTin);
			Language.GetValue(this.rbDangBai);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00196C88 File Offset: 0x00194E88
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				bool flag = Convert.ToInt32(this.setting["typeAction"]) == 0;
				if (flag)
				{
					this.rbNhanTin.Checked = true;
				}
				else
				{
					this.rbDangBai.Checked = true;
				}
				this.txtContent.Text = this.setting["txtContent"].ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00196E70 File Offset: 0x00195070
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
				List<string> list = this.txtContent.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung tin nhắn/bài viết!"), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					bool @checked = this.rbNhanTin.Checked;
					if (@checked)
					{
						json_Settings.Update("typeAction", 0);
					}
					else
					{
						json_Settings.Update("typeAction", 1);
					}
					json_Settings.Update("txtContent", this.txtContent.Text.Trim());
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
								fHDChucMungSinhNhat.isSave = true;
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
								fHDChucMungSinhNhat.isSave = true;
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

		// Token: 0x06000B89 RID: 2953 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00197204 File Offset: 0x00195404
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

		// Token: 0x06000B8B RID: 2955 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x001972C8 File Offset: 0x001954C8
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtContent.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách tin nhắn/bài viết ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0019735C File Offset: 0x0019555C
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận!"), 1);
		}

		// Token: 0x040011D8 RID: 4568
		private JObject setting;

		// Token: 0x040011D9 RID: 4569
		private string id_KichBan;

		// Token: 0x040011DA RID: 4570
		private string id_TuongTac;

		// Token: 0x040011DB RID: 4571
		private string Id_HanhDong;

		// Token: 0x040011DC RID: 4572
		private int type;

		// Token: 0x040011DD RID: 4573
		public static bool isSave;
	}
}
