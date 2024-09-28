using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x0200003C RID: 60
	[DesignerGenerated]
	public partial class CraxsAbout : Form
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00024FBC File Offset: 0x000231BC
		public CraxsAbout()
		{
			base.Load += this.CraxsAbout_Load;
			base.MouseDown += this.CraxsAbout_MouseDown;
			this.InitializeComponent();
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0000297F File Offset: 0x00000B7F
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00026E90 File Offset: 0x00025090
		internal virtual PictureBox PictureBox2 { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00002987 File Offset: 0x00000B87
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00026EA4 File Offset: 0x000250A4
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.CraxsAbout_MouseDown);
				Label label = this._Label3;
				if (label != null)
				{
					label.MouseDown -= value2;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.MouseDown += value2;
				}
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000298F File Offset: 0x00000B8F
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00026EE8 File Offset: 0x000250E8
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.CraxsAbout_MouseDown);
				Label label = this._Label1;
				if (label != null)
				{
					label.MouseDown -= value2;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.MouseDown += value2;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002997 File Offset: 0x00000B97
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00026F2C File Offset: 0x0002512C
		internal virtual Label Label2 { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000299F File Offset: 0x00000B9F
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00026F40 File Offset: 0x00025140
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000029A7 File Offset: 0x00000BA7
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00026F84 File Offset: 0x00025184
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x000029AF File Offset: 0x00000BAF
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00026F98 File Offset: 0x00025198
		internal virtual PictureBox PictureBox3
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox3_Click);
				MouseEventHandler value3 = new MouseEventHandler(this.CraxsAbout_MouseDown);
				PictureBox pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
					pictureBox.MouseDown -= value3;
				}
				this._PictureBox3 = value;
				pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
					pictureBox.MouseDown += value3;
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000029B7 File Offset: 0x00000BB7
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00026FF8 File Offset: 0x000251F8
		internal virtual PictureBox PictureBox4
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox4;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox4_Click);
				PictureBox pictureBox = this._PictureBox4;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox4 = value;
				pictureBox = this._PictureBox4;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x000029BF File Offset: 0x00000BBF
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0002703C File Offset: 0x0002523C
		internal virtual PictureBox PictureBox5
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox5_Click);
				PictureBox pictureBox = this._PictureBox5;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox5 = value;
				pictureBox = this._PictureBox5;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000029C7 File Offset: 0x00000BC7
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00027080 File Offset: 0x00025280
		internal virtual PictureBox PictureBox6
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox6;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox6_Click);
				PictureBox pictureBox = this._PictureBox6;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox6 = value;
				pictureBox = this._PictureBox6;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000029CF File Offset: 0x00000BCF
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x000270C4 File Offset: 0x000252C4
		internal virtual DrakeUITabControlMenu Maintabcontrol
		{
			[CompilerGenerated]
			get
			{
				return this._Maintabcontrol;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Maintabcontrol_MouseDown);
				DrakeUITabControlMenu maintabcontrol = this._Maintabcontrol;
				if (maintabcontrol != null)
				{
					maintabcontrol.MouseDown -= value2;
				}
				this._Maintabcontrol = value;
				maintabcontrol = this._Maintabcontrol;
				if (maintabcontrol != null)
				{
					maintabcontrol.MouseDown += value2;
				}
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x000029D7 File Offset: 0x00000BD7
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00027108 File Offset: 0x00025308
		internal virtual TabPage TabPage1
		{
			[CompilerGenerated]
			get
			{
				return this._TabPage1;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.TabPage1_MouseDown);
				TabPage tabPage = this._TabPage1;
				if (tabPage != null)
				{
					tabPage.MouseDown -= value2;
				}
				this._TabPage1 = value;
				tabPage = this._TabPage1;
				if (tabPage != null)
				{
					tabPage.MouseDown += value2;
				}
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000029DF File Offset: 0x00000BDF
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0002714C File Offset: 0x0002534C
		internal virtual TabPage TabPage2 { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000029E7 File Offset: 0x00000BE7
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00027160 File Offset: 0x00025360
		internal virtual Label Label7 { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000029EF File Offset: 0x00000BEF
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00027174 File Offset: 0x00025374
		internal virtual DrakeUITextBox bdytext { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000029F7 File Offset: 0x00000BF7
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00027188 File Offset: 0x00025388
		internal virtual Label Label6 { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x000029FF File Offset: 0x00000BFF
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0002719C File Offset: 0x0002539C
		internal virtual DrakeUITextBox subtext { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00002A07 File Offset: 0x00000C07
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x000271B0 File Offset: 0x000253B0
		internal virtual Label Label5 { get; set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00002A0F File Offset: 0x00000C0F
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x000271C4 File Offset: 0x000253C4
		internal virtual DrakeUIButtonIcon reqbtn
		{
			[CompilerGenerated]
			get
			{
				return this._reqbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.reqbtn_Click);
				DrakeUIButtonIcon reqbtn = this._reqbtn;
				if (reqbtn != null)
				{
					reqbtn.Click -= value2;
				}
				this._reqbtn = value;
				reqbtn = this._reqbtn;
				if (reqbtn != null)
				{
					reqbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00002A17 File Offset: 0x00000C17
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00027208 File Offset: 0x00025408
		internal virtual DrakeUIButtonIcon checkupdatbtn
		{
			[CompilerGenerated]
			get
			{
				return this._checkupdatbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.checkupdatbtn_Click);
				DrakeUIButtonIcon checkupdatbtn = this._checkupdatbtn;
				if (checkupdatbtn != null)
				{
					checkupdatbtn.Click -= value2;
				}
				this._checkupdatbtn = value;
				checkupdatbtn = this._checkupdatbtn;
				if (checkupdatbtn != null)
				{
					checkupdatbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00002A1F File Offset: 0x00000C1F
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0002724C File Offset: 0x0002544C
		internal virtual TabPage TabPage3 { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00002A27 File Offset: 0x00000C27
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00027260 File Offset: 0x00025460
		internal virtual TextBox logupdate { get; set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002A2F File Offset: 0x00000C2F
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00027274 File Offset: 0x00025474
		internal virtual DrakeUIButtonIcon updatbtn
		{
			[CompilerGenerated]
			get
			{
				return this._updatbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.updatbtn_Click);
				DrakeUIButtonIcon updatbtn = this._updatbtn;
				if (updatbtn != null)
				{
					updatbtn.Click -= value2;
				}
				this._updatbtn = value;
				updatbtn = this._updatbtn;
				if (updatbtn != null)
				{
					updatbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00002A37 File Offset: 0x00000C37
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x000272B8 File Offset: 0x000254B8
		internal virtual TabPage TabPage4 { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00002A3F File Offset: 0x00000C3F
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x000272CC File Offset: 0x000254CC
		internal virtual WebBrowser LogBrowser { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00002A47 File Offset: 0x00000C47
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x000272E0 File Offset: 0x000254E0
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00002A4F File Offset: 0x00000C4F
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x000272F4 File Offset: 0x000254F4
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x06000486 RID: 1158 RVA: 0x00027308 File Offset: 0x00025508
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://CraxsRat.net/");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00027350 File Offset: 0x00025550
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://www.facebook.com/craxsrat");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0002738C File Offset: 0x0002558C
		private void PictureBox4_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://twitter.com/EvLFDev");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000273C8 File Offset: 0x000255C8
		private void PictureBox5_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://www.t.me/evlfdev");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00027404 File Offset: 0x00025604
		private void PictureBox6_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://craxsrat.net/support.html");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00011540 File Offset: 0x0000F740
		private void method_5(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00027440 File Offset: 0x00025640
		private void CraxsAbout_Load(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists(Application.StartupPath + "/ChangeLog.html"))
				{
					string documentText = File.ReadAllText(Application.StartupPath + "/ChangeLog.html");
					this.LogBrowser.DocumentText = documentText;
				}
				else
				{
					this.LogBrowser.Visible = false;
				}
			}
			catch (Exception ex)
			{
				this.LogBrowser.Visible = false;
			}
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
			}
			catch (Exception ex2)
			{
			}
			this.Label2.Text = "CraxsRat v4.9.5 Cracked By GoogleCrash";
			string value;
			if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("7YJYs8nIczW6UcZhgdEyXw==", "Class"), false) == 0)
			{
				XmlElement xmlElement = xmlDocument.FirstChild["P1"];
				value = xmlElement.FirstChild.Value;
			}
			this.string_0 = Module2.smethod_58(value, "​‍‌‎‏");
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001893C File Offset: 0x00016B3C
		private void CraxsAbout_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Module2.ReleaseCapture();
				Module2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00027570 File Offset: 0x00025770
		private void reqbtn_Click(object sender, EventArgs e)
		{
			DateTime t = DateTime.Parse(Module2.smethod_35());
			if ((DateTime.Compare(t, DateTime.MinValue) != 0 || !Module2.smethod_30("Connection Error", "Please make sure you are connected to the internet and try again", false)) && (!(string.IsNullOrEmpty(this.subtext.Text) | string.IsNullOrWhiteSpace(this.subtext.Text)) || !Module2.smethod_30("Subject", "Please Subject for the message", false)) && (!(string.IsNullOrEmpty(this.bdytext.Text) | string.IsNullOrWhiteSpace(this.bdytext.Text)) || !Module2.smethod_30("Description", "Please Add some description First", false)))
			{
				if (Module4.smethod_9() != null || MySettingsProperty.Settings.reportmade)
				{
					string text = Module4.smethod_9();
					if (text == null && Module2.smethod_30("Error", "ops something went wrong  please contact developer: craxsrat.net", false))
					{
						base.Close();
					}
					if (DateTime.Compare(DateTime.Parse(text).AddHours(3.0), DateTime.Now) > 0 && Module2.smethod_30("Timeout", "You can only make 1 Report every 3 hours", false))
					{
						base.Close();
					}
				}
				string text2 = "DIS:" + this.bdytext.Text;
				if (!Module2.smethod_16(this.string_0, Module2.smethod_59(text2, "IsNullOrWhiteSpace")))
				{
					if (Module2.smethod_30("Error", "Report failed to send  please try again later", false))
					{
						base.Close();
					}
				}
				else if (Module2.smethod_30("Success", "Report have been sent", false))
				{
					Module4.smethod_10(t.ToString());
					MySettingsProperty.Settings.requestmade = true;
					MySettingsProperty.Settings.Save();
					base.Close();
				}
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001893C File Offset: 0x00016B3C
		private void TabPage1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Module2.ReleaseCapture();
				Module2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001893C File Offset: 0x00016B3C
		private void Maintabcontrol_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Module2.ReleaseCapture();
				Module2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00027718 File Offset: 0x00025918
		private void checkupdatbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Module2.smethod_31();
				if (text != null)
				{
					if (Operators.CompareString(text, "Error404", false) != 0)
					{
						try
						{
							Module2.smethod_30("Up to date", "Congrats  Craxs Rat is updated.", false);
							return;
						}
						catch (Exception)
						{
							Module2.smethod_30("Connection error 2", "please try again later.", false);
							return;
						}
					}
					Module2.smethod_30("Connection error 1", "please try again later.", false);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00027798 File Offset: 0x00025998
		private void updatbtn_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Module2.smethod_31();
				if (text != null)
				{
					if (Operators.CompareString(text, "Error", false) == 0)
					{
						Module2.smethod_30("Connection error 1", "please try again later.", false);
					}
					else
					{
						try
						{
							XmlDocument xmlDocument = new XmlDocument();
							try
							{
								xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
							}
							catch (Exception ex)
							{
								Module2.smethod_30("License error", "your license is uncorrect  please try again later.", false);
								return;
							}
							XmlElement xmlElement = xmlDocument.FirstChild["P12"];
							string text2 = Module2.smethod_58(xmlElement.FirstChild.Value, "8efb22c2ce7c3610f7792");
							XmlElement xmlElement2 = xmlDocument.FirstChild["P6"];
							string text3 = Module2.smethod_58(xmlElement2.FirstChild.Value, "IO.String");
							XmlElement xmlElement3 = xmlDocument.FirstChild["P1"];
							XmlElement xmlElement4 = xmlDocument.FirstChild["P2"];
							XmlElement xmlElement5 = xmlDocument.FirstChild["P4"];
							string value = xmlElement5.FirstChild.Value;
							string[] array = text.Split(new char[]
							{
								':'
							});
							string right = array[0];
							string text4 = array[1];
							if (Operators.CompareString(value, right, false) == 0)
							{
								Module2.smethod_30("Up to date", "Congrats  Craxs Rat is updated.", false);
							}
							else if (Operators.ConditionalCompareObjectEqual(Module2.smethod_58(value, "ZoomPictureBox"), Module2.smethod_3(Application.ExecutablePath), false))
							{
								if (Directory.Exists(Path.GetTempPath() + "CP"))
								{
									Directory.Delete(Path.GetTempPath() + "CP", true);
								}
								if (File.Exists(Path.GetTempPath() + "CP\\up.zip"))
								{
									File.Delete(Path.GetTempPath() + "CP\\up.zip");
								}
								Directory.CreateDirectory(Path.GetTempPath() + "CP");
								File.WriteAllBytes(Path.GetTempPath() + "CP\\up.zip", Module0.up);
								try
								{
									Module2.smethod_37(Path.GetTempPath() + "CP\\up.zip", Path.GetTempPath() + "CP");
								}
								catch (Exception ex2)
								{
								}
								string left = Module2.smethod_33();
								if (Operators.CompareString(left, "ERROR", false) == 0)
								{
									left = "General Fix and improvment";
								}
								string text5 = Module2.smethod_59(text4, "3ExbQ7wkzRDfp5f7OMqX5Wr6d0Q") + "|";
								string text6 = Module2.smethod_59(Module2.smethod_58(text2, "8efb22c2ce7c3610f7792"), "RDfp5f7OMqX5Wr") + "|";
								string text7 = Module2.smethod_59(left, "YHscdQVEUFJuoYTUJ") + "|";
								string text8 = Module2.smethod_59(Module2.smethod_58(value, "ZoomPictureBox"), "CFVBGNDHYWGQERGRB") + "|";
								string text9 = Module2.smethod_59(right, "sdvgerAESFrgaERGVs") + "|";
								string text10 = Module2.smethod_59(Application.StartupPath, "kvaiehriwrgvSDRGvserg") + "|";
								string text11 = Module2.smethod_59(Module2.smethod_58(text3, "Build"), "iugaeurNQWESVD") + "|";
								string text12 = Module2.smethod_59(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project"), "RWTHWEVCDHJKadfg") + "|";
								string text13 = Module2.smethod_59("TRoGIZp8ohMSJ10k4Gmt9C", "EARGeardvAERGvd") + "|";
								string text14 = string.Concat(new string[]
								{
									text5,
									text6,
									text7,
									text8,
									text9,
									text10,
									text11,
									text12,
									text13
								});
								File.WriteAllText(Path.GetTempPath() + "CP\\config.ini", Module2.smethod_59(text14, "3ExbQ7wkzRDfp5f7OMqX5Wr6d0Q"));
								Process process = new Process();
								process.StartInfo.FileName = Path.GetTempPath() + "CP\\CraxsUpdates.exe";
								process.StartInfo.WorkingDirectory = Path.GetTempPath() + "CP";
								try
								{
									process.Start();
								}
								catch (Exception ex3)
								{
									Module2.smethod_30("Can't lunch updates", "please try again later.", false);
									return;
								}
								Process currentProcess = Process.GetCurrentProcess();
								currentProcess.Kill();
							}
							else
							{
								Module2.smethod_30("License error", "your license is uncorrect  please try again later.", false);
							}
						}
						catch (Exception ex4)
						{
							Module2.smethod_30("Connection error 2", "please try again later.", false);
						}
					}
				}
			}
			catch (Exception ex5)
			{
			}
		}

		// Token: 0x04000205 RID: 517
		public string string_0;
	}
}
