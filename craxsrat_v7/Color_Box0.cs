using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000AD RID: 173
	[DesignerGenerated]
	public partial class Color_Box0 : Form
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x00075F68 File Offset: 0x00074168
		public Color_Box0()
		{
			base.Load += this.Color_Box0_Load;
			base.Activated += this.Color_Box0_Activated;
			base.Deactivate += this.Color_Box0_Deactivate;
			this.bool_0 = false;
			this.bool_1 = false;
			this.Yellow = Color.Yellow;
			this.color_0 = Color.Yellow;
			this.point_0 = new Point(0, 0);
			this.bool_2 = false;
			this.point_1 = default(Point);
			this.bool_3 = false;
			this.string_0 = "null";
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000061C5 File Offset: 0x000043C5
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x000764B8 File Offset: 0x000746B8
		internal virtual PictureBox C_Box3 { get; set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000061CD File Offset: 0x000043CD
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x000764CC File Offset: 0x000746CC
		internal virtual PictureBox C_Box2
		{
			[CompilerGenerated]
			get
			{
				return this._C_Box2;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.C_Box2_Paint);
				MouseEventHandler value3 = new MouseEventHandler(this.C_Box2_MouseDown);
				MouseEventHandler value4 = new MouseEventHandler(this.C_Box2_MouseMove);
				MouseEventHandler value5 = new MouseEventHandler(this.C_Box2_MouseUp);
				EventHandler value6 = new EventHandler(this.C_Box2_Click);
				PictureBox c_Box = this._C_Box2;
				if (c_Box != null)
				{
					c_Box.Paint -= value2;
					c_Box.MouseDown -= value3;
					c_Box.MouseMove -= value4;
					c_Box.MouseUp -= value5;
					c_Box.Click -= value6;
				}
				this._C_Box2 = value;
				c_Box = this._C_Box2;
				if (c_Box != null)
				{
					c_Box.Paint += value2;
					c_Box.MouseDown += value3;
					c_Box.MouseMove += value4;
					c_Box.MouseUp += value5;
					c_Box.Click += value6;
				}
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x000061D5 File Offset: 0x000043D5
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00076590 File Offset: 0x00074790
		internal virtual Button BTN_OK
		{
			[CompilerGenerated]
			get
			{
				return this._BTN_OK;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.BTN_OK_Click);
				Button btn_OK = this._BTN_OK;
				if (btn_OK != null)
				{
					btn_OK.Click -= value2;
				}
				this._BTN_OK = value;
				btn_OK = this._BTN_OK;
				if (btn_OK != null)
				{
					btn_OK.Click += value2;
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x000061DD File Offset: 0x000043DD
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x000765D4 File Offset: 0x000747D4
		internal virtual PictureBox C_Box0
		{
			[CompilerGenerated]
			get
			{
				return this._C_Box0;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.C_Box0_Paint);
				MouseEventHandler value3 = new MouseEventHandler(this.C_Box0_MouseDown);
				MouseEventHandler value4 = new MouseEventHandler(this.C_Box0_MouseMove);
				MouseEventHandler value5 = new MouseEventHandler(this.C_Box0_MouseUp);
				EventHandler value6 = new EventHandler(this.C_Box0_Click);
				PictureBox c_Box = this._C_Box0;
				if (c_Box != null)
				{
					c_Box.Paint -= value2;
					c_Box.MouseDown -= value3;
					c_Box.MouseMove -= value4;
					c_Box.MouseUp -= value5;
					c_Box.Click -= value6;
				}
				this._C_Box0 = value;
				c_Box = this._C_Box0;
				if (c_Box != null)
				{
					c_Box.Paint += value2;
					c_Box.MouseDown += value3;
					c_Box.MouseMove += value4;
					c_Box.MouseUp += value5;
					c_Box.Click += value6;
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x000061E5 File Offset: 0x000043E5
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00076698 File Offset: 0x00074898
		internal virtual Timer ti
		{
			[CompilerGenerated]
			get
			{
				return this._ti;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ti_Tick);
				Timer ti = this._ti;
				if (ti != null)
				{
					ti.Tick -= value2;
				}
				this._ti = value;
				ti = this._ti;
				if (ti != null)
				{
					ti.Tick += value2;
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x000061ED File Offset: 0x000043ED
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x000766DC File Offset: 0x000748DC
		internal virtual CheckBox CK1
		{
			[CompilerGenerated]
			get
			{
				return this._CK1;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.CK1_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.CK1_MouseUp);
				CheckBox ck = this._CK1;
				if (ck != null)
				{
					ck.MouseDown -= value2;
					ck.MouseUp -= value3;
				}
				this._CK1 = value;
				ck = this._CK1;
				if (ck != null)
				{
					ck.MouseDown += value2;
					ck.MouseUp += value3;
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000061F5 File Offset: 0x000043F5
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x0007673C File Offset: 0x0007493C
		internal virtual PictureBox BoxTitle
		{
			[CompilerGenerated]
			get
			{
				return this._BoxTitle;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.BoxTitle_Resize);
				PaintEventHandler value3 = new PaintEventHandler(this.BoxTitle_Paint);
				EventHandler value4 = new EventHandler(this.BoxTitle_Click);
				PictureBox boxTitle = this._BoxTitle;
				if (boxTitle != null)
				{
					boxTitle.Resize -= value2;
					boxTitle.Paint -= value3;
					boxTitle.Click -= value4;
				}
				this._BoxTitle = value;
				boxTitle = this._BoxTitle;
				if (boxTitle != null)
				{
					boxTitle.Resize += value2;
					boxTitle.Paint += value3;
					boxTitle.Click += value4;
				}
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000767B8 File Offset: 0x000749B8
		private void method_0()
		{
			this.BoxTitle.BackColor = Module5.color_0;
			this.BackColor = Module5.color_0;
			try
			{
				foreach (Button button in base.Controls.OfType<Button>())
				{
					button.BackColor = Module5.White;
					button.ForeColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<Button> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (CheckBox checkBox in base.Controls.OfType<CheckBox>())
				{
					checkBox.BackColor = Module5.color_0;
					checkBox.ForeColor = Module5.White;
				}
			}
			finally
			{
				IEnumerator<CheckBox> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00076888 File Offset: 0x00074A88
		private void Color_Box0_Load(object sender, EventArgs e)
		{
			this.method_0();
			this.BTN_OK.Font = Module8.font_1;
			base.TopMost = true;
			this.bool_1 = true;
			this.bitmap_0 = new Bitmap(1, 1);
			this.graphics_0 = Graphics.FromImage(this.bitmap_0);
			if (Module6.point_0 == default(Point))
			{
				this.point_1 = new Point(1, 1);
			}
			else
			{
				this.point_1 = Module6.point_0;
			}
			object[] objects_ = new object[]
			{
				this.point_1.X,
				this.point_1.Y
			};
			this.method_9(objects_, this.C_Box2);
			this.C_Box2.Invalidate();
			if (Module6.point_1 == default(Point))
			{
				this.point_0 = new Point(1, 1);
			}
			else
			{
				this.point_0 = Module6.point_1;
			}
			object[] objects_2 = new object[]
			{
				this.point_0.X,
				this.point_0.Y
			};
			this.method_4(objects_2, this.C_Box0);
			this.C_Box0.Invalidate();
			this.bool_1 = false;
			this.bool_0 = true;
		}

		// Token: 0x06000B02 RID: 2818
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetKeyState(long nVirtKey);

		// Token: 0x06000B03 RID: 2819 RVA: 0x000769D0 File Offset: 0x00074BD0
		private void C_Box0_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			Rectangle rect = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, Color.White, this.Yellow, LinearGradientMode.Horizontal))
			{
				graphics2.FillRectangle(linearGradientBrush, rect);
			}
			Rectangle rect2 = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
			checked
			{
				using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rect2, Color.Transparent, Color.Black, LinearGradientMode.Vertical))
				{
					graphics2.FillRectangle(linearGradientBrush2, rect2);
					int num = this.C_Box0.Height - 7;
					graphics2.DrawLine(new Pen(Color.Black, 5f), 0, num, this.C_Box0.Width, num);
				}
				graphics2 = null;
				if (!(this.point_0 == default(Point)))
				{
					e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					Rectangle rect3;
					if (!this.bool_2)
					{
						rect3 = new Rectangle(this.point_0.X - 5, this.point_0.Y - 5, 10, 10);
					}
					else
					{
						rect3 = new Rectangle(this.point_0.X - 7, this.point_0.Y - 7, 14, 14);
					}
					Pen pen = new Pen(Color.Black, 1f);
					if ((int)Math.Round((double)this.C_Box0.Height / 2.0) < this.point_0.Y)
					{
						pen = new Pen(Color.White, 1f);
					}
					e.Graphics.DrawEllipse(pen, rect3);
					Bitmap bitmap = new Bitmap(this.C_Box0.ClientSize.Width, this.C_Box0.Height);
					this.C_Box0.DrawToBitmap(bitmap, this.C_Box0.ClientRectangle);
					if (bitmap.Width > this.point_0.X & bitmap.Height > this.point_0.Y)
					{
						Color pixel = bitmap.GetPixel(this.point_0.X, this.point_0.Y);
						bitmap.Dispose();
						this.color_0 = pixel;
					}
				}
				this.C_Box3.BackColor = this.color_0;
				this.method_13(new object[]
				{
					this.C_Box3.BackColor.R,
					this.C_Box3.BackColor.G,
					this.C_Box3.BackColor.B
				});
				this.C_Box3.Refresh();
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00076CBC File Offset: 0x00074EBC
		private void C_Box0_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_2 = true;
			object[] objects_ = new object[]
			{
				e.X,
				e.Y
			};
			this.method_4(objects_, this.C_Box0);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00076D00 File Offset: 0x00074F00
		private void method_4(object[] objects_0, Control control_0)
		{
			if ((this.bool_2 | this.bool_1) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(objects_0[0], control_0.Width - 7, false)), Operators.NotObject(Operators.CompareObjectLess(objects_0[0], 1, false))), Operators.NotObject(Operators.CompareObjectGreater(objects_0[1], control_0.Height - 7, false)))), Operators.NotObject(Operators.CompareObjectLess(objects_0[1], 1, false)))))
			{
				this.point_0.X = Conversions.ToInteger(objects_0[0]);
				this.point_0.Y = Conversions.ToInteger(objects_0[1]);
				Module6.point_1 = new Point(this.point_0.X, this.point_0.Y);
				Bitmap bitmap = new Bitmap(control_0.ClientSize.Width, control_0.Height);
				control_0.DrawToBitmap(bitmap, control_0.ClientRectangle);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, objects_0[0], false), Operators.CompareObjectGreater(bitmap.Height, objects_0[1], false))))
				{
					Color pixel = bitmap.GetPixel(Conversions.ToInteger(objects_0[0]), Conversions.ToInteger(objects_0[1]));
					bitmap.Dispose();
					this.color_0 = pixel;
					control_0.Refresh();
				}
				control_0.Invalidate();
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00076E68 File Offset: 0x00075068
		private void C_Box0_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_2)
			{
				if (Operators.ConditionalCompareObjectEqual(this.C_Box0.Tag, null, false))
				{
					Cursor.Clip = this.C_Box0.RectangleToScreen(checked(new Rectangle(1, 1, this.C_Box0.Width - 7, this.C_Box0.Height - 7)));
					this.C_Box0.Tag = true;
				}
				object[] objects_ = new object[]
				{
					e.X,
					e.Y
				};
				this.method_4(objects_, this.C_Box0);
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00076F08 File Offset: 0x00075108
		private void C_Box0_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_2 = false;
			Cursor.Clip = default(Rectangle);
			this.C_Box0.Tag = null;
			this.C_Box0.Invalidate();
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00076F44 File Offset: 0x00075144
		private void C_Box2_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), this.C_Box2.ClientSize), Color.Red, Color.Blue, 0f))
			{
				linearGradientBrush.InterpolationColors = new ColorBlend
				{
					Positions = new float[]
					{
						0f,
						0.1f,
						0.284f,
						0.5f,
						0.668f,
						0.9f,
						1f
					},
					Colors = new Color[]
					{
						Color.Purple,
						Color.Red,
						Color.Yellow,
						Color.Lime,
						Color.Cyan,
						Color.Blue,
						Color.LightBlue
					}
				};
				e.Graphics.FillRectangle(linearGradientBrush, this.C_Box2.ClientRectangle);
			}
			if (!(this.point_1 == default(Point)))
			{
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Rectangle rect = checked(new Rectangle(this.point_1.X - 3, -1, 5, this.C_Box2.Height - 3));
				Pen pen = new Pen(Color.Black, 1f);
				e.Graphics.DrawRectangle(pen, rect);
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000770A0 File Offset: 0x000752A0
		private void C_Box2_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_3 = true;
			object[] objects_ = new object[]
			{
				e.X,
				e.Y
			};
			this.method_9(objects_, this.C_Box2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000770E4 File Offset: 0x000752E4
		private void method_9(object[] objects_0, Control control_0)
		{
			if ((this.bool_3 | this.bool_1) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(objects_0[0], control_0.Width - 7, false)), Operators.NotObject(Operators.CompareObjectLess(objects_0[0], 1, false))), Operators.NotObject(Operators.CompareObjectGreater(objects_0[1], control_0.Height - 7, false)))), Operators.NotObject(Operators.CompareObjectLess(objects_0[1], 1, false)))))
			{
				this.point_1.X = Conversions.ToInteger(objects_0[0]);
				this.point_1.Y = Conversions.ToInteger(objects_0[1]);
				Module6.point_0 = new Point(this.point_1.X, this.point_1.Y);
				Bitmap bitmap = new Bitmap(control_0.ClientSize.Width, control_0.Height);
				control_0.DrawToBitmap(bitmap, control_0.ClientRectangle);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, objects_0[0], false), Operators.CompareObjectGreater(bitmap.Height, objects_0[1], false))))
				{
					Color pixel = bitmap.GetPixel(Conversions.ToInteger(objects_0[0]), Conversions.ToInteger(objects_0[1]));
					bitmap.Dispose();
					this.Yellow = pixel;
					this.C_Box0.Invalidate();
				}
				control_0.Invalidate();
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00077250 File Offset: 0x00075450
		private void C_Box2_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_3)
			{
				if (Operators.ConditionalCompareObjectEqual(this.C_Box2.Tag, null, false))
				{
					Cursor.Clip = this.C_Box2.RectangleToScreen(checked(new Rectangle(1, 1, this.C_Box2.Width - 7, this.C_Box2.Height - 7)));
					this.C_Box2.Tag = true;
				}
				object[] objects_ = new object[]
				{
					e.X,
					e.Y
				};
				this.method_9(objects_, this.C_Box2);
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000772F0 File Offset: 0x000754F0
		private void C_Box2_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_3 = false;
			Cursor.Clip = default(Rectangle);
			this.C_Box2.Tag = null;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00077320 File Offset: 0x00075520
		private void ti_Tick(object sender, EventArgs e)
		{
			try
			{
				this.graphics_0.CopyFromScreen(new Point((Size)Cursor.Position), Point.Empty, this.bitmap_0.Size);
				this.C_Box3.BackColor = Color.FromArgb((int)this.bitmap_0.GetPixel(0, 0).R, (int)this.bitmap_0.GetPixel(0, 0).G, (int)this.bitmap_0.GetPixel(0, 0).B);
				this.method_13(new object[]
				{
					this.C_Box3.BackColor.R,
					this.C_Box3.BackColor.G,
					this.C_Box3.BackColor.B
				});
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00077424 File Offset: 0x00075624
		private void method_13(object[] objects_0)
		{
			this.string_0 = string.Format("RGB:({0},{1},{2})", RuntimeHelpers.GetObjectValue(objects_0[0]), RuntimeHelpers.GetObjectValue(objects_0[1]), RuntimeHelpers.GetObjectValue(objects_0[2]));
			this.BoxTitle.Refresh();
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00077464 File Offset: 0x00075664
		private void CK1_MouseDown(object sender, MouseEventArgs e)
		{
			this.ti.Enabled = true;
			this.CK1.Checked = true;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0007748C File Offset: 0x0007568C
		private void CK1_MouseUp(object sender, MouseEventArgs e)
		{
			this.ti.Enabled = false;
			this.CK1.Checked = false;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00022684 File Offset: 0x00020884
		private void BTN_OK_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x000774B4 File Offset: 0x000756B4
		private void Color_Box0_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000774B4 File Offset: 0x000756B4
		private void Color_Box0_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000774B4 File Offset: 0x000756B4
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0000246D File Offset: 0x0000066D
		private void C_Box0_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x000774CC File Offset: 0x000756CC
		private void BoxTitle_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.bool_0)
				{
					string text = this.string_0;
					Color white = Module5.White;
					e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)white.R, (int)white.G, (int)white.B)), 0, 1, this.BoxTitle.Width, 1);
					Brush brush = new SolidBrush(Module5.White);
					Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
					Size size = TextRenderer.MeasureText(text, Module8.font_1);
					Rectangle rect = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
					e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
					e.Graphics.DrawString(text, Module8.font_1, brush, 0f, 2f);
					Size size2 = TextRenderer.MeasureText("S", Module8.font_1);
					if (this.BoxTitle.Height != size2.Height + 3)
					{
						this.BoxTitle.Height = size2.Height + 3;
					}
				}
			}
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0000246D File Offset: 0x0000066D
		private void BoxTitle_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0000246D File Offset: 0x0000066D
		private void C_Box2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400062B RID: 1579
		private bool bool_0;

		// Token: 0x0400062C RID: 1580
		public bool bool_1;

		// Token: 0x0400062D RID: 1581
		public Color Yellow;

		// Token: 0x0400062E RID: 1582
		public Color color_0;

		// Token: 0x0400062F RID: 1583
		private Bitmap bitmap_0;

		// Token: 0x04000630 RID: 1584
		private Graphics graphics_0;

		// Token: 0x04000631 RID: 1585
		private Point point_0;

		// Token: 0x04000632 RID: 1586
		private bool bool_2;

		// Token: 0x04000633 RID: 1587
		private Point point_1;

		// Token: 0x04000634 RID: 1588
		private bool bool_3;

		// Token: 0x04000635 RID: 1589
		private string string_0;
	}
}
