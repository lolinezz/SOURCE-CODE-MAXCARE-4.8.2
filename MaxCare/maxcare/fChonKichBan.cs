using System;
using System.Collections.Generic;
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
	// Token: 0x020000E7 RID: 231
	public partial class fChonKichBan : Form
	{
		// Token: 0x06000947 RID: 2375 RVA: 0x000030CC File Offset: 0x000012CC
		public fChonKichBan()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings("configInteractGeneral", false);
			this.ChangeLanguage();
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x001260AC File Offset: 0x001242AC
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label2);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.label1);
			Language.GetValue(this.label7);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnCancel);
			foreach (object obj in this.dtgvKichBan.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			foreach (object obj2 in this.dtgvKichBanChoose.Columns)
			{
				DataGridViewColumn control2 = (DataGridViewColumn)obj2;
				Language.GetValue(control2);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00126214 File Offset: 0x00124414
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			this.LoadKichBan(null);
			this.LoadKichBan(this.settings.GetValueList("lstIdKichBan", 0));
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00126268 File Offset: 0x00124468
		private void LoadKichBan(List<string> lstIdKichBan = null)
		{
			try
			{
				bool flag = lstIdKichBan != null && lstIdKichBan.Count > 0;
				if (flag)
				{
					this.dtgvKichBanChoose.Rows.Clear();
					for (int i = 0; i < lstIdKichBan.Count; i++)
					{
						DataTable kichBanById = InteractSQL.GetKichBanById(lstIdKichBan[i]);
						bool flag2 = kichBanById.Rows.Count > 0;
						if (flag2)
						{
							DataRow dataRow = kichBanById.Rows[0];
							this.dtgvKichBanChoose.Rows.Add(new object[]
							{
								this.dtgvKichBanChoose.RowCount + 1,
								dataRow["Id_KichBan"],
								dataRow["TenKichBan"]
							});
						}
					}
				}
				else
				{
					this.dtgvKichBan.Rows.Clear();
					DataTable allKichBan = InteractSQL.GetAllKichBan();
					bool flag3 = allKichBan.Rows.Count > 0;
					if (flag3)
					{
						for (int j = 0; j < allKichBan.Rows.Count; j++)
						{
							DataRow dataRow2 = allKichBan.Rows[j];
							this.dtgvKichBan.Rows.Add(new object[]
							{
								j + 1,
								dataRow2["Id_KichBan"],
								dataRow2["TenKichBan"]
							});
						}
					}
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00126500 File Offset: 0x00124700
		public void DoiChoDgv(ref DataGridView dgv, int oldRow, int newRow)
		{
			for (int i = 1; i < dgv.Columns.Count; i++)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(dgv, oldRow, i);
				DatagridviewHelper.SetStatusDataGridView(dgv, oldRow, i, DatagridviewHelper.GetStatusDataGridView(dgv, newRow, i));
				DatagridviewHelper.SetStatusDataGridView(dgv, newRow, i, statusDataGridView);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00126570 File Offset: 0x00124770
		private void button2_Click(object sender, EventArgs e)
		{
			int index = this.dtgvKichBanChoose.SelectedRows[0].Index;
			bool flag = index == 0;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index - 1, "cIdKichBanChoose");
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index, "cIdKichBanChoose");
				bool flag2 = statusDataGridView + statusDataGridView2 != "";
				if (flag2)
				{
					this.DoiChoDgv(ref this.dtgvKichBanChoose, index, index - 1);
					this.dtgvKichBanChoose.Rows[index - 1].Selected = true;
				}
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00126678 File Offset: 0x00124878
		private void button3_Click(object sender, EventArgs e)
		{
			int index = this.dtgvKichBanChoose.SelectedRows[0].Index;
			bool flag = index == this.dtgvKichBanChoose.RowCount - 1;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index + 1, "cIdKichBanChoose");
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index, "cIdKichBanChoose");
				bool flag2 = statusDataGridView + statusDataGridView2 != "";
				if (flag2)
				{
					this.DoiChoDgv(ref this.dtgvKichBanChoose, index, index + 1);
					this.dtgvKichBanChoose.Rows[index + 1].Selected = true;
				}
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00126794 File Offset: 0x00124994
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

		// Token: 0x06000950 RID: 2384 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00126858 File Offset: 0x00124A58
		private bool CheckTrung(string id)
		{
			bool result = false;
			for (int i = 0; i < this.dtgvKichBanChoose.RowCount; i++)
			{
				bool flag = id == this.dtgvKichBanChoose.Rows[i].Cells[1].Value.ToString();
				if (flag)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x001268F4 File Offset: 0x00124AF4
		private void dtgvKichBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int num = Convert.ToInt32(this.dtgvKichBan.SelectedRows[0].Cells[1].Value);
			string text = this.dtgvKichBan.SelectedRows[0].Cells[2].Value.ToString();
			bool flag = !this.CheckTrung(num.ToString());
			if (flag)
			{
				this.dtgvKichBanChoose.Rows.Add(new object[]
				{
					this.dtgvKichBanChoose.RowCount + 1,
					num,
					text
				});
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x001269E4 File Offset: 0x00124BE4
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.dtgvKichBanChoose.Rows.RemoveAt(this.dtgvKichBanChoose.SelectedRows[0].Index);
			for (int i = 0; i < this.dtgvKichBanChoose.RowCount; i++)
			{
				DatagridviewHelper.SetStatusDataGridView(this.dtgvKichBanChoose, i, "cSTTChoose", i + 1);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00126A88 File Offset: 0x00124C88
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.dtgvKichBanChoose.RowCount; i++)
				{
					list.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, i, "cIdKichBanChoose"));
				}
				this.settings.Update("lstIdKichBan", list);
				this.settings.Save("");
				base.Close();
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 3);
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00126BBC File Offset: 0x00124DBC
		private void dtgvKichBanChoose_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.lblCountAcc.Text = this.dtgvKichBanChoose.RowCount.ToString();
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00126BBC File Offset: 0x00124DBC
		private void dtgvKichBanChoose_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.lblCountAcc.Text = this.dtgvKichBanChoose.RowCount.ToString();
		}

		// Token: 0x04000D2A RID: 3370
		private JSON_Settings settings;
	}
}
