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
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x0200011A RID: 282
	public partial class fHDNhanTinBanBe : Form
	{
		// Token: 0x06000C3A RID: 3130 RVA: 0x001C032C File Offset: 0x001BE52C
		public fHDNhanTinBanBe(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDNhanTinBanBe.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDNhanTinBanBe");
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

		// Token: 0x06000C3B RID: 3131 RVA: 0x001C0510 File Offset: 0x001BE710
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
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.label9);
			Language.GetValue(this.rbNgauNhien);
			Language.GetValue(this.rbUidChiDinh);
			Language.GetValue(this.rbTrucTuyen);
			Language.GetValue(this.lblStatusUid);
			Language.GetValue(this.label10);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x001C0650 File Offset: 0x001BE850
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.txtTinNhan.Text = this.setting["txtTinNhan"].ToString();
				switch (Convert.ToInt32(this.setting["typeDoiTuong"]))
				{
				case 0:
					this.rbNgauNhien.Checked = true;
					break;
				case 1:
					this.rbUidChiDinh.Checked = true;
					break;
				case 2:
					this.rbTrucTuyen.Checked = true;
					break;
				}
				this.txtUidChiDinh.Text = this.setting["txtUidChiDinh"].ToString();
			}
			catch
			{
			}
			this.CheckTypeDoiTuong();
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x001C08B0 File Offset: 0x001BEAB0
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
				List<string> list = this.txtTinNhan.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung tin nhắn!"), 3);
				}
				else
				{
					bool @checked = this.rbUidChiDinh.Checked;
					if (@checked)
					{
						list = this.txtUidChiDinh.Lines.ToList<string>();
						list = MCommon.Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách UID cần nhắn tin!"), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("txtTinNhan", this.txtTinNhan.Text.Trim());
					bool checked2 = this.rbNgauNhien.Checked;
					if (checked2)
					{
						json_Settings.Update("typeDoiTuong", 0);
					}
					else
					{
						bool checked3 = this.rbUidChiDinh.Checked;
						if (checked3)
						{
							json_Settings.Update("typeDoiTuong", 1);
						}
						else
						{
							json_Settings.Update("typeDoiTuong", 2);
						}
					}
					json_Settings.Update("txtUidChiDinh", this.txtUidChiDinh.Text.Trim());
					string fullString = json_Settings.GetFullString();
					bool flag4 = this.type == 0;
					if (flag4)
					{
						bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn thêm hành động mới?")) == DialogResult.Yes;
						if (flag5)
						{
							bool flag6 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
							if (flag6)
							{
								fHDNhanTinBanBe.isSave = true;
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
						bool flag7 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn cập nhật hành động?")) == DialogResult.Yes;
						if (flag7)
						{
							bool flag8 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
							if (flag8)
							{
								fHDNhanTinBanBe.isSave = true;
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

		// Token: 0x06000C3F RID: 3135 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x001C0D34 File Offset: 0x001BEF34
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

		// Token: 0x06000C41 RID: 3137 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x001C0DF8 File Offset: 0x001BEFF8
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTinNhan.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách tin nhắn ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x001C0E8C File Offset: 0x001BF08C
		private void rbUidChiDinh_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckTypeDoiTuong();
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x001C0EA8 File Offset: 0x001BF0A8
		private void CheckTypeDoiTuong()
		{
			this.plUidChiDinh.Enabled = this.rbUidChiDinh.Checked;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x001C0E8C File Offset: 0x001BF08C
		private void rbNgauNhien_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckTypeDoiTuong();
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x001C0ED8 File Offset: 0x001BF0D8
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUidChiDinh.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusUid.Text = string.Format(Language.GetValue("Danh sách UID ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x001C0F6C File Offset: 0x001BF16C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.rbTrucTuyen.Visible = true;
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000DD81C File Offset: 0x000DBA1C
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"), 1);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x040013FE RID: 5118
		private JObject setting;

		// Token: 0x040013FF RID: 5119
		private string id_KichBan;

		// Token: 0x04001400 RID: 5120
		private string id_TuongTac;

		// Token: 0x04001401 RID: 5121
		private string Id_HanhDong;

		// Token: 0x04001402 RID: 5122
		private int type;

		// Token: 0x04001403 RID: 5123
		public static bool isSave;
	}
}
