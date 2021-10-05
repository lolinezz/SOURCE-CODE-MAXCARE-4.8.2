using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DeviceId;
using HttpRequest;
using License;
using License.RNCryptor;
using MailKit;
using MailKit.Net.Imap;
using MCommon;
using MimeKit;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using xNet;

namespace maxcare
{
	// maxcare.Comon
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Diagnostics;
	using System.Drawing;
	using System.IO;
	using System.Linq;
	using System.Management;
	using System.Net;
	using System.Net.Mail;
	using System.Security.Cryptography;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Windows.Forms;
	using DeviceId;
	using HttpRequest;
	using License;
	using License.RNCryptor;
	using MailKit;
	using MailKit.Net.Imap;
	using maxcare;
	using MCommon;
	using MimeKit;
	using Newtonsoft.Json.Linq;
	using OpenQA.Selenium;
	using OpenQA.Selenium.Chrome;
	using xNet;

	public class Comon
	{
		public static int getWidthScreen;

		public static int getHeightScreen;

		public static string userName;

		public static string passWord;

		public static string valueReturnApiKey;

		private static string[] VietNamChar = new string[15]
		{
		"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ",
		"ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"
		};

		public static string GetTokenBussinessFromCookie(string cookie)
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + cookie
			});
			string input = requestHTTP.Request("GET", "https://business.facebook.com/business_locations/");
			return Regex.Match(input, "EAAG(.*?)\"").Value.Replace("\"", "");
		}

		public static void QuitChrome(ChromeDriver chrome)
		{
			//Discarded unreachable code: IL_0014, IL_0021
			try
			{
				chrome.Quit();
			}
			catch
			{
			}
		}

		public static ChromeDriver OpenChrome(ChromeDriver chrome, bool isHideCMD, bool isHideImage, string UserAgent, string LinkProfile, bool isHideChrome, Point Size, Point Position, string Proxy, int TimeForSearchingElement = 0, int TimeforLoadingPage = 0)
		{
			ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
			if (isHideCMD)
			{
				chromeDriverService.HideCommandPromptWindow = true;
			}
			ChromeOptions chromeOptions = new ChromeOptions();
			chromeOptions.AddArguments("--disable-notifications", "--window-size=" + Size.X + "," + Size.Y, "--window-position=" + Position.X + "," + Position.Y, "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--mute-audio", "--disable-popup-blocking", "--user-agent=" + UserAgent);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.notifications", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.plugins", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.popups", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.auto_select_certificate", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.mixed_script", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_mic", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream_camera", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.protocol_handlers", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.midi_sysex", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.push_messaging", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.ssl_cert_decisions", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.metro_switch_to_desktop", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.protected_media_identifier", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.site_engagement", 1);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.durable_storage", 1);
			chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.images", 1);
			chromeOptions.AddUserProfilePreference("useAutomationExtension", true);
			if (isHideChrome)
			{
				LinkProfile = "";
				chromeOptions.AddArgument("--headless");
			}
			if (isHideImage)
			{
				chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
			}
			if (!string.IsNullOrEmpty(LinkProfile.Trim()))
			{
				chromeOptions.AddArgument("--user-data-dir=" + LinkProfile);
			}
			if (Proxy == "-1")
			{
				Proxy = "";
			}
			if (!string.IsNullOrEmpty(Proxy.Trim()))
			{
				chromeOptions.AddArgument("--proxy-server= 127.0.0.1:" + Proxy);
			}
			chrome = new ChromeDriver(chromeDriverService, chromeOptions);
			chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeForSearchingElement);
			chrome.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TimeforLoadingPage);
			return chrome;
		}

		public static List<string> RemoveEmptyItems(List<string> lst)
		{
			for (int i = 0; i < lst.Count; i++)
			{
				if (lst[i].Trim() == "")
				{
					lst.RemoveAt(i--);
				}
			}
			return lst;
		}

		public static string CountNumberGroupUsingCookie(string cookie)
		{
			//Discarded unreachable code: IL_00ff, IL_0122
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + cookie
				});
				string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/groups/?seemore&refid=27");
				MatchCollection matchCollection = Regex.Matches(input, "</li>");
				return matchCollection.Count.ToString();
			}
			catch
			{
				return "";
			}
		}

		public static string CountNumberFriendUsingCookie(string cookie)
		{
			//Discarded unreachable code: IL_019a, IL_01bd
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + cookie
				});
				string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/profile.php?v=friends&refid=17");
				string input2 = Regex.Match(input, "allactivity\\?refid=17\"(.*?)</h3>").Value.ToString();
				string text = Regex.Match(input2, "\\((.*?)\\)").Groups[1].Value.ToString().Replace(".", "");
				if (text == "")
				{
					text = "0";
				}
				return text;
			}
			catch
			{
				return "";
			}
		}

		public static string ConvertToShortCookie(string cookie)
		{
			//Discarded unreachable code: IL_00aa, IL_00be
			try
			{
				string value = Regex.Match(cookie, "c_user=(.*?);").Value;
				string value2 = Regex.Match(cookie, "xs=(.*?);").Value;
				string value3 = Regex.Match(cookie, "fr=(.*?);").Value;
				string value4 = Regex.Match(cookie, "datr=(.*?);").Value;
				return value + value2 + value3 + value4;
			}
			catch
			{
				return cookie;
			}
		}

		public static bool SearchElement(ChromeDriver chrome, int typeSearch, string value)
		{
			//Discarded unreachable code: IL_003d, IL_004f
			try
			{
				if (typeSearch == 0)
				{
					IWebElement webElement = chrome.FindElementById(value);
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static bool CheckWall(string uid)
		{
			//Discarded unreachable code: IL_00c9, IL_00d6
			bool result = false;
			try
			{
				xNet.HttpRequest httpRequest = new xNet.HttpRequest();
				httpRequest.KeepAlive = true;
				httpRequest.Cookies = new CookieDictionary();
				httpRequest.AddHeader(HttpHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
				httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
				httpRequest.UserAgent = Http.ChromeUserAgent();
				string address = "https://graph.facebook.com/" + uid + "/picture";
				string text = httpRequest.Get(address).ToString();
				result = true;
			}
			catch
			{
			}
			return result;
		}

		public static bool CheckAvatar(string uid)
		{
			string text = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string text2 = requestHTTP.Request("GET", "https://graph.facebook.com/" + uid + "/picture");
			if (text2.Contains("error"))
			{
				return false;
			}
			return true;
		}

		public static string CheckAccMailYahoo(string username, string pass)
		{
			string text = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string input = requestHTTP.Request("GET", "https://login.yahoo.com/config/login");
			string value = Regex.Match(input, "acrumb\" value=\"(.*?)\"").Groups[1].Value;
			string value2 = Regex.Match(input, "sessionIndex\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "persistent\" value=\"(.*?)\"").Groups[1].Value;
			string s = "acrumb=" + value + "&sessionIndex=" + value2 + "&username=" + username + "&passwd=&signin=Ti%E1%BA%BFp%C2%A0theo&persistent=" + value3;
			input = requestHTTP.Request("POST", "https://login.yahoo.com/config/login", null, Encoding.ASCII.GetBytes(s));
			string value4 = Regex.Match(input, "crumb\" value=\"(.*?)\"").Groups[1].Value;
			string value5 = Regex.Match(input, "passwordContext\" value=\"(.*?)\"").Groups[1].Value;
			s = "browser-fp-data=%7B%22language%22%3A%22en-US%22%2C%22colorDepth%22%3A24%2C%22deviceMemory%22%3A8%2C%22pixelRatio%22%3A1%2C%22hardwareConcurrency%22%3A8%2C%22timezoneOffset%22%3A-420%2C%22timezone%22%3A%22Asia%2FBangkok%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22openDatabase%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22Win32%22%2C%22doNotTrack%22%3A%221%22%2C%22plugins%22%3A%7B%22count%22%3A3%2C%22hash%22%3A%22e43a8bc708fc490225cde0663b28278c%22%7D%2C%22canvas%22%3A%22canvas+winding%3Ayes%7Ecanvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Google+Inc.%7EANGLE+%28Intel%28R%29+UHD+Graphics+630+Direct3D11+vs_5_0+ps_5_0%29%22%2C%22adBlock%22%3A1%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A0%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A0%2C%22event%22%3A0%2C%22start%22%3A0%7D%2C%22fonts%22%3A%7B%22count%22%3A45%2C%22hash%22%3A%2246a30c0488455f08568f3e573502b25e%22%7D%2C%22audio%22%3A%22124.0434474653739%22%2C%22resolution%22%3A%7B%22w%22%3A%221920%22%2C%22h%22%3A%221080%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%221040%22%2C%22h%22%3A%221920%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1559177497471%2C%22render%22%3A1559177497688%7D%7D&crumb=" + value4 + "&acrumb=" + value + "&sessionIndex=" + value2 + "&displayName=phuonglazy&username=" + username + "&passwordContext=" + value5 + "&password=" + pass + "&verifyPassword=%C4%90%C4%83ng+nh%E1%BA%ADp";
			input = requestHTTP.Request("POST", "https://login.yahoo.com/account/challenge/password", null, Encoding.ASCII.GetBytes(s));
			string text2 = requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
			text = ((input.Contains("login-passwd") || !input.Contains(username.Replace("@yahoo.com", ""))) ? "0|" : "1|");
			string cookiesString = requestHTTP.GetCookiesString("https://login.yahoo.com");
			return text + cookiesString;
		}

		public static string CheckAccMailYahooCookie(string username, string cookieMail)
		{
			string text = "";
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + cookieMail
			});
			string text2 = requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
			text = ((text2.Contains("login-username") || !text2.Contains(username.Replace("@yahoo.com", ""))) ? "0|" : "1|");
			string cookiesString = requestHTTP.GetCookiesString("https://login.yahoo.com");
			return text + cookiesString;
		}

		public static string GetOtpYahooFromCookie(string cook, int timeout)
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + cook
			});
			string text = requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
			bool flag = false;
			string text2 = "";
			int tickCount = Environment.TickCount;
			do
			{
				if (Environment.TickCount - tickCount > timeout * 1000)
				{
					return "";
				}
				string input = requestHTTP.Request("GET", "https://mail.yahoo.com").ToString();
				string value = Regex.Match(input, "message-subject(.*?)</span>", RegexOptions.Singleline).Value;
				text2 = Regex.Match(value, "\\d{6}", RegexOptions.Singleline).Value;
				if (text2 != "")
				{
					flag = true;
					break;
				}
			}
			while (!flag);
			return text2;
		}

		public static string CheckMailHotmailAndDeleteAllMessage(string username, string password)
		{
			//Discarded unreachable code: IL_0126, IL_0139, IL_0156, IL_0179
			string text = "";
			try
			{
				using (ImapClient imapClient = new ImapClient())
				{
					imapClient.Connect("outlook.office365.com", 993, useSsl: true);
					imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
					imapClient.Authenticate(username, password);
					IMailFolder inbox = imapClient.Inbox;
					inbox.Open(FolderAccess.ReadOnly);
					for (int i = 0; i < inbox.Count; i++)
					{
						MimeMessage message = inbox.GetMessage(i);
						inbox.AddFlags(i, MessageFlags.Deleted, silent: true);
						string subject = message.Subject;
					}
					imapClient.Disconnect(quit: true);
				}
				return "1";
			}
			catch
			{
				return "0";
			}
		}

		public static void ExportError(ChromeDriver chrome, string error)
		{
			//Discarded unreachable code: IL_02fc, IL_0309
			try
			{
				Random random = new Random();
				string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1, 1000);
				string text2 = "";
				if (chrome != null)
				{
					text2 = chrome.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
					Screenshot screenshot = ((ITakesScreenshot)chrome).GetScreenshot();
					screenshot.SaveAsFile("log\\images\\" + text + ".png");
					File.WriteAllText("log\\html\\" + text + ".html", text2);
				}
				File.AppendAllText("log\\log.txt", DateTime.Now.ToString() + "|<" + text + ">|" + error + Environment.NewLine);
			}
			catch
			{
			}
		}

		public static string GetOtpHotMailFromEaag(string username, string password, int timeout)
		{
			//Discarded unreachable code: IL_01b1, IL_01c6
			bool flag = false;
			string text = "";
			int tickCount = Environment.TickCount;
			do
			{
				if (Environment.TickCount - tickCount > timeout * 1000)
				{
					return "";
				}
				using (ImapClient imapClient = new ImapClient())
				{
					imapClient.Connect("outlook.office365.com", 993, useSsl: true);
					imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
					imapClient.Authenticate(username, password);
					IMailFolder inbox = imapClient.Inbox;
					inbox.Open(FolderAccess.ReadOnly);
					if (inbox.Count <= 0)
					{
						goto IL_0194;
					}
					MimeMessage message = inbox.GetMessage(0);
					string input = message.Body.ToString();
					text = Regex.Match(input, "\\d{6}", RegexOptions.Singleline).Value;
					if (text.Equals(""))
					{
						goto IL_0194;
					}
					flag = true;
					goto end_IL_0064;
				IL_0194:
					imapClient.Disconnect(quit: true);
					continue;
				end_IL_0064:;
				}
				break;
			}
			while (!flag);
			return text;
		}

		public static bool AddFriendAcceptFriendUidFromCookie(string cookie, string uid)
		{
			//Discarded unreachable code: IL_0295, IL_02a2
			bool result = false;
			try
			{
				if (CheckLiveCookie(cookie).Equals("Die"))
				{
					return result;
				}
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + cookie
				});
				string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/" + uid);
				string text = Regex.Match(input, "/a/mobile/friends/profile_add_friend(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
				if (text.Equals(""))
				{
					return result;
				}
				text = "https://mbasic.facebook.com" + text;
				input = requestHTTP.Request("GET", text);
				Thread.Sleep(300);
				input = requestHTTP.Request("GET", "https://mbasic.facebook.com/" + uid);
				result = ((!input.Contains("profile_add_friend")) ? true : false);
			}
			catch
			{
			}
			return result;
		}

		public static string InviteLikePageCookie(string cookie, string idPage, int timeSleep = 0)
		{
			//Discarded unreachable code: IL_02a2, IL_02af
			int num = 0;
			try
			{
				if (CheckLiveCookie(cookie).Equals("Die"))
				{
					return "";
				}
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + cookie
				});
				string url = "https://mbasic.facebook.com/send_page_invite/?pageid=" + idPage;
				bool flag = false;
				do
				{
					flag = false;
					string text = requestHTTP.Request("GET", url);
					MatchCollection matchCollection = Regex.Matches(text, "/pages/friend_invite/send/(.*?)\"");
					for (int i = 0; i < matchCollection.Count; i++)
					{
						string url2 = "https://mbasic.facebook.com" + matchCollection[i].Value.Replace("\"", "").Replace("amp;", "");
						requestHTTP.Request("GET", url2);
						num++;
						if (timeSleep != 0)
						{
							Thread.Sleep(timeSleep);
						}
					}
					if (text.Contains("offset"))
					{
						flag = true;
					}
				}
				while (flag);
			}
			catch
			{
			}
			return num.ToString() ?? "";
		}

		public static string CheckLiveCookie(string cookie)
		{
			//Discarded unreachable code: IL_01c9, IL_01d6
			cookie = ConvertToStandardCookie(cookie);
			string result = "Die";
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + cookie
				});
				string value = Regex.Match(cookie, "c_user=(.*?);").Groups[1].Value;
				string text = requestHTTP.Request("GET", "https://www.facebook.com/me");
				if (!value.Equals("") && text.Contains(value) && text.Contains("entity_id") && !text.Contains("checkpointSubmitButton"))
				{
					result = "Live";
				}
			}
			catch
			{
			}
			return result;
		}

		public static string GetFbdtsg(string cookie, string uA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
		{
			//Discarded unreachable code: IL_0151, IL_0173
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: application/x-www-form-urlencoded",
				"user-agent: " + uA,
				"cookie: " + cookie
				});
				string text = requestHTTP.Request("GET", "https://m.facebook.com/ajax/dtsg/?__ajax__=true");
				text = text.Replace("for (;;);", "");
				JObject jObject = JObject.Parse(text);
				return jObject["payload"]["token"].ToString();
			}
			catch
			{
				return "";
			}
		}

		public static string AutoShare(string cookie, string content, string link, string id_group)
		{
			string idPost = GetIdPost(link);
			if (idPost == "")
			{
				return "";
			}
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + cookie
			});
			string value = Regex.Match(cookie, "c_user=(.*?);").Groups[1].Value;
			string fbdtsg = GetFbdtsg(cookie);
			string input = requestHTTP.Request("GET", "https://m.facebook.com/me");
			string value2 = Regex.Match(input, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "name=\"privacyx\" value=\"(.*?)\"").Groups[1].Value;
			string value4 = Regex.Match(input, "__spin_r\":(.*?),").Groups[1].Value;
			string text = value4;
			string value5 = Regex.Match(input, "__spin_t\":(.*?),").Groups[1].Value;
			string s = "__user=" + value + "&__a=1&__dyn=7AgNe-UOByEogDxyHqzGomzFEbEyGzEy4aheC267Uqzob4q2i5UK3u2C3-u5RyUoxGEbbyEjKewXwgUOdwJyFElwzxCuifz8nxm1Dxa2m4o6e2e79oeGwaWum1NwJxCq7ooxu6U8kU4m3mbx-2K1KUkBzXG6o6CEWu4EhwG-U99m4-3Cfz8-4U-5898Gfxm7omyUnG12AgG4eeKi8wg8jyE5WcyES48y8xK3yeCzEmgK7o88vwEy8iwSwjU4W2WE9EjwtUym2mfxW68lBwcO&__csr=&__req=13&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + value4 + "&__s=k2qltm%3Act038n%3Av4okyh&__hsi=6766055500147629515-0&fb_dtsg=" + WebUtility.UrlEncode(fbdtsg) + "&jazoest=" + value2 + "&__spin_r=" + text + "&__spin_b=trunk&__spin_t=" + value5;
			string text2 = "";
			text2 = ((!(id_group != "")) ? ("https://www.facebook.com/share/dialog/submit/?app_id=2309869772&audience_type=self&composer_session_id=38700f24-cbee-4aaa-a626-9fd6f4056e3a&ephemeral_ttl_mode=0&ft[tn]=J]-R-R&ft[type]=25&ft[mf_story_key]=&ft[top_level_post_id]=&ft[tl_objid]=&ft[content_owner_id_new]=&ft[throwback_story_fbid]=&ft[story_location]=9&ft[story_attachment_style]=share&ft[fbfeed_location]=5&internalextra[feedback_source]=2&is_forced_reshare_of_post=true&message=" + WebUtility.UrlEncode(content) + "&owner_id=&post_id=" + idPost + "&privacy=" + value3 + "&share_to_group_as_page=false&share_type=99&shared_ad_id=&source=osbach&is_throwback_post=false&url=&shared_from_post_id=&logging_session_id=e24e7b30-b545-4305-a233-b9874afe63d4&perform_messenger_logging=true&video_start_time_ms=0&is_app_content_token=false&av=" + value) : ("https://www.facebook.com/share/dialog/submit/?app_id=2309869772&audience_type=group&audience_targets[0]=" + id_group + "&composer_session_id=38700f24-cbee-4aaa-a626-9fd6f4056e3a&ephemeral_ttl_mode=0&ft[tn]=J]-R-R&ft[type]=25&ft[mf_story_key]=&ft[top_level_post_id]=&ft[tl_objid]=&ft[content_owner_id_new]=&ft[throwback_story_fbid]=&ft[story_location]=9&ft[story_attachment_style]=share&ft[fbfeed_location]=5&internalextra[feedback_source]=2&is_forced_reshare_of_post=true&message=" + WebUtility.UrlEncode(content) + "&owner_id=&post_id=" + idPost + "&share_to_group_as_page=false&share_type=99&shared_ad_id=&source=osbach&is_throwback_post=false&url=&shared_from_post_id=&logging_session_id=e24e7b30-b545-4305-a233-b9874afe63d4&perform_messenger_logging=true&video_start_time_ms=0&is_app_content_token=false&av=" + value));
			string input2 = requestHTTP.Request("POST", text2, null, Encoding.ASCII.GetBytes(s));
			return Regex.Match(input2, "object_id\":(.*?),").Groups[1].Value;
		}

		public static string GetIdPost(string Link)
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: application/x-www-form-urlencoded", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36" });
			string input = requestHTTP.Request("GET", Link);
			string value = Regex.Match(input, "\\\\\"post_fbid\\\\\":(.*?)}", RegexOptions.Singleline).Groups[1].Value;
			if (value == "")
			{
				value = Regex.Match(input, "share_fbid:\"(.*?)\"", RegexOptions.Singleline).Groups[1].Value;
			}
			if (value == "")
			{
				value = Regex.Match(input, "videos/(.*?)/", RegexOptions.Singleline).Groups[1].Value;
			}
			return value;
		}

		public static void PublicPost(string cookie)
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + cookie
			});
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/privacy/touch/composer/selector/?logging_source=composer_options");
			string text = Regex.Match(input, "/privacy/save(.*?)\"").Value.Replace("\"", "").Replace("&amp;", "&");
			string text2 = requestHTTP.Request("GET", "https://mbasic.facebook.com" + text);
		}

		public static List<string> GetListFriendsFromCookie(string cookie)
		{
			//Discarded unreachable code: IL_02c8, IL_02d5
			List<string> list = new List<string>();
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[3]
			{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
			"cookie: " + cookie
			});
			string text = "https://mbasic.facebook.com/friends/center/friends/?ppk=" + 0;
			bool flag = true;
			try
			{
				while (flag)
				{
					string input = requestHTTP.Request("GET", text);
					MatchCollection matchCollection = Regex.Matches(input, "/friends/hovercard(.*?)<");
					for (int i = 0; i < matchCollection.Count; i++)
					{
						string value = Regex.Match(matchCollection[i].Value, "uid=(.*?)&").Groups[1].Value;
						string value2 = Regex.Match(matchCollection[i].Value, ">(.*?)<").Groups[1].Value;
						list.Add(value + "|" + value2);
					}
					text = Regex.Match(input, "/friends/center/friends/.ppk=(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
					if (text.Equals(""))
					{
						flag = false;
						continue;
					}
					flag = true;
					text = "https://mbasic.facebook.com" + text;
				}
			}
			catch
			{
			}
			return list;
		}

		public static bool PublicListFriends(string cookie)
		{
			//Discarded unreachable code: IL_026e, IL_0281
			bool flag = false;
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
				"cookie: " + cookie
				});
				string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/me/friends");
				string text = Regex.Match(input, "/privacyx/selector/(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
				text = "https://mbasic.facebook.com" + text;
				input = requestHTTP.Request("GET", text);
				string text2 = Regex.Match(input, "/a/privacy/.px=300645083384735(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
				text2 = "https://mbasic.facebook.com" + text2;
				input = requestHTTP.Request("GET", text2);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static List<string> CheckMyPages(string token)
		{
			//Discarded unreachable code: IL_01cc, IL_01d9
			List<string> list = new List<string>();
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
				string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/accounts?access_token=" + token + "&fields=id,likes&limit=50");
				JObject jObject = JObject.Parse(json);
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					list.Add(jObject["data"][i]["id"].ToString() + "|" + jObject["data"][i]["likes"].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		public static List<string> CheckMyBM(string token)
		{
			//Discarded unreachable code: IL_01cc, IL_01d9
			List<string> list = new List<string>();
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
				string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/businesses?access_token=" + token + "&fields=id,name&limit=50");
				JObject jObject = JObject.Parse(json);
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					list.Add(jObject["data"][i]["id"].ToString() + "|" + jObject["data"][i]["name"].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		public static List<string> CheckMyTkqc(string token)
		{
			//Discarded unreachable code: IL_0251, IL_025e, IL_02a1, IL_02ae
			List<string> list = new List<string>();
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
				string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/adaccounts?access_token=" + token + "&fields=id,min_billing_threshold&limit=100");
				JObject jObject = JObject.Parse(json);
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					try
					{
						list.Add(jObject["data"][i]["id"].ToString() + "|" + jObject["data"][i]["min_billing_threshold"]["amount"].ToString() + " " + jObject["data"][i]["min_billing_threshold"]["currency"].ToString());
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return list;
		}

		public static List<string> CheckMyGroupAdmin(string token)
		{
			//Discarded unreachable code: IL_01fe, IL_020b, IL_024e, IL_025b
			List<string> list = new List<string>();
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
				string json = requestHTTP.Request("GET", "https://graph.facebook.com/me/groups?access_token=" + token + "&fields=id,administrator,member_count&limit=5000");
				JObject jObject = JObject.Parse(json);
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					try
					{
						if (jObject["data"][i]["administrator"].ToString().Equals("True"))
						{
							list.Add(jObject["data"][i]["id"].ToString() + "|" + jObject["data"][i]["member_count"].ToString());
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return list;
		}

		public static Dictionary<string, string> GetInforUserFromUid(string token, string uid, string cookie = "")
		{
			//Discarded unreachable code: IL_01d0, IL_01dd, IL_020d, IL_021a, IL_024a, IL_0257, IL_0287, IL_0294, IL_02f8, IL_0393, IL_043e, IL_044b, IL_0600, IL_063e
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
				int num = 0;
				JObject jObject;
				string value;
				string text;
				string text2;
				string value2;
				string value3;
				string value4;
				string value5;
				while (true)
				{
					string json = requestHTTP.Request("GET", "https://graph.facebook.com/v2.11/" + uid + "?fields=id,name,email,gender,birthday,friends.limit(0),groups.limit(5000){id}&access_token=" + token);
					jObject = JObject.Parse(json);
					value = "";
					text = "";
					text2 = "";
					value2 = "";
					value3 = "";
					value4 = "";
					value5 = "Live";
					string text3 = jObject["name"].ToString();
					try
					{
						value4 = jObject["birthday"].ToString();
					}
					catch
					{
					}
					try
					{
						value3 = jObject["gender"].ToString();
					}
					catch
					{
					}
					try
					{
						value = jObject["email"].ToString();
					}
					catch
					{
					}
					try
					{
						value2 = jObject["mobile_phone"].ToString();
					}
					catch
					{
					}
					try
					{
						text2 = jObject["friends"]["summary"]["total_count"].ToString();
					}
					catch
					{
						if (cookie != "" && CheckLiveCookie(cookie) == "Live" && num == 0 && PublicListFriends(cookie))
						{
							num++;
							continue;
						}
					}
					break;
				}
				if (text2 == "")
				{
					text2 = "0";
				}
				try
				{
					text = jObject["groups"]["data"].Count().ToString() ?? "";
				}
				catch
				{
				}
				if (text == "")
				{
					text = "0";
				}
				dictionary.Add("uid", jObject["id"].ToString());
				dictionary.Add("name", jObject["name"].ToString());
				dictionary.Add("birthday", value4);
				dictionary.Add("gender", value3);
				dictionary.Add("token", token);
				dictionary.Add("email", value);
				dictionary.Add("phone", value2);
				dictionary.Add("friends", text2);
				dictionary.Add("groups", text);
				dictionary.Add("info", value5);
			}
			catch
			{
				dictionary.Add("info", "Die");
			}
			return dictionary;
		}

		public static List<string> GetRandomFriendFromToken(string token, int limit)
		{
			List<string> list = new List<string>();
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://api.facebook.com/method/fql.query?query=select%20uid2%20from%20friend%20where%20uid1%20=%20me()%20order%20by%20rand()%20limit%20" + limit + "&access_token=" + token + "&format=json").ToString();
			JArray source = JArray.Parse(json);
			List<JObject> list2 = source.OfType<JObject>().ToList();
			for (int i = 0; i < list2.Count(); i++)
			{
				list.Add(list2[i]["uid2"].ToString());
			}
			return list;
		}

		public static Dictionary<string, string> GetInforUserFromToken(string token)
		{
			//Discarded unreachable code: IL_01b0, IL_01bd, IL_01ec, IL_01f9, IL_0228, IL_0235, IL_0264, IL_0271, IL_0334, IL_0341, IL_0512, IL_0551
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
				string json = requestHTTP.Request("GET", "https://graph.facebook.com/v2.11/me?fields=id,name,email,gender,birthday,friends.limit(0),groups.limit(5000){id}&access_token=" + token).ToString();
				JObject jObject = JObject.Parse(json);
				string value = "";
				string text = "";
				string text2 = "";
				string value2 = "";
				string value3 = "";
				string value4 = "Live";
				string text3 = jObject["name"].ToString();
				string text4 = "";
				try
				{
					text4 = jObject["birthday"].ToString();
				}
				catch
				{
				}
				try
				{
					value3 = jObject["gender"].ToString();
				}
				catch
				{
				}
				try
				{
					value = jObject["email"].ToString();
				}
				catch
				{
				}
				try
				{
					value2 = jObject["mobile_phone"].ToString();
				}
				catch
				{
				}
				text2 = jObject["friends"]["summary"]["total_count"].ToString();
				try
				{
					text = jObject["groups"]["data"].Count().ToString() ?? "";
				}
				catch
				{
				}
				if (text == "")
				{
					text = "0";
				}
				dictionary.Add("uid", jObject["id"].ToString());
				dictionary.Add("name", jObject["name"].ToString());
				dictionary.Add("birthday", jObject["birthday"].ToString());
				dictionary.Add("gender", value3);
				dictionary.Add("token", token);
				dictionary.Add("email", value);
				dictionary.Add("phone", value2);
				dictionary.Add("friends", text2);
				dictionary.Add("groups", text);
				dictionary.Add("info", value4);
			}
			catch (Exception)
			{
				dictionary.Add("info", "Die");
			}
			return dictionary;
		}

		public static string GetTokenAndroidFromUidPass(string username, string password)
		{
			//Discarded unreachable code: IL_024d, IL_02ab
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string text = "";
			bool flag = false;
			string text2 = "882a8490361da98702bf97a021ddc14d";
			string text3 = Encryptor("api_key=" + text2 + "email=" + username + "format=JSONlocale=vi_vnmethod=auth.loginpassword=" + password + "return_ssl_resources=0v=1.062f8ce9f74b12f84c123cc23437a4a32").ToLower();
			string json = requestHTTP.Request("GET", "https://api.facebook.com/restserver.php?&api_key=" + text2 + "&email=" + username + "&format=JSON&locale=vi_vn&method=auth.login&password=" + password + "&return_ssl_resources=0&v=1.0&sig=" + text3);
			JObject jObject = JObject.Parse(json);
			try
			{
				text = jObject["access_token"].ToString();
			}
			catch
			{
				flag = true;
				text = jObject["error_code"]?.ToString() ?? "";
			}
			return flag ? ("1|" + text) : ("0|" + text);
		}

		public static string GetTokenIosFromUidPass(string username, string password)
		{
			//Discarded unreachable code: IL_024d, IL_02ab
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string text = "";
			bool flag = false;
			string text2 = "3e7c78e35a76a9299309885393b02d97";
			string text3 = Encryptor("api_key=" + text2 + "email=" + username + "format=JSONlocale=vi_vnmethod=auth.loginpassword=" + password + "return_ssl_resources=0v=1.0c1e620fa708a1d5696fb991c1bde5662").ToLower();
			string json = requestHTTP.Request("GET", "https://api.facebook.com/restserver.php?&api_key=" + text2 + "&email=" + username + "&format=JSON&locale=vi_vn&method=auth.login&password=" + password + "&return_ssl_resources=0&v=1.0&sig=" + text3);
			JObject jObject = JObject.Parse(json);
			try
			{
				text = jObject["access_token"].ToString();
			}
			catch
			{
				flag = true;
				text = jObject["error_code"]?.ToString() ?? "";
			}
			return flag ? ("1|" + text) : ("0|" + text);
		}

		public static string CheckAccountUidPass(string username, string password)
		{
			//Discarded unreachable code: IL_05f7, IL_0615
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string text = "";
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com");
			string value = Regex.Match(input, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string value2 = Regex.Match(input, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
			string value4 = Regex.Match(input, "\"li\" value=\"(.*?)\"").Groups[1].Value;
			string[] array = new string[1] { "referer: https://mbasic.facebook.com/checkpoint/?_rdr" };
			byte[] bytes = ((Encoding)null).GetBytes("fb_dtsg=" + value + "%3D&jazoest=" + value2 + "&m_ts=" + value3 + "&li=" + value4 + "&try_number=0&unrecognized_tries=0&email=" + username + "&pass=" + password + "&login=Log+In");
			string text2 = requestHTTP.Request((string)(object)requestHTTP, "POST", (string[])(object)"https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", bytes, autoredrirect: true, (WebProxy)null, 60000);
			text2 = requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
			if (text2.Contains("checkpoint/?next"))
			{
				text = "2|";
				value = Regex.Match(text2, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				value2 = Regex.Match(text2, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
				string value5 = Regex.Match(text2, "\"nh\" value=\"(.*?)\"").Groups[1].Value;
				string value6 = Regex.Match(text2, "client_revision\":(.*?),").Groups[1].Value;
				byte[] bytes2 = ((Encoding)null).GetBytes("jazoest=" + value2 + "&fb_dtsg=" + value + "&nh=" + value5 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=&__req=&__be=0&__pc=PHASED%3ADEFAULT&dpr=&__rev=" + value6);
				input = requestHTTP.Request((string)(object)requestHTTP, "POST", (string[])(object)"https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", bytes2, autoredrirect: true, (WebProxy)null, 60000);
				input = requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
				MatchCollection matchCollection = Regex.Matches(input, "verification_method\" value=\"(.*?)\"");
				if (matchCollection.Count > 0)
				{
					foreach (Match item in matchCollection)
					{
						text = text + item.Groups[1].Value + "-";
					}
					text = text.TrimEnd('-');
				}
				else if (input.Contains("full-name") || input.Contains("captcha"))
				{
					text += "72h";
				}
				else if (input.Contains("mvm uiP fsm"))
				{
					text += "vhh";
				}
				return text + "|" + requestHTTP.GetCookiesString("https://www.facebook.com/");
			}
			if (text2.Contains("id=\"email\"") || text2.Contains("id=\"pass\""))
			{
				return "3|";
			}
			return "1|" + requestHTTP.GetCookiesString("https://www.facebook.com/");
		}

		public static string SwapCheckpoint(string username, string password, string userAgent, string ip, int port)
		{
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2]
			{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: " + userAgent
			});
			requestHTTP.SetProxy(ip, port);
			requestHTTP.usProxy = true;
			string result = "";
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com");
			string value = Regex.Match(input, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string value2 = Regex.Match(input, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
			string value4 = Regex.Match(input, "\"li\" value=\"(.*?)\"").Groups[1].Value;
			byte[] bytes = ((Encoding)null).GetBytes("fb_dtsg=" + value + "%3D&jazoest=" + value2 + "&m_ts=" + value3 + "&li=" + value4 + "&try_number=0&unrecognized_tries=0&email=" + username + "&pass=" + password + "&login=Log+In");
			string text = requestHTTP.Request((string)(object)requestHTTP, "POST", (string[])(object)"https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", bytes, autoredrirect: true, (WebProxy)null, 60000);
			text = requestHTTP.Request("GET", "https://m.facebook.com/checkpoint/?next=https%3A%2F%2Fm.facebook.com%2F");
			text = requestHTTP.Request("GET", "https://mbasic.facebook.com/checkpoint/?next=https%3A%2F%2Fmbasic.facebook.com%2F");
			text = requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%www.facebook.com%2F");
			return result;
		}

		public static string GetCheckpointFromIdMethod(string idMethod)
		{
			string result = "";
			switch (idMethod)
			{
				case "3":
					result = "Ảnh";
					break;
				case "2":
					result = "Ngày sinh";
					break;
				case "20":
					result = "Tin nhắn";
					break;
				case "4":
					result = "Otp";
					break;
				case "34":
					result = "Otp";
					break;
				case "14":
					result = "Thiết bị";
					break;
				case "26":
					result = "Bạn bè";
					break;
				case "18":
					result = "Bình luận";
					break;
				case "72h":
					result = "72h";
					break;
				case "vhh":
					result = "Vô hiệu hóa";
					break;
			}
			return result;
		}

		public static List<string> RequestLoginUidPassMbasic(string username, string password)
		{
			//Discarded unreachable code: IL_0461, IL_047f
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			List<string> list = new List<string>();
			string input = requestHTTP.Request("GET", "https://mbasic.facebook.com");
			string value = Regex.Match(input, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string value2 = Regex.Match(input, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
			string value4 = Regex.Match(input, "\"li\" value=\"(.*?)\"").Groups[1].Value;
			string[] array = new string[1] { "referer: https://mbasic.facebook.com/checkpoint/?_rdr" };
			byte[] bytes = ((Encoding)null).GetBytes("fb_dtsg=" + value + "%3D&jazoest=" + value2 + "&m_ts=" + value3 + "&li=" + value4 + "&try_number=0&unrecognized_tries=0&email=" + username + "&pass=" + password + "&login=Log+In");
			string text = ((requestHTTP)/*Error near IL_02e9: Stack underflow*/).Request((string)(object)requestHTTP, "POST", (string[])(object)"https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", bytes, autoredrirect: true, (WebProxy)null, 60000);
			if (text.Contains("checkpoint_title"))
			{
				value = Regex.Match(text, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				value2 = Regex.Match(text, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
				string value5 = Regex.Match(input, "\"nh\" value=\"(.*?)\"").Groups[1].Value;
				input = requestHTTP.Request("GET", "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
				string value6 = Regex.Match(input, "<select name=\"verification_method(.*?)</select>").Value;
				MatchCollection matchCollection = Regex.Matches(value6, "\\d{2}");
				foreach (Match item in matchCollection)
				{
					list.Add(item.Value);
				}
			}
			return list;
		}

		public static bool CheckMailYahoo(string mail)
		{
			bool result = false;
			mail = mail.Replace("@yahoo.com", "");
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[5] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", "X-Requested-With: XMLHttpRequest", "Cookie: AS=v=1&s=jc8Jz1UA", "Referrer: https://login.yahoo.com/account/module/create?validateField=yid" });
			byte[] bytes = ((Encoding)null).GetBytes("browser-fp-data=&specId=yidReg&crumb=&acrumb=jc8Jz1UA&c=&s=&done=https%3A%2F%2Fwww.yahoo.com&googleIdToken=&authCode=&tos0=yahoo_freereg%7Cvn%7Cvi-VN&tos1=yahoo_comms_atos%7Cvn%7Cvi-VN&firstName=&lastName=&yid=" + mail + "&password=&shortCountryCode=VN&phone=&mm=&dd=&yyyy=&freeformGender=");
			string text = ((requestHTTP)/*Error near IL_0174: Stack underflow*/).Request((string)(object)requestHTTP, "POST", (string[])(object)"https://login.yahoo.com/account/module/create?validateField=yid", bytes, autoredrirect: true, (WebProxy)null, 60000);
			if (text.Contains("yid\",\"error"))
			{
				result = true;
			}
			return result;
		}

		public static bool CheckMailHotmail(string mail)
		{
			bool flag = false;
			mail = mail.Replace("@yahoo.com", "");
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			string json = requestHTTP.Request("GET", "https://login.microsoftonline.com/common/userrealm/?user=" + mail + "&api-version=2.1&stsRequest=rQIIAbPSySgpKSi20tcvyC8qSczRy81MLsovzk8ryc_LycxL1UvOz9XLL0rPTAGxioS4BC6HNYTFGB7zWy90MI6xcUHgKkZlwkboX2BkfMHIeItJ0L8o3TMlvNgtNSW1KLEkMz_vERNvaHFqkX9eTmVIfnZq3iRmvpz89My8-OKitPi0nPxyoADQhILE5JL4kszk7NSSXcwqiSaWqYZpKWm6xpZplromhiZmupYWiWa6FhYmZqaGFqlpFomJF1gEfrAwLmIFurmyae30LeVybvNE3C_Vi-5_e4pVPy_FOcvSIiIgNUPbJyU1KjE0PTcsMdezzCM5PN2oJN8zyN0g0MjZ3bzSuNzW0srwACcjAA2&checkForMicrosoftAccount=true").ToString();
			JObject jObject = JObject.Parse(json);
			if (jObject["MicrosoftAccount"].ToString().Equals("1"))
			{
				return false;
			}
			return true;
		}

		public static bool ChangePryvacyMail(string cookie)
		{
			//Discarded unreachable code: IL_0392, IL_03a5
			bool flag = true;
			try
			{
				string value = Regex.Match(cookie, "c_user=(.*?);").Groups[1].Value;
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.87 Safari/537.36",
				"cookie: " + cookie
				});
				string text = requestHTTP.Request("GET", "https://www.facebook.com/");
				if (!value.Equals("") && text.Contains(value) && text.Contains("name=\"fb_dtsg\" value="))
				{
					string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/settings/email/");
					string text2 = Regex.Match(input, "/privacyx/selector(.*?)\"").Value.Replace("amp;", "").Replace("\"", "");
					string input2 = requestHTTP.Request("GET", "https://mbasic.facebook.com" + text2 + "&priv_expand=see_all");
					string text3 = Regex.Match(input2, "/a/privacy/.px=286958161406148(.*?)\"").Value.Replace("amp;", "").Replace("\"", "");
					if (text3.Equals(""))
					{
						return false;
					}
					string text4 = requestHTTP.Request("GET", "https://mbasic.facebook.com" + text3);
					return true;
				}
				return false;
			}
			catch
			{
				return false;
			}
		}

		public static string LoadErrorFromErrorcode(string temp)
		{
			string result = "";
			if (temp.Split('|')[0] == "1")
			{
				switch (Convert.ToInt32(temp.Split('|')[1]))
				{
					case 401:
						result = "Changed pass";
						break;
					case 405:
						result = Language.GetValue("Checkpoint");
						break;
					case 400:
						result = "Tài khoản không tồn tại";
						break;
					case 613:
						result = "Giới hạn lấy token";
						break;
					case 104:
						result = "Lỗi phần mềm";
						break;
					default:
						result = "Lỗi hệ thống";
						break;
				}
			}
			return result;
		}

		public static string Encryptor(string str)
		{
			MD5 mD = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(str);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static void resetDcom(string profileName)
		{
			Process process = new Process();
			process.StartInfo.FileName = "rasdial.exe";
			process.StartInfo.Arguments = "\"" + profileName + "\" /disconnect";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(1000);
		}

		public static void DelayTime(double second)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(second * 1000.0));
		}

		public static void startDcom(string profileName)
		{
			Thread.Sleep(1000);
			Process process = new Process();
			process.StartInfo.FileName = "rasdial.exe";
			process.StartInfo.Arguments = "\"" + profileName + "\"";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(1500);
		}

		public static bool ChangeIP(int typeChangeIP, string profileDcom, int iTypeHotspot, string sLinkNord)
		{
			return true;
		}

		private static string RunCMD(string cmd)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + cmd;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}

		public static void KillProcessChromeDriver()
		{
			Process[] processesByName = Process.GetProcessesByName("chromedriver");
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}

		public static Point GetPointFromIndexPosition(int indexPos, int maxApp = 6)
		{
			Point result = default(Point);
			int num = 2 * getWidthScreen / maxApp;
			int num2 = maxApp / 2;
			while (indexPos > 5)
			{
				indexPos -= 6;
			}
			if (indexPos <= num2 - 1)
			{
				result.Y = 0;
			}
			else if (indexPos < maxApp)
			{
				result.Y = getHeightScreen / 2;
				indexPos -= num2;
			}
			result.X = indexPos * num;
			return result;
		}

		public static DataTable SearchAccount(string field, string keyword, int idfile)
		{
			//Discarded unreachable code: IL_06ce, IL_06db
			DataTable result = new DataTable();
			try
			{
				string text = "";
				switch (field)
				{
					case "all":
						text = "(uid like '%{0}%' OR token like '%{0}%' OR email like '%{0}%' OR phone like '%{0}%' OR name like '%{0}%' OR friends like '%{0}%' OR groups like '%{0}%' OR gender like '%{0}%' OR backup like '%{0}%' OR info like '%{0}%' OR pass like '%{0}%' OR cookie like '%{0}%' OR mailrecovery like '%{0}%' OR passmail like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "uid":
						text = "(uid like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "token":
						text = "(token like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "email":
						text = "(email like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "phone":
						text = "(phone like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "name":
						text = "(name like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "friend":
						text = "(friends like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "group":
						text = "(groups like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "birthday":
						text = "(birthday like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "gioitinh":
						text = "(gender like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "backup":
						text = "(backup like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "tinhtrang":
						text = "(info like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "pass":
						text = "(pass like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "cookie":
						text = "(cookie like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "mail":
						text = "(mailrecovery like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					case "passmail":
						text = "(passmail like '%{0}%')";
						text = string.Format(text, keyword);
						break;
					default:
						text = "(0 = 1)";
						break;
				}
				string query = "SELECT * FROM accounts WHERE idfile = " + idfile + " AND " + text;
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		private static string PrivateKey(string s)
		{
			return s + "minsoftware.tk";
		}

		public static string CreateRandomPassword(int length = 15)
		{
			string text = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			Random random = new Random();
			char[] array = new char[length];
			for (int i = 0; i < length - 2; i++)
			{
				array[i] = text[random.Next(0, text.Length)];
			}
			array[13] = '1';
			array[14] = 'T';
			return new string(array);
		}

		public static bool HasMethod(object objectToCheck, string methodName)
		{
			Type type = objectToCheck.GetType();
			return type.GetMethod(methodName) != null;
		}

		public static string Decode_UTF8(string s)
		{
			byte[] bytes = Encoding.Default.GetBytes(s);
			_ = Encoding.UTF8;
			return (string)(object)bytes;
		}

		public static double CompareTwoString(string str1, string str2)
		{
			double num = 0.0;
			string[] array = str2.Split(' ');
			for (int i = 0; i < array.Length; i++)
			{
				if (str2 != "" && str1.Contains(" " + array[i] + " "))
				{
					num += 1.0;
				}
			}
			return num / (double)array.Length;
		}

		public static string CheckSsh(string ssh)
		{
			//Discarded unreachable code: IL_00d5, IL_0103
			int portAvailable = BitviseHandle.GetPortAvailable();
			try
			{
				return BitviseHandle.Connect(ssh.Split('|')[0], ssh.Split('|')[1], ssh.Split('|')[2], portAvailable) ? ("1|" + portAvailable) : ("0|" + portAvailable);
			}
			catch
			{
				return "0|" + portAvailable;
			}
		}

		private static string MaHoa(string x)
		{
			MD5 mD = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(x);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X"));
			}
			return stringBuilder.ToString();
		}

		public static string GetIdKey(string a = "")
		{
			string x = new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
				.AddSystemDriveSerialNumber()
				.ToString();
			return MaHoa(x);
		}

		public static string GetAccessKey(string a = "")
		{
			if (a.Equals(""))
			{
				a = GetIdKey();
			}
			return EncodeMD5(PrivateKey(a));
		}

		public static string EncodeMD5(string txt)
		{
			string text = "";
			byte[] bytes = Encoding.UTF8.GetBytes(txt);
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
			byte[] array = bytes;
			foreach (byte b in array)
			{
				text += b.ToString("X2");
			}
			return text.ToLower();
		}

		public static string GetUUID()
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "CMD.exe",
				Arguments = "/C wmic csproduct get UUID"
			};
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			string text = process.StandardOutput.ReadToEnd();
			return text.Replace("UUID", "").Replace("\n", "").Replace(" ", "")
				.Replace("-", "")
				.Replace("\r", "");
		}

		public static string GetIdCpu()
		{
			//Discarded unreachable code: IL_0085, IL_0098
			string result = string.Empty;
			ManagementClass managementClass = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
			{
				if (managementObjectEnumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
					result = managementObject.Properties["processorID"].Value.ToString();
				}
			}
			return result;
		}

		public static void Shutdown()
		{
			//Discarded unreachable code: IL_0109, IL_011c
			ManagementBaseObject managementBaseObject = null;
			ManagementClass managementClass = new ManagementClass("Win32_OperatingSystem");
			managementClass.Get();
			managementClass.Scope.Options.EnablePrivileges = true;
			ManagementBaseObject methodParameters = managementClass.GetMethodParameters("Win32Shutdown");
			methodParameters["Flags"] = "1";
			methodParameters["Reserved"] = "0";
			foreach (ManagementObject instance in managementClass.GetInstances())
			{
				managementBaseObject = instance.InvokeMethod("Win32Shutdown", methodParameters, null);
			}
		}

		public static string CheckKeyAndLoginPro(string userName, string passWord, string idKey = "", int softIndex = 11)
		{
			if (idKey.Equals(""))
			{
				idKey = GetIdKey();
			}
			RequestHTTP requestHTTP = new RequestHTTP();
			requestHTTP.SetSSL(SecurityProtocolType.Tls12);
			requestHTTP.SetKeepAlive(k: true);
			requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
			Decryptor decryptor = new Decryptor();
			Random random = new Random();
			int num = random.Next(0, 999999);
			global::License.License license = new global::License.License(userName, passWord, idKey, softIndex.ToString(), num.ToString());
			string text = license.CheckLic();
			if (text == "error")
			{
				return "error";
			}
			string encryptedBase = Base64Decode(text);
			string text2 = decryptor.Decrypt(encryptedBase, "MINSOFTWARE_KEY_PRO" + num);
			if (text2 == "" || text2 == "null")
			{
				return "error";
			}
			return text2;
		}

		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		public static bool IsValidMail(string emailaddress)
		{
			//Discarded unreachable code: IL_0019, IL_002b
			try
			{
				MailAddress mailAddress = new MailAddress(emailaddress);
				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		public static string ConvertToStandardCookie(string cookie)
		{
			//Discarded unreachable code: IL_00aa, IL_00be
			try
			{
				string value = Regex.Match(cookie, "c_user=(.*?);").Value;
				string value2 = Regex.Match(cookie, "xs=(.*?);").Value;
				string value3 = Regex.Match(cookie, "fr=(.*?);").Value;
				string value4 = Regex.Match(cookie, "datr=(.*?);").Value;
				return value + value2 + value3 + value4;
			}
			catch
			{
				return cookie;
			}
		}

		public static void DisconnectSshPort(int port)
		{
			//Discarded unreachable code: IL_0014, IL_0021
			try
			{
				BitviseHandle.Disconnect(port);
			}
			catch
			{
			}
		}

		public static List<string> GetGroupFromCookie(string cookie, string uA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
		{
			//Discarded unreachable code: IL_0190, IL_019d, IL_01c6, IL_01d3
			cookie = ConvertToStandardCookie(cookie);
			List<string> list = new List<string>();
			try
			{
				RequestHTTP requestHTTP = new RequestHTTP();
				requestHTTP.SetSSL(SecurityProtocolType.Tls12);
				requestHTTP.SetKeepAlive(k: true);
				requestHTTP.SetDefaultHeaders(new string[3]
				{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: " + uA,
				"cookie: " + cookie
				});
				string input = requestHTTP.Request("GET", "https://mbasic.facebook.com/groups/?seemore");
				MatchCollection matchCollection = Regex.Matches(input, "<a href=\"/groups/[0-9]+\\?refid=27");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					try
					{
						string text = Regex.Match(matchCollection[i].Value, "groups/(.*?)\\?refid=27").Groups[1].Value.ToString();
						if (text != "")
						{
							list.Add(text);
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return list;
		}

		public static string ToUnicode(string str)
		{
			for (int i = 1; i < VietNamChar.Length; i++)
			{
				for (int j = 0; j < VietNamChar[i].Length; j++)
				{
					str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
				}
			}
			return str;
		}
	}

}