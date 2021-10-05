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
	// Token: 0x02000093 RID: 147
	public partial class fSuaChuDe : Form
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x00002B58 File Offset: 0x00000D58
		public fSuaChuDe(string oldChude)
		{
			this.InitializeComponent();
			this.txtChude.Text = oldChude;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00054604 File Offset: 0x00052804
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00054604 File Offset: 0x00052804
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0007EE94 File Offset: 0x0007D094
		private void btnAdd_Click(object sender, EventArgs e)
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			string text = this.txtChude.Text;
			string text2 = this.txtNewChuDe.Text;
			bool flag = text2 == "";
			if (flag)
			{
				MCommon.Common.ShowMessageBox("Vui lòng nhập tên chủ đề mới!", 2);
			}
			else
			{
				bool flag2 = !listChuDe.Contains(text2);
				if (flag2)
				{
					CommonSQL.UpdateChuDe(text, text2);
					bool flag3 = MessageBox.Show("Cập nhật thành công, bạn có muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
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

		// Token: 0x060005AC RID: 1452 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00054604 File Offset: 0x00052804
		private void fSuaChuDe_FormClosing(object sender, FormClosingEventArgs e)
		{
		}
	}
}
