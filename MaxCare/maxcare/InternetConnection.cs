using System;
using System.Runtime.InteropServices;

namespace maxcare
{
	// Token: 0x020000F8 RID: 248
	internal class InternetConnection
	{
		// Token: 0x06000A09 RID: 2569
		[DllImport("wininet.dll")]
		private static extern bool InternetGetConnectedState(out int description, int reservedValuine);

		// Token: 0x06000A0A RID: 2570 RVA: 0x0014C4E0 File Offset: 0x0014A6E0
		public static bool IsConnectedToInternet()
		{
			int num;
			return InternetConnection.InternetGetConnectedState(out num, 0);
		}
	}
}
