using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000BE RID: 190
	[DesignerGenerated]
	public partial class nonetform : Form
	{
		// Token: 0x06000DFA RID: 3578 RVA: 0x00093224 File Offset: 0x00091424
		public nonetform()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00006A2C File Offset: 0x00004C2C
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000935E4 File Offset: 0x000917E4
		internal virtual DrakeUIAvatar DrakeUIAvatar1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar1_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar1 = value;
				drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00006A34 File Offset: 0x00004C34
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00093628 File Offset: 0x00091828
		internal virtual Label Label1 { get; set; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00006A3C File Offset: 0x00004C3C
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x0009363C File Offset: 0x0009183C
		internal virtual DrakeUIAvatar DrakeUIAvatar2 { get; set; }

		// Token: 0x06000E03 RID: 3587 RVA: 0x00093650 File Offset: 0x00091850
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			base.Close();
			this.method_1();
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0009366C File Offset: 0x0009186C
		public void method_1()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) == 0)
			{
				this.Label1.Text = "لا يوجد اتصال بالإنترنت.\r\n\r\nيرجى التحقق من الإنترنت الخاص بك وحاول مرة أخرى.";
			}
			else if (Operators.CompareString(left, "CN", false) != 0)
			{
				this.Label1.Text = "No internet Connection.\r\n\r\nPlease Check your internet and try again.";
			}
			else
			{
				this.Label1.Text = "没有网络连接。\r\n\r\n请检查您的互联网并重试。";
			}
		}
	}
}
