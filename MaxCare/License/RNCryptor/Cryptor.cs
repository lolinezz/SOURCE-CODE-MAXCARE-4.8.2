using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace License.RNCryptor
{
	// License.RNCryptor.Cryptor
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Security.Cryptography;
	using System.Text;

	public abstract class Cryptor
	{
		protected AesMode aesMode;

		protected Options options;

		protected bool hmac_includesHeader;

		protected bool hmac_includesPadding;

		protected HmacAlgorithm hmac_algorithm;

		protected const Algorithm algorithm = Algorithm.AES;

		protected const short saltLength = 8;

		protected const short ivLength = 16;

		protected const Pbkdf2Prf pbkdf2_prf = Pbkdf2Prf.SHA1;

		protected const int pbkdf2_iterations = 10000;

		protected const short pbkdf2_keyLength = 32;

		protected const short hmac_length = 32;

		public Encoding TextEncoding { get; set; }

		public Cryptor()
		{
			TextEncoding = Encoding.UTF8;
		}

		protected void configureSettings(Schema schemaVersion)
		{
			switch (schemaVersion)
			{
				case Schema.V0:
					aesMode = AesMode.CTR;
					options = Options.V0;
					hmac_includesHeader = false;
					hmac_includesPadding = true;
					hmac_algorithm = HmacAlgorithm.SHA1;
					break;
				case Schema.V1:
					aesMode = AesMode.CBC;
					options = Options.V1;
					hmac_includesHeader = false;
					hmac_includesPadding = false;
					hmac_algorithm = HmacAlgorithm.SHA256;
					break;
				case Schema.V2:
				case Schema.V3:
					aesMode = AesMode.CBC;
					options = Options.V1;
					hmac_includesHeader = true;
					hmac_includesPadding = false;
					hmac_algorithm = HmacAlgorithm.SHA256;
					break;
			}
		}

		protected byte[] generateHmac(PayloadComponents components, string password)
		{
			List<byte> list = new List<byte>();
			if (hmac_includesHeader)
			{
				list.AddRange(assembleHeader(components));
			}
			list.AddRange(components.ciphertext);
			byte[] key = generateKey(components.hmacSalt, password);
			HMAC hMAC = null;
			switch (hmac_algorithm)
			{
				case HmacAlgorithm.SHA1:
					hMAC = new HMACSHA1(key);
					break;
				case HmacAlgorithm.SHA256:
					hMAC = new HMACSHA256(key);
					break;
			}
			List<byte> list2 = new List<byte>();
			list2.AddRange(hMAC.ComputeHash(list.ToArray()));
			if (hmac_includesPadding)
			{
				for (int i = list2.Count; i < 32; i++)
				{
					list2.Add(0);
				}
			}
			return list2.ToArray();
		}

		protected byte[] assembleHeader(PayloadComponents components)
		{
			List<byte> list = new List<byte>();
			list.AddRange(components.schema);
			list.AddRange(components.options);
			list.AddRange(components.salt);
			list.AddRange(components.hmacSalt);
			list.AddRange(components.iv);
			return list.ToArray();
		}

		protected byte[] generateKey(byte[] salt, string password)
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 10000);
			return rfc2898DeriveBytes.GetBytes(32);
		}

		protected byte[] encryptAesCtrLittleEndianNoPadding(byte[] plaintextBytes, byte[] key, byte[] iv)
		{
			byte[] plaintext = computeAesCtrLittleEndianCounter(plaintextBytes.Length, iv);
			byte[] second = encryptAesEcbNoPadding(plaintext, key);
			return bitwiseXOR(plaintextBytes, second);
		}

		private byte[] computeAesCtrLittleEndianCounter(int payloadLength, byte[] iv)
		{
			byte[] array = new byte[iv.Length];
			iv.CopyTo(array, 0);
			int num = (int)Math.Ceiling((decimal)payloadLength / (decimal)iv.Length);
			List<byte> list = new List<byte>();
			for (int i = 0; i < num; i++)
			{
				list.AddRange(array);
				array[0]++;
			}
			return list.ToArray();
		}

		private byte[] encryptAesEcbNoPadding(byte[] plaintext, byte[] key)
		{
			//Discarded unreachable code: IL_0064, IL_0079, IL_0087, IL_009a
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.ECB;
			aes.Padding = PaddingMode.None;
			ICryptoTransform transform = aes.CreateEncryptor(key, null);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					cryptoStream.Write(plaintext, 0, plaintext.Length);
				}
				return memoryStream.ToArray();
			}
		}

		private byte[] bitwiseXOR(byte[] first, byte[] second)
		{
			byte[] array = new byte[first.Length];
			ulong num = (ulong)second.Length;
			ulong num2 = (ulong)first.Length;
			ulong num3 = 0uL;
			for (ulong num4 = 0uL; num4 < num2; num4++)
			{
				array[num4] = (byte)(first[num4] ^ second[num3]);
				num3 = ((++num3 < num) ? num3 : 0);
			}
			return array;
		}

		protected string hex_encode(byte[] input)
		{
			string text = "";
			foreach (byte b in input)
			{
				text += $"{b:x2}";
			}
			return text;
		}
	}

}