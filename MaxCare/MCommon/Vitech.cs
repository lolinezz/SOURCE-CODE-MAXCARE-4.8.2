using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MCommon
{
	// MCommon.Vitech
	using System;
	using System.Net;
	using System.Net.Http;
	using System.Net.Http.Headers;
	using System.Text;
	using System.Threading.Tasks;
	using MCommon;

	internal class Vitech
	{
		private object k = new object();

		private object k1 = new object();

		public int typeProxy;

		private string apiKey;

		public string proxy;

		public string ip = "";

		public int dangSuDung = 0;

		public int daSuDung = 0;

		public int limit_theads_use = 3;

		public Vitech(string apiKey, string proxy, int typeProxy, int limit_theads_use)
		{
			this.apiKey = apiKey;
			this.proxy = proxy;
			this.limit_theads_use = limit_theads_use;
			ip = "";
			this.typeProxy = typeProxy;
		}

		public bool ChangeProxy()
		{
			//Discarded unreachable code: IL_0072, IL_0085
			bool result = false;
			try
			{
				string url = "https://apiv2-public.vitechcheap.com/v1/public/rotate";
				string data = "{\"proxy\": \"" + proxy + "\"}";
				string text = RequestPost(url, apiKey, data);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		private static string RequestPost(string url, string apiKey, string data)
		{
			string text = "";
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
				StringContent c = new StringContent((string)(object)data, (Encoding)(object)data, "application/json");
				Task<string> task = Task.Run(() => PostURI(new Uri(url), c));
				task.Wait();
				return task.Result;
			}
			catch (Exception ex)
			{
				MCommon.Common.ExportError(null, ex, "Request Post");
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

		public bool CheckLiveProxy()
		{
			//Discarded unreachable code: IL_000e, IL_001b
			bool result = false;
			try
			{
			}
			catch
			{
			}
			return result;
		}
	}

}