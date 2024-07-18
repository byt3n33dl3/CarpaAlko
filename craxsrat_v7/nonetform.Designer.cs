namespace Craxs_Rat
{
	// Token: 0x020000BE RID: 190
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class nonetform : global::System.Windows.Forms.Form
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x00093240 File Offset: 0x00091440
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

		// Token: 0x06000DFC RID: 3580 RVA: 0x00093284 File Offset: 0x00091484
		private void InitializeComponent()
		{
			this.DrakeUIAvatar1 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DrakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
			base.SuspendLayout();
			this.DrakeUIAvatar1.AvatarSize = 45;
			this.DrakeUIAvatar1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIAvatar1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.DrakeUIAvatar1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIAvatar1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar1.Icon = global::DrakeUI.Framework.DrakeUIAvatar.UIIcon.Text;
			this.DrakeUIAvatar1.Location = new global::System.Drawing.Point(371, 0);
			this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
			this.DrakeUIAvatar1.Size = new global::System.Drawing.Size(65, 66);
			this.DrakeUIAvatar1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIAvatar1.StyleCustomMode = true;
			this.DrakeUIAvatar1.Symbol = 61452;
			this.DrakeUIAvatar1.SymbolSize = 25;
			this.DrakeUIAvatar1.TabIndex = 0;
			this.DrakeUIAvatar1.Text = "OK";
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			this.Label1.Location = new global::System.Drawing.Point(71, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(300, 66);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "No internet Connection.\r\n\r\nPlease Check you internet and try again.";
			this.Label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.DrakeUIAvatar2.AvatarSize = 45;
			this.DrakeUIAvatar2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DrakeUIAvatar2.FillColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar2.ForeColor = global::System.Drawing.Color.Black;
			this.DrakeUIAvatar2.Location = new global::System.Drawing.Point(0, 0);
			this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
			this.DrakeUIAvatar2.Size = new global::System.Drawing.Size(71, 66);
			this.DrakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIAvatar2.StyleCustomMode = true;
			this.DrakeUIAvatar2.Symbol = 61553;
			this.DrakeUIAvatar2.SymbolSize = 25;
			this.DrakeUIAvatar2.TabIndex = 2;
			this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(436, 66);
			base.ControlBox = false;
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.DrakeUIAvatar2);
			base.Controls.Add(this.DrakeUIAvatar1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "nonetform";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "nonetform";
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x040007BB RID: 1979
		private global::System.IDisposable components;
	}
}
