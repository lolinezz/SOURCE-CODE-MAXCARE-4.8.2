using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000B4 RID: 180
	public partial class fHDLinkToInstagram : Form
	{
		// Token: 0x060006B8 RID: 1720 RVA: 0x000A9D30 File Offset: 0x000A7F30
		public fHDLinkToInstagram(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDLinkToInstagram.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDLinkToInstagram").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDLinkToInstagram', 'Liên kết Instagram');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDLinkToInstagram");
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

		// Token: 0x060006B9 RID: 1721 RVA: 0x000A9F58 File Offset: 0x000A8158
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000A9FF0 File Offset: 0x000A81F0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				int valueInt = this.setting.GetValueInt("typePass", 0);
				bool flag = valueInt == 0;
				if (flag)
				{
					this.rbPassRandom.Checked = true;
				}
				else
				{
					this.rbPassTuNhap.Checked = true;
				}
				this.txtPassword.Text = this.setting.GetValue("txtPassword", "");
				this.txtPathFileSaveAcc.Text = FileHelper.GetPathToCurrentFolder() + "\\accountIG.txt";
				this.ckbUpAvatar.Checked = this.setting.GetValueBool("ckbUpAvatar", false);
				this.txtPathImage.Text = this.setting.GetValue("txtPathImage", "");
				this.ckbFollow.Checked = this.setting.GetValueBool("ckbFollow", false);
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 1);
			}
			catch
			{
			}
			this.rbPassTuNhap_CheckedChanged(null, null);
			this.ckbUpAvatar_CheckedChanged(null, null);
			this.ckbFollow_CheckedChanged(null, null);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000AA284 File Offset: 0x000A8484
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
				int num = 0;
				bool @checked = this.rbPassTuNhap.Checked;
				if (@checked)
				{
					num = 1;
				}
				json_Settings.Update("typePass", num);
				json_Settings.Update("txtPassword", this.txtPassword.Text.Trim());
				json_Settings.Update("ckbUpAvatar", this.ckbUpAvatar.Checked);
				json_Settings.Update("txtPathImage", this.txtPathImage.Text.Trim());
				json_Settings.Update("ckbFollow", this.ckbFollow.Checked);
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
							fHDLinkToInstagram.isSave = true;
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
							fHDLinkToInstagram.isSave = true;
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

		// Token: 0x060006BD RID: 1725 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000AA5C8 File Offset: 0x000A87C8
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

		// Token: 0x060006BF RID: 1727 RVA: 0x000AA68C File Offset: 0x000A888C
		private void rbPassTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPassword.Enabled = this.rbPassTuNhap.Checked;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00054604 File Offset: 0x00052804
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000AA6BC File Offset: 0x000A88BC
		private void ckbUpAvatar_CheckedChanged(object sender, EventArgs e)
		{
			this.panel3.Enabled = this.ckbUpAvatar.Checked;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000AA6EC File Offset: 0x000A88EC
		private void ckbFollow_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbFollow.Checked;
		}

		// Token: 0x04000718 RID: 1816
		private JSON_Settings setting = null;

		// Token: 0x04000719 RID: 1817
		private string id_KichBan;

		// Token: 0x0400071A RID: 1818
		private string id_TuongTac;

		// Token: 0x0400071B RID: 1819
		private string Id_HanhDong;

		// Token: 0x0400071C RID: 1820
		private int type;

		// Token: 0x0400071D RID: 1821
		public static bool isSave;
	}
}
