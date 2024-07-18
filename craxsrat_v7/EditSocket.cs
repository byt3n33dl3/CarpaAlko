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
	// Token: 0x020000B6 RID: 182
	[DesignerGenerated]
	public partial class EditSocket : Form
	{
		// Token: 0x06000C20 RID: 3104 RVA: 0x0007EF48 File Offset: 0x0007D148
		public EditSocket()
		{
			base.Load += this.EditSocket_Load;
			this.rectangles_0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x000064F4 File Offset: 0x000046F4
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x0007FB10 File Offset: 0x0007DD10
		internal virtual Panel PanelBOX
		{
			[CompilerGenerated]
			get
			{
				return this._PanelBOX;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PanelBOX_Paint);
				Panel panelBOX = this._PanelBOX;
				if (panelBOX != null)
				{
					panelBOX.Paint -= value2;
				}
				this._PanelBOX = value;
				panelBOX = this._PanelBOX;
				if (panelBOX != null)
				{
					panelBOX.Paint += value2;
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000064FC File Offset: 0x000046FC
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0007FB54 File Offset: 0x0007DD54
		internal virtual Button btnUp
		{
			[CompilerGenerated]
			get
			{
				return this._btnUp;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.btnUp_Click);
				Button btnUp = this._btnUp;
				if (btnUp != null)
				{
					btnUp.Click -= value2;
				}
				this._btnUp = value;
				btnUp = this._btnUp;
				if (btnUp != null)
				{
					btnUp.Click += value2;
				}
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00006504 File Offset: 0x00004704
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0007FB98 File Offset: 0x0007DD98
		internal virtual Button btnDown
		{
			[CompilerGenerated]
			get
			{
				return this._btnDown;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDown_Click);
				Button btnDown = this._btnDown;
				if (btnDown != null)
				{
					btnDown.Click -= value2;
				}
				this._btnDown = value;
				btnDown = this._btnDown;
				if (btnDown != null)
				{
					btnDown.Click += value2;
				}
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0000650C File Offset: 0x0000470C
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0007FBDC File Offset: 0x0007DDDC
		internal virtual Label T0 { get; set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00006514 File Offset: 0x00004714
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x0007FBF0 File Offset: 0x0007DDF0
		internal virtual Label Label2 { get; set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0000651C File Offset: 0x0000471C
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x0007FC04 File Offset: 0x0007DE04
		internal virtual Label Label1 { get; set; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00006524 File Offset: 0x00004724
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x0007FC18 File Offset: 0x0007DE18
		internal virtual Button b_Add
		{
			[CompilerGenerated]
			get
			{
				return this._b_Add;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b_Add_Click);
				Button b_Add = this._b_Add;
				if (b_Add != null)
				{
					b_Add.Click -= value2;
				}
				this._b_Add = value;
				b_Add = this._b_Add;
				if (b_Add != null)
				{
					b_Add.Click += value2;
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0000652C File Offset: 0x0000472C
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0007FC5C File Offset: 0x0007DE5C
		internal virtual Button b_del
		{
			[CompilerGenerated]
			get
			{
				return this._b_del;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b_del_Click);
				Button b_del = this._b_del;
				if (b_del != null)
				{
					b_del.Click -= value2;
				}
				this._b_del = value;
				b_del = this._b_del;
				if (b_del != null)
				{
					b_del.Click += value2;
				}
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00006534 File Offset: 0x00004734
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0007FCA0 File Offset: 0x0007DEA0
		internal virtual DataGridView DGV0 { get; set; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0000653C File Offset: 0x0000473C
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0007FCB4 File Offset: 0x0007DEB4
		internal virtual DataGridViewTextBoxColumn Column2 { get; set; }

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00006544 File Offset: 0x00004744
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
		internal virtual TextBox TextIP { get; set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0000654C File Offset: 0x0000474C
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x0007FCDC File Offset: 0x0007DEDC
		internal virtual Button OKY
		{
			[CompilerGenerated]
			get
			{
				return this._OKY;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OKY_Click);
				Button oky = this._OKY;
				if (oky != null)
				{
					oky.Click -= value2;
				}
				this._OKY = value;
				oky = this._OKY;
				if (oky != null)
				{
					oky.Click += value2;
				}
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00006554 File Offset: 0x00004754
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x0007FD20 File Offset: 0x0007DF20
		internal virtual NumericUpDown po { get; set; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0000655C File Offset: 0x0000475C
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x0007FD34 File Offset: 0x0007DF34
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

		// Token: 0x06000C3F RID: 3135 RVA: 0x0007FD78 File Offset: 0x0007DF78
		private void method_0()
		{
			this.po.BackColor = Module5.color_0;
			this.po.ForeColor = Module5.White;
			checked
			{
				this.rectangles_0.Add(new Rectangle(this.po.Location.X - 1, this.po.Location.Y - 1, this.po.Width + 1, this.po.Height + 1));
				try
				{
					foreach (DataGridView dataGridView in this.PanelBOX.Controls.OfType<DataGridView>())
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
				try
				{
					foreach (Label label in this.PanelBOX.Controls.OfType<Label>())
					{
						label.ForeColor = Module5.White;
					}
				}
				finally
				{
					IEnumerator<Label> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				try
				{
					foreach (Button button in this.PanelBOX.Controls.OfType<Button>())
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
					foreach (TextBox textBox in this.PanelBOX.Controls.OfType<TextBox>())
					{
						textBox.BackColor = Module5.color_0;
						textBox.ForeColor = Module5.White;
						this.rectangles_0.Add(new Rectangle(textBox.Location.X - 1, textBox.Location.Y - 1, textBox.Width + 1, textBox.Height + 1));
					}
				}
				finally
				{
					IEnumerator<TextBox> enumerator4;
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
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00080070 File Offset: 0x0007E270
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

		// Token: 0x06000C41 RID: 3137 RVA: 0x000800B8 File Offset: 0x0007E2B8
		private void EditSocket_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\12.ico");
			this.method_0();
			this.TextIP.Text = Module2.smethod_53();
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00080114 File Offset: 0x0007E314
		private void b_Add_Click(object sender, EventArgs e)
		{
			this.DGV0.Rows.Add(new object[]
			{
				this.TextIP.Text + ":" + Conversions.ToString(this.po.Value)
			});
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00080160 File Offset: 0x0007E360
		private void b_del_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
					}
				}
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000801C8 File Offset: 0x0007E3C8
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.method_5(false);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000801DC File Offset: 0x0007E3DC
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.method_5(true);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000801F0 File Offset: 0x0007E3F0
		private void method_5(bool bool_0)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count == 1 & this.DGV0.Rows.Count != 1)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Value);
						if (!bool_0)
						{
							if (this.DGV0.SelectedRows[i].Index != 0)
							{
								this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index - 1, new object[]
								{
									text
								});
								this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
								this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index + 1);
								this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
							}
						}
						else
						{
							this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
							this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index + 1, new object[]
							{
								text
							});
							this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index + 1].Cells[0];
						}
					}
				}
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00022684 File Offset: 0x00020884
		private void OKY_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00080424 File Offset: 0x0007E624
		private void PanelBOX_Paint(object sender, PaintEventArgs e)
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

		// Token: 0x040006CE RID: 1742
		private List<Rectangle> rectangles_0;
	}
}
