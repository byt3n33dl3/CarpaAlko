namespace Craxs_Rat
{
	// Token: 0x020000B1 RID: 177
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Dialog1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x0007B874 File Offset: 0x00079A74
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0007B8B8 File Offset: 0x00079AB8
		private void InitializeComponent()
		{
			this.Mytext = new global::System.Windows.Forms.TextBox();
			this.Mytitle = new global::System.Windows.Forms.Label();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			base.SuspendLayout();
			this.Mytext.Font = new global::System.Drawing.Font("Palatino Linotype", 10f, global::System.Drawing.FontStyle.Bold);
			this.Mytext.Location = new global::System.Drawing.Point(16, 57);
			this.Mytext.Margin = new global::System.Windows.Forms.Padding(4);
			this.Mytext.Name = "Mytext";
			this.Mytext.Size = new global::System.Drawing.Size(643, 30);
			this.Mytext.TabIndex = 1;
			this.Mytitle.AutoSize = true;
			this.Mytitle.Font = new global::System.Drawing.Font("Palatino Linotype", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Mytitle.ForeColor = global::System.Drawing.Color.White;
			this.Mytitle.Location = new global::System.Drawing.Point(16, 7);
			this.Mytitle.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Mytitle.Name = "Mytitle";
			this.Mytitle.Size = new global::System.Drawing.Size(168, 46);
			this.Mytitle.TabIndex = 3;
			this.Mytitle.Text = "Craxs Rat";
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(550, 105);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(109, 35);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.TabIndex = 4;
			this.DrakeUIButtonIcon1.Text = "OK";
			this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(399, 105);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(109, 35);
			this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon2.Symbol = 61453;
			this.DrakeUIButtonIcon2.TabIndex = 5;
			this.DrakeUIButtonIcon2.Text = "Cancel";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(672, 152);
			base.ControlBox = false;
			base.Controls.Add(this.DrakeUIButtonIcon2);
			base.Controls.Add(this.DrakeUIButtonIcon1);
			base.Controls.Add(this.Mytitle);
			base.Controls.Add(this.Mytext);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Dialog1";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000676 RID: 1654
		private global::System.IDisposable components;
	}
}
