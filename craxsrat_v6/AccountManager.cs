using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000033 RID: 51
	[DesignerGenerated]
	public partial class AccountManager : Form
	{
		// Token: 0x060003AE RID: 942 RVA: 0x00020BCC File Offset: 0x0001EDCC
		public AccountManager()
		{
			base.Load += this.AccountManager_Load;
			base.Activated += this.AccountManager_Activated;
			base.Deactivate += this.AccountManager_Deactivate;
			this.string_0 = "null";
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000282F File Offset: 0x00000A2F
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00021318 File Offset: 0x0001F518
		internal virtual DataGridView DGV0
		{
			[CompilerGenerated]
			get
			{
				return this._DGV0;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewRowsRemovedEventHandler value2 = new DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
				DataGridViewRowsAddedEventHandler value3 = new DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
				EventHandler value4 = new EventHandler(this.DGV0_SelectionChanged);
				DataGridView dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.RowsRemoved -= value2;
					dgv.RowsAdded -= value3;
					dgv.SelectionChanged -= value4;
				}
				this._DGV0 = value;
				dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.RowsRemoved += value2;
					dgv.RowsAdded += value3;
					dgv.SelectionChanged += value4;
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00002837 File Offset: 0x00000A37
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00021394 File Offset: 0x0001F594
		internal virtual ContextMenuStrip ctxMenu { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000283F File Offset: 0x00000A3F
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000213A8 File Offset: 0x0001F5A8
		internal virtual ToolStripMenuItem SaveToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToolStripMenuItem_Click);
				ToolStripMenuItem saveToolStripMenuItem = this._SaveToolStripMenuItem;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click -= value2;
				}
				this._SaveToolStripMenuItem = value;
				saveToolStripMenuItem = this._SaveToolStripMenuItem;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002847 File Offset: 0x00000A47
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x000213EC File Offset: 0x0001F5EC
		internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveAsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveAsToolStripMenuItem_Click);
				ToolStripMenuItem saveAsToolStripMenuItem = this._SaveAsToolStripMenuItem;
				if (saveAsToolStripMenuItem != null)
				{
					saveAsToolStripMenuItem.Click -= value2;
				}
				this._SaveAsToolStripMenuItem = value;
				saveAsToolStripMenuItem = this._SaveAsToolStripMenuItem;
				if (saveAsToolStripMenuItem != null)
				{
					saveAsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000284F File Offset: 0x00000A4F
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00021430 File Offset: 0x0001F630
		internal virtual System.Windows.Forms.Timer TOpacity
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
				System.Windows.Forms.Timer topacity = this._TOpacity;
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00002857 File Offset: 0x00000A57
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00021474 File Offset: 0x0001F674
		internal virtual ProgressBar PB { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000285F File Offset: 0x00000A5F
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00021488 File Offset: 0x0001F688
		internal virtual PictureBox BoxTitle
		{
			[CompilerGenerated]
			get
			{
				return this._BoxTitle;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.BoxTitle_Paint);
				EventHandler value3 = new EventHandler(this.BoxTitle_Resize);
				PictureBox boxTitle = this._BoxTitle;
				if (boxTitle != null)
				{
					boxTitle.Paint -= value2;
					boxTitle.Resize -= value3;
				}
				this._BoxTitle = value;
				boxTitle = this._BoxTitle;
				if (boxTitle != null)
				{
					boxTitle.Paint += value2;
					boxTitle.Resize += value3;
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00002867 File Offset: 0x00000A67
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x000214E8 File Offset: 0x0001F6E8
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000286F File Offset: 0x00000A6F
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x000214FC File Offset: 0x0001F6FC
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00002877 File Offset: 0x00000A77
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00021510 File Offset: 0x0001F710
		internal virtual DataGridViewImageColumn Column2 { get; set; }

		// Token: 0x060003C5 RID: 965 RVA: 0x00021524 File Offset: 0x0001F724
		private void method_0()
		{
			this.BoxTitle.BackColor = Module5.color_0;
			try
			{
				foreach (DataGridView dataGridView in base.Controls.OfType<DataGridView>())
				{
					dataGridView.BackgroundColor = Module5.color_0;
					dataGridView.BackColor = Module5.color_0;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.SelectionForeColor = Module5.color_0;
					dataGridView.DefaultCellStyle.ForeColor = Module5.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Module5.White;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Module5.White;
				}
			}
			finally
			{
				IEnumerator<DataGridView> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000215F8 File Offset: 0x0001F7F8
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

		// Token: 0x060003C7 RID: 967 RVA: 0x00021640 File Offset: 0x0001F840
		private void AccountManager_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\1.ico");
			this.ctxMenu.Renderer = new GClass12();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			if (Operators.CompareString(Module5.Saving_data, "No", false) == 0)
			{
				this.SaveToolStripMenuItem.Visible = true;
				this.SaveAsToolStripMenuItem.Visible = true;
			}
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
			this.bool_0 = true;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00021700 File Offset: 0x0001F900
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem((AccountManager.Class7.waitCallback_0 == null) ? (AccountManager.Class7.waitCallback_0 = new WaitCallback(AccountManager.Class7.class7_0.method_0)) : AccountManager.Class7.waitCallback_0, new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.object_1,
					this.string_1 + " - " + this.string_2,
					"Accounts",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000217D8 File Offset: 0x0001F9D8
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Module8.smethod_5(this.gclass8_0);
			ThreadPool.QueueUserWorkItem((AccountManager.Class7.waitCallback_1 == null) ? (AccountManager.Class7.waitCallback_1 = new WaitCallback(AccountManager.Class7.class7_0.method_1)) : AccountManager.Class7.waitCallback_1, new object[]
			{
				this.DGV0,
				this.object_0,
				"Account Manager",
				this.object_1,
				this.string_1 + " - " + this.string_2,
				"Accounts",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0002188C File Offset: 0x0001FA8C
		private void BoxTitle_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.bool_0)
				{
					int count = this.DGV0.Rows.Count;
					string str = "All " + Conversions.ToString(count);
					string str2 = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
					Color white = Module5.White;
					e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)white.R, (int)white.G, (int)white.B)), 0, 1, this.BoxTitle.Width, 1);
					Brush brush = new SolidBrush(Module5.White);
					Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
					Size size = TextRenderer.MeasureText(str + Strings.Space(10) + str2, Module8.font_1);
					Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
					e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
					e.Graphics.DrawString(str + Strings.Space(10) + str2 + Strings.Space(10), Module8.font_1, brush, 0f, 2f);
					Size size2 = TextRenderer.MeasureText("S", Module8.font_1);
					if (this.BoxTitle.Height != size2.Height + 3)
					{
						this.BoxTitle.Height = size2.Height + 3;
					}
				}
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00021A40 File Offset: 0x0001FC40
		private void AccountManager_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00021A40 File Offset: 0x0001FC40
		private void AccountManager_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00021A40 File Offset: 0x0001FC40
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00021A40 File Offset: 0x0001FC40
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00021A40 File Offset: 0x0001FC40
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00021A40 File Offset: 0x0001FC40
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x040001B5 RID: 437
		public TcpClient tcpClient_0;

		// Token: 0x040001B6 RID: 438
		public GClass8 gclass8_0;

		// Token: 0x040001B7 RID: 439
		public string string_0;

		// Token: 0x040001B8 RID: 440
		public string object_0;

		// Token: 0x040001B9 RID: 441
		public string object_1;

		// Token: 0x040001BA RID: 442
		public string string_1;

		// Token: 0x040001BB RID: 443
		public string string_2;

		// Token: 0x040001BC RID: 444
		private bool bool_0;

		// Token: 0x02000034 RID: 52
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class7
		{
			// Token: 0x060003D3 RID: 979 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x040001BD RID: 445
			public static readonly AccountManager.Class7 class7_0 = new AccountManager.Class7();

			// Token: 0x040001BE RID: 446
			public static WaitCallback waitCallback_0;

			// Token: 0x040001BF RID: 447
			public static WaitCallback waitCallback_1;
		}
	}
}
