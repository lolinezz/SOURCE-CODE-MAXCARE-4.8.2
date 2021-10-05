using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using maxcare;
using MCommon;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Common
{
	// Token: 0x0200005C RID: 92
	public class CommonCSharp
	{
		// Token: 0x06000386 RID: 902 RVA: 0x00015450 File Offset: 0x00013650
		public static List<string> RemoveEmptyItems(List<string> lst)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < lst.Count; i++)
			{
				string text = lst[i].Trim();
				bool flag = text != "";
				if (flag)
				{
					list.Add(text);
				}
			}
			return list;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00040244 File Offset: 0x0003E444
		public static void resetDcom(string profileDcom)
		{
			Process process = new Process();
			process.StartInfo.FileName = "rasdial.exe";
			process.StartInfo.Arguments = "\"" + profileDcom + "\" /disconnect";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(3000);
			process = new Process();
			process.StartInfo.FileName = "rasdial.exe";
			process.StartInfo.Arguments = "\"" + profileDcom + "\"";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(1500);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000154EC File Offset: 0x000136EC
		public static string TrimEnd(string text, string value)
		{
			bool flag = !text.EndsWith(value);
			string result;
			if (flag)
			{
				result = text;
			}
			else
			{
				result = text.Remove(text.LastIndexOf(value));
			}
			return result;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000403BC File Offset: 0x0003E5BC
		public static void SaveDatagridview(DataGridView dgv, string namePath)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dgv.RowCount; i++)
			{
				string text = "";
				for (int j = 0; j < dgv.ColumnCount; j++)
				{
					object value = dgv.Rows[i].Cells[j].Value;
					text += ((value == null) ? "" : (((value != null) ? value.ToString() : null) + "|"));
				}
				text = text.TrimEnd(new char[]
				{
					'|'
				});
				list.Add(text);
			}
			File.WriteAllLines(namePath, list);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00040504 File Offset: 0x0003E704
		public static void LoadDatagridview(DataGridView dgv, string namePath)
		{
			List<string> list = File.ReadAllLines(namePath).ToList<string>();
			bool flag = list.Count > 0;
			if (flag)
			{
				for (int i = 0; i < list.Count; i++)
				{
					string text = list[i];
					DataGridViewRowCollection rows = dgv.Rows;
					object[] values = text.Split(new char[]
					{
						'|'
					});
					rows.Add(values);
				}
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000405B0 File Offset: 0x0003E7B0
		public static string SelectFolder()
		{
			string result = "";
			try
			{
				using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
				{
					DialogResult dialogResult = folderBrowserDialog.ShowDialog();
					bool flag = dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath);
					if (flag)
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

		// Token: 0x0600038C RID: 908 RVA: 0x00040674 File Offset: 0x0003E874
		public static void UpdateStatusDataGridView(DataGridView dgv, int row, string colName, object status)
		{
			try
			{
				dgv.Invoke(new MethodInvoker(delegate()
				{
					dgv.Rows[row].Cells[colName].Value = status;
				}));
			}
			catch
			{
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000406FC File Offset: 0x0003E8FC
		public static string GetStatusDataGridView(DataGridView dgv, int row, string colName)
		{
			string output = "";
			dgv.Invoke(new MethodInvoker(delegate()
			{
				try
				{
					output = dgv.Rows[row].Cells[colName].Value.ToString();
				}
				catch
				{
				}
			}));
			return output;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00015904 File Offset: 0x00013B04
		public static void KillProcess(string nameProcess)
		{
			try
			{
				foreach (Process process in Process.GetProcessesByName(nameProcess))
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00040774 File Offset: 0x0003E974
		public static bool CheckBasicString(string text)
		{
			bool result = true;
			foreach (char c in text)
			{
				bool flag = (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.' && c != '[' && c != ']';
				if (flag)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00015A24 File Offset: 0x00013C24
		public static string RemoveCharNotLatin(string text)
		{
			string text2 = "";
			foreach (char c in text)
			{
				bool flag = (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
				if (flag)
				{
					text2 += c.ToString();
				}
			}
			return text2;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00015AE8 File Offset: 0x00013CE8
		public static string ConvertToUTF8(string text)
		{
			byte[] bytes = Encoding.Default.GetBytes(text);
			text = Encoding.UTF8.GetString(bytes);
			return text;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00015BC8 File Offset: 0x00013DC8
		public static bool IsContainNumber(string pValue)
		{
			foreach (char c in pValue)
			{
				bool flag = char.IsDigit(c);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00015C30 File Offset: 0x00013E30
		public static void ReadHtmlText(string text)
		{
			string text2 = "zzz999.html";
			File.WriteAllText(text2, text);
			Process.Start(text2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0004083C File Offset: 0x0003EA3C
		public static string ReadHTMLCode(string Url)
		{
			string result;
			try
			{
				bool flag = Url.StartsWith("http://app.minsoftware.vn/api/auth?datavery=");
				if (flag)
				{
					Base.check++;
				}
				result = new RequestHttp("", "", "", 0).RequestGet(Url);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				result = "";
			}
			return result;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public static bool IsValidMail(string emailaddress)
		{
			bool result;
			try
			{
				MailAddress mailAddress = new MailAddress(emailaddress);
				result = true;
			}
			catch (FormatException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00040920 File Offset: 0x0003EB20
		public static string Md5Encode(string sChuoi)
		{
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(sChuoi));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public static string Base64Encode(string text)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00004020 File Offset: 0x00002220
		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00015E78 File Offset: 0x00014078
		public static string CreateRandomString(int lengText, Random rd = null)
		{
			string text = "";
			bool flag = rd == null;
			if (flag)
			{
				rd = new Random();
			}
			string text2 = "abcdefghijklmnopqrstuvwxyz";
			for (int i = 0; i < lengText; i++)
			{
				text += text2[rd.Next(0, text2.Length)].ToString();
			}
			return text;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00015F2C File Offset: 0x0001412C
		public static string CreateRandomNumber(int leng, Random rd = null)
		{
			string text = "";
			bool flag = rd == null;
			if (flag)
			{
				rd = new Random();
			}
			string text2 = "0123456789";
			for (int i = 0; i < leng; i++)
			{
				text += text2[rd.Next(0, text2.Length)].ToString();
			}
			return text;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00018BBC File Offset: 0x00016DBC
		public static string convertToUnSign(string s)
		{
			Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
			string input = s.Normalize(NormalizationForm.FormD);
			return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00015FE0 File Offset: 0x000141E0
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
			bool flag = string.IsNullOrEmpty(text);
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000160C0 File Offset: 0x000142C0
		public static void DelayTime(double second)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(second * 1000.0));
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000409AC File Offset: 0x0003EBAC
		public static void ExportError(ChromeDriver chrome, string error)
		{
			try
			{
				Random random = new Random();
				string text = string.Concat(new string[]
				{
					DateTime.Now.Day.ToString(),
					"_",
					DateTime.Now.Month.ToString(),
					"_",
					DateTime.Now.Year.ToString(),
					"_",
					DateTime.Now.Hour.ToString(),
					"_",
					DateTime.Now.Minute.ToString(),
					"_",
					DateTime.Now.Second.ToString(),
					"_",
					random.Next(1000, 9999).ToString()
				});
				bool flag = chrome != null;
				if (flag)
				{
					string contents = chrome.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;", Array.Empty<object>()).ToString();
					Screenshot screenshot = ((ITakesScreenshot)chrome).GetScreenshot();
					screenshot.SaveAsFile("log\\images\\" + text + ".png");
					File.WriteAllText("log\\html\\" + text + ".html", contents);
				}
				File.AppendAllText("log\\log.txt", string.Concat(new string[]
				{
					DateTime.Now.ToString(),
					"|<",
					text,
					">|",
					error,
					Environment.NewLine
				}));
			}
			catch
			{
			}
		}
	}
}
