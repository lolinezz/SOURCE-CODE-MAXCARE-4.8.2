using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// Token: 0x02000051 RID: 81
	internal class Tinsoft
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000273A File Offset: 0x0000093A
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00002742 File Offset: 0x00000942
		public string api_key { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000274B File Offset: 0x0000094B
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00002753 File Offset: 0x00000953
		public string proxy { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000275C File Offset: 0x0000095C
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00002764 File Offset: 0x00000964
		public string ip { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000276D File Offset: 0x0000096D
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00002775 File Offset: 0x00000975
		public int port { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000277E File Offset: 0x0000097E
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00002786 File Offset: 0x00000986
		public int timeout { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000278F File Offset: 0x0000098F
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00002797 File Offset: 0x00000997
		public int next_change { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000027A0 File Offset: 0x000009A0
		// (set) Token: 0x06000326 RID: 806 RVA: 0x000027A8 File Offset: 0x000009A8
		public int location { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000027B1 File Offset: 0x000009B1
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000027B9 File Offset: 0x000009B9
		public int countConnected { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000027C2 File Offset: 0x000009C2
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000027CA File Offset: 0x000009CA
		public int connecting { get; set; }

		// Token: 0x0600032B RID: 811 RVA: 0x0003B838 File Offset: 0x00039A38
		public Tinsoft(string api_key, int location = 0)
		{
			this.api_key = api_key;
			this.proxy = "";
			this.ip = "";
			this.port = 0;
			this.timeout = 0;
			this.next_change = 0;
			this.location = location;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0003B8EC File Offset: 0x00039AEC
		public bool changeProxy()
		{
			bool flag = this.checkLastRequest();
			if (flag)
			{
				this.errorCode = "";
				this.next_change = 0;
				this.proxy = "";
				this.ip = "";
				this.port = 0;
				this.timeout = 0;
				string svcontent = this.getSVContent(string.Concat(new string[]
				{
					this.svUrl,
					"/api/changeProxy.php?key=",
					this.api_key,
					"&location=",
					this.location.ToString()
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
			return false;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0003BC64 File Offset: 0x00039E64
		public void stopProxy()
		{
			this.errorCode = "";
			this.proxy = "";
			this.ip = "";
			this.port = 0;
			this.timeout = 0;
			bool flag = this.api_key != "";
			if (flag)
			{
				this.getSVContent(this.svUrl + "/api/stopProxy.php?key=" + this.api_key);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0003BD60 File Offset: 0x00039F60
		public bool getProxyStatus()
		{
			bool flag = this.checkLastRequest();
			if (flag)
			{
				this.errorCode = "";
				this.proxy = "";
				this.ip = "";
				this.port = 0;
				this.timeout = 0;
				string svcontent = this.getSVContent(this.svUrl + "/api/getProxy.php?key=" + this.api_key);
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
					}
					catch
					{
					}
				}
			}
			else
			{
				this.errorCode = "Request so fast!";
			}
			return false;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0003C044 File Offset: 0x0003A244
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

		// Token: 0x06000330 RID: 816 RVA: 0x0003C108 File Offset: 0x0003A308
		private string getSVContent(string url)
		{
			Console.WriteLine(url);
			string text = "";
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
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

		// Token: 0x06000331 RID: 817 RVA: 0x0003C214 File Offset: 0x0003A414
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

		// Token: 0x0400024C RID: 588
		public string errorCode = "";

		// Token: 0x0400024E RID: 590
		private string svUrl = "http://proxy.tinsoftsv.com";

		// Token: 0x0400024F RID: 591
		private int lastRequest = 0;
	}
}
