using System;

namespace OnyxLocker
{
	// Token: 0x02000006 RID: 6
	internal interface IEncryptionProvider
	{
		// Token: 0x06000011 RID: 17
		byte[] CreateEncryptionKey();

		// Token: 0x06000012 RID: 18
		byte[] GetEncryptionKey();

		// Token: 0x06000013 RID: 19
		byte[] EncryptBytes(byte[] fileBytes, byte[] encryptionKey);
	}
}
