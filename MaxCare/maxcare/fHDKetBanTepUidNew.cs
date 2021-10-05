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
	// Token: 0x020000FB RID: 251
	public partial class fHDKetBanTepUidNew : Form
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x00152A2C File Offset: 0x00150C2C
		public fHDKetBanTepUidNew(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDKetBanTepUidNew.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDKetBanTepUidNew").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanTepUidNew', 'Kết bạn theo tệp Uid v2');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDKetBanTepUidNew");
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

		// Token: 0x06000A37 RID: 2615 RVA: 0x00152C54 File Offset: 0x00150E54
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label8);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label2);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label5);
			Language.GetValue(this.label10);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00152D30 File Offset: 0x00150F30
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtLink.Text = this.setting.GetValue("txtLink", "");
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 3);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 5);
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 3);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 3);
			}
			catch
			{
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00152EC0 File Offset: 0x001510C0
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
				json_Settings.Update("txtLink", this.txtLink.Text);
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
				json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
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
							fHDKetBanTepUidNew.isSave = true;
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
							fHDKetBanTepUidNew.isSave = true;
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

		// Token: 0x06000A3B RID: 2619 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00153188 File Offset: 0x00151388
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

		// Token: 0x06000A3D RID: 2621 RVA: 0x0015324C File Offset: 0x0015144C
		private void txtIdPost_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtLink.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label5.Text = string.Format(Language.GetValue("Danh sách Link bài viết ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x04000E94 RID: 3732
		private JSON_Settings setting = null;

		// Token: 0x04000E95 RID: 3733
		private string id_KichBan;

		// Token: 0x04000E96 RID: 3734
		private string id_TuongTac;

		// Token: 0x04000E97 RID: 3735
		private string Id_HanhDong;

		// Token: 0x04000E98 RID: 3736
		private int type;

		// Token: 0x04000E99 RID: 3737
		public static bool isSave;
	}
}
