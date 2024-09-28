using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000BD RID: 189
	[DesignerGenerated]
	public partial class LanguageSelector : Form
	{
		// Token: 0x06000DEC RID: 3564 RVA: 0x00092A9C File Offset: 0x00090C9C
		public LanguageSelector()
		{
			this.string_0 = "";
			this.InitializeComponent();
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00006A0C File Offset: 0x00004C0C
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x000930E4 File Offset: 0x000912E4
		internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1 { get; set; }

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00006A14 File Offset: 0x00004C14
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x000930F8 File Offset: 0x000912F8
		internal virtual DrakeUIButton copydev
		{
			[CompilerGenerated]
			get
			{
				return this._copydev;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.copydev_Click);
				DrakeUIButton copydev = this._copydev;
				if (copydev != null)
				{
					copydev.Click -= value2;
				}
				this._copydev = value;
				copydev = this._copydev;
				if (copydev != null)
				{
					copydev.Click += value2;
				}
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00006A1C File Offset: 0x00004C1C
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0009313C File Offset: 0x0009133C
		internal virtual DrakeUIButton DrakeUIButton1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButton1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButton1_Click);
				DrakeUIButton drakeUIButton = this._DrakeUIButton1;
				if (drakeUIButton != null)
				{
					drakeUIButton.Click -= value2;
				}
				this._DrakeUIButton1 = value;
				drakeUIButton = this._DrakeUIButton1;
				if (drakeUIButton != null)
				{
					drakeUIButton.Click += value2;
				}
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00006A24 File Offset: 0x00004C24
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00093180 File Offset: 0x00091380
		internal virtual DrakeUIButton DrakeUIButton2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButton2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButton2_Click);
				DrakeUIButton drakeUIButton = this._DrakeUIButton2;
				if (drakeUIButton != null)
				{
					drakeUIButton.Click -= value2;
				}
				this._DrakeUIButton2 = value;
				drakeUIButton = this._DrakeUIButton2;
				if (drakeUIButton != null)
				{
					drakeUIButton.Click += value2;
				}
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000931C4 File Offset: 0x000913C4
		private void copydev_Click(object sender, EventArgs e)
		{
			this.string_0 = "AR";
			base.Close();
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000931E4 File Offset: 0x000913E4
		private void DrakeUIButton1_Click(object sender, EventArgs e)
		{
			this.string_0 = "EN";
			base.Close();
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00093204 File Offset: 0x00091404
		private void DrakeUIButton2_Click(object sender, EventArgs e)
		{
			this.string_0 = "CN";
			base.Close();
		}

		// Token: 0x040007BA RID: 1978
		public string string_0;
	}
}
