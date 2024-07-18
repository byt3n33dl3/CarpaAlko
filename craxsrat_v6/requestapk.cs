using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000031 RID: 49
	[DesignerGenerated]
	public partial class requestapk : Form
	{
		// Token: 0x06000350 RID: 848 RVA: 0x0001D994 File Offset: 0x0001BB94
		public requestapk()
		{
			base.Load += this.requestapk_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000353 RID: 851 RVA: 0x000026FF File Offset: 0x000008FF
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		internal virtual Label Label1 { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00002707 File Offset: 0x00000907
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0001F0DC File Offset: 0x0001D2DC
		internal virtual Label Label2 { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000270F File Offset: 0x0000090F
		// (set) Token: 0x06000358 RID: 856 RVA: 0x0001F0F0 File Offset: 0x0001D2F0
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00002717 File Offset: 0x00000917
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0001F104 File Offset: 0x0001D304
		internal virtual Label Label3 { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000271F File Offset: 0x0000091F
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0001F118 File Offset: 0x0001D318
		internal virtual DrakeUITextBox appnametext { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00002727 File Offset: 0x00000927
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0001F12C File Offset: 0x0001D32C
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000272F File Offset: 0x0000092F
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0001F140 File Offset: 0x0001D340
		internal virtual Panel Panel3 { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00002737 File Offset: 0x00000937
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0001F154 File Offset: 0x0001D354
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000273F File Offset: 0x0000093F
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0001F168 File Offset: 0x0001D368
		internal virtual Panel Panel5 { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00002747 File Offset: 0x00000947
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0001F17C File Offset: 0x0001D37C
		internal virtual DrakeUITextBox reqemail { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000274F File Offset: 0x0000094F
		// (set) Token: 0x06000368 RID: 872 RVA: 0x0001F190 File Offset: 0x0001D390
		internal virtual Label Label4 { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00002757 File Offset: 0x00000957
		// (set) Token: 0x0600036A RID: 874 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
		internal virtual Panel Panel6 { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000275F File Offset: 0x0000095F
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		internal virtual Panel Panel7 { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00002767 File Offset: 0x00000967
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0001F1CC File Offset: 0x0001D3CC
		internal virtual DrakeUITextBox apklinktext { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000276F File Offset: 0x0000096F
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
		internal virtual Label Label5 { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00002777 File Offset: 0x00000977
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		internal virtual Panel Panel8 { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000277F File Offset: 0x0000097F
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0001F208 File Offset: 0x0001D408
		internal virtual Panel Panel9 { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00002787 File Offset: 0x00000987
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0001F21C File Offset: 0x0001D41C
		internal virtual DrakeUITextBox appvirtext { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000278F File Offset: 0x0000098F
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0001F230 File Offset: 0x0001D430
		internal virtual Label Label6 { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00002797 File Offset: 0x00000997
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0001F244 File Offset: 0x0001D444
		internal virtual Panel Panel10 { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000279F File Offset: 0x0000099F
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0001F258 File Offset: 0x0001D458
		internal virtual Panel Panel11 { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000027A7 File Offset: 0x000009A7
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0001F26C File Offset: 0x0001D46C
		internal virtual DrakeUITextBox discriptext { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000027AF File Offset: 0x000009AF
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0001F280 File Offset: 0x0001D480
		internal virtual Label Label7 { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000027B7 File Offset: 0x000009B7
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0001F294 File Offset: 0x0001D494
		internal virtual DrakeUIButtonIcon exitbtn
		{
			[CompilerGenerated]
			get
			{
				return this._exitbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.exitbtn_Click);
				DrakeUIButtonIcon exitbtn = this._exitbtn;
				if (exitbtn != null)
				{
					exitbtn.Click -= value2;
				}
				this._exitbtn = value;
				exitbtn = this._exitbtn;
				if (exitbtn != null)
				{
					exitbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000027BF File Offset: 0x000009BF
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
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

		// Token: 0x06000385 RID: 901 RVA: 0x00011540 File Offset: 0x0000F740
		private void exitbtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0001F31C File Offset: 0x0001D51C
		private void requestapk_Load(object sender, EventArgs e)
		{
			if (Module4.smethod_7() != null || MySettingsProperty.Settings.requestmade)
			{
				string text = Module4.smethod_7();
				if (text == null && Module2.smethod_30("Error", "ops something went wrong  please contact developer: craxsrat.net", false))
				{
					base.Close();
				}
				if (DateTime.Compare(DateTime.Parse(text).AddHours(3.0), DateTime.Now) > 0 && Module2.smethod_30("Timeout", "You can only make 1 Request every 3 hours", false))
				{
					base.Close();
				}
			}
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
			}
			catch (Exception ex)
			{
			}
			if (!Module2.smethod_40(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project"), "AngelAndroid_FileManager"))
			{
				Module2.smethod_30("Error", Module2.smethod_58("vRPM0KvAe2l5ow7/GwxeqrqbxBIoVXSqReiWDDXGYRM=", "File Manager"), false);
			}
			string value2;
			string value3;
			if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("7YJYs8nIczW6UcZhgdEyXw==", "Class"), false) == 0)
			{
				XmlElement xmlElement = xmlDocument.FirstChild["P1"];
				XmlElement xmlElement2 = xmlDocument.FirstChild["P2"];
				XmlElement xmlElement3 = xmlDocument.FirstChild["P4"];
				string value = xmlElement3.FirstChild.Value;
				if (Operators.ConditionalCompareObjectNotEqual(Module2.smethod_58(value, "ZoomPictureBox"), Module2.smethod_3(Application.ExecutablePath), false))
				{
					Module2.smethod_30("Error", Module2.smethod_58("6PR33ggFwNg/Cx/Ol4q0/muMb85+G7mzi2bGyBqiLj7q1G4i34Y8qqFjTWwBPKJ6sM8Wj+b0GnBg\r\nd6DUvXOMQg==", "Camera Manager"), false);
					Module2.smethod_1();
					GClass9.cypherRat_0.Home_Btn.Enabled = false;
					GClass9.cypherRat_0.blockbtn.Enabled = false;
					GClass9.cypherRat_0.Connection_btn.Enabled = false;
					GClass9.cypherRat_0.Build_btn.Enabled = false;
					GClass9.cypherRat_0.inject_btn.Enabled = false;
					GClass9.cypherRat_0.Settings_btn.Enabled = false;
					GClass9.string_4 = "a";
					GClass9.string_1 = "v";
					GClass9.cypherRat_0 = new CypherRat();
					GClass9.cypherRat_0.WindowState = FormWindowState.Minimized;
				}
				value2 = xmlElement2.FirstChild.Value;
				value3 = xmlElement.FirstChild.Value;
			}
			this.reqemail.Text = Module2.smethod_58(value3, "​‍‌‎‏");
			if (Operators.CompareString(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), Module2.smethod_58(value2, "​‍‌‎‏"), false) != 0)
			{
				Module2.smethod_30("Error", Module2.smethod_58("klI0IxCLnJCwukOCUJVZScG58hb6E8uTLNLIZenwPv0=", "IOtigrYWEQAyiFol") + "\r\n" + Module2.smethod_58("W6lGX3nOzKRzR87g8nYD2s+/G0rvYMviMszv/jE91nc=", "TMjiwHlZykdArGgb"), false);
				Module2.smethod_1();
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001F608 File Offset: 0x0001D808
		private void reqbtn_Click(object sender, EventArgs e)
		{
			DateTime t = DateTime.Parse(Module2.smethod_35());
			if ((DateTime.Compare(t, DateTime.MinValue) != 0 || !Module2.smethod_30("Connection Error", "Please make sure you are connected to the internet and try again", false)) && (!(string.IsNullOrEmpty(this.appnametext.Text) | string.IsNullOrWhiteSpace(this.appnametext.Text)) || !Module2.smethod_30("App name not found", "Please enter the app name", false)))
			{
				string string_ = string.Concat(new string[]
				{
					"Name:",
					this.appnametext.Text.ToString(),
					"\r\napplink:",
					this.apklinktext.Text.ToString(),
					"\r\nappversion:",
					this.appvirtext.Text.ToString(),
					"\r\nDec:",
					this.discriptext.Text
				});
				if (!Module2.smethod_15(this.reqemail.Text, Module2.smethod_59(string_, "IsNullOrWhiteSpace")))
				{
					if (Module2.smethod_30("Error", "Request failed to send  please try again later", false))
					{
						base.Close();
					}
				}
				else if (Module2.smethod_30("Success", "Request have been sent", false))
				{
					Module4.smethod_8(t.ToString());
					MySettingsProperty.Settings.requestmade = true;
					MySettingsProperty.Settings.Save();
					base.Close();
				}
			}
		}
	}
}
