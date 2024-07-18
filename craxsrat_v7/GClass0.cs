using System;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x0200000C RID: 12
	public class GClass0
	{
		// Token: 0x0600014B RID: 331 RVA: 0x0000B95C File Offset: 0x00009B5C
		internal string method_0()
		{
			string result = string.Empty;
			SelectQuery query = new SelectQuery("Win32_processor");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					result = managementObject["processorId"].ToString();
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000B9DC File Offset: 0x00009BDC
		public static string smethod_0()
		{
			SelectQuery query = new SelectQuery("Win32_BaseBoard");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
			string result;
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					result = managementObject["SerialNumber"].ToString();
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000BA54 File Offset: 0x00009C54
		public static string smethod_1()
		{
			SelectQuery query = new SelectQuery("Win32_processor");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
			string result;
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					result = managementObject["processorId"].ToString();
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		public static string smethod_2(string string_0)
		{
			byte[] source = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(string_0));
			return string.Concat(source.Select((GClass0.Class0.func_0 != null) ? GClass0.Class0.func_0 : (GClass0.Class0.func_0 = new Func<byte, string>(GClass0.Class0.class0_0.method_0))));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000BB1C File Offset: 0x00009D1C
		internal string method_1()
		{
			ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = managementClass.GetInstances();
			string text = string.Empty;
			try
			{
				foreach (ManagementBaseObject managementBaseObject in instances)
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (text.Equals(string.Empty))
					{
						if (Conversions.ToBoolean(managementObject["IPEnabled"]))
						{
							text = managementObject["MacAddress"].ToString();
						}
						managementObject.Dispose();
					}
					text = text.Replace(":", string.Empty);
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return text;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000BBCC File Offset: 0x00009DCC
		internal string method_2(string string_0 = "C")
		{
			ManagementObject managementObject = new ManagementObject(string.Format("win32_logicaldisk.deviceid=\"{0}:\"", string_0));
			managementObject.Get();
			return managementObject["VolumeSerialNumber"].ToString();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000BC04 File Offset: 0x00009E04
		internal string method_3()
		{
			string result = string.Empty;
			SelectQuery query = new SelectQuery("Win32_BaseBoard");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					result = managementObject["SerialNumber"].ToString();
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000BC84 File Offset: 0x00009E84
		internal string method_4()
		{
			string queryString = "Select SerialNumber From Win32_BaseBoard";
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
			{
				try
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						foreach (PropertyData propertyData in managementObject.Properties)
						{
							if (Operators.CompareString(propertyData.Name, "SerialNumber", false) == 0)
							{
								if (propertyData.Value != null)
								{
									propertyData.Value.ToString();
									break;
								}
								break;
							}
						}
					}
				}
				finally
				{
					ManagementObjectCollection.ManagementObjectEnumerator enumerator;
					if (enumerator != null)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			string result;
			return result;
		}

		// Token: 0x0200000D RID: 13
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class0
		{
			// Token: 0x06000155 RID: 341 RVA: 0x0000BD64 File Offset: 0x00009F64
			internal string method_0(byte _byte_0)
			{
				return _byte_0.ToString("x2");
			}

			// Token: 0x04000046 RID: 70
			public static readonly GClass0.Class0 class0_0 = new GClass0.Class0();

			// Token: 0x04000047 RID: 71
			public static Func<byte, string> func_0;
		}
	}
}
