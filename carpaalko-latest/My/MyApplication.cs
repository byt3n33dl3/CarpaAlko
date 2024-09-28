using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000848C File Offset: 0x0000668C
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			base.Startup += this.MyApplication_Startup;
			base.UnhandledException += this.MyApplication_UnhandledException;
			base.IsSingleInstance = false;
			base.EnableVisualStyles = true;
			base.SaveMySettingsOnExit = true;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000022A0 File Offset: 0x000004A0
		[STAThread]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000084E0 File Offset: 0x000066E0
		public string method_0(Exception exception_0)
		{
			string text = "-------------------------------------------------------------------";
			string text2 = "ERROR:\r\n" + text + "\r\n";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			try
			{
				text3 = exception_0.Message + "\r\n" + text + "\r\n";
			}
			catch (Exception)
			{
			}
			try
			{
				text4 = exception_0.StackTrace + "\r\n" + text + "\r\n";
			}
			catch (Exception)
			{
			}
			try
			{
				text5 = exception_0.InnerException.Message + "\r\n" + text + "\r\n";
			}
			catch (Exception)
			{
			}
			try
			{
				text6 = exception_0.InnerException.StackTrace + "\r\n" + text + "\r\n";
			}
			catch (Exception)
			{
			}
			checked
			{
				try
				{
					string text8 = "";
					int count = exception_0.Data.Keys.Count;
					for (int i = 0; i <= count; i++)
					{
						try
						{
							text8 = Conversions.ToString(Operators.ConcatenateObject(text8, Operators.ConcatenateObject(exception_0.Data[RuntimeHelpers.GetObjectValue(exception_0.Data.Keys.Cast<object>().ElementAtOrDefault(i))], "\r\n")));
						}
						catch (Exception)
						{
						}
					}
					text7 = text8 + "\r\n" + text + "\r\n";
				}
				catch (Exception)
				{
				}
				return string.Concat(new string[]
				{
					text2,
					text3,
					text4,
					text5,
					text6,
					text7
				});
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000086A0 File Offset: 0x000068A0
		private void MyApplication_Startup(object sender, StartupEventArgs e)
		{
			try
			{
				if (Directory.Exists(Path.GetTempPath() + "CP"))
				{
					Directory.Delete(Path.GetTempPath() + "CP", true);
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (Directory.Exists(Path.GetTempPath() + "UPATER"))
				{
					Directory.Delete(Path.GetTempPath() + "UPATER", true);
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (File.Exists(Path.GetTempPath() + "UPATER.zip"))
				{
					File.Delete(Path.GetTempPath() + "UPATER.zip");
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00008768 File Offset: 0x00006968
		private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
		{
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt"))
			{
				File.Create(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt").Dispose();
			}
			string text = "";
			try
			{
				text = e.Exception.Message;
			}
			catch (Exception)
			{
			}
			string text2 = "";
			try
			{
				text2 = e.Exception.Source;
			}
			catch (Exception)
			{
			}
			string text3 = "";
			try
			{
				text3 = e.Exception.TargetSite.Name;
			}
			catch (Exception)
			{
			}
			string text4 = "";
			try
			{
				text4 = e.Exception.InnerException.Message;
			}
			catch (Exception)
			{
			}
			string text5 = "";
			try
			{
				text5 = e.Exception.StackTrace;
			}
			catch (Exception)
			{
			}
			string text6 = "";
			try
			{
				text6 = this.method_0(e.Exception);
			}
			catch (Exception)
			{
			}
			File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt", string.Concat(new string[]
			{
				"\r\n",
				text,
				"\r\n                                            \r\n",
				text2,
				"\r\n                                              \r\n",
				DateTime.Now.ToString(),
				"\r\n                                               \r\n",
				text3,
				"\r\n                                               \r\n",
				text5,
				"\r\n                                               \r\n\r\n                                               \r\n",
				text6,
				"\r\n                                               \r\n",
				text4,
				"\r\n----------------End--------------"
			}));
			Interaction.MsgBox("Unhandled Exception \r\n Try Send Error logs to Developer at t.me/EvLFDEV :\r\n" + AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt", MsgBoxStyle.OkOnly, null);
			e.ExitApplication = true;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022B7 File Offset: 0x000004B7
		protected override void OnCreateMainForm()
		{
			base.MainForm = MyProject.Forms.CypherRat;
		}
	}
}
