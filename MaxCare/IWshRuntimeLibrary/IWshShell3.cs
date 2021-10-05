using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x020001A3 RID: 419
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[CompilerGenerated]
	[TypeIdentifier]
	[ComImport]
	public interface IWshShell3 : IWshShell2
	{
		// Token: 0x060011D5 RID: 4565
		void _VtblGap1_4();

		// Token: 0x060011D6 RID: 4566
		[DispId(1002)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([MarshalAs(UnmanagedType.BStr)] [In] string PathLink);
	}
}
