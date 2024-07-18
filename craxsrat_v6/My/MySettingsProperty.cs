using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat.My
{
	// Token: 0x0200000B RID: 11
	[StandardModule]
	[CompilerGenerated]
	[HideModuleName]
	[DebuggerNonUserCode]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000B948 File Offset: 0x00009B48
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
