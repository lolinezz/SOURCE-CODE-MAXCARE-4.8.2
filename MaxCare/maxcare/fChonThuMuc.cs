using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008B RID: 139
	public partial class fChonThuMuc : Form
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00002B06 File Offset: 0x00000D06
		public fChonThuMuc(bool isFromBin = false)
		{
			this.InitializeComponent();
			fChonThuMuc.isAdd = false;
			this.isFromBin = isFromBin;
			this.ChangeLanguage();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0006E438 File Offset: 0x0006C638
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			foreach (object obj in this.dtgvAcc.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0006E518 File Offset: 0x0006C718
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			fChonThuMuc.isAdd = true;
			bool flag = this.isFromBin;
			if (flag)
			{
				fChonThuMuc.lstChooseIdFilesFromBin = new List<string>();
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
					if (flag2)
					{
						fChonThuMuc.lstChooseIdFilesFromBin.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, "cId"));
					}
				}
				bool flag3 = fChonThuMuc.lstChooseIdFilesFromBin.Count == 0;
				if (flag3)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
					return;
				}
			}
			else
			{
				fChonThuMuc.lstChooseIdFiles = new List<string>();
				for (int j = 0; j < this.dtgvAcc.Rows.Count; j++)
				{
					bool flag4 = Convert.ToBoolean(this.dtgvAcc.Rows[j].Cells["cChose"].Value);
					if (flag4)
					{
						fChonThuMuc.lstChooseIdFiles.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, "cId"));
					}
				}
				bool flag5 = fChonThuMuc.lstChooseIdFiles.Count == 0;
				if (flag5)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
					return;
				}
			}
			base.Close();
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0006E758 File Offset: 0x0006C958
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			bool flag = this.isFromBin;
			if (flag)
			{
				bool flag2 = fChonThuMuc.lstChooseIdFilesFromBin == null;
				if (flag2)
				{
					fChonThuMuc.lstChooseIdFilesFromBin = new List<string>();
				}
				this.LoadListFiles(fChonThuMuc.lstChooseIdFilesFromBin);
			}
			else
			{
				bool flag3 = fChonThuMuc.lstChooseIdFiles == null;
				if (flag3)
				{
					fChonThuMuc.lstChooseIdFiles = new List<string>();
				}
				this.LoadListFiles(fChonThuMuc.lstChooseIdFiles);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0006E7D8 File Offset: 0x0006C9D8
		private void LoadListFiles(List<string> lstIdFile = null)
		{
			try
			{
				bool flag = this.isFromBin;
				DataTable dataTable;
				if (flag)
				{
					dataTable = CommonSQL.GetAllFilesFromDatabaseForBin(false);
				}
				else
				{
					dataTable = CommonSQL.GetAllFilesFromDatabase(false);
				}
				bool flag2 = lstIdFile != null && lstIdFile.Count > 0;
				if (flag2)
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						bool flag3 = lstIdFile.Contains(dataTable.Rows[i]["id"].ToString());
						if (flag3)
						{
							this.dtgvAcc.Rows.Add(new object[]
							{
								true,
								i + 1,
								dataTable.Rows[i]["id"],
								dataTable.Rows[i]["name"]
							});
						}
						else
						{
							this.dtgvAcc.Rows.Add(new object[]
							{
								false,
								i + 1,
								dataTable.Rows[i]["id"],
								dataTable.Rows[i]["name"]
							});
						}
					}
				}
				else
				{
					for (int j = 0; j < dataTable.Rows.Count; j++)
					{
						this.dtgvAcc.Rows.Add(new object[]
						{
							false,
							j + 1,
							dataTable.Rows[j]["id"],
							dataTable.Rows[j]["name"]
						});
					}
				}
				this.UpdateSelectCountRecord();
				this.UpdateTotalCountRecord();
				bool flag4 = this.CountSelectRow() == this.dtgvAcc.RowCount;
				if (flag4)
				{
					this.checkBox1.Checked = true;
				}
				else
				{
					this.checkBox1.Checked = false;
				}
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(ex, "LoadListFiles");
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0006EBAC File Offset: 0x0006CDAC
		private void UpdateSelectCountRecord()
		{
			try
			{
				this.lblCountChoose.Text = this.CountSelectRow().ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0006EC08 File Offset: 0x0006CE08
		private void DtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.ColumnIndex == 0;
			if (flag)
			{
				this.UpdateSelectCountRecord();
				bool flag2 = this.CountSelectRow() == this.dtgvAcc.RowCount;
				if (flag2)
				{
					this.checkBox1.Checked = true;
				}
				else
				{
					this.checkBox1.Checked = false;
				}
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0006EC94 File Offset: 0x0006CE94
		private void UpdateTotalCountRecord()
		{
			try
			{
				this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0006ECFC File Offset: 0x0006CEFC
		private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
				if (flag)
				{
					this.dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
				}
				else
				{
					this.dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0006EDF8 File Offset: 0x0006CFF8
		private int CountSelectRow()
		{
			int num = 0;
			for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
			{
				bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
				if (flag)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0006EE98 File Offset: 0x0006D098
		private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.ColumnIndex == 0;
			if (flag)
			{
				try
				{
					bool flag2 = Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
					if (flag2)
					{
						this.dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
					}
					else
					{
						this.dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0006EFB0 File Offset: 0x0006D1B0
		private void checkBox1_Click(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, i, "cChose", true);
				}
			}
			else
			{
				for (int j = 0; j < this.dtgvAcc.Rows.Count; j++)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, j, "cChose", false);
				}
			}
		}

		// Token: 0x0400042E RID: 1070
		private bool isFromBin = false;

		// Token: 0x0400042F RID: 1071
		public static List<string> lstChooseIdFiles;

		// Token: 0x04000430 RID: 1072
		public static List<string> lstChooseIdFilesFromBin;

		// Token: 0x04000431 RID: 1073
		public static bool isAdd;
	}
}
