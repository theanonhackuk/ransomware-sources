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
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class Form3 : Form
	{
		// Token: 0x060000CD RID: 205 RVA: 0x000026B7 File Offset: 0x000008B7
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static Form3()
		{
			Class9.jBg04XuzOGhUk();
			Form3.list_0 = new List<WeakReference>();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000026C8 File Offset: 0x000008C8
		[DebuggerNonUserCode]
		public Form3()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			base.Load += this.Form3_Load;
			Form3.smethod_0(this);
			this.InitializeComponent();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007618 File Offset: 0x00005818
		[DebuggerNonUserCode]
		private static void smethod_0(object object_1)
		{
			List<WeakReference> obj = Form3.list_0;
			checked
			{
				lock (obj)
				{
					if (Form3.list_0.Count == Form3.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form3.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form3.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form3.list_0[num] = Form3.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						Form3.list_0.RemoveRange(num, Form3.list_0.Count - num);
						Form3.list_0.Capacity = Form3.list_0.Count;
					}
					Form3.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_1)));
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00007968 File Offset: 0x00005B68
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00007980 File Offset: 0x00005B80
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000079D8 File Offset: 0x00005BD8
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000079F0 File Offset: 0x00005BF0
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

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007A48 File Offset: 0x00005C48
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00007A60 File Offset: 0x00005C60
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

		// Token: 0x060000D8 RID: 216 RVA: 0x00007AB8 File Offset: 0x00005CB8
		private void Button1_Click(object sender, EventArgs e)
		{
			if (!Versioned.IsNumeric(this.TextBox1.Text))
			{
				Interaction.MsgBox("Enter Your Port", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				this.search();
				if (this.bool_0)
				{
					Interaction.MsgBox("Error Port", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					this.listen();
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007B0C File Offset: 0x00005D0C
		public void listen()
		{
			try
			{
				this.object_0 = int.Parse(this.TextBox1.Text);
				Class2.umavbhbSM.Form2.port = int.Parse(Conversions.ToString(this.object_0));
				Class2.umavbhbSM.Form2.listen();
				this.Hide();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000025ED File Offset: 0x000007ED
		public void search()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000025ED File Offset: 0x000007ED
		private void Form3_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000025ED File Offset: 0x000007ED
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000025ED File Offset: 0x000007ED
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400004C RID: 76
		private static List<WeakReference> list_0;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400004F RID: 79
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000050 RID: 80
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000051 RID: 81
		private object object_0;

		// Token: 0x04000052 RID: 82
		private bool bool_0;
	}
}
