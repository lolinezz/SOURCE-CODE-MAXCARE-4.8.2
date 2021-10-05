using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using MCommon;

namespace maxcare
{
	// Token: 0x02000116 RID: 278
	public partial class fHDKetBanGoiY : Form
	{
		// Token: 0x06000C10 RID: 3088 RVA: 0x001B64D0 File Offset: 0x001B46D0
		public fHDKetBanGoiY(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDKetBanGoiY.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string jsonStringOrPathFile = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDKetBanGoiY");
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

		// Token: 0x06000C11 RID: 3089 RVA: 0x001B66B4 File Offset: 0x001B48B4
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
			Language.GetValue(this.ckbChiKetBanTenCoDau);
			Language.GetValue(this.ckbOnlyAddFriendWithMutualFriends);
			Language.GetValue(this.label8);
			Language.GetValue(this.label9);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x001B67B0 File Offset: 0x001B49B0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 0);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 0);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 0);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 0);
				this.ckbChiKetBanTenCoDau.Checked = this.setting.GetValueBool("ckbChiKetBanTenCoDau", false);
				this.ckbOnlyAddFriendWithMutualFriends.Checked = this.setting.GetValueBool("ckbOnlyAddFriendWithMutualFriends", false);
				this.nudTimesWarning.Value = this.setting.GetValueInt("nudTimesWarning", 3);
			}
			catch
			{
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x001B69AC File Offset: 0x001B4BAC
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
				json_Settings.Update("ckbChiKetBanTenCoDau", this.ckbChiKetBanTenCoDau.Checked);
				json_Settings.Update("ckbOnlyAddFriendWithMutualFriends", this.ckbOnlyAddFriendWithMutualFriends.Checked);
				json_Settings.Update("nudTimesWarning", this.nudTimesWarning.Value);
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
							fHDKetBanGoiY.isSave = true;
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
							fHDKetBanGoiY.isSave = true;
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

		// Token: 0x06000C15 RID: 3093 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x001B6CD8 File Offset: 0x001B4ED8
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

		// Token: 0x04001378 RID: 4984
		private JSON_Settings setting;

		// Token: 0x04001379 RID: 4985
		private string id_KichBan;

		// Token: 0x0400137A RID: 4986
		private string id_TuongTac;

		// Token: 0x0400137B RID: 4987
		private string Id_HanhDong;

		// Token: 0x0400137C RID: 4988
		private int type;

		// Token: 0x0400137D RID: 4989
		public static bool isSave;
	}
}
