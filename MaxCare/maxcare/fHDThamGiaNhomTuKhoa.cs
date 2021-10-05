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
	// Token: 0x0200010E RID: 270
	public partial class fHDThamGiaNhomTuKhoa : Form
	{
		// Token: 0x06000BB3 RID: 2995 RVA: 0x001A0474 File Offset: 0x0019E674
		public fHDThamGiaNhomTuKhoa(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDThamGiaNhomTuKhoa.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string json = "";
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDThamGiaNhomTuKhoa");
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

		// Token: 0x06000BB4 RID: 2996 RVA: 0x001A0658 File Offset: 0x0019E858
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
			Language.GetValue(this.ckbTuDongTraLoiCauHoi);
			Language.GetValue(this.lblStatusComment);
			Language.GetValue(this.label9);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x001A0768 File Offset: 0x0019E968
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = Convert.ToInt32(this.setting["nudSoLuongFrom"]);
				this.nudSoLuongTo.Value = Convert.ToInt32(this.setting["nudSoLuongTo"]);
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.txtTuKhoa.Text = this.setting["txtTuKhoa"].ToString();
				this.ckbTuDongTraLoiCauHoi.Checked = Convert.ToBoolean(this.setting["ckbTuDongTraLoiCauHoi"]);
				this.txtCauTraLoi.Text = this.setting["txtCauTraLoi"].ToString();
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x001A0968 File Offset: 0x0019EB68
		private void CheckedChangeFull()
		{
			this.ckbTuongTac_CheckedChanged(null, null);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x001A0984 File Offset: 0x0019EB84
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
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách từ khóa!"), 3);
				}
				else
				{
					bool @checked = this.ckbTuDongTraLoiCauHoi.Checked;
					if (@checked)
					{
						list = this.txtCauTraLoi.Lines.ToList<string>();
						list = MCommon.Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách câu trả lời!"), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudSoLuongFrom", this.nudSoLuongFrom.Value);
					json_Settings.Update("nudSoLuongTo", this.nudSoLuongTo.Value);
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("txtTuKhoa", this.txtTuKhoa.Text.Trim());
					json_Settings.Update("ckbTuDongTraLoiCauHoi", this.ckbTuDongTraLoiCauHoi.Checked);
					json_Settings.Update("txtCauTraLoi", this.txtCauTraLoi.Text.Trim());
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
								fHDThamGiaNhomTuKhoa.isSave = true;
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
								fHDThamGiaNhomTuKhoa.isSave = true;
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

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x001A0D8C File Offset: 0x0019EF8C
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

		// Token: 0x06000BBB RID: 3003 RVA: 0x00054604 File Offset: 0x00052804
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x001A0E50 File Offset: 0x0019F050
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue("Danh sách từ khóa ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x001A0EE4 File Offset: 0x0019F0E4
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtCauTraLoi.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.lblStatusComment.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x001A0F78 File Offset: 0x0019F178
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTac.Enabled = this.ckbTuDongTraLoiCauHoi.Checked;
		}

		// Token: 0x04001254 RID: 4692
		private JObject setting;

		// Token: 0x04001255 RID: 4693
		private string id_KichBan;

		// Token: 0x04001256 RID: 4694
		private string id_TuongTac;

		// Token: 0x04001257 RID: 4695
		private string Id_HanhDong;

		// Token: 0x04001258 RID: 4696
		private int type;

		// Token: 0x04001259 RID: 4697
		public static bool isSave;
	}
}
