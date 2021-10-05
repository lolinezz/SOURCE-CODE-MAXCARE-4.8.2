using System;

namespace License.RNCryptor
{
	// Token: 0x0200000D RID: 13
	public struct PayloadComponents
	{
		// Token: 0x0400001F RID: 31
		public byte[] schema;

		// Token: 0x04000020 RID: 32
		public byte[] options;

		// Token: 0x04000021 RID: 33
		public byte[] salt;

		// Token: 0x04000022 RID: 34
		public byte[] hmacSalt;

		// Token: 0x04000023 RID: 35
		public byte[] iv;

		// Token: 0x04000024 RID: 36
		public int headerLength;

		// Token: 0x04000025 RID: 37
		public byte[] hmac;

		// Token: 0x04000026 RID: 38
		public byte[] ciphertext;
	}
}
