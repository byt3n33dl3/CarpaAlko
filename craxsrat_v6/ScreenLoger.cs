using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000C2 RID: 194
	[DesignerGenerated]
	public partial class ScreenLoger : Form
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x00096E1C File Offset: 0x0009501C
		public ScreenLoger()
		{
			this.method_1();
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00096E7C File Offset: 0x0009507C
		private void method_0()
		{
			this.Logs = new TextBox();
			base.SuspendLayout();
			this.Logs.BackColor = Color.Black;
			this.Logs.BorderStyle = BorderStyle.None;
			this.Logs.Dock = DockStyle.Fill;
			this.Logs.Font = new Font("Microsoft PhagsPa", 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Logs.ForeColor = Color.White;
			this.Logs.Location = new Point(0, 0);
			this.Logs.Multiline = true;
			this.Logs.Name = "Logs";
			this.Logs.ReadOnly = true;
			this.Logs.ScrollBars = ScrollBars.Vertical;
			this.Logs.Size = new Size(524, 601);
			this.Logs.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(524, 601);
			base.ControlBox = false;
			base.Controls.Add(this.Logs);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "ScreenLoger";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "ScreenLoger";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00006B3C File Offset: 0x00004D3C
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00096FDC File Offset: 0x000951DC
		internal virtual TextBox Logs { get; set; }

		// Token: 0x06000E5F RID: 3679 RVA: 0x00006B44 File Offset: 0x00004D44
		public void method_1()
		{
			this.method_0();
		}
	}
}
