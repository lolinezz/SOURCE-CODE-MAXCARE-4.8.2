using System;

namespace maxcare.Enum
{
	// Token: 0x0200019F RID: 415
	public class GetContentStatusChrome
	{
		// Token: 0x060011D2 RID: 4562 RVA: 0x002C9A98 File Offset: 0x002C7C98
		public static string GetContent(StatusChromeAccount status)
		{
			string result = "";
			switch (status)
			{
			case StatusChromeAccount.ChromeClosed:
				result = Language.GetValue("Không tìm thấy chrome!");
				break;
			case StatusChromeAccount.Checkpoint:
				result = "Checkpoint!";
				break;
			case StatusChromeAccount.NoInternet:
				result = Language.GetValue("Không có kết nối Internet!");
				break;
			case StatusChromeAccount.Blocked:
				result = Language.GetValue("Facebook Blocked!");
				break;
			}
			return result;
		}
	}
}
