using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;

namespace maxcare
{
	// Token: 0x0200009D RID: 157
	public partial class fSelectFolder : Form
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00002C60 File Offset: 0x00000E60
		public fSelectFolder()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fSelectFolder.pathFolder = "";
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000880E0 File Offset: 0x000862E0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00088134 File Offset: 0x00086334
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			fSelectFolder.pathFolder = this.txtPathFolder.Text.Trim();
			bool flag = fSelectFolder.pathFolder == "";
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập đường dẫn Folder!"), 2);
				this.txtPathFolder.Focus();
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000881CC File Offset: 0x000863CC
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			fSelectFolder.pathFolder = "";
		}

		// Token: 0x04000566 RID: 1382
		public static string pathFolder = "";
	}
}
