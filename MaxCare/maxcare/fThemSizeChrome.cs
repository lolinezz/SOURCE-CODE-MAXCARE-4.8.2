using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x020000E0 RID: 224
	public partial class fThemSizeChrome : Form
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x00003039 File Offset: 0x00001239
		public fThemSizeChrome()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00115CEC File Offset: 0x00113EEC
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.grDanhSach);
			Language.GetValue(this.label1);
			foreach (object obj in this.dtgvDanhSach.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnHuy);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00115DEC File Offset: 0x00113FEC
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			this.LoadDsFile();
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00115E08 File Offset: 0x00114008
		private void LoadContentFileFromDtgv(int row)
		{
			try
			{
				this.txtTen.Text = DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, "cName");
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, "cSize");
				this.txtPixelRatio.Text = ((DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, "cPixelRatio") == "") ? "0" : DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, "cPixelRatio"));
				this.nudWidth.Value = Convert.ToInt32(statusDataGridView.Split(new char[]
				{
					'x'
				})[0]);
				this.nudHeight.Value = Convert.ToInt32(statusDataGridView.Split(new char[]
				{
					'x'
				})[1]);
			}
			catch
			{
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00115FD0 File Offset: 0x001141D0
		private void LoadDsFile()
		{
			int num = -1;
			int rowCount = this.dtgvDanhSach.RowCount;
			int num2 = rowCount;
			if (num2 != 0)
			{
				if (num2 != 1)
				{
					num = this.dtgvDanhSach.SelectedRows[0].Index;
				}
				else
				{
					num = 0;
				}
			}
			this.dtgvDanhSach.Rows.Clear();
			JSON_Settings json_Settings = new JSON_Settings("configChrome", false);
			bool flag = json_Settings.GetValue("sizeChrome", "") != "";
			if (flag)
			{
				Dictionary<string, object> dictionary = JSON_Settings.ConvertToDictionary(JObject.Parse(json_Settings.GetValue("sizeChrome", "")));
				foreach (KeyValuePair<string, object> keyValuePair in dictionary)
				{
					bool flag2 = keyValuePair.Value.ToString().Split(new char[]
					{
						'x'
					}).Length == 3;
					if (flag2)
					{
						this.dtgvDanhSach.Rows.Add(new object[]
						{
							this.dtgvDanhSach.RowCount + 1,
							keyValuePair.Key,
							keyValuePair.Value.ToString().Substring(0, keyValuePair.Value.ToString().LastIndexOf('x')),
							keyValuePair.Value.ToString().Split(new char[]
							{
								'x'
							})[2],
							"Sửa",
							"Xóa"
						});
					}
					else
					{
						this.dtgvDanhSach.Rows.Add(new object[]
						{
							this.dtgvDanhSach.RowCount + 1,
							keyValuePair.Key,
							keyValuePair.Value.ToString().Substring(0, keyValuePair.Value.ToString().LastIndexOf('x')),
							"",
							"Sửa",
							"Xóa"
						});
					}
				}
				bool flag3 = num == -1 && this.dtgvDanhSach.RowCount > 0;
				if (flag3)
				{
					num = 0;
				}
				else
				{
					bool flag4 = num + 1 > this.dtgvDanhSach.RowCount;
					if (flag4)
					{
						num = this.dtgvDanhSach.RowCount - 1;
					}
				}
				bool flag5 = num == -1;
				if (flag5)
				{
					this.txtTen.Text = "";
					this.nudWidth.Value = 0m;
					this.nudHeight.Value = 0m;
				}
				else
				{
					MCommon.Common.ClearSelectedOnDatagridview(this.dtgvDanhSach);
					this.dtgvDanhSach.Rows[num].Selected = true;
					this.LoadContentFileFromDtgv(num);
				}
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00116494 File Offset: 0x00114694
		private void rControl(int type)
		{
			switch (type)
			{
			case 1:
				this.grDanhSach.Enabled = false;
				this.grChiTiet.Enabled = true;
				this.txtTen.Clear();
				this.txtTen.Focus();
				this.nudWidth.Value = 0m;
				this.nudHeight.Value = 0m;
				break;
			case 2:
				this.grDanhSach.Enabled = true;
				this.grChiTiet.Enabled = false;
				break;
			case 3:
				this.grDanhSach.Enabled = false;
				this.grChiTiet.Enabled = true;
				break;
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x001165B0 File Offset: 0x001147B0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.rControl(1);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x001165D0 File Offset: 0x001147D0
		private void dtgvDanhSach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			string name = this.dtgvDanhSach.Columns[e.ColumnIndex].Name;
			bool flag = name != "cSua" && name != "cXoa";
			if (flag)
			{
				this.dtgvDanhSach.Cursor = Cursors.Default;
			}
			else
			{
				bool flag2 = e.RowIndex < this.dtgvDanhSach.RowCount;
				if (flag2)
				{
					this.dtgvDanhSach.Cursor = Cursors.Hand;
				}
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x001166A8 File Offset: 0x001148A8
		private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0;
			if (flag)
			{
				string name = dataGridView.Columns[e.ColumnIndex].Name;
				string a = name;
				if (!(a == "cSua"))
				{
					if (a == "cXoa")
					{
						bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn xóa?")) == DialogResult.Yes;
						if (flag2)
						{
							JSON_Settings json_Settings = new JSON_Settings(new JSON_Settings("configChrome", false).GetValue("sizeChrome", ""), true);
							json_Settings.Remove(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, this.dtgvDanhSach.CurrentRow.Index, "cName"));
							JSON_Settings json_Settings2 = new JSON_Settings("configChrome", false);
							json_Settings2.Update("sizeChrome", json_Settings.GetFullString());
							json_Settings2.Save("");
							this.LoadDsFile();
						}
					}
				}
				else
				{
					this.rControl(3);
				}
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x001168CC File Offset: 0x00114ACC
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.txtTen.Text.Trim() == "";
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng điền tên thiết bị!"), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn lưu lại?")) == DialogResult.Yes;
					if (flag2)
					{
						JSON_Settings json_Settings = new JSON_Settings(new JSON_Settings("configChrome", false).GetValue("sizeChrome", ""), true);
						json_Settings.Update(this.txtTen.Text.Trim(), string.Concat(new string[]
						{
							this.nudWidth.Value.ToString(),
							"x",
							this.nudHeight.Value.ToString(),
							"x",
							this.txtPixelRatio.Text.Trim()
						}));
						JSON_Settings json_Settings2 = new JSON_Settings("configChrome", false);
						json_Settings2.Update("sizeChrome", json_Settings.GetFullString());
						json_Settings2.Save("");
						this.LoadDsFile();
						this.rControl(2);
					}
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00116B58 File Offset: 0x00114D58
		private void btnHuy_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn hủy?")) == DialogResult.Yes;
				if (flag)
				{
					this.rControl(2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00116BD0 File Offset: 0x00114DD0
		private void dtgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.LoadContentFileFromDtgv(this.dtgvDanhSach.CurrentRow.Index);
		}

		// Token: 0x04000C7D RID: 3197
		private Random rd = new Random();

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
