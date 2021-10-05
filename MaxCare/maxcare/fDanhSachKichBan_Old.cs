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
	// Token: 0x020000FA RID: 250
	public partial class fDanhSachKichBan_Old : Form
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x0014EA8C File Offset: 0x0014CC8C
		public fDanhSachKichBan_Old(string kickBan)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.kichBan = kickBan;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0014EAD8 File Offset: 0x0014CCD8
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox1);
			foreach (object obj in this.dtgvKichBan.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.groupBox2);
			foreach (object obj2 in this.dtgvHanhDong.Columns)
			{
				DataGridViewColumn control2 = (DataGridViewColumn)obj2;
				Language.GetValue(control2);
			}
			Language.GetValue(this.thêmMớiToolStripMenuItem);
			Language.GetValue(this.sửaToolStripMenuItem);
			Language.GetValue(this.xóaToolStripMenuItem);
			Language.GetValue(this.nhânBảnToolStripMenuItem);
			Language.GetValue(this.toolStripMenuItem1);
			Language.GetValue(this.toolStripMenuItem3);
			Language.GetValue(this.toolStripMenuItem4);
			Language.GetValue(this.toolStripMenuItem2);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0014EC74 File Offset: 0x0014CE74
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			this.LoadKichBan(this.kichBan);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0014EC9C File Offset: 0x0014CE9C
		private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SuaKichBan();
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0014ECB8 File Offset: 0x0014CEB8
		private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.XoaKichBan();
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0014ECD4 File Offset: 0x0014CED4
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.XoaHanhDong();
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00126500 File Offset: 0x00124700
		public void DoiChoDgv(ref DataGridView dgv, int oldRow, int newRow)
		{
			for (int i = 1; i < dgv.Columns.Count; i++)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dgv, oldRow, i);
				DatagridviewHelper.SetStatusDataGridView(dgv, oldRow, i, DatagridviewHelper.GetStatusDataGridView(dgv, newRow, i));
				DatagridviewHelper.SetStatusDataGridView(dgv, newRow, i, statusDataGridView);
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0014ECF0 File Offset: 0x0014CEF0
		private void button2_Click(object sender, EventArgs e)
		{
			int index = this.dtgvHanhDong.SelectedRows[0].Index;
			bool flag = index == 0;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index - 1, "cId_HanhDong");
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index, "cId_HanhDong");
				bool flag2 = statusDataGridView + statusDataGridView2 != "";
				if (flag2)
				{
					bool flag3 = InteractSQL.UpdateThuTuHanhDong(statusDataGridView, statusDataGridView2);
					bool flag4 = flag3;
					if (flag4)
					{
						this.DoiChoDgv(ref this.dtgvHanhDong, index, index - 1);
						this.dtgvHanhDong.Rows[index - 1].Selected = true;
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
					}
				}
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0014EE3C File Offset: 0x0014D03C
		private void button3_Click(object sender, EventArgs e)
		{
			int index = this.dtgvHanhDong.SelectedRows[0].Index;
			bool flag = index == this.dtgvHanhDong.RowCount - 1;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index + 1, "cId_HanhDong");
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index, "cId_HanhDong");
				bool flag2 = statusDataGridView + statusDataGridView2 != "";
				if (flag2)
				{
					bool flag3 = InteractSQL.UpdateThuTuHanhDong(statusDataGridView, statusDataGridView2);
					bool flag4 = flag3;
					if (flag4)
					{
						this.DoiChoDgv(ref this.dtgvHanhDong, index, index + 1);
						this.dtgvHanhDong.Rows[index + 1].Selected = true;
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
					}
				}
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0014EF98 File Offset: 0x0014D198
		private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ThemKichBan();
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0014EFB4 File Offset: 0x0014D1B4
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.ThemHanhDong();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0014EFD0 File Offset: 0x0014D1D0
		private void nhânBảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.NhanBanKichBan();
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0014EFEC File Offset: 0x0014D1EC
		private void dtgvKichBan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex > -1;
			if (flag)
			{
				this.LoadHanhDong();
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0014F024 File Offset: 0x0014D224
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.SuaHanhDong();
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0014F040 File Offset: 0x0014D240
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.NhanBanHanhDong();
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0014F05C File Offset: 0x0014D25C
		private void dtgvHanhDong_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			Keys keys = keyCode;
			if (keys <= Keys.Delete)
			{
				if (keys != Keys.Insert)
				{
					if (keys != Keys.Delete)
					{
						return;
					}
					this.XoaHanhDong();
					return;
				}
			}
			else
			{
				if (keys == Keys.D)
				{
					bool flag = e.Modifiers == Keys.Control;
					if (flag)
					{
						this.NhanBanHanhDong();
					}
					return;
				}
				switch (keys)
				{
				case Keys.F1:
					break;
				case Keys.F2:
					this.SuaHanhDong();
					return;
				case Keys.F3:
				case Keys.F4:
					return;
				case Keys.F5:
					this.LoadHanhDong();
					return;
				default:
					return;
				}
			}
			this.ThemHanhDong();
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0014F14C File Offset: 0x0014D34C
		private void NhanBanHanhDong()
		{
			try
			{
				bool flag = this.dtgvHanhDong.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox("Vui lòng thêm hành động trước!", 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvHanhDong.SelectedRows[0];
					string id_HanhDong = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
					string str = dataGridViewRow.Cells["cTenHanhDong"].Value.ToString();
					string text = str + " - Copy";
					int num = 2;
					while (InteractSQL.CheckExistTenHanhDong(text))
					{
						text = str + string.Format(" - Copy ({0})", num++);
					}
					bool flag2 = InteractSQL.DuplicateHanhDong(id_HanhDong, text);
					if (flag2)
					{
						DataTable hanhDongMoi = InteractSQL.GetHanhDongMoi();
						this.dtgvHanhDong.Rows.Add(new object[]
						{
							this.dtgvHanhDong.RowCount + 1,
							hanhDongMoi.Rows[0]["Id_HanhDong"],
							hanhDongMoi.Rows[0]["TenHanhDong"],
							hanhDongMoi.Rows[0]["MoTa"]
						});
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0014F3D0 File Offset: 0x0014D5D0
		private void LoadHanhDong()
		{
			try
			{
				this.dtgvHanhDong.Rows.Clear();
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (!flag)
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string idKichBan = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
					DataTable allHanhDongByKichBan = InteractSQL.GetAllHanhDongByKichBan(idKichBan);
					for (int i = 0; i < allHanhDongByKichBan.Rows.Count; i++)
					{
						this.dtgvHanhDong.Rows.Add(new object[]
						{
							this.dtgvHanhDong.RowCount + 1,
							allHanhDongByKichBan.Rows[i]["Id_HanhDong"],
							allHanhDongByKichBan.Rows[i]["TenHanhDong"],
							allHanhDongByKichBan.Rows[i]["MoTa"]
						});
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0014F598 File Offset: 0x0014D798
		private void XoaHanhDong()
		{
			try
			{
				bool flag = this.dtgvHanhDong.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thêm hành động trước!"), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có chắc muốn xóa hoạt động này?")) == DialogResult.Yes;
					if (flag2)
					{
						DataGridViewRow dataGridViewRow = this.dtgvHanhDong.SelectedRows[0];
						bool flag3 = InteractSQL.DeleteHanhDongByIdHanhDong(dataGridViewRow.Cells["cId_HanhDong"].Value.ToString());
						if (flag3)
						{
							int index = dataGridViewRow.Index;
							for (int i = index; i < this.dtgvHanhDong.Rows.Count - 1; i++)
							{
								this.DoiChoDgv(ref this.dtgvHanhDong, i, i + 1);
							}
							this.dtgvHanhDong.Rows.RemoveAt(this.dtgvHanhDong.Rows.Count - 1);
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0014F7B0 File Offset: 0x0014D9B0
		private void ThemHanhDong()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
					int count = InteractSQL.GetAllHanhDongByKichBan(text).Rows.Count;
					MCommon.Common.ShowForm(new fThemHanhDong(text));
					DataTable allHanhDongByKichBan = InteractSQL.GetAllHanhDongByKichBan(text);
					int count2 = allHanhDongByKichBan.Rows.Count;
					bool flag2 = count2 > count;
					if (flag2)
					{
						this.dtgvHanhDong.Rows.Add(new object[]
						{
							this.dtgvHanhDong.RowCount + 1,
							allHanhDongByKichBan.Rows[count2 - 1]["Id_HanhDong"],
							allHanhDongByKichBan.Rows[count2 - 1]["TenHanhDong"],
							allHanhDongByKichBan.Rows[count2 - 1]["MoTa"]
						});
					}
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0014F9E8 File Offset: 0x0014DBE8
		private void SuaHanhDong()
		{
			try
			{
				bool flag = this.dtgvHanhDong.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thêm hành động trước!"), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvHanhDong.SelectedRows[0];
					string text = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
					DataTable hanhDongById = InteractSQL.GetHanhDongById(text);
					string str = "maxcare.f";
					object obj = hanhDongById.Rows[0]["TenTuongTac"];
					string name = str + ((obj != null) ? obj.ToString() : null);
					Form formByName = MCommon.Common.GetFormByName(name, text);
					bool flag2 = formByName != null;
					if (flag2)
					{
						MCommon.Common.ShowForm(formByName);
					}
					hanhDongById = InteractSQL.GetHanhDongById(text);
					DatagridviewHelper.SetStatusDataGridView(this.dtgvHanhDong, dataGridViewRow.Index, "cTenHanhDong", hanhDongById.Rows[0]["TenHanhDong"].ToString());
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0014FBE0 File Offset: 0x0014DDE0
		private void dtgvKichBan_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			Keys keys = keyCode;
			if (keys <= Keys.Delete)
			{
				if (keys != Keys.Insert)
				{
					if (keys != Keys.Delete)
					{
						return;
					}
					this.XoaKichBan();
					return;
				}
			}
			else
			{
				if (keys == Keys.D)
				{
					bool flag = e.Modifiers == Keys.Control;
					if (flag)
					{
						this.NhanBanKichBan();
					}
					return;
				}
				switch (keys)
				{
				case Keys.F1:
					break;
				case Keys.F2:
					this.SuaKichBan();
					return;
				case Keys.F3:
				case Keys.F4:
					return;
				case Keys.F5:
					this.LoadKichBan("");
					return;
				default:
					return;
				}
			}
			this.ThemKichBan();
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0014FCE4 File Offset: 0x0014DEE4
		private void LoadKichBan(string kichBan = "")
		{
			try
			{
				this.dtgvKichBan.Rows.Clear();
				DataTable allKichBan = InteractSQL.GetAllKichBan();
				bool flag = allKichBan.Rows.Count > 0;
				if (flag)
				{
					for (int i = 0; i < allKichBan.Rows.Count; i++)
					{
						DataRow dataRow = allKichBan.Rows[i];
						this.dtgvKichBan.Rows.Add(new object[]
						{
							i + 1,
							dataRow["Id_KichBan"],
							dataRow["TenKichBan"]
						});
					}
				}
				bool flag2 = kichBan != "";
				if (flag2)
				{
					for (int j = 0; j < this.dtgvKichBan.RowCount; j++)
					{
						bool flag3 = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBan, j, "cId_KichBan") == kichBan;
						if (flag3)
						{
							this.dtgvKichBan.Rows[j].Selected = true;
							break;
						}
					}
				}
				this.LoadHanhDong();
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0014FEFC File Offset: 0x0014E0FC
		private void XoaKichBan()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có chắc muốn xóa kịch bản này?")) == DialogResult.Yes;
					if (flag2)
					{
						DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
						bool flag3 = InteractSQL.DeleteKichBan(dataGridViewRow.Cells["cId_KichBan"].Value.ToString());
						if (flag3)
						{
							int index = dataGridViewRow.Index;
							for (int i = index; i < this.dtgvKichBan.Rows.Count - 1; i++)
							{
								this.DoiChoDgv(ref this.dtgvKichBan, i, i + 1);
							}
							this.dtgvKichBan.Rows.RemoveAt(this.dtgvKichBan.Rows.Count - 1);
							this.LoadHanhDong();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00150120 File Offset: 0x0014E320
		private void SuaKichBan()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string id = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
					MCommon.Common.ShowForm(new fThemKichBan(1, id));
					string status = InteractSQL.GetKichBanById(id).Rows[0]["TenKichBan"].ToString();
					DatagridviewHelper.SetStatusDataGridView(this.dtgvKichBan, dataGridViewRow.Index, "cTenKichBan", status);
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x001502AC File Offset: 0x0014E4AC
		private void ThemKichBan()
		{
			try
			{
				string a = "";
				try
				{
					a = InteractSQL.GetKichBanMoi().Rows[0]["Id_KichBan"].ToString();
				}
				catch
				{
				}
				MCommon.Common.ShowForm(new fThemKichBan(0, ""));
				DataTable kichBanMoi = InteractSQL.GetKichBanMoi();
				string b = "";
				try
				{
					b = kichBanMoi.Rows[0]["Id_KichBan"].ToString();
				}
				catch
				{
				}
				bool flag = a != b;
				if (flag)
				{
					this.dtgvKichBan.Rows.Add(new object[]
					{
						this.dtgvKichBan.RowCount + 1,
						kichBanMoi.Rows[0]["Id_KichBan"],
						kichBanMoi.Rows[0]["TenKichBan"]
					});
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00150504 File Offset: 0x0014E704
		private void NhanBanKichBan()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string id_KichBanCu = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
					string str = dataGridViewRow.Cells["cTenKichBan"].Value.ToString();
					string text = str + " - Copy";
					int num = 2;
					while (InteractSQL.CheckExistTenKichBan(text))
					{
						text = str + string.Format(" - Copy ({0})", num++);
					}
					bool flag2 = InteractSQL.DuplicateKichBan(id_KichBanCu, text);
					if (flag2)
					{
						DataTable kichBanMoi = InteractSQL.GetKichBanMoi();
						this.dtgvKichBan.Rows.Add(new object[]
						{
							this.dtgvKichBan.RowCount + 1,
							kichBanMoi.Rows[0]["Id_KichBan"],
							kichBanMoi.Rows[0]["TenKichBan"]
						});
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00150758 File Offset: 0x0014E958
		private void dtgvKichBan_KeyUp(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			Keys keys = keyCode;
			if (keys == Keys.Up || keys == Keys.Down)
			{
				this.LoadHanhDong();
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00054604 File Offset: 0x00052804
		private void fDanhSachKichBan_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x001507AC File Offset: 0x0014E9AC
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

		// Token: 0x04000E72 RID: 3698
		private string kichBan = "";

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
