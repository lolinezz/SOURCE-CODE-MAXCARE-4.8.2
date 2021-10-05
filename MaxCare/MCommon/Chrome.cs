using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using maxcare;
using maxcare.Enum;
using maxcare.Properties;
using MaxCare.maxcare.Properties;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace MCommon
{
	// MCommon.Chrome
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Drawing;
	using System.IO;
	using System.IO.Compression;
	using System.Linq;
	using System.Threading;
	using maxcare;
	using maxcare.Enum;
	using maxcare.Properties;
	using MCommon;
	using Newtonsoft.Json.Linq;
	using OpenQA.Selenium;
	using OpenQA.Selenium.Chrome;
	using OpenQA.Selenium.Interactions;
	using OpenQA.Selenium.Support.UI;

	public class Chrome
	{
		public int IndexChrome;

		private Random rd;

		public Process process { get; set; }

		public ChromeDriver chrome { get; set; }

		public bool HideBrowser { get; set; }

		public bool Incognito { get; set; }

		public bool DisableImage { get; set; }

		public bool DisableSound { get; set; }

		public bool AutoPlayVideo { get; set; }

		public string UserAgent { get; set; }

		public int PixelRatio { get; set; }

		public string ProfilePath { get; set; }

		public Point Size { get; set; }

		public Point Position { get; set; }

		public int TimeWaitForSearchingElement { get; set; }

		public int TimeWaitForLoadingPage { get; set; }

		public string Proxy { get; set; }

		public int TypeProxy { get; set; }

		public string App { get; set; }

		public string LinkToOtherBrowser { get; set; }

		public string PathExtension { get; set; }

		public bool IsUseEmulator { get; set; }

		public bool IsUsePortable { get; set; }

		public string PathToPortableZip { get; set; }

		public Point Size_Emulator { get; set; }

		public StatusChromeAccount Status { get; set; }

		public Chrome()
		{
			IndexChrome = 0;
			HideBrowser = false;
			DisableImage = false;
			DisableSound = false;
			Incognito = false;
			UserAgent = "";
			ProfilePath = "";
			Size = new Point(300, 300);
			Size = new Point(Size.X, Size.Y);
			Proxy = "";
			TypeProxy = 0;
			Position = new Point(Position.X, Position.Y);
			TimeWaitForSearchingElement = 0;
			TimeWaitForLoadingPage = 1;
			App = "";
			AutoPlayVideo = false;
			LinkToOtherBrowser = "";
			PathExtension = "data\\extension";
			IsUseEmulator = false;
			Size_Emulator = new Point(300, 300);
			Status = StatusChromeAccount.Empty;
			IsUsePortable = false;
			PathToPortableZip = "";
			rd = new Random();
		}

		public bool Open(bool isGetUseragentDefault = false)
		{
			//Discarded unreachable code: IL_083e, IL_084c, IL_0ed0, IL_0efc
			bool result = false;
			try
			{
				ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
				chromeDriverService.HideCommandPromptWindow = true;
				ChromeOptions chromeOptions = new ChromeOptions();
				chromeOptions.AddArguments("--disable-3d-apis", "--disable-background-networking", "--disable-bundled-ppapi-flash", "--disable-client-side-phishing-detection", "--disable-default-apps", "--disable-hang-monitor", "--disable-prompt-on-repost", "--disable-sync", "--disable-webgl", "--enable-blink-features=ShadowDOMV0", "--enable-logging", "--disable-notifications", "--window-size=" + Size.X + "," + Size.Y, "--window-position=" + Position.X + "," + Position.Y, "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-blink-features=\"BlockCredentialedSubresources\"", "--disable-popup-blocking");
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 0);
				if (DisableSound)
				{
					chromeOptions.AddArgument("--mute-audio");
				}
				chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
				chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
				chromeOptions.AddExcludedArgument("enable-automation");
				chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
				if (LinkToOtherBrowser != "" && File.Exists(LinkToOtherBrowser))
				{
					chromeOptions.BinaryLocation = LinkToOtherBrowser;
				}
				if (IsUsePortable)
				{
					if (!string.IsNullOrEmpty(ProfilePath.Trim()))
					{
						if (!Directory.Exists(ProfilePath))
						{
							ZipFile.ExtractToDirectory(PathToPortableZip, ProfilePath);
						}
						chromeOptions.BinaryLocation = ProfilePath + "\\App\\Chrome-bin\\chrome.exe";
						if (!HideBrowser)
						{
							if (DisableImage)
							{
								chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
							}
							chromeOptions.AddArgument("--user-data-dir=" + ProfilePath + "\\Data\\profile");
						}
						else
						{
							chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
							chromeOptions.AddArgument("--headless");
						}
					}
				}
				else if (!HideBrowser)
				{
					if (DisableImage)
					{
						chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
					}
					if (!string.IsNullOrEmpty(ProfilePath.Trim()))
					{
						try
						{
							chromeOptions.AddArgument("--user-data-dir=" + ProfilePath);
							File.Delete(ProfilePath + "\\Default\\Secure Preferences");
							string json = File.ReadAllText(ProfilePath + "\\Default\\Preferences");
							JObject jObject = JObject.Parse(json);
							jObject["profile"]["exit_type"] = "none";
							File.WriteAllText(ProfilePath + "\\Default\\Preferences", jObject.ToString());
						}
						catch (Exception)
						{
						}
					}
				}
				else
				{
					chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
					chromeOptions.AddArgument("--headless");
				}
				if (Incognito)
				{
					chromeOptions.AddArguments("--incognito");
				}
				if (!string.IsNullOrEmpty(Proxy.Trim()))
				{
					switch (Proxy.Split(':').Count())
					{
						case 1:
							if (TypeProxy == 0)
							{
								chromeOptions.AddArgument("--proxy-server= 127.0.0.1:" + Proxy);
							}
							else
							{
								chromeOptions.AddArgument("--proxy-server= socks5://127.0.0.1:" + Proxy);
							}
							break;
						case 2:
							if (TypeProxy == 0)
							{
								chromeOptions.AddArgument("--proxy-server= " + Proxy);
							}
							else
							{
								chromeOptions.AddArgument("--proxy-server= socks5://" + Proxy);
							}
							break;
						case 4:
							if (TypeProxy == 0)
							{
								chromeOptions.AddArgument("--proxy-server= " + Proxy.Split(':')[0] + ":" + Proxy.Split(':')[1]);
								chromeOptions.AddExtension("extension\\proxy1.crx");
							}
							else
							{
								chromeOptions.AddArgument("--proxy-server= socks5://" + Proxy.Split(':')[0] + ":" + Proxy.Split(':')[1]);
								chromeOptions.AddExtension("extension\\proxy1.crx");
							}
							break;
					}
				}
				if (!isGetUseragentDefault)
				{
					chromeOptions.AddArgument("--user-agent=" + UserAgent);
				}
				bool flag = false;
				if (!HideBrowser && PathExtension.Trim() != "")
				{
					if (!Directory.Exists(PathExtension))
					{
						Directory.CreateDirectory(PathExtension);
					}
					string[] files = Directory.GetFiles(PathExtension);
					if (files.Length != 0)
					{
						flag = true;
					}
					for (int i = 0; i < files.Length; i++)
					{
						chromeOptions.AddExtension(files[i]);
					}
				}
				if (!flag && !string.IsNullOrEmpty(App.Trim()))
				{
					chromeOptions.AddArgument("--app= " + App);
				}
				if (IsUseEmulator)
				{
					ChromeMobileEmulationDeviceSettings deviceSettings = new ChromeMobileEmulationDeviceSettings
					{
						EnableTouchEvents = true,
						Width = Size_Emulator.X,
						Height = Size_Emulator.Y,
						UserAgent = UserAgent,
						PixelRatio = PixelRatio
					};
					chromeOptions.EnableMobileEmulation(deviceSettings);
				}
				if (AutoPlayVideo)
				{
					chromeOptions.AddArgument("--autoplay-policy=no-user-gesture-required");
				}
				chrome = new ChromeDriver(chromeDriverService, chromeOptions);
				chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeWaitForSearchingElement);
				chrome.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(TimeWaitForLoadingPage);
				if (Settings.Default.PathChrome == "")
				{
					chrome.Close();
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex2)
			{
				ExportError(null, ex2, "chrome.Open()");
			}
			return result;
		}

		public string GetPageSource()
		{
			//Discarded unreachable code: IL_004d, IL_005a
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				return chrome.PageSource;
			}
			catch (Exception)
			{
			}
			return "";
		}

		public bool CheckIsLive()
		{
			return !CheckChromeClosed();
		}

		public bool CheckChromeClosed()
		{
			//Discarded unreachable code: IL_0052, IL_007e
			if (process != null)
			{
				return process.HasExited;
			}
			bool result = true;
			try
			{
				string title = chrome.Title;
				result = false;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.CheckChromeClosed()");
			}
			return result;
		}

		public bool CreateShortcut(string shortcutName, string shortcutPath, string icon = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string targetFileLocation = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
		{
			//Discarded unreachable code: IL_0096, IL_0151
			bool result = false;
			try
			{
				MCommon.Common.CreateShortcut(shortcutName, shortcutPath, targetFileLocation, "--user-data-dir=\"" + ProfilePath + "\"", targetFileLocation.Substring(0, targetFileLocation.LastIndexOf("\\")), icon);
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.CreateShortcut(" + shortcutName + "," + shortcutPath + "," + targetFileLocation + ")");
			}
			return result;
		}

		public string GetCssSelector(string querySelector, string attributeName, string attributeValue)
		{
			//Discarded unreachable code: IL_0115, IL_01d0
			string result = "";
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + querySelector + "','" + attributeName + "','" + attributeValue + "')").ToString();
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GetCssSelector(" + querySelector + "," + attributeName + "," + attributeValue + ")");
			}
			return result;
		}

		public string GetCssSelector(string querySelector)
		{
			//Discarded unreachable code: IL_00a4, IL_00ee
			string result = "";
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; return GetSelector(" + querySelector + ")").ToString();
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GetCssSelector(" + querySelector + ")");
			}
			return result;
		}

		public string GetAttributeValue(string querySelector, string attributeName)
		{
			//Discarded unreachable code: IL_00ec, IL_017e
			string result = "";
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("return document.querySelector('" + querySelector + "').getAttribute('" + attributeName + "')").ToString();
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GetAttributeValue(" + querySelector + "," + attributeName + ")");
			}
			return result;
		}

		public int ScrollSmooth(int distance)
		{
			//Discarded unreachable code: IL_0111, IL_014d
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				int num = Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
				chrome.ExecuteScript("window.scrollBy({ top: " + distance + ",behavior: 'smooth'});");
				DelayTime(0.1);
				if (num == Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString()))
				{
					return 2;
				}
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.ScrollSmooth({distance})");
			}
			return 1;
		}

		public string GetUseragent()
		{
			//Discarded unreachable code: IL_0083, IL_0090
			string result = "";
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				result = chrome.ExecuteScript("return navigator.userAgent").ToString();
			}
			catch
			{
			}
			return result;
		}

		public int SendKeyDown(int typeAttribute, string attributeValue)
		{
			//Discarded unreachable code: IL_0103, IL_0145
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				switch (typeAttribute)
				{
					case 1:
						chrome.FindElementById(attributeValue).SendKeys(Keys.ArrowDown);
						break;
					case 2:
						chrome.FindElementByName(attributeValue).SendKeys(Keys.ArrowDown);
						break;
					case 3:
						chrome.FindElementByXPath(attributeValue).SendKeys(Keys.ArrowDown);
						break;
					case 4:
						chrome.FindElementByCssSelector(attributeValue).SendKeys(Keys.ArrowDown);
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendKeyDown({typeAttribute},{attributeValue})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeyEnd(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0, int times = 1)
		{
			//Discarded unreachable code: IL_02be, IL_0300
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			for (int i = 0; i < times; DelayTime(1.0), i++)
			{
				try
				{
					if (subTypeAttribute == 0)
					{
						switch (typeAttribute)
						{
							case 1:
								chrome.FindElementsById(attributeValue)[index].SendKeys(Keys.End);
								break;
							case 2:
								chrome.FindElementsByName(attributeValue)[index].SendKeys(Keys.End);
								break;
							case 3:
								chrome.FindElementsByXPath(attributeValue)[index].SendKeys(Keys.End);
								break;
							case 4:
								chrome.FindElementsByCssSelector(attributeValue)[index].SendKeys(Keys.End);
								break;
						}
					}
					else
					{
						switch (typeAttribute)
						{
							case 1:
								chrome.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex].SendKeys(Keys.End);
								break;
							case 2:
								chrome.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex].SendKeys(Keys.End);
								break;
							case 3:
								chrome.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex].SendKeys(Keys.End);
								break;
							case 4:
								chrome.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex].SendKeys(Keys.End);
								break;
						}
					}
					flag = true;
				}
				catch (Exception ex)
				{
					ExportError(null, ex, $"chrome.End({typeAttribute},{attributeValue})");
					continue;
				}
				break;
			}
			return flag ? 1 : 0;
		}

		public string GetURL()
		{
			//Discarded unreachable code: IL_004e, IL_0078
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				return chrome.Url;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GetURL()");
			}
			return "";
		}

		public int GotoURL(string url)
		{
			//Discarded unreachable code: IL_0056, IL_00a0
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				chrome.Navigate().GoToUrl(url);
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GotoURL(" + url + ")");
			}
			return flag ? 1 : 0;
		}

		public int GotoURLIfNotExist(string url)
		{
			//Discarded unreachable code: IL_0073, IL_00bf
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (GetURL() != url)
				{
					chrome.Navigate().GoToUrl(url);
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GotoURL(" + url + ")");
			}
			return flag ? 1 : 0;
		}

		public int Refresh()
		{
			//Discarded unreachable code: IL_0050, IL_007a
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				chrome.Navigate().Refresh();
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.Refresh()");
			}
			return flag ? 1 : 0;
		}

		public int GotoBackPage(int times = 1)
		{
			//Discarded unreachable code: IL_008c, IL_00b8
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				for (int i = 0; i < times; i++)
				{
					chrome.Navigate().Back();
					DelayTime(0.5);
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GotoBackPage()");
			}
			return flag ? 1 : 0;
		}

		public int HoverElement(int typeAttribute, string attributeValue, int index, double timeHover_second)
		{
			//Discarded unreachable code: IL_01aa, IL_01f7
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				WebDriverWait webDriverWait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10.0));
				switch (typeAttribute)
				{
					case 1:
						new Actions(chrome).MoveToElement(chrome.FindElementsById(attributeValue)[index]).Perform();
						break;
					case 2:
						new Actions(chrome).MoveToElement(chrome.FindElementsByName(attributeValue)[index]).Perform();
						break;
					case 3:
						new Actions(chrome).MoveToElement(chrome.FindElementsByXPath(attributeValue)[index]).Perform();
						break;
					case 4:
						new Actions(chrome).MoveToElement(chrome.FindElementsByCssSelector(attributeValue)[index]).Perform();
						break;
				}
				Thread.Sleep(Convert.ToInt32(timeHover_second * 1000.0));
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.HoverElement({typeAttribute}, {attributeValue}, {timeHover_second})");
			}
			return flag ? 1 : 0;
		}

		public int HoverElement(int typeAttribute, string attributeValue, double timeHover_second)
		{
			//Discarded unreachable code: IL_017f, IL_01cc
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				WebDriverWait webDriverWait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10.0));
				switch (typeAttribute)
				{
					case 1:
						new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(attributeValue)))).Perform();
						break;
					case 2:
						new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(attributeValue)))).Perform();
						break;
					case 3:
						new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(attributeValue)))).Perform();
						break;
					case 4:
						new Actions(chrome).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(attributeValue)))).Perform();
						break;
				}
				Thread.Sleep(Convert.ToInt32(timeHover_second * 1000.0));
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.HoverElement({typeAttribute}, {attributeValue}, {timeHover_second})");
			}
			return flag ? 1 : 0;
		}

		public bool MoveToElement(int typeAttribute, string attributeValue, int index)
		{
			//Discarded unreachable code: IL_015b, IL_01a6
			bool result = true;
			try
			{
				switch (typeAttribute)
				{
					case 1:
						new Actions(chrome).MoveToElement(chrome.FindElementsById(attributeValue)[index]).Build().Perform();
						break;
					case 2:
						new Actions(chrome).MoveToElement(chrome.FindElementsByName(attributeValue)[index]).Build().Perform();
						break;
					case 3:
						new Actions(chrome).MoveToElement(chrome.FindElementsByXPath(attributeValue)[index]).Build().Perform();
						break;
					case 4:
						new Actions(chrome).MoveToElement(chrome.FindElementsByCssSelector(attributeValue)[index]).Build().Perform();
						break;
				}
				result = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.MoveToElement({typeAttribute},{attributeValue},{index})");
			}
			return result;
		}

		public object ExecuteScript(string script)
		{
			//Discarded unreachable code: IL_004e, IL_0098
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				return chrome.ExecuteScript(script);
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.ExecuteScript(" + script + ")");
			}
			return "";
		}

		public Image CaptureWindow(IntPtr handle)
		{
			IntPtr windowDC = User32.GetWindowDC(handle);
			User32.RECT rect = default(User32.RECT);
			User32.GetWindowRect(handle, ref rect);
			int nWidth = rect.right - rect.left;
			int nHeight = rect.bottom - rect.top;
			IntPtr intPtr = GDI32.CreateCompatibleDC(windowDC);
			IntPtr intPtr2 = GDI32.CreateCompatibleBitmap(windowDC, nWidth, nHeight);
			IntPtr hObject = GDI32.SelectObject(intPtr, intPtr2);
			GDI32.BitBlt(intPtr, 0, 0, nWidth, nHeight, windowDC, 0, 0, 13369376);
			GDI32.SelectObject(intPtr, hObject);
			GDI32.DeleteDC(intPtr);
			User32.ReleaseDC(handle, windowDC);
			Image result = Image.FromHbitmap(intPtr2);
			GDI32.DeleteObject(intPtr2);
			return result;
		}

		public Bitmap ScreenCapture(int count = 1)
		{
			//Discarded unreachable code: IL_0037, IL_0075, IL_0099, IL_00c5
			Bitmap result = null;
			try
			{
				for (int i = 0; i < count; i++)
				{
					try
					{
						result = (Bitmap)CaptureWindow(process.MainWindowHandle);
					}
					catch (Exception ex)
					{
						ExportError(this, ex, "CaptureWindow");
						MCommon.Common.DelayTime(1.0);
						continue;
					}
					break;
				}
			}
			catch (Exception ex2)
			{
				ExportError(null, ex2, "AutoChrome.ScreenCapture()");
			}
			return result;
		}

		public bool CheckExistImage(string ImagePath, int timeSearchImage_Second = 0)
		{
			if (FindImage(ImagePath, timeSearchImage_Second).HasValue)
			{
				return true;
			}
			return false;
		}

		public Point? FindImage(string ImagePath, int timeSearchImage_Second = 0)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(ImagePath);
			FileInfo[] files = directoryInfo.GetFiles();
			int tickCount = Environment.TickCount;
			do
			{
				Bitmap bitmap = ScreenCapture(3);
				if (bitmap == null)
				{
					break;
				}
				Point? point = null;
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					Bitmap subBitmap = (Bitmap)Image.FromFile(fileInfo.FullName);
					point = ImageScanOpenCV.FindOutPoint(bitmap, subBitmap);
					if (point.HasValue)
					{
						int x = point.Value.X;
						int y = point.Value.Y;
						return new Point(x, y);
					}
				}
				MCommon.Common.DelayTime(1.0);
			}
			while (Environment.TickCount - tickCount <= timeSearchImage_Second * 1000);
			return null;
		}

		public int Click(string ImagePath, int timeSearchImage_Second = 0)
		{
			//Discarded unreachable code: IL_00a3, IL_00b0
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				Point? point = FindImage(ImagePath, timeSearchImage_Second);
				if (point.HasValue)
				{
					AutoControl.SendClickOnPosition(process.MainWindowHandle, point.Value.X, point.Value.Y);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		public int Click(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0, int times = 1)
		{
			//Discarded unreachable code: IL_0296, IL_02d8
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			for (int i = 0; i < times; DelayTime(1.0), i++)
			{
				try
				{
					if (subTypeAttribute == 0)
					{
						switch (typeAttribute)
						{
							case 1:
								chrome.FindElementsById(attributeValue)[index].Click();
								break;
							case 2:
								chrome.FindElementsByName(attributeValue)[index].Click();
								break;
							case 3:
								chrome.FindElementsByXPath(attributeValue)[index].Click();
								break;
							case 4:
								chrome.FindElementsByCssSelector(attributeValue)[index].Click();
								break;
						}
					}
					else
					{
						switch (typeAttribute)
						{
							case 1:
								chrome.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex].Click();
								break;
							case 2:
								chrome.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex].Click();
								break;
							case 3:
								chrome.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex].Click();
								break;
							case 4:
								chrome.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex].Click();
								break;
						}
					}
					flag = true;
				}
				catch (Exception ex)
				{
					ExportError(null, ex, $"chrome.Click({typeAttribute},{attributeValue})");
					continue;
				}
				break;
			}
			return flag ? 1 : 0;
		}

		public int FindAndClick(double timeWait_Second, int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0)
		{
			//Discarded unreachable code: IL_02ab, IL_02b9, IL_0315, IL_03c4
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					try
					{
						if (subTypeAttribute == 0)
						{
							switch (typeAttribute)
							{
								case 1:
									chrome.FindElementsById(attributeValue)[index].Click();
									break;
								case 2:
									chrome.FindElementsByName(attributeValue)[index].Click();
									break;
								case 3:
									chrome.FindElementsByXPath(attributeValue)[index].Click();
									break;
								case 4:
									chrome.FindElementsByCssSelector(attributeValue)[index].Click();
									break;
							}
						}
						else
						{
							switch (typeAttribute)
							{
								case 1:
									chrome.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex].Click();
									break;
								case 2:
									chrome.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex].Click();
									break;
								case 3:
									chrome.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex].Click();
									break;
								case 4:
									chrome.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex].Click();
									break;
							}
						}
						flag = true;
						DelayTime(1.0);
					}
					catch (Exception)
					{
						goto IL_02be;
					}
					break;
				IL_02be:
					if ((double)(Environment.TickCount - tickCount) >= timeWait_Second * 1000.0)
					{
						break;
					}
					DelayTime(1.0);
				}
			}
			catch (Exception ex2)
			{
				ExportError(null, ex2, $"chrome.FindAndClick({timeWait_Second},{typeAttribute},{attributeValue},{index},{subTypeAttribute},{subAttributeValue},{subIndex}");
			}
			return flag ? 1 : 0;
		}

		public int ClickWithAction(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0)
		{
			//Discarded unreachable code: IL_0331, IL_0373
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (subTypeAttribute != 0)
				{
					switch (typeAttribute)
					{
						case 1:
							new Actions(chrome).Click(chrome.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex]).Perform();
							break;
						case 2:
							new Actions(chrome).Click(chrome.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex]).Perform();
							break;
						case 3:
							new Actions(chrome).Click(chrome.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex]).Perform();
							break;
						case 4:
							new Actions(chrome).Click(chrome.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex]).Perform();
							break;
					}
				}
				else
				{
					switch (typeAttribute)
					{
						case 1:
							new Actions(chrome).Click(chrome.FindElementsById(attributeValue)[index]).Perform();
							break;
						case 2:
							new Actions(chrome).Click(chrome.FindElementsByName(attributeValue)[index]).Perform();
							break;
						case 3:
							new Actions(chrome).Click(chrome.FindElementsByXPath(attributeValue)[index]).Perform();
							break;
						case 4:
							new Actions(chrome).Click(chrome.FindElementsByCssSelector(attributeValue)[index]).Perform();
							break;
					}
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.ClickWithAction({typeAttribute},{attributeValue})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeys(int typeAttribute, string attributeValue, string content, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			//Discarded unreachable code: IL_016a, IL_01e3
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (isClick)
				{
					Click(typeAttribute, attributeValue);
					DelayTime(timeDelayAfterClick);
				}
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
					case 4:
						chrome.FindElementByCssSelector(attributeValue).SendKeys(content);
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendKeys({typeAttribute},{attributeValue},{content},{isClick})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeys(int typeAttribute, string attributeValue, int index, string content, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			//Discarded unreachable code: IL_0197, IL_0210
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (isClick)
				{
					Click(typeAttribute, attributeValue);
					DelayTime(timeDelayAfterClick);
				}
				switch (typeAttribute)
				{
					case 1:
						chrome.FindElementsById(attributeValue)[index].SendKeys(content);
						break;
					case 2:
						chrome.FindElementsByName(attributeValue)[index].SendKeys(content);
						break;
					case 3:
						chrome.FindElementsByXPath(attributeValue)[index].SendKeys(content);
						break;
					case 4:
						chrome.FindElementsByCssSelector(attributeValue)[index].SendKeys(content);
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendKeys({typeAttribute},{attributeValue},{content},{isClick})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeys(int typeAttribute, string attributeValue, string content, double timeDelay_Second, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			//Discarded unreachable code: IL_0241, IL_02cc
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (isClick)
				{
					Click(typeAttribute, attributeValue);
					DelayTime(timeDelayAfterClick);
				}
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
						case 4:
							chrome.FindElementByCssSelector(attributeValue).SendKeys(content[i].ToString());
							break;
					}
					if (timeDelay_Second > 0.0)
					{
						int num = Convert.ToInt32(timeDelay_Second * 1000.0);
						if (num < 100)
						{
							num = 100;
						}
						Thread.Sleep(Base.rd.Next(num, num + 50));
					}
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendKeys({typeAttribute},{attributeValue},{content},{timeDelay_Second},{isClick})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeys(int typeAttribute, string attributeValue, int index, string content, double timeDelay_Second, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			//Discarded unreachable code: IL_026d, IL_02f8
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (isClick)
				{
					Click(typeAttribute, attributeValue);
					DelayTime(timeDelayAfterClick);
				}
				for (int i = 0; i < content.Length; i++)
				{
					switch (typeAttribute)
					{
						case 1:
							chrome.FindElementsById(attributeValue)[index].SendKeys(content[i].ToString());
							break;
						case 2:
							chrome.FindElementsByName(attributeValue)[index].SendKeys(content[i].ToString());
							break;
						case 3:
							chrome.FindElementsByXPath(attributeValue)[index].SendKeys(content[i].ToString());
							break;
						case 4:
							chrome.FindElementsByCssSelector(attributeValue)[index].SendKeys(content[i].ToString());
							break;
					}
					if (timeDelay_Second > 0.0)
					{
						int num = Convert.ToInt32(timeDelay_Second * 1000.0);
						if (num < 100)
						{
							num = 100;
						}
						Thread.Sleep(Base.rd.Next(num, num + 50));
					}
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendKeys({typeAttribute},{attributeValue},{content},{timeDelay_Second},{isClick})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeys(Random rd, int typeAttribute, string attributeValue, string content, double timeDelay_Second, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			//Discarded unreachable code: IL_055d, IL_05e8
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (isClick)
				{
					Click(typeAttribute, attributeValue);
					DelayTime(timeDelayAfterClick);
				}
				int num = 0;
				int num2 = rd.Next(1, 1000) % 3;
				if (content.Length < 3)
				{
					num2 = 2;
				}
				else
				{
					num = rd.Next(1, content.Length * 3 / 4);
				}
				switch (num2)
				{
					case 0:
						{
							string content4 = content.Substring(0, num);
							SendKeys(typeAttribute, attributeValue, content4, Convert.ToDouble(rd.Next(10, 100)) / 1000.0);
							DelayTime(rd.Next(1, 3));
							int num3 = rd.Next(1, num);
							for (int i = 0; i < num3; i++)
							{
								SendBackspace(typeAttribute, attributeValue);
								DelayTime(Convert.ToDouble(rd.Next(1000, 2000)) / 10000.0);
							}
							string text = "";
							switch (typeAttribute)
							{
								case 1:
									text = "#" + attributeValue;
									break;
								case 2:
									text = "[name=\"" + attributeValue + "\"]";
									break;
								case 4:
									text = attributeValue;
									break;
							}
							content4 = content.Substring(chrome.ExecuteScript("return document.querySelector('" + text + "').value+''").ToString().Length);
							DelayTime(rd.Next(1, 3));
							SendKeys(typeAttribute, attributeValue, content4, Convert.ToDouble(rd.Next(100, 300)) / 1000.0, isClick: false);
							DelayTime(rd.Next(1, 3));
							break;
						}
					case 1:
						{
							string content2 = content.Substring(0, num);
							string content3 = content.Substring(num);
							SendKeys(typeAttribute, attributeValue, content2, Convert.ToDouble(rd.Next(10, 100)) / 1000.0);
							DelayTime(rd.Next(1, 3));
							SendKeys(typeAttribute, attributeValue, content3, Convert.ToDouble(rd.Next(100, 300)) / 1000.0, isClick: false);
							DelayTime(rd.Next(1, 3));
							break;
						}
					case 2:
						SendKeys(typeAttribute, attributeValue, content, Convert.ToDouble(rd.Next(100, 200)) / 1000.0);
						DelayTime(rd.Next(1, 3));
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendKeys({typeAttribute},{attributeValue},{content},{timeDelay_Second},{isClick})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeysv2(int typeAttribute, string attributeValue, int index, int subTypeAttribute, string subAttributeValue, int subIndex, string content, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			//Discarded unreachable code: IL_0310, IL_0389
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (isClick)
				{
					Click(typeAttribute, attributeValue, index, subTypeAttribute, subAttributeValue, subIndex);
					DelayTime(timeDelayAfterClick);
				}
				if (subTypeAttribute == 0)
				{
					switch (typeAttribute)
					{
						case 1:
							chrome.FindElementsById(attributeValue)[index].SendKeys(content);
							break;
						case 2:
							chrome.FindElementsByName(attributeValue)[index].SendKeys(content);
							break;
						case 3:
							chrome.FindElementsByXPath(attributeValue)[index].SendKeys(content);
							break;
						case 4:
							chrome.FindElementsByCssSelector(attributeValue)[index].SendKeys(content);
							break;
					}
				}
				else
				{
					switch (typeAttribute)
					{
						case 1:
							chrome.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex].SendKeys(content);
							break;
						case 2:
							chrome.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex].SendKeys(content);
							break;
						case 3:
							chrome.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex].SendKeys(content);
							break;
						case 4:
							chrome.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex].SendKeys(content);
							break;
					}
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendKeys({typeAttribute},{attributeValue},{content},{isClick})");
			}
			return flag ? 1 : 0;
		}

		public int SendKeysWithSpeed(int tocDo, int typeAttribute, string attributeValue, string content, double timeDelay_Second, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			if (!CheckIsLive())
			{
				return -2;
			}
			int result = 0;
			switch (tocDo)
			{
				case 0:
					result = SendKeys(Base.rd, typeAttribute, attributeValue, content, timeDelay_Second, isClick, timeDelayAfterClick);
					break;
				case 1:
					result = SendKeys(typeAttribute, attributeValue, content, timeDelay_Second, isClick, timeDelayAfterClick);
					break;
				case 2:
					result = SendKeys(typeAttribute, attributeValue, content, isClick, timeDelayAfterClick);
					break;
			}
			return result;
		}

		public int SendKeysWithSpeedv2(int tocDo, int typeAttribute, string attributeValue, int index, int subTypeAttribute, string subAttributeValue, int subIndex, string content, bool isClick = true, double timeDelayAfterClick = 0.1)
		{
			if (!CheckIsLive())
			{
				return -2;
			}
			int result = 0;
			switch (tocDo)
			{
				case 0:
					result = SendKeysv2(typeAttribute, attributeValue, index, subTypeAttribute, subAttributeValue, subIndex, content);
					break;
				case 1:
					result = SendKeysv2(typeAttribute, attributeValue, index, subTypeAttribute, subAttributeValue, subIndex, content);
					break;
				case 2:
					result = SendKeysv2(typeAttribute, attributeValue, index, subTypeAttribute, subAttributeValue, subIndex, content);
					break;
			}
			return result;
		}

		public int SendBackspace(int typeAttribute, string attributeValue)
		{
			//Discarded unreachable code: IL_0103, IL_0145
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				switch (typeAttribute)
				{
					case 1:
						chrome.FindElementById(attributeValue).SendKeys(Keys.Backspace);
						break;
					case 2:
						chrome.FindElementByName(attributeValue).SendKeys(Keys.Backspace);
						break;
					case 3:
						chrome.FindElementByXPath(attributeValue).SendKeys(Keys.Backspace);
						break;
					case 4:
						chrome.FindElementByCssSelector(attributeValue).SendKeys(Keys.Backspace);
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendBackspace({typeAttribute},{attributeValue})");
			}
			return flag ? 1 : 0;
		}

		public void DelayThaoTacNho(int timeAdd = 0, Random rd = null)
		{
			if (rd == null)
			{
				rd = new Random();
			}
			DelayTime(rd.Next(timeAdd + 1, timeAdd + 4));
		}

		public void DelayRandom(int timeFrom, int timeTo)
		{
			DelayTime(Base.rd.Next(timeFrom, timeTo + 1));
		}

		public int SendEnter(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0)
		{
			//Discarded unreachable code: IL_02b1, IL_02fe
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (subTypeAttribute == 0)
				{
					switch (typeAttribute)
					{
						case 1:
							chrome.FindElementsById(attributeValue)[index].SendKeys(Keys.Enter);
							break;
						case 2:
							chrome.FindElementsByName(attributeValue)[index].SendKeys(Keys.Enter);
							break;
						case 3:
							chrome.FindElementsByXPath(attributeValue)[index].SendKeys(Keys.Enter);
							break;
						case 4:
							chrome.FindElementsByCssSelector(attributeValue)[index].SendKeys(Keys.Enter);
							break;
					}
				}
				else
				{
					switch (typeAttribute)
					{
						case 1:
							chrome.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex].SendKeys(Keys.Enter);
							break;
						case 2:
							chrome.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex].SendKeys(Keys.Enter);
							break;
						case 3:
							chrome.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex].SendKeys(Keys.Enter);
							break;
						case 4:
							chrome.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex].SendKeys(Keys.Enter);
							break;
					}
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendEnter({typeAttribute},{attributeValue},{index})");
			}
			return flag ? 1 : 0;
		}

		public int PasteContent(int typeAttribute, string attributeValue, int index = 0, bool isClick = true, int timeDelayAfterClick = 0)
		{
			//Discarded unreachable code: IL_0200, IL_024d
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (isClick)
				{
					Click(typeAttribute, attributeValue);
					Thread.Sleep(Convert.ToInt32(timeDelayAfterClick * 1000));
				}
				switch (typeAttribute)
				{
					case 1:
						chrome.FindElementsById(attributeValue)[index].SendKeys(Keys.Control + "v");
						break;
					case 2:
						chrome.FindElementsByName(attributeValue)[index].SendKeys(Keys.Control + "v");
						break;
					case 3:
						chrome.FindElementsByXPath(attributeValue)[index].SendKeys(Keys.Control + "v");
						break;
					case 4:
						chrome.FindElementsByCssSelector(attributeValue)[index].SendKeys(Keys.Control + "v");
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.PasteContent({typeAttribute},{attributeValue},{isClick})");
			}
			return flag ? 1 : 0;
		}

		public int SelectText(int typeAttribute, string attributeValue)
		{
			//Discarded unreachable code: IL_016b, IL_01ad
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				switch (typeAttribute)
				{
					case 1:
						chrome.FindElementById(attributeValue).SendKeys(Keys.Control + "a");
						break;
					case 2:
						chrome.FindElementByName(attributeValue).SendKeys(Keys.Control + "a");
						break;
					case 3:
						chrome.FindElementByXPath(attributeValue).SendKeys(Keys.Control + "a");
						break;
					case 4:
						chrome.FindElementByCssSelector(attributeValue).SendKeys(Keys.Control + "a");
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SelectText({typeAttribute},{attributeValue})");
			}
			return flag ? 1 : 0;
		}

		public int ClearText(int typeAttribute, string attributeValue)
		{
			//Discarded unreachable code: IL_00ef, IL_0131
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				switch (typeAttribute)
				{
					case 1:
						chrome.FindElementById(attributeValue).Clear();
						break;
					case 2:
						chrome.FindElementByName(attributeValue).Clear();
						break;
					case 3:
						chrome.FindElementByXPath(attributeValue).Clear();
						break;
					case 4:
						chrome.FindElementByCssSelector(attributeValue).Clear();
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.ClearText({typeAttribute},{attributeValue})");
			}
			return flag ? 1 : 0;
		}

		public int CountElement(string querySelector)
		{
			//Discarded unreachable code: IL_00b8, IL_0102
			int result = 0;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				result = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('" + querySelector.Replace("'", "\\'") + "').length+''").ToString());
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.CountElement(" + querySelector + ")");
			}
			return result;
		}

		public int CheckExistElement(string querySelector, double timeWait_Second = 0.0)
		{
			//Discarded unreachable code: IL_0142, IL_018a
			bool flag = true;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)chrome.ExecuteScript("return document.querySelectorAll('" + querySelector.Replace("'", "\\'") + "').length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
					{
						flag = false;
						break;
					}
					if (!CheckIsLive())
					{
						return -2;
					}
					Thread.Sleep(1000);
				}
			}
			catch (Exception ex)
			{
				flag = false;
				ExportError(null, ex, $"chrome.CheckExistElement({querySelector},{timeWait_Second})");
			}
			return flag ? 1 : 0;
		}

		public int CheckExistElementv2(string JSPath, double timeWait_Second = 0.0)
		{
			//Discarded unreachable code: IL_00ed, IL_0135
			bool flag = true;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)chrome.ExecuteScript("return " + JSPath + ".length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
					{
						flag = false;
						break;
					}
					Thread.Sleep(1000);
				}
			}
			catch (Exception ex)
			{
				flag = false;
				ExportError(null, ex, $"chrome.CheckExistElement({JSPath},{timeWait_Second})");
			}
			return flag ? 1 : 0;
		}

		public int WaitForSearchElement(string querySelector, int typeSearch = 0, double timeWait_Second = 0.0)
		{
			//Discarded unreachable code: IL_021d, IL_0270
			bool flag = true;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				if (typeSearch == 0)
				{
					while ((string)chrome.ExecuteScript("return document.querySelectorAll('" + querySelector.Replace("'", "\\'") + "').length+''") == "0")
					{
						if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
						{
							flag = false;
							break;
						}
						Thread.Sleep(1000);
					}
				}
				else
				{
					while ((string)chrome.ExecuteScript("return document.querySelectorAll('" + querySelector.Replace("'", "\\'") + "').length+''") != "0")
					{
						if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
						{
							flag = false;
							break;
						}
						Thread.Sleep(1000);
					}
				}
			}
			catch (Exception ex)
			{
				flag = false;
				ExportError(null, ex, $"chrome.WaitForSearchElement({querySelector},{typeSearch},{timeWait_Second})");
			}
			return flag ? 1 : 0;
		}

		public int CheckExistElements(double timeWait_Second = 0.0, params string[] querySelectors)
		{
			//Discarded unreachable code: IL_00fc, IL_0158
			int num = 0;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", querySelectors) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
					if (num != 0)
					{
						return num;
					}
					if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
					{
						break;
					}
					Thread.Sleep(1000);
					bool flag = true;
				}
			}
			catch (Exception ex)
			{
				ExportError(null, ex, string.Format("chrome.CheckExistElements({0},{1})", timeWait_Second, string.Join("|", querySelectors)));
			}
			return num;
		}

		public string CheckExistElementsV2(double timeWait_Second = 0.0, params string[] querySelectors)
		{
			//Discarded unreachable code: IL_0119, IL_0175
			int num = 0;
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", querySelectors) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
					if (num != 0)
					{
						return querySelectors[num - 1];
					}
					if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
					{
						break;
					}
					Thread.Sleep(1000);
					bool flag = true;
				}
			}
			catch (Exception ex)
			{
				ExportError(null, ex, string.Format("chrome.CheckExistElements({0},{1})", timeWait_Second, string.Join("|", querySelectors)));
			}
			return "";
		}

		public int CheckExistElements(double timeWait_Second, Dictionary<int, List<string>> dic)
		{
			//Discarded unreachable code: IL_00e3, IL_00f7, IL_013e, IL_014b
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					foreach (KeyValuePair<int, List<string>> item in dic)
					{
						if (Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", item.Value) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; } return (output + ''); ")) != 0)
						{
							return item.Key;
						}
					}
					if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
					{
						break;
					}
					Thread.Sleep(1000);
					bool flag = true;
				}
			}
			catch
			{
			}
			return 0;
		}

		public int SendEnter(int typeAttribute, string attributeValue)
		{
			//Discarded unreachable code: IL_0103, IL_0145
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				switch (typeAttribute)
				{
					case 1:
						chrome.FindElementById(attributeValue).SendKeys(Keys.Enter);
						break;
					case 2:
						chrome.FindElementByName(attributeValue).SendKeys(Keys.Enter);
						break;
					case 3:
						chrome.FindElementByXPath(attributeValue).SendKeys(Keys.Enter);
						break;
					case 4:
						chrome.FindElementByCssSelector(attributeValue).SendKeys(Keys.Enter);
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.SendEnter({typeAttribute},{attributeValue})");
			}
			return flag ? 1 : 0;
		}

		public int Scroll(int x, int y)
		{
			//Discarded unreachable code: IL_0082, IL_00c9
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				string script = $"window.scrollTo({x}, {y})";
				chrome.ExecuteScript(script);
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.Scroll({x},{y})");
			}
			return flag ? 1 : 0;
		}

		public int ScrollSmooth(string JSpath)
		{
			//Discarded unreachable code: IL_0069, IL_00b8
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				chrome.ExecuteScript(JSpath + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
				return 1;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.ScrollSmooth(" + JSpath + ")");
				return 0;
			}
		}

		public int ScrollSmoothIfNotExistOnScreen(string JSpath)
		{
			//Discarded unreachable code: IL_0088, IL_00d7
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				if (CheckExistElementOnScreen(JSpath) != 0)
				{
					chrome.ExecuteScript(JSpath + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
				}
				return 1;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.ScrollSmoothIfNotExistOnScreen(" + JSpath + ")");
				return 0;
			}
		}

		public int CheckExistElementOnScreen(string JSpath)
		{
			//Discarded unreachable code: IL_0084, IL_00ce
			int result = 0;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				result = Convert.ToInt32(chrome.ExecuteScript("var check='';x=" + JSpath + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;"));
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.CheckExistElementOnScreen(" + JSpath + ")");
			}
			return result;
		}

		public Point GetSizeChrome()
		{
			//Discarded unreachable code: IL_00ba, IL_00c7
			Point result = new Point(0, 0);
			if (CheckIsLive())
			{
				try
				{
					string text = chrome.ExecuteScript("return window.innerHeight+'|'+window.innerWidth").ToString();
					result.X = Convert.ToInt32(text.Split('|')[1]);
					result.Y = Convert.ToInt32(text.Split('|')[0]);
				}
				catch
				{
				}
			}
			return result;
		}

		public int Close()
		{
			//Discarded unreachable code: IL_0040, IL_004d, IL_0080, IL_008d, IL_009e, IL_00b0
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				try
				{
					chrome.Quit();
				}
				catch
				{
				}
				if (process != null)
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
				return 1;
			}
			catch
			{
				return 0;
			}
		}

		public int ClearText()
		{
			if (!CheckIsLive())
			{
				return -2;
			}
			new Actions(chrome).KeyDown(Keys.Shift).SendKeys(Keys.ArrowUp).SendKeys(Keys.ArrowUp)
				.SendKeys(Keys.ArrowUp)
				.SendKeys(Keys.Delete)
				.KeyUp(Keys.Shift)
				.Build()
				.Perform();
			return 1;
		}

		public int ScreenCapture(string imagePath, string fileName)
		{
			//Discarded unreachable code: IL_00cc, IL_0160
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				Screenshot screenshot = ((ITakesScreenshot)chrome).GetScreenshot();
				screenshot.SaveAsFile(imagePath + (imagePath.EndsWith("\\") ? "" : "\\") + fileName + ".png");
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.ScreenCapture(" + imagePath + "," + fileName + ")");
			}
			return flag ? 1 : 0;
		}

		public int AddCookieIntoChrome(string cookie, string domain = ".facebook.com")
		{
			//Discarded unreachable code: IL_019d, IL_0236
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				string[] array = cookie.Split(';');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Trim() != "")
					{
						string[] array3 = text.Split('=');
						if (array3.Count() > 1 && array3[0].Trim() != "")
						{
							Cookie cookie2 = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), domain, "/", DateTime.Now.AddDays(10.0));
							chrome.Manage().Cookies.AddCookie(cookie2);
						}
					}
				}
				return 1;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.AddCookieIntoChrome(" + cookie + "," + domain + ")");
				return 0;
			}
		}

		public string GetCookieFromChrome(string domain = "facebook")
		{
			//Discarded unreachable code: IL_0129, IL_0175
			string text = "";
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				Cookie[] array = chrome.Manage().Cookies.AllCookies.ToArray();
				Cookie[] array2 = array;
				foreach (Cookie cookie in array2)
				{
					if (cookie.Domain.Contains(domain))
					{
						text = text + cookie.Name + "=" + cookie.Value + ";";
					}
				}
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.GetCookieFromChrome(" + domain + ")");
			}
			return text;
		}

		public int OpenNewTab(string url, bool switchToLastTab = true)
		{
			//Discarded unreachable code: IL_00b6, IL_00fb
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				chrome.ExecuteScript("window.open('" + url + "', '_blank').focus();");
				if (switchToLastTab)
				{
					chrome.SwitchTo().Window(chrome.WindowHandles.Last());
				}
				return 1;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.OpenNewTab({url},{switchToLastTab})");
				return 0;
			}
		}

		public int CloseCurrentTab()
		{
			//Discarded unreachable code: IL_0044, IL_0073
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				chrome.Close();
				return 1;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.CloseCurrentTab()");
				return 0;
			}
		}

		public int SwitchToFirstTab()
		{
			//Discarded unreachable code: IL_005e, IL_008d
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				chrome.SwitchTo().Window(chrome.WindowHandles.First());
				return 1;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.SwitchToFirstTab()");
				return 0;
			}
		}

		public int SwitchToLastTab()
		{
			//Discarded unreachable code: IL_005e, IL_008d
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				chrome.SwitchTo().Window(chrome.WindowHandles.Last());
				return 1;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.SwitchToLastTab()");
				return 0;
			}
		}

		public void DelayTime(double timeDelay_Seconds)
		{
			//Discarded unreachable code: IL_003c, IL_0076
			try
			{
				if (!CheckChromeClosed())
				{
					Thread.Sleep(Convert.ToInt32(timeDelay_Seconds * 1000.0));
				}
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.DelayTime({timeDelay_Seconds})");
			}
		}

		public static void ExportError(Chrome chrome, Exception ex, string error = "")
		{
			try
			{
				if (!(error == "chrome.Open()"))
				{
					return;
				}
				if (!Directory.Exists("log"))
				{
					Directory.CreateDirectory("log");
				}
				if (!Directory.Exists("log\\html"))
				{
					Directory.CreateDirectory("log\\html");
				}
				if (!Directory.Exists("log\\images"))
				{
					Directory.CreateDirectory("log\\images");
				}
				Random random = new Random();
				string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
				if (chrome != null)
				{
					string contents = chrome.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
					chrome.ScreenCapture("log\\images\\", text);
					File.WriteAllText("log\\html\\" + text + ".html", contents);
				}
				using (StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true))
				{
					streamWriter.WriteLine("-----------------------------------------------------------------------------");
					streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					streamWriter.WriteLine("File: " + text);
					if (error != "")
					{
						streamWriter.WriteLine("Error: " + error);
					}
					streamWriter.WriteLine();
					if (ex != null)
					{
						streamWriter.WriteLine("Type: " + ex.GetType().FullName);
						streamWriter.WriteLine("Message: " + ex.Message);
						streamWriter.WriteLine("StackTrace: " + ex.StackTrace);
						ex = ex.InnerException;
					}
				}
			}
			catch
			{
			}
		}

		public int Select(int typeAttribute, string attributeValue, string value)
		{
			//Discarded unreachable code: IL_0116, IL_015e
			bool flag = false;
			if (!CheckIsLive())
			{
				return -2;
			}
			try
			{
				switch (typeAttribute)
				{
					case 1:
						new SelectElement(chrome.FindElementById(attributeValue)).SelectByValue(value);
						break;
					case 2:
						new SelectElement(chrome.FindElementByName(attributeValue)).SelectByValue(value);
						break;
					case 3:
						new SelectElement(chrome.FindElementByXPath(attributeValue)).SelectByValue(value);
						break;
					case 4:
						new SelectElement(chrome.FindElementByCssSelector(attributeValue)).SelectByValue(value);
						break;
				}
				flag = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, $"chrome.Select({typeAttribute},{attributeValue},{value})");
			}
			return flag ? 1 : 0;
		}

		internal bool GetProcess()
		{
			//Discarded unreachable code: IL_006d, IL_0095, IL_01cb, IL_01d8, IL_0212, IL_021f
			try
			{
				if (process != null)
				{
					return true;
				}
				string title = "";
				for (int i = 0; i < 10; i++)
				{
					try
					{
						try
						{
							title = chrome.CurrentWindowHandle;
						}
						catch
						{
							title = MCommon.Common.CreateRandomStringNumber(15, rd);
						}
						if (title != "")
						{
							for (int j = 0; j < 30; j++)
							{
								chrome.ExecuteScript("document.title='" + title + "'");
								DelayTime(1.0);
								process = (from x in Process.GetProcessesByName("chrome")
										   where x.MainWindowTitle.Contains(title)
										   select x).FirstOrDefault();
								if (process != null)
								{
									return true;
								}
							}
						}
					}
					catch
					{
					}
					DelayTime(1.0);
				}
			}
			catch
			{
			}
			return false;
		}

		public string CheckExistElementsv2(double timeWait_Second = 0.0, params string[] querySelectors)
		{
			//Discarded unreachable code: IL_0119, IL_0175
			int num = 0;
			if (!CheckIsLive())
			{
				return "-2";
			}
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					num = Convert.ToInt32(chrome.ExecuteScript("var arr='" + string.Join("|", querySelectors) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
					if (num != 0)
					{
						return querySelectors[num - 1];
					}
					if ((double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0)
					{
						break;
					}
					Thread.Sleep(1000);
					bool flag = true;
				}
			}
			catch (Exception ex)
			{
				ExportError(null, ex, string.Format("chrome.CheckExistElementsv2({0},{1})", timeWait_Second, string.Join("|", querySelectors)));
			}
			return "";
		}
	}

}