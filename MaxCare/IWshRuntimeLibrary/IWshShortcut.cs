using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// IWshRuntimeLibrary.IWshShortcut
	using System.Reflection;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;

	[ComImport]
	[DefaultMember("FullName")]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[CompilerGenerated]
	[TypeIdentifier]
	public interface IWshShortcut
	{
		[DispId(0)]
		string FullName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string Arguments
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1000)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1000)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1001)]
		string Description
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1001)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1001)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1003)]
		string IconLocation
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1003)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1003)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string TargetPath
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1005)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1005)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1007)]
		string WorkingDirectory
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		void _VtblGap1_2();

		void _VtblGap2_1();

		void _VtblGap3_2();

		void _VtblGap4_1();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(2001)]
		void Save();
	}

}