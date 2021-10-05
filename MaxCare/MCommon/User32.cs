using System;
using System.Runtime.InteropServices;

namespace MCommon
{
	// Token: 0x02000013 RID: 19
	internal class User32
	{
		// Token: 0x0600005C RID: 92
		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		// Token: 0x0600005D RID: 93
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(IntPtr hWnd);

		// Token: 0x0600005E RID: 94
		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		// Token: 0x0600005F RID: 95
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref User32.RECT rect);

		// Token: 0x02000014 RID: 20
		public struct RECT
		{
			// Token: 0x04000039 RID: 57
			public int left;

			// Token: 0x0400003A RID: 58
			public int top;

			// Token: 0x0400003B RID: 59
			public int right;

			// Token: 0x0400003C RID: 60
			public int bottom;
		}
	}
}
