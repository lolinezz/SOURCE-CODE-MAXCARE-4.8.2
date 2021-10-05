using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000090 RID: 144
	public partial class fChonBaiViet : Form
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x00076D6C File Offset: 0x00074F6C
		public fChonBaiViet(ref List<string> lstData)
		{
			this.InitializeComponent();
			this.LoadcbbChuDe(false);
			this.lstData = lstData;
			this.RefreshDtgvDaChon();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00076DB8 File Offset: 0x00074FB8
		private void RefreshDtgvDaChon()
		{
			bool flag = this.lstData.Count > 0;
			if (flag)
			{
				this.dgvBaiVietDaChon.Rows.Clear();
				for (int i = 0; i < this.lstData.Count; i++)
				{
					try
					{
						BaiViet infoPosyByID = this.GetInfoPosyByID(this.lstData[i]);
						this.dgvBaiVietDaChon.Rows.Add(new object[]
						{
							i + 1,
							infoPosyByID.tenChuDe,
							infoPosyByID.id,
							infoPosyByID.tieuDe,
							infoPosyByID.anh.Split(new char[]
							{
								'|'
							}).Length - 1,
							infoPosyByID.video.Split(new char[]
							{
								'|'
							}).Length - 1
						});
					}
					catch
					{
						this.lstData.RemoveAt(i--);
					}
				}
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00076F54 File Offset: 0x00075154
		private BaiViet GetInfoPosyByID(string id)
		{
			BaiViet result = new BaiViet();
			try
			{
				result = CommonSQL.GetListBaiVietByID(id)[0];
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00076FB0 File Offset: 0x000751B0
		private void LoadcbbChuDe(bool check = false)
		{
			int selectedIndex = this.cbbChuDe.SelectedIndex;
			this.cbbChuDe.Items.Clear();
			List<string> listChuDe = CommonSQL.GetListChuDe();
			for (int i = 0; i < listChuDe.Count; i++)
			{
				this.cbbChuDe.Items.Add(listChuDe[i]);
			}
			bool flag = this.cbbChuDe.Items.Count == 0;
			if (flag)
			{
				this.cbbChuDe.SelectedIndex = -1;
			}
			else
			{
				bool flag2 = this.cbbChuDe.Items.Count == 1;
				if (flag2)
				{
					this.cbbChuDe.SelectedIndex = 0;
				}
				else
				{
					bool flag3 = selectedIndex == -1;
					if (flag3)
					{
						this.cbbChuDe.SelectedIndex = 0;
					}
					else
					{
						bool flag4 = this.cbbChuDe.Items.Count - 1 < selectedIndex;
						if (flag4)
						{
							this.cbbChuDe.SelectedIndex = this.cbbChuDe.Items.Count - 1;
						}
						else
						{
							this.cbbChuDe.SelectedIndex = selectedIndex;
						}
					}
				}
			}
			this.LoadDsBaiVietByChuDe(check);
			this.RefreshDtgvDaChon();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00077164 File Offset: 0x00075364
		private void LoadDsBaiVietByChuDe(bool isLoadAll = true)
		{
			try
			{
				this.dgvDSBaiViet.Rows.Clear();
				List<BaiViet> list = new List<BaiViet>();
				bool flag = !isLoadAll;
				if (flag)
				{
					list = CommonSQL.GetListBaiViet(this.cbbChuDe.SelectedItem.ToString());
				}
				else
				{
					list = CommonSQL.GetListBaiViet("");
				}
				BaiViet baiViet = new BaiViet();
				for (int i = 0; i < list.Count; i++)
				{
					baiViet = list[i];
					this.dgvDSBaiViet.Rows.Add(new object[]
					{
						i + 1,
						baiViet.tenChuDe,
						baiViet.id,
						baiViet.tieuDe,
						baiViet.anh.Split(new char[]
						{
							'|'
						}).Length - 1,
						baiViet.video.Split(new char[]
						{
							'|'
						}).Length - 1
					});
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00077314 File Offset: 0x00075514
		private void BtnSave_Click(object sender, EventArgs e)
		{
			this.lstData.Clear();
			for (int i = 0; i < this.dgvBaiVietDaChon.RowCount; i++)
			{
				this.lstData.Add(this.dgvBaiVietDaChon.Rows[i].Cells["cId"].Value.ToString());
			}
			bool flag = MessageBox.Show("Lưu thành công, bạn có muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00077408 File Offset: 0x00075608
		private void metroButton1_Click(object sender, EventArgs e)
		{
			MCommon.Common.ShowForm(new fDanhSachChuDe());
			this.LoadcbbChuDe(this.checkAll);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00077438 File Offset: 0x00075638
		private void thêmBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				int count = CommonSQL.GetListBaiViet("").Count;
				MCommon.Common.ShowForm(new fThemBaiViet(this.cbbChuDe.SelectedIndex));
				int count2 = CommonSQL.GetListBaiViet("").Count;
				bool flag = count2 > count;
				if (flag)
				{
					BaiViet baiViet = CommonSQL.GetBaiVietNewest()[0];
					this.dgvDSBaiViet.Rows.Add(new object[]
					{
						this.dgvDSBaiViet.RowCount + 1,
						baiViet.tenChuDe,
						baiViet.id,
						baiViet.tieuDe,
						baiViet.anh.Split(new char[]
						{
							'|'
						}).Length - 1,
						baiViet.video.Split(new char[]
						{
							'|'
						}).Length - 1
					});
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000775CC File Offset: 0x000757CC
		private void sửaBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow dataGridViewRow = this.dgvDSBaiViet.SelectedRows[0];
				int idBaiviet = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
				MCommon.Common.ShowForm(new fSuaBaiViet(idBaiviet));
				BaiViet baiViet = CommonSQL.GetListBaiVietByID(idBaiviet.ToString())[0];
				MCommon.Common.SetStatusDataGridView(this.dgvDSBaiViet, dataGridViewRow.Index, "cTieuDe", baiViet.tieuDe);
				MCommon.Common.SetStatusDataGridView(this.dgvDSBaiViet, dataGridViewRow.Index, "cAnh", baiViet.anh.Split(new char[]
				{
					'|'
				}).Length - 1);
				MCommon.Common.SetStatusDataGridView(this.dgvDSBaiViet, dataGridViewRow.Index, "cVideo", baiViet.video.Split(new char[]
				{
					'|'
				}).Length - 1);
				this.RefreshDtgvDaChon();
			}
			catch
			{
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0007775C File Offset: 0x0007595C
		private bool checkTrung(string id)
		{
			bool result = false;
			for (int i = 0; i < this.dgvBaiVietDaChon.Rows.Count; i++)
			{
				bool flag = id == this.dgvBaiVietDaChon.Rows[i].Cells[2].Value.ToString();
				if (flag)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000777FC File Offset: 0x000759FC
		private void dtgvKichBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int num = Convert.ToInt32(this.dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
			List<BaiViet> listBaiVietByID = CommonSQL.GetListBaiVietByID(num.ToString());
			BaiViet baiViet = new BaiViet();
			for (int i = 0; i < listBaiVietByID.Count; i++)
			{
				bool flag = this.checkTrung(num.ToString());
				if (flag)
				{
					break;
				}
				baiViet = listBaiVietByID[i];
				this.dgvBaiVietDaChon.Rows.Add(new object[]
				{
					this.dgvBaiVietDaChon.Rows.Count + 1,
					baiViet.tenChuDe,
					baiViet.id,
					baiViet.tieuDe,
					baiViet.anh.Split(new char[]
					{
						'|'
					}).Length - 1,
					baiViet.video.Split(new char[]
					{
						'|'
					}).Length - 1
				});
				this.lstData.Add(baiViet.id.ToString());
			}
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000779D0 File Offset: 0x00075BD0
		private void chiTiếtBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				int idBaiviet = Convert.ToInt32(this.dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
				fChiTietBaiViet fChiTietBaiViet = new fChiTietBaiViet(idBaiviet);
				fChiTietBaiViet.Show();
			}
			catch
			{
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00077A4C File Offset: 0x00075C4C
		private void UpdateSTTOnDtgvAcc()
		{
			for (int i = 0; i < this.dgvBaiVietDaChon.RowCount; i++)
			{
				MCommon.Common.SetStatusDataGridView(this.dgvBaiVietDaChon, i, "cStt1", i + 1);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00077ABC File Offset: 0x00075CBC
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.dgvDSBaiViet.Rows.Clear();
			List<BaiViet> listBaiViet = CommonSQL.GetListBaiViet(this.cbbChuDe.SelectedItem.ToString());
			BaiViet baiViet = new BaiViet();
			for (int i = 0; i < listBaiViet.Count; i++)
			{
				try
				{
					baiViet = listBaiViet[i];
					this.dgvDSBaiViet.Rows.Add(new object[]
					{
						i + 1,
						baiViet.tenChuDe,
						baiViet.id,
						baiViet.tieuDe,
						baiViet.anh.Split(new char[]
						{
							'|'
						}).Length - 1,
						baiViet.video.Split(new char[]
						{
							'|'
						}).Length - 1
					});
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00077C20 File Offset: 0x00075E20
		private void làmMớiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LoadDsBaiVietByChuDe(this.checkAll);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00054604 File Offset: 0x00052804
		private void cbbChuDe_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00077C48 File Offset: 0x00075E48
		private void hiểnThịTấtCảBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.checkAll = true;
			this.dgvDSBaiViet.Rows.Clear();
			this.LoadDsBaiVietByChuDe(this.checkAll);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00054604 File Offset: 0x00052804
		private void cbbChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00077C94 File Offset: 0x00075E94
		private void dgvBaiVietDaChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach (object obj in this.dgvBaiVietDaChon.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				this.dgvBaiVietDaChon.Rows.RemoveAt(dataGridViewRow.Index);
			}
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00077D54 File Offset: 0x00075F54
		private void xóaBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow dataGridViewRow = this.dgvDSBaiViet.SelectedRows[0];
				bool flag = dataGridViewRow != null;
				if (flag)
				{
					bool flag2 = MessageBox.Show("Bạn có muốn xóa bài viết này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
					if (flag2)
					{
						int id = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
						CommonSQL.DeleteBaiViet(id);
						this.dgvDSBaiViet.Rows.Remove(dataGridViewRow);
						this.RefreshDtgvDaChon();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00054604 File Offset: 0x00052804
		private void dgvDSBaiViet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00054604 File Offset: 0x00052804
		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00077E44 File Offset: 0x00076044
		private void dgvBaiVietDaChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.UpdateSTTOnDtgvAcc();
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00077E44 File Offset: 0x00076044
		private void dgvBaiVietDaChon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.UpdateSTTOnDtgvAcc();
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00077E8C File Offset: 0x0007608C
		private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkAll = false;
			this.LoadDsBaiVietByChuDe(this.checkAll);
		}

		// Token: 0x04000493 RID: 1171
		private bool checkAll = false;

		// Token: 0x04000494 RID: 1172
		private List<string> lstData = new List<string>();
	}
}
