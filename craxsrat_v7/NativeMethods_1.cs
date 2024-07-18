using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Craxs_Rat
{
	// Token: 0x020000E7 RID: 231
	public class NativeMethods_1
	{
		// Token: 0x0600116F RID: 4463
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool UpdateLayeredWindow(IntPtr hWnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, int crKey, ref NativeMethods_1.BLENDFUNCTION pblend, int dwFlags);

		// Token: 0x06001170 RID: 4464
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr GetDC(IntPtr hWnd);

		// Token: 0x06001171 RID: 4465
		[DllImport("gdi32.dll")]
		internal static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		// Token: 0x06001172 RID: 4466
		[DllImport("gdi32.dll")]
		internal static extern IntPtr SelectObject(IntPtr hdc, IntPtr h);

		// Token: 0x06001173 RID: 4467
		[DllImport("gdi32.dll")]
		internal static extern IntPtr DeleteDC(IntPtr hdc);

		// Token: 0x06001174 RID: 4468
		[DllImport("gdi32.dll")]
		internal static extern IntPtr DeleteObject(IntPtr ho);

		// Token: 0x020000E8 RID: 232
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct BLENDFUNCTION
		{
			// Token: 0x06001175 RID: 4469 RVA: 0x000B57F4 File Offset: 0x000B39F4
			public BLENDFUNCTION(byte byte_2)
			{
				this = default(NativeMethods_1.BLENDFUNCTION);
				this.byte_0 = 0;
				this.byte_1 = 0;
				this.byte_2 = byte_2;
				this.byte_3 = 1;
			}

			// Token: 0x0400097F RID: 2431
			public byte byte_0;

			// Token: 0x04000980 RID: 2432
			public byte byte_1;

			// Token: 0x04000981 RID: 2433
			public byte byte_2;

			// Token: 0x04000982 RID: 2434
			public byte byte_3;
		}

		// Token: 0x020000E9 RID: 233
		internal struct Struct1
		{
			// Token: 0x04000983 RID: 2435
			public int int_0;

			// Token: 0x04000984 RID: 2436
			public int int_1;

			// Token: 0x04000985 RID: 2437
			public int int_2;

			// Token: 0x04000986 RID: 2438
			public int int_3;
		}
	}
}
