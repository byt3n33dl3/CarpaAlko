using System;
using System.Reflection;

// Token: 0x0200011F RID: 287
internal class Class2
{
	// Token: 0x06001360 RID: 4960 RVA: 0x000D14FC File Offset: 0x000CF6FC
	internal static void smethod_0(int typemdt)
	{
		Type type = Class2.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class2.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x04000D11 RID: 3345
	internal static Module module_0 = typeof(Class2).Assembly.ManifestModule;

	// Token: 0x02000120 RID: 288
	// (Invoke) Token: 0x06001364 RID: 4964
	internal delegate void Delegate7(object o);
}
