using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000121 RID: 289
internal class Class34
{
	// Token: 0x06001367 RID: 4967 RVA: 0x000D1590 File Offset: 0x000CF790
	static Class34()
	{
		Class34.tMmvmVecn = typeof(Class34).Assembly;
		Class34.uint_0 = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};
		Class34.bool_0 = false;
		Class34.bool_3 = false;
		Class34.object_0 = null;
		Class34.dictionary_0 = null;
		Class34.object_1 = new object();
		Class34.int_4 = 0;
		Class34.object_2 = new object();
		Class34.list_0 = null;
		Class34.list_1 = null;
		Class34.byte_1 = new byte[0];
		Class34.byte_0 = new byte[0];
		Class34.intptr_3 = IntPtr.Zero;
		Class34.intptr_0 = IntPtr.Zero;
		Class34.string_0 = new string[0];
		Class34.int_5 = new int[0];
		Class34.int_1 = 1;
		Class34.bool_1 = false;
		Class34.sortedList_0 = new SortedList();
		Class34.int_2 = 0;
		Class34.long_0 = 0L;
		Class34.delegate9_1 = null;
		Class34.delegate9_0 = null;
		Class34.long_1 = 0L;
		Class34.int_3 = 0;
		Class34.bool_2 = false;
		Class34.BmwDsdqaTf = false;
		Class34.int_0 = 0;
		Class34.intptr_1 = IntPtr.Zero;
		Class34.firstrundone = false;
		Class34.hashtable_0 = new Hashtable();
		Class34.delegate11_0 = null;
		Class34.delegate12_0 = null;
		Class34.delegate13_0 = null;
		Class34.delegate14_0 = null;
		Class34.delegate15_0 = null;
		Class34.delegate16_0 = null;
		Class34.intptr_2 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x0000246D File Offset: 0x0000066D
	private void method_0()
	{
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x000D170C File Offset: 0x000CF90C
	internal static byte[] smethod_0(object object_3)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - object_3.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)object_3.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)object_3.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < object_3.Length; i++)
		{
			array2[i] = object_3[i];
		}
		byte[] array3 = array2;
		int num4 = object_3.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class34.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class34.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class34.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class34.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class34.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class34.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class34.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class34.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class34.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class34.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class34.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class34.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class34.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class34.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class34.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class34.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class34.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class34.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class34.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class34.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class34.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class34.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class34.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class34.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class34.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class34.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class34.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class34.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class34.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class34.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class34.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class34.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class34.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class34.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class34.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class34.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class34.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class34.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class34.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class34.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class34.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class34.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class34.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class34.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class34.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class34.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class34.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class34.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class34.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class34.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class34.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class34.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class34.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class34.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class34.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class34.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class34.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class34.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class34.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class34.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class34.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class34.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class34.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class34.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00007651 File Offset: 0x00005851
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class34.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + object_3[(int)uint_5] + Class34.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0000767A File Offset: 0x0000587A
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class34.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + object_3[(int)uint_5] + Class34.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x000076A3 File Offset: 0x000058A3
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class34.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + object_3[(int)uint_5] + Class34.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x000076C9 File Offset: 0x000058C9
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class34.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + object_3[(int)uint_5] + Class34.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x000076F0 File Offset: 0x000058F0
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x00007702 File Offset: 0x00005902
	internal static bool smethod_6()
	{
		if (!Class34.bool_0)
		{
			Class34.smethod_8();
			Class34.bool_0 = true;
		}
		return Class34.bool_3;
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00002A98 File Offset: 0x00000C98
	internal Class34()
	{
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x000D1D6C File Offset: 0x000CFF6C
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)byte_2[(int)(num7 + 3U)] << 24 | (int)byte_2[(int)(num7 + 2U)] << 16 | (int)byte_2[(int)(num7 + 1U)] << 8 | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)((int)byte_4[(int)(num7 + 3U)] << 24 | (int)byte_4[(int)(num7 + 2U)] << 16 | (int)byte_4[(int)(num7 + 1U)] << 8 | (int)byte_4[(int)num7]);
			}
			uint num13;
			uint num12 = num13 = num4;
			num13 = (uint)((ulong)(num13 * num13) % 2255337217UL);
			num13 = 6521U * (num13 & 524287U) - (num13 >> 19);
			uint num14 = 1500367300U ^ num13;
			uint num15 = num14 & 1431655765U;
			num14 &= 2863311530U;
			uint num16 = num14 >> 1 | num15 << 1;
			uint num17 = num13 / 1482195009U + 1482195009U;
			uint num18 = (num13 - num13 ^ num17) + num13;
			uint num19 = (679227636U ^ num13) + num13;
			num13 ^= num13 >> 15;
			num13 += num16;
			num13 ^= num13 << 5;
			num13 += num18;
			num13 ^= num13 >> 2;
			num13 += num19;
			num13 = (151267072U + num13 ^ num18) - num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num20 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num20 & num9) >> num10);
				}
			}
			else
			{
				uint num21 = num4 ^ num11;
				array[num6] = (byte)(num21 & 255U);
				array[num6 + 1] = (byte)((num21 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num21 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num21 & 4278190080U) >> 24);
			}
		}
		Class34.byte_1 = array;
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x000D1FF4 File Offset: 0x000D01F4
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class34.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				try
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return result;
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x000D2074 File Offset: 0x000D0274
	internal static void smethod_8()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class34.bool_3 = true;
			return;
		}
		try
		{
			Class34.bool_3 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x0000771B File Offset: 0x0000591B
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class34.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class34.smethod_0(byte_2);
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x000D20C0 File Offset: 0x000D02C0
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1);
			stream_0.Read(byte_2, 0, num);
			Class34.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x00007736 File Offset: 0x00005936
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x000D20FC File Offset: 0x000D02FC
	internal static uint smethod_12(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x000D2158 File Offset: 0x000D0358
	private static void smethod_13(object object_3, int int_6)
	{
		Class39.smethod_2(0, new object[]
		{
			object_3,
			int_6
		}, null);
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x000D2184 File Offset: 0x000D0384
	internal static string smethod_14(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x000D21B4 File Offset: 0x000D03B4
	internal static uint smethod_15(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_7, ref uint uint_2)
	{
		IntPtr ptr = intptr_6;
		if (Class34.bool_4)
		{
			ptr = intptr_5;
		}
		long num;
		if (IntPtr.Size == 4)
		{
			num = (long)Marshal.ReadInt32(ptr, IntPtr.Size * 2);
		}
		else
		{
			num = Marshal.ReadInt64(ptr, IntPtr.Size * 2);
		}
		object obj = Class34.hashtable_0[num];
		if (obj == null)
		{
			return Class34.delegate9_1(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
		}
		Class34.Struct13 @struct = (Class34.Struct13)obj;
		IntPtr intPtr = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
		Marshal.Copy(@struct.byte_0, 0, intPtr, @struct.byte_0.Length);
		if (@struct.MuWlxphtb0)
		{
			intptr_7 = intPtr;
			uint_2 = (uint)@struct.byte_0.Length;
			Class34.smethod_24(intptr_7, @struct.byte_0.Length, 64, ref Class34.int_0);
			return 0U;
		}
		Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
		Marshal.WriteInt32(ptr, IntPtr.Size * 3, @struct.byte_0.Length);
		uint result = 0U;
		if (uint_1 == 216669565U && !Class34.firstrundone)
		{
			Class34.firstrundone = true;
		}
		else
		{
			result = Class34.delegate9_1(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
		}
		return result;
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00007744 File Offset: 0x00005944
	private static int smethod_16()
	{
		return 5;
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x000D22D8 File Offset: 0x000D04D8
	private static void smethod_17()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x000D2300 File Offset: 0x000D0500
	private static Delegate smethod_18(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_4,
			type_0
		});
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x000D2360 File Offset: 0x000D0560
	internal unsafe static void smethod_19()
	{
		if (!Class34.bool_1)
		{
			Class34.bool_1 = true;
			long num = 0L;
			Marshal.ReadIntPtr(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt32(new IntPtr((void*)(&num)), 0);
			Marshal.ReadInt64(new IntPtr((void*)(&num)), 0);
			Marshal.WriteIntPtr(new IntPtr((void*)(&num)), 0, IntPtr.Zero);
			Marshal.WriteInt32(new IntPtr((void*)(&num)), 0, 0);
			Marshal.WriteInt64(new IntPtr((void*)(&num)), 0, 0L);
			Marshal.Copy(new byte[1], 0, Marshal.AllocCoTaskMem(8), 1);
			Class34.smethod_17();
			if (IntPtr.Size == 4 && Type.GetType("System.Reflection.ReflectionContext", false) != null)
			{
				foreach (object obj in Process.GetCurrentProcess().Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					if (processModule.ModuleName.ToLower() == "clrjit.dll")
					{
						Version v = new Version(processModule.FileVersionInfo.ProductMajorPart, processModule.FileVersionInfo.ProductMinorPart, processModule.FileVersionInfo.ProductBuildPart, processModule.FileVersionInfo.ProductPrivatePart);
						Version v2 = new Version(4, 0, 30319, 17020);
						Version v3 = new Version(4, 0, 30319, 17921);
						if (v >= v2 && v < v3)
						{
							Class34.bool_4 = true;
							break;
						}
					}
				}
			}
			Class34.Class38 @class = new Class34.Class38(Class34.tMmvmVecn.GetManifestResourceStream("JnUrkb2mNQ7NA5u63A.bqXxxinMWrTK7v4hN3"));
			@class.method_0().Position = 0L;
			byte[] array = @class.method_1((int)@class.method_0().Length);
			byte[] array2 = new byte[32];
			array2[0] = 115;
			array2[0] = 134;
			array2[0] = 135;
			array2[0] = 153;
			array2[1] = 53;
			array2[1] = 125;
			array2[1] = 237;
			array2[2] = 45;
			array2[2] = 124;
			array2[2] = 151;
			array2[2] = 76;
			array2[2] = 29;
			array2[3] = 65;
			array2[3] = 142;
			array2[3] = 47;
			array2[3] = 102;
			array2[3] = 123;
			array2[3] = 215;
			array2[4] = 95;
			array2[4] = 69;
			array2[4] = 112;
			array2[4] = 88;
			array2[4] = 133;
			array2[4] = 46;
			array2[5] = 158;
			array2[5] = 96;
			array2[5] = 165;
			array2[5] = 147;
			array2[5] = 205;
			array2[6] = 164;
			array2[6] = 137;
			array2[6] = 169;
			array2[6] = 134;
			array2[6] = 134;
			array2[6] = 46;
			array2[7] = 94;
			array2[7] = 172;
			array2[7] = 140;
			array2[7] = 215;
			array2[7] = 24;
			array2[7] = 240;
			array2[8] = 121;
			array2[8] = 153;
			array2[8] = 100;
			array2[9] = 142;
			array2[9] = 104;
			array2[9] = 166;
			array2[9] = 60;
			array2[9] = 112;
			array2[9] = 203;
			array2[10] = 152;
			array2[10] = 102;
			array2[10] = 199;
			array2[10] = 213;
			array2[11] = 207;
			array2[11] = 101;
			array2[11] = 74;
			array2[11] = 61;
			array2[12] = 144;
			array2[12] = 148;
			array2[12] = 145;
			array2[12] = 81;
			array2[12] = 49;
			array2[13] = 152;
			array2[13] = 165;
			array2[13] = 138;
			array2[13] = 86;
			array2[13] = 133;
			array2[13] = 215;
			array2[14] = 152;
			array2[14] = 64;
			array2[14] = 146;
			array2[14] = 165;
			array2[15] = 103;
			array2[15] = 144;
			array2[15] = 56;
			array2[16] = 57;
			array2[16] = 139;
			array2[16] = 155;
			array2[17] = 92;
			array2[17] = 18;
			array2[17] = 154;
			array2[17] = 209;
			array2[18] = 130;
			array2[18] = 21;
			array2[18] = 103;
			array2[18] = 107;
			array2[18] = 42;
			array2[18] = 101;
			array2[19] = 140;
			array2[19] = 146;
			array2[19] = 109;
			array2[20] = 138;
			array2[20] = 143;
			array2[20] = 153;
			array2[20] = 127;
			array2[20] = 15;
			array2[20] = 171;
			array2[21] = 141;
			array2[21] = 130;
			array2[21] = 64;
			array2[21] = 191;
			array2[22] = 126;
			array2[22] = 148;
			array2[22] = 153;
			array2[22] = 144;
			array2[22] = 35;
			array2[23] = 140;
			array2[23] = 124;
			array2[23] = 106;
			array2[23] = 161;
			array2[23] = 177;
			array2[23] = 214;
			array2[24] = 104;
			array2[24] = 114;
			array2[24] = 170;
			array2[24] = 153;
			array2[24] = 50;
			array2[24] = 150;
			array2[25] = 126;
			array2[25] = 116;
			array2[25] = 52;
			array2[25] = 76;
			array2[26] = 133;
			array2[26] = 67;
			array2[26] = 63;
			array2[26] = 164;
			array2[26] = 153;
			array2[27] = 122;
			array2[27] = 89;
			array2[27] = 105;
			array2[27] = 170;
			array2[28] = 162;
			array2[28] = 126;
			array2[28] = 236;
			array2[29] = 113;
			array2[29] = 85;
			array2[29] = 130;
			array2[29] = 87;
			array2[30] = 96;
			array2[30] = 118;
			array2[30] = 215;
			array2[30] = 166;
			array2[30] = 115;
			array2[31] = 131;
			array2[31] = 141;
			array2[31] = 132;
			array2[31] = 187;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 98;
			array4[0] = 160;
			array4[0] = 103;
			array4[1] = 163;
			array4[1] = 155;
			array4[1] = 112;
			array4[1] = 17;
			array4[2] = 134;
			array4[2] = 163;
			array4[2] = 226;
			array4[3] = 91;
			array4[3] = 226;
			array4[3] = 124;
			array4[3] = 97;
			array4[3] = 154;
			array4[3] = 115;
			array4[4] = 53;
			array4[4] = 170;
			array4[4] = 228;
			array4[5] = 87;
			array4[5] = 132;
			array4[5] = 185;
			array4[5] = 84;
			array4[5] = 162;
			array4[5] = 102;
			array4[6] = 138;
			array4[6] = 90;
			array4[6] = 145;
			array4[6] = 77;
			array4[6] = 86;
			array4[6] = 70;
			array4[7] = 84;
			array4[7] = 115;
			array4[7] = 167;
			array4[7] = 113;
			array4[7] = 100;
			array4[7] = 152;
			array4[8] = 102;
			array4[8] = 111;
			array4[8] = 167;
			array4[8] = 126;
			array4[8] = 118;
			array4[8] = 10;
			array4[9] = 92;
			array4[9] = 141;
			array4[9] = 144;
			array4[9] = 221;
			array4[9] = 136;
			array4[9] = 207;
			array4[10] = 115;
			array4[10] = 140;
			array4[10] = 175;
			array4[10] = 67;
			array4[11] = 169;
			array4[11] = 50;
			array4[11] = 141;
			array4[11] = 140;
			array4[11] = 175;
			array4[12] = 115;
			array4[12] = 182;
			array4[12] = 164;
			array4[12] = 152;
			array4[13] = 39;
			array4[13] = 124;
			array4[13] = 109;
			array4[14] = 94;
			array4[14] = 177;
			array4[14] = 116;
			array4[14] = 70;
			array4[15] = 143;
			array4[15] = 138;
			array4[15] = 96;
			array4[15] = 221;
			byte[] array5 = array4;
			Array.Reverse(array5);
			byte[] publicKeyToken = Class34.tMmvmVecn.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
				Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] ^= array5[i];
			}
			byte[] array6 = array;
			int num2 = array6.Length % 4;
			int num3 = array6.Length / 4;
			byte[] array7 = new byte[array6.Length];
			int num4 = array3.Length / 4;
			uint num5 = 0U;
			if (num2 > 0)
			{
				num3++;
			}
			for (int j = 0; j < num3; j++)
			{
				int num6 = j % num4;
				int num7 = j * 4;
				uint num8 = (uint)(num6 * 4);
				uint num9 = (uint)((int)array3[(int)(num8 + 3U)] << 24 | (int)array3[(int)(num8 + 2U)] << 16 | (int)array3[(int)(num8 + 1U)] << 8 | (int)array3[(int)num8]);
				uint num10 = 255U;
				int num11 = 0;
				uint num12;
				if (j == num3 - 1 && num2 > 0)
				{
					num5 += num9;
					num12 = 0U;
					for (int k = 0; k < num2; k++)
					{
						if (k > 0)
						{
							num12 <<= 8;
						}
						num12 |= (uint)array6[array6.Length - (1 + k)];
					}
				}
				else
				{
					num8 = (uint)num7;
					num5 += num9;
					num12 = (uint)((int)array6[(int)(num8 + 3U)] << 24 | (int)array6[(int)(num8 + 2U)] << 16 | (int)array6[(int)(num8 + 1U)] << 8 | (int)array6[(int)num8]);
				}
				num5 = num5;
				uint num13 = num5;
				uint num14 = num5;
				num14 = (uint)((ulong)(num14 * num14) % 2255337217UL);
				num14 = 6521U * (num14 & 524287U) - (num14 >> 19);
				uint num15 = 1500367300U ^ num14;
				uint num16 = num15 & 1431655765U;
				num15 &= 2863311530U;
				uint num17 = num15 >> 1 | num16 << 1;
				uint num18 = num14 / 1482195009U + 1482195009U;
				uint num19 = (num14 - num14 ^ num18) + num14;
				uint num20 = (679227636U ^ num14) + num14;
				num14 ^= num14 >> 15;
				num14 += num17;
				num14 ^= num14 << 5;
				num14 += num19;
				num14 ^= num14 >> 2;
				num14 += num20;
				num14 = (151267072U + num14 ^ num19) - num14;
				num5 = num13 + (uint)num14;
				if (j == num3 - 1 && num2 > 0)
				{
					uint num21 = num5 ^ num12;
					for (int l = 0; l < num2; l++)
					{
						if (l > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array7[num7 + l] = (byte)((num21 & num10) >> num11);
					}
				}
				else
				{
					uint num22 = num5 ^ num12;
					array7[num7] = (byte)(num22 & 255U);
					array7[num7 + 1] = (byte)((num22 & 65280U) >> 8);
					array7[num7 + 2] = (byte)((num22 & 16711680U) >> 16);
					array7[num7 + 3] = (byte)((num22 & 4278190080U) >> 24);
				}
			}
			byte[] array8 = array7;
			int num23 = array8.Length / 8;
			byte[] array9;
			byte* ptr;
			if ((array9 = array8) != null && array9.Length != 0)
			{
				ptr = &array9[0];
			}
			else
			{
				ptr = null;
			}
			for (int m = 0; m < num23; m++)
			{
				*(long*)(ptr + m * 8) ^= 181362631L;
			}
			array9 = null;
			@class = new Class34.Class38(new MemoryStream(array8));
			@class.method_0().Position = 0L;
			long num24 = Marshal.GetHINSTANCE(Class34.tMmvmVecn.GetModules()[0]).ToInt64();
			int int_ = 0;
			int num25 = 0;
			if (Class34.tMmvmVecn.Location == null || Class34.tMmvmVecn.Location.Length == 0)
			{
				num25 = 7680;
			}
			@class.method_3();
			@class.method_3();
			@class.method_3();
			int num26 = @class.method_3();
			int num27 = @class.method_3();
			if (num27 == 4)
			{
				SymmetricAlgorithm symmetricAlgorithm = Class34.smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				Array.Clear(array3, 0, array3.Length);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				Array.Clear(array5, 0, array5.Length);
				memoryStream.Close();
				cryptoStream.Close();
				@class.method_4();
				num26 = @class.method_3();
				num27 = @class.method_3();
			}
			if (num27 == 1)
			{
				IntPtr intptr_ = IntPtr.Zero;
				intptr_ = Class34.smethod_25(56U, 1, (uint)Process.GetCurrentProcess().Id);
				if (IntPtr.Size == 4)
				{
					Class34.int_2 = Marshal.GetHINSTANCE(Class34.tMmvmVecn.GetModules()[0]).ToInt32();
				}
				Class34.long_0 = Marshal.GetHINSTANCE(Class34.tMmvmVecn.GetModules()[0]).ToInt64();
				IntPtr zero = IntPtr.Zero;
				for (int n = 0; n < num26; n++)
				{
					IntPtr intPtr = new IntPtr(Class34.long_0 + (long)@class.method_3() - (long)num25);
					if (Class34.smethod_24(intPtr, 4, 4, ref int_) == 0)
					{
						Class34.smethod_24(intPtr, 4, 8, ref int_);
					}
					if (IntPtr.Size == 4)
					{
						Class34.smethod_23(intptr_, intPtr, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					else
					{
						Class34.smethod_23(intptr_, intPtr, BitConverter.GetBytes(@class.method_3()), 4U, out zero);
					}
					Class34.smethod_24(intPtr, 4, int_, ref int_);
				}
				while (@class.method_0().Position < @class.method_0().Length - 1L)
				{
					int num28 = @class.method_3();
					IntPtr intptr_2 = new IntPtr(Class34.long_0 + (long)num28 - (long)num25);
					int num29 = @class.method_3();
					if (Class34.smethod_24(intptr_2, num29 * 4, 4, ref int_) == 0)
					{
						Class34.smethod_24(intptr_2, num29 * 4, 8, ref int_);
					}
					for (int num30 = 0; num30 < num29; num30++)
					{
						Marshal.WriteInt32(new IntPtr(intptr_2.ToInt64() + (long)(num30 * 4)), @class.method_3());
					}
					Class34.smethod_24(intptr_2, num29 * 4, int_, ref int_);
				}
				Class34.smethod_26(intptr_);
				return;
			}
			for (int num31 = 0; num31 < num26; num31++)
			{
				IntPtr intPtr2 = new IntPtr(num24 + (long)@class.method_3() - (long)num25);
				if (Class34.smethod_24(intPtr2, 4, 4, ref int_) == 0)
				{
					Class34.smethod_24(intPtr2, 4, 8, ref int_);
				}
				Marshal.WriteInt32(intPtr2, @class.method_3());
				Class34.smethod_24(intPtr2, 4, int_, ref int_);
			}
			Class34.hashtable_0 = new Hashtable(@class.method_3() + 1);
			Class34.Struct13 @struct = default(Class34.Struct13);
			@struct.byte_0 = new byte[]
			{
				42
			};
			@struct.MuWlxphtb0 = false;
			Class34.hashtable_0.Add(0L, @struct);
			while (@class.method_0().Position < @class.method_0().Length - 1L)
			{
				int num32 = @class.method_3() - num25;
				int num33 = @class.method_3();
				bool muWlxphtb = false;
				if (num33 >= 1879048192)
				{
					muWlxphtb = true;
				}
				int num34 = @class.method_3();
				byte[] array10 = @class.method_1(num34);
				Class34.Struct13 struct2 = default(Class34.Struct13);
				struct2.byte_0 = array10;
				struct2.MuWlxphtb0 = muWlxphtb;
				Class34.hashtable_0.Add(num24 + (long)num32, struct2);
			}
			Class34.long_1 = Marshal.GetHINSTANCE(typeof(Class34).Assembly.GetModules()[0]).ToInt64();
			if (IntPtr.Size == 4)
			{
				Class34.int_3 = Convert.ToInt32(Class34.long_1);
			}
			byte[] bytes = new byte[]
			{
				109,
				115,
				99,
				111,
				114,
				106,
				105,
				116,
				46,
				100,
				108,
				108
			};
			string @string = Encoding.UTF8.GetString(bytes);
			IntPtr intPtr3 = IntPtr.Zero;
			if (intPtr3 == IntPtr.Zero)
			{
				bytes = new byte[]
				{
					99,
					108,
					114,
					106,
					105,
					116,
					46,
					100,
					108,
					108
				};
				@string = Encoding.UTF8.GetString(bytes);
				intPtr3 = Class34.LoadLibrary(@string);
			}
			byte[] bytes2 = new byte[]
			{
				103,
				101,
				116,
				74,
				105,
				116
			};
			string string2 = Encoding.UTF8.GetString(bytes2);
			IntPtr ptr2 = ((Class34.Delegate10)Class34.smethod_18(Class34.GetProcAddress(intPtr3, string2), typeof(Class34.Delegate10)))();
			long value = 0L;
			if (IntPtr.Size == 4)
			{
				value = (long)Marshal.ReadInt32(ptr2);
			}
			else
			{
				value = Marshal.ReadInt64(ptr2);
			}
			Marshal.ReadIntPtr(ptr2, 0);
			Class34.delegate9_0 = new Class34.Delegate9(Class34.smethod_15);
			IntPtr intPtr4 = IntPtr.Zero;
			intPtr4 = Marshal.GetFunctionPointerForDelegate(Class34.delegate9_0);
			long num35 = 0L;
			if (IntPtr.Size == 4)
			{
				num35 = (long)Marshal.ReadInt32(new IntPtr(value));
			}
			else
			{
				num35 = Marshal.ReadInt64(new IntPtr(value));
			}
			Process currentProcess = Process.GetCurrentProcess();
			try
			{
				foreach (object obj2 in currentProcess.Modules)
				{
					ProcessModule processModule2 = (ProcessModule)obj2;
					if (processModule2.ModuleName == @string && (num35 < processModule2.BaseAddress.ToInt64() || num35 > processModule2.BaseAddress.ToInt64() + (long)processModule2.ModuleMemorySize) && typeof(Class34).Assembly.EntryPoint != null)
					{
						return;
					}
				}
			}
			catch
			{
			}
			try
			{
				using (IEnumerator enumerator = currentProcess.Modules.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((ProcessModule)enumerator.Current).BaseAddress.ToInt64() == Class34.long_1)
						{
							break;
						}
					}
				}
			}
			catch
			{
			}
			Class34.delegate9_1 = null;
			try
			{
				Class34.delegate9_1 = (Class34.Delegate9)Class34.smethod_18(new IntPtr(num35), typeof(Class34.Delegate9));
			}
			catch
			{
				try
				{
					Delegate @delegate = Class34.smethod_18(new IntPtr(num35), typeof(Class34.Delegate9));
					Class34.delegate9_1 = (Class34.Delegate9)Delegate.CreateDelegate(typeof(Class34.Delegate9), @delegate.Method);
				}
				catch
				{
				}
			}
			int int_2 = 0;
			if (typeof(Class34).Assembly.EntryPoint != null && typeof(Class34).Assembly.EntryPoint.GetParameters().Length == 2 && typeof(Class34).Assembly.Location != null && typeof(Class34).Assembly.Location.Length > 0)
			{
				return;
			}
			try
			{
				object value2 = typeof(Class34).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(typeof(Class34).Assembly.ManifestModule.ModuleHandle);
				if (value2 is IntPtr)
				{
					Class34.intptr_1 = (IntPtr)value2;
				}
				if (value2.GetType().ToString() == "System.Reflection.RuntimeModule")
				{
					Class34.intptr_1 = (IntPtr)value2.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(value2);
				}
				MemoryStream memoryStream2 = new MemoryStream();
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				if (IntPtr.Size == 4)
				{
					memoryStream2.Write(BitConverter.GetBytes(Class34.intptr_1.ToInt32()), 0, 4);
				}
				else
				{
					memoryStream2.Write(BitConverter.GetBytes(Class34.intptr_1.ToInt64()), 0, 8);
				}
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
				memoryStream2.Position = 0L;
				byte[] array11 = memoryStream2.ToArray();
				memoryStream2.Close();
				uint num36 = 0U;
				try
				{
					byte* value3;
					if ((array9 = array11) != null && array9.Length != 0)
					{
						value3 = &array9[0];
					}
					else
					{
						value3 = null;
					}
					Class34.delegate9_0(new IntPtr((void*)value3), new IntPtr((void*)value3), new IntPtr((void*)value3), 216669565U, new IntPtr((void*)value3), ref num36);
				}
				finally
				{
					array9 = null;
				}
			}
			catch
			{
			}
			RuntimeHelpers.PrepareDelegate(Class34.delegate9_1);
			RuntimeHelpers.PrepareMethod(Class34.delegate9_1.Method.MethodHandle);
			RuntimeHelpers.PrepareDelegate(Class34.delegate9_0);
			RuntimeHelpers.PrepareMethod(Class34.delegate9_0.Method.MethodHandle);
			byte[] array12;
			if (IntPtr.Size != 4)
			{
				array12 = new byte[]
				{
					72,
					184,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					73,
					57,
					64,
					8,
					116,
					12,
					72,
					184,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					byte.MaxValue,
					224,
					72,
					184,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					0,
					byte.MaxValue,
					224
				};
			}
			else
			{
				array12 = new byte[]
				{
					85,
					139,
					236,
					139,
					69,
					16,
					129,
					120,
					4,
					125,
					29,
					234,
					12,
					116,
					7,
					184,
					182,
					177,
					74,
					6,
					235,
					5,
					184,
					182,
					146,
					64,
					12,
					93,
					byte.MaxValue,
					224
				};
			}
			IntPtr intPtr5 = Class34.smethod_22(IntPtr.Zero, (uint)array12.Length, 4096U, 64U);
			byte[] array13 = array12;
			byte[] bytes3;
			byte[] bytes4;
			byte[] bytes5;
			if (IntPtr.Size == 4)
			{
				bytes3 = BitConverter.GetBytes(Class34.intptr_1.ToInt32());
				bytes4 = BitConverter.GetBytes(intPtr4.ToInt32());
				bytes5 = BitConverter.GetBytes(Convert.ToInt32(num35));
			}
			else
			{
				bytes3 = BitConverter.GetBytes(Class34.intptr_1.ToInt64());
				bytes4 = BitConverter.GetBytes(intPtr4.ToInt64());
				bytes5 = BitConverter.GetBytes(num35);
			}
			if (IntPtr.Size == 4)
			{
				array13[9] = bytes3[0];
				array13[10] = bytes3[1];
				array13[11] = bytes3[2];
				array13[12] = bytes3[3];
				array13[16] = bytes5[0];
				array13[17] = bytes5[1];
				array13[18] = bytes5[2];
				array13[19] = bytes5[3];
				array13[23] = bytes4[0];
				array13[24] = bytes4[1];
				array13[25] = bytes4[2];
				array13[26] = bytes4[3];
			}
			else
			{
				array13[2] = bytes3[0];
				array13[3] = bytes3[1];
				array13[4] = bytes3[2];
				array13[5] = bytes3[3];
				array13[6] = bytes3[4];
				array13[7] = bytes3[5];
				array13[8] = bytes3[6];
				array13[9] = bytes3[7];
				array13[18] = bytes5[0];
				array13[19] = bytes5[1];
				array13[20] = bytes5[2];
				array13[21] = bytes5[3];
				array13[22] = bytes5[4];
				array13[23] = bytes5[5];
				array13[24] = bytes5[6];
				array13[25] = bytes5[7];
				array13[30] = bytes4[0];
				array13[31] = bytes4[1];
				array13[32] = bytes4[2];
				array13[33] = bytes4[3];
				array13[34] = bytes4[4];
				array13[35] = bytes4[5];
				array13[36] = bytes4[6];
				array13[37] = bytes4[7];
			}
			Marshal.Copy(array13, 0, intPtr5, array13.Length);
			Class34.bool_2 = false;
			Class34.smethod_24(new IntPtr(value), IntPtr.Size, 64, ref int_2);
			Marshal.WriteIntPtr(new IntPtr(value), intPtr5);
			Class34.smethod_24(new IntPtr(value), IntPtr.Size, int_2, ref int_2);
		}
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x000D3CBC File Offset: 0x000D1EBC
	internal static object smethod_20(Assembly assembly_0)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_0).Location))
			{
				return ((Assembly)assembly_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString()))
			{
				return assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06001380 RID: 4992
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x06001381 RID: 4993
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x06001382 RID: 4994 RVA: 0x000D3DCC File Offset: 0x000D1FCC
	private static IntPtr smethod_21(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class34.delegate11_0 == null)
		{
			Class34.delegate11_0 = (Class34.Delegate11)Marshal.GetDelegateForFunctionPointer(Class34.GetProcAddress(Class34.smethod_27(), "Find ".Trim() + "ResourceA"), typeof(Class34.Delegate11));
		}
		return Class34.delegate11_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x000D3E24 File Offset: 0x000D2024
	private static IntPtr smethod_22(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class34.delegate12_0 == null)
		{
			Class34.delegate12_0 = (Class34.Delegate12)Marshal.GetDelegateForFunctionPointer(Class34.GetProcAddress(Class34.smethod_27(), "Virtual ".Trim() + "Alloc"), typeof(Class34.Delegate12));
		}
		return Class34.delegate12_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x000D3E80 File Offset: 0x000D2080
	private static int smethod_23(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class34.delegate13_0 == null)
		{
			Class34.delegate13_0 = (Class34.Delegate13)Marshal.GetDelegateForFunctionPointer(Class34.GetProcAddress(Class34.smethod_27(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class34.Delegate13));
		}
		return Class34.delegate13_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x000D3EE8 File Offset: 0x000D20E8
	private static int smethod_24(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class34.delegate14_0 == null)
		{
			Class34.delegate14_0 = (Class34.Delegate14)Marshal.GetDelegateForFunctionPointer(Class34.GetProcAddress(Class34.smethod_27(), "Virtual ".Trim() + "Protect"), typeof(Class34.Delegate14));
		}
		return Class34.delegate14_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x000D3F44 File Offset: 0x000D2144
	private static IntPtr smethod_25(uint uint_1, int int_6, uint uint_2)
	{
		if (Class34.delegate15_0 == null)
		{
			Class34.delegate15_0 = (Class34.Delegate15)Marshal.GetDelegateForFunctionPointer(Class34.GetProcAddress(Class34.smethod_27(), "Open ".Trim() + "Process"), typeof(Class34.Delegate15));
		}
		return Class34.delegate15_0(uint_1, int_6, uint_2);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x000D3F9C File Offset: 0x000D219C
	private static int smethod_26(IntPtr intptr_4)
	{
		if (Class34.delegate16_0 == null)
		{
			Class34.delegate16_0 = (Class34.Delegate16)Marshal.GetDelegateForFunctionPointer(Class34.GetProcAddress(Class34.smethod_27(), "Close ".Trim() + "Handle"), typeof(Class34.Delegate16));
		}
		return Class34.delegate16_0(intptr_4);
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00007747 File Offset: 0x00005947
	private static IntPtr smethod_27()
	{
		if (Class34.intptr_2 == IntPtr.Zero)
		{
			Class34.intptr_2 = Class34.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class34.intptr_2;
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x000D3FF4 File Offset: 0x000D21F4
	private static byte[] smethod_28(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x0000777D File Offset: 0x0000597D
	internal static byte[] smethod_29(MemoryStream memoryStream_0)
	{
		return ((MemoryStream)memoryStream_0).ToArray();
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x000D4054 File Offset: 0x000D2254
	private static byte[] smethod_30(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class34.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			192,
			40,
			81,
			122,
			39,
			141,
			16,
			147,
			155,
			219,
			17,
			1,
			81,
			24,
			115,
			91,
			19,
			87,
			80,
			114,
			249,
			234,
			78,
			253,
			31,
			178,
			194,
			74,
			88,
			83,
			122,
			116
		};
		symmetricAlgorithm.IV = new byte[]
		{
			58,
			253,
			59,
			81,
			11,
			226,
			127,
			33,
			118,
			51,
			35,
			235,
			51,
			145,
			129,
			22
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class34.smethod_29(stream);
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x000D40C0 File Offset: 0x000D22C0
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x000D40D0 File Offset: 0x000D22D0
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x000D40C0 File Offset: 0x000D22C0
	private byte[] method_4()
	{
		return null;
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x000D40C0 File Offset: 0x000D22C0
	private byte[] method_5()
	{
		return null;
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x000D40C0 File Offset: 0x000D22C0
	private byte[] method_6()
	{
		return null;
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x000D40C0 File Offset: 0x000D22C0
	private byte[] method_7()
	{
		return null;
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x0000778A File Offset: 0x0000598A
	internal byte[] method_8()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x000077A5 File Offset: 0x000059A5
	internal byte[] method_9()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x000D40C0 File Offset: 0x000D22C0
	internal byte[] method_10()
	{
		return null;
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x000D40C0 File Offset: 0x000D22C0
	internal byte[] method_11()
	{
		return null;
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x000077C0 File Offset: 0x000059C0
	internal static object smethod_31(Class34.Class38 class38_0)
	{
		return class38_0.method_0();
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x000077C8 File Offset: 0x000059C8
	internal static void smethod_32(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x000077D1 File Offset: 0x000059D1
	internal static long smethod_33(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x000077D9 File Offset: 0x000059D9
	internal static object smethod_34(Class34.Class38 class38_0, int int_6)
	{
		return class38_0.method_1(int_6);
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x000077E2 File Offset: 0x000059E2
	internal static void smethod_35(Class34.Class38 class38_0)
	{
		class38_0.method_4();
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x000077EA File Offset: 0x000059EA
	internal static void smethod_36(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x000077F2 File Offset: 0x000059F2
	internal static object smethod_37(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x000077FA File Offset: 0x000059FA
	internal static object smethod_38(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x00007802 File Offset: 0x00005A02
	internal static object smethod_39()
	{
		return Class34.smethod_7();
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00007809 File Offset: 0x00005A09
	internal static void smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x00007812 File Offset: 0x00005A12
	internal static object smethod_41(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0000781C File Offset: 0x00005A1C
	internal static object smethod_42()
	{
		return new MemoryStream();
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x00007823 File Offset: 0x00005A23
	internal static void smethod_43(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x0000782E File Offset: 0x00005A2E
	internal static void smethod_44(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x00007836 File Offset: 0x00005A36
	internal static object smethod_45(MemoryStream memoryStream_0)
	{
		return Class34.smethod_29(memoryStream_0);
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x0000783E File Offset: 0x00005A3E
	internal static void smethod_46(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x00007846 File Offset: 0x00005A46
	internal static object smethod_47(Assembly assembly_0)
	{
		return assembly_0.EntryPoint;
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x0000784E File Offset: 0x00005A4E
	internal static bool smethod_48(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 == methodInfo_1;
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x00007857 File Offset: 0x00005A57
	internal static bool smethod_49()
	{
		return null == null;
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x0000785D File Offset: 0x00005A5D
	internal static object smethod_50()
	{
		return null;
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x00007857 File Offset: 0x00005A57
	internal static bool smethod_51()
	{
		return null == null;
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x0000785D File Offset: 0x00005A5D
	internal static object smethod_52()
	{
		return null;
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x0000237A File Offset: 0x0000057A
	static int smethod_53()
	{
		return 1;
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x00007860 File Offset: 0x00005A60
	internal static IntPtr smethod_54(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadIntPtr(intptr_4, int_6);
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00007869 File Offset: 0x00005A69
	internal static int smethod_55(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt32(intptr_4, int_6);
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00007872 File Offset: 0x00005A72
	internal static long smethod_56(IntPtr intptr_4, int int_6)
	{
		return Marshal.ReadInt64(intptr_4, int_6);
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x0000787B File Offset: 0x00005A7B
	internal static void smethod_57(IntPtr intptr_4, int int_6, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, int_6, intptr_5);
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x00007885 File Offset: 0x00005A85
	internal static void smethod_58(IntPtr intptr_4, int int_6, int int_7)
	{
		Marshal.WriteInt32(intptr_4, int_6, int_7);
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x0000788F File Offset: 0x00005A8F
	internal static void smethod_59(IntPtr intptr_4, int int_6, long long_2)
	{
		Marshal.WriteInt64(intptr_4, int_6, long_2);
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x00007899 File Offset: 0x00005A99
	internal static IntPtr smethod_60(int int_6)
	{
		return Marshal.AllocCoTaskMem(int_6);
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x000078A1 File Offset: 0x00005AA1
	internal static void smethod_61(byte[] byte_2, int int_6, IntPtr intptr_4, int int_7)
	{
		Marshal.Copy(byte_2, int_6, intptr_4, int_7);
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x000078AC File Offset: 0x00005AAC
	internal static void smethod_62()
	{
		Class34.smethod_17();
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x000078B3 File Offset: 0x00005AB3
	internal static object smethod_63()
	{
		return Process.GetCurrentProcess();
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x000078BA File Offset: 0x00005ABA
	internal static object smethod_64(Process process_0)
	{
		return process_0.MainModule;
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x000078C2 File Offset: 0x00005AC2
	internal static IntPtr smethod_65(ProcessModule processModule_0)
	{
		return processModule_0.BaseAddress;
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x000078CA File Offset: 0x00005ACA
	internal static IntPtr smethod_66(IntPtr intptr_4, string string_1, uint uint_1)
	{
		return Class34.smethod_21(intptr_4, string_1, uint_1);
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x000078D4 File Offset: 0x00005AD4
	internal static bool smethod_67(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 != intptr_5;
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x000078DD File Offset: 0x00005ADD
	internal static int smethod_69()
	{
		return IntPtr.Size;
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x000078E4 File Offset: 0x00005AE4
	internal static Type smethod_70(string string_1, bool bool_5)
	{
		return Type.GetType(string_1, bool_5);
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x000078ED File Offset: 0x00005AED
	internal static bool smethod_71(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x000078F6 File Offset: 0x00005AF6
	internal static object smethod_72(Process process_0)
	{
		return process_0.Modules;
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x000078FE File Offset: 0x00005AFE
	internal static object smethod_73(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00007906 File Offset: 0x00005B06
	internal static object smethod_74(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0000790E File Offset: 0x00005B0E
	internal static object smethod_75(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00007916 File Offset: 0x00005B16
	internal static object smethod_76(string string_1)
	{
		return string_1.ToLower();
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x0000791E File Offset: 0x00005B1E
	internal static bool smethod_77(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00007927 File Offset: 0x00005B27
	internal static object smethod_78(ProcessModule processModule_0)
	{
		return processModule_0.FileVersionInfo;
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x0000792F File Offset: 0x00005B2F
	internal static int smethod_79(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMajorPart;
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00007937 File Offset: 0x00005B37
	internal static int smethod_80(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductMinorPart;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x0000793F File Offset: 0x00005B3F
	internal static int smethod_81(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductBuildPart;
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x00007947 File Offset: 0x00005B47
	internal static int smethod_82(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.ProductPrivatePart;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x0000794F File Offset: 0x00005B4F
	internal static bool smethod_83(Version version_0, Version version_1)
	{
		return version_0 >= version_1;
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00007958 File Offset: 0x00005B58
	internal static bool smethod_84(Version version_0, Version version_1)
	{
		return version_0 < version_1;
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x00007961 File Offset: 0x00005B61
	internal static bool smethod_85(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x00007969 File Offset: 0x00005B69
	internal static void smethod_86(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00007971 File Offset: 0x00005B71
	internal static object smethod_87(Assembly assembly_0, string string_1)
	{
		return assembly_0.GetManifestResourceStream(string_1);
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x000077C0 File Offset: 0x000059C0
	internal static object smethod_88(Class34.Class38 class38_0)
	{
		return class38_0.method_0();
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x000077C8 File Offset: 0x000059C8
	internal static void smethod_89(Stream stream_0, long long_2)
	{
		stream_0.Position = long_2;
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x000077D1 File Offset: 0x000059D1
	internal static long smethod_90(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x000077D9 File Offset: 0x000059D9
	internal static object smethod_91(Class34.Class38 class38_0, int int_6)
	{
		return class38_0.method_1(int_6);
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x000077EA File Offset: 0x000059EA
	internal static void smethod_92(Array array_0)
	{
		Array.Reverse(array_0);
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x000077F2 File Offset: 0x000059F2
	internal static object smethod_93(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x000077FA File Offset: 0x000059FA
	internal static object smethod_94(AssemblyName assemblyName_0)
	{
		return assemblyName_0.GetPublicKeyToken();
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x0000797A File Offset: 0x00005B7A
	internal static void smethod_95(Array array_0, int int_6, int int_7)
	{
		Array.Clear(array_0, int_6, int_7);
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00007984 File Offset: 0x00005B84
	internal static object smethod_96(Assembly assembly_0)
	{
		return assembly_0.GetModules();
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x0000798C File Offset: 0x00005B8C
	internal static IntPtr smethod_97(Module module_0)
	{
		return Marshal.GetHINSTANCE(module_0);
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x00007994 File Offset: 0x00005B94
	internal static object smethod_98(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x0000799C File Offset: 0x00005B9C
	internal static int smethod_99(string string_1)
	{
		return string_1.Length;
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x000079A4 File Offset: 0x00005BA4
	internal static int smethod_100(Class34.Class38 class38_0)
	{
		return class38_0.method_3();
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00007802 File Offset: 0x00005A02
	internal static object smethod_101()
	{
		return Class34.smethod_7();
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x00007809 File Offset: 0x00005A09
	internal static void smethod_102(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00007812 File Offset: 0x00005A12
	internal static object smethod_103(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_2, byte[] byte_3)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00007823 File Offset: 0x00005A23
	internal static void smethod_104(Stream stream_0, byte[] byte_2, int int_6, int int_7)
	{
		stream_0.Write(byte_2, int_6, int_7);
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0000782E File Offset: 0x00005A2E
	internal static void smethod_105(CryptoStream cryptoStream_0)
	{
		cryptoStream_0.FlushFinalBlock();
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x000079AC File Offset: 0x00005BAC
	internal static object smethod_106(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x0000783E File Offset: 0x00005A3E
	internal static void smethod_107(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x000077E2 File Offset: 0x000059E2
	internal static void smethod_108(Class34.Class38 class38_0)
	{
		class38_0.method_4();
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x000079B4 File Offset: 0x00005BB4
	internal static int smethod_109(Process process_0)
	{
		return process_0.Id;
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x000079BC File Offset: 0x00005BBC
	internal static IntPtr smethod_110(uint uint_1, int int_6, uint uint_2)
	{
		return Class34.smethod_25(uint_1, int_6, uint_2);
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x000079C6 File Offset: 0x00005BC6
	internal static object smethod_111(int int_6)
	{
		return BitConverter.GetBytes(int_6);
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x000079CE File Offset: 0x00005BCE
	internal static long smethod_112(Stream stream_0)
	{
		return stream_0.Position;
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x000079D6 File Offset: 0x00005BD6
	internal static void smethod_113(IntPtr intptr_4, int int_6)
	{
		Marshal.WriteInt32(intptr_4, int_6);
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x000079DF File Offset: 0x00005BDF
	internal static int smethod_114(IntPtr intptr_4)
	{
		return Class34.smethod_26(intptr_4);
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x000079E7 File Offset: 0x00005BE7
	internal static void smethod_115(Hashtable hashtable_1, object object_3, object object_4)
	{
		hashtable_1.Add(object_3, object_4);
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x000079F1 File Offset: 0x00005BF1
	internal static Type smethod_116(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x000079F9 File Offset: 0x00005BF9
	internal static int smethod_117(long long_2)
	{
		return Convert.ToInt32(long_2);
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00007A01 File Offset: 0x00005C01
	internal static object smethod_118()
	{
		return Encoding.UTF8;
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00007A08 File Offset: 0x00005C08
	internal static object smethod_119(Encoding encoding_0, byte[] byte_2)
	{
		return encoding_0.GetString(byte_2);
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00007A11 File Offset: 0x00005C11
	internal static bool smethod_120(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 == intptr_5;
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00007A1A File Offset: 0x00005C1A
	internal static object smethod_121(IntPtr intptr_4, Type type_0)
	{
		return Class34.smethod_18(intptr_4, type_0);
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00007A23 File Offset: 0x00005C23
	internal static IntPtr smethod_122(Class34.Delegate10 delegate10_0)
	{
		return delegate10_0();
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00007A2B File Offset: 0x00005C2B
	internal static int smethod_123(IntPtr intptr_4)
	{
		return Marshal.ReadInt32(intptr_4);
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00007A33 File Offset: 0x00005C33
	internal static long smethod_124(IntPtr intptr_4)
	{
		return Marshal.ReadInt64(intptr_4);
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x00007A3B File Offset: 0x00005C3B
	internal static IntPtr smethod_125(Delegate delegate_0)
	{
		return Marshal.GetFunctionPointerForDelegate(delegate_0);
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00007A43 File Offset: 0x00005C43
	internal static int smethod_126(ProcessModule processModule_0)
	{
		return processModule_0.ModuleMemorySize;
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00007846 File Offset: 0x00005A46
	internal static object smethod_127(Assembly assembly_0)
	{
		return assembly_0.EntryPoint;
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00007A4B File Offset: 0x00005C4B
	internal static bool smethod_128(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return methodInfo_0 != methodInfo_1;
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00007A54 File Offset: 0x00005C54
	internal static object smethod_129(Delegate delegate_0)
	{
		return delegate_0.Method;
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x00007A5C File Offset: 0x00005C5C
	internal static object smethod_130(Type type_0, MethodInfo methodInfo_0)
	{
		return Delegate.CreateDelegate(type_0, methodInfo_0);
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00007A65 File Offset: 0x00005C65
	internal static object smethod_131(MethodBase methodBase_0)
	{
		return methodBase_0.GetParameters();
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x00007A6D File Offset: 0x00005C6D
	internal static object smethod_132(Assembly assembly_0)
	{
		return assembly_0.ManifestModule;
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00007A75 File Offset: 0x00005C75
	internal static ModuleHandle smethod_133(Module module_0)
	{
		return module_0.ModuleHandle;
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x00007A7D File Offset: 0x00005C7D
	internal static Type smethod_134(object object_3)
	{
		return object_3.GetType();
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x00007A85 File Offset: 0x00005C85
	internal static object smethod_135(FieldInfo fieldInfo_0, object object_3)
	{
		return fieldInfo_0.GetValue(object_3);
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x00007A8E File Offset: 0x00005C8E
	internal static object smethod_136(long long_2)
	{
		return BitConverter.GetBytes(long_2);
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00007A96 File Offset: 0x00005C96
	internal static void smethod_137(Delegate delegate_0)
	{
		RuntimeHelpers.PrepareDelegate(delegate_0);
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x00007A9E File Offset: 0x00005C9E
	internal static RuntimeMethodHandle smethod_138(MethodBase methodBase_0)
	{
		return methodBase_0.MethodHandle;
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x00007AA6 File Offset: 0x00005CA6
	internal static void smethod_139(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x00007AAE File Offset: 0x00005CAE
	internal static void smethod_140(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00007AB7 File Offset: 0x00005CB7
	internal static IntPtr smethod_141(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		return Class34.smethod_22(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x00007AC2 File Offset: 0x00005CC2
	internal static void smethod_142(IntPtr intptr_4, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, intptr_5);
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00007857 File Offset: 0x00005A57
	internal static bool smethod_143()
	{
		return null == null;
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x0000785D File Offset: 0x00005A5D
	internal static object smethod_144()
	{
		return null;
	}

	// Token: 0x04000D12 RID: 3346
	private static int int_0;

	// Token: 0x04000D13 RID: 3347
	private static int int_1;

	// Token: 0x04000D14 RID: 3348
	private static Class34.Delegate13 delegate13_0;

	// Token: 0x04000D15 RID: 3349
	private static long long_0;

	// Token: 0x04000D16 RID: 3350
	private static int int_2;

	// Token: 0x04000D17 RID: 3351
	private static bool bool_0;

	// Token: 0x04000D18 RID: 3352
	private static IntPtr intptr_0;

	// Token: 0x04000D19 RID: 3353
	private static Class34.Delegate16 delegate16_0;

	// Token: 0x04000D1A RID: 3354
	private static IntPtr intptr_1;

	// Token: 0x04000D1B RID: 3355
	internal static Class34.Delegate9 delegate9_0;

	// Token: 0x04000D1C RID: 3356
	internal static object object_0;

	// Token: 0x04000D1D RID: 3357
	private static object object_1;

	// Token: 0x04000D1E RID: 3358
	internal static Assembly tMmvmVecn;

	// Token: 0x04000D1F RID: 3359
	private static byte[] byte_0;

	// Token: 0x04000D20 RID: 3360
	private static bool bool_1;

	// Token: 0x04000D21 RID: 3361
	internal static Hashtable hashtable_0;

	// Token: 0x04000D22 RID: 3362
	private static List<string> list_0;

	// Token: 0x04000D23 RID: 3363
	private static string[] string_0;

	// Token: 0x04000D24 RID: 3364
	private static bool bool_2;

	// Token: 0x04000D25 RID: 3365
	private static bool BmwDsdqaTf;

	// Token: 0x04000D26 RID: 3366
	private static bool bool_3;

	// Token: 0x04000D27 RID: 3367
	[Class34.Attribute1(typeof(Class34.Attribute1.Class35<object>[]))]
	private static bool firstrundone;

	// Token: 0x04000D28 RID: 3368
	private static Class34.Delegate15 delegate15_0;

	// Token: 0x04000D29 RID: 3369
	private static byte[] byte_1;

	// Token: 0x04000D2A RID: 3370
	private static int int_3;

	// Token: 0x04000D2B RID: 3371
	private static Class34.Delegate12 delegate12_0;

	// Token: 0x04000D2C RID: 3372
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x04000D2D RID: 3373
	private static List<int> list_1;

	// Token: 0x04000D2E RID: 3374
	private static Class34.Delegate14 delegate14_0;

	// Token: 0x04000D2F RID: 3375
	private static int int_4;

	// Token: 0x04000D30 RID: 3376
	private static int[] int_5;

	// Token: 0x04000D31 RID: 3377
	private static IntPtr intptr_2;

	// Token: 0x04000D32 RID: 3378
	private static uint[] uint_0;

	// Token: 0x04000D33 RID: 3379
	internal static Class34.Delegate9 delegate9_1;

	// Token: 0x04000D34 RID: 3380
	private static SortedList sortedList_0;

	// Token: 0x04000D35 RID: 3381
	private static IntPtr intptr_3;

	// Token: 0x04000D36 RID: 3382
	private static long long_1;

	// Token: 0x04000D37 RID: 3383
	private static Class34.Delegate11 delegate11_0;

	// Token: 0x04000D38 RID: 3384
	private static object object_2;

	// Token: 0x04000D39 RID: 3385
	private static bool bool_4 = false;

	// Token: 0x02000122 RID: 290
	// (Invoke) Token: 0x06001408 RID: 5128
	private delegate void Delegate8(object o);

	// Token: 0x02000123 RID: 291
	internal class Attribute1 : Attribute
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x00007ACB File Offset: 0x00005CCB
		public Attribute1(object object_0)
		{
		}

		// Token: 0x02000124 RID: 292
		internal class Class35<T>
		{
			// Token: 0x0600140D RID: 5133 RVA: 0x00007AD3 File Offset: 0x00005CD3
			internal static bool smethod_0()
			{
				return Class34.Attribute1.Class35<T>.object_0 == null;
			}

			// Token: 0x0600140E RID: 5134 RVA: 0x00007ADD File Offset: 0x00005CDD
			internal static object smethod_1()
			{
				return Class34.Attribute1.Class35<T>.object_0;
			}

			// Token: 0x04000D3A RID: 3386
			internal static object object_0;
		}
	}

	// Token: 0x02000125 RID: 293
	internal class Class36
	{
		// Token: 0x0600140F RID: 5135 RVA: 0x000D40E0 File Offset: 0x000D22E0
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class34.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class34.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x02000126 RID: 294
	// (Invoke) Token: 0x06001412 RID: 5138
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate9(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x02000127 RID: 295
	// (Invoke) Token: 0x06001416 RID: 5142
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate10();

	// Token: 0x02000128 RID: 296
	internal struct Struct13
	{
		// Token: 0x04000D3B RID: 3387
		internal bool MuWlxphtb0;

		// Token: 0x04000D3C RID: 3388
		internal byte[] byte_0;
	}

	// Token: 0x02000129 RID: 297
	internal class Class38
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x00007AE4 File Offset: 0x00005CE4
		public Class38(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00007AF8 File Offset: 0x00005CF8
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00007B05 File Offset: 0x00005D05
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00007B13 File Offset: 0x00005D13
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00007B23 File Offset: 0x00005D23
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00007B30 File Offset: 0x00005D30
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x04000D3D RID: 3389
		private BinaryReader binaryReader_0;
	}

	// Token: 0x0200012A RID: 298
	// (Invoke) Token: 0x06001420 RID: 5152
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = 2)]
	private delegate IntPtr Delegate11(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x0200012B RID: 299
	// (Invoke) Token: 0x06001424 RID: 5156
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate12(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x0200012C RID: 300
	// (Invoke) Token: 0x06001428 RID: 5160
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate13(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x0200012D RID: 301
	// (Invoke) Token: 0x0600142C RID: 5164
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate14(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x0200012E RID: 302
	// (Invoke) Token: 0x06001430 RID: 5168
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate15(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x0200012F RID: 303
	// (Invoke) Token: 0x06001434 RID: 5172
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate16(IntPtr ptr);

	// Token: 0x02000130 RID: 304
	[Flags]
	private enum Enum3
	{

	}
}
