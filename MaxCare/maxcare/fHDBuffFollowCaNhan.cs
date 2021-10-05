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
	// Token: 0x02000107 RID: 263
	public partial class fHDBuffFollowCaNhan : Form
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x00186DF4 File Offset: 0x00184FF4
		public fHDBuffFollowCaNhan(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBuffFollowCaNhan.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDBuffFollowCaNhan").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffFollowCaNhan', '{  \"txtUid\": \"\",\"nudDelayFrom\": \"5\",  \"nudDelayTo\": \"10\"}', 'Buff Follow cá nhân');");
			}
			string json = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBuffFollowCaNhan");
				json = tuongTac.Rows[0]["CauHinh"].ToString();
				this.id_TuongTac = tuongTac.Rows[0]["Id_TuongTac"].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0]["MoTa"].ToString());
			}
			else
			{
				bool flag3 = type == 1;
				if (flag3)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					json = hanhDongById.Rows[0]["CauHinh"].ToString();
					this.btnAdd.Text = Language.GetValue("Cập nhật");
					this.txtTenHanhDong.Text = hanhDongById.Rows[0]["TenHanhDong"].ToString();
				}
			}
			this.setting = JObject.Parse(json);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00187040 File Offset: 0x00185240
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label2);
			Language.GetValue(this.label10);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x001870E8 File Offset: 0x001852E8
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = Convert.ToInt32(this.setting["nudDelayFrom"]);
				this.nudDelayTo.Value = Convert.ToInt32(this.setting["nudDelayTo"]);
				this.txtUid.Text = this.setting["txtUid"].ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x001871DC File Offset: 0x001853DC
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
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập danh sách Uid cá nhân!"), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("nudDelayFrom", this.nudDelayFrom.Value);
					json_Settings.Update("nudDelayTo", this.nudDelayTo.Value);
					json_Settings.Update("txtUid", this.txtUid.Text.Trim());
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
								fHDBuffFollowCaNhan.isSave = true;
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
								fHDBuffFollowCaNhan.isSave = true;
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

		// Token: 0x06000B37 RID: 2871 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x001874A4 File Offset: 0x001856A4
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

		// Token: 0x06000B39 RID: 2873 RVA: 0x00187568 File Offset: 0x00185768
		private void txtIdPost_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = MCommon.Common.RemoveEmptyItems(list);
				this.label2.Text = string.Format(Language.GetValue("Danh sách Uid Cá nhân ({0}):"), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x04001118 RID: 4376
		private JObject setting;

		// Token: 0x04001119 RID: 4377
		private string id_KichBan;

		// Token: 0x0400111A RID: 4378
		private string id_TuongTac;

		// Token: 0x0400111B RID: 4379
		private string Id_HanhDong;

		// Token: 0x0400111C RID: 4380
		private int type;

		// Token: 0x0400111D RID: 4381
		public static bool isSave;
	}
}
