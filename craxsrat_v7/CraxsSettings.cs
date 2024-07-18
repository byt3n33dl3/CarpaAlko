using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000B0 RID: 176
	[DesignerGenerated]
	public partial class CraxsSettings : Form
	{
		// Token: 0x06000B4E RID: 2894 RVA: 0x00078ED0 File Offset: 0x000770D0
		public CraxsSettings()
		{
			base.Load += this.CraxsSettings_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00006275 File Offset: 0x00004475
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0007B044 File Offset: 0x00079244
		internal virtual ComboBox Notifi { get; set; }

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0000627D File Offset: 0x0000447D
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0007B058 File Offset: 0x00079258
		internal virtual ComboBox saveit { get; set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00006285 File Offset: 0x00004485
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0007B06C File Offset: 0x0007926C
		internal virtual Label Label4 { get; set; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0000628D File Offset: 0x0000448D
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0007B080 File Offset: 0x00079280
		internal virtual Label Label5 { get; set; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00006295 File Offset: 0x00004495
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x0007B094 File Offset: 0x00079294
		internal virtual ComboBox logit { get; set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0000629D File Offset: 0x0000449D
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x0007B0A8 File Offset: 0x000792A8
		internal virtual Label Label6 { get; set; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000062A5 File Offset: 0x000044A5
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x0007B0BC File Offset: 0x000792BC
		internal virtual Label Label7 { get; set; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000062AD File Offset: 0x000044AD
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x0007B0D0 File Offset: 0x000792D0
		internal virtual ComboBox FMI { get; set; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000062B5 File Offset: 0x000044B5
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x0007B0E4 File Offset: 0x000792E4
		internal virtual Label Label8 { get; set; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000062BD File Offset: 0x000044BD
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x0007B0F8 File Offset: 0x000792F8
		internal virtual ComboBox FMQ { get; set; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000062C5 File Offset: 0x000044C5
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x0007B10C File Offset: 0x0007930C
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000062CD File Offset: 0x000044CD
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0007B120 File Offset: 0x00079320
		internal virtual Splitter Splitter1 { get; set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x000062D5 File Offset: 0x000044D5
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x0007B134 File Offset: 0x00079334
		internal virtual Label Label9 { get; set; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000062DD File Offset: 0x000044DD
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x0007B148 File Offset: 0x00079348
		internal virtual ComboBox NotifiDis { get; set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x000062E5 File Offset: 0x000044E5
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0007B15C File Offset: 0x0007935C
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x000062ED File Offset: 0x000044ED
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0007B1A0 File Offset: 0x000793A0
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000062F5 File Offset: 0x000044F5
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x0007B1E4 File Offset: 0x000793E4
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x000062FD File Offset: 0x000044FD
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x0007B1F8 File Offset: 0x000793F8
		internal virtual ComboBox Hidecoonstart { get; set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00006305 File Offset: 0x00004505
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x0007B20C File Offset: 0x0007940C
		internal virtual Label Label3 { get; set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0000630D File Offset: 0x0000450D
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0007B220 File Offset: 0x00079420
		internal virtual Label Label2 { get; set; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00006315 File Offset: 0x00004515
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x0007B234 File Offset: 0x00079434
		internal virtual Label Label1 { get; set; }

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0000631D File Offset: 0x0000451D
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x0007B248 File Offset: 0x00079448
		internal virtual ComboBox LiveSQ { get; set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00006325 File Offset: 0x00004525
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x0007B25C File Offset: 0x0007945C
		internal virtual Label Label12 { get; set; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0000632D File Offset: 0x0000452D
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0007B270 File Offset: 0x00079470
		internal virtual Label Label11 { get; set; }

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00006335 File Offset: 0x00004535
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0007B284 File Offset: 0x00079484
		internal virtual Label Label10 { get; set; }

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0000633D File Offset: 0x0000453D
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0007B298 File Offset: 0x00079498
		internal virtual Panel Panel3 { get; set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00006345 File Offset: 0x00004545
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x0007B2AC File Offset: 0x000794AC
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0000634D File Offset: 0x0000454D
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0007B2C0 File Offset: 0x000794C0
		internal virtual ComboBox LSFPS { get; set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00006355 File Offset: 0x00004555
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0007B2D4 File Offset: 0x000794D4
		internal virtual DrakeUITabControl DrakeUITabControl1 { get; set; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0000635D File Offset: 0x0000455D
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0007B2E8 File Offset: 0x000794E8
		internal virtual TabPage TabPage4 { get; set; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00006365 File Offset: 0x00004565
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x0007B2FC File Offset: 0x000794FC
		internal virtual TabPage TabPage5 { get; set; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0000636D File Offset: 0x0000456D
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x0007B310 File Offset: 0x00079510
		internal virtual ComboBox plysound { get; set; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00006375 File Offset: 0x00004575
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0007B324 File Offset: 0x00079524
		internal virtual Label Label14 { get; set; }

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0000637D File Offset: 0x0000457D
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0007B338 File Offset: 0x00079538
		internal virtual Label Label15 { get; set; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00006385 File Offset: 0x00004585
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0007B34C File Offset: 0x0007954C
		internal virtual ComboBox lngtext { get; set; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0000638D File Offset: 0x0000458D
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0007B360 File Offset: 0x00079560
		internal virtual Label recordfps { get; set; }

		// Token: 0x06000B99 RID: 2969 RVA: 0x00006395 File Offset: 0x00004595
		private void CraxsSettings_Load(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0007B374 File Offset: 0x00079574
		public void method_1()
		{
			try
			{
				this.Hidecoonstart.Text = Conversions.ToString(this.Hidecoonstart.Items[this.Hidecoonstart.Items.IndexOf(MySettingsProperty.Settings.hidecoonstart)]);
				this.Notifi.Text = Conversions.ToString(this.Notifi.Items[this.Notifi.Items.IndexOf(MySettingsProperty.Settings.show_alert)]);
				this.NotifiDis.Text = Conversions.ToString(this.NotifiDis.Items[this.NotifiDis.Items.IndexOf(MySettingsProperty.Settings.ShowAlertDis)]);
				this.logit.Text = Conversions.ToString(this.logit.Items[this.logit.Items.IndexOf(MySettingsProperty.Settings.LOG)]);
				this.saveit.Text = Conversions.ToString(this.saveit.Items[this.saveit.Items.IndexOf(MySettingsProperty.Settings.Saving_data)]);
				this.FMI.Text = Conversions.ToString(this.FMI.Items[this.FMI.Items.IndexOf(MySettingsProperty.Settings.FM_IC_Size)]);
				this.FMQ.Text = Conversions.ToString(MySettingsProperty.Settings.ImageQualty);
				this.LiveSQ.Text = Conversions.ToString(this.LiveSQ.Items[this.LiveSQ.Items.IndexOf(MySettingsProperty.Settings.live_sc_qulty)]);
				this.LSFPS.Text = Conversions.ToString(this.LSFPS.Items[this.LSFPS.Items.IndexOf(MySettingsProperty.Settings.live_fps_rec)]);
				if (MySettingsProperty.Settings.NOTI_SOUND)
				{
					this.plysound.Text = "Yes";
				}
				else
				{
					this.plysound.Text = "No";
				}
				string left = Module4.smethod_1();
				if (Operators.CompareString(left, "EN", false) != 0)
				{
					if (Operators.CompareString(left, "AR", false) == 0)
					{
						this.lngtext.Text = "AR-العربية";
					}
					else if (Operators.CompareString(left, "CN", false) == 0)
					{
						this.lngtext.Text = "CN-中国人";
					}
				}
				else
				{
					this.lngtext.Text = "EN-English";
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0007B62C File Offset: 0x0007982C
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			MySettingsProperty.Settings.performance = "Normal";
			MySettingsProperty.Settings.show_alert = "Yes";
			MySettingsProperty.Settings.ShowAlertDis = "Yes";
			MySettingsProperty.Settings.hidecoonstart = "Yes";
			MySettingsProperty.Settings.LOG = "Yes";
			MySettingsProperty.Settings.Saving_data = "Yes";
			MySettingsProperty.Settings.FM_IC_Size = "Small";
			MySettingsProperty.Settings.ImageQualty = Conversions.ToInteger("20");
			this.method_1();
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0007B6BC File Offset: 0x000798BC
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			MySettingsProperty.Settings.show_alert = this.Notifi.Text;
			MySettingsProperty.Settings.ShowAlertDis = this.NotifiDis.Text;
			MySettingsProperty.Settings.LOG = this.logit.Text;
			MySettingsProperty.Settings.Saving_data = this.saveit.Text;
			MySettingsProperty.Settings.FM_IC_Size = this.FMI.Text;
			MySettingsProperty.Settings.ImageQualty = Conversions.ToInteger(this.FMQ.Text);
			MySettingsProperty.Settings.hidecoonstart = this.Hidecoonstart.Text;
			MySettingsProperty.Settings.live_sc_qulty = this.LiveSQ.Text;
			MySettingsProperty.Settings.live_fps_rec = this.LSFPS.Text;
			string text = this.plysound.Text;
			if (Operators.CompareString(text, "Yes", false) != 0)
			{
				if (Operators.CompareString(text, "No", false) != 0)
				{
					MySettingsProperty.Settings.NOTI_SOUND = false;
				}
				else
				{
					MySettingsProperty.Settings.NOTI_SOUND = false;
				}
			}
			else
			{
				MySettingsProperty.Settings.NOTI_SOUND = true;
			}
			string object_ = this.lngtext.Text.Split(new char[]
			{
				'-'
			})[0];
			Module4.smethod_2(object_);
			MySettingsProperty.Settings.Save();
			Alert.ShowSucess("Saved Changes will be made after restarting the program");
			base.Close();
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_6(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0007B818 File Offset: 0x00079A18
		private void method_7(object sender, EventArgs e)
		{
			Module4.smethod_2("AR");
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0007B830 File Offset: 0x00079A30
		private void method_8(object sender, EventArgs e)
		{
			Module4.smethod_2("CN");
		}
	}
}
