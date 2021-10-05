using System;
using System.Runtime.InteropServices;

namespace MCommon
{
	// Token: 0x02000012 RID: 18
	internal class GDI32
	{
		// Token: 0x06000055 RID: 85
		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

		// Token: 0x06000056 RID: 86
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

		// Token: 0x06000057 RID: 87
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		// Token: 0x06000058 RID: 88
		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr hDC);

		// Token: 0x06000059 RID: 89
		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x0600005A RID: 90
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

		// Token: 0x04000038 RID: 56
		public const int SRCCOPY = 13369376;
	}
}
