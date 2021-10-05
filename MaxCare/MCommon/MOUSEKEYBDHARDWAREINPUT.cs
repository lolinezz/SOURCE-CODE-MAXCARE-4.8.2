using System;
using System.Runtime.InteropServices;

namespace MCommon
{
	// Token: 0x0200002D RID: 45
	[StructLayout(LayoutKind.Explicit)]
	public struct MOUSEKEYBDHARDWAREINPUT
	{
		// Token: 0x040001B9 RID: 441
		[FieldOffset(0)]
		public HARDWAREINPUT Hardware;

		// Token: 0x040001BA RID: 442
		[FieldOffset(0)]
		public KEYBDINPUT Keyboard;

		// Token: 0x040001BB RID: 443
		[FieldOffset(0)]
		public MOUSEINPUT Mouse;
	}
}
