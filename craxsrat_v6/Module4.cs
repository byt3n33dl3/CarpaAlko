using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Craxs_Rat
{
	// Token: 0x02000015 RID: 21
	[StandardModule]
	internal sealed class Module4
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		public static void smethod_0()
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true);
				try
				{
					if (registryKey2 == null)
					{
						registryKey2 = registryKey.CreateSubKey(Module4.string_0);
					}
				}
				catch (Exception ex)
				{
				}
				registryKey2.Close();
				registryKey.Close();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		public static string smethod_1()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("UserLanguage"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("UserLanguage").ToString();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000FB2C File Offset: 0x0000DD2C
		public static void smethod_2(object object_2)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true);
				registryKey2.SetValue("UserLanguage", object_2);
				registryKey2.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000FB88 File Offset: 0x0000DD88
		public static string smethod_3()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("STIP"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("STIP").ToString();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		public static void smethod_4(object object_2)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true);
				registryKey2.SetValue("STIP", object_2);
				registryKey2.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		public static string smethod_5()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("SK"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("SK").ToString();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000FD50 File Offset: 0x0000DF50
		public static void smethod_6(object object_2)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true);
				registryKey2.SetValue("SK", object_2);
				registryKey2.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		public static string smethod_7()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("LR"));
						if (objectValue != null)
						{
							return Module2.smethod_58(registryKey2.GetValue("LR").ToString(), "OpenSubKey");
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000FE68 File Offset: 0x0000E068
		public static void smethod_8(string string_1)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true);
				registryKey2.SetValue("LR", Module2.smethod_59(string_1, "OpenSubKey"));
				registryKey2.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		public static string smethod_9()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("RP"));
						if (objectValue != null)
						{
							return Module2.smethod_58(registryKey2.GetValue("RP").ToString(), "OpenSubKey");
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000FF8C File Offset: 0x0000E18C
		public static void smethod_10(string string_1)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(Module4.string_0, true);
				registryKey2.SetValue("RP", Module2.smethod_59(string_1, "OpenSubKey"));
				registryKey2.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400005C RID: 92
		private static string string_0 = "Software\\\\CraxsRat";
	}
}
