using System;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace Common
{
	// Token: 0x0200005B RID: 91
	public class CommonChromeDriver
	{
		// Token: 0x0600037B RID: 891 RVA: 0x0003F4B0 File Offset: 0x0003D6B0
		public static ChromeDriver OpenChrome(ChromeDriver chrome, bool isHideChrome, bool isHideImage, bool isDisableSound, string UserAgent, string LinkProfile, Point Size, Point Position, string Proxy, int TimeWaitForSearchingElement = 0, int TimeWaitForLoadingPage = 60)
		{
			ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
			chromeDriverService.HideCommandPromptWindow = true;
			ChromeOptions chromeOptions = new ChromeOptions();
			chromeOptions.AddArguments(new string[]
			{
				"--disable-notifications",
				"--window-size=" + Size.X.ToString() + "," + Size.Y.ToString(),
				"--window-position=" + Position.X.ToString() + "," + Position.Y.ToString(),
				"--no-sandbox",
				"--disable-gpu",
				"--disable-dev-shm-usage",
				"--disable-web-security",
				"--disable-rtc-smoothness-algorithm",
				"--disable-webrtc-hw-decoding",
				"--disable-webrtc-hw-encoding",
				"--disable-webrtc-multiple-routes",
				"--disable-webrtc-hw-vp8-encoding",
				"--enforce-webrtc-ip-permission-check",
				"--force-webrtc-ip-handling-policy",
				"--ignore-certificate-errors",
				"--disable-infobars",
				"--disable-popup-blocking"
			});
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
			chromeOptions.AddUserProfilePreference("useAutomationExtension", true);
			if (isDisableSound)
			{
				chromeOptions.AddArgument("--mute-audio");
			}
			bool flag = !isHideChrome;
			if (flag)
			{
				if (isHideImage)
				{
					chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
				}
				bool flag2 = !string.IsNullOrEmpty(LinkProfile.Trim());
				if (flag2)
				{
					chromeOptions.AddArgument("--user-data-dir=" + LinkProfile);
				}
			}
			else
			{
				chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
				chromeOptions.AddArgument("--headless");
			}
			bool flag3 = !string.IsNullOrEmpty(Proxy.Trim());
			if (flag3)
			{
				chromeOptions.AddArgument("--proxy-server= 127.0.0.1:" + Proxy);
			}
			bool flag4 = !string.IsNullOrEmpty(UserAgent.Trim());
			if (flag4)
			{
				chromeOptions.AddArgument("--user-agent=" + UserAgent);
			}
			chrome = new ChromeDriver(chromeDriverService, chromeOptions);
			chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds((double)TimeWaitForSearchingElement);
			chrome.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds((double)TimeWaitForLoadingPage);
			return chrome;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0003FBD4 File Offset: 0x0003DDD4
		public static void QuitChrome(ChromeDriver chrome)
		{
			try
			{
				chrome.Quit();
			}
			catch
			{
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0003FC18 File Offset: 0x0003DE18
		public static bool CheckChromeClosed(ChromeDriver chrome)
		{
			bool result = true;
			try
			{
				string title = chrome.Title;
				result = false;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0003FC70 File Offset: 0x0003DE70
		public static bool CheckExistElement(ChromeDriver chrome, int typeAttribute, string attributeValue, int timeOut = 0)
		{
			bool flag = false;
			TimeSpan implicitWait = chrome.Manage().Timeouts().ImplicitWait;
			chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(0.0);
			int tickCount = Environment.TickCount;
			bool flag3;
			do
			{
				switch (typeAttribute)
				{
				case 1:
					flag = (chrome.FindElementsById(attributeValue).Count > 0);
					break;
				case 2:
					flag = (chrome.FindElementsByName(attributeValue).Count > 0);
					break;
				case 3:
					flag = (chrome.FindElementsByXPath(attributeValue).Count > 0);
					break;
				}
				bool flag2 = flag;
				if (flag2)
				{
					break;
				}
				flag3 = (Environment.TickCount - tickCount > timeOut * 1000);
			}
			while (!flag3);
			chrome.Manage().Timeouts().ImplicitWait = implicitWait;
			return flag;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0003FDC4 File Offset: 0x0003DFC4
		public static bool NavigateChrome(ChromeDriver chrome, string url)
		{
			bool result = false;
			try
			{
				chrome.Navigate().GoToUrl(url);
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0003FE28 File Offset: 0x0003E028
		public static bool ScrollChrome(ChromeDriver chrome, int x, int y)
		{
			bool result = false;
			try
			{
				string script = string.Format("window.scrollTo({0}, {1})", x, y);
				chrome.ExecuteScript(script, Array.Empty<object>());
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0003FEB8 File Offset: 0x0003E0B8
		public static bool SendKeysChrome(ChromeDriver chrome, int typeAttribute, string attributeValue, string content, double timeDelay)
		{
			bool result = false;
			try
			{
				for (int i = 0; i < content.Length; i++)
				{
					switch (typeAttribute)
					{
					case 1:
						chrome.FindElementById(attributeValue).SendKeys(content[i].ToString());
						break;
					case 2:
						chrome.FindElementByName(attributeValue).SendKeys(content[i].ToString());
						break;
					case 3:
						chrome.FindElementByXPath(attributeValue).SendKeys(content[i].ToString());
						break;
					}
					bool flag = i < content.Length - 1;
					if (flag)
					{
						Thread.Sleep(Convert.ToInt32(timeDelay * 1000.0));
					}
				}
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00040038 File Offset: 0x0003E238
		public static bool SendKeysChrome(ChromeDriver chrome, int typeAttribute, string attributeValue, string content)
		{
			bool result = false;
			try
			{
				switch (typeAttribute)
				{
				case 1:
					chrome.FindElementById(attributeValue).SendKeys(content);
					break;
				case 2:
					chrome.FindElementByName(attributeValue).SendKeys(content);
					break;
				case 3:
					chrome.FindElementByXPath(attributeValue).SendKeys(content);
					break;
				}
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00040114 File Offset: 0x0003E314
		public static bool ClickChrome(ChromeDriver chrome, int typeAttribute, string attributeValue)
		{
			bool result = false;
			try
			{
				switch (typeAttribute)
				{
				case 1:
					chrome.FindElementById(attributeValue).Click();
					break;
				case 2:
					chrome.FindElementByName(attributeValue).Click();
					break;
				case 3:
					chrome.FindElementByXPath(attributeValue).Click();
					break;
				}
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000401E0 File Offset: 0x0003E3E0
		public static bool ExecuteScriptChrome(ChromeDriver chrome, string script)
		{
			bool result = false;
			try
			{
				chrome.ExecuteScript(script, Array.Empty<object>());
				result = true;
			}
			catch
			{
			}
			return result;
		}
	}
}
