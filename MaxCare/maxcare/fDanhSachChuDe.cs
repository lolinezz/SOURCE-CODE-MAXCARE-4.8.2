using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x02000091 RID: 145
	public partial class fDanhSachChuDe : Form
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x00002B39 File Offset: 0x00000D39
		public fDanhSachChuDe()
		{
			this.InitializeComponent();
			this.LoadcbbChuDe();
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0007AB18 File Offset: 0x00078D18
		private void LoadcbbChuDe()
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			for (int i = 0; i < listChuDe.Count; i++)
			{
				this.dgvChuDe.Rows.Add(new object[]
				{
					i + 1,
					listChuDe[i]
				});
			}
			this.lblCountChuDe.Text = listChuDe.Count<string>().ToString();
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0007ABB4 File Offset: 0x00078DB4
		private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fThemChuDe());
			this.dgvChuDe.Rows.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0007ABF0 File Offset: 0x00078DF0
		private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string oldChude = this.dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
			MCommon.Common.ShowForm(new fSuaChuDe(oldChude));
			this.dgvChuDe.Rows.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00054604 File Offset: 0x00052804
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00054604 File Offset: 0x00052804
		private void lblCountChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00054604 File Offset: 0x00052804
		private void btnThem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00054604 File Offset: 0x00052804
		private void btnSua_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00054604 File Offset: 0x00052804
		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0007AC60 File Offset: 0x00078E60
		private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = MessageBox.Show("Bạn có muốn xóa chủ đề này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
			if (flag)
			{
				string text = this.dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
				CommonSQL.DeleteChuDe(text);
				CommonSQL.DeleteBaiVietByChuDe(text);
				this.dgvChuDe.Rows.Clear();
				this.LoadcbbChuDe();
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0007AD1C File Offset: 0x00078F1C
		private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.dgvChuDe.Rows.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00054604 File Offset: 0x00052804
		private void dgvChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00054604 File Offset: 0x00052804
		private void dgvChuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00054604 File Offset: 0x00052804
		private void fDanhSachChuDe_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00054604 File Offset: 0x00052804
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
