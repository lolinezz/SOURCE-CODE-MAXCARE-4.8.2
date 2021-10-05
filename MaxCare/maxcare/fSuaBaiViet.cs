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
	// Token: 0x02000092 RID: 146
	public partial class fSuaBaiViet : Form
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x0007C710 File Offset: 0x0007A910
		public fSuaBaiViet(int idBaiviet)
		{
			this.InitializeComponent();
			this.LoadcbbChuDe();
			this.idBai = idBaiviet;
			List<BaiViet> listBaiVietByID = CommonSQL.GetListBaiVietByID(idBaiviet.ToString());
			foreach (BaiViet baiViet in listBaiVietByID)
			{
				this.cbbChuDe.Text = baiViet.tenChuDe;
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

		// Token: 0x06000592 RID: 1426 RVA: 0x0007C890 File Offset: 0x0007AA90
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

		// Token: 0x06000593 RID: 1427 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00054604 File Offset: 0x00052804
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0007C928 File Offset: 0x0007AB28
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
				BaiViet baiviet = new BaiViet
				{
					tieuDe = this.txtName.Text,
					anh = text,
					video = video,
					noiDung = this.txtConten.Text
				};
				CommonSQL.UpdateBaiViet(this.idBai, baiviet);
				DialogResult dialogResult = MessageBox.Show("Cập nhập thành công.Bạn có muốn thoát ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				bool flag3 = dialogResult == DialogResult.Yes;
				if (flag3)
				{
					base.Dispose();
				}
			}
			else
			{
				MessageBox.Show("Chưa nhập tiêu đề", "Lỗi");
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0007CB2C File Offset: 0x0007AD2C
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

		// Token: 0x0600059A RID: 1434 RVA: 0x0007CC40 File Offset: 0x0007AE40
		private void btnDelLink_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.dgvPic.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				this.dgvPic.Rows.RemoveAt(dataGridViewRow.Index);
			}
			this.lblNanh.Text = "Ảnh (" + this.dgvPic.Rows.Count.ToString() + "):";
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnEdit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0007CD2C File Offset: 0x0007AF2C
		private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Process.Start(this.dgvPic.SelectedRows[0].Cells[0].Value.ToString());
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00054604 File Offset: 0x00052804
		private void cbbChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0007CD74 File Offset: 0x0007AF74
		private void fSuaBaiViet_FormClosed(object sender, FormClosedEventArgs e)
		{
			List<string> list = new List<string>();
			fChonBaiViet fChonBaiViet = new fChonBaiViet(ref list);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00054604 File Offset: 0x00052804
		private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0007CD90 File Offset: 0x0007AF90
		private void metroButton1_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fDanhSachChuDe());
			this.cbbChuDe.Items.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0007CDCC File Offset: 0x0007AFCC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MCommon.Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x040004D5 RID: 1237
		private int idBai;
	}
}
