using System;
using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000F1 RID: 241
	[StandardModule]
	internal sealed class Module10
	{
		// Token: 0x060011A5 RID: 4517 RVA: 0x000B8430 File Offset: 0x000B6630
		public static Font smethod_0(string string_0, int int_0, FontStyle fontStyle_0)
		{
			Module10.privateFontCollection_0 = new PrivateFontCollection();
			Module10.privateFontCollection_0.AddFontFile(Module8.string_1 + "\\Fonts\\" + string_0);
			return new Font(Module10.privateFontCollection_0.Families[0], (float)int_0, fontStyle_0);
		}

		// Token: 0x040009BB RID: 2491
		private static PrivateFontCollection privateFontCollection_0 = null;
	}
}
