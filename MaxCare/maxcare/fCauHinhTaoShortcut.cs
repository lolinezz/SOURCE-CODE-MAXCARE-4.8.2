using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000E3 RID: 227
	public partial class fCauHinhTaoShortcut : Form
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x0011B3B0 File Offset: 0x001195B0
		public fCauHinhTaoShortcut()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings("configInteractGeneral", false);
			this.ChangeLanguage();
			fCauHinhTaoShortcut.isOK = false;
			string path = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
			string path2 = "C:\\Program Files (x64)\\Google\\Chrome\\Application\\chrome.exe";
			string path3 = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !File.Exists(path);
			if (flag)
			{
				bool flag2 = !File.Exists(path2);
				if (flag2)
				{
					bool flag3 = File.Exists(path3);
					if (flag3)
					{
						this.pathChromeOrigin = path3;
					}
				}
				else
				{
					this.pathChromeOrigin = path2;
				}
			}
			else
			{
				this.pathChromeOrigin = path;
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0011B4B8 File Offset: 0x001196B8
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.label2);
			Language.GetValue(this.metroButton2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0011B540 File Offset: 0x00119740
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.txtPathShortcut.Text.Trim() == "";
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập đường dẫn đến Thư mục lưu Shortcut!"), 3);
			}
			else
			{
				bool flag2 = this.txtPathChromeOrigin.Text.Trim() == "";
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue("Vui lòng nhập đường dẫn đến chrome.exe!"), 3);
				}
				else
				{
					bool flag3 = !this.txtPathChromeOrigin.Text.Trim().EndsWith("chrome.exe");
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue("Đường dẫn đến chrome.exe không hợp lệ!"), 3);
					}
					else
					{
						this.settings.Update("txtPathShortcut", this.txtPathShortcut.Text.Trim());
						this.settings.Update("txtPathChromeOrigin", this.txtPathChromeOrigin.Text.Trim());
						this.settings.Save("");
						fCauHinhTaoShortcut.isOK = true;
						base.Close();
					}
				}
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0004B984 File Offset: 0x00049B84
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00054604 File Offset: 0x00052804
		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0011B72C File Offset: 0x0011992C
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.txtPathShortcut.Text = this.settings.GetValue("txtPathShortcut", "");
			bool flag = this.txtPathShortcut.Text.Trim() == "" || !Directory.Exists(this.txtPathShortcut.Text.Trim());
			if (flag)
			{
				this.txtPathShortcut.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			}
			bool flag2 = File.Exists(this.settings.GetValue("txtPathChromeOrigin", ""));
			if (flag2)
			{
				this.txtPathChromeOrigin.Text = this.settings.GetValue("txtPathChromeOrigin", "");
			}
			else
			{
				this.txtPathChromeOrigin.Text = this.pathChromeOrigin;
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0011B8B8 File Offset: 0x00119AB8
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathShortcut.Text = MCommon.Common.SelectFolder();
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0011B8DC File Offset: 0x00119ADC
		private void metroButton2_Click(object sender, EventArgs e)
		{
			this.txtPathChromeOrigin.Text = MCommon.Common.SelectFile(Language.GetValue("Chọn File"), "");
		}

		// Token: 0x04000CB9 RID: 3257
		public static bool isOK;

		// Token: 0x04000CBA RID: 3258
		private string pathChromeOrigin = "";

		// Token: 0x04000CBB RID: 3259
		private JSON_Settings settings;
	}
}
