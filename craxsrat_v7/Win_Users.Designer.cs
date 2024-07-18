namespace Craxs_Rat
{
	// Token: 0x02000111 RID: 273
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Win_Users : global::System.Windows.Forms.Form
	{
		// Token: 0x06001341 RID: 4929 RVA: 0x000D093C File Offset: 0x000CEB3C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					((global::System.IDisposable)this.components).Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000D0980 File Offset: 0x000CEB80
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.ctxz = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.OpenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctxz.SuspendLayout();
			base.SuspendLayout();
			this.DGV0.AllowUserToAddRows = false;
			this.DGV0.AllowUserToDeleteRows = false;
			this.DGV0.AllowUserToResizeColumns = false;
			this.DGV0.AllowUserToResizeRows = false;
			this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DGV0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGV0.BackgroundColor = global::System.Drawing.Color.Black;
			this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Column1,
				this.Column6,
				this.Column3,
				this.Column2
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
			this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV0.EnableHeadersVisualStyles = false;
			this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.DGV0.Location = new global::System.Drawing.Point(0, 0);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DGV0.RowHeadersVisible = false;
			this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV0.Size = new global::System.Drawing.Size(393, 338);
			this.DGV0.TabIndex = 4;
			this.Column1.HeaderText = "Name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 61;
			this.Column6.HeaderText = "IP";
			this.Column6.Name = "Column6";
			this.Column6.Width = 40;
			this.Column3.HeaderText = "UUID";
			this.Column3.Name = "Column3";
			this.Column3.Width = 54;
			this.Column2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.FillWeight = 1f;
			this.Column2.HeaderText = "";
			this.Column2.MinimumWidth = 2;
			this.Column2.Name = "Column2";
			this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column2.Width = 2;
			this.TOpacity.Interval = 1;
			this.ctxz.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.OpenToolStripMenuItem,
				this.DeleteToolStripMenuItem
			});
			this.ctxz.Name = "ctxz";
			this.ctxz.ShowImageMargin = false;
			this.ctxz.Size = new global::System.Drawing.Size(156, 70);
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.OpenToolStripMenuItem.Text = "Open";
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.DeleteToolStripMenuItem.Text = "Delete";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(393, 338);
			base.Controls.Add(this.DGV0);
			base.Name = "Win_Users";
			base.Opacity = 0.0;
			this.Text = "Win_Users";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctxz.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000CFB RID: 3323
		private global::System.ComponentModel.Container components;
	}
}
