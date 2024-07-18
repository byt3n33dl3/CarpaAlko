using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000E2 RID: 226
	[DesignerGenerated]
	public partial class Report : Form
	{
		// Token: 0x0600114A RID: 4426 RVA: 0x000B4784 File Offset: 0x000B2984
		public Report()
		{
			base.Load += this.Report_Load;
			base.MouseClick += this.Report_MouseClick;
			base.Closing += this.Report_Closing;
			this.black = Color.Black;
			this.color_0 = Color.FromArgb(157, 5, 17);
			this.int_0 = 5;
			this.int_1 = 5;
			this.int_2 = 9;
			this.int_3 = 15;
			this.InitializeComponent();
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0000726C File Offset: 0x0000546C
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x000B4918 File Offset: 0x000B2B18
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

		// Token: 0x0600114F RID: 4431 RVA: 0x000B495C File Offset: 0x000B2B5C
		private async void method_1(Form form_0, int int_1 = 80)
		{
			while (form_0.Opacity < 1.0)
			{
				TaskAwaiter taskAwaiter = Task.Delay(int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
				taskAwaiter = default(TaskAwaiter);
				form_0.Opacity += 0.05;
			}
			form_0.Opacity = 1.0;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x000B49A4 File Offset: 0x000B2BA4
		private async void method_2(Form form_0, int int_1 = 80)
		{
			while (form_0.Opacity > 0.0)
			{
				TaskAwaiter taskAwaiter = Task.Delay(int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
				taskAwaiter = default(TaskAwaiter);
				form_0.Opacity -= 0.05;
			}
			form_0.Opacity = 0.0;
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x000B49EC File Offset: 0x000B2BEC
		public void method_3(Bitmap bitmap_0, string string_0)
		{
			Report.Class25 @class = new Report.Class25();
			@class.report_0 = this;
			@class.bitmap_0 = bitmap_0;
			@class.string_0 = string_0;
			Task task = new Task(new Action(@class.method_0));
			task.RunSynchronously();
			task.Wait();
			task.Dispose();
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x000B4A38 File Offset: 0x000B2C38
		private object method_4(Bitmap image_0, string string_0)
		{
			object object_ = GClass9.object_5;
			ObjectFlowControl.CheckForSyncLockOnValueType(object_);
			lock (object_)
			{
				if (this.gclass5s_0.Count >= 60)
				{
					this.gclass5s_0.RemoveAt(0);
				}
				try
				{
					GClass5 item = new GClass5
					{
						image_0 = image_0,
						string_0 = string_0
					};
					this.gclass5s_0.Add(item);
					if (this.gclass5s_0.Count > 0 & !this.bool_0)
					{
						this.method_6();
					}
				}
				catch (InvalidOperationException ex)
				{
				}
			}
			return null;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x000B4B00 File Offset: 0x000B2D00
		private void Report_Load(object sender, EventArgs e)
		{
			this.intptr_0 = base.Handle;
			this.bool_0 = false;
			this.gclass5s_0 = new List<GClass5>();
			checked
			{
				int x;
				if (Operators.CompareString(Module5.location, "Right", false) == 0)
				{
					x = Screen.PrimaryScreen.WorkingArea.Width - base.Width;
				}
				else
				{
					x = 5;
				}
				int y = Screen.PrimaryScreen.WorkingArea.Height - base.Height;
				base.Location = new Point(x, y);
				this.Bgworker = new BackgroundWorker();
				if (!this.Bgworker.IsBusy)
				{
					this.Bgworker.RunWorkerAsync();
				}
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x000B4BAC File Offset: 0x000B2DAC
		public void method_6()
		{
			this.bool_0 = true;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x000B4BC0 File Offset: 0x000B2DC0
		public void method_7()
		{
			this.bool_0 = false;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x000B4BD4 File Offset: 0x000B2DD4
		private void Bgworker_DoWork(object sender, DoWorkEventArgs e)
		{
			checked
			{
				for (;;)
				{
					Thread.Sleep(1);
					try
					{
						Thread.Sleep(25);
						if (this.gclass5s_0.Count > 0 & this.bool_0)
						{
							try
							{
								object object_ = GClass9.object_5;
								ObjectFlowControl.CheckForSyncLockOnValueType(object_);
								lock (object_)
								{
									Bitmap bitmap = new Bitmap(base.Width, base.Height);
									Graphics graphics = Graphics.FromImage(bitmap);
									graphics.SmoothingMode = SmoothingMode.AntiAlias;
									graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
									graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
									graphics.CompositingQuality = CompositingQuality.GammaCorrected;
									graphics.CompositingMode = CompositingMode.SourceOver;
									try
									{
										foreach (GClass5 gclass in this.gclass5s_0)
										{
											if (gclass.Height <= this.int_2)
											{
												gclass.Height = this.int_2;
											}
											else
											{
												int count = this.gclass5s_0.Count;
												if (count <= 60)
												{
													if (count <= 20)
													{
														if (count <= 15)
														{
															if (count <= 10)
															{
																if (count <= 5)
																{
																	gclass.Height += -1;
																}
																else
																{
																	gclass.Height += -2;
																}
															}
															else
															{
																gclass.Height += -4;
															}
														}
														else
														{
															gclass.Height += -8;
														}
													}
													else
													{
														gclass.Height += -14;
													}
												}
												else
												{
													gclass.Height = this.int_2;
												}
												if (gclass.Height <= this.int_2)
												{
													gclass.Height = this.int_2;
												}
											}
											SizeF sizeF = default(SizeF);
											int height = (int)Math.Round((double)(unchecked(graphics.MeasureString(gclass.string_0, Module8.font_1).Height + (float)this.int_0)));
											Rectangle rectangle = new Rectangle(0, gclass.Height, base.Width, height);
											LinearGradientBrush brush = new LinearGradientBrush(rectangle, this.black, this.black, LinearGradientMode.BackwardDiagonal);
											GraphicsPath path = this.method_11(rectangle, (Operators.CompareString(Module5.Round, "Yes", false) == 0) ? 12 : 1);
											graphics.FillPath(brush, path);
											rectangle = new Rectangle(0, gclass.Height - this.int_0, 0, 0);
											ControlPaint.DrawLockedFrame(graphics, rectangle, false);
											object[] array = new object[2];
											array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(gclass.image_0.Clone()));
											Point point = new Point(base.Width - gclass.image_0.Width - 7, gclass.Height + this.int_0);
											array[1] = point;
											NewLateBinding.LateCall(graphics, null, "DrawImage", array, null, null, null, true);
											using (SolidBrush solidBrush = new SolidBrush(this.color_0))
											{
												graphics.DrawString(gclass.string_0, Module8.font_1, solidBrush, (float)this.int_1, (float)(gclass.Height + this.int_0));
											}
											if (gclass.Height > base.Height - 50)
											{
												break;
											}
										}
									}
									finally
									{
										List<GClass5>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									try
									{
										IL_318:
										foreach (GClass5 gclass2 in this.gclass5s_0)
										{
											if (!gclass2.bool_0)
											{
												gclass2.dateTime_0 = DateTime.Now.AddSeconds((double)this.int_3);
												gclass2.bool_0 = true;
											}
											int num = DateTime.Compare(gclass2.dateTime_0, DateTime.Now);
											if (num < 0)
											{
												this.gclass5s_0.Remove(gclass2);
												goto IL_3A3;
											}
										}
										goto IL_3A9;
									}
									finally
									{
										List<GClass5>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									goto IL_3A3;
									IL_3A9:
									if (this.gclass5s_0.Count == 0 & this.bool_0)
									{
										bitmap = null;
										this.method_7();
									}
									graphics.Flush(FlushIntention.Sync);
									graphics.Dispose();
									this.method_13(bitmap);
									continue;
									IL_3A3:
									goto IL_318;
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x000B508C File Offset: 0x000B328C
		private async void Report_MouseClick(object sender, MouseEventArgs e)
		{
			TaskAwaiter<object> taskAwaiter = Task.Factory.StartNew<object>(new Func<object>(this.method_14), TaskCreationOptions.None).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<object> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<object>);
			}
			taskAwaiter.GetResult();
			taskAwaiter = default(TaskAwaiter<object>);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x000B50D4 File Offset: 0x000B32D4
		private object method_10()
		{
			object object_ = GClass9.object_5;
			ObjectFlowControl.CheckForSyncLockOnValueType(object_);
			lock (object_)
			{
				this.gclass5s_0.Clear();
				this.method_12();
				this.method_7();
			}
			return null;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x000B5134 File Offset: 0x000B3334
		public GraphicsPath method_11(Rectangle rectangle_0, int int_4)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			checked
			{
				graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_4, rectangle_0.Y, int_4, int_4, 270f, 90f);
				graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_4, rectangle_0.Y + rectangle_0.Height - int_4, int_4, int_4, 0f, 90f);
				graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_4, int_4, int_4, 90f, 90f);
				graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y, int_4, int_4, 180f, 90f);
				graphicsPath.CloseFigure();
				return graphicsPath;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x000B51F8 File Offset: 0x000B33F8
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				if (!base.DesignMode)
				{
					createParams.ExStyle |= 524288;
				}
				return createParams;
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x000B522C File Offset: 0x000B342C
		public void method_12()
		{
			if (!base.IsDisposed && base.Width > 0 && base.Height > 0)
			{
				Bitmap bitmap_ = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb);
				this.method_13(bitmap_);
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x000B5278 File Offset: 0x000B3478
		public void method_13(Bitmap bitmap_0)
		{
			if (!base.IsDisposed && base.Width > 0 && base.Height > 0)
			{
				using (Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb))
				{
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.SmoothingMode = SmoothingMode.AntiAlias;
						graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
						graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
						graphics.CompositingQuality = CompositingQuality.GammaCorrected;
						graphics.CompositingMode = CompositingMode.SourceOver;
						if (bitmap_0 != null)
						{
							graphics.DrawImage(bitmap_0, new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height));
						}
						IntPtr dc = NativeMethods_1.GetDC(IntPtr.Zero);
						IntPtr intPtr = NativeMethods_1.CreateCompatibleDC(dc);
						IntPtr hbitmap = bitmap.GetHbitmap(Color.FromArgb(0));
						IntPtr h = NativeMethods_1.SelectObject(intPtr, hbitmap);
						NativeMethods_1.BLENDFUNCTION blendfunction = new NativeMethods_1.BLENDFUNCTION(225);
						Point location = base.Location;
						Size size = bitmap.Size;
						Point empty = Point.Empty;
						NativeMethods_1.UpdateLayeredWindow(this.intptr_0, dc, ref location, ref size, intPtr, ref empty, 0, ref blendfunction, 2);
						NativeMethods_1.SelectObject(intPtr, h);
						NativeMethods_1.DeleteObject(hbitmap);
						NativeMethods_1.DeleteDC(intPtr);
						NativeMethods_1.DeleteDC(dc);
					}
				}
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000B53D4 File Offset: 0x000B35D4
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (base.Created)
			{
				this.method_13(null);
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000B53F8 File Offset: 0x000B35F8
		protected override void OnLocationChanged(EventArgs e)
		{
			base.OnLocationChanged(e);
			if (base.Created)
			{
				this.method_13(null);
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000B541C File Offset: 0x000B361C
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (base.Visible)
			{
				this.method_13(null);
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000B5440 File Offset: 0x000B3640
		private void Report_Closing(object sender, CancelEventArgs e)
		{
			if (this.Bgworker != null)
			{
				this.Bgworker.Dispose();
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000B5464 File Offset: 0x000B3664
		[CompilerGenerated]
		private object method_14()
		{
			return this.method_10();
		}

		// Token: 0x0400095E RID: 2398
		public List<GClass5> gclass5s_0;

		// Token: 0x04000960 RID: 2400
		private IntPtr intptr_0;

		// Token: 0x04000961 RID: 2401
		private Color black;

		// Token: 0x04000962 RID: 2402
		private Color color_0;

		// Token: 0x04000963 RID: 2403
		private int int_0;

		// Token: 0x04000964 RID: 2404
		private int int_1;

		// Token: 0x04000965 RID: 2405
		private int int_2;

		// Token: 0x04000966 RID: 2406
		private int int_3;

		// Token: 0x04000967 RID: 2407
		private bool bool_0;

		// Token: 0x020000E5 RID: 229
		[CompilerGenerated]
		internal sealed class Class25
		{
			// Token: 0x06001169 RID: 4457 RVA: 0x000B56D4 File Offset: 0x000B38D4
			internal void method_0()
			{
				this.method_1();
			}

			// Token: 0x0600116A RID: 4458 RVA: 0x000B56E8 File Offset: 0x000B38E8
			internal object method_1()
			{
				return this.report_0.method_4(this.bitmap_0, this.string_0);
			}

			// Token: 0x04000976 RID: 2422
			public Bitmap bitmap_0;

			// Token: 0x04000977 RID: 2423
			public string string_0;

			// Token: 0x04000978 RID: 2424
			public Report report_0;
		}
	}
}
