using System;
using System.Reflection;

// Token: 0x0200001A RID: 26
internal class Class8
{
	// Token: 0x0600013B RID: 315 RVA: 0x0000B7B8 File Offset: 0x000099B8
	internal static void EAu04XuuFtYBm(int typemdt)
	{
		Type type = Class8.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class8.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00002406 File Offset: 0x00000606
	public Class8()
	{
		Class9.jBg04XuzOGhUk();
		base..ctor();
	}

	// Token: 0x0600013D RID: 317 RVA: 0x000028E3 File Offset: 0x00000AE3
	// Note: this type is marked as 'beforefieldinit'.
	static Class8()
	{
		Class9.jBg04XuzOGhUk();
		Class8.module_0 = typeof(Class8).Assembly.ManifestModule;
	}

	// Token: 0x04000080 RID: 128
	internal static Module module_0;

	// Token: 0x0200001B RID: 27
	// (Invoke) Token: 0x0600013F RID: 319
	internal delegate void Delegate0(object o);
}
