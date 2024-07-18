using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000111 RID: 273
	[DesignerGenerated]
	public partial class Win_Users : Form
	{
		// Token: 0x06001340 RID: 4928 RVA: 0x000D08FC File Offset: 0x000CEAFC
		public Win_Users()
		{
			base.Load += this.Win_Users_Load;
			base.Closing += this.Win_Users_Closing;
			this.InitializeComponent();
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00007609 File Offset: 0x00005809
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x000D0EC4 File Offset: 0x000CF0C4
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
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV0_CellContentClick);
				DataGridViewCellMouseEventHandler value3 = new DataGridViewCellMouseEventHandler(this.DGV0_CellMouseDoubleClick);
				DataGridView dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellContentClick -= value2;
					dgv.CellMouseDoubleClick -= value3;
				}
				this._DGV0 = value;
				dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellContentClick += value2;
					dgv.CellMouseDoubleClick += value3;
				}
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00007611 File Offset: 0x00005811
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x000D0F24 File Offset: 0x000CF124
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00007619 File Offset: 0x00005819
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x000D0F38 File Offset: 0x000CF138
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00007621 File Offset: 0x00005821
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x000D0F4C File Offset: 0x000CF14C
		internal virtual DataGridViewTextBoxColumn Column3 { get; set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00007629 File Offset: 0x00005829
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x000D0F60 File Offset: 0x000CF160
		internal virtual DataGridViewImageColumn Column2 { get; set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00007631 File Offset: 0x00005831
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x000D0F74 File Offset: 0x000CF174
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

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00007639 File Offset: 0x00005839
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x000D0FB8 File Offset: 0x000CF1B8
		internal virtual ContextMenuStrip ctxz { get; set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00007641 File Offset: 0x00005841
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x000D0FCC File Offset: 0x000CF1CC
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

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00007649 File Offset: 0x00005849
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x000D1010 File Offset: 0x000CF210
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

		// Token: 0x06001355 RID: 4949 RVA: 0x000D1054 File Offset: 0x000CF254
		private void Win_Users_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\1.ico");
			this.ctxz.Renderer = new GClass12();
			this.DGV0.ContextMenuStrip = this.ctxz;
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			this.method_0();
			this.method_3();
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000D10F0 File Offset: 0x000CF2F0
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

		// Token: 0x06001357 RID: 4951 RVA: 0x000D11B8 File Offset: 0x000CF3B8
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

		// Token: 0x06001358 RID: 4952 RVA: 0x000D1200 File Offset: 0x000CF400
		private void Win_Users_Closing(object sender, CancelEventArgs e)
		{
			MyProject.Forms.CypherRat.win_Users_0 = null;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0000246D File Offset: 0x0000066D
		private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000D1220 File Offset: 0x000CF420
		public void method_3()
		{
			this.Text = "Users (" + Conversions.ToString(this.DGV0.Rows.Count) + ")";
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000D1258 File Offset: 0x000CF458
		private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (this.DGV0.Rows.Count > 0 && e.RowIndex != -1)
			{
				string str = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[2].Value);
				string text = Module8.string_1 + "\\Users\\" + str;
				if (!Directory.Exists(text))
				{
					this.DGV0.Rows.RemoveAt(e.RowIndex);
					this.method_3();
				}
				else
				{
					Process.Start(text);
				}
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000D12F4 File Offset: 0x000CF4F4
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
						string text = Module8.string_1 + "\\Users\\" + str;
						if (Directory.Exists(text))
						{
							Process.Start(text);
						}
						else
						{
							this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
							this.method_3();
						}
					}
				}
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000D13CC File Offset: 0x000CF5CC
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string str = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
						string path = Module8.string_1 + "\\Users\\" + str;
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						this.method_3();
						if (Directory.Exists(path))
						{
							try
							{
								Directory.Delete(path, true);
							}
							catch (Exception ex)
							{
							}
						}
					}
				}
			}
		}
	}
}
