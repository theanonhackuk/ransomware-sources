using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

// Token: 0x02000003 RID: 3
[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	// Token: 0x06000002 RID: 2 RVA: 0x0000290C File Offset: 0x00000B0C
	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		List<WeakReference> obj = Form0.list_0;
		checked
		{
			lock (obj)
			{
				if (Form0.list_0.Count == Form0.list_0.Capacity)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Form0.list_0.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Form0.list_0[num4];
						if (weakReference.IsAlive)
						{
							if (num4 != num)
							{
								Form0.list_0[num] = Form0.list_0[num4];
							}
							num++;
						}
						num4++;
					}
					Form0.list_0.RemoveRange(num, Form0.list_0.Count - num);
					Form0.list_0.Capacity = Form0.list_0.Count;
				}
				Form0.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000029F4 File Offset: 0x00000BF4
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			Class9.jBg04XuzOGhUk();
		}
		finally
		{
		}
		Class2.Form0_0.Run(args);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002248 File Offset: 0x00000448
	[DebuggerStepThrough]
	public Form0() : base(AuthenticationMode.Windows)
	{
		Form0.smethod_0(this);
		this.IsSingleInstance = false;
		this.EnableVisualStyles = true;
		this.SaveMySettingsOnExit = true;
		this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002273 File Offset: 0x00000473
	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		this.MainForm = Class2.umavbhbSM.Form1;
	}

	// Token: 0x04000001 RID: 1
	private static List<WeakReference> list_0 = new List<WeakReference>();
}
