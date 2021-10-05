using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000094 RID: 148
	public partial class fThemBaiViet : Form
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x00002B7D File Offset: 0x00000D7D
		public fThemBaiViet(int cbbChuDeSlectedIndex)
		{
			this.InitializeComponent();
			this.LoadcbbChuDe();
			this.cbbChuDe.SelectedIndex = cbbChuDeSlectedIndex;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00080C28 File Offset: 0x0007EE28
		private void LoadcbbChuDe()
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			for (int i = 0; i < listChuDe.Count; i++)
			{
				this.cbbChuDe.Items.Add(listChuDe[i]);
			}
			try
			{
				this.cbbChuDe.SelectedIndex = 0;
			}
			catch
			{
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00080CC0 File Offset: 0x0007EEC0
		private void metroButton1_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fDanhSachChuDe());
			this.cbbChuDe.Items.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00080CFC File Offset: 0x0007EEFC
		private void btnAddLink_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
			openFileDialog.FilterIndex = 0;
			openFileDialog.Multiselect = true;
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string[] fileNames = openFileDialog.FileNames;
				for (int i = 0; i < fileNames.Length; i++)
				{
					this.dgvPic.Rows.Add(new object[]
					{
						fileNames[i]
					});
				}
				this.lblNanh.Text = "Ảnh (" + this.dgvPic.Rows.Count.ToString() + "):";
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00080E10 File Offset: 0x0007F010
		private void btnDelLink_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.dgvPic.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				this.dgvPic.Rows.RemoveAt(dataGridViewRow.Index);
			}
			this.lblNanh.Text = "Ảnh (" + this.dgvPic.Rows.Count.ToString() + "):";
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00080EFC File Offset: 0x0007F0FC
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.txtName.Text != "";
			if (flag)
			{
				string text = "";
				bool flag2 = this.dgvPic.Rows.Count != 0;
				if (flag2)
				{
					for (int i = 0; i < this.dgvPic.Rows.Count; i++)
					{
						text = text + this.dgvPic.Rows[i].Cells[0].Value.ToString() + "|";
					}
				}
				string video = "";
				string tenchuDe = this.cbbChuDe.SelectedItem.ToString();
				BaiViet baiviet = new BaiViet
				{
					tieuDe = this.txtName.Text,
					anh = text,
					video = video,
					ngayTao = DateTime.Now.ToString("dd/MM/yyyy"),
					noiDung = this.txtConten.Text
				};
				CommonSQL.AddBaiViet(tenchuDe, baiviet);
				DialogResult dialogResult = MessageBox.Show("Thêm thành công. Bạn muốn có muốn đóng cửa sổ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				bool flag3 = dialogResult == DialogResult.Yes;
				if (flag3)
				{
					base.Close();
				}
			}
			else
			{
				MCommon.Common.ShowMessageBox("Chưa nhập tiêu đề!", 2);
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnEdit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00081128 File Offset: 0x0007F328
		private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Process.Start(this.dgvPic.SelectedRows[0].Cells[0].Value.ToString());
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00054604 File Offset: 0x00052804
		private void cbbChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00054604 File Offset: 0x00052804
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00054604 File Offset: 0x00052804
		private void DgvVideo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00054604 File Offset: 0x00052804
		private void BunifuCustomLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}
	}
}
