using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using MCommon;

namespace maxcare
{
	// Token: 0x02000105 RID: 261
	public partial class fHDBackupData : Form
	{
		// Token: 0x06000B1A RID: 2842 RVA: 0x00181B28 File Offset: 0x0017FD28
		public fHDBackupData(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBackupData.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac("", "HDBackupData").Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBackupData', '{  \"ckbNgaySinh\": \"True\",  \"ckbAnhBanBe\": \"True\",  \"nudSoLuongAnh\": \"20\",  \"ckbNhanTin\": \"True\",  \"ckbBinhLuan\": \"True\",  \"ckbCreateHTML\": \"True\"}', 'Backup dữ liệu');");
			}
			string jsonStringOrPathFile = "";
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac("", "HDBackupData");
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

		// Token: 0x06000B1B RID: 2843 RVA: 0x00181D74 File Offset: 0x0017FF74
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.ckbNgaySinh);
			Language.GetValue(this.ckbAnhBanBe);
			Language.GetValue(this.label7);
			Language.GetValue(this.label10);
			Language.GetValue(this.ckbBackupImageNangCao);
			Language.GetValue(this.button2);
			Language.GetValue(this.ckbNhanTin);
			Language.GetValue(this.ckbBinhLuan);
			Language.GetValue(this.label4);
			Language.GetValue(this.label2);
			Language.GetValue(this.ckbCreateHTML);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00181E94 File Offset: 0x00180094
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.ckbNgaySinh.Checked = this.setting.GetValueBool("ckbNgaySinh", true);
				this.ckbAnhBanBe.Checked = this.setting.GetValueBool("ckbAnhBanBe", true);
				this.ckbBackupImageNangCao.Checked = this.setting.GetValueBool("ckbBackupImageNangCao", false);
				this.nudSoLuongAnh.Value = this.setting.GetValueInt("nudSoLuongAnh", 20);
				this.nudSoThang.Value = this.setting.GetValueInt("nudSoThang", 5);
				this.ckbNhanTin.Checked = this.setting.GetValueBool("ckbNhanTin", true);
				this.ckbBinhLuan.Checked = this.setting.GetValueBool("ckbBinhLuan", true);
				this.ckbCreateHTML.Checked = this.setting.GetValueBool("ckbCreateHTML", true);
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x001820C8 File Offset: 0x001802C8
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
				bool flag2 = !this.ckbNgaySinh.Checked && !this.ckbAnhBanBe.Checked && !this.ckbNhanTin.Checked && !this.ckbBinhLuan.Checked;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn cấu hình backup!"), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update("ckbNgaySinh", this.ckbNgaySinh.Checked);
					json_Settings.Update("ckbAnhBanBe", this.ckbAnhBanBe.Checked);
					json_Settings.Update("ckbBackupImageNangCao", this.ckbBackupImageNangCao.Checked);
					json_Settings.Update("nudSoLuongAnh", this.nudSoLuongAnh.Value);
					json_Settings.Update("ckbNhanTin", this.ckbNhanTin.Checked);
					json_Settings.Update("ckbBinhLuan", this.ckbBinhLuan.Checked);
					json_Settings.Update("nudSoThang", this.nudSoThang.Value);
					json_Settings.Update("ckbCreateHTML", this.ckbCreateHTML.Checked);
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
								fHDBackupData.isSave = true;
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
								fHDBackupData.isSave = true;
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

		// Token: 0x06000B1F RID: 2847 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x001824BC File Offset: 0x001806BC
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

		// Token: 0x06000B21 RID: 2849 RVA: 0x00182580 File Offset: 0x00180780
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbBinhLuan_CheckedChanged(null, null);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00054604 File Offset: 0x00052804
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x001825B8 File Offset: 0x001807B8
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbAnhBanBe.Checked;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x001825E8 File Offset: 0x001807E8
		private void ckbBinhLuan_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbBinhLuan.Checked;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00182618 File Offset: 0x00180818
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue("Nếu tích tùy chọn này thì sẽ backup được nhiều ảnh bạn bè hơn.") + "\r\n" + Language.GetValue("Đồng nghĩa với việc tốc độ backup sẽ chậm hơn!"), 1);
		}

		// Token: 0x040010D6 RID: 4310
		private JSON_Settings setting;

		// Token: 0x040010D7 RID: 4311
		private string id_KichBan;

		// Token: 0x040010D8 RID: 4312
		private string id_TuongTac;

		// Token: 0x040010D9 RID: 4313
		private string Id_HanhDong;

		// Token: 0x040010DA RID: 4314
		private int type;

		// Token: 0x040010DB RID: 4315
		public static bool isSave;
	}
}
