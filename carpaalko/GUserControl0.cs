using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000016 RID: 22
	[ToolboxBitmap("ZoomPictureBox.bmp")]
	[DesignerGenerated]
	public class GUserControl0 : UserControl
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
		public GUserControl0()
		{
			this.int_0 = 4000;
			this.int_1 = 100;
			this.int_2 = 100;
			this.double_0 = 16.0;
			this.bool_0 = true;
			this.bool_1 = true;
			this._GEnum0_0 = (GUserControl0.GEnum0)0;
			this.InitializeComponent();
			this.DoubleBuffered = true;
			this.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
			base.Size = new Size(200, 200);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00010074 File Offset: 0x0000E274
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					((IDisposable)this.components).Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000100B8 File Offset: 0x0000E2B8
		private void InitializeComponent()
		{
			this.components = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000100D8 File Offset: 0x0000E2D8
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x000100F0 File Offset: 0x0000E2F0
		[Category("_ZoomPictureBox")]
		public Image Image_0
		{
			get
			{
				return this._Image_0;
			}
			set
			{
				this._Image_0 = value;
				this.method_0();
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001010C File Offset: 0x0000E30C
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00010124 File Offset: 0x0000E324
		[Category("_ZoomPictureBox")]
		[DefaultValue(0)]
		public GUserControl0.GEnum0 GEnum0_0
		{
			get
			{
				return this._GEnum0_0;
			}
			set
			{
				this._GEnum0_0 = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00010138 File Offset: 0x0000E338
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00010150 File Offset: 0x0000E350
		[Browsable(false)]
		public double Double_0
		{
			get
			{
				return this._Double_0;
			}
			set
			{
				this._Double_0 = this.method_1(value);
				base.Invalidate(this.rectangle_0);
				this.rectangle_0 = this.method_5();
				base.Invalidate(this.rectangle_0);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00010190 File Offset: 0x0000E390
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000101AC File Offset: 0x0000E3AC
		[Browsable(false)]
		public Point Point_0
		{
			get
			{
				return this.rectangle_0.Location;
			}
			set
			{
				this.rectangle_0.Location = value;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000101C8 File Offset: 0x0000E3C8
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (this.bool_1 && e.Button == MouseButtons.Left)
			{
				this.point_0 = e.Location;
				this.bool_2 = true;
			}
			base.OnMouseDown(e);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00010208 File Offset: 0x0000E408
		protected override void OnMouseMove(MouseEventArgs e)
		{
			checked
			{
				if (this.bool_2)
				{
					base.Invalidate(this.rectangle_0);
					ref Rectangle ptr = ref this.rectangle_0;
					this.rectangle_0.X = ptr.X + (e.X - this.point_0.X);
					ptr = ref this.rectangle_0;
					this.rectangle_0.Y = ptr.Y + (e.Y - this.point_0.Y);
					this.point_0 = e.Location;
					base.Invalidate(this.rectangle_0);
				}
				base.OnMouseMove(e);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00010294 File Offset: 0x0000E494
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			if (this.bool_2)
			{
				this.bool_2 = false;
				base.Invalidate();
			}
			base.OnMouseUp(mevent);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000102C0 File Offset: 0x0000E4C0
		protected override void OnMouseEnter(EventArgs e)
		{
			base.Select();
			base.OnMouseEnter(e);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000102DC File Offset: 0x0000E4DC
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			if (this.bool_0 && base.Bounds.Contains(base.PointToClient(Control.MousePosition)))
			{
				double num = this._Double_0;
				num *= 1.0 + (double)e.Delta / (double)this.int_0;
				this.Double_0 = num;
			}
			base.OnMouseWheel(e);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00010340 File Offset: 0x0000E540
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this._Double_0 > 4.0)
			{
				e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
				e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			}
			else
			{
				e.Graphics.InterpolationMode = InterpolationMode.Default;
			}
			if (this._Image_0 != null)
			{
				e.Graphics.DrawImage(this._Image_0, this.rectangle_0);
			}
			base.OnPaint(e);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000103B0 File Offset: 0x0000E5B0
		protected override void OnParentChanged(EventArgs e)
		{
			this.method_0();
			base.OnParentChanged(e);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000103CC File Offset: 0x0000E5CC
		private void method_0()
		{
			if (this._Image_0 != null)
			{
				this.Double_0 = this.method_3();
				this.rectangle_0 = this.method_4();
			}
			base.Invalidate();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00010404 File Offset: 0x0000E604
		private double method_1(double double_1)
		{
			double_1 = Math.Min(double_1, this.double_0);
			checked
			{
				if (this._Image_0 != null)
				{
					if ((int)Math.Round(unchecked((double)this._Image_0.Width * double_1)) < this.int_1)
					{
						double_1 = (double)this.int_1 / (double)this._Image_0.Width;
					}
					if ((int)Math.Round(unchecked((double)this._Image_0.Height * double_1)) < this.int_2)
					{
						double_1 = (double)this.int_2 / (double)this._Image_0.Height;
					}
				}
				return double_1;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000238D File Offset: 0x0000058D
		public void method_2()
		{
			this.method_0();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00010498 File Offset: 0x0000E698
		private double method_3()
		{
			double result;
			if (base.ClientSize == Size.Empty)
			{
				result = 1.0;
			}
			else
			{
				double num = (double)this._Image_0.Width / (double)this._Image_0.Height;
				double num2 = (double)base.ClientSize.Width / (double)base.ClientSize.Height;
				if (num > num2)
				{
					result = (double)base.ClientSize.Width / (double)this._Image_0.Width;
				}
				else
				{
					result = (double)base.ClientSize.Height / (double)this._Image_0.Height;
				}
			}
			return result;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00010544 File Offset: 0x0000E744
		private Rectangle method_4()
		{
			checked
			{
				int num = (int)Math.Round(unchecked((double)this._Image_0.Width * this._Double_0));
				int num2 = (int)Math.Round(unchecked((double)this._Image_0.Height * this._Double_0));
				int x = (base.ClientSize.Width - num) / 2;
				int y = (base.ClientSize.Height - num2) / 2;
				Rectangle result = new Rectangle(x, y, num, num2);
				return result;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000105BC File Offset: 0x0000E7BC
		private Rectangle method_5()
		{
			checked
			{
				Rectangle empty;
				try
				{
					if (this._Image_0 != null)
					{
						if (this.rectangle_0 == Rectangle.Empty)
						{
							this.rectangle_0 = this.method_4();
						}
						Point point = this.method_6(this._GEnum0_0);
						double num = (double)this.rectangle_0.Width / (double)this._Image_0.Width;
						double num2 = this._Double_0 / num;
						this.rectangle_0.Width = (int)Math.Round(unchecked((double)this.rectangle_0.Width * num2));
						this.rectangle_0.Height = (int)Math.Round(unchecked((double)this.rectangle_0.Height * num2));
						Point point2;
						point2.X = (int)Math.Round(unchecked((double)point.X * num2));
						point2.Y = (int)Math.Round(unchecked((double)point.Y * num2));
						ref Rectangle ptr = ref this.rectangle_0;
						this.rectangle_0.X = ptr.X + (point.X - point2.X);
						ptr = ref this.rectangle_0;
						this.rectangle_0.Y = ptr.Y + (point.Y - point2.Y);
						empty = this.rectangle_0;
					}
					else
					{
						empty = Rectangle.Empty;
					}
				}
				catch (Exception ex)
				{
				}
				return empty;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00010718 File Offset: 0x0000E918
		private Point method_6(GUserControl0.GEnum0 genum0_0)
		{
			checked
			{
				Point empty;
				switch (genum0_0)
				{
				case (GUserControl0.GEnum0)0:
				{
					Point point = base.PointToClient(Control.MousePosition);
					empty.X = point.X - this.rectangle_0.X;
					empty.Y = point.Y - this.rectangle_0.Y;
					break;
				}
				case (GUserControl0.GEnum0)1:
					empty.X = base.Width / 2 - this.rectangle_0.X;
					empty.Y = base.Height / 2 - this.rectangle_0.Y;
					break;
				case (GUserControl0.GEnum0)2:
					empty.X = this.rectangle_0.Width / 2;
					empty.Y = this.rectangle_0.Height / 2;
					break;
				default:
					empty = Point.Empty;
					break;
				}
				return empty;
			}
		}

		// Token: 0x0400005D RID: 93
		private Container components;

		// Token: 0x0400005E RID: 94
		public int int_0;

		// Token: 0x0400005F RID: 95
		public int int_1;

		// Token: 0x04000060 RID: 96
		public int int_2;

		// Token: 0x04000061 RID: 97
		public double double_0;

		// Token: 0x04000062 RID: 98
		public bool bool_0;

		// Token: 0x04000063 RID: 99
		public bool bool_1;

		// Token: 0x04000064 RID: 100
		private Rectangle rectangle_0;

		// Token: 0x04000065 RID: 101
		private double _Double_0;

		// Token: 0x04000066 RID: 102
		private Image _Image_0;

		// Token: 0x04000067 RID: 103
		private Point point_0;

		// Token: 0x04000068 RID: 104
		private bool bool_2;

		// Token: 0x04000069 RID: 105
		private GUserControl0.GEnum0 _GEnum0_0;

		// Token: 0x02000017 RID: 23
		public enum GEnum0
		{

		}
	}
}
