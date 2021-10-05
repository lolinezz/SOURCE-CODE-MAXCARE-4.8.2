using System;
using System.Net;
using System.Text.RegularExpressions;
using MCommon;
using Newtonsoft.Json.Linq;

namespace Common
{
	// Token: 0x0200005F RID: 95
	public class CommonFacebook
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x00040D44 File Offset: 0x0003EF44
		public static string CheckLiveCookie(string cookie, string userAgent, string proxy, int typeProxy)
		{
			string result = "0|";
			string value = Regex.Match(cookie, "c_user=(.*?);").Groups[1].Value;
			RequestXNet requestXNet = new RequestXNet(cookie, userAgent, proxy, typeProxy);
			bool flag = value != "";
			if (flag)
			{
				try
				{
					string text = requestXNet.RequestGet("https://www.facebook.com/me").ToString();
					bool flag2 = text.Contains("id=\"code_in_cliff\"");
					if (flag2)
					{
						result = "1|0";
					}
					else
					{
						bool flag3 = Regex.Match(text, "\"USER_ID\":\"(.*?)\"").Groups[1].Value.Trim() == value.Trim() && !text.Contains("checkpointSubmitButton");
						if (flag3)
						{
							result = "1|1";
						}
					}
				}
				catch
				{
					result = "2|";
				}
			}
			return result;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00040F1C File Offset: 0x0003F11C
		public static string GetFbdtsg(string cookie, string userAgent, string proxy, int typeProxy)
		{
			string result;
			try
			{
				string input = new RequestXNet(cookie, userAgent, proxy, typeProxy).RequestGet("https://m.facebook.com/ajax/dtsg/?__ajax__=true").ToString();
				string value = Regex.Match(input, "\"token\":\"(.*?)\"").Groups[1].Value;
				result = value;
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00040FD8 File Offset: 0x0003F1D8
		public static string GetCookieFromFacebookAccount(string email, string pass, string userAgent, string proxy, int typeProxy)
		{
			string data = "email=" + WebUtility.UrlEncode(email) + "&pass=" + WebUtility.UrlEncode(pass);
			RequestXNet requestXNet = new RequestXNet("", userAgent, proxy, typeProxy);
			requestXNet.RequestPost("https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", data, "application/x-www-form-urlencoded").ToString();
			return requestXNet.GetCookie();
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000410A0 File Offset: 0x0003F2A0
		public static string GetNameByUID(string uid, string token, string useragent, string proxy, int typeProxy)
		{
			string result;
			try
			{
				RequestXNet requestXNet = new RequestXNet("", useragent, proxy, typeProxy);
				string json = requestXNet.RequestGet("https://graph.facebook.com/" + uid + "?fields=name&access_token=" + token);
				JObject jobject = JObject.Parse(json);
				string text = jobject["name"].ToString();
				result = text;
			}
			catch
			{
				result = "";
			}
			return result;
		}
	}
}
