using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000095 RID: 149
	public partial class fThemChuDe : Form
	{
		// Token: 0x060005C1 RID: 1473 RVA: 0x00002BA9 File Offset: 0x00000DA9
		public fThemChuDe()
		{
			this.InitializeComponent();
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00054604 File Offset: 0x00052804
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000832F0 File Offset: 0x000814F0
		private void btnAdd_Click(object sender, EventArgs e)
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			string text = this.txtChuDe.Text;
			bool flag = text == "";
			if (flag)
			{
				MCommon.Common.ShowMessageBox("Vui lòng nhập tên chủ đề mới!", 2);
			}
			else
			{
				bool flag2 = !listChuDe.Contains(text);
				if (flag2)
				{
					CommonSQL.AddChuDe(text);
					bool flag3 = MessageBox.Show("Thêm thành công, bạn có muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
					if (flag3)
					{
						base.Close();
					}
				}
				else
				{
					MCommon.Common.ShowMessageBox("Tên chủ đề đã tồn tại, vui lòng đổi tên khác!", 2);
				}
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
