namespace Craxs_Rat
{
	// Token: 0x020000CE RID: 206
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class WebViewMonitor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x000A1B70 File Offset: 0x0009FD70
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

		// Token: 0x06000F58 RID: 3928 RVA: 0x000A1BB4 File Offset: 0x0009FDB4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.SaveCheck = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.DrakeUIComboBox1 = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.Mytitle = new global::System.Windows.Forms.Label();
			this.TargetLink = new global::DrakeUI.Framework.DrakeUITextBox();
			this.DrakeUIButtonIcon7 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.statustext = new global::System.Windows.Forms.Label();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.DrakeUITabControl1 = new global::DrakeUI.Framework.DrakeUITabControl();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.vsbar = new global::DrakeUI.Framework.DrakeUIScrollBar();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.resulttext = new global::System.Windows.Forms.Label();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.BWloader = new global::System.ComponentModel.BackgroundWorker();
			this.timeloader = new global::System.Windows.Forms.Timer(this.components);
			this.vewimage = new global::System.Windows.Forms.PictureBox();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.DrakeUITabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.Panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vewimage).BeginInit();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.SaveCheck);
			this.Panel1.Controls.Add(this.DrakeUIComboBox1);
			this.Panel1.Controls.Add(this.Mytitle);
			this.Panel1.Controls.Add(this.TargetLink);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon7);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(991, 113);
			this.Panel1.TabIndex = 1;
			this.SaveCheck.CheckBoxColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.SaveCheck.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.SaveCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.SaveCheck.ForeColor = global::System.Drawing.Color.White;
			this.SaveCheck.Location = new global::System.Drawing.Point(869, 28);
			this.SaveCheck.Name = "SaveCheck";
			this.SaveCheck.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.SaveCheck.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.SaveCheck.Size = new global::System.Drawing.Size(97, 29);
			this.SaveCheck.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.SaveCheck.StyleCustomMode = true;
			this.SaveCheck.TabIndex = 22;
			this.SaveCheck.Text = "Record";
			this.SaveCheck.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.DrakeUIComboBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.DrakeUIComboBox1.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.DrakeUIComboBox1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIComboBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIComboBox1.ForeColor = global::System.Drawing.Color.White;
			this.DrakeUIComboBox1.Items.AddRange(new object[]
			{
				"Just Open",
				"Open + Monitor"
			});
			this.DrakeUIComboBox1.Location = new global::System.Drawing.Point(24, 71);
			this.DrakeUIComboBox1.Margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.DrakeUIComboBox1.MinimumSize = new global::System.Drawing.Size(84, 0);
			this.DrakeUIComboBox1.Name = "DrakeUIComboBox1";
			this.DrakeUIComboBox1.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.DrakeUIComboBox1.Radius = 15;
			this.DrakeUIComboBox1.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIComboBox1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIComboBox1.Size = new global::System.Drawing.Size(193, 30);
			this.DrakeUIComboBox1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIComboBox1.TabIndex = 21;
			this.DrakeUIComboBox1.Text = "Just Open";
			this.DrakeUIComboBox1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Mytitle.AutoSize = true;
			this.Mytitle.Font = new global::System.Drawing.Font("Palatino Linotype", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Mytitle.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Mytitle.Location = new global::System.Drawing.Point(16, 11);
			this.Mytitle.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Mytitle.Name = "Mytitle";
			this.Mytitle.Size = new global::System.Drawing.Size(295, 46);
			this.Mytitle.TabIndex = 20;
			this.Mytitle.Text = "CraxsRat Browser";
			this.TargetLink.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.TargetLink.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.TargetLink.FillColor = global::System.Drawing.Color.Black;
			this.TargetLink.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.TargetLink.ForeColor = global::System.Drawing.Color.White;
			this.TargetLink.Location = new global::System.Drawing.Point(227, 71);
			this.TargetLink.Margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.TargetLink.Maximum = 2147483647.0;
			this.TargetLink.Minimum = -2147483648.0;
			this.TargetLink.Name = "TargetLink";
			this.TargetLink.Padding = new global::System.Windows.Forms.Padding(7, 6, 7, 6);
			this.TargetLink.Radius = 15;
			this.TargetLink.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.TargetLink.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.TargetLink.Size = new global::System.Drawing.Size(613, 30);
			this.TargetLink.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.TargetLink.TabIndex = 19;
			this.TargetLink.Watermark = "Enter Link";
			this.TargetLink.WordWarp = false;
			this.DrakeUIButtonIcon7.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.DrakeUIButtonIcon7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon7.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon7.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon7.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon7.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon7.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon7.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon7.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon7.Location = new global::System.Drawing.Point(849, 69);
			this.DrakeUIButtonIcon7.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon7.Name = "DrakeUIButtonIcon7";
			this.DrakeUIButtonIcon7.Radius = 25;
			this.DrakeUIButtonIcon7.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon7.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon7.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon7.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon7.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon7.Size = new global::System.Drawing.Size(132, 32);
			this.DrakeUIButtonIcon7.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon7.Symbol = 57571;
			this.DrakeUIButtonIcon7.TabIndex = 18;
			this.DrakeUIButtonIcon7.Text = "Open";
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.statustext);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new global::System.Drawing.Point(0, 665);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(966, 22);
			this.Panel2.TabIndex = 2;
			this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.statustext.Font = new global::System.Drawing.Font("Palatino Linotype", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.statustext.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.statustext.Location = new global::System.Drawing.Point(0, 0);
			this.statustext.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.statustext.Name = "statustext";
			this.statustext.Size = new global::System.Drawing.Size(966, 22);
			this.statustext.TabIndex = 21;
			this.statustext.Text = "...";
			this.Panel3.Controls.Add(this.DrakeUITabControl1);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Panel3.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(991, 727);
			this.Panel3.TabIndex = 3;
			this.DrakeUITabControl1.Controls.Add(this.TabPage1);
			this.DrakeUITabControl1.Controls.Add(this.TabPage2);
			this.DrakeUITabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DrakeUITabControl1.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.DrakeUITabControl1.FillColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
			this.DrakeUITabControl1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUITabControl1.ItemSize = new global::System.Drawing.Size(420, 40);
			this.DrakeUITabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.DrakeUITabControl1.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUITabControl1.MenuStyle = global::DrakeUI.Framework.UIMenuStyle.Custom;
			this.DrakeUITabControl1.Multiline = true;
			this.DrakeUITabControl1.Name = "DrakeUITabControl1";
			this.DrakeUITabControl1.SelectedIndex = 0;
			this.DrakeUITabControl1.Size = new global::System.Drawing.Size(991, 727);
			this.DrakeUITabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.DrakeUITabControl1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUITabControl1.TabBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.DrakeUITabControl1.TabIndex = 2;
			this.DrakeUITabControl1.TabSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUITabControl1.TabSelectedForeColor = global::System.Drawing.Color.Black;
			this.DrakeUITabControl1.TabSelectedHighColor = global::System.Drawing.Color.Black;
			this.DrakeUITabControl1.TabUnSelectedForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.TabPage1.BackColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
			this.TabPage1.Controls.Add(this.vewimage);
			this.TabPage1.Controls.Add(this.Panel2);
			this.TabPage1.Controls.Add(this.vsbar);
			this.TabPage1.Controls.Add(this.Panel1);
			this.TabPage1.Location = new global::System.Drawing.Point(0, 40);
			this.TabPage1.Margin = new global::System.Windows.Forms.Padding(4);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new global::System.Drawing.Size(991, 687);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "General";
			this.vsbar.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.vsbar.FillColor = global::System.Drawing.Color.Black;
			this.vsbar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.vsbar.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.vsbar.Location = new global::System.Drawing.Point(966, 113);
			this.vsbar.Margin = new global::System.Windows.Forms.Padding(4);
			this.vsbar.Name = "vsbar";
			this.vsbar.PressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.vsbar.Size = new global::System.Drawing.Size(25, 574);
			this.vsbar.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.vsbar.TabIndex = 1;
			this.vsbar.Text = "DrakeUIScrollBar1";
			this.TabPage2.BackColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
			this.TabPage2.Controls.Add(this.resulttext);
			this.TabPage2.Controls.Add(this.Panel4);
			this.TabPage2.Location = new global::System.Drawing.Point(0, 40);
			this.TabPage2.Margin = new global::System.Windows.Forms.Padding(4);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new global::System.Drawing.Size(991, 687);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Custome";
			this.resulttext.BackColor = global::System.Drawing.Color.Black;
			this.resulttext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.resulttext.ForeColor = global::System.Drawing.Color.White;
			this.resulttext.Location = new global::System.Drawing.Point(0, 73);
			this.resulttext.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resulttext.Name = "resulttext";
			this.resulttext.Size = new global::System.Drawing.Size(991, 614);
			this.resulttext.TabIndex = 1;
			this.resulttext.Text = "Client Result";
			this.resulttext.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.Panel4.BackColor = global::System.Drawing.Color.Black;
			this.Panel4.Controls.Add(this.Label2);
			this.Panel4.Controls.Add(this.DrakeUIButtonIcon1);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel4.Location = new global::System.Drawing.Point(0, 0);
			this.Panel4.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(991, 73);
			this.Panel4.TabIndex = 2;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Palatino Linotype", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Label2.Location = new global::System.Drawing.Point(16, 11);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(267, 46);
			this.Label2.TabIndex = 20;
			this.Label2.Text = "Add Html View";
			this.DrakeUIButtonIcon1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Arial", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(748, 25);
			this.DrakeUIButtonIcon1.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.Radius = 25;
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(227, 32);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 61543;
			this.DrakeUIButtonIcon1.TabIndex = 18;
			this.DrakeUIButtonIcon1.Text = "Select Html File";
			this.timeloader.Interval = 30;
			this.vewimage.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.vewimage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.vewimage.Location = new global::System.Drawing.Point(0, 113);
			this.vewimage.Name = "vewimage";
			this.vewimage.Size = new global::System.Drawing.Size(966, 552);
			this.vewimage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.vewimage.TabIndex = 3;
			this.vewimage.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(991, 727);
			base.Controls.Add(this.Panel3);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "WebViewMonitor";
			base.ShowIcon = false;
			this.Text = "WebViewMonitor";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.DrakeUITabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.vewimage).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400086C RID: 2156
		private global::System.ComponentModel.Container components;
	}
}
