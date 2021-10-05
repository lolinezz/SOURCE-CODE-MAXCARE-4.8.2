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
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000B9 RID: 185
	public partial class fHDTuongTacBaiVietNhomv2 : Form
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x000BBB54 File Offset: 0x000B9D54
		public fHDTuongTacBaiVietNhomv2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDTuongTacBaiVietNhomv2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDTuongTacBaiVietNhomv2").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietNhomv2', 'Tương tác Bài viết nhóm v2');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDTuongTacBaiVietNhomv2");
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

		// Token: 0x06000716 RID: 1814 RVA: 0x000BBD7C File Offset: 0x000B9F7C
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
			Language.GetValue(this.label14);
			Language.GetValue(this.label13);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label15);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000BBE78 File Offset: 0x000BA078
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudTimeFrom.Value = this.setting.GetValueInt("nudTimeFrom", 10);
				this.nudTimeTo.Value = this.setting.GetValueInt("nudTimeTo", 30);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 1);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 3);
				this.nudCountLikeFrom.Value = this.setting.GetValueInt("nudCountLikeFrom", 1);
				this.nudCountLikeTo.Value = this.setting.GetValueInt("nudCountLikeTo", 3);
				this.nudCountCommentFrom.Value = this.setting.GetValueInt("nudCountCommentFrom", 1);
				this.nudCountCommentTo.Value = this.setting.GetValueInt("nudCountCommentTo", 3);
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				bool flag = this.setting.GetValue("typeCamXuc", "").Contains("0");
				if (flag)
				{
					this.ckbLike.Checked = true;
				}
				bool flag2 = this.setting.GetValue("typeCamXuc", "").Contains("1");
				if (flag2)
				{
					this.ckbLove.Checked = true;
				}
				bool flag3 = this.setting.GetValue("typeCamXuc", "").Contains("2");
				if (flag3)
				{
					this.ckbCare.Checked = true;
				}
				bool flag4 = this.setting.GetValue("typeCamXuc", "").Contains("3");
				if (flag4)
				{
					this.ckbHaha.Checked = true;
				}
				bool flag5 = this.setting.GetValue("typeCamXuc", "").Contains("4");
				if (flag5)
				{
					this.ckbWow.Checked = true;
				}
				bool flag6 = this.setting.GetValue("typeCamXuc", "").Contains("5");
				if (flag6)
				{
					this.ckbSad.Checked = true;
				}
				bool flag7 = this.setting.GetValue("typeCamXuc", "").Contains("6");
				if (flag7)
				{
					this.ckbAngry.Checked = true;
				}
				bool flag8 = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag8)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000BC510 File Offset: 0x000BA710
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
				json_Settings.Update("nudTimeFrom", this.nudTimeFrom.Value);
				json_Settings.Update("nudTimeTo", this.nudTimeTo.Value);
				json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
				json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
				json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
				json_Settings.Update("ckbComment", this.ckbComment.Checked);
				json_Settings.Update("txtComment", this.txtComment.Text.Trim());
				json_Settings.Update("nudCountLikeFrom", this.nudCountLikeFrom.Value);
				json_Settings.Update("nudCountLikeTo", this.nudCountLikeTo.Value);
				json_Settings.Update("nudCountCommentFrom", this.nudCountCommentFrom.Value);
				json_Settings.Update("nudCountCommentTo", this.nudCountCommentTo.Value);
				string text2 = "";
				bool checked2 = this.ckbLike.Checked;
				if (checked2)
				{
					text2 += "0";
				}
				bool checked3 = this.ckbLove.Checked;
				if (checked3)
				{
					text2 += "1";
				}
				bool checked4 = this.ckbCare.Checked;
				if (checked4)
				{
					text2 += "2";
				}
				bool checked5 = this.ckbHaha.Checked;
				if (checked5)
				{
					text2 += "3";
				}
				bool checked6 = this.ckbWow.Checked;
				if (checked6)
				{
					text2 += "4";
				}
				bool checked7 = this.ckbSad.Checked;
				if (checked7)
				{
					text2 += "5";
				}
				bool checked8 = this.ckbAngry.Checked;
				if (checked8)
				{
					text2 += "6";
				}
				json_Settings.Update("typeCamXuc", text2);
				int num = 0;
				bool checked9 = this.rbNganCachKyTu.Checked;
				if (checked9)
				{
					num = 1;
				}
				json_Settings.Update("typeNganCach", num);
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
							fHDTuongTacBaiVietNhomv2.isSave = true;
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
							fHDTuongTacBaiVietNhomv2.isSave = true;
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

		// Token: 0x0600071A RID: 1818 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000BCB70 File Offset: 0x000BAD70
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

		// Token: 0x0600071C RID: 1820 RVA: 0x000BCC34 File Offset: 0x000BAE34
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000BCC50 File Offset: 0x000BAE50
		private void UpdateSoLuongBinhLuan()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtComment.Lines.ToList<string>();
				}
				else
				{
					list = this.txtComment.Text.Split(new string[]
					{
						"\n|\n"
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000BCD4C File Offset: 0x000BAF4C
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000BCD78 File Offset: 0x000BAF78
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
			this.panel3.Enabled = this.ckbInteract.Checked;
			this.panel2.Enabled = this.ckbInteract.Checked;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000BCDC8 File Offset: 0x000BAFC8
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountComment.Enabled = this.ckbComment.Checked;
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000BCE18 File Offset: 0x000BB018
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 207;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000BCE3C File Offset: 0x000BB03C
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 163;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000BCE60 File Offset: 0x000BB060
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000BCC34 File Offset: 0x000BAE34
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000BCC34 File Offset: 0x000BAE34
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x040007FC RID: 2044
		private JSON_Settings setting = null;

		// Token: 0x040007FD RID: 2045
		private string id_KichBan;

		// Token: 0x040007FE RID: 2046
		private string id_TuongTac;

		// Token: 0x040007FF RID: 2047
		private string Id_HanhDong;

		// Token: 0x04000800 RID: 2048
		private int type;

		// Token: 0x04000801 RID: 2049
		public static bool isSave;
	}
}
