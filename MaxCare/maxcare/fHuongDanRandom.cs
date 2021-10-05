using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;

namespace maxcare
{
	// Token: 0x020000E8 RID: 232
	public partial class fHuongDanRandom : Form
	{
		// Token: 0x06000959 RID: 2393 RVA: 0x0000310C File Offset: 0x0000130C
		public fHuongDanRandom()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.LoadDgv();
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00128D94 File Offset: 0x00126F94
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			foreach (object obj in this.dgv.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00128E20 File Offset: 0x00127020
		private void LoadDgv()
		{
			Random random = new Random();
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r1]",
				Resources.icon11
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r2]",
				Resources.icon12
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r3]",
				Resources.icon13
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r4]",
				Resources.icon14
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r5]",
				Resources.icon15
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r6]",
				Resources.icon16
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r7]",
				Resources.icon17
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[r8]",
				Resources.icon18
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[d]",
				Resources.icon19
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[t]",
				Resources.icon20
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[n*]",
				Resources.icon21
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[s*]",
				Resources.icon22
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				"[q***]",
				Resources.icon23
			});
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00054604 File Offset: 0x00052804
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
