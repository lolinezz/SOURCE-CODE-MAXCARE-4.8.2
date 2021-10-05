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
	// Token: 0x020000AC RID: 172
	public partial class fHDBaiVietTrenTuong : Form
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x0009530C File Offset: 0x0009350C
		public fHDBaiVietTrenTuong(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBaiVietTrenTuong.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "fHDBaiVietTrenTuong").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('fHDBaiVietTrenTuong', '{  \"nudTimeFrom\": \"10\",  \"nudTimeTo\": \"30\",  \"nudDelayFrom\": \"2\",  \"nudDelayTo\": \"3\",  \"ckbInteract\": \"True\",  \"ckbShareWall\": \"False\",  \"ckbComment\": \"False\",  \"txtComment\": \"\"}', 'Bài viết trên tường');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "fHDBaiVietTrenTuong");
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

		// Token: 0x06000652 RID: 1618 RVA: 0x00095554 File Offset: 0x00093754
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
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00095650 File Offset: 0x00093850
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt("nudSoLuongFrom", 3);
				this.nudSoLuongTo.Value = this.setting.GetValueInt("nudSoLuongTo", 5);
				this.nudDelayFrom.Value = this.setting.GetValueInt("nudDelayFrom", 5);
				this.nudDelayTo.Value = this.setting.GetValueInt("nudDelayTo", 7);
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.ckbCommentText.Checked = this.setting.GetValueBool("ckbCommentText", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				bool flag = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
				this.ckbSendAnh.Checked = this.setting.GetValueBool("ckbSendAnh", false);
				this.txtAnh.Text = this.setting.GetValue("txtAnh", "");
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0009598C File Offset: 0x00093B8C
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
						JSON_Settings json_Settings = new JSON_Settings();
						json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
						json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
						json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings.Update("ckbComment", this.ckbComment.Checked);
						json_Settings.Update("ckbCommentText", this.ckbCommentText.Checked);
						json_Settings.Update("txtComment", this.txtComment.Text.Trim());
						int num = 0;
						bool checked2 = this.rbNganCachKyTu.Checked;
						if (checked2)
						{
							num = 1;
						}
						json_Settings.Update("typeNganCach", num);
						json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
						string fullString = json_Settings.GetFullString();
						bool flag5 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag5)
						{
							fHDBaiVietTrenTuong.isSave = true;
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
				bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
				if (flag6)
				{
					string text2 = this.txtTenHanhDong.Text.Trim();
					bool flag7 = text2 == "";
					if (flag7)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập tên hành động!"), 3);
					}
					else
					{
						bool checked3 = this.ckbComment.Checked;
						if (checked3)
						{
							List<string> list2 = this.txtComment.Lines.ToList<string>();
							list2 = MCommon.Common.RemoveEmptyItems(list2);
							bool flag8 = list2.Count == 0;
							if (flag8)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
								return;
							}
						}
						JSON_Settings json_Settings2 = new JSON_Settings();
						json_Settings2.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
						json_Settings2.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
						json_Settings2.Update("nudDelayFrom", this.nudDelayFrom.Value);
						json_Settings2.Update("nudDelayTo", this.nudDelayTo.Value);
						json_Settings2.Update("ckbInteract", this.ckbInteract.Checked);
						json_Settings2.Update("ckbComment", this.ckbComment.Checked);
						json_Settings2.Update("ckbCommentText", this.ckbCommentText.Checked);
						json_Settings2.Update("txtComment", this.txtComment.Text.Trim());
						int num2 = 0;
						bool checked4 = this.rbNganCachKyTu.Checked;
						if (checked4)
						{
							num2 = 1;
						}
						json_Settings2.Update("typeNganCach", num2);
						json_Settings2.Update("ckbSendAnh", this.ckbSendAnh.Checked);
						json_Settings2.Update("txtAnh", this.txtAnh.Text.Trim());
						string fullString2 = json_Settings2.GetFullString();
						bool flag9 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text2, fullString2);
						if (flag9)
						{
							fHDBaiVietTrenTuong.isSave = true;
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

		// Token: 0x06000656 RID: 1622 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00096148 File Offset: 0x00094348
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

		// Token: 0x06000658 RID: 1624 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0009620C File Offset: 0x0009440C
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

		// Token: 0x0600065A RID: 1626 RVA: 0x000962A0 File Offset: 0x000944A0
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.rbNganCachMoiDong_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
			this.ckbSendAnh_CheckedChanged(null, null);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000962F4 File Offset: 0x000944F4
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00096324 File Offset: 0x00094524
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00096340 File Offset: 0x00094540
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

		// Token: 0x0600065F RID: 1631 RVA: 0x0009643C File Offset: 0x0009463C
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 207;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00096460 File Offset: 0x00094660
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 165;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00096324 File Offset: 0x00094524
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00096484 File Offset: 0x00094684
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0009652C File Offset: 0x0009472C
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00096570 File Offset: 0x00094770
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00054604 File Offset: 0x00052804
		private void plComment_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00054604 File Offset: 0x00052804
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0009659C File Offset: 0x0009479C
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000965CC File Offset: 0x000947CC
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x0400060B RID: 1547
		private JSON_Settings setting;

		// Token: 0x0400060C RID: 1548
		private string id_KichBan;

		// Token: 0x0400060D RID: 1549
		private string id_TuongTac;

		// Token: 0x0400060E RID: 1550
		private string Id_HanhDong;

		// Token: 0x0400060F RID: 1551
		private int type;

		// Token: 0x04000610 RID: 1552
		public static bool isSave;
	}
}
