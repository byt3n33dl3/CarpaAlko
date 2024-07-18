using System;
using System.Collections.Generic;
using System.Management;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000011 RID: 17
	[StandardModule]
	internal sealed class Module3
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x0000F444 File Offset: 0x0000D644
		public static string smethod_0(string string_0 = "C")
		{
			ManagementObject managementObject = new ManagementObject(string.Format("win32_logicaldisk.deviceid=\"{0}:\"", string_0));
			managementObject.Get();
			return managementObject["VolumeSerialNumber"].ToString();
		}

		// Token: 0x04000052 RID: 82
		public static string string_0 = string.Empty;

		// Token: 0x04000053 RID: 83
		public static int int_0 = 8;

		// Token: 0x04000054 RID: 84
		public static int int_1 = -1;

		// Token: 0x04000055 RID: 85
		public static List<GClass8> gclass8s_0 = new List<GClass8>();
	}
}
