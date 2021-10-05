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
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x02000104 RID: 260
	public partial class fHDBaiVietFanpage : Form
	{
		// Token: 0x06000AFF RID: 2815 RVA: 0x0017BEE8 File Offset: 0x0017A0E8
		public fHDBaiVietFanpage(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBaiVietFanpage.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBaiVietFanpage");
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

		// Token: 0x06000B00 RID: 2816 RVA: 0x0017C0CC File Offset: 0x0017A2CC
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
			Language.GetValue(this.lblStatusUid);
			Language.GetValue(this.label2);
			Language.GetValue(this.ckbAutoPlayVideo);
			Language.GetValue(this.label9);
			Language.GetValue(this.label11);
			Language.GetValue(this.label10);
			Language.GetValue(this.ckbInteract);
			Language.GetValue(this.ckbShareWall);
			Language.GetValue(this.ckbComment);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button3);
			Language.GetValue(this.label12);
			Language.GetValue(this.ckbLikePage);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0017C294 File Offset: 0x0017A494
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongPageFrom.Value = Convert.ToInt32(this.setting["nudSoLuongPageFrom"]);
				this.nudSoLuongPageTo.Value = Convert.ToInt32(this.setting["nudSoLuongPageTo"]);
				this.nudSoLuongBaiVietFrom.Value = Convert.ToInt32(this.setting["nudSoLuongBaiVietFrom"]);
				this.nudSoLuongBaiVietTo.Value = Convert.ToInt32(this.setting["nudSoLuongBaiVietTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.txtUid.Text = this.setting["txtUid"].ToString();
				this.ckbInteract.Checked = Convert.ToBoolean(this.setting["ckbInteract"]);
				this.ckbShareWall.Checked = Convert.ToBoolean(this.setting["ckbShareWall"]);
				this.ckbComment.Checked = Convert.ToBoolean(this.setting["ckbComment"]);
				this.ckbCommentText.Checked = Convert.ToBoolean(this.setting["ckbCommentText"]);
				this.txtComment.Text = this.setting["txtComment"].ToString();
				this.ckbSendAnh.Checked = Convert.ToBoolean(this.setting["ckbSendAnh"]);
				this.txtAnh.Text = this.setting["txtAnh"].ToString();
				bool flag = Convert.ToInt32(this.setting["typeNganCach"]) == 1;
				if (flag)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
				this.ckbLikePage.Checked = Convert.ToBoolean(this.setting["ckbLikePage"]);
				this.ckbAutoPlayVideo.Checked = Convert.ToBoolean(this.setting["ckbAutoPlayVideo"]);
				this.nudViewFrom.Value = Convert.ToInt32(this.setting["nudViewFrom"]);
				this.nudViewTo.Value = Convert.ToInt32(this.setting["nudViewTo"]);
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0017C79C File Offset: 0x0017A99C
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
						List<string> list = this.txtUid.Lines.ToList<string>();
						list = MCommon.Common.RemoveEmptyItems(list);
						bool flag4 = list.Count == 0;
						if (flag4)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Id page!"), 3);
						}
						else
						{
							bool @checked = this.ckbComment.Checked;
							if (@checked)
							{
								list = this.txtComment.Lines.ToList<string>();
								list = MCommon.Common.RemoveEmptyItems(list);
								bool flag5 = list.Count == 0;
								if (flag5)
								{
									MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
									return;
								}
							}
							JSON_Settings json_Settings = new JSON_Settings();
							json_Settings.Update("nudSoLuongPageFrom", this.nudSoLuongPageFrom.Value);
							json_Settings.Update("nudSoLuongPageTo", this.nudSoLuongPageTo.Value);
							json_Settings.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
							json_Settings.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
							json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
							json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
							json_Settings.Update("txtUid", this.txtUid.Text.Trim());
							json_Settings.Update("ckbInteract", this.ckbInteract.Checked);
							json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
							json_Settings.Update("ckbComment", this.ckbComment.Checked);
							json_Settings.Update("ckbCommentText", this.ckbCommentText.Checked);
							json_Settings.Update("txtComment", this.txtComment.Text.Trim());
							json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
							json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
							int num = 0;
							bool checked2 = this.rbNganCachKyTu.Checked;
							if (checked2)
							{
								num = 1;
							}
							json_Settings.Update("typeNganCach", num);
							json_Settings.Update("ckbLikePage", this.ckbLikePage.Checked);
							json_Settings.Update("ckbAutoPlayVideo", this.ckbAutoPlayVideo.Checked);
							json_Settings.Update("nudViewFrom", this.nudViewFrom.Value);
							json_Settings.Update("nudViewTo", this.nudViewTo.Value);
							string fullString = json_Settings.GetFullString();
							bool flag6 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
							if (flag6)
							{
								fHDBaiVietFanpage.isSave = true;
								base.Close();
							}
							else
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Thêm thất bại, vui lòng thử lại sau!"), 2);
							}
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
						List<string> list2 = this.txtUid.Lines.ToList<string>();
						list2 = MCommon.Common.RemoveEmptyItems(list2);
						bool flag9 = list2.Count == 0;
						if (flag9)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Id page!"), 3);
						}
						else
						{
							bool checked3 = this.ckbComment.Checked;
							if (checked3)
							{
								list2 = this.txtComment.Lines.ToList<string>();
								list2 = MCommon.Common.RemoveEmptyItems(list2);
								bool flag10 = list2.Count == 0;
								if (flag10)
								{
									MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung bình luận!"), 3);
									return;
								}
							}
							JSON_Settings json_Settings2 = new JSON_Settings();
							json_Settings2.Update("nudSoLuongPageFrom", this.nudSoLuongPageFrom.Value);
							json_Settings2.Update("nudSoLuongPageTo", this.nudSoLuongPageTo.Value);
							json_Settings2.Update("nudSoLuongBaiVietFrom", this.nudSoLuongBaiVietFrom.Value);
							json_Settings2.Update("nudSoLuongBaiVietTo", this.nudSoLuongBaiVietTo.Value);
							json_Settings2.Update("nudDelayFrom", this.nudDelayFrom.Value);
							json_Settings2.Update("nudDelayTo", this.nudDelayTo.Value);
							json_Settings2.Update("txtUid", this.txtUid.Text.Trim());
							json_Settings2.Update("ckbInteract", this.ckbInteract.Checked);
							json_Settings2.Update("ckbShareWall", this.ckbShareWall.Checked);
							json_Settings2.Update("ckbComment", this.ckbComment.Checked);
							json_Settings2.Update("ckbCommentText", this.ckbCommentText.Checked);
							json_Settings2.Update("txtComment", this.txtComment.Text.Trim());
							json_Settings2.Update("ckbSendAnh", this.ckbSendAnh.Checked);
							json_Settings2.Update("txtAnh", this.txtAnh.Text.Trim());
							int num2 = 0;
							bool checked4 = this.rbNganCachKyTu.Checked;
							if (checked4)
							{
								num2 = 1;
							}
							json_Settings2.Update("typeNganCach", num2);
							json_Settings2.Update("ckbLikePage", this.ckbLikePage.Checked);
							json_Settings2.Update("ckbAutoPlayVideo", this.ckbAutoPlayVideo.Checked);
							json_Settings2.Update("nudViewFrom", this.nudViewFrom.Value);
							json_Settings2.Update("nudViewTo", this.nudViewTo.Value);
							string fullString2 = json_Settings2.GetFullString();
							bool flag11 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text2, fullString2);
							if (flag11)
							{
								fHDBaiVietFanpage.isSave = true;
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

		// Token: 0x06000B04 RID: 2820 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0017D340 File Offset: 0x0017B540
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

		// Token: 0x06000B06 RID: 2822 RVA: 0x0017D404 File Offset: 0x0017B604
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0017D420 File Offset: 0x0017B620
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

		// Token: 0x06000B08 RID: 2824 RVA: 0x0017D51C File Offset: 0x0017B71C
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbAutoPlayVideo_CheckedChanged(null, null);
			this.ckbCommentText_CheckedChanged(null, null);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0017D564 File Offset: 0x0017B764
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0017D594 File Offset: 0x0017B794
		private void txtUid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusUid.Text = string.Format(Language.GetValue("Danh sách Uid page cần tương tác ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0017D628 File Offset: 0x0017B828
		private void ckbAutoPlayVideo_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbAutoPlayVideo.Checked;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0017D658 File Offset: 0x0017B858
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 210;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0017D67C File Offset: 0x0017B87C
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 164;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0017D6A0 File Offset: 0x0017B8A0
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0017D404 File Offset: 0x0017B604
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0017D404 File Offset: 0x0017B604
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0017D714 File Offset: 0x0017B914
		private void button3_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên page!"), 1);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0017D748 File Offset: 0x0017B948
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0017D78C File Offset: 0x0017B98C
		private void button2_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0017D7B8 File Offset: 0x0017B9B8
		private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0017D7E8 File Offset: 0x0017B9E8
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x04001093 RID: 4243
		private JObject setting;

		// Token: 0x04001094 RID: 4244
		private string id_KichBan;

		// Token: 0x04001095 RID: 4245
		private string id_TuongTac;

		// Token: 0x04001096 RID: 4246
		private string Id_HanhDong;

		// Token: 0x04001097 RID: 4247
		private int type;

		// Token: 0x04001098 RID: 4248
		public static bool isSave;
	}
}
