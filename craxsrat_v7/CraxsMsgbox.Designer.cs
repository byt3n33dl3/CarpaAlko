namespace Craxs_Rat
{
	// Token: 0x02000022 RID: 34
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CraxsMsgbox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000222 RID: 546 RVA: 0x000117A8 File Offset: 0x0000F9A8
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

		// Token: 0x06000223 RID: 547 RVA: 0x000117EC File Offset: 0x0000F9EC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.okbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.nobtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.msgtext = new global::System.Windows.Forms.Label();
			this.titletext = new global::DrakeUI.Framework.DrakeUITitlePanel();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1.SuspendLayout();
			this.titletext.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.okbtn);
			this.Panel1.Controls.Add(this.nobtn);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new global::System.Drawing.Point(0, 230);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(688, 39);
			this.Panel1.TabIndex = 0;
			this.okbtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.okbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.okbtn.FillColor = global::System.Drawing.Color.Black;
			this.okbtn.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.okbtn.ForeColor = global::System.Drawing.Color.Lime;
			this.okbtn.Location = new global::System.Drawing.Point(589, 3);
			this.okbtn.Name = "okbtn";
			this.okbtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.okbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.okbtn.Size = new global::System.Drawing.Size(87, 28);
			this.okbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.okbtn.TabIndex = 1;
			this.okbtn.Text = "OK";
			this.nobtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.nobtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nobtn.FillColor = global::System.Drawing.Color.Black;
			this.nobtn.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.nobtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.nobtn.Location = new global::System.Drawing.Point(487, 3);
			this.nobtn.Name = "nobtn";
			this.nobtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.nobtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.nobtn.Size = new global::System.Drawing.Size(87, 28);
			this.nobtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.nobtn.Symbol = 61453;
			this.nobtn.TabIndex = 0;
			this.nobtn.Text = "NO";
			this.msgtext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.msgtext.Font = new global::System.Drawing.Font("Roboto", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.msgtext.Location = new global::System.Drawing.Point(0, 35);
			this.msgtext.Name = "msgtext";
			this.msgtext.Size = new global::System.Drawing.Size(688, 195);
			this.msgtext.TabIndex = 2;
			this.msgtext.Text = "you are the only responsible for using this program\r\nOnly install in phone you have permissions to";
			this.msgtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.titletext.Controls.Add(this.msgtext);
			this.titletext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.titletext.FillColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
			this.titletext.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.titletext.ForeColor = global::System.Drawing.Color.White;
			this.titletext.Location = new global::System.Drawing.Point(0, 0);
			this.titletext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.titletext.Name = "titletext";
			this.titletext.Padding = new global::System.Windows.Forms.Padding(0, 35, 0, 0);
			this.titletext.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.titletext.Size = new global::System.Drawing.Size(688, 230);
			this.titletext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.titletext.TabIndex = 3;
			this.titletext.Text = "title";
			this.titletext.TitleColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Panel2.Controls.Add(this.titletext);
			this.Panel2.Controls.Add(this.Panel1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(688, 269);
			this.Panel2.TabIndex = 3;
			this.Timer1.Interval = 500;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(688, 269);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "CraxsMsgbox";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CraxsMsgbox";
			base.TopMost = true;
			this.Panel1.ResumeLayout(false);
			this.titletext.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400007E RID: 126
		private global::System.ComponentModel.Container components;
	}
}
