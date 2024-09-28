using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000022 RID: 34
	[DesignerGenerated]
	public partial class CraxsMsgbox : Form
	{
		// Token: 0x06000221 RID: 545 RVA: 0x00011720 File Offset: 0x0000F920
		public CraxsMsgbox(string text, string text, bool bool_1)
		{
			base.Load += this.CraxsMsgbox_Load;
			base.Paint += this.CraxsMsgbox_Paint;
			this.bool_0 = true;
			this.int_0 = 30;
			this.int_1 = 3;
			this.transparent = Color.Transparent;
			this.InitializeComponent();
			this.titletext.Text = text;
			this.msgtext.Text = text;
			if (!bool_1)
			{
				this.nobtn.Visible = false;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000023E5 File Offset: 0x000005E5
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00011E04 File Offset: 0x00010004
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000023ED File Offset: 0x000005ED
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00011E18 File Offset: 0x00010018
		internal virtual DrakeUIButtonIcon nobtn
		{
			[CompilerGenerated]
			get
			{
				return this._nobtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.nobtn_Click);
				DrakeUIButtonIcon nobtn = this._nobtn;
				if (nobtn != null)
				{
					nobtn.Click -= value2;
				}
				this._nobtn = value;
				nobtn = this._nobtn;
				if (nobtn != null)
				{
					nobtn.Click += value2;
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000023F5 File Offset: 0x000005F5
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00011E5C File Offset: 0x0001005C
		internal virtual DrakeUIButtonIcon okbtn
		{
			[CompilerGenerated]
			get
			{
				return this._okbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.okbtn_Click);
				DrakeUIButtonIcon okbtn = this._okbtn;
				if (okbtn != null)
				{
					okbtn.Click -= value2;
				}
				this._okbtn = value;
				okbtn = this._okbtn;
				if (okbtn != null)
				{
					okbtn.Click += value2;
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000023FD File Offset: 0x000005FD
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00011EA0 File Offset: 0x000100A0
		internal virtual Label msgtext { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002405 File Offset: 0x00000605
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00011EB4 File Offset: 0x000100B4
		internal virtual DrakeUITitlePanel titletext { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000240D File Offset: 0x0000060D
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00011EC8 File Offset: 0x000100C8
		internal virtual Panel Panel2
		{
			[CompilerGenerated]
			get
			{
				return this._Panel2;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel2_Paint);
				Panel panel = this._Panel2;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel2 = value;
				panel = this._Panel2;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002415 File Offset: 0x00000615
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00011F0C File Offset: 0x0001010C
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00011F50 File Offset: 0x00010150
		protected override CreateParams CreateParams
		{
			get
			{
				this.method_0();
				CreateParams createParams = base.CreateParams;
				CreateParams result;
				if (this.bool_0)
				{
					result = createParams;
				}
				else
				{
					createParams.ClassStyle |= 131072;
					result = createParams;
				}
				return result;
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00011F90 File Offset: 0x00010190
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			if (msg == 133)
			{
				int num = 2;
				if (this.bool_0)
				{
					CraxsMsgbox.dwmapi.DwmSetWindowAttribute(base.Handle, 2, ref num, 4);
					CraxsMsgbox.GClass1.MARGINS margins = default(CraxsMsgbox.GClass1.MARGINS);
					margins.int_3 = 1;
					margins.int_0 = 1;
					margins.int_1 = 1;
					margins.int_2 = 1;
					CraxsMsgbox.dwmapi.DwmExtendFrameIntoClientArea(base.Handle, ref margins);
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00012008 File Offset: 0x00010208
		private void method_0()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int num = 0;
				CraxsMsgbox.dwmapi.DwmIsCompositionEnabled(ref num);
				this.bool_0 = (num == 1);
			}
			else
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001204C File Offset: 0x0001024C
		private void okbtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Yes;
			this.Timer1.Stop();
			base.Close();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00012074 File Offset: 0x00010274
		private void nobtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			this.Timer1.Stop();
			base.Close();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001209C File Offset: 0x0001029C
		private void CraxsMsgbox_Load(object sender, EventArgs e)
		{
			base.CenterToScreen();
			base.Top = 0;
			this.Timer1.Start();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000120C4 File Offset: 0x000102C4
		private void method_3(Form form_0, float float_0, Graphics graphics_0, Color color_0, float float_1)
		{
			if (base.WindowState != FormWindowState.Minimized)
			{
				using (GraphicsPath graphicsPath = this.method_4(form_0.ClientRectangle, float_0))
				{
					using (Pen pen = new Pen(color_0, float_1))
					{
						using (Matrix matrix = new Matrix())
						{
							graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
							form_0.Region = new System.Drawing.Region(graphicsPath);
							if (float_1 >= 1f)
							{
								Rectangle clientRectangle = form_0.ClientRectangle;
								float scaleX = 1f - (float_1 + 1f) / (float)clientRectangle.Width;
								float scaleY = 1f - (float_1 + 1f) / (float)clientRectangle.Height;
								matrix.Scale(scaleX, scaleY);
								matrix.Translate(float_1 / 1.6f, float_1 / 1.6f);
								graphics_0.Transform = matrix;
								graphics_0.DrawPath(pen, graphicsPath);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000121DC File Offset: 0x000103DC
		private GraphicsPath method_4(Rectangle rectangle_0, float float_0)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			float num = float_0 * 2f;
			graphicsPath.StartFigure();
			graphicsPath.AddArc((float)rectangle_0.X, (float)rectangle_0.Y, num, num, 180f, 90f);
			graphicsPath.AddArc((float)rectangle_0.Right - num, (float)rectangle_0.Y, num, num, 270f, 90f);
			graphicsPath.AddArc((float)rectangle_0.Right - num, (float)rectangle_0.Bottom - num, num, num, 0f, 90f);
			graphicsPath.AddArc((float)rectangle_0.X, (float)rectangle_0.Bottom - num, num, num, 90f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00012298 File Offset: 0x00010498
		private void method_5(Control control_0, float float_0, Graphics graphics_0, Color color_0)
		{
			using (GraphicsPath graphicsPath = this.method_4(control_0.ClientRectangle, float_0))
			{
				using (Pen pen = new Pen(color_0, 1f))
				{
					graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
					control_0.Region = new System.Drawing.Region(graphicsPath);
					graphics_0.DrawPath(pen, graphicsPath);
				}
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00012318 File Offset: 0x00010518
		private void method_6(Rectangle rectangle_0, Graphics graphics_0, Color color_0)
		{
			using (GraphicsPath graphicsPath = this.method_4(rectangle_0, (float)this.int_0))
			{
				using (Pen pen = new Pen(color_0, 3f))
				{
					graphics_0.DrawPath(pen, graphicsPath);
				}
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00012384 File Offset: 0x00010584
		private CraxsMsgbox.Struct0 method_7()
		{
			CraxsMsgbox.Struct0 result = default(CraxsMsgbox.Struct0);
			using (Bitmap bitmap = new Bitmap(1, 1))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					Rectangle rectangle = new Rectangle(0, 0, 1, 1);
					rectangle.X = checked(base.Bounds.X - 1);
					rectangle.Y = base.Bounds.Y;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					result.color_0 = bitmap.GetPixel(0, 0);
					rectangle.X = base.Bounds.Right;
					rectangle.Y = base.Bounds.Y;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					result.color_1 = bitmap.GetPixel(0, 0);
					rectangle.X = base.Bounds.X;
					rectangle.Y = base.Bounds.Bottom;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					result.color_2 = bitmap.GetPixel(0, 0);
					rectangle.X = base.Bounds.Right;
					rectangle.Y = base.Bounds.Bottom;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					result.color_3 = bitmap.GetPixel(0, 0);
				}
			}
			return result;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00012560 File Offset: 0x00010760
		private void CraxsMsgbox_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle clientRectangle = base.ClientRectangle;
			checked
			{
				int num = (int)Math.Round((double)clientRectangle.Width / 2.0);
				int num2 = (int)Math.Round((double)clientRectangle.Height / 2.0);
				CraxsMsgbox.Struct0 @struct = this.method_7();
				this.method_6(clientRectangle, e.Graphics, @struct.color_0);
				Rectangle rectangle_ = new Rectangle(clientRectangle.Right - num, clientRectangle.Y, num, num2);
				this.method_6(rectangle_, e.Graphics, @struct.color_1);
				Rectangle rectangle_2 = new Rectangle(clientRectangle.X, clientRectangle.Bottom - num2, num, num2);
				this.method_6(rectangle_2, e.Graphics, @struct.color_2);
				Rectangle rectangle_3 = new Rectangle(clientRectangle.Right - num, clientRectangle.Bottom - num2, num, num2);
				this.method_6(rectangle_3, e.Graphics, @struct.color_3);
				this.method_3(this, (float)this.int_0, e.Graphics, this.transparent, (float)this.int_1);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00012678 File Offset: 0x00010878
		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
			this.method_5(this.Panel2, (float)this.int_0 - (float)this.int_1 / 2f, e.Graphics, this.transparent);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000126B4 File Offset: 0x000108B4
		private void Timer1_Tick(object sender, EventArgs e)
		{
			base.TopMost = true;
			base.BringToFront();
		}

		// Token: 0x04000086 RID: 134
		private bool bool_0;

		// Token: 0x04000087 RID: 135
		private int int_0;

		// Token: 0x04000088 RID: 136
		private int int_1;

		// Token: 0x04000089 RID: 137
		private Color transparent;

		// Token: 0x02000023 RID: 35
		public class GClass1
		{
			// Token: 0x02000024 RID: 36
			public struct MARGINS
			{
				// Token: 0x0400008A RID: 138
				public int int_0;

				// Token: 0x0400008B RID: 139
				public int int_1;

				// Token: 0x0400008C RID: 140
				public int int_2;

				// Token: 0x0400008D RID: 141
				public int int_3;
			}
		}

		// Token: 0x02000025 RID: 37
		public class dwmapi
		{
			// Token: 0x06000242 RID: 578
			[DllImport("dwmapi")]
			public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref CraxsMsgbox.GClass1.MARGINS pMarInset);

			// Token: 0x06000243 RID: 579
			[DllImport("dwmapi")]
			internal static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

			// Token: 0x06000244 RID: 580
			[DllImport("dwmapi.dll")]
			public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
		}

		// Token: 0x02000026 RID: 38
		public class GClass2
		{
		}

		// Token: 0x02000027 RID: 39
		private struct Struct0
		{
			// Token: 0x0400008E RID: 142
			public Color color_0;

			// Token: 0x0400008F RID: 143
			public Color color_1;

			// Token: 0x04000090 RID: 144
			public Color color_2;

			// Token: 0x04000091 RID: 145
			public Color color_3;
		}
	}
}
