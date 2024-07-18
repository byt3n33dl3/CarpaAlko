namespace Craxs_Rat
{
	// Token: 0x020000D2 RID: 210
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Icons : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x000A7D20 File Offset: 0x000A5F20
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

		// Token: 0x06000F9D RID: 3997 RVA: 0x000A7D64 File Offset: 0x000A5F64
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
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
				this.Column2,
				this.Column3,
				this.Column4
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(0, 120, 215);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.White;
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
			this.DGV0.Size = new global::System.Drawing.Size(388, 334);
			this.DGV0.TabIndex = 5;
			this.Column1.FillWeight = 24f;
			this.Column1.HeaderText = "icon";
			this.Column1.Name = "Column1";
			this.Column1.Width = 34;
			this.Column2.HeaderText = "name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 61;
			this.Column3.HeaderText = "sizes (px)\t";
			this.Column3.Name = "Column3";
			this.Column3.Width = 84;
			this.Column4.HeaderText = "size";
			this.Column4.Name = "Column4";
			this.Column4.Width = 53;
			this.TOpacity.Interval = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(388, 334);
			base.Controls.Add(this.DGV0);
			base.Name = "Icons";
			base.Opacity = 0.0;
			base.ShowInTaskbar = false;
			this.Text = "Icons";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400088A RID: 2186
		private global::System.ComponentModel.Container components;
	}
}
