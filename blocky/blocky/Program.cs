using System;
using System.Windows.Forms;

namespace blocky
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002D7E File Offset: 0x00000F7E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
