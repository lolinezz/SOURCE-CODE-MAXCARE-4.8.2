using System;
using System.Windows.Forms;

namespace maxcare.Helper
{
	// Token: 0x0200019C RID: 412
	public class MessageBoxHelper
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x002C9918 File Offset: 0x002C7B18
		public static void ShowMessageBox(object s, int type = 1)
		{
			switch (type)
			{
			case 1:
				MessageBox.Show(s.ToString(), Language.GetValue("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case 2:
				MessageBox.Show(s.ToString(), Language.GetValue("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			case 3:
				MessageBox.Show(s.ToString(), Language.GetValue("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x002C9A00 File Offset: 0x002C7C00
		public static DialogResult ShowMessageBoxWithQuestion(string content)
		{
			return MessageBox.Show(content, Language.GetValue("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
	}
}
