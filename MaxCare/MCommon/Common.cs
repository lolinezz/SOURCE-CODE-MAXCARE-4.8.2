
namespace MCommon
{
	// MCommon.Common
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Diagnostics;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Net.Mail;
	using System.Reflection;
	using System.Runtime.InteropServices;
	using System.Security.Cryptography;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Windows.Forms;
	using AE.Net.Mail;
	using IWshRuntimeLibrary;
	using maxcare;
	using MCommon;
	using Newtonsoft.Json.Linq;
	using OtpNet;

	public class Common
	{
		private static Random rd = new Random();

		private static int getWidthScreen = Screen.PrimaryScreen.WorkingArea.Width;

		private static int getHeightScreen = Screen.PrimaryScreen.WorkingArea.Height;

		private static object k = new object();

		public static double ConvertDatetimeToTimestamp(DateTime value)
		{
			return (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
		}

		public static string ConvertListParamsToString(object lstParams)
		{
			//Discarded unreachable code: IL_00a7, IL_00b4
			string text = "";
			try
			{
				PropertyInfo[] properties = lstParams.GetType().GetProperties();
				foreach (PropertyInfo propertyInfo in properties)
				{
					text = text + propertyInfo.GetValue(lstParams)?.ToString() + ",";
				}
				text = text.TrimEnd(',');
			}
			catch
			{
			}
			return text;
		}

		public static string GetFbDtag(string cookie, string useragent, string proxy, int typeProxy)
		{
			//Discarded unreachable code: IL_0074, IL_0096
			try
			{
				string input = new RequestXNet(cookie, useragent, proxy, typeProxy).RequestGet("https://m.facebook.com/help/");
				return Regex.Match(input, Base64Decode("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
			}
			catch
			{
				return "";
			}
		}

		public static List<string> GetIntersectItemBetweenTwoList(List<string> lstRoot, List<string> lstCompare)
		{
			//Discarded unreachable code: IL_0025, IL_0032
			List<string> result = new List<string>();
			try
			{
				result = lstRoot.Intersect(lstCompare).ToList();
			}
			catch
			{
			}
			return result;
		}

		public static List<string> GetExceptItemBetweenTwoList(List<string> lstRoot, List<string> lstCompare)
		{
			//Discarded unreachable code: IL_0025, IL_0032
			List<string> result = new List<string>();
			try
			{
				result = lstRoot.Except(lstCompare).ToList();
			}
			catch
			{
			}
			return result;
		}

		private static void Enable(string interfaceName)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
		}

		private static void Disable(string interfaceName)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
		}

		public static string GetDateCreatFolder(string pathFolder)
		{
			//Discarded unreachable code: IL_0030, IL_003d
			try
			{
				return Directory.GetCreationTime(pathFolder).ToString("yyyy/MM/dd HH:mm:ss");
			}
			catch (Exception)
			{
			}
			return "";
		}

		public static string GetDateCreatFile(string pathFile)
		{
			//Discarded unreachable code: IL_0030, IL_003d
			try
			{
				return File.GetCreationTime(pathFile).ToString("yyyy/MM/dd HH:mm:ss");
			}
			catch (Exception)
			{
			}
			return "";
		}

		public static string GetRandomItemFromList(ref List<string> lst, Random rd)
		{
			string text = "";
			try
			{
				text = lst[rd.Next(0, lst.Count)];
				lst.Remove(text);
			}
			catch (Exception)
			{
				throw;
			}
			return text;
		}

		public static string CheckAccountHotmail(string username, string password, string imap = "")
		{
			//Discarded unreachable code: IL_0213, IL_0281
			int num = 0;
			while (true)
			{
				try
				{
					if (imap == "")
					{
						if (username.Contains("@hotmail.") || username.Contains("@outlook.") || username.Contains("@rickystar.") || username.Contains("@nickpromail."))
						{
							imap = "outlook.office365.com";
						}
						else if (username.EndsWith("@yandex.com"))
						{
							imap = "imap.yandex.com";
						}
						else if (username.EndsWith("@gmail.com"))
						{
							imap = "imap.gmail.com";
						}
					}
					if (imap == "")
					{
						return "0";
					}
					ImapClient imapClient = new ImapClient(imap, username, password, AuthMethods.Login, 993, secure: true);
					imapClient.Dispose();
					return "1";
				}
				catch (Exception ex)
				{
					if (!ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
					{
						goto IL_0265;
					}
					num++;
					if (num >= 10)
					{
						goto IL_0265;
					}
					goto end_IL_0218;
				IL_0265:
					return "0";
				end_IL_0218:;
				}
			}
		}

		public static string CheckAccountEmail(string username, string password, string imap)
		{
			//Discarded unreachable code: IL_0057, IL_00c2
			int num = 0;
			while (true)
			{
				try
				{
					ImapClient imapClient = new ImapClient(imap, username, password, AuthMethods.Login, 993, secure: true);
					imapClient.Dispose();
					return "1";
				}
				catch (Exception ex)
				{
					if (!ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
					{
						goto IL_00a7;
					}
					num++;
					if (num >= 10)
					{
						goto IL_00a7;
					}
					goto end_IL_005c;
				IL_00a7:
					return "0";
				end_IL_005c:;
				}
			}
		}

		public static string ConvertSecondsToTime(int seconds)
		{
			//Discarded unreachable code: IL_00c6, IL_00e8
			try
			{
				TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
				if (seconds < 60)
				{
					return TimeSpan.FromSeconds(seconds).ToString("ss");
				}
				if (seconds < 3600)
				{
					return TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");
				}
				return TimeSpan.FromSeconds(seconds).ToString("hh\\:mm\\:ss");
			}
			catch
			{
				return "";
			}
		}

		public static bool CreateShortcutChrome(string shortcutName, string shortcutPath, string profilePath, string icon = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string targetFileLocation = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
		{
			//Discarded unreachable code: IL_0097, IL_0152
			bool result = false;
			try
			{
				CreateShortcut(shortcutName, shortcutPath, targetFileLocation, "--user-data-dir=\"" + profilePath + "\"", targetFileLocation.Substring(0, targetFileLocation.LastIndexOf("\\")), icon);
				result = true;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "chrome.CreateShortcut(" + shortcutName + "," + shortcutPath + "," + targetFileLocation + ")select");
			}
			return result;
		}

		public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string arg, string WorkingDirectory = "C:\\Program Files (x86)\\Google\\Chrome\\Application", string icon = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
		{
			string pathLink = Path.Combine(shortcutPath, shortcutName + ".lnk");
			WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			IWshShortcut wshShortcut = (IWshShortcut)(dynamic)wshShell.CreateShortcut(pathLink);
			wshShortcut.Description = "Shortcut Chrome MIN Software";
			wshShortcut.WorkingDirectory = WorkingDirectory;
			wshShortcut.IconLocation = icon;
			wshShortcut.TargetPath = targetFileLocation;
			wshShortcut.Arguments = arg;
			wshShortcut.Save();
		}

		public static void ShowMessageBox(object s, int type)
		{
			switch (type)
			{
				case 1:
					MessageBox.Show(s.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case 2:
					MessageBox.Show(s.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					break;
				case 3:
					MessageBox.Show(s.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
			}
		}

		public static void SetStatusDataGridView(DataGridView dgv, int row, string colName, object status)
		{
			//Discarded unreachable code: IL_005c, IL_0069
			try
			{
				Application.DoEvents();
				dgv.Invoke((MethodInvoker)delegate
				{
					dgv.Rows[row].Cells[colName].Value = status;
				});
			}
			catch
			{
			}
		}

		public static int CompareImage(string pathFile1, string pathFile2)
		{
			//Discarded unreachable code: IL_0081, IL_008e
			int result = 0;
			try
			{
				List<bool> hash = GetHash(new Bitmap(pathFile1));
				List<bool> hash2 = GetHash(new Bitmap(pathFile1));
				result = hash.Zip(hash2, (bool i, bool j) => i == j).Count((bool eq) => eq);
			}
			catch
			{
			}
			return result;
		}

		public static bool SetTextToClipboard(string content)
		{
			//Discarded unreachable code: IL_0051, IL_005e
			bool isSuccess = false;
			try
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						Clipboard.SetText(content);
						isSuccess = true;
					}
					catch
					{
					}
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}
			catch
			{
			}
			return isSuccess;
		}

		public static List<bool> GetHash(Bitmap bmpSource)
		{
			List<bool> list = new List<bool>();
			Bitmap bitmap = new Bitmap(bmpSource, new Size(16, 16));
			for (int i = 0; i < bitmap.Height; i++)
			{
				for (int j = 0; j < bitmap.Width; j++)
				{
					list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
				}
			}
			return list;
		}

		public static List<string> CloneList(List<string> lstFrom)
		{
			//Discarded unreachable code: IL_004b, IL_0058
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < lstFrom.Count; i++)
				{
					list.Add(lstFrom[i]);
				}
			}
			catch
			{
			}
			return list;
		}

		public static string SpinText(string text, Random rand)
		{
			int num = -1;
			char[] anyOf = new char[2] { '{', '}' };
			text += "~";
			do
			{
				int num2 = num;
				num = -1;
				while ((num2 = text.IndexOf('{', num2 + 1)) != -1)
				{
					int num3 = num2;
					while ((num3 = text.IndexOfAny(anyOf, num3 + 1)) != -1 && text[num3] != '}')
					{
						if (num == -1)
						{
							num = num2;
						}
						num2 = num3;
					}
					if (num3 != -1)
					{
						string[] array = text.Substring(num2 + 1, num3 - 1 - (num2 + 1 - 1)).Split('|');
						text = text.Remove(num2, num3 - (num2 - 1)).Insert(num2, array[rand.Next(array.Length)]);
					}
				}
			}
			while (num-- != -1);
			return text.Remove(text.Length - 1);
		}

		public static void OpenFileAndPressData(string linkPathFile, string title = "Nhập danh sách Uid cần clone", string status = "Danh sách Uid", string footer = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
		{
			//Discarded unreachable code: IL_0051, IL_005e
			try
			{
				if (!File.Exists(linkPathFile))
				{
					CreateFile(linkPathFile);
				}
				ShowForm(new fNhapDuLieu1(linkPathFile, title, status, footer));
			}
			catch
			{
			}
		}

		public static DateTime ConvertTimeStampToDateTime(double timestamp)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime();
		}

		public static Form GetFormByName(string name, string para)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Type[] types = executingAssembly.GetTypes();
			foreach (Type type in types)
			{
				if (type.BaseType != null && type.BaseType.FullName == "System.Windows.Forms.Form" && type.FullName == name)
				{
					return Activator.CreateInstance(Type.GetType(name), "", 1, para) as Form;
				}
			}
			return null;
		}

		public static void CreateFile(string pathFile)
		{
			//Discarded unreachable code: IL_0042, IL_004f
			try
			{
				if (!File.Exists(pathFile))
				{
					File.AppendAllText(pathFile, "");
				}
			}
			catch
			{
			}
		}

		public static void ClearSelectedOnDatagridview(DataGridView dtgv)
		{
			for (int i = 0; i < dtgv.RowCount; i++)
			{
				dtgv.Rows[i].Selected = false;
			}
		}

		public static void CreateFolder(string pathFolder)
		{
			//Discarded unreachable code: IL_002d, IL_003a
			try
			{
				if (!Directory.Exists(pathFolder))
				{
					Directory.CreateDirectory(pathFolder);
				}
			}
			catch
			{
			}
		}

		public static void ShowForm(Form f)
		{
			//Discarded unreachable code: IL_0025, IL_0032
			try
			{
				f.ShowInTaskbar = false;
				f.ShowDialog();
			}
			catch (Exception)
			{
			}
		}

		public static List<int> ShuffleList(List<int> lst)
		{
			int num = 0;
			int num2 = lst.Count;
			int num3 = 0;
			while (num2 != 0)
			{
				num3 = Base.rd.Next(0, lst.Count);
				num2--;
				num = lst[num2];
				lst[num2] = lst[num3];
				lst[num3] = num;
			}
			return lst;
		}

		public static List<string> ShuffleList(List<string> lst)
		{
			string text = "";
			int num = lst.Count;
			int num2 = 0;
			while (num != 0)
			{
				num2 = Base.rd.Next(0, lst.Count);
				num--;
				text = lst[num];
				lst[num] = lst[num2];
				lst[num2] = text;
			}
			return lst;
		}

		public static List<string> RemoveEmptyItems(List<string> lst)
		{
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < lst.Count; i++)
			{
				text = lst[i].Trim();
				if (text != "")
				{
					list.Add(text);
				}
			}
			return list;
		}

