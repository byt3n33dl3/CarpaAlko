namespace Craxs_Rat
{
	// Token: 0x020000A2 RID: 162
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AppsProperties : global::System.Windows.Forms.Form
	{
		// Token: 0x060008AF RID: 2223 RVA: 0x000418E0 File Offset: 0x0003FAE0
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

		// Token: 0x060008B0 RID: 2224 RVA: 0x00041924 File Offset: 0x0003FB24
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.BoxIcons = new global::System.Windows.Forms.PictureBox();
			this.BOXPNL1 = new global::System.Windows.Forms.Panel();
			this.LAppInstallTime = new global::System.Windows.Forms.Label();
			this.LAppFlag = new global::System.Windows.Forms.Label();
			this.LAppName = new global::System.Windows.Forms.Label();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.LPermissions = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.BoxIcons).BeginInit();
			this.BOXPNL1.SuspendLayout();
			base.SuspendLayout();
			this.BoxIcons.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.BoxIcons.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.BoxIcons.Location = new global::System.Drawing.Point(0, 0);
			this.BoxIcons.Name = "BoxIcons";
			this.BoxIcons.Size = new global::System.Drawing.Size(335, 196);
			this.BoxIcons.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.BoxIcons.TabIndex = 0;
			this.BoxIcons.TabStop = false;
			this.BOXPNL1.AutoScroll = true;
			this.BOXPNL1.BackColor = global::System.Drawing.Color.Black;
			this.BOXPNL1.Controls.Add(this.LPermissions);
			this.BOXPNL1.Controls.Add(this.LAppInstallTime);
			this.BOXPNL1.Controls.Add(this.LAppFlag);
			this.BOXPNL1.Controls.Add(this.LAppName);
			this.BOXPNL1.Controls.Add(this.BoxIcons);
			this.BOXPNL1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BOXPNL1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.BOXPNL1.Location = new global::System.Drawing.Point(0, 0);
			this.BOXPNL1.Name = "BOXPNL1";
			this.BOXPNL1.Size = new global::System.Drawing.Size(335, 474);
			this.BOXPNL1.TabIndex = 1;
			this.LAppInstallTime.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.LAppInstallTime.Location = new global::System.Drawing.Point(0, 270);
			this.LAppInstallTime.Name = "LAppInstallTime";
			this.LAppInstallTime.Size = new global::System.Drawing.Size(335, 37);
			this.LAppInstallTime.TabIndex = 3;
			this.LAppInstallTime.Text = "installTime ";
			this.LAppInstallTime.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.LAppFlag.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.LAppFlag.Location = new global::System.Drawing.Point(0, 233);
			this.LAppFlag.Name = "LAppFlag";
			this.LAppFlag.Size = new global::System.Drawing.Size(335, 37);
			this.LAppFlag.TabIndex = 2;
			this.LAppFlag.Text = "flag";
			this.LAppFlag.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.LAppName.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.LAppName.Location = new global::System.Drawing.Point(0, 196);
			this.LAppName.Name = "LAppName";
			this.LAppName.Size = new global::System.Drawing.Size(335, 37);
			this.LAppName.TabIndex = 1;
			this.LAppName.Text = "AppName";
			this.LAppName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.TOpacity.Interval = 1;
			this.LPermissions.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.LPermissions.Location = new global::System.Drawing.Point(0, 307);
			this.LPermissions.Name = "LPermissions";
			this.LPermissions.Size = new global::System.Drawing.Size(335, 37);
			this.LPermissions.TabIndex = 5;
			this.LPermissions.Text = "Permissions";
			this.LPermissions.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(335, 474);
			base.Controls.Add(this.BOXPNL1);
			base.Name = "AppsProperties";
			base.Opacity = 0.0;
			this.Text = "Properties";
			((global::System.ComponentModel.ISupportInitialize)this.BoxIcons).EndInit();
			this.BOXPNL1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400048B RID: 1163
		private global::System.ComponentModel.Container components;
	}
}
