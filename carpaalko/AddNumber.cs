using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000035 RID: 53
	[DesignerGenerated]
	public partial class AddNumber : Form
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x00021A88 File Offset: 0x0001FC88
		public AddNumber()
		{
			base.Load += this.AddNumber_Load;
			this.rectangles_0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000287F File Offset: 0x00000A7F
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00022270 File Offset: 0x00020470
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
				PaintEventHandler value2 = new PaintEventHandler(this.Panel1_Paint);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00002887 File Offset: 0x00000A87
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000222B4 File Offset: 0x000204B4
		internal virtual TextBox InputText1 { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000288F File Offset: 0x00000A8F
		// (set) Token: 0x060003DD RID: 989 RVA: 0x000222C8 File Offset: 0x000204C8
		internal virtual Label L1 { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00002897 File Offset: 0x00000A97
		// (set) Token: 0x060003DF RID: 991 RVA: 0x000222DC File Offset: 0x000204DC
		internal virtual TextBox InputText0 { get; set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000289F File Offset: 0x00000A9F
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x000222F0 File Offset: 0x000204F0
		internal virtual Label L0 { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000028A7 File Offset: 0x00000AA7
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00022304 File Offset: 0x00020504
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000028AF File Offset: 0x00000AAF
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00022348 File Offset: 0x00020548
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000028B7 File Offset: 0x00000AB7
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0002238C File Offset: 0x0002058C
		internal virtual DrakeUINavBar DrakeUINavBar1 { get; set; }

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000223A0 File Offset: 0x000205A0
		private void method_1()
		{
			try
			{
				foreach (Label label in this.Panel1.Controls.OfType<Label>())
				{
					label.ForeColor = Module5.White;
					label.BackColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<Label> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (TextBox textBox in this.Panel1.Controls.OfType<TextBox>())
				{
					textBox.ForeColor = Module5.White;
					textBox.BackColor = Module5.color_0;
					this.rectangles_0.Add(checked(new Rectangle(textBox.Location.X - 1, textBox.Location.Y - 1, textBox.Width + 1, textBox.Height + 1)));
				}
			}
			finally
			{
				IEnumerator<TextBox> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			try
			{
				foreach (Button button in this.Panel1.Controls.OfType<Button>())
				{
					button.BackColor = Module5.White;
					button.ForeColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<Button> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			try
			{
				foreach (Panel panel in base.Controls.OfType<Panel>())
				{
					panel.BackColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<Panel> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
			this.Refresh();
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00022560 File Offset: 0x00020760
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

		// Token: 0x060003EB RID: 1003 RVA: 0x000225A8 File Offset: 0x000207A8
		private void AddNumber_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\12.ico");
			this.method_1();
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000225F4 File Offset: 0x000207F4
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Color white = Module5.White;
			if (this.rectangles_0.Count > 0)
			{
				try
				{
					foreach (Rectangle rect in this.rectangles_0)
					{
						if (rect.Width > 0)
						{
							e.Graphics.FillRectangle(new SolidBrush(white), rect);
						}
					}
				}
				finally
				{
					List<Rectangle>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00022684 File Offset: 0x00020884
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x040001C9 RID: 457
		private List<Rectangle> rectangles_0;
	}
}
