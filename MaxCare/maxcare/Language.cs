using System;
using System.Windows.Forms;

namespace maxcare
{
	// Token: 0x020000D1 RID: 209
	public class Language
	{
		// Token: 0x06000899 RID: 2201 RVA: 0x0010D82C File Offset: 0x0010BA2C
		public static string GetValue(string key)
		{
			return key;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0010D848 File Offset: 0x0010BA48
		public static void GetValue(Control control)
		{
			control.Text = Language.GetValue(control.Text);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0010D874 File Offset: 0x0010BA74
		public static void GetValue(ToolStripItem control)
		{
			control.Text = Language.GetValue(control.Text);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0010D8A0 File Offset: 0x0010BAA0
		public static void GetValue(DataGridViewColumn control)
		{
			control.HeaderText = Language.GetValue(control.HeaderText);
		}

		// Token: 0x04000C10 RID: 3088
		public static string data = "";
	}
}
