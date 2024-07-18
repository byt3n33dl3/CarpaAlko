using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Craxs_Rat
{
	// Token: 0x0200010D RID: 269
	public class GRichTextBox0 : RichTextBox
	{
		// Token: 0x06001311 RID: 4881 RVA: 0x000CEC24 File Offset: 0x000CCE24
		public GRichTextBox0()
		{
			base.SetStyle(ControlStyles.EnableNotifyMessage, true);
			GRichTextBox0.HideCaret(base.Handle);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000CEC50 File Offset: 0x000CCE50
		protected override void WndProc(ref Message m)
		{
			if (m.Msg != 522 || !this.bool_0)
			{
				base.WndProc(ref m);
			}
			GRichTextBox0.HideCaret(base.Handle);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x000CEC88 File Offset: 0x000CCE88
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control)
			{
				this.bool_0 = true;
			}
			base.OnKeyDown(e);
			GRichTextBox0.HideCaret(base.Handle);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000CECC0 File Offset: 0x000CCEC0
		protected override void OnKeyUp(KeyEventArgs e)
		{
			this.bool_0 = false;
			base.OnKeyUp(e);
			GRichTextBox0.HideCaret(base.Handle);
		}

		// Token: 0x06001315 RID: 4885
		[DllImport("user32.dll")]
		public static extern bool HideCaret(IntPtr hWnd);

		// Token: 0x04000CD3 RID: 3283
		private bool bool_0;
	}
}
