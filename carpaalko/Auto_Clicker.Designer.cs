namespace Craxs_Rat
{
	// Token: 0x02000036 RID: 54
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Auto_Clicker : global::System.Windows.Forms.Form
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x000226C4 File Offset: 0x000208C4
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

		// Token: 0x060003F0 RID: 1008 RVA: 0x00022708 File Offset: 0x00020908
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.statustext = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.clientimage = new global::System.Windows.Forms.PictureBox();
			this.DrakeUIButtonIcon5 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon4 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.refreshbtn = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.selectedrecord = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.clientimage).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.statustext);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new global::System.Drawing.Point(0, 866);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(578, 33);
			this.Panel1.TabIndex = 4;
			this.statustext.BackColor = global::System.Drawing.Color.Black;
			this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.statustext.ForeColor = global::System.Drawing.Color.Lime;
			this.statustext.Location = new global::System.Drawing.Point(0, 0);
			this.statustext.Name = "statustext";
			this.statustext.Size = new global::System.Drawing.Size(578, 33);
			this.statustext.TabIndex = 0;
			this.statustext.Text = "...";
			this.statustext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.clientimage);
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon5);
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon4);
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon3);
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
			this.Panel2.Controls.Add(this.refreshbtn);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.selectedrecord);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(578, 158);
			this.Panel2.TabIndex = 5;
			this.clientimage.Location = new global::System.Drawing.Point(12, 49);
			this.clientimage.Name = "clientimage";
			this.clientimage.Size = new global::System.Drawing.Size(71, 66);
			this.clientimage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.clientimage.TabIndex = 36;
			this.clientimage.TabStop = false;
			this.DrakeUIButtonIcon5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon5.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon5.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon5.Location = new global::System.Drawing.Point(380, 84);
			this.DrakeUIButtonIcon5.Name = "DrakeUIButtonIcon5";
			this.DrakeUIButtonIcon5.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon5.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon5.Size = new global::System.Drawing.Size(104, 66);
			this.DrakeUIButtonIcon5.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon5.Symbol = 61584;
			this.DrakeUIButtonIcon5.TabIndex = 35;
			this.DrakeUIButtonIcon5.Text = "Repeat";
			this.DrakeUIButtonIcon4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon4.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon4.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon4.Location = new global::System.Drawing.Point(210, 85);
			this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
			this.DrakeUIButtonIcon4.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon4.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon4.Size = new global::System.Drawing.Size(104, 66);
			this.DrakeUIButtonIcon4.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon4.Symbol = 61741;
			this.DrakeUIButtonIcon4.TabIndex = 34;
			this.DrakeUIButtonIcon4.Text = "Clear";
			this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(210, 13);
			this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
			this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(104, 66);
			this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon3.Symbol = 61517;
			this.DrakeUIButtonIcon3.TabIndex = 33;
			this.DrakeUIButtonIcon3.Text = "Record";
			this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(107, 85);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(97, 66);
			this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon2.Symbol = 61516;
			this.DrakeUIButtonIcon2.TabIndex = 32;
			this.DrakeUIButtonIcon2.Text = "Stop";
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(107, 12);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(97, 66);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 61515;
			this.DrakeUIButtonIcon1.TabIndex = 31;
			this.DrakeUIButtonIcon1.Text = "Start";
			this.refreshbtn.AvatarSize = 45;
			this.refreshbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.refreshbtn.FillColor = global::System.Drawing.Color.Transparent;
			this.refreshbtn.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.refreshbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.refreshbtn.Location = new global::System.Drawing.Point(541, 47);
			this.refreshbtn.Name = "refreshbtn";
			this.refreshbtn.Size = new global::System.Drawing.Size(32, 32);
			this.refreshbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.refreshbtn.Symbol = 61473;
			this.refreshbtn.SymbolSize = 25;
			this.refreshbtn.TabIndex = 30;
			this.refreshbtn.Text = "DrakeUIAvatar3";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			this.Label1.Location = new global::System.Drawing.Point(387, 19);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(84, 25);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Records";
			this.selectedrecord.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.selectedrecord.FillColor = global::System.Drawing.Color.Black;
			this.selectedrecord.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.selectedrecord.ForeColor = global::System.Drawing.Color.White;
			this.selectedrecord.Location = new global::System.Drawing.Point(343, 49);
			this.selectedrecord.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.selectedrecord.MinimumSize = new global::System.Drawing.Size(63, 0);
			this.selectedrecord.Name = "selectedrecord";
			this.selectedrecord.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.selectedrecord.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.selectedrecord.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.selectedrecord.Size = new global::System.Drawing.Size(191, 30);
			this.selectedrecord.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.selectedrecord.TabIndex = 5;
			this.selectedrecord.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Panel3.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel3.Location = new global::System.Drawing.Point(0, 158);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(578, 708);
			this.Panel3.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(578, 899);
			base.Controls.Add(this.Panel3);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Auto_Clicker";
			base.ShowIcon = false;
			this.Text = "Auto Clicker";
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.clientimage).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001CA RID: 458
		private global::System.IDisposable components;
	}
}
