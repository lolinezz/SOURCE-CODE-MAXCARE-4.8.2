using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000122 RID: 290
	public partial class fThemKichBan : Form
	{
		// Token: 0x06000D17 RID: 3351 RVA: 0x001E17E4 File Offset: 0x001DF9E4
		public fThemKichBan(int type, string id = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.type = type;
			this.id = id;
			bool flag = type == 1;
			if (flag)
			{
				this.bunifuCustomLabel1.Text = Language.GetValue("Cập nhật kịch bản");
				this.btnAdd.Text = Language.GetValue("Cập nhật");
				this.txtTen.Text = InteractSQL.GetKichBanById(id).Rows[0]["TenKichBan"].ToString();
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x001E18D4 File Offset: 0x001DFAD4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00054604 File Offset: 0x00052804
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0004B984 File Offset: 0x00049B84
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x001E1928 File Offset: 0x001DFB28
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtTen.Text.Trim();
			bool flag = text == "";
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập tên kịch bản!"), 2);
			}
			else
			{
				bool flag2 = this.type == 0;
				if (flag2)
				{
					bool flag3 = InteractSQL.InsertKichBan(text);
					if (flag3)
					{
						base.Close();
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
					}
				}
				else
				{
					bool flag4 = InteractSQL.UpdateKichBan(this.id, text);
					if (flag4)
					{
						base.Close();
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Có lỗi, vui lòng thử lại sau!"), 2);
					}
				}
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0004B984 File Offset: 0x00049B84
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x001E1A54 File Offset: 0x001DFC54
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			bool flag = this.panel1.BorderStyle == BorderStyle.FixedSingle;
			if (flag)
			{
				int num = 1;
				int num2 = num / 2;
				using (Pen pen = new Pen(Color.DarkViolet, (float)num))
				{
					e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, this.panel1.ClientSize.Width - num, this.panel1.ClientSize.Height - num));
				}
			}
		}

		// Token: 0x04001597 RID: 5527
		private int type = 0;

		// Token: 0x04001598 RID: 5528
		private string id = "";
	}
}
