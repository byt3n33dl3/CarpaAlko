using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000EE RID: 238
	public class GClass6
	{
		// Token: 0x0600117A RID: 4474 RVA: 0x000B59F4 File Offset: 0x000B3BF4
		public GClass6()
		{
			this.dictionary_0 = new Dictionary<string, string>();
			this.int_0 = 0;
		}

		// Token: 0x0600117B RID: 4475
		[DllImport("winmm.dll")]
		private static extern int mciSendStringW([MarshalAs(UnmanagedType.LPTStr)] string lpstrCommand, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpstrReturnString, uint uReturnLength, IntPtr hwndCallback);

		// Token: 0x0600117C RID: 4476 RVA: 0x000B5A1C File Offset: 0x000B3C1C
		public bool method_0(string string_0, string string_1)
		{
			bool result;
			if (Operators.CompareString(string_0.Trim(), "", false) == 0 | !File.Exists(string_1))
			{
				result = false;
			}
			else if (GClass6.mciSendStringW("open \"" + string_1 + "\" alias Snd_" + this.int_0.ToString(), null, 0U, IntPtr.Zero) == 0)
			{
				this.dictionary_0.Add(string_0, "Snd_" + this.int_0.ToString());
				ref int ptr = ref this.int_0;
				this.int_0 = checked(ptr + 1);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000B5AB0 File Offset: 0x000B3CB0
		public bool method_1(string string_0)
		{
			bool result;
			if (!this.dictionary_0.ContainsKey(string_0))
			{
				result = false;
			}
			else
			{
				GClass6.mciSendStringW("seek " + this.dictionary_0[string_0] + " to start", null, 0U, IntPtr.Zero);
				result = (GClass6.mciSendStringW("play " + this.dictionary_0[string_0], null, 0U, IntPtr.Zero) == 0);
			}
			return result;
		}

		// Token: 0x040009AA RID: 2474
		private Dictionary<string, string> dictionary_0;

		// Token: 0x040009AB RID: 2475
		private int int_0;
	}
}
