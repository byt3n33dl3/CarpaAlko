namespace Craxs_Rat
{
	// Token: 0x020000AE RID: 174
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ContactsManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B1A RID: 2842 RVA: 0x00077684 File Offset: 0x00075884
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

		// Token: 0x06000B1B RID: 2843 RVA: 0x000776C8 File Offset: 0x000758C8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.BoxTitle = new global::System.Windows.Forms.PictureBox();
			this.SendSmsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
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
				this.Column2
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
			this.DGV0.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DGV0.RowHeadersVisible = false;
			this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV0.Size = new global::System.Drawing.Size(552, 263);
			this.DGV0.TabIndex = 3;
			this.Column1.HeaderText = "name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 73;
			this.Column6.HeaderText = "number";
			this.Column6.Name = "Column6";
			this.Column6.Width = 89;
			this.Column9.HeaderText = "connected-via";
			this.Column9.Name = "Column9";
			this.Column9.Width = 136;
			this.Column2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.FillWeight = 1f;
			this.Column2.HeaderText = "";
			this.Column2.MinimumWidth = 2;
			this.Column2.Name = "Column2";
			this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column2.Width = 2;
			this.ctxMenu.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RefreshToolStripMenuItem,
				this.SendSmsToolStripMenuItem,
				this.AddToolStripMenuItem,
				this.DeleteToolStripMenuItem,
				this.SaveToolStripMenuItem,
				this.SaveAsToolStripMenuItem
			});
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(186, 176);
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new global::System.Drawing.Size(185, 24);
			this.RefreshToolStripMenuItem.Text = "Refresh";
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new global::System.Drawing.Size(185, 24);
			this.AddToolStripMenuItem.Text = "Add";
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new global::System.Drawing.Size(185, 24);
			this.DeleteToolStripMenuItem.Text = "Delete";
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(185, 24);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(185, 24);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.TOpacity.Interval = 1;
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 263);
			this.PB.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(552, 12);
			this.PB.TabIndex = 6;
			this.BoxTitle.BackColor = global::System.Drawing.Color.Black;
			this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.BoxTitle.ErrorImage = null;
			this.BoxTitle.InitialImage = null;
			this.BoxTitle.Location = new global::System.Drawing.Point(0, 275);
			this.BoxTitle.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BoxTitle.Name = "BoxTitle";
			this.BoxTitle.Size = new global::System.Drawing.Size(552, 22);
			this.BoxTitle.TabIndex = 7;
			this.BoxTitle.TabStop = false;
			this.SendSmsToolStripMenuItem.Name = "SendSmsToolStripMenuItem";
			this.SendSmsToolStripMenuItem.Size = new global::System.Drawing.Size(185, 24);
			this.SendSmsToolStripMenuItem.Text = "Send sms";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(552, 297);
			base.Controls.Add(this.DGV0);
			base.Controls.Add(this.PB);
			base.Controls.Add(this.BoxTitle);
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "ContactsManager";
			base.Opacity = 0.0;
			this.Text = "ContactsManager";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctxMenu.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000636 RID: 1590
		private global::System.ComponentModel.Container components;
	}
}
