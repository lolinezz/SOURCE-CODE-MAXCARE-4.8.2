using System;
using System.Net;
using System.Text;
using License.RNCryptor;

namespace License
{
	// License.License
	using System;
	using System.Net;
	using System.Text;

	public class License
	{
		private string Usr = "";

		private string Pwd = "";

		private string Hardware = "";

		private string SoftIndex = "";

		private string RandomKey = "";

		private string ServerURL = "http://minmaxsoft.com/chapall/api.php/";

		public License(string usr, string pwd, string hardware, string softIndex, string randomKey)
		{
			Usr = usr;
			Pwd = pwd;
			Hardware = hardware;
			SoftIndex = softIndex;
			RandomKey = randomKey;
		}

		public string CheckLic()
		{
			//Discarded unreachable code: IL_01b6, IL_01c5
			string result = "";
			try
			{
				string text = "MINSOFTWARE_KEY_PRO" + RandomKey;
				Encryptor encryptor = new Encryptor();
				Decryptor decryptor = new Decryptor();
				string plaintext = SoftIndex + "|" + Hardware + "|" + Usr + "|" + Pwd + "|" + text;
				string text2 = encryptor.Encrypt(plaintext, "KEY_8f558b28346e6cf3c_HASH_989ae0d760020f2");
				string text3 = ReadHTMLCode(ServerURL + "CheckAllToken/?api=" + text2).Replace("\"", "");
				if (text3 != null)
				{
					result = text3;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public string CheckAcc()
		{
			//Discarded unreachable code: IL_0117, IL_0126
			string result = "";
			try
			{
				string text = "MINSOFTWARE_KEY_PRO" + RandomKey;
				Encryptor encryptor = new Encryptor();
				Decryptor decryptor = new Decryptor();
				string plaintext = Usr + "|" + Pwd;
				string text2 = encryptor.Encrypt(plaintext, "KEY_8f558b28346e6cf3c_HASH_989ae0d760020f2");
				string text3 = ReadHTMLCode(ServerURL + "CheckLoginMin/?api=" + text2).Replace("\"", "");
				if (text3 != null)
				{
					result = text3;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		private string ReadHTMLCode(string URL)
		{
			//Discarded unreachable code: IL_0024, IL_0032
			try
			{
				WebClient webClient = new WebClient();
				byte[] result = webClient.DownloadData(URL);
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				return (string)(object)result;
			}
			catch
			{
				return null;
			}
		}
	}

}