using System;
using System.IO;
using System.Windows.Forms;

namespace maxcare.Helper
{
	// Token: 0x02000198 RID: 408
	public class FileHelper
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x002C8D34 File Offset: 0x002C6F34
		public static string GetPathToCurrentFolder()
		{
			return Path.GetDirectoryName(Application.ExecutablePath);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00015754 File Offset: 0x00013954
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

		// Token: 0x060011AD RID: 4525 RVA: 0x002C8D54 File Offset: 0x002C6F54
		public static string SelectFile(string title = "Chọn File txt", string defaultFolder = "C:\\", string filter = "txt Files (*.txt)|*.txt|All files (*.*)|*.*")
		{
			string result = "";
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = filter;
					openFileDialog.InitialDirectory = defaultFolder;
					openFileDialog.Title = title;
					bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag)
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

		// Token: 0x060011AE RID: 4526 RVA: 0x002C8E18 File Offset: 0x002C7018
		public static bool DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
				bool flag = !directoryInfo.Exists;
				if (flag)
				{
					return false;
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				Directory.CreateDirectory(destDirName);
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					string destFileName = Path.Combine(destDirName, fileInfo.Name);
					fileInfo.CopyTo(destFileName, true);
				}
				if (copySubDirs)
				{
					foreach (DirectoryInfo directoryInfo2 in directories)
					{
						string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
						FileHelper.DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs);
					}
				}
				return true;
			}
			catch (Exception)
			{
			}
			return false;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x002C8F70 File Offset: 0x002C7170
		public static void CreateFile(string pathFile)
		{
			try
			{
				File.AppendAllText(pathFile, "");
			}
			catch
			{
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x002C8FC8 File Offset: 0x002C71C8
		public static void CreateFolderIfNotExist(string pathFolder)
		{
			try
			{
				Directory.CreateDirectory(pathFolder);
			}
			catch
			{
			}
		}
	}
}
