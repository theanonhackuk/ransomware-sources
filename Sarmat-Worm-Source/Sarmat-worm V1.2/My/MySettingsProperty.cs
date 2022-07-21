using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm.My
{
	// Token: 0x02000018 RID: 24
	[DebuggerNonUserCode]
	[StandardModule]
	[CompilerGenerated]
	[HideModuleName]
	internal sealed class MySettingsProperty
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000B7A4 File Offset: 0x000099A4
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
