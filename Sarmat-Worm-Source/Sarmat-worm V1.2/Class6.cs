using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000015 RID: 21
[StandardModule]
internal sealed class Class6
{
	// Token: 0x0600012D RID: 301 RVA: 0x00009838 File Offset: 0x00007A38
	public static byte[] smethod_0(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00009854 File Offset: 0x00007A54
	public static string smethod_1(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00009870 File Offset: 0x00007A70
	public static Array smethod_2(byte[] byte_0, string string_0)
	{
		List<byte[]> list = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream();
		string[] array = Strings.Split(Class6.smethod_1(byte_0), string_0, -1, CompareMethod.Binary);
		memoryStream.Write(byte_0, 0, array[0].Length);
		checked
		{
			memoryStream2.Write(byte_0, array[0].Length + string_0.Length, byte_0.Length - (array[0].Length + string_0.Length));
			list.Add(memoryStream.ToArray());
			list.Add(memoryStream2.ToArray());
			memoryStream.Dispose();
			memoryStream2.Dispose();
			return list.ToArray();
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00009908 File Offset: 0x00007B08
	public static int smethod_3(string string_0)
	{
		int result;
		if (Operators.CompareString(string_0, Strings.UCase("Afghanistan"), false) == 0)
		{
			result = 1;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Albania"), false) == 0)
		{
			result = 2;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Algeria"), false) == 0)
		{
			result = 3;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("American Samoa"), false) == 0)
		{
			result = 4;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Andorra"), false) == 0)
		{
			result = 5;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Angola"), false) == 0)
		{
			result = 6;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Anguilla"), false) == 0)
		{
			result = 7;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Antigua and Barbuda"), false) == 0)
		{
			result = 8;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Argentina"), false) == 0)
		{
			result = 9;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Armenia"), false) == 0)
		{
			result = 10;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Aruba"), false) == 0)
		{
			result = 11;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Australia"), false) == 0)
		{
			result = 12;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Austria"), false) == 0)
		{
			result = 13;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Azerbaijan"), false) == 0)
		{
			result = 14;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bahamas"), false) == 0)
		{
			result = 15;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bahrain"), false) == 0)
		{
			result = 16;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bangladesh"), false) == 0)
		{
			result = 17;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Barbados"), false) == 0)
		{
			result = 18;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Belarus"), false) == 0)
		{
			result = 19;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Belgium"), false) == 0)
		{
			result = 20;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Belize"), false) == 0)
		{
			result = 21;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Benin"), false) == 0)
		{
			result = 22;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bermuda"), false) == 0)
		{
			result = 23;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bhutan"), false) == 0)
		{
			result = 24;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bolivia"), false) == 0)
		{
			result = 25;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bosnia & Herzegovina"), false) == 0)
		{
			result = 26;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Botswana"), false) == 0)
		{
			result = 27;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bouvet Island"), false) == 0)
		{
			result = 28;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Brazil"), false) == 0)
		{
			result = 29;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("British Indian Ocean Territory"), false) == 0)
		{
			result = 30;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("British Virgin Islands"), false) == 0)
		{
			result = 31;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Brunei"), false) == 0)
		{
			result = 32;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Bulgaria"), false) == 0)
		{
			result = 33;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Burkina Faso"), false) == 0)
		{
			result = 34;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Burundi"), false) == 0)
		{
			result = 35;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Cambodia"), false) == 0)
		{
			result = 36;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Cameroon"), false) == 0)
		{
			result = 37;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Canada"), false) == 0)
		{
			result = 38;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Cape Verde"), false) == 0)
		{
			result = 39;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("catalonia"), false) == 0)
		{
			result = 40;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Cayman Islands"), false) == 0)
		{
			result = 41;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Central African Republic"), false) == 0)
		{
			result = 42;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Chad"), false) == 0)
		{
			result = 43;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Chile"), false) == 0)
		{
			result = 44;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("China"), false) == 0)
		{
			result = 45;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Christmas Islands"), false) == 0)
		{
			result = 46;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Cocos (Keeling) Islands"), false) == 0)
		{
			result = 47;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Colombia"), false) == 0)
		{
			result = 48;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Comoras"), false) == 0)
		{
			result = 49;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Congo, the Democratic Republic of the"), false) == 0)
		{
			result = 50;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Costa Rica"), false) == 0)
		{
			result = 51;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Croatia"), false) == 0)
		{
			result = 52;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Cuba"), false) == 0)
		{
			result = 53;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Cyprus"), false) == 0)
		{
			result = 54;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Czech Republic"), false) == 0)
		{
			result = 55;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Denmark"), false) == 0)
		{
			result = 56;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Djibouti"), false) == 0)
		{
			result = 57;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Dominica"), false) == 0)
		{
			result = 58;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Dominican Republic"), false) == 0)
		{
			result = 59;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Ecuador"), false) == 0)
		{
			result = 60;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Egypt"), false) == 0)
		{
			result = 61;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("El Salvador"), false) == 0)
		{
			result = 62;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("England"), false) == 0)
		{
			result = 63;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Equatorial Guinea"), false) == 0)
		{
			result = 64;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Eritrea"), false) == 0)
		{
			result = 65;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Estonia"), false) == 0)
		{
			result = 66;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Ethiopia"), false) == 0)
		{
			result = 67;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("europeanunion"), false) == 0)
		{
			result = 68;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Falkland Islands (Malvinas)"), false) == 0)
		{
			result = 69;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Faroe Islands"), false) == 0)
		{
			result = 70;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Fiji"), false) == 0)
		{
			result = 71;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Finland"), false) == 0)
		{
			result = 72;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("France"), false) == 0)
		{
			result = 73;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("French Guiana"), false) == 0)
		{
			result = 74;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("French Polynesia"), false) == 0)
		{
			result = 75;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("French Southern Territories"), false) == 0)
		{
			result = 76;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Gabon"), false) == 0)
		{
			result = 77;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Gambia"), false) == 0)
		{
			result = 78;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Georgia"), false) == 0)
		{
			result = 79;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Germany"), false) == 0)
		{
			result = 80;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Ghana"), false) == 0)
		{
			result = 81;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Gibraltar"), false) == 0)
		{
			result = 82;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Greece"), false) == 0)
		{
			result = 83;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Greenland"), false) == 0)
		{
			result = 84;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Grenada"), false) == 0)
		{
			result = 85;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Guadeloupe"), false) == 0)
		{
			result = 86;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Guam"), false) == 0)
		{
			result = 87;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Guatemala"), false) == 0)
		{
			result = 88;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Guinea"), false) == 0)
		{
			result = 89;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Guinea-Bissau"), false) == 0)
		{
			result = 90;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Guyana"), false) == 0)
		{
			result = 91;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Haiti"), false) == 0)
		{
			result = 92;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Heard Island and McDonald Islands"), false) == 0)
		{
			result = 93;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Honduras"), false) == 0)
		{
			result = 94;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Hong Kong"), false) == 0)
		{
			result = 95;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Hungary"), false) == 0)
		{
			result = 96;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Iceland"), false) == 0)
		{
			result = 97;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("India"), false) == 0)
		{
			result = 98;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Indonesia"), false) == 0)
		{
			result = 99;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Iran, Islamic Republic of"), false) == 0)
		{
			result = 100;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Iraq"), false) == 0)
		{
			result = 101;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Ireland"), false) == 0)
		{
			result = 102;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Israel"), false) == 0)
		{
			result = 103;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Italy"), false) == 0)
		{
			result = 104;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Jamaica"), false) == 0)
		{
			result = 105;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Japan"), false) == 0)
		{
			result = 106;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Jordan"), false) == 0)
		{
			result = 107;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Kazakhstan"), false) == 0)
		{
			result = 108;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Kenya"), false) == 0)
		{
			result = 109;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Kiribati"), false) == 0)
		{
			result = 110;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Korea, Democratic People's Republic of"), false) == 0)
		{
			result = 111;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Korea, Republic of"), false) == 0)
		{
			result = 112;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Kuwait"), false) == 0)
		{
			result = 113;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Kyrgyzstan"), false) == 0)
		{
			result = 114;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Laos"), false) == 0)
		{
			result = 115;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Latvia"), false) == 0)
		{
			result = 116;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Lebanon"), false) == 0)
		{
			result = 117;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Lesotho"), false) == 0)
		{
			result = 118;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Liberia"), false) == 0)
		{
			result = 119;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Libya"), false) == 0)
		{
			result = 120;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Liechtenstein"), false) == 0)
		{
			result = 121;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Lithuania"), false) == 0)
		{
			result = 122;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Luxembourg"), false) == 0)
		{
			result = 123;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Macao"), false) == 0)
		{
			result = 124;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Macedonia"), false) == 0)
		{
			result = 125;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Madagascar"), false) == 0)
		{
			result = 126;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Malawi"), false) == 0)
		{
			result = 127;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Malaysia"), false) == 0)
		{
			result = 128;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Maldives"), false) == 0)
		{
			result = 129;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Mali"), false) == 0)
		{
			result = 130;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Malta"), false) == 0)
		{
			result = 131;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Marshall Islands"), false) == 0)
		{
			result = 132;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Martinique"), false) == 0)
		{
			result = 133;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Mauritania"), false) == 0)
		{
			result = 134;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Mauritius"), false) == 0)
		{
			result = 135;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Mayotte"), false) == 0)
		{
			result = 136;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Mexico"), false) == 0)
		{
			result = 137;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Micronesia, Federated States of"), false) == 0)
		{
			result = 138;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Moldava"), false) == 0)
		{
			result = 139;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Monaco"), false) == 0)
		{
			result = 140;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Mongolia"), false) == 0)
		{
			result = 141;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Montenegro"), false) == 0)
		{
			result = 142;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Montserrat"), false) == 0)
		{
			result = 143;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Morocco"), false) == 0)
		{
			result = 144;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Mozambique"), false) == 0)
		{
			result = 145;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Myanmar"), false) == 0)
		{
			result = 146;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Namibia"), false) == 0)
		{
			result = 147;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Nauru"), false) == 0)
		{
			result = 148;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Nepal"), false) == 0)
		{
			result = 149;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Netherlands Antilles"), false) == 0)
		{
			result = 150;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Netherlands, The"), false) == 0)
		{
			result = 151;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("New Caledonia"), false) == 0)
		{
			result = 152;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("New Zealand"), false) == 0)
		{
			result = 153;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Nicaragua"), false) == 0)
		{
			result = 154;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Niger"), false) == 0)
		{
			result = 155;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Nigeria"), false) == 0)
		{
			result = 156;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Niue"), false) == 0)
		{
			result = 157;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Norfolk Island"), false) == 0)
		{
			result = 158;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Northern Mariana Islands"), false) == 0)
		{
			result = 159;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Norway"), false) == 0)
		{
			result = 160;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Oman"), false) == 0)
		{
			result = 161;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Pakistan"), false) == 0)
		{
			result = 162;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Palau"), false) == 0)
		{
			result = 163;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Panama"), false) == 0)
		{
			result = 164;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Papua New Guinea"), false) == 0)
		{
			result = 165;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Paraguay"), false) == 0)
		{
			result = 166;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Peru"), false) == 0)
		{
			result = 167;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Phillipines"), false) == 0)
		{
			result = 168;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Pitcairn Islands"), false) == 0)
		{
			result = 169;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Poland"), false) == 0)
		{
			result = 170;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Portugal"), false) == 0)
		{
			result = 171;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("ps"), false) == 0)
		{
			result = 172;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Puerto Rico"), false) == 0)
		{
			result = 173;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Qatar"), false) == 0)
		{
			result = 174;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Reunion"), false) == 0)
		{
			result = 175;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Romania"), false) == 0)
		{
			result = 176;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("rs"), false) == 0)
		{
			result = 177;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Russian Federation"), false) == 0)
		{
			result = 178;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Rwanda"), false) == 0)
		{
			result = 179;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Saint Helena"), false) == 0)
		{
			result = 180;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Saint Kitts and Nevis"), false) == 0)
		{
			result = 181;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Saint Lucia"), false) == 0)
		{
			result = 182;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Saint Pierre"), false) == 0)
		{
			result = 183;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Saint Vincent and the Grenadines"), false) == 0)
		{
			result = 184;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Samoa"), false) == 0)
		{
			result = 185;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("San Marino"), false) == 0)
		{
			result = 186;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Sao Tome and Principe"), false) == 0)
		{
			result = 187;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Saudi Arabia"), false) == 0)
		{
			result = 188;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("scotland"), false) == 0)
		{
			result = 189;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Senegal"), false) == 0)
		{
			result = 190;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Seychelles"), false) == 0)
		{
			result = 191;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Sierra Leone"), false) == 0)
		{
			result = 192;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Singapore"), false) == 0)
		{
			result = 193;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Slovakia"), false) == 0)
		{
			result = 194;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Slovenia"), false) == 0)
		{
			result = 195;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Solomon Islands"), false) == 0)
		{
			result = 196;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Somalia"), false) == 0)
		{
			result = 197;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("South Africa"), false) == 0)
		{
			result = 198;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("South Georgia and the South Sandwich Islands"), false) == 0)
		{
			result = 199;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Spain"), false) == 0)
		{
			result = 200;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Sri Lanka"), false) == 0)
		{
			result = 201;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Sudan"), false) == 0)
		{
			result = 202;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Suriname"), false) == 0)
		{
			result = 203;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Svalbard & Jan Mayen Islands"), false) == 0)
		{
			result = 204;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Swaziland"), false) == 0)
		{
			result = 205;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Sweden"), false) == 0)
		{
			result = 206;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Switzerland"), false) == 0)
		{
			result = 207;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Syrian Arab Republic"), false) == 0)
		{
			result = 208;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Taiwan"), false) == 0)
		{
			result = 209;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Tajikistan"), false) == 0)
		{
			result = 210;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Tanzania, United Republic of"), false) == 0)
		{
			result = 211;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Thailand"), false) == 0)
		{
			result = 212;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Togo"), false) == 0)
		{
			result = 213;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Tokelau"), false) == 0)
		{
			result = 214;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Tonga"), false) == 0)
		{
			result = 215;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Trinidad and Tobago"), false) == 0)
		{
			result = 216;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Tunisia"), false) == 0)
		{
			result = 217;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Turkey"), false) == 0)
		{
			result = 218;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Turkmenistan"), false) == 0)
		{
			result = 219;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Turks"), false) == 0)
		{
			result = 220;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Tuvalu"), false) == 0)
		{
			result = 221;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Uganda"), false) == 0)
		{
			result = 222;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Ukraine"), false) == 0)
		{
			result = 223;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("United Arab Emirates"), false) == 0)
		{
			result = 224;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("United Kingdom"), false) == 0)
		{
			result = 225;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("United States Minor Outlying Islands"), false) == 0)
		{
			result = 226;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("United States"), false) == 0)
		{
			result = 227;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Uruguay"), false) == 0)
		{
			result = 228;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Uzbekistan"), false) == 0)
		{
			result = 229;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Wales"), false) == 0)
		{
			result = 230;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Wallis and Futuna"), false) == 0)
		{
			result = 231;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Vanuatu"), false) == 0)
		{
			result = 232;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Vatican City State"), false) == 0)
		{
			result = 233;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Venezuela"), false) == 0)
		{
			result = 234;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Western Sahara"), false) == 0)
		{
			result = 235;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Viet Nam"), false) == 0)
		{
			result = 236;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Virgin Islands, U.S"), false) == 0)
		{
			result = 237;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Yemen"), false) == 0)
		{
			result = 238;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Zambia"), false) == 0)
		{
			result = 229;
		}
		else if (Operators.CompareString(string_0, Strings.UCase("Zimbabwe"), false) == 0)
		{
			result = 240;
		}
		else
		{
			result = 241;
		}
		return result;
	}
}
