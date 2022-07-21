using System;

namespace OnyxLocker
{
	// Token: 0x02000007 RID: 7
	internal interface IFileChecker
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20
		string[] TargetFiles { get; }

		// Token: 0x06000015 RID: 21
		bool IsTargetFile(string filePath);
	}
}
