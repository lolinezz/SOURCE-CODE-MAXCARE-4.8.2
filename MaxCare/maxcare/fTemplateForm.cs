using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace maxcare
{
	// Token: 0x020000A7 RID: 167
	public partial class fTemplateForm : Form
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x00002DE9 File Offset: 0x00000FE9
		public fTemplateForm()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000932D4 File Offset: 0x000914D4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
