using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000D1 RID: 209
	[StandardModule]
	public sealed class GModule1
	{
		// Token: 0x06000F9A RID: 3994 RVA: 0x000A7BFC File Offset: 0x000A5DFC
		public static Image smethod_0(string string_0)
		{
			string text = GClass9.gclass4_0.method_5(string_0.Trim()).ToUpper();
			int num = Array.IndexOf<string>(GClass9.gclass4_0.strings_1, text);
			int num2 = GClass9.imageList_0.Images.IndexOfKey(text);
			int num3 = num;
			checked
			{
				if (num3 != -1)
				{
					if (num3 == GClass9.gclass4_0.strings_0.Length)
					{
						num--;
						num2 = -1;
					}
					else if (num3 > GClass9.gclass4_0.strings_0.Length)
					{
						num2 = -1;
					}
				}
				else
				{
					num2 = -1;
				}
				Image result;
				try
				{
					if (num2 == -1)
					{
						num2 = GClass9.imageList_0.Images.IndexOfKey("-1".ToUpper());
					}
					result = GClass9.imageList_0.Images[num2];
				}
				catch (Exception ex)
				{
					result = GClass9.imageList_0.Images[0];
				}
				return result;
			}
		}
	}
}
