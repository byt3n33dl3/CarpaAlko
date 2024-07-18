using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000A7 RID: 167
	[DesignerGenerated]
	public partial class CallPhone : Form
	{
		// Token: 0x06000A14 RID: 2580 RVA: 0x0006FEF8 File Offset: 0x0006E0F8
		public CallPhone()
		{
			base.Load += this.CallPhone_Load;
			this.bool_0 = false;
			this.string_0 = "call";
			this.string_1 = "null";
			this.rectangles_0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00005FB5 File Offset: 0x000041B5
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00071080 File Offset: 0x0006F280
		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.TextBox1_KeyPress);
				KeyEventHandler value4 = new KeyEventHandler(this.TextBox1_KeyDown);
				TextBox textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
					textBox.KeyPress -= value3;
					textBox.KeyDown -= value4;
				}
				this._TextBox1 = value;
				textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
					textBox.KeyPress += value3;
					textBox.KeyDown += value4;
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00005FBD File Offset: 0x000041BD
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000710FC File Offset: 0x0006F2FC
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00005FC5 File Offset: 0x000041C5
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00071140 File Offset: 0x0006F340
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

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00005FCD File Offset: 0x000041CD
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00071184 File Offset: 0x0006F384
		internal virtual Label L0 { get; set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00005FD5 File Offset: 0x000041D5
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00071198 File Offset: 0x0006F398
		internal virtual Button B_hash
		{
			[CompilerGenerated]
			get
			{
				return this._B_hash;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.B_hash_Click);
				Button b_hash = this._B_hash;
				if (b_hash != null)
				{
					b_hash.Click -= value2;
				}
				this._B_hash = value;
				b_hash = this._B_hash;
				if (b_hash != null)
				{
					b_hash.Click += value2;
				}
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00005FDD File Offset: 0x000041DD
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x000711DC File Offset: 0x0006F3DC
		internal virtual Button b0
		{
			[CompilerGenerated]
			get
			{
				return this._b0;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b0_Click);
				Button b = this._b0;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b0 = value;
				b = this._b0;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00005FE5 File Offset: 0x000041E5
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00071220 File Offset: 0x0006F420
		internal virtual Button B_star
		{
			[CompilerGenerated]
			get
			{
				return this._B_star;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.B_star_Click);
				Button b_star = this._B_star;
				if (b_star != null)
				{
					b_star.Click -= value2;
				}
				this._B_star = value;
				b_star = this._B_star;
				if (b_star != null)
				{
					b_star.Click += value2;
				}
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00005FED File Offset: 0x000041ED
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00071264 File Offset: 0x0006F464
		internal virtual Button b9
		{
			[CompilerGenerated]
			get
			{
				return this._b9;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b9_Click);
				Button b = this._b9;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b9 = value;
				b = this._b9;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00005FF5 File Offset: 0x000041F5
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x000712A8 File Offset: 0x0006F4A8
		internal virtual Button b8
		{
			[CompilerGenerated]
			get
			{
				return this._b8;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b8_Click);
				Button b = this._b8;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b8 = value;
				b = this._b8;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00005FFD File Offset: 0x000041FD
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x000712EC File Offset: 0x0006F4EC
		internal virtual Button b7
		{
			[CompilerGenerated]
			get
			{
				return this._b7;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b7_Click);
				Button b = this._b7;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b7 = value;
				b = this._b7;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00006005 File Offset: 0x00004205
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00071330 File Offset: 0x0006F530
		internal virtual Button b6
		{
			[CompilerGenerated]
			get
			{
				return this._b6;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b6_Click);
				Button b = this._b6;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b6 = value;
				b = this._b6;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0000600D File Offset: 0x0000420D
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00071374 File Offset: 0x0006F574
		internal virtual Button b5
		{
			[CompilerGenerated]
			get
			{
				return this._b5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b5_Click);
				Button b = this._b5;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b5 = value;
				b = this._b5;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00006015 File Offset: 0x00004215
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000713B8 File Offset: 0x0006F5B8
		internal virtual Button b4
		{
			[CompilerGenerated]
			get
			{
				return this._b4;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b4_Click);
				Button b = this._b4;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b4 = value;
				b = this._b4;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0000601D File Offset: 0x0000421D
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x000713FC File Offset: 0x0006F5FC
		internal virtual Button b3
		{
			[CompilerGenerated]
			get
			{
				return this._b3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b3_Click);
				Button b = this._b3;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b3 = value;
				b = this._b3;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00006025 File Offset: 0x00004225
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00071440 File Offset: 0x0006F640
		internal virtual Button b2
		{
			[CompilerGenerated]
			get
			{
				return this._b2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b2_Click);
				Button b = this._b2;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b2 = value;
				b = this._b2;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0000602D File Offset: 0x0000422D
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00071484 File Offset: 0x0006F684
		internal virtual Button b1
		{
			[CompilerGenerated]
			get
			{
				return this._b1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b1_Click);
				Button b = this._b1;
				if (b != null)
				{
					b.Click -= value2;
				}
				this._b1 = value;
				b = this._b1;
				if (b != null)
				{
					b.Click += value2;
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00006035 File Offset: 0x00004235
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x000714C8 File Offset: 0x0006F6C8
		internal virtual Button b_DEL
		{
			[CompilerGenerated]
			get
			{
				return this._b_DEL;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b_DEL_Click);
				Button b_DEL = this._b_DEL;
				if (b_DEL != null)
				{
					b_DEL.Click -= value2;
				}
				this._b_DEL = value;
				b_DEL = this._b_DEL;
				if (b_DEL != null)
				{
					b_DEL.Click += value2;
				}
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0000603D File Offset: 0x0000423D
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0007150C File Offset: 0x0006F70C
		internal virtual ContextMenuStrip CMenu { get; set; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00006045 File Offset: 0x00004245
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00071520 File Offset: 0x0006F720
		internal virtual ToolStripMenuItem CutToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CutToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CutToolStripMenuItem_Click);
				ToolStripMenuItem cutToolStripMenuItem = this._CutToolStripMenuItem;
				if (cutToolStripMenuItem != null)
				{
					cutToolStripMenuItem.Click -= value2;
				}
				this._CutToolStripMenuItem = value;
				cutToolStripMenuItem = this._CutToolStripMenuItem;
				if (cutToolStripMenuItem != null)
				{
					cutToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0000604D File Offset: 0x0000424D
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00071564 File Offset: 0x0006F764
		internal virtual ToolStripMenuItem CopyToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CopyToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyToolStripMenuItem_Click);
				ToolStripMenuItem copyToolStripMenuItem = this._CopyToolStripMenuItem;
				if (copyToolStripMenuItem != null)
				{
					copyToolStripMenuItem.Click -= value2;
				}
				this._CopyToolStripMenuItem = value;
				copyToolStripMenuItem = this._CopyToolStripMenuItem;
				if (copyToolStripMenuItem != null)
				{
					copyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00006055 File Offset: 0x00004255
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x000715A8 File Offset: 0x0006F7A8
		internal virtual ToolStripMenuItem PasteToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PasteToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteToolStripMenuItem_Click);
				ToolStripMenuItem pasteToolStripMenuItem = this._PasteToolStripMenuItem;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click -= value2;
				}
				this._PasteToolStripMenuItem = value;
				pasteToolStripMenuItem = this._PasteToolStripMenuItem;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0000605D File Offset: 0x0000425D
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x000715EC File Offset: 0x0006F7EC
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

		// Token: 0x06000A43 RID: 2627 RVA: 0x00071630 File Offset: 0x0006F830
		private void method_0()
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

		// Token: 0x06000A44 RID: 2628 RVA: 0x000717E8 File Offset: 0x0006F9E8
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

		// Token: 0x06000A45 RID: 2629 RVA: 0x00071830 File Offset: 0x0006FA30
		private void CallPhone_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\18.ico");
			this.CMenu.Renderer = new GClass12();
			this.TextBox1.ContextMenuStrip = this.CMenu;
			this.method_0();
			int fontSize = MySettingsProperty.Settings.FontSize;
			if (!CallPhone.smethod_0("Wingdings 3"))
			{
				this.b_DEL.Text = "<";
			}
			else
			{
				this.b_DEL.Font = new Font("Wingdings 3", (float)fontSize, FontStyle.Regular);
				this.b_DEL.Text = "…";
			}
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000718EC File Offset: 0x0006FAEC
		public static bool smethod_0(string string_2)
		{
			bool result;
			using (Font font = new Font(string_2, 10f))
			{
				result = (string.Compare(string_2, font.Name, StringComparison.InvariantCultureIgnoreCase) == 0);
			}
			return result;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00071938 File Offset: 0x0006FB38
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

		// Token: 0x06000A48 RID: 2632 RVA: 0x000719C8 File Offset: 0x0006FBC8
		private void b1_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "1";
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000719F4 File Offset: 0x0006FBF4
		private void b2_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "2";
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00071A20 File Offset: 0x0006FC20
		private void b3_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "3";
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00071A4C File Offset: 0x0006FC4C
		private void b4_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "4";
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00071A78 File Offset: 0x0006FC78
		private void b5_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "5";
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00071AA4 File Offset: 0x0006FCA4
		private void b6_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "6";
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00071AD0 File Offset: 0x0006FCD0
		private void b7_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "7";
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00071AFC File Offset: 0x0006FCFC
		private void b8_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "8";
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00071B28 File Offset: 0x0006FD28
		private void b9_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "9";
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00071B54 File Offset: 0x0006FD54
		private void b0_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "0";
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00071B80 File Offset: 0x0006FD80
		private void b_DEL_Click(object sender, EventArgs e)
		{
			if (this.TextBox1.Text.Length > 0)
			{
				this.TextBox1.Text = this.TextBox1.Text.Remove(checked(this.TextBox1.Text.Length - 1));
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00071BD0 File Offset: 0x0006FDD0
		private void B_star_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "*";
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00071BFC File Offset: 0x0006FDFC
		private void B_hash_Click(object sender, EventArgs e)
		{
			TextBox textBox;
			(textBox = this.TextBox1).Text = textBox.Text + "#";
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_17(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0000246D File Offset: 0x0000066D
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00071C28 File Offset: 0x0006FE28
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.bool_0)
			{
				e.Handled = false;
			}
			else
			{
				string text = "0123456789,*#+";
				if (!text.Contains(e.KeyChar.ToString()))
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00071C6C File Offset: 0x0006FE6C
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Back)
			{
				this.bool_0 = false;
			}
			else
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00071C94 File Offset: 0x0006FE94
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TextBox1.Cut();
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00071CAC File Offset: 0x0006FEAC
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TextBox1.Copy();
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00071CC4 File Offset: 0x0006FEC4
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = "0123456789,*#+";
			if (MyProject.Computer.Clipboard.ContainsText())
			{
				string text2 = MyProject.Computer.Clipboard.GetText();
				if (text2.Length <= 1500)
				{
					foreach (char value in text2)
					{
						if (!text.ToString().Contains(Conversions.ToString(value)))
						{
							return;
						}
					}
				}
			}
			this.TextBox1.Paste();
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00071D50 File Offset: 0x0006FF50
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			this.string_0 = "call";
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x040005CD RID: 1485
		private bool bool_0;

		// Token: 0x040005CE RID: 1486
		public string string_0;

		// Token: 0x040005CF RID: 1487
		public string string_1;

		// Token: 0x040005D0 RID: 1488
		private List<Rectangle> rectangles_0;
	}
}
