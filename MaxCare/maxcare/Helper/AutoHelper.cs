using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace maxcare.Helper
{
	// Token: 0x02000189 RID: 393
	public class AutoHelper
	{
		// Token: 0x06001185 RID: 4485 RVA: 0x002C7200 File Offset: 0x002C5400
		public static void CaptureApplication(Process proc, string pathToSave)
		{
			AutoHelper.User32.Rect rect = default(AutoHelper.User32.Rect);
			AutoHelper.User32.GetWindowRect(proc.MainWindowHandle, ref rect);
			int width = rect.right - rect.left;
			int height = rect.bottom - rect.top;
			Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
			}
			bitmap.Save(pathToSave, ImageFormat.Png);
		}

		// Token: 0x0200018A RID: 394
		private class User32
		{
			// Token: 0x06001187 RID: 4487
			[DllImport("user32.dll")]
			public static extern IntPtr GetWindowRect(IntPtr hWnd, ref AutoHelper.User32.Rect rect);

			// Token: 0x0200018B RID: 395
			public struct Rect
			{
				// Token: 0x04001ABA RID: 6842
				public int left;

				// Token: 0x04001ABB RID: 6843
				public int top;

				// Token: 0x04001ABC RID: 6844
				public int right;

				// Token: 0x04001ABD RID: 6845
				public int bottom;
			}
		}
	}
}
