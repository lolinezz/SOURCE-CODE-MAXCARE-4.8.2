using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using maxcare.Helper;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000A9 RID: 169
	public partial class fShowProgressBar : Form
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x00002E27 File Offset: 0x00001027
		public fShowProgressBar(List<string> lstPathFolder)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.lstPathFolder = lstPathFolder;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00094CC0 File Offset: 0x00092EC0
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblproccess);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00094CE0 File Offset: 0x00092EE0
		private void frm_progress_Load(object sender, EventArgs e)
		{
			try
			{
				new Thread(delegate()
				{
					int count = 0;
					int total = this.lstPathFolder.Count;
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lòng chờ ({0}/{1})..."), count, total);
					}));
					for (int i = 0; i < this.lstPathFolder.Count; i++)
					{
						string sourceDirName = this.lstPathFolder[i].Split(new char[]
						{
							'|'
						})[0];
						string destDirName = this.lstPathFolder[i].Split(new char[]
						{
							'|'
						})[1];
						bool flag = FileHelper.DirectoryCopy(sourceDirName, destDirName, true);
						if (flag)
						{
							int count2 = count;
							count = count2 + 1;
						}
						double percentage = (double)count * 1.0 / (double)total * 100.0;
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lòng chờ ({0}/{1})..."), count, total);
							this.progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
						}));
					}
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						base.Close();
					}));
				}).Start();
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox("Error: " + ex.Message, 2);
				base.Close();
			}
		}

		// Token: 0x04000602 RID: 1538
		private List<string> lstPathFolder = new List<string>();
	}
}
