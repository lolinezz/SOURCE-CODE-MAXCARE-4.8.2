using System;
using System.Net;
using maxcare;

namespace Common
{
	// Token: 0x0200005A RID: 90
	public class CheckKey
	{
		// Token: 0x06000379 RID: 889 RVA: 0x0003F178 File Offset: 0x0003D378
		public static string CheckVersion(string softname = "test")
		{
			string str = "https://minsoftware.xyz/file/" + softname + "/";
			try
			{
				WebClient webClient = new WebClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Uri address = new Uri(str + "update.ini");
				webClient.DownloadFile(address, "./update/update.ini");
				CommonIniFile commonIniFile = new CommonIniFile("./update/update.ini");
				string text = commonIniFile.Read("Version", "Infor");
				double num = Convert.ToDouble(text.Replace(".", "").Insert(1, "."));
				CommonIniFile commonIniFile2 = new CommonIniFile("update.ini");
				string text2 = commonIniFile2.Read("Version", "Infor");
				double num2 = Convert.ToDouble(text2.Replace(".", "").Insert(1, "."));
				bool flag = num > num2;
				if (flag)
				{
					string str2 = "\r\nVersion: " + text;
					str2 = str2 + "\r\n" + Language.GetValue("Nội dung update:");
					str2 = str2 + "\r\n" + CommonCSharp.Base64Decode(commonIniFile.Read("Content", "Infor"));
					return str2 + "\r\n\r\n" + Language.GetValue("Bạn có muốn cập nhật phần mềm?");
				}
			}
			catch
			{
			}
			return "";
		}
	}
}
