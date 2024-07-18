using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x0200010E RID: 270
	public class GClass12 : ToolStripSystemRenderer
	{
		// Token: 0x06001316 RID: 4886 RVA: 0x000CECE8 File Offset: 0x000CCEE8
		public GClass12()
		{
			this.bool_0 = false;
			this.Bool_0 = false;
			this.color_0 = Module5.White;
			this.color_1 = Module5.color_0;
			this.color_2 = Module5.color_0;
			this.color_3 = Color.FromArgb(45, 45, 48);
			this.color_4 = Module5.White;
			this.color_5 = Module5.White;
			this.color_6 = Color.FromArgb(10, 10, 10);
			this.color_7 = Module5.color_0;
			this.color_8 = Module5.color_0;
			this.color_9 = Color.FromArgb(101, 101, 101);
			this.color_10 = Color.FromArgb(123, 123, 123);
			this.color_11 = Module5.White;
			this.color_12 = Module5.color_0;
			this.color_13 = Color.FromArgb(70, 70, 70);
			this.color_14 = Module5.White;
			this.font_0 = Module8.font_1;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000CEDD8 File Offset: 0x000CCFD8
		public void method_0(Graphics graphics_0, int int_0, int int_1, int int_2, int int_3, int int_4, Color color_15)
		{
			checked
			{
				try
				{
					Pen pen = new Pen(color_15);
					RectangleF rectangleF = new RectangleF((float)int_0, (float)int_1, (float)int_2, (float)int_3);
					RectangleF rect = new RectangleF(rectangleF.Location, new SizeF((float)int_4, (float)int_4));
					graphics_0.DrawArc(pen, rect, 180f, 90f);
					graphics_0.DrawLine(pen, int_0 + (int)Math.Round((double)int_4 / 2.0), int_1, int_0 + int_2 - (int)Math.Round((double)int_4 / 2.0), int_1);
					rect.X = unchecked(rectangleF.Right - (float)int_4);
					graphics_0.DrawArc(pen, rect, 270f, 90f);
					graphics_0.DrawLine(pen, int_0 + int_2, int_1 + (int)Math.Round((double)int_4 / 2.0), int_0 + int_2, int_1 + int_3 - (int)Math.Round((double)int_4 / 2.0));
					rect.Y = unchecked(rectangleF.Bottom - (float)int_4);
					graphics_0.DrawArc(pen, rect, 0f, 90f);
					graphics_0.DrawLine(pen, int_0 + (int)Math.Round((double)int_4 / 2.0), int_1 + int_3, int_0 + int_2 - (int)Math.Round((double)int_4 / 2.0), int_1 + int_3);
					rect.X = rectangleF.Left;
					graphics_0.DrawArc(pen, rect, 90f, 90f);
					graphics_0.DrawLine(pen, int_0, int_1 + (int)Math.Round((double)int_4 / 2.0), int_0, int_1 + int_3 - (int)Math.Round((double)int_4 / 2.0));
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x000CEFA4 File Offset: 0x000CD1A4
		protected override void Initialize(ToolStrip toolStrip)
		{
			try
			{
				base.Initialize(toolStrip);
				if (!(toolStrip is MenuStrip))
				{
					if (!(toolStrip is ToolStripDropDownMenu))
					{
						if (toolStrip is ToolStrip)
						{
							toolStrip.ForeColor = this.color_4;
							toolStrip.BackColor = this.color_2;
						}
					}
					else
					{
						toolStrip.ForeColor = this.color_4;
						toolStrip.BackColor = this.color_2;
					}
				}
				else
				{
					toolStrip.ForeColor = this.color_4;
					toolStrip.BackColor = this.color_3;
				}
				toolStrip.Font = this.font_0;
				toolStrip.Padding = new Padding(5, 2, 5, 2);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000CF064 File Offset: 0x000CD264
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			checked
			{
				if (e.ToolStrip is ToolStripDropDownMenu)
				{
					Pen pen = new Pen(this.color_14, 1f);
					e.Graphics.DrawRectangle(pen, 0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
					pen.Dispose();
				}
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000CF0C0 File Offset: 0x000CD2C0
		public Bitmap method_1(Image image_0, Color color_15, Color color_16)
		{
			float[][] array = new float[5][];
			int num = 0;
			float[] array2 = new float[5];
			array2[0] = 1f;
			array[num] = array2;
			int num2 = 1;
			float[] array3 = new float[5];
			array3[1] = 1f;
			array[num2] = array3;
			int num3 = 2;
			float[] array4 = new float[5];
			array4[2] = 1f;
			array[num3] = array4;
			int num4 = 3;
			float[] array5 = new float[5];
			array5[3] = 1f;
			array[num4] = array5;
			array[4] = checked(new float[]
			{
				(float)(color_16.R - color_15.R) / 255f,
				(float)(color_16.G - color_15.G) / 255f,
				(float)(color_16.B - color_15.B) / 255f,
				0f,
				1f
			});
			ColorMatrix colorMatrix = new ColorMatrix(array);
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix);
			Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(image_0, new Rectangle(0, 0, image_0.Width, image_0.Height), 0, 0, image_0.Width, image_0.Height, GraphicsUnit.Pixel, imageAttributes);
			}
			return bitmap;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000CF1F0 File Offset: 0x000CD3F0
		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		{
			if (!this.bool_0)
			{
				try
				{
					foreach (object obj in e.ToolStrip.Items)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						if (NewLateBinding.LateGet(objectValue, null, "Image", new object[0], null, null, null) != null)
						{
							Image image_ = (Image)NewLateBinding.LateGet(objectValue, null, "Image", new object[0], null, null, null);
							NewLateBinding.LateSet(objectValue, null, "Image", new object[]
							{
								this.method_1(image_, Color.FromArgb(190, 190, 190), Module5.White)
							}, null, null);
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
				this.bool_0 = true;
			}
			checked
			{
				try
				{
					if (!(e.ToolStrip is ToolStripDropDownMenu))
					{
						if (e.ToolStrip is MenuStrip)
						{
							if (!e.Item.IsOnDropDown && e.Item.Selected)
							{
								if (e.Item.Enabled)
								{
									if (!e.Item.Pressed)
									{
										Rectangle rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height);
										LinearGradientBrush brush = new LinearGradientBrush(rect, this.color_0, this.color_0, LinearGradientMode.Vertical);
										e.Graphics.FillRectangle(brush, rect);
										this.method_0(e.Graphics, rect.Left, rect.Top, rect.Width - 1, rect.Height - 1, 1, this.color_5);
									}
									else
									{
										Rectangle rect2 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height);
										LinearGradientBrush brush2 = new LinearGradientBrush(rect2, this.color_2, this.color_2, LinearGradientMode.Vertical);
										e.Graphics.FillRectangle(brush2, rect2);
										this.method_0(e.Graphics, rect2.Left, rect2.Top, rect2.Width - 1, rect2.Height - 1, 1, this.color_14);
									}
								}
								e.Item.ForeColor = this.color_1;
							}
							else
							{
								if (e.Item.Enabled && e.Item.Pressed)
								{
									Rectangle rect3 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height);
									LinearGradientBrush brush3 = new LinearGradientBrush(rect3, this.color_2, this.color_2, LinearGradientMode.Vertical);
									e.Graphics.FillRectangle(brush3, rect3);
									this.method_0(e.Graphics, rect3.Left, rect3.Top, rect3.Width - 1, rect3.Height - 1, 1, this.color_14);
								}
								e.Item.ForeColor = this.color_4;
							}
						}
					}
					else if (e.Item.Selected)
					{
						if (e.Item.Enabled)
						{
							Array array = (Array)e.Item.Tag;
							if (e.Item.Image != null && Conversions.ToInteger(NewLateBinding.LateIndexGet(array, new object[]
							{
								0
							}, null)) == 0)
							{
								NewLateBinding.LateIndexSet(array, new object[]
								{
									0,
									1
								}, null);
								if (Operators.CompareString(NewLateBinding.LateIndexGet(array, new object[]
								{
									2
								}, null).ToString(), "null", false) != 0)
								{
									e.Item.Image = (Image)NewLateBinding.LateIndexGet(array, new object[]
									{
										2
									}, null);
								}
								else
								{
									Image image = e.Item.Image;
									NewLateBinding.LateIndexSet(array, new object[]
									{
										2,
										this.method_1(image, Module5.White, Module5.color_0)
									}, null);
									e.Item.Image = (Image)NewLateBinding.LateIndexGet(array, new object[]
									{
										2
									}, null);
								}
								e.Item.Tag = array;
							}
							Rectangle rect4 = new Rectangle(1, 0, e.Item.Width - 1, e.Item.Height);
							LinearGradientBrush brush4 = new LinearGradientBrush(rect4, this.color_0, this.color_0, LinearGradientMode.Vertical);
							e.Graphics.FillRectangle(brush4, rect4);
							this.method_0(e.Graphics, rect4.Left, rect4.Top, rect4.Width - 1, rect4.Height - 1, 1, this.color_5);
							e.Item.ForeColor = this.color_1;
						}
					}
					else
					{
						Array array2 = (Array)e.Item.Tag;
						if (e.Item.Image != null && Conversions.ToInteger(NewLateBinding.LateIndexGet(array2, new object[]
						{
							0
						}, null)) == 1)
						{
							NewLateBinding.LateIndexSet(array2, new object[]
							{
								0,
								0
							}, null);
							if (Operators.CompareString(NewLateBinding.LateIndexGet(array2, new object[]
							{
								1
							}, null).ToString(), "null", false) == 0)
							{
								Image image2 = e.Item.Image;
								NewLateBinding.LateIndexSet(array2, new object[]
								{
									1,
									this.method_1(image2, Module5.color_0, Module5.White)
								}, null);
								e.Item.Image = (Image)NewLateBinding.LateIndexGet(array2, new object[]
								{
									1
								}, null);
							}
							else
							{
								e.Item.Image = (Image)NewLateBinding.LateIndexGet(array2, new object[]
								{
									1
								}, null);
							}
							e.Item.Tag = array2;
						}
						e.Item.ForeColor = this.color_4;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000CF838 File Offset: 0x000CDA38
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
		{
			try
			{
				if (!e.Item.Selected)
				{
					if (!e.Item.Enabled)
					{
						e.ArrowColor = this.color_13;
					}
					else
					{
						e.ArrowColor = this.color_11;
					}
				}
				else if (!e.Item.Enabled)
				{
					e.ArrowColor = this.color_13;
				}
				else
				{
					e.ArrowColor = this.color_12;
				}
				base.OnRenderArrow(e);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x000075B9 File Offset: 0x000057B9
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x000CF8D0 File Offset: 0x000CDAD0
		public bool Bool_0 { get; set; }

		// Token: 0x0600131F RID: 4895 RVA: 0x000CF8E4 File Offset: 0x000CDAE4
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			checked
			{
				if (!e.Vertical && e.Item is ToolStripSeparator && !this.Bool_0)
				{
					Rectangle rectangle = new Rectangle(Point.Empty, e.Item.Size);
					int num = (int)Math.Round(unchecked((double)rectangle.Bottom - (double)rectangle.Height / 2.0 - 1.0));
					int x = rectangle.Left + 30;
					int x2 = rectangle.Right - 10;
					e.Graphics.DrawLine(new Pen(new SolidBrush(this.color_7)), x, num, x2, num);
					e.Graphics.DrawLine(new Pen(new SolidBrush(this.color_8)), x, num + 1, x2, num + 1);
				}
				else
				{
					base.OnRenderSeparator(e);
				}
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000CF9C0 File Offset: 0x000CDBC0
		protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
		{
			checked
			{
				try
				{
					base.OnRenderImageMargin(e);
					Color color = this.color_0;
					SolidBrush brush = new SolidBrush(this.color_7);
					SolidBrush brush2 = new SolidBrush(this.color_8);
					Rectangle rect = new Rectangle(e.AffectedBounds.Width + 0, 2, 1, e.AffectedBounds.Height);
					Rectangle rect2 = new Rectangle(e.AffectedBounds.Width + 1, 2, 1, e.AffectedBounds.Height);
					new Pen(color);
					e.Graphics.FillRectangle(brush, rect);
					e.Graphics.FillRectangle(brush2, rect2);
					e.ToolStrip.BackColor = this.color_2;
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x04000CD4 RID: 3284
		private bool bool_0;

		// Token: 0x04000CD6 RID: 3286
		public Color color_0;

		// Token: 0x04000CD7 RID: 3287
		public Color color_1;

		// Token: 0x04000CD8 RID: 3288
		public Color color_2;

		// Token: 0x04000CD9 RID: 3289
		public Color color_3;

		// Token: 0x04000CDA RID: 3290
		public Color color_4;

		// Token: 0x04000CDB RID: 3291
		public Color color_5;

		// Token: 0x04000CDC RID: 3292
		public Color color_6;

		// Token: 0x04000CDD RID: 3293
		public Color color_7;

		// Token: 0x04000CDE RID: 3294
		public Color color_8;

		// Token: 0x04000CDF RID: 3295
		public Color color_9;

		// Token: 0x04000CE0 RID: 3296
		public Color color_10;

		// Token: 0x04000CE1 RID: 3297
		public Color color_11;

		// Token: 0x04000CE2 RID: 3298
		public Color color_12;

		// Token: 0x04000CE3 RID: 3299
		public Color color_13;

		// Token: 0x04000CE4 RID: 3300
		public Color color_14;

		// Token: 0x04000CE5 RID: 3301
		public Font font_0;
	}
}
