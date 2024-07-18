using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x0200002F RID: 47
	[DesignerGenerated]
	public partial class dia : Form
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0001CE38 File Offset: 0x0001B038
		public dia()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000026BF File Offset: 0x000008BF
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
		internal virtual TableLayoutPanel TableLayoutPanel1 { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000026C7 File Offset: 0x000008C7
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
		internal virtual Button OK_Button
		{
			[CompilerGenerated]
			get
			{
				return this._OK_Button;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OK_Button_Click);
				Button ok_Button = this._OK_Button;
				if (ok_Button != null)
				{
					ok_Button.Click -= value2;
				}
				this._OK_Button = value;
				ok_Button = this._OK_Button;
				if (ok_Button != null)
				{
					ok_Button.Click += value2;
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000026CF File Offset: 0x000008CF
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0001D508 File Offset: 0x0001B708
		internal virtual Button Cancel_Button
		{
			[CompilerGenerated]
			get
			{
				return this._Cancel_Button;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Cancel_Button_Click);
				Button cancel_Button = this._Cancel_Button;
				if (cancel_Button != null)
				{
					cancel_Button.Click -= value2;
				}
				this._Cancel_Button = value;
				cancel_Button = this._Cancel_Button;
				if (cancel_Button != null)
				{
					cancel_Button.Click += value2;
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600033F RID: 831 RVA: 0x000026D7 File Offset: 0x000008D7
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0001D54C File Offset: 0x0001B74C
		internal virtual MetroSetTextBox NewKey
		{
			[CompilerGenerated]
			get
			{
				return this._NewKey;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.NewKey_Click);
				MetroSetTextBox newKey = this._NewKey;
				if (newKey != null)
				{
					newKey.Click -= value2;
				}
				this._NewKey = value;
				newKey = this._NewKey;
				if (newKey != null)
				{
					newKey.Click += value2;
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000026DF File Offset: 0x000008DF
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0001D590 File Offset: 0x0001B790
		internal virtual Label Label2 { get; set; }

		// Token: 0x06000343 RID: 835 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
		private void OK_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001D5DC File Offset: 0x0001B7DC
		private void NewKey_Click(object sender, EventArgs e)
		{
			this.NewKey.Text = "";
		}
	}
}
