using System;
using System.Windows.Forms;

namespace CustomWindowsForm
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000942C File Offset: 0x0000762C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BlackForm());
		}
	}
}
