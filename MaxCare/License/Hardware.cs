using System;
using System.Configuration;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace License
{
	// Token: 0x02000006 RID: 6
	public class Hardware
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000040A4 File Offset: 0x000022A4
		private string maHoa(string sChuoi)
		{
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(sChuoi));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(string.Format("{0:x2}", array[i]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004134 File Offset: 0x00002334
		public string getHDD()
		{
			string result = "";
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					object obj = managementObject["SerialNumber"];
					result = this.maHoa(Hardware.EncryptHDD(((obj != null) ? obj.ToString() : null) ?? "", true)).ToUpper();
				}
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004250 File Offset: 0x00002450
		private static string EncryptHDD(string toEncrypt, bool useHashing)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
			AppSettingsReader appSettingsReader = new AppSettingsReader();
			string s = "#HiepdepTrai#";
			byte[] key;
			if (useHashing)
			{
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
				md5CryptoServiceProvider.Clear();
			}
			else
			{
				key = Encoding.UTF8.GetBytes(s);
			}
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
			byte[] array = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
			tripleDESCryptoServiceProvider.Clear();
			return Convert.ToBase64String(array, 0, array.Length);
		}
	}
}
