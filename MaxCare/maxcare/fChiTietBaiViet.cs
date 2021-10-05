using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008F RID: 143
	public partial class fChiTietBaiViet : Form
	{
		// Token: 0x06000550 RID: 1360 RVA: 0x00074F1C File Offset: 0x0007311C
		public fChiTietBaiViet(int idBaiviet)
		{
			this.InitializeComponent();
			List<BaiViet> listBaiVietByID = CommonSQL.GetListBaiVietByID(idBaiviet.ToString());
			foreach (BaiViet baiViet in listBaiVietByID)
			{
				this.txtChuDe.Text = baiViet.tenChuDe;
				this.txtName.Text = baiViet.tieuDe;
				this.txtConten.Text = baiViet.noiDung;
				string[] array = baiViet.anh.Split(new char[]
				{
					'|'
				});
				this.lblNanh.Text = "Ảnh (" + (array.Length - 1).ToString() + "):";
				string[] array2 = baiViet.video.Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < array.Length - 1; i++)
				{
					this.dgvPic.Rows.Add(new object[]
					{
						array[i]
					});
				}
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00054604 File Offset: 0x00052804
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00075090 File Offset: 0x00073290
		private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				Process.Start(this.dgvPic.SelectedRows[0].Cells[0].Value.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show("Link ảnh không tồn tại", "Lỗi");
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00054604 File Offset: 0x00052804
		private void LblVideo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00054604 File Offset: 0x00052804
		private void DgvVideo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00054604 File Offset: 0x00052804
		private void DgvPic_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
