using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace maxcare
{
	// maxcare.TwoCaptcha
	using System;
	using System.Collections.Specialized;
	using System.IO;
	using System.Net;
	using System.Text;
	using System.Threading;
	using maxcare;

	public class TwoCaptcha
	{
		public string APIKey { get; private set; }

		public TwoCaptcha(string sApiAnticaptcha)
		{
			APIKey = sApiAnticaptcha;
		}

		public bool SolveNormalCapcha(int type, string base64Image, out string result)
		{
			//Discarded unreachable code: IL_0146, IL_0159, IL_0338, IL_034d, IL_0353, IL_0368
			string text = "";
			string text2 = "";
			text2 = ((type != 0) ? "api.captcha.guru" : "2captcha.com");
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["method"] = "base64";
				nameValueCollection["key"] = APIKey;
				nameValueCollection["body"] = base64Image;
				byte[] array = webClient.UploadValues("http://" + text2 + "/in.php", nameValueCollection);
				_ = Encoding.Default;
				text = (string)(object)array;
			}
			Thread.Sleep(TimeSpan.FromSeconds(5.0));
			if (text.Substring(0, 3) == "OK|")
			{
				string text3 = text.Remove(0, 3);
				for (int i = 0; i < 24; i++)
				{
					WebRequest webRequest = WebRequest.Create("http://" + text2 + "/res.php?key=" + APIKey + "&action=get&id=" + text3);
					using (WebResponse webResponse = webRequest.GetResponse())
					{
						using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
						{
							string text4 = streamReader.ReadToEnd();
							if (text4.Length < 3)
							{
								result = text4;
								return false;
							}
							if (text4.Substring(0, 3) == "OK|")
							{
								result = text4.Remove(0, 3);
								return true;
							}
							if (text4 != "CAPCHA_NOT_READY")
							{
								result = text4;
								return false;
							}
						}
					}
					Thread.Sleep(5000);
				}
				result = "Timeout";
				return false;
			}
			result = text;
			return false;
		}

		public static string ResloveNormalCaptcha(int type, string captchaKey, string imgBase64)
		{
			string result = "";
			TwoCaptcha twoCaptcha = new TwoCaptcha(captchaKey);
			bool flag = twoCaptcha.SolveNormalCapcha(type, imgBase64, out result);
			while (!flag)
			{
				flag = twoCaptcha.SolveNormalCapcha(type, imgBase64, out result);
				Thread.Sleep(TimeSpan.FromSeconds(2.0));
			}
			return result;
		}

		public bool SolveRecaptchaV2(int type, string googleKey, string pageUrl, out string result)
		{
			//Discarded unreachable code: IL_0332, IL_0347, IL_034d, IL_0362, IL_03c9, IL_03de, IL_03df, IL_03f4, IL_03f5, IL_0402
			string text = "";
			text = ((type != 0) ? "api.captcha.guru" : "2captcha.com");
			string requestUriString = "http://" + text + "/in.php?key=" + APIKey + "&method=userrecaptcha&googlekey=" + googleKey + "&pageurl=" + pageUrl;
			try
			{
				WebRequest webRequest = WebRequest.Create(requestUriString);
				using (WebResponse webResponse = webRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
					{
						string text2 = streamReader.ReadToEnd();
						if (text2.Length < 3)
						{
							result = text2;
							return false;
						}
						if (text2.Substring(0, 3) == "OK|")
						{
							string text3 = text2.Remove(0, 3);
							for (int i = 0; i < 24; i++)
							{
								WebRequest webRequest2 = WebRequest.Create("http://" + text + "/res.php?key=" + APIKey + "&action=get&id=" + text3);
								using (WebResponse webResponse2 = webRequest2.GetResponse())
								{
									using (StreamReader streamReader2 = new StreamReader(webResponse2.GetResponseStream()))
									{
										string text4 = streamReader2.ReadToEnd();
										if (text4.Length < 3)
										{
											result = text4;
											return false;
										}
										if (text4.Substring(0, 3) == "OK|")
										{
											result = text4.Remove(0, 3);
											return true;
										}
										if (text4 != "CAPCHA_NOT_READY")
										{
											result = text4;
											return false;
										}
									}
								}
								Thread.Sleep(5000);
							}
							result = "Timeout";
							return false;
						}
						result = text2;
						return false;
					}
				}
			}
			catch
			{
			}
			result = "Unknown error";
			return false;
		}

		public static string ResolveRecaptcha(int type, string captchaKey, string ggKey, string pageUrl)
		{
			string result = "";
			TwoCaptcha twoCaptcha = new TwoCaptcha(captchaKey);
			bool flag = twoCaptcha.SolveRecaptchaV2(type, ggKey, pageUrl, out result);
			while (!flag)
			{
				flag = twoCaptcha.SolveRecaptchaV2(type, ggKey, pageUrl, out result);
				Thread.Sleep(TimeSpan.FromSeconds(2.0));
			}
			return result;
		}
	}

}