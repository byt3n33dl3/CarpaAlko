namespace Craxs_Rat
{
	// Token: 0x02000032 RID: 50
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class smsMaker : global::System.Windows.Forms.Form
	{
		// Token: 0x06000389 RID: 905 RVA: 0x0001F78C File Offset: 0x0001D98C
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

		// Token: 0x0600038A RID: 906 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.phonetext = new global::DrakeUI.Framework.DrakeUITextBox();
			this.msgtext = new global::DrakeUI.Framework.DrakeUITextBox();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label34 = new global::System.Windows.Forms.Label();
			this.numslist = new global::DrakeUI.Framework.DrakeUIListBox();
			this.remnum = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.addnum = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.selectlist = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.checkall = new global::DrakeUI.Framework.DrakeUICheckBox();
			base.SuspendLayout();
			this.phonetext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.phonetext.FillColor = global::System.Drawing.Color.White;
			this.phonetext.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.phonetext.Location = new global::System.Drawing.Point(101, 428);
			this.phonetext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.phonetext.Maximum = 2147483647.0;
			this.phonetext.Minimum = -2147483648.0;
			this.phonetext.Name = "phonetext";
			this.phonetext.Padding = new global::System.Windows.Forms.Padding(5);
			this.phonetext.RectColor = global::System.Drawing.Color.FromArgb(56, 142, 60);
			this.phonetext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.phonetext.Size = new global::System.Drawing.Size(227, 30);
			this.phonetext.Style = global::DrakeUI.Framework.UIStyle.Green;
			this.phonetext.TabIndex = 0;
			this.phonetext.TextAlignment = global::System.Drawing.ContentAlignment.BottomCenter;
			this.phonetext.Watermark = "Phone Number";
			this.msgtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.msgtext.FillColor = global::System.Drawing.Color.White;
			this.msgtext.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.msgtext.Location = new global::System.Drawing.Point(407, 39);
			this.msgtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.msgtext.Maximum = 2147483647.0;
			this.msgtext.MaxLength = 160;
			this.msgtext.Minimum = -2147483648.0;
			this.msgtext.Multiline = true;
			this.msgtext.Name = "msgtext";
			this.msgtext.Padding = new global::System.Windows.Forms.Padding(5);
			this.msgtext.RectColor = global::System.Drawing.Color.FromArgb(230, 80, 80);
			this.msgtext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.msgtext.Size = new global::System.Drawing.Size(366, 362);
			this.msgtext.Style = global::DrakeUI.Framework.UIStyle.Red;
			this.msgtext.StyleCustomMode = true;
			this.msgtext.TabIndex = 1;
			this.msgtext.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
			this.DrakeUIToolTip1.SetToolTip(this.msgtext, "Max limit 160");
			this.msgtext.Watermark = "";
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(638, 503);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(136, 35);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 61768;
			this.DrakeUIButtonIcon1.TabIndex = 2;
			this.DrakeUIButtonIcon1.Text = "Send";
			this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(487, 503);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(137, 35);
			this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon2.Symbol = 61453;
			this.DrakeUIButtonIcon2.TabIndex = 3;
			this.DrakeUIButtonIcon2.Text = "Cancel";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.Label1.Location = new global::System.Drawing.Point(116, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(163, 25);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Phones Numbers";
			this.Label34.AutoSize = true;
			this.Label34.BackColor = global::System.Drawing.Color.Transparent;
			this.Label34.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label34.ForeColor = global::System.Drawing.Color.White;
			this.Label34.Location = new global::System.Drawing.Point(584, 429);
			this.Label34.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label34.Name = "Label34";
			this.Label34.Size = new global::System.Drawing.Size(115, 24);
			this.Label34.TabIndex = 66;
			this.Label34.Text = "All contacts";
			this.numslist.FillColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
			this.numslist.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.numslist.ItemSelectBackColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.numslist.ItemSelectForeColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
			this.numslist.Location = new global::System.Drawing.Point(18, 39);
			this.numslist.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numslist.Name = "numslist";
			this.numslist.Padding = new global::System.Windows.Forms.Padding(2);
			this.numslist.RectColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.numslist.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.numslist.Size = new global::System.Drawing.Size(366, 362);
			this.numslist.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.numslist.StyleCustomMode = true;
			this.numslist.TabIndex = 67;
			this.numslist.Text = "DrakeUIListBox1";
			this.remnum.AvatarSize = 30;
			this.remnum.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.remnum.FillColor = global::System.Drawing.Color.Black;
			this.remnum.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.remnum.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.remnum.Location = new global::System.Drawing.Point(15, 429);
			this.remnum.Margin = new global::System.Windows.Forms.Padding(4);
			this.remnum.Name = "remnum";
			this.remnum.Size = new global::System.Drawing.Size(35, 30);
			this.remnum.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.remnum.Symbol = 61526;
			this.remnum.SymbolSize = 30;
			this.remnum.TabIndex = 69;
			this.remnum.Text = "DrakeUIAvatar2";
			this.DrakeUIToolTip1.SetToolTip(this.remnum, "Remove numer from list");
			this.addnum.AvatarSize = 30;
			this.addnum.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.addnum.FillColor = global::System.Drawing.Color.Black;
			this.addnum.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.addnum.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.addnum.Location = new global::System.Drawing.Point(58, 429);
			this.addnum.Margin = new global::System.Windows.Forms.Padding(4);
			this.addnum.Name = "addnum";
			this.addnum.Size = new global::System.Drawing.Size(35, 30);
			this.addnum.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.addnum.Symbol = 61525;
			this.addnum.SymbolSize = 30;
			this.addnum.TabIndex = 68;
			this.addnum.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.addnum, "add number to list");
			this.selectlist.AvatarSize = 30;
			this.selectlist.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.selectlist.FillColor = global::System.Drawing.Color.Black;
			this.selectlist.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.selectlist.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.selectlist.Location = new global::System.Drawing.Point(347, 428);
			this.selectlist.Margin = new global::System.Windows.Forms.Padding(4);
			this.selectlist.Name = "selectlist";
			this.selectlist.Size = new global::System.Drawing.Size(35, 30);
			this.selectlist.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.selectlist.Symbol = 61462;
			this.selectlist.SymbolSize = 30;
			this.selectlist.TabIndex = 70;
			this.selectlist.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.selectlist, "get numbers from text file");
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.Label2.Location = new global::System.Drawing.Point(531, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(129, 25);
			this.Label2.TabIndex = 71;
			this.Label2.Text = "Message text";
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.Black;
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.DrakeUIToolTip1.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.checkall.CheckBoxColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.checkall.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkall.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkall.Location = new global::System.Drawing.Point(535, 424);
			this.checkall.Name = "checkall";
			this.checkall.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkall.Size = new global::System.Drawing.Size(42, 29);
			this.checkall.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.checkall.StyleCustomMode = true;
			this.checkall.TabIndex = 72;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(786, 550);
			base.ControlBox = false;
			base.Controls.Add(this.checkall);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.selectlist);
			base.Controls.Add(this.remnum);
			base.Controls.Add(this.addnum);
			base.Controls.Add(this.numslist);
			base.Controls.Add(this.Label34);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.DrakeUIButtonIcon2);
			base.Controls.Add(this.DrakeUIButtonIcon1);
			base.Controls.Add(this.msgtext);
			base.Controls.Add(this.phonetext);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "smsMaker";
			base.ShowIcon = false;
			this.Text = "Create SMS";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400019C RID: 412
		private global::System.ComponentModel.Container components;
	}
}
