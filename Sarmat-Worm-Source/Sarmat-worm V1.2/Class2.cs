using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BlueWorm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000005 RID: 5
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class Class2
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002292 File Offset: 0x00000492
	// Note: this type is marked as 'beforefieldinit'.
	[DebuggerNonUserCode]
	static Class2()
	{
		Class9.jBg04XuzOGhUk();
		Class2.class5_0 = new Class2.Class5<Class1>();
		Class2.class5_1 = new Class2.Class5<Form0>();
		Class2.rLrYqryvn = new Class2.Class5<User>();
		Class2.class5_2 = new Class2.Class5<Class2.Class3>();
		Class2.class5_3 = new Class2.Class5<Class2.Class4>();
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000008 RID: 8 RVA: 0x00002A30 File Offset: 0x00000C30
	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_0.method_0();
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00002A4C File Offset: 0x00000C4C
	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_1.method_0();
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002A68 File Offset: 0x00000C68
	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.rLrYqryvn.method_0();
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600000B RID: 11 RVA: 0x00002A84 File Offset: 0x00000C84
	[HelpKeyword("My.Forms")]
	internal static Class2.Class3 umavbhbSM
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_2.method_0();
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000C RID: 12 RVA: 0x00002AA0 File Offset: 0x00000CA0
	[HelpKeyword("My.WebServices")]
	internal static Class2.Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return Class2.class5_3.method_0();
		}
	}

	// Token: 0x04000002 RID: 2
	private static readonly Class2.Class5<Class1> class5_0;

	// Token: 0x04000003 RID: 3
	private static readonly Class2.Class5<Form0> class5_1;

	// Token: 0x04000004 RID: 4
	private static readonly Class2.Class5<User> rLrYqryvn;

	// Token: 0x04000005 RID: 5
	private static Class2.Class5<Class2.Class3> class5_2;

	// Token: 0x04000006 RID: 6
	private static readonly Class2.Class5<Class2.Class4> class5_3;

	// Token: 0x02000006 RID: 6
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002ABC File Offset: 0x00000CBC
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000022CB File Offset: 0x000004CB
		public Form1 Form1
		{
			[DebuggerNonUserCode]
			get
			{
				this.form1_0 = Class2.Class3.smethod_0<Form1>(this.form1_0);
				return this.form1_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form1>(ref this.form1_0);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002AE4 File Offset: 0x00000CE4
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000022F8 File Offset: 0x000004F8
		public Form2 Form2
		{
			[DebuggerNonUserCode]
			get
			{
				this.form2_0 = Class2.Class3.smethod_0<Form2>(this.form2_0);
				return this.form2_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form2_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form2>(ref this.form2_0);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002B0C File Offset: 0x00000D0C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002325 File Offset: 0x00000525
		public Form3 Form3
		{
			[DebuggerNonUserCode]
			get
			{
				this.form3_0 = Class2.Class3.smethod_0<Form3>(this.form3_0);
				return this.form3_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form3_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form3>(ref this.form3_0);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002B34 File Offset: 0x00000D34
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002352 File Offset: 0x00000552
		public Form4 Form4
		{
			[DebuggerNonUserCode]
			get
			{
				this.form4_0 = Class2.Class3.smethod_0<Form4>(this.form4_0);
				return this.form4_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form4_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form4>(ref this.form4_0);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002B5C File Offset: 0x00000D5C
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000237F File Offset: 0x0000057F
		public Form5 Form5
		{
			[DebuggerNonUserCode]
			get
			{
				this.form5_0 = Class2.Class3.smethod_0<Form5>(this.form5_0);
				return this.form5_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form5_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form5>(ref this.form5_0);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002B84 File Offset: 0x00000D84
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000023AC File Offset: 0x000005AC
		public Form6 Form6
		{
			[DebuggerNonUserCode]
			get
			{
				this.form6_0 = Class2.Class3.smethod_0<Form6>(this.form6_0);
				return this.form6_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form6_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form6>(ref this.form6_0);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002BAC File Offset: 0x00000DAC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000023D9 File Offset: 0x000005D9
		public Form7 Form7
		{
			[DebuggerNonUserCode]
			get
			{
				this.form7_0 = Class2.Class3.smethod_0<Form7>(this.form7_0);
				return this.form7_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form7_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form7>(ref this.form7_0);
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002BD4 File Offset: 0x00000DD4
		[DebuggerHidden]
		private static T smethod_0<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (Class2.Class3.hashtable_0 != null)
				{
					if (Class2.Class3.hashtable_0.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					Class2.Class3.hashtable_0 = new Hashtable();
				}
				Class2.Class3.hashtable_0.Add(typeof(T), null);
				try
				{
					return Activator.CreateInstance<T>();
				}
				catch (TargetInvocationException ex) when (ex.InnerException != null)
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
					{
						ex.InnerException.Message
					});
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					Class2.Class3.hashtable_0.Remove(typeof(T));
				}
			}
			return Instance;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			gparam_0.Dispose();
			gparam_0 = default(T);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002406 File Offset: 0x00000606
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002413 File Offset: 0x00000613
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002D10 File Offset: 0x00000F10
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D28 File Offset: 0x00000F28
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class2.Class3);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D44 File Offset: 0x00000F44
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x04000007 RID: 7
		public Form1 form1_0;

		// Token: 0x04000008 RID: 8
		public Form2 form2_0;

		// Token: 0x04000009 RID: 9
		public Form3 form3_0;

		// Token: 0x0400000A RID: 10
		public Form4 form4_0;

		// Token: 0x0400000B RID: 11
		public Form5 form5_0;

		// Token: 0x0400000C RID: 12
		public Form6 form6_0;

		// Token: 0x0400000D RID: 13
		public Form7 form7_0;

		// Token: 0x0400000E RID: 14
		[ThreadStatic]
		private static Hashtable hashtable_0;
	}

	// Token: 0x02000007 RID: 7
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002413 File Offset: 0x00000613
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D10 File Offset: 0x00000F10
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D5C File Offset: 0x00000F5C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class2.Class4);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D44 File Offset: 0x00000F44
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002D78 File Offset: 0x00000F78
		[DebuggerHidden]
		private static T smethod_0<T>(T instance) where T : new()
		{
			T result;
			if (instance == null)
			{
				result = Activator.CreateInstance<T>();
			}
			else
			{
				result = instance;
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002D9C File Offset: 0x00000F9C
		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002406 File Offset: 0x00000606
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
		}
	}

	// Token: 0x02000008 RID: 8
	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<T> where T : new()
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002DB8 File Offset: 0x00000FB8
		[DebuggerHidden]
		internal T method_0()
		{
			if (Class2.Class5<T>.gparam_0 == null)
			{
				Class2.Class5<T>.gparam_0 = Activator.CreateInstance<T>();
			}
			return Class2.Class5<T>.gparam_0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002406 File Offset: 0x00000606
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
		}

		// Token: 0x0400000F RID: 15
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;
	}
}
