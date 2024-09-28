using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000A2 RID: 162
	[DesignerGenerated]
	public partial class AppsProperties : Form
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x0004189C File Offset: 0x0003FA9C
		public AppsProperties()
		{
			base.Load += this.AppsProperties_Load;
			this.string_0 = "null";
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00005BBD File Offset: 0x00003DBD
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00041D80 File Offset: 0x0003FF80
		internal virtual PictureBox BoxIcons
		{
			[CompilerGenerated]
			get
			{
				return this._BoxIcons;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.BoxIcons_Click);
				PictureBox boxIcons = this._BoxIcons;
				if (boxIcons != null)
				{
					boxIcons.Click -= value2;
				}
				this._BoxIcons = value;
				boxIcons = this._BoxIcons;
				if (boxIcons != null)
				{
					boxIcons.Click += value2;
				}
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00005BC5 File Offset: 0x00003DC5
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00041DC4 File Offset: 0x0003FFC4
		internal virtual Panel BOXPNL1 { get; set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00005BCD File Offset: 0x00003DCD
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00041DD8 File Offset: 0x0003FFD8
		internal virtual Label LAppInstallTime { get; set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00005BD5 File Offset: 0x00003DD5
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00041DEC File Offset: 0x0003FFEC
		internal virtual Label LAppFlag { get; set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00005BDD File Offset: 0x00003DDD
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00041E00 File Offset: 0x00040000
		internal virtual Label LAppName { get; set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00005BE5 File Offset: 0x00003DE5
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00041E14 File Offset: 0x00040014
		internal virtual Timer TOpacity
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
				Timer topacity = this._TOpacity;
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

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00005BED File Offset: 0x00003DED
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00041E58 File Offset: 0x00040058
		internal virtual Label LPermissions { get; set; }

		// Token: 0x060008BF RID: 2239 RVA: 0x00041E6C File Offset: 0x0004006C
		private void AppsProperties_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\2.ico");
			this.method_1();
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00041EC4 File Offset: 0x000400C4
		private void method_1()
		{
			try
			{
				foreach (Panel panel in base.Controls.OfType<Panel>())
				{
					panel.BackColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<Panel> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (Label label in this.BOXPNL1.Controls.OfType<Label>())
				{
					label.ForeColor = Module5.White;
					label.BackColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<Label> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			try
			{
				foreach (PictureBox pictureBox in this.BOXPNL1.Controls.OfType<PictureBox>())
				{
					pictureBox.BackColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<PictureBox> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			this.LPermissions.ForeColor = Module5.Blue;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00041FDC File Offset: 0x000401DC
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

		// Token: 0x060008C2 RID: 2242 RVA: 0x00042024 File Offset: 0x00040224
		private void BoxIcons_Click(object sender, EventArgs e)
		{
			Process.Start(string.Format("{0}{1}", "https://play.google.com/store/apps/details?id=", Conversions.ToString(this.BoxIcons.Tag)));
		}

		// Token: 0x04000493 RID: 1171
		public string string_0;
	}
}
