using System;
using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000F0 RID: 240
	[StandardModule]
	internal sealed class Module9
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x000B83D0 File Offset: 0x000B65D0
		public static Font smethod_0(string string_0, int int_0, FontStyle fontStyle_0)
		{
			Module9.privateFontCollection_0 = new PrivateFontCollection();
			Module9.privateFontCollection_0.AddFontFile(Module8.string_1 + "\\Fonts\\" + string_0);
			return new Font(Module9.privateFontCollection_0.Families[0], (float)int_0, fontStyle_0);
		}

		// Token: 0x040009BA RID: 2490
		private static PrivateFontCollection privateFontCollection_0 = null;
	}
}
