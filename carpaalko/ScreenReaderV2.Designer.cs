namespace Craxs_Rat
{
	// Token: 0x020000C7 RID: 199
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ScreenReaderV2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x000994D8 File Offset: 0x000976D8
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

		// Token: 0x06000E8E RID: 3726 RVA: 0x0009951C File Offset: 0x0009771C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.activetext = new global::System.Windows.Forms.Label();
			this.Save = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.disablebtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.enablebtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon4 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.presstimer = new global::System.Windows.Forms.Timer(this.components);
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.savetimer = new global::System.Windows.Forms.Timer(this.components);
			this.viewpic = new global::System.Windows.Forms.PictureBox();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.viewpic).BeginInit();
			base.SuspendLayout();
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.activetext);
			this.Panel2.Controls.Add(this.Save);
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
			this.Panel2.Controls.Add(this.disablebtn);
			this.Panel2.Controls.Add(this.enablebtn);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(518, 50);
			this.Panel2.TabIndex = 1;
			this.activetext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.activetext.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.activetext.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.activetext.Location = new global::System.Drawing.Point(141, 0);
			this.activetext.Name = "activetext";
			this.activetext.Size = new global::System.Drawing.Size(273, 50);
			this.activetext.TabIndex = 24;
			this.activetext.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Save.CheckBoxColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Save.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Save.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Save.Font = new global::System.Drawing.Font("Roboto", 10f);
			this.Save.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Save.Location = new global::System.Drawing.Point(414, 0);
			this.Save.Margin = new global::System.Windows.Forms.Padding(4);
			this.Save.Name = "Save";
			this.Save.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.Save.Size = new global::System.Drawing.Size(104, 50);
			this.Save.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Save.StyleCustomMode = true;
			this.Save.TabIndex = 23;
			this.Save.Text = "Record";
			this.Save.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.DrakeUIToolTip1.SetToolTip(this.Save, "Record Screen");
			this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(94, 0);
			this.DrakeUIButtonIcon2.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.Radius = 25;
			this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(47, 50);
			this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon2.Symbol = 57469;
			this.DrakeUIButtonIcon2.TabIndex = 22;
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon2, "Clear");
			this.disablebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.disablebtn.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.disablebtn.FillColor = global::System.Drawing.Color.Black;
			this.disablebtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.disablebtn.FillPressColor = global::System.Drawing.Color.Black;
			this.disablebtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.Font = new global::System.Drawing.Font("Arial", 12f);
			this.disablebtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.Location = new global::System.Drawing.Point(47, 0);
			this.disablebtn.Margin = new global::System.Windows.Forms.Padding(4);
			this.disablebtn.Name = "disablebtn";
			this.disablebtn.Radius = 25;
			this.disablebtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.disablebtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.disablebtn.RectHoverColor = global::System.Drawing.Color.White;
			this.disablebtn.RectPressColor = global::System.Drawing.Color.White;
			this.disablebtn.RectSelectedColor = global::System.Drawing.Color.White;
			this.disablebtn.Size = new global::System.Drawing.Size(47, 50);
			this.disablebtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.disablebtn.Symbol = 61534;
			this.disablebtn.TabIndex = 21;
			this.DrakeUIToolTip1.SetToolTip(this.disablebtn, "Stop");
			this.enablebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.enablebtn.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.enablebtn.FillColor = global::System.Drawing.Color.Black;
			this.enablebtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.enablebtn.FillPressColor = global::System.Drawing.Color.Black;
			this.enablebtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.Font = new global::System.Drawing.Font("Arial", 12f);
			this.enablebtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.Location = new global::System.Drawing.Point(0, 0);
			this.enablebtn.Margin = new global::System.Windows.Forms.Padding(4);
			this.enablebtn.Name = "enablebtn";
			this.enablebtn.Radius = 25;
			this.enablebtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.enablebtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.enablebtn.RectHoverColor = global::System.Drawing.Color.White;
			this.enablebtn.RectPressColor = global::System.Drawing.Color.White;
			this.enablebtn.RectSelectedColor = global::System.Drawing.Color.White;
			this.enablebtn.Size = new global::System.Drawing.Size(47, 50);
			this.enablebtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.enablebtn.Symbol = 61671;
			this.enablebtn.TabIndex = 20;
			this.DrakeUIToolTip1.SetToolTip(this.enablebtn, "Start");
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon4);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon3);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new global::System.Drawing.Point(0, 866);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(518, 27);
			this.Panel1.TabIndex = 2;
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(172, 0);
			this.DrakeUIButtonIcon1.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.Radius = 10;
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(174, 27);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 57353;
			this.DrakeUIButtonIcon1.TabIndex = 22;
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon1, "Home");
			this.DrakeUIButtonIcon4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.DrakeUIButtonIcon4.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon4.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon4.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon4.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon4.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.Location = new global::System.Drawing.Point(346, 0);
			this.DrakeUIButtonIcon4.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
			this.DrakeUIButtonIcon4.Radius = 10;
			this.DrakeUIButtonIcon4.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon4.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.Size = new global::System.Drawing.Size(172, 27);
			this.DrakeUIButtonIcon4.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon4.Symbol = 61524;
			this.DrakeUIButtonIcon4.TabIndex = 23;
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon4, "Return");
			this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(0, 0);
			this.DrakeUIButtonIcon3.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
			this.DrakeUIButtonIcon3.Radius = 10;
			this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(172, 27);
			this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon3.Symbol = 61641;
			this.DrakeUIButtonIcon3.SymbolSize = 20;
			this.DrakeUIButtonIcon3.TabIndex = 21;
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon3, "Recent");
			this.presstimer.Interval = 1000;
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.Black;
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.DrakeUIToolTip1.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.savetimer.Interval = 1000;
			this.viewpic.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewpic.Location = new global::System.Drawing.Point(0, 50);
			this.viewpic.Name = "viewpic";
			this.viewpic.Size = new global::System.Drawing.Size(518, 816);
			this.viewpic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.viewpic.TabIndex = 3;
			this.viewpic.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(518, 893);
			base.Controls.Add(this.viewpic);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "ScreenReaderV2";
			this.Text = "ScreenReaderV2";
			this.Panel2.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.viewpic).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007FE RID: 2046
		private global::System.ComponentModel.Container components;
	}
}
