using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OnyxLocker.Classes
{
	// Token: 0x0200000B RID: 11
	internal class FolderBrowser : IDriveExplorer
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000028F4 File Offset: 0x00000AF4
		public List<string> GetStartingFolders()
		{
			List<string> list = (from drive in DriveInfo.GetDrives()
			select drive.Name).ToList<string>();
			list.AddRange(this.GetSpecialFolders());
			return list;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002944 File Offset: 0x00000B44
		private List<string> GetSpecialFolders()
		{
			return new List<string>
			{
				Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
				Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
				Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
				Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
			};
		}
	}
}
