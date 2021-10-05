using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace MCommon
{
	// Token: 0x02000049 RID: 73
	public class Firefox
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000255F File Offset: 0x0000075F
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00002567 File Offset: 0x00000767
		public bool HideBrowser { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00002570 File Offset: 0x00000770
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00002578 File Offset: 0x00000778
		public bool DisableImage { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00002581 File Offset: 0x00000781
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002589 File Offset: 0x00000789
		public bool DisableSound { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00002592 File Offset: 0x00000792
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000259A File Offset: 0x0000079A
		public bool AutoPlayVideo { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000025A3 File Offset: 0x000007A3
		// (set) Token: 0x0600029D RID: 669 RVA: 0x000025AB File Offset: 0x000007AB
		public string UserAgent { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600029E RID: 670 RVA: 0x000025B4 File Offset: 0x000007B4
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000025BC File Offset: 0x000007BC
		public string ProfilePath { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000025C5 File Offset: 0x000007C5
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x000025CD File Offset: 0x000007CD
		public Point Size { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000025D6 File Offset: 0x000007D6
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000025DE File Offset: 0x000007DE
		public int Size_Heigh { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000025E7 File Offset: 0x000007E7
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x000025EF File Offset: 0x000007EF
		public int Size_Width { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00002600 File Offset: 0x00000800
		public Point Position { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00002609 File Offset: 0x00000809
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00002611 File Offset: 0x00000811
		public int Position_X { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000261A File Offset: 0x0000081A
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00002622 File Offset: 0x00000822
		public int Position_Y { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000262B File Offset: 0x0000082B
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00002633 File Offset: 0x00000833
		public int TimeWaitForSearchingElement { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00002644 File Offset: 0x00000844
		public int TimeWaitForLoadingPage { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000264D File Offset: 0x0000084D
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00002655 File Offset: 0x00000855
		public string Proxy { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000265E File Offset: 0x0000085E
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002666 File Offset: 0x00000866
		public int TypeProxy { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000266F File Offset: 0x0000086F
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00002677 File Offset: 0x00000877
		public string App { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00002680 File Offset: 0x00000880
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00002688 File Offset: 0x00000888
		public string LinkToOtherBrowser { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00002691 File Offset: 0x00000891
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00002699 File Offset: 0x00000899
		public string PathExtension { get; set; }

		// Token: 0x060002BA RID: 698 RVA: 0x0002E060 File Offset: 0x0002C260
		public Firefox()
		{
			this.DisableImage = true;
			this.DisableSound = false;
			this.UserAgent = "";
			this.ProfilePath = "";
			this.Size_Heigh = 300;
			this.Size_Width = 300;
			this.Size = new Point(this.Size_Width, this.Size_Heigh);
			this.Position_X = 300;
			this.Position_Y = 0;
			this.Proxy = "";
			this.TypeProxy = 0;
			this.Position = new Point(this.Position_X, this.Position_Y);
			this.TimeWaitForSearchingElement = 0;
			this.TimeWaitForLoadingPage = 5;
			this.App = "";
			this.AutoPlayVideo = false;
			this.LinkToOtherBrowser = "";
			this.PathExtension = "data\\extension";
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0002E1B0 File Offset: 0x0002C3B0
		public bool Open()
		{
			bool result = false;
			this.isAlive = true;
			try
			{
				FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
				firefoxDriverService.HideCommandPromptWindow = true;
				FirefoxOptions firefoxOptions = new FirefoxOptions();
				firefoxOptions.SetPreference("security.notification_enable_delay", 0);
				firefoxOptions.SetPreference("dom.webnotifications.enabled", false);
				firefoxOptions.SetPreference("permissions.default.image", this.DisableImage ? 1 : 0);
				firefoxOptions.SetPreference("browser.download.folderList", 2);
				firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", false);
				firefoxOptions.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/msword, application/csv, application/ris, text/csv, image/png, application/pdf, text/html, text/plain, application/zip, application/x-zip, application/x-zip-compressed, application/download, application/octet-stream");
				firefoxOptions.SetPreference("browser.download.manager.showWhenStarting", false);
				firefoxOptions.SetPreference("browser.download.manager.focusWhenStarting", false);
				firefoxOptions.SetPreference("browser.download.useDownloadDir", true);
				firefoxOptions.SetPreference("browser.helperApps.alwaysAsk.force", false);
				firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", false);
				firefoxOptions.SetPreference("browser.download.manager.closeWhenDone", true);
				firefoxOptions.SetPreference("browser.download.manager.showAlertOnComplete", false);
				firefoxOptions.SetPreference("browser.download.manager.useWindow", false);
				firefoxOptions.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
				firefoxOptions.SetPreference("pdfjs.disabled", true);
				firefoxOptions.AddArguments(new string[]
				{
					"-width=" + this.Size.X.ToString(),
					"-height=" + this.Size.Y.ToString()
				});
				bool flag = this.UserAgent != "";
				if (flag)
				{
					firefoxOptions.SetPreference("general.useragent.override", this.UserAgent);
				}
				else
				{
					firefoxOptions.SetPreference("general.useragent.override", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0");
				}
				FirefoxProfileManager firefoxProfileManager = new FirefoxProfileManager();
				this.firefox = new FirefoxDriver(firefoxDriverService, firefoxOptions);
				this.firefox.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes((double)this.TimeWaitForLoadingPage);
				this.firefox.Manage().Window.Position = this.Position;
				result = true;
			}
			catch (Exception ex)
			{
				Firefox.ExportError(null, ex, "firefox.Open()");
			}
			return result;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0002E610 File Offset: 0x0002C810
		public static string SetPositionAndSizeFireFox(FirefoxOptions option, int i)
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			int num = width / 3;
			int num2 = height / 2;
			bool flag = i < 3;
			int num3;
			int num4;
			if (flag)
			{
				num3 = num * i;
				num4 = 0;
			}
			else
			{
				num3 = num * (i % 3);
				int num5 = i / 2;
				bool flag2 = num5 % 2 == 0;
				if (flag2)
				{
					num4 = 0;
				}
				else
				{
					num4 = num2;
				}
			}
			option.AddArgument(string.Format("--width={0}", num));
			option.AddArgument(string.Format("--height={0}", num2));
			return num3.ToString() + "|" + num4.ToString();
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0002E768 File Offset: 0x0002C968
		public string GetCssSelector(string querySelector, string attributeName, string attributeValue)
		{
			string result = "";
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					result = this.firefox.ExecuteScript(string.Concat(new string[]
					{
						"function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('",
						querySelector,
						"','",
						attributeName,
						"','",
						attributeValue,
						"')"
					}), Array.Empty<object>()).ToString();
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Concat(new string[]
					{
						"firefox.GetCssSelector(",
						querySelector,
						",",
						attributeName,
						",",
						attributeValue,
						")"
					}));
				}
			}
			return result;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0002E940 File Offset: 0x0002CB40
		public string GetAttributeValue(string querySelector, string attributeName)
		{
			string result = "";
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					result = this.firefox.ExecuteScript(string.Concat(new string[]
					{
						"return document.querySelector('",
						querySelector,
						"').getAttribute('",
						attributeName,
						"')"
					}), Array.Empty<object>()).ToString();
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Concat(new string[]
					{
						"firefox.GetAttributeValue(",
						querySelector,
						",",
						attributeName,
						")"
					}));
				}
			}
			return result;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		public void ScrollSmooth(int distance)
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.ExecuteScript("window.scrollBy({ top: " + distance.ToString() + ",behavior: 'smooth'});", Array.Empty<object>());
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("chrome.ScrollSmooth({0})", distance));
				}
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0002EB90 File Offset: 0x0002CD90
		public string GetUseragent()
		{
			string result = "";
			try
			{
				result = this.firefox.ExecuteScript("return navigator.userAgent", Array.Empty<object>()).ToString();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0002EC18 File Offset: 0x0002CE18
		public bool SendKeyDown(int typeAttribute, string attributeValue)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					switch (typeAttribute)
					{
					case 1:
						this.firefox.FindElementById(attributeValue).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
						break;
					case 2:
						this.firefox.FindElementByName(attributeValue).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
						break;
					case 3:
						this.firefox.FindElementByXPath(attributeValue).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
						break;
					case 4:
						this.firefox.FindElementByCssSelector(attributeValue).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
						break;
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.SendKeyDown({0},{1})", typeAttribute, attributeValue));
				}
			}
			return result;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0002ED78 File Offset: 0x0002CF78
		public string GetURL()
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					return this.firefox.Url;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.GetURL()");
				}
			}
			return "";
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0002EE0C File Offset: 0x0002D00C
		public bool GotoURL(string url)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.Navigate().GoToUrl(url);
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.GotoURL(" + url + ")");
				}
			}
			return result;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0002EEC4 File Offset: 0x0002D0C4
		public bool Refresh()
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.Navigate().Refresh();
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.Refresh()");
				}
			}
			return result;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0002EF58 File Offset: 0x0002D158
		public bool GotoBackPage()
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.Navigate().Back();
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.GotoBackPage()");
				}
			}
			return result;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0002EFEC File Offset: 0x0002D1EC
		public bool HoverElement(int typeAttribute, string attributeValue, double timeHover_second)
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					switch (typeAttribute)
					{
					case 1:
						new Actions(this.firefox).MoveToElement(this.firefox.FindElement(By.Id(attributeValue))).Perform();
						break;
					case 2:
						new Actions(this.firefox).MoveToElement(this.firefox.FindElement(By.Name(attributeValue))).Perform();
						break;
					case 3:
						new Actions(this.firefox).MoveToElement(this.firefox.FindElement(By.XPath(attributeValue))).Perform();
						break;
					case 4:
						new Actions(this.firefox).MoveToElement(this.firefox.FindElement(By.CssSelector(attributeValue))).Perform();
						break;
					}
					Thread.Sleep(Convert.ToInt32(timeHover_second * 1000.0));
					return true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.HoverElement({0}, {1}, {2})", typeAttribute, attributeValue, timeHover_second));
				}
			}
			return false;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0002F1CC File Offset: 0x0002D3CC
		public bool Click(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					bool flag2 = subTypeAttribute == 0;
					if (flag2)
					{
						switch (typeAttribute)
						{
						case 1:
							this.firefox.FindElementsById(attributeValue)[index].Click();
							break;
						case 2:
							this.firefox.FindElementsByName(attributeValue)[index].Click();
							break;
						case 3:
							this.firefox.FindElementsByXPath(attributeValue)[index].Click();
							break;
						case 4:
							this.firefox.FindElementsByCssSelector(attributeValue)[index].Click();
							break;
						}
					}
					else
					{
						switch (typeAttribute)
						{
						case 1:
							this.firefox.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex].Click();
							break;
						case 2:
							this.firefox.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex].Click();
							break;
						case 3:
							this.firefox.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex].Click();
							break;
						case 4:
							this.firefox.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex].Click();
							break;
						}
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.Click({0},{1})", typeAttribute, attributeValue));
				}
			}
			return result;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0002F4BC File Offset: 0x0002D6BC
		public bool ClickWithAction(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					bool flag2 = subTypeAttribute != 0;
					if (flag2)
					{
						switch (typeAttribute)
						{
						case 1:
							new Actions(this.firefox).Click(this.firefox.FindElementsById(attributeValue)[index].FindElements(By.Id(subAttributeValue))[subIndex]).Perform();
							break;
						case 2:
							new Actions(this.firefox).Click(this.firefox.FindElementsByName(attributeValue)[index].FindElements(By.Name(subAttributeValue))[subIndex]).Perform();
							break;
						case 3:
							new Actions(this.firefox).Click(this.firefox.FindElementsByXPath(attributeValue)[index].FindElements(By.XPath(subAttributeValue))[subIndex]).Perform();
							break;
						case 4:
							new Actions(this.firefox).Click(this.firefox.FindElementsByCssSelector(attributeValue)[index].FindElements(By.CssSelector(subAttributeValue))[subIndex]).Perform();
							break;
						}
					}
					else
					{
						switch (typeAttribute)
						{
						case 1:
							new Actions(this.firefox).Click(this.firefox.FindElementsById(attributeValue)[index]).Perform();
							break;
						case 2:
							new Actions(this.firefox).Click(this.firefox.FindElementsByName(attributeValue)[index]).Perform();
							break;
						case 3:
							new Actions(this.firefox).Click(this.firefox.FindElementsByXPath(attributeValue)[index]).Perform();
							break;
						case 4:
							new Actions(this.firefox).Click(this.firefox.FindElementsByCssSelector(attributeValue)[index]).Perform();
							break;
						}
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.ClickWithAction({0},{1})", typeAttribute, attributeValue));
				}
			}
			return result;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0002F854 File Offset: 0x0002DA54
		public bool SendKeys(int typeAttribute, string attributeValue, string content, bool isClick = true)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					if (isClick)
					{
						this.Click(typeAttribute, attributeValue, 0, 0, "", 0);
					}
					switch (typeAttribute)
					{
					case 1:
						this.firefox.FindElementById(attributeValue).SendKeys(content);
						break;
					case 2:
						this.firefox.FindElementByName(attributeValue).SendKeys(content);
						break;
					case 3:
						this.firefox.FindElementByXPath(attributeValue).SendKeys(content);
						break;
					case 4:
						this.firefox.FindElementByCssSelector(attributeValue).SendKeys(content);
						break;
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.SendKeys({0},{1},{2},{3})", new object[]
					{
						typeAttribute,
						attributeValue,
						content,
						isClick
					}));
				}
			}
			return result;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0002FA44 File Offset: 0x0002DC44
		public bool SendKeys(int typeAttribute, string attributeValue, string content, double timeDelay_Second, bool isClick = true)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					if (isClick)
					{
						this.Click(typeAttribute, attributeValue, 0, 0, "", 0);
					}
					for (int i = 0; i < content.Length; i++)
					{
						switch (typeAttribute)
						{
						case 1:
							this.firefox.FindElementById(attributeValue).SendKeys(content[i].ToString());
							break;
						case 2:
							this.firefox.FindElementByName(attributeValue).SendKeys(content[i].ToString());
							break;
						case 3:
							this.firefox.FindElementByXPath(attributeValue).SendKeys(content[i].ToString());
							break;
						case 4:
							this.firefox.FindElementByCssSelector(attributeValue).SendKeys(content[i].ToString());
							break;
						}
						Thread.Sleep(Convert.ToInt32(timeDelay_Second * 1000.0));
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.SendKeys({0},{1},{2},{3},{4})", new object[]
					{
						typeAttribute,
						attributeValue,
						content,
						timeDelay_Second,
						isClick
					}));
				}
			}
			return result;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0002FCCC File Offset: 0x0002DECC
		public bool SelectText(int typeAttribute, string attributeValue)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					switch (typeAttribute)
					{
					case 1:
						this.firefox.FindElementById(attributeValue).SendKeys(OpenQA.Selenium.Keys.Control + "a");
						break;
					case 2:
						this.firefox.FindElementByName(attributeValue).SendKeys(OpenQA.Selenium.Keys.Control + "a");
						break;
					case 3:
						this.firefox.FindElementByXPath(attributeValue).SendKeys(OpenQA.Selenium.Keys.Control + "a");
						break;
					case 4:
						this.firefox.FindElementByCssSelector(attributeValue).SendKeys(OpenQA.Selenium.Keys.Control + "a");
						break;
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.SelectText({0},{1})", typeAttribute, attributeValue));
				}
			}
			return result;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		public bool ClearText(int typeAttribute, string attributeValue)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					switch (typeAttribute)
					{
					case 1:
						this.firefox.FindElementById(attributeValue).Clear();
						break;
					case 2:
						this.firefox.FindElementByName(attributeValue).Clear();
						break;
					case 3:
						this.firefox.FindElementByXPath(attributeValue).Clear();
						break;
					case 4:
						this.firefox.FindElementByCssSelector(attributeValue).Clear();
						break;
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.ClearText({0},{1})", typeAttribute, attributeValue));
				}
			}
			return result;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0002FFEC File Offset: 0x0002E1EC
		public bool CheckExistElement(string querySelector, double timeWait_Second = 0.0)
		{
			bool result = true;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					int tickCount = Environment.TickCount;
					while ((string)this.firefox.ExecuteScript("return document.querySelectorAll('" + querySelector + "').length+''", Array.Empty<object>()) == "0")
					{
						bool flag2 = (double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0;
						if (flag2)
						{
							result = false;
							break;
						}
						Thread.Sleep(1000);
					}
				}
				catch (Exception ex)
				{
					result = false;
					Firefox.ExportError(null, ex, string.Format("firefox.CheckExistElement({0},{1})", querySelector, timeWait_Second));
				}
			}
			return result;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0003013C File Offset: 0x0002E33C
		public bool CheckExistElementv2(string JSPath, double timeWait_Second = 0.0)
		{
			bool result = true;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					int tickCount = Environment.TickCount;
					while ((string)this.firefox.ExecuteScript("return " + JSPath + ".length+''", Array.Empty<object>()) == "0")
					{
						bool flag2 = (double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0;
						if (flag2)
						{
							result = false;
							break;
						}
						Thread.Sleep(1000);
					}
				}
				catch (Exception ex)
				{
					result = false;
					Firefox.ExportError(null, ex, string.Format("firefox.CheckExistElement({0},{1})", JSPath, timeWait_Second));
				}
			}
			return result;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0003028C File Offset: 0x0002E48C
		public bool CheckChromeClosed()
		{
			bool result = true;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					string title = this.firefox.Title;
					result = false;
				}
				catch (Exception ex)
				{
					this.isAlive = false;
					Firefox.ExportError(null, ex, "firefox.CheckChromeClosed()");
				}
			}
			return result;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0003032C File Offset: 0x0002E52C
		public bool WaitForSearchElement(string querySelector, int typeSearch = 0, double timeWait_Second = 0.0)
		{
			bool result = true;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					int tickCount = Environment.TickCount;
					bool flag2 = typeSearch == 0;
					if (flag2)
					{
						while ((string)this.firefox.ExecuteScript("return document.querySelectorAll('" + querySelector + "').length+''", Array.Empty<object>()) == "0")
						{
							bool flag3 = (double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0;
							if (flag3)
							{
								result = false;
								break;
							}
							Thread.Sleep(1000);
						}
					}
					else
					{
						while ((string)this.firefox.ExecuteScript("return document.querySelectorAll('" + querySelector + "').length+''", Array.Empty<object>()) != "0")
						{
							bool flag4 = (double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0;
							if (flag4)
							{
								result = false;
								break;
							}
							Thread.Sleep(1000);
						}
					}
				}
				catch (Exception ex)
				{
					result = false;
					Firefox.ExportError(null, ex, string.Format("firefox.WaitForSearchElement({0},{1},{2})", querySelector, typeSearch, timeWait_Second));
				}
			}
			return result;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00030564 File Offset: 0x0002E764
		public int CheckExistElements(double timeWait_Second = 0.0, params string[] querySelectors)
		{
			int result = 0;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					int tickCount = Environment.TickCount;
					int i;
					for (;;)
					{
						for (i = 0; i < querySelectors.Length; i++)
						{
							bool flag2 = this.CheckExistElement(querySelectors[i], 0.0);
							if (flag2)
							{
								goto Block_3;
							}
						}
						bool flag3 = (double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0;
						if (flag3)
						{
							goto Block_5;
						}
						Thread.Sleep(1000);
					}
					Block_3:
					return i + 1;
					Block_5:;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.CheckExistElements({0},{1})", timeWait_Second, string.Join("|", querySelectors)));
				}
			}
			return result;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public bool SendEnter(int typeAttribute, string attributeValue)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					switch (typeAttribute)
					{
					case 1:
						this.firefox.FindElementById(attributeValue).SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 2:
						this.firefox.FindElementByName(attributeValue).SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 3:
						this.firefox.FindElementByXPath(attributeValue).SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 4:
						this.firefox.FindElementByCssSelector(attributeValue).SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.SendEnter({0},{1})", typeAttribute, attributeValue));
				}
			}
			return result;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00030818 File Offset: 0x0002EA18
		public bool Scroll(int x, int y)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					string script = string.Format("window.scrollTo({0}, {1})", x, y);
					this.firefox.ExecuteScript(script, Array.Empty<object>());
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.Scroll({0},{1})", x, y));
				}
			}
			return result;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000308FC File Offset: 0x0002EAFC
		public void ScrollSmooth(string JSpath)
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.ExecuteScript(JSpath + ".scrollIntoView({ behavior: 'smooth', block: 'center'});", Array.Empty<object>());
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.ScrollSmooth(" + JSpath + ")");
				}
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000309BC File Offset: 0x0002EBBC
		public int CheckExistElementOnScreen(string JSpath)
		{
			int result = -2;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					result = Convert.ToInt32(this.firefox.ExecuteScript("var check='';x=" + JSpath + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;", Array.Empty<object>()));
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.CheckExistElementOnScreen(" + JSpath + ")");
				}
			}
			return result;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00030AA4 File Offset: 0x0002ECA4
		public Point GetSizeChrome()
		{
			Point result = new Point(0, 0);
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					string text = this.firefox.ExecuteScript("return window.innerHeight+'|'+window.innerWidth", Array.Empty<object>()).ToString();
					result.X = Convert.ToInt32(text.Split(new char[]
					{
						'|'
					})[1]);
					result.Y = Convert.ToInt32(text.Split(new char[]
					{
						'|'
					})[0]);
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00030B98 File Offset: 0x0002ED98
		public void Close()
		{
			try
			{
				bool flag = this.firefox != null;
				if (flag)
				{
					this.firefox.Quit();
				}
				this.isAlive = false;
			}
			catch (Exception ex)
			{
				Firefox.ExportError(null, ex, "firefox.Close()");
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00030C24 File Offset: 0x0002EE24
		public void AddCookieIntoFirefox(string cookie, string domain = ".facebook.com")
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					string[] array = cookie.Split(new char[]
					{
						';'
					});
					foreach (string text in array)
					{
						bool flag2 = text.Trim() != "";
						if (flag2)
						{
							string[] array3 = text.Split(new char[]
							{
								'='
							});
							bool flag3 = array3.Count<string>() > 1 && array3[0].Trim() != "";
							if (flag3)
							{
								Cookie cookie2 = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), domain, "/", new DateTime?(DateTime.Now.AddDays(10.0)));
								this.firefox.Manage().Cookies.AddCookie(cookie2);
							}
						}
					}
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Concat(new string[]
					{
						"firefox.AddCookieIntoChrome(",
						cookie,
						",",
						domain,
						")"
					}));
				}
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00030E68 File Offset: 0x0002F068
		public string GetCookieFromChrome(string domain = "facebook")
		{
			string text = "";
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					Cookie[] array = this.firefox.Manage().Cookies.AllCookies.ToArray<Cookie>();
					foreach (Cookie cookie in array)
					{
						bool flag2 = cookie.Domain.Contains(domain);
						if (flag2)
						{
							text = string.Concat(new string[]
							{
								text,
								cookie.Name,
								"=",
								cookie.Value,
								";"
							});
						}
					}
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.GetCookieFromChrome(" + domain + ")");
				}
			}
			return text;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00030FE4 File Offset: 0x0002F1E4
		public void OpenNewTab(string url, bool switchToLastTab = true)
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.ExecuteScript("window.open('" + url + "', '_blank').focus();", Array.Empty<object>());
					if (switchToLastTab)
					{
						this.firefox.SwitchTo().Window(this.firefox.WindowHandles.Last<string>());
					}
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.OpenNewTab({0},{1})", url, switchToLastTab));
				}
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000310E8 File Offset: 0x0002F2E8
		public void CloseCurrentTab()
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.Close();
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.CloseCurrentTab()");
				}
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00031164 File Offset: 0x0002F364
		public void SwitchToFirstTab()
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.SwitchTo().Window(this.firefox.WindowHandles.First<string>());
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.SwitchToFirstTab()");
				}
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000311F8 File Offset: 0x0002F3F8
		public void SwitchToLastTab()
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					this.firefox.SwitchTo().Window(this.firefox.WindowHandles.Last<string>());
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.SwitchToLastTab()");
				}
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0003128C File Offset: 0x0002F48C
		public void DelayTime(double timeDelay_Seconds)
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					Thread.Sleep(Convert.ToInt32(timeDelay_Seconds * 1000.0));
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.DelayTime({0})", timeDelay_Seconds));
				}
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00031320 File Offset: 0x0002F520
		public bool Select(int typeAttribute, string attributeValue, string value)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					switch (typeAttribute)
					{
					case 1:
						new SelectElement(this.firefox.FindElementById(attributeValue)).SelectByValue(value);
						break;
					case 2:
						new SelectElement(this.firefox.FindElementByName(attributeValue)).SelectByValue(value);
						break;
					case 3:
						new SelectElement(this.firefox.FindElementByXPath(attributeValue)).SelectByValue(value);
						break;
					case 4:
						new SelectElement(this.firefox.FindElementByCssSelector(attributeValue)).SelectByValue(value);
						break;
					}
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format("firefox.Select({0},{1},{2})", typeAttribute, attributeValue, value));
				}
			}
			return result;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00031498 File Offset: 0x0002F698
		public bool ScreenCapture(string imagePath, string fileName)
		{
			bool result = false;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					Screenshot screenshot = ((ITakesScreenshot)this.firefox).GetScreenshot();
					screenshot.SaveAsFile(imagePath + (imagePath.EndsWith("\\") ? "" : "\\") + fileName + ".png");
					result = true;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Concat(new string[]
					{
						"chrome.ScreenCapture(",
						imagePath,
						",",
						fileName,
						")"
					}));
				}
			}
			return result;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00031610 File Offset: 0x0002F810
		public object ExecuteScript(string script)
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					return this.firefox.ExecuteScript(script, Array.Empty<object>());
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, "firefox.ExecuteScript(" + script + ")");
				}
			}
			return "";
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00016CC8 File Offset: 0x00014EC8
		public static void ExportError(Chrome firefox, Exception ex, string error = "")
		{
			try
			{
				bool flag = !Directory.Exists("log");
				if (flag)
				{
					Directory.CreateDirectory("log");
				}
				bool flag2 = !Directory.Exists("log\\html");
				if (flag2)
				{
					Directory.CreateDirectory("log\\html");
				}
				bool flag3 = !Directory.Exists("log\\images");
				if (flag3)
				{
					Directory.CreateDirectory("log\\images");
				}
				Random random = new Random();
				string text = string.Concat(new string[]
				{
					DateTime.Now.Day.ToString(),
					"_",
					DateTime.Now.Month.ToString(),
					"_",
					DateTime.Now.Year.ToString(),
					"_",
					DateTime.Now.Hour.ToString(),
					"_",
					DateTime.Now.Minute.ToString(),
					"_",
					DateTime.Now.Second.ToString(),
					"_",
					random.Next(1000, 9999).ToString()
				});
				bool flag4 = firefox != null;
				if (flag4)
				{
					string contents = firefox.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
					firefox.ScreenCapture("log\\images\\", text);
					File.WriteAllText("log\\html\\" + text + ".html", contents);
				}
				using (StreamWriter streamWriter = new StreamWriter("log\\log.txt", true))
				{
					streamWriter.WriteLine("-----------------------------------------------------------------------------");
					streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					streamWriter.WriteLine("File: " + text);
					bool flag5 = error != "";
					if (flag5)
					{
						streamWriter.WriteLine("Error: " + error);
					}
					streamWriter.WriteLine();
					bool flag6 = ex != null;
					if (flag6)
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

		// Token: 0x0400021F RID: 543
		private FirefoxDriver firefox;

		// Token: 0x04000220 RID: 544
		public bool isAlive = false;
	}
}
