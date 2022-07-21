using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Ryuk.Net.Properties
{
	// Token: 0x0200000C RID: 12
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00009447 File Offset: 0x00007647
		internal Resources()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009454 File Offset: 0x00007654
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Ryuk.Net.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000094A0 File Offset: 0x000076A0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000094B7 File Offset: 0x000076B7
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000094C0 File Offset: 0x000076C0
		internal static byte[] decrypter
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("decrypter", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000094F0 File Offset: 0x000076F0
		internal static string Source
		{
			get
			{
				return Resources.ResourceManager.GetString("Source", Resources.resourceCulture);
			}
		}

		// Token: 0x04000076 RID: 118
		private static ResourceManager resourceMan;

		// Token: 0x04000077 RID: 119
		private static CultureInfo resourceCulture;
	}
}
