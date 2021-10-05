using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// MCommon.TMProxy
	using System;
	using System.Net;
	using System.Net.Http;
	using System.Security.Cryptography;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading.Tasks;
	using MCommon;
	using Newtonsoft.Json.Linq;

	internal class TMProxy
	{
		private Random rd = new Random();

		private object k1 = new object();

		private object k = new object();

		public int dangSuDung = 0;

		public int daSuDung = 0;

		public int limit_theads_use = 3;

		public string api_key { get; set; }

		public string proxy { get; set; }

		public int typeProxy { get; set; }

		public string ip { get; set; }

		public int timeout { get; set; }

		public int port { get; set; }

		public int next_change { get; set; }

		public TMProxy(string api_key, int typeProxy, int limit_theads_use)
		{
			this.api_key = api_key;
			proxy = "";
			ip = "";
			port = 0;
			next_change = 0;
			this.typeProxy = typeProxy;
			this.limit_theads_use = limit_theads_use;
			dangSuDung = 0;
			daSuDung = 0;
		}

		public static bool CheckApiProxy(string apiProxy)
		{
			//Discarded unreachable code: IL_0106, IL_0113
			string data = "{\"api_key\": \"" + apiProxy + "\"}";
			string text = RequestPost("https://tmproxy.com/api/proxy/stats", data);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					string datetime = jObject["data"]["expired_at"].ToString();
					DateTime t = MCommon.Common.ConvertStringToDatetime(datetime, "HH:mm:ss dd/MM/yyyy");
					if (DateTime.Compare(t, DateTime.Now) > 0)
					{
						return true;
					}
				}
				catch
				{
				}
			}
			return false;
		}

		public string TryToGetMyIP()
		{
			//Discarded unreachable code: IL_01ec, IL_01ff
			lock (k1)
			{
				if (dangSuDung == 0)
				{
					if (daSuDung > 0 && daSuDung < limit_theads_use)
					{
						if (GetTimeOut() < 30 && !ChangeProxy())
						{
							return "0";
						}
					}
					else if (!ChangeProxy())
					{
						return "0";
					}
				}
				else
				{
					if (daSuDung >= limit_theads_use)
					{
						return "2";
					}
					if (GetTimeOut() < 30 && !ChangeProxy())
					{
						return "0";
					}
				}
				daSuDung++;
				dangSuDung++;
				return "1";
			}
		}

		public int GetTimeOut()
		{
			CheckStatusProxy();
			return timeout;
		}

		public void DecrementDangSuDung()
		{
			//Discarded unreachable code: IL_0088, IL_009b
			lock (k)
			{
				dangSuDung--;
				if (dangSuDung == 0 && daSuDung == limit_theads_use)
				{
					daSuDung = 0;
				}
			}
		}

		public string Md5Encode(string text)
		{
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(text));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		public bool ChangeProxy()
		{
			//Discarded unreachable code: IL_00b7, IL_00d3, IL_0405, IL_0412
			next_change = 0;
			proxy = "";
			ip = "";
			port = 0;
			string arg = "abccd9f3bf38f38414cb87e36f76c8e4";
			int num = 8989;
			string sVContent = GetSVContent("https://tmproxy.com/api/proxy/current-time");
			long num2 = 0L;
			try
			{
				num2 = Convert.ToInt64(sVContent);
			}
			catch
			{
				num2 = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			}
			long num3 = Convert.ToInt64(num2 / 60) + num;
			string text = $"{arg}{api_key}{num3}";
			string text2 = Md5Encode(text);
			string data = "{\"api_key\": \"" + api_key + "\",\"sign\": \"" + text2 + "\"}";
			string text3 = RequestPost("https://tmproxy.com/api/proxy/get-new-proxy", data);
			if (text3 != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text3);
					string value = Regex.Match(JObject.Parse(text3)["message"].ToString(), "\\d+").Value;
					next_change = ((!(value == "")) ? int.Parse(value) : 0);
					if (next_change == 0)
					{
						if (typeProxy == 0)
						{
							proxy = jObject["data"]["https"].ToString();
							string[] array = proxy.Split(':');
							ip = array[0];
							port = int.Parse(array[1]);
						}
						else
						{
							proxy = jObject["data"]["socks5"].ToString();
							string[] array2 = proxy.Split(':');
							ip = array2[0];
							port = int.Parse(array2[1]);
						}
						return true;
					}
				}
				catch
				{
				}
			}
			return false;
		}

		private string GetSVContent(string url)
		{
			//Discarded unreachable code: IL_0096, IL_00a3
			string text = "";
			try
			{
				text = new RequestHttp().RequestGet(url);
				if (string.IsNullOrEmpty(text))
				{
					text = "";
				}
			}
			catch
			{
			}
			return text;
		}

		public bool CheckStatusProxy()
		{
			//Discarded unreachable code: IL_033e, IL_034b
			next_change = 0;
			proxy = "";
			ip = "";
			port = 0;
			timeout = 0;
			string data = "{\"api_key\": \"" + api_key + "\"}";
			string text = RequestPost("https://tmproxy.com/api/proxy/get-current-proxy", data);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject["code"].ToString() == "0")
					{
						next_change = Convert.ToInt32(jObject["data"]["next_request"].ToString());
						timeout = Convert.ToInt32(jObject["data"]["timeout"].ToString());
						if (typeProxy == 0)
						{
							proxy = jObject["data"]["https"].ToString();
							string[] array = proxy.Split(':');
							ip = array[0];
							port = int.Parse(array[1]);
						}
						else
						{
							proxy = jObject["data"]["socks5"].ToString();
							string[] array2 = proxy.Split(':');
							ip = array2[0];
							port = int.Parse(array2[1]);
						}
						return true;
					}
				}
				catch
				{
				}
			}
			return false;
		}

		public string GetProxy()
		{
			bool flag = false;
			while (!CheckStatusProxy())
			{
			}
			return proxy;
		}

		private static string RequestPost(string url, string data)
		{
			string text = "";
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				StringContent c = new StringContent((string)(object)data, (Encoding)(object)data, "application/json");
				Task<string> task = Task.Run(() => PostURI(new Uri(url),c));
				task.Wait();
				return task.Result;
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "Request Post");
				return "";
			}
		}

		public static string RequestGet(string url)
		{
			//Discarded unreachable code: IL_006c, IL_00ae
			string text = "";
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Task<string> task = Task.Run(() => GetURI(new Uri(url)));
				task.Wait();
				return task.Result;
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "Request get");
				return "";
			}
		}

		private static async Task<string> PostURI(Uri u, HttpContent c)
		{
			string response = string.Empty;
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage result = await client.PostAsync(u, c);
				if (result.IsSuccessStatusCode)
				{
					response = await result.Content.ReadAsStringAsync();
				}
			}
			return response;
		}

		private static async Task<string> GetURI(Uri u)
		{
			string response = string.Empty;
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage result = await client.GetAsync(u);
				if (result.IsSuccessStatusCode)
				{
					response = await result.Content.ReadAsStringAsync();
				}
			}
			return response;
		}
	}

}