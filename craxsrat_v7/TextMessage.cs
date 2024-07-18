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
	// Token: 0x02000109 RID: 265
	[DesignerGenerated]
	public partial class TextMessage : Form
	{
		// Token: 0x060012F2 RID: 4850 RVA: 0x000CE0B8 File Offset: 0x000CC2B8
		public TextMessage()
		{
			base.Load += this.TextMessage_Load;
			this.string_0 = "null";
			this.InitializeComponent();
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00007581 File Offset: 0x00005781
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x000CE3E4 File Offset: 0x000CC5E4
		internal virtual RichTextBox TextMsg { get; set; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00007589 File Offset: 0x00005789
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x000CE3F8 File Offset: 0x000CC5F8
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00007591 File Offset: 0x00005791
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x000CE43C File Offset: 0x000CC63C
		internal virtual ContextMenuStrip CMenu { get; set; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00007599 File Offset: 0x00005799
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x000CE450 File Offset: 0x000CC650
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x000075A1 File Offset: 0x000057A1
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x000CE494 File Offset: 0x000CC694
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x000075A9 File Offset: 0x000057A9
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x000CE4D8 File Offset: 0x000CC6D8
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

		// Token: 0x06001301 RID: 4865 RVA: 0x000CE51C File Offset: 0x000CC71C
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

		// Token: 0x06001302 RID: 4866 RVA: 0x000CE584 File Offset: 0x000CC784
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

		// Token: 0x06001303 RID: 4867 RVA: 0x000CE5CC File Offset: 0x000CC7CC
		private void TextMessage_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\14.ico");
			this.method_0();
			this.TextMsg.Font = Module8.font_1;
			this.CMenu.Renderer = new GClass12();
			this.TextMsg.ContextMenuStrip = this.CMenu;
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000CE654 File Offset: 0x000CC854
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TextMsg.Cut();
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000CE66C File Offset: 0x000CC86C
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TextMsg.Copy();
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000CE684 File Offset: 0x000CC884
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TextMsg.Paste();
		}

		// Token: 0x04000CCA RID: 3274
		public TcpClient object_0;

		// Token: 0x04000CCB RID: 3275
		public GClass8 object_1;

		// Token: 0x04000CCC RID: 3276
		public string string_0;
	}
}
