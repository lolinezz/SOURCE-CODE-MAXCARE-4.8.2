using System;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// Token: 0x02000059 RID: 89
	internal class XproxyProxy
	{
		// Token: 0x06000374 RID: 884 RVA: 0x0003E868 File Offset: 0x0003CA68
		public XproxyProxy(string ServicesURL, string proxy, int typeProxy, int limit_theads_use)
		{
			this.ServicesURL = ServicesURL;
			this.proxy = proxy;
			this.limit_theads_use = limit_theads_use;
			this.ip = "";
			this.typeProxy = typeProxy;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0003E904 File Offset: 0x0003CB04
		private void ExportToFile(string content)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0003E918 File Offset: 0x0003CB18
		public bool ChangeProxy()
		{
			int num = new JSON_Settings("configGeneral", false).GetValueInt("nudDelayResetXProxy", 5) * 60;
			bool result = false;
			try
			{
				int tickCount = Environment.TickCount;
				this.ServicesURL = this.ServicesURL.TrimEnd(new char[]
				{
					'/'
				});
				string text = this.ServicesURL + "/reset?proxy=" + this.proxy;
				RequestXNet requestXNet = new RequestXNet("", "", "", 0);
				string text2 = requestXNet.RequestGet(text);
				this.ExportToFile(text + ": " + text2);
				JObject jobject = JObject.Parse(text2);
				bool flag = false;
				bool flag2 = jobject.ContainsKey("msg") && (JObject.Parse(text2)["msg"].ToString() == "command_sent" || JObject.Parse(text2)["msg"].ToString() == "OK" || JObject.Parse(text2)["msg"].ToString().ToLower() == "ok");
				if (flag2)
				{
					flag = true;
				}
				else
				{
					bool flag3 = jobject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"].ToString().ToLower() == "0";
					if (flag3)
					{
						flag = true;
					}
				}
				bool flag4 = flag;
				if (flag4)
				{
					for (;;)
					{
						bool flag5 = this.CheckLiveProxy();
						if (flag5)
						{
							break;
						}
						Thread.Sleep(1000);
						if (Environment.TickCount - tickCount >= num * 1000)
						{
							goto IL_33B;
						}
					}
					Thread.Sleep(1000);
					return true;
				}
				IL_33B:;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0003ECA4 File Offset: 0x0003CEA4
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

		// Token: 0x06000378 RID: 888 RVA: 0x0003ED60 File Offset: 0x0003CF60
		public bool CheckLiveProxy()
		{
			bool result = false;
			try
			{
				this.ServicesURL = this.ServicesURL.TrimEnd(new char[]
				{
					'/'
				});
				string text = this.ServicesURL + "/status?proxy=" + this.proxy;
				RequestXNet requestXNet = new RequestXNet("", "", "", 0);
				string text2 = requestXNet.RequestGet(text);
				this.ExportToFile(text + ": " + text2);
				try
				{
					bool flag = !text2.Contains("public_ip_v6") && !text2.Contains("public_ip");
					if (flag)
					{
						result = Convert.ToBoolean(JObject.Parse(text2)["status"].ToString());
					}
					else
					{
						string text3 = this.proxy.Split(new char[]
						{
							':'
						})[1];
						bool flag2 = text3.StartsWith("4") || text3.StartsWith("5");
						if (flag2)
						{
							result = (JObject.Parse(text2)["public_ip"].ToString() != "" && JObject.Parse(text2)["public_ip"].ToString() != "CONNECT_INTERNET_ERROR");
						}
						else
						{
							bool flag3 = text3.StartsWith("6") || text3.StartsWith("7");
							if (flag3)
							{
								result = (JObject.Parse(text2)["public_ip_v6"].ToString() != "" && JObject.Parse(text2)["public_ip_v6"].ToString() != "CONNECT_INTERNET_ERROR");
							}
						}
					}
				}
				catch
				{
					result = (JObject.Parse(text2)["error_code"].ToString() == "0");
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x04000288 RID: 648
		private object k = new object();

		// Token: 0x04000289 RID: 649
		private object k1 = new object();

		// Token: 0x0400028A RID: 650
		public int typeProxy;

		// Token: 0x0400028B RID: 651
		private string ServicesURL;

		// Token: 0x0400028C RID: 652
		public string proxy;

		// Token: 0x0400028D RID: 653
		public string ip = "";

		// Token: 0x0400028E RID: 654
		public bool isProxyLive = true;

		// Token: 0x0400028F RID: 655
		public int dangSuDung = 0;

		// Token: 0x04000290 RID: 656
		public int daSuDung = 0;

		// Token: 0x04000291 RID: 657
		public int limit_theads_use = 3;
	}
}
