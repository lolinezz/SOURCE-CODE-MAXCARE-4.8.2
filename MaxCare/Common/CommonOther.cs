using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MCommon;
using Newtonsoft.Json.Linq;

namespace Common
{
	// Token: 0x02000061 RID: 97
	public class CommonOther
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x000413CC File Offset: 0x0003F5CC
		public static string CreateMailGenerator(string tenMail = "")
		{
			string text = "";
			int num = 0;
			while (text == "")
			{
				num++;
				text = CommonOther.GetDuoiMail();
				bool flag = num == 10;
				if (flag)
				{
					return "";
				}
			}
			bool flag2 = tenMail == "";
			if (flag2)
			{
				tenMail = CommonCSharp.CreateRandomString(10, null);
			}
			return tenMail + text;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000414A8 File Offset: 0x0003F6A8
		public static string GetDuoiMail()
		{
			RequestHttp requestHttp = new RequestHttp("", "", "", 0);
			string input = requestHttp.RequestGet("https://generator.email/");
			MatchCollection matchCollection = Regex.Matches(input, "change_dropdown_list\\(this.innerHTML\\)\" id=\"(.*?)\"");
			List<string> list = new List<string>();
			for (int i = 0; i < matchCollection.Count; i++)
			{
				string value = matchCollection[i].Groups[1].Value;
				bool flag = CommonCSharp.CheckBasicString(value) && !CommonCSharp.IsContainNumber(value) && !value.Contains("-") && (value.EndsWith(".com") || value.EndsWith(".org") || value.EndsWith(".info"));
				if (flag)
				{
					list.Add(value);
				}
			}
			bool flag2 = list.Count <= 0;
			string result;
			if (flag2)
			{
				result = "";
			}
			else
			{
				Random random = new Random();
				result = "@" + list[random.Next(0, list.Count)];
			}
			return result;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000416D8 File Offset: 0x0003F8D8
		public static string GetOTPGenerator(string mail, int timeOut = 30)
		{
			RequestHttp requestHttp = new RequestHttp("", "", "", 0);
			string text = "";
			string text2 = string.Concat(new string[]
			{
				"/",
				mail.Split(new char[]
				{
					'@'
				})[1],
				"/",
				mail.Split(new char[]
				{
					'@'
				})[0],
				"/(.*?)\""
			});
			int tickCount = Environment.TickCount;
			bool flag2;
			do
			{
				bool flag = Environment.TickCount - tickCount > timeOut * 1000;
				if (flag)
				{
					break;
				}
				string input = requestHttp.RequestGet("https://generator.email/" + mail);
				text = Regex.Match(input, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\"").Value.TrimEnd(new char[]
				{
					'"'
				});
				text = Regex.Match(text, "c=(.*?)&").Groups[1].Value;
				flag2 = (text != "");
			}
			while (!flag2);
			return text;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0004190C File Offset: 0x0003FB0C
		public static bool DelAllMail(string mail)
		{
			RequestHttp requestHttp = new RequestHttp("", "", "", 0);
			string text = requestHttp.RequestGet("https://generator.email/" + mail);
			string value = Regex.Match(text, "delll: \"(.*?)\"").Groups[1].Value;
			string data = "delll=" + value;
			text = requestHttp.RequestPost("https://generator.email/del_mail.php", data);
			return text.Contains("successfully");
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00041A34 File Offset: 0x0003FC34
		public static string CheckCountry(string hometown)
		{
			RequestHttp requestHttp = new RequestHttp("", "", "", 0);
			string text = requestHttp.RequestGet("https://minsoftware.xyz/minsoftware/api1.php/GetCodeCheckCountry");
			string str = text.Replace("\"", "");
			string result = "";
			string json = requestHttp.RequestPost("https://www.mapdevelopers.com/data.php?operation=geocode&address=" + hometown + "&region=US&code=" + str, "").ToString();
			JObject jobject = JObject.Parse(json);
			string text2 = jobject["data"]["country"].ToString();
			bool flag = text2 != "";
			if (flag)
			{
				result = text2;
			}
			return result;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00041BC0 File Offset: 0x0003FDC0
		public static string CheckBalance(string apikey)
		{
			string text = "";
			RequestXNet requestXNet = new RequestXNet("", "", "", 0);
			string json = requestXNet.RequestGet("https://api.rentcode.net/api/ig/balance?apiKey=" + Uri.EscapeDataString(apikey));
			JObject jobject = JObject.Parse(json);
			bool flag = Convert.ToBoolean(jobject["success"]);
			if (flag)
			{
				try
				{
					text = jobject["results"]["balance"].ToString();
				}
				catch
				{
				}
			}
			return (text == "") ? "" : Convert.ToInt32(text).ToString();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00041D44 File Offset: 0x0003FF44
		public static string GetPhoneRentcode(string apikey, int id_service = 3, int id_provider = 2, int timeOut = 60)
		{
			string text = "";
			RequestXNet requestXNet = new RequestXNet("", "", "", 0);
			string data = string.Concat(new string[]
			{
				"{ \"serviceProviderId\": ",
				id_service.ToString(),
				", \"networkProvider\": ",
				id_provider.ToString(),
				" }"
			});
			string text2 = "";
			for (int i = 0; i < 5; i++)
			{
				try
				{
					string json = requestXNet.RequestPost("https://api.rentcode.net/api/ig/create-request?apiKey=" + Uri.EscapeDataString(apikey), data, "application/json");
					text2 = JObject.Parse(json)["results"]["id"].ToString();
					bool flag = text2 != "";
					if (flag)
					{
						break;
					}
				}
				catch
				{
				}
			}
			bool flag2 = text2 != "";
			if (flag2)
			{
				int tickCount = Environment.TickCount;
				for (;;)
				{
					bool flag3 = Environment.TickCount - tickCount > timeOut * 1000;
					if (flag3)
					{
						break;
					}
					string json = requestXNet.RequestGet("https://api.rentcode.net/api/ig/orders/" + text2 + "/check-status?apiKey=" + Uri.EscapeDataString(apikey));
					JObject jobject = JObject.Parse(json);
					bool flag4 = Convert.ToBoolean(jobject["success"]);
					if (flag4)
					{
						try
						{
							text = jobject["results"]["phoneNumber"].ToString();
							bool flag5 = text != "";
							if (flag5)
							{
								break;
							}
						}
						catch
						{
						}
					}
				}
			}
			return text2 + "|" + text;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000420F4 File Offset: 0x000402F4
		public static string GetOTPRentcode(string apikey, string id_order, int timeOut = 60)
		{
			string text = "";
			RequestXNet requestXNet = new RequestXNet("", "", "", 0);
			string data = "{ \"pageIndex\": 0, \"pageSize\": 0, \"sortColumnName\": \"string\", \"isAsc\": true, \"searchObject\": { \"additionalProp1\": { }, \"additionalProp2\": { }, \"additionalProp3\": { } } }";
			int tickCount = Environment.TickCount;
			for (;;)
			{
				bool flag = Environment.TickCount - tickCount > timeOut * 1000;
				if (flag)
				{
					break;
				}
				string json = requestXNet.RequestPost("https://api.rentcode.net/api/ig/orders/" + id_order + "/results?apiKey=" + Uri.EscapeDataString(apikey), data, "application/json");
				JObject jobject = JObject.Parse(json);
				bool flag2 = Convert.ToInt32(jobject["total"]) > 0;
				if (flag2)
				{
					try
					{
						text = jobject["results"][0]["message"].ToString();
						text = Regex.Match(text, "\\d{6}").Value;
						bool flag3 = text != "";
						if (flag3)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return text;
		}
	}
}
