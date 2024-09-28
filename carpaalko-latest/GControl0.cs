using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Craxs_Rat
{
	// Token: 0x0200010F RID: 271
	public class GControl0 : Control
	{
		// Token: 0x06001321 RID: 4897 RVA: 0x000CFA98 File Offset: 0x000CDC98
		public GControl0()
		{
			this.ToolTip = new ToolTip();
			ToolTip toolTip = this.ToolTip;
			this.ToolTip.Active = false;
			this.ToolTip.UseAnimation = true;
			this.ToolTip.UseFading = true;
			this.ToolTip.AutomaticDelay = 1000;
			this.ToolTip.AutoPopDelay = 18000;
			this.ToolTip.OwnerDraw = true;
			this.ToolTip.BackColor = Module5.color_0;
			this.ToolTip.Popup += this.ToolTip_Popup;
			this.ToolTip.Draw += this.ToolTip_Draw;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x000075C1 File Offset: 0x000057C1
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x000CFB4C File Offset: 0x000CDD4C
		public virtual ToolTip ToolTip
		{
			[CompilerGenerated]
			get
			{
				return this.__ToolTip;
			}
			[CompilerGenerated]
			set
			{
				PopupEventHandler value2 = new PopupEventHandler(this.ToolTip_Popup);
				DrawToolTipEventHandler value3 = new DrawToolTipEventHandler(this.ToolTip_Draw);
				ToolTip _ToolTip = this.__ToolTip;
				if (_ToolTip != null)
				{
					_ToolTip.Popup -= value2;
					_ToolTip.Draw -= value3;
				}
				this.__ToolTip = value;
				_ToolTip = this.__ToolTip;
				if (_ToolTip != null)
				{
					_ToolTip.Popup += value2;
					_ToolTip.Draw += value3;
				}
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000CFBAC File Offset: 0x000CDDAC
		private void ToolTip_Popup(object sender, PopupEventArgs e)
		{
			Size toolTipSize = TextRenderer.MeasureText(this.ToolTip.GetToolTip((Control)e.AssociatedWindow), Module8.font_1);
			checked
			{
				toolTipSize.Width += 16;
				toolTipSize.Height += 10;
				e.ToolTipSize = toolTipSize;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000CFC04 File Offset: 0x000CDE04
		private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
		{
			e.DrawBackground();
			Rectangle bounds = new Rectangle(0, 0, e.Bounds.Width, e.Bounds.Height);
			ControlPaint.DrawBorder(e.Graphics, bounds, Module5.White, ButtonBorderStyle.Solid);
			using (StringFormat stringFormat = new StringFormat())
			{
				stringFormat.Alignment = StringAlignment.Near;
				stringFormat.LineAlignment = StringAlignment.Center;
				Rectangle r = new Rectangle(0, 0, e.Bounds.Width, e.Bounds.Height);
				e.Graphics.MeasureString(e.ToolTipText, Module8.font_1);
				e.Graphics.DrawString(e.ToolTipText, Module8.font_1, new SolidBrush(Module5.White), r, stringFormat);
			}
		}

		// Token: 0x04000CE6 RID: 3302
		[AccessedThroughProperty("_ToolTip")]
		[CompilerGenerated]
		private ToolTip __ToolTip;
	}
}
