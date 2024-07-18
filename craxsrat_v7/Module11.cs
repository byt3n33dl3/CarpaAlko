using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000F2 RID: 242
	[StandardModule]
	internal sealed class Module11
	{
		// Token: 0x060011A6 RID: 4518
		[DllImport("shell32.dll")]
		public static extern void SHChangeNotify(Module11.Enum1 enum1_0, Module11.Enum0 enum0_0, IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060011A7 RID: 4519 RVA: 0x000B847C File Offset: 0x000B667C
		public static void smethod_0()
		{
			Module11.SHChangeNotify((Module11.Enum1)134217728, (Module11.Enum0)0, IntPtr.Zero, IntPtr.Zero);
		}

		// Token: 0x020000F3 RID: 243
		[Flags]
		public enum Enum0
		{

		}

		// Token: 0x020000F4 RID: 244
		[Flags]
		public enum Enum1
		{

		}
	}
}
