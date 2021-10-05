using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Common;
using maxcare;
using maxcare.Enum;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// Token: 0x02000041 RID: 65
	public class CommonChrome
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00018CF0 File Offset: 0x00016EF0
		public static bool CheckFacebookBlocked(Chrome chrome)
		{
			return chrome.GetURL().StartsWith("https://m.facebook.com/feature_limit_notice/") || chrome.CheckExistElements(0.0, new string[]
			{
				"[href*=\"facebook.com/help/177066345680802\"]",
				"[href*=\"facebook.com/help/contact/\"]"
			}) != 0 || chrome.GetURL().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway");
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00018DD0 File Offset: 0x00016FD0
		public static void AnswerQuestionWhenJoinGroup(Chrome chrome, List<string> lstCauTraLoi)
		{
			List<string> list = new List<string>();
			int num = chrome.CountElement("textarea");
			for (int i = 0; i < num; i++)
			{
				bool flag = list.Count == 0;
				if (flag)
				{
					list = Common.CloneList(lstCauTraLoi);
				}
				string text = list[Base.rd.Next(0, list.Count)];
				text = Common.SpinText(text, Base.rd);
				list.Remove(text);
				chrome.ScrollSmooth(string.Format("document.querySelectorAll('textarea')[{0}]", num));
				chrome.DelayRandom(1, 2);
				chrome.SendKeys(4, "textarea", i, text, 0.1, true, 0.1);
				chrome.DelayRandom(1, 2);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00018F28 File Offset: 0x00017128
		public static void AnswerQuestionWhenJoinGroupWWW(Chrome chrome, List<string> lstCauTraLoi)
		{
			List<string> list = new List<string>();
			string text = "[aria-label=\"Answer Questions\"][role=\"dialog\"] [data-visualcompletion=\"ignore-dynamic\"]";
			int num = 0;
			int num2 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('" + text + "').length").ToString());
			for (int i = 0; i < num2; i++)
			{
				bool flag = chrome.ExecuteScript(string.Concat(new string[]
				{
					"return document.querySelectorAll('",
					text,
					"')[",
					i.ToString(),
					"].querySelector('[name=\"radio\"]')+''"
				})).ToString() != "null";
				if (flag)
				{
					num = 1;
				}
				else
				{
					bool flag2 = chrome.ExecuteScript(string.Concat(new string[]
					{
						"return document.querySelectorAll('",
						text,
						"')[",
						i.ToString(),
						"].querySelector('textarea')+''"
					})).ToString() != "null";
					if (flag2)
					{
						num = 2;
					}
					else
					{
						bool flag3 = chrome.ExecuteScript(string.Concat(new string[]
						{
							"return document.querySelectorAll('",
							text,
							"')[",
							i.ToString(),
							"].querySelector('[name=\"checkbox\"]')+''"
						})).ToString() != "null";
						if (flag3)
						{
							num = 3;
						}
					}
				}
				chrome.ScrollSmoothIfNotExistOnScreen(string.Concat(new string[]
				{
					"document.querySelectorAll('",
					text,
					"')[",
					i.ToString(),
					"]"
				}));
				chrome.DelayTime(1.0);
				switch (num)
				{
				case 1:
					chrome.ExecuteScript(string.Concat(new string[]
					{
						"document.querySelectorAll('",
						text,
						"')[",
						i.ToString(),
						"].querySelector('[name=\"radio\"]').click()"
					}));
					chrome.DelayTime(1.0);
					break;
				case 2:
				{
					bool flag4 = list.Count == 0;
					if (flag4)
					{
						list = Common.CloneList(lstCauTraLoi);
					}
					string text2 = list[Base.rd.Next(0, list.Count)];
					list.Remove(text2);
					chrome.SendKeysv2(4, text ?? "", i, 4, "textarea", 0, text2, true, 0.1);
					chrome.DelayTime(1.0);
					break;
				}
				case 3:
					chrome.ExecuteScript(string.Concat(new string[]
					{
						"document.querySelectorAll('",
						text,
						"')[",
						i.ToString(),
						"].querySelector('[name=\"checkbox\"]').click()"
					}));
					chrome.DelayTime(1.0);
					break;
				}
			}
			bool flag5 = chrome.CheckExistElement("[name=\"agree-to-group-rules\"]", 0.0) == 1;
			if (flag5)
			{
				chrome.Click(2, "agree-to-group-rules", 0, 0, "", 0, 1);
				chrome.DelayTime(1.0);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001955C File Offset: 0x0001775C
		public static bool IsCheckpointWhenLoginWhenGiaiCP(Chrome chrome)
		{
			bool result;
			try
			{
				List<string> list = new List<string>
				{
					"#captcha_response",
					"[name=\"captcha_response\"]",
					"[name=\"verification_method\"]",
					"[name=\"password_new\"]",
					"[href=\"https://www.facebook.com/communitystandards/\"]"
				};
				result = (chrome.CheckExistElements(0.0, list.ToArray()) > 0);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0001964C File Offset: 0x0001784C
		public static int LoginFacebookUsingUidPassWhenGiaiCP(Chrome chrome, string uid, string pass, string fa2 = "", string URL = "https://www.facebook.com")
		{
			Random random = new Random();
			int result = 0;
			try
			{
				int num = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
				bool flag = num == 0;
				if (flag)
				{
					bool flag2 = chrome.GotoURL(URL) == -2;
					if (flag2)
					{
						result = -2;
						goto IL_E89;
					}
					num = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
				}
				bool flag3 = chrome.CheckExistElement("[data-cookiebanner=\"accept_button\"]", 0.0) == 1;
				if (flag3)
				{
					chrome.Click(4, "[data-cookiebanner=\"accept_button\"]", 0, 0, "", 0, 1);
					chrome.DelayTime(1.0);
				}
				bool flag4 = num == 1;
				if (flag4)
				{
					chrome.GotoURLIfNotExist("https://www.facebook.com/login");
					bool flag5 = chrome.CheckExistElement("[data-cookiebanner=\"accept_button\"]", 0.0) == 1;
					if (flag5)
					{
						chrome.Click(4, "[data-cookiebanner=\"accept_button\"]", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag6 = chrome.SendKeys(1, "email", uid, 0.1, true, 0.1) == -2;
					if (flag6)
					{
						result = -2;
						goto IL_E89;
					}
					chrome.DelayTime(1.0);
					bool flag7 = chrome.SendKeys(1, "pass", pass, 0.1, true, 0.1) == -2;
					if (flag7)
					{
						result = -2;
						goto IL_E89;
					}
					chrome.DelayTime(1.0);
					bool flag8 = chrome.Click(1, "loginbutton", 0, 0, "", 0, 1) == -2;
					if (flag8)
					{
						result = -2;
						goto IL_E89;
					}
					chrome.DelayTime(1.0);
					bool flag9 = chrome.CheckExistElement("#approvals_code", 5.0) == 1 && fa2 != "";
					if (flag9)
					{
						string totp = Common.GetTotp(fa2.Replace(" ", "").Replace("\n", ""));
						bool flag10 = totp != "";
						if (flag10)
						{
							chrome.SendKeys(1, "approvals_code", totp, 0.1, true, 0.1);
							chrome.DelayTime(1.0);
							chrome.Click(1, "checkpointSubmitButton", 0, 0, "", 0, 1);
							chrome.DelayTime(1.0);
						}
					}
					int num2 = 0;
					while (chrome.CheckExistElement("#checkpointSubmitButton", 3.0) == 1)
					{
						bool flag11 = !chrome.CheckIsLive();
						if (flag11)
						{
							result = -2;
							goto IL_E89;
						}
						bool flag12 = CommonChrome.IsCheckpointWhenLoginWhenGiaiCP(chrome) || num2 == 7;
						if (flag12)
						{
							break;
						}
						chrome.Click(1, "checkpointSubmitButton", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
						num2++;
					}
				}
				else
				{
					int num3 = chrome.GotoURLIfNotExist("https://m.facebook.com/login");
					bool flag13 = chrome.CheckExistElement("[data-cookiebanner=\"accept_button\"]", 0.0) == 1;
					if (flag13)
					{
						chrome.Click(4, "[data-cookiebanner=\"accept_button\"]", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					num3 = chrome.CheckExistElement("[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 1.0);
					int num4 = num3;
					int num5 = num4;
					if (num5 == -2)
					{
						result = -2;
						goto IL_E89;
					}
					if (num5 != 1)
					{
						bool flag14 = chrome.SendKeys(1, "m_login_email", uid, 0.1, true, 0.1) == 1;
						if (flag14)
						{
							chrome.DelayThaoTacNho(0, null);
							string attributeValue = (chrome.CheckExistElements(3.0, new string[]
							{
								"#m_login_password",
								"[name=\"pass\"]"
							}) == 1) ? "#m_login_password" : "[name=\"pass\"]";
							chrome.SendKeys(4, attributeValue, pass, 0.1, true, 0.1);
							chrome.DelayThaoTacNho(0, null);
							chrome.Click(2, "login", 0, 0, "", 0, 1);
							chrome.DelayThaoTacNho(0, null);
						}
					}
					else
					{
						chrome.DelayThaoTacNho(0, null);
						bool flag15 = chrome.Click(4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 0, 0, "", 0, 1) == -2;
						if (flag15)
						{
							result = -2;
							goto IL_E89;
						}
						chrome.DelayThaoTacNho(2, null);
						num3 = chrome.CheckExistElements(10.0, new string[]
						{
							"[name=\"pass\"]",
							"#approvals_code"
						});
						bool flag16 = num3 == -2;
						if (flag16)
						{
							result = -2;
							goto IL_E89;
						}
						bool flag17 = num3 == 1;
						if (flag17)
						{
							bool flag18 = chrome.SendKeys(2, "pass", pass, 0.1, true, 0.1) == 1;
							if (flag18)
							{
								chrome.DelayThaoTacNho(0, null);
								bool flag19 = chrome.Click(4, chrome.GetCssSelector("button", "data-sigil", "password_login_button"), 0, 0, "", 0, 1) == 1;
								if (flag19)
								{
									chrome.DelayTime(1.0);
								}
							}
						}
					}
					num3 = chrome.CheckExistElement("#approvals_code", 5.0);
					bool flag20 = num3 == -2;
					if (flag20)
					{
						result = -2;
						goto IL_E89;
					}
					bool flag21 = num3 == 1 && fa2.Trim() != "";
					if (flag21)
					{
						string totp2 = Common.GetTotp(fa2.Replace(" ", "").Replace("\n", ""));
						bool flag22 = totp2 != "";
						if (flag22)
						{
							chrome.SendKeys(1, "approvals_code", totp2, 0.1, true, 0.1);
							chrome.DelayThaoTacNho(-1, null);
							chrome.Click(1, "checkpointSubmitButton-actual-button", 0, 0, "", 0, 1);
							chrome.DelayThaoTacNho(0, null);
						}
					}
					int num6 = 0;
					while (chrome.CheckExistElement("#checkpointSubmitButton-actual-button", 3.0) == 1)
					{
						bool flag23 = chrome.CheckExistElement("[name=\"password_new\"]", 0.0) == 1;
						if (flag23)
						{
							break;
						}
						bool flag24 = !chrome.CheckIsLive();
						if (flag24)
						{
							result = -2;
							goto IL_E89;
						}
						bool flag25 = CommonChrome.IsCheckpointWhenLogin(chrome) || num6 == 7;
						if (flag25)
						{
							break;
						}
						chrome.Click(1, "checkpointSubmitButton-actual-button", 0, 0, "", 0, 1);
						chrome.DelayThaoTacNho(0, null);
						num6++;
					}
				}
				chrome.DelayTime(1.0);
				return CommonChrome.CheckLiveCookie(chrome, "https://m.facebook.com");
			}
			catch (Exception ex)
			{
				Common.ExportError(chrome, ex, "Login Uid Pass Fail");
			}
			IL_E89:
			return result;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001A50C File Offset: 0x0001870C
		public static string GetNameFromPost(Chrome chrome)
		{
			string text = chrome.ExecuteScript("var x='';document.querySelectorAll('[property=\"og:title\"]').length>0&&(x=document.querySelector('[property=\"og:title\"]').getAttribute('content')),''==x&&document.querySelectorAll('[data-gt] a').length>0&&(x=document.querySelector('[data-gt] a').innerText),''==x&&document.querySelectorAll('.actor').length>0&&(x=document.querySelector('.actor').innerText), x+''; return x;").ToString();
			bool flag = text == "";
			if (flag)
			{
				text = chrome.ExecuteScript("return document.title").ToString().Split(new char[]
				{
					'-',
					'|'
				})[0].Trim();
			}
			return text;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001A5C4 File Offset: 0x000187C4
		public static string GetNameFromStory(Chrome chrome)
		{
			return chrome.ExecuteScript("var x='';document.querySelectorAll('.overflowText').length>0&&(x=document.querySelector('.overflowText').innerText), x+''; return x;").ToString();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001A600 File Offset: 0x00018800
		public static int GoToHome(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = !(chrome.GetURL() == "https://m.facebook.com/home.php") && !(chrome.GetURL() == "https://m.facebook.com");
					if (flag3)
					{
						bool flag4 = chrome.CheckExistElement("#feed_jewel a", 0.0) == 1;
						if (flag4)
						{
							chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('#feed_jewel a')");
							chrome.DelayThaoTacNho(0, null);
						}
						bool flag5 = chrome.Click(4, "#feed_jewel a", 0, 0, "", 0, 1) != 1;
						if (flag5)
						{
							chrome.GotoURL("https://m.facebook.com/home.php");
						}
						chrome.DelayTime(1.0);
						bool flag6 = chrome.CheckExistElement("#nux-nav-button", 2.0) == 1;
						if (flag6)
						{
							chrome.ClickWithAction(1, "nux-nav-button", 0, 0, "", 0);
							chrome.DelayTime(2.0);
						}
					}
					bool flag7 = chrome.CheckChromeClosed();
					if (flag7)
					{
						return -2;
					}
					bool flag8 = chrome.GetURL() == "https://m.facebook.com/home.php" || chrome.GetURL() == "https://m.facebook.com/home.php?ref=wizard&_rdr" || chrome.GetURL() == "https://m.facebook.com";
					if (flag8)
					{
						return 1;
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001A940 File Offset: 0x00018B40
		public static int GoToFriend(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("#requests_jewel a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('#requests_jewel a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "#requests_jewel a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, "#requests_jewel a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						bool flag6 = chrome.Click(4, "[href=\"/friends/center/friends/?mff_nav=1\"]", 0, 0, "", 0, 1) == 1;
						if (flag6)
						{
							chrome.DelayThaoTacNho(0, null);
							return 1;
						}
					}
					return chrome.GotoURL("https://m.facebook.com/friends/center/friends/?mff_nav=1");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		public static int GoToFriendSuggest(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("#requests_jewel a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('#requests_jewel a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "#requests_jewel a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, "#requests_jewel a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						bool flag6 = chrome.Click(4, "[href=\"/friends/center/suggestions/?mff_nav=1&ref=bookmarks\"]", 0, 0, "", 0, 1) == 1;
						if (flag6)
						{
							chrome.DelayThaoTacNho(0, null);
							return 1;
						}
					}
					return chrome.GotoURL("https://m.facebook.com/friends/center/suggestions/?mff_nav=1&ref=bookmarks");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001AE50 File Offset: 0x00019050
		public static int GoToGroup(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("[data-sigil=\"nav-popover bookmarks\"]>a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "[data-sigil=\"nav-popover bookmarks\"]>a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, "[data-sigil=\"nav-popover bookmarks\"]>a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						string cssSelector = chrome.GetCssSelector("a", "href", "/groups/");
						bool flag6 = cssSelector != "";
						if (flag6)
						{
							chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + cssSelector + "')");
							chrome.DelayThaoTacNho(0, null);
							bool flag7 = chrome.Click(4, cssSelector, 0, 0, "", 0, 1) == 1;
							if (flag7)
							{
								chrome.DelayThaoTacNho(2, null);
								bool flag8 = chrome.Click(4, "[href=\"/groups_browse/your_groups/\"]", 0, 0, "", 0, 1) == 1;
								if (flag8)
								{
									chrome.DelayThaoTacNho(0, null);
									return 1;
								}
							}
						}
					}
					return chrome.GotoURL("https://m.facebook.com/groups_browse/your_groups/");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0001B1FC File Offset: 0x000193FC
		public static int GoToWatch(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("[data-sigil=\"nav-popover bookmarks\"]>a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "[data-sigil=\"nav-popover bookmarks\"]>a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, "[data-sigil=\"nav-popover bookmarks\"]>a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						string cssSelector = chrome.GetCssSelector("a", "href", "/watch/");
						bool flag6 = cssSelector != "";
						if (flag6)
						{
							chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + cssSelector + "')");
							chrome.DelayThaoTacNho(0, null);
							bool flag7 = chrome.Click(4, cssSelector, 0, 0, "", 0, 1) == 1;
							if (flag7)
							{
								chrome.DelayThaoTacNho(0, null);
								return 1;
							}
						}
					}
					return chrome.GotoURL("https://m.facebook.com/watch/?ref=bookmarks");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001B534 File Offset: 0x00019734
		public static int GoToSetting(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("[data-sigil=\"nav-popover bookmarks\"]>a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "[data-sigil=\"nav-popover bookmarks\"]>a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, "[data-sigil=\"nav-popover bookmarks\"]>a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						string cssSelector = chrome.GetCssSelector("a", "href", "/settings/");
						bool flag6 = cssSelector != "";
						if (flag6)
						{
							chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + cssSelector + "')");
							chrome.DelayThaoTacNho(0, null);
							bool flag7 = chrome.Click(4, cssSelector, 0, 0, "", 0, 1) == 1;
							if (flag7)
							{
								chrome.DelayThaoTacNho(0, null);
								return 1;
							}
						}
					}
					return chrome.GotoURL("https://m.facebook.com/settings/?entry_point=bookmark");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001B86C File Offset: 0x00019A6C
		public static int GoToSetting_TimelineAndTagging(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					CommonChrome.GoToSetting(chrome);
					string cssSelector = chrome.GetCssSelector("a", "href", "/privacy/touch/timeline_and_tagging/");
					bool flag3 = cssSelector != "";
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + cssSelector + "')");
						chrome.DelayThaoTacNho(0, null);
						bool flag4 = chrome.Click(4, cssSelector, 0, 0, "", 0, 1) == 1;
						if (flag4)
						{
							chrome.DelayThaoTacNho(0, null);
							return 1;
						}
					}
					return chrome.GotoURL("https://m.facebook.com/privacy/touch/timeline_and_tagging/");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001BA44 File Offset: 0x00019C44
		public static int GoToNotifications(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("#notifications_jewel a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('#notifications_jewel a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "#notifications_jewel a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						num = chrome.Click(4, "#notifications_jewel a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						return 1;
					}
					return chrome.GotoURL("https://m.facebook.com/notifications.php?ref=bookmarks");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001BC48 File Offset: 0x00019E48
		public static int GoToMessages(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("#messages_jewel a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('#messages_jewel a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "#messages_jewel a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, "#messages_jewel a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						return 1;
					}
					return chrome.GotoURL("https://m.facebook.com/messages/?entrypoint=jewel&no_hist=1&ref=bookmarks");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001BE60 File Offset: 0x0001A060
		public static int GoToMessagesUnread(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = CommonChrome.GoToMessages(chrome) == 1;
					if (flag2)
					{
						bool flag3 = chrome.Click(4, "[href=\"/messages/?folder=unread&refid=11&ref=bookmarks\"]", 0, 0, "", 0, 1) == 1;
						if (flag3)
						{
							chrome.DelayRandom(3, 5);
							return 1;
						}
					}
					return chrome.GotoURL("https://m.facebook.com/messages/?folder=unread&ref=bookmarks");
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001BF74 File Offset: 0x0001A174
		public static int GoToSearch(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement("#notifications_jewel a", 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('#search_jewel a')");
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, "#search_jewel a", 0, 0, "", 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, "#search_jewel a", 0, 0, "", 0, 1);
					}
					bool flag5 = num == 1 && chrome.CheckExistElement("#main-search-input", 0.0) == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						return 1;
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
		public static int GoToSearchGroup(Chrome chrome, string tuKhoa, int tocDoGoVanBan = 0)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = CommonChrome.GoToSearch(chrome) == 1;
					if (flag3)
					{
						bool flag4 = false;
						bool flag5 = chrome.CheckExistElement("#main-search-input", 0.0) == 1;
						if (flag5)
						{
							tuKhoa = Common.SpinText(tuKhoa, Base.rd);
							switch (tocDoGoVanBan)
							{
							case 0:
								chrome.SendKeys(Base.rd, 1, "main-search-input", tuKhoa, 0.1, true, 0.1);
								break;
							case 1:
								chrome.SendKeys(1, "main-search-input", tuKhoa, 0.1, true, 0.1);
								break;
							case 2:
								chrome.SendKeys(1, "main-search-input", tuKhoa, true, 0.1);
								break;
							}
							chrome.DelayThaoTacNho(0, null);
							chrome.SendEnter(1, "main-search-input");
							chrome.DelayThaoTacNho(2, null);
							string cssSelector = chrome.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
							bool flag6 = cssSelector != "";
							if (flag6)
							{
								bool flag7 = chrome.Click(4, cssSelector, 0, 0, "", 0, 1) == 0;
								if (flag7)
								{
									bool flag8 = chrome.Click(4, "[data-sigil=\" flyout-causal\"]", 0, 0, "", 0, 1) == 1;
									if (flag8)
									{
										chrome.DelayThaoTacNho(0, null);
										cssSelector = chrome.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
										bool flag9 = cssSelector != "";
										if (flag9)
										{
											flag4 = true;
											chrome.Click(4, cssSelector, 0, 0, "", 0, 1);
											chrome.DelayThaoTacNho(2, null);
										}
									}
								}
								else
								{
									flag4 = true;
									chrome.DelayThaoTacNho(2, null);
								}
							}
						}
						bool flag10 = !flag4;
						if (flag10)
						{
							chrome.GotoURL("https://m.facebook.com/search/groups/?q=" + tuKhoa);
							chrome.DelayThaoTacNho(2, null);
							flag4 = true;
						}
						bool flag11 = flag4;
						if (flag11)
						{
							chrome.DelayThaoTacNho(1, null);
							return 1;
						}
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001C678 File Offset: 0x0001A878
		public static int GoToSearchFriend(Chrome chrome, string tuKhoa, int tocDoGoVanBan = 0)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = CommonChrome.GoToSearch(chrome) == 1;
					if (flag3)
					{
						bool flag4 = false;
						bool flag5 = chrome.CheckExistElement("#main-search-input", 0.0) == 1;
						if (flag5)
						{
							tuKhoa = Common.SpinText(tuKhoa, Base.rd);
							switch (tocDoGoVanBan)
							{
							case 0:
								chrome.SendKeys(Base.rd, 1, "main-search-input", tuKhoa, 0.1, true, 0.1);
								break;
							case 1:
								chrome.SendKeys(1, "main-search-input", tuKhoa, 0.1, true, 0.1);
								break;
							case 2:
								chrome.SendKeys(1, "main-search-input", tuKhoa, true, 0.1);
								break;
							}
							chrome.DelayThaoTacNho(0, null);
							chrome.SendEnter(1, "main-search-input");
							chrome.DelayThaoTacNho(2, null);
							string cssSelector = chrome.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
							bool flag6 = cssSelector != "";
							if (flag6)
							{
								bool flag7 = chrome.Click(4, cssSelector, 0, 0, "", 0, 1) == 0;
								if (flag7)
								{
									bool flag8 = chrome.Click(4, "[data-sigil=\" flyout-causal\"]", 0, 0, "", 0, 1) == 1;
									if (flag8)
									{
										chrome.DelayThaoTacNho(0, null);
										cssSelector = chrome.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
										bool flag9 = cssSelector != "";
										if (flag9)
										{
											flag4 = true;
											chrome.Click(4, cssSelector, 0, 0, "", 0, 1);
											chrome.DelayThaoTacNho(2, null);
										}
									}
								}
								else
								{
									flag4 = true;
									chrome.DelayThaoTacNho(2, null);
								}
							}
						}
						bool flag10 = !flag4;
						if (flag10)
						{
							chrome.GotoURL("https://m.facebook.com/search/people/?q=" + tuKhoa + "&source=filter&isTrending=0");
							chrome.DelayThaoTacNho(2, null);
							flag4 = true;
						}
						bool flag11 = flag4;
						if (flag11)
						{
							chrome.DelayThaoTacNho(1, null);
							return 1;
						}
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001CB64 File Offset: 0x0001AD64
		public static int GoToBirthday(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.GotoURL("https://m.facebook.com/browse/birthdays/") != -2;
					if (flag2)
					{
						chrome.DelayRandom(2, 5);
						return 1;
					}
					return -2;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001CC1C File Offset: 0x0001AE1C
		public static int GoToPoke(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.GotoURL("https://m.facebook.com/pokes/") != -2;
					if (flag2)
					{
						chrome.DelayRandom(2, 5);
						return 1;
					}
					return -2;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001CCD4 File Offset: 0x0001AED4
		public static int ScrollRandom(Chrome chrome, int from = 3, int to = 5)
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					return -2;
				}
				int num = Base.rd.Next(from, to + 1);
				int num2 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
				bool flag2 = chrome.ScrollSmooth(Base.rd.Next(chrome.GetSizeChrome().Y / 2, chrome.GetSizeChrome().Y)) == 1;
				if (flag2)
				{
					chrome.DelayRandom(1, 3);
					int num3 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
					bool flag3 = num2 != num3;
					if (flag3)
					{
						for (int i = 0; i < num - 1; i++)
						{
							num2 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
							bool flag4 = chrome.ScrollSmooth(((Base.rd.Next(1, 1000) % 5 != 0) ? 1 : -1) * Base.rd.Next(chrome.GetSizeChrome().Y / 2, chrome.GetSizeChrome().Y)) == -2;
							if (flag4)
							{
								return -2;
							}
							chrome.DelayRandom(1, 3);
							num3 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
							bool flag5 = num2 != num3;
							if (!flag5)
							{
								break;
							}
							chrome.DelayRandom(1, 2);
						}
					}
					return 1;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001CF9C File Offset: 0x0001B19C
		public static int CheckStatusChrome(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					int num = chrome.CheckExistElement("[jsselect=\"suggestionsSummaryList\"]", 0.0);
					int num2 = num;
					int num3 = num2;
					if (num3 == -2)
					{
						return -2;
					}
					if (num3 == 1)
					{
						return -3;
					}
					bool flag3 = CommonChrome.IsCheckpoint(chrome);
					if (flag3)
					{
						return -1;
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001D09C File Offset: 0x0001B29C
		public static string GetUserAgentDefault()
		{
			string text = "";
			try
			{
				JSON_Settings json_Settings = new JSON_Settings("configGeneral", false);
				Chrome chrome = new Chrome
				{
					HideBrowser = true,
					PathExtension = ""
				};
				bool flag = json_Settings.GetValueInt("typeBrowser", 0) != 0;
				if (flag)
				{
					chrome.LinkToOtherBrowser = json_Settings.GetValue("txtLinkToOtherBrowser", "");
				}
				bool flag2 = chrome.Open(true);
				if (flag2)
				{
					text = chrome.GetUseragent();
					text = text.Replace("Headless", "");
					chrome.Close();
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001D208 File Offset: 0x0001B408
		public static string LoginFacebookUsingCookie(Chrome chrome, string cookie, string URL = "https://www.facebook.com")
		{
			try
			{
				bool flag = chrome.GotoURLIfNotExist(URL) == -2;
				if (flag)
				{
					return "-2";
				}
				bool flag2 = chrome.AddCookieIntoChrome(cookie, ".facebook.com") == -2;
				if (flag2)
				{
					return "-2";
				}
				bool flag3 = chrome.Refresh() == -2;
				if (flag3)
				{
					return "-2";
				}
				return CommonChrome.CheckLiveCookie(chrome, "https://m.facebook.com").ToString() ?? "";
			}
			catch
			{
			}
			return "0";
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001D36C File Offset: 0x0001B56C
		public static int CheckTypeWebFacebookFromUrl(string url)
		{
			int result = 0;
			bool flag = url.StartsWith("https://www.facebook") || url.StartsWith("https://facebook") || url.StartsWith("https://web.facebook");
			if (flag)
			{
				result = 1;
			}
			else
			{
				bool flag2 = url.StartsWith("https://m.facebook") || url.StartsWith("https://d.facebook") || url.StartsWith("https://mobile.facebook");
				if (flag2)
				{
					result = 2;
				}
				else
				{
					bool flag3 = url.StartsWith("https://mbasic.facebook");
					if (flag3)
					{
						result = 3;
					}
				}
			}
			return result;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
		public static int CheckFacebookWebsite(Chrome chrome, string url)
		{
			bool flag = !chrome.CheckIsLive();
			int result;
			if (flag)
			{
				result = -2;
			}
			else
			{
				int num = 0;
				for (int i = 0; i < 2; i++)
				{
					num = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
					bool flag2 = num == 0;
					if (!flag2)
					{
						break;
					}
					chrome.GotoURL(url);
					chrome.DelayTime(1.0);
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0001D580 File Offset: 0x0001B780
		public static List<string> GetListLinkFromWebsite(Chrome chrome)
		{
			List<string> result = new List<string>();
			try
			{
				result = chrome.ExecuteScript("var arr=[]; document.querySelectorAll('a').forEach(e=>{arr.push(e.href)});var s=arr.join('|'); return s").ToString().Split(new char[]
				{
					'|'
				}).ToList<string>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0001D60C File Offset: 0x0001B80C
		public static int GotoLogin(Chrome chrome, int typeWeb)
		{
			bool flag = false;
			try
			{
				switch (typeWeb)
				{
				case 1:
					chrome.GotoURL("https://www.facebook.com/login");
					break;
				case 2:
					chrome.GotoURL("https://m.facebook.com/login");
					break;
				case 3:
					chrome.GotoURL("https://mbasic.facebook.com/login");
					break;
				}
				flag = true;
				chrome.DelayTime(1.0);
			}
			catch (Exception ex)
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0001D720 File Offset: 0x0001B920
		public static string LoginFacebookUsingUidPassNew(Chrome chrome, string uid, string pass, string fa2 = "", string Url = "https://m.facebook.com", int tocDoGoVanBan = 0, bool isDontSaveBrowser = false, int timeOut = 120)
		{
			int num = 0;
			int num2 = 0;
			int tickCount = Environment.TickCount;
			try
			{
				bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) != CommonChrome.CheckTypeWebFacebookFromUrl(Url);
				if (flag)
				{
					chrome.GotoURL(Url);
				}
				string text;
				for (;;)
				{
					int num3 = CommonChrome.CheckFacebookWebsite(chrome, chrome.GetURL());
					bool flag2 = chrome.CheckExistElement("[data-cookiebanner=\"accept_button\"]", 0.0) == 1;
					if (flag2)
					{
						chrome.Click(4, "[data-cookiebanner=\"accept_button\"]", 0, 0, "", 0, 1);
						bool flag3 = chrome.CheckExistElement("[name=\"pass\"]", 0.0) != 1;
						if (flag3)
						{
							CommonChrome.GotoLogin(chrome, num3);
							bool flag4 = chrome.CheckExistElement("[data-cookiebanner=\"accept_button\"]", 0.0) == 1;
							if (flag4)
							{
								chrome.Click(4, "[data-cookiebanner=\"accept_button\"]", 0, 0, "", 0, 1);
							}
						}
					}
					else
					{
						bool flag5 = chrome.CheckExistElement("[name=\"email\"]", 0.0) == 1 && chrome.CheckExistElement("[name=\"pass\"]", 0.0) == 1 && chrome.CheckExistElement("[name=\"login\"]", 0.0) == 1;
						bool flag6 = chrome.CheckExistElements(0.0, new string[]
						{
							"[ajaxify*=\"/login/device-based/async/remove/\"]",
							"[data-sigil=\"login_profile_form\"] div[role=\"button\"]",
							"[action=\"/login/device-based/validate-pin/\"] input[type=\"submit\"]"
						}) > 0;
						bool flag7 = !flag5 && !flag6;
						if (flag7)
						{
							CommonChrome.GotoLogin(chrome, num3);
							bool flag8 = chrome.CheckExistElement("[data-cookiebanner=\"accept_button\"]", 0.0) == 1;
							if (flag8)
							{
								chrome.Click(4, "[data-cookiebanner=\"accept_button\"]", 0, 0, "", 0, 1);
							}
						}
					}
					bool flag9 = CommonChrome.CheckCheckpoint(chrome, "", "");
					if (flag9)
					{
						break;
					}
					int num4 = chrome.CheckExistElements(0.0, new string[]
					{
						"[data-sigil=\"login_profile_form\"] div[role=\"button\"]",
						"[action=\"/login/device-based/validate-pin/\"] input[type=\"submit\"]"
					});
					bool flag10 = num3 == 2 && num4 > 0;
					if (flag10)
					{
						int num5 = num4;
						int num6 = num5;
						if (num6 != 1)
						{
							if (num6 == 2)
							{
								chrome.ExecuteScript("document.querySelector('[action=\"/login/device-based/validate-pin/\"] input[type=\"submit\"]').click()");
							}
						}
						else
						{
							chrome.ExecuteScript("document.querySelector('[data-sigil=\"login_profile_form\"] div[role=\"button\"]').click()");
						}
						chrome.DelayTime(1.0);
						num2 = chrome.CheckExistElements(5.0, new string[]
						{
							"[name=\"pass\"]",
							"#approvals_code"
						});
						bool flag11 = num2 == 1;
						if (flag11)
						{
							bool flag12 = chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, "pass", pass, 0.1, true, 0.1) == 1;
							if (flag12)
							{
								chrome.DelayTime(1.0);
								bool flag13 = chrome.Click(4, chrome.GetCssSelector("button", "data-sigil", "password_login_button"), 0, 0, "", 0, 1) == 1;
								if (flag13)
								{
									chrome.DelayTime(1.0);
								}
							}
						}
					}
					else
					{
						bool flag14 = chrome.CheckExistElement("[data-sigil=\"touchable\"]", 0.0) == 1 && chrome.CheckExistElement("#m_login_auto_search_form_forgot_password_button", 0.0) != 1;
						if (flag14)
						{
							chrome.Click(4, "[data-sigil=\"touchable\"]", 0, 0, "", 0, 1);
						}
						int num7 = 1;
						bool flag15 = false;
						do
						{
							switch (num7)
							{
							case 1:
								num2 = chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, "email", uid, 0.1, true, 0.1);
								break;
							case 2:
								num2 = chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, "pass", pass, 0.1, true, 0.1);
								break;
							case 3:
								num2 = chrome.SendEnter(2, "pass");
								chrome.DelayTime(3.0);
								flag15 = true;
								break;
							default:
								flag15 = true;
								break;
							}
							bool flag16 = num2 == -2;
							if (flag16)
							{
								goto Block_24;
							}
							chrome.DelayTime(1.0);
							num7++;
						}
						while (!flag15);
					}
					Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>
					{
						{
							1,
							new List<string>
							{
								"[name=\"login\"]",
								"[name=\"reset_action\"]"
							}
						},
						{
							2,
							new List<string>
							{
								"[name=\"approvals_code\"]"
							}
						},
						{
							3,
							new List<string>
							{
								"#checkpoint_title"
							}
						},
						{
							4,
							new List<string>
							{
								"#checkpointSubmitButton",
								"#checkpointBottomBar"
							}
						},
						{
							5,
							new List<string>
							{
								"#qf_skip_dialog_skip_link"
							}
						},
						{
							6,
							new List<string>
							{
								"#nux-nav-button"
							}
						},
						{
							7,
							new List<string>
							{
								"[name=\"n\"]"
							}
						},
						{
							8,
							new List<string>
							{
								"#identify_search_text_input"
							}
						}
					};
					int num8 = 0;
					int num9 = 0;
					for (;;)
					{
						bool flag17 = Environment.TickCount - tickCount >= timeOut * 1000;
						if (flag17)
						{
							goto Block_25;
						}
						num2 = chrome.CheckExistElements(0.0, dic);
						switch (num2)
						{
						case 1:
						{
							bool flag18 = num8 == 0 && num9 == 0;
							if (flag18)
							{
								text = "";
								int num10 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
								int num11 = num10;
								if (num11 != 1)
								{
									if (num11 == 2)
									{
										text = chrome.ExecuteScript("var out='';var x=document.querySelector('#login_error');if(x!=null) out=x.innerText;return out;").ToString();
									}
								}
								else
								{
									text = chrome.ExecuteScript("var out='';var x=document.querySelector('#error_box');if(x!=null) out=x.innerText;return out;").ToString();
									text = ((text.Split(new string[]
									{
										"\r\n"
									}, StringSplitOptions.RemoveEmptyEntries).Count<string>() > 1) ? text.Split(new string[]
									{
										"\r\n"
									}, StringSplitOptions.RemoveEmptyEntries)[1] : text);
								}
								bool flag19 = text != "";
								if (flag19)
								{
									goto Block_32;
								}
								bool flag20 = chrome.CheckExistElement("[href=\"/login/identify/\"]", 0.0) == 1;
								if (flag20)
								{
									num = 4;
								}
								else
								{
									bool flag21 = chrome.CheckExistElement("#account_recovery_initiate_view_label", 0.0) == 1;
									if (flag21)
									{
										num = 5;
									}
									else
									{
										bool flag22 = !Convert.ToBoolean(chrome.ExecuteScript("return (document.querySelector('[name=\"email\"]').value!='' && document.querySelector('[name=\"pass\"]').value!='')+''").ToString());
										if (flag22)
										{
											bool flag23 = chrome.ExecuteScript("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "";
											if (flag23)
											{
												num = 4;
											}
											else
											{
												bool flag24 = chrome.ExecuteScript("return document.querySelector('[name=\"pass\"]').value").ToString().Trim() == "";
												if (flag24)
												{
													num = 5;
												}
											}
										}
									}
								}
							}
							else
							{
								bool flag25 = chrome.ExecuteScript("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "";
								if (flag25)
								{
									goto Block_38;
								}
							}
							break;
						}
						case 2:
						{
							bool flag26 = fa2 == "";
							if (flag26)
							{
								num = 3;
							}
							else
							{
								num8++;
								bool flag27 = num8 > 2;
								if (flag27)
								{
									goto Block_40;
								}
								string totp = Common.GetTotp(fa2.Replace(" ", "").Replace("\n", "").Trim());
								bool flag28 = string.IsNullOrEmpty(totp);
								if (flag28)
								{
									goto Block_41;
								}
								chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, "approvals_code", totp, 0.1, true, 0.1);
								chrome.DelayTime(1.0);
								chrome.SendEnter(2, "approvals_code");
								chrome.DelayTime(1.0);
							}
							break;
						}
						case 3:
						{
							bool flag29 = num8 > 1;
							if (flag29)
							{
								num = 6;
							}
							else
							{
								bool flag30 = CommonChrome.CheckCheckpoint(chrome, "", "");
								if (flag30)
								{
									goto Block_43;
								}
								num2 = chrome.CheckExistElements(0.0, new string[]
								{
									"button#checkpointSubmitButton",
									"#checkpointSubmitButton [type=\"submit\"]"
								});
								num9++;
								bool flag31 = num9 > 10;
								if (flag31)
								{
									goto Block_44;
								}
								bool flag32 = chrome.CheckExistElement("[value=\"dont_save\"]", 0.0) == 1 && isDontSaveBrowser;
								if (flag32)
								{
									chrome.Click(4, "[value=\"dont_save\"]", 0, 0, "", 0, 1);
								}
								bool flag33 = num2 == 1;
								if (flag33)
								{
									chrome.Click(4, "button#checkpointSubmitButton", 0, 0, "", 0, 1);
								}
								else
								{
									chrome.Click(4, "#checkpointSubmitButton [type=\"submit\"]", 0, 0, "", 0, 1);
								}
								chrome.DelayTime(1.0);
							}
							break;
						}
						case 4:
						{
							bool flag34 = num8 > 1;
							if (flag34)
							{
								num = 6;
							}
							else
							{
								bool flag35 = CommonChrome.CheckCheckpoint(chrome, "", "");
								if (flag35)
								{
									goto Block_48;
								}
								num2 = chrome.CheckExistElements(0.0, new string[]
								{
									"button#checkpointSubmitButton",
									"#checkpointSubmitButton [type=\"submit\"]"
								});
								num9++;
								bool flag36 = num9 > 10;
								if (flag36)
								{
									goto Block_49;
								}
								bool flag37 = chrome.CheckExistElement("[value=\"dont_save\"]", 0.0) == 1 && isDontSaveBrowser;
								if (flag37)
								{
									chrome.Click(4, "[value=\"dont_save\"]", 0, 0, "", 0, 1);
								}
								bool flag38 = num2 == 1;
								if (flag38)
								{
									chrome.Click(4, "button#checkpointSubmitButton", 0, 0, "", 0, 1);
								}
								else
								{
									chrome.Click(4, "#checkpointSubmitButton [type=\"submit\"]", 0, 0, "", 0, 1);
								}
								chrome.DelayTime(1.0);
							}
							break;
						}
						case 5:
							chrome.ClickWithAction(1, "qf_skip_dialog_skip_link", 0, 0, "", 0);
							chrome.DelayTime(2.0);
							break;
						case 6:
							chrome.Click(1, "nux-nav-button", 0, 0, "", 0, 1);
							chrome.DelayTime(2.0);
							break;
						case 7:
							num = 5;
							break;
						case 8:
							goto IL_152A;
						default:
						{
							bool flag39 = chrome.GetURL().Contains("facebook.com/confirm");
							if (flag39)
							{
								goto Block_52;
							}
							bool flag40 = CommonChrome.CheckCheckpoint(chrome, "", "");
							if (flag40)
							{
								goto Block_53;
							}
							bool flag41 = chrome.CheckExistElement("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 0.0) == 1;
							if (flag41)
							{
								chrome.ExecuteScript("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
								chrome.DelayTime(3.0);
								bool flag42 = chrome.CheckExistElement("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1;
								if (flag42)
								{
									chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
									chrome.DelayTime(3.0);
								}
							}
							else
							{
								bool flag43 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 2;
								if (flag43)
								{
									bool flag44 = chrome.GetURL().StartsWith("https://m.facebook.com/zero/policy/optin");
									if (flag44)
									{
										chrome.DelayTime(1.0);
										chrome.ExecuteScript("document.querySelector('a[data-sigil=\"touchable\"]').click()");
										chrome.DelayTime(3.0);
										bool flag45 = chrome.CheckExistElement("button[data-sigil=\"touchable\"]", 10.0) == 1;
										if (flag45)
										{
											chrome.DelayTime(1.0);
											chrome.ExecuteScript("document.querySelector('button[data-sigil=\"touchable\"]').click()");
											chrome.DelayTime(3.0);
										}
									}
									bool flag46 = Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check"));
									if (flag46)
									{
										for (int i = 0; i < 5; i++)
										{
											Common.DelayTime(2.0);
											bool flag47 = !Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check"));
											if (flag47)
											{
												break;
											}
										}
										for (int j = 0; j < 5; j++)
										{
											Common.DelayTime(2.0);
											bool flag48 = !Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check"));
											if (flag48)
											{
												break;
											}
										}
										bool flag49 = chrome.CheckExistElement("[href=\"/home.php\"]", 0.0) == 1;
										if (flag49)
										{
											chrome.Click(4, "[href=\"/home.php\"]", 0, 0, "", 0, 1);
										}
									}
									for (;;)
									{
										bool flag50 = chrome.GetURL().StartsWith("https://m.facebook.com/legal_consent");
										if (!flag50)
										{
											break;
										}
										int num12 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('button').length").ToString());
										bool flag51 = num12 == 3;
										if (flag51)
										{
											chrome.Click(4, "button", 0, 0, "", 0, 1);
										}
										else
										{
											bool flag52 = num12 == 4;
											if (flag52)
											{
												chrome.Click(4, "button", 1, 0, "", 0, 1);
											}
										}
										chrome.DelayTime(2.0);
									}
									bool flag53 = chrome.GetURL().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway");
									if (flag53)
									{
										bool flag54 = chrome.CheckExistElement("[data-nt=\"NT:IMAGE\"]", 15.0) == 1;
										if (flag54)
										{
											chrome.ExecuteScript("document.querySelector('[data-nt=\"NT:IMAGE\"]').click()");
											chrome.DelayTime(2.0);
										}
									}
									bool flag55 = chrome.CheckExistElement("button[value=\"OK\"]", 0.0) == 1;
									if (flag55)
									{
										chrome.Click(4, "button[value=\"OK\"]", 0, 0, "", 0, 1);
										chrome.DelayTime(1.0);
									}
									bool flag56 = chrome.CheckExistElement("[data-store-id=\"2\"]>span", 0.0) == 1;
									if (flag56)
									{
										chrome.Click(4, "[data-store-id=\"2\"]>span", 0, 0, "", 0, 1);
										chrome.DelayTime(1.0);
									}
									bool flag57 = chrome.CheckExistElement("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span", 0.0) == 1;
									if (flag57)
									{
										chrome.Click(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span", 0, 0, "", 0, 1);
										chrome.DelayTime(3.0);
									}
								}
								else
								{
									bool flag58 = chrome.GetURL().StartsWith("https://www.facebook.com/legal_consent");
									if (flag58)
									{
										for (int k = 0; k < 5; k++)
										{
											bool flag59 = chrome.CheckExistElement("button", 0.0) != 1;
											if (flag59)
											{
												break;
											}
											chrome.ExecuteScript("document.querySelector('button').click()");
											chrome.DelayTime(1.0);
										}
									}
								}
							}
							bool flag60 = CommonChrome.CheckLoginSuccess(chrome, "", "");
							if (flag60)
							{
								num = 1;
							}
							break;
						}
						}
						if (num != 0)
						{
							goto IL_1E81;
						}
					}
					IL_152A:
					chrome.GotoURL("https://www.facebook.com");
					chrome.DelayTime(1.0);
				}
				num = 2;
				goto IL_1EBD;
				Block_24:
				num = -2;
				Block_25:
				goto IL_1E81;
				Block_32:
				return text;
				Block_38:
				num = 0;
				goto IL_1EBD;
				Block_40:
				num = 6;
				goto IL_1EBD;
				Block_41:
				num = 6;
				goto IL_1EBD;
				Block_43:
				num = 2;
				Block_44:
				goto IL_1EBD;
				Block_48:
				num = 2;
				Block_49:
				goto IL_1EBD;
				Block_52:
				num = 1;
				goto IL_1EBD;
				Block_53:
				num = 2;
				IL_1E81:;
			}
			catch (Exception ex)
			{
				Common.ExportError(chrome, ex, "Error Login Uid Pass");
			}
			IL_1EBD:
			return num.ToString() ?? "";
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0001F634 File Offset: 0x0001D834
		public static string GetInfoAccountFromUidUsingCookie(Chrome chrome)
		{
			bool flag = false;
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			string text8 = "";
			string text9 = "";
			string text10 = "";
			try
			{
				string cookieFromChrome = chrome.GetCookieFromChrome("facebook");
				string value = Regex.Match(cookieFromChrome + ";", "c_user=(.*?);").Groups[1].Value;
				string text11 = CommonChrome.RequestGet(chrome, CommonChrome.GetHostFacebook(chrome, 3) + "/friends/center/friends/?mff_nav=1", CommonChrome.GetHostFacebook(chrome, 3));
				text6 = Regex.Match(text11, "bm bn\">(.*?)<").Groups[1].Value.Replace(",", "").Replace(".", "");
				bool flag2 = text6 == "";
				if (flag2)
				{
					text6 = Regex.Match(text11, "bm\">(.*?)<").Groups[1].Value.Replace(",", "").Replace(".", "");
				}
				text6 = Regex.Match(text6, "\\d+").Value;
				text11 = CommonChrome.RequestGet(chrome, CommonChrome.GetHostFacebook(chrome, 3) + "/groups/?seemore&refid=27", CommonChrome.GetHostFacebook(chrome, 3));
				text7 = Regex.Matches(text11, "class=\"bl\"").Count.ToString();
				bool flag3 = text7 == "0";
				if (flag3)
				{
					text7 = Regex.Matches(text11, "class=\"bm\"").Count.ToString();
				}
				try
				{
					text11 = CommonChrome.RequestGet(chrome, CommonChrome.GetHostFacebook(chrome, 2) + "/composer/ocelot/async_loader/?publisher=feed", CommonChrome.GetHostFacebook(chrome, 2));
					string value2 = Regex.Match(text11, "fb_dtsg\\\\\" value=\\\\\"(.*?)\\\\\"").Groups[1].Value;
					text8 = Regex.Match(text11, "EAAA(.*?)\"").Value.TrimEnd(new char[]
					{
						'"',
						'\\'
					});
					string data = string.Concat(new string[]
					{
						"av=",
						value,
						"&__user=",
						value,
						"&__a=1&__dyn=&__csr=&__req=y&__hs=18794.EXP2%3Acomet_pkg.2.1.0.0&dpr=1&__ccg=EXCELLENT&__rev=1003974565&__s=zbue97%3A5iciql%3Abxnvge&__hsi=6974199735511561326-0&__comet_req=1&fb_dtsg=",
						value2,
						"&jazoest=22414&lsd=&__spin_r=1003974565&__spin_b=trunk&__spin_t=1623807413&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=PrivacyAccessHubYourInformationSectionQuery&variables=%7B%7D&server_timestamps=true&doc_id=3200030856767767"
					});
					text11 = CommonChrome.RequestPost(chrome, CommonChrome.GetHostFacebook(chrome, 1) + "/api/graphql/", data, CommonChrome.GetHostFacebook(chrome, 1) + "/api/graphql/", "application/x-www-form-urlencoded");
					JObject jobject = JObject.Parse(text11);
					text9 = jobject["data"]["section"]["tiles"][1]["links"][0]["non_link_content"]["metadata"].ToString();
				}
				catch
				{
				}
				string infoAccountFromUidUsingToken = CommonChrome.GetInfoAccountFromUidUsingToken(chrome, text8);
				string[] array = infoAccountFromUidUsingToken.Split(new char[]
				{
					'|'
				});
				text = array[1];
				text2 = array[2];
				text3 = array[3];
				text5 = array[5];
				bool flag4 = text10 == "";
				if (flag4)
				{
					text10 = "0";
				}
				bool flag5 = text6 == "";
				if (flag5)
				{
					text6 = "0";
				}
				bool flag6 = text7 == "";
				if (flag6)
				{
					text7 = "0";
				}
			}
			catch (Exception ex)
			{
				bool flag7 = CommonChrome.CheckLiveCookie(chrome, "https://m.facebook.com/") == 0;
				if (flag7)
				{
					return "-1";
				}
				CommonCSharp.ExportError(null, ex.ToString());
			}
			return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}", new object[]
			{
				flag,
				text,
				text2,
				text3,
				text4,
				text5,
				text6,
				text7,
				text8,
				text9,
				text10
			});
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001FF24 File Offset: 0x0001E124
		public static string GetInfoAccountFromUidUsingToken(Chrome chrome, string token)
		{
			bool flag = false;
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			try
			{
				string json = CommonChrome.RequestGet(chrome, "https://graph.facebook.com/v2.11/me?fields=name,email,gender,birthday&access_token=" + token, "https://graph.facebook.com/");
				JObject jobject = JObject.Parse(json);
				flag = true;
				text = jobject["name"].ToString();
				try
				{
					text2 = jobject["gender"].ToString();
				}
				catch
				{
				}
				try
				{
					text3 = jobject["birthday"].ToString();
				}
				catch
				{
				}
				try
				{
					text5 = jobject["email"].ToString();
				}
				catch
				{
				}
			}
			catch
			{
			}
			return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", new object[]
			{
				flag,
				text,
				text2,
				text3,
				text4,
				text5,
				text6,
				text7
			});
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0002020C File Offset: 0x0001E40C
		public static string GetTokenEAAAAZ(Chrome chrome)
		{
			string result = "";
			try
			{
				string input = CommonChrome.RequestGet(chrome, "https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed", "https://m.facebook.com");
				result = Regex.Match(input, "EAAAAZ(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00020318 File Offset: 0x0001E518
		public static int CheckLiveCookie(Chrome chrome, string url = "https://m.facebook.com")
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					return -2;
				}
				bool flag2 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) != CommonChrome.CheckTypeWebFacebookFromUrl(url);
				if (flag2)
				{
					chrome.GotoURL(url);
				}
				string url2 = chrome.GetURL();
				bool flag3 = url2.Contains("facebook.com/checkpoint/") || url2.Contains("facebook.com/nt/screen/?params=%7B%22token") || url2.Contains("facebook.com/x/checkpoint/");
				if (flag3)
				{
					return 2;
				}
				int num = CommonChrome.CheckFacebookWebsite(chrome, url);
				bool flag4 = num == 2;
				if (flag4)
				{
					bool flag5 = chrome.CheckExistElement("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1;
					if (flag5)
					{
						chrome.ExecuteScript("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
						chrome.DelayTime(3.0);
						bool flag6 = chrome.CheckExistElement("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1;
						if (flag6)
						{
							chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
							chrome.DelayTime(3.0);
						}
					}
					bool flag7 = chrome.GetURL().StartsWith("https://m.facebook.com/zero/optin/write/");
					if (flag7)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
						chrome.DelayTime(3.0);
					}
					bool flag8 = chrome.GetURL().StartsWith("https://m.facebook.com/zero/policy/optin");
					if (flag8)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('a[data-sigil=\"touchable\"]').click()");
						chrome.DelayTime(3.0);
						bool flag9 = chrome.CheckExistElement("button[data-sigil=\"touchable\"]", 10.0) == 1;
						if (flag9)
						{
							chrome.DelayTime(1.0);
							chrome.ExecuteScript("document.querySelector('button[data-sigil=\"touchable\"]').click()");
							chrome.DelayTime(3.0);
						}
					}
					bool flag10 = Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check"));
					if (flag10)
					{
						for (int i = 0; i < 5; i++)
						{
							Common.DelayTime(2.0);
							bool flag11 = !Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check"));
							if (flag11)
							{
								break;
							}
						}
						for (int j = 0; j < 5; j++)
						{
							Common.DelayTime(2.0);
							bool flag12 = !Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check"));
							if (flag12)
							{
								break;
							}
						}
						bool flag13 = chrome.CheckExistElement("[href=\"/home.php\"]", 0.0) == 1;
						if (flag13)
						{
							chrome.Click(4, "[href=\"/home.php\"]", 0, 0, "", 0, 1);
						}
					}
					bool flag14 = chrome.GetURL().StartsWith("https://m.facebook.com/legal_consent");
					if (flag14)
					{
						chrome.ExecuteScript("document.querySelector('button').click()");
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelectorAll('button')[1].click()");
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('button').click()");
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelectorAll('button')[1].click()");
						chrome.DelayTime(1.0);
					}
					bool flag15 = chrome.GetURL().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway");
					if (flag15)
					{
						chrome.Click(4, "[data-sigil=\"touchable\"]", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag16 = chrome.CheckExistElement("button[value=\"OK\"]", 0.0) == 1;
					if (flag16)
					{
						chrome.Click(4, "button[value=\"OK\"]", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag17 = chrome.CheckExistElement("[data-store-id=\"2\"]>span", 0.0) == 1;
					if (flag17)
					{
						chrome.Click(4, "[data-store-id=\"2\"]>span", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag18 = chrome.CheckExistElement("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span", 0.0) == 1;
					if (flag18)
					{
						chrome.Click(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span", 0, 0, "", 0, 1);
						chrome.DelayTime(3.0);
					}
					bool flag19 = chrome.CheckExistElement("#nux-nav-button", 0.0) == 1;
					if (flag19)
					{
						bool flag20 = false;
						for (int k = 0; k < 5; k++)
						{
							bool flag21 = flag20;
							if (flag21)
							{
								break;
							}
							int num2 = chrome.CheckExistElements(3.0, new string[]
							{
								"#qf_skip_dialog_skip_link",
								"#nux-nav-button"
							});
							int num3 = num2;
							int num4 = num3;
							if (num4 != 1)
							{
								if (num4 != 2)
								{
									flag20 = true;
								}
								else
								{
									chrome.Click(1, "nux-nav-button", 0, 0, "", 0, 1);
									chrome.DelayTime(2.0);
								}
							}
							else
							{
								chrome.ExecuteScript("document.querySelector('#qf_skip_dialog_skip_link').click()");
								chrome.DelayTime(1.0);
							}
						}
					}
				}
				else
				{
					bool flag22 = num == 1;
					if (flag22)
					{
						bool flag23 = chrome.GetURL().StartsWith("https://www.facebook.com/legal_consent");
						if (flag23)
						{
							for (int l = 0; l < 5; l++)
							{
								bool flag24 = chrome.CheckExistElement("button", 0.0) != 1;
								if (flag24)
								{
									break;
								}
								chrome.ExecuteScript("document.querySelector('button').click()");
								chrome.DelayTime(1.0);
							}
						}
					}
				}
				CommonChrome.CheckStatusAccount(chrome, true);
				switch (chrome.Status)
				{
				case StatusChromeAccount.ChromeClosed:
					return -2;
				case StatusChromeAccount.LoginWithUserPass:
				case StatusChromeAccount.LoginWithSelectAccount:
					return 0;
				case StatusChromeAccount.Checkpoint:
					return 2;
				case StatusChromeAccount.Logined:
					return 1;
				case StatusChromeAccount.NoInternet:
					return -3;
				case StatusChromeAccount.Noveri:
					return 3;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00020F18 File Offset: 0x0001F118
		public static int CheckLiveCookieWhenGiaiCP(Chrome chrome, string url = "https://m.facebook.com")
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					return -2;
				}
				bool flag2 = chrome.GetURL().Contains("https://m.facebook.com/x/checkpoint/hacked_cleanup") || chrome.CheckExistElement("#checkpointButtonGetStarted", 0.0) == 1;
				if (flag2)
				{
					return 1;
				}
				bool flag3 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 0;
				if (flag3)
				{
					chrome.GotoURL(url);
				}
				int num = CommonChrome.CheckFacebookWebsite(chrome, url);
				bool flag4 = num == 2;
				if (flag4)
				{
					bool flag5 = chrome.CheckExistElement("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1;
					if (flag5)
					{
						chrome.ExecuteScript("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
						chrome.DelayTime(3.0);
						bool flag6 = chrome.CheckExistElement("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1;
						if (flag6)
						{
							chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
							chrome.DelayTime(3.0);
						}
					}
					bool flag7 = chrome.GetURL().StartsWith("https://m.facebook.com/zero/optin/write/");
					if (flag7)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
						chrome.DelayTime(3.0);
					}
					bool flag8 = chrome.GetURL().StartsWith("https://m.facebook.com/zero/policy/optin");
					if (flag8)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('a[data-sigil=\"touchable\"]').click()");
						chrome.DelayTime(3.0);
						bool flag9 = chrome.CheckExistElement("button[data-sigil=\"touchable\"]", 10.0) == 1;
						if (flag9)
						{
							chrome.DelayTime(1.0);
							chrome.ExecuteScript("document.querySelector('button[data-sigil=\"touchable\"]').click()");
							chrome.DelayTime(3.0);
						}
					}
					bool flag10 = Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check"));
					if (flag10)
					{
						for (int i = 0; i < 5; i++)
						{
							Common.DelayTime(2.0);
							bool flag11 = !Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check"));
							if (flag11)
							{
								break;
							}
						}
						for (int j = 0; j < 5; j++)
						{
							Common.DelayTime(2.0);
							bool flag12 = !Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check"));
							if (flag12)
							{
								break;
							}
						}
						bool flag13 = chrome.CheckExistElement("[href=\"/home.php\"]", 0.0) == 1;
						if (flag13)
						{
							chrome.Click(4, "[href=\"/home.php\"]", 0, 0, "", 0, 1);
						}
					}
					bool flag14 = chrome.GetURL().StartsWith("https://m.facebook.com/legal_consent");
					if (flag14)
					{
						chrome.ExecuteScript("document.querySelector('button').click()");
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelectorAll('button')[1].click()");
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('button').click()");
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelectorAll('button')[1].click()");
						chrome.DelayTime(1.0);
					}
					bool flag15 = chrome.GetURL().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway");
					if (flag15)
					{
						chrome.Click(4, "[data-sigil=\"touchable\"]", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag16 = chrome.CheckExistElement("button[value=\"OK\"]", 0.0) == 1;
					if (flag16)
					{
						chrome.Click(4, "button[value=\"OK\"]", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag17 = chrome.CheckExistElement("[data-store-id=\"2\"]>span", 0.0) == 1;
					if (flag17)
					{
						chrome.Click(4, "[data-store-id=\"2\"]>span", 0, 0, "", 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag18 = chrome.CheckExistElement("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span", 0.0) == 1;
					if (flag18)
					{
						chrome.Click(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span", 0, 0, "", 0, 1);
						chrome.DelayTime(3.0);
					}
				}
				else
				{
					bool flag19 = num == 1;
					if (flag19)
					{
						bool flag20 = chrome.GetURL().StartsWith("https://www.facebook.com/legal_consent");
						if (flag20)
						{
							for (int k = 0; k < 5; k++)
							{
								bool flag21 = chrome.CheckExistElement("button", 0.0) != 1;
								if (flag21)
								{
									break;
								}
								chrome.ExecuteScript("document.querySelector('button').click()");
								chrome.DelayTime(1.0);
							}
						}
					}
				}
				CommonChrome.CheckStatusAccount(chrome, true);
				switch (chrome.Status)
				{
				case StatusChromeAccount.ChromeClosed:
					return -2;
				case StatusChromeAccount.LoginWithUserPass:
				case StatusChromeAccount.LoginWithSelectAccount:
					return 0;
				case StatusChromeAccount.Checkpoint:
					return 2;
				case StatusChromeAccount.Logined:
					return 1;
				case StatusChromeAccount.NoInternet:
					return -3;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0002193C File Offset: 0x0001FB3C
		public static bool IsCheckpoint(Chrome chrome)
		{
			try
			{
				bool flag = chrome.CheckExistElements(0.0, new string[]
				{
					"#checkpointSubmitButton",
					"#captcha_response",
					"[name=\"verification_method\"]",
					"#checkpointBottomBar",
					"[href =\"https://www.facebook.com/communitystandards/\"]"
				}) > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00021A44 File Offset: 0x0001FC44
		public static bool IsCheckpointWhenLogin(Chrome chrome)
		{
			try
			{
				bool flag = chrome.CheckExistElements(0.0, new string[]
				{
					"[name=\"captcha_response\"]",
					"#captcha_response",
					"[name=\"password_new\"]",
					"[name=\"verification_method\"]",
					"[href =\"https://www.facebook.com/communitystandards/\"]"
				}) > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00021B4C File Offset: 0x0001FD4C
		public static string GetTokenEAAG(Chrome chrome)
		{
			string result = "";
			try
			{
				bool flag = !chrome.GetURL().Contains("https://business.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://business.facebook.com/");
				}
				result = (string)chrome.ExecuteScript("async function GetTokenEaag() { var output = ''; try { var response = await fetch('https://business.facebook.com/business_locations/'); if (response.ok) { var body = await response.text(); output=body.match(new RegExp('EAAG(.*?)\"'))[0].replace('\"',''); } } catch {} return output; }; var c = await GetTokenEaag(); return c;");
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00021C1C File Offset: 0x0001FE1C
		public static string RequestGet(Chrome chrome, string url, string website)
		{
			try
			{
				bool flag = website.Split(new char[]
				{
					'/'
				}).Length > 2;
				if (flag)
				{
					website = website.Replace("//", "__");
					website = website.Split(new char[]
					{
						'/'
					})[0];
					website = website.Replace("__", "//");
				}
				bool flag2 = !chrome.GetURL().StartsWith(website);
				if (flag2)
				{
					chrome.GotoURL(website);
					chrome.DelayTime(1.0);
					chrome.ExecuteScript("document.querySelector('body').innerHTML='MIN SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
				}
				return (string)chrome.ExecuteScript("async function RequestGet() { var output = ''; try { var response = await fetch('" + url + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00021E08 File Offset: 0x00020008
		public static string RequestPost(Chrome chrome, string url, string data, string website, string contentType = "application/x-www-form-urlencoded")
		{
			try
			{
				bool flag = !chrome.GetURL().StartsWith(website);
				if (flag)
				{
					chrome.GotoURL(website);
					chrome.DelayTime(1.0);
					chrome.ExecuteScript("document.querySelector('body').innerHTML='MIN SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
				}
				chrome.DelayTime(1.0);
				data = data.Replace("\n", "\\n").Replace("\"", "\\\"");
				return (string)chrome.ExecuteScript(string.Concat(new string[]
				{
					"async function RequestPost() { var output = ''; try { var response = await fetch('",
					url,
					"', { method: 'POST', body: '",
					data,
					"', headers: { 'Content-Type': '",
					contentType,
					"' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;"
				}));
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0002200C File Offset: 0x0002020C
		public static string GetBirthday(Chrome chrome, string token)
		{
			string result = "";
			try
			{
				bool flag = !chrome.GetURL().Contains("https://graph.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://graph.facebook.com/");
				}
				string json = (string)chrome.ExecuteScript("async function RequestGet() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me?fields=id,birthday,name&access_token=" + token + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
				JObject jobject = JObject.Parse(json);
				return string.Concat(new string[]
				{
					jobject["id"].ToString(),
					"|",
					jobject["birthday"].ToString(),
					"|",
					jobject["name"].ToString()
				});
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000221D0 File Offset: 0x000203D0
		public static List<string> GetMyListUidMessage(Chrome chrome)
		{
			List<string> list = new List<string>();
			try
			{
				bool flag = !chrome.GetURL().Contains("https://mbasic.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://mbasic.facebook.com/");
				}
				string input = (string)chrome.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com/messages/'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				int num = 1;
				string text2;
				do
				{
					MatchCollection matchCollection = Regex.Matches(input, "#fua\">(.*?)<");
					for (int i = 0; i < matchCollection.Count; i++)
					{
						try
						{
							string text = matchCollection[i].Groups[1].Value.Replace("\"", "");
							text = WebUtility.HtmlDecode(text);
							bool flag2 = !list.Contains(text);
							if (flag2)
							{
								list.Add(text);
							}
						}
						catch
						{
						}
					}
					text2 = Regex.Match(input, "/messages/.pageNum=(.*?)\"").Value.Replace("amp;", "");
					input = (string)chrome.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com" + text2 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
					num++;
					bool flag3 = num >= 5;
					if (flag3)
					{
						break;
					}
				}
				while (text2 != "");
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000224A4 File Offset: 0x000206A4
		public static List<string> GetMyListComments(Chrome chrome, int numberMonth)
		{
			List<string> list = new List<string>();
			try
			{
				bool flag = !chrome.GetURL().Contains("https://mbasic.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://mbasic.facebook.com/");
				}
				string format = "https://mbasic.facebook.com/{0}/allactivity/?category_key=commentscluster&timestart={1}&timeend={2}";
				string text = chrome.ExecuteScript("return (document.cookie + ';').match(new RegExp('c_user=(.*?);'))[1]").ToString();
				List<string> list2 = new List<string>();
				for (int i = 0; i < numberMonth; i++)
				{
					DateTime dateTime = DateTime.Now.AddMonths(2 - i);
					DateTime dateTime2 = DateTime.Now.AddMonths(1 - i);
					string arg = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime.Year, dateTime.Month, 1)).ToString();
					string arg2 = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime2.Year, dateTime2.Month, 1)).ToString();
					string text2 = string.Format(format, text, arg, arg2);
					list2.Add(text2);
				}
				for (int j = 0; j < list2.Count; j++)
				{
					string text2 = list2[j];
					bool flag2;
					do
					{
						flag2 = false;
						string text3 = CommonChrome.RequestGet(chrome, text2, "https://mbasic.facebook.com/");
						text3 = WebUtility.HtmlDecode(text3);
						MatchCollection matchCollection = Regex.Matches(text3, "<span>(.*?)</h4>");
						for (int k = 0; k < matchCollection.Count; k++)
						{
							string text4 = matchCollection[k].Groups[1].Value;
							text4 = text4.Substring(0, text4.LastIndexOf('<'));
							MatchCollection matchCollection2 = Regex.Matches(text4, "<(.*?)>");
							for (int l = 0; l < matchCollection2.Count; l++)
							{
								text4 = text4.Replace(matchCollection2[l].Value, "");
							}
							bool flag3 = text4 != "" && !list.Contains(text4);
							if (flag3)
							{
								list.Add(text4);
							}
						}
						bool flag4 = Regex.IsMatch(text3, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"");
						if (flag4)
						{
							text2 = "https://mbasic.facebook.com" + Regex.Match(text3, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"").Value.Replace("\"", "");
							flag2 = true;
						}
					}
					while (flag2);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00022940 File Offset: 0x00020B40
		public static List<string> GetMyListUidNameFriend(Chrome chrome)
		{
			List<string> list = new List<string>();
			try
			{
				string tokenEAAAAZ = CommonChrome.GetTokenEAAAAZ(chrome);
				bool flag = !chrome.GetURL().Contains("https://graph.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://graph.facebook.com/");
				}
				string json = (string)chrome.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=id,name&access_token=" + tokenEAAAAZ + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				JObject jobject = JObject.Parse(json);
				bool flag2 = jobject["data"].Count<JToken>() > 0;
				if (flag2)
				{
					for (int i = 0; i < jobject["data"].Count<JToken>(); i++)
					{
						string str = jobject["data"][i]["id"].ToString();
						string str2 = jobject["data"][i]["name"].ToString();
						list.Add(str + "|" + str2);
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00022B6C File Offset: 0x00020D6C
		internal static void CheckStatusAccount(Chrome chrome, bool isSendRequest)
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					chrome.Status = StatusChromeAccount.ChromeClosed;
				}
				else
				{
					string text2;
					if (isSendRequest)
					{
						string text = chrome.GetURL();
						text = Regex.Match(text, "https://(.*?)facebook.com").Value + "/login";
						text2 = CommonChrome.RequestGet(chrome, text, text);
					}
					else
					{
						text2 = chrome.GetPageSource();
					}
					bool flag2 = text2 == "-2";
					if (flag2)
					{
						chrome.Status = StatusChromeAccount.ChromeClosed;
					}
					else
					{
						bool flag3 = Regex.IsMatch(text2, "login_form") || text2.Contains("/login/?next");
						if (flag3)
						{
							bool flag4 = chrome.CheckExistElement("[href*=\"/login/?next\"]", 0.0) == 1;
							if (flag4)
							{
								chrome.Click(4, "[href*=\"/login/?next\"]", 0, 0, "", 0, 1);
							}
							chrome.Status = StatusChromeAccount.LoginWithUserPass;
						}
						else
						{
							bool flag5 = Regex.IsMatch(text2, "login_profile_form") || Regex.IsMatch(text2, "/login/device-based/validate-p");
							if (flag5)
							{
								chrome.Status = StatusChromeAccount.LoginWithSelectAccount;
							}
							else
							{
								bool flag6 = Convert.ToBoolean(chrome.ExecuteScript("var kq=false;if(document.querySelector('#mErrorView')!=null && !document.querySelector('#mErrorView').getAttribute('style').includes('display:none')) kq=true;return kq+''")) || Regex.IsMatch(text2, "href=\"https://m.facebook.com/login.php");
								if (flag6)
								{
									chrome.Status = StatusChromeAccount.LoginWithSelectAccount;
								}
								else
								{
									bool flag7 = CommonChrome.CheckNoveri(chrome, "", "");
									if (flag7)
									{
										chrome.Status = StatusChromeAccount.Noveri;
									}
									else
									{
										bool flag8 = CommonChrome.CheckCheckpoint(chrome, "", "");
										if (flag8)
										{
											chrome.Status = StatusChromeAccount.Checkpoint;
										}
										else
										{
											bool flag9 = text2.Contains("error-information-popup-content") || text2.Contains("suggestionsSummaryList");
											if (flag9)
											{
												chrome.Status = StatusChromeAccount.NoInternet;
											}
											else
											{
												bool flag10 = CommonChrome.CheckLoginSuccess(chrome, "", "");
												if (flag10)
												{
													chrome.Status = StatusChromeAccount.Logined;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00022FC0 File Offset: 0x000211C0
		public static bool CheckNoveri(Chrome chrome, string currentUrl = "", string html = "")
		{
			bool flag = currentUrl == "";
			if (flag)
			{
				currentUrl = chrome.GetURL();
			}
			List<string> lstKerword = new List<string>
			{
				"facebook.com/confirmemail.php"
			};
			bool flag2 = CommonChrome.CheckStringContainKeyword(currentUrl, lstKerword);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				List<string> list = new List<string>
				{
					"[name=\"c\"]"
				};
				bool flag3 = chrome.CheckExistElements(0.0, list.ToArray()) > 0;
				result = flag3;
			}
			return result;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000230B0 File Offset: 0x000212B0
		public static bool CheckCheckpoint(Chrome chrome, string currentUrl = "", string html = "")
		{
			bool flag = currentUrl == "";
			if (flag)
			{
				currentUrl = chrome.GetURL();
			}
			List<string> lstKerword = new List<string>
			{
				"facebook.com/checkpoint/828281030927956",
				"facebook.com/checkpoint/1501092823525282",
				"facebook.com/nt/screen/?params=%7B%22token",
				"facebook.com/x/checkpoint/"
			};
			bool flag2 = CommonChrome.CheckStringContainKeyword(currentUrl, lstKerword);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				bool flag3 = html == "";
				if (flag3)
				{
					html = chrome.GetPageSource();
				}
				List<string> lstKerword2 = new List<string>
				{
					"verification_method",
					"submit[Yes]",
					"send_code",
					"/checkpoint/dyi",
					"captcha_response",
					"https://www.facebook.com/communitystandards/",
					"help/121104481304395",
					"help/166863010078512",
					"help/117450615006715",
					"checkpoint/1501092823525282",
					"checkpoint/828281030927956",
					"name=\"code_1\""
				};
				bool flag4 = CommonChrome.CheckStringContainKeyword(html, lstKerword2);
				if (flag4)
				{
					result = true;
				}
				else
				{
					List<string> list = new List<string>
					{
						"[name=\"verification_method\"]",
						"[name=\"submit[Yes]\"]",
						"[name=\"send_code\"]",
						"#captcha_response",
						"[href=\"https://www.facebook.com/communitystandards/\"]",
						"[name=\"code_1\"]",
						"[action=\"/login/checkpoint/\"] [name=\"contact_index\"]"
					};
					bool flag5 = chrome.CheckExistElements(0.0, list.ToArray()) > 0;
					result = flag5;
				}
			}
			return result;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0002344C File Offset: 0x0002164C
		public static bool CheckLoginSuccess(Chrome chrome, string currentUrl = "", string html = "")
		{
			bool flag = currentUrl == "";
			if (flag)
			{
				currentUrl = chrome.GetURL();
			}
			List<string> lstKerword = new List<string>
			{
				"https://m.facebook.com/home.php"
			};
			bool flag2 = CommonChrome.CheckStringContainKeyword(currentUrl, lstKerword);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				bool flag3 = html == "";
				if (flag3)
				{
					html = chrome.GetPageSource();
				}
				List<string> lstKerword2 = new List<string>
				{
					"/friends/",
					"/logout.php?button_location=settings&amp;button_name=logout"
				};
				bool flag4 = CommonChrome.CheckStringContainKeyword(html, lstKerword2);
				if (flag4)
				{
					result = true;
				}
				else
				{
					List<string> list = new List<string>
					{
						"a[href*=\"/friends/\"]",
						"[action=\"/logout.php?button_location=settings&button_name=logout\"]"
					};
					bool flag5 = chrome.CheckExistElements(0.0, list.ToArray()) > 0;
					result = flag5;
				}
			}
			return result;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000235F0 File Offset: 0x000217F0
		private static bool CheckStringContainKeyword(string content, List<string> lstKerword)
		{
			for (int i = 0; i < lstKerword.Count; i++)
			{
				bool flag = Regex.IsMatch(content, lstKerword[i]) || content.Contains(lstKerword[i]);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00023684 File Offset: 0x00021884
		public static List<string> BackupImageOne(Chrome chrome, string uidFr, string nameFr, string token, int countImage = 20)
		{
			List<string> list = new List<string>();
			try
			{
				bool flag = !chrome.GetURL().Contains("https://graph.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://graph.facebook.com/");
				}
				string text = (string)chrome.ExecuteScript(string.Concat(new string[]
				{
					"async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/",
					uidFr,
					"/photos?fields=images&limit=",
					countImage.ToString(),
					"&access_token=",
					token,
					"'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;"
				}));
				JObject jobject = JObject.Parse(text);
				bool flag2 = jobject != null && text.Contains("images");
				if (flag2)
				{
					for (int i = 0; i < jobject["data"].Count<JToken>(); i++)
					{
						int num = jobject["data"][i]["images"].ToList<JToken>().Count - 1;
						List<string> list2 = list;
						string[] array = new string[9];
						array[0] = uidFr;
						array[1] = "*";
						array[2] = nameFr;
						array[3] = "*";
						int num2 = 4;
						JToken jtoken = jobject["data"][i]["images"][num]["source"];
						array[num2] = ((jtoken != null) ? jtoken.ToString() : null);
						array[5] = "|";
						int num3 = 6;
						JToken jtoken2 = jobject["data"][i]["images"][num]["width"];
						array[num3] = ((jtoken2 != null) ? jtoken2.ToString() : null);
						array[7] = "|";
						int num4 = 8;
						JToken jtoken3 = jobject["data"][i]["images"][num]["height"];
						array[num4] = ((jtoken3 != null) ? jtoken3.ToString() : null);
						list2.Add(string.Concat(array));
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00023AE0 File Offset: 0x00021CE0
		public static List<string> GetMyListUidFriend(Chrome chrome)
		{
			List<string> list = new List<string>();
			try
			{
				string tokenEAAAAZ = CommonChrome.GetTokenEAAAAZ(chrome);
				bool flag = !chrome.GetURL().Contains("https://graph.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://graph.facebook.com/");
				}
				string json = (string)chrome.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=id&access_token=" + tokenEAAAAZ + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				JObject jobject = JObject.Parse(json);
				bool flag2 = jobject["data"].Count<JToken>() > 0;
				if (flag2)
				{
					for (int i = 0; i < jobject["data"].Count<JToken>(); i++)
					{
						string item = jobject["data"][i]["id"].ToString();
						list.Add(item);
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00023CA8 File Offset: 0x00021EA8
		public static List<string> GetMyListNameFriend(Chrome chrome, bool isOnlyGetVNName = false)
		{
			List<string> list = new List<string>();
			try
			{
				string tokenEAAAAZ = CommonChrome.GetTokenEAAAAZ(chrome);
				bool flag = !chrome.GetURL().Contains("https://graph.facebook.com/");
				if (flag)
				{
					chrome.GotoURL("https://graph.facebook.com/");
				}
				string json = (string)chrome.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=name&access_token=" + tokenEAAAAZ + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				JObject jobject = JObject.Parse(json);
				for (int i = 0; i < jobject["data"].Count<JToken>(); i++)
				{
					try
					{
						string text = jobject["data"][i]["name"].ToString();
						if (isOnlyGetVNName)
						{
							bool flag2 = Common.IsVNName(text);
							if (flag2)
							{
								list.Add(text);
							}
						}
						else
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

		// Token: 0x06000239 RID: 569 RVA: 0x00023EA0 File Offset: 0x000220A0
		public static bool SkipNotifyWhenAddFriend(Chrome chrome)
		{
			bool result = true;
			string text = "";
			switch (chrome.CheckExistElements(2.0, new string[]
			{
				"[data-sigil=\" m-overlay-layer\"] button",
				"[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]",
				"[data-sigil=\"touchable m-error-overlay-done\"]",
				"[data-sigil=\"touchable m-overlay-layer\"]",
				"[data-sigil=\"touchable m-error-overlay-cancel\"]"
			}))
			{
			case 0:
				result = false;
				break;
			case 1:
				text = "[data-sigil=\" m-overlay-layer\"] button";
				break;
			case 2:
				text = "[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]";
				break;
			case 3:
				text = "[data-sigil=\"touchable m-error-overlay-done\"]";
				break;
			case 4:
				text = "[data-sigil=\"touchable m-overlay-layer\"]";
				break;
			case 5:
				text = "[data-sigil=\"touchable m-error-overlay-cancel\"]";
				break;
			}
			bool flag = text != "";
			if (flag)
			{
				chrome.ExecuteScript("document.querySelector('" + text + "').click();");
			}
			return result;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0002409C File Offset: 0x0002229C
		public static string GetFbDtag(Chrome chrome)
		{
			string result;
			try
			{
				string text = chrome.GetURL();
				bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(text) != 2;
				if (flag)
				{
					chrome.GotoURL("https://m.facebook.com");
				}
				text = Regex.Match(chrome.GetURL(), "https://(.*?)facebook.com").Value;
				string input = CommonChrome.RequestGet(chrome, text + "/help/", text);
				result = Regex.Match(input, Common.Base64Decode("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000241B8 File Offset: 0x000223B8
		public static string GetHostFacebook(Chrome chrome, int typeWeb = 2)
		{
			try
			{
				string url = chrome.GetURL();
				bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(url) != typeWeb;
				if (flag)
				{
					switch (typeWeb)
					{
					case 1:
						chrome.GotoURL("https://www.facebook.com");
						break;
					case 2:
						chrome.GotoURL("https://m.facebook.com");
						break;
					case 3:
						chrome.GotoURL("https://mbasic.facebook.com");
						break;
					}
				}
				return Regex.Match(chrome.GetURL(), "https://(.*?)facebook.com").Value;
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000242FC File Offset: 0x000224FC
		public static List<string> GetListGroup(Chrome chrome)
		{
			List<string> list = new List<string>();
			try
			{
				string fbDtag = CommonChrome.GetFbDtag(chrome);
				string value = Regex.Match(chrome.GetCookieFromChrome("facebook"), "c_user=(.*?);").Groups[1].Value;
				string text = chrome.GetURL();
				bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(text) != 1;
				if (flag)
				{
					chrome.GotoURL("https://www.facebook.com");
				}
				text = Regex.Match(chrome.GetURL(), "https://(.*?)facebook.com").Value;
				string url = string.Concat(new string[]
				{
					text,
					"/ajax/typeahead/first_degree.php?fb_dtsg_ag=",
					fbDtag,
					"&filter%5B0%5D=group&viewer=",
					value,
					"&__user=",
					value,
					"&__a=1&__dyn=&__comet_req=0&jazoest=26581"
				});
				string json = CommonChrome.RequestGet(chrome, url, text).Replace("for (;;);", "");
				JObject jobject = JObject.Parse(json);
				foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["payload"]["entries"]))
				{
					try
					{
						list.Add(string.Format("{0}|{1}|{2}", jtoken["uid"], jtoken["text"], jtoken["size"]));
					}
					catch
					{
					}
				}
			}
			catch (Exception ex)
			{
			}
			return list;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0002463C File Offset: 0x0002283C
		public static List<string> GetListPage(Chrome chrome)
		{
			List<string> list = new List<string>();
			try
			{
				string tokenEAAAAZ = CommonChrome.GetTokenEAAAAZ(chrome);
				string json = CommonChrome.RequestGet(chrome, "https://graph.facebook.com/v3.0/me/accounts?access_token=" + tokenEAAAAZ + "&limit=5000&fields=id,name,like,country_page_likes", "https://graph.facebook.com").ToString();
				JObject jobject = JObject.Parse(json);
				foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
				{
					list.Add(jtoken["id"].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000247A8 File Offset: 0x000229A8
		public static List<string> GetListPage2(Chrome chrome)
		{
			List<string> list = new List<string>();
			try
			{
				string tokenEAAAAZ = CommonChrome.GetTokenEAAAAZ(chrome);
				string json = CommonChrome.RequestGet(chrome, "https://graph.facebook.com/v3.0/me/accounts?access_token=" + tokenEAAAAZ + "&limit=5000&fields=id,name,like,country_page_likes", "https://graph.facebook.com").ToString();
				JObject jobject = JObject.Parse(json);
				foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
				{
					list.Add(jtoken["name"].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00024914 File Offset: 0x00022B14
		public static string GetWebsiteFacebook(Chrome chrome, int typeWeb)
		{
			string url = "";
			switch (typeWeb)
			{
			case 1:
				url = "https://www.facebook.com";
				break;
			case 2:
				url = "https://m.facebook.com";
				break;
			case 3:
				url = "https://mbasic.facebook.com";
				break;
			}
			string url2 = chrome.GetURL();
			bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(url2) != typeWeb;
			if (flag)
			{
				chrome.GotoURL(url);
			}
			return Regex.Match(chrome.GetURL(), "https://(.*?)facebook.com").Value;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00024A20 File Offset: 0x00022C20
		public static Bitmap CropImageFromChrome(Chrome chrome, string cssSelector)
		{
			chrome.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + cssSelector + "')");
			chrome.DelayTime(1.0);
			string text = chrome.ExecuteScript("var img=document.querySelector('" + cssSelector + "').getBoundingClientRect(); return Math.floor(img.x)+'|'+Math.floor(img.y)+'|'+Math.ceil(img.width)+'|'+Math.ceil(img.height);").ToString();
			int num = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[0]) + 10;
			int num2 = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[1]) + 30;
			int width = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[2]);
			int height = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[3]);
			Bitmap image = chrome.ScreenCapture(1);
			Bitmap bitmap = new Bitmap(width, height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.DrawImage(image, -num, -num2);
			return bitmap;
		}
	}
}
