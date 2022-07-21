using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000016 RID: 22
[StandardModule]
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[HideModuleName]
internal sealed class Class7
{
	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000131 RID: 305 RVA: 0x0000B67C File Offset: 0x0000987C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(Class7.resourceManager_0, null))
			{
				ResourceManager resourceManager = new ResourceManager("BlueWorm.Resources", typeof(Class7).Assembly);
				Class7.resourceManager_0 = resourceManager;
			}
			return Class7.resourceManager_0;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000132 RID: 306 RVA: 0x0000B6C0 File Offset: 0x000098C0
	// (set) Token: 0x06000133 RID: 307 RVA: 0x0000288C File Offset: 0x00000A8C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class7.OokoxFxnhf;
		}
		set
		{
			Class7.OokoxFxnhf = value;
		}
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000B6D4 File Offset: 0x000098D4
	internal static byte[] smethod_0()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Class7.ResourceManager_0.GetObject("Saramat", Class7.OokoxFxnhf));
		return (byte[])objectValue;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0000B704 File Offset: 0x00009904
	internal static byte[] smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Class7.ResourceManager_0.GetObject("stub", Class7.OokoxFxnhf));
		return (byte[])objectValue;
	}

	// Token: 0x0400007B RID: 123
	private static ResourceManager resourceManager_0;

	// Token: 0x0400007C RID: 124
	private static CultureInfo OokoxFxnhf;
}
