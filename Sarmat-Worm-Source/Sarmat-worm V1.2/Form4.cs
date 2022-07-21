using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class Form4 : Form
	{
		// Token: 0x060000DE RID: 222 RVA: 0x000026F4 File Offset: 0x000008F4
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static Form4()
		{
			Class9.jBg04XuzOGhUk();
			Form4.list_0 = new List<WeakReference>();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002705 File Offset: 0x00000905
		[DebuggerNonUserCode]
		public Form4()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			Form4.smethod_0(this);
			this.InitializeComponent();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007B98 File Offset: 0x00005D98
		[DebuggerNonUserCode]
		private static void smethod_0(object object_0)
		{
			List<WeakReference> obj = Form4.list_0;
			checked
			{
				lock (obj)
				{
					if (Form4.list_0.Count == Form4.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form4.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form4.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form4.list_0[num] = Form4.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						Form4.list_0.RemoveRange(num, Form4.list_0.Count - num);
						Form4.list_0.Capacity = Form4.list_0.Count;
					}
					Form4.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000084E0 File Offset: 0x000066E0
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000271E File Offset: 0x0000091E
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000084F8 File Offset: 0x000066F8
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002727 File Offset: 0x00000927
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00008510 File Offset: 0x00006710
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002730 File Offset: 0x00000930
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00008528 File Offset: 0x00006728
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002739 File Offset: 0x00000939
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00008540 File Offset: 0x00006740
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002742 File Offset: 0x00000942
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this.knlWxuajTv;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.knlWxuajTv = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00008558 File Offset: 0x00006758
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000274B File Offset: 0x0000094B
		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LinkLabel1 = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00008570 File Offset: 0x00006770
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002754 File Offset: 0x00000954
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00008588 File Offset: 0x00006788
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000275D File Offset: 0x0000095D
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000085A0 File Offset: 0x000067A0
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002766 File Offset: 0x00000966
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000085B8 File Offset: 0x000067B8
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000276F File Offset: 0x0000096F
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000085D0 File Offset: 0x000067D0
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002778 File Offset: 0x00000978
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000085E8 File Offset: 0x000067E8
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002781 File Offset: 0x00000981
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x04000053 RID: 83
		private static List<WeakReference> list_0;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("Label6")]
		private Label knlWxuajTv;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
