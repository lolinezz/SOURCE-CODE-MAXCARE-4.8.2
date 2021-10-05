using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using maxcare.Helper;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000F5 RID: 245
	public partial class frm_progress : Form
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x0000321E File Offset: 0x0000141E
		public frm_progress()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0014BA40 File Offset: 0x00149C40
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblproccess);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0014BA60 File Offset: 0x00149C60
		private void frm_progress_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = File.Exists(string.Concat(new string[]
				{
					"./",
					Base.softname,
					"/",
					Base.softname,
					".zip"
				}));
				if (flag)
				{
					File.Delete(string.Concat(new string[]
					{
						"./",
						Base.softname,
						"/",
						Base.softname,
						".zip"
					}));
				}
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string str = Base.hostname + Base.softname;
				bool flag2 = InternetConnection.IsConnectedToInternet();
				if (flag2)
				{
					Uri uri = new Uri(str + "/" + Base.softname + ".zip");
					this.StartDownload(uri, string.Concat(new string[]
					{
						"./",
						Base.softname,
						"/",
						Base.softname,
						".zip"
					}));
				}
				else
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Không có kết nối Internet, vui lòng kiểm tra lại!"), 1);
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox("Error: " + ex.Message, 2);
				base.Close();
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0014BD14 File Offset: 0x00149F14
		public void Copy(string sourceDirectory, string targetDirectory)
		{
			DirectoryInfo source = new DirectoryInfo(sourceDirectory);
			DirectoryInfo target = new DirectoryInfo(targetDirectory);
			this.CopyAll(source, target);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0014BD48 File Offset: 0x00149F48
		public void CopyAll(DirectoryInfo source, DirectoryInfo target)
		{
			Directory.CreateDirectory(target.FullName);
			int num = 1;
			foreach (FileInfo fileInfo in source.GetFiles())
			{
				Application.DoEvents();
				fileInfo.CopyTo(Path.Combine(target.FullName, fileInfo.Name), true);
				num++;
			}
			foreach (DirectoryInfo directoryInfo in source.GetDirectories())
			{
				DirectoryInfo target2 = target.CreateSubdirectory(directoryInfo.Name);
				this.CopyAll(directoryInfo, target2);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0014BE28 File Offset: 0x0014A028
		private void StartDownload(Uri uri, string pathFile)
		{
			Thread thread = new Thread(delegate()
			{
				WebClient webClient = new WebClient();
				webClient.DownloadProgressChanged += this.client_DownloadProgressChanged;
				webClient.DownloadFileCompleted += this.client_DownloadFileCompleted;
				webClient.DownloadFileAsync(uri, pathFile);
			});
			thread.Start();
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0014BE7C File Offset: 0x0014A07C
		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				double num = double.Parse(e.BytesReceived.ToString());
				double num2 = double.Parse(e.TotalBytesToReceive.ToString());
				double d = num / num2 * 100.0;
				this.lblproccess.Text = string.Format(Language.GetValue("Đang tải xuống, vui lòng chờ ({0}%)..."), int.Parse(Math.Truncate(d).ToString()));
				this.progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
			}));
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0014BEC0 File Offset: 0x0014A0C0
		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.lblproccess.Text = Language.GetValue("Đang giải nén file...");
			}));
			try
			{
				ZipFile.ExtractToDirectory(string.Concat(new string[]
				{
					"./",
					Base.softname,
					"/",
					Base.softname,
					".zip"
				}), "./" + Base.softname + "/");
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					base.Close();
				}));
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox("Error: " + ex.Message, 2);
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					base.Close();
				}));
			}
		}
	}
}
