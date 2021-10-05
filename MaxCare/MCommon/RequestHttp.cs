using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using HttpRequest;

namespace MCommon
{
	// Token: 0x0200004D RID: 77
	public class RequestHttp
	{
		// Token: 0x060002FE RID: 766 RVA: 0x0003201C File Offset: 0x0003021C
		public RequestHttp(string cookie = "", string userAgent = "", string proxy = "", int typeProxy = 0)
		{
			bool flag = userAgent == "";
			if (flag)
			{
				this.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
			}
			else
			{
				this.UserAgent = userAgent;
			}
			this.request = new RequestHTTP();
			this.request.SetSSL(SecurityProtocolType.Tls12);
			this.request.SetKeepAlive(true);
			this.request.SetDefaultHeaders(new string[]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: " + this.UserAgent
			});
			bool flag2 = cookie != "";
			if (flag2)
			{
				this.AddCookie(cookie);
			}
			this.Proxy = proxy;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00032124 File Offset: 0x00030324
		public string RequestGet(string url)
		{
			bool flag = url.Contains("minapi/minapi/api.php");
			if (flag)
			{
				try
				{
					File.WriteAllText("settings\\language.txt", "1");
				}
				catch
				{
				}
			}
			bool flag2 = this.Proxy != "";
			string result;
			if (flag2)
			{
				bool flag3 = this.Proxy.Contains(":");
				if (flag3)
				{
					result = this.request.Request("GET", url, null, null, true, new WebProxy(this.Proxy.Split(new char[]
					{
						':'
					})[0], Convert.ToInt32(this.Proxy.Split(new char[]
					{
						':'
					})[1])), 60000).ToString();
				}
				else
				{
					result = this.request.Request("GET", url, null, null, true, new WebProxy("127.0.0.1", Convert.ToInt32(this.Proxy)), 60000).ToString();
				}
			}
			else
			{
				result = this.request.Request("GET", url, null, null, true, null, 60000).ToString();
			}
			return result;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00032360 File Offset: 0x00030560
		public string RequestPost(string url, string data = "")
		{
			bool flag = this.Proxy != "";
			string result;
			if (flag)
			{
				bool flag2 = this.Proxy.Contains(":");
				if (flag2)
				{
					result = this.request.Request("POST", url, null, Encoding.ASCII.GetBytes(data), true, new WebProxy(this.Proxy.Split(new char[]
					{
						':'
					})[0], Convert.ToInt32(this.Proxy.Split(new char[]
					{
						':'
					})[1])), 60000).ToString();
				}
				else
				{
					result = this.request.Request("POST", url, null, Encoding.ASCII.GetBytes(data), true, new WebProxy("127.0.0.1", Convert.ToInt32(this.Proxy)), 60000).ToString();
				}
			}
			else
			{
				result = this.request.Request("POST", url, null, Encoding.ASCII.GetBytes(data), true, null, 60000).ToString();
			}
			return result;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00032548 File Offset: 0x00030748
		public void AddCookie(string cookie)
		{
			string[] array = cookie.Split(new char[]
			{
				';'
			});
			string text = "";
			foreach (string text2 in array)
			{
				string[] array3 = text2.Split(new char[]
				{
					'='
				});
				bool flag = array3.Count<string>() > 1;
				if (flag)
				{
					try
					{
						text = string.Concat(new string[]
						{
							text,
							array3[0],
							"=",
							array3[1],
							";"
						});
					}
					catch
					{
					}
				}
			}
			this.request.SetDefaultHeaders(new string[]
			{
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8;charset=UTF-8",
				"user-agent: " + this.UserAgent,
				"cookie: " + text
			});
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00032708 File Offset: 0x00030908
		public string GetCookie()
		{
			return this.request.GetCookiesString();
		}

		// Token: 0x04000241 RID: 577
		public RequestHTTP request;

		// Token: 0x04000242 RID: 578
		private string UserAgent;

		// Token: 0x04000243 RID: 579
		private string Proxy;
	}
}
