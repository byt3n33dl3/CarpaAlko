namespace Craxs_Rat
{
	// Token: 0x020000AC RID: 172
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ClipboardManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x000756A8 File Offset: 0x000738A8
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

		// Token: 0x06000ADE RID: 2782 RVA: 0x000756EC File Offset: 0x000738EC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.BTN_SET = new global::System.Windows.Forms.Button();
			this.BTN_GET = new global::System.Windows.Forms.Button();
			this.BoxClipboard = new global::System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TOpacity.Interval = 1;
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.BTN_SET);
			this.Panel1.Controls.Add(this.BTN_GET);
			this.Panel1.Controls.Add(this.BoxClipboard);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(373, 204);
			this.Panel1.TabIndex = 3;
			this.BTN_SET.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BTN_SET.Location = new global::System.Drawing.Point(286, 104);
			this.BTN_SET.Name = "BTN_SET";
			this.BTN_SET.Size = new global::System.Drawing.Size(75, 23);
			this.BTN_SET.TabIndex = 3;
			this.BTN_SET.Text = "SET";
			this.BTN_SET.UseVisualStyleBackColor = true;
			this.BTN_GET.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BTN_GET.Location = new global::System.Drawing.Point(286, 75);
			this.BTN_GET.Name = "BTN_GET";
			this.BTN_GET.Size = new global::System.Drawing.Size(75, 23);
			this.BTN_GET.TabIndex = 1;
			this.BTN_GET.Text = "GET";
			this.BTN_GET.UseVisualStyleBackColor = true;
			this.BoxClipboard.BackColor = global::System.Drawing.Color.Black;
			this.BoxClipboard.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.BoxClipboard.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.BoxClipboard.Location = new global::System.Drawing.Point(21, 28);
			this.BoxClipboard.Multiline = true;
			this.BoxClipboard.Name = "BoxClipboard";
			this.BoxClipboard.Size = new global::System.Drawing.Size(247, 147);
			this.BoxClipboard.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(373, 204);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "ClipboardManager";
			base.Opacity = 0.0;
			this.Text = "ClipboardManager";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000619 RID: 1561
		private global::System.ComponentModel.Container components;
	}
}
