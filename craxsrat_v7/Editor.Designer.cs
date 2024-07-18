namespace Craxs_Rat
{
	// Token: 0x020000B5 RID: 181
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Editor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x0007E4F8 File Offset: 0x0007C6F8
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

		// Token: 0x06000C06 RID: 3078 RVA: 0x0007E53C File Offset: 0x0007C73C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.EditText = new global::System.Windows.Forms.RichTextBox();
			this.b_ok = new global::System.Windows.Forms.Button();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.CMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Panel1.SuspendLayout();
			this.CMenu.SuspendLayout();
			base.SuspendLayout();
			this.EditText.BackColor = global::System.Drawing.Color.Black;
			this.EditText.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.EditText.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.EditText.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.EditText.Location = new global::System.Drawing.Point(0, 0);
			this.EditText.Name = "EditText";
			this.EditText.Size = new global::System.Drawing.Size(414, 213);
			this.EditText.TabIndex = 1;
			this.EditText.Text = "";
			this.EditText.WordWrap = false;
			this.b_ok.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.b_ok.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.b_ok.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b_ok.ForeColor = global::System.Drawing.Color.Black;
			this.b_ok.Location = new global::System.Drawing.Point(343, 3);
			this.b_ok.Name = "b_ok";
			this.b_ok.Size = new global::System.Drawing.Size(67, 23);
			this.b_ok.TabIndex = 2;
			this.b_ok.Text = "save";
			this.b_ok.UseVisualStyleBackColor = false;
			this.b_ok.Visible = false;
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.b_ok);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.Panel1.Location = new global::System.Drawing.Point(0, 213);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(414, 28);
			this.Panel1.TabIndex = 3;
			this.TOpacity.Interval = 1;
			this.CMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CutToolStripMenuItem,
				this.CopyToolStripMenuItem,
				this.PasteToolStripMenuItem
			});
			this.CMenu.Name = "CMenu";
			this.CMenu.ShowImageMargin = false;
			this.CMenu.Size = new global::System.Drawing.Size(156, 92);
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
			base.Controls.Add(this.EditText);
			base.Controls.Add(this.Panel1);
			base.Name = "Editor";
			base.Opacity = 0.0;
			this.Text = "Editor";
			this.Panel1.ResumeLayout(false);
			this.CMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040006B1 RID: 1713
		private global::System.ComponentModel.Container components;
	}
}