		public static string TrimEnd(string text, string value)
		{
			if (!text.EndsWith(value))
			{
				return text;
			}
			return text.Remove(text.LastIndexOf(value));
		}

		public static void SaveDatagridview(DataGridView dgv, string FilePath, char splitChar = '|')
		{
			List<string> list = new List<string>();
			string text = "";
			object obj = null;
			for (int i = 0; i < dgv.RowCount; i++)
			{
				text = "";
				for (int j = 0; j < dgv.ColumnCount; j++)
				{
					obj = dgv.Rows[i].Cells[j].Value;
					text += ((obj == null) ? splitChar.ToString() : (obj?.ToString() + splitChar));
				}
				text = text.TrimEnd(splitChar);
				list.Add(text);
			}
			File.WriteAllLines(FilePath, list);
		}

		public static void LoadDatagridview(DataGridView dgv, string namePath, char splitChar = '|')
		{
			if (!File.Exists(namePath))
			{
				CreateFile(namePath);
			}
			List<string> list = File.ReadAllLines(namePath).ToList();
			string text = "";
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i];
					DataGridViewRowCollection rows = dgv.Rows;
					object[] values = text.Split(splitChar);
					rows.Add(values);
				}
			}
		}

		public static string SelectFolder()
		{
			//Discarded unreachable code: IL_0061, IL_0074, IL_007b, IL_0088
			string result = "";
			try
			{
				using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
				{
					DialogResult dialogResult = folderBrowserDialog.ShowDialog();
					if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
					{
						result = folderBrowserDialog.SelectedPath;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		public static string SelectFile(string title = "Chọn File txt", string typeFile = "txt Files (*.txt)|*.txt|")
		{
			//Discarded unreachable code: IL_0090, IL_00a3, IL_00aa, IL_00b7
			string result = "";
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = typeFile + "All files (*.*)|*.*";
					openFileDialog.InitialDirectory = "C:\\";
					openFileDialog.Title = title;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						result = openFileDialog.FileName;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		public static void KillProcess(string nameProcess)
		{
			//Discarded unreachable code: IL_003e, IL_004b
			try
			{
				Process[] processesByName = Process.GetProcessesByName(nameProcess);
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}

		public static bool CheckBasicString(string text)
		{
			bool result = true;
			foreach (char c in text)
			{
				if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.')
				{
					result = false;
					break;
				}
			}
			return result;
		}

		public static string RemoveCharNotLatin(string text)
		{
			string text2 = "";
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
				{
					text2 += c;
				}
			}
			return text2;
		}

		public static string ConvertToUTF8(string text)
		{
			byte[] bytes = Encoding.Default.GetBytes(text);
			text = Encoding.UTF8.GetString(bytes);
			return text;
		}

		public static bool IsNumber(string pValue)
		{
			if (pValue == "")
			{
				return false;
			}
			foreach (char c in pValue)
			{
				if (!char.IsDigit(c))
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsContainNumber(string pValue)
		{
			foreach (char c in pValue)
			{
				if (char.IsDigit(c))
				{
					return true;
				}
			}
			return false;
		}

		public static void ReadHtmlText(string html)
		{
			string text = "zzz999.html";
			File.WriteAllText(text, html);
			Process.Start(text);
		}

		public static string ReadHTMLCode(string Url)
		{
			//Discarded unreachable code: IL_005c, IL_006a
			try
			{
				return new RequestHttp().RequestGet(Url);
			}
			catch
			{
				return null;
			}
		}

		public static bool IsValidMail(string emailaddress)
		{
			//Discarded unreachable code: IL_0019, IL_002b
			try
			{
				MailAddress mailAddress = new MailAddress(emailaddress);
				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		public static string Md5Encode(string text, string type = "X2")
		{
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(text));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString(type));
			}
			return stringBuilder.ToString();
		}

		public static string Base64Encode(string base64Decoded)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(base64Decoded);
			return Convert.ToBase64String(bytes);
		}

		public static string Base64Decode(string base64Encoded)
		{
			byte[] bytes = Convert.FromBase64String(base64Encoded);
			return Encoding.UTF8.GetString(bytes);
		}

		public static string CreateRandomStringNumber(int lengText, Random rd = null)
		{
			string text = "";
			if (rd == null)
			{
				rd = new Random();
			}
			string text2 = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			for (int i = 0; i < lengText; i++)
			{
				text += text2[rd.Next(0, text2.Length)];
			}
			return text;
		}

		public static string CreateRandomString(int lengText, Random rd = null)
		{
			string text = "";
			if (rd == null)
			{
				rd = new Random();
			}
			string text2 = "abcdefghijklmnopqrstuvwxyz";
			for (int i = 0; i < lengText; i++)
			{
				text += text2[rd.Next(0, text2.Length)];
			}
			return text;
		}

		public static string CreateRandomNumber(int leng, Random rd = null)
		{
			string text = "";
			if (rd == null)
			{
				rd = new Random();
			}
			string text2 = "0123456789";
			for (int i = 0; i < leng; i++)
			{
				text += text2[rd.Next(0, text2.Length)];
			}
			return text;
		}

		public static string RunCMD(string cmd)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + cmd;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}

		public static void DelayTime(double second)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(second * 1000.0));
		}

		public static string HtmlDecode(string text)
		{
			return WebUtility.HtmlDecode(text);
		}

		public static string HtmlEncode(string text)
		{
			return WebUtility.HtmlEncode(text);
		}

		public static string UrlDecode(string text)
		{
			return WebUtility.UrlDecode(text);
		}

		public static string UrlEncode(string text)
		{
			return WebUtility.UrlEncode(text);
		}

		public static Point GetSizeChrome(int column, int row)
		{
			JSON_Settings jSON_Settings = new JSON_Settings("configChrome");
			if (jSON_Settings.GetValueInt("width") == 0)
			{
				jSON_Settings.Update("width", getWidthScreen);
				jSON_Settings.Update("heigh", getHeightScreen);
				jSON_Settings.Save();
			}
			getWidthScreen = jSON_Settings.GetValueInt("width");
			getHeightScreen = jSON_Settings.GetValueInt("heigh");
			int x = getWidthScreen / column + 15;
			int y = getHeightScreen / row + 10;
			return new Point(x, y);
		}

		public static Point GetPointFromIndexPosition(int indexPos, int column, int row)
		{
			JSON_Settings jSON_Settings = new JSON_Settings("configChrome");
			if (jSON_Settings.GetValueInt("width") == 0)
			{
				jSON_Settings.Update("width", getWidthScreen);
				jSON_Settings.Update("heigh", getHeightScreen);
				jSON_Settings.Save();
			}
			getWidthScreen = jSON_Settings.GetValueInt("width");
			getHeightScreen = jSON_Settings.GetValueInt("heigh");
			Point result = default(Point);
			while (indexPos >= column * row)
			{
				indexPos -= column * row;
			}
			switch (row)
			{
				case 1:
					result.Y = 0;
					break;
				case 2:
					if (indexPos < column)
					{
						result.Y = 0;
					}
					else if (indexPos < column * 2)
					{
						int num = indexPos / column;
						result.Y = getHeightScreen / 2;
						indexPos -= column;
					}
					break;
				case 3:
					if (indexPos < column)
					{
						result.Y = 0;
					}
					else if (indexPos < column * 2)
					{
						result.Y = getHeightScreen / 3;
						indexPos -= column;
					}
					else if (indexPos < column * 3)
					{
						result.Y = getHeightScreen / 3 * 2;
						indexPos -= column * 2;
					}
					break;
				case 4:
					if (indexPos < column)
					{
						result.Y = 0;
					}
					else if (indexPos < column * 2)
					{
						result.Y = getHeightScreen / 4;
						indexPos -= column;
					}
					else if (indexPos < column * 3)
					{
						result.Y = getHeightScreen / 4 * 2;
						indexPos -= column * 2;
					}
					else if (indexPos < column * 4)
					{
						result.Y = getHeightScreen / 4 * 3;
						indexPos -= column * 3;
					}
					break;
				case 5:
					if (indexPos < column)
					{
						result.Y = 0;
					}
					else if (indexPos < column * 2)
					{
						result.Y = getHeightScreen / 5;
						indexPos -= column;
					}
					else if (indexPos < column * 3)
					{
						result.Y = getHeightScreen / 5 * 2;
						indexPos -= column * 2;
					}
					else if (indexPos < column * 4)
					{
						result.Y = getHeightScreen / 5 * 3;
						indexPos -= column * 3;
					}
					else
					{
						result.Y = getHeightScreen / 5 * 4;
						indexPos -= column * 4;
					}
					break;
			}
			int num2 = getWidthScreen / column;
			result.X = indexPos * num2 - 10;
			return result;
		}

		public static int GetIndexOfPossitionApp(ref List<int> lstPossition)
		{
			int result = 0;
			lock (lstPossition)
			{
				for (int i = 0; i < lstPossition.Count; i++)
				{
					if (lstPossition[i] == 0)
					{
						result = i;
						lstPossition[i] = 1;
						break;
					}
				}
			}
			return result;
		}

		public static void FillIndexPossition(ref List<int> lstPossition, int indexPos)
		{
			lock (lstPossition)
			{
				lstPossition[indexPos] = 0;
			}
		}

		public static string CheckProxy(string proxy, int typeProxy)
		{
			//Discarded unreachable code: IL_006b, IL_008a
			string text = "";
			try
			{
				RequestXNet requestXNet = new RequestXNet("", SetupFolder.GetUseragentIPhone(rd), proxy, typeProxy);
				return requestXNet.RequestGet("https://api64.ipify.org/");
			}
			catch (Exception)
			{
				return CheckProxy2(proxy, typeProxy);
			}
		}

		public static string CheckProxy3(string proxy, int typeProxy)
		{
			//Discarded unreachable code: IL_006b, IL_008a
			string text = "";
			try
			{
				RequestXNet requestXNet = new RequestXNet("", SetupFolder.GetUseragentIPhone(rd), proxy, typeProxy);
				return requestXNet.RequestGet("https://api64.ipify.org/");
			}
			catch (Exception)
			{
				return CheckProxy2(proxy, typeProxy);
			}
		}

		public static string CheckProxy2(string proxy, int typeProxy)
		{
			//Discarded unreachable code: IL_009b, IL_00c5
			string result = "";
			try
			{
				RequestXNet requestXNet = new RequestXNet("", SetupFolder.GetUseragentIPhone(rd), proxy, typeProxy);
				string input = requestXNet.RequestGet("https://showip.net/");
				result = Regex.Match(input, "value=\"(.*?)\"").Groups[1].Value;
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "Check Proxy2");
			}
			return result;
		}

		public static string CheckProxyOnlyV4(string proxy, int typeProxy)
		{
			//Discarded unreachable code: IL_009c, IL_00c6
			string result = "";
			try
			{
				RequestXNet requestXNet = new RequestXNet("", "", proxy, typeProxy);
				string json = requestXNet.RequestGet("http://lumtest.com/myip.json");
				result = JObject.Parse(json)["ip"].ToString();
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "Check Proxy");
			}
			return result;
		}

		public static string CheckIP()
		{
			//Discarded unreachable code: IL_00c0, IL_00cd
			string result = "";
			try
			{
				RequestXNet requestXNet = new RequestXNet("", "", "", 0);
				string text = "";
				text = requestXNet.RequestGet("http://lumtest.com/myip.json");
				result = JObject.Parse(text)["ip"].ToString();
			}
			catch
			{
			}
			return result;
		}

		public static void ExportError(Chrome chrome, Exception ex, string error = "")
		{
			try
			{
				if (!Directory.Exists("log"))
				{
					Directory.CreateDirectory("log");
				}
				if (!Directory.Exists("log\\html"))
				{
					Directory.CreateDirectory("log\\html");
				}
				if (!Directory.Exists("log\\images"))
				{
					Directory.CreateDirectory("log\\images");
				}
				Random random = new Random();
				string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
				if (chrome != null)
				{
					string contents = chrome.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
					chrome.ScreenCapture("log\\images\\", text);
					File.WriteAllText("log\\html\\" + text + ".html", contents);
				}
				using (StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true))
				{
					streamWriter.WriteLine("-----------------------------------------------------------------------------");
					streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					streamWriter.WriteLine("File: " + text);
					if (error != "")
					{
						streamWriter.WriteLine("Error: " + error);
					}
					streamWriter.WriteLine();
					if (ex != null)
					{
						streamWriter.WriteLine("Type: " + ex.GetType().FullName);
						streamWriter.WriteLine("Message: " + ex.Message);
						streamWriter.WriteLine("StackTrace: " + ex.StackTrace);
						ex = ex.InnerException;
					}
				}
			}
			catch
			{
			}
		}

		public static void ExportError(Exception ex, string error = "")
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true))
				{
					streamWriter.WriteLine("-----------------------------------------------------------------------------");
					streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					if (error != "")
					{
						streamWriter.WriteLine("Error: " + error);
					}
					streamWriter.WriteLine();
					if (ex != null)
					{
						streamWriter.WriteLine("Type: " + ex.GetType().FullName);
						streamWriter.WriteLine("Message: " + ex.Message);
						streamWriter.WriteLine("StackTrace: " + ex.StackTrace);
						ex = ex.InnerException;
					}
				}
			}
			catch
			{
			}
		}

		public static string RunCMD(string fileName, string cmd, int timeout = 10)
		{
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.StartInfo.Arguments = cmd;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			ProcessStartInfo startInfo = process.StartInfo;
			startInfo.StandardOutputEncoding = (Encoding)(object)startInfo;
			ProcessStartInfo startInfo2 = process.StartInfo;
			startInfo.StandardErrorEncoding = (Encoding)(object)startInfo2;
			StringBuilder output = new StringBuilder();
			process.OutputDataReceived += delegate (object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					output.Append(e.Data + "\n");
				}
			};
			process.Start();
			process.BeginOutputReadLine();
			if (timeout < 0)
			{
				process.WaitForExit();
			}
			else
			{
				process.WaitForExit(timeout * 1000);
			}
			process.Close();
			return output.ToString();
		}

		public static bool ResetDcom(string profileDcom)
		{
			bool flag = false;
			string text = RunCMD("rasdial.exe", "\"" + profileDcom + "\"", 3);
			if (text.Contains("Successfully connected to "))
			{
				flag = true;
			}
			else if (text.Contains("You are already connected to "))
			{
				for (int i = 0; i < 3; i++)
				{
					text = RunCMD("rasdial.exe", "\"" + profileDcom + "\" /disconnect", 3);
					if (text.Trim() == "Command completed successfully.")
					{
						flag = true;
						break;
					}
					DelayTime(1.0);
				}
				DelayTime(1.0);
				if (flag)
				{
					for (int j = 0; j < 3; j++)
					{
						text = RunCMD("rasdial.exe", "\"" + profileDcom + "\"", 3);
						if (text.Contains("Successfully connected to "))
						{
							flag = true;
							break;
						}
						DelayTime(1.0);
					}
				}
				DelayTime(1.0);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		public static bool ChangeIP(int typeChangeIP, int typeDcom, string profileDcom, string urlHilink, int iTypeHotspot, string sLinkNord)
		{
			//Discarded unreachable code: IL_027d, IL_02a9
			bool result = false;
			string text = "";
			try
			{
				switch (typeChangeIP)
				{
					case 0:
						return true;
					case 1:
						{
							string text2 = CheckIP();
							IntPtr intPtr = AutoControl.FindWindowHandle(null, "HMA VPN");
							AutoControl.BringToFront(intPtr);
							AutoControl.SendClickOnPosition(AutoControl.FindHandle(intPtr, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
							Thread.Sleep(5000);
							string text3 = CheckIP();
							AutoControl.SendClickOnPosition(AutoControl.FindHandle(intPtr, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
							int tickCount = Environment.TickCount;
							do
							{
								text = CheckIP();
							}
							while (Environment.TickCount - tickCount <= 20000 && (text == text2 || text == text3));
							if (text != text2)
							{
								result = true;
							}
							break;
						}
					case 2:
						{
							if (typeDcom == 0)
							{
								result = ResetDcom(profileDcom);
								break;
							}
							int num = ResetHilink(urlHilink);
							if (num == 0)
							{
								Thread.Sleep(2000);
								num = ResetHilink(urlHilink);
							}
							result = num == 1;
							break;
						}
				}
			}
			catch (Exception ex)
			{
				ExportError(null, ex, "Error ChangeIP");
			}
			return result;
		}

		public static bool CheckStringIsContainIcon(string content)
		{
			return content.Length != Regex.Replace(content, "\\p{Cs}", "").Length;
		}

		public static int ResetHilink(string urlHilink)
		{
			//Discarded unreachable code: IL_0107, IL_0165, IL_0525, IL_0532
			int result = -1;
			try
			{
				string text = "http" + Regex.Match(urlHilink, "http(.*?)/html").Groups[1].Value;
				RequestHttp requestHttp = new RequestHttp("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36");
				string input = requestHttp.RequestGet(urlHilink);
				string text2 = "";
				try
				{
					text2 = Regex.Matches(input, "csrf_token\" content=\"(.*?)\"")[1].Groups[1].Value;
				}
				catch
				{
					text2 = Regex.Match(requestHttp.RequestGet(text + "/api/webserver/token"), "<token>(.*?)</token>").Groups[1].Value;
				}
				input = requestHttp.RequestGet(text + "/api/dialup/mobile-dataswitch");
				requestHttp.request.SetDefaultHeaders(new string[8]
				{
				"__RequestVerificationToken: " + text2,
				"Accept: */*",
				"Accept-Encoding: gzip, deflate",
				"Accept-Language: vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5",
				"Content-Type: application/x-www-form-urlencoded; charset=UTF-8",
				"X-Requested-With: XMLHttpRequest",
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36"
				});
				string text3 = "";
				if (input.Contains("dataswitch>1"))
				{
					text3 = input.Replace("response", "request").Replace("dataswitch>1", "dataswitch>0");
				}
				else
				{
					if (!input.Contains("dataswitch>0"))
					{
						return -1;
					}
					text3 = input.Replace("response", "request").Replace("dataswitch>0", "dataswitch>1");
				}
				string text4 = requestHttp.RequestPost(text + "/api/dialup/mobile-dataswitch", text3);
				if (text4.Contains("OK"))
				{
					input = requestHttp.RequestGet(text + "/api/dialup/mobile-dataswitch");
					if (input.Contains("dataswitch>1<"))
					{
						for (int i = 0; i < 10; i++)
						{
							string text5 = requestHttp.RequestGet(text + "/api/monitoring/traffic-statistics");
							if (!text5.Contains("<CurrentUpload>0"))
							{
								break;
							}
							Thread.Sleep(1000);
						}
					}
					return Convert.ToInt32(Regex.Match(input, "dataswitch>(.*?)<").Groups[1].Value);
				}
				result = -1;
			}
			catch
			{
			}
			return result;
		}

		public static DateTime ConvertStringToDatetime(string datetime, string format = "dd/MM/yyyy HH:mm:ss")
		{
			return DateTime.ParseExact(datetime, format, CultureInfo.InvariantCulture);
		}

		public static string GetTotp(string input)
		{
			string text = GetTotpServer(input);
			if (text == "")
			{
				text = GetTotpClient(input);
			}
			return text;
		}

		public static string GetTotpServer(string input)
		{
			//Discarded unreachable code: IL_0136, IL_014d, IL_018a, IL_01a1, IL_025c, IL_0269
			string text = "";
			try
			{
				string text2 = "";
				input = input.Replace(" ", "").Trim();
				string text3 = "http://app.minsoftware.vn/api/2fa1?secret=" + input;
				string text4 = "http://2fa.live/tok/" + input;
				for (int i = 0; i < 5; i++)
				{
					text = "";
					try
					{
						text2 = ReadHTMLCode(text4);
						if (text2.Contains("token"))
						{
							JObject jObject = JObject.Parse(text2);
							text = jObject["token"].ToString().Trim();
						}
					}
					catch (Exception ex)
					{
						ExportError(ex, text4);
					}
					try
					{
						if (text.Trim() == "")
						{
							text = ReadHTMLCode(text3);
						}
					}
					catch (Exception ex2)
					{
						ExportError(ex2, text3);
					}
					if (text != "" && IsNumber(text))
					{
						for (int j = text.Length; j < 6; j++)
						{
							text = "0" + text;
						}
						break;
					}
					DelayTime(1.0);
				}
			}
			catch
			{
			}
			return text;
		}

		public static string GetTotpClient(string input)
		{
			//Discarded unreachable code: IL_006c, IL_00b7
			try
			{
				byte[] secretKey = Base32Encoding.ToBytes(input.Trim().Replace(" ", ""));
				Totp totp = new Totp(secretKey);
				return totp.ComputeTotp(DateTime.UtcNow);
			}
			catch (Exception ex)
			{
				ExportError(ex, "GetTotp(" + input + ")");
			}
			return "";
		}

		private static int RemainingSeconds()
		{
			return 30 - (int)((DateTime.UtcNow.Ticks - 621355968000000000L) / 10000000 % 30);
		}

		private static byte[] GetBigEndianBytes(long input)
		{
			byte[] bytes = BitConverter.GetBytes(input);
			Array.Reverse(bytes);
			return bytes;
		}

		private static long CalculateTime30FromTimestamp(DateTime timestamp)
		{
			long num = (timestamp.Ticks - 621355968000000000L) / 10000000;
			return num / 30;
		}

		private static string Digits(long input, int digitCount)
		{
			return ((int)input % (int)Math.Pow(10.0, digitCount)).ToString().PadLeft(digitCount, '0');
		}

		private static byte[] ToBytes(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				throw new ArgumentNullException("input");
			}
			input = input.TrimEnd('=');
			int num = input.Length * 5 / 8;
			byte[] array = new byte[num];
			byte b = 0;
			byte b2 = 8;
			int num2 = 0;
			int num3 = 0;
			string text = input;
			foreach (char c in text)
			{
				int num4 = CharToValue(c);
				if (b2 > 5)
				{
					num2 = num4 << b2 - 5;
					b = (byte)(b | num2);
					b2 = (byte)(b2 - 5);
				}
				else
				{
					num2 = num4 >> 5 - b2;
					b = (byte)(b | num2);
					array[num3++] = b;
					b = (byte)(num4 << 3 + b2);
					b2 = (byte)(b2 + 3);
				}
			}
			if (num3 != num)
			{
				array[num3] = b;
			}
			return array;
		}

		private static int CharToValue(char c)
		{
			if (c < '[' && c > '@')
			{
				return c - 65;
			}
			if (c < '8' && c > '1')
			{
				return c - 24;
			}
			if (c < '{' && c > '`')
			{
				return c - 97;
			}
			throw new ArgumentException("Character is not a Base32 character.", "c");
		}

		public static DataTable ShuffleDataTable(DataTable dt)
		{
			//Discarded unreachable code: IL_004b, IL_0058
			DataTable result = new DataTable();
			try
			{
				result = (from DataRow r in dt.Rows
						  orderby Base.rd.Next()
						  select r).CopyToDataTable();
			}
			catch
			{
			}
			return result;
		}

		public static bool CopyFolder(string pathFrom, string pathTo)
		{
			//Discarded unreachable code: IL_00e6, IL_00f4
			try
			{
				CreateFolder(pathTo);
				string[] directories = Directory.GetDirectories(pathFrom, "*", SearchOption.AllDirectories);
				foreach (string text in directories)
				{
					Directory.CreateDirectory(text.Replace(pathFrom, pathTo));
				}
				string[] files = Directory.GetFiles(pathFrom, "*.*", SearchOption.AllDirectories);
				foreach (string text2 in files)
				{
					File.Copy(text2, text2.Replace(pathFrom, pathTo), overwrite: true);
				}
				return true;
			}
			catch (Exception)
			{
			}
			return false;
		}

		public static bool MoveFolder(string pathFrom, string pathTo)
		{
			//Discarded unreachable code: IL_001f, IL_002c
			try
			{
				Directory.Move(pathFrom, pathTo);
				return true;
			}
			catch (Exception)
			{
			}
			return false;
		}

		public static bool DeleteFolder(string pathFolder)
		{
			//Discarded unreachable code: IL_001e, IL_002b
			try
			{
				Directory.Delete(pathFolder, recursive: true);
				return true;
			}
			catch
			{
			}
			return false;
		}

		public static bool IsVNName(string ten)
		{
			ten = ten.Trim();
			if (ten == "")
			{
				return false;
			}
			return ten != ConvertToUnSign(ten) && IsContainsVNChar(ten);
		}

		public static bool IsContainsVNChar(string text)
		{
			bool result = true;
			string text2 = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZaAeEoOuUiIdDyYáàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ";
			foreach (char value in text)
			{
				if (!text2.ToCharArray().Contains(value))
				{
					result = false;
					break;
				}
			}
			return result;
		}

		public static string ConvertToUnSign(string s)
		{
			Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
			string input = s.Normalize(NormalizationForm.FormD);
			return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
		}
	}

}