using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000D2 RID: 210
	[DesignerGenerated]
	public partial class Icons : Form
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x000A7CF4 File Offset: 0x000A5EF4
		public Icons()
		{
			base.Load += this.Icons_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00006E34 File Offset: 0x00005034
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x000A8180 File Offset: 0x000A6380
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
				DataGridViewSortCompareEventHandler value2 = new DataGridViewSortCompareEventHandler(this.DGV0_SortCompare);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DGV0_CellDoubleClick);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.DGV0_CellContentClick);
				DataGridView dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.SortCompare -= value2;
					dgv.CellDoubleClick -= value3;
					dgv.CellContentClick -= value4;
				}
				this._DGV0 = value;
				dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.SortCompare += value2;
					dgv.CellDoubleClick += value3;
					dgv.CellContentClick += value4;
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00006E3C File Offset: 0x0000503C
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x000A81FC File Offset: 0x000A63FC
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00006E44 File Offset: 0x00005044
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x000A8240 File Offset: 0x000A6440
		internal virtual DataGridViewImageColumn Column1 { get; set; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00006E4C File Offset: 0x0000504C
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x000A8254 File Offset: 0x000A6454
		internal virtual DataGridViewTextBoxColumn Column2 { get; set; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00006E54 File Offset: 0x00005054
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x000A8268 File Offset: 0x000A6468
		internal virtual DataGridViewTextBoxColumn Column3 { get; set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00006E5C File Offset: 0x0000505C
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x000A827C File Offset: 0x000A647C
		internal virtual DataGridViewTextBoxColumn Column4 { get; set; }

		// Token: 0x06000FAA RID: 4010 RVA: 0x000A8290 File Offset: 0x000A6490
		private void method_0()
		{
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
					dataGridView.Columns[0].DefaultCellStyle.SelectionBackColor = Module5.color_0;
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

		// Token: 0x06000FAB RID: 4011 RVA: 0x000A8374 File Offset: 0x000A6574
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

		// Token: 0x06000FAC RID: 4012 RVA: 0x000A83BC File Offset: 0x000A65BC
		private void Icons_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\4.ico");
			this.method_0();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000868B0 File Offset: 0x00084AB0
		private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.RowIndex1 == 0)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000A8430 File Offset: 0x000A6630
		private void DGV0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				this.int_0 = e.RowIndex;
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0000246D File Offset: 0x0000066D
		private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04000891 RID: 2193
		public int int_0;
	}
}
