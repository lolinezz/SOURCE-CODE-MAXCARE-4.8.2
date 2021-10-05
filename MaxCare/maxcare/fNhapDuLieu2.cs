using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000F3 RID: 243
	public partial class fNhapDuLieu2 : Form
	{
		// Token: 0x060009DA RID: 2522 RVA: 0x001478C8 File Offset: 0x00145AC8
		public fNhapDuLieu2(string linkPathFolder, string title)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.linkPathFolder = linkPathFolder;
			this.lblTitle.Text = title;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00147934 File Offset: 0x00145B34
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.groupBox2);
			foreach (object obj in this.dtgvDanhSach.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnHuy);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00147A14 File Offset: 0x00145C14
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			MCommon.Common.CreateFolder(this.linkPathFolder);
			this.LoadDsFile(this.linkPathFolder);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00147A4C File Offset: 0x00145C4C
		private void LoadContentFileFromDtgv(int row)
		{
			this.txtContent.Lines = File.ReadAllLines(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, "cName"));
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00147A9C File Offset: 0x00145C9C
		private void LoadDsFile(string linkPathFolder)
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
			List<string> list = Directory.GetFiles(linkPathFolder).ToList<string>();
			for (int i = 0; i < list.Count; i++)
			{
				this.dtgvDanhSach.Rows.Add(new object[]
				{
					i + 1,
					list[i],
					Language.GetValue("Chi tiết"),
					Language.GetValue("Sửa"),
					Language.GetValue("Xóa")
				});
			}
			bool flag = num == -1 && this.dtgvDanhSach.RowCount > 0;
			if (flag)
			{
				num = 0;
			}
			else
			{
				bool flag2 = num + 1 > this.dtgvDanhSach.RowCount;
				if (flag2)
				{
					num = this.dtgvDanhSach.RowCount - 1;
				}
			}
			bool flag3 = num == -1;
			if (flag3)
			{
				this.txtContent.Text = "";
			}
			else
			{
				MCommon.Common.ClearSelectedOnDatagridview(this.dtgvDanhSach);
				this.dtgvDanhSach.Rows[num].Selected = true;
				this.LoadContentFileFromDtgv(num);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00147D04 File Offset: 0x00145F04
		private void rControl(int type)
		{
			bool flag = type == 1;
			if (flag)
			{
				this.dtgvDanhSach.Enabled = false;
				this.btnAdd.Enabled = false;
				this.btnSave.Enabled = true;
				this.btnHuy.Enabled = true;
				this.txtContent.ReadOnly = false;
				this.txtContent.Focus();
			}
			else
			{
				this.dtgvDanhSach.Enabled = true;
				this.btnAdd.Enabled = true;
				this.btnSave.Enabled = false;
				this.btnHuy.Enabled = false;
				this.txtContent.ReadOnly = true;
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00147E1C File Offset: 0x0014601C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string text;
				bool flag;
				do
				{
					text = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + MCommon.Common.CreateRandomString(3, this.rd) + ".txt";
					flag = File.Exists(text);
				}
				while (flag);
				string text2 = this.linkPathFolder + "\\" + text;
				MCommon.Common.CreateFile(text2);
				this.txtContent.Lines = File.ReadAllLines(text2);
				this.dtgvDanhSach.Rows.Add(new object[]
				{
					this.dtgvDanhSach.RowCount + 1,
					text2,
					Language.GetValue("Chi tiết"),
					Language.GetValue("Sửa"),
					Language.GetValue("Xóa")
				});
				MCommon.Common.ClearSelectedOnDatagridview(this.dtgvDanhSach);
				this.dtgvDanhSach.Rows[this.dtgvDanhSach.RowCount - 1].Selected = true;
				this.rControl(1);
				this.isAdd = true;
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00054604 File Offset: 0x00052804
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00054604 File Offset: 0x00052804
		private void dtgvDanhSach_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0014805C File Offset: 0x0014625C
		private void dtgvDanhSach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			string name = this.dtgvDanhSach.Columns[e.ColumnIndex].Name;
			bool flag = name != "cChiTiet" && name != "cSua" && name != "cXoa";
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

		// Token: 0x060009E6 RID: 2534 RVA: 0x00148154 File Offset: 0x00146354
		private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0;
			if (flag)
			{
				string name = dataGridView.Columns[e.ColumnIndex].Name;
				string a = name;
				if (!(a == "cChiTiet"))
				{
					if (!(a == "cSua"))
					{
						if (a == "cXoa")
						{
							bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn xóa?")) == DialogResult.Yes;
							if (flag2)
							{
								File.Delete(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, e.RowIndex, "cName"));
								this.LoadDsFile(this.linkPathFolder);
							}
						}
					}
					else
					{
						this.txtContent.Lines = File.ReadAllLines(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, e.RowIndex, "cName"));
						this.isAdd = false;
						this.rControl(1);
					}
				}
				else
				{
					this.LoadContentFileFromDtgv(e.RowIndex);
				}
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00148350 File Offset: 0x00146550
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.dtgvDanhSach.SelectedRows[0].Cells["cName"].Value.ToString();
				MCommon.Common.CreateFile(text);
				bool flag = this.txtContent.Text.Trim() == "";
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập nội dung cần lưu!"), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn lưu lại?")) == DialogResult.Yes;
					if (flag2)
					{
						File.WriteAllLines(text, this.txtContent.Lines);
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Lưu thành công!"), 1);
						this.rControl(2);
					}
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x001484E0 File Offset: 0x001466E0
		private void btnHuy_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.dtgvDanhSach.SelectedRows[0].Cells["cName"].Value.ToString();
				MCommon.Common.CreateFile(text);
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue("Bạn có muốn hủy?")) == DialogResult.Yes;
				if (flag)
				{
					bool flag2 = this.isAdd;
					if (flag2)
					{
						File.Delete(text);
					}
					this.rControl(2);
					this.LoadDsFile(this.linkPathFolder);
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
			}
		}

		// Token: 0x04000E27 RID: 3623
		private string linkPathFolder = "";

		// Token: 0x04000E28 RID: 3624
		private Random rd = new Random();

		// Token: 0x04000E29 RID: 3625
		private bool isAdd = false;
	}
}
