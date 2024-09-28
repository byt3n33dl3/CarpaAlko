using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000F5 RID: 245
	[StandardModule]
	internal sealed class Module12
	{
		// Token: 0x060011A8 RID: 4520
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SHGetFileInfo(string string_0, int int_0, ref Module12.Struct2 struct2_0, int int_1, int int_2);

		// Token: 0x060011A9 RID: 4521
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool DestroyIcon(IntPtr hIcon);

		// Token: 0x060011AA RID: 4522 RVA: 0x000B84A0 File Offset: 0x000B66A0
		public static Bitmap smethod_0(string string_0)
		{
			int num;
			if (Operators.CompareString(Module5.FM_IC_Size, "Large", false) != 0)
			{
				num = 1;
			}
			else
			{
				num = 0;
			}
			Module12.Struct2 @struct = default(Module12.Struct2);
			@struct.string_0 = new string('\0', 260);
			@struct.string_1 = new string('\0', 80);
			Module12.SHGetFileInfo(string_0, 128, ref @struct, Marshal.SizeOf(@struct), 256 | num | 16);
			Bitmap result = Icon.FromHandle(@struct.intptr_0).ToBitmap();
			Module12.DestroyIcon(@struct.intptr_0);
			return result;
		}

		// Token: 0x060011AB RID: 4523
		[DllImport("shell32.dll")]
		private static extern int SHGetFileInfoW([MarshalAs(UnmanagedType.LPTStr)] [In] string string_0, int int_0, ref Module12.Struct3 struct3_0, int int_1, int int_2);

		// Token: 0x060011AC RID: 4524 RVA: 0x000B8538 File Offset: 0x000B6738
		public static Bitmap smethod_1(string string_0, bool bool_0)
		{
			Module12.Struct3 @struct = default(Module12.Struct3);
			if (bool_0)
			{
				Module12.SHGetFileInfoW(string_0, 0, ref @struct, Marshal.SizeOf(@struct), 256);
			}
			else
			{
				Module12.SHGetFileInfoW(string_0, 0, ref @struct, Marshal.SizeOf(@struct), 257);
			}
			Bitmap result = Icon.FromHandle(@struct.intptr_0).ToBitmap();
			Module12.DestroyIcon(@struct.intptr_0);
			return result;
		}

		// Token: 0x020000F6 RID: 246
		private struct Struct2
		{
			// Token: 0x040009BE RID: 2494
			public IntPtr intptr_0;

			// Token: 0x040009BF RID: 2495
			public int int_0;

			// Token: 0x040009C0 RID: 2496
			public int int_1;

			// Token: 0x040009C1 RID: 2497
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string string_0;

			// Token: 0x040009C2 RID: 2498
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string string_1;
		}

		// Token: 0x020000F7 RID: 247
		public enum Enum2
		{

		}

		// Token: 0x020000F8 RID: 248
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct Struct3
		{
			// Token: 0x040009C4 RID: 2500
			public IntPtr intptr_0;

			// Token: 0x040009C5 RID: 2501
			public int int_0;

			// Token: 0x040009C6 RID: 2502
			public int int_1;

			// Token: 0x040009C7 RID: 2503
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string string_0;

			// Token: 0x040009C8 RID: 2504
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string string_1;
		}
	}
}
