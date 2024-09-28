using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000B1 RID: 177
	[DesignerGenerated]
	public partial class Dialog1 : Form
	{
		// Token: 0x06000BA2 RID: 2978 RVA: 0x0007B848 File Offset: 0x00079A48
		public Dialog1()
		{
			base.Load += this.Dialog1_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0000639D File Offset: 0x0000459D
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0007BCE0 File Offset: 0x00079EE0
		internal virtual TextBox Mytext { get; set; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x000063A5 File Offset: 0x000045A5
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x0007BCF4 File Offset: 0x00079EF4
		internal virtual Label Mytitle { get; set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x000063AD File Offset: 0x000045AD
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x0007BD08 File Offset: 0x00079F08
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon1_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon1 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000063B5 File Offset: 0x000045B5
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x0007BD4C File Offset: 0x00079F4C
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon2_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon2 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0007BD90 File Offset: 0x00079F90
		private void Dialog1_Load(object sender, EventArgs e)
		{
			this.Mytitle.Text = this.string_0;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0007BDB0 File Offset: 0x00079FB0
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			this.string_1 = this.Mytext.Text;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0007BDDC File Offset: 0x00079FDC
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x0400067B RID: 1659
		public string string_0;

		// Token: 0x0400067C RID: 1660
		public string string_1;
	}
}
