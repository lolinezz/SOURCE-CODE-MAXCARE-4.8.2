using System;
using System.Runtime.InteropServices;

namespace maxcare.Helper
{
	// Token: 0x02000188 RID: 392
	public class User32Helper
	{
		// Token: 0x06001182 RID: 4482
		[DllImport("user32.dll", SetLastError = true)]
		public static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		// Token: 0x06001183 RID: 4483
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
	}
}
