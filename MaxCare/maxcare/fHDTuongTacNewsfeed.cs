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
	// Token: 0x02000100 RID: 256
	public partial class fHDTuongTacNewsfeed : Form
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x00163CF0 File Offset: 0x00161EF0
		public fHDTuongTacNewsfeed(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDTuongTacNewsfeed.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDTuongTacNewsfeed").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNewsfeed', 'Tương tác Newsfeed');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDTuongTacNewsfeed");
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

		// Token: 0x06000A81 RID: 2689 RVA: 0x00163F18 File Offset: 0x00162118
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
			Language.GetValue(this.label10);
			Language.GetValue(this.label9);
			Language.GetValue(this.label12);
			Language.GetValue(this.label11);
			Language.GetValue(this.label14);
			Language.GetValue(this.label13);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label15);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0016406C File Offset: 0x0016226C
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
				this.nudCountShareFrom.Value = this.setting.GetValueInt("nudCountShareFrom", 1);
				this.nudCountShareTo.Value = this.setting.GetValueInt("nudCountShareTo", 3);
				this.nudCountCommentFrom.Value = this.setting.GetValueInt("nudCountCommentFrom", 1);
				this.nudCountCommentTo.Value = this.setting.GetValueInt("nudCountCommentTo", 3);
				this.ckbInteract.Checked = this.setting.GetValueBool("ckbInteract", false);
				this.ckbShareWall.Checked = this.setting.GetValueBool("ckbShareWall", false);
				this.ckbComment.Checked = this.setting.GetValueBool("ckbComment", false);
				this.ckbCommentText.Checked = this.setting.GetValueBool("ckbCommentText", false);
				this.txtComment.Text = this.setting.GetValue("txtComment", "");
				this.ckbSendAnh.Checked = this.setting.GetValueBool("ckbSendAnh", false);
				this.txtAnh.Text = this.setting.GetValue("txtAnh", "");
				bool flag = this.setting.GetValueInt("typeNganCach", 0) == 1;
				if (flag)
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

		// Token: 0x06000A83 RID: 2691 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00164564 File Offset: 0x00162764
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
				json_Settings.Update("ckbShareWall", this.ckbShareWall.Checked);
				json_Settings.Update("ckbComment", this.ckbComment.Checked);
				json_Settings.Update("ckbCommentText", this.ckbCommentText.Checked);
				json_Settings.Update("txtComment", this.txtComment.Text.Trim());
				json_Settings.Update("nudCountLikeFrom", this.nudCountLikeFrom.Value);
				json_Settings.Update("nudCountLikeTo", this.nudCountLikeTo.Value);
				json_Settings.Update("nudCountShareFrom", this.nudCountShareFrom.Value);
				json_Settings.Update("nudCountShareTo", this.nudCountShareTo.Value);
				json_Settings.Update("nudCountCommentFrom", this.nudCountCommentFrom.Value);
				json_Settings.Update("nudCountCommentTo", this.nudCountCommentTo.Value);
				json_Settings.Update("ckbSendAnh", this.ckbSendAnh.Checked);
				json_Settings.Update("txtAnh", this.txtAnh.Text.Trim());
				int num = 0;
				bool checked2 = this.rbNganCachKyTu.Checked;
				if (checked2)
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
							fHDTuongTacNewsfeed.isSave = true;
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
							fHDTuongTacNewsfeed.isSave = true;
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

		// Token: 0x06000A85 RID: 2693 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00164B40 File Offset: 0x00162D40
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

		// Token: 0x06000A87 RID: 2695 RVA: 0x00164C04 File Offset: 0x00162E04
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00164C20 File Offset: 0x00162E20
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

		// Token: 0x06000A89 RID: 2697 RVA: 0x00164D1C File Offset: 0x00162F1C
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
			this.ckbShareWall_CheckedChanged(null, null);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00164D64 File Offset: 0x00162F64
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountLike.Enabled = this.ckbInteract.Checked;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00164D94 File Offset: 0x00162F94
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00164DC4 File Offset: 0x00162FC4
		private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountShareWall.Enabled = this.ckbShareWall.Checked;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00164DF4 File Offset: 0x00162FF4
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 207;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00164E18 File Offset: 0x00163018
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 163;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00164E3C File Offset: 0x0016303C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00164C04 File Offset: 0x00162E04
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00164C04 File Offset: 0x00162E04
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000964F8 File Offset: 0x000946F8
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"), 1);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00164EB0 File Offset: 0x001630B0
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00164EF4 File Offset: 0x001630F4
		private void button3_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00164F20 File Offset: 0x00163120
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00164F50 File Offset: 0x00163150
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x04000F74 RID: 3956
		private JSON_Settings setting = null;

		// Token: 0x04000F75 RID: 3957
		private string id_KichBan;

		// Token: 0x04000F76 RID: 3958
		private string id_TuongTac;

		// Token: 0x04000F77 RID: 3959
		private string Id_HanhDong;

		// Token: 0x04000F78 RID: 3960
		private int type;

		// Token: 0x04000F79 RID: 3961
		public static bool isSave;
	}
}
