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
	// Token: 0x020000B0 RID: 176
	public partial class fHDGiaiCheckpoint : Form
	{
		// Token: 0x0600068F RID: 1679 RVA: 0x000A0ED0 File Offset: 0x0009F0D0
		public fHDGiaiCheckpoint(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDGiaiCheckpoint.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDGiaiCheckpoint").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDGiaiCheckpoint', 'Giải checkpoint');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDGiaiCheckpoint");
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

		// Token: 0x06000690 RID: 1680 RVA: 0x000A1118 File Offset: 0x0009F318
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000A116C File Offset: 0x0009F36C
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.ckbCaptcha.Checked = this.setting.GetValueBool("ckbCaptcha", false);
				this.txtCaptcha.Text = this.setting.GetValue("txtCaptcha", "");
				this.ckbPhone.Checked = this.setting.GetValueBool("ckbPhone", false);
				this.txtPhone.Text = this.setting.GetValue("txtPhone", "");
				this.ckbImage.Checked = this.setting.GetValueBool("ckbImage", false);
				this.txtImage.Text = this.setting.GetValue("txtImage", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000A1350 File Offset: 0x0009F550
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
				json_Settings.Update("ckbCaptcha", this.ckbCaptcha.Checked);
				json_Settings.Update("txtCaptcha", this.txtCaptcha.Text);
				json_Settings.Update("ckbPhone", this.ckbPhone.Checked);
				json_Settings.Update("txtPhone", this.txtPhone.Text);
				json_Settings.Update("ckbImage", this.ckbImage.Checked);
				json_Settings.Update("txtImage", this.txtImage.Text);
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
							fHDGiaiCheckpoint.isSave = true;
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
							fHDGiaiCheckpoint.isSave = true;
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

		// Token: 0x06000694 RID: 1684 RVA: 0x000A163C File Offset: 0x0009F83C
		private void CheckedChangeFull()
		{
			this.checkBox1_CheckedChanged(null, null);
			this.ckbPhone_CheckedChanged(null, null);
			this.ckbImage_CheckedChanged(null, null);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000A1674 File Offset: 0x0009F874
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

		// Token: 0x06000697 RID: 1687 RVA: 0x000A1738 File Offset: 0x0009F938
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.txtCaptcha.Enabled = this.ckbCaptcha.Checked;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000A1768 File Offset: 0x0009F968
		private void ckbPhone_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPhone.Enabled = this.ckbPhone.Checked;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000A1798 File Offset: 0x0009F998
		private void ckbImage_CheckedChanged(object sender, EventArgs e)
		{
			this.txtImage.Enabled = this.ckbImage.Checked;
		}

		// Token: 0x040006A0 RID: 1696
		private JSON_Settings setting;

		// Token: 0x040006A1 RID: 1697
		private string id_KichBan;

		// Token: 0x040006A2 RID: 1698
		private string id_TuongTac;

		// Token: 0x040006A3 RID: 1699
		private string Id_HanhDong;

		// Token: 0x040006A4 RID: 1700
		private int type;

		// Token: 0x040006A5 RID: 1701
		public static bool isSave;
	}
}
