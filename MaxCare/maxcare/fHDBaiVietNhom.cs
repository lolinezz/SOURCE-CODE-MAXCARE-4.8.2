using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x0200010A RID: 266
	public partial class fHDBaiVietNhom : Form
	{
		// Token: 0x06000B68 RID: 2920 RVA: 0x001919F0 File Offset: 0x0018FBF0
		public fHDBaiVietNhom(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBaiVietNhom.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBaiVietNhom");
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

		// Token: 0x06000B69 RID: 2921 RVA: 0x00191BD4 File Offset: 0x0018FDD4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label68);
			Language.GetValue(this.label19);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.ckbShareWall);
			Language.GetValue(this.ckbSendAnh);
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button3);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00191D28 File Offset: 0x0018FF28
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongNhomFrom.Value = Convert.ToInt32(this.setting["nudSoLuongNhomFrom"]);
				this.nudSoLuongNhomTo.Value = Convert.ToInt32(this.setting["nudSoLuongNhomTo"]);
				this.nudSoLuongBaiVietFrom.Value = Convert.ToInt32(this.setting["nudSoLuongBaiVietFrom"]);
				this.nudSoLuongBaiVietTo.Value = Convert.ToInt32(this.setting["nudSoLuongBaiVietTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.ckbInteract.Checked = Convert.ToBoolean(this.setting["ckbInteract"]);
				this.ckbShareWall.Checked = Convert.ToBoolean(this.setting["ckbShareWall"]);
				this.ckbComment.Checked = Convert.ToBoolean(this.setting["ckbComment"]);
				this.txtComment.Text = this.setting["txtComment"].ToString();
				bool flag = Convert.ToInt32(this.setting["typeNganCach"]) == 1;
				if (flag)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
				this.ckbSendAnh.Checked = Convert.ToBoolean(this.setting["ckbSendAnh"]);
				this.txtAnh.Text = this.setting["txtAnh"].ToString();
				this.ckbVip.Checked = Convert.ToBoolean(this.setting["ckbVip"]);
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00192100 File Offset: 0x00190300
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.type == 0;
			if (flag)
			{
				bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
				if (flag2)
				{
					string text = this.txtTenHanhDong.Text.Trim();
					bool flag3 = text == "";
					if (flag3)
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
							bool flag4 = list.Count == 0;
							if (flag4)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
								return;
							}
						}
						bool checked2 = this.ckbSendAnh.Checked;
						if (checked2)
						{
							bool flag5 = this.txtAnh.Text.Trim().Length == 0;
							if (flag5)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn folder ảnh!"), 3);
								return;
							}
						}
						JSON_Settings json_Settings = new JSON_Settings();
						json_Settings.Update("nudSoLuongNhomFrom", this.nudSoLuongNhomFrom.Value);
						json_Settings.Update("nudSoLuongNhomTo", this.nudSoLuongNhomTo.Value);
						json_Settings.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
						json_Settings.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
						json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings.Update("ckbComment", this.ckbComment.Checked);
						json_Settings.Update("txtComment", this.txtComment.Text.Trim());
						int num = 0;
						bool checked3 = this.rbNganCachKyTu.Checked;
						if (checked3)
						{
							num = 1;
						}
						json_Settings.Update("typeNganCach", num);
						json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
						json_Settings.Update("ckbVip", this.ckbVip.Checked);
						string fullString = json_Settings.GetFullString();
						bool flag6 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag6)
						{
							fHDBaiVietNhom.isSave = true;
							base.Close();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Thêm thất bại, vui lòng thử lại sau!"), 2);
						}
					}
				}
			}
			else
			{
				bool flag7 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
				if (flag7)
				{
					string text2 = this.txtTenHanhDong.Text.Trim();
					bool flag8 = text2 == "";
					if (flag8)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập tên hành động!"), 3);
					}
					else
					{
						bool checked4 = this.ckbComment.Checked;
						if (checked4)
						{
							List<string> list2 = this.txtComment.Lines.ToList<string>();
							list2 = MCommon.Common.RemoveEmptyItems(list2);
							bool flag9 = list2.Count == 0;
							if (flag9)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
								return;
							}
						}
						bool checked5 = this.ckbSendAnh.Checked;
						if (checked5)
						{
							bool flag10 = this.txtAnh.Text.Trim().Length == 0;
							if (flag10)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn folder ảnh!"), 3);
								return;
							}
						}
						JSON_Settings json_Settings2 = new JSON_Settings();
						json_Settings2.Update("nudSoLuongNhomFrom", this.nudSoLuongNhomFrom.Value);
						json_Settings2.Update("nudSoLuongNhomTo", this.nudSoLuongNhomTo.Value);
						json_Settings2.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
						json_Settings2.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
						json_Settings2.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings2.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings2.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings2.Update("ckbShareWall", this.ckbShareWall.Checked);
						json_Settings2.Update("ckbComment", this.ckbComment.Checked);
						json_Settings2.Update("txtComment", this.txtComment.Text.Trim());
						int num2 = 0;
						bool checked6 = this.rbNganCachKyTu.Checked;
						if (checked6)
						{
							num2 = 1;
						}
						json_Settings2.Update("typeNganCach", num2);
						json_Settings2.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings2.Update("txtAnh", this.txtAnh.Text.Trim());
						json_Settings2.Update("ckbVip", this.ckbVip.Checked);
						string fullString2 = json_Settings2.GetFullString();
						bool flag11 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text2, fullString2);
						if (flag11)
						{
							fHDBaiVietNhom.isSave = true;
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

		// Token: 0x06000B6D RID: 2925 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00192AC4 File Offset: 0x00190CC4
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

		// Token: 0x06000B6F RID: 2927 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00192B88 File Offset: 0x00190D88
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00192BA4 File Offset: 0x00190DA4
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

		// Token: 0x06000B72 RID: 2930 RVA: 0x00192CA0 File Offset: 0x00190EA0
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbSendAnh_CheckedChanged(null, null);
			this.ckbVip_CheckedChanged(null, null);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00192CE8 File Offset: 0x00190EE8
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00192B88 File Offset: 0x00190D88
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00192B88 File Offset: 0x00190D88
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00192D18 File Offset: 0x00190F18
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 207;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00192D3C File Offset: 0x00190F3C
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 163;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00192D60 File Offset: 0x00190F60
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
			bool flag2 = (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control;
			if (flag2)
			{
				this.panel2.Visible = true;
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00192E24 File Offset: 0x00191024
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00192E54 File Offset: 0x00191054
		private void button2_Click(object sender, EventArgs e)
		{
			this.txtAnh.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button3_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00192E78 File Offset: 0x00191078
		private void button5_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00192EBC File Offset: 0x001910BC
		private void button4_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00192EE8 File Offset: 0x001910E8
		private void ckbVip_CheckedChanged(object sender, EventArgs e)
		{
			this.btnNhap.Enabled = this.ckbVip.Checked;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00192F18 File Offset: 0x00191118
		private void btnNhap_Click(object sender, EventArgs e)
		{
			Process.Start("configs\\nhom.txt");
		}

		// Token: 0x0400119F RID: 4511
		private JObject setting;

		// Token: 0x040011A0 RID: 4512
		private string id_KichBan;

		// Token: 0x040011A1 RID: 4513
		private string id_TuongTac;

		// Token: 0x040011A2 RID: 4514
		private string Id_HanhDong;

		// Token: 0x040011A3 RID: 4515
		private int type;

		// Token: 0x040011A4 RID: 4516
		public static bool isSave;
	}
}
