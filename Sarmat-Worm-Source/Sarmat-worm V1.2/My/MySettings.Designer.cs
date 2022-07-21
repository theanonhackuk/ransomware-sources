using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm.My
{
	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000138 RID: 312 RVA: 0x000028CB File Offset: 0x00000ACB
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (Class2.Form0_0.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000B734 File Offset: 0x00009934
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							Class2.Form0_0.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x0400007D RID: 125
		private static MySettings defaultInstance;

		// Token: 0x0400007E RID: 126
		private static bool addedHandler;

		// Token: 0x0400007F RID: 127
		private static object addedHandlerLockObject;
	}
}
