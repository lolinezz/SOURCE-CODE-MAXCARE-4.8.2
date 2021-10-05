using System;

namespace maxcare.Helper
{
	// Token: 0x0200019D RID: 413
	public class StringHelper
	{
		// Token: 0x060011D0 RID: 4560 RVA: 0x002C9A44 File Offset: 0x002C7C44
		public static bool CheckStringIsNumber(string content)
		{
			try
			{
				int num = Convert.ToInt32(content);
				return true;
			}
			catch
			{
			}
			return false;
		}
	}
}
