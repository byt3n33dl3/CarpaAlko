namespace Craxs_Rat
{
	// Token: 0x020000FC RID: 252
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SMSManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x000BF590 File Offset: 0x000BD790
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

		// Token: 0x06001265 RID: 4709 RVA: 0x000BF5D4 File Offset: 0x000BD7D4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.PathsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OutboxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InboxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SentToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.QueuedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FailedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.BoxTitle = new global::System.Windows.Forms.PictureBox();
			this.DrakeUIAvatar1 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ContextMenuStrip1.SuspendLayout();
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
			this.DGV0.ContextMenuStrip = this.ContextMenuStrip1;
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
			this.DGV0.Margin = new global::System.Windows.Forms.Padding(4);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DGV0.RowHeadersVisible = false;
			this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV0.Size = new global::System.Drawing.Size(675, 365);
			this.DGV0.TabIndex = 3;
			this.Column1.HeaderText = "address";
			this.Column1.Name = "Column1";
			this.Column1.Width = 92;
			this.Column6.HeaderText = "name";
			this.Column6.Name = "Column6";
			this.Column6.Width = 73;
			this.Column9.HeaderText = "date";
			this.Column9.Name = "Column9";
			this.Column9.Width = 66;
			this.Column7.HeaderText = "part";
			this.Column7.Name = "Column7";
			this.Column7.Width = 63;
			this.Column2.HeaderText = "path";
			this.Column2.Name = "Column2";
			this.Column2.Width = 66;
			this.Column3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column3.FillWeight = 1f;
			this.Column3.HeaderText = "";
			this.Column3.MinimumWidth = 2;
			this.Column3.Name = "Column3";
			this.Column3.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column3.Width = 2;
			this.ContextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.PathsToolStripMenuItem,
				this.SaveToolStripMenuItem,
				this.SaveAsToolStripMenuItem
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.ShowImageMargin = false;
			this.ContextMenuStrip1.Size = new global::System.Drawing.Size(105, 76);
			this.PathsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.AllToolStripMenuItem,
				this.OutboxToolStripMenuItem,
				this.InboxToolStripMenuItem,
				this.SentToolStripMenuItem,
				this.QueuedToolStripMenuItem,
				this.FailedToolStripMenuItem
			});
			this.PathsToolStripMenuItem.Name = "PathsToolStripMenuItem";
			this.PathsToolStripMenuItem.Size = new global::System.Drawing.Size(104, 24);
			this.PathsToolStripMenuItem.Text = "Paths";
			this.AllToolStripMenuItem.Name = "AllToolStripMenuItem";
			this.AllToolStripMenuItem.Size = new global::System.Drawing.Size(134, 26);
			this.AllToolStripMenuItem.Text = "all";
			this.OutboxToolStripMenuItem.Name = "OutboxToolStripMenuItem";
			this.OutboxToolStripMenuItem.Size = new global::System.Drawing.Size(134, 26);
			this.OutboxToolStripMenuItem.Text = "outbox";
			this.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem";
			this.InboxToolStripMenuItem.Size = new global::System.Drawing.Size(134, 26);
			this.InboxToolStripMenuItem.Text = "inbox";
			this.SentToolStripMenuItem.Name = "SentToolStripMenuItem";
			this.SentToolStripMenuItem.Size = new global::System.Drawing.Size(134, 26);
			this.SentToolStripMenuItem.Text = "sent";
			this.QueuedToolStripMenuItem.Name = "QueuedToolStripMenuItem";
			this.QueuedToolStripMenuItem.Size = new global::System.Drawing.Size(134, 26);
			this.QueuedToolStripMenuItem.Text = "queued";
			this.FailedToolStripMenuItem.Name = "FailedToolStripMenuItem";
			this.FailedToolStripMenuItem.Size = new global::System.Drawing.Size(134, 26);
			this.FailedToolStripMenuItem.Text = "failed";
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(104, 24);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(104, 24);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.TOpacity.Interval = 1;
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 365);
			this.PB.Margin = new global::System.Windows.Forms.Padding(4);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(675, 12);
			this.PB.TabIndex = 6;
			this.BoxTitle.BackColor = global::System.Drawing.Color.Black;
			this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.BoxTitle.ErrorImage = null;
			this.BoxTitle.InitialImage = null;
			this.BoxTitle.Location = new global::System.Drawing.Point(0, 377);
			this.BoxTitle.Margin = new global::System.Windows.Forms.Padding(4);
			this.BoxTitle.Name = "BoxTitle";
			this.BoxTitle.Size = new global::System.Drawing.Size(675, 22);
			this.BoxTitle.TabIndex = 7;
			this.BoxTitle.TabStop = false;
			this.DrakeUIAvatar1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.DrakeUIAvatar1.BackColor = global::System.Drawing.Color.Transparent;
			this.DrakeUIAvatar1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIAvatar1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIAvatar1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIAvatar1.Location = new global::System.Drawing.Point(597, 284);
			this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
			this.DrakeUIAvatar1.Size = new global::System.Drawing.Size(56, 46);
			this.DrakeUIAvatar1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIAvatar1.Symbol = 61579;
			this.DrakeUIAvatar1.TabIndex = 9;
			this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Send SMS");
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(675, 399);
			base.Controls.Add(this.DrakeUIAvatar1);
			base.Controls.Add(this.DGV0);
			base.Controls.Add(this.PB);
			base.Controls.Add(this.BoxTitle);
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "SMSManager";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "SMSManager";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ContextMenuStrip1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A3E RID: 2622
		private global::System.ComponentModel.Container components;
	}
}
