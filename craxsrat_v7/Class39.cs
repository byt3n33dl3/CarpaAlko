using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x02000131 RID: 305
internal class Class39
{
	// Token: 0x06001437 RID: 5175 RVA: 0x00007B3D File Offset: 0x00005D3D
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x000D4160 File Offset: 0x000D2360
	internal static object[] smethod_1<T>(int int_1, object object_1, object object_2, ref T gparam_0)
	{
		Class39.Class45 @class = null;
		object obj = Class39.object_0;
		lock (obj)
		{
			if (!Class39.bool_0)
			{
				Class39.bool_0 = true;
				Class39.smethod_4();
			}
			if (Class39.class45_0[int_1] != null)
			{
				@class = Class39.class45_0[int_1];
			}
			else
			{
				Class39.binaryReader_0.BaseStream.Position = (long)Class39.int_0[int_1];
				@class = new Class39.Class45();
				Module module = typeof(Class39).Module;
				int metadataToken = Class39.smethod_6(Class39.binaryReader_0);
				int num = Class39.smethod_6(Class39.binaryReader_0);
				int num2 = Class39.smethod_6(Class39.binaryReader_0);
				int num3 = Class39.smethod_6(Class39.binaryReader_0);
				@class.object_0 = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = @class.object_0.GetParameters();
				@class.class41_0 = new Class39.Class41[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class39.Class41 class2 = new Class39.Class41();
					class2.bool_0 = type.IsByRef;
					class2.int_0 = i;
					@class.class41_0[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class39.Enum4 enum4_;
					if (type == typeof(string))
					{
						enum4_ = (Class39.Enum4)14;
					}
					else if (type == typeof(byte))
					{
						enum4_ = (Class39.Enum4)2;
					}
					else if (type == typeof(sbyte))
					{
						enum4_ = (Class39.Enum4)1;
					}
					else if (type == typeof(short))
					{
						enum4_ = (Class39.Enum4)3;
					}
					else if (type == typeof(ushort))
					{
						enum4_ = (Class39.Enum4)4;
					}
					else if (type == typeof(int))
					{
						enum4_ = (Class39.Enum4)5;
					}
					else if (type == typeof(uint))
					{
						enum4_ = (Class39.Enum4)6;
					}
					else if (type == typeof(long))
					{
						enum4_ = (Class39.Enum4)7;
					}
					else if (type == typeof(ulong))
					{
						enum4_ = (Class39.Enum4)8;
					}
					else if (type == typeof(float))
					{
						enum4_ = (Class39.Enum4)9;
					}
					else if (type == typeof(double))
					{
						enum4_ = (Class39.Enum4)10;
					}
					else if (type == typeof(bool))
					{
						enum4_ = (Class39.Enum4)11;
					}
					else if (type == typeof(IntPtr))
					{
						enum4_ = (Class39.Enum4)12;
					}
					else if (type == typeof(UIntPtr))
					{
						enum4_ = (Class39.Enum4)13;
					}
					else if (type == typeof(char))
					{
						enum4_ = (Class39.Enum4)15;
					}
					else
					{
						enum4_ = (Class39.Enum4)0;
					}
					class2.enum4_0 = enum4_;
				}
				@class.UqaYjxudZI = new List<Class39.Class42>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = Class39.smethod_6(Class39.binaryReader_0);
					Class39.Class42 class3 = new Class39.Class42();
					class3.type_0 = null;
					if (num4 >= 0 && num4 < 50)
					{
						class3.enum4_0 = (Class39.Enum4)(num4 & 31);
						class3.bool_0 = ((num4 & 32) > 0);
					}
					class3.int_0 = j;
					@class.UqaYjxudZI.Add(class3);
				}
				@class.list_1 = new List<Class39.Class43>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = Class39.smethod_6(Class39.binaryReader_0);
					int int_2 = Class39.smethod_6(Class39.binaryReader_0);
					Class39.Class43 class4 = new Class39.Class43();
					class4.int_0 = num5;
					class4.int_1 = int_2;
					Class39.Class44 class5 = new Class39.Class44();
					class4.class44_0 = class5;
					num5 = Class39.smethod_6(Class39.binaryReader_0);
					int_2 = Class39.smethod_6(Class39.binaryReader_0);
					int num6 = Class39.smethod_6(Class39.binaryReader_0);
					class5.int_0 = num5;
					class5.int_1 = int_2;
					class5.int_3 = num6;
					if (num6 == 0)
					{
						class5.type_0 = module.ResolveType(Class39.smethod_6(Class39.binaryReader_0));
					}
					else if (num6 == 1)
					{
						class5.int_2 = Class39.smethod_6(Class39.binaryReader_0);
					}
					else
					{
						Class39.smethod_6(Class39.binaryReader_0);
					}
					@class.list_1.Add(class4);
				}
				@class.list_1.Sort(new Comparison<Class39.Class43>(Class39.Class65<T>.<>9.method_0));
				@class.list_0 = new List<Class39.Class40>(num3);
				for (int l = 0; l < num3; l++)
				{
					Class39.Class40 class6 = new Class39.Class40();
					byte b = Class39.binaryReader_0.ReadByte();
					class6.enum6_0 = (Class39.Enum6)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num7 = (int)Class39.byte_0[(int)b];
					if (num7 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num7)
						{
						case 1:
							obj2 = Class39.smethod_6(Class39.binaryReader_0);
							break;
						case 2:
							obj2 = Class39.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class39.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class39.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num8 = Class39.smethod_6(Class39.binaryReader_0);
							int[] array = new int[num8];
							for (int m = 0; m < num8; m++)
							{
								array[m] = Class39.smethod_6(Class39.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class39.class45_0[int_1] = @class;
			}
		}
		Class39.Class48 class7 = new Class39.Class48();
		class7.class45_0 = @class;
		ParameterInfo[] parameters2 = @class.object_0.GetParameters();
		bool flag2 = false;
		int num9 = 0;
		if (@class.object_0 is MethodInfo && ((MethodInfo)@class.object_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.object_0.IsStatic)
		{
			class7.class50_0 = new Class39.Class50[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class50_0[n] = Class39.Class50.smethod_1(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num9++;
				}
			}
		}
		else
		{
			class7.class50_0 = new Class39.Class50[parameters2.Length + 1];
			if (@class.object_0.DeclaringType.IsValueType)
			{
				class7.class50_0[0] = new Class39.Class61(new Class39.Class62(object_2), @class.object_0.DeclaringType);
			}
			else
			{
				class7.class50_0[0] = new Class39.Class62(object_2);
			}
			for (int num10 = 0; num10 < parameters2.Length; num10++)
			{
				Type parameterType2 = parameters2[num10].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class50_0[num10 + 1] = Class39.Class50.smethod_1(parameterType2, object_1[num10]);
					num9++;
				}
				else
				{
					class7.class50_0[num10 + 1] = Class39.Class50.smethod_1(parameterType2, object_1[num10]);
				}
			}
		}
		class7.class50_1 = new Class39.Class50[@class.UqaYjxudZI.Count];
		for (int num11 = 0; num11 < @class.UqaYjxudZI.Count; num11++)
		{
			Class39.Class42 class8 = @class.UqaYjxudZI[num11];
			switch (class8.enum4_0)
			{
			case (Class39.Enum4)0:
				class7.class50_1[num11] = null;
				break;
			case (Class39.Enum4)1:
			case (Class39.Enum4)2:
			case (Class39.Enum4)3:
			case (Class39.Enum4)4:
			case (Class39.Enum4)5:
			case (Class39.Enum4)6:
			case (Class39.Enum4)11:
			case (Class39.Enum4)15:
				class7.class50_1[num11] = new Class39.Class52(0, class8.enum4_0);
				break;
			case (Class39.Enum4)7:
			case (Class39.Enum4)8:
				class7.class50_1[num11] = new Class39.Class53(0L, class8.enum4_0);
				break;
			case (Class39.Enum4)9:
			case (Class39.Enum4)10:
				class7.class50_1[num11] = new Class39.Class55(0.0, class8.enum4_0);
				break;
			case (Class39.Enum4)12:
				class7.class50_1[num11] = new Class39.Class54(IntPtr.Zero);
				break;
			case (Class39.Enum4)13:
				class7.class50_1[num11] = new Class39.Class54(UIntPtr.Zero);
				break;
			case (Class39.Enum4)14:
				class7.class50_1[num11] = null;
				break;
			case (Class39.Enum4)16:
				class7.class50_1[num11] = new Class39.Class62(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num12 = 0;
		if (flag2)
		{
			num12 = 1;
		}
		num12 += num9;
		object[] array2 = new object[num12];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.object_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.object_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class50_2 != null)
			{
				array2[0] = class7.class50_2.vmethod_3(methodInfo.ReturnType);
			}
		}
		if (num9 > 0)
		{
			int num13 = 0;
			if (flag2)
			{
				num13++;
			}
			for (int num14 = 0; num14 < parameters2.Length; num14++)
			{
				Type type2 = parameters2[num14].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class50_0[num14] != null)
					{
						if (@class.object_0.IsStatic)
						{
							array2[num13] = class7.class50_0[num14].vmethod_3(type2);
						}
						else
						{
							array2[num13] = class7.class50_0[num14 + 1].vmethod_3(type2);
						}
					}
					else
					{
						array2[num13] = null;
					}
					num13++;
				}
			}
		}
		if (!@class.object_0.IsStatic && @class.object_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class50_0[0].vmethod_3(@class.object_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x000D4B40 File Offset: 0x000D2D40
	internal static object[] smethod_2(int int_1, object object_1, object object_2)
	{
		int num = 0;
		return Class39.smethod_1<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x00007B45 File Offset: 0x00005D45
	internal static object[] smethod_3<T>(int int_1, object object_1, ref T gparam_0)
	{
		return Class39.smethod_1<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x000D4B5C File Offset: 0x000D2D5C
	internal static void smethod_4()
	{
		if (Class39.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class39).Assembly.GetManifestResourceStream("jucLfjvbYwrhQmDysl.Q6o0g2xrmPLFJhSKAI"));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class39.smethod_5(byte_);
		}
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x000D4BC0 File Offset: 0x000D2DC0
	internal static void smethod_5(byte[] byte_1)
	{
		Class39.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class39.byte_0 = new byte[255];
		int num = Class39.smethod_6(Class39.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class39.binaryReader_0.ReadByte();
			Class39.byte_0[num2] = Class39.binaryReader_0.ReadByte();
		}
		num = Class39.smethod_6(Class39.binaryReader_0);
		Class39.list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class39.list_0.Add(Encoding.Unicode.GetString(Class39.binaryReader_0.ReadBytes(Class39.smethod_6(Class39.binaryReader_0))));
		}
		num = Class39.smethod_6(Class39.binaryReader_0);
		Class39.class45_0 = new Class39.Class45[num];
		Class39.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class39.class45_0[k] = null;
			Class39.int_0[k] = Class39.smethod_6(Class39.binaryReader_0);
		}
		int num3 = (int)Class39.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class39.int_0[l];
			Class39.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x000D4CF4 File Offset: 0x000D2EF4
	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num >= 128U)
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (!flag)
			{
				return (int)num2;
			}
			return (int)(~(int)num2);
		}
		else
		{
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
	}

	// Token: 0x04000D3F RID: 3391
	internal static Class39.Class45[] class45_0 = null;

	// Token: 0x04000D40 RID: 3392
	internal static int[] int_0 = null;

	// Token: 0x04000D41 RID: 3393
	internal static List<string> list_0;

	// Token: 0x04000D42 RID: 3394
	private static BinaryReader binaryReader_0;

	// Token: 0x04000D43 RID: 3395
	private static byte[] byte_0;

	// Token: 0x04000D44 RID: 3396
	private static bool bool_0 = false;

	// Token: 0x04000D45 RID: 3397
	private static object object_0 = new object();

	// Token: 0x02000132 RID: 306
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct14
	{
		// Token: 0x04000D46 RID: 3398
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000D47 RID: 3399
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x04000D48 RID: 3400
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x04000D49 RID: 3401
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x04000D4A RID: 3402
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000D4B RID: 3403
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x02000133 RID: 307
	private class Class52 : Class39.Class51
	{
		// Token: 0x06001440 RID: 5184 RVA: 0x000D4D8C File Offset: 0x000D2F8C
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			this.struct14_0 = ((Class39.Class52)class50_0).struct14_0;
			this.enum4_0 = ((Class39.Class52)class50_0).enum4_0;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000D4DBC File Offset: 0x000D2FBC
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_9(class50_0);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000D4DD0 File Offset: 0x000D2FD0
		public Class52(bool bool_0)
		{
			this.enum7_0 = (Class39.Enum7)1;
			if (!bool_0)
			{
				this.struct14_0.int_0 = 0;
			}
			else
			{
				this.struct14_0.int_0 = 1;
			}
			this.enum4_0 = (Class39.Enum4)11;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000D4E10 File Offset: 0x000D3010
		public Class52(Class39.Class52 class52_0)
		{
			this.enum7_0 = class52_0.enum7_0;
			this.struct14_0.int_0 = class52_0.struct14_0.int_0;
			this.enum4_0 = class52_0.enum4_0;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00007B5A File Offset: 0x00005D5A
		public override Class39.Class51 vmethod_69()
		{
			return new Class39.Class52(this);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000D4E54 File Offset: 0x000D3054
		public Class52(int int_0)
		{
			this.enum7_0 = (Class39.Enum7)1;
			this.struct14_0.int_0 = int_0;
			this.enum4_0 = (Class39.Enum4)5;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000D4E84 File Offset: 0x000D3084
		public Class52(uint uint_0)
		{
			this.enum7_0 = (Class39.Enum7)1;
			this.struct14_0.uint_0 = uint_0;
			this.enum4_0 = (Class39.Enum4)6;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000D4EB4 File Offset: 0x000D30B4
		public Class52(int int_0, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)1;
			this.struct14_0.int_0 = int_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000D4EE4 File Offset: 0x000D30E4
		public Class52(uint uint_0, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)1;
			this.struct14_0.uint_0 = uint_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000D4F14 File Offset: 0x000D3114
		public override bool vmethod_10()
		{
			Class39.Enum4 @enum = this.enum4_0;
			switch (@enum)
			{
			case (Class39.Enum4)1:
			case (Class39.Enum4)3:
			case (Class39.Enum4)5:
			case (Class39.Enum4)7:
				goto IL_46;
			case (Class39.Enum4)2:
			case (Class39.Enum4)4:
			case (Class39.Enum4)6:
				break;
			default:
				if (@enum == (Class39.Enum4)11)
				{
					goto IL_46;
				}
				if (@enum == (Class39.Enum4)15)
				{
					goto IL_46;
				}
				break;
			}
			return this.struct14_0.uint_0 == 0U;
			IL_46:
			return this.struct14_0.int_0 == 0;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00007B62 File Offset: 0x00005D62
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000D4F78 File Offset: 0x000D3178
		public override Class39.Class50 vmethod_11(Class39.Enum4 enum4_1)
		{
			switch (enum4_1)
			{
			case (Class39.Enum4)1:
				return this.vmethod_13();
			case (Class39.Enum4)2:
				return this.vmethod_14();
			case (Class39.Enum4)3:
				return this.vmethod_15();
			case (Class39.Enum4)4:
				return this.vmethod_16();
			case (Class39.Enum4)5:
				return this.vmethod_17();
			case (Class39.Enum4)6:
				return this.vmethod_18();
			case (Class39.Enum4)11:
				return this.vmethod_12();
			case (Class39.Enum4)15:
				return this.method_7();
			case (Class39.Enum4)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class39.Enum8)4).ToString());
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000D5024 File Offset: 0x000D3224
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum4_0)
				{
				case (Class39.Enum4)1:
					return this.struct14_0.sbyte_0;
				case (Class39.Enum4)2:
					return this.struct14_0.byte_0;
				case (Class39.Enum4)3:
					return this.struct14_0.short_0;
				case (Class39.Enum4)4:
					return this.struct14_0.ushort_0;
				case (Class39.Enum4)5:
					return this.struct14_0.int_0;
				case (Class39.Enum4)6:
					return this.struct14_0.uint_0;
				case (Class39.Enum4)7:
					return (long)this.struct14_0.int_0;
				case (Class39.Enum4)8:
					return (ulong)this.struct14_0.uint_0;
				case (Class39.Enum4)11:
					return this.yQwppAuByG();
				case (Class39.Enum4)15:
					return (char)this.struct14_0.int_0;
				}
				return this.struct14_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct14_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct14_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct14_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct14_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct14_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct14_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct14_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct14_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct14_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct14_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct14_0.uint_0);
			}
			if (type_0.IsEnum)
			{
				return this.method_6(type_0);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000D5368 File Offset: 0x000D3568
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct14_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct14_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct14_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct14_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct14_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct14_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct14_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct14_0.uint_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct14_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct14_0.int_0);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000D54E0 File Offset: 0x000D36E0
		public override Class39.Class52 vmethod_12()
		{
			return new Class39.Class52(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00007B6D File Offset: 0x00005D6D
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00007B75 File Offset: 0x00005D75
		public override Class39.Class52 vmethod_13()
		{
			return new Class39.Class52((int)this.struct14_0.sbyte_0, (Class39.Enum4)1);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00007B88 File Offset: 0x00005D88
		public Class39.Class52 method_7()
		{
			return new Class39.Class52(this.struct14_0.int_0, (Class39.Enum4)15);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00007B9C File Offset: 0x00005D9C
		public override Class39.Class52 vmethod_14()
		{
			return new Class39.Class52((uint)this.struct14_0.byte_0, (Class39.Enum4)2);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00007BAF File Offset: 0x00005DAF
		public override Class39.Class52 vmethod_15()
		{
			return new Class39.Class52((int)this.struct14_0.short_0, (Class39.Enum4)3);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00007BC2 File Offset: 0x00005DC2
		public override Class39.Class52 vmethod_16()
		{
			return new Class39.Class52((uint)this.struct14_0.ushort_0, (Class39.Enum4)4);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00007BD5 File Offset: 0x00005DD5
		public override Class39.Class52 vmethod_17()
		{
			return new Class39.Class52(this.struct14_0.int_0, (Class39.Enum4)5);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00007BE8 File Offset: 0x00005DE8
		public override Class39.Class52 vmethod_18()
		{
			return new Class39.Class52(this.struct14_0.uint_0, (Class39.Enum4)6);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00007BFB File Offset: 0x00005DFB
		public override Class39.Class53 vmethod_19()
		{
			return new Class39.Class53((long)this.struct14_0.int_0, (Class39.Enum4)7);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00007C0F File Offset: 0x00005E0F
		public override Class39.Class53 vmethod_20()
		{
			return new Class39.Class53((ulong)this.struct14_0.uint_0, (Class39.Enum4)8);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00007C23 File Offset: 0x00005E23
		public override Class39.Class52 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00007C2B File Offset: 0x00005E2B
		public override Class39.Class52 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00007C33 File Offset: 0x00005E33
		public override Class39.Class52 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00007C3B File Offset: 0x00005E3B
		public override Class39.Class53 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00007C43 File Offset: 0x00005E43
		public override Class39.Class52 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00007C4B File Offset: 0x00005E4B
		public override Class39.Class52 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00007C53 File Offset: 0x00005E53
		public override Class39.Class52 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00007C5B File Offset: 0x00005E5B
		public override Class39.Class53 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00007C63 File Offset: 0x00005E63
		public override Class39.Class52 vmethod_29()
		{
			return new Class39.Class52((int)(checked((sbyte)this.struct14_0.int_0)), (Class39.Enum4)1);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00007C77 File Offset: 0x00005E77
		public override Class39.Class52 vmethod_30()
		{
			return new Class39.Class52((int)(checked((sbyte)this.struct14_0.uint_0)), (Class39.Enum4)1);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00007C8B File Offset: 0x00005E8B
		public override Class39.Class52 vmethod_31()
		{
			return new Class39.Class52((int)(checked((short)this.struct14_0.int_0)), (Class39.Enum4)3);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00007C9F File Offset: 0x00005E9F
		public override Class39.Class52 vmethod_32()
		{
			return new Class39.Class52((int)(checked((short)this.struct14_0.uint_0)), (Class39.Enum4)3);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00007BD5 File Offset: 0x00005DD5
		public override Class39.Class52 vmethod_33()
		{
			return new Class39.Class52(this.struct14_0.int_0, (Class39.Enum4)5);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00007CB3 File Offset: 0x00005EB3
		public override Class39.Class52 vmethod_34()
		{
			return new Class39.Class52(checked((int)this.struct14_0.uint_0), (Class39.Enum4)5);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00007BFB File Offset: 0x00005DFB
		public override Class39.Class53 vmethod_35()
		{
			return new Class39.Class53((long)this.struct14_0.int_0, (Class39.Enum4)7);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00007CC7 File Offset: 0x00005EC7
		public override Class39.Class53 vmethod_36()
		{
			return new Class39.Class53((long)((ulong)this.struct14_0.uint_0), (Class39.Enum4)7);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00007CDB File Offset: 0x00005EDB
		public override Class39.Class52 vmethod_37()
		{
			return new Class39.Class52((int)(checked((byte)this.struct14_0.int_0)), (Class39.Enum4)2);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00007CEF File Offset: 0x00005EEF
		public override Class39.Class52 vmethod_38()
		{
			return new Class39.Class52((int)(checked((byte)this.struct14_0.uint_0)), (Class39.Enum4)2);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00007D03 File Offset: 0x00005F03
		public override Class39.Class52 vmethod_39()
		{
			return new Class39.Class52((int)(checked((ushort)this.struct14_0.int_0)), (Class39.Enum4)4);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00007D17 File Offset: 0x00005F17
		public override Class39.Class52 vmethod_40()
		{
			return new Class39.Class52((int)(checked((ushort)this.struct14_0.uint_0)), (Class39.Enum4)4);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00007D2B File Offset: 0x00005F2B
		public override Class39.Class52 vmethod_41()
		{
			return new Class39.Class52(checked((uint)this.struct14_0.int_0), (Class39.Enum4)6);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00007BE8 File Offset: 0x00005DE8
		public override Class39.Class52 vmethod_42()
		{
			return new Class39.Class52(this.struct14_0.uint_0, (Class39.Enum4)6);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00007D3F File Offset: 0x00005F3F
		public override Class39.Class53 vmethod_43()
		{
			return new Class39.Class53(checked((ulong)this.struct14_0.int_0), (Class39.Enum4)8);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00007C0F File Offset: 0x00005E0F
		public override Class39.Class53 vmethod_44()
		{
			return new Class39.Class53((ulong)this.struct14_0.uint_0, (Class39.Enum4)8);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00007D53 File Offset: 0x00005F53
		public override Class39.Class55 vmethod_45()
		{
			return new Class39.Class55((float)this.struct14_0.int_0);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00007D66 File Offset: 0x00005F66
		public override Class39.Class55 vmethod_46()
		{
			return new Class39.Class55((double)this.struct14_0.int_0);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00007D79 File Offset: 0x00005F79
		public override Class39.Class55 zLqpmHyYrP()
		{
			return new Class39.Class55(this.struct14_0.uint_0);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x000D5500 File Offset: 0x000D3700
		public override Class39.Class54 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_24().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_23().struct14_0.int_0);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x000D5544 File Offset: 0x000D3744
		public override Class39.Class54 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_28().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_27().struct14_0.uint_0);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000D5588 File Offset: 0x000D3788
		public override Class39.Class54 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_35().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_33().struct14_0.int_0);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000D55CC File Offset: 0x000D37CC
		public override Class39.Class54 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_43().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_41().struct14_0.uint_0);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000D5610 File Offset: 0x000D3810
		public override Class39.Class54 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_36().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_34().struct14_0.int_0);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000D5654 File Offset: 0x000D3854
		public override Class39.Class54 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_44().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_42().struct14_0.uint_0);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000D5698 File Offset: 0x000D3898
		public override Class39.Class50 vmethod_53()
		{
			Class39.Enum4 @enum = this.enum4_0;
			switch (@enum)
			{
			case (Class39.Enum4)1:
			case (Class39.Enum4)3:
			case (Class39.Enum4)5:
				goto IL_43;
			case (Class39.Enum4)2:
			case (Class39.Enum4)4:
				break;
			default:
				if (@enum == (Class39.Enum4)11)
				{
					goto IL_43;
				}
				if (@enum == (Class39.Enum4)15)
				{
					goto IL_43;
				}
				break;
			}
			return new Class39.Class52((int)(-(int)((ulong)this.struct14_0.uint_0)));
			IL_43:
			return new Class39.Class52(-this.struct14_0.int_0);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x000D56FC File Offset: 0x000D38FC
		public override Class39.Class50 Add(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 + ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).Add(this);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x000D5760 File Offset: 0x000D3960
		public override Class39.Class50 vmethod_54(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(checked(this.struct14_0.int_0 + ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_54(this);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x000D57C4 File Offset: 0x000D39C4
		public override Class39.Class50 vmethod_55(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(checked(this.struct14_0.uint_0 + ((Class39.Class52)class50_0).struct14_0.uint_0));
			}
			if (class50_0.method_2())
			{
				return ((Class39.Class54)class50_0).vmethod_55(this);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000D5828 File Offset: 0x000D3A28
		public override Class39.Class50 vmethod_56(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 - ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_8(this);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000D588C File Offset: 0x000D3A8C
		public override Class39.Class50 vmethod_57(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(checked(this.struct14_0.int_0 - ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			if (class50_0.method_2())
			{
				return ((Class39.Class54)class50_0).method_9(this);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x000D58F0 File Offset: 0x000D3AF0
		public override Class39.Class50 vmethod_58(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(checked(this.struct14_0.uint_0 - ((Class39.Class52)class50_0).struct14_0.uint_0));
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_10(this);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000D5954 File Offset: 0x000D3B54
		public override Class39.Class50 vmethod_59(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 * ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_59(this);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x000D59B8 File Offset: 0x000D3BB8
		public override Class39.Class50 vmethod_60(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(checked(this.struct14_0.int_0 * ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			if (class50_0.method_2())
			{
				return ((Class39.Class54)class50_0).vmethod_60(this);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000D5A1C File Offset: 0x000D3C1C
		public override Class39.Class50 vmethod_61(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(checked(this.struct14_0.uint_0 * ((Class39.Class52)class50_0).struct14_0.uint_0));
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_61(this);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000D5A80 File Offset: 0x000D3C80
		public override Class39.Class50 vmethod_62(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 / ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_11(this);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x000D5AE4 File Offset: 0x000D3CE4
		public override Class39.Class50 vmethod_63(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.uint_0 / ((Class39.Class52)class50_0).struct14_0.uint_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_12(this);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000D5B48 File Offset: 0x000D3D48
		public override Class39.Class50 vmethod_64(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 % ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_13(this);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x000D5BAC File Offset: 0x000D3DAC
		public override Class39.Class50 vmethod_65(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.uint_0 % ((Class39.Class52)class50_0).struct14_0.uint_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_14(this);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x000D5C10 File Offset: 0x000D3E10
		public override Class39.Class50 vmethod_66(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 & ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_66(this);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x000D5C74 File Offset: 0x000D3E74
		public override Class39.Class50 vmethod_67(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 | ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_67(this);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00007D8D File Offset: 0x00005F8D
		public override Class39.Class50 vmethod_68()
		{
			return new Class39.Class52(~this.struct14_0.int_0);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000D5CD8 File Offset: 0x000D3ED8
		public override Class39.Class50 igEvpBpxrl(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 ^ ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).igEvpBpxrl(this);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000D5D3C File Offset: 0x000D3F3C
		public override Class39.Class50 vmethod_70(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 << ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_17(this);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000D5DA0 File Offset: 0x000D3FA0
		public override Class39.Class50 vmethod_71(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.int_0 >> ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (class50_0.method_2())
			{
				return ((Class39.Class54)class50_0).method_16(this);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000D5E04 File Offset: 0x000D4004
		public override Class39.Class50 vmethod_72(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return new Class39.Class52(this.struct14_0.uint_0 >> ((Class39.Class52)class50_0).struct14_0.int_0);
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).method_15(this);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x000D5E68 File Offset: 0x000D4068
		public override string ToString()
		{
			Class39.Enum4 @enum = this.enum4_0;
			switch (@enum)
			{
			case (Class39.Enum4)1:
			case (Class39.Enum4)3:
			case (Class39.Enum4)5:
				goto IL_3B;
			case (Class39.Enum4)2:
			case (Class39.Enum4)4:
				break;
			default:
				if (@enum == (Class39.Enum4)11)
				{
					goto IL_3B;
				}
				break;
			}
			return this.struct14_0.uint_0.ToString();
			IL_3B:
			return this.struct14_0.int_0.ToString();
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00007DA0 File Offset: 0x00005FA0
		internal override Class39.Class50 vmethod_7()
		{
			return this;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0000237A File Offset: 0x0000057A
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x000D5EC0 File Offset: 0x000D40C0
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return ((Class39.Class62)class50_0).vmethod_4(this);
			}
			if (class50_0.iFavIhWly7())
			{
				return ((Class39.Class56)class50_0).vmethod_4(this);
			}
			Class39.Class50 @class = class50_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (!@class.method_1())
			{
				return ((Class39.Class54)@class).vmethod_4(this);
			}
			return this.struct14_0.int_0 == ((Class39.Class52)@class).struct14_0.int_0;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x000D5F44 File Offset: 0x000D4144
		private static Class39.Class51 smethod_4(Class39.Class50 class50_0)
		{
			Class39.Class51 @class = class50_0 as Class39.Class51;
			if (@class == null && class50_0.iFavIhWly7())
			{
				@class = (class50_0.vmethod_7() as Class39.Class51);
			}
			return @class;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000D5F70 File Offset: 0x000D4170
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return false;
			}
			if (class50_0.iFavIhWly7())
			{
				return ((Class39.Class56)class50_0).vmethod_5(this);
			}
			Class39.Class50 @class = class50_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct14_0.uint_0 != ((Class39.Class52)@class).struct14_0.uint_0;
			}
			return ((Class39.Class54)@class).vmethod_5(this);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000D5FEC File Offset: 0x000D41EC
		public override bool vmethod_73(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.int_0 >= ((Class39.Class52)class50_0).struct14_0.int_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_77(this);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x000D604C File Offset: 0x000D424C
		public override bool vmethod_74(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.uint_0 >= ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_78(this);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000D60AC File Offset: 0x000D42AC
		public override bool vmethod_75(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.int_0 > ((Class39.Class52)class50_0).struct14_0.int_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_79(this);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x000D610C File Offset: 0x000D430C
		public override bool vmethod_76(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.uint_0 > ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_80(this);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x000D616C File Offset: 0x000D436C
		public override bool vmethod_77(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.int_0 <= ((Class39.Class52)class50_0).struct14_0.int_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_73(this);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x000D61CC File Offset: 0x000D43CC
		public override bool vmethod_78(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.uint_0 <= ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_74(this);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x000D622C File Offset: 0x000D442C
		public override bool vmethod_79(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.int_0 < ((Class39.Class52)class50_0).struct14_0.int_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_75(this);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000D628C File Offset: 0x000D448C
		public override bool vmethod_80(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				return this.struct14_0.uint_0 < ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
			if (!class50_0.method_2())
			{
				throw new Class39.Exception1();
			}
			return ((Class39.Class54)class50_0).vmethod_76(this);
		}

		// Token: 0x04000D4C RID: 3404
		public Class39.Struct14 struct14_0;

		// Token: 0x04000D4D RID: 3405
		public Class39.Enum4 enum4_0;
	}

	// Token: 0x02000134 RID: 308
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct15
	{
		// Token: 0x04000D4E RID: 3406
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000D4F RID: 3407
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x04000D50 RID: 3408
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x04000D51 RID: 3409
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x04000D52 RID: 3410
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000D53 RID: 3411
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x04000D54 RID: 3412
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x04000D55 RID: 3413
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x02000135 RID: 309
	private class Class53 : Class39.Class51
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x000D62EC File Offset: 0x000D44EC
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			this.struct15_0 = ((Class39.Class53)class50_0).struct15_0;
			this.enum4_0 = ((Class39.Class53)class50_0).enum4_0;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x000D4DBC File Offset: 0x000D2FBC
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_9(class50_0);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000D631C File Offset: 0x000D451C
		public Class53(long long_0)
		{
			this.enum7_0 = (Class39.Enum7)2;
			this.struct15_0.long_0 = long_0;
			this.enum4_0 = (Class39.Enum4)7;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x000D634C File Offset: 0x000D454C
		public Class53(Class39.Class53 class53_0)
		{
			this.enum7_0 = class53_0.enum7_0;
			this.struct15_0.long_0 = class53_0.struct15_0.long_0;
			this.enum4_0 = class53_0.enum4_0;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public override Class39.Class51 vmethod_69()
		{
			return new Class39.Class53(this);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000D6390 File Offset: 0x000D4590
		public Class53(long long_0, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)2;
			this.struct15_0.long_0 = long_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x000D63C0 File Offset: 0x000D45C0
		public Class53(ulong ulong_0)
		{
			this.enum7_0 = (Class39.Enum7)2;
			this.struct15_0.ulong_0 = ulong_0;
			this.enum4_0 = (Class39.Enum4)8;
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000D63F0 File Offset: 0x000D45F0
		public Class53(ulong ulong_0, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)2;
			this.struct15_0.ulong_0 = ulong_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000D6420 File Offset: 0x000D4620
		public override bool vmethod_10()
		{
			if (this.enum4_0 == (Class39.Enum4)7)
			{
				return this.struct15_0.long_0 == 0L;
			}
			return this.struct15_0.ulong_0 == 0UL;
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00007B62 File Offset: 0x00005D62
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000D6464 File Offset: 0x000D4664
		public override Class39.Class50 vmethod_11(Class39.Enum4 enum4_1)
		{
			switch (enum4_1)
			{
			case (Class39.Enum4)1:
				return this.vmethod_13();
			case (Class39.Enum4)2:
				return this.vmethod_14();
			case (Class39.Enum4)3:
				return this.vmethod_15();
			case (Class39.Enum4)4:
				return this.vmethod_16();
			case (Class39.Enum4)5:
				return this.vmethod_17();
			case (Class39.Enum4)6:
				return this.vmethod_18();
			case (Class39.Enum4)7:
				return this.vmethod_19();
			case (Class39.Enum4)8:
				return this.vmethod_20();
			case (Class39.Enum4)11:
				return this.vmethod_12();
			case (Class39.Enum4)15:
				return this.method_7();
			case (Class39.Enum4)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class39.Enum8)4).ToString());
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000D651C File Offset: 0x000D471C
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum4_0)
				{
				case (Class39.Enum4)1:
					return this.struct15_0.sbyte_0;
				case (Class39.Enum4)2:
					return this.struct15_0.byte_0;
				case (Class39.Enum4)3:
					return this.struct15_0.short_0;
				case (Class39.Enum4)4:
					return this.struct15_0.ushort_0;
				case (Class39.Enum4)5:
					return this.struct15_0.int_0;
				case (Class39.Enum4)6:
					return this.struct15_0.uint_0;
				case (Class39.Enum4)7:
					return this.struct15_0.long_0;
				case (Class39.Enum4)8:
					return this.struct15_0.ulong_0;
				case (Class39.Enum4)11:
					return this.yQwppAuByG();
				case (Class39.Enum4)15:
					return (char)this.struct15_0.int_0;
				}
				return this.struct15_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct15_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct15_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct15_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct15_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct15_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct15_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return this.struct15_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct15_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct15_0.long_0;
			}
			if (type_0.IsEnum)
			{
				return this.method_6(type_0);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x000D67E8 File Offset: 0x000D49E8
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct15_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct15_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct15_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct15_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct15_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct15_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct15_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct15_0.ulong_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct15_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct15_0.long_0);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x000D54E0 File Offset: 0x000D36E0
		public override Class39.Class52 vmethod_12()
		{
			return new Class39.Class52(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00007B6D File Offset: 0x00005D6D
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00007DAB File Offset: 0x00005FAB
		public Class39.Class52 method_7()
		{
			return new Class39.Class52((int)this.struct15_0.sbyte_0, (Class39.Enum4)15);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00007DBF File Offset: 0x00005FBF
		public override Class39.Class52 vmethod_13()
		{
			return new Class39.Class52((int)this.struct15_0.sbyte_0, (Class39.Enum4)1);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00007DD2 File Offset: 0x00005FD2
		public override Class39.Class52 vmethod_14()
		{
			return new Class39.Class52((uint)this.struct15_0.byte_0, (Class39.Enum4)2);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00007DE5 File Offset: 0x00005FE5
		public override Class39.Class52 vmethod_15()
		{
			return new Class39.Class52((int)this.struct15_0.short_0, (Class39.Enum4)3);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00007DF8 File Offset: 0x00005FF8
		public override Class39.Class52 vmethod_16()
		{
			return new Class39.Class52((uint)this.struct15_0.ushort_0, (Class39.Enum4)4);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00007E0B File Offset: 0x0000600B
		public override Class39.Class52 vmethod_17()
		{
			return new Class39.Class52(this.struct15_0.int_0, (Class39.Enum4)5);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00007E1E File Offset: 0x0000601E
		public override Class39.Class52 vmethod_18()
		{
			return new Class39.Class52(this.struct15_0.uint_0, (Class39.Enum4)6);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00007E31 File Offset: 0x00006031
		public override Class39.Class53 vmethod_19()
		{
			return new Class39.Class53(this.struct15_0.long_0, (Class39.Enum4)7);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00007E44 File Offset: 0x00006044
		public override Class39.Class53 vmethod_20()
		{
			return new Class39.Class53(this.struct15_0.ulong_0, (Class39.Enum4)8);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00007C23 File Offset: 0x00005E23
		public override Class39.Class52 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00007C2B File Offset: 0x00005E2B
		public override Class39.Class52 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00007C33 File Offset: 0x00005E33
		public override Class39.Class52 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00007C3B File Offset: 0x00005E3B
		public override Class39.Class53 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00007C43 File Offset: 0x00005E43
		public override Class39.Class52 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00007C4B File Offset: 0x00005E4B
		public override Class39.Class52 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00007C53 File Offset: 0x00005E53
		public override Class39.Class52 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00007C5B File Offset: 0x00005E5B
		public override Class39.Class53 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00007E57 File Offset: 0x00006057
		public override Class39.Class52 vmethod_29()
		{
			return new Class39.Class52((int)(checked((sbyte)this.struct15_0.long_0)), (Class39.Enum4)1);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00007E6B File Offset: 0x0000606B
		public override Class39.Class52 vmethod_30()
		{
			return new Class39.Class52((int)(checked((sbyte)this.struct15_0.ulong_0)), (Class39.Enum4)1);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00007E7F File Offset: 0x0000607F
		public override Class39.Class52 vmethod_31()
		{
			return new Class39.Class52((int)(checked((short)this.struct15_0.long_0)), (Class39.Enum4)3);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00007E93 File Offset: 0x00006093
		public override Class39.Class52 vmethod_32()
		{
			return new Class39.Class52((int)(checked((short)this.struct15_0.ulong_0)), (Class39.Enum4)3);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00007EA7 File Offset: 0x000060A7
		public override Class39.Class52 vmethod_33()
		{
			return new Class39.Class52(checked((int)this.struct15_0.long_0), (Class39.Enum4)5);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00007EBB File Offset: 0x000060BB
		public override Class39.Class52 vmethod_34()
		{
			return new Class39.Class52(checked((int)this.struct15_0.ulong_0), (Class39.Enum4)5);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00007E31 File Offset: 0x00006031
		public override Class39.Class53 vmethod_35()
		{
			return new Class39.Class53(this.struct15_0.long_0, (Class39.Enum4)7);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00007ECF File Offset: 0x000060CF
		public override Class39.Class53 vmethod_36()
		{
			return new Class39.Class53(checked((long)this.struct15_0.ulong_0), (Class39.Enum4)7);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00007EE3 File Offset: 0x000060E3
		public override Class39.Class52 vmethod_37()
		{
			return new Class39.Class52((int)(checked((byte)this.struct15_0.long_0)), (Class39.Enum4)2);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00007EF7 File Offset: 0x000060F7
		public override Class39.Class52 vmethod_38()
		{
			return new Class39.Class52((int)(checked((byte)this.struct15_0.ulong_0)), (Class39.Enum4)2);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00007F0B File Offset: 0x0000610B
		public override Class39.Class52 vmethod_39()
		{
			return new Class39.Class52((int)(checked((ushort)this.struct15_0.long_0)), (Class39.Enum4)4);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00007F1F File Offset: 0x0000611F
		public override Class39.Class52 vmethod_40()
		{
			return new Class39.Class52((int)(checked((ushort)this.struct15_0.ulong_0)), (Class39.Enum4)4);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00007F33 File Offset: 0x00006133
		public override Class39.Class52 vmethod_41()
		{
			return new Class39.Class52(checked((uint)this.struct15_0.long_0), (Class39.Enum4)6);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00007F47 File Offset: 0x00006147
		public override Class39.Class52 vmethod_42()
		{
			return new Class39.Class52(checked((uint)this.struct15_0.ulong_0), (Class39.Enum4)6);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00007F5B File Offset: 0x0000615B
		public override Class39.Class53 vmethod_43()
		{
			return new Class39.Class53(checked((ulong)this.struct15_0.long_0), (Class39.Enum4)8);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00007E44 File Offset: 0x00006044
		public override Class39.Class53 vmethod_44()
		{
			return new Class39.Class53(this.struct15_0.ulong_0, (Class39.Enum4)8);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00007F6F File Offset: 0x0000616F
		public override Class39.Class55 vmethod_45()
		{
			return new Class39.Class55((float)this.struct15_0.long_0);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00007F82 File Offset: 0x00006182
		public override Class39.Class55 vmethod_46()
		{
			return new Class39.Class55((double)this.struct15_0.long_0);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00007F95 File Offset: 0x00006195
		public override Class39.Class55 zLqpmHyYrP()
		{
			return new Class39.Class55(this.struct15_0.ulong_0);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000D5500 File Offset: 0x000D3700
		public override Class39.Class54 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_24().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_23().struct14_0.int_0);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000D5544 File Offset: 0x000D3744
		public override Class39.Class54 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_28().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_27().struct14_0.uint_0);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000D5588 File Offset: 0x000D3788
		public override Class39.Class54 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_35().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_33().struct14_0.int_0);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000D55CC File Offset: 0x000D37CC
		public override Class39.Class54 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_43().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_41().struct14_0.uint_0);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000D5610 File Offset: 0x000D3810
		public override Class39.Class54 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_36().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_34().struct14_0.int_0);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x000D6960 File Offset: 0x000D4B60
		public override Class39.Class54 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)(checked((uint)this.struct15_0.ulong_0)));
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00007FA9 File Offset: 0x000061A9
		public override Class39.Class50 vmethod_53()
		{
			return new Class39.Class53(-this.struct15_0.long_0);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000D6998 File Offset: 0x000D4B98
		public override Class39.Class50 Add(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 + ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000D69E4 File Offset: 0x000D4BE4
		public override Class39.Class50 vmethod_54(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(checked(this.struct15_0.long_0 + ((Class39.Class53)class50_0).struct15_0.long_0));
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000D6A30 File Offset: 0x000D4C30
		public override Class39.Class50 vmethod_55(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(checked(this.struct15_0.ulong_0 + ((Class39.Class53)class50_0).struct15_0.ulong_0));
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000D6A7C File Offset: 0x000D4C7C
		public override Class39.Class50 vmethod_56(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 - ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000D6AC8 File Offset: 0x000D4CC8
		public override Class39.Class50 vmethod_57(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(checked(this.struct15_0.long_0 - ((Class39.Class53)class50_0).struct15_0.long_0));
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000D6B14 File Offset: 0x000D4D14
		public override Class39.Class50 vmethod_58(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(checked(this.struct15_0.ulong_0 - ((Class39.Class53)class50_0).struct15_0.ulong_0));
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000D6B60 File Offset: 0x000D4D60
		public override Class39.Class50 vmethod_59(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 * ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000D6BAC File Offset: 0x000D4DAC
		public override Class39.Class50 vmethod_60(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(checked(this.struct15_0.long_0 * ((Class39.Class53)class50_0).struct15_0.long_0));
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000D6BF8 File Offset: 0x000D4DF8
		public override Class39.Class50 vmethod_61(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(checked(this.struct15_0.ulong_0 * ((Class39.Class53)class50_0).struct15_0.ulong_0));
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000D6C44 File Offset: 0x000D4E44
		public override Class39.Class50 vmethod_62(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 / ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x000D6C90 File Offset: 0x000D4E90
		public override Class39.Class50 vmethod_63(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.ulong_0 / ((Class39.Class53)class50_0).struct15_0.ulong_0);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000D6CDC File Offset: 0x000D4EDC
		public override Class39.Class50 vmethod_64(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 % ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000D6D28 File Offset: 0x000D4F28
		public override Class39.Class50 vmethod_65(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.ulong_0 % ((Class39.Class53)class50_0).struct15_0.ulong_0);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000D6D74 File Offset: 0x000D4F74
		public override Class39.Class50 vmethod_66(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 & ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000D6DC0 File Offset: 0x000D4FC0
		public override Class39.Class50 vmethod_67(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 | ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00007FBC File Offset: 0x000061BC
		public override Class39.Class50 vmethod_68()
		{
			return new Class39.Class53(~this.struct15_0.long_0);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000D6E0C File Offset: 0x000D500C
		public override Class39.Class50 igEvpBpxrl(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.long_0 ^ ((Class39.Class53)class50_0).struct15_0.long_0);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000D6E58 File Offset: 0x000D5058
		public override Class39.Class50 vmethod_70(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_3())
			{
				return new Class39.Class53(this.struct15_0.long_0 << ((Class39.Class53)class50_0).struct15_0.int_0);
			}
			if (class50_0.vmethod_2())
			{
				return new Class39.Class53(this.struct15_0.long_0 << ((Class39.Class51)class50_0).vmethod_17().struct14_0.int_0);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x000D6EDC File Offset: 0x000D50DC
		public override Class39.Class50 vmethod_71(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_3())
			{
				return new Class39.Class53(this.struct15_0.long_0 >> ((Class39.Class53)class50_0).struct15_0.int_0);
			}
			if (class50_0.vmethod_2())
			{
				return new Class39.Class53(this.struct15_0.long_0 >> ((Class39.Class51)class50_0).vmethod_17().struct14_0.int_0);
			}
			throw new Class39.Exception1();
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000D6F60 File Offset: 0x000D5160
		public override Class39.Class50 vmethod_72(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_3())
			{
				return new Class39.Class53(this.struct15_0.ulong_0 >> ((Class39.Class53)class50_0).struct15_0.int_0);
			}
			if (!class50_0.vmethod_2())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class53(this.struct15_0.ulong_0 >> ((Class39.Class51)class50_0).vmethod_17().struct14_0.int_0);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000D6FE4 File Offset: 0x000D51E4
		public override string ToString()
		{
			if (this.enum4_0 == (Class39.Enum4)7)
			{
				return this.struct15_0.long_0.ToString();
			}
			return this.struct15_0.ulong_0.ToString();
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00007DA0 File Offset: 0x00005FA0
		internal override Class39.Class50 vmethod_7()
		{
			return this;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0000237A File Offset: 0x0000057A
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000D701C File Offset: 0x000D521C
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return ((Class39.Class62)class50_0).vmethod_4(this);
			}
			if (!class50_0.iFavIhWly7())
			{
				Class39.Class50 @class = class50_0.vmethod_7();
				return @class.method_3() && this.struct15_0.long_0 == ((Class39.Class53)@class).struct15_0.long_0;
			}
			return ((Class39.Class56)class50_0).vmethod_4(this);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000D5F44 File Offset: 0x000D4144
		private static Class39.Class51 smethod_4(Class39.Class50 class50_0)
		{
			Class39.Class51 @class = class50_0 as Class39.Class51;
			if (@class == null && class50_0.iFavIhWly7())
			{
				@class = (class50_0.vmethod_7() as Class39.Class51);
			}
			return @class;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000D7084 File Offset: 0x000D5284
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return false;
			}
			if (!class50_0.iFavIhWly7())
			{
				Class39.Class50 @class = class50_0.vmethod_7();
				return @class.method_3() && this.struct15_0.ulong_0 != ((Class39.Class53)@class).struct15_0.ulong_0;
			}
			return ((Class39.Class56)class50_0).vmethod_5(this);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000D70E4 File Offset: 0x000D52E4
		public override bool vmethod_73(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.long_0 >= ((Class39.Class53)class50_0).struct15_0.long_0;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000D7130 File Offset: 0x000D5330
		public override bool vmethod_74(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.ulong_0 >= ((Class39.Class53)class50_0).struct15_0.ulong_0;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x000D717C File Offset: 0x000D537C
		public override bool vmethod_75(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.long_0 > ((Class39.Class53)class50_0).struct15_0.long_0;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000D71C4 File Offset: 0x000D53C4
		public override bool vmethod_76(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.ulong_0 > ((Class39.Class53)class50_0).struct15_0.ulong_0;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000D720C File Offset: 0x000D540C
		public override bool vmethod_77(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.long_0 <= ((Class39.Class53)class50_0).struct15_0.long_0;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000D7258 File Offset: 0x000D5458
		public override bool vmethod_78(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.ulong_0 <= ((Class39.Class53)class50_0).struct15_0.ulong_0;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000D72A4 File Offset: 0x000D54A4
		public override bool vmethod_79(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.long_0 < ((Class39.Class53)class50_0).struct15_0.long_0;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x000D72EC File Offset: 0x000D54EC
		public override bool vmethod_80(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_3())
			{
				throw new Class39.Exception1();
			}
			return this.struct15_0.ulong_0 < ((Class39.Class53)class50_0).struct15_0.ulong_0;
		}

		// Token: 0x04000D56 RID: 3414
		public Class39.Struct15 struct15_0;

		// Token: 0x04000D57 RID: 3415
		public Class39.Enum4 enum4_0;
	}

	// Token: 0x02000136 RID: 310
	private class Class54 : Class39.Class51
	{
		// Token: 0x060014F9 RID: 5369 RVA: 0x000D7334 File Offset: 0x000D5534
		internal void method_6(Class39.Class50 class50_0)
		{
			if (!class50_0.method_2())
			{
				this.vmethod_9(class50_0);
				return;
			}
			this.object_0 = ((Class39.Class54)class50_0).object_0;
			this.enum4_0 = ((Class39.Class54)class50_0).enum4_0;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000D7374 File Offset: 0x000D5574
		internal unsafe override void vmethod_9(Class39.Class50 class50_0)
		{
			if (class50_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr value = new IntPtr(((Class39.Class53)this.object_0).struct15_0.long_0);
					IntPtr intPtr = new IntPtr(((Class39.Class53)((Class39.Class54)class50_0).object_0).struct15_0.long_0);
					*(long*)((void*)value) = intPtr.ToInt64();
					return;
				}
				IntPtr value2 = new IntPtr(((Class39.Class52)this.object_0).struct14_0.int_0);
				IntPtr intPtr2 = new IntPtr(((Class39.Class52)((Class39.Class54)class50_0).object_0).struct14_0.int_0);
				*(int*)((void*)value2) = intPtr2.ToInt32();
				return;
			}
			else
			{
				object obj = class50_0.vmethod_3(null);
				if (obj == null)
				{
					return;
				}
				IntPtr value3;
				if (IntPtr.Size == 8)
				{
					value3 = new IntPtr(((Class39.Class53)this.object_0).struct15_0.long_0);
				}
				else
				{
					value3 = new IntPtr(((Class39.Class52)this.object_0).struct14_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)((void*)value3) = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)((void*)value3) = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)((void*)value3) = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)((void*)value3) = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)((void*)value3) = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)((void*)value3) = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)((void*)value3) = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)((void*)value3) = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)((void*)value3) = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)((void*)value3) = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (!(type == typeof(char)))
				{
					throw new Class39.Exception1();
				}
				*(short*)((void*)value3) = (short)((char)obj);
				return;
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000D4DBC File Offset: 0x000D2FBC
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_9(class50_0);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000D7674 File Offset: 0x000D5874
		public Class54(IntPtr intptr_0)
		{
			this.enum7_0 = (Class39.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class39.Class53(intptr_0.ToInt64());
				this.enum4_0 = (Class39.Enum4)12;
				return;
			}
			this.object_0 = new Class39.Class52(intptr_0.ToInt32());
			this.enum4_0 = (Class39.Enum4)12;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x000D76CC File Offset: 0x000D58CC
		public Class54(UIntPtr uintptr_0)
		{
			this.enum7_0 = (Class39.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class39.Class53(uintptr_0.ToUInt64());
				this.enum4_0 = (Class39.Enum4)12;
				return;
			}
			this.object_0 = new Class39.Class52(uintptr_0.ToUInt32());
			this.enum4_0 = (Class39.Enum4)12;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000D7724 File Offset: 0x000D5924
		public Class54()
		{
			this.enum7_0 = (Class39.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class39.Class53(0L);
				this.enum4_0 = (Class39.Enum4)12;
				return;
			}
			this.object_0 = new Class39.Class52(0);
			this.enum4_0 = (Class39.Enum4)12;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00007FCF File Offset: 0x000061CF
		public override Class39.Class51 vmethod_69()
		{
			return new Class39.Class54
			{
				object_0 = this.object_0.vmethod_69(),
				enum4_0 = this.enum4_0
			};
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000D7778 File Offset: 0x000D5978
		public Class54(long long_0)
		{
			this.enum7_0 = (Class39.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class39.Class53(long_0);
				this.enum4_0 = (Class39.Enum4)12;
				return;
			}
			this.object_0 = new Class39.Class52((int)long_0);
			this.enum4_0 = (Class39.Enum4)12;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000D77C4 File Offset: 0x000D59C4
		public Class54(long long_0, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)3;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class39.Class53(long_0);
				this.enum4_0 = enum4_1;
				return;
			}
			this.object_0 = new Class39.Class52((int)long_0);
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x000D7810 File Offset: 0x000D5A10
		public Class54(ulong ulong_0)
		{
			this.enum7_0 = (Class39.Enum7)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class39.Class53(ulong_0);
				this.enum4_0 = (Class39.Enum4)13;
				return;
			}
			this.object_0 = new Class39.Class52((uint)ulong_0);
			this.enum4_0 = (Class39.Enum4)13;
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000D785C File Offset: 0x000D5A5C
		public Class54(ulong ulong_0, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)4;
			if (IntPtr.Size == 8)
			{
				this.object_0 = new Class39.Class53(ulong_0);
				this.enum4_0 = enum4_1;
				return;
			}
			this.object_0 = new Class39.Class52((uint)ulong_0);
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00007FF3 File Offset: 0x000061F3
		public override bool vmethod_10()
		{
			return this.object_0.vmethod_10();
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00007B62 File Offset: 0x00005D62
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00007B6D File Offset: 0x00005D6D
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0000237A File Offset: 0x0000057A
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000D78A8 File Offset: 0x000D5AA8
		public override Class39.Class50 vmethod_11(Class39.Enum4 enum4_1)
		{
			switch (enum4_1)
			{
			case (Class39.Enum4)1:
				return this.vmethod_13();
			case (Class39.Enum4)2:
				return this.vmethod_14();
			case (Class39.Enum4)3:
				return this.vmethod_15();
			case (Class39.Enum4)4:
				return this.vmethod_16();
			case (Class39.Enum4)5:
				return this.vmethod_17();
			case (Class39.Enum4)6:
				return this.vmethod_18();
			case (Class39.Enum4)7:
				return this.vmethod_19();
			case (Class39.Enum4)8:
				return this.vmethod_20();
			case (Class39.Enum4)11:
				return this.vmethod_12();
			case (Class39.Enum4)12:
				return this;
			case (Class39.Enum4)13:
				return this;
			case (Class39.Enum4)16:
				return this.vmethod_69();
			}
			throw new Exception(((Class39.Enum8)4).ToString());
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000D7960 File Offset: 0x000D5B60
		internal IntPtr method_7()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class39.Class53)this.object_0).struct15_0.long_0);
			}
			return new IntPtr(((Class39.Class52)this.object_0).struct14_0.int_0);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x000D79AC File Offset: 0x000D5BAC
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(IntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class39.Class53)this.object_0).struct15_0.long_0);
				}
				return new IntPtr(((Class39.Class52)this.object_0).struct14_0.int_0);
			}
			else if (!(type_0 == typeof(UIntPtr)))
			{
				if (!(type_0 == null) && !(type_0 == typeof(object)))
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					if (this.enum4_0 == (Class39.Enum4)12)
					{
						return new IntPtr(((Class39.Class53)this.object_0).struct15_0.long_0);
					}
					return new UIntPtr(((Class39.Class53)this.object_0).struct15_0.ulong_0);
				}
				else
				{
					if (this.enum4_0 == (Class39.Enum4)12)
					{
						return new IntPtr(((Class39.Class53)this.object_0).struct15_0.int_0);
					}
					return new UIntPtr(((Class39.Class52)this.object_0).struct14_0.uint_0);
				}
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new UIntPtr(((Class39.Class53)this.object_0).struct15_0.ulong_0);
				}
				return new UIntPtr(((Class39.Class52)this.object_0).struct14_0.uint_0);
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00008000 File Offset: 0x00006200
		public override Class39.Class52 vmethod_12()
		{
			return this.object_0.vmethod_12();
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0000800D File Offset: 0x0000620D
		public override Class39.Class52 vmethod_13()
		{
			return this.object_0.vmethod_13();
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0000801A File Offset: 0x0000621A
		public override Class39.Class52 vmethod_14()
		{
			return this.object_0.vmethod_14();
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00008027 File Offset: 0x00006227
		public override Class39.Class52 vmethod_15()
		{
			return this.object_0.vmethod_15();
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00008034 File Offset: 0x00006234
		public override Class39.Class52 vmethod_16()
		{
			return this.object_0.vmethod_16();
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00008041 File Offset: 0x00006241
		public override Class39.Class52 vmethod_17()
		{
			return this.object_0.vmethod_17();
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0000804E File Offset: 0x0000624E
		public override Class39.Class52 vmethod_18()
		{
			return this.object_0.vmethod_18();
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0000805B File Offset: 0x0000625B
		public override Class39.Class53 vmethod_19()
		{
			return this.object_0.vmethod_19();
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00008068 File Offset: 0x00006268
		public override Class39.Class53 vmethod_20()
		{
			return this.object_0.vmethod_20();
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00007C23 File Offset: 0x00005E23
		public override Class39.Class52 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00007C2B File Offset: 0x00005E2B
		public override Class39.Class52 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00007C33 File Offset: 0x00005E33
		public override Class39.Class52 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00007C3B File Offset: 0x00005E3B
		public override Class39.Class53 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00007C43 File Offset: 0x00005E43
		public override Class39.Class52 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00007C4B File Offset: 0x00005E4B
		public override Class39.Class52 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00007C53 File Offset: 0x00005E53
		public override Class39.Class52 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00007C5B File Offset: 0x00005E5B
		public override Class39.Class53 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00008075 File Offset: 0x00006275
		public override Class39.Class52 vmethod_29()
		{
			return this.object_0.vmethod_29();
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00008082 File Offset: 0x00006282
		public override Class39.Class52 vmethod_30()
		{
			return this.object_0.vmethod_30();
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0000808F File Offset: 0x0000628F
		public override Class39.Class52 vmethod_31()
		{
			return this.object_0.vmethod_31();
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0000809C File Offset: 0x0000629C
		public override Class39.Class52 vmethod_32()
		{
			return this.object_0.vmethod_32();
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000080A9 File Offset: 0x000062A9
		public override Class39.Class52 vmethod_33()
		{
			return this.object_0.vmethod_33();
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000080B6 File Offset: 0x000062B6
		public override Class39.Class52 vmethod_34()
		{
			return this.object_0.vmethod_34();
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000080C3 File Offset: 0x000062C3
		public override Class39.Class53 vmethod_35()
		{
			return this.object_0.vmethod_35();
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000080D0 File Offset: 0x000062D0
		public override Class39.Class53 vmethod_36()
		{
			return this.object_0.vmethod_36();
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000080DD File Offset: 0x000062DD
		public override Class39.Class52 vmethod_37()
		{
			return this.object_0.vmethod_37();
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000080EA File Offset: 0x000062EA
		public override Class39.Class52 vmethod_38()
		{
			return this.object_0.vmethod_38();
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000080F7 File Offset: 0x000062F7
		public override Class39.Class52 vmethod_39()
		{
			return this.object_0.vmethod_39();
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00008104 File Offset: 0x00006304
		public override Class39.Class52 vmethod_40()
		{
			return this.object_0.vmethod_40();
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00008111 File Offset: 0x00006311
		public override Class39.Class52 vmethod_41()
		{
			return this.object_0.vmethod_41();
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0000811E File Offset: 0x0000631E
		public override Class39.Class52 vmethod_42()
		{
			return this.object_0.vmethod_42();
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0000812B File Offset: 0x0000632B
		public override Class39.Class53 vmethod_43()
		{
			return this.object_0.vmethod_43();
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00008138 File Offset: 0x00006338
		public override Class39.Class53 vmethod_44()
		{
			return this.object_0.vmethod_44();
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00008145 File Offset: 0x00006345
		public override Class39.Class55 vmethod_45()
		{
			return this.object_0.vmethod_45();
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00008152 File Offset: 0x00006352
		public override Class39.Class55 vmethod_46()
		{
			return this.object_0.vmethod_46();
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0000815F File Offset: 0x0000635F
		public override Class39.Class55 zLqpmHyYrP()
		{
			return this.object_0.zLqpmHyYrP();
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000D5500 File Offset: 0x000D3700
		public override Class39.Class54 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_24().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_23().struct14_0.int_0);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000D5544 File Offset: 0x000D3744
		public override Class39.Class54 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_28().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_27().struct14_0.uint_0);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000D5588 File Offset: 0x000D3788
		public override Class39.Class54 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_35().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_33().struct14_0.int_0);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000D55CC File Offset: 0x000D37CC
		public override Class39.Class54 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_43().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_41().struct14_0.uint_0);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000D5610 File Offset: 0x000D3810
		public override Class39.Class54 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_36().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_34().struct14_0.int_0);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000D5654 File Offset: 0x000D3854
		public override Class39.Class54 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_44().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_42().struct14_0.uint_0);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000D7B48 File Offset: 0x000D5D48
		public override Class39.Class50 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(-((Class39.Class53)this.object_0).struct15_0.long_0);
			}
			return new Class39.Class54((long)(-(long)((Class39.Class52)this.object_0).struct14_0.int_0));
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000D7B98 File Offset: 0x000D5D98
		public override Class39.Class50 Add(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 + ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 + ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 + ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 + ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000D7C88 File Offset: 0x000D5E88
		public override Class39.Class50 vmethod_54(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.long_0 + ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(this.vmethod_17().struct14_0.int_0 + ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.long_0 + ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(this.vmethod_17().struct14_0.int_0 + ((Class39.Class52)class50_0).struct14_0.int_0)));
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000D7D78 File Offset: 0x000D5F78
		public override Class39.Class50 vmethod_55(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.ulong_0 + ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0));
				}
				return new Class39.Class54((ulong)(checked(this.vmethod_17().struct14_0.uint_0 + ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.ulong_0 + unchecked((ulong)((Class39.Class52)class50_0).struct14_0.uint_0)));
				}
				return new Class39.Class54((long)((ulong)(checked(this.vmethod_17().struct14_0.uint_0 + ((Class39.Class52)class50_0).struct14_0.uint_0))));
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000D7E64 File Offset: 0x000D6064
		public override Class39.Class50 vmethod_56(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 - ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 - ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 - ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 - ((Class39.Class52)class50_0).struct14_0.int_0));
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000D7F54 File Offset: 0x000D6154
		public Class39.Class50 method_8(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0 - this.vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0 - this.vmethod_17().struct14_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0 - this.vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(((Class39.Class52)class50_0).struct14_0.int_0 - this.vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000D8044 File Offset: 0x000D6244
		public override Class39.Class50 vmethod_57(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.long_0 - ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(this.vmethod_17().struct14_0.int_0 - ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.long_0 - ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(this.vmethod_17().struct14_0.int_0 - ((Class39.Class52)class50_0).struct14_0.int_0)));
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x000D8134 File Offset: 0x000D6334
		public Class39.Class50 method_9(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0 - this.vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(((Class39.Class52)class50_0).struct14_0.int_0 - this.vmethod_17().struct14_0.int_0)));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0 - this.vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0 - this.vmethod_17().struct14_0.int_0)));
			}
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x000D8224 File Offset: 0x000D6424
		public override Class39.Class50 vmethod_58(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.ulong_0 - ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0));
				}
				return new Class39.Class54((ulong)(checked(this.vmethod_17().struct14_0.uint_0 - ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.ulong_0 - unchecked((ulong)((Class39.Class52)class50_0).struct14_0.uint_0)));
				}
				return new Class39.Class54((long)((ulong)(checked(this.vmethod_17().struct14_0.uint_0 - ((Class39.Class52)class50_0).struct14_0.uint_0))));
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x000D8310 File Offset: 0x000D6510
		public Class39.Class50 method_10(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0 - this.vmethod_19().struct15_0.ulong_0));
				}
				return new Class39.Class54((ulong)(checked(((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0 - this.vmethod_17().struct14_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(unchecked((ulong)((Class39.Class52)class50_0).struct14_0.uint_0) - this.vmethod_19().struct15_0.ulong_0));
				}
				return new Class39.Class54((long)((ulong)(checked(((Class39.Class52)class50_0).struct14_0.uint_0 - this.vmethod_17().struct14_0.uint_0))));
			}
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000D83FC File Offset: 0x000D65FC
		public override Class39.Class50 vmethod_59(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 * ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 * ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 * ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 * ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x000D84EC File Offset: 0x000D66EC
		public override Class39.Class50 vmethod_60(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.long_0 * ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(this.vmethod_17().struct14_0.int_0 * ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.long_0 * ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0));
				}
				return new Class39.Class54((long)(checked(this.vmethod_17().struct14_0.int_0 * ((Class39.Class52)class50_0).struct14_0.int_0)));
			}
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x000D85DC File Offset: 0x000D67DC
		public override Class39.Class50 vmethod_61(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.ulong_0 * ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0));
				}
				return new Class39.Class54((ulong)(checked(this.vmethod_17().struct14_0.uint_0 * ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(checked(this.vmethod_19().struct15_0.ulong_0 * unchecked((ulong)((Class39.Class52)class50_0).struct14_0.uint_0)));
				}
				return new Class39.Class54((long)((ulong)(checked(this.vmethod_17().struct14_0.uint_0 * ((Class39.Class52)class50_0).struct14_0.uint_0))));
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x000D86C8 File Offset: 0x000D68C8
		public override Class39.Class50 vmethod_62(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 / ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 / ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 / ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 / ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000D87B8 File Offset: 0x000D69B8
		public Class39.Class50 method_11(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0 / this.vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(((Class39.Class52)class50_0).struct14_0.int_0 / this.vmethod_17().struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0 / this.vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0 / this.vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000D88A8 File Offset: 0x000D6AA8
		public override Class39.Class50 vmethod_63(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.ulong_0 / ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((ulong)(this.vmethod_17().struct14_0.uint_0 / ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.ulong_0 / ((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((long)((ulong)(this.vmethod_17().struct14_0.uint_0 / ((Class39.Class52)class50_0).struct14_0.uint_0)));
			}
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000D8998 File Offset: 0x000D6B98
		public Class39.Class50 method_12(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0 / this.vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((long)((ulong)(((Class39.Class52)class50_0).struct14_0.uint_0 / this.vmethod_17().struct14_0.uint_0)));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0 / this.vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((ulong)(((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0 / this.vmethod_17().struct14_0.uint_0));
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000D8A88 File Offset: 0x000D6C88
		public override Class39.Class50 vmethod_64(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 % ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 % ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 % ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 % ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000D8B78 File Offset: 0x000D6D78
		public Class39.Class50 method_13(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0 % this.vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0 % this.vmethod_17().struct14_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0 % this.vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(((Class39.Class52)class50_0).struct14_0.int_0 % this.vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x000D8C68 File Offset: 0x000D6E68
		public override Class39.Class50 vmethod_65(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.ulong_0 % ((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((long)((ulong)(this.vmethod_17().struct14_0.uint_0 % ((Class39.Class52)class50_0).struct14_0.uint_0)));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.ulong_0 % ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((ulong)(this.vmethod_17().struct14_0.uint_0 % ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0));
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000D8D58 File Offset: 0x000D6F58
		public Class39.Class50 method_14(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0 % this.vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((long)((ulong)(((Class39.Class52)class50_0).struct14_0.uint_0 % this.vmethod_17().struct14_0.uint_0)));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0 % this.vmethod_19().struct15_0.ulong_0);
				}
				return new Class39.Class54((ulong)(((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0 % this.vmethod_17().struct14_0.uint_0));
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000D8E48 File Offset: 0x000D7048
		public override Class39.Class50 vmethod_66(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 & ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 & ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 & ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 & ((Class39.Class52)class50_0).struct14_0.int_0));
			}
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000D8F38 File Offset: 0x000D7138
		public override Class39.Class50 vmethod_67(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 | ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 | ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 | ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 | ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000D9028 File Offset: 0x000D7228
		public override Class39.Class50 vmethod_68()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(~this.vmethod_19().struct15_0.long_0);
			}
			return new Class39.Class54((long)(~(long)this.vmethod_17().struct14_0.int_0));
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x000D906C File Offset: 0x000D726C
		public override Class39.Class50 igEvpBpxrl(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 ^ ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 ^ ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 ^ ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 ^ ((Class39.Class52)class50_0).struct14_0.int_0));
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x000D915C File Offset: 0x000D735C
		public override Class39.Class50 vmethod_70(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 << ((Class39.Class52)class50_0).struct14_0.int_0);
				}
				return new Class39.Class54((long)((long)this.vmethod_17().struct14_0.int_0 << ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 << ((Class39.Class54)class50_0).vmethod_19().struct15_0.int_0);
				}
				return new Class39.Class54((long)((long)this.vmethod_17().struct14_0.int_0 << ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000D9254 File Offset: 0x000D7454
		public override Class39.Class50 vmethod_71(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 >> ((Class39.Class52)class50_0).struct14_0.int_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 >> ((Class39.Class52)class50_0).struct14_0.int_0));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.long_0 >> ((Class39.Class54)class50_0).vmethod_19().struct15_0.int_0);
				}
				return new Class39.Class54((long)(this.vmethod_17().struct14_0.int_0 >> ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0));
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000D934C File Offset: 0x000D754C
		public override Class39.Class50 vmethod_72(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.ulong_0 >> ((Class39.Class52)class50_0).struct14_0.int_0);
				}
				return new Class39.Class54((long)((ulong)(this.vmethod_17().struct14_0.uint_0 >> ((Class39.Class52)class50_0).struct14_0.int_0)));
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class39.Class54(this.vmethod_19().struct15_0.ulong_0 >> ((Class39.Class54)class50_0).vmethod_19().struct15_0.int_0);
				}
				return new Class39.Class54((long)((ulong)(this.vmethod_17().struct14_0.uint_0 >> ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0)));
			}
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0000816C File Offset: 0x0000636C
		public Class39.Class50 method_15(Class39.Class52 class52_0)
		{
			return new Class39.Class54((long)((ulong)(class52_0.struct14_0.uint_0 >> this.vmethod_17().struct14_0.int_0)));
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00008193 File Offset: 0x00006393
		public Class39.Class50 method_16(Class39.Class52 class52_0)
		{
			return new Class39.Class54((long)(class52_0.struct14_0.int_0 >> this.vmethod_19().struct15_0.int_0));
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000081BA File Offset: 0x000063BA
		public Class39.Class50 method_17(Class39.Class52 class52_0)
		{
			return new Class39.Class54((long)((long)class52_0.struct14_0.int_0 << this.vmethod_19().struct15_0.int_0));
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000081E1 File Offset: 0x000063E1
		public override string ToString()
		{
			return this.object_0.ToString();
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00007DA0 File Offset: 0x00005FA0
		internal override Class39.Class50 vmethod_7()
		{
			return this;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0000237A File Offset: 0x0000057A
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000D9444 File Offset: 0x000D7644
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return false;
			}
			if (class50_0.iFavIhWly7())
			{
				return ((Class39.Class56)class50_0).vmethod_4(this);
			}
			Class39.Class50 @class = class50_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 == ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 == ((Class39.Class52)class50_0).struct14_0.int_0;
			}
			else
			{
				if (!@class.method_2())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_19().struct15_0.long_0 == ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0;
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000D951C File Offset: 0x000D771C
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return false;
			}
			if (class50_0.iFavIhWly7())
			{
				return ((Class39.Class56)class50_0).vmethod_5(this);
			}
			Class39.Class50 @class = class50_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (!@class.method_1())
			{
				if (@class.method_2())
				{
					int size = IntPtr.Size;
					return this.vmethod_19().struct15_0.ulong_0 != ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return false;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 != ((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 != ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000D9600 File Offset: 0x000D7800
		public override bool vmethod_73(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 >= ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 >= ((Class39.Class52)class50_0).struct14_0.int_0;
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 >= ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 >= ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0;
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x000D96EC File Offset: 0x000D78EC
		public override bool vmethod_74(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 >= ((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 >= ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 >= ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 >= ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000D97D8 File Offset: 0x000D79D8
		public override bool vmethod_75(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 > ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 > ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 > ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 > ((Class39.Class52)class50_0).struct14_0.int_0;
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000D98B8 File Offset: 0x000D7AB8
		public override bool vmethod_76(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 > ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 > ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 > ((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 > ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000D9998 File Offset: 0x000D7B98
		public override bool vmethod_77(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_1())
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 <= ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 <= ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 <= ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 <= ((Class39.Class52)class50_0).struct14_0.int_0;
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000D9A84 File Offset: 0x000D7C84
		public override bool vmethod_78(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 <= ((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 <= ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 <= ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 <= ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0;
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x000D9B70 File Offset: 0x000D7D70
		public override bool vmethod_79(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 < ((Class39.Class52)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 < ((Class39.Class52)class50_0).struct14_0.int_0;
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.long_0 < ((Class39.Class54)class50_0).vmethod_19().struct15_0.long_0;
				}
				return this.vmethod_17().struct14_0.int_0 < ((Class39.Class54)class50_0).vmethod_17().struct14_0.int_0;
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000D9C50 File Offset: 0x000D7E50
		public override bool vmethod_80(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (class50_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 < ((Class39.Class52)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 < ((Class39.Class52)class50_0).struct14_0.uint_0;
			}
			else
			{
				if (!class50_0.method_2())
				{
					throw new Class39.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_19().struct15_0.ulong_0 < ((Class39.Class54)class50_0).vmethod_19().struct15_0.ulong_0;
				}
				return this.vmethod_17().struct14_0.uint_0 < ((Class39.Class54)class50_0).vmethod_17().struct14_0.uint_0;
			}
		}

		// Token: 0x04000D58 RID: 3416
		public object object_0;

		// Token: 0x04000D59 RID: 3417
		public Class39.Enum4 enum4_0;
	}

	// Token: 0x02000137 RID: 311
	private abstract class Class51 : Class39.Class50
	{
		// Token: 0x06001561 RID: 5473
		public abstract bool vmethod_10();

		// Token: 0x06001562 RID: 5474
		public abstract bool yQwppAuByG();

		// Token: 0x06001563 RID: 5475
		public abstract Class39.Class50 vmethod_11(Class39.Enum4 enum4_0);

		// Token: 0x06001564 RID: 5476
		public abstract Class39.Class52 vmethod_12();

		// Token: 0x06001565 RID: 5477
		public abstract Class39.Class52 vmethod_13();

		// Token: 0x06001566 RID: 5478
		public abstract Class39.Class52 vmethod_14();

		// Token: 0x06001567 RID: 5479
		public abstract Class39.Class52 vmethod_15();

		// Token: 0x06001568 RID: 5480
		public abstract Class39.Class52 vmethod_16();

		// Token: 0x06001569 RID: 5481
		public abstract Class39.Class52 vmethod_17();

		// Token: 0x0600156A RID: 5482
		public abstract Class39.Class52 vmethod_18();

		// Token: 0x0600156B RID: 5483
		public abstract Class39.Class53 vmethod_19();

		// Token: 0x0600156C RID: 5484
		public abstract Class39.Class53 vmethod_20();

		// Token: 0x0600156D RID: 5485
		public abstract Class39.Class52 vmethod_21();

		// Token: 0x0600156E RID: 5486
		public abstract Class39.Class52 vmethod_22();

		// Token: 0x0600156F RID: 5487
		public abstract Class39.Class52 vmethod_23();

		// Token: 0x06001570 RID: 5488
		public abstract Class39.Class53 vmethod_24();

		// Token: 0x06001571 RID: 5489
		public abstract Class39.Class52 vmethod_25();

		// Token: 0x06001572 RID: 5490
		public abstract Class39.Class52 vmethod_26();

		// Token: 0x06001573 RID: 5491
		public abstract Class39.Class52 vmethod_27();

		// Token: 0x06001574 RID: 5492
		public abstract Class39.Class53 vmethod_28();

		// Token: 0x06001575 RID: 5493
		public abstract Class39.Class52 vmethod_29();

		// Token: 0x06001576 RID: 5494
		public abstract Class39.Class52 vmethod_30();

		// Token: 0x06001577 RID: 5495
		public abstract Class39.Class52 vmethod_31();

		// Token: 0x06001578 RID: 5496
		public abstract Class39.Class52 vmethod_32();

		// Token: 0x06001579 RID: 5497
		public abstract Class39.Class52 vmethod_33();

		// Token: 0x0600157A RID: 5498
		public abstract Class39.Class52 vmethod_34();

		// Token: 0x0600157B RID: 5499
		public abstract Class39.Class53 vmethod_35();

		// Token: 0x0600157C RID: 5500
		public abstract Class39.Class53 vmethod_36();

		// Token: 0x0600157D RID: 5501
		public abstract Class39.Class52 vmethod_37();

		// Token: 0x0600157E RID: 5502
		public abstract Class39.Class52 vmethod_38();

		// Token: 0x0600157F RID: 5503
		public abstract Class39.Class52 vmethod_39();

		// Token: 0x06001580 RID: 5504
		public abstract Class39.Class52 vmethod_40();

		// Token: 0x06001581 RID: 5505
		public abstract Class39.Class52 vmethod_41();

		// Token: 0x06001582 RID: 5506
		public abstract Class39.Class52 vmethod_42();

		// Token: 0x06001583 RID: 5507
		public abstract Class39.Class53 vmethod_43();

		// Token: 0x06001584 RID: 5508
		public abstract Class39.Class53 vmethod_44();

		// Token: 0x06001585 RID: 5509
		public abstract Class39.Class55 vmethod_45();

		// Token: 0x06001586 RID: 5510
		public abstract Class39.Class55 vmethod_46();

		// Token: 0x06001587 RID: 5511
		public abstract Class39.Class55 zLqpmHyYrP();

		// Token: 0x06001588 RID: 5512
		public abstract Class39.Class54 vmethod_47();

		// Token: 0x06001589 RID: 5513
		public abstract Class39.Class54 vmethod_48();

		// Token: 0x0600158A RID: 5514
		public abstract Class39.Class54 vmethod_49();

		// Token: 0x0600158B RID: 5515
		public abstract Class39.Class54 vmethod_50();

		// Token: 0x0600158C RID: 5516
		public abstract Class39.Class54 vmethod_51();

		// Token: 0x0600158D RID: 5517
		public abstract Class39.Class54 vmethod_52();

		// Token: 0x0600158E RID: 5518
		public abstract Class39.Class50 vmethod_53();

		// Token: 0x0600158F RID: 5519
		public abstract Class39.Class50 Add(Class39.Class50 class50_0);

		// Token: 0x06001590 RID: 5520
		public abstract Class39.Class50 vmethod_54(Class39.Class50 class50_0);

		// Token: 0x06001591 RID: 5521
		public abstract Class39.Class50 vmethod_55(Class39.Class50 class50_0);

		// Token: 0x06001592 RID: 5522
		public abstract Class39.Class50 vmethod_56(Class39.Class50 class50_0);

		// Token: 0x06001593 RID: 5523
		public abstract Class39.Class50 vmethod_57(Class39.Class50 class50_0);

		// Token: 0x06001594 RID: 5524
		public abstract Class39.Class50 vmethod_58(Class39.Class50 class50_0);

		// Token: 0x06001595 RID: 5525
		public abstract Class39.Class50 vmethod_59(Class39.Class50 class50_0);

		// Token: 0x06001596 RID: 5526
		public abstract Class39.Class50 vmethod_60(Class39.Class50 class50_0);

		// Token: 0x06001597 RID: 5527
		public abstract Class39.Class50 vmethod_61(Class39.Class50 class50_0);

		// Token: 0x06001598 RID: 5528
		public abstract Class39.Class50 vmethod_62(Class39.Class50 class50_0);

		// Token: 0x06001599 RID: 5529
		public abstract Class39.Class50 vmethod_63(Class39.Class50 class50_0);

		// Token: 0x0600159A RID: 5530
		public abstract Class39.Class50 vmethod_64(Class39.Class50 class50_0);

		// Token: 0x0600159B RID: 5531
		public abstract Class39.Class50 vmethod_65(Class39.Class50 class50_0);

		// Token: 0x0600159C RID: 5532
		public abstract Class39.Class50 vmethod_66(Class39.Class50 class50_0);

		// Token: 0x0600159D RID: 5533
		public abstract Class39.Class50 vmethod_67(Class39.Class50 class50_0);

		// Token: 0x0600159E RID: 5534
		public abstract Class39.Class50 vmethod_68();

		// Token: 0x0600159F RID: 5535
		public abstract Class39.Class50 igEvpBpxrl(Class39.Class50 class50_0);

		// Token: 0x060015A0 RID: 5536
		public abstract Class39.Class51 vmethod_69();

		// Token: 0x060015A1 RID: 5537
		public abstract Class39.Class50 vmethod_70(Class39.Class50 class50_0);

		// Token: 0x060015A2 RID: 5538
		public abstract Class39.Class50 vmethod_71(Class39.Class50 class50_0);

		// Token: 0x060015A3 RID: 5539
		public abstract Class39.Class50 vmethod_72(Class39.Class50 class50_0);

		// Token: 0x060015A4 RID: 5540
		public abstract bool vmethod_73(Class39.Class50 class50_0);

		// Token: 0x060015A5 RID: 5541
		public abstract bool vmethod_74(Class39.Class50 class50_0);

		// Token: 0x060015A6 RID: 5542
		public abstract bool vmethod_75(Class39.Class50 class50_0);

		// Token: 0x060015A7 RID: 5543
		public abstract bool vmethod_76(Class39.Class50 class50_0);

		// Token: 0x060015A8 RID: 5544
		public abstract bool vmethod_77(Class39.Class50 class50_0);

		// Token: 0x060015A9 RID: 5545
		public abstract bool vmethod_78(Class39.Class50 class50_0);

		// Token: 0x060015AA RID: 5546
		public abstract bool vmethod_79(Class39.Class50 class50_0);

		// Token: 0x060015AB RID: 5547
		public abstract bool vmethod_80(Class39.Class50 class50_0);

		// Token: 0x060015AC RID: 5548 RVA: 0x0000237A File Offset: 0x0000057A
		internal override bool vmethod_2()
		{
			return true;
		}
	}

	// Token: 0x02000138 RID: 312
	private class Class55 : Class39.Class51
	{
		// Token: 0x060015AE RID: 5550 RVA: 0x000D9D44 File Offset: 0x000D7F44
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			this.double_0 = ((Class39.Class55)class50_0).double_0;
			this.enum4_0 = ((Class39.Class55)class50_0).enum4_0;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000D4DBC File Offset: 0x000D2FBC
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_9(class50_0);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000D9D74 File Offset: 0x000D7F74
		public Class55(double double_1)
		{
			this.enum7_0 = (Class39.Enum7)5;
			this.enum4_0 = (Class39.Enum4)10;
			this.double_0 = double_1;
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000D9DA0 File Offset: 0x000D7FA0
		public Class55(Class39.Class55 class55_0)
		{
			this.enum7_0 = class55_0.enum7_0;
			this.enum4_0 = class55_0.enum4_0;
			this.double_0 = class55_0.double_0;
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000081EE File Offset: 0x000063EE
		public override Class39.Class51 vmethod_69()
		{
			return new Class39.Class55(this);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000D9DD8 File Offset: 0x000D7FD8
		public Class55(double double_1, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)5;
			this.double_0 = double_1;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000D9E00 File Offset: 0x000D8000
		public Class55(float float_0)
		{
			this.enum7_0 = (Class39.Enum7)5;
			this.double_0 = (double)float_0;
			this.enum4_0 = (Class39.Enum4)9;
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000D9E2C File Offset: 0x000D802C
		public Class55(float float_0, Class39.Enum4 enum4_1)
		{
			this.enum7_0 = (Class39.Enum7)5;
			this.double_0 = (double)float_0;
			this.enum4_0 = enum4_1;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000081F6 File Offset: 0x000063F6
		public override bool vmethod_10()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00007B62 File Offset: 0x00005D62
		public override bool yQwppAuByG()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00008209 File Offset: 0x00006409
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000D9E58 File Offset: 0x000D8058
		public override Class39.Class50 vmethod_11(Class39.Enum4 enum4_1)
		{
			switch (enum4_1)
			{
			case (Class39.Enum4)1:
				return this.vmethod_13();
			case (Class39.Enum4)2:
				return this.vmethod_14();
			case (Class39.Enum4)3:
				return this.vmethod_15();
			case (Class39.Enum4)4:
				return this.vmethod_16();
			case (Class39.Enum4)5:
				return this.vmethod_17();
			case (Class39.Enum4)6:
				return this.vmethod_18();
			case (Class39.Enum4)7:
				return this.vmethod_19();
			case (Class39.Enum4)8:
				return this.vmethod_20();
			case (Class39.Enum4)9:
				return this.vmethod_45();
			case (Class39.Enum4)10:
				return this.vmethod_46();
			case (Class39.Enum4)11:
				return this.vmethod_12();
			default:
				throw new Exception(((Class39.Enum8)4).ToString());
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000D9EFC File Offset: 0x000D80FC
		internal override object vmethod_3(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.enum4_0 == (Class39.Enum4)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000D9F9C File Offset: 0x000D819C
		public override Class39.Class52 vmethod_12()
		{
			return new Class39.Class52(this.vmethod_10() ? 1 : 0);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00007B6D File Offset: 0x00005D6D
		internal override bool vmethod_6()
		{
			return this.yQwppAuByG();
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00008216 File Offset: 0x00006416
		public override Class39.Class52 vmethod_13()
		{
			return new Class39.Class52((int)((sbyte)this.double_0), (Class39.Enum4)1);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00008225 File Offset: 0x00006425
		public override Class39.Class52 vmethod_14()
		{
			return new Class39.Class52((uint)((byte)this.double_0), (Class39.Enum4)2);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00008234 File Offset: 0x00006434
		public override Class39.Class52 vmethod_15()
		{
			return new Class39.Class52((int)((short)this.double_0), (Class39.Enum4)3);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00008243 File Offset: 0x00006443
		public override Class39.Class52 vmethod_16()
		{
			return new Class39.Class52((uint)((ushort)this.double_0), (Class39.Enum4)4);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00008252 File Offset: 0x00006452
		public override Class39.Class52 vmethod_17()
		{
			return new Class39.Class52((int)this.double_0, (Class39.Enum4)5);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00008261 File Offset: 0x00006461
		public override Class39.Class52 vmethod_18()
		{
			return new Class39.Class52((uint)this.double_0, (Class39.Enum4)6);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00008270 File Offset: 0x00006470
		public override Class39.Class53 vmethod_19()
		{
			return new Class39.Class53((long)this.double_0, (Class39.Enum4)7);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0000827F File Offset: 0x0000647F
		public override Class39.Class53 vmethod_20()
		{
			return new Class39.Class53((ulong)this.double_0, (Class39.Enum4)8);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00007C23 File Offset: 0x00005E23
		public override Class39.Class52 vmethod_21()
		{
			return this.vmethod_13();
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00007C2B File Offset: 0x00005E2B
		public override Class39.Class52 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00007C33 File Offset: 0x00005E33
		public override Class39.Class52 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00007C3B File Offset: 0x00005E3B
		public override Class39.Class53 vmethod_24()
		{
			return this.vmethod_19();
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00007C43 File Offset: 0x00005E43
		public override Class39.Class52 vmethod_25()
		{
			return this.vmethod_14();
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00007C4B File Offset: 0x00005E4B
		public override Class39.Class52 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00007C53 File Offset: 0x00005E53
		public override Class39.Class52 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00007C5B File Offset: 0x00005E5B
		public override Class39.Class53 vmethod_28()
		{
			return this.vmethod_20();
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0000828E File Offset: 0x0000648E
		public override Class39.Class52 vmethod_29()
		{
			return new Class39.Class52((int)(checked((sbyte)this.double_0)), (Class39.Enum4)1);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0000828E File Offset: 0x0000648E
		public override Class39.Class52 vmethod_30()
		{
			return new Class39.Class52((int)(checked((sbyte)this.double_0)), (Class39.Enum4)1);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0000829D File Offset: 0x0000649D
		public override Class39.Class52 vmethod_31()
		{
			return new Class39.Class52((int)(checked((short)this.double_0)), (Class39.Enum4)3);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0000829D File Offset: 0x0000649D
		public override Class39.Class52 vmethod_32()
		{
			return new Class39.Class52((int)(checked((short)this.double_0)), (Class39.Enum4)3);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x000082AC File Offset: 0x000064AC
		public override Class39.Class52 vmethod_33()
		{
			return new Class39.Class52(checked((int)this.double_0), (Class39.Enum4)5);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000082AC File Offset: 0x000064AC
		public override Class39.Class52 vmethod_34()
		{
			return new Class39.Class52(checked((int)this.double_0), (Class39.Enum4)5);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000082BB File Offset: 0x000064BB
		public override Class39.Class53 vmethod_35()
		{
			return new Class39.Class53(checked((long)this.double_0), (Class39.Enum4)7);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000082BB File Offset: 0x000064BB
		public override Class39.Class53 vmethod_36()
		{
			return new Class39.Class53(checked((long)this.double_0), (Class39.Enum4)7);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000082CA File Offset: 0x000064CA
		public override Class39.Class52 vmethod_37()
		{
			return new Class39.Class52((int)(checked((byte)this.double_0)), (Class39.Enum4)2);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000082CA File Offset: 0x000064CA
		public override Class39.Class52 vmethod_38()
		{
			return new Class39.Class52((int)(checked((byte)this.double_0)), (Class39.Enum4)2);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000082D9 File Offset: 0x000064D9
		public override Class39.Class52 vmethod_39()
		{
			return new Class39.Class52((int)(checked((ushort)this.double_0)), (Class39.Enum4)4);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000082D9 File Offset: 0x000064D9
		public override Class39.Class52 vmethod_40()
		{
			return new Class39.Class52((int)(checked((ushort)this.double_0)), (Class39.Enum4)4);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x000082E8 File Offset: 0x000064E8
		public override Class39.Class52 vmethod_41()
		{
			return new Class39.Class52(checked((uint)this.double_0), (Class39.Enum4)6);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000082E8 File Offset: 0x000064E8
		public override Class39.Class52 vmethod_42()
		{
			return new Class39.Class52(checked((uint)this.double_0), (Class39.Enum4)6);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000082F7 File Offset: 0x000064F7
		public override Class39.Class53 vmethod_43()
		{
			return new Class39.Class53(checked((ulong)this.double_0), (Class39.Enum4)8);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000082F7 File Offset: 0x000064F7
		public override Class39.Class53 vmethod_44()
		{
			return new Class39.Class53(checked((ulong)this.double_0), (Class39.Enum4)8);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00008306 File Offset: 0x00006506
		public override Class39.Class55 vmethod_45()
		{
			return new Class39.Class55((float)this.double_0, (Class39.Enum4)9);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00008316 File Offset: 0x00006516
		public override Class39.Class55 vmethod_46()
		{
			return new Class39.Class55(this.double_0, (Class39.Enum4)10);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00008326 File Offset: 0x00006526
		public override Class39.Class55 zLqpmHyYrP()
		{
			return new Class39.Class55(this.double_0);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000D5500 File Offset: 0x000D3700
		public override Class39.Class54 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_24().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_23().struct14_0.int_0);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000D5544 File Offset: 0x000D3744
		public override Class39.Class54 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_28().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_27().struct14_0.uint_0);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000D5588 File Offset: 0x000D3788
		public override Class39.Class54 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_35().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_33().struct14_0.int_0);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x000D55CC File Offset: 0x000D37CC
		public override Class39.Class54 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_43().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_41().struct14_0.uint_0);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x000D5610 File Offset: 0x000D3810
		public override Class39.Class54 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_36().struct15_0.long_0);
			}
			return new Class39.Class54((long)this.vmethod_34().struct14_0.int_0);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000D5654 File Offset: 0x000D3854
		public override Class39.Class54 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class39.Class54(this.vmethod_44().struct15_0.ulong_0);
			}
			return new Class39.Class54((ulong)this.vmethod_42().struct14_0.uint_0);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000D9FBC File Offset: 0x000D81BC
		public override Class39.Class50 vmethod_53()
		{
			if (this.enum4_0 == (Class39.Enum4)9)
			{
				return new Class39.Class55((float)(-(float)this.double_0));
			}
			return new Class39.Class55(-this.double_0);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x000D9FF0 File Offset: 0x000D81F0
		public override Class39.Class50 Add(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 + ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x000D9FF0 File Offset: 0x000D81F0
		public override Class39.Class50 vmethod_54(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 + ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x000D9FF0 File Offset: 0x000D81F0
		public override Class39.Class50 vmethod_55(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 + ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000DA034 File Offset: 0x000D8234
		public override Class39.Class50 vmethod_56(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 - ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000DA034 File Offset: 0x000D8234
		public override Class39.Class50 vmethod_57(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 - ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000DA034 File Offset: 0x000D8234
		public override Class39.Class50 vmethod_58(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 - ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000DA078 File Offset: 0x000D8278
		public override Class39.Class50 vmethod_59(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4() || !class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 * ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000DA0C4 File Offset: 0x000D82C4
		public override Class39.Class50 vmethod_60(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 * ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000DA0C4 File Offset: 0x000D82C4
		public override Class39.Class50 vmethod_61(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 * ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000DA108 File Offset: 0x000D8308
		public override Class39.Class50 vmethod_62(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 / ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000DA108 File Offset: 0x000D8308
		public override Class39.Class50 vmethod_63(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 / ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000DA14C File Offset: 0x000D834C
		public override Class39.Class50 vmethod_64(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 % ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000DA14C File Offset: 0x000D834C
		public override Class39.Class50 vmethod_65(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return new Class39.Class55(this.double_0 % ((Class39.Class55)class50_0).double_0);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00008334 File Offset: 0x00006534
		public override Class39.Class50 vmethod_66(Class39.Class50 class50_0)
		{
			throw new Class39.Exception1();
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00008334 File Offset: 0x00006534
		public override Class39.Class50 vmethod_67(Class39.Class50 class50_0)
		{
			throw new Class39.Exception1();
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00008334 File Offset: 0x00006534
		public override Class39.Class50 vmethod_68()
		{
			throw new Class39.Exception1();
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00008334 File Offset: 0x00006534
		public override Class39.Class50 igEvpBpxrl(Class39.Class50 class50_0)
		{
			throw new Class39.Exception1();
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00008334 File Offset: 0x00006534
		public override Class39.Class50 vmethod_70(Class39.Class50 class50_0)
		{
			throw new Class39.Exception1();
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00008334 File Offset: 0x00006534
		public override Class39.Class50 vmethod_71(Class39.Class50 class50_0)
		{
			throw new Class39.Exception1();
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00008334 File Offset: 0x00006534
		public override Class39.Class50 vmethod_72(Class39.Class50 class50_0)
		{
			throw new Class39.Exception1();
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00007DA0 File Offset: 0x00005FA0
		internal override Class39.Class50 vmethod_7()
		{
			return this;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000DA190 File Offset: 0x000D8390
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return false;
			}
			if (class50_0.iFavIhWly7())
			{
				return ((Class39.Class56)class50_0).vmethod_4(this);
			}
			Class39.Class50 @class = class50_0.vmethod_7();
			return @class.method_4() && this.double_0 == ((Class39.Class55)@class).double_0;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000DA1E0 File Offset: 0x000D83E0
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			if (class50_0.method_0())
			{
				return false;
			}
			if (!class50_0.iFavIhWly7())
			{
				Class39.Class50 @class = class50_0.vmethod_7();
				return @class.method_4() && this.double_0 != ((Class39.Class55)@class).double_0;
			}
			return ((Class39.Class56)class50_0).vmethod_5(this);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x000DA234 File Offset: 0x000D8434
		public override bool vmethod_73(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 >= ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000DA234 File Offset: 0x000D8434
		public override bool vmethod_74(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 >= ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000DA278 File Offset: 0x000D8478
		public override bool vmethod_75(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 > ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x000DA278 File Offset: 0x000D8478
		public override bool vmethod_76(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 > ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000DA2B8 File Offset: 0x000D84B8
		public override bool vmethod_77(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 <= ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000DA2B8 File Offset: 0x000D84B8
		public override bool vmethod_78(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 <= ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000DA2FC File Offset: 0x000D84FC
		public override bool vmethod_79(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 < ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000DA2FC File Offset: 0x000D84FC
		public override bool vmethod_80(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				class50_0 = class50_0.vmethod_7();
			}
			if (!class50_0.method_4())
			{
				throw new Class39.Exception1();
			}
			return this.double_0 < ((Class39.Class55)class50_0).double_0;
		}

		// Token: 0x04000D5A RID: 3418
		public double double_0;

		// Token: 0x04000D5B RID: 3419
		public Class39.Enum4 enum4_0;
	}

	// Token: 0x02000139 RID: 313
	internal enum Enum4 : byte
	{

	}

	// Token: 0x0200013A RID: 314
	internal enum Enum5 : byte
	{

	}

	// Token: 0x0200013B RID: 315
	private class Exception0 : Exception
	{
		// Token: 0x06001606 RID: 5638 RVA: 0x000DA33C File Offset: 0x000D853C
		public Exception0(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x0200013C RID: 316
	private class Exception1 : Exception
	{
		// Token: 0x06001607 RID: 5639 RVA: 0x000DA350 File Offset: 0x000D8550
		public Exception1()
		{
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000DA33C File Offset: 0x000D853C
		public Exception1(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x0200013D RID: 317
	internal class Class40
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x000DA364 File Offset: 0x000D8564
		public override string ToString()
		{
			object obj = this.enum6_0;
			if (this.object_0 == null)
			{
				return obj.ToString();
			}
			return obj.ToString() + 'H'.ToString() + this.object_0.ToString();
		}

		// Token: 0x04000D5E RID: 3422
		internal Class39.Enum6 enum6_0 = (Class39.Enum6)126;

		// Token: 0x04000D5F RID: 3423
		internal object object_0;
	}

	// Token: 0x0200013E RID: 318
	internal abstract class Class56 : Class39.Class50
	{
		// Token: 0x0600160B RID: 5643 RVA: 0x000D9D30 File Offset: 0x000D7F30
		public Class56()
		{
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0000237A File Offset: 0x0000057A
		internal override bool iFavIhWly7()
		{
			return true;
		}

		// Token: 0x0600160D RID: 5645
		internal abstract IntPtr vmethod_10();

		// Token: 0x0600160E RID: 5646
		internal abstract void vmethod_11(Class39.Class50 class50_0);

		// Token: 0x0600160F RID: 5647 RVA: 0x0000237A File Offset: 0x0000057A
		internal override bool vmethod_0()
		{
			return true;
		}
	}

	// Token: 0x0200013F RID: 319
	internal class Class57 : Class39.Class56
	{
		// Token: 0x06001610 RID: 5648 RVA: 0x000DA3C8 File Offset: 0x000D85C8
		public Class57(int int_1, Class39.Class48 class48_1)
		{
			this.class48_0 = class48_1;
			this.int_0 = int_1;
			this.enum7_0 = (Class39.Enum7)7;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000DA3F0 File Offset: 0x000D85F0
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			if (class50_0 is Class39.Class57)
			{
				this.class48_0 = ((Class39.Class57)class50_0).class48_0;
				this.int_0 = ((Class39.Class57)class50_0).int_0;
				return;
			}
			Class39.Class42 @class = this.class48_0.class45_0.UqaYjxudZI[this.int_0];
			if (class50_0 is Class39.Class56 && (@class.enum4_0 & (Class39.Enum4)226) > (Class39.Enum4)0)
			{
				Class39.Class50 class50_ = (class50_0 as Class39.Class56).vmethod_7();
				this.vmethod_11(class50_);
				return;
			}
			this.vmethod_11(class50_0);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000DA478 File Offset: 0x000D8678
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_11(class50_0);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0000833B File Offset: 0x0000653B
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000DA48C File Offset: 0x000D868C
		internal override void vmethod_11(Class39.Class50 class50_0)
		{
			this.class48_0.class50_1[this.int_0] = class50_0;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000DA4AC File Offset: 0x000D86AC
		internal override object vmethod_3(Type type_0)
		{
			if (this.class48_0.class50_1[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000DA4DC File Offset: 0x000D86DC
		internal override Class39.Class50 vmethod_7()
		{
			if (this.class48_0.class50_1[this.int_0] != null)
			{
				return this.class48_0.class50_1[this.int_0].vmethod_7();
			}
			return new Class39.Class62(null);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00008342 File Offset: 0x00006542
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000DA51C File Offset: 0x000D871C
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			return class50_0.iFavIhWly7() && class50_0 is Class39.Class57 && ((Class39.Class57)class50_0).int_0 == this.int_0;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000DA554 File Offset: 0x000D8754
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			return !class50_0.iFavIhWly7() || !(class50_0 is Class39.Class57) || ((Class39.Class57)class50_0).int_0 != this.int_0;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0000834F File Offset: 0x0000654F
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000D60 RID: 3424
		private Class39.Class48 class48_0;

		// Token: 0x04000D61 RID: 3425
		internal int int_0;
	}

	// Token: 0x02000140 RID: 320
	internal class Class58 : Class39.Class56
	{
		// Token: 0x0600161B RID: 5659 RVA: 0x000DA58C File Offset: 0x000D878C
		public Class58(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum7_0 = (Class39.Enum7)7;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0000833B File Offset: 0x0000653B
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000DA5B4 File Offset: 0x000D87B4
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			if (class50_0 is Class39.Class58)
			{
				this.array_0 = ((Class39.Class58)class50_0).array_0;
				this.int_0 = ((Class39.Class58)class50_0).int_0;
				return;
			}
			this.vmethod_11(class50_0);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000DA478 File Offset: 0x000D8678
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_11(class50_0);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000DA5F4 File Offset: 0x000D87F4
		internal override void vmethod_11(Class39.Class50 class50_0)
		{
			this.array_0.SetValue(class50_0.vmethod_3(null), this.int_0);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0000835C File Offset: 0x0000655C
		internal override object vmethod_3(Type type_0)
		{
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0000836A File Offset: 0x0000656A
		internal override Class39.Class50 vmethod_7()
		{
			return Class39.Class50.smethod_1(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00008342 File Offset: 0x00006542
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000DA61C File Offset: 0x000D881C
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			if (!class50_0.iFavIhWly7())
			{
				return false;
			}
			if (class50_0 is Class39.Class58)
			{
				Class39.Class58 @class = (Class39.Class58)class50_0;
				return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
			}
			return false;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000DA668 File Offset: 0x000D8868
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			if (!class50_0.iFavIhWly7())
			{
				return true;
			}
			if (!(class50_0 is Class39.Class58))
			{
				return true;
			}
			Class39.Class58 @class = (Class39.Class58)class50_0;
			return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0000834F File Offset: 0x0000654F
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000D62 RID: 3426
		private Array array_0;

		// Token: 0x04000D63 RID: 3427
		internal int int_0;
	}

	// Token: 0x02000141 RID: 321
	internal class Class59 : Class39.Class56
	{
		// Token: 0x06001626 RID: 5670 RVA: 0x000DA6B4 File Offset: 0x000D88B4
		public Class59(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum7_0 = (Class39.Enum7)7;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0000833B File Offset: 0x0000653B
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000DA6DC File Offset: 0x000D88DC
		internal override void vmethod_11(Class39.Class50 class50_0)
		{
			if (this.object_0 != null && this.object_0 is Class39.Class50)
			{
				this.fieldInfo_0.SetValue(((Class39.Class50)this.object_0).vmethod_3(null), class50_0.vmethod_3(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class50_0.vmethod_3(null));
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000DA73C File Offset: 0x000D893C
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			if (!(class50_0 is Class39.Class59))
			{
				this.vmethod_11(class50_0);
				return;
			}
			this.fieldInfo_0 = ((Class39.Class59)class50_0).fieldInfo_0;
			this.object_0 = ((Class39.Class59)class50_0).object_0;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000DA478 File Offset: 0x000D8678
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_11(class50_0);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0000835C File Offset: 0x0000655C
		internal override object vmethod_3(Type type_0)
		{
			return this.vmethod_7().vmethod_3(type_0);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000DA77C File Offset: 0x000D897C
		internal override Class39.Class50 vmethod_7()
		{
			if (this.object_0 != null && this.object_0 is Class39.Class50)
			{
				return Class39.Class50.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class39.Class50)this.object_0).vmethod_3(null)));
			}
			return Class39.Class50.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00008342 File Offset: 0x00006542
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000DA7EC File Offset: 0x000D89EC
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			if (!class50_0.iFavIhWly7())
			{
				return false;
			}
			if (class50_0 is Class39.Class59)
			{
				Class39.Class59 @class = (Class39.Class59)class50_0;
				return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
			}
			return false;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000DA83C File Offset: 0x000D8A3C
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			if (!class50_0.iFavIhWly7())
			{
				return true;
			}
			if (!(class50_0 is Class39.Class59))
			{
				return true;
			}
			Class39.Class59 @class = (Class39.Class59)class50_0;
			return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0000834F File Offset: 0x0000654F
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000D64 RID: 3428
		internal FieldInfo fieldInfo_0;

		// Token: 0x04000D65 RID: 3429
		internal object object_0;
	}

	// Token: 0x02000142 RID: 322
	internal class Class60 : Class39.Class56
	{
		// Token: 0x06001631 RID: 5681 RVA: 0x000DA88C File Offset: 0x000D8A8C
		public Class60(int int_1, Class39.Class48 class48_1)
		{
			this.class48_0 = class48_1;
			this.int_0 = int_1;
			this.enum7_0 = (Class39.Enum7)7;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0000833B File Offset: 0x0000653B
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x000DA8B4 File Offset: 0x000D8AB4
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			if (!(class50_0 is Class39.Class60))
			{
				this.vmethod_11(class50_0);
				return;
			}
			this.class48_0 = ((Class39.Class60)class50_0).class48_0;
			this.int_0 = ((Class39.Class60)class50_0).int_0;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000DA478 File Offset: 0x000D8678
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_11(class50_0);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x000DA8F4 File Offset: 0x000D8AF4
		internal override void vmethod_11(Class39.Class50 class50_0)
		{
			this.class48_0.class50_0[this.int_0] = class50_0;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x000DA914 File Offset: 0x000D8B14
		internal override object vmethod_3(Type type_0)
		{
			if (this.class48_0.class50_0[this.int_0] != null)
			{
				return this.vmethod_7().vmethod_3(type_0);
			}
			return null;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x000DA944 File Offset: 0x000D8B44
		internal override Class39.Class50 vmethod_7()
		{
			if (this.class48_0.class50_0[this.int_0] != null)
			{
				return this.class48_0.class50_0[this.int_0].vmethod_7();
			}
			return new Class39.Class62(null);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00008342 File Offset: 0x00006542
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x000DA984 File Offset: 0x000D8B84
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			return class50_0.iFavIhWly7() && class50_0 is Class39.Class60 && ((Class39.Class60)class50_0).int_0 == this.int_0;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000DA9B8 File Offset: 0x000D8BB8
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			return !class50_0.iFavIhWly7() || !(class50_0 is Class39.Class60) || ((Class39.Class60)class50_0).int_0 != this.int_0;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0000834F File Offset: 0x0000654F
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000D66 RID: 3430
		private Class39.Class48 class48_0;

		// Token: 0x04000D67 RID: 3431
		internal int int_0;
	}

	// Token: 0x02000143 RID: 323
	internal class Class61 : Class39.Class56
	{
		// Token: 0x0600163C RID: 5692 RVA: 0x000DA9F0 File Offset: 0x000D8BF0
		public Class61(Class39.Class50 class50_1, Type type_0)
		{
			this.class50_0 = class50_1;
			this.LksYdldxWw = type_0;
			this.enum7_0 = (Class39.Enum7)7;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0000833B File Offset: 0x0000653B
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x000DAA18 File Offset: 0x000D8C18
		internal override void vmethod_9(Class39.Class50 class50_1)
		{
			if (!(class50_1 is Class39.Class61))
			{
				this.class50_0.vmethod_9(class50_1);
				return;
			}
			this.LksYdldxWw = ((Class39.Class61)class50_1).LksYdldxWw;
			this.class50_0 = ((Class39.Class61)class50_1).class50_0;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x000DA478 File Offset: 0x000D8678
		internal override void vmethod_1(Class39.Class50 class50_1)
		{
			this.vmethod_11(class50_1);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000DAA5C File Offset: 0x000D8C5C
		internal override void vmethod_11(Class39.Class50 class50_1)
		{
			this.class50_0 = class50_1;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000DAA70 File Offset: 0x000D8C70
		internal override object vmethod_3(Type type_0)
		{
			if (this.class50_0 == null)
			{
				return new Class39.Class62(null);
			}
			if (!(type_0 == null) && !(type_0 == typeof(object)))
			{
				return this.class50_0.vmethod_3(type_0);
			}
			return this.class50_0.vmethod_3(this.LksYdldxWw);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x000DAAC8 File Offset: 0x000D8CC8
		internal override Class39.Class50 vmethod_7()
		{
			if (this.class50_0 != null)
			{
				return this.class50_0.vmethod_7();
			}
			return new Class39.Class62(null);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00008342 File Offset: 0x00006542
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x000DAAF0 File Offset: 0x000D8CF0
		internal override bool vmethod_4(Class39.Class50 class50_1)
		{
			if (!class50_1.iFavIhWly7())
			{
				return false;
			}
			if (!(class50_1 is Class39.Class61))
			{
				return false;
			}
			Class39.Class61 @class = (Class39.Class61)class50_1;
			if (@class.LksYdldxWw != this.LksYdldxWw)
			{
				return false;
			}
			if (this.class50_0 != null)
			{
				return this.class50_0.vmethod_4(@class.class50_0);
			}
			return @class.class50_0 == null;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x000DAB54 File Offset: 0x000D8D54
		internal override bool vmethod_5(Class39.Class50 class50_1)
		{
			if (!class50_1.iFavIhWly7())
			{
				return true;
			}
			if (!(class50_1 is Class39.Class61))
			{
				return true;
			}
			Class39.Class61 @class = (Class39.Class61)class50_1;
			if (@class.LksYdldxWw != this.LksYdldxWw)
			{
				return true;
			}
			if (this.class50_0 != null)
			{
				return this.class50_0.vmethod_5(@class.class50_0);
			}
			return @class.class50_0 != null;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0000834F File Offset: 0x0000654F
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000D68 RID: 3432
		private Class39.Class50 class50_0;

		// Token: 0x04000D69 RID: 3433
		private Type LksYdldxWw;
	}

	// Token: 0x02000144 RID: 324
	internal class Class41
	{
		// Token: 0x04000D6A RID: 3434
		public int int_0;

		// Token: 0x04000D6B RID: 3435
		public bool bool_0;

		// Token: 0x04000D6C RID: 3436
		public Class39.Enum4 enum4_0;
	}

	// Token: 0x02000145 RID: 325
	internal class Class42
	{
		// Token: 0x04000D6D RID: 3437
		public int int_0;

		// Token: 0x04000D6E RID: 3438
		public Class39.Enum4 enum4_0;

		// Token: 0x04000D6F RID: 3439
		public bool bool_0;

		// Token: 0x04000D70 RID: 3440
		public Type type_0 = typeof(object);
	}

	// Token: 0x02000146 RID: 326
	internal class Class43
	{
		// Token: 0x04000D71 RID: 3441
		public int int_0;

		// Token: 0x04000D72 RID: 3442
		public int int_1;

		// Token: 0x04000D73 RID: 3443
		public Class39.Class44 class44_0;
	}

	// Token: 0x02000147 RID: 327
	internal class Class44
	{
		// Token: 0x04000D74 RID: 3444
		public int int_0;

		// Token: 0x04000D75 RID: 3445
		public int int_1;

		// Token: 0x04000D76 RID: 3446
		public byte byte_0;

		// Token: 0x04000D77 RID: 3447
		public Type type_0;

		// Token: 0x04000D78 RID: 3448
		public int int_2;

		// Token: 0x04000D79 RID: 3449
		public int int_3;
	}

	// Token: 0x02000148 RID: 328
	internal class Class45
	{
		// Token: 0x04000D7A RID: 3450
		internal object object_0;

		// Token: 0x04000D7B RID: 3451
		internal List<Class39.Class40> list_0;

		// Token: 0x04000D7C RID: 3452
		internal Class39.Class41[] class41_0;

		// Token: 0x04000D7D RID: 3453
		internal List<Class39.Class42> UqaYjxudZI;

		// Token: 0x04000D7E RID: 3454
		internal List<Class39.Class43> list_1;
	}

	// Token: 0x02000149 RID: 329
	private class Class46
	{
		// Token: 0x0600164C RID: 5708 RVA: 0x000DABDC File Offset: 0x000D8DDC
		public Class46(FieldInfo fieldInfo_0, int int_1)
		{
			this.object_0 = fieldInfo_0;
			this.int_0 = int_1;
		}

		// Token: 0x04000D7F RID: 3455
		internal object object_0;

		// Token: 0x04000D80 RID: 3456
		internal int int_0;
	}

	// Token: 0x0200014A RID: 330
	private class Class47
	{
		// Token: 0x0600164D RID: 5709 RVA: 0x00008392 File Offset: 0x00006592
		public Class47(MethodBase methodBase_1, List<Class39.Class46> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000DAC00 File Offset: 0x000D8E00
		public Class47(MethodBase methodBase_1, Class39.Class46[] class46_0)
		{
			this.list_0.AddRange(class46_0);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000DAC2C File Offset: 0x000D8E2C
		public override bool Equals(object obj)
		{
			Class39.Class47 @class = obj as Class39.Class47;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].object_0 != @class.list_0[i].object_0)
				{
					return false;
				}
				if (this.list_0[i].int_0 != @class.list_0[i].int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000DACE8 File Offset: 0x000D8EE8
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class39.Class46 @class in this.list_0)
			{
				int num2 = @class.object_0.GetHashCode() + @class.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000DAD60 File Offset: 0x000D8F60
		public Class39.Class46 method_0(int int_0)
		{
			foreach (Class39.Class46 @class in this.list_0)
			{
				if (@class.int_0 == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000DADC4 File Offset: 0x000D8FC4
		public bool method_1(int int_0)
		{
			using (List<Class39.Class46>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.int_0 == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04000D81 RID: 3457
		private List<Class39.Class46> list_0 = new List<Class39.Class46>();

		// Token: 0x04000D82 RID: 3458
		private MethodBase methodBase_0;
	}

	// Token: 0x0200014B RID: 331
	// (Invoke) Token: 0x06001654 RID: 5716
	private delegate object Delegate17(object target, object[] paramters);

	// Token: 0x0200014C RID: 332
	// (Invoke) Token: 0x06001658 RID: 5720
	private delegate object Delegate18(object target);

	// Token: 0x0200014D RID: 333
	// (Invoke) Token: 0x0600165C RID: 5724
	private delegate void Delegate19(IntPtr a, byte b, int c);

	// Token: 0x0200014E RID: 334
	// (Invoke) Token: 0x06001660 RID: 5728
	private delegate void Delegate20(IntPtr s, IntPtr t, uint c);

	// Token: 0x0200014F RID: 335
	internal class Class48
	{
		// Token: 0x06001663 RID: 5731 RVA: 0x000DAE24 File Offset: 0x000D9024
		internal void method_0()
		{
			bool flag = false;
			this.method_2(ref flag);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000DAE3C File Offset: 0x000D903C
		internal void method_1()
		{
			this.class64_0.method_1();
			this.class50_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr hglobal in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(hglobal);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x000DAED0 File Offset: 0x000D90D0
		internal void method_2(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_4(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class39.Class40 @class = this.class45_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_7(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class64_0.method_1();
						int int_ = this.int_1;
						Class39.Class43 class2 = this.method_5(int_, innerException);
						List<Class39.Class43> list = this.method_6(int_, false);
						List<Class39.Class43> list2 = new List<Class39.Class43>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						list2.Sort(new Comparison<Class39.Class43>(Class39.Class48.Class49.<>9.EaecoUppfe));
						Class39.Class43 class3 = null;
						foreach (Class39.Class43 class4 in list2)
						{
							if (class4.class44_0.int_3 != 0)
							{
								this.class64_0.method_2(new Class39.Class62(innerException));
								this.int_1 = class4.class44_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 != null)
						{
							this.int_2 = class3.class44_0.int_0;
							this.method_3(int_, class3.class44_0.int_0);
							if (this.int_2 >= 0)
							{
								this.class64_0.method_2(new Class39.Class62(innerException));
								this.int_1 = this.int_2;
								this.int_0 = this.int_1;
								this.int_2 = -1;
								this.method_0();
							}
							return;
						}
						throw innerException;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class64_0.method_1();
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000DB188 File Offset: 0x000D9388
		internal void method_3(int int_3, int int_4)
		{
			if (this.class45_0.list_1 != null)
			{
				foreach (Class39.Class43 @class in this.class45_0.list_1)
				{
					if ((@class.class44_0.int_3 == 4 || @class.class44_0.int_3 == 2) && @class.class44_0.int_0 >= int_3 && @class.class44_0.int_1 <= int_4)
					{
						this.int_1 = @class.class44_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000DB254 File Offset: 0x000D9454
		internal void method_4(int int_3, int int_4)
		{
			if (this.class45_0.list_1 != null)
			{
				foreach (Class39.Class43 @class in this.class45_0.list_1)
				{
					if (@class.class44_0.int_3 == 2 && @class.class44_0.int_0 >= int_3 && @class.class44_0.int_1 <= int_4)
					{
						this.int_1 = @class.class44_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000DB310 File Offset: 0x000D9510
		internal Class39.Class43 method_5(int int_3, Exception exception_1)
		{
			Class39.Class43 @class = null;
			if (this.class45_0.list_1 != null)
			{
				foreach (Class39.Class43 class2 in this.class45_0.list_1)
				{
					if (class2.class44_0 != null && class2.class44_0.int_3 == 0 && (class2.class44_0.type_0 == exception_1.GetType() || (class2.class44_0.type_0 != null && (class2.class44_0.type_0.FullName == exception_1.GetType().FullName || class2.class44_0.type_0.FullName == typeof(object).FullName || class2.class44_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (class2.class44_0.int_0 < @class.class44_0.int_0)
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000DB478 File Offset: 0x000D9678
		internal List<Class39.Class43> method_6(int int_3, bool bool_4)
		{
			if (this.class45_0.list_1 == null)
			{
				return null;
			}
			List<Class39.Class43> list = new List<Class39.Class43>();
			foreach (Class39.Class43 @class in this.class45_0.list_1)
			{
				if ((@class.class44_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000DB514 File Offset: 0x000D9714
		private unsafe void method_7(Class39.Class40 class40_0)
		{
			switch (class40_0.enum6_0)
			{
			case (Class39.Enum6)0:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_73(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)1:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)2:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class64_0.method_2(class2.vmethod_66(class3));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)3:
			case (Class39.Enum6)89:
			case (Class39.Enum6)96:
			case (Class39.Enum6)108:
			case (Class39.Enum6)144:
			case (Class39.Enum6)174:
				return;
			case (Class39.Enum6)4:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_26());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class52((int)(*(ushort*)((void*)intPtr)), (Class39.Enum4)4));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)5:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_64(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)6:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_78(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)7:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_68());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)8:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_50());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)9:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Array array = (Array)this.class64_0.method_4().vmethod_3(null);
				object obj = array.GetValue(class2.vmethod_17().struct14_0.int_0);
				Type type = array.GetType().GetElementType();
				this.class64_0.method_2(Class39.Class50.smethod_1(type, obj));
				return;
			}
			case (Class39.Enum6)10:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_56(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)11:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_45());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)12:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_77(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)13:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				bool flag = Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_80(@class);
				if (flag)
				{
					this.class64_0.method_2(new Class39.Class52(1));
				}
				else
				{
					this.class64_0.method_2(new Class39.Class52(0));
				}
				if (flag)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)14:
			{
				Class39.Class50 @class = this.class50_1[(int)this.object_0];
				this.class64_0.method_2(@class);
				return;
			}
			case (Class39.Enum6)15:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_22());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class52((int)(*(short*)((void*)intPtr)), (Class39.Enum4)3));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)16:
			{
				int num = (int)this.object_0;
				Type elementType = typeof(Class39).Module.ResolveType(num);
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Array array2 = Array.CreateInstance(elementType, class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(new Class39.Class62(array2));
				return;
			}
			case (Class39.Enum6)17:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class39).Module.ResolveField(num);
				object obj = this.class64_0.method_4().vmethod_3(null);
				this.class64_0.method_2(Class39.Class50.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class39.Enum6)18:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_22());
				return;
			}
			case (Class39.Enum6)19:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_31());
				return;
			}
			case (Class39.Enum6)20:
				throw this.exception_0;
			case (Class39.Enum6)21:
				this.class64_0.method_2(this.class64_0.method_3());
				return;
			case (Class39.Enum6)22:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_72(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)23:
			case (Class39.Enum6)75:
			case (Class39.Enum6)123:
			case (Class39.Enum6)127:
			case (Class39.Enum6)128:
			case (Class39.Enum6)160:
				throw new Class39.Exception1();
			case (Class39.Enum6)24:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class39).Module.ResolveField(num);
				Class39.Class50 class4 = this.class64_0.method_4();
				class4.vmethod_7();
				object obj = class4.vmethod_3(null);
				this.class64_0.method_2(new Class39.Class59(fieldInfo, obj));
				return;
			}
			case (Class39.Enum6)25:
				throw (Exception)this.class64_0.method_4().vmethod_3(null);
			case (Class39.Enum6)26:
			case (Class39.Enum6)36:
			case (Class39.Enum6)47:
			case (Class39.Enum6)73:
			case (Class39.Enum6)117:
			case (Class39.Enum6)118:
			case (Class39.Enum6)168:
			case (Class39.Enum6)173:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Array array3 = (Array)this.class64_0.method_4().vmethod_3(null);
				Type type = array3.GetType().GetElementType();
				array3.SetValue(@class.vmethod_3(type), class2.vmethod_17().struct14_0.int_0);
				return;
			}
			case (Class39.Enum6)27:
				this.bool_2 = true;
				return;
			case (Class39.Enum6)28:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class39).Module.ResolveType(num);
				Class39.Class56 class5 = this.class64_0.method_4() as Class39.Class56;
				if (class5 == null)
				{
					throw new Class39.Exception1();
				}
				object obj = class5.vmethod_3(type);
				Class39.Class50 @class;
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class39.Class48.smethod_9(obj);
					}
					@class = Class39.Class50.smethod_1(type, obj);
				}
				else if (type.IsValueType)
				{
					obj = Activator.CreateInstance(type);
					@class = Class39.Class50.smethod_1(type, obj);
				}
				else
				{
					@class = new Class39.Class62(null);
				}
				this.class64_0.method_2(@class);
				return;
			}
			case (Class39.Enum6)29:
				this.method_12(true);
				return;
			case (Class39.Enum6)30:
				this.method_12(false);
				return;
			case (Class39.Enum6)31:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (!Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_75(@class))
				{
					this.class64_0.method_2(new Class39.Class52(0));
					return;
				}
				this.class64_0.method_2(new Class39.Class52(1));
				return;
			}
			case (Class39.Enum6)32:
			{
				int num = (int)this.object_0;
				this.class50_1[num] = this.method_8(this.class64_0.method_4(), this.class45_0.UqaYjxudZI[num].enum4_0, this.class45_0.UqaYjxudZI[num].bool_0);
				return;
			}
			case (Class39.Enum6)33:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				Class39.Class50 class50_ = this.class64_0.method_4();
				Class39.Class51 class3 = Class39.Class48.smethod_1(class50_);
				if (class3 != null && class2 != null)
				{
					if (class3.vmethod_76(@class))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (@class.vmethod_5(class50_))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)34:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_79(@class))
				{
					this.class64_0.method_2(new Class39.Class52(1));
					return;
				}
				this.class64_0.method_2(new Class39.Class52(0));
				return;
			}
			case (Class39.Enum6)35:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(uint), obj));
				return;
			}
			case (Class39.Enum6)37:
				this.class64_0.method_2(new Class39.Class52((int)this.object_0));
				return;
			case (Class39.Enum6)38:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class39).Module.ResolveField(num);
				object obj = this.class64_0.method_4().vmethod_3(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class39.Enum6)39:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class39.Class51)@class).vmethod_23();
				}
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)40:
			{
				int num = (int)this.object_0;
				if (this.class45_0.object_0.IsStatic)
				{
					this.class50_0[num] = this.method_8(this.class64_0.method_4(), this.class45_0.class41_0[num].enum4_0, false);
					return;
				}
				this.class50_0[num] = this.method_8(this.class64_0.method_4(), this.class45_0.class41_0[num - 1].enum4_0, false);
				return;
			}
			case (Class39.Enum6)41:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_37());
				return;
			}
			case (Class39.Enum6)42:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_32());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)43:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_58(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)44:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(byte), obj));
				return;
			}
			case (Class39.Enum6)45:
				this.class64_0.method_2(new Class39.Class55((float)this.object_0));
				return;
			case (Class39.Enum6)46:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_80(@class))
				{
					this.class64_0.method_2(new Class39.Class52(1));
					return;
				}
				this.class64_0.method_2(new Class39.Class52(0));
				return;
			}
			case (Class39.Enum6)48:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_65(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)49:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_71(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)50:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_21());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)51:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_48());
				return;
			}
			case (Class39.Enum6)52:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class39.Class51)@class).vmethod_21();
				}
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)53:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class39).Module.ResolveField(num);
				this.class64_0.method_2(Class39.Class50.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class39.Enum6)54:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_46());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class55(*(double*)((void*)intPtr), (Class39.Enum4)10));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)55:
			{
				object obj = Class39.Class48.object_2;
				lock (obj)
				{
					object obj2 = this.class64_0.method_4().vmethod_3(null);
					Class39.Class50 @class = null;
					if (Class39.Class48.dictionary_1.TryGetValue(obj2, out @class))
					{
						this.class64_0.method_2(@class);
					}
					else
					{
						this.class64_0.method_2(new Class39.Class62(null));
					}
				}
				return;
			}
			case (Class39.Enum6)56:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class39).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num);
						}
						catch
						{
							obj = module.ResolveMember(num);
						}
					}
				}
				this.class64_0.method_2(new Class39.Class62(obj));
				return;
			}
			case (Class39.Enum6)57:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(long), obj));
				return;
			}
			case (Class39.Enum6)58:
			case (Class39.Enum6)134:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class39).Module.ResolveType(num);
				Class39.Class50 @class = this.class64_0.method_4();
				object obj = @class.vmethod_3(type);
				if (obj == null)
				{
					if (type.IsValueType)
					{
						obj = Activator.CreateInstance(type);
						@class = Class39.Class50.smethod_1(type, obj);
					}
					else
					{
						@class = new Class39.Class62(null);
					}
				}
				else
				{
					if (type.IsValueType)
					{
						obj = Class39.Class48.smethod_9(obj);
					}
					@class = Class39.Class50.smethod_1(type, obj);
				}
				Class39.Class56 class6 = this.class64_0.method_4() as Class39.Class56;
				if (class6 == null)
				{
					throw new Class39.Exception1();
				}
				class6.vmethod_9(@class);
				return;
			}
			case (Class39.Enum6)59:
				this.class64_0.method_4();
				return;
			case (Class39.Enum6)60:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_38());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)61:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_47());
				return;
			}
			case (Class39.Enum6)62:
				this.int_0 = -3;
				if (this.class64_0.method_0() > 0)
				{
					this.class50_2 = this.class64_0.method_4();
				}
				return;
			case (Class39.Enum6)63:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_52());
				return;
			}
			case (Class39.Enum6)64:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_23());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class52(*(int*)((void*)intPtr), (Class39.Enum4)5));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)65:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class39).Module.ResolveField(num);
				object obj = this.class64_0.method_4().vmethod_3(fieldInfo.FieldType);
				Class39.Class50 @class = this.class64_0.method_4();
				object obj2 = @class.vmethod_3(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (@class is Class39.Class57)
					{
						((Class39.Class56)@class).vmethod_11(Class39.Class50.smethod_1(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class39.Enum6)66:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_75(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)67:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_47());
					return;
				}
				if (class2 == null || !class2.method_2())
				{
					throw new Class39.Exception1();
				}
				IntPtr intPtr = ((Class39.Class54)class2).method_7();
				if (IntPtr.Size == 8)
				{
					long num2 = *(long*)((void*)intPtr);
					this.class64_0.method_2(new Class39.Class54(num2, (Class39.Enum4)12));
					return;
				}
				int num = *(int*)((void*)intPtr);
				this.class64_0.method_2(new Class39.Class54((long)num, (Class39.Enum4)12));
				return;
			}
			case (Class39.Enum6)68:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_25());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class52((int)(*(byte*)((void*)intPtr)), (Class39.Enum4)2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)69:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class39.Enum6)70:
			{
				object obj = Class39.Class48.object_2;
				lock (obj)
				{
					Class39.Class50 @class = this.class64_0.method_4();
					object obj2 = this.class64_0.method_4().vmethod_3(null);
					Class39.Class48.dictionary_1[obj2] = @class;
				}
				return;
			}
			case (Class39.Enum6)71:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class39.Enum6)72:
			{
				int[] array4 = (int[])this.object_0;
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				long num2 = class2.vmethod_19().struct15_0.long_0;
				if ((num2 < 0L || class2.method_4()) && IntPtr.Size == 4)
				{
					num2 = (long)((int)num2);
				}
				if (class2.method_1())
				{
					Class39.Class52 class7 = (Class39.Class52)class2;
					if (class7.enum4_0 == (Class39.Enum4)6)
					{
						num2 = (long)((ulong)class7.struct14_0.uint_0);
					}
				}
				if (num2 < (long)array4.Length && num2 >= 0L)
				{
					this.int_0 = array4[(int)(checked((IntPtr)num2))] - 1;
				}
				return;
			}
			case (Class39.Enum6)74:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class39).Module.ResolveField(num);
				this.class64_0.method_2(new Class39.Class59(fieldInfo, null));
				return;
			}
			case (Class39.Enum6)76:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_60(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)77:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_23());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)78:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_43());
				return;
			}
			case (Class39.Enum6)79:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_28());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)80:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class39).Module.ResolveType(num);
				Class39.Class50 @class = this.class64_0.method_4();
				object obj = @class.vmethod_3(null);
				if (obj == null)
				{
					this.class64_0.method_2(new Class39.Class62(null));
					return;
				}
				if (type.IsAssignableFrom(obj.GetType()))
				{
					this.class64_0.method_2(@class);
					return;
				}
				this.class64_0.method_2(new Class39.Class62(null));
				return;
			}
			case (Class39.Enum6)81:
				this.class64_0.method_2(this.class64_0.method_4().vmethod_7());
				return;
			case (Class39.Enum6)82:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class39).Module;
				this.class64_0.method_2(new Class39.Class54(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class39.Enum6)83:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_54(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)84:
			{
				bool flag2 = false;
				Class39.Class50 @class = this.class64_0.method_4();
				flag2 = (@class == null || !@class.vmethod_6());
				if (flag2)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)85:
				this.class64_0.method_2(new Class39.Class60((int)this.object_0, this));
				return;
			case (Class39.Enum6)86:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_61(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)87:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_25());
				return;
			}
			case (Class39.Enum6)88:
			{
				Class39.Class51 class2 = this.class64_0.method_4() as Class39.Class51;
				Class39.Class51 class3 = this.class64_0.method_4() as Class39.Class51;
				IntPtr intPtr = Class39.Class48.smethod_8(this.class64_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class3.vmethod_14().struct14_0.byte_0;
					uint num3 = class2.vmethod_18().struct14_0.uint_0;
					Class39.Class48.smethod_10(intPtr, byte_, (int)num3);
				}
				return;
			}
			case (Class39.Enum6)90:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_29());
				return;
			}
			case (Class39.Enum6)91:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_27());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)92:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.Add(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)93:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class64_0.method_2(class2.vmethod_67(class3));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)94:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_24());
				return;
			}
			case (Class39.Enum6)95:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class39.Class51)@class).vmethod_46();
				}
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)97:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_21());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class52((int)(*(sbyte*)((void*)intPtr)), (Class39.Enum4)1));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)98:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_42());
				return;
			}
			case (Class39.Enum6)99:
			{
				int num = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class39).Module.ResolveMethod(num);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array5 = new object[parameters.Length];
				Class39.Class50[] array6 = new Class39.Class50[parameters.Length];
				List<Class39.Class46> list = null;
				Class39.Class47 class8 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class39.Class50 @class = this.class64_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag2 = false;
					if (type.IsByRef)
					{
						Class39.Class59 class9 = @class as Class39.Class59;
						if (class9 != null)
						{
							if (list == null)
							{
								list = new List<Class39.Class46>();
							}
							list.Add(new Class39.Class46(class9.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class9.object_0;
							if (!(obj2 is Class39.Class50))
							{
								flag2 = true;
							}
							else
							{
								@class = (obj2 as Class39.Class50);
							}
						}
					}
					if (!flag2)
					{
						if (@class != null)
						{
							obj2 = @class.vmethod_3(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (@class is Class39.Class57)
								{
									((Class39.Class56)@class).vmethod_11(Class39.Class50.smethod_1(type, obj2));
								}
							}
						}
					}
					array6[array5.Length - 1 - i] = @class;
					array5[array5.Length - 1 - i] = obj2;
				}
				Class39.Delegate17 @delegate = null;
				if (list != null)
				{
					class8 = new Class39.Class47(constructorInfo, list);
					@delegate = Class39.Class48.smethod_4(constructorInfo, true, class8);
				}
				object obj = null;
				if (@delegate != null)
				{
					obj = @delegate(null, array5);
				}
				else
				{
					obj = constructorInfo.Invoke(array5);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class8 == null || !class8.method_1(j)))
					{
						if (array6[j].method_2())
						{
							((Class39.Class54)array6[j]).method_6(Class39.Class50.smethod_1(parameters[j].ParameterType, array5[j]));
						}
						else if (!(array6[j] is Class39.Class57))
						{
							array6[j].vmethod_9(Class39.Class50.smethod_1(parameters[j].ParameterType, array5[j]));
						}
						else
						{
							array6[j].vmethod_9(Class39.Class50.smethod_1(parameters[j].ParameterType.GetElementType(), array5[j]));
						}
					}
				}
				this.class64_0.method_2(Class39.Class50.smethod_1(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class39.Enum6)100:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_39());
				return;
			}
			case (Class39.Enum6)101:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_33());
				return;
			}
			case (Class39.Enum6)102:
			{
				int num = (int)this.object_0;
				uint num3 = (uint)Class39.Class48.smethod_0(typeof(Class39).Module.ResolveType(num));
				this.class64_0.method_2(new Class39.Class52(num3, (Class39.Enum4)6));
				return;
			}
			case (Class39.Enum6)103:
			{
				Type type = typeof(Class39).Module.ResolveType((int)this.object_0);
				object obj = this.class64_0.method_4().vmethod_3(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class39.Class62 class10 = new Class39.Class62(Class39.Class50.smethod_1(type, Class39.Class48.smethod_9(obj)));
				this.class64_0.method_2(class10);
				return;
			}
			case (Class39.Enum6)104:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class != null && @class.vmethod_6())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)105:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(ushort), obj));
				return;
			}
			case (Class39.Enum6)106:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class39.Class51)@class).vmethod_22();
				}
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)107:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class39.Class51)@class).vmethod_45();
				}
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)109:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class64_0.method_4() as Class39.Class51).vmethod_17().struct14_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class64_0.method_2(new Class39.Class54(intPtr));
				return;
			}
			case (Class39.Enum6)110:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_63(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)111:
			{
				Class39.Class50 class11 = Class39.Class48.smethod_6(this.class64_0.method_4());
				Class39.Class50 @class = Class39.Class48.smethod_6(this.class64_0.method_4());
				if (class11.vmethod_4(@class))
				{
					this.class64_0.method_2(new Class39.Class52(1));
					return;
				}
				this.class64_0.method_2(new Class39.Class52(0));
				return;
			}
			case (Class39.Enum6)112:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.zLqpmHyYrP());
				return;
			}
			case (Class39.Enum6)113:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_49());
				return;
			}
			case (Class39.Enum6)114:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class39).Module.ResolveType(num);
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(type, obj));
				return;
			}
			case (Class39.Enum6)115:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(float), obj));
				return;
			}
			case (Class39.Enum6)116:
				this.class64_0.method_2(new Class39.Class62(null));
				return;
			case (Class39.Enum6)119:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_70(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)120:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (!@class.iFavIhWly7())
				{
					throw new Class39.Exception1();
				}
				object obj = @class.vmethod_3(null);
				if (obj != null)
				{
					@class = Class39.Class50.smethod_1(obj.GetType(), obj);
				}
				else
				{
					@class = new Class39.Class62(null);
				}
				this.class64_0.method_2(@class);
				return;
			}
			case (Class39.Enum6)121:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_59(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)122:
				this.class64_0.method_2(new Class39.Class55((double)this.object_0));
				return;
			case (Class39.Enum6)124:
				return;
			case (Class39.Enum6)125:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class39).Module.ResolveType(num);
				object obj = this.class64_0.method_4().vmethod_7().vmethod_3(type);
				Class39.Class50 @class = Class39.Class50.smethod_1(type, obj);
				this.class64_0.method_2(@class);
				return;
			}
			case (Class39.Enum6)126:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_24());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class53(*(long*)((void*)intPtr), (Class39.Enum4)7));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)129:
			{
				Class39.Class51 class2 = this.class64_0.method_4() as Class39.Class51;
				IntPtr intPtr = Class39.Class48.smethod_8(this.class64_0.method_4());
				IntPtr intPtr2 = Class39.Class48.smethod_8(this.class64_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num3 = class2.vmethod_18().struct14_0.uint_0;
					Class39.Class48.smethod_11(intPtr2, intPtr, num3);
				}
				return;
			}
			case (Class39.Enum6)130:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_34());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)131:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = (Class39.Class51)this.class64_0.method_4();
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_57(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)132:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class39).Module.ResolveType(num);
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				((Array)this.class64_0.method_4().vmethod_3(null)).SetValue(@class.vmethod_3(type), class2.vmethod_17().struct14_0.int_0);
				return;
			}
			case (Class39.Enum6)133:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class39.Class51)@class).vmethod_24();
				}
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)135:
			{
				Class39.Class51 class12 = Class39.Class48.smethod_1(this.class64_0.method_3());
				if (class12 != null)
				{
					Class39.Class55 class13 = class12 as Class39.Class55;
					if (class13 != null)
					{
						if (double.IsNaN(class13.double_0))
						{
							throw new OverflowException(((Class39.Enum8)2).ToString());
						}
						if (double.IsInfinity(class13.double_0))
						{
							throw new OverflowException(((Class39.Enum8)1).ToString());
						}
					}
					return;
				}
				throw new ArithmeticException(((Class39.Enum8)0).ToString());
			}
			case (Class39.Enum6)136:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(int), obj));
				return;
			}
			case (Class39.Enum6)137:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_74(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)138:
			{
				int num = (int)this.object_0;
				MethodBase methodBase = typeof(Class39).Module.ResolveMethod(num);
				Type type = this.class64_0.method_4().vmethod_3(null).GetType();
				List<Type> list2 = new List<Type>();
				do
				{
					list2.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list2.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type2 in list2)
				{
					foreach (MethodInfo methodInfo in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class64_0.method_2(new Class39.Class54(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class39.Enum6)139:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_41());
				return;
			}
			case (Class39.Enum6)140:
			{
				Array array2 = (Array)this.class64_0.method_4().vmethod_3(null);
				this.class64_0.method_2(new Class39.Class52(array2.Length, (Class39.Enum4)5));
				return;
			}
			case (Class39.Enum6)141:
				this.class64_0.method_2(((Class39.Class51)this.class64_0.method_4()).vmethod_53());
				return;
			case (Class39.Enum6)142:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (@class.vmethod_2())
				{
					@class = ((Class39.Class51)@class).vmethod_47();
				}
				this.class64_0.method_4().vmethod_1(@class);
				return;
			}
			case (Class39.Enum6)143:
			{
				if (Class39.list_0.Count != 0)
				{
					this.class64_0.method_2(new Class39.Class63(Class39.list_0[(int)this.object_0]));
					return;
				}
				Module module = typeof(Class39).Module;
				this.class64_0.method_2(new Class39.Class63(module.ResolveString((int)this.object_0 | 1879048192)));
				return;
			}
			case (Class39.Enum6)145:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				Class39.Class50 class50_ = this.class64_0.method_4();
				Class39.Class51 class3 = Class39.Class48.smethod_1(class50_);
				if (class3 != null && class2 != null)
				{
					if (!class3.vmethod_76(@class))
					{
						this.class64_0.method_2(new Class39.Class52(0));
						return;
					}
					this.class64_0.method_2(new Class39.Class52(1));
					return;
				}
				else
				{
					if (!@class.vmethod_5(class50_))
					{
						this.class64_0.method_2(new Class39.Class52(0));
						return;
					}
					this.class64_0.method_2(new Class39.Class52(1));
					return;
				}
				break;
			}
			case (Class39.Enum6)146:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(double), obj));
				return;
			}
			case (Class39.Enum6)147:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null && class3 != null)
				{
					this.class64_0.method_2(class2.igEvpBpxrl(class3));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)148:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(sbyte), obj));
				return;
			}
			case (Class39.Enum6)149:
			{
				int num = (int)this.object_0;
				typeof(Class39).Module.ResolveType(num);
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Array array2 = (Array)this.class64_0.method_4().vmethod_3(null);
				this.class64_0.method_2(new Class39.Class58(class2.vmethod_17().struct14_0.int_0, array2));
				return;
			}
			case (Class39.Enum6)150:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_44());
				return;
			}
			case (Class39.Enum6)151:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_62(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)152:
				this.class64_0.method_2(this.class50_0[(int)this.object_0]);
				return;
			case (Class39.Enum6)153:
			{
				Class39.Class50 class14 = this.class64_0.method_4();
				Class39.Class50 @class = this.class64_0.method_4();
				if (class14.vmethod_4(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)154:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_35());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)155:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_45());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class55(*(float*)((void*)intPtr), (Class39.Enum4)9));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)156:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_46());
				return;
			}
			case (Class39.Enum6)157:
				this.class64_0.method_2(new Class39.Class57((int)this.object_0, this));
				return;
			case (Class39.Enum6)158:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				Class39.Class51 class3 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class3 != null && class2 != null)
				{
					this.class64_0.method_2(class3.vmethod_55(class2));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)159:
				if (this.class64_0.method_4().vmethod_5(this.class64_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class39.Enum6)161:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class39).Module.ResolveType(num);
				Class39.Class56 class15 = this.class64_0.method_4() as Class39.Class56;
				if (class15 == null)
				{
					throw new Class39.Exception1();
				}
				if (type.IsValueType)
				{
					object obj = Activator.CreateInstance(type);
					class15.vmethod_11(Class39.Class50.smethod_1(type, obj));
					return;
				}
				class15.vmethod_11(new Class39.Class62(null));
				return;
			}
			case (Class39.Enum6)162:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_51());
				return;
			}
			case (Class39.Enum6)163:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				Class39.Class51 class2 = Class39.Class48.smethod_1(@class);
				if (@class != null && @class.iFavIhWly7() && class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_27());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class39.Class54)class2).method_7();
					this.class64_0.method_2(new Class39.Class52(*(uint*)((void*)intPtr), (Class39.Enum4)6));
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)164:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_40());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)165:
			{
				Class39.Class50 @class = this.class64_0.method_4();
				if (Class39.Class48.smethod_1(this.class64_0.method_4()).vmethod_79(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class39.Enum6)166:
				this.class64_0.method_2(new Class39.Class53((long)this.object_0));
				return;
			case (Class39.Enum6)167:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 != null)
				{
					this.class64_0.method_2(class2.vmethod_26());
					return;
				}
				throw new Class39.Exception1();
			}
			case (Class39.Enum6)169:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(IntPtr), obj));
				return;
			}
			case (Class39.Enum6)170:
				this.bool_3 = (bool)this.class64_0.method_4().vmethod_3(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class39.Enum6)171:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				object obj = ((Array)this.class64_0.method_4().vmethod_3(null)).GetValue(class2.vmethod_17().struct14_0.int_0);
				this.class64_0.method_2(Class39.Class50.smethod_1(typeof(short), obj));
				return;
			}
			case (Class39.Enum6)172:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_36());
				return;
			}
			case (Class39.Enum6)175:
			{
				Class39.Class51 class2 = Class39.Class48.smethod_1(this.class64_0.method_4());
				if (class2 == null)
				{
					throw new Class39.Exception1();
				}
				this.class64_0.method_2(class2.vmethod_30());
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000DE560 File Offset: 0x000DC760
		private Class39.Class50 method_8(Class39.Class50 class50_3, Class39.Enum4 enum4_0, bool bool_4 = false)
		{
			if (!bool_4 && class50_3.iFavIhWly7())
			{
				class50_3 = class50_3.vmethod_7();
			}
			if (class50_3.method_1())
			{
				return ((Class39.Class52)class50_3).vmethod_11(enum4_0);
			}
			if (class50_3.method_3())
			{
				return ((Class39.Class53)class50_3).vmethod_11(enum4_0);
			}
			if (class50_3.method_4())
			{
				return ((Class39.Class55)class50_3).vmethod_11(enum4_0);
			}
			if (class50_3.method_2())
			{
				return ((Class39.Class54)class50_3).vmethod_11(enum4_0);
			}
			return class50_3;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000083B3 File Offset: 0x000065B3
		private Class39.Class50 method_9(int int_3)
		{
			return this.class50_1[int_3];
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000DE5D8 File Offset: 0x000DC7D8
		private void method_10(int int_3)
		{
			this.method_11(int_3, this.class64_0.method_4());
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x000DE5F8 File Offset: 0x000DC7F8
		private static int smethod_0(Type type_0)
		{
			object obj = Class39.Class48.object_1;
			int result;
			lock (obj)
			{
				if (Class39.Class48.dictionary_0 == null)
				{
					Class39.Class48.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (Class39.Class48.dictionary_0.TryGetValue(type_0, out num))
					{
						result = num;
					}
					else
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class39.Class48.dictionary_0[type_0] = num;
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000DE6C8 File Offset: 0x000DC8C8
		private void method_11(int int_3, Class39.Class50 class50_3)
		{
			this.class50_1[int_3] = this.method_8(class50_3, this.class45_0.UqaYjxudZI[int_3].enum4_0, this.class45_0.UqaYjxudZI[int_3].bool_0);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000D5F44 File Offset: 0x000D4144
		private static Class39.Class51 smethod_1(Class39.Class50 class50_3)
		{
			Class39.Class51 @class = class50_3 as Class39.Class51;
			if (@class == null && class50_3.iFavIhWly7())
			{
				@class = (class50_3.vmethod_7() as Class39.Class51);
			}
			return @class;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x000DE710 File Offset: 0x000DC910
		private void method_12(bool bool_4)
		{
			int metadataToken = (int)this.object_0;
			MethodBase methodBase = typeof(Class39).Module.ResolveMethod(metadataToken);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class39.Class50[] array2 = new Class39.Class50[parameters.Length];
			List<Class39.Class46> list = null;
			Class39.Class47 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class39.Class50 class2 = this.class64_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class39.Class59 class3 = class2 as Class39.Class59;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class39.Class46>();
						}
						list.Add(new Class39.Class46(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (obj is Class39.Class50)
						{
							class2 = (obj as Class39.Class50);
						}
						else
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (class3.fieldInfo_0.IsStatic)
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									else
									{
										obj = Activator.CreateInstance(type);
									}
									if (class2 is Class39.Class57)
									{
										((Class39.Class56)class2).vmethod_11(Class39.Class50.smethod_1(type, obj));
									}
								}
							}
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_3(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class39.Class57)
							{
								((Class39.Class56)class2).vmethod_11(Class39.Class50.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class39.Delegate17 @delegate = null;
			if (list == null)
			{
				if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					@delegate = Class39.Class48.smethod_2(methodBase, bool_4);
				}
			}
			else
			{
				@class = new Class39.Class47(methodBase, list);
				@delegate = Class39.Class48.smethod_3(methodBase, bool_4, @class);
			}
			object obj2 = null;
			Class39.Class50 class4 = null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class64_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_3(methodBase.DeclaringType);
				}
				if (obj2 == null)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class39.Class57)
					{
						((Class39.Class56)class4).vmethod_11(Class39.Class50.smethod_1(type2, obj2));
					}
				}
			}
			object obj3;
			if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class39.Class57)
				{
					((Class39.Class56)class4).vmethod_11(Class39.Class50.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (@delegate == null)
			{
				obj3 = methodBase.Invoke(obj2, array);
			}
			else
			{
				obj3 = @delegate(obj2, array);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (!array2[j].method_2())
					{
						if (!(array2[j] is Class39.Class57))
						{
							array2[j].vmethod_9(Class39.Class50.smethod_1(parameters[j].ParameterType, array[j]));
						}
						else
						{
							array2[j].vmethod_9(Class39.Class50.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
						}
					}
					else
					{
						((Class39.Class54)array2[j]).method_6(Class39.Class50.smethod_1(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class64_0.method_2(Class39.Class50.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000DEB20 File Offset: 0x000DCD20
		private static Class39.Delegate17 smethod_2(object object_6, bool bool_4)
		{
			object obj = Class39.Class48.object_3;
			Class39.Delegate17 result2;
			lock (obj)
			{
				Class39.Delegate17 result = null;
				if (!bool_4)
				{
					if (Class39.Class48.dictionary_3.TryGetValue(object_6, out result))
					{
						return result;
					}
				}
				else if (Class39.Class48.dictionary_2.TryGetValue(object_6, out result))
				{
					return result;
				}
				MethodInfo methodInfo = object_6 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_6.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (object_6.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (object_6.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class39.Class48.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (array[k].IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						ilgenerator.Emit(OpCodes.Castclass, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_6.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (!object_6.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, object_6.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox, object_6.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
				}
				if (bool_4)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Call, object_6 as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(OpCodes.Callvirt, object_6 as ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class39.Class48.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class39.Delegate17 @delegate = (Class39.Delegate17)dynamicMethod.CreateDelegate(typeof(Class39.Delegate17));
				if (!bool_4)
				{
					Class39.Class48.dictionary_3.Add(object_6, @delegate);
				}
				else
				{
					Class39.Class48.dictionary_2.Add(object_6, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000DEFBC File Offset: 0x000DD1BC
		private static Class39.Delegate17 smethod_3(object object_6, bool bool_4, Class39.Class47 class47_0)
		{
			object obj = Class39.Class48.ivacpLcqOn;
			Class39.Delegate17 result2;
			lock (obj)
			{
				Class39.Delegate17 result = null;
				if (!bool_4)
				{
					if (Class39.Class48.dictionary_5.TryGetValue(class47_0, out result))
					{
						return result;
					}
				}
				else if (Class39.Class48.dictionary_4.TryGetValue(class47_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = object_6 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class39), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = object_6.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (object_6.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (class47_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
				}
				if (object_6.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class39.Class48.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class47_0.method_1(k))
					{
						if (array[k].IsValueType)
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
						else if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!object_6.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (object_6.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, object_6.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, object_6.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (class47_0.method_1(l))
					{
						Class39.Class46 @class = class47_0.method_0(l);
						if (@class.object_0.IsStatic)
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
						}
						else if (!@class.object_0.DeclaringType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
						}
					}
					else if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (!bool_4)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Callvirt, object_6 as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(OpCodes.Call, object_6 as ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (class47_0.method_1(m))
						{
							Class39.Class46 class2 = class47_0.method_0(m);
							if (class2.object_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class39.Class48.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
								if (class2.object_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class39.Class48.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.object_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class39.Class48.smethod_5(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class39.Delegate17 @delegate = (Class39.Delegate17)dynamicMethod.CreateDelegate(typeof(Class39.Delegate17));
				if (bool_4)
				{
					Class39.Class48.dictionary_4.Add(class47_0, @delegate);
				}
				else
				{
					Class39.Class48.dictionary_5.Add(class47_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000DF654 File Offset: 0x000DD854
		private static Class39.Delegate17 smethod_4(object object_6, bool bool_4, Class39.Class47 class47_0)
		{
			object obj = Class39.Class48.object_4;
			Class39.Delegate17 result;
			lock (obj)
			{
				Class39.Delegate17 @delegate = null;
				if (Class39.Class48.dictionary_6.TryGetValue(class47_0, out @delegate))
				{
					result = @delegate;
				}
				else
				{
					ConstructorInfo constructorInfo = object_6 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class39), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = object_6.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (!parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType;
						}
						else
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
					}
					int num = array.Length;
					if (object_6.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (class47_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
					}
					if (object_6.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(object_6.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class39.Class48.smethod_5(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class47_0.method_1(k))
						{
							if (!array[k].IsValueType)
							{
								if (array[k] != typeof(object))
								{
									ilgenerator.Emit(OpCodes.Castclass, array[k]);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (!class47_0.method_1(l))
						{
							if (!parameters[l].ParameterType.IsByRef)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
							}
						}
						else
						{
							Class39.Class46 @class = class47_0.method_0(l);
							if (!@class.object_0.IsStatic)
							{
								if (!@class.object_0.DeclaringType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Castclass, @class.object_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Unbox, @class.object_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.object_0);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.object_0);
							}
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, object_6 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (!class47_0.method_1(m))
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class39.Class48.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								Class39.Class46 class2 = class47_0.method_0(m);
								if (class2.object_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class39.Class48.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.object_0);
									if (class2.object_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class39.Class48.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class39.Delegate17 delegate2 = (Class39.Delegate17)dynamicMethod.CreateDelegate(typeof(Class39.Delegate17));
					Class39.Class48.dictionary_6.Add(class47_0, delegate2);
					result = delegate2;
				}
			}
			return result;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x000DFB78 File Offset: 0x000DDD78
		private static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000DFC58 File Offset: 0x000DDE58
		private static Class39.Class50 smethod_6(Class39.Class50 class50_3)
		{
			if (class50_3.vmethod_7().method_0())
			{
				object obj = class50_3.vmethod_3(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class39.Class50 @class = Class39.Class48.smethod_7(Class39.Class50.smethod_1(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class39.Class51;
					}
				}
			}
			return class50_3;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000D5F44 File Offset: 0x000D4144
		private static Class39.Class51 smethod_7(Class39.Class50 class50_3)
		{
			Class39.Class51 @class = class50_3 as Class39.Class51;
			if (@class == null && class50_3.iFavIhWly7())
			{
				@class = (class50_3.vmethod_7() as Class39.Class51);
			}
			return @class;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000DFCBC File Offset: 0x000DDEBC
		private static IntPtr smethod_8(object object_6)
		{
			if (object_6 == null)
			{
				return IntPtr.Zero;
			}
			if (object_6.method_2())
			{
				return ((Class39.Class54)object_6).method_7();
			}
			if (object_6.iFavIhWly7())
			{
				Class39.Class56 @class = (Class39.Class56)object_6;
				IntPtr result;
				try
				{
					result = @class.vmethod_10();
				}
				catch
				{
					goto IL_30;
				}
				return result;
			}
			IL_30:
			object obj = object_6.vmethod_3(typeof(IntPtr));
			if (obj != null && obj.GetType() == typeof(IntPtr))
			{
				return (IntPtr)obj;
			}
			throw new Class39.Exception1();
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000DFD4C File Offset: 0x000DDF4C
		private static object smethod_9(object object_6)
		{
			object obj = Class39.Class48.object_5;
			object result;
			lock (obj)
			{
				if (Class39.Class48.dictionary_7 == null)
				{
					Class39.Class48.dictionary_7 = new Dictionary<Type, Class39.Delegate18>();
				}
				if (object_6 != null)
				{
					try
					{
						Type type = object_6.GetType();
						Class39.Delegate18 @delegate;
						if (!Class39.Class48.dictionary_7.TryGetValue(type, out @delegate))
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
							{
								typeof(object)
							}, true);
							ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
							ilgenerator.Emit(OpCodes.Ldarg_0);
							ilgenerator.Emit(OpCodes.Unbox_Any, type);
							ilgenerator.Emit(OpCodes.Box, type);
							ilgenerator.Emit(OpCodes.Ret);
							Class39.Delegate18 delegate2 = (Class39.Delegate18)dynamicMethod.CreateDelegate(typeof(Class39.Delegate18));
							Class39.Class48.dictionary_7.Add(type, delegate2);
							return delegate2(object_6);
						}
						return @delegate(object_6);
					}
					catch
					{
						return null;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000DFE64 File Offset: 0x000DE064
		private static void smethod_10(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class39.Class48.object_5;
			lock (obj)
			{
				if (Class39.Class48.wRecHpubLl == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class39), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class39.Class48.wRecHpubLl = (Class39.Delegate19)dynamicMethod.CreateDelegate(typeof(Class39.Delegate19));
				}
				Class39.Class48.wRecHpubLl(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x000DFF58 File Offset: 0x000DE158
		private static void smethod_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class39.Class48.delegate20_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class39), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class39.Class48.delegate20_0 = (Class39.Delegate20)dynamicMethod.CreateDelegate(typeof(Class39.Delegate20));
			}
			Class39.Class48.delegate20_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x04000D83 RID: 3459
		internal Class39.Class45 class45_0;

		// Token: 0x04000D84 RID: 3460
		internal Class39.Class50[] class50_0 = new Class39.Class50[0];

		// Token: 0x04000D85 RID: 3461
		internal Class39.Class50[] class50_1 = new Class39.Class50[0];

		// Token: 0x04000D86 RID: 3462
		internal Class39.Class64 class64_0 = new Class39.Class64();

		// Token: 0x04000D87 RID: 3463
		internal Class39.Class50 class50_2;

		// Token: 0x04000D88 RID: 3464
		internal Exception exception_0;

		// Token: 0x04000D89 RID: 3465
		internal List<IntPtr> list_0;

		// Token: 0x04000D8A RID: 3466
		private int int_0;

		// Token: 0x04000D8B RID: 3467
		private int int_1;

		// Token: 0x04000D8C RID: 3468
		private int int_2 = -1;

		// Token: 0x04000D8D RID: 3469
		private object object_0;

		// Token: 0x04000D8E RID: 3470
		private bool bool_0;

		// Token: 0x04000D8F RID: 3471
		private bool bool_1;

		// Token: 0x04000D90 RID: 3472
		private bool bool_2;

		// Token: 0x04000D91 RID: 3473
		private bool bool_3;

		// Token: 0x04000D92 RID: 3474
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x04000D93 RID: 3475
		private static object object_1 = new object();

		// Token: 0x04000D94 RID: 3476
		private static Dictionary<object, Class39.Class50> dictionary_1 = new Dictionary<object, Class39.Class50>();

		// Token: 0x04000D95 RID: 3477
		private static object object_2 = new object();

		// Token: 0x04000D96 RID: 3478
		private static Dictionary<MethodBase, Class39.Delegate17> dictionary_2 = new Dictionary<MethodBase, Class39.Delegate17>();

		// Token: 0x04000D97 RID: 3479
		private static Dictionary<MethodBase, Class39.Delegate17> dictionary_3 = new Dictionary<MethodBase, Class39.Delegate17>();

		// Token: 0x04000D98 RID: 3480
		private static object object_3 = new object();

		// Token: 0x04000D99 RID: 3481
		private static Dictionary<Class39.Class47, Class39.Delegate17> dictionary_4 = new Dictionary<Class39.Class47, Class39.Delegate17>();

		// Token: 0x04000D9A RID: 3482
		private static Dictionary<Class39.Class47, Class39.Delegate17> dictionary_5 = new Dictionary<Class39.Class47, Class39.Delegate17>();

		// Token: 0x04000D9B RID: 3483
		private static object ivacpLcqOn = new object();

		// Token: 0x04000D9C RID: 3484
		private static Dictionary<Class39.Class47, Class39.Delegate17> dictionary_6 = new Dictionary<Class39.Class47, Class39.Delegate17>();

		// Token: 0x04000D9D RID: 3485
		private static object object_4 = new object();

		// Token: 0x04000D9E RID: 3486
		private static Dictionary<Type, Class39.Delegate18> dictionary_7;

		// Token: 0x04000D9F RID: 3487
		private static object object_5 = new object();

		// Token: 0x04000DA0 RID: 3488
		private static Class39.Delegate19 wRecHpubLl;

		// Token: 0x04000DA1 RID: 3489
		private static Class39.Delegate20 delegate20_0;

		// Token: 0x02000150 RID: 336
		[CompilerGenerated]
		[Serializable]
		private sealed class Class49
		{
			// Token: 0x06001680 RID: 5760 RVA: 0x000083BD File Offset: 0x000065BD
			internal int EaecoUppfe(Class39.Class43 x, Class39.Class43 y)
			{
				return x.class44_0.int_0.CompareTo(y.class44_0.int_0);
			}

			// Token: 0x04000DA2 RID: 3490
			public static readonly Class39.Class48.Class49 <>9 = new Class39.Class48.Class49();

			// Token: 0x04000DA3 RID: 3491
			public static Comparison<Class39.Class43> <>9__12_0;
		}
	}

	// Token: 0x02000151 RID: 337
	internal enum Enum6 : byte
	{

	}

	// Token: 0x02000152 RID: 338
	internal enum Enum7 : byte
	{

	}

	// Token: 0x02000153 RID: 339
	internal abstract class Class50
	{
		// Token: 0x06001681 RID: 5761 RVA: 0x00008A5C File Offset: 0x00006C5C
		public Class50()
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000083DA File Offset: 0x000065DA
		internal bool method_0()
		{
			return this.enum7_0 == (Class39.Enum7)0;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000083E5 File Offset: 0x000065E5
		internal bool method_1()
		{
			return this.enum7_0 == (Class39.Enum7)1;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000E0100 File Offset: 0x000DE300
		internal bool method_2()
		{
			return this.enum7_0 == (Class39.Enum7)3 || this.enum7_0 == (Class39.Enum7)4;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000083F0 File Offset: 0x000065F0
		internal bool method_3()
		{
			return this.enum7_0 == (Class39.Enum7)2;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x000083FB File Offset: 0x000065FB
		internal bool method_4()
		{
			return this.enum7_0 == (Class39.Enum7)5;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00008406 File Offset: 0x00006606
		internal bool method_5()
		{
			return this.enum7_0 == (Class39.Enum7)6;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00008411 File Offset: 0x00006611
		internal virtual bool iFavIhWly7()
		{
			return false;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00008411 File Offset: 0x00006611
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x0600168A RID: 5770
		internal abstract void vmethod_1(Class39.Class50 class50_0);

		// Token: 0x0600168B RID: 5771 RVA: 0x00008411 File Offset: 0x00006611
		internal virtual bool vmethod_2()
		{
			return false;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000E0124 File Offset: 0x000DE324
		internal Class50(Class39.Enum7 enum7_1)
		{
			this.enum7_0 = enum7_1;
		}

		// Token: 0x0600168D RID: 5773
		internal abstract object vmethod_3(Type type_0);

		// Token: 0x0600168E RID: 5774
		internal abstract bool vmethod_4(Class39.Class50 class50_0);

		// Token: 0x0600168F RID: 5775
		internal abstract bool vmethod_5(Class39.Class50 class50_0);

		// Token: 0x06001690 RID: 5776
		internal abstract bool vmethod_6();

		// Token: 0x06001691 RID: 5777
		internal abstract Class39.Class50 vmethod_7();

		// Token: 0x06001692 RID: 5778 RVA: 0x00008411 File Offset: 0x00006611
		internal virtual bool vmethod_8()
		{
			return false;
		}

		// Token: 0x06001693 RID: 5779
		internal abstract void vmethod_9(Class39.Class50 class50_0);

		// Token: 0x06001694 RID: 5780 RVA: 0x000E0140 File Offset: 0x000DE340
		internal static Class39.Enum5 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class39.Enum5)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class39.Enum5)14;
			}
			if (type == typeof(byte))
			{
				return (Class39.Enum5)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class39.Enum5)1;
			}
			if (type == typeof(short))
			{
				return (Class39.Enum5)3;
			}
			if (type == typeof(ushort))
			{
				return (Class39.Enum5)4;
			}
			if (type == typeof(int))
			{
				return (Class39.Enum5)5;
			}
			if (type == typeof(uint))
			{
				return (Class39.Enum5)6;
			}
			if (type == typeof(long))
			{
				return (Class39.Enum5)7;
			}
			if (type == typeof(ulong))
			{
				return (Class39.Enum5)8;
			}
			if (type == typeof(float))
			{
				return (Class39.Enum5)9;
			}
			if (type == typeof(double))
			{
				return (Class39.Enum5)10;
			}
			if (type == typeof(bool))
			{
				return (Class39.Enum5)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class39.Enum5)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class39.Enum5)13;
			}
			if (type == typeof(char))
			{
				return (Class39.Enum5)15;
			}
			if (type == typeof(object))
			{
				return (Class39.Enum5)0;
			}
			if (!type.IsEnum)
			{
				return (Class39.Enum5)17;
			}
			return (Class39.Enum5)16;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000E02F0 File Offset: 0x000DE4F0
		internal static Class39.Class50 smethod_1(Type type_0, object object_0)
		{
			Class39.Enum5 @enum = Class39.Class50.smethod_0(type_0);
			Class39.Enum5 enum2 = (Class39.Enum5)18;
			if (object_0 != null)
			{
				enum2 = Class39.Class50.smethod_0(object_0.GetType());
			}
			Class39.Class50 @class = null;
			switch (@enum)
			{
			case (Class39.Enum5)0:
				if (enum2 == (Class39.Enum5)15)
				{
					@class = new Class39.Class62(object_0);
				}
				else
				{
					@class = Class39.Class50.smethod_2(object_0);
				}
				break;
			case (Class39.Enum5)1:
				if (enum2 <= (Class39.Enum5)2)
				{
					if (enum2 == (Class39.Enum5)1)
					{
						@class = new Class39.Class52((int)((sbyte)object_0), (Class39.Enum4)1);
						break;
					}
					if (enum2 == (Class39.Enum5)2)
					{
						@class = new Class39.Class52((int)((sbyte)((byte)object_0)), (Class39.Enum4)1);
						break;
					}
				}
				else if (enum2 != (Class39.Enum5)11)
				{
					if (enum2 == (Class39.Enum5)15)
					{
						@class = new Class39.Class52((int)((sbyte)((char)object_0)), (Class39.Enum4)1);
						break;
					}
				}
				else
				{
					if ((bool)object_0)
					{
						@class = new Class39.Class52(1, (Class39.Enum4)1);
						break;
					}
					@class = new Class39.Class52(0, (Class39.Enum4)1);
					break;
				}
				throw new InvalidCastException();
			case (Class39.Enum5)2:
				if (enum2 <= (Class39.Enum5)2)
				{
					if (enum2 == (Class39.Enum5)1)
					{
						@class = new Class39.Class52((int)((byte)((sbyte)object_0)), (Class39.Enum4)2);
						break;
					}
					if (enum2 == (Class39.Enum5)2)
					{
						@class = new Class39.Class52((int)((byte)object_0), (Class39.Enum4)2);
						break;
					}
				}
				else if (enum2 != (Class39.Enum5)11)
				{
					if (enum2 == (Class39.Enum5)15)
					{
						@class = new Class39.Class52((int)((byte)((char)object_0)), (Class39.Enum4)2);
						break;
					}
				}
				else
				{
					if ((bool)object_0)
					{
						@class = new Class39.Class52(1, (Class39.Enum4)2);
						break;
					}
					@class = new Class39.Class52(0, (Class39.Enum4)2);
					break;
				}
				throw new InvalidCastException();
			case (Class39.Enum5)3:
				if (enum2 != (Class39.Enum5)3)
				{
					if (enum2 != (Class39.Enum5)11)
					{
						if (enum2 != (Class39.Enum5)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class39.Class52((int)((short)((char)object_0)), (Class39.Enum4)3);
					}
					else if ((bool)object_0)
					{
						@class = new Class39.Class52(1, (Class39.Enum4)3);
					}
					else
					{
						@class = new Class39.Class52(0, (Class39.Enum4)3);
					}
				}
				else
				{
					@class = new Class39.Class52((int)((short)object_0), (Class39.Enum4)3);
				}
				break;
			case (Class39.Enum5)4:
				if (enum2 != (Class39.Enum5)4)
				{
					if (enum2 != (Class39.Enum5)11)
					{
						if (enum2 != (Class39.Enum5)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class39.Class52((int)((char)object_0), (Class39.Enum4)4);
					}
					else if ((bool)object_0)
					{
						@class = new Class39.Class52(1, (Class39.Enum4)4);
					}
					else
					{
						@class = new Class39.Class52(0, (Class39.Enum4)4);
					}
				}
				else
				{
					@class = new Class39.Class52((int)((ushort)object_0), (Class39.Enum4)4);
				}
				break;
			case (Class39.Enum5)5:
				if (enum2 != (Class39.Enum5)5)
				{
					if (enum2 != (Class39.Enum5)11)
					{
						if (enum2 != (Class39.Enum5)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class39.Class52((int)((char)object_0), (Class39.Enum4)5);
					}
					else if ((bool)object_0)
					{
						@class = new Class39.Class52(1, (Class39.Enum4)5);
					}
					else
					{
						@class = new Class39.Class52(0, (Class39.Enum4)5);
					}
				}
				else
				{
					@class = new Class39.Class52((int)object_0, (Class39.Enum4)5);
				}
				break;
			case (Class39.Enum5)6:
				if (enum2 != (Class39.Enum5)6)
				{
					if (enum2 != (Class39.Enum5)11)
					{
						if (enum2 != (Class39.Enum5)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class39.Class52((uint)((char)object_0), (Class39.Enum4)6);
					}
					else if (!(bool)object_0)
					{
						@class = new Class39.Class52(0U, (Class39.Enum4)6);
					}
					else
					{
						@class = new Class39.Class52(1U, (Class39.Enum4)6);
					}
				}
				else
				{
					@class = new Class39.Class52((uint)object_0, (Class39.Enum4)6);
				}
				break;
			case (Class39.Enum5)7:
				if (enum2 != (Class39.Enum5)7)
				{
					if (enum2 != (Class39.Enum5)11)
					{
						if (enum2 != (Class39.Enum5)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class39.Class53((long)((ulong)((char)object_0)), (Class39.Enum4)7);
					}
					else if ((bool)object_0)
					{
						@class = new Class39.Class53(1L, (Class39.Enum4)7);
					}
					else
					{
						@class = new Class39.Class53(0L, (Class39.Enum4)7);
					}
				}
				else
				{
					@class = new Class39.Class53((long)object_0, (Class39.Enum4)7);
				}
				break;
			case (Class39.Enum5)8:
				if (enum2 != (Class39.Enum5)8)
				{
					if (enum2 != (Class39.Enum5)11)
					{
						if (enum2 != (Class39.Enum5)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class39.Class53((ulong)((char)object_0), (Class39.Enum4)8);
					}
					else if (!(bool)object_0)
					{
						@class = new Class39.Class53(0UL, (Class39.Enum4)8);
					}
					else
					{
						@class = new Class39.Class53(1UL, (Class39.Enum4)8);
					}
				}
				else
				{
					@class = new Class39.Class53((ulong)object_0, (Class39.Enum4)8);
				}
				break;
			case (Class39.Enum5)9:
				if (enum2 != (Class39.Enum5)9)
				{
					throw new InvalidCastException();
				}
				@class = new Class39.Class55((float)object_0);
				break;
			case (Class39.Enum5)10:
				if (enum2 != (Class39.Enum5)10)
				{
					throw new InvalidCastException();
				}
				@class = new Class39.Class55((double)object_0);
				break;
			case (Class39.Enum5)11:
				switch (enum2)
				{
				case (Class39.Enum5)1:
					@class = new Class39.Class52((sbyte)object_0 != 0);
					goto IL_618;
				case (Class39.Enum5)2:
					@class = new Class39.Class52((byte)object_0 > 0);
					goto IL_618;
				case (Class39.Enum5)3:
					@class = new Class39.Class52((short)object_0 != 0);
					goto IL_618;
				case (Class39.Enum5)4:
					@class = new Class39.Class52((ushort)object_0 > 0);
					goto IL_618;
				case (Class39.Enum5)5:
					@class = new Class39.Class52((int)object_0 != 0);
					goto IL_618;
				case (Class39.Enum5)6:
					@class = new Class39.Class52((uint)object_0 > 0U);
					goto IL_618;
				case (Class39.Enum5)7:
					@class = new Class39.Class52((long)object_0 != 0L);
					goto IL_618;
				case (Class39.Enum5)8:
					@class = new Class39.Class52((ulong)object_0 > 0UL);
					goto IL_618;
				case (Class39.Enum5)9:
				case (Class39.Enum5)10:
				case (Class39.Enum5)12:
				case (Class39.Enum5)13:
				case (Class39.Enum5)14:
				case (Class39.Enum5)15:
				case (Class39.Enum5)16:
					throw new InvalidCastException();
				case (Class39.Enum5)11:
					@class = new Class39.Class52((bool)object_0);
					goto IL_618;
				case (Class39.Enum5)18:
					@class = new Class39.Class52(false);
					goto IL_618;
				}
				@class = new Class39.Class52(object_0 != null);
				break;
			case (Class39.Enum5)12:
				if (enum2 != (Class39.Enum5)12)
				{
					throw new InvalidCastException();
				}
				@class = new Class39.Class54((IntPtr)object_0);
				break;
			case (Class39.Enum5)13:
				if (enum2 != (Class39.Enum5)13)
				{
					throw new InvalidCastException();
				}
				@class = new Class39.Class54((UIntPtr)object_0);
				break;
			case (Class39.Enum5)14:
				@class = new Class39.Class63(object_0 as string);
				break;
			case (Class39.Enum5)15:
				switch (enum2)
				{
				case (Class39.Enum5)1:
					@class = new Class39.Class52((int)((sbyte)object_0), (Class39.Enum4)15);
					break;
				case (Class39.Enum5)2:
					@class = new Class39.Class52((int)((byte)object_0), (Class39.Enum4)15);
					break;
				case (Class39.Enum5)3:
					@class = new Class39.Class52((int)((short)object_0), (Class39.Enum4)15);
					break;
				case (Class39.Enum5)4:
					@class = new Class39.Class52((int)((ushort)object_0), (Class39.Enum4)15);
					break;
				case (Class39.Enum5)5:
					@class = new Class39.Class52((int)object_0, (Class39.Enum4)15);
					break;
				case (Class39.Enum5)6:
					@class = new Class39.Class52((int)((uint)object_0), (Class39.Enum4)15);
					break;
				default:
					if (enum2 != (Class39.Enum5)15)
					{
						throw new InvalidCastException();
					}
					@class = new Class39.Class52((int)((char)object_0), (Class39.Enum4)15);
					break;
				}
				break;
			case (Class39.Enum5)16:
			case (Class39.Enum5)17:
				@class = Class39.Class50.smethod_2(object_0);
				break;
			case (Class39.Enum5)18:
				throw new InvalidCastException();
			}
			IL_618:
			if (type_0.IsByRef)
			{
				@class = new Class39.Class61(@class, type_0.GetElementType());
			}
			return @class;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000E0934 File Offset: 0x000DEB34
		private static Class39.Class50 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object object_ = Convert.ChangeType(object_0, underlyingType);
				Class39.Class50 @class = Class39.Class50.smethod_3(Class39.Class50.smethod_1(underlyingType, object_));
				if (@class != null)
				{
					return @class as Class39.Class51;
				}
			}
			return new Class39.Class62(object_0);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000D5F44 File Offset: 0x000D4144
		private static Class39.Class51 smethod_3(Class39.Class50 class50_0)
		{
			Class39.Class51 @class = class50_0 as Class39.Class51;
			if (@class == null && class50_0.iFavIhWly7())
			{
				@class = (class50_0.vmethod_7() as Class39.Class51);
			}
			return @class;
		}

		// Token: 0x04000DA6 RID: 3494
		internal Class39.Enum7 enum7_0;
	}

	// Token: 0x02000154 RID: 340
	private class Class62 : Class39.Class50
	{
		// Token: 0x06001698 RID: 5784 RVA: 0x000E0984 File Offset: 0x000DEB84
		public Class62() : this(null)
		{
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000E0998 File Offset: 0x000DEB98
		internal override void vmethod_9(Class39.Class50 class50_1)
		{
			if (!(class50_1 is Class39.Class62))
			{
				this.class50_0 = class50_1.vmethod_7();
				return;
			}
			this.class50_0 = ((Class39.Class62)class50_1).class50_0;
			this.type_0 = ((Class39.Class62)class50_1).type_0;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000D4DBC File Offset: 0x000D2FBC
		internal override void vmethod_1(Class39.Class50 class50_1)
		{
			this.vmethod_9(class50_1);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000E09DC File Offset: 0x000DEBDC
		public Class62(object object_0) : base((Class39.Enum7)0)
		{
			this.class50_0 = object_0;
			this.type_0 = null;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000E0A00 File Offset: 0x000DEC00
		public Class62(object object_0, Type type_1) : base((Class39.Enum7)0)
		{
			this.class50_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000E0A24 File Offset: 0x000DEC24
		public override string ToString()
		{
			if (this.class50_0 != null)
			{
				return this.class50_0.ToString();
			}
			return ((Class39.Enum8)5).ToString();
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000E0A54 File Offset: 0x000DEC54
		internal override object vmethod_3(Type type_1)
		{
			if (this.class50_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class50_0 is Class39.Class50))
			{
				object obj = this.class50_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.type_0 != null))
			{
				object obj2 = ((Class39.Class50)this.class50_0).vmethod_3(type_1);
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class39.Class50)this.class50_0).vmethod_3(this.type_0);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000E0C28 File Offset: 0x000DEE28
		internal override bool vmethod_4(Class39.Class50 class50_1)
		{
			if (!class50_1.iFavIhWly7())
			{
				object obj = this.vmethod_3(null);
				object obj2 = class50_1.vmethod_3(null);
				return obj == obj2;
			}
			return ((Class39.Class56)class50_1).vmethod_4(this);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000E0C5C File Offset: 0x000DEE5C
		internal override bool vmethod_5(Class39.Class50 class50_1)
		{
			if (class50_1.iFavIhWly7())
			{
				return ((Class39.Class56)class50_1).vmethod_5(this);
			}
			object obj = this.vmethod_3(null);
			object obj2 = class50_1.vmethod_3(null);
			return obj != obj2;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000E0C94 File Offset: 0x000DEE94
		internal override Class39.Class50 vmethod_7()
		{
			Class39.Class50 @class = this.class50_0 as Class39.Class50;
			if (@class != null)
			{
				return @class.vmethod_7();
			}
			return this;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000E0CB8 File Offset: 0x000DEEB8
		internal override bool vmethod_6()
		{
			if (this.class50_0 != null)
			{
				Class39.Class50 @class = this.class50_0 as Class39.Class50;
				return @class == null || @class.vmethod_3(null) != null;
			}
			return false;
		}

		// Token: 0x04000DA7 RID: 3495
		public Class39.Class50 class50_0;

		// Token: 0x04000DA8 RID: 3496
		public Type type_0;
	}

	// Token: 0x02000155 RID: 341
	private class Class63 : Class39.Class50
	{
		// Token: 0x060016A3 RID: 5795 RVA: 0x000E0CEC File Offset: 0x000DEEEC
		public Class63(string string_1) : base((Class39.Enum7)6)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000E0D08 File Offset: 0x000DEF08
		internal override void vmethod_9(Class39.Class50 class50_0)
		{
			this.string_0 = ((Class39.Class63)class50_0).string_0;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x000D4DBC File Offset: 0x000D2FBC
		internal override void vmethod_1(Class39.Class50 class50_0)
		{
			this.vmethod_9(class50_0);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000E0D28 File Offset: 0x000DEF28
		public override string ToString()
		{
			if (this.string_0 != null)
			{
				return '*'.ToString() + this.string_0 + '*'.ToString();
			}
			return ((Class39.Enum8)5).ToString();
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00008414 File Offset: 0x00006614
		internal override bool vmethod_6()
		{
			return this.string_0 != null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0000841F File Offset: 0x0000661F
		internal override object vmethod_3(Type type_0)
		{
			return this.string_0;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000E0D6C File Offset: 0x000DEF6C
		internal override bool vmethod_4(Class39.Class50 class50_0)
		{
			if (!class50_0.iFavIhWly7())
			{
				object obj = this.string_0;
				object obj2 = class50_0.vmethod_3(null);
				return obj == obj2;
			}
			return ((Class39.Class56)class50_0).vmethod_4(this);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x000E0DA0 File Offset: 0x000DEFA0
		internal override bool vmethod_5(Class39.Class50 class50_0)
		{
			if (class50_0.iFavIhWly7())
			{
				return ((Class39.Class56)class50_0).vmethod_5(this);
			}
			object obj = this.string_0;
			object obj2 = class50_0.vmethod_3(null);
			return obj != obj2;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00007DA0 File Offset: 0x00005FA0
		internal override Class39.Class50 vmethod_7()
		{
			return this;
		}

		// Token: 0x04000DA9 RID: 3497
		public string string_0;
	}

	// Token: 0x02000156 RID: 342
	internal class Class64
	{
		// Token: 0x060016AC RID: 5804 RVA: 0x00008427 File Offset: 0x00006627
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000E0DD8 File Offset: 0x000DEFD8
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x000E0DF0 File Offset: 0x000DEFF0
		public void method_2(Class39.Class50 class50_0)
		{
			this.list_0.Add(class50_0);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00008434 File Offset: 0x00006634
		public Class39.Class50 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0000844E File Offset: 0x0000664E
		public Class39.Class50 method_4()
		{
			Class39.Class50 result = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return result;
		}

		// Token: 0x04000DAA RID: 3498
		private List<Class39.Class50> list_0 = new List<Class39.Class50>();
	}

	// Token: 0x02000157 RID: 343
	internal enum Enum8
	{

	}

	// Token: 0x02000158 RID: 344
	[CompilerGenerated]
	[Serializable]
	private sealed class Class65<T>
	{
		// Token: 0x060016B4 RID: 5812 RVA: 0x000083BD File Offset: 0x000065BD
		internal int method_0(Class39.Class43 x, Class39.Class43 y)
		{
			return x.class44_0.int_0.CompareTo(y.class44_0.int_0);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0000847B File Offset: 0x0000667B
		internal static bool smethod_0()
		{
			return Class39.Class65<T>.object_0 == null;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00008485 File Offset: 0x00006685
		internal static object smethod_1()
		{
			return Class39.Class65<T>.object_0;
		}

		// Token: 0x04000DAC RID: 3500
		public static readonly Class39.Class65<T> <>9 = new Class39.Class65<T>();

		// Token: 0x04000DAD RID: 3501
		public static Comparison<Class39.Class43> <>9__45_0;

		// Token: 0x04000DAE RID: 3502
		internal static object object_0;
	}
}
