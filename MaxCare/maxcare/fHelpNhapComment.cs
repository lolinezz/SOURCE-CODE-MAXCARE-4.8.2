using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace maxcare
{
	// Token: 0x020000A8 RID: 168
	public partial class fHelpNhapComment : Form
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x00002E08 File Offset: 0x00001008
		public fHelpNhapComment()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00093E94 File Offset: 0x00092094
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
