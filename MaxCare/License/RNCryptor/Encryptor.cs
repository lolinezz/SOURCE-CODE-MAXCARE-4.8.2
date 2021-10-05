using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace License.RNCryptor
{
	// Token: 0x02000010 RID: 16
	public class Encryptor : Cryptor
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004D80 File Offset: 0x00002F80
		public string Encrypt(string plaintext, string password)
		{
			string result;
			try
			{
				result = Encryptor.Base64Encode(this.Encrypt(plaintext, password, this.defaultSchemaVersion));
			}
			catch
			{
				result = "null";
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public static string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004E20 File Offset: 0x00003020
		public string Encrypt(string plaintext, string password, Schema schemaVersion)
		{
			base.configureSettings(schemaVersion);
			byte[] bytes = base.TextEncoding.GetBytes(plaintext);
			PayloadComponents payloadComponents = new PayloadComponents
			{
				schema = new byte[]
				{
					(byte)schemaVersion
				},
				options = new byte[]
				{
					(byte)this.options
				},
				salt = this.generateRandomBytes(8),
				hmacSalt = this.generateRandomBytes(8),
				iv = this.generateRandomBytes(16)
			};
			byte[] key = base.generateKey(payloadComponents.salt, password);
			AesMode aesMode = this.aesMode;
			AesMode aesMode2 = aesMode;
			if (aesMode2 != AesMode.CTR)
			{
				if (aesMode2 == AesMode.CBC)
				{
					payloadComponents.ciphertext = this.encryptAesCbcPkcs7(bytes, key, payloadComponents.iv);
				}
			}
			else
			{
				payloadComponents.ciphertext = base.encryptAesCtrLittleEndianNoPadding(bytes, key, payloadComponents.iv);
			}
			payloadComponents.hmac = base.generateHmac(payloadComponents, password);
			List<byte> list = new List<byte>();
			list.AddRange(base.assembleHeader(payloadComponents));
			list.AddRange(payloadComponents.ciphertext);
			list.AddRange(payloadComponents.hmac);
			return Convert.ToBase64String(list.ToArray());
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004FCC File Offset: 0x000031CC
		private byte[] encryptAesCbcPkcs7(byte[] plaintext, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aes.CreateEncryptor(key, iv);
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					cryptoStream.Write(plaintext, 0, plaintext.Length);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000050A0 File Offset: 0x000032A0
		private byte[] generateRandomBytes(int length)
		{
			byte[] array = new byte[length];
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetBytes(array);
			return array;
		}

		// Token: 0x04000034 RID: 52
		private Schema defaultSchemaVersion = Schema.V2;
	}
}
