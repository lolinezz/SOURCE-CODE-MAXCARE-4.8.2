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
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000AE RID: 174
	public partial class fHDChangeTenPhu : Form
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x0009B774 File Offset: 0x00099974
		public fHDChangeTenPhu(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			fHDChangeTenPhu.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDChangeTenPhu").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDChangeTenPhu', 'Thay đổi tên phụ');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDChangeTenPhu");
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

		// Token: 0x06000678 RID: 1656 RVA: 0x0009B9BC File Offset: 0x00099BBC
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0009BA10 File Offset: 0x00099C10
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtTenPhu.Text = this.setting.GetValue("txtTenPhu", "");
			}
			catch
			{
			}
			this.txtTuKhoa_TextChanged(null, null);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0009BAA0 File Offset: 0x00099CA0
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
				json_Settings.Update("txtTenPhu", this.txtTenPhu.Text.Trim());
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
							fHDChangeTenPhu.isSave = true;
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
							fHDChangeTenPhu.isSave = true;
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

		// Token: 0x0600067C RID: 1660 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0009BCA8 File Offset: 0x00099EA8
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

		// Token: 0x0600067E RID: 1662 RVA: 0x0009BD6C File Offset: 0x00099F6C
		private void txtTuKhoa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTenPhu.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label2.Text = string.Format(Language.GetValue("Danh sách tên phụ ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x04000658 RID: 1624
		private JSON_Settings setting = null;

		// Token: 0x04000659 RID: 1625
		private string id_KichBan;

		// Token: 0x0400065A RID: 1626
		private string id_TuongTac;

		// Token: 0x0400065B RID: 1627
		private string Id_HanhDong;

		// Token: 0x0400065C RID: 1628
		private int type;

		// Token: 0x0400065D RID: 1629
		public static bool isSave;
	}
}
