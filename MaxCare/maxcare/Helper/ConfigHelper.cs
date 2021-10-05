using System;
using System.Linq;

namespace maxcare.Helper
{
	// Token: 0x0200018D RID: 397
	public class ConfigHelper
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x002C74C0 File Offset: 0x002C56C0
		public static string GetPathProfile()
		{
			JsonHelper jsonHelper = new JsonHelper("configGeneral", false);
			string text = jsonHelper.GetValue("txbPathProfile", "");
			bool flag = !text.Contains('\\');
			if (flag)
			{
				text = FileHelper.GetPathToCurrentFolder() + "\\" + ((jsonHelper.GetValue("txbPathProfile", "") == "") ? "profiles" : jsonHelper.GetValue("txbPathProfile", ""));
			}
			return text;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x002C75FC File Offset: 0x002C57FC
		public static string GetPathBackup()
		{
			return FileHelper.GetPathToCurrentFolder() + "\\backup";
		}
	}
}
