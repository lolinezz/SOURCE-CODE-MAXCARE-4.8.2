using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// Token: 0x02000052 RID: 82
	internal class TinsoftProxy
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000027D3 File Offset: 0x000009D3
		// (set) Token: 0x06000333 RID: 819 RVA: 0x000027DB File Offset: 0x000009DB
		public string api_key { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000027E4 File Offset: 0x000009E4
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000027EC File Offset: 0x000009EC
		public string proxy { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000336 RID: 822 RVA: 0x000027F5 File Offset: 0x000009F5
		// (set) Token: 0x06000337 RID: 823 RVA: 0x000027FD File Offset: 0x000009FD
		public string ip { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00002806 File Offset: 0x00000A06
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000280E File Offset: 0x00000A0E
		public int port { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00002817 File Offset: 0x00000A17
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000281F File Offset: 0x00000A1F
		public int timeout { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00002828 File Offset: 0x00000A28
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00002830 File Offset: 0x00000A30
		public int next_change { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00002839 File Offset: 0x00000A39
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00002841 File Offset: 0x00000A41
		public int location { get; set; }

		// Token: 0x06000340 RID: 832 RVA: 0x0003C3A8 File Offset: 0x0003A5A8
		public TinsoftProxy(string api_key, int limit_theads_use, int location = 0)
		{
			this.api_key = api_key;
			this.proxy = "";
			this.ip = "";
			this.port = 0;
			this.timeout = 0;
			this.next_change = 0;
			this.location = location;
			this.limit_theads_use = limit_theads_use;
			this.dangSuDung = 0;
			this.daSuDung = 0;
			this.canChangeIP = true;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0003C4A8 File Offset: 0x0003A6A8
		public string TryToGetMyIP()
		{
			object obj = this.k1;
			string result;
			lock (obj)
			{
				bool flag2 = this.dangSuDung == 0;
				if (flag2)
				{
					bool flag3 = this.daSuDung > 0 && this.daSuDung < this.limit_theads_use;
					if (flag3)
					{
						bool flag4 = this.GetTimeOut() < 30;
						if (flag4)
						{
							bool flag5 = this.ChangeProxy();
							if (!flag5)
							{
								return "0";
							}
						}
					}
					else
					{
						bool flag6 = this.ChangeProxy();
						if (!flag6)
						{
							return "0";
						}
					}
				}
				else
				{
					bool flag7 = this.daSuDung < this.limit_theads_use;
					if (!flag7)
					{
						return "2";
					}
					bool flag8 = this.GetTimeOut() < 30;
					if (flag8)
					{
						bool flag9 = this.ChangeProxy();
						if (!flag9)
						{
							return "0";
						}
					}
				}
				this.daSuDung++;
				this.dangSuDung++;
				result = "1";
			}
			return result;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0003C6D4 File Offset: 0x0003A8D4
		public void DecrementDangSuDung()
		{
			object obj = this.k;
			lock (obj)
			{
				this.dangSuDung--;
				bool flag2 = this.dangSuDung == 0 && this.daSuDung == this.limit_theads_use;
				if (flag2)
				{
					this.daSuDung = 0;
				}
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0003C790 File Offset: 0x0003A990
		public bool ChangeProxy()
		{
			object obj = this.k;
			bool result;
			lock (obj)
			{
				bool flag2 = this.checkLastRequest();
				if (flag2)
				{
					this.errorCode = "";
					this.next_change = 0;
					this.proxy = "";
					this.ip = "";
					this.port = 0;
					this.timeout = 0;
					string svcontent = this.getSVContent(string.Concat(new object[]
					{
						this.svUrl,
						"/api/changeProxy.php?key=",
						this.api_key,
						"&location=",
						this.location
					}));
					bool flag3 = svcontent != "";
					if (flag3)
					{
						try
						{
							JObject jobject = JObject.Parse(svcontent);
							bool flag4 = bool.Parse(jobject["success"].ToString());
							if (flag4)
							{
								this.proxy = jobject["proxy"].ToString();
								string[] array = this.proxy.Split(new char[]
								{
									':'
								});
								this.ip = array[0];
								this.port = int.Parse(array[1]);
								this.timeout = int.Parse(jobject["timeout"].ToString());
								this.next_change = int.Parse(jobject["next_change"].ToString());
								this.errorCode = "";
								return true;
							}
							this.errorCode = jobject["description"].ToString();
							this.next_change = int.Parse(jobject["next_change"].ToString());
						}
						catch
						{
						}
					}
					else
					{
						this.errorCode = "request server timeout!";
					}
				}
				else
				{
					this.errorCode = "Request so fast!";
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0003CB7C File Offset: 0x0003AD7C
		public string GetProxy()
		{
			bool flag;
			do
			{
				flag = this.CheckStatusProxy();
			}
			while (!flag);
			return this.proxy;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0003CBC0 File Offset: 0x0003ADC0
		public int GetTimeOut()
		{
			bool flag;
			do
			{
				flag = this.CheckStatusProxy();
			}
			while (!flag);
			return this.timeout;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0003CC04 File Offset: 0x0003AE04
		public int GetNextChange()
		{
			bool flag;
			do
			{
				flag = this.CheckStatusProxy();
			}
			while (!flag);
			return this.next_change;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0003CC48 File Offset: 0x0003AE48
		public bool CheckStatusProxy()
		{
			object obj = this.k;
			bool result;
			lock (obj)
			{
				this.errorCode = "";
				this.next_change = 0;
				this.proxy = "";
				this.ip = "";
				this.port = 0;
				this.timeout = 0;
				string svcontent = this.getSVContent(string.Concat(new object[]
				{
					this.svUrl,
					"/api/getProxy.php?key=",
					this.api_key
				}));
				bool flag2 = svcontent != "";
				if (flag2)
				{
					try
					{
						JObject jobject = JObject.Parse(svcontent);
						bool flag3 = bool.Parse(jobject["success"].ToString());
						if (flag3)
						{
							this.proxy = jobject["proxy"].ToString();
							string[] array = this.proxy.Split(new char[]
							{
								':'
							});
							this.ip = array[0];
							this.port = int.Parse(array[1]);
							this.timeout = int.Parse(jobject["timeout"].ToString());
							this.next_change = int.Parse(jobject["next_change"].ToString());
							this.errorCode = "";
							return true;
						}
						this.errorCode = jobject["description"].ToString();
						bool flag4 = jobject["next_change"] != null;
						if (flag4)
						{
							this.next_change = int.Parse(jobject["next_change"].ToString());
						}
					}
					catch (Exception ex)
					{
					}
				}
				else
				{
					this.errorCode = "request server timeout!";
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0003CFF0 File Offset: 0x0003B1F0
		private bool checkLastRequest()
		{
			try
			{
				DateTime dateTime = new DateTime(2001, 1, 1);
				long ticks = DateTime.Now.Ticks - dateTime.Ticks;
				TimeSpan timeSpan = new TimeSpan(ticks);
				int num = (int)timeSpan.TotalSeconds;
				bool flag = num - this.lastRequest >= 10;
				if (flag)
				{
					this.lastRequest = num;
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0003D0B0 File Offset: 0x0003B2B0
		private string getSVContent(string url)
		{
			Console.WriteLine(url);
			string text = "";
			try
			{
				using (WebClient webClient = new WebClient())
				{
					text = webClient.DownloadString(url);
				}
				bool flag = string.IsNullOrEmpty(text);
				if (flag)
				{
					text = "";
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0003D188 File Offset: 0x0003B388
		private static string GetSVContent(string url)
		{
			Console.WriteLine(url);
			string text = "";
			try
			{
				using (WebClient webClient = new WebClient())
				{
					text = webClient.DownloadString(url);
				}
				bool flag = string.IsNullOrEmpty(text);
				if (flag)
				{
					text = "";
				}
			}
			catch
			{
				text = "";
			}
			return text;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0003D260 File Offset: 0x0003B460
		public static bool CheckApiProxy(string apiProxy)
		{
			string svcontent = TinsoftProxy.GetSVContent("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + apiProxy);
			bool flag = svcontent != "";
			if (flag)
			{
				JObject jobject = JObject.Parse(svcontent);
				bool flag2 = bool.Parse(jobject["success"].ToString());
				if (flag2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0003C214 File Offset: 0x0003A414
		public static List<string> GetListKey(string api_user)
		{
			List<string> list = new List<string>();
			try
			{
				RequestXNet requestXNet = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
				string json = requestXNet.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + api_user);
				JObject jobject = JObject.Parse(json);
				foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
				{
					bool flag = Convert.ToBoolean(jtoken["success"].ToString());
					if (flag)
					{
						list.Add(jtoken["key"].ToString());
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x04000259 RID: 601
		private object k1 = new object();

		// Token: 0x0400025A RID: 602
		private object k = new object();

		// Token: 0x0400025B RID: 603
		public string errorCode = "";

		// Token: 0x0400025C RID: 604
		private string svUrl = "http://proxy.tinsoftsv.com";

		// Token: 0x0400025D RID: 605
		private int lastRequest = 0;

		// Token: 0x0400025E RID: 606
		public bool canChangeIP = true;

		// Token: 0x0400025F RID: 607
		public int dangSuDung = 0;

		// Token: 0x04000260 RID: 608
		public int daSuDung = 0;

		// Token: 0x04000261 RID: 609
		public int limit_theads_use = 3;
	}
}
