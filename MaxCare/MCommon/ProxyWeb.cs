using System;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// Token: 0x02000016 RID: 22
	internal class ProxyWeb
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public ProxyWeb(string apiKey, string proxy, int typeProxy, int limit_theads_use)
		{
			this.apiKey = apiKey;
			this.proxy = proxy;
			this.limit_theads_use = limit_theads_use;
			this.ip = "";
			this.typeProxy = typeProxy;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006B48 File Offset: 0x00004D48
		public bool ChangeProxy()
		{
			bool result = false;
			try
			{
				string url = "https://api.proxyv6.net/api/reset-ip-manual?api_key=" + this.apiKey;
				string data = string.Concat(new string[]
				{
					"{\"host\": \"",
					this.proxy.Split(new char[]
					{
						':'
					})[0],
					"\", \"port\": ",
					this.proxy.Split(new char[]
					{
						':'
					})[1],
					"}"
				});
				RequestXNet requestXNet = new RequestXNet("", "", "", 0);
				string json = requestXNet.RequestPost(url, data, "application/json");
				bool flag = JObject.Parse(json)["message"].ToString() == "SUCCESS";
				if (flag)
				{
					for (int i = 0; i < 120; i++)
					{
						bool flag2 = this.CheckLiveProxy();
						if (flag2)
						{
							Thread.Sleep(1000);
							return true;
						}
						Thread.Sleep(1000);
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006DA8 File Offset: 0x00004FA8
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

		// Token: 0x0600006C RID: 108 RVA: 0x00006E64 File Offset: 0x00005064
		public bool CheckLiveProxy()
		{
			bool result = false;
			try
			{
				string url = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + this.apiKey;
				string str = string.Concat(new string[]
				{
					this.proxy.Split(new char[]
					{
						':'
					})[2],
					":",
					this.proxy.Split(new char[]
					{
						':'
					})[3],
					"@",
					this.proxy.Split(new char[]
					{
						':'
					})[0],
					":",
					this.proxy.Split(new char[]
					{
						':'
					})[1]
				});
				string data = "{\"proxies\": [\"" + str + "\"]}";
				RequestXNet requestXNet = new RequestXNet("", "", "", 0);
				string json = requestXNet.RequestPost(url, data, "application/json");
				result = Convert.ToBoolean(JObject.Parse(json)["message"].ToString() == "SUCCESS" && JObject.Parse(json)["data"]["ip"].ToString() != "");
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0400003D RID: 61
		private object k = new object();

		// Token: 0x0400003E RID: 62
		private object k1 = new object();

		// Token: 0x0400003F RID: 63
		public int typeProxy;

		// Token: 0x04000040 RID: 64
		private string apiKey;

		// Token: 0x04000041 RID: 65
		public string proxy;

		// Token: 0x04000042 RID: 66
		public string ip = "";

		// Token: 0x04000043 RID: 67
		public int dangSuDung = 0;

		// Token: 0x04000044 RID: 68
		public int daSuDung = 0;

		// Token: 0x04000045 RID: 69
		public int limit_theads_use = 3;
	}
}
