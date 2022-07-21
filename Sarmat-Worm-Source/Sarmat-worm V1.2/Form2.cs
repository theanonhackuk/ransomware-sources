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
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class Form2 : Form
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00002638 File Offset: 0x00000838
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static Form2()
		{
			Class9.jBg04XuzOGhUk();
			Form2.list_0 = new List<WeakReference>();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006DA0 File Offset: 0x00004FA0
		public Form2()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			base.FormClosing += this.Form2_FormClosing;
			base.Load += this.Form2_Load;
			Form2.smethod_0(this);
			this.int_0 = 0;
			this.InitializeComponent();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006DF4 File Offset: 0x00004FF4
		[DebuggerNonUserCode]
		private static void smethod_0(object object_0)
		{
			List<WeakReference> obj = Form2.list_0;
			checked
			{
				lock (obj)
				{
					if (Form2.list_0.Count == Form2.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form2.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form2.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form2.list_0[num] = Form2.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						Form2.list_0.RemoveRange(num, Form2.list_0.Count - num);
						Form2.list_0.Capacity = Form2.list_0.Count;
					}
					Form2.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00007390 File Offset: 0x00005590
		[DebuggerNonUserCode]
		internal virtual ContextMenuStrip vmethod_0()
		{
			return this.contextMenuStrip_0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002649 File Offset: 0x00000849
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_1(ContextMenuStrip WithEventsValue)
		{
			this.contextMenuStrip_0 = WithEventsValue;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000073A8 File Offset: 0x000055A8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000073C0 File Offset: 0x000055C0
		internal virtual ToolStripMenuItem AddPortToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AddPortToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AddPortToolStripMenuItem_Click);
				if (this._AddPortToolStripMenuItem != null)
				{
					this._AddPortToolStripMenuItem.Click -= value2;
				}
				this._AddPortToolStripMenuItem = value;
				if (this._AddPortToolStripMenuItem != null)
				{
					this._AddPortToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00007418 File Offset: 0x00005618
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00007430 File Offset: 0x00005630
		internal virtual ToolStripMenuItem RemovePortToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemovePortToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemovePortToolStripMenuItem_Click);
				if (this._RemovePortToolStripMenuItem != null)
				{
					this._RemovePortToolStripMenuItem.Click -= value2;
				}
				this._RemovePortToolStripMenuItem = value;
				if (this._RemovePortToolStripMenuItem != null)
				{
					this._RemovePortToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00007488 File Offset: 0x00005688
		[DebuggerNonUserCode]
		internal virtual ImageList vmethod_2()
		{
			return this.imageList_0;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002652 File Offset: 0x00000852
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_3(ImageList WithEventsValue)
		{
			this.imageList_0 = WithEventsValue;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000074A0 File Offset: 0x000056A0
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000265B File Offset: 0x0000085B
		internal virtual ListView ListView1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListView1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListView1 = value;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000074B8 File Offset: 0x000056B8
		[DebuggerNonUserCode]
		internal virtual ColumnHeader vmethod_4()
		{
			return this.columnHeader_0;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002664 File Offset: 0x00000864
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_5(ColumnHeader WithEventsValue)
		{
			this.columnHeader_0 = WithEventsValue;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000074D0 File Offset: 0x000056D0
		[DebuggerNonUserCode]
		internal virtual ColumnHeader vmethod_6()
		{
			return this.columnHeader_1;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000266D File Offset: 0x0000086D
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_7(ColumnHeader WithEventsValue)
		{
			this.columnHeader_1 = WithEventsValue;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000074E8 File Offset: 0x000056E8
		[DebuggerNonUserCode]
		internal virtual ColumnHeader HdJsnjmybB()
		{
			return this.columnHeader_2;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002676 File Offset: 0x00000876
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_8(ColumnHeader WithEventsValue)
		{
			this.columnHeader_2 = WithEventsValue;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00007500 File Offset: 0x00005700
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00007518 File Offset: 0x00005718
		internal virtual ToolStripMenuItem ExitButWillDeleteVictimsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExitButWillDeleteVictimsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExitButWillDeleteVictimsToolStripMenuItem_Click);
				if (this._ExitButWillDeleteVictimsToolStripMenuItem != null)
				{
					this._ExitButWillDeleteVictimsToolStripMenuItem.Click -= value2;
				}
				this._ExitButWillDeleteVictimsToolStripMenuItem = value;
				if (this._ExitButWillDeleteVictimsToolStripMenuItem != null)
				{
					this._ExitButWillDeleteVictimsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000025ED File Offset: 0x000007ED
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002616 File Offset: 0x00000816
		private void AddPortToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class2.umavbhbSM.Form3.Show();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000267F File Offset: 0x0000087F
		private void RemovePortToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ListView1.Items.Remove(this.ListView1.FocusedItem);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00007570 File Offset: 0x00005770
		public void listen()
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			Class2.umavbhbSM.Form1.s.Start(this.port);
			ListViewItem listViewItem = this.ListView1.Items.Add("");
			this.ListView1.Items[this.int_0].ImageIndex = 0;
			listViewItem.SubItems.Add(Conversions.ToString(this.port));
			listViewItem.SubItems.Add("Listening Started");
			this.ListView1.SmallImageList = this.vmethod_2();
			checked
			{
				this.int_0++;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000269C File Offset: 0x0000089C
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Class2.umavbhbSM.Form1.Visible)
			{
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000026AF File Offset: 0x000008AF
		private void ExitButWillDeleteVictimsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0400003F RID: 63
		private static List<WeakReference> list_0;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("AddPortToolStripMenuItem")]
		private ToolStripMenuItem _AddPortToolStripMenuItem;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("RemovePortToolStripMenuItem")]
		private ToolStripMenuItem _RemovePortToolStripMenuItem;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("ImageList2")]
		private ImageList imageList_0;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("ListView1")]
		private ListView _ListView1;

		// Token: 0x04000046 RID: 70
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader columnHeader_0;

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader columnHeader_1;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader columnHeader_2;

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("ExitButWillDeleteVictimsToolStripMenuItem")]
		private ToolStripMenuItem _ExitButWillDeleteVictimsToolStripMenuItem;

		// Token: 0x0400004A RID: 74
		private int int_0;

		// Token: 0x0400004B RID: 75
		public int port;
	}
}
