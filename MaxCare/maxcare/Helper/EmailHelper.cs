using System;
using System.Linq;
using System.Text.RegularExpressions;
using AE.Net.Mail;
using MCommon;

namespace maxcare.Helper
{
	// Token: 0x02000197 RID: 407
	internal class EmailHelper
	{
		// Token: 0x060011A7 RID: 4519 RVA: 0x002C7D34 File Offset: 0x002C5F34
		public static void DeleteMail(string username, string password, string imap = "")
		{
			int num = 0;
			for (;;)
			{
				try
				{
					bool flag = imap == "";
					if (flag)
					{
						imap = "outlook.office365.com";
						bool flag2 = username.Contains("@hotmail.") || username.Contains("@outlook.") || username.Contains("@rickystar.") || username.Contains("@nickpromail.");
						if (flag2)
						{
							imap = "outlook.office365.com";
						}
						else
						{
							bool flag3 = username.EndsWith("@yandex.com");
							if (flag3)
							{
								imap = "imap.yandex.com";
							}
							else
							{
								bool flag4 = username.EndsWith("@gmail.com");
								if (flag4)
								{
									imap = "imap.gmail.com";
								}
							}
						}
					}
					ImapClient imapClient = new ImapClient(imap, username, password, AuthMethods.Login, 993, true, false);
					bool flag5 = imap == "imap.yandex.com";
					Lazy<MailMessage>[] array;
					if (flag5)
					{
						array = imapClient.SearchMessages(SearchCondition.Unseen(), false, false);
					}
					else
					{
						array = imapClient.SearchMessages(SearchCondition.From("security@facebookmail.com").And(new SearchCondition[]
						{
							SearchCondition.Unseen()
						}), false, false);
					}
					bool flag6 = array.Length != 0;
					if (flag6)
					{
						for (int i = array.Length - 1; i >= 0; i--)
						{
							Lazy<MailMessage> lazy = array[i];
							imapClient.DeleteMessage(lazy.Value);
						}
					}
					bool isDisposed = imapClient.IsDisposed;
					if (isDisposed)
					{
						imapClient.Dispose();
					}
					bool isConnected = imapClient.IsConnected;
					if (isConnected)
					{
						imapClient.Disconnect();
					}
				}
				catch (Exception ex)
				{
					bool flag7 = ex.ToString().Contains("The remote certificate is invalid according to the validation procedure");
					if (flag7)
					{
						num++;
						bool flag8 = num < 10;
						if (flag8)
						{
							continue;
						}
					}
				}
				break;
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x002C80A0 File Offset: 0x002C62A0
		public static string GetOtpFromMail(int type, string username, string password, int timeout = 10, string imap = "")
		{
			int num = 0;
			int num2 = 10;
			bool flag = imap == "";
			if (flag)
			{
				imap = "outlook.office365.com";
				bool flag2 = username.Contains("@hotmail.") || username.Contains("@outlook.") || username.Contains("@rickystar.") || username.Contains("@nickpromail.");
				if (flag2)
				{
					imap = "outlook.office365.com";
				}
				else
				{
					bool flag3 = username.EndsWith("@yandex.com");
					if (flag3)
					{
						imap = "imap.yandex.com";
					}
					else
					{
						bool flag4 = username.EndsWith("@gmail.com");
						if (flag4)
						{
							imap = "imap.gmail.com";
						}
					}
				}
			}
			for (;;)
			{
				try
				{
					ImapClient imapClient = new ImapClient(imap, username, password, AuthMethods.Login, 993, true, false);
					for (int i = 0; i < timeout; i++)
					{
						try
						{
							for (int j = 0; j < 2; j++)
							{
								bool flag5 = imap == "imap.yandex.com";
								if (flag5)
								{
									j = 1;
								}
								bool flag6 = j == 0;
								if (flag6)
								{
									imapClient.SelectMailbox("Inbox");
								}
								else
								{
									imapClient.SelectMailbox("Spam");
								}
								int messageCount = imapClient.GetMessageCount();
								bool flag7 = messageCount > 0;
								if (flag7)
								{
									bool flag8 = imap == "imap.yandex.com";
									Lazy<MailMessage>[] array;
									if (flag8)
									{
										array = imapClient.SearchMessages(SearchCondition.Unseen(), false, false);
									}
									else
									{
										array = imapClient.SearchMessages(SearchCondition.From("security@facebookmail.com").Or(new SearchCondition[]
										{
											SearchCondition.From("registration@facebookmail.com")
										}).And(new SearchCondition[]
										{
											SearchCondition.Unseen()
										}), false, false);
									}
									bool flag9 = array.Length != 0;
									if (flag9)
									{
										for (int k = array.Count<Lazy<MailMessage>>() - 1; k >= 0; k--)
										{
											string input = array[k].Value.Body.ToString();
											string text = "";
											switch (type)
											{
											case 0:
												text = Regex.Match(input, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim();
												break;
											case 1:
												text = Regex.Match(input, "\\d{8}").Value.Trim();
												break;
											case 2:
											{
												text = Regex.Match(input, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\n").Value.Trim();
												bool flag10 = text == "";
												if (flag10)
												{
													text = Regex.Match(input, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim();
												}
												break;
											}
											case 3:
												text = Regex.Match(input, "confirmcontact.php\\?c=(.*?)&").Groups[1].Value;
												break;
											}
											bool flag11 = text != "";
											if (flag11)
											{
												bool isDisposed = imapClient.IsDisposed;
												if (isDisposed)
												{
													imapClient.Dispose();
												}
												bool isConnected = imapClient.IsConnected;
												if (isConnected)
												{
													imapClient.Disconnect();
												}
												return text;
											}
										}
									}
								}
							}
						}
						catch
						{
						}
						MCommon.Common.DelayTime(1.0);
					}
					bool isDisposed2 = imapClient.IsDisposed;
					if (isDisposed2)
					{
						imapClient.Dispose();
					}
					bool isConnected2 = imapClient.IsConnected;
					if (isConnected2)
					{
						imapClient.Disconnect();
					}
				}
				catch (Exception ex)
				{
					bool flag12 = ex.ToString().ToLower().Contains("blocked");
					if (flag12)
					{
						return "block";
					}
					num++;
					bool flag13 = num < num2;
					if (flag13)
					{
						continue;
					}
				}
				break;
			}
			return "";
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x002C8768 File Offset: 0x002C6968
		public static string GetOtpFromMail2(int type, string username, string password, string subUser, int timeout = 10, string imap = "")
		{
			int num = 0;
			int num2 = 10;
			bool flag = imap == "";
			if (flag)
			{
				imap = "outlook.office365.com";
				bool flag2 = username.Contains("@hotmail.") || username.Contains("@outlook.") || username.Contains("@rickystar.") || username.Contains("@nickpromail.");
				if (flag2)
				{
					imap = "outlook.office365.com";
				}
				else
				{
					bool flag3 = username.EndsWith("@yandex.com");
					if (flag3)
					{
						imap = "imap.yandex.com";
					}
					else
					{
						bool flag4 = username.EndsWith("@gmail.com");
						if (flag4)
						{
							imap = "imap.gmail.com";
						}
					}
				}
			}
			for (;;)
			{
				try
				{
					ImapClient imapClient = new ImapClient(imap, username, password, AuthMethods.Login, 993, true, false);
					for (int i = 0; i < timeout; i++)
					{
						try
						{
							for (int j = 0; j < 3; j++)
							{
								bool flag5 = j <= 1;
								if (flag5)
								{
									imapClient.SelectMailbox("Inbox");
								}
								else
								{
									imapClient.SelectMailbox("Spam");
								}
								int messageCount = imapClient.GetMessageCount();
								bool flag6 = messageCount > 0;
								if (flag6)
								{
									Lazy<MailMessage>[] array = null;
									bool flag7 = imap == "imap.yandex.com";
									if (flag7)
									{
										array = imapClient.SearchMessages(SearchCondition.To(subUser), false, false);
									}
									bool flag8 = array.Length != 0;
									if (flag8)
									{
										for (int k = array.Count<Lazy<MailMessage>>() - 1; k >= array.Count<Lazy<MailMessage>>() - 20; k--)
										{
											try
											{
												string text = array[k].Value.Body.ToString();
												bool flag9 = text.Contains(subUser);
												if (flag9)
												{
													string text2 = "";
													if (type != 0)
													{
														if (type == 1)
														{
															text2 = Regex.Match(text, "\\d{8}").Value.Trim();
														}
													}
													else
													{
														text2 = Regex.Match(text, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim();
													}
													bool flag10 = text2 != "";
													if (flag10)
													{
														bool isDisposed = imapClient.IsDisposed;
														if (isDisposed)
														{
															imapClient.Dispose();
														}
														bool isConnected = imapClient.IsConnected;
														if (isConnected)
														{
															imapClient.Disconnect();
														}
														return text2;
													}
												}
											}
											catch
											{
												break;
											}
										}
									}
								}
							}
						}
						catch (Exception ex)
						{
						}
						MCommon.Common.DelayTime(1.0);
					}
					bool isDisposed2 = imapClient.IsDisposed;
					if (isDisposed2)
					{
						imapClient.Dispose();
					}
					bool isConnected2 = imapClient.IsConnected;
					if (isConnected2)
					{
						imapClient.Disconnect();
					}
				}
				catch (Exception ex2)
				{
					bool flag11 = ex2.ToString().ToLower().Contains("blocked");
					if (flag11)
					{
						return "block";
					}
					num++;
					bool flag12 = num < num2;
					if (flag12)
					{
						continue;
					}
				}
				break;
			}
			return "";
		}
	}
}
