namespace Craxs_Rat
{
	// Token: 0x020000A0 RID: 160
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Applications : global::System.Windows.Forms.Form
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x0003FA84 File Offset: 0x0003DC84
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

		// Token: 0x06000872 RID: 2162 RVA: 0x0003FAC8 File Offset: 0x0003DCC8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Craxs_Rat.Applications));
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.ctx = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.OpenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PropertiesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UninstallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ClearAppDataToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.BoxTitle = new global::System.Windows.Forms.PictureBox();
			this.EnableToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctx.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
			base.SuspendLayout();
			this.DGV0.AllowUserToAddRows = false;
			this.DGV0.AllowUserToDeleteRows = false;
			this.DGV0.AllowUserToResizeColumns = false;
			this.DGV0.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.Black;
			this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DGV0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGV0.BackgroundColor = global::System.Drawing.Color.Black;
			this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Column1,
				this.Column6,
				this.Column9,
				this.Column2,
				this.Column3
			});
			this.DGV0.ContextMenuStrip = this.ctx;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV0.EnableHeadersVisualStyles = false;
			this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.DGV0.Location = new global::System.Drawing.Point(0, 0);
			this.DGV0.Margin = new global::System.Windows.Forms.Padding(4);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DGV0.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.Black;
			this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV0.Size = new global::System.Drawing.Size(493, 496);
			this.DGV0.TabIndex = 4;
			this.Column1.HeaderText = "App Name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 105;
			this.Column6.HeaderText = "Type";
			this.Column6.Name = "Column6";
			this.Column6.Width = 67;
			this.Column9.HeaderText = "App ID";
			this.Column9.Name = "Column9";
			this.Column9.Width = 80;
			this.Column2.HeaderText = "Install Time";
			this.Column2.Name = "Column2";
			this.Column2.Width = 114;
			this.Column3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column3.FillWeight = 1f;
			this.Column3.HeaderText = "";
			this.Column3.MinimumWidth = 2;
			this.Column3.Name = "Column3";
			this.Column3.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column3.Width = 2;
			this.ctx.BackColor = global::System.Drawing.Color.Black;
			this.ctx.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.ctx.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.OpenToolStripMenuItem,
				this.RefreshToolStripMenuItem,
				this.PropertiesToolStripMenuItem,
				this.SaveToolStripMenuItem,
				this.SaveAsToolStripMenuItem,
				this.UninstallToolStripMenuItem,
				this.ClearAppDataToolStripMenuItem,
				this.EnableToolStripMenuItem
			});
			this.ctx.Name = "ctx";
			this.ctx.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ctx.ShowImageMargin = false;
			this.ctx.Size = new global::System.Drawing.Size(148, 228);
			this.OpenToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.OpenToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.OpenToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image");
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.OpenToolStripMenuItem.Text = "Open";
			this.RefreshToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.RefreshToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.RefreshToolStripMenuItem.Text = "Refresh";
			this.PropertiesToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.PropertiesToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
			this.PropertiesToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.PropertiesToolStripMenuItem.Text = "Properties";
			this.SaveToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.SaveToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.SaveAsToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.UninstallToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.UninstallToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem";
			this.UninstallToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.UninstallToolStripMenuItem.Text = "uninstall";
			this.ClearAppDataToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.ClearAppDataToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.ClearAppDataToolStripMenuItem.Name = "ClearAppDataToolStripMenuItem";
			this.ClearAppDataToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.ClearAppDataToolStripMenuItem.Text = "Disable";
			this.TOpacity.Interval = 1;
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 496);
			this.PB.Margin = new global::System.Windows.Forms.Padding(4);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(493, 12);
			this.PB.TabIndex = 6;
			this.BoxTitle.BackColor = global::System.Drawing.Color.Black;
			this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.BoxTitle.ErrorImage = null;
			this.BoxTitle.InitialImage = null;
			this.BoxTitle.Location = new global::System.Drawing.Point(0, 508);
			this.BoxTitle.Margin = new global::System.Windows.Forms.Padding(4);
			this.BoxTitle.Name = "BoxTitle";
			this.BoxTitle.Size = new global::System.Drawing.Size(493, 22);
			this.BoxTitle.TabIndex = 7;
			this.BoxTitle.TabStop = false;
			this.EnableToolStripMenuItem.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.EnableToolStripMenuItem.ForeColor = global::System.Drawing.Color.FromArgb(195, 5, 5);
			this.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
			this.EnableToolStripMenuItem.Size = new global::System.Drawing.Size(147, 28);
			this.EnableToolStripMenuItem.Text = "Enable";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(493, 530);
			base.Controls.Add(this.DGV0);
			base.Controls.Add(this.PB);
			base.Controls.Add(this.BoxTitle);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "Applications";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "Applications";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctx.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400046D RID: 1133
		private global::System.ComponentModel.Container components;
	}
}
