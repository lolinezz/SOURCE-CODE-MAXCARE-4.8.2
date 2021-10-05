using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace License.RNCryptor
{
	// License.RNCryptor.Decryptor
	using System.Collections.Generic;
	using System.IO;
	using System.Security.Cryptography;
	using System.Text;

	public class Decryptor : Cryptor
	{
		public string Decrypt(string encryptedBase64, string password)
		{
			//Discarded unreachable code: IL_00ec, IL_010f
			try
			{
				PayloadComponents components = unpackEncryptedBase64Data(encryptedBase64);
				if (!hmacIsValid(components, password))
				{
					return "";
				}
				byte[] key = generateKey(components.salt, password);
				byte[] result = new byte[0];
				switch (aesMode)
				{
					case AesMode.CTR:
						result = encryptAesCtrLittleEndianNoPadding(components.ciphertext, key, components.iv);
						break;
					case AesMode.CBC:
						result = decryptAesCbcPkcs7(components.ciphertext, key, components.iv);
						break;
				}
				_ = Encoding.UTF8;
				return (string)(object)result;
			}
			catch
			{
				return "null";
			}
		}

		private byte[] decryptAesCbcPkcs7(byte[] encrypted, byte[] key, byte[] iv)
		{
			//Discarded unreachable code: IL_0066, IL_007b, IL_0082, IL_0097, IL_009e, IL_00b1
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aes.CreateDecryptor(key, iv);
			string s;
			using (MemoryStream stream = new MemoryStream(encrypted))
			{
				using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
				{
					using (StreamReader streamReader = new StreamReader(stream2))
					{
						s = streamReader.ReadToEnd();
					}
				}
			}
			return base.TextEncoding.GetBytes(s);
		}

		private PayloadComponents unpackEncryptedBase64Data(string encryptedBase64)
		{
			List<byte> list = new List<byte>();
			list.AddRange((IEnumerable<byte>)(object)encryptedBase64);
			int num = 0;
			PayloadComponents result = default(PayloadComponents);
			result.schema = list.GetRange(0, 1).ToArray();
			num++;
			configureSettings((Schema)list[0]);
			result.options = list.GetRange(1, 1).ToArray();
			num++;
			result.salt = list.GetRange(num, 8).ToArray();
			num += result.salt.Length;
			result.hmacSalt = list.GetRange(num, 8).ToArray();
			num += result.hmacSalt.Length;
			result.iv = list.GetRange(num, 16).ToArray();
			num = (result.headerLength = num + result.iv.Length);
			result.ciphertext = list.GetRange(num, list.Count - 32 - result.headerLength).ToArray();
			num += result.ciphertext.Length;
			result.hmac = list.GetRange(num, 32).ToArray();
			return result;
		}

		private bool hmacIsValid(PayloadComponents components, string password)
		{
			byte[] array = generateHmac(components, password);
			if (array.Length != components.hmac.Length)
			{
				return false;
			}
			for (int i = 0; i < components.hmac.Length; i++)
			{
				if (array[i] != components.hmac[i])
				{
					return false;
				}
			}
			return true;
		}
	}

}